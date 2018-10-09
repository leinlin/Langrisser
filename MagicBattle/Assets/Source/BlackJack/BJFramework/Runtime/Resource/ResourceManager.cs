using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.Utils;
using Boo.Lang;
using SLua;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlackJack.BJFramework.Runtime.Resource
{
	// Token: 0x0200008A RID: 138
	[CustomLuaClass]
	public class ResourceManager : ITickable
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x0001905C File Offset: 0x0001725C
		protected ResourceManager()
		{
			this.State = ResourceManager.RMState.None;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00019124 File Offset: 0x00017324
		[DoNotToLua]
		public static ResourceManager CreateResourceManager()
		{
			if (ResourceManager.m_instance == null)
			{
				ResourceManager.m_instance = new ResourceManager();
			}
			return ResourceManager.m_instance;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00019140 File Offset: 0x00017340
		[DoNotToLua]
		public bool Initlize(ResourcesSettings settings)
		{
			global::Debug.Log("ResourceManager.Initlize start");
			this.State = ResourceManager.RMState.Inited;
			this.m_disableAssetBundle = settings.DisableAssetBundle;
			this.m_skipStreamingAssetsFileProcessing = (this.m_disableAssetBundle && settings.SkipStreamingAssetsFileProcessing);
			this.m_disableAssetBundleDownload = (this.m_disableAssetBundle || settings.DisableAssetBundleDownload);
			this.m_skipAssetBundlePreUpdateing = (this.m_disableAssetBundle || this.m_disableAssetBundleDownload || settings.SkipAssetBundlePreUpdateing);
			this.m_bundleDownloadUrlRoot = settings.AssetBundleDownloadUrlRoot;
			this.m_updateingWorkerCount = ((settings.PreUpdateWorkerCount >= 1) ? settings.PreUpdateWorkerCount : 1);
			this.m_loadAssetFromBundleInEditor = (!settings.DisableAssetBundle && settings.LoadAssetFromBundleInEditor);
			this.m_unloadUnusedAssetTimeInterval = settings.UnloadUnusedAssetTimeInterval;
			this.m_assetPathIgnoreCase = settings.AssetPathIgnoreCase;
			this.m_enableDetailResourceManagerLog = settings.EnableDetailResourceManagerLog;
			return this.LoadTouchedBundleSet();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00019248 File Offset: 0x00017448
		[DoNotToLua]
		public void Uninitlize()
		{
			global::Debug.Log("ResourceManager.Uninitlize");
			this.State = ResourceManager.RMState.None;
			this.m_corutineHelper.CancelAll();
			this.m_assetsCacheDict.Clear();
			this.m_bundleCacheDict.Clear();
			this.m_bundleCachetoUnload.Clear();
			this.m_bundleLoadingCtxDict.Clear();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000192A0 File Offset: 0x000174A0
		public IEnumerator LoadAsset<T>(string path, Action<string, T> onCompleted, bool noErrlog = false, bool loadAync = false) where T : UnityEngine.Object
		{
			if (Application.isEditor)
			{
				this.m_loadFilePaths.Add(path);
			}
			if (Application.isEditor)
			{
				this.m_loadedAssetPathSet.Add(path);
			}
			this.m_loadingOpCount++;
			T asset = this.GetAssetFromCache(path) as T;
			if (asset != null)
			{
				this.m_loadingOpCount--;
				onCompleted(path, asset);
				if (this.EventOnAssetLoaded != null)
				{
					this.EventOnAssetLoaded();
				}
				yield break;
			}
			int atIndexInPath = path.IndexOf('@');
			string assetPath;
			string subAssetName;
			if (atIndexInPath == -1)
			{
				assetPath = path;
				subAssetName = null;
			}
			else
			{
				assetPath = path.Substring(0, atIndexInPath);
				subAssetName = path.Substring(atIndexInPath + 1);
			}
			bool hasSubAssetName = !string.IsNullOrEmpty(subAssetName);
			bool isNeedLoadAllRes = this.IsNeedLoadAllForAssetPath(assetPath);
			if (hasSubAssetName && !isNeedLoadAllRes)
			{
				this.m_loadingOpCount--;
				throw new ApplicationException(string.Format("[{0}] hasSubAssetName but not in fbx", path));
			}
			ResourceManager.BundleCacheItem bundleCacheItem = null;
			UnityEngine.Object[] allAsset = null;
			if (this.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				this.LoadAssetByResourcesLoad<T>(assetPath, delegate(string lPath, UnityEngine.Object[] lAllAsset)
				{
					allAsset = lAllAsset;
				}, noErrlog, isNeedLoadAllRes);
			}
			else
			{
				if (!Application.isEditor || this.m_loadAssetFromBundleInEditor)
				{
					IEnumerator iter = this.LoadAssetFromBundle(assetPath, delegate(string lPath, UnityEngine.Object[] lAllAsset, ResourceManager.BundleCacheItem lBundleCacheItem)
					{
						allAsset = lAllAsset;
						bundleCacheItem = lBundleCacheItem;
					}, noErrlog, loadAync);
					while (iter.MoveNext())
					{
						yield return null;
					}
					bundleCacheItem = ((allAsset == null) ? null : bundleCacheItem);
				}
				if (Application.isEditor && (allAsset == null || allAsset.Length == 0))
				{
					this.LoadAssetByAssetDatabase<T>(assetPath, delegate(string lPath, UnityEngine.Object[] lAllAsset)
					{
						allAsset = lAllAsset;
					}, noErrlog, isNeedLoadAllRes);
				}
				if (allAsset == null || allAsset.Length == 0)
				{
					this.LoadAssetByResourcesLoad<T>(assetPath, delegate(string lPath, UnityEngine.Object[] lAllAsset)
					{
						allAsset = lAllAsset;
					}, noErrlog, isNeedLoadAllRes);
				}
			}
			UnityEngine.Object mainAsset = null;
			if (allAsset != null && allAsset.Length != 0)
			{
				if (!hasSubAssetName)
				{
					asset = (allAsset[0] as T);
				}
				else
				{
					if (allAsset.Length == 2 && (allAsset[1] is Texture2D || allAsset[0] is Sprite))
					{
						UnityEngine.Object @object = allAsset[0];
						allAsset[0] = allAsset[1];
						allAsset[1] = @object;
					}
					mainAsset = allAsset[0];
					foreach (UnityEngine.Object object2 in allAsset)
					{
						if (object2 != null && object2 != mainAsset && object2.name == subAssetName)
						{
							asset = (object2 as T);
							break;
						}
					}
					asset = ((!(asset != null)) ? (mainAsset as T) : asset);
				}
				if (asset == null)
				{
					global::Debug.LogError(string.Format("LoadAsset fail for {0}", path));
				}
				for (int j = 0; j < allAsset.Length; j++)
				{
					UnityEngine.Object object3 = allAsset[j];
					if (!(object3 == null))
					{
						if (object3 is Sprite)
						{
							this.PushAssetToCache(string.Format("{0}@{1}", assetPath, object3.name), object3, bundleCacheItem);
						}
						else if (j == 0)
						{
							this.PushAssetToCache(assetPath, object3, bundleCacheItem);
						}
						else if (object3 != null)
						{
							this.PushAssetToCache(string.Format("{0}@{1}", assetPath, object3.name), object3, bundleCacheItem);
						}
					}
				}
			}
			this.m_loadingOpCount--;
			GameObject prefab = asset as GameObject;
			if (prefab != null)
			{
				PrefabResourceContainerBase[] resourceContanierList = prefab.GetComponentsInChildren<PrefabResourceContainerBase>(true);
				foreach (PrefabResourceContainerBase resContainer in resourceContanierList)
				{
					IEnumerator iter2 = resContainer.RecacheAllAssetsFromResourceManager();
					while (iter2.MoveNext())
					{
						yield return null;
					}
				}
			}
			onCompleted(path, asset);
			if (this.EventOnAssetLoaded != null)
			{
				this.EventOnAssetLoaded();
			}
			yield break;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000192D8 File Offset: 0x000174D8
		protected bool IsNeedLoadAllForAssetPath(string assetPath)
		{
			return assetPath.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || assetPath.EndsWith(".fbx", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000192FC File Offset: 0x000174FC
		public void StartLoadAssetsCorutine(HashSet<string> pathList, IDictionary<string, UnityEngine.Object> assetDict, Action onComplete, bool loadAsync = false)
		{
			if (pathList.Count >= 10)
			{
				int endCout = 0;
				this.m_corutineHelper.StartCorutine(this.LoadAssetsCorutine(pathList, 0, assetDict, delegate
				{
					endCout++;
					if (endCout == 2)
					{
						onComplete();
					}
				}, loadAsync));
				this.m_corutineHelper.StartCorutine(this.LoadAssetsCorutine(pathList, 1, assetDict, delegate
				{
					endCout++;
					if (endCout == 2)
					{
						onComplete();
					}
				}, loadAsync));
			}
			else
			{
				this.m_corutineHelper.StartCorutine(this.LoadAssetsCorutine(pathList, int.MaxValue, assetDict, onComplete, loadAsync));
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000193A0 File Offset: 0x000175A0
		public void StartLoadAssetCorutine(string path, Action<string, UnityEngine.Object> onComplete)
		{
			this.m_corutineHelper.StartCorutine(this.LoadAsset<UnityEngine.Object>(path, onComplete, false, false));
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000193B8 File Offset: 0x000175B8
		protected IEnumerator LoadAssetsCorutine(HashSet<string> pathList, int corutineId, IDictionary<string, UnityEngine.Object> assetDict, Action onComplete, bool loadAsync)
		{
			if (Application.isEditor)
			{
				this.m_loadFilePaths.UnionWith(pathList);
			}
			int i = -1;
			this.m_loadingOpCount++;
			this._stopWatch.Reset();
			this._stopWatch.Start();
			foreach (string path in pathList)
			{
				i++;
				if (corutineId == 2147483647 || i % 2 == corutineId)
				{
					UnityEngine.Object asset = null;
					IEnumerator iter = this.LoadAsset<UnityEngine.Object>(path, delegate(string lpath, UnityEngine.Object lasset)
					{
						asset = lasset;
					}, loadAsync, false);
					while (TinyCorutineHelper.MoveNext(iter))
					{
						if (this._stopWatch.Elapsed.TotalSeconds > 0.1)
						{
							if (pathList.Count > 100)
							{
								this.m_loadingProgress = ((float)i + 1f) / (float)pathList.Count;
							}
							this._stopWatch.Reset();
							this._stopWatch.Start();
							yield return null;
						}
					}
					if (assetDict != null)
					{
						assetDict[path] = asset;
					}
					if (this._stopWatch.Elapsed.TotalSeconds > 0.1)
					{
						if (pathList.Count > 100)
						{
							this.m_loadingProgress = ((float)i + 1f) / (float)pathList.Count;
						}
						this._stopWatch.Reset();
						this._stopWatch.Start();
						yield return null;
					}
				}
			}
			onComplete();
			this.m_loadingOpCount--;
			yield break;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000193F8 File Offset: 0x000175F8
		protected void LoadAssetByResourcesLoad<T>(string path, Action<string, UnityEngine.Object[]> onCompleted, bool noErrlog = false, bool isNeedLoadAllRes = false) where T : UnityEngine.Object
		{
			int num = path.LastIndexOf(".");
			string text = (num != -1) ? path.Substring(0, num) : path;
			int num2 = text.IndexOf("Resources/");
			text = ((num2 != -1) ? text.Substring(num2 + "Resources/".Length) : text);
			UnityEngine.Object[] array;
			if (isNeedLoadAllRes)
			{
				array = Resources.LoadAll(text);
			}
			else
			{
				array = new UnityEngine.Object[]
				{
					Resources.Load<T>(text)
				};
			}
			if (array == null || array.Length == 0)
			{
				if (!noErrlog)
				{
					global::Debug.LogError(string.Format("LoadAssetByResourcesLoad fail {0}", text));
				}
				else
				{
					global::Debug.Log(string.Format("LoadAssetByResourcesLoad fail {0}", text));
				}
			}
			else
			{
				global::Debug.Log(string.Format("LoadAssetByResourcesLoad ok {0}", text));
			}
			onCompleted(text, array);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000194D4 File Offset: 0x000176D4
		protected virtual void LoadAssetByAssetDatabase<T>(string path, Action<string, UnityEngine.Object[]> onCompleted, bool noErrlog = false, bool isNeedLoadAllRes = false) where T : UnityEngine.Object
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000194D8 File Offset: 0x000176D8
		protected UnityEngine.Object GetAssetFromCache(string key)
		{
			ResourceManager.AssetCacheItem assetCacheItem;
			bool flag = this.m_assetsCacheDict.TryGetValue(key, out assetCacheItem);
			if (flag)
			{
				WeakReference weakRefrence = assetCacheItem.m_weakRefrence;
				if (weakRefrence.IsAlive)
				{
					if (this.m_enableDetailResourceManagerLog)
					{
						global::Debug.Log("GetAssetFromCache OK " + key);
					}
					if (assetCacheItem.m_removeReserveOnHit)
					{
						this.RemoveReserve4CacheHit(key);
					}
					return weakRefrence.Target as UnityEngine.Object;
				}
				if (this.m_enableDetailResourceManagerLog)
				{
					global::Debug.Log("GetAssetFromCache Dead " + key);
				}
				this.m_assetsCacheDict.Remove(key);
			}
			else if (this.m_enableDetailResourceManagerLog)
			{
				global::Debug.Log("GetAssetFromCache NULL " + key);
			}
			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00019590 File Offset: 0x00017790
		protected void PushAssetToCache(string key, UnityEngine.Object asset, ResourceManager.BundleCacheItem bundleCacheItem = null)
		{
			ResourceManager.AssetCacheItem assetCacheItem;
			bool flag = this.m_assetsCacheDict.TryGetValue(key, out assetCacheItem);
			if (flag && object.ReferenceEquals(assetCacheItem.m_weakRefrence.Target, asset))
			{
				return;
			}
			assetCacheItem = new ResourceManager.AssetCacheItem();
			assetCacheItem.m_weakRefrence = new WeakReference(asset);
			assetCacheItem.m_cacheKey = key;
			this.m_assetsCacheDict[key] = assetCacheItem;
			if (bundleCacheItem != null)
			{
				this.OnBundleCacheHit(bundleCacheItem);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000195FC File Offset: 0x000177FC
		public void SetDownloadUrlRoot(string url)
		{
			if (this.m_bundleDownloadUrlRoot == url)
			{
				return;
			}
			this.m_bundleDownloadUrlRoot = url;
			this.m_downloadUrlRootWithPlatform = null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00019620 File Offset: 0x00017820
		[DoNotToLua]
		public void Tick()
		{
			this.m_corutineHelper.Tick();
			this.TickReserve();
			this.TickAsset();
			this.TickBundle();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00019640 File Offset: 0x00017840
		protected void TickAsset()
		{
			if (this.m_needUnloadUnusedAssets && this.m_loadingOpCount == 0)
			{
				this.m_needUnloadUnusedAssets = false;
				this.UnloadUnusedAssets();
			}
			if (this.m_currUnloadUnusedAssetsOperation != null && this.m_currUnloadUnusedAssetsOperation.isDone)
			{
				this.m_currUnloadUnusedAssetsOperation = null;
				GC.Collect();
				this.CleanUnusedAssetsCache();
				if (this.m_needUnloadAllUnusedBundles)
				{
					if (this.UnloadAllUnusedBundles(false))
					{
						this.m_needUnloadAllUnusedBundles = false;
						this.m_needGC = true;
					}
					if (this.m_eventOnUnloadUnusedResourceAllCompleted != null)
					{
						this.m_eventOnUnloadUnusedResourceAllCompleted();
						this.m_eventOnUnloadUnusedResourceAllCompleted = null;
					}
				}
			}
			if (this.m_nextUnloadUnusedAssetTime <= Timer.m_currTime && this.m_loadingOpCount == 0 && this.m_currUnloadUnusedAssetsOperation == null)
			{
				this.m_nextUnloadUnusedAssetTime = Timer.m_currTime.AddSeconds((double)this.m_unloadUnusedAssetTimeInterval);
				this.UnloadUnusedAssets();
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001972C File Offset: 0x0001792C
		protected void TickGC()
		{
			if (this.m_needGC)
			{
				this.m_needGC = false;
				GC.Collect();
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00019748 File Offset: 0x00017948
		protected void TickMemUseage()
		{
			if (this.m_nextCheckMemUseageTime < Timer.m_currTime)
			{
				this.OutputMemUseage();
				this.m_nextCheckMemUseageTime = Timer.m_currTime.AddSeconds(30.0);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00019780 File Offset: 0x00017980
		public void OutputMemUseage()
		{
			float num = 1E-06f;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("@@@@    MemUseage Check:");
			stringBuilder.AppendFormat("@@@@    MemUseage Check:            GC TotalMemory:{0}M. \r\n", (float)GC.GetTotalMemory(false) * num);
			stringBuilder.AppendFormat("@@@@    MemUseage Check:            GC CollectionCount:{0}  \r\n", GC.CollectionCount(0));
			stringBuilder.AppendLine("@@@@    MemUseage Check end");
			global::Debug.LogWarning(stringBuilder.ToString());
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000197F0 File Offset: 0x000179F0
		public bool UnloadUnusedAssets()
		{
			if (this.m_loadingOpCount != 0)
			{
				return false;
			}
			if (this.m_currUnloadUnusedAssetsOperation == null)
			{
				this.m_currUnloadUnusedAssetsOperation = Resources.UnloadUnusedAssets();
			}
			return true;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00019818 File Offset: 0x00017A18
		public bool UnloadUnusedResourceAll(Action onComplete = null, HashSet<string> keepReserve = null)
		{
			if (this.m_loadingOpCount != 0)
			{
				global::Debug.LogError("UnloadUnusedResourceAll fail, m_loadingOpCount != 0" + this.m_loadingOpCount.ToString());
				this.m_needUnloadUnusedAssets = true;
				if (onComplete != null)
				{
					onComplete();
				}
				return false;
			}
			this.ClearAllReserve(keepReserve);
			this.UnloadUnusedAssets();
			this.m_needUnloadAllUnusedBundles = true;
			if (onComplete != null)
			{
				this.m_eventOnUnloadUnusedResourceAllCompleted += onComplete;
			}
			return true;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00019888 File Offset: 0x00017A88
		protected void CleanUnusedAssetsCache()
		{
			Dictionary<string, ResourceManager.AssetCacheItem>.ValueCollection values = this.m_assetsCacheDict.Values;
			foreach (ResourceManager.AssetCacheItem assetCacheItem in values)
			{
				if (!assetCacheItem.m_weakRefrence.IsAlive)
				{
					this.m_assetsCacheToRemove.Add(assetCacheItem);
				}
			}
			foreach (ResourceManager.AssetCacheItem assetCacheItem2 in this.m_assetsCacheToRemove)
			{
				this.m_assetsCacheDict.Remove(assetCacheItem2.m_cacheKey);
			}
			this.m_assetsCacheToRemove.Clear();
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00019964 File Offset: 0x00017B64
		protected string GetDownloadBundleUrl(string path)
		{
			if (this.m_downloadUrlRootWithPlatform == null)
			{
				if (string.IsNullOrEmpty(this.m_downloadBundleUrlPrefix))
				{
					this.m_downloadUrlRootWithPlatform = string.Format("{0}/{1}", this.m_bundleDownloadUrlRoot, Util.GetCurrentTargetPlatform());
				}
				else
				{
					this.m_downloadUrlRootWithPlatform = string.Format("{0}/{1}/{2}", this.m_bundleDownloadUrlRoot, this.m_downloadBundleUrlPrefix, Util.GetCurrentTargetPlatform());
				}
			}
			return string.Format("{0}/{1}", this.m_downloadUrlRootWithPlatform, path);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000199E0 File Offset: 0x00017BE0
		protected string GetStreamingAssetBundleUrl(string bundleName)
		{
			return string.Format("file://{0}/{1}", PathHelper.StreamingAssetsBundlePath, bundleName);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000199F4 File Offset: 0x00017BF4
		protected string GetStreamingAssetBundlePath(string bundleName)
		{
			return string.Format("{0}/{1}", PathHelper.StreamingAssetsBundlePath, bundleName);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00019A08 File Offset: 0x00017C08
		protected string GetBundleLoadingUrl(string bundleName)
		{
			if (this.m_disableAssetBundleDownload)
			{
				return this.GetStreamingAssetBundleUrl(bundleName);
			}
			return this.GetDownloadBundleUrl(bundleName);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00019A24 File Offset: 0x00017C24
		protected bool IsBundleNeedLoadFromStreamingAssetFile(string bundleName, int version)
		{
			if (this.m_disableAssetBundleDownload)
			{
				return true;
			}
			BundleData.SingleBundleData streamingAssetsBundleDataItem = this.m_streamingAssetsBundleDataHelper.GetBundleDataByName(bundleName);
			if (streamingAssetsBundleDataItem == null)
			{
				return false;
			}
			if (!streamingAssetsBundleDataItem.m_isInStreamingAssets)
			{
				return false;
			}
			if (streamingAssetsBundleDataItem.m_version < version)
			{
				return false;
			}
			if (this.m_streamingAssetsFileList.m_fileList.Find((StreamingAssetsFileList.ListItem item) => item.m_bundleName == streamingAssetsBundleDataItem.m_bundleName) == null)
			{
				global::Debug.LogError(string.Format("ResourceManager.IsBundleNeedLoadFromStreamingAssetFile not exist: {0}", streamingAssetsBundleDataItem.m_bundleName));
				return false;
			}
			return true;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00019AC8 File Offset: 0x00017CC8
		protected IEnumerator LoadBundleFromCacheOrDownload(string url, int bundleVersion, uint bundleCRC, Action<AssetBundle> onEnd)
		{
			for (int doCount = 1; doCount <= 2; doCount++)
			{
				WWW www = WWW.LoadFromCacheOrDownload(url, bundleVersion, bundleCRC);
				while (!www.isDone && string.IsNullOrEmpty(www.error))
				{
					yield return null;
				}
				if (!string.IsNullOrEmpty(www.error))
				{
					global::Debug.LogError(string.Format("ResourceManager.LoadBundleFromCacheOrDownload error{0}: {1}", doCount, www.error));
				}
				else
				{
					if (!(www.assetBundle == null))
					{
						onEnd(www.assetBundle);
						yield break;
					}
					global::Debug.LogError(string.Format("ResourceManager.LoadBundleFromCacheOrDownload {0}: www.assetBundle==null", doCount));
				}
			}
			onEnd(null);
			yield break;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00019AFC File Offset: 0x00017CFC
		public HashSet<string> GetLoadedAssetPathSet()
		{
			return this.m_loadedAssetPathSet;
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060005D3 RID: 1491 RVA: 0x00019B04 File Offset: 0x00017D04
		// (remove) Token: 0x060005D4 RID: 1492 RVA: 0x00019B3C File Offset: 0x00017D3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action EventOnAssetLoaded;

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00019B74 File Offset: 0x00017D74
		public static ResourceManager Instance
		{
			get
			{
				return ResourceManager.m_instance;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00019B7C File Offset: 0x00017D7C
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00019B84 File Offset: 0x00017D84
		public ResourceManager.RMState State { get; protected set; }

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060005D8 RID: 1496 RVA: 0x00019B90 File Offset: 0x00017D90
		// (remove) Token: 0x060005D9 RID: 1497 RVA: 0x00019BC8 File Offset: 0x00017DC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event Action m_eventOnUnloadUnusedResourceAllCompleted;

		// Token: 0x060005DA RID: 1498 RVA: 0x00019C00 File Offset: 0x00017E00
		public void SetDownloadBundleUrlPrefix(string prefix)
		{
			this.m_downloadBundleUrlPrefix = prefix;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00019C0C File Offset: 0x00017E0C
		protected IEnumerator LoadAssetFromBundle(string path, Action<string, UnityEngine.Object[], ResourceManager.BundleCacheItem> onCompleted, bool noErrlog = false, bool loadAync = false)
		{
			BundleData.SingleBundleData bundleData = this.GetBundleDataByAssetPath(path);
			if (bundleData == null)
			{
				global::Debug.LogError(string.Format("LoadAssetFromBundle bundleData=null {0}", path));
				onCompleted(path, null, null);
				yield break;
			}
			if (this.m_enableDetailResourceManagerLog)
			{
				global::Debug.Log(string.Format("LoadAssetFromBundle  start bundlename={0} path = {1}", bundleData.m_bundleName, path));
			}
			AssetBundle bundle = null;
			ResourceManager.BundleCacheItem bundleCacheItem = this.GetAssetBundleFromCache(bundleData.m_bundleName);
			if (bundleCacheItem == null)
			{
				IEnumerator iter = this.LoadBundle(bundleData, loadAync, delegate(AssetBundle lbundle, ResourceManager.BundleCacheItem lbundleCacheItem)
				{
					bundle = lbundle;
					bundleCacheItem = lbundleCacheItem;
				});
				while (iter.MoveNext())
				{
					yield return null;
				}
				if (bundle == null)
				{
					if (!noErrlog)
					{
						global::Debug.LogError(string.Format("LoadAssetFromBundle LoadBundle fail {0}", bundleData.m_bundleName));
					}
					else
					{
						global::Debug.Log(string.Format("LoadAssetFromBundle LoadBundle fail {0}", bundleData.m_bundleName));
					}
					onCompleted(path, null, null);
					yield break;
				}
			}
			else
			{
				bundle = bundleCacheItem.m_bundle;
			}
			string assetName = this.GetAssetNameByPath(path);
			UnityEngine.Object[] allAssets;
			if (loadAync)
			{
				AssetBundleRequest assetReqIter = bundle.LoadAssetWithSubAssetsAsync(assetName);
				while (!assetReqIter.isDone)
				{
					yield return null;
				}
				allAssets = assetReqIter.allAssets;
			}
			else
			{
				allAssets = bundle.LoadAssetWithSubAssets(assetName);
			}
			if (allAssets == null || allAssets.Length <= 0)
			{
				if (!noErrlog)
				{
					global::Debug.LogError(string.Format("LoadAssetFromBundle bundle.LoadAsset fail {0} {1}", assetName, bundleData.m_bundleName));
				}
				else
				{
					global::Debug.Log(string.Format("LoadAssetFromBundle bundle.LoadAsset fail {0} {1}", assetName, bundleData.m_bundleName));
				}
				onCompleted(path, null, null);
				yield break;
			}
			onCompleted(path, allAssets, bundleCacheItem);
			yield break;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00019C44 File Offset: 0x00017E44
		protected IEnumerator LoadBundle4UnityScene(string scenePath, Action<string, ResourceManager.BundleCacheItem> onComplete, bool noErrlog, bool loadAync)
		{
			global::Debug.Log(string.Format("LoadBundle4UnityScene start {0}", scenePath));
			BundleData.SingleBundleData bundleData = this.GetBundleDataByAssetPath(scenePath);
			if (bundleData == null)
			{
				global::Debug.LogError(string.Format("LoadBundle4UnityScene bundleData=null {0}", scenePath));
				onComplete(scenePath, null);
				yield break;
			}
			global::Debug.Log(string.Format("LoadBundle4UnityScene bundlename={0} {1}", bundleData.m_bundleName, scenePath));
			AssetBundle bundle = null;
			ResourceManager.BundleCacheItem bundleCacheItem = this.GetAssetBundleFromCache(bundleData.m_bundleName);
			if (bundleCacheItem == null)
			{
				IEnumerator iter = this.LoadBundle(bundleData, loadAync, delegate(AssetBundle lbundle, ResourceManager.BundleCacheItem lbundleCacheItem)
				{
					bundle = lbundle;
					bundleCacheItem = lbundleCacheItem;
				});
				while (iter.MoveNext())
				{
					yield return null;
				}
				if (bundle == null)
				{
					if (!noErrlog)
					{
						global::Debug.LogError(string.Format("LoadBundle4UnityScene LoadBundle fail {0}", bundleData.m_bundleName));
					}
					else
					{
						global::Debug.Log(string.Format("LoadBundle4UnityScene LoadBundle fail {0}", bundleData.m_bundleName));
					}
					onComplete(scenePath, null);
					yield break;
				}
			}
			onComplete(scenePath, bundleCacheItem);
			yield break;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00019C7C File Offset: 0x00017E7C
		protected IEnumerator LoadBundle(BundleData.SingleBundleData bundleData, bool loadAync, Action<AssetBundle, ResourceManager.BundleCacheItem> onComplete)
		{
			ResourceManager.BundleCacheItem bundleCatchItem = this.GetAssetBundleFromCache(bundleData.m_bundleName);
			if (bundleCatchItem != null)
			{
				onComplete(bundleCatchItem.m_bundle, bundleCatchItem);
				yield break;
			}
			ResourceManager.BundleLoadingCtx bundleLoadingCtx;
			bool alreadyInLoading = this.RegBundleLoadingCtx(bundleData.m_bundleName, out bundleLoadingCtx);
			if (alreadyInLoading)
			{
				float startWaitTime = Time.time;
				while (!bundleLoadingCtx.m_isEnd)
				{
					if (Time.time > startWaitTime + 20f)
					{
						global::Debug.LogError(new object[]
						{
							"LoadBundle Waiting LoadingCtx {0} time out!",
							bundleLoadingCtx.m_bundleName
						});
						onComplete(null, null);
						yield break;
					}
					yield return null;
				}
				onComplete(bundleLoadingCtx.m_bundle, this.GetAssetBundleFromCache(bundleData.m_bundleName));
				this.UnregBundleLoadingCtx(bundleLoadingCtx);
				yield break;
			}
			string[] dependenceList = this.m_assetBundleManifest.GetDirectDependencies(bundleData.m_bundleName);
			System.Collections.Generic.List<ResourceManager.BundleCacheItem> dependBundleCacheList = null;
			if (dependenceList != null && dependenceList.Length != 0)
			{
				string[] array = dependenceList;
				for (int i = 0; i < array.Length; i++)
				{
					string dependence = array[i];
					AssetBundle dependBundle = null;
					ResourceManager.BundleCacheItem dependCacheItem = null;
					IEnumerator iter = this.LoadBundle(dependence, loadAync, delegate(AssetBundle lbundle, ResourceManager.BundleCacheItem lbundleCache)
					{
						dependBundle = lbundle;
						dependCacheItem = lbundleCache;
					}, false);
					while (iter.MoveNext())
					{
						yield return null;
					}
					if (dependBundle == null)
					{
						global::Debug.LogError(string.Format("LoadBundle fail by load dependence fail {0} {1}", bundleData.m_bundleName, bundleData.m_version));
						onComplete(null, null);
						yield break;
					}
					if (dependBundleCacheList == null)
					{
						dependBundleCacheList = new System.Collections.Generic.List<ResourceManager.BundleCacheItem>();
					}
					dependBundleCacheList.Add(dependCacheItem);
				}
			}
			bool isNewTouchedBundle = this.AddBundle2TouchedBundleSet(bundleData.m_bundleName, true);
			AssetBundle loadedBundle = null;
			IEnumerator lbIter = this.LoadBundleFromWWWOrStreamingImpl(bundleData, loadAync, true, delegate(AssetBundle lbundle)
			{
				loadedBundle = lbundle;
			});
			while (lbIter.MoveNext())
			{
				yield return null;
			}
			if (loadedBundle == null)
			{
				bundleLoadingCtx.m_isEnd = true;
				onComplete(null, null);
				this.UnregBundleLoadingCtx(bundleLoadingCtx);
				yield break;
			}
			bundleLoadingCtx.m_isEnd = true;
			bundleLoadingCtx.m_bundle = loadedBundle;
			bundleCatchItem = this.PushAssetBundleToCache(bundleData.m_bundleName, loadedBundle);
			bundleCatchItem.m_dependBundleCacheList = dependBundleCacheList;
			if (dependBundleCacheList != null)
			{
				foreach (ResourceManager.BundleCacheItem bundleCacheItem in dependBundleCacheList)
				{
					bundleCacheItem.AddRefrence();
				}
			}
			if (isNewTouchedBundle && bundleData.m_isResaveFileBundle)
			{
				this.DealWithResaveFileInBundle(loadedBundle, this.m_bundleDataHelper);
			}
			this.UnregBundleLoadingCtx(bundleLoadingCtx);
			onComplete(loadedBundle, bundleCatchItem);
			yield break;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00019CAC File Offset: 0x00017EAC
		protected IEnumerator LoadBundle(string bundleName, bool loadAync, Action<AssetBundle, ResourceManager.BundleCacheItem> onComplete, bool noErrlog = false)
		{
			BundleData.SingleBundleData bundleData = this.m_bundleDataHelper.GetBundleDataByName(bundleName);
			if (bundleData == null)
			{
				if (!noErrlog)
				{
					global::Debug.LogError(string.Format("LoadBundle fail {0}", bundleName));
				}
				else
				{
					global::Debug.Log(string.Format("LoadBundle fail {0}", bundleName));
				}
				onComplete(null, null);
				yield break;
			}
			IEnumerator iter = this.LoadBundle(bundleData, loadAync, onComplete);
			while (iter.MoveNext())
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00019CE4 File Offset: 0x00017EE4
		protected IEnumerator LoadBundleFromWWWOrStreamingImpl(BundleData.SingleBundleData bundleData, bool loadAync, bool ignoreCRC, Action<AssetBundle> onComplete)
		{
			AssetBundle loadedBundle = null;
			uint crc = (!ignoreCRC) ? bundleData.m_bundleCRC : 0u;
			if (this.IsBundleNeedLoadFromStreamingAssetFile(bundleData.m_bundleName, bundleData.m_version))
			{
				string path = this.GetStreamingAssetBundlePath(bundleData.m_bundleName);
				if (loadAync)
				{
					AssetBundleCreateRequest req = AssetBundle.LoadFromFileAsync(path);
					while (!req.isDone)
					{
						yield return null;
					}
					if (req.assetBundle == null)
					{
						global::Debug.LogError(new object[]
						{
							"LoadBundleFromWWWOrStreamingImpl LoadFromFileAsync  fail {0} {1}",
							path,
							crc
						});
						onComplete(null);
						yield break;
					}
					loadedBundle = req.assetBundle;
				}
				else
				{
					loadedBundle = AssetBundle.LoadFromFile(path);
				}
				if (loadedBundle != null)
				{
					onComplete(loadedBundle);
					yield break;
				}
			}
			string url = this.GetBundleLoadingUrl(bundleData.m_bundleName);
			WWW www = WWW.LoadFromCacheOrDownload(url, bundleData.m_version, crc);
			while (!www.isDone && string.IsNullOrEmpty(www.error))
			{
				yield return null;
			}
			if (!string.IsNullOrEmpty(www.error))
			{
				global::Debug.LogError("LoadBundleFromWWWOrStreamingImpl: " + www.error);
				onComplete(null);
				yield break;
			}
			if (!www.isDone || www.assetBundle == null)
			{
				global::Debug.LogError(string.Format("LoadBundleFromWWWOrStreamingImpl: error={0}, url={1}, ver={2}", www.error, url, bundleData.m_version));
				onComplete(null);
				yield break;
			}
			loadedBundle = www.assetBundle;
			onComplete(loadedBundle);
			yield break;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00019D1C File Offset: 0x00017F1C
		public bool MakeAssetBundleDontUnload(string assetPath)
		{
			if (this.m_disableAssetBundle)
			{
				return true;
			}
			BundleData.SingleBundleData bundleDataByAssetPath = this.GetBundleDataByAssetPath(assetPath);
			if (bundleDataByAssetPath == null)
			{
				return false;
			}
			ResourceManager.BundleCacheItem assetBundleFromCache = this.GetAssetBundleFromCache(bundleDataByAssetPath.m_bundleName);
			if (assetBundleFromCache == null)
			{
				return false;
			}
			assetBundleFromCache.m_dontUnload = true;
			return true;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00019D64 File Offset: 0x00017F64
		protected ResourceManager.BundleCacheItem GetAssetBundleFromCache(string bundleName)
		{
			ResourceManager.BundleCacheItem result;
			bool flag = this.m_bundleCacheDict.TryGetValue(bundleName, out result);
			if (flag)
			{
				if (this.m_enableDetailResourceManagerLog)
				{
					global::Debug.Log("GetAssetBundleFromCache ok " + bundleName);
				}
			}
			else if (this.m_enableDetailResourceManagerLog)
			{
				global::Debug.Log("GetAssetBundleFromCache null " + bundleName);
			}
			return result;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00019DC4 File Offset: 0x00017FC4
		protected ResourceManager.BundleCacheItem PushAssetBundleToCache(string bundleName, AssetBundle bundle)
		{
			ResourceManager.BundleCacheItem bundleCacheItem;
			if (!this.m_bundleCacheDict.TryGetValue(bundleName, out bundleCacheItem))
			{
				bundleCacheItem = new ResourceManager.BundleCacheItem();
				bundleCacheItem.m_bundleName = bundleName;
				bundleCacheItem.m_bundle = bundle;
				bundleCacheItem.m_hitCount = 0;
				bundleCacheItem.m_lastTouchTime = Timer.m_currTime;
				bundleCacheItem.m_timeOutTime = Timer.m_currTime.AddSeconds((double)ResourceManager.BundleCacheItem.m_firstTimeOut);
				this.m_bundleCacheDict[bundleName] = bundleCacheItem;
			}
			return bundleCacheItem;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00019E30 File Offset: 0x00018030
		protected void OnBundleCacheHit(ResourceManager.BundleCacheItem item)
		{
			if (item.m_hitCount != 0 && item.m_lastTouchTime.AddSeconds((double)ResourceManager.BundleCacheItem.s_validedHitInterval) > Timer.m_currTime)
			{
				return;
			}
			item.m_lastTouchTime = Timer.m_currTime;
			item.m_hitCount++;
			switch (item.m_hitCount)
			{
			case 1:
				item.m_timeOutTime = Timer.m_currTime.AddSeconds((double)ResourceManager.BundleCacheItem.m_firstTimeOut);
				break;
			case 2:
				item.m_timeOutTime = item.m_timeOutTime.AddSeconds((double)(ResourceManager.BundleCacheItem.m_OnHitTimeOutDelay * 2));
				break;
			case 3:
				item.m_timeOutTime = item.m_timeOutTime.AddSeconds((double)(ResourceManager.BundleCacheItem.m_OnHitTimeOutDelay * 4));
				break;
			default:
				item.m_timeOutTime = item.m_timeOutTime.AddSeconds((double)(ResourceManager.BundleCacheItem.m_OnHitTimeOutDelay * 16));
				break;
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00019F18 File Offset: 0x00018118
		protected bool RegBundleLoadingCtx(string bundleName, out ResourceManager.BundleLoadingCtx ctx)
		{
			if (!this.m_bundleLoadingCtxDict.TryGetValue(bundleName, out ctx))
			{
				ctx = new ResourceManager.BundleLoadingCtx();
				ctx.m_bundleName = bundleName;
				ctx.m_ref = 1;
				this.m_bundleLoadingCtxDict[bundleName] = ctx;
				return false;
			}
			ctx.m_ref++;
			return true;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00019F70 File Offset: 0x00018170
		protected void UnregBundleLoadingCtx(ResourceManager.BundleLoadingCtx bundleLoadingCtx)
		{
			bundleLoadingCtx.m_ref--;
			if (bundleLoadingCtx.m_ref <= 0)
			{
				this.m_bundleLoadingCtxDict.Remove(bundleLoadingCtx.m_bundleName);
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00019FA0 File Offset: 0x000181A0
		protected BundleData.SingleBundleData GetBundleDataByAssetPath(string path)
		{
			if (this.m_bundleDataHelper == null)
			{
				return null;
			}
			return this.m_bundleDataHelper.GetBundleDataByAssetPath(path);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00019FBC File Offset: 0x000181BC
		protected BundleData.SingleBundleData GetResaveFileBundleDataByPath(string relativePath)
		{
			if (this.m_bundleDataHelper == null)
			{
				return null;
			}
			return this.m_bundleDataHelper.GetResaveFileBundleDataByPath(relativePath);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00019FD8 File Offset: 0x000181D8
		protected string GetAssetNameByPath(string path)
		{
			return Path.GetFileNameWithoutExtension(path);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00019FE0 File Offset: 0x000181E0
		protected void TickBundle()
		{
			if (this.m_touchedBundleSetDirty)
			{
				this.SaveTouchedBundleSet(false);
			}
			if (this.m_nextTickBundleTime > Timer.m_currTime)
			{
				return;
			}
			this.m_nextTickBundleTime = Timer.m_currTime.AddSeconds(120.0);
			this.UnloadAllUnusedBundles(true);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001A038 File Offset: 0x00018238
		protected bool UnloadAllUnusedBundles(bool onlyTimeOut = false)
		{
			return true;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001A03C File Offset: 0x0001823C
		protected void DealWithResaveFileInBundle(AssetBundle assetBundle, BundleDataHelper bundleHelper)
		{
			BundleData.SingleBundleData bundleDataByName = bundleHelper.GetBundleDataByName(assetBundle.name);
			int num = 0;
			foreach (string name in bundleDataByName.m_assetList)
			{
				ResaveFileSctipableObject resaveFileSctipableObject = assetBundle.LoadAsset<ResaveFileSctipableObject>(name);
				string text = string.Format("{0}/{1}/{2}", Application.persistentDataPath, GameManager.Instance.GameClientSetting.ResourcesSetting.ResaveFileDestDir, resaveFileSctipableObject.m_fileSrcPath);
				text = text.Replace('\\', '/');
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				byte[] bytes = resaveFileSctipableObject.GetBytes();
				File.WriteAllBytes(text, bytes);
				num += bytes.Length;
				Resources.UnloadAsset(resaveFileSctipableObject);
				if (num > 10000000)
				{
					num = 0;
					GC.Collect();
				}
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001A134 File Offset: 0x00018334
		private string ConvertRelativePathFile2OrginalPathFile(string relativePathFile)
		{
			string fileName = Path.GetFileName(relativePathFile);
			string text = fileName.Replace(".asset", string.Empty);
			int startIndex = text.LastIndexOf("_");
			string text2 = text.Remove(startIndex, 1).Insert(startIndex, ".");
			string[] array = text2.Split(new char[]
			{
				'_'
			});
			string text3 = string.Empty;
			foreach (string arg in array)
			{
				text3 = string.Format("{0}/{1}", text3, arg);
			}
			string directoryName = Path.GetDirectoryName(relativePathFile);
			return string.Format("{0}{1}", directoryName.Replace(GameManager.Instance.GameClientSetting.ResourcesSetting.ResaveAssetRoot + "/", string.Empty), text3);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001A20C File Offset: 0x0001840C
		public string GetResaveRuntimePath(string srcDir, string relativePath)
		{
			string text = this.ConvertRelativePathFile2OrginalPathFile(relativePath);
			if (Application.isEditor && !GameManager.Instance.GameClientSetting.ResourcesSetting.LoadAssetFromBundleInEditor)
			{
				return string.Format("{0}/{1}", srcDir, text);
			}
			return string.Format("{0}/{1}/{2}/{3}", new object[]
			{
				Application.persistentDataPath,
				GameManager.Instance.GameClientSetting.ResourcesSetting.ResaveFileDestDir,
				srcDir,
				text
			});
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001A288 File Offset: 0x00018488
		public string TryGetResaveFile(string srcDir, string relativePath)
		{
			string resaveRuntimePath = this.GetResaveRuntimePath(srcDir, relativePath);
			if (File.Exists(resaveRuntimePath))
			{
				return resaveRuntimePath;
			}
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001A2AC File Offset: 0x000184AC
		public IEnumerator DownloadResaveFile(string srcDir, HashSet<string> relativePaths, Action<string, bool> onComplete)
		{
			bool ret = true;
			foreach (string relativePath in relativePaths)
			{
				string path = this.TryGetResaveFile(srcDir, relativePath);
				if (path == null)
				{
					BundleData.SingleBundleData singleBundleData = this.GetResaveFileBundleDataByPath(relativePath);
					if (singleBundleData == null)
					{
						global::Debug.LogError(string.Format("Load Resave BundleData {0} failed", relativePath));
						ret = false;
					}
					else
					{
						AssetBundle bundle = null;
						IEnumerator iter = this.LoadBundle(singleBundleData, false, delegate(AssetBundle lbundle, ResourceManager.BundleCacheItem lcacheItem)
						{
							bundle = lbundle;
						});
						while (iter.MoveNext())
						{
							yield return null;
						}
						if (bundle == null)
						{
							global::Debug.LogError(string.Format("Load Resave Bundle {0} failed", relativePath));
							ret = false;
						}
						else
						{
							this.DealWithResaveFileInBundle(bundle, this.m_bundleDataHelper);
						}
					}
				}
			}
			this.UnloadAllUnusedBundles(false);
			if (onComplete != null)
			{
				onComplete(srcDir, ret);
			}
			yield break;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001A2DC File Offset: 0x000184DC
		public void StartDownloadResaveFile(string srcDir, HashSet<string> relativePaths, Action<string, bool> onComplete)
		{
			this.m_corutineHelper.StartCorutine(this.DownloadResaveFile(srcDir, relativePaths, onComplete));
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001A2F4 File Offset: 0x000184F4
		protected bool LoadTouchedBundleSet()
		{
			string filePersistentPath = Util.GetFilePersistentPath("TouchedBundleSet");
			if (!File.Exists(filePersistentPath))
			{
				this.m_touchedBundleSet = new HashSet<string>();
				this.SaveTouchedBundleSet(true);
				return true;
			}
			try
			{
				System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
				this.m_touchedBundleSet = new HashSet<string>();
				FileStream fileStream;
				FileStream serializationStream = fileStream = File.OpenRead(filePersistentPath);
				try
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					list = (binaryFormatter.Deserialize(serializationStream) as System.Collections.Generic.List<string>);
				}
				finally
				{
					if (fileStream != null)
					{
						((IDisposable)fileStream).Dispose();
					}
				}
				foreach (string item in list)
				{
					this.m_touchedBundleSet.Add(item);
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("LoadTouchedBundleSet failed! error = {0}", ex.Message));
				this.m_touchedBundleSet = new HashSet<string>();
				this.SaveTouchedBundleSet(true);
				return false;
			}
			return true;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001A414 File Offset: 0x00018614
		public void SaveTouchedBundleSet(bool force = false)
		{
			if (this.m_touchedBundleSet == null)
			{
				return;
			}
			if (!force && !this.m_touchedBundleSetDirty)
			{
				return;
			}
			try
			{
				string filePersistentPath = Util.GetFilePersistentPath("TouchedBundleSet");
				System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
				foreach (string item in this.m_touchedBundleSet)
				{
					list.Add(item);
				}
				FileStream fileStream;
				FileStream serializationStream = fileStream = File.Open(filePersistentPath, FileMode.OpenOrCreate, FileAccess.Write);
				try
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.Serialize(serializationStream, list);
				}
				finally
				{
					if (fileStream != null)
					{
						((IDisposable)fileStream).Dispose();
					}
				}
				this.m_touchedBundleSetDirty = false;
			}
			catch (Exception ex)
			{
				global::Debug.LogError(new object[]
				{
					"SaveTouchedBundleSet Error: {0}",
					ex.Message
				});
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001A51C File Offset: 0x0001871C
		public bool AddBundle2TouchedBundleSet(string bundleName, bool checkBundleData = true)
		{
			if (checkBundleData && this.m_bundleDataHelper.GetBundleDataByName(bundleName) == null)
			{
				return false;
			}
			if (this.m_touchedBundleSet.Add(bundleName))
			{
				this.m_touchedBundleSetDirty = true;
				return true;
			}
			return false;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001A554 File Offset: 0x00018754
		public bool IsAssetInTouchedBundleSet(string assetPath)
		{
			BundleData.SingleBundleData bundleDataByAssetPath = this.m_bundleDataHelper.GetBundleDataByAssetPath(assetPath);
			return bundleDataByAssetPath != null && this.m_touchedBundleSet.Contains(bundleDataByAssetPath.m_bundleName);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001A588 File Offset: 0x00018788
		public void StartAssetBundleManifestLoading(Action<bool> onEnd)
		{
			global::Debug.Log("ResourceManager.StartAssetBundleManifestLoading");
			if (this.State != ResourceManager.RMState.AssetBundlePreUpdateEnd && this.State != ResourceManager.RMState.BundleDataLoadEnd)
			{
				global::Debug.LogError("StartAssetBundleManifestLoading in wrong state");
				onEnd(false);
				return;
			}
			this.State = ResourceManager.RMState.AssetBundleManifestLoading;
			if (this.m_disableAssetBundle)
			{
				global::Debug.Log("ResourceManager.StartAssetBundleManifestLoading skip");
				this.State = ResourceManager.RMState.AssetBundleManifestLoadEnd;
				onEnd(true);
				return;
			}
			this.m_eventAssetBundleManifestLoading += onEnd;
			this.m_corutineHelper.StartCorutine(new Func<IEnumerator>(this.AssetBundleManifestLoadingWorker));
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001A614 File Offset: 0x00018814
		[DoNotToLua]
		protected IEnumerator AssetBundleManifestLoadingWorker()
		{
			BundleData.SingleBundleData singleBundleData = this.m_bundleDataHelper.GetBundleDataByName(this.GetAssetBundleManifestBundleName());
			AssetBundle manifestBundle = null;
			IEnumerator lbIter = this.LoadBundleFromWWWOrStreamingImpl(singleBundleData, false, true, delegate(AssetBundle lbundle)
			{
				manifestBundle = lbundle;
			});
			yield return lbIter;
			if (manifestBundle == null)
			{
				this.OnAssetBundleManifestLoadingWorkerEnd(false);
				yield break;
			}
			global::Debug.Log("AssetBundleManifestLoadingWorker download AssetBundleManifest ok");
			AssetBundleManifest[] assets = manifestBundle.LoadAllAssets<AssetBundleManifest>();
			if (assets.Length <= 0)
			{
				global::Debug.LogError("BundleDataLoadingWorker can not find AssetBundleManifest in bundle ");
				this.OnAssetBundleManifestLoadingWorkerEnd(false);
				yield break;
			}
			this.m_assetBundleManifest = assets[0];
			global::Debug.Log("AssetBundleManifestLoadingWorker m_assetBundleManifest load ok");
			manifestBundle.Unload(false);
			this.OnAssetBundleManifestLoadingWorkerEnd(true);
			yield break;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001A630 File Offset: 0x00018830
		protected void OnAssetBundleManifestLoadingWorkerEnd(bool success)
		{
			if (success)
			{
				this.State = ResourceManager.RMState.AssetBundleManifestLoadEnd;
			}
			if (this.m_eventAssetBundleManifestLoading != null)
			{
				this.m_eventAssetBundleManifestLoading(success);
				this.m_eventAssetBundleManifestLoading = null;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001A660 File Offset: 0x00018860
		protected string GetAssetBundleManifestBundleName()
		{
			return Util.GetCurrentTargetPlatform();
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060005F9 RID: 1529 RVA: 0x0001A668 File Offset: 0x00018868
		// (remove) Token: 0x060005FA RID: 1530 RVA: 0x0001A6A0 File Offset: 0x000188A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event Action<bool> m_eventAssetBundleManifestLoading;

		// Token: 0x060005FB RID: 1531 RVA: 0x0001A6D8 File Offset: 0x000188D8
		public void StartAssetBundlePreUpdateing(Action<bool> onEnd)
		{
			global::Debug.Log("ResourceManager.StartBundleDataLoading");
			if (this.State != ResourceManager.RMState.BundleDataLoadEnd)
			{
				global::Debug.LogError("StartAssetBundlePreUpdateing in wrong state");
				onEnd(false);
				return;
			}
			this.State = ResourceManager.RMState.AssetBundlePreUpdateing;
			if (this.m_skipAssetBundlePreUpdateing)
			{
				global::Debug.Log("ResourceManager.StartAssetBundlePreUpdateing skip");
				this.State = ResourceManager.RMState.AssetBundlePreUpdateEnd;
				onEnd(true);
				return;
			}
			int @int = PlayerPrefs.GetInt("PreUpdateVersion4BundleData");
			if (@int == this.m_bundleData.m_version && this.m_lastPreUpdateBundleData == null)
			{
				global::Debug.Log("StartAssetBundlePreUpdateing do not need");
				this.State = ResourceManager.RMState.AssetBundlePreUpdateEnd;
				onEnd(true);
				return;
			}
			this.m_eventOnAssetBundleUpdateingEnd += onEnd;
			this.CalcPreUpdateBundleListByBundleData();
			this.StartAssetBundleUpdateingWorkers(new Action<bool>(this.OnAssetBundlePreUpdateingWorkerEnd), null);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001A7A0 File Offset: 0x000189A0
		protected void StartAssetBundleUpdateingWorkers(Action<bool> onEnd, Action<BundleData.SingleBundleData> onSingleBundleDownloadSuccess = null)
		{
			this.m_isAllUpdateWorkerSuccess = true;
			this.m_assetBundleUpdateingDownloadedByte = 0L;
			for (int i = 0; i < this.m_updateingWorkerCount; i++)
			{
				this.m_updateWorkerAliveCount++;
				this.m_corutineHelper.StartCorutine(this.AssetBundleUpdateingWorker(onEnd, onSingleBundleDownloadSuccess));
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001A7F4 File Offset: 0x000189F4
		protected IEnumerator AssetBundleUpdateingWorker(Action<bool> OnEnd, Action<BundleData.SingleBundleData> onSingleBundleDownloadSuccess = null)
		{
			string url;
			WWW www;
			for (;;)
			{
				BundleData.SingleBundleData singleBundleData = this.GetSingleBundleData4PreUpdate();
				if (singleBundleData == null)
				{
					break;
				}
				url = this.GetDownloadBundleUrl(singleBundleData.m_bundleName);
				global::Debug.Log("AssetBundleUpdateingWorker download start " + url);
				long currDownloadByte = 0L;
				www = WWW.LoadFromCacheOrDownload(url, singleBundleData.m_version, singleBundleData.m_bundleCRC);
				while (!www.isDone && string.IsNullOrEmpty(www.error))
				{
					this.m_assetBundleUpdateingDownloadedByte -= currDownloadByte;
					long wwwBytesDownloaded = (long)((float)singleBundleData.m_size * www.progress);
					this.m_assetBundleUpdateingDownloadedByte += wwwBytesDownloaded;
					currDownloadByte = wwwBytesDownloaded;
					yield return null;
				}
				if (!string.IsNullOrEmpty(www.error))
				{
					goto Block_2;
				}
				if (!www.isDone || www.assetBundle == null)
				{
					goto IL_1AA;
				}
				this.m_assetBundleUpdateingDownloadedByte -= currDownloadByte;
				this.m_assetBundleUpdateingDownloadedByte += singleBundleData.m_size;
				if (singleBundleData.m_isResaveFileBundle)
				{
					this.DealWithResaveFileInBundle(www.assetBundle, this.m_bundleDataHelper);
				}
				www.assetBundle.Unload(true);
				global::Debug.Log("AssetBundleUpdateingWorker download ok " + url);
				if (onSingleBundleDownloadSuccess != null)
				{
					onSingleBundleDownloadSuccess(singleBundleData);
				}
			}
			OnEnd(true);
			yield break;
			Block_2:
			global::Debug.LogError(www.error);
			OnEnd(false);
			yield break;
			IL_1AA:
			global::Debug.LogError("AssetBundleUpdateingWorker download  fail url = " + url);
			OnEnd(false);
			yield break;
			yield break;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0001A820 File Offset: 0x00018A20
		protected void CalcPreUpdateBundleListByBundleData()
		{
			if (this.State < ResourceManager.RMState.BundleDataLoadEnd)
			{
				return;
			}
			if (this.m_skipAssetBundlePreUpdateing)
			{
				return;
			}
			int @int = PlayerPrefs.GetInt("PreUpdateVersion4BundleData");
			if (@int == this.m_bundleData.m_version)
			{
				return;
			}
			if (this.m_updateingBundleList != null)
			{
				return;
			}
			this.m_updateingBundleList = new System.Collections.Generic.List<BundleData.SingleBundleData>();
			foreach (BundleData.SingleBundleData singleBundleData in this.m_bundleData.m_bundleList)
			{
				if (this.m_touchedBundleSet.Contains(singleBundleData.m_bundleName))
				{
					BundleData.SingleBundleData singleBundleData2 = null;
					BundleData.SingleBundleData singleBundleData3 = null;
					bool flag = false;
					if (this.m_lastPreUpdateBundleData != null)
					{
						foreach (BundleData.SingleBundleData singleBundleData4 in this.m_lastPreUpdateBundleData.m_bundleList)
						{
							if (singleBundleData4.m_bundleName == singleBundleData.m_bundleName)
							{
								singleBundleData2 = singleBundleData4;
								break;
							}
						}
					}
					if (this.m_streamingAssetsBundleData != null)
					{
						foreach (BundleData.SingleBundleData singleBundleData5 in this.m_streamingAssetsBundleData.m_bundleList)
						{
							if (singleBundleData5.m_bundleName == singleBundleData.m_bundleName)
							{
								singleBundleData3 = ((!singleBundleData5.m_isInStreamingAssets) ? null : singleBundleData5);
								break;
							}
						}
					}
					BundleData.SingleBundleData singleBundleData6;
					if (singleBundleData2 == null || singleBundleData3 == null)
					{
						singleBundleData6 = ((singleBundleData2 != null) ? singleBundleData2 : singleBundleData3);
						if (singleBundleData3 != null)
						{
							flag = this.m_streamingAssetsMissingBundles.Contains(singleBundleData3);
						}
					}
					else
					{
						singleBundleData6 = ((singleBundleData2.m_version <= singleBundleData3.m_version) ? singleBundleData3 : singleBundleData2);
						if (singleBundleData3.m_version > singleBundleData2.m_version)
						{
							flag = this.m_streamingAssetsMissingBundles.Contains(singleBundleData3);
						}
					}
					if (singleBundleData6 == null || singleBundleData6.m_version != singleBundleData.m_version || flag)
					{
						this.m_updateingBundleList.Add(singleBundleData);
					}
				}
			}
			this.m_assetBundleUpdateingTotalByte = 0L;
			foreach (BundleData.SingleBundleData singleBundleData7 in this.m_updateingBundleList)
			{
				this.m_assetBundleUpdateingTotalByte += singleBundleData7.m_size;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001AB2C File Offset: 0x00018D2C
		protected BundleData.SingleBundleData GetSingleBundleData4PreUpdate()
		{
			if (this.m_updateingBundleList.Count == 0)
			{
				return null;
			}
			BundleData.SingleBundleData singleBundleData = this.m_updateingBundleList[0];
			this.m_updateingBundleList.Remove(singleBundleData);
			return singleBundleData;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001AB68 File Offset: 0x00018D68
		protected void OnAssetBundlePreUpdateingWorkerEnd(bool success)
		{
			this.m_updateWorkerAliveCount--;
			if (!success)
			{
				this.m_isAllUpdateWorkerSuccess = false;
			}
			if (this.m_updateWorkerAliveCount == 0)
			{
				if (this.m_isAllUpdateWorkerSuccess)
				{
					this.State = ResourceManager.RMState.AssetBundlePreUpdateEnd;
				}
				if (this.m_isAllUpdateWorkerSuccess)
				{
					PlayerPrefs.SetInt("PreUpdateVersion4BundleData", this.m_bundleData.m_version);
					PlayerPrefs.Save();
					global::Debug.Log(string.Format("Set PlayerPrefs {0}={1}", "PreUpdateVersion4BundleData", this.m_bundleData.m_version));
				}
				if (this.m_eventOnAssetBundleUpdateingEnd != null)
				{
					this.m_eventOnAssetBundleUpdateingEnd(this.m_isAllUpdateWorkerSuccess);
					this.m_eventOnAssetBundleUpdateingEnd = null;
				}
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001AC1C File Offset: 0x00018E1C
		public float GetAssetBundleUpdateingPercent()
		{
			if (this.m_assetBundleUpdateingTotalByte == 0L)
			{
				return 0f;
			}
			return (float)this.m_assetBundleUpdateingDownloadedByte / (float)this.m_assetBundleUpdateingTotalByte;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001AC40 File Offset: 0x00018E40
		public long GetPreUpdateingDownloadedBytes()
		{
			return this.m_assetBundleUpdateingDownloadedByte;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001AC48 File Offset: 0x00018E48
		public long GetTotalPreUpdateingDownloadBytes()
		{
			this.CalcPreUpdateBundleListByBundleData();
			return this.m_assetBundleUpdateingTotalByte;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001AC58 File Offset: 0x00018E58
		public void StartDownloadUntouchedAssets(HashSet<string> assets, Action<bool> OnEnd)
		{
			if (this.m_updateWorkerAliveCount != 0)
			{
				global::Debug.LogError("Still loading.Cannot Start download untouch asset!");
				OnEnd(false);
				return;
			}
			if (this.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("Resource Manager not ready.Cannot Start download untouch asset!");
				OnEnd(false);
				return;
			}
			HashSet<BundleData.SingleBundleData> hashSet = new HashSet<BundleData.SingleBundleData>();
			foreach (string text in assets)
			{
				BundleData.SingleBundleData bundleDataByAssetPath = this.GetBundleDataByAssetPath(text);
				if (bundleDataByAssetPath == null)
				{
					global::Debug.LogError(string.Format("Load Untouched BundleData {0} failed", text));
				}
				else if (!this.m_touchedBundleSet.Contains(bundleDataByAssetPath.m_bundleName))
				{
					hashSet.Add(bundleDataByAssetPath);
				}
			}
			if (hashSet.Count == 0)
			{
				OnEnd(true);
			}
			this.m_updateingBundleList.AddRange(hashSet);
			this.m_assetBundleUpdateingTotalByte = 0L;
			foreach (BundleData.SingleBundleData singleBundleData2 in this.m_updateingBundleList)
			{
				this.m_assetBundleUpdateingTotalByte += singleBundleData2.m_size;
			}
			this.m_eventOnAssetBundleUpdateingEnd += OnEnd;
			this.StartAssetBundleUpdateingWorkers(new Action<bool>(this.OnUntouchedAssetBundleUpdateingWorkerEnd), delegate(BundleData.SingleBundleData singleBundleData)
			{
				this.AddBundle2TouchedBundleSet(singleBundleData.m_bundleName, true);
			});
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		protected void OnUntouchedAssetBundleUpdateingWorkerEnd(bool success)
		{
			this.m_updateWorkerAliveCount--;
			if (!success)
			{
				this.m_isAllUpdateWorkerSuccess = false;
			}
			if (this.m_updateWorkerAliveCount == 0 && this.m_eventOnAssetBundleUpdateingEnd != null)
			{
				this.m_eventOnAssetBundleUpdateingEnd(this.m_isAllUpdateWorkerSuccess);
				this.m_eventOnAssetBundleUpdateingEnd = null;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0001AE30 File Offset: 0x00019030
		public long GetTotalUntouchedAssetBundleDownloadBytes()
		{
			return this.m_assetBundleUpdateingTotalByte;
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000607 RID: 1543 RVA: 0x0001AE38 File Offset: 0x00019038
		// (remove) Token: 0x06000608 RID: 1544 RVA: 0x0001AE70 File Offset: 0x00019070
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event Action<bool> m_eventOnAssetBundleUpdateingEnd;

		// Token: 0x06000609 RID: 1545 RVA: 0x0001AEA8 File Offset: 0x000190A8
		public void StartBundleDataLoading(Action<bool> onEnd)
		{
			global::Debug.Log("ResourceManager.StartBundleDataLoading");
			if (this.State != ResourceManager.RMState.StreamingAssetsFilesProcessEnd)
			{
				global::Debug.LogError("StartBundleDataLoading in wrong state");
				onEnd(false);
				return;
			}
			this.State = ResourceManager.RMState.BundleDataLoading;
			if (this.m_disableAssetBundle)
			{
				global::Debug.Log("ResourceManager.StartBundleDataLoading skip");
				this.State = ResourceManager.RMState.BundleDataLoadEnd;
				onEnd(true);
				return;
			}
			this.EventOnBundleDataLoadingEnd += onEnd;
			this.m_corutineHelper.StartCorutine(new Func<IEnumerator>(this.BundleDataLoadingWorker));
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001AF28 File Offset: 0x00019128
		private IEnumerator BundleDataLoadingWorker()
		{
			uint urlBundleDataCRC = 0u;
			int lastPreUpdateBundleDataVersion = PlayerPrefs.GetInt("PreUpdateVersion4BundleData");
			int streamingAssetsBundleDataVersion = this.m_streamingAssetsBundleData.m_version;
			this.m_currBundleDataVersion = PlayerPrefs.GetInt("BundleDataVersion");
			this.m_currBundleDataVersion = ((this.m_currBundleDataVersion != 0) ? this.m_currBundleDataVersion : streamingAssetsBundleDataVersion);
			if (this.m_disableAssetBundleDownload)
			{
				int bundleDataVersion4Loading = this.m_currBundleDataVersion;
				bundleDataVersion4Loading = ((bundleDataVersion4Loading <= streamingAssetsBundleDataVersion) ? streamingAssetsBundleDataVersion : bundleDataVersion4Loading);
				bundleDataVersion4Loading = ((bundleDataVersion4Loading <= lastPreUpdateBundleDataVersion) ? lastPreUpdateBundleDataVersion : bundleDataVersion4Loading);
				this.m_bundleData = this.m_streamingAssetsBundleData;
				global::Debug.Log(string.Format("ResourceManager.StartBundleDataLoading download skip load from streamingassets url bundleDataVersion4Loading = m_currBundleDataVersion = {0}", bundleDataVersion4Loading));
			}
			else
			{
				int urlBundleDataVersion = 0;
				bool checkComplete = false;
				IEnumerator iter = this.CheckBundleDataVersionFromUrl(delegate(bool lret, int lversion, uint crc, bool lCheckRet)
				{
					checkComplete = lret;
					urlBundleDataVersion = lversion;
					urlBundleDataCRC = crc;
				});
				while (iter.MoveNext())
				{
					yield return null;
				}
				if (!checkComplete)
				{
					this.OnBundleDataLoadingWorkerEnd(false);
				}
				if (urlBundleDataVersion == this.m_currBundleDataVersion)
				{
					global::Debug.Log("BundleDataLoadingWorker urlBundleDataVersion = m_currBundleDataVersion = " + this.m_currBundleDataVersion.ToString());
				}
				int bundleDataVersion4Loading = urlBundleDataVersion;
				string bundleDataBundleUrl = this.GetDownloadBundleUrl(PathHelper.BundleDataBundleName);
				AssetBundle assetBundle;
				if (lastPreUpdateBundleDataVersion != 0 && lastPreUpdateBundleDataVersion != bundleDataVersion4Loading)
				{
					global::Debug.Log(string.Format("BundleDataLoadingWorker LoadFromCacheOrDownload for m_oldBundleData {0} {1}", bundleDataBundleUrl, lastPreUpdateBundleDataVersion));
					AssetBundle assetBundle = null;
					IEnumerator iter2 = this.LoadBundleFromCacheOrDownload(bundleDataBundleUrl, lastPreUpdateBundleDataVersion, 0u, delegate(AssetBundle lbundle)
					{
						assetBundle = lbundle;
					});
					yield return iter2;
					if (assetBundle == null)
					{
						global::Debug.LogError("BundleDataLoadingWorker download old BundleDataBundle  fail url = " + bundleDataBundleUrl);
						this.OnBundleDataLoadingWorkerEnd(false);
						yield break;
					}
					global::Debug.Log("BundleDataLoadingWorker download m_lastPreUpdateBundleData bundle ok");
					this.m_lastPreUpdateBundleData = assetBundle.LoadAsset<BundleData>(PathHelper.BundleDataAssetName);
					if (this.m_lastPreUpdateBundleData == null)
					{
						global::Debug.LogError(string.Format("BundleDataLoadingWorker LoadAsset for old m_bundleData fail: {0}", PathHelper.BundleDataAssetName));
						this.OnBundleDataLoadingWorkerEnd(false);
						yield break;
					}
					global::Debug.Log(string.Format("BundleDataLoadingWorker load m_lastPreUpdateBundleData from {0} ok, Ver={1}.", PathHelper.BundleDataAssetName, this.m_lastPreUpdateBundleData.m_version));
					assetBundle.Unload(false);
					if (this.m_lastPreUpdateBundleData.m_version != lastPreUpdateBundleDataVersion)
					{
						this.m_lastPreUpdateBundleData = null;
					}
				}
				global::Debug.Log(string.Format("BundleDataLoadingWorker LoadFromCacheOrDownload for new m_bundleData {0} {1}", bundleDataBundleUrl, bundleDataVersion4Loading));
				assetBundle = null;
				IEnumerator iter3 = this.LoadBundleFromCacheOrDownload(bundleDataBundleUrl, bundleDataVersion4Loading, urlBundleDataCRC, delegate(AssetBundle lbundle)
				{
					assetBundle = lbundle;
				});
				yield return iter3;
				if (assetBundle == null)
				{
					global::Debug.LogError("BundleDataLoadingWorker download newest BundleDataBundle  fail url = " + bundleDataBundleUrl);
					this.OnBundleDataLoadingWorkerEnd(false);
					yield break;
				}
				global::Debug.Log("BundleDataLoadingWorker download newest BundleDataBundle ok");
				this.m_bundleData = assetBundle.LoadAsset<BundleData>(PathHelper.BundleDataAssetName);
				if (this.m_bundleData == null)
				{
					global::Debug.LogError("BundleDataLoadingWorker LoadAsset for m_bundleData fail");
					this.OnBundleDataLoadingWorkerEnd(false);
					yield break;
				}
				global::Debug.Log("BundleDataLoadingWorker load m_bundleData ok");
				assetBundle.Unload(false);
			}
			this.m_currBundleDataVersion = this.m_bundleData.m_version;
			PlayerPrefs.SetInt("BundleDataVersion", this.m_bundleData.m_version);
			PlayerPrefs.Save();
			global::Debug.Log(string.Format("Set PlayerPrefs {0}={1}", "BundleDataVersion", this.m_bundleData.m_version));
			this.m_bundleDataHelper = new BundleDataHelper(this.m_bundleData, this.m_assetPathIgnoreCase);
			this.OnBundleDataLoadingWorkerEnd(true);
			yield break;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001AF44 File Offset: 0x00019144
		public IEnumerator CheckBundleDataVersionFromUrl(Action<bool, int, uint, bool> onEnd)
		{
			if (this.m_disableAssetBundle || this.m_disableAssetBundleDownload)
			{
				onEnd(true, 0, 0u, true);
				yield break;
			}
			int streamingAssetsBundleDataVersion = this.m_streamingAssetsBundleData.m_version;
			string bundleDataVersionUrl = this.GetDownloadBundleUrl(PathHelper.BundleDataVersionFileName);
			global::Debug.Log("CheckBundleDataVersionFromUrl start download BundleDataVersion url = " + bundleDataVersionUrl);
			WWW wwwBundleDataVersion = new WWW(bundleDataVersionUrl);
			while (!wwwBundleDataVersion.isDone && string.IsNullOrEmpty(wwwBundleDataVersion.error))
			{
				yield return null;
			}
			if (!string.IsNullOrEmpty(wwwBundleDataVersion.error))
			{
				global::Debug.LogError(string.Format("ResourceManager.CheckBundleDataVersionFromUrl download {0} error {1}", bundleDataVersionUrl, wwwBundleDataVersion.error));
				onEnd(false, 0, 0u, false);
				yield break;
			}
			if (!wwwBundleDataVersion.isDone || string.IsNullOrEmpty(wwwBundleDataVersion.text))
			{
				global::Debug.LogError("CheckBundleDataVersionFromUrl download BundleDataVersion  fail url = " + bundleDataVersionUrl);
				onEnd(false, 0, 0u, false);
				yield break;
			}
			string[] strVals = wwwBundleDataVersion.text.Split(new char[]
			{
				','
			});
			int urlBundleDataVersion = int.Parse((strVals.Length <= 0) ? string.Empty : strVals[0]);
			uint urlBundleDataCRC = uint.Parse((strVals.Length <= 1) ? string.Empty : strVals[1]);
			global::Debug.Log(string.Format("CheckBundleDataVersionFromUrl BundleDataVersion: New = {0}; Last = {1}, Install ={2}, NewCRC = {3}", new object[]
			{
				urlBundleDataVersion,
				this.m_currBundleDataVersion,
				streamingAssetsBundleDataVersion,
				urlBundleDataCRC
			}));
			onEnd(true, urlBundleDataVersion, urlBundleDataCRC, urlBundleDataVersion == this.m_currBundleDataVersion);
			yield break;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001AF68 File Offset: 0x00019168
		private void OnBundleDataLoadingWorkerEnd(bool success)
		{
			global::Debug.Log("ResourceManager.OnBundleDataLoadingWorkerEnd");
			if (success)
			{
				this.State = ResourceManager.RMState.BundleDataLoadEnd;
				foreach (BundleData.SingleBundleData singleBundleData in this.m_bundleData.m_bundleList)
				{
					if (singleBundleData.m_isNeedPreUpdateByDefault)
					{
						this.AddBundle2TouchedBundleSet(singleBundleData.m_bundleName, true);
					}
				}
			}
			if (this.EventOnBundleDataLoadingEnd != null)
			{
				this.EventOnBundleDataLoadingEnd(success);
				this.EventOnBundleDataLoadingEnd = null;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001B010 File Offset: 0x00019210
		public int GetBundleDataBasicVersion()
		{
			if (this.m_bundleData != null)
			{
				return this.m_bundleData.m_basicVersion;
			}
			return 0;
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600060E RID: 1550 RVA: 0x0001B030 File Offset: 0x00019230
		// (remove) Token: 0x0600060F RID: 1551 RVA: 0x0001B068 File Offset: 0x00019268
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event Action<bool> EventOnBundleDataLoadingEnd;

		// Token: 0x06000610 RID: 1552 RVA: 0x0001B0A0 File Offset: 0x000192A0
		public void CheckBundleCache()
		{
			if (!this.IsBundleCacheSignalFileExist())
			{
				this.ClearForCacheLost();
				this.CreateBundleCacheSignalFile();
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001B0BC File Offset: 0x000192BC
		private bool IsBundleCacheSignalFileExist()
		{
			string text = string.Format("{0}/{1}", Application.persistentDataPath, "dontmove.tmp");
			text = text.Replace('\\', '/');
			return File.Exists(text);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001B0F8 File Offset: 0x000192F8
		private void CreateBundleCacheSignalFile()
		{
			string text = string.Format("{0}/{1}", Application.persistentDataPath, "dontmove.tmp");
			text = text.Replace('\\', '/');
			string directoryName = Path.GetDirectoryName(text);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			byte[] bytes = new byte[]
			{
				0,
				1
			};
			File.WriteAllBytes(text, bytes);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001B150 File Offset: 0x00019350
		private void ClearForCacheLost()
		{
			PlayerPrefs.SetInt("StreamingAssetsFileListVersion", 0);
			PlayerPrefs.SetInt("BundleDataVersion", 0);
			PlayerPrefs.SetInt("PreUpdateVersion4BundleData", 0);
			PlayerPrefs.Save();
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001B178 File Offset: 0x00019378
		public IEnumerator ReserveAsset(string path, Action<string, UnityEngine.Object> onCompleted, bool noErrlog = false, int reserveTime = 0)
		{
			this.m_loadingOpCount++;
			string path2 = path;
			ResourceManager.ReserveItem reserveItem;
			IEnumerator iter = this.LoadAsset<UnityEngine.Object>(path2, delegate(string lpath, UnityEngine.Object lasset)
			{
				reserveItem = this.AddAsset2Reserve(path, reserveTime, lasset);
				if (this.EventOnAssetLoaded != null)
				{
					this.EventOnAssetLoaded();
				}
			}, noErrlog, false);
			while (iter.MoveNext())
			{
				yield return null;
			}
			this.m_loadingOpCount--;
			yield break;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001B1AC File Offset: 0x000193AC
		public void StartReserveAssetsCorutine(HashSet<string> pathList, IDictionary<string, UnityEngine.Object> assetDict, Action onComplete, bool loadAsync = false, int reserveTime = 0)
		{
			IDictionary<string, UnityEngine.Object> assetDict2 = assetDict;
			this.StartLoadAssetsCorutine(pathList, assetDict2, delegate
			{
				foreach (KeyValuePair<string, UnityEngine.Object> keyValuePair in assetDict)
				{
					this.AddAsset2Reserve(keyValuePair.Key, reserveTime, keyValuePair.Value);
				}
				if (onComplete != null)
				{
					onComplete();
				}
			}, loadAsync);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001B200 File Offset: 0x00019400
		private ResourceManager.ReserveItem AddAsset2Reserve(string path, int reserveTime, UnityEngine.Object asset)
		{
			ResourceManager.ReserveItem reserveItem;
			if (this.m_assetReserveDict.TryGetValue(path, out reserveItem))
			{
				this.SetupReserveTimeOut(reserveItem, reserveTime);
			}
			else
			{
				reserveItem = new ResourceManager.ReserveItem();
				reserveItem.m_asset = asset;
				this.SetupReserveTimeOut(reserveItem, reserveTime);
				this.m_assetReserveDict[path] = reserveItem;
			}
			if (reserveItem.m_timeOut == DateTime.MinValue)
			{
				ResourceManager.AssetCacheItem assetCacheItem;
				bool flag = this.m_assetsCacheDict.TryGetValue(path, out assetCacheItem);
				if (flag)
				{
					assetCacheItem.m_removeReserveOnHit = true;
				}
			}
			return reserveItem;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001B284 File Offset: 0x00019484
		private void SetupReserveTimeOut(ResourceManager.ReserveItem reserveItem, int ReserveTime)
		{
			if (ReserveTime != 0)
			{
				DateTime dateTime = DateTime.Now.AddSeconds((double)ReserveTime);
				reserveItem.m_timeOut = ((!(reserveItem.m_timeOut < dateTime)) ? reserveItem.m_timeOut : dateTime);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001B2CC File Offset: 0x000194CC
		protected void RemoveReserve(string path)
		{
			this.m_assetReserveDict.Remove(path);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001B2DC File Offset: 0x000194DC
		private void RemoveReserve4CacheHit(string path)
		{
			ResourceManager.ReserveItem reserveItem;
			if (this.m_assetReserveDict.TryGetValue(path, out reserveItem) && reserveItem.m_timeOut == DateTime.MinValue)
			{
				this.RemoveReserve(path);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001B318 File Offset: 0x00019518
		protected void ClearAllReserve(HashSet<string> keepReserve = null)
		{
			if (keepReserve != null)
			{
				foreach (string key in keepReserve)
				{
					ResourceManager.ReserveItem reserveItem;
					if (this.m_assetReserveDict.TryGetValue(key, out reserveItem))
					{
						this.m_assetReserveDict4Keep.Add(key, reserveItem);
					}
					else
					{
						UnityEngine.Object assetFromCache = this.GetAssetFromCache(key);
						if (assetFromCache != null)
						{
							reserveItem = new ResourceManager.ReserveItem();
							reserveItem.m_asset = assetFromCache;
							this.m_assetReserveDict4Keep.Add(key, reserveItem);
						}
					}
				}
				this.m_assetReserveDict.Clear();
				this.m_assetReserveDict.Merge(this.m_assetReserveDict4Keep);
				this.m_assetReserveDict4Keep.Clear();
			}
			else
			{
				this.m_assetReserveDict.Clear();
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001B3F8 File Offset: 0x000195F8
		protected void TickReserve()
		{
			DateTime currTime = Timer.m_currTime;
			if (this.m_reserveTickDelayOutTime < currTime)
			{
				this.m_reserveTickDelayOutTime = currTime.AddSeconds(5.0);
				foreach (KeyValuePair<string, ResourceManager.ReserveItem> keyValuePair in this.m_assetReserveDict)
				{
					if (keyValuePair.Value.m_timeOut != DateTime.MinValue && keyValuePair.Value.m_timeOut < currTime)
					{
						this.m_assetReserve4Remove.Add(keyValuePair.Key);
					}
				}
				if (this.m_assetReserve4Remove.Count != 0)
				{
					foreach (string path in this.m_assetReserve4Remove)
					{
						this.RemoveReserve(path);
					}
					this.m_assetReserve4Remove.Clear();
				}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001B528 File Offset: 0x00019728
		public void StartStreamingAssetsFilesProcessing(Action<bool> onEnd)
		{
			global::Debug.Log("ResourceManager.StartStreamingAssetsFilesProcessing");
			if (this.State != ResourceManager.RMState.Inited)
			{
				global::Debug.LogError("StartProcessStreamingAssetsFiles in wrong state");
				onEnd(false);
				return;
			}
			this.State = ResourceManager.RMState.StreamingAssetsFilesProcessing;
			if (this.m_skipStreamingAssetsFileProcessing)
			{
				global::Debug.Log("ResourceManager.StartStreamingAssetsFilesProcessing skip processing");
				this.State = ResourceManager.RMState.StreamingAssetsFilesProcessEnd;
				onEnd(true);
				return;
			}
			int @int = PlayerPrefs.GetInt("StreamingAssetsFileListVersion");
			this.m_streamingAssetsBundleData = Resources.Load<BundleData>(PathHelper.StreamAssetBundleDataResourcesPath);
			if (this.m_streamingAssetsBundleData == null)
			{
				global::Debug.LogError("Load streamingAssetsBundleData fail");
				onEnd(false);
				return;
			}
			this.m_streamingAssetsBundleDataHelper = new BundleDataHelper(this.m_streamingAssetsBundleData, this.m_assetPathIgnoreCase);
			global::Debug.Log(string.Format("ResourceManager.StartStreamingAssetsFilesProcessing m_streamingAssetsBundleData.version = {0}", this.m_streamingAssetsBundleData.m_version));
			this.m_streamingAssetsFileList = Resources.Load<StreamingAssetsFileList>(PathHelper.StreamingAssetsFileListResourcesName);
			if (this.m_streamingAssetsFileList == null)
			{
				global::Debug.LogError("Load StreamingAssetsFileList fail");
				onEnd(false);
				return;
			}
			global::Debug.Log(string.Format("ResourceManager.StartStreamingAssetsFilesProcessing StreamingAssetsFileList: curVer = {0}, oldVer = {1}", this.m_streamingAssetsFileList.m_version, @int));
			using (System.Collections.Generic.List<BundleData.SingleBundleData>.Enumerator enumerator = this.m_streamingAssetsBundleData.m_bundleList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BundleData.SingleBundleData singleBundleData = enumerator.Current;
					if (singleBundleData.m_isInStreamingAssets)
					{
						if (this.m_streamingAssetsFileList.m_fileList.Find((StreamingAssetsFileList.ListItem item) => item.m_bundleName == singleBundleData.m_bundleName) == null)
						{
							this.m_streamingAssetsMissingBundles.Add(singleBundleData);
						}
					}
				}
			}
			if (this.m_streamingAssetsFileList.m_version <= @int)
			{
				this.m_currStreamingAssetsFileListVersion = @int;
				this.State = ResourceManager.RMState.StreamingAssetsFilesProcessEnd;
				global::Debug.LogWarning("ResourceManager.StartStreamingAssetsFilesProcessing m_streamingAssetsFileList.m_version <= oldVersion, may skip processing");
				onEnd(true);
				return;
			}
			this.m_currStreamingAssetsFileListVersion = this.m_streamingAssetsFileList.m_version;
			this.m_eventOnStreamingAssetsFilesProcessingEnd += onEnd;
			this.m_corutineHelper.StartCorutine(new Func<IEnumerator>(this.StreamingAssetsFileProcessor));
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0001B754 File Offset: 0x00019954
		private IEnumerator StreamingAssetsFileProcessor()
		{
			bool ret = true;
			IEnumerator iter = this.DealWithResaveFileInBundleAfterStreamingAssetProcessing();
			yield return iter;
			this.OnStreamingAssetsFileProcessorEnd(ret);
			yield break;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0001B770 File Offset: 0x00019970
		private IEnumerator DealWithResaveFileInBundleAfterStreamingAssetProcessing()
		{
			foreach (StreamingAssetsFileList.ListItem fileItem in this.m_streamingAssetsFileList.m_fileList)
			{
				if (!(fileItem.m_bundleName == PathHelper.BundleDataBundleName))
				{
					if (fileItem.m_filePath.IndexOf(PathHelper.StreamingAssetsBundlePathDirName) != -1)
					{
						BundleData.SingleBundleData singleBundleData = this.m_streamingAssetsBundleDataHelper.GetBundleDataByName(fileItem.m_bundleName);
						if (singleBundleData == null)
						{
							UnityEngine.Debug.LogError(string.Format("singleBundleData is null, bundleName = {0}", fileItem.m_bundleName));
						}
						if (singleBundleData.m_isResaveFileBundle)
						{
							AssetBundle assetBundle = null;
							string srcPath = this.GetStreamingAssetBundlePath(fileItem.m_bundleName);
							AssetBundleCreateRequest req = AssetBundle.LoadFromFileAsync(srcPath);
							while (!req.isDone)
							{
								yield return null;
							}
							assetBundle = req.assetBundle;
							if (assetBundle == null)
							{
								global::Debug.LogError(new object[]
								{
									"Cannot Load Resave Bundle File:{0}",
									srcPath
								});
							}
							else
							{
								this.DealWithResaveFileInBundle(assetBundle, this.m_streamingAssetsBundleDataHelper);
								assetBundle.Unload(false);
							}
						}
					}
				}
			}
			yield break;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001B78C File Offset: 0x0001998C
		private void OnStreamingAssetsFileProcessorEnd(bool success)
		{
			global::Debug.Log("ResourceManager.OnStreamingAssetsFileProcessorEnd");
			if (success)
			{
				this.State = ResourceManager.RMState.StreamingAssetsFilesProcessEnd;
				PlayerPrefs.SetInt("StreamingAssetsFileListVersion", this.m_currStreamingAssetsFileListVersion);
				PlayerPrefs.Save();
			}
			this.SaveTouchedBundleSet(false);
			if (this.m_eventOnStreamingAssetsFilesProcessingEnd != null)
			{
				this.m_eventOnStreamingAssetsFilesProcessingEnd(success);
				this.m_eventOnStreamingAssetsFilesProcessingEnd = null;
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000620 RID: 1568 RVA: 0x0001B7EC File Offset: 0x000199EC
		// (remove) Token: 0x06000621 RID: 1569 RVA: 0x0001B824 File Offset: 0x00019A24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event Action<bool> m_eventOnStreamingAssetsFilesProcessingEnd;

		// Token: 0x06000622 RID: 1570 RVA: 0x0001B85C File Offset: 0x00019A5C
		public IEnumerator LoadUnityScene(string path, Action<string, Scene?> onCompleted, bool noErrlog = false, bool loadAync = false)
		{
			global::Debug.Log(string.Format("LoadUnityScene {0}", path));
			if (Application.isEditor)
			{
				this.m_loadedAssetPathSet.Add(path);
			}
			this.m_loadingOpCount++;
			string sceneName = Path.GetFileNameWithoutExtension(path);
			if (this.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("LoadUnityScene but  State != RMState.Ready");
				onCompleted(path, null);
				yield break;
			}
			bool ret = false;
			if (!Application.isEditor || this.m_loadAssetFromBundleInEditor)
			{
				IEnumerator iter = this.LoadBundle4UnityScene(path, delegate(string lpath, ResourceManager.BundleCacheItem bundleCacheItem)
				{
					ret = (bundleCacheItem != null);
				}, noErrlog, loadAync);
				while (iter.MoveNext())
				{
					yield return null;
				}
				if (!ret)
				{
					onCompleted(path, null);
					yield break;
				}
				AsyncOperation asyncOp = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
				while (!asyncOp.isDone)
				{
					yield return null;
				}
			}
			Scene scene = SceneManager.GetSceneByName(sceneName);
			if (!scene.IsValid() || scene.isLoaded)
			{
			}
			this.m_loadingOpCount--;
			onCompleted(path, new Scene?(scene));
			yield break;
		}

		// Token: 0x04000300 RID: 768
		protected static ResourceManager m_instance;

		// Token: 0x04000302 RID: 770
		protected TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x04000303 RID: 771
		protected bool m_needGC;

		// Token: 0x04000304 RID: 772
		protected int m_unloadUnusedAssetTimeInterval;

		// Token: 0x04000305 RID: 773
		protected DateTime m_nextUnloadUnusedAssetTime;

		// Token: 0x04000306 RID: 774
		protected DateTime m_nextCheckMemUseageTime;

		// Token: 0x04000307 RID: 775
		protected bool m_assetPathIgnoreCase;

		// Token: 0x04000308 RID: 776
		protected bool m_enableDetailResourceManagerLog;

		// Token: 0x04000309 RID: 777
		protected AsyncOperation m_currUnloadUnusedAssetsOperation;

		// Token: 0x0400030A RID: 778
		protected bool m_disableAssetBundle;

		// Token: 0x0400030B RID: 779
		protected bool m_loadAssetFromBundleInEditor;

		// Token: 0x0400030C RID: 780
		protected Dictionary<string, ResourceManager.AssetCacheItem> m_assetsCacheDict = new Dictionary<string, ResourceManager.AssetCacheItem>();

		// Token: 0x0400030D RID: 781
		protected System.Collections.Generic.List<ResourceManager.AssetCacheItem> m_assetsCacheToRemove = new System.Collections.Generic.List<ResourceManager.AssetCacheItem>();

		// Token: 0x0400030E RID: 782
		protected string m_bundleDownloadUrlRoot;

		// Token: 0x0400030F RID: 783
		protected string m_downloadUrlRootWithPlatform;

		// Token: 0x04000310 RID: 784
		protected string m_downloadBundleUrlPrefix;

		// Token: 0x04000311 RID: 785
		protected bool m_needUnloadAllUnusedBundles;

		// Token: 0x04000313 RID: 787
		protected bool m_needUnloadUnusedAssets;

		// Token: 0x04000314 RID: 788
		protected int m_loadingOpCount;

		// Token: 0x04000315 RID: 789
		protected HashSet<string> m_loadedAssetPathSet = new HashSet<string>();

		// Token: 0x04000316 RID: 790
		protected const string m_streamingAssetsFileListVersionKey = "StreamingAssetsFileListVersion";

		// Token: 0x04000317 RID: 791
		protected const string m_bundleDataVersionKey = "BundleDataVersion";

		// Token: 0x04000318 RID: 792
		protected const string m_preUpdateVersion4BundleDataKey = "PreUpdateVersion4BundleData";

		// Token: 0x04000319 RID: 793
		protected const string m_touchedBundleSetFileName = "TouchedBundleSet";

		// Token: 0x0400031A RID: 794
		public HashSet<string> m_loadFilePaths = new HashSet<string>();

		// Token: 0x0400031B RID: 795
		private Stopwatch _stopWatch = new Stopwatch();

		// Token: 0x0400031C RID: 796
		public float m_loadingProgress;

		// Token: 0x0400031D RID: 797
		protected BundleData m_bundleData;

		// Token: 0x0400031E RID: 798
		protected BundleDataHelper m_bundleDataHelper;

		// Token: 0x0400031F RID: 799
		protected AssetBundleManifest m_assetBundleManifest;

		// Token: 0x04000320 RID: 800
		protected DateTime m_nextTickBundleTime = DateTime.Now.AddSeconds(120.0);

		// Token: 0x04000321 RID: 801
		protected Dictionary<string, ResourceManager.BundleCacheItem> m_bundleCacheDict = new Dictionary<string, ResourceManager.BundleCacheItem>();

		// Token: 0x04000322 RID: 802
		protected System.Collections.Generic.List<ResourceManager.BundleCacheItem> m_bundleCachetoUnload = new System.Collections.Generic.List<ResourceManager.BundleCacheItem>();

		// Token: 0x04000323 RID: 803
		protected Dictionary<string, ResourceManager.BundleLoadingCtx> m_bundleLoadingCtxDict = new Dictionary<string, ResourceManager.BundleLoadingCtx>();

		// Token: 0x04000324 RID: 804
		protected HashSet<string> m_touchedBundleSet;

		// Token: 0x04000325 RID: 805
		protected bool m_touchedBundleSetDirty;

		// Token: 0x04000327 RID: 807
		protected bool m_skipAssetBundlePreUpdateing;

		// Token: 0x04000328 RID: 808
		protected int m_updateingWorkerCount;

		// Token: 0x0400032A RID: 810
		protected System.Collections.Generic.List<BundleData.SingleBundleData> m_updateingBundleList;

		// Token: 0x0400032B RID: 811
		protected int m_updateWorkerAliveCount;

		// Token: 0x0400032C RID: 812
		protected bool m_isAllUpdateWorkerSuccess;

		// Token: 0x0400032D RID: 813
		protected long m_assetBundleUpdateingTotalByte;

		// Token: 0x0400032E RID: 814
		protected long m_assetBundleUpdateingDownloadedByte;

		// Token: 0x0400032F RID: 815
		private bool m_disableAssetBundleDownload;

		// Token: 0x04000330 RID: 816
		private int m_currBundleDataVersion;

		// Token: 0x04000331 RID: 817
		private BundleData m_lastPreUpdateBundleData;

		// Token: 0x04000333 RID: 819
		private const string m_signalFileName = "dontmove.tmp";

		// Token: 0x04000334 RID: 820
		protected Dictionary<string, ResourceManager.ReserveItem> m_assetReserveDict = new Dictionary<string, ResourceManager.ReserveItem>();

		// Token: 0x04000335 RID: 821
		protected Dictionary<string, ResourceManager.ReserveItem> m_assetReserveDict4Keep = new Dictionary<string, ResourceManager.ReserveItem>();

		// Token: 0x04000336 RID: 822
		protected System.Collections.Generic.List<string> m_assetReserve4Remove = new System.Collections.Generic.List<string>();

		// Token: 0x04000337 RID: 823
		protected DateTime m_reserveTickDelayOutTime;

		// Token: 0x04000338 RID: 824
		protected const float ReserveTickDelayTime = 5f;

		// Token: 0x04000339 RID: 825
		private bool m_skipStreamingAssetsFileProcessing;

		// Token: 0x0400033B RID: 827
		private int m_currStreamingAssetsFileListVersion;

		// Token: 0x0400033C RID: 828
		private StreamingAssetsFileList m_streamingAssetsFileList;

		// Token: 0x0400033D RID: 829
		private BundleData m_streamingAssetsBundleData;

		// Token: 0x0400033E RID: 830
		private BundleDataHelper m_streamingAssetsBundleDataHelper;

		// Token: 0x0400033F RID: 831
		private Boo.Lang.List<BundleData.SingleBundleData> m_streamingAssetsMissingBundles = new Boo.Lang.List<BundleData.SingleBundleData>();

		// Token: 0x0200008B RID: 139
		public enum RMState
		{
			// Token: 0x04000341 RID: 833
			None,
			// Token: 0x04000342 RID: 834
			Inited,
			// Token: 0x04000343 RID: 835
			StreamingAssetsFilesProcessing,
			// Token: 0x04000344 RID: 836
			StreamingAssetsFilesProcessEnd,
			// Token: 0x04000345 RID: 837
			BundleDataLoading,
			// Token: 0x04000346 RID: 838
			BundleDataLoadEnd,
			// Token: 0x04000347 RID: 839
			AssetBundlePreUpdateing,
			// Token: 0x04000348 RID: 840
			AssetBundlePreUpdateEnd,
			// Token: 0x04000349 RID: 841
			AssetBundleManifestLoading,
			// Token: 0x0400034A RID: 842
			AssetBundleManifestLoadEnd,
			// Token: 0x0400034B RID: 843
			Ready = 9
		}

		// Token: 0x0200008C RID: 140
		protected class AssetCacheItem
		{
			// Token: 0x0400034C RID: 844
			public string m_cacheKey;

			// Token: 0x0400034D RID: 845
			public WeakReference m_weakRefrence;

			// Token: 0x0400034E RID: 846
			public bool m_removeReserveOnHit;
		}

		// Token: 0x0200008D RID: 141
		protected class BundleCacheItem
		{
			// Token: 0x06000626 RID: 1574 RVA: 0x0001B8B4 File Offset: 0x00019AB4
			public void AddRefrence()
			{
				this.m_refCount++;
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x0001B8C4 File Offset: 0x00019AC4
			public void RemoveRefrence()
			{
				this.m_refCount--;
			}

			// Token: 0x0400034F RID: 847
			public string m_bundleName;

			// Token: 0x04000350 RID: 848
			public DateTime m_lastTouchTime;

			// Token: 0x04000351 RID: 849
			public DateTime m_timeOutTime;

			// Token: 0x04000352 RID: 850
			public int m_hitCount;

			// Token: 0x04000353 RID: 851
			public int m_refCount;

			// Token: 0x04000354 RID: 852
			public AssetBundle m_bundle;

			// Token: 0x04000355 RID: 853
			public bool m_dontUnload;

			// Token: 0x04000356 RID: 854
			public System.Collections.Generic.List<ResourceManager.BundleCacheItem> m_dependBundleCacheList;

			// Token: 0x04000357 RID: 855
			public static float s_validedHitInterval = 1f;

			// Token: 0x04000358 RID: 856
			public static int m_firstTimeOut = 600;

			// Token: 0x04000359 RID: 857
			public static int m_OnHitTimeOutDelay = 60;
		}

		// Token: 0x0200008E RID: 142
		public class BundleLoadingCtx
		{
			// Token: 0x0400035A RID: 858
			public string m_bundleName;

			// Token: 0x0400035B RID: 859
			public AssetBundle m_bundle;

			// Token: 0x0400035C RID: 860
			public bool m_isEnd;

			// Token: 0x0400035D RID: 861
			public int m_ref;
		}

		// Token: 0x0200008F RID: 143
		protected class ReserveItem
		{
			// Token: 0x0400035E RID: 862
			public UnityEngine.Object m_asset;

			// Token: 0x0400035F RID: 863
			public DateTime m_timeOut = DateTime.MinValue;
		}
	}
}
