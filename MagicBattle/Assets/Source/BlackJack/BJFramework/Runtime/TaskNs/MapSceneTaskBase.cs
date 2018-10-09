using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.Utils;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.TaskNs
{
	// Token: 0x020000C8 RID: 200
	[HotFix]
	public class MapSceneTaskBase : Task, IDynamicAssetProvider
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x00020CA4 File Offset: 0x0001EEA4
		public MapSceneTaskBase(string name) : base(name)
		{
			this.InitPipeCtxDefault();
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00020D6C File Offset: 0x0001EF6C
		protected virtual void InitPipeCtxDefault()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPipeCtxDefault_hotfix != null)
			{
				this.m_InitPipeCtxDefault_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_pipeCtxDefault = new MapSceneUpdatePipeLineCtxBase();
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		protected override bool OnStart(object param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartObject_hotfix.call(new object[]
				{
					this,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.StartUpdatePipeLine(null);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00020E5C File Offset: 0x0001F05C
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearAllContextAndRes();
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00020EC4 File Offset: 0x0001F0C4
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideAllView();
			this.ClearContextOnPause();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00020F30 File Offset: 0x0001F130
		protected virtual bool StartUpdatePipeLine(MapSceneUpdatePipeLineCtxBase pipeCtx = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUpdatePipeLineMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartUpdatePipeLineMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_pipeCtxDefault.IsRunning())
			{
				this.m_pipeLineWait2Start.Add(pipeCtx);
				return true;
			}
			pipeCtx = ((pipeCtx != null) ? pipeCtx : this.m_pipeCtxDefault);
			if (!this.StartPipeLineCtx(pipeCtx))
			{
				global::Debug.LogError(string.Format("StartPipeLineCtx fail maybe is already runing ctx={0}", pipeCtx));
				return false;
			}
			if (this.IsNeedUpdateDataCache(pipeCtx))
			{
				this.UpdateDataCache(pipeCtx);
			}
			bool flag = pipeCtx == this.m_pipeCtxDefault && this.IsNeedLoadStaticRes();
			bool flag2 = false;
			List<string> list = null;
			if (this.IsNeedCollectAllDynamicResForLoad(pipeCtx))
			{
				list = this.CollectAllDynamicResForLoad(pipeCtx);
				flag2 = (list != null && list.Count != 0);
			}
			this.PreProcessBeforeResLoad(pipeCtx);
			if (flag || flag2)
			{
				if (flag)
				{
					this.StartLoadStaticRes(pipeCtx);
				}
				if (flag2)
				{
					this.StartLoadDynamicRes(list, pipeCtx);
				}
				return true;
			}
			this.StartUpdateView(pipeCtx);
			return true;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00021090 File Offset: 0x0001F290
		protected virtual MapSceneUpdatePipeLineCtxBase AllocPipeLineCtx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocPipeLineCtx_hotfix != null)
			{
				return (MapSceneUpdatePipeLineCtxBase)this.m_AllocPipeLineCtx_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase;
			if (this.m_unusingPipeLineCtxList.Count != 0)
			{
				mapSceneUpdatePipeLineCtxBase = this.m_unusingPipeLineCtxList[0];
				this.m_unusingPipeLineCtxList.Remove(mapSceneUpdatePipeLineCtxBase);
			}
			else
			{
				mapSceneUpdatePipeLineCtxBase = this.CreatePipeLineCtx();
			}
			return mapSceneUpdatePipeLineCtxBase;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00021134 File Offset: 0x0001F334
		protected virtual MapSceneUpdatePipeLineCtxBase CreatePipeLineCtx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatePipeLineCtx_hotfix != null)
			{
				return (MapSceneUpdatePipeLineCtxBase)this.m_CreatePipeLineCtx_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new MapSceneUpdatePipeLineCtxBase();
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000211A8 File Offset: 0x0001F3A8
		protected virtual bool StartPipeLineCtx(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartPipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartPipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pipeCtx == null || !pipeCtx.Start())
			{
				return false;
			}
			this.m_runingPipeLineCtxList.Add(pipeCtx);
			return true;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00021244 File Offset: 0x0001F444
		protected virtual void ReleasePipeLineCtx(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReleasePipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_ReleasePipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			pipeCtx.Clear();
			this.m_runingPipeLineCtxList.Remove(pipeCtx);
			if (pipeCtx != this.m_pipeCtxDefault)
			{
				this.m_unusingPipeLineCtxList.Add(pipeCtx);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000212E0 File Offset: 0x0001F4E0
		protected virtual bool IsNeedUpdateDataCache(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00021360 File Offset: 0x0001F560
		protected virtual void UpdateDataCache(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_UpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000213D0 File Offset: 0x0001F5D0
		protected virtual void PreProcessBeforeResLoad(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreProcessBeforeResLoadMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_PreProcessBeforeResLoadMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00021440 File Offset: 0x0001F640
		protected virtual bool IsNeedLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadStaticRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadStaticRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mainLayer == null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000214B8 File Offset: 0x0001F6B8
		protected virtual void StartLoadStaticRes(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoadStaticResMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_StartLoadStaticResMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneUpdatePipeLineCtxBase pipeCtx = pipeCtx2;
			MapSceneTaskBase $this = this;
			MapSceneTaskBase.LayerDesc[] layerDescArray = this.LayerDescArray;
			if (layerDescArray == null || layerDescArray.Length <= 0)
			{
				global::Debug.LogError(string.Format("StartLoadStaticRes fail LayerDescArray size error", new object[0]));
				throw new Exception(string.Format("StartLoadStaticRes fail LayerDescArray size error", new object[0]));
			}
			this.m_layerArray = new SceneLayerBase[layerDescArray.Length];
			for (int i = 0; i < layerDescArray.Length; i++)
			{
				string layerName = layerDescArray[i].m_layerName;
				string layerResPath = layerDescArray[i].m_layerResPath;
				bool isUILayer = layerDescArray[i].m_isUILayer;
				pipeCtx.m_loadingStaticResCorutineCount++;
				int index = i;
				if (!isUILayer)
				{
					SceneManager.Instance.CreateLayer(typeof(ThreeDSceneLayer), layerName, layerResPath, delegate(SceneLayerBase layer)
					{
						if (layer == null)
						{
							global::Debug.LogError(string.Format("Load Layer fail task={0} layer={1}", $this.ToString(), layerName));
							return;
						}
						$this.m_layerArray[index] = layer;
						pipeCtx.m_loadingStaticResCorutineCount--;
						$this.OnLoadStaticResCompleted(pipeCtx);
					}, false);
				}
				else
				{
					SceneManager.Instance.CreateLayer(typeof(UISceneLayer), layerName, layerResPath, delegate(SceneLayerBase layer)
					{
						if (layer == null)
						{
							global::Debug.LogError(string.Format("Load Layer fail task={0} layer={1}", $this.ToString(), layerName));
							return;
						}
						$this.m_layerArray[index] = layer;
						pipeCtx.m_loadingStaticResCorutineCount--;
						$this.OnLoadStaticResCompleted(pipeCtx);
					}, false);
				}
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00021654 File Offset: 0x0001F854
		protected virtual void OnLoadStaticResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoadStaticResCompletedMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_OnLoadStaticResCompletedMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsLoadAllResCompleted(pipeCtx))
			{
				this.OnLoadAllResCompleted(pipeCtx);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000216D8 File Offset: 0x0001F8D8
		protected virtual bool IsNeedCollectAllDynamicResForLoad(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedCollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedCollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00021758 File Offset: 0x0001F958
		protected virtual List<string> CollectAllDynamicResForLoad(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return null;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000217D8 File Offset: 0x0001F9D8
		protected void StartLoadDynamicRes(List<string> resPathList, MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoadDynamicResList`1MapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_StartLoadDynamicResList`1MapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					resPathList,
					pipeCtx2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneUpdatePipeLineCtxBase pipeCtx = pipeCtx2;
			MapSceneTaskBase $this = this;
			HashSet<string> hashSet = this.CalculateDynamicResReallyNeedLoad(resPathList);
			if (hashSet == null || hashSet.Count == 0)
			{
				this.OnLoadDynamicResCompleted(null, pipeCtx);
				return;
			}
			Dictionary<string, UnityEngine.Object> resDict = new Dictionary<string, UnityEngine.Object>();
			pipeCtx.m_loadingDynamicResCorutineCount++;
			ResourceManager.Instance.StartLoadAssetsCorutine(hashSet, resDict, delegate
			{
				pipeCtx.m_loadingDynamicResCorutineCount--;
				$this.OnLoadDynamicResCompleted(resDict, pipeCtx);
			}, true);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000218D0 File Offset: 0x0001FAD0
		protected HashSet<string> CalculateDynamicResReallyNeedLoad(List<string> resPathList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateDynamicResReallyNeedLoadList`1_hotfix != null)
			{
				return (HashSet<string>)this.m_CalculateDynamicResReallyNeedLoadList`1_hotfix.call(new object[]
				{
					this,
					resPathList
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<string> hashSet = new HashSet<string>();
			for (int i = 0; i < resPathList.Count; i++)
			{
				string text = resPathList[i];
				MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
				if (!this.m_dynamicResCacheDict.TryGetValue(text, out dynamicResCacheItem))
				{
					hashSet.Add(text);
				}
			}
			return hashSet;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00021990 File Offset: 0x0001FB90
		protected virtual void OnLoadDynamicResCompleted(Dictionary<string, UnityEngine.Object> resDict, MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoadDynamicResCompletedDictionary`2MapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_OnLoadDynamicResCompletedDictionary`2MapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					resDict,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (resDict != null && resDict.Count != 0)
			{
				foreach (KeyValuePair<string, UnityEngine.Object> keyValuePair in resDict)
				{
					if (keyValuePair.Value != null)
					{
						MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
						if (!this.m_dynamicResCacheDict.TryGetValue(keyValuePair.Key, out dynamicResCacheItem))
						{
							dynamicResCacheItem = new MapSceneTaskBase.DynamicResCacheItem();
							this.m_dynamicResCacheDict.Add(keyValuePair.Key, dynamicResCacheItem);
						}
						dynamicResCacheItem.m_res = keyValuePair.Value;
						dynamicResCacheItem.m_isLocked = pipeCtx.m_lockResCache;
					}
				}
			}
			if (this.IsLoadAllResCompleted(pipeCtx))
			{
				this.OnLoadAllResCompleted(pipeCtx);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00021AD4 File Offset: 0x0001FCD4
		protected virtual bool IsLoadAllResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return pipeCtx.m_loadingStaticResCorutineCount == 0 && pipeCtx.m_loadingDynamicResCorutineCount == 0;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00021B68 File Offset: 0x0001FD68
		protected virtual void OnLoadAllResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_OnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pipeCtx == this.m_pipeCtxDefault)
			{
				this.InitLayerStateOnLoadAllResCompleted(pipeCtx);
			}
			this.StartUpdateView(pipeCtx);
			this.ReleasePipeLineCtx(pipeCtx);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00021BFC File Offset: 0x0001FDFC
		protected virtual void InitLayerStateOnLoadAllResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mainLayer.State != SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PushLayer(this.m_mainLayer);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00021C90 File Offset: 0x0001FE90
		protected virtual void StartUpdateView(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_StartUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateView(pipeCtx);
			this.PostUpdateView(pipeCtx);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00021D10 File Offset: 0x0001FF10
		protected virtual void UpdateView(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_UpdateViewMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pipeCtx.m_updateViewAction != null)
			{
				pipeCtx.m_updateViewAction();
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00021D98 File Offset: 0x0001FF98
		protected virtual void PostUpdateView(MapSceneUpdatePipeLineCtxBase pipeCtx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix != null)
			{
				this.m_PostUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix.call(new object[]
				{
					this,
					pipeCtx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00021E08 File Offset: 0x00020008
		protected virtual void HideAllView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideAllView_hotfix != null)
			{
				this.m_HideAllView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_layerArray == null || this.m_layerArray.Length == 0)
			{
				return;
			}
			foreach (SceneLayerBase layer in this.m_layerArray)
			{
				SceneManager.Instance.PopLayer(layer);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00021EAC File Offset: 0x000200AC
		protected virtual void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_layerArray != null)
			{
				foreach (SceneLayerBase layer in this.m_layerArray)
				{
					SceneManager.Instance.FreeLayer(layer);
				}
			}
			this.m_dynamicResCacheDict.Clear();
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00021F4C File Offset: 0x0002014C
		protected virtual void ClearContextOnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearContextOnPause_hotfix != null)
			{
				this.m_ClearContextOnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00021FAC File Offset: 0x000201AC
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.TickDynamicResCache();
			if (!this.m_pipeCtxDefault.IsRunning())
			{
				while (this.m_pipeLineWait2Start.Count != 0)
				{
					MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = this.m_pipeLineWait2Start[0];
					this.StartUpdatePipeLine(mapSceneUpdatePipeLineCtxBase);
					this.m_pipeLineWait2Start.Remove(mapSceneUpdatePipeLineCtxBase);
				}
			}
			this.m_corutineHelper.Tick();
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00022064 File Offset: 0x00020264
		protected void ReleaseDynamicResCache(string path)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReleaseDynamicResCacheString_hotfix != null)
			{
				this.m_ReleaseDynamicResCacheString_hotfix.call(new object[]
				{
					this,
					path
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
			if (this.m_dynamicResCacheDict.TryGetValue(path, out dynamicResCacheItem))
			{
				dynamicResCacheItem.m_ref -= 1u;
				if (dynamicResCacheItem.m_ref <= 0u && !dynamicResCacheItem.m_isLocked)
				{
					dynamicResCacheItem.m_waitForRelease = true;
				}
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00022114 File Offset: 0x00020314
		protected void LockDynamicResCache(string path)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LockDynamicResCacheString_hotfix != null)
			{
				this.m_LockDynamicResCacheString_hotfix.call(new object[]
				{
					this,
					path
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
			if (this.m_dynamicResCacheDict.TryGetValue(path, out dynamicResCacheItem))
			{
				dynamicResCacheItem.m_isLocked = true;
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000221A0 File Offset: 0x000203A0
		protected void UnlockDynamicResCache(string path)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnlockDynamicResCacheString_hotfix != null)
			{
				this.m_UnlockDynamicResCacheString_hotfix.call(new object[]
				{
					this,
					path
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
			if (this.m_dynamicResCacheDict.TryGetValue(path, out dynamicResCacheItem))
			{
				dynamicResCacheItem.m_isLocked = false;
				if (dynamicResCacheItem.m_ref <= 0u)
				{
					dynamicResCacheItem.m_waitForRelease = true;
				}
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00022240 File Offset: 0x00020440
		protected void UnlockAllDynamicResCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnlockAllDynamicResCache_hotfix != null)
			{
				this.m_UnlockAllDynamicResCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<string, MapSceneTaskBase.DynamicResCacheItem> keyValuePair in this.m_dynamicResCacheDict)
			{
				keyValuePair.Value.m_isLocked = false;
				if (keyValuePair.Value.m_ref <= 0u)
				{
					keyValuePair.Value.m_waitForRelease = true;
				}
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00022314 File Offset: 0x00020514
		protected void TickDynamicResCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickDynamicResCache_hotfix != null)
			{
				this.m_TickDynamicResCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_nextUnLoadDynamicResTime <= Timer.m_currTime)
			{
				this.m_nextUnLoadDynamicResTime = Timer.m_currTime.AddSeconds((double)this.m_unloadDynamicResTimeInterval);
				foreach (KeyValuePair<string, MapSceneTaskBase.DynamicResCacheItem> keyValuePair in this.m_dynamicResCacheDict)
				{
					if (keyValuePair.Value.m_waitForRelease && !keyValuePair.Value.m_isLocked)
					{
						this.m_wait2ReleaseResList.Add(keyValuePair.Key);
					}
					else if (keyValuePair.Value.m_ref <= 0u && !keyValuePair.Value.m_isLocked)
					{
						keyValuePair.Value.m_waitForRelease = true;
					}
				}
				foreach (string key in this.m_wait2ReleaseResList)
				{
					this.m_dynamicResCacheDict.Remove(key);
				}
				this.m_wait2ReleaseResList.Clear();
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000224B0 File Offset: 0x000206B0
		UnityEngine.Object IDynamicAssetProvider.AllocDynamicAsset(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAssetString_hotfix != null)
			{
				return (UnityEngine.Object)this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAssetString_hotfix.call(new object[]
				{
					this,
					name
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
			if (this.m_dynamicResCacheDict.TryGetValue(name, out dynamicResCacheItem))
			{
				dynamicResCacheItem.m_ref += 1u;
				dynamicResCacheItem.m_waitForRelease = false;
				return dynamicResCacheItem.m_res;
			}
			return null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0002255C File Offset: 0x0002075C
		T IDynamicAssetProvider.AllocDynamicAsset<T>(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAssetString_hotfix != null)
			{
				return (T)((object)this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAssetString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
			if (!string.IsNullOrEmpty(name) && this.m_dynamicResCacheDict.TryGetValue(name, out dynamicResCacheItem))
			{
				T t = dynamicResCacheItem.m_res as T;
				if (t != null)
				{
					dynamicResCacheItem.m_ref += 1u;
					dynamicResCacheItem.m_waitForRelease = false;
				}
				return t;
			}
			return (T)((object)null);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00022638 File Offset: 0x00020838
		void IDynamicAssetProvider.ReleaseDynamicAsset(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.ReleaseDynamicAssetString_hotfix != null)
			{
				this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.ReleaseDynamicAssetString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ReleaseDynamicResCache(name);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000226B0 File Offset: 0x000208B0
		bool IDynamicAssetProvider.CheckAsset(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.CheckAssetString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.CheckAssetString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MapSceneTaskBase.DynamicResCacheItem dynamicResCacheItem;
			return this.m_dynamicResCacheDict.TryGetValue(name, out dynamicResCacheItem);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0002273C File Offset: 0x0002093C
		protected SceneLayerBase m_mainLayer
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_m_mainLayer_hotfix != null)
				{
					return (SceneLayerBase)this.m_get_m_mainLayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return (this.m_layerArray != null && this.m_layerArray.Length != 0) ? this.m_layerArray[0] : null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000227D0 File Offset: 0x000209D0
		protected virtual MapSceneTaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (MapSceneTaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				throw new NotImplementedException();
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00022848 File Offset: 0x00020A48
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00022868 File Offset: 0x00020A68
		[DoNotToLua]
		public new MapSceneTaskBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MapSceneTaskBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00022874 File Offset: 0x00020A74
		private bool __callBase_Start(object param)
		{
			return base.Start(param);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00022880 File Offset: 0x00020A80
		private void __callBase_Stop()
		{
			base.Stop();
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00022888 File Offset: 0x00020A88
		private void __callBase_Pause()
		{
			base.Pause();
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00022890 File Offset: 0x00020A90
		private bool __callBase_Resume(object param)
		{
			return base.Resume(param);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0002289C File Offset: 0x00020A9C
		private void __callBase_ClearOnStopEvent()
		{
			base.ClearOnStopEvent();
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000228A4 File Offset: 0x00020AA4
		private void __callBase_ExecAfterTicks(Action action, ulong delayTickCount)
		{
			base.ExecAfterTicks(action, delayTickCount);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000228B0 File Offset: 0x00020AB0
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000228BC File Offset: 0x00020ABC
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000228C4 File Offset: 0x00020AC4
		private bool __callBase_OnResume(object param)
		{
			return base.OnResume(param);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000228D0 File Offset: 0x00020AD0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000228D8 File Offset: 0x00020AD8
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000228E0 File Offset: 0x00020AE0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000228E8 File Offset: 0x00020AE8
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitPipeCtxDefault_hotfix = (luaObj.RawGet("InitPipeCtxDefault") as LuaFunction);
					this.m_OnStartObject_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_StartUpdatePipeLineMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("StartUpdatePipeLine") as LuaFunction);
					this.m_AllocPipeLineCtx_hotfix = (luaObj.RawGet("AllocPipeLineCtx") as LuaFunction);
					this.m_CreatePipeLineCtx_hotfix = (luaObj.RawGet("CreatePipeLineCtx") as LuaFunction);
					this.m_StartPipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("StartPipeLineCtx") as LuaFunction);
					this.m_ReleasePipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("ReleasePipeLineCtx") as LuaFunction);
					this.m_IsNeedUpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_PreProcessBeforeResLoadMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("PreProcessBeforeResLoad") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_StartLoadStaticResMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("StartLoadStaticRes") as LuaFunction);
					this.m_OnLoadStaticResCompletedMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("OnLoadStaticResCompleted") as LuaFunction);
					this.m_IsNeedCollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("IsNeedCollectAllDynamicResForLoad") as LuaFunction);
					this.m_CollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_StartLoadDynamicResList`1MapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("StartLoadDynamicRes") as LuaFunction);
					this.m_CalculateDynamicResReallyNeedLoadList`1_hotfix = (luaObj.RawGet("CalculateDynamicResReallyNeedLoad") as LuaFunction);
					this.m_OnLoadDynamicResCompletedDictionary`2MapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("OnLoadDynamicResCompleted") as LuaFunction);
					this.m_IsLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("IsLoadAllResCompleted") as LuaFunction);
					this.m_OnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("OnLoadAllResCompleted") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_StartUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("StartUpdateView") as LuaFunction);
					this.m_UpdateViewMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PostUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_HideAllView_hotfix = (luaObj.RawGet("HideAllView") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_ClearContextOnPause_hotfix = (luaObj.RawGet("ClearContextOnPause") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_ReleaseDynamicResCacheString_hotfix = (luaObj.RawGet("ReleaseDynamicResCache") as LuaFunction);
					this.m_LockDynamicResCacheString_hotfix = (luaObj.RawGet("LockDynamicResCache") as LuaFunction);
					this.m_UnlockDynamicResCacheString_hotfix = (luaObj.RawGet("UnlockDynamicResCache") as LuaFunction);
					this.m_UnlockAllDynamicResCache_hotfix = (luaObj.RawGet("UnlockAllDynamicResCache") as LuaFunction);
					this.m_TickDynamicResCache_hotfix = (luaObj.RawGet("TickDynamicResCache") as LuaFunction);
					this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAssetString_hotfix = (luaObj.RawGet("BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAsset") as LuaFunction);
					this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAssetString_hotfix = (luaObj.RawGet("BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.AllocDynamicAsset") as LuaFunction);
					this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.ReleaseDynamicAssetString_hotfix = (luaObj.RawGet("BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.ReleaseDynamicAsset") as LuaFunction);
					this.m_BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.CheckAssetString_hotfix = (luaObj.RawGet("BlackJack.BJFramework.Runtime.TaskNs.IDynamicAssetProvider.CheckAsset") as LuaFunction);
					this.m_get_m_mainLayer_hotfix = (luaObj.RawGet("get_m_mainLayer") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00022DB4 File Offset: 0x00020FB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MapSceneTaskBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040004C4 RID: 1220
		protected MapSceneUpdatePipeLineCtxBase m_pipeCtxDefault;

		// Token: 0x040004C5 RID: 1221
		protected List<MapSceneUpdatePipeLineCtxBase> m_runingPipeLineCtxList = new List<MapSceneUpdatePipeLineCtxBase>();

		// Token: 0x040004C6 RID: 1222
		protected List<MapSceneUpdatePipeLineCtxBase> m_unusingPipeLineCtxList = new List<MapSceneUpdatePipeLineCtxBase>();

		// Token: 0x040004C7 RID: 1223
		protected List<MapSceneUpdatePipeLineCtxBase> m_pipeLineWait2Start = new List<MapSceneUpdatePipeLineCtxBase>();

		// Token: 0x040004C8 RID: 1224
		protected SceneLayerBase[] m_layerArray;

		// Token: 0x040004C9 RID: 1225
		protected Dictionary<string, MapSceneTaskBase.DynamicResCacheItem> m_dynamicResCacheDict = new Dictionary<string, MapSceneTaskBase.DynamicResCacheItem>();

		// Token: 0x040004CA RID: 1226
		protected List<string> m_wait2ReleaseResList = new List<string>();

		// Token: 0x040004CB RID: 1227
		protected TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x040004CC RID: 1228
		private int m_unloadDynamicResTimeInterval = 1;

		// Token: 0x040004CD RID: 1229
		private DateTime m_nextUnLoadDynamicResTime;

		// Token: 0x040004CE RID: 1230
		[DoNotToLua]
		private MapSceneTaskBase.LuaExportHelper luaExportHelper;

		// Token: 0x040004CF RID: 1231
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040004D0 RID: 1232
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040004D1 RID: 1233
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040004D2 RID: 1234
		private LuaFunction m_InitPipeCtxDefault_hotfix;

		// Token: 0x040004D3 RID: 1235
		private LuaFunction m_OnStartObject_hotfix;

		// Token: 0x040004D4 RID: 1236
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x040004D5 RID: 1237
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x040004D6 RID: 1238
		private LuaFunction m_StartUpdatePipeLineMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004D7 RID: 1239
		private LuaFunction m_AllocPipeLineCtx_hotfix;

		// Token: 0x040004D8 RID: 1240
		private LuaFunction m_CreatePipeLineCtx_hotfix;

		// Token: 0x040004D9 RID: 1241
		private LuaFunction m_StartPipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004DA RID: 1242
		private LuaFunction m_ReleasePipeLineCtxMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004DB RID: 1243
		private LuaFunction m_IsNeedUpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004DC RID: 1244
		private LuaFunction m_UpdateDataCacheMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004DD RID: 1245
		private LuaFunction m_PreProcessBeforeResLoadMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004DE RID: 1246
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x040004DF RID: 1247
		private LuaFunction m_StartLoadStaticResMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E0 RID: 1248
		private LuaFunction m_OnLoadStaticResCompletedMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E1 RID: 1249
		private LuaFunction m_IsNeedCollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E2 RID: 1250
		private LuaFunction m_CollectAllDynamicResForLoadMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E3 RID: 1251
		private LuaFunction m_StartLoadDynamicResList;

		// Token: 0x040004E4 RID: 1252
		private LuaFunction m_CalculateDynamicResReallyNeedLoadList;

		// Token: 0x040004E5 RID: 1253
		private LuaFunction m_OnLoadDynamicResCompletedDictionary;

		// Token: 0x040004E6 RID: 1254
		private LuaFunction m_IsLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E7 RID: 1255
		private LuaFunction m_OnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E8 RID: 1256
		private LuaFunction m_InitLayerStateOnLoadAllResCompletedMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004E9 RID: 1257
		private LuaFunction m_StartUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004EA RID: 1258
		private LuaFunction m_UpdateViewMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004EB RID: 1259
		private LuaFunction m_PostUpdateViewMapSceneUpdatePipeLineCtxBase_hotfix;

		// Token: 0x040004EC RID: 1260
		private LuaFunction m_HideAllView_hotfix;

		// Token: 0x040004ED RID: 1261
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040004EE RID: 1262
		private LuaFunction m_ClearContextOnPause_hotfix;

		// Token: 0x040004EF RID: 1263
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x040004F0 RID: 1264
		private LuaFunction m_ReleaseDynamicResCacheString_hotfix;

		// Token: 0x040004F1 RID: 1265
		private LuaFunction m_LockDynamicResCacheString_hotfix;

		// Token: 0x040004F2 RID: 1266
		private LuaFunction m_UnlockDynamicResCacheString_hotfix;

		// Token: 0x040004F3 RID: 1267
		private LuaFunction m_UnlockAllDynamicResCache_hotfix;

		// Token: 0x040004F4 RID: 1268
		private LuaFunction m_TickDynamicResCache_hotfix;

		// Token: 0x040004F5 RID: 1269
		private LuaFunction AllocDynamicAssetString_hotfix;

		// Token: 0x040004F6 RID: 1270
		private LuaFunction AllocDynamicAssetString_hotfix;

		// Token: 0x040004F7 RID: 1271
		private LuaFunction ReleaseDynamicAssetString_hotfix;

		// Token: 0x040004F8 RID: 1272
		private LuaFunction CheckAssetString_hotfix;

		// Token: 0x040004F9 RID: 1273
		private LuaFunction m_get_m_mainLayer_hotfix;

		// Token: 0x040004FA RID: 1274
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x020000C9 RID: 201
		[CustomLuaClass]
		public struct LayerDesc
		{
			// Token: 0x040004FB RID: 1275
			public string m_layerName;

			// Token: 0x040004FC RID: 1276
			public string m_layerResPath;

			// Token: 0x040004FD RID: 1277
			public bool m_isUILayer;
		}

		// Token: 0x020000CA RID: 202
		public class DynamicResCacheItem
		{
			// Token: 0x040004FE RID: 1278
			public UnityEngine.Object m_res;

			// Token: 0x040004FF RID: 1279
			public uint m_ref;

			// Token: 0x04000500 RID: 1280
			public bool m_waitForRelease;

			// Token: 0x04000501 RID: 1281
			public bool m_isLocked;
		}

		// Token: 0x020000CB RID: 203
		public new class LuaExportHelper
		{
			// Token: 0x0600074F RID: 1871 RVA: 0x00022E24 File Offset: 0x00021024
			public LuaExportHelper(MapSceneTaskBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x00022E34 File Offset: 0x00021034
			public bool __callBase_Start(object param)
			{
				return this.m_owner.__callBase_Start(param);
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x00022E44 File Offset: 0x00021044
			public void __callBase_Stop()
			{
				this.m_owner.__callBase_Stop();
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x00022E54 File Offset: 0x00021054
			public void __callBase_Pause()
			{
				this.m_owner.__callBase_Pause();
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x00022E64 File Offset: 0x00021064
			public bool __callBase_Resume(object param)
			{
				return this.m_owner.__callBase_Resume(param);
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x00022E74 File Offset: 0x00021074
			public void __callBase_ClearOnStopEvent()
			{
				this.m_owner.__callBase_ClearOnStopEvent();
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x00022E84 File Offset: 0x00021084
			public void __callBase_ExecAfterTicks(Action action, ulong delayTickCount)
			{
				this.m_owner.__callBase_ExecAfterTicks(action, delayTickCount);
			}

			// Token: 0x06000756 RID: 1878 RVA: 0x00022E94 File Offset: 0x00021094
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x06000757 RID: 1879 RVA: 0x00022EA4 File Offset: 0x000210A4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x00022EB4 File Offset: 0x000210B4
			public bool __callBase_OnResume(object param)
			{
				return this.m_owner.__callBase_OnResume(param);
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x00022EC4 File Offset: 0x000210C4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600075A RID: 1882 RVA: 0x00022ED4 File Offset: 0x000210D4
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x0600075B RID: 1883 RVA: 0x00022EE4 File Offset: 0x000210E4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x00022EF4 File Offset: 0x000210F4
			// (set) Token: 0x0600075D RID: 1885 RVA: 0x00022F04 File Offset: 0x00021104
			public MapSceneUpdatePipeLineCtxBase m_pipeCtxDefault
			{
				get
				{
					return this.m_owner.m_pipeCtxDefault;
				}
				set
				{
					this.m_owner.m_pipeCtxDefault = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x0600075E RID: 1886 RVA: 0x00022F14 File Offset: 0x00021114
			// (set) Token: 0x0600075F RID: 1887 RVA: 0x00022F24 File Offset: 0x00021124
			public List<MapSceneUpdatePipeLineCtxBase> m_runingPipeLineCtxList
			{
				get
				{
					return this.m_owner.m_runingPipeLineCtxList;
				}
				set
				{
					this.m_owner.m_runingPipeLineCtxList = value;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000760 RID: 1888 RVA: 0x00022F34 File Offset: 0x00021134
			// (set) Token: 0x06000761 RID: 1889 RVA: 0x00022F44 File Offset: 0x00021144
			public List<MapSceneUpdatePipeLineCtxBase> m_unusingPipeLineCtxList
			{
				get
				{
					return this.m_owner.m_unusingPipeLineCtxList;
				}
				set
				{
					this.m_owner.m_unusingPipeLineCtxList = value;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000762 RID: 1890 RVA: 0x00022F54 File Offset: 0x00021154
			// (set) Token: 0x06000763 RID: 1891 RVA: 0x00022F64 File Offset: 0x00021164
			public List<MapSceneUpdatePipeLineCtxBase> m_pipeLineWait2Start
			{
				get
				{
					return this.m_owner.m_pipeLineWait2Start;
				}
				set
				{
					this.m_owner.m_pipeLineWait2Start = value;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000764 RID: 1892 RVA: 0x00022F74 File Offset: 0x00021174
			// (set) Token: 0x06000765 RID: 1893 RVA: 0x00022F84 File Offset: 0x00021184
			public SceneLayerBase[] m_layerArray
			{
				get
				{
					return this.m_owner.m_layerArray;
				}
				set
				{
					this.m_owner.m_layerArray = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000766 RID: 1894 RVA: 0x00022F94 File Offset: 0x00021194
			// (set) Token: 0x06000767 RID: 1895 RVA: 0x00022FA4 File Offset: 0x000211A4
			public Dictionary<string, MapSceneTaskBase.DynamicResCacheItem> m_dynamicResCacheDict
			{
				get
				{
					return this.m_owner.m_dynamicResCacheDict;
				}
				set
				{
					this.m_owner.m_dynamicResCacheDict = value;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000768 RID: 1896 RVA: 0x00022FB4 File Offset: 0x000211B4
			// (set) Token: 0x06000769 RID: 1897 RVA: 0x00022FC4 File Offset: 0x000211C4
			public List<string> m_wait2ReleaseResList
			{
				get
				{
					return this.m_owner.m_wait2ReleaseResList;
				}
				set
				{
					this.m_owner.m_wait2ReleaseResList = value;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600076A RID: 1898 RVA: 0x00022FD4 File Offset: 0x000211D4
			// (set) Token: 0x0600076B RID: 1899 RVA: 0x00022FE4 File Offset: 0x000211E4
			public TinyCorutineHelper m_corutineHelper
			{
				get
				{
					return this.m_owner.m_corutineHelper;
				}
				set
				{
					this.m_owner.m_corutineHelper = value;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600076C RID: 1900 RVA: 0x00022FF4 File Offset: 0x000211F4
			// (set) Token: 0x0600076D RID: 1901 RVA: 0x00023004 File Offset: 0x00021204
			public int m_unloadDynamicResTimeInterval
			{
				get
				{
					return this.m_owner.m_unloadDynamicResTimeInterval;
				}
				set
				{
					this.m_owner.m_unloadDynamicResTimeInterval = value;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600076E RID: 1902 RVA: 0x00023014 File Offset: 0x00021214
			// (set) Token: 0x0600076F RID: 1903 RVA: 0x00023024 File Offset: 0x00021224
			public DateTime m_nextUnLoadDynamicResTime
			{
				get
				{
					return this.m_owner.m_nextUnLoadDynamicResTime;
				}
				set
				{
					this.m_owner.m_nextUnLoadDynamicResTime = value;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000770 RID: 1904 RVA: 0x00023034 File Offset: 0x00021234
			public SceneLayerBase m_mainLayer
			{
				get
				{
					return this.m_owner.m_mainLayer;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000771 RID: 1905 RVA: 0x00023044 File Offset: 0x00021244
			public MapSceneTaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00023054 File Offset: 0x00021254
			public void InitPipeCtxDefault()
			{
				this.m_owner.InitPipeCtxDefault();
			}

			// Token: 0x06000773 RID: 1907 RVA: 0x00023064 File Offset: 0x00021264
			public bool OnStart(object param)
			{
				return this.m_owner.OnStart(param);
			}

			// Token: 0x06000774 RID: 1908 RVA: 0x00023074 File Offset: 0x00021274
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x00023084 File Offset: 0x00021284
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x00023094 File Offset: 0x00021294
			public bool StartUpdatePipeLine(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				return this.m_owner.StartUpdatePipeLine(pipeCtx);
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x000230A4 File Offset: 0x000212A4
			public MapSceneUpdatePipeLineCtxBase AllocPipeLineCtx()
			{
				return this.m_owner.AllocPipeLineCtx();
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x000230B4 File Offset: 0x000212B4
			public MapSceneUpdatePipeLineCtxBase CreatePipeLineCtx()
			{
				return this.m_owner.CreatePipeLineCtx();
			}

			// Token: 0x06000779 RID: 1913 RVA: 0x000230C4 File Offset: 0x000212C4
			public bool StartPipeLineCtx(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				return this.m_owner.StartPipeLineCtx(pipeCtx);
			}

			// Token: 0x0600077A RID: 1914 RVA: 0x000230D4 File Offset: 0x000212D4
			public void ReleasePipeLineCtx(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.ReleasePipeLineCtx(pipeCtx);
			}

			// Token: 0x0600077B RID: 1915 RVA: 0x000230E4 File Offset: 0x000212E4
			public bool IsNeedUpdateDataCache(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				return this.m_owner.IsNeedUpdateDataCache(pipeCtx);
			}

			// Token: 0x0600077C RID: 1916 RVA: 0x000230F4 File Offset: 0x000212F4
			public void UpdateDataCache(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.UpdateDataCache(pipeCtx);
			}

			// Token: 0x0600077D RID: 1917 RVA: 0x00023104 File Offset: 0x00021304
			public void PreProcessBeforeResLoad(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.PreProcessBeforeResLoad(pipeCtx);
			}

			// Token: 0x0600077E RID: 1918 RVA: 0x00023114 File Offset: 0x00021314
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x0600077F RID: 1919 RVA: 0x00023124 File Offset: 0x00021324
			public void StartLoadStaticRes(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.StartLoadStaticRes(pipeCtx);
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x00023134 File Offset: 0x00021334
			public void OnLoadStaticResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.OnLoadStaticResCompleted(pipeCtx);
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x00023144 File Offset: 0x00021344
			public bool IsNeedCollectAllDynamicResForLoad(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				return this.m_owner.IsNeedCollectAllDynamicResForLoad(pipeCtx);
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x00023154 File Offset: 0x00021354
			public List<string> CollectAllDynamicResForLoad(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				return this.m_owner.CollectAllDynamicResForLoad(pipeCtx);
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x00023164 File Offset: 0x00021364
			public void StartLoadDynamicRes(List<string> resPathList, MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.StartLoadDynamicRes(resPathList, pipeCtx);
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x00023174 File Offset: 0x00021374
			public HashSet<string> CalculateDynamicResReallyNeedLoad(List<string> resPathList)
			{
				return this.m_owner.CalculateDynamicResReallyNeedLoad(resPathList);
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x00023184 File Offset: 0x00021384
			public void OnLoadDynamicResCompleted(Dictionary<string, UnityEngine.Object> resDict, MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.OnLoadDynamicResCompleted(resDict, pipeCtx);
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x00023194 File Offset: 0x00021394
			public bool IsLoadAllResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				return this.m_owner.IsLoadAllResCompleted(pipeCtx);
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x000231A4 File Offset: 0x000213A4
			public void OnLoadAllResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.OnLoadAllResCompleted(pipeCtx);
			}

			// Token: 0x06000788 RID: 1928 RVA: 0x000231B4 File Offset: 0x000213B4
			public void InitLayerStateOnLoadAllResCompleted(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted(pipeCtx);
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x000231C4 File Offset: 0x000213C4
			public void StartUpdateView(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.StartUpdateView(pipeCtx);
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x000231D4 File Offset: 0x000213D4
			public void UpdateView(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.UpdateView(pipeCtx);
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x000231E4 File Offset: 0x000213E4
			public void PostUpdateView(MapSceneUpdatePipeLineCtxBase pipeCtx)
			{
				this.m_owner.PostUpdateView(pipeCtx);
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x000231F4 File Offset: 0x000213F4
			public void HideAllView()
			{
				this.m_owner.HideAllView();
			}

			// Token: 0x0600078D RID: 1933 RVA: 0x00023204 File Offset: 0x00021404
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600078E RID: 1934 RVA: 0x00023214 File Offset: 0x00021414
			public void ClearContextOnPause()
			{
				this.m_owner.ClearContextOnPause();
			}

			// Token: 0x0600078F RID: 1935 RVA: 0x00023224 File Offset: 0x00021424
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06000790 RID: 1936 RVA: 0x00023234 File Offset: 0x00021434
			public void ReleaseDynamicResCache(string path)
			{
				this.m_owner.ReleaseDynamicResCache(path);
			}

			// Token: 0x06000791 RID: 1937 RVA: 0x00023244 File Offset: 0x00021444
			public void LockDynamicResCache(string path)
			{
				this.m_owner.LockDynamicResCache(path);
			}

			// Token: 0x06000792 RID: 1938 RVA: 0x00023254 File Offset: 0x00021454
			public void UnlockDynamicResCache(string path)
			{
				this.m_owner.UnlockDynamicResCache(path);
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x00023264 File Offset: 0x00021464
			public void UnlockAllDynamicResCache()
			{
				this.m_owner.UnlockAllDynamicResCache();
			}

			// Token: 0x06000794 RID: 1940 RVA: 0x00023274 File Offset: 0x00021474
			public void TickDynamicResCache()
			{
				this.m_owner.TickDynamicResCache();
			}

			// Token: 0x04000502 RID: 1282
			private MapSceneTaskBase m_owner;
		}
	}
}
