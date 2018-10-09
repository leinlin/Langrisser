using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using BlackJack.BJFramework.Runtime.Resource;
using ProtoBuf;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x02000060 RID: 96
	[CustomLuaClass]
	public class LuaManager
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x000141B4 File Offset: 0x000123B4
		private LuaManager()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000141C8 File Offset: 0x000123C8
		[DoNotToLua]
		public static LuaManager CreateLuaManager()
		{
			if (LuaManager.m_instance == null)
			{
				LuaManager.m_instance = new LuaManager();
			}
			return LuaManager.m_instance;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000141E4 File Offset: 0x000123E4
		[DoNotToLua]
		public bool Initlize(string luaRootPath, string luaInitModule = "LuaManagerInit")
		{
			this.m_luaRootPath = luaRootPath;
			this.m_luaInitModuleName = luaInitModule;
			return true;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000141F8 File Offset: 0x000123F8
		[DoNotToLua]
		public void Uninitlize()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000141FC File Offset: 0x000123FC
		[DoNotToLua]
		public void SetEventBindAllInPublishVersion(Action bindAction)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00014200 File Offset: 0x00012400
		[DoNotToLua]
		public IEnumerator StartLuaSvr(Action<bool> onComplete)
		{
			if (ResourceManager.Instance.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("StartLuaSvr fail ResourceManager not ready");
				onComplete(false);
				yield break;
			}
			string initModulePath = this.GetModulePath(this.m_luaInitModuleName);
			TextAsset initModuleAsset = null;
			IEnumerator iter = ResourceManager.Instance.LoadAsset<TextAsset>(initModulePath, delegate(string lpath, TextAsset lasset)
			{
				initModuleAsset = lasset;
			}, false, false);
			yield return iter;
			if (initModuleAsset == null)
			{
				global::Debug.LogError("StartLuaSvr fail load initModuleAsset fail");
				onComplete(false);
				yield break;
			}
			ResourceManager.Instance.MakeAssetBundleDontUnload(initModulePath);
			this.m_luaSvr = new LuaSvr();
			LuaSvr.mainState.loaderDelegate = new LuaState.LoaderDelegate(this.LuaLoader);
			this.m_luaSvr.init(null, delegate
			{
				if (!string.IsNullOrEmpty(this.m_luaInitModuleName))
				{
					this.m_luaSvr.start(this.m_luaInitModuleName);
				}
				this.m_luaProtoBufExtensionHandler = LuaProtoBufExtensionHandler.Create();
				DummyType.InitLuaModule(LuaSvr.mainState);
			}, LuaSvrFlag.LSF_EXTLIB);
			onComplete(true);
			yield break;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00014224 File Offset: 0x00012424
		[DoNotToLua]
		public LuaState GetLuaState()
		{
			return LuaSvr.mainState;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001422C File Offset: 0x0001242C
		public LuaTable GetHotFixLuaModuleByTypeFullName(Type type)
		{
			if (type == null)
			{
				return null;
			}
			if (!typeof(IExtensible).IsAssignableFrom(type))
			{
				LuaTable result;
				this.m_hotfixDict.TryGetValue(type.FullName, out result);
				return result;
			}
			IProtobufExtensionTypeInfo extTypeInfo = this.m_luaProtoBufExtensionHandler.GetExtTypeInfo(type.FullName);
			if (extTypeInfo != null && extTypeInfo.HasExtensionInHierarchy())
			{
				return DummyType.HotFixModule;
			}
			return null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00014298 File Offset: 0x00012498
		public void RegHotFix(string typeFullName, LuaTable module)
		{
			if (module == null)
			{
				global::Debug.LogWarning(string.Format("LuaManager RegHotFix failed, can't find module {0}", typeFullName));
				return;
			}
			global::Debug.Log(string.Format("LuaManager RegHotFix succeed for:  {0}", typeFullName));
			this.m_hotfixDict[typeFullName] = module;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000142D4 File Offset: 0x000124D4
		[DoNotToLua]
		public static bool TryInitHotfixForObj(object obj, string luaModuleName = null, Type objType = null)
		{
			if (LuaManager.m_instance == null || obj == null)
			{
				return false;
			}
			Type type = objType ?? obj.GetType();
			LuaTable luaTable = (!string.IsNullOrEmpty(luaModuleName)) ? LuaManager.Instance.RequireModule(luaModuleName) : LuaManager.Instance.GetHotFixLuaModuleByTypeFullName(type);
			if (luaTable == null)
			{
				return false;
			}
			MethodInfo method = type.GetMethod("InitHotFix", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic);
			if (method == null)
			{
				global::Debug.LogWarning(string.Format("LuaManager.TryInitHotfixForObj Can't find InitHotFix method in :{0}", luaModuleName));
				return false;
			}
			return (bool)method.Invoke(obj, new object[]
			{
				luaTable
			});
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00014374 File Offset: 0x00012574
		public LuaTable RequireModule(string moduleName)
		{
			return LuaSvr.mainState.doString(string.Format("return require(\"{0}\")", moduleName)) as LuaTable;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00014390 File Offset: 0x00012590
		private byte[] LuaLoader(string moduleName)
		{
			string modulePath = this.GetModulePath(moduleName);
			TextAsset asset = null;
			IEnumerator enumerator = ResourceManager.Instance.LoadAsset<TextAsset>(modulePath, delegate(string lpath, TextAsset lasset)
			{
				asset = lasset;
			}, false, false);
			enumerator.MoveNext();
			if (asset == null)
			{
				global::Debug.LogError(string.Format("load lua module fail {0}", moduleName));
				return null;
			}
			return asset.bytes;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00014404 File Offset: 0x00012604
		public bool IsLuaModuleExist(string moduleName)
		{
			string modulePath = this.GetModulePath(moduleName);
			TextAsset asset = null;
			IEnumerator enumerator = ResourceManager.Instance.LoadAsset<TextAsset>(modulePath, delegate(string lpath, TextAsset lasset)
			{
				asset = lasset;
			}, true, false);
			enumerator.MoveNext();
			return !(asset == null);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001445C File Offset: 0x0001265C
		private string GetModulePath(string moduleName)
		{
			return string.Format("{0}/{1}.txt", this.m_luaRootPath, moduleName.Replace('.', '/'));
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00014478 File Offset: 0x00012678
		public static LuaManager Instance
		{
			get
			{
				return LuaManager.m_instance;
			}
		}

		// Token: 0x04000202 RID: 514
		private static LuaManager m_instance;

		// Token: 0x04000203 RID: 515
		private string m_luaRootPath;

		// Token: 0x04000204 RID: 516
		private string m_luaInitModuleName;

		// Token: 0x04000205 RID: 517
		private LuaSvr m_luaSvr;

		// Token: 0x04000206 RID: 518
		private Dictionary<string, LuaTable> m_hotfixDict = new Dictionary<string, LuaTable>();

		// Token: 0x04000207 RID: 519
		private LuaProtoBufExtensionHandler m_luaProtoBufExtensionHandler;

		// Token: 0x04000208 RID: 520
		public const string LuaObjHelperMemberName = "m_luaObjHelper";
	}
}
