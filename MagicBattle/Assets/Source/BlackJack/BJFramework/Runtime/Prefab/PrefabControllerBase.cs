using System;
using System.Diagnostics;
using System.Reflection;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Prefab
{
	// Token: 0x02000074 RID: 116
	[CustomLuaClass]
	public class PrefabControllerBase : MonoBehaviour
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00017AD8 File Offset: 0x00015CD8
		private void Awake()
		{
			if (PrefabControllerBase.m_onAwake != null)
			{
				PrefabControllerBase.m_onAwake(base.gameObject);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00017AF4 File Offset: 0x00015CF4
		public virtual void Initlize(string ctrlName, bool bindNow)
		{
			if (this.m_inited)
			{
				return;
			}
			this.m_inited = true;
			this.m_ctrlName = ctrlName;
			if (bindNow)
			{
				this.BindFields();
			}
			this.BindResContainer();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00017B24 File Offset: 0x00015D24
		public T GetAssetInContainer<T>(string resName) where T : UnityEngine.Object
		{
			if (this.m_resContainer == null)
			{
				return (T)((object)null);
			}
			return this.m_resContainer.GetAsset(resName) as T;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00017B54 File Offset: 0x00015D54
		public UnityEngine.Object GetAssetInContainer(string resName)
		{
			return this.GetAssetInContainer<UnityEngine.Object>(resName);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00017B60 File Offset: 0x00015D60
		public void BindResContainer()
		{
			this.m_resContainer = base.GetComponent<PrefabResourceContainer>();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00017B70 File Offset: 0x00015D70
		public virtual void BindFields()
		{
			FieldInfo[] fields = base.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.GetValue(this) == null)
				{
					object[] customAttributes = fieldInfo.GetCustomAttributes(typeof(AutoBindAttribute), false);
					if (customAttributes.Length != 0)
					{
						AutoBindAttribute autoBindAttribute = null;
						foreach (object obj in customAttributes)
						{
							if (obj.GetType() == typeof(AutoBindAttribute))
							{
								autoBindAttribute = (obj as AutoBindAttribute);
								break;
							}
						}
						if (autoBindAttribute != null)
						{
							string path = autoBindAttribute.m_path;
							bool optional = autoBindAttribute.m_optional;
							Type fieldType = fieldInfo.FieldType;
							UnityEngine.Object @object = this.BindFieldImpl(fieldType, path, autoBindAttribute.m_initState, fieldInfo.Name, fieldType.Name, optional);
							if (@object != null)
							{
								fieldInfo.SetValue(this, @object);
							}
						}
					}
				}
			}
			this.OnBindFiledsCompleted();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00017C88 File Offset: 0x00015E88
		public PrefabControllerNextUpdateExecutor GetNextUpdateExecutor()
		{
			return this.m_nextUpdateExecutor;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00017C90 File Offset: 0x00015E90
		protected virtual void OnBindFiledsCompleted()
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00017C94 File Offset: 0x00015E94
		protected virtual UnityEngine.Object BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName = null, bool optional = false)
		{
			UnityEngine.Object result = null;
			GameObject childByPath = this.GetChildByPath(path);
			if (childByPath == null)
			{
				global::Debug.LogError(string.Format("BindFields fail can not found child {0} in {1} {2}", path, base.gameObject, base.GetType().Name));
				return null;
			}
			if (fieldType == typeof(GameObject))
			{
				result = childByPath;
			}
			else if (fieldType.IsSubclassOf(typeof(PrefabControllerBase)))
			{
				PrefabControllerBase prefabControllerBase = childByPath.GetComponent(fieldType) as PrefabControllerBase;
				if (prefabControllerBase == null)
				{
					if (!optional)
					{
						global::Debug.LogError(string.Format("BindFields fail can not found comp in child {0} {1}", path, fieldType.Name));
					}
					return null;
				}
				result = prefabControllerBase;
			}
			else if (fieldType.IsSubclassOf(typeof(Component)))
			{
				Component component = childByPath.GetComponent(fieldType);
				if (component == null)
				{
					if (!optional)
					{
						global::Debug.LogError(string.Format("BindFields fail can not found comp in child {0} {1}", path, fieldType.Name));
					}
					return null;
				}
				result = component;
			}
			return result;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00017D90 File Offset: 0x00015F90
		public GameObject GetChildByPath(string path)
		{
			int num = path.IndexOf('/');
			if (num == -1)
			{
				return base.gameObject;
			}
			string name = path.Substring(num + 1);
			Transform transform = base.transform.Find(name);
			if (transform == null)
			{
				return null;
			}
			return transform.gameObject;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00017DE0 File Offset: 0x00015FE0
		public static PrefabControllerBase AddControllerToGameObject(GameObject root, string path, TypeDNName ctrlTypeDNName, string ctrlName, string luaModuleName = null, bool autoBind = false)
		{
			Type type = ClassLoader.Instance.LoadType(ctrlTypeDNName);
			if (type == null)
			{
				global::Debug.LogError(string.Format("AddControllerToGameObject fail for {0}", ctrlTypeDNName.m_typeFullName));
				return null;
			}
			int num = path.IndexOf('/');
			if (num == -1)
			{
				if (!root.name.Contains(path))
				{
					global::Debug.LogError(string.Format("AddControllerToGameObject fail path error {0}", path));
					return null;
				}
				PrefabControllerBase prefabControllerBase = root.GetComponent(type) as PrefabControllerBase;
				if (prefabControllerBase != null)
				{
					return prefabControllerBase;
				}
				root.GetComponent(type);
				prefabControllerBase = (root.AddComponent(type) as PrefabControllerBase);
				if (prefabControllerBase != null)
				{
					if (type.IsDefined(typeof(HotFixManuallyAttribute), false) && !string.IsNullOrEmpty(luaModuleName))
					{
						LuaManager.TryInitHotfixForObj(prefabControllerBase, luaModuleName, null);
					}
					prefabControllerBase.Initlize(ctrlName, autoBind);
				}
				return prefabControllerBase;
			}
			else
			{
				string name = path.Substring(num + 1);
				Transform transform = root.transform.Find(name);
				if (transform == null)
				{
					global::Debug.LogError(string.Format("AddControllerToGameObject fail path error {0}", path));
					return null;
				}
				GameObject gameObject = transform.gameObject;
				PrefabControllerBase prefabControllerBase = gameObject.GetComponent(type) as PrefabControllerBase;
				if (prefabControllerBase != null)
				{
					return prefabControllerBase;
				}
				prefabControllerBase = (gameObject.AddComponent(type) as PrefabControllerBase);
				if (prefabControllerBase != null)
				{
					prefabControllerBase.Initlize(ctrlName, autoBind);
				}
				return prefabControllerBase;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00017F3C File Offset: 0x0001613C
		public string CtrlName
		{
			get
			{
				return this.m_ctrlName;
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000566 RID: 1382 RVA: 0x00017F44 File Offset: 0x00016144
		// (remove) Token: 0x06000567 RID: 1383 RVA: 0x00017F78 File Offset: 0x00016178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<GameObject> m_onAwake;

		// Token: 0x040002A4 RID: 676
		protected bool m_inited;

		// Token: 0x040002A5 RID: 677
		protected string m_ctrlName;

		// Token: 0x040002A6 RID: 678
		public PrefabResourceContainer m_resContainer;

		// Token: 0x040002A7 RID: 679
		protected PrefabControllerNextUpdateExecutor m_nextUpdateExecutor = new PrefabControllerNextUpdateExecutor();
	}
}
