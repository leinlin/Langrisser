using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Resource;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Prefab
{
	// Token: 0x02000079 RID: 121
	[CustomLuaClass]
	public abstract class PrefabResourceContainerBase : MonoBehaviour
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00018300 File Offset: 0x00016500
		public bool TryGetAsset(string assetName, out UnityEngine.Object asset)
		{
			asset = null;
			if (this.m_assetCacheList == null)
			{
				return false;
			}
			foreach (PrefabResourceContainerBase.AssetCacheItem assetCacheItem in this.m_assetCacheList)
			{
				if (assetCacheItem.Name == assetName)
				{
					asset = assetCacheItem.RuntimeAssetCache;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00018388 File Offset: 0x00016588
		public UnityEngine.Object GetAsset(string assetName)
		{
			UnityEngine.Object result;
			if (this.TryGetAsset(assetName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000183A8 File Offset: 0x000165A8
		public T GetAsset<T>(string assetName) where T : UnityEngine.Object
		{
			return this.GetAsset(assetName) as T;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000183BC File Offset: 0x000165BC
		public IEnumerable GetAssetAsync(string assetName, Action<UnityEngine.Object> onEnd, bool isLoadAssetAsync = false)
		{
			UnityEngine.Object asset;
			if (this.TryGetAsset(assetName, out asset))
			{
				onEnd(asset);
				yield break;
			}
			PrefabResourceContainerBase.AssetCacheItem item = this.GetCacheItemFromList(assetName);
			if (item == null)
			{
				onEnd(null);
				yield break;
			}
			ResourceManager instance = ResourceManager.Instance;
			string assetPath = item.AssetPath;
			Action<string, UnityEngine.Object> onCompleted = delegate(string lPath, UnityEngine.Object lasset)
			{
				asset = lasset;
			};
			IEnumerator iter = instance.LoadAsset<UnityEngine.Object>(assetPath, onCompleted, false, isLoadAssetAsync);
			while (iter.MoveNext())
			{
				yield return null;
			}
			item.RuntimeAssetCache = asset;
			this.m_assetCacheList.Add(item);
			this.m_rawAssetCacheDict[item.AssetPath] = asset;
			onEnd(asset);
			yield break;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000183F4 File Offset: 0x000165F4
		public IEnumerable StartLazyLoadBackground(bool isLoadAssetAsync = true)
		{
			HashSet<string> assetPathSet = new HashSet<string>();
			foreach (PrefabResourceContainerBase.AssetCacheItem assetCacheItem in this.AssetList)
			{
				if (assetCacheItem.LazyLoad && assetCacheItem.RuntimeAssetCache == null && !string.IsNullOrEmpty(assetCacheItem.AssetPath))
				{
					assetPathSet.Add(assetCacheItem.AssetPath);
				}
			}
			IEnumerator iter = this.LoadAndCacheAsset(assetPathSet, isLoadAssetAsync);
			while (iter.MoveNext())
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00018420 File Offset: 0x00016620
		public IEnumerable StartLazyLoadBackground(List<string> assetNames, bool isLoadAssetAsync = true)
		{
			HashSet<string> assetPathSet = new HashSet<string>();
			foreach (PrefabResourceContainerBase.AssetCacheItem assetCacheItem in this.AssetList)
			{
				if (assetCacheItem.LazyLoad && assetCacheItem.RuntimeAssetCache == null && !string.IsNullOrEmpty(assetCacheItem.AssetPath) && assetNames.Contains(assetCacheItem.Name))
				{
					assetPathSet.Add(assetCacheItem.AssetPath);
				}
			}
			IEnumerator iter = this.LoadAndCacheAsset(assetPathSet, isLoadAssetAsync);
			while (iter.MoveNext())
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00018454 File Offset: 0x00016654
		public IEnumerator RecacheAllAssetsFromResourceManager()
		{
			this.m_assetCacheList = new List<PrefabResourceContainerBase.AssetCacheItem>();
			this.m_rawAssetCacheDict = new Dictionary<string, UnityEngine.Object>();
			HashSet<string> assetPathSet = new HashSet<string>();
			foreach (PrefabResourceContainerBase.AssetCacheItem assetCacheItem in this.AssetList)
			{
				if (!string.IsNullOrEmpty(assetCacheItem.AssetPath) && !assetCacheItem.LazyLoad)
				{
					assetPathSet.Add(assetCacheItem.AssetPath);
				}
			}
			IEnumerator iter = this.LoadAndCacheAsset(assetPathSet, false);
			while (iter.MoveNext())
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00018470 File Offset: 0x00016670
		protected IEnumerator LoadAndCacheAsset(HashSet<string> assetPathSet, bool isLoadAssetAsync)
		{
			if (assetPathSet == null || assetPathSet.Count == 0)
			{
				yield break;
			}
			bool isLoadAssetsEnd = false;
			ResourceManager.Instance.StartLoadAssetsCorutine(assetPathSet, this.m_rawAssetCacheDict, delegate
			{
				isLoadAssetsEnd = true;
			}, isLoadAssetAsync);
			while (!isLoadAssetsEnd)
			{
				yield return null;
			}
			foreach (PrefabResourceContainerBase.AssetCacheItem assetCacheItem in this.AssetList)
			{
				if (!string.IsNullOrEmpty(assetCacheItem.AssetPath) && !assetCacheItem.LazyLoad)
				{
					UnityEngine.Object runtimeAssetCache;
					if (this.m_rawAssetCacheDict.TryGetValue(assetCacheItem.AssetPath, out runtimeAssetCache))
					{
						assetCacheItem.RuntimeAssetCache = runtimeAssetCache;
						this.m_assetCacheList.Add(assetCacheItem);
						if (assetCacheItem.IsAssetBundleNotUnload)
						{
							ResourceManager.Instance.MakeAssetBundleDontUnload(assetCacheItem.AssetPath);
						}
					}
				}
			}
			yield break;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001849C File Offset: 0x0001669C
		private PrefabResourceContainerBase.AssetCacheItem GetCacheItemFromList(string assetName)
		{
			foreach (PrefabResourceContainerBase.AssetCacheItem assetCacheItem in this.AssetList)
			{
				if (assetCacheItem.Name == assetName)
				{
					return assetCacheItem;
				}
			}
			return null;
		}

		// Token: 0x040002B0 RID: 688
		public List<PrefabResourceContainerBase.AssetCacheItem> AssetList = new List<PrefabResourceContainerBase.AssetCacheItem>();

		// Token: 0x040002B1 RID: 689
		public List<PrefabResourceContainerBase.AssetCacheItem> m_assetCacheList;

		// Token: 0x040002B2 RID: 690
		protected Dictionary<string, UnityEngine.Object> m_rawAssetCacheDict;

		// Token: 0x0200007A RID: 122
		[Serializable]
		public class AssetCacheItem
		{
			// Token: 0x040002B3 RID: 691
			public string Name;

			// Token: 0x040002B4 RID: 692
			[Header("[不要手动设置!]")]
			public string AssetPath;

			// Token: 0x040002B5 RID: 693
			public UnityEngine.Object Asset;

			// Token: 0x040002B6 RID: 694
			[Header("[是否延时加载!]")]
			public bool LazyLoad;

			// Token: 0x040002B7 RID: 695
			[Header("[不要手动设置!]")]
			public bool IsAssetBundleNotUnload;

			// Token: 0x040002B8 RID: 696
			[Header("[不要手动设置!]")]
			public UnityEngine.Object RuntimeAssetCache;
		}
	}
}
