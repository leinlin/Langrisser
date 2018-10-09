using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EBD RID: 3773
	[HotFix]
	public class RankingUITask : UITask
	{
		// Token: 0x0601273E RID: 75582 RVA: 0x004BC62C File Offset: 0x004BA82C
		public RankingUITask(string name) : base(typeof(RankingUITask).Name)
		{
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

		// Token: 0x0601273F RID: 75583 RVA: 0x004BC7DC File Offset: 0x004BA9DC
		public static void StartRankingUITask(Action<bool> onPrepareEnd, UIIntent prevIntent, RankingListType rankingType)
		{
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(prevIntent, typeof(RankingUITask).Name, null);
			uiintentReturnable.SetParam(RankingUITask.ParamKey_RankingType, rankingType);
			UIManager.Instance.StartUITaskWithPrepare(uiintentReturnable, onPrepareEnd, true);
		}

		// Token: 0x06012740 RID: 75584 RVA: 0x004BC820 File Offset: 0x004BAA20
		public override void PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix != null)
			{
				this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix.call(new object[]
				{
					this,
					intent,
					onPrepareEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<bool> onPrepareEnd = onPrepareEnd2;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			RankingListType structParam = uiintentCustom.GetStructParam<RankingListType>(RankingUITask.ParamKey_RankingType);
			if (!projectLPlayerContext.IsRankingListInfoValid(structParam))
			{
				RankingNetTask rankingNetTask = new RankingNetTask(structParam, 0);
				rankingNetTask.EventOnStop += delegate(Task task)
				{
					RankingNetTask rankingNetTask2 = task as RankingNetTask;
					if (rankingNetTask2.Result == 0)
					{
						onPrepareEnd(true);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(rankingNetTask2.Result, 2f, null, true);
						onPrepareEnd(false);
					}
				};
				rankingNetTask.Start(null);
			}
			else
			{
				onPrepareEnd(true);
			}
		}

		// Token: 0x06012741 RID: 75585 RVA: 0x004BC918 File Offset: 0x004BAB18
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx = base.GetPipeLineCtx();
			this.InitPipeLineCtxStateFromUIIntent(intent);
			this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsNeedLoadDynamic);
			this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsRefreshRankingList);
			return base.OnStart(intent);
		}

		// Token: 0x06012742 RID: 75586 RVA: 0x004BC9BC File Offset: 0x004BABBC
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitPipeLineCtxStateFromUIIntent(intent);
			this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsNeedLoadDynamic);
			this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsRefreshRankingList);
			return base.OnResume(intent);
		}

		// Token: 0x06012743 RID: 75587 RVA: 0x004BCA54 File Offset: 0x004BAC54
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return true;
		}

		// Token: 0x06012744 RID: 75588 RVA: 0x004BCAC4 File Offset: 0x004BACC4
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_currRankList = projectLPlayerContext.GetRankingListInfoByType(this.m_currRankListType);
			if (this.m_currRankList == null)
			{
				Debug.LogError("RankListUITask UpdateDataCache error, m_currRankList == null");
				return;
			}
		}

		// Token: 0x06012745 RID: 75589 RVA: 0x004BCB5C File Offset: 0x004BAD5C
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsPipelineStateMaskNeedUpdate(RankingUITask.PipeLineStateMaskType.IsNeedLoadDynamic);
		}

		// Token: 0x06012746 RID: 75590 RVA: 0x004BCBD0 File Offset: 0x004BADD0
		protected override List<string> CollectAllDynamicResForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllDynamicResForLoad_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			foreach (RankingTargetPlayerInfo rankingTargetPlayerInfo in this.m_currRankList.PlayerList)
			{
				string playerHeadIconImageName = UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(rankingTargetPlayerInfo.PlayerInfo.HeadIcon));
				if (!string.IsNullOrEmpty(playerHeadIconImageName))
				{
					base.CollectSpriteAsset(playerHeadIconImageName);
				}
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string playerHeadIconImageName2 = UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait());
			if (!string.IsNullOrEmpty(playerHeadIconImageName2))
			{
				base.CollectSpriteAsset(playerHeadIconImageName2);
			}
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06012747 RID: 75591 RVA: 0x004BCCF0 File Offset: 0x004BAEF0
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_uiCtrlArray.Length != 0)
			{
				this.m_mainCtrl = (this.m_uiCtrlArray[0] as RankingUIController);
				this.m_rankingListUICtrl = (this.m_uiCtrlArray[1] as RankingListUIController);
			}
			if (this.m_mainCtrl != null)
			{
				this.m_mainCtrl.EventOnRankingTypeMenuClick += this.OnRankingTypeMenuClick;
				this.m_mainCtrl.EventOnResetRankingType += this.OnResetRankingType;
				this.m_mainCtrl.EventOnRetunButtonClick += this.OnReturnButtonClick;
			}
			if (this.m_rankingListUICtrl != null)
			{
				this.m_rankingListUICtrl.CreateItemListPool(10);
			}
		}

		// Token: 0x06012748 RID: 75592 RVA: 0x004BCE00 File Offset: 0x004BB000
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mainCtrl != null)
			{
				this.m_mainCtrl.UpdateRankingUICtrl(this.m_currRankListType);
			}
			if (this.IsPipelineStateMaskNeedUpdate(RankingUITask.PipeLineStateMaskType.IsRefreshRankingList) && this.m_rankingListUICtrl != null)
			{
				this.m_rankingListUICtrl.UpdateRankingListInfo(this.m_currRankList);
			}
		}

		// Token: 0x06012749 RID: 75593 RVA: 0x004BCEB0 File Offset: 0x004BB0B0
		protected void OnRankingTypeMenuClick(RankingListType rankingType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankingTypeMenuClickRankingListType_hotfix != null)
			{
				this.m_OnRankingTypeMenuClickRankingListType_hotfix.call(new object[]
				{
					this,
					rankingType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RankingListType rankingType = rankingType2;
			RankingUITask $this = this;
			if (this.m_currRankListType == rankingType)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsRankingListInfoValid(rankingType))
			{
				int errorCode = 0;
				if (!projectLPlayerContext.IsAbleQueryRankingListInfo(rankingType, out errorCode))
				{
					CommonUIController.Instance.ShowErrorMessage(errorCode, 2f, null, true);
					return;
				}
				RankingNetTask rankingNetTask = new RankingNetTask(rankingType, 0);
				rankingNetTask.EventOnStop += delegate(Task task)
				{
					RankingNetTask rankingNetTask2 = task as RankingNetTask;
					if (rankingNetTask2.Result == 0)
					{
						$this.m_currRankListType = rankingType;
						$this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsNeedLoadDynamic);
						$this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsRefreshRankingList);
						$this.StartUpdatePipeLine($this.m_currIntent, false, false, true);
						return;
					}
					CommonUIController.Instance.ShowErrorMessage(rankingNetTask2.Result, 2f, null, true);
					$this.StartUpdatePipeLine($this.m_currIntent, false, false, true);
				};
				rankingNetTask.Start(null);
			}
			else
			{
				this.m_currRankListType = rankingType;
				this.EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType.IsRefreshRankingList);
				base.StartUpdatePipeLine(this.m_currIntent, false, false, true);
			}
		}

		// Token: 0x0601274A RID: 75594 RVA: 0x004BCFE4 File Offset: 0x004BB1E4
		protected void OnResetRankingType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResetRankingType_hotfix != null)
			{
				this.m_OnResetRankingType_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(this.m_currIntent, true, false, true);
		}

		// Token: 0x0601274B RID: 75595 RVA: 0x004BD054 File Offset: 0x004BB254
		protected void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			base.ReturnPrevUITask();
		}

		// Token: 0x0601274C RID: 75596 RVA: 0x004BD0C4 File Offset: 0x004BB2C4
		protected void InitPipeLineCtxStateFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPipeLineCtxStateFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitPipeLineCtxStateFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			this.m_currRankListType = uiintentCustom.GetStructParam<RankingListType>(RankingUITask.ParamKey_RankingType);
		}

		// Token: 0x0601274D RID: 75597 RVA: 0x004BD14C File Offset: 0x004BB34C
		protected bool IsPipelineStateMaskNeedUpdate(RankingUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currPipeLineCtx.IsNeedUpdate((int)state);
		}

		// Token: 0x0601274E RID: 75598 RVA: 0x004BD1D4 File Offset: 0x004BB3D4
		protected void EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix != null)
			{
				this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.AddUpdateMask((int)state);
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0601274F RID: 75599 RVA: 0x004BD250 File Offset: 0x004BB450
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x06012750 RID: 75600 RVA: 0x004BD2C4 File Offset: 0x004BB4C4
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x06012751 RID: 75601 RVA: 0x004BD338 File Offset: 0x004BB538
		// (set) Token: 0x06012752 RID: 75602 RVA: 0x004BD358 File Offset: 0x004BB558
		[DoNotToLua]
		public new RankingUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RankingUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012753 RID: 75603 RVA: 0x004BD364 File Offset: 0x004BB564
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06012754 RID: 75604 RVA: 0x004BD370 File Offset: 0x004BB570
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06012755 RID: 75605 RVA: 0x004BD378 File Offset: 0x004BB578
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06012756 RID: 75606 RVA: 0x004BD380 File Offset: 0x004BB580
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06012757 RID: 75607 RVA: 0x004BD38C File Offset: 0x004BB58C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06012758 RID: 75608 RVA: 0x004BD398 File Offset: 0x004BB598
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06012759 RID: 75609 RVA: 0x004BD3A4 File Offset: 0x004BB5A4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601275A RID: 75610 RVA: 0x004BD3AC File Offset: 0x004BB5AC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601275B RID: 75611 RVA: 0x004BD3B4 File Offset: 0x004BB5B4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601275C RID: 75612 RVA: 0x004BD3BC File Offset: 0x004BB5BC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601275D RID: 75613 RVA: 0x004BD3C4 File Offset: 0x004BB5C4
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601275E RID: 75614 RVA: 0x004BD3CC File Offset: 0x004BB5CC
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601275F RID: 75615 RVA: 0x004BD3D4 File Offset: 0x004BB5D4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06012760 RID: 75616 RVA: 0x004BD3DC File Offset: 0x004BB5DC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06012761 RID: 75617 RVA: 0x004BD3E8 File Offset: 0x004BB5E8
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06012762 RID: 75618 RVA: 0x004BD3F4 File Offset: 0x004BB5F4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06012763 RID: 75619 RVA: 0x004BD400 File Offset: 0x004BB600
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06012764 RID: 75620 RVA: 0x004BD40C File Offset: 0x004BB60C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06012765 RID: 75621 RVA: 0x004BD414 File Offset: 0x004BB614
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06012766 RID: 75622 RVA: 0x004BD41C File Offset: 0x004BB61C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06012767 RID: 75623 RVA: 0x004BD424 File Offset: 0x004BB624
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06012768 RID: 75624 RVA: 0x004BD42C File Offset: 0x004BB62C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06012769 RID: 75625 RVA: 0x004BD434 File Offset: 0x004BB634
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601276B RID: 75627 RVA: 0x004BD448 File Offset: 0x004BB648
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix = (luaObj.RawGet("PrepareForStartOrResume") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectAllDynamicResForLoad_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnRankingTypeMenuClickRankingListType_hotfix = (luaObj.RawGet("OnRankingTypeMenuClick") as LuaFunction);
					this.m_OnResetRankingType_hotfix = (luaObj.RawGet("OnResetRankingType") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_InitPipeLineCtxStateFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitPipeLineCtxStateFromUIIntent") as LuaFunction);
					this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix = (luaObj.RawGet("IsPipelineStateMaskNeedUpdate") as LuaFunction);
					this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix = (luaObj.RawGet("EnablePipelineStateMask") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601276C RID: 75628 RVA: 0x004BD6BC File Offset: 0x004BB8BC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A603 RID: 42499
		protected RankingListType m_currRankListType;

		// Token: 0x0400A604 RID: 42500
		protected RankingListInfo m_currRankList;

		// Token: 0x0400A605 RID: 42501
		private RankingUIController m_mainCtrl;

		// Token: 0x0400A606 RID: 42502
		private RankingListUIController m_rankingListUICtrl;

		// Token: 0x0400A607 RID: 42503
		protected static string ParamKey_RankingType = "RankingType";

		// Token: 0x0400A608 RID: 42504
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "RankingListUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/RankingList_ABS/Prefab/RankingListUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A609 RID: 42505
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RankingListUILayer",
				m_attachPath = "RankingListUIPrefab",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RankingUIController"),
				m_ctrlName = "RankingUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RankingListUILayer",
				m_attachPath = "RankingListUIPrefab/ListGroup",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RankingListUIController"),
				m_ctrlName = "RankingListUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RankingListUILayer",
				m_attachPath = "RankingListUIPrefab/ListGroup/PlayerInfoGroup",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.SelfRankingListItemUIController"),
				m_ctrlName = "SelfRankingListItemUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RankingListUILayer",
				m_attachPath = "RankingListUIPrefab/SubMenumGroup/NoneSubMenuArea",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RankingSubMenuUIController"),
				m_ctrlName = "RankingSubMenuUIController"
			}
		};

		// Token: 0x0400A60A RID: 42506
		[DoNotToLua]
		private RankingUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A60B RID: 42507
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A60C RID: 42508
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A60D RID: 42509
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A60E RID: 42510
		private LuaFunction m_PrepareForStartOrResumeUIIntentAction;

		// Token: 0x0400A60F RID: 42511
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A610 RID: 42512
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A611 RID: 42513
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x0400A612 RID: 42514
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x0400A613 RID: 42515
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A614 RID: 42516
		private LuaFunction m_CollectAllDynamicResForLoad_hotfix;

		// Token: 0x0400A615 RID: 42517
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A616 RID: 42518
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A617 RID: 42519
		private LuaFunction m_OnRankingTypeMenuClickRankingListType_hotfix;

		// Token: 0x0400A618 RID: 42520
		private LuaFunction m_OnResetRankingType_hotfix;

		// Token: 0x0400A619 RID: 42521
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400A61A RID: 42522
		private LuaFunction m_InitPipeLineCtxStateFromUIIntentUIIntent_hotfix;

		// Token: 0x0400A61B RID: 42523
		private LuaFunction m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix;

		// Token: 0x0400A61C RID: 42524
		private LuaFunction m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix;

		// Token: 0x0400A61D RID: 42525
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A61E RID: 42526
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000EBE RID: 3774
		public enum PipeLineStateMaskType
		{
			// Token: 0x0400A620 RID: 42528
			IsNeedLoadDynamic,
			// Token: 0x0400A621 RID: 42529
			IsRefreshRankingList
		}

		// Token: 0x02000EBF RID: 3775
		public new class LuaExportHelper
		{
			// Token: 0x0601276D RID: 75629 RVA: 0x004BD724 File Offset: 0x004BB924
			public LuaExportHelper(RankingUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601276E RID: 75630 RVA: 0x004BD734 File Offset: 0x004BB934
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601276F RID: 75631 RVA: 0x004BD744 File Offset: 0x004BB944
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06012770 RID: 75632 RVA: 0x004BD754 File Offset: 0x004BB954
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06012771 RID: 75633 RVA: 0x004BD764 File Offset: 0x004BB964
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06012772 RID: 75634 RVA: 0x004BD774 File Offset: 0x004BB974
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06012773 RID: 75635 RVA: 0x004BD784 File Offset: 0x004BB984
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06012774 RID: 75636 RVA: 0x004BD794 File Offset: 0x004BB994
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06012775 RID: 75637 RVA: 0x004BD7A4 File Offset: 0x004BB9A4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06012776 RID: 75638 RVA: 0x004BD7B4 File Offset: 0x004BB9B4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06012777 RID: 75639 RVA: 0x004BD7C4 File Offset: 0x004BB9C4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06012778 RID: 75640 RVA: 0x004BD7D4 File Offset: 0x004BB9D4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06012779 RID: 75641 RVA: 0x004BD7E4 File Offset: 0x004BB9E4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601277A RID: 75642 RVA: 0x004BD7F4 File Offset: 0x004BB9F4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601277B RID: 75643 RVA: 0x004BD804 File Offset: 0x004BBA04
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601277C RID: 75644 RVA: 0x004BD814 File Offset: 0x004BBA14
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601277D RID: 75645 RVA: 0x004BD824 File Offset: 0x004BBA24
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0601277E RID: 75646 RVA: 0x004BD834 File Offset: 0x004BBA34
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601277F RID: 75647 RVA: 0x004BD844 File Offset: 0x004BBA44
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06012780 RID: 75648 RVA: 0x004BD854 File Offset: 0x004BBA54
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06012781 RID: 75649 RVA: 0x004BD864 File Offset: 0x004BBA64
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06012782 RID: 75650 RVA: 0x004BD874 File Offset: 0x004BBA74
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06012783 RID: 75651 RVA: 0x004BD884 File Offset: 0x004BBA84
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06012784 RID: 75652 RVA: 0x004BD894 File Offset: 0x004BBA94
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170037DA RID: 14298
			// (get) Token: 0x06012785 RID: 75653 RVA: 0x004BD8A4 File Offset: 0x004BBAA4
			// (set) Token: 0x06012786 RID: 75654 RVA: 0x004BD8B4 File Offset: 0x004BBAB4
			public RankingListType m_currRankListType
			{
				get
				{
					return this.m_owner.m_currRankListType;
				}
				set
				{
					this.m_owner.m_currRankListType = value;
				}
			}

			// Token: 0x170037DB RID: 14299
			// (get) Token: 0x06012787 RID: 75655 RVA: 0x004BD8C4 File Offset: 0x004BBAC4
			// (set) Token: 0x06012788 RID: 75656 RVA: 0x004BD8D4 File Offset: 0x004BBAD4
			public RankingListInfo m_currRankList
			{
				get
				{
					return this.m_owner.m_currRankList;
				}
				set
				{
					this.m_owner.m_currRankList = value;
				}
			}

			// Token: 0x170037DC RID: 14300
			// (get) Token: 0x06012789 RID: 75657 RVA: 0x004BD8E4 File Offset: 0x004BBAE4
			// (set) Token: 0x0601278A RID: 75658 RVA: 0x004BD8F4 File Offset: 0x004BBAF4
			public RankingUIController m_mainCtrl
			{
				get
				{
					return this.m_owner.m_mainCtrl;
				}
				set
				{
					this.m_owner.m_mainCtrl = value;
				}
			}

			// Token: 0x170037DD RID: 14301
			// (get) Token: 0x0601278B RID: 75659 RVA: 0x004BD904 File Offset: 0x004BBB04
			// (set) Token: 0x0601278C RID: 75660 RVA: 0x004BD914 File Offset: 0x004BBB14
			public RankingListUIController m_rankingListUICtrl
			{
				get
				{
					return this.m_owner.m_rankingListUICtrl;
				}
				set
				{
					this.m_owner.m_rankingListUICtrl = value;
				}
			}

			// Token: 0x170037DE RID: 14302
			// (get) Token: 0x0601278D RID: 75661 RVA: 0x004BD924 File Offset: 0x004BBB24
			// (set) Token: 0x0601278E RID: 75662 RVA: 0x004BD92C File Offset: 0x004BBB2C
			public static string ParamKey_RankingType
			{
				get
				{
					return RankingUITask.ParamKey_RankingType;
				}
				set
				{
					RankingUITask.ParamKey_RankingType = value;
				}
			}

			// Token: 0x170037DF RID: 14303
			// (get) Token: 0x0601278F RID: 75663 RVA: 0x004BD934 File Offset: 0x004BBB34
			// (set) Token: 0x06012790 RID: 75664 RVA: 0x004BD944 File Offset: 0x004BBB44
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x170037E0 RID: 14304
			// (get) Token: 0x06012791 RID: 75665 RVA: 0x004BD954 File Offset: 0x004BBB54
			// (set) Token: 0x06012792 RID: 75666 RVA: 0x004BD964 File Offset: 0x004BBB64
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x170037E1 RID: 14305
			// (get) Token: 0x06012793 RID: 75667 RVA: 0x004BD974 File Offset: 0x004BBB74
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170037E2 RID: 14306
			// (get) Token: 0x06012794 RID: 75668 RVA: 0x004BD984 File Offset: 0x004BBB84
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06012795 RID: 75669 RVA: 0x004BD994 File Offset: 0x004BBB94
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06012796 RID: 75670 RVA: 0x004BD9A4 File Offset: 0x004BBBA4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06012797 RID: 75671 RVA: 0x004BD9B4 File Offset: 0x004BBBB4
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x06012798 RID: 75672 RVA: 0x004BD9C4 File Offset: 0x004BBBC4
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x06012799 RID: 75673 RVA: 0x004BD9D4 File Offset: 0x004BBBD4
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601279A RID: 75674 RVA: 0x004BD9E4 File Offset: 0x004BBBE4
			public List<string> CollectAllDynamicResForLoad()
			{
				return this.m_owner.CollectAllDynamicResForLoad();
			}

			// Token: 0x0601279B RID: 75675 RVA: 0x004BD9F4 File Offset: 0x004BBBF4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0601279C RID: 75676 RVA: 0x004BDA04 File Offset: 0x004BBC04
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0601279D RID: 75677 RVA: 0x004BDA14 File Offset: 0x004BBC14
			public void OnRankingTypeMenuClick(RankingListType rankingType)
			{
				this.m_owner.OnRankingTypeMenuClick(rankingType);
			}

			// Token: 0x0601279E RID: 75678 RVA: 0x004BDA24 File Offset: 0x004BBC24
			public void OnResetRankingType()
			{
				this.m_owner.OnResetRankingType();
			}

			// Token: 0x0601279F RID: 75679 RVA: 0x004BDA34 File Offset: 0x004BBC34
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x060127A0 RID: 75680 RVA: 0x004BDA44 File Offset: 0x004BBC44
			public void InitPipeLineCtxStateFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitPipeLineCtxStateFromUIIntent(intent);
			}

			// Token: 0x060127A1 RID: 75681 RVA: 0x004BDA54 File Offset: 0x004BBC54
			public bool IsPipelineStateMaskNeedUpdate(RankingUITask.PipeLineStateMaskType state)
			{
				return this.m_owner.IsPipelineStateMaskNeedUpdate(state);
			}

			// Token: 0x060127A2 RID: 75682 RVA: 0x004BDA64 File Offset: 0x004BBC64
			public void EnablePipelineStateMask(RankingUITask.PipeLineStateMaskType state)
			{
				this.m_owner.EnablePipelineStateMask(state);
			}

			// Token: 0x0400A622 RID: 42530
			private RankingUITask m_owner;
		}
	}
}
