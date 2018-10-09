using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200086C RID: 2156
	[CustomLuaClass]
	public class AssetUtility
	{
		// Token: 0x06006B15 RID: 27413 RVA: 0x001E0C34 File Offset: 0x001DEE34
		public AssetUtility()
		{
			PDSDK.m_eventOnLowMemoryWarning = new Action(this.OnLowMemoryWarning);
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x001E0C70 File Offset: 0x001DEE70
		public static string MakeSpriteAssetName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return string.Empty;
			}
			string result;
			try
			{
				result = name + '@' + Path.GetFileNameWithoutExtension(name);
			}
			catch (ArgumentException)
			{
				global::Debug.LogError("MakeSpriteAssetName, " + name + " error");
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x001E0CDC File Offset: 0x001DEEDC
		public static string MakeSpriteAssetName(string name, string subName)
		{
			if (string.IsNullOrEmpty(name))
			{
				return string.Empty;
			}
			string result;
			try
			{
				result = string.Concat(new object[]
				{
					name,
					'@',
					Path.GetFileNameWithoutExtension(name),
					subName
				});
			}
			catch (ArgumentException)
			{
				global::Debug.LogError("MakeSpriteAssetName, " + name + " error");
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x001E0D58 File Offset: 0x001DEF58
		public static void AddAssetToList(string name, List<string> list)
		{
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (list == null)
			{
				return;
			}
			if (name == "NULL")
			{
				global::Debug.LogWarning("AddAssetToList, Wrong asset name NULL");
				return;
			}
			string item = "Assets/GameProject/RuntimeAssets/" + name;
			if (list.Contains(item))
			{
				return;
			}
			list.Add(item);
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x001E0DB4 File Offset: 0x001DEFB4
		public static void AddSpriteAssetToList(string name, List<string> list)
		{
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (list == null)
			{
				return;
			}
			if (name == "NULL")
			{
				global::Debug.LogWarning("AddSpriteAssetToList, Wrong sprite name NULL");
				return;
			}
			if (name.IndexOf('@') >= 0)
			{
				AssetUtility.AddAssetToList(name, list);
			}
			else
			{
				AssetUtility.AddAssetToList(AssetUtility.MakeSpriteAssetName(name), list);
			}
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x001E0E18 File Offset: 0x001DF018
		public void RegisterDynamicAssetProvider(IDynamicAssetProvider assetProvider)
		{
			if (assetProvider == null)
			{
				return;
			}
			if (this.m_dynamicAssetProviders.Contains(assetProvider))
			{
				global::Debug.LogError("RegisterDynamicAssetProvider alreasy exist");
				return;
			}
			this.m_dynamicAssetProviders.Insert(0, assetProvider);
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x001E0E4C File Offset: 0x001DF04C
		public void UnregisterDynamicAssetProvider(IDynamicAssetProvider assetProvider)
		{
			if (assetProvider == null)
			{
				return;
			}
			if (!this.m_dynamicAssetProviders.Contains(assetProvider))
			{
				global::Debug.LogError("UnregisterDynamicAssetProvider not exist");
				return;
			}
			this.m_dynamicAssetProviders.Remove(assetProvider);
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x001E0E80 File Offset: 0x001DF080
		public void RegisterDynamicAssetCache(Dictionary<string, UnityEngine.Object> assetCache)
		{
			if (assetCache == null)
			{
				return;
			}
			if (this.m_dynamicAssetCaches.Contains(assetCache))
			{
				global::Debug.LogError("RegisterDynamicAssetCache alreasy exist");
				return;
			}
			this.m_dynamicAssetCaches.Insert(0, assetCache);
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x001E0EB4 File Offset: 0x001DF0B4
		public void UnregisterDynamicAssetCache(Dictionary<string, UnityEngine.Object> assetCache)
		{
			if (assetCache == null)
			{
				return;
			}
			if (!this.m_dynamicAssetCaches.Contains(assetCache))
			{
				global::Debug.LogError("UnregisterDynamicAssetCache not exist");
				return;
			}
			this.m_dynamicAssetCaches.Remove(assetCache);
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x001E0EE8 File Offset: 0x001DF0E8
		public T GetAsset<T>(string name) where T : UnityEngine.Object
		{
			if (string.IsNullOrEmpty(name))
			{
				return (T)((object)null);
			}
			UnityEngine.Object @object = this._GetAsset(name);
			T t = @object as T;
			if (t == null)
			{
				global::Debug.LogError(string.Format("AssetUtility.GetAsset <{0}> {1} is null, {2}.", typeof(T).Name, name, (!(@object == null)) ? string.Format("the actual type is: {0}", @object.GetType().Name) : string.Empty));
			}
			return t;
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x001E0F78 File Offset: 0x001DF178
		public Sprite GetSprite(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			if (name.IndexOf('@') >= 0)
			{
				return this.GetAsset<Sprite>(name);
			}
			return this.GetAsset<Sprite>(AssetUtility.MakeSpriteAssetName(name));
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x001E0FAC File Offset: 0x001DF1AC
		private UnityEngine.Object _GetAsset(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			string text = "Assets/GameProject/RuntimeAssets/" + name;
			foreach (Dictionary<string, UnityEngine.Object> dictionary in this.m_dynamicAssetCaches)
			{
				UnityEngine.Object result;
				if (dictionary.TryGetValue(text, out result))
				{
					return result;
				}
			}
			foreach (IDynamicAssetProvider dynamicAssetProvider in this.m_dynamicAssetProviders)
			{
				UnityEngine.Object @object = dynamicAssetProvider.AllocDynamicAsset(text);
				if (@object != null)
				{
					return @object;
				}
			}
			global::Debug.LogError("_GetAsset, " + name + " not loaded");
			return null;
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x001E10B0 File Offset: 0x001DF2B0
		public void InitLruAssetCache(int cacheType, int maxCount)
		{
			LruAssetCache lruAssetCache = this.GetLruAssetCache(cacheType);
			if (lruAssetCache != null)
			{
				global::Debug.LogError("InitLruAssetCache alreasy exist");
				return;
			}
			lruAssetCache = new LruAssetCache(cacheType, maxCount);
			this.m_lruAssetCaches.Add(lruAssetCache);
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x001E10EC File Offset: 0x001DF2EC
		public void UninitAllLruAssetCache()
		{
			this.ClearAllLruCache();
			this.m_lruAssetCaches.Clear();
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x001E1100 File Offset: 0x001DF300
		public void AddAssetToLruCache(int cacheType, string name)
		{
			UnityEngine.Object @object = this._GetAsset(name);
			if (@object == null)
			{
				return;
			}
			this.AddAssetToLruCache(cacheType, @object);
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x001E112C File Offset: 0x001DF32C
		public void AddAssetToLruCache(int cacheType, UnityEngine.Object a)
		{
			if (a == null)
			{
				return;
			}
			LruAssetCache lruAssetCache = this.GetLruAssetCache(cacheType);
			if (lruAssetCache != null)
			{
				lruAssetCache.Add(a);
			}
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x001E1160 File Offset: 0x001DF360
		public void ClearLruCache(int cacheType)
		{
			LruAssetCache lruAssetCache = this.GetLruAssetCache(cacheType);
			if (lruAssetCache != null)
			{
				lruAssetCache.Clear();
			}
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x001E1184 File Offset: 0x001DF384
		public void ClearAllLruCache()
		{
			foreach (LruAssetCache lruAssetCache in this.m_lruAssetCaches)
			{
				lruAssetCache.Clear();
			}
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x001E11E0 File Offset: 0x001DF3E0
		private LruAssetCache GetLruAssetCache(int cacheType)
		{
			foreach (LruAssetCache lruAssetCache in this.m_lruAssetCaches)
			{
				if (lruAssetCache.GetCacheType() == cacheType)
				{
					return lruAssetCache;
				}
			}
			return null;
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x001E124C File Offset: 0x001DF44C
		public void TestMemoryWarning()
		{
			this.OnLowMemoryWarning();
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x001E1254 File Offset: 0x001DF454
		private void OnLowMemoryWarning()
		{
			Utility.LogMemorySize("AssetUtility.OnLowMemoryWarning");
			if (this.EventOnMemoryWarning != null)
			{
				this.EventOnMemoryWarning();
			}
			this.ClearAllLruCache();
			ResourceManager.Instance.UnloadUnusedResourceAll(null, null);
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06006B2B RID: 27435 RVA: 0x001E1294 File Offset: 0x001DF494
		// (set) Token: 0x06006B2A RID: 27434 RVA: 0x001E128C File Offset: 0x001DF48C
		public static AssetUtility Instance
		{
			get
			{
				return AssetUtility.s_instance;
			}
			set
			{
				AssetUtility.s_instance = value;
			}
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06006B2C RID: 27436 RVA: 0x001E129C File Offset: 0x001DF49C
		// (remove) Token: 0x06006B2D RID: 27437 RVA: 0x001E12D4 File Offset: 0x001DF4D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action EventOnMemoryWarning;

		// Token: 0x04005276 RID: 21110
		public const string DataPath = "Assets/GameProject/RuntimeAssets/";

		// Token: 0x04005278 RID: 21112
		private static AssetUtility s_instance;

		// Token: 0x04005279 RID: 21113
		private List<IDynamicAssetProvider> m_dynamicAssetProviders = new List<IDynamicAssetProvider>();

		// Token: 0x0400527A RID: 21114
		private List<Dictionary<string, UnityEngine.Object>> m_dynamicAssetCaches = new List<Dictionary<string, UnityEngine.Object>>();

		// Token: 0x0400527B RID: 21115
		private List<LruAssetCache> m_lruAssetCaches = new List<LruAssetCache>();
	}
}
