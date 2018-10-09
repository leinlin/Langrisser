using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.Utils;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x02000111 RID: 273
	[HotFixManually]
	public class UITaskBase : Task
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x0002E8DC File Offset: 0x0002CADC
		public UITaskBase(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ctorString_hotfix != null)
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

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002E988 File Offset: 0x0002CB88
		public virtual void InitlizeBeforeManagerStartIt()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_InitlizeBeforeManagerStartIt_hotfix != null)
			{
				this.m_InitlizeBeforeManagerStartIt_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.LayerDescArray == null)
			{
				return;
			}
			for (int i = 0; i < this.LayerDescArray.Length; i++)
			{
				this.LayerDescArray[i].m_index = i;
			}
			this.m_layerArray = new SceneLayerBase[this.LayerDescArray.Length];
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002EA20 File Offset: 0x0002CC20
		public virtual void PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix != null)
			{
				this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix.call(new object[]
				{
					this,
					intent,
					onPrepareEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002EA90 File Offset: 0x0002CC90
		protected sealed override bool OnStart(object param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnStartObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartObject_hotfix.call(new object[]
				{
					this,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.OnStart(param as UIIntent);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0002EB08 File Offset: 0x0002CD08
		protected virtual bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx = this.GetPipeLineCtx();
			return this.StartUpdatePipeLine(intent, false, false, true);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		protected UITaskPipeLineCtx GetPipeLineCtx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_GetPipeLineCtx_hotfix != null)
			{
				return (UITaskPipeLineCtx)this.m_GetPipeLineCtx_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currPipeLineCtx == null)
			{
				this.m_currPipeLineCtx = this.CreatePipeLineCtx();
			}
			return this.m_currPipeLineCtx;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0002EC08 File Offset: 0x0002CE08
		protected virtual UITaskPipeLineCtx CreatePipeLineCtx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_CreatePipeLineCtx_hotfix != null)
			{
				return (UITaskPipeLineCtx)this.m_CreatePipeLineCtx_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new UITaskPipeLineCtx();
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0002EC6C File Offset: 0x0002CE6C
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnableUIInput(true, new bool?(true));
			UIManager.Instance.GlobalUIInputBlockClear(base.Name);
			this.ClearAllContextAndRes();
			if (this.m_uiCtrlArray != null)
			{
				foreach (UIControllerBase uicontrollerBase in this.m_uiCtrlArray)
				{
					if (uicontrollerBase != null)
					{
						uicontrollerBase.Clear();
					}
				}
				this.m_uiCtrlArray = null;
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002ED24 File Offset: 0x0002CF24
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("UITask OnPause {0}", base.Name));
			this.EnableUIInput(true, new bool?(true));
			UIManager.Instance.GlobalUIInputBlockClear(base.Name);
			this.SaveContextInIntentOnPause();
			this.HideAllView();
			this.ClearContextOnPause();
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		protected sealed override bool OnResume(object param = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnResumeObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeObject_hotfix.call(new object[]
				{
					this,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("UITask OnResume {0}    param{1}", base.Name, param));
			return this.OnResume(param as UIIntent);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0002EE48 File Offset: 0x0002D048
		protected virtual bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.m_isTaskResume = true;
			return this.StartUpdatePipeLine(intent, false, false, true);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0002EECC File Offset: 0x0002D0CC
		public virtual bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.StartUpdatePipeLine(intent, false, false, true);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002EF44 File Offset: 0x0002D144
		protected bool StartUpdatePipeLine(UIIntent intent = null, bool onlyUpdateView = false, bool canBeSkip = false, bool enableQueue = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_StartUpdatePipeLineUIIntentBooleanBooleanBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartUpdatePipeLineUIIntentBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					intent,
					onlyUpdateView,
					canBeSkip,
					enableQueue
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.State != Task.TaskState.Running)
			{
				global::Debug.LogError(string.Format("{0}.UITaskBase.StartUpdatePipeLine Error: State {1} != TaskState.Running", base.GetType().Name, base.State));
				return false;
			}
			if (this.m_blockPipeLine)
			{
				global::Debug.LogError(string.Format("UITaskBase.StartUpdatePipeLine {0} m_blockPipeLine=true", base.Name));
				return false;
			}
			if (this.m_currPipeLineCtx.m_isRuning)
			{
				if (enableQueue)
				{
					this.m_piplineQueue.Add(new UITaskBase.PiplineQueueItem
					{
						m_canBeSkip = canBeSkip,
						m_intent = intent,
						m_onlyUpdateView = onlyUpdateView
					});
				}
				return false;
			}
			if (canBeSkip && this.NeedSkipUpdatePipeLine(intent, onlyUpdateView))
			{
				global::Debug.Log("UITaskBase.StartUpdatePipeLine Skiped");
				return true;
			}
			if (intent != null && (this.m_currIntent != intent || this.m_currMode != intent.TargetMode))
			{
				if (!this.SetCurrentMode(intent.TargetMode))
				{
					global::Debug.LogError(string.Format("UITaskBase.StartUpdatePipeLine fail error mode {0}", intent.TargetMode));
					return false;
				}
				this.ClearContextOnIntentChange(intent);
				this.m_currIntent = intent;
			}
			this.m_currPipeLineCtx.m_isRuning = true;
			this.m_lastStartUpdatePipeLineTime = Timer.m_currTick;
			this.EnableUIInput(false, new bool?(false));
			if (onlyUpdateView)
			{
				this.StartUpdateView();
				return true;
			}
			if (this.IsNeedUpdateDataCache())
			{
				this.UpdateDataCache();
			}
			bool flag = this.IsNeedLoadStaticRes();
			bool flag2 = this.IsNeedLoadDynamicRes();
			if (flag || flag2)
			{
				if (flag)
				{
					this.StartLoadStaticRes();
				}
				if (flag2)
				{
					this.StartLoadDynamicRes();
				}
				return true;
			}
			if (this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady != null)
			{
				this.m_blockPipeLine = true;
				this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady();
				return true;
			}
			this.StartUpdateView();
			return true;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002F19C File Offset: 0x0002D39C
		protected virtual bool NeedSkipUpdatePipeLine(UIIntent intent, bool onlyUpdateView)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_NeedSkipUpdatePipeLineUIIntentBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_NeedSkipUpdatePipeLineUIIntentBoolean_hotfix.call(new object[]
				{
					this,
					intent,
					onlyUpdateView
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Timer.m_currTick <= this.m_lastStartUpdatePipeLineTime;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0002F22C File Offset: 0x0002D42C
		protected virtual bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002F28C File Offset: 0x0002D48C
		protected virtual void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0002F2DC File Offset: 0x0002D4DC
		protected virtual bool IsNeedLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_IsNeedLoadStaticRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadStaticRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.MainLayer == null;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002F344 File Offset: 0x0002D544
		protected virtual void StartLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_StartLoadStaticRes_hotfix != null)
			{
				this.m_StartLoadStaticRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<UITaskBase.LayerDesc> list = this.CollectAllStaticResDescForLoad();
			this.CheckLayerDescArray(list);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (this.m_layerArray[list[i].m_index] != null)
				{
					list.RemoveAt(i);
				}
				else
				{
					this.m_loadingStaticResCorutineCount++;
				}
			}
			if (list.Count == 0)
			{
				this.OnLoadStaticResCompleted();
				return;
			}
			foreach (UITaskBase.LayerDesc layerDesc in list)
			{
				string layerName = layerDesc.m_layerName;
				string layerResPath = layerDesc.m_layerResPath;
				bool isUILayer = layerDesc.m_isUILayer;
				int index = layerDesc.m_index;
				if (isUILayer)
				{
					this.m_currPipeLineCtx.m_layerLoadedInPipe = true;
					SceneManager.Instance.CreateLayer(typeof(UISceneLayer), layerName, layerResPath, delegate(SceneLayerBase layer)
					{
						if (layer == null)
						{
							global::Debug.LogError(string.Format("Load Layer fail task={0} layer={1}", this.ToString(), layerName));
							return;
						}
						this.m_layerArray[index] = layer;
						this.m_loadingStaticResCorutineCount--;
						this.OnLoadStaticResCompleted();
					}, false);
				}
				else if (layerResPath.EndsWith(".unity"))
				{
					SceneManager.Instance.CreateLayer(typeof(UnitySceneLayer), layerName, layerResPath, delegate(SceneLayerBase layer)
					{
						if (layer == null)
						{
							global::Debug.LogError(string.Format("Load Layer fail task={0} layer={1}", this.ToString(), layerName));
							return;
						}
						this.m_layerArray[index] = layer;
						this.m_loadingStaticResCorutineCount--;
						this.OnLoadStaticResCompleted();
					}, false);
				}
				else
				{
					this.m_currPipeLineCtx.m_layerLoadedInPipe = true;
					SceneManager.Instance.CreateLayer(typeof(ThreeDSceneLayer), layerName, layerResPath, delegate(SceneLayerBase layer)
					{
						if (layer == null)
						{
							global::Debug.LogError(string.Format("Load Layer fail task={0} layer={1}", this.ToString(), layerName));
							return;
						}
						this.m_layerArray[index] = layer;
						this.m_loadingStaticResCorutineCount--;
						this.OnLoadStaticResCompleted();
					}, false);
				}
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002F548 File Offset: 0x0002D748
		protected virtual void CheckLayerDescArray(List<UITaskBase.LayerDesc> layerDescArray)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_CheckLayerDescArrayList`1_hotfix != null)
			{
				this.m_CheckLayerDescArrayList`1_hotfix.call(new object[]
				{
					this,
					layerDescArray
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (layerDescArray == null || layerDescArray.Count <= 0)
			{
				global::Debug.LogError("StartLoadStaticRes fail LayerDescArray size error");
				throw new Exception("StartLoadStaticRes fail LayerDescArray size error");
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002F5D0 File Offset: 0x0002D7D0
		protected virtual void OnLoadStaticResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnLoadStaticResCompleted_hotfix != null)
			{
				this.m_OnLoadStaticResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsLoadAllResCompleted())
			{
				if (base.State == Task.TaskState.Paused)
				{
					return;
				}
				if (base.State == Task.TaskState.Stopped)
				{
					this.ClearAllContextAndRes();
					return;
				}
				this.OnLoadAllResCompleted();
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002F654 File Offset: 0x0002D854
		protected virtual bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002F6B4 File Offset: 0x0002D8B4
		protected virtual void StartLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_StartLoadDynamicRes_hotfix != null)
			{
				this.m_StartLoadDynamicRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<string> list = this.CollectAllDynamicResForLoad();
			if (list == null || list.Count == 0)
			{
				this.OnLoadDynamicResCompleted();
				return;
			}
			HashSet<string> hashSet = this.CalculateDynamicResReallyNeedLoad(list);
			if (hashSet == null || hashSet.Count == 0)
			{
				this.OnLoadDynamicResCompleted();
				return;
			}
			this.m_loadingDynamicResCorutineCount++;
			ResourceManager.Instance.StartLoadAssetsCorutine(hashSet, this.m_dynamicResCacheDict, delegate
			{
				this.m_loadingDynamicResCorutineCount--;
				this.OnLoadDynamicResCompleted();
			}, false);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0002F770 File Offset: 0x0002D970
		protected virtual List<string> CollectAllDynamicResForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_CollectAllDynamicResForLoad_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return null;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		protected virtual List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_CollectAllStaticResDescForLoad_hotfix != null)
			{
				return (List<UITaskBase.LayerDesc>)this.m_CollectAllStaticResDescForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MainLayer == null)
			{
				List<UITaskBase.LayerDesc> list = new List<UITaskBase.LayerDesc>();
				foreach (UITaskBase.LayerDesc layerDesc in this.LayerDescArray)
				{
					if (!layerDesc.m_isLazyLoad)
					{
						list.Add(layerDesc);
					}
				}
				return list;
			}
			return null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0002F878 File Offset: 0x0002DA78
		protected HashSet<string> CalculateDynamicResReallyNeedLoad(List<string> resPathList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_CalculateDynamicResReallyNeedLoadList`1_hotfix != null)
			{
				return (HashSet<string>)this.m_CalculateDynamicResReallyNeedLoadList`1_hotfix.call(new object[]
				{
					this,
					resPathList
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string text in resPathList)
			{
				if (!string.IsNullOrEmpty(text) && !this.m_dynamicResCacheDict.ContainsKey(text))
				{
					hashSet.Add(text);
				}
			}
			return hashSet;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0002F958 File Offset: 0x0002DB58
		protected virtual void OnLoadDynamicResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnLoadDynamicResCompleted_hotfix != null)
			{
				this.m_OnLoadDynamicResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsLoadAllResCompleted())
			{
				if (base.State == Task.TaskState.Paused)
				{
					return;
				}
				if (base.State == Task.TaskState.Stopped)
				{
					this.ClearAllContextAndRes();
					return;
				}
				this.OnLoadAllResCompleted();
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002F9DC File Offset: 0x0002DBDC
		public void RedirectPipLineOnAllResReady(Action callBack)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_RedirectPipLineOnAllResReadyAction_hotfix != null)
			{
				this.m_RedirectPipLineOnAllResReadyAction_hotfix.call(new object[]
				{
					this,
					callBack
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currPipeLineCtx == null)
			{
				this.m_currPipeLineCtx = this.CreatePipeLineCtx();
			}
			this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady = callBack;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002FA60 File Offset: 0x0002DC60
		protected virtual void OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("OnLoadAllResCompleted task={0}", this.ToString()));
			if (this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady != null)
			{
				this.m_blockPipeLine = true;
				this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady();
				return;
			}
			if (this.m_currPipeLineCtx.m_layerLoadedInPipe)
			{
				this.InitLayerStateOnLoadAllResCompleted();
				this.InitAllUIControllers();
			}
			this.PostOnLoadAllResCompleted();
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002FB10 File Offset: 0x0002DD10
		public void ReturnFromRedirectPipLineOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ReturnFromRedirectPipLineOnLoadAllResCompleted_hotfix != null)
			{
				this.m_ReturnFromRedirectPipLineOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady == null)
			{
				global::Debug.Log("ReturnFromRedirectPipLineOnLoadAllResCompleted error: m_currPipeLineCtx.m_redirectPipLineOnAllResReady == null, can't ReturnFromRedirectPipLine");
				return;
			}
			this.m_currPipeLineCtx.m_redirectPipLineOnAllResReady = null;
			this.m_blockPipeLine = false;
			if (this.m_currPipeLineCtx.m_layerLoadedInPipe)
			{
				this.InitLayerStateOnLoadAllResCompleted();
				this.InitAllUIControllers();
			}
			this.PostOnLoadAllResCompleted();
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002FBB0 File Offset: 0x0002DDB0
		protected virtual void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MainLayer.State != SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PushLayer(this.MainLayer);
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002FC24 File Offset: 0x0002DE24
		protected virtual void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.UICtrlDescArray == null || this.UICtrlDescArray.Length == 0)
			{
				return;
			}
			if (this.m_uiCtrlArray == null)
			{
				this.m_uiCtrlArray = new UIControllerBase[this.UICtrlDescArray.Length];
			}
			List<UIControllerBase> list = new List<UIControllerBase>();
			for (int i = 0; i < this.UICtrlDescArray.Length; i++)
			{
				if (!(this.m_uiCtrlArray[i] != null))
				{
					UITaskBase.UIControllerDesc uicontrollerDesc = this.UICtrlDescArray[i];
					UITaskBase.LayerDesc layerDescByName = this.GetLayerDescByName(uicontrollerDesc.m_attachLayerName);
					SceneLayerBase layerByName = this.GetLayerByName(uicontrollerDesc.m_attachLayerName);
					if (layerByName == null)
					{
						if (layerDescByName != null && layerDescByName.m_isLazyLoad)
						{
							goto IL_185;
						}
						global::Debug.LogError(string.Format("InitAllUIControllers fail for ctrl={0} can not find layer={1} in task={2}", uicontrollerDesc.m_ctrlName, uicontrollerDesc.m_attachLayerName, this.ToString()));
					}
					if (layerByName != null)
					{
						PrefabControllerBase prefabControllerBase = PrefabControllerBase.AddControllerToGameObject(layerByName.LayerPrefabRoot, uicontrollerDesc.m_attachPath, uicontrollerDesc.m_ctrlTypeDNName, uicontrollerDesc.m_ctrlName, uicontrollerDesc.m_luaModuleName, false);
						if (prefabControllerBase == null)
						{
							global::Debug.LogError(string.Format("InitAllUIControllers AddControllerToGameObject fail for ctrl={0} layer={1} in task={2}", uicontrollerDesc.m_ctrlName, uicontrollerDesc.m_attachLayerName, this.ToString()));
						}
						this.m_uiCtrlArray[i] = (prefabControllerBase as UIControllerBase);
						list.Add(prefabControllerBase as UIControllerBase);
					}
				}
				IL_185:;
			}
			foreach (UIControllerBase uicontrollerBase in list)
			{
				if (uicontrollerBase != null)
				{
					uicontrollerBase.BindFields();
				}
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002FE24 File Offset: 0x0002E024
		protected virtual void PostOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_PostOnLoadAllResCompleted_hotfix != null)
			{
				this.m_PostOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartUpdateView();
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0002FE7C File Offset: 0x0002E07C
		protected virtual bool IsLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_IsLoadAllResCompleted_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_loadingStaticResCorutineCount == 0 && this.m_loadingDynamicResCorutineCount == 0;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		protected virtual void StartUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_StartUpdateView_hotfix != null)
			{
				this.m_StartUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playingUpdateViewEffectList.Add(null);
			this.UpdateView();
			this.m_playingUpdateViewEffectList.Remove(null);
			if (this.m_playingUpdateViewEffectList.Count != 0)
			{
				return;
			}
			this.PostUpdateViewBeforeClearContext();
			this.ClearContextOnUpdateViewEnd();
			this.EnableUIInput(true, new bool?(true));
			this.PostUpdateView();
			if (this.EventOnPostUpdateView != null)
			{
				this.EventOnPostUpdateView(this);
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0002FFA8 File Offset: 0x0002E1A8
		protected virtual void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0002FFFC File Offset: 0x0002E1FC
		protected void RegUpdateViewPlayingEffect(string name = null, int timeout = 0, Action<string> onTimeOut = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_RegUpdateViewPlayingEffectStringInt32Action`1_hotfix != null)
			{
				this.m_RegUpdateViewPlayingEffectStringInt32Action`1_hotfix.call(new object[]
				{
					this,
					name,
					timeout,
					onTimeOut
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (name == null)
			{
				this.m_playingUpdateViewEffectList.Add(null);
			}
			UITaskBase.PlayingUpdateViewEffectItem playingUpdateViewEffectItem = new UITaskBase.PlayingUpdateViewEffectItem
			{
				m_name = name
			};
			if (timeout != 0)
			{
				playingUpdateViewEffectItem.m_timeOutTime = new DateTime?(Timer.m_currTime.AddMilliseconds((double)timeout));
				playingUpdateViewEffectItem.m_onTimeOut = onTimeOut;
			}
			this.m_playingUpdateViewEffectList.Add(playingUpdateViewEffectItem);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x000300D0 File Offset: 0x0002E2D0
		protected void UnregUpdateViewPlayingEffect(string name = null, bool isTimeOut = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_UnregUpdateViewPlayingEffectStringBoolean_hotfix != null)
			{
				this.m_UnregUpdateViewPlayingEffectStringBoolean_hotfix.call(new object[]
				{
					this,
					name2,
					isTimeOut
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string name = name2;
			Action<string> action = null;
			if (name == null)
			{
				this.m_playingUpdateViewEffectList.Remove(null);
			}
			else
			{
				UITaskBase.PlayingUpdateViewEffectItem playingUpdateViewEffectItem = this.m_playingUpdateViewEffectList.Find((UITaskBase.PlayingUpdateViewEffectItem litem) => litem.m_name == name);
				if (playingUpdateViewEffectItem != null)
				{
					action = playingUpdateViewEffectItem.m_onTimeOut;
					this.m_playingUpdateViewEffectList.Remove(playingUpdateViewEffectItem);
				}
			}
			if (isTimeOut && action != null)
			{
				action(name);
			}
			if (this.m_playingUpdateViewEffectList.Count == 0)
			{
				this.ClearContextOnUpdateViewEnd();
				this.EnableUIInput(true, new bool?(true));
				this.PostUpdateView();
				if (this.EventOnPostUpdateView != null)
				{
					this.EventOnPostUpdateView(this);
				}
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000301F8 File Offset: 0x0002E3F8
		protected virtual void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_piplineQueue.Count != 0)
			{
				UITaskBase.PiplineQueueItem piplineQueueItem = this.m_piplineQueue[0];
				this.m_piplineQueue.RemoveAt(0);
				this.StartUpdatePipeLine(piplineQueueItem.m_intent, piplineQueueItem.m_onlyUpdateView, piplineQueueItem.m_canBeSkip, true);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0003028C File Offset: 0x0002E48C
		protected virtual void PostUpdateViewBeforeClearContext()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_PostUpdateViewBeforeClearContext_hotfix != null)
			{
				this.m_PostUpdateViewBeforeClearContext_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000302DC File Offset: 0x0002E4DC
		protected virtual void HideAllView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_HideAllView_hotfix != null)
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
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase != null && sceneLayerBase.State == SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PopLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00030388 File Offset: 0x0002E588
		protected virtual void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ClearAllContextAndRes_hotfix != null)
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
				foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
				{
					if (sceneLayerBase != null)
					{
						SceneManager.Instance.FreeLayer(sceneLayerBase);
					}
				}
			}
			this.m_dynamicResCacheDict.Clear();
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00030424 File Offset: 0x0002E624
		protected virtual void SaveContextInIntentOnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SaveContextInIntentOnPause_hotfix != null)
			{
				this.m_SaveContextInIntentOnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00030474 File Offset: 0x0002E674
		protected virtual void ClearContextOnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ClearContextOnPause_hotfix != null)
			{
				this.m_ClearContextOnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000304C4 File Offset: 0x0002E6C4
		protected virtual void ClearContextOnIntentChange(UIIntent newIntent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ClearContextOnIntentChangeUIIntent_hotfix != null)
			{
				this.m_ClearContextOnIntentChangeUIIntent_hotfix.call(new object[]
				{
					this,
					newIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00030524 File Offset: 0x0002E724
		protected virtual void ClearContextOnUpdateViewEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ClearContextOnUpdateViewEnd_hotfix != null)
			{
				this.m_ClearContextOnUpdateViewEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.Clear();
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00030580 File Offset: 0x0002E780
		public virtual void EnableUIInput(bool isEnable, bool? isGlobalEnable = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_EnableUIInputBooleanNullable`1_hotfix != null)
			{
				this.m_EnableUIInputBooleanNullable`1_hotfix.call(new object[]
				{
					this,
					isEnable,
					isGlobalEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isUIInputEnable = isEnable;
			if (isGlobalEnable != null)
			{
				bool value = isGlobalEnable.Value;
				if (value)
				{
					UIManager.Instance.GlobalUIInputEnable(base.Name, true);
				}
				else
				{
					UIManager.Instance.GlobalUIInputEnable(base.Name, false);
				}
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00030638 File Offset: 0x0002E838
		protected UITaskBase.LayerDesc GetLayerDescByName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_GetLayerDescByNameString_hotfix != null)
			{
				return (UITaskBase.LayerDesc)this.m_GetLayerDescByNameString_hotfix.call(new object[]
				{
					this,
					name
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (UITaskBase.LayerDesc layerDesc in this.LayerDescArray)
			{
				if (layerDesc.m_layerName == name)
				{
					return layerDesc;
				}
			}
			return null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000306D8 File Offset: 0x0002E8D8
		protected SceneLayerBase GetLayerByName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_GetLayerByNameString_hotfix != null)
			{
				return (SceneLayerBase)this.m_GetLayerByNameString_hotfix.call(new object[]
				{
					this,
					name
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase != null && sceneLayerBase.LayerName == name)
				{
					return sceneLayerBase;
				}
			}
			return null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00030784 File Offset: 0x0002E984
		protected void RegisterModesDefine(string defaultMode, params string[] modes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_RegisterModesDefineStringStringbe_hotfix != null)
			{
				this.m_RegisterModesDefineStringStringbe_hotfix.call(new object[]
				{
					this,
					defaultMode,
					modes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_modeDefine != null)
			{
				throw new Exception("RegisterModesDefine already called");
			}
			this.m_modeDefine = new List<string>
			{
				defaultMode
			};
			this.m_modeDefine.AddRange(modes);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0003082C File Offset: 0x0002EA2C
		protected virtual bool SetCurrentMode(string mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetCurrentModeString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SetCurrentModeString_hotfix.call(new object[]
				{
					this,
					mode
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currMode == mode)
			{
				return true;
			}
			if (this.m_modeDefine != null)
			{
				if (string.IsNullOrEmpty(mode))
				{
					this.m_currMode = this.m_modeDefine[0];
				}
				else
				{
					if (!this.m_modeDefine.Contains(mode))
					{
						global::Debug.LogError(string.Format("UITaskBase.SetCurrentMode fail error mode {0}", mode));
						return false;
					}
					this.m_currMode = mode;
				}
			}
			return true;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00030908 File Offset: 0x0002EB08
		protected void SetIsNeedPauseTimeOut(bool isNeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetIsNeedPauseTimeOutBoolean_hotfix != null)
			{
				this.m_SetIsNeedPauseTimeOutBoolean_hotfix.call(new object[]
				{
					this,
					isNeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.IsNeedPauseTimeOut = isNeed;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00030970 File Offset: 0x0002EB70
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.TickForDelayTimeExecuteActionList();
			if (this.m_corutineHelper != null)
			{
				this.m_corutineHelper.Tick();
			}
			if (this.m_playingUpdateViewEffectList.Count != 0)
			{
				foreach (UITaskBase.PlayingUpdateViewEffectItem playingUpdateViewEffectItem in this.m_playingUpdateViewEffectList)
				{
					if (playingUpdateViewEffectItem != null)
					{
						DateTime? timeOutTime = playingUpdateViewEffectItem.m_timeOutTime;
						if (timeOutTime != null && playingUpdateViewEffectItem.m_timeOutTime <= Timer.m_currTime)
						{
							this.UnregUpdateViewPlayingEffect(playingUpdateViewEffectItem.m_name, false);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00030A8C File Offset: 0x0002EC8C
		private void TickForDelayTimeExecuteActionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_TickForDelayTimeExecuteActionList_hotfix != null)
			{
				this.m_TickForDelayTimeExecuteActionList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_delayTimeExecList != null && this.m_delayTimeExecList.Count != 0)
			{
				while (this.m_delayTimeExecList.First != null)
				{
					UITaskBase.DelayTimeExecItem value = this.m_delayTimeExecList.First.Value;
					if (!(value.m_execTargetTime <= Timer.m_currTime))
					{
						break;
					}
					value.m_action();
					this.m_delayTimeExecList.RemoveFirst();
				}
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00030B54 File Offset: 0x0002ED54
		public void PostDelayTimeExecuteAction(Action action, float delaySeconds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_PostDelayTimeExecuteActionActionSingle_hotfix != null)
			{
				this.m_PostDelayTimeExecuteActionActionSingle_hotfix.call(new object[]
				{
					this,
					action,
					delaySeconds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (delaySeconds < 0f)
			{
				delaySeconds = 0f;
			}
			UITaskBase.DelayTimeExecItem delayTimeExecItem = new UITaskBase.DelayTimeExecItem
			{
				m_execTargetTime = Timer.m_currTime.AddSeconds((double)delaySeconds),
				m_action = action
			};
			if (this.m_delayTimeExecList.Count == 0 || this.m_delayTimeExecList.Last.Value.m_execTargetTime <= delayTimeExecItem.m_execTargetTime)
			{
				this.m_delayTimeExecList.AddLast(delayTimeExecItem);
			}
			else
			{
				LinkedListNode<UITaskBase.DelayTimeExecItem> linkedListNode = this.m_delayTimeExecList.First;
				while (linkedListNode.Value.m_execTargetTime <= delayTimeExecItem.m_execTargetTime)
				{
					linkedListNode = linkedListNode.Next;
				}
				this.m_delayTimeExecList.AddBefore(linkedListNode, delayTimeExecItem);
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00030C80 File Offset: 0x0002EE80
		public void PostDelayTicksExecuteAction(Action action, ulong delayTickCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_PostDelayTicksExecuteActionActionUInt64_hotfix != null)
			{
				this.m_PostDelayTicksExecuteActionActionUInt64_hotfix.call(new object[]
				{
					this,
					action,
					delayTickCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ExecAfterTicks(action, delayTickCount);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00030CF8 File Offset: 0x0002EEF8
		protected void SetTag(string tag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetTagString_hotfix != null)
			{
				this.m_SetTagString_hotfix.call(new object[]
				{
					this,
					tag
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_tagList == null)
			{
				this.m_tagList = new List<string>();
			}
			if (!this.m_tagList.Contains(tag))
			{
				this.m_tagList.Add(tag);
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00030D8C File Offset: 0x0002EF8C
		public bool HasTag(string tag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_HasTagString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasTagString_hotfix.call(new object[]
				{
					this,
					tag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_tagList != null && this.m_tagList.Contains(tag);
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000B33 RID: 2867 RVA: 0x00030E14 File Offset: 0x0002F014
		// (remove) Token: 0x06000B34 RID: 2868 RVA: 0x00030EA0 File Offset: 0x0002F0A0
		public event Action<UITaskBase> EventOnPostUpdateView
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_add_EventOnPostUpdateViewAction`1_hotfix != null)
				{
					this.m_add_EventOnPostUpdateViewAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UITaskBase> action = this.EventOnPostUpdateView;
				Action<UITaskBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UITaskBase>>(ref this.EventOnPostUpdateView, (Action<UITaskBase>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_remove_EventOnPostUpdateViewAction`1_hotfix != null)
				{
					this.m_remove_EventOnPostUpdateViewAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UITaskBase> action = this.EventOnPostUpdateView;
				Action<UITaskBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UITaskBase>>(ref this.EventOnPostUpdateView, (Action<UITaskBase>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00030F2C File Offset: 0x0002F12C
		public UIIntent CurrentIntent
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_get_CurrentIntent_hotfix != null)
				{
					return (UIIntent)this.m_get_CurrentIntent_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_currIntent;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00030F90 File Offset: 0x0002F190
		protected bool IsUIInputEnable
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_get_IsUIInputEnable_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsUIInputEnable_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isUIInputEnable && UITaskBase.IsGlobalUIInputEnable;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00031000 File Offset: 0x0002F200
		protected static bool IsGlobalUIInputEnable
		{
			get
			{
				return UIManager.Instance.IsGlobalUIInputEnable();
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0003100C File Offset: 0x0002F20C
		protected virtual SceneLayerBase MainLayer
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_get_MainLayer_hotfix != null)
				{
					return (SceneLayerBase)this.m_get_MainLayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return (this.m_layerArray != null && this.m_layerArray.Length != 0) ? this.m_layerArray[0] : null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00031090 File Offset: 0x0002F290
		protected virtual UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000310F8 File Offset: 0x0002F2F8
		protected virtual UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00031160 File Offset: 0x0002F360
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x000311C4 File Offset: 0x0002F3C4
		public bool IsNeedPauseTimeOut
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_get_IsNeedPauseTimeOut_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsNeedPauseTimeOut_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsNeedPauseTimeOut>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_set_IsNeedPauseTimeOutBoolean_hotfix != null)
				{
					this.m_set_IsNeedPauseTimeOutBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsNeedPauseTimeOut>k__BackingField = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0003122C File Offset: 0x0002F42C
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0003124C File Offset: 0x0002F44C
		[DoNotToLua]
		public new UITaskBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UITaskBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00031258 File Offset: 0x0002F458
		private bool __callBase_Start(object param)
		{
			return base.Start(param);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00031264 File Offset: 0x0002F464
		private void __callBase_Stop()
		{
			base.Stop();
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0003126C File Offset: 0x0002F46C
		private void __callBase_Pause()
		{
			base.Pause();
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00031274 File Offset: 0x0002F474
		private bool __callBase_Resume(object param)
		{
			return base.Resume(param);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00031280 File Offset: 0x0002F480
		private void __callBase_ClearOnStopEvent()
		{
			base.ClearOnStopEvent();
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00031288 File Offset: 0x0002F488
		private void __callBase_ExecAfterTicks(Action action, ulong delayTickCount)
		{
			base.ExecAfterTicks(action, delayTickCount);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00031294 File Offset: 0x0002F494
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000312A0 File Offset: 0x0002F4A0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000312A8 File Offset: 0x0002F4A8
		private bool __callBase_OnResume(object param)
		{
			return base.OnResume(param);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000312B4 File Offset: 0x0002F4B4
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000312BC File Offset: 0x0002F4BC
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000312C4 File Offset: 0x0002F4C4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000312CC File Offset: 0x0002F4CC
		private void __callDele_EventOnPostUpdateView(UITaskBase obj)
		{
			Action<UITaskBase> eventOnPostUpdateView = this.EventOnPostUpdateView;
			if (eventOnPostUpdateView != null)
			{
				eventOnPostUpdateView(obj);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000312F0 File Offset: 0x0002F4F0
		private void __clearDele_EventOnPostUpdateView(UITaskBase obj)
		{
			this.EventOnPostUpdateView = null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00031314 File Offset: 0x0002F514
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
					this.m_InitlizeBeforeManagerStartIt_hotfix = (luaObj.RawGet("InitlizeBeforeManagerStartIt") as LuaFunction);
					this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix = (luaObj.RawGet("PrepareForStartOrResume") as LuaFunction);
					this.m_OnStartObject_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_GetPipeLineCtx_hotfix = (luaObj.RawGet("GetPipeLineCtx") as LuaFunction);
					this.m_CreatePipeLineCtx_hotfix = (luaObj.RawGet("CreatePipeLineCtx") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_OnResumeObject_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_StartUpdatePipeLineUIIntentBooleanBooleanBoolean_hotfix = (luaObj.RawGet("StartUpdatePipeLine") as LuaFunction);
					this.m_NeedSkipUpdatePipeLineUIIntentBoolean_hotfix = (luaObj.RawGet("NeedSkipUpdatePipeLine") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_StartLoadStaticRes_hotfix = (luaObj.RawGet("StartLoadStaticRes") as LuaFunction);
					this.m_CheckLayerDescArrayList`1_hotfix = (luaObj.RawGet("CheckLayerDescArray") as LuaFunction);
					this.m_OnLoadStaticResCompleted_hotfix = (luaObj.RawGet("OnLoadStaticResCompleted") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_StartLoadDynamicRes_hotfix = (luaObj.RawGet("StartLoadDynamicRes") as LuaFunction);
					this.m_CollectAllDynamicResForLoad_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_CollectAllStaticResDescForLoad_hotfix = (luaObj.RawGet("CollectAllStaticResDescForLoad") as LuaFunction);
					this.m_CalculateDynamicResReallyNeedLoadList`1_hotfix = (luaObj.RawGet("CalculateDynamicResReallyNeedLoad") as LuaFunction);
					this.m_OnLoadDynamicResCompleted_hotfix = (luaObj.RawGet("OnLoadDynamicResCompleted") as LuaFunction);
					this.m_RedirectPipLineOnAllResReadyAction_hotfix = (luaObj.RawGet("RedirectPipLineOnAllResReady") as LuaFunction);
					this.m_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("OnLoadAllResCompleted") as LuaFunction);
					this.m_ReturnFromRedirectPipLineOnLoadAllResCompleted_hotfix = (luaObj.RawGet("ReturnFromRedirectPipLineOnLoadAllResCompleted") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_PostOnLoadAllResCompleted_hotfix = (luaObj.RawGet("PostOnLoadAllResCompleted") as LuaFunction);
					this.m_IsLoadAllResCompleted_hotfix = (luaObj.RawGet("IsLoadAllResCompleted") as LuaFunction);
					this.m_StartUpdateView_hotfix = (luaObj.RawGet("StartUpdateView") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_RegUpdateViewPlayingEffectStringInt32Action`1_hotfix = (luaObj.RawGet("RegUpdateViewPlayingEffect") as LuaFunction);
					this.m_UnregUpdateViewPlayingEffectStringBoolean_hotfix = (luaObj.RawGet("UnregUpdateViewPlayingEffect") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_PostUpdateViewBeforeClearContext_hotfix = (luaObj.RawGet("PostUpdateViewBeforeClearContext") as LuaFunction);
					this.m_HideAllView_hotfix = (luaObj.RawGet("HideAllView") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_SaveContextInIntentOnPause_hotfix = (luaObj.RawGet("SaveContextInIntentOnPause") as LuaFunction);
					this.m_ClearContextOnPause_hotfix = (luaObj.RawGet("ClearContextOnPause") as LuaFunction);
					this.m_ClearContextOnIntentChangeUIIntent_hotfix = (luaObj.RawGet("ClearContextOnIntentChange") as LuaFunction);
					this.m_ClearContextOnUpdateViewEnd_hotfix = (luaObj.RawGet("ClearContextOnUpdateViewEnd") as LuaFunction);
					this.m_EnableUIInputBooleanNullable`1_hotfix = (luaObj.RawGet("EnableUIInput") as LuaFunction);
					this.m_GetLayerDescByNameString_hotfix = (luaObj.RawGet("GetLayerDescByName") as LuaFunction);
					this.m_GetLayerByNameString_hotfix = (luaObj.RawGet("GetLayerByName") as LuaFunction);
					this.m_RegisterModesDefineStringStringbe_hotfix = (luaObj.RawGet("RegisterModesDefine") as LuaFunction);
					this.m_SetCurrentModeString_hotfix = (luaObj.RawGet("SetCurrentMode") as LuaFunction);
					this.m_SetIsNeedPauseTimeOutBoolean_hotfix = (luaObj.RawGet("SetIsNeedPauseTimeOut") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_TickForDelayTimeExecuteActionList_hotfix = (luaObj.RawGet("TickForDelayTimeExecuteActionList") as LuaFunction);
					this.m_PostDelayTimeExecuteActionActionSingle_hotfix = (luaObj.RawGet("PostDelayTimeExecuteAction") as LuaFunction);
					this.m_PostDelayTicksExecuteActionActionUInt64_hotfix = (luaObj.RawGet("PostDelayTicksExecuteAction") as LuaFunction);
					this.m_SetTagString_hotfix = (luaObj.RawGet("SetTag") as LuaFunction);
					this.m_HasTagString_hotfix = (luaObj.RawGet("HasTag") as LuaFunction);
					this.m_add_EventOnPostUpdateViewAction`1_hotfix = (luaObj.RawGet("add_EventOnPostUpdateView") as LuaFunction);
					this.m_remove_EventOnPostUpdateViewAction`1_hotfix = (luaObj.RawGet("remove_EventOnPostUpdateView") as LuaFunction);
					this.m_get_CurrentIntent_hotfix = (luaObj.RawGet("get_CurrentIntent") as LuaFunction);
					this.m_get_IsUIInputEnable_hotfix = (luaObj.RawGet("get_IsUIInputEnable") as LuaFunction);
					this.m_get_MainLayer_hotfix = (luaObj.RawGet("get_MainLayer") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_get_IsNeedPauseTimeOut_hotfix = (luaObj.RawGet("get_IsNeedPauseTimeOut") as LuaFunction);
					this.m_set_IsNeedPauseTimeOutBoolean_hotfix = (luaObj.RawGet("set_IsNeedPauseTimeOut") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00031A38 File Offset: 0x0002FC38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UITaskBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04000678 RID: 1656
		protected List<string> m_modeDefine;

		// Token: 0x04000679 RID: 1657
		protected UIIntent m_currIntent;

		// Token: 0x0400067A RID: 1658
		protected string m_currMode;

		// Token: 0x0400067B RID: 1659
		protected bool m_isUIInputEnable = true;

		// Token: 0x0400067C RID: 1660
		protected bool m_enableUIInputLog = true;

		// Token: 0x0400067D RID: 1661
		protected int m_loadingStaticResCorutineCount;

		// Token: 0x0400067E RID: 1662
		protected int m_loadingDynamicResCorutineCount;

		// Token: 0x0400067F RID: 1663
		protected List<UITaskBase.PlayingUpdateViewEffectItem> m_playingUpdateViewEffectList = new List<UITaskBase.PlayingUpdateViewEffectItem>();

		// Token: 0x04000680 RID: 1664
		protected SceneLayerBase[] m_layerArray;

		// Token: 0x04000681 RID: 1665
		protected UIControllerBase[] m_uiCtrlArray;

		// Token: 0x04000682 RID: 1666
		protected UITaskPipeLineCtx m_currPipeLineCtx;

		// Token: 0x04000683 RID: 1667
		protected Dictionary<string, UnityEngine.Object> m_dynamicResCacheDict = new Dictionary<string, UnityEngine.Object>();

		// Token: 0x04000684 RID: 1668
		protected TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x04000685 RID: 1669
		protected bool m_blockPipeLine;

		// Token: 0x04000686 RID: 1670
		private ulong m_lastStartUpdatePipeLineTime;

		// Token: 0x04000688 RID: 1672
		private LinkedList<UITaskBase.DelayTimeExecItem> m_delayTimeExecList = new LinkedList<UITaskBase.DelayTimeExecItem>();

		// Token: 0x04000689 RID: 1673
		protected List<UITaskBase.PiplineQueueItem> m_piplineQueue = new List<UITaskBase.PiplineQueueItem>();

		// Token: 0x0400068A RID: 1674
		protected List<string> m_tagList;

		// Token: 0x0400068B RID: 1675
		[DoNotToLua]
		private UITaskBase.LuaExportHelper luaExportHelper;

		// Token: 0x0400068C RID: 1676
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400068D RID: 1677
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400068E RID: 1678
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400068F RID: 1679
		private LuaFunction m_InitlizeBeforeManagerStartIt_hotfix;

		// Token: 0x04000690 RID: 1680
		private LuaFunction m_PrepareForStartOrResumeUIIntentAction;

		// Token: 0x04000691 RID: 1681
		private LuaFunction m_OnStartObject_hotfix;

		// Token: 0x04000692 RID: 1682
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04000693 RID: 1683
		private LuaFunction m_GetPipeLineCtx_hotfix;

		// Token: 0x04000694 RID: 1684
		private LuaFunction m_CreatePipeLineCtx_hotfix;

		// Token: 0x04000695 RID: 1685
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04000696 RID: 1686
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x04000697 RID: 1687
		private LuaFunction m_OnResumeObject_hotfix;

		// Token: 0x04000698 RID: 1688
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04000699 RID: 1689
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x0400069A RID: 1690
		private LuaFunction m_StartUpdatePipeLineUIIntentBooleanBooleanBoolean_hotfix;

		// Token: 0x0400069B RID: 1691
		private LuaFunction m_NeedSkipUpdatePipeLineUIIntentBoolean_hotfix;

		// Token: 0x0400069C RID: 1692
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x0400069D RID: 1693
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x0400069E RID: 1694
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x0400069F RID: 1695
		private LuaFunction m_StartLoadStaticRes_hotfix;

		// Token: 0x040006A0 RID: 1696
		private LuaFunction m_CheckLayerDescArrayList;

		// Token: 0x040006A1 RID: 1697
		private LuaFunction m_OnLoadStaticResCompleted_hotfix;

		// Token: 0x040006A2 RID: 1698
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040006A3 RID: 1699
		private LuaFunction m_StartLoadDynamicRes_hotfix;

		// Token: 0x040006A4 RID: 1700
		private LuaFunction m_CollectAllDynamicResForLoad_hotfix;

		// Token: 0x040006A5 RID: 1701
		private LuaFunction m_CollectAllStaticResDescForLoad_hotfix;

		// Token: 0x040006A6 RID: 1702
		private LuaFunction m_CalculateDynamicResReallyNeedLoadList;

		// Token: 0x040006A7 RID: 1703
		private LuaFunction m_OnLoadDynamicResCompleted_hotfix;

		// Token: 0x040006A8 RID: 1704
		private LuaFunction m_RedirectPipLineOnAllResReadyAction_hotfix;

		// Token: 0x040006A9 RID: 1705
		private LuaFunction m_OnLoadAllResCompleted_hotfix;

		// Token: 0x040006AA RID: 1706
		private LuaFunction m_ReturnFromRedirectPipLineOnLoadAllResCompleted_hotfix;

		// Token: 0x040006AB RID: 1707
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x040006AC RID: 1708
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040006AD RID: 1709
		private LuaFunction m_PostOnLoadAllResCompleted_hotfix;

		// Token: 0x040006AE RID: 1710
		private LuaFunction m_IsLoadAllResCompleted_hotfix;

		// Token: 0x040006AF RID: 1711
		private LuaFunction m_StartUpdateView_hotfix;

		// Token: 0x040006B0 RID: 1712
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040006B1 RID: 1713
		private LuaFunction m_RegUpdateViewPlayingEffectStringInt32Action;

		// Token: 0x040006B2 RID: 1714
		private LuaFunction m_UnregUpdateViewPlayingEffectStringBoolean_hotfix;

		// Token: 0x040006B3 RID: 1715
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x040006B4 RID: 1716
		private LuaFunction m_PostUpdateViewBeforeClearContext_hotfix;

		// Token: 0x040006B5 RID: 1717
		private LuaFunction m_HideAllView_hotfix;

		// Token: 0x040006B6 RID: 1718
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040006B7 RID: 1719
		private LuaFunction m_SaveContextInIntentOnPause_hotfix;

		// Token: 0x040006B8 RID: 1720
		private LuaFunction m_ClearContextOnPause_hotfix;

		// Token: 0x040006B9 RID: 1721
		private LuaFunction m_ClearContextOnIntentChangeUIIntent_hotfix;

		// Token: 0x040006BA RID: 1722
		private LuaFunction m_ClearContextOnUpdateViewEnd_hotfix;

		// Token: 0x040006BB RID: 1723
		private LuaFunction m_EnableUIInputBooleanNullable;

		// Token: 0x040006BC RID: 1724
		private LuaFunction m_GetLayerDescByNameString_hotfix;

		// Token: 0x040006BD RID: 1725
		private LuaFunction m_GetLayerByNameString_hotfix;

		// Token: 0x040006BE RID: 1726
		private LuaFunction m_RegisterModesDefineStringStringbe_hotfix;

		// Token: 0x040006BF RID: 1727
		private LuaFunction m_SetCurrentModeString_hotfix;

		// Token: 0x040006C0 RID: 1728
		private LuaFunction m_SetIsNeedPauseTimeOutBoolean_hotfix;

		// Token: 0x040006C1 RID: 1729
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x040006C2 RID: 1730
		private LuaFunction m_TickForDelayTimeExecuteActionList_hotfix;

		// Token: 0x040006C3 RID: 1731
		private LuaFunction m_PostDelayTimeExecuteActionActionSingle_hotfix;

		// Token: 0x040006C4 RID: 1732
		private LuaFunction m_PostDelayTicksExecuteActionActionUInt64_hotfix;

		// Token: 0x040006C5 RID: 1733
		private LuaFunction m_SetTagString_hotfix;

		// Token: 0x040006C6 RID: 1734
		private LuaFunction m_HasTagString_hotfix;

		// Token: 0x040006C7 RID: 1735
		private LuaFunction m_add_EventOnPostUpdateViewAction;

		// Token: 0x040006C8 RID: 1736
		private LuaFunction m_remove_EventOnPostUpdateViewAction;

		// Token: 0x040006C9 RID: 1737
		private LuaFunction m_get_CurrentIntent_hotfix;

		// Token: 0x040006CA RID: 1738
		private LuaFunction m_get_IsUIInputEnable_hotfix;

		// Token: 0x040006CB RID: 1739
		private LuaFunction m_get_MainLayer_hotfix;

		// Token: 0x040006CC RID: 1740
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040006CD RID: 1741
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x040006CE RID: 1742
		private LuaFunction m_get_IsNeedPauseTimeOut_hotfix;

		// Token: 0x040006CF RID: 1743
		private LuaFunction m_set_IsNeedPauseTimeOutBoolean_hotfix;

		// Token: 0x02000112 RID: 274
		public class PlayingUpdateViewEffectItem
		{
			// Token: 0x040006D0 RID: 1744
			public string m_name;

			// Token: 0x040006D1 RID: 1745
			public DateTime? m_timeOutTime;

			// Token: 0x040006D2 RID: 1746
			public Action<string> m_onTimeOut;
		}

		// Token: 0x02000113 RID: 275
		[CustomLuaClass]
		public class LayerDesc
		{
			// Token: 0x040006D3 RID: 1747
			public string m_layerName;

			// Token: 0x040006D4 RID: 1748
			public string m_layerResPath;

			// Token: 0x040006D5 RID: 1749
			public bool m_isUILayer;

			// Token: 0x040006D6 RID: 1750
			public bool m_isLazyLoad;

			// Token: 0x040006D7 RID: 1751
			public int m_index;

			// Token: 0x040006D8 RID: 1752
			public bool m_isReserve;
		}

		// Token: 0x02000114 RID: 276
		[CustomLuaClass]
		public class UIControllerDesc
		{
			// Token: 0x040006D9 RID: 1753
			public string m_ctrlName;

			// Token: 0x040006DA RID: 1754
			public string m_luaModuleName;

			// Token: 0x040006DB RID: 1755
			public TypeDNName m_ctrlTypeDNName;

			// Token: 0x040006DC RID: 1756
			public string m_attachLayerName;

			// Token: 0x040006DD RID: 1757
			public string m_attachPath;
		}

		// Token: 0x02000115 RID: 277
		public class DelayTimeExecItem
		{
			// Token: 0x040006DE RID: 1758
			public DateTime m_execTargetTime;

			// Token: 0x040006DF RID: 1759
			public Action m_action;
		}

		// Token: 0x02000116 RID: 278
		public class PiplineQueueItem
		{
			// Token: 0x040006E0 RID: 1760
			public UIIntent m_intent;

			// Token: 0x040006E1 RID: 1761
			public bool m_onlyUpdateView;

			// Token: 0x040006E2 RID: 1762
			public bool m_canBeSkip;
		}

		// Token: 0x02000117 RID: 279
		public new class LuaExportHelper
		{
			// Token: 0x06000B55 RID: 2901 RVA: 0x00031AC8 File Offset: 0x0002FCC8
			public LuaExportHelper(UITaskBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000B56 RID: 2902 RVA: 0x00031AD8 File Offset: 0x0002FCD8
			public bool __callBase_Start(object param)
			{
				return this.m_owner.__callBase_Start(param);
			}

			// Token: 0x06000B57 RID: 2903 RVA: 0x00031AE8 File Offset: 0x0002FCE8
			public void __callBase_Stop()
			{
				this.m_owner.__callBase_Stop();
			}

			// Token: 0x06000B58 RID: 2904 RVA: 0x00031AF8 File Offset: 0x0002FCF8
			public void __callBase_Pause()
			{
				this.m_owner.__callBase_Pause();
			}

			// Token: 0x06000B59 RID: 2905 RVA: 0x00031B08 File Offset: 0x0002FD08
			public bool __callBase_Resume(object param)
			{
				return this.m_owner.__callBase_Resume(param);
			}

			// Token: 0x06000B5A RID: 2906 RVA: 0x00031B18 File Offset: 0x0002FD18
			public void __callBase_ClearOnStopEvent()
			{
				this.m_owner.__callBase_ClearOnStopEvent();
			}

			// Token: 0x06000B5B RID: 2907 RVA: 0x00031B28 File Offset: 0x0002FD28
			public void __callBase_ExecAfterTicks(Action action, ulong delayTickCount)
			{
				this.m_owner.__callBase_ExecAfterTicks(action, delayTickCount);
			}

			// Token: 0x06000B5C RID: 2908 RVA: 0x00031B38 File Offset: 0x0002FD38
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x00031B48 File Offset: 0x0002FD48
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x00031B58 File Offset: 0x0002FD58
			public bool __callBase_OnResume(object param)
			{
				return this.m_owner.__callBase_OnResume(param);
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x00031B68 File Offset: 0x0002FD68
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x00031B78 File Offset: 0x0002FD78
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x00031B88 File Offset: 0x0002FD88
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x00031B98 File Offset: 0x0002FD98
			public void __callDele_EventOnPostUpdateView(UITaskBase obj)
			{
				this.m_owner.__callDele_EventOnPostUpdateView(obj);
			}

			// Token: 0x06000B63 RID: 2915 RVA: 0x00031BA8 File Offset: 0x0002FDA8
			public void __clearDele_EventOnPostUpdateView(UITaskBase obj)
			{
				this.m_owner.__clearDele_EventOnPostUpdateView(obj);
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00031BB8 File Offset: 0x0002FDB8
			// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00031BC8 File Offset: 0x0002FDC8
			public List<string> m_modeDefine
			{
				get
				{
					return this.m_owner.m_modeDefine;
				}
				set
				{
					this.m_owner.m_modeDefine = value;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00031BD8 File Offset: 0x0002FDD8
			// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00031BE8 File Offset: 0x0002FDE8
			public UIIntent m_currIntent
			{
				get
				{
					return this.m_owner.m_currIntent;
				}
				set
				{
					this.m_owner.m_currIntent = value;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00031BF8 File Offset: 0x0002FDF8
			// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00031C08 File Offset: 0x0002FE08
			public string m_currMode
			{
				get
				{
					return this.m_owner.m_currMode;
				}
				set
				{
					this.m_owner.m_currMode = value;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00031C18 File Offset: 0x0002FE18
			// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00031C28 File Offset: 0x0002FE28
			public bool m_isUIInputEnable
			{
				get
				{
					return this.m_owner.m_isUIInputEnable;
				}
				set
				{
					this.m_owner.m_isUIInputEnable = value;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00031C38 File Offset: 0x0002FE38
			// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00031C48 File Offset: 0x0002FE48
			public bool m_enableUIInputLog
			{
				get
				{
					return this.m_owner.m_enableUIInputLog;
				}
				set
				{
					this.m_owner.m_enableUIInputLog = value;
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00031C58 File Offset: 0x0002FE58
			// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00031C68 File Offset: 0x0002FE68
			public int m_loadingStaticResCorutineCount
			{
				get
				{
					return this.m_owner.m_loadingStaticResCorutineCount;
				}
				set
				{
					this.m_owner.m_loadingStaticResCorutineCount = value;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00031C78 File Offset: 0x0002FE78
			// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00031C88 File Offset: 0x0002FE88
			public int m_loadingDynamicResCorutineCount
			{
				get
				{
					return this.m_owner.m_loadingDynamicResCorutineCount;
				}
				set
				{
					this.m_owner.m_loadingDynamicResCorutineCount = value;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00031C98 File Offset: 0x0002FE98
			// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00031CA8 File Offset: 0x0002FEA8
			public List<UITaskBase.PlayingUpdateViewEffectItem> m_playingUpdateViewEffectList
			{
				get
				{
					return this.m_owner.m_playingUpdateViewEffectList;
				}
				set
				{
					this.m_owner.m_playingUpdateViewEffectList = value;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00031CB8 File Offset: 0x0002FEB8
			// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00031CC8 File Offset: 0x0002FEC8
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

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00031CD8 File Offset: 0x0002FED8
			// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00031CE8 File Offset: 0x0002FEE8
			public UIControllerBase[] m_uiCtrlArray
			{
				get
				{
					return this.m_owner.m_uiCtrlArray;
				}
				set
				{
					this.m_owner.m_uiCtrlArray = value;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00031CF8 File Offset: 0x0002FEF8
			// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00031D08 File Offset: 0x0002FF08
			public UITaskPipeLineCtx m_currPipeLineCtx
			{
				get
				{
					return this.m_owner.m_currPipeLineCtx;
				}
				set
				{
					this.m_owner.m_currPipeLineCtx = value;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00031D18 File Offset: 0x0002FF18
			// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00031D28 File Offset: 0x0002FF28
			public Dictionary<string, UnityEngine.Object> m_dynamicResCacheDict
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

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00031D38 File Offset: 0x0002FF38
			// (set) Token: 0x06000B7D RID: 2941 RVA: 0x00031D48 File Offset: 0x0002FF48
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

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00031D58 File Offset: 0x0002FF58
			// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00031D68 File Offset: 0x0002FF68
			public bool m_blockPipeLine
			{
				get
				{
					return this.m_owner.m_blockPipeLine;
				}
				set
				{
					this.m_owner.m_blockPipeLine = value;
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00031D78 File Offset: 0x0002FF78
			// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00031D88 File Offset: 0x0002FF88
			public ulong m_lastStartUpdatePipeLineTime
			{
				get
				{
					return this.m_owner.m_lastStartUpdatePipeLineTime;
				}
				set
				{
					this.m_owner.m_lastStartUpdatePipeLineTime = value;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00031D98 File Offset: 0x0002FF98
			// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00031DA8 File Offset: 0x0002FFA8
			public LinkedList<UITaskBase.DelayTimeExecItem> m_delayTimeExecList
			{
				get
				{
					return this.m_owner.m_delayTimeExecList;
				}
				set
				{
					this.m_owner.m_delayTimeExecList = value;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00031DB8 File Offset: 0x0002FFB8
			// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00031DC8 File Offset: 0x0002FFC8
			public List<UITaskBase.PiplineQueueItem> m_piplineQueue
			{
				get
				{
					return this.m_owner.m_piplineQueue;
				}
				set
				{
					this.m_owner.m_piplineQueue = value;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00031DD8 File Offset: 0x0002FFD8
			// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00031DE8 File Offset: 0x0002FFE8
			public List<string> m_tagList
			{
				get
				{
					return this.m_owner.m_tagList;
				}
				set
				{
					this.m_owner.m_tagList = value;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00031DF8 File Offset: 0x0002FFF8
			public bool IsUIInputEnable
			{
				get
				{
					return this.m_owner.IsUIInputEnable;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00031E08 File Offset: 0x00030008
			public static bool IsGlobalUIInputEnable
			{
				get
				{
					return UITaskBase.IsGlobalUIInputEnable;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00031E10 File Offset: 0x00030010
			public SceneLayerBase MainLayer
			{
				get
				{
					return this.m_owner.MainLayer;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00031E20 File Offset: 0x00030020
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00031E30 File Offset: 0x00030030
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x17000133 RID: 307
			// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00031E40 File Offset: 0x00030040
			public bool IsNeedPauseTimeOut
			{
				set
				{
					this.m_owner.IsNeedPauseTimeOut = value;
				}
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x00031E50 File Offset: 0x00030050
			public bool OnStart(object param)
			{
				return this.m_owner.OnStart(param);
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x00031E60 File Offset: 0x00030060
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x00031E70 File Offset: 0x00030070
			public UITaskPipeLineCtx GetPipeLineCtx()
			{
				return this.m_owner.GetPipeLineCtx();
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x00031E80 File Offset: 0x00030080
			public UITaskPipeLineCtx CreatePipeLineCtx()
			{
				return this.m_owner.CreatePipeLineCtx();
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x00031E90 File Offset: 0x00030090
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x00031EA0 File Offset: 0x000300A0
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x00031EB0 File Offset: 0x000300B0
			public bool OnResume(object param)
			{
				return this.m_owner.OnResume(param);
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x00031EC0 File Offset: 0x000300C0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06000B96 RID: 2966 RVA: 0x00031ED0 File Offset: 0x000300D0
			public bool StartUpdatePipeLine(UIIntent intent, bool onlyUpdateView, bool canBeSkip, bool enableQueue)
			{
				return this.m_owner.StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x00031EE4 File Offset: 0x000300E4
			public bool NeedSkipUpdatePipeLine(UIIntent intent, bool onlyUpdateView)
			{
				return this.m_owner.NeedSkipUpdatePipeLine(intent, onlyUpdateView);
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x00031EF4 File Offset: 0x000300F4
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x06000B99 RID: 2969 RVA: 0x00031F04 File Offset: 0x00030104
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x06000B9A RID: 2970 RVA: 0x00031F14 File Offset: 0x00030114
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x06000B9B RID: 2971 RVA: 0x00031F24 File Offset: 0x00030124
			public void StartLoadStaticRes()
			{
				this.m_owner.StartLoadStaticRes();
			}

			// Token: 0x06000B9C RID: 2972 RVA: 0x00031F34 File Offset: 0x00030134
			public void CheckLayerDescArray(List<UITaskBase.LayerDesc> layerDescArray)
			{
				this.m_owner.CheckLayerDescArray(layerDescArray);
			}

			// Token: 0x06000B9D RID: 2973 RVA: 0x00031F44 File Offset: 0x00030144
			public void OnLoadStaticResCompleted()
			{
				this.m_owner.OnLoadStaticResCompleted();
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x00031F54 File Offset: 0x00030154
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x00031F64 File Offset: 0x00030164
			public void StartLoadDynamicRes()
			{
				this.m_owner.StartLoadDynamicRes();
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x00031F74 File Offset: 0x00030174
			public List<string> CollectAllDynamicResForLoad()
			{
				return this.m_owner.CollectAllDynamicResForLoad();
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x00031F84 File Offset: 0x00030184
			public List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
			{
				return this.m_owner.CollectAllStaticResDescForLoad();
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x00031F94 File Offset: 0x00030194
			public HashSet<string> CalculateDynamicResReallyNeedLoad(List<string> resPathList)
			{
				return this.m_owner.CalculateDynamicResReallyNeedLoad(resPathList);
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x00031FA4 File Offset: 0x000301A4
			public void OnLoadDynamicResCompleted()
			{
				this.m_owner.OnLoadDynamicResCompleted();
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x00031FB4 File Offset: 0x000301B4
			public void OnLoadAllResCompleted()
			{
				this.m_owner.OnLoadAllResCompleted();
			}

			// Token: 0x06000BA5 RID: 2981 RVA: 0x00031FC4 File Offset: 0x000301C4
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x00031FD4 File Offset: 0x000301D4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06000BA7 RID: 2983 RVA: 0x00031FE4 File Offset: 0x000301E4
			public void PostOnLoadAllResCompleted()
			{
				this.m_owner.PostOnLoadAllResCompleted();
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x00031FF4 File Offset: 0x000301F4
			public bool IsLoadAllResCompleted()
			{
				return this.m_owner.IsLoadAllResCompleted();
			}

			// Token: 0x06000BA9 RID: 2985 RVA: 0x00032004 File Offset: 0x00030204
			public void StartUpdateView()
			{
				this.m_owner.StartUpdateView();
			}

			// Token: 0x06000BAA RID: 2986 RVA: 0x00032014 File Offset: 0x00030214
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06000BAB RID: 2987 RVA: 0x00032024 File Offset: 0x00030224
			public void RegUpdateViewPlayingEffect(string name, int timeout, Action<string> onTimeOut)
			{
				this.m_owner.RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
			}

			// Token: 0x06000BAC RID: 2988 RVA: 0x00032034 File Offset: 0x00030234
			public void UnregUpdateViewPlayingEffect(string name, bool isTimeOut)
			{
				this.m_owner.UnregUpdateViewPlayingEffect(name, isTimeOut);
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x00032044 File Offset: 0x00030244
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x06000BAE RID: 2990 RVA: 0x00032054 File Offset: 0x00030254
			public void PostUpdateViewBeforeClearContext()
			{
				this.m_owner.PostUpdateViewBeforeClearContext();
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x00032064 File Offset: 0x00030264
			public void HideAllView()
			{
				this.m_owner.HideAllView();
			}

			// Token: 0x06000BB0 RID: 2992 RVA: 0x00032074 File Offset: 0x00030274
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x00032084 File Offset: 0x00030284
			public void SaveContextInIntentOnPause()
			{
				this.m_owner.SaveContextInIntentOnPause();
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x00032094 File Offset: 0x00030294
			public void ClearContextOnPause()
			{
				this.m_owner.ClearContextOnPause();
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x000320A4 File Offset: 0x000302A4
			public void ClearContextOnIntentChange(UIIntent newIntent)
			{
				this.m_owner.ClearContextOnIntentChange(newIntent);
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x000320B4 File Offset: 0x000302B4
			public void ClearContextOnUpdateViewEnd()
			{
				this.m_owner.ClearContextOnUpdateViewEnd();
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x000320C4 File Offset: 0x000302C4
			public UITaskBase.LayerDesc GetLayerDescByName(string name)
			{
				return this.m_owner.GetLayerDescByName(name);
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x000320D4 File Offset: 0x000302D4
			public SceneLayerBase GetLayerByName(string name)
			{
				return this.m_owner.GetLayerByName(name);
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x000320E4 File Offset: 0x000302E4
			public void RegisterModesDefine(string defaultMode, string[] modes)
			{
				this.m_owner.RegisterModesDefine(defaultMode, modes);
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x000320F4 File Offset: 0x000302F4
			public bool SetCurrentMode(string mode)
			{
				return this.m_owner.SetCurrentMode(mode);
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x00032104 File Offset: 0x00030304
			public void SetIsNeedPauseTimeOut(bool isNeed)
			{
				this.m_owner.SetIsNeedPauseTimeOut(isNeed);
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x00032114 File Offset: 0x00030314
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06000BBB RID: 3003 RVA: 0x00032124 File Offset: 0x00030324
			public void TickForDelayTimeExecuteActionList()
			{
				this.m_owner.TickForDelayTimeExecuteActionList();
			}

			// Token: 0x06000BBC RID: 3004 RVA: 0x00032134 File Offset: 0x00030334
			public void SetTag(string tag)
			{
				this.m_owner.SetTag(tag);
			}

			// Token: 0x040006E3 RID: 1763
			private UITaskBase m_owner;
		}
	}
}
