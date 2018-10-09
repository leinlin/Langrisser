using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FC7 RID: 4039
	[HotFix]
	public class ThearchyUITask : UITask
	{
		// Token: 0x060142F9 RID: 82681 RVA: 0x00523568 File Offset: 0x00521768
		public ThearchyUITask(string name) : base(name)
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

		// Token: 0x060142FA RID: 82682 RVA: 0x00523694 File Offset: 0x00521894
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
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x060142FB RID: 82683 RVA: 0x00523720 File Offset: 0x00521920
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
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x060142FC RID: 82684 RVA: 0x005237AC File Offset: 0x005219AC
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_thearchyTrialInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_thearchyTrialInfo = uiintentCustom.GetClassParam<ConfigDataThearchyTrialInfo>("ThearchyTrialInfo");
			}
			if (this.m_thearchyTrialInfo != null && !projectLPlayerContext.IsThearchyOpened(this.m_thearchyTrialInfo.ID))
			{
				this.m_thearchyTrialInfo = null;
			}
			if (this.m_thearchyTrialInfo == null)
			{
				foreach (KeyValuePair<int, ConfigDataThearchyTrialInfo> keyValuePair in configDataLoader.GetAllConfigDataThearchyTrialInfo())
				{
					if (projectLPlayerContext.IsThearchyOpened(keyValuePair.Key))
					{
						this.m_thearchyTrialInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x060142FD RID: 82685 RVA: 0x00523904 File Offset: 0x00521B04
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
			base.ClearAssetList();
			if (this.m_thearchyTrialInfo != null)
			{
				base.CollectAsset(this.m_thearchyTrialInfo.Model);
				base.CollectAsset(this.m_thearchyTrialInfo.Fx);
				List<Goods> list = new List<Goods>();
				foreach (ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo in this.m_thearchyTrialInfo.m_levelInfos)
				{
					base.CollectSpriteAsset(configDataThearchyTrialLevelInfo.Icon);
					list.Clear();
					UIUtility.AppendRandomDropRewardGoodsToList(configDataThearchyTrialLevelInfo.Drop_ID, list);
					foreach (Goods goods in list)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060142FE RID: 82686 RVA: 0x00523A74 File Offset: 0x00521C74
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
			this.InitThearchyUIController();
		}

		// Token: 0x060142FF RID: 82687 RVA: 0x00523AE0 File Offset: 0x00521CE0
		protected override void ClearAllContextAndRes()
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
			base.ClearAllContextAndRes();
			this.UninitThearchyUIController();
		}

		// Token: 0x06014300 RID: 82688 RVA: 0x00523B4C File Offset: 0x00521D4C
		private void InitThearchyUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitThearchyUIController_hotfix != null)
			{
				this.m_InitThearchyUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_thearchyUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_thearchyUIController = (this.m_uiCtrlArray[0] as ThearchyUIController);
				}
				if (!(this.m_thearchyUIController != null))
				{
					Debug.LogError("ThearchyUIController is null");
					return;
				}
				this.m_thearchyUIController.EventOnReturn += this.ThearchyUIController_OnReturn;
				this.m_thearchyUIController.EventOnShowHelp += this.ThearchyUIController_OnShowHelp;
				this.m_thearchyUIController.EventOnAddTicket += this.ThearchyUIController_OnAddTicket;
				this.m_thearchyUIController.EventOnShowTeam += this.ThearchyUIController_OnShowTeam;
				this.m_thearchyUIController.EventOnStartThearchyLevel += this.ThearchyUIController_OnStartThearchyLevel;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
			}
		}

		// Token: 0x06014301 RID: 82689 RVA: 0x00523CC8 File Offset: 0x00521EC8
		private void UninitThearchyUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitThearchyUIController_hotfix != null)
			{
				this.m_UninitThearchyUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_thearchyUIController != null)
			{
				this.m_thearchyUIController.EventOnReturn -= this.ThearchyUIController_OnReturn;
				this.m_thearchyUIController.EventOnShowHelp -= this.ThearchyUIController_OnShowHelp;
				this.m_thearchyUIController.EventOnAddTicket -= this.ThearchyUIController_OnAddTicket;
				this.m_thearchyUIController.EventOnShowTeam -= this.ThearchyUIController_OnShowTeam;
				this.m_thearchyUIController.EventOnStartThearchyLevel -= this.ThearchyUIController_OnStartThearchyLevel;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06014302 RID: 82690 RVA: 0x00523DC4 File Offset: 0x00521FC4
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
			if (base.IsOpeningUI())
			{
				this.m_thearchyUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.m_thearchyUIController.SetDailyRewardCount(projectLPlayerContext.GetThearchyDailyRewardRestCount(), projectLPlayerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_ThearchyTrial));
			if (this.m_thearchyTrialInfo != null)
			{
				this.m_thearchyUIController.SetThearchy(this.m_thearchyTrialInfo);
				this.m_thearchyUIController.SetAllThearchyLevelListItems(this.m_thearchyTrialInfo.m_levelInfos);
			}
		}

		// Token: 0x06014303 RID: 82691 RVA: 0x00523EA0 File Offset: 0x005220A0
		private void ThearchyUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyUIController_OnReturn_hotfix != null)
			{
				this.m_ThearchyUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06014304 RID: 82692 RVA: 0x00523F24 File Offset: 0x00522124
		private void ThearchyUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyUIController_OnShowHelp_hotfix != null)
			{
				this.m_ThearchyUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Thearchy);
		}

		// Token: 0x06014305 RID: 82693 RVA: 0x00523F90 File Offset: 0x00522190
		private void ThearchyUIController_OnAddTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyUIController_OnAddTicket_hotfix != null)
			{
				this.m_ThearchyUIController_OnAddTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06014306 RID: 82694 RVA: 0x00523FF0 File Offset: 0x005221F0
		private void ThearchyUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyUIController_OnShowTeam_hotfix != null)
			{
				this.m_ThearchyUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_ThearchyTrial, this.m_thearchyTrialInfo.ID, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06014307 RID: 82695 RVA: 0x00524074 File Offset: 0x00522274
		private void TeamUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_TeamUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TeamUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06014308 RID: 82696 RVA: 0x00524100 File Offset: 0x00522300
		private void ThearchyUIController_OnStartThearchyLevel(ConfigDataThearchyTrialLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyUIController_OnStartThearchyLevelConfigDataThearchyTrialLevelInfo_hotfix != null)
			{
				this.m_ThearchyUIController_OnStartThearchyLevelConfigDataThearchyTrialLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackThearchyLevel(levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.ThearchyTrial, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x06014309 RID: 82697 RVA: 0x005241B0 File Offset: 0x005223B0
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

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0601430A RID: 82698 RVA: 0x00524224 File Offset: 0x00522424
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

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0601430B RID: 82699 RVA: 0x00524298 File Offset: 0x00522498
		// (set) Token: 0x0601430C RID: 82700 RVA: 0x005242B8 File Offset: 0x005224B8
		[DoNotToLua]
		public new ThearchyUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ThearchyUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601430D RID: 82701 RVA: 0x005242C4 File Offset: 0x005224C4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0601430E RID: 82702 RVA: 0x005242D0 File Offset: 0x005224D0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601430F RID: 82703 RVA: 0x005242D8 File Offset: 0x005224D8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014310 RID: 82704 RVA: 0x005242E0 File Offset: 0x005224E0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014311 RID: 82705 RVA: 0x005242EC File Offset: 0x005224EC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014312 RID: 82706 RVA: 0x005242F8 File Offset: 0x005224F8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014313 RID: 82707 RVA: 0x00524304 File Offset: 0x00522504
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014314 RID: 82708 RVA: 0x0052430C File Offset: 0x0052250C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014315 RID: 82709 RVA: 0x00524314 File Offset: 0x00522514
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014316 RID: 82710 RVA: 0x0052431C File Offset: 0x0052251C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06014317 RID: 82711 RVA: 0x00524324 File Offset: 0x00522524
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06014318 RID: 82712 RVA: 0x0052432C File Offset: 0x0052252C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06014319 RID: 82713 RVA: 0x00524334 File Offset: 0x00522534
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601431A RID: 82714 RVA: 0x0052433C File Offset: 0x0052253C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601431B RID: 82715 RVA: 0x00524348 File Offset: 0x00522548
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0601431C RID: 82716 RVA: 0x00524354 File Offset: 0x00522554
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0601431D RID: 82717 RVA: 0x00524360 File Offset: 0x00522560
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0601431E RID: 82718 RVA: 0x0052436C File Offset: 0x0052256C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0601431F RID: 82719 RVA: 0x00524374 File Offset: 0x00522574
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014320 RID: 82720 RVA: 0x0052437C File Offset: 0x0052257C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014321 RID: 82721 RVA: 0x00524384 File Offset: 0x00522584
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014322 RID: 82722 RVA: 0x0052438C File Offset: 0x0052258C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014323 RID: 82723 RVA: 0x00524394 File Offset: 0x00522594
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014326 RID: 82726 RVA: 0x005243FC File Offset: 0x005225FC
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitThearchyUIController_hotfix = (luaObj.RawGet("InitThearchyUIController") as LuaFunction);
					this.m_UninitThearchyUIController_hotfix = (luaObj.RawGet("UninitThearchyUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ThearchyUIController_OnReturn_hotfix = (luaObj.RawGet("ThearchyUIController_OnReturn") as LuaFunction);
					this.m_ThearchyUIController_OnShowHelp_hotfix = (luaObj.RawGet("ThearchyUIController_OnShowHelp") as LuaFunction);
					this.m_ThearchyUIController_OnAddTicket_hotfix = (luaObj.RawGet("ThearchyUIController_OnAddTicket") as LuaFunction);
					this.m_ThearchyUIController_OnShowTeam_hotfix = (luaObj.RawGet("ThearchyUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_ThearchyUIController_OnStartThearchyLevelConfigDataThearchyTrialLevelInfo_hotfix = (luaObj.RawGet("ThearchyUIController_OnStartThearchyLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014327 RID: 82727 RVA: 0x00524670 File Offset: 0x00522870
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B250 RID: 45648
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ThearchyUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Thearchy_ABS/Prefab/ThearchyUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B251 RID: 45649
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ThearchyUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ThearchyUIController"),
				m_ctrlName = "ThearchyUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ThearchyUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "ThearchyPlayerResourceUIController"
			}
		};

		// Token: 0x0400B252 RID: 45650
		private ThearchyUIController m_thearchyUIController;

		// Token: 0x0400B253 RID: 45651
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400B254 RID: 45652
		private ConfigDataThearchyTrialInfo m_thearchyTrialInfo;

		// Token: 0x0400B255 RID: 45653
		[DoNotToLua]
		private ThearchyUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B256 RID: 45654
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B257 RID: 45655
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B258 RID: 45656
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B259 RID: 45657
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B25A RID: 45658
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B25B RID: 45659
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400B25C RID: 45660
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B25D RID: 45661
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B25E RID: 45662
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B25F RID: 45663
		private LuaFunction m_InitThearchyUIController_hotfix;

		// Token: 0x0400B260 RID: 45664
		private LuaFunction m_UninitThearchyUIController_hotfix;

		// Token: 0x0400B261 RID: 45665
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B262 RID: 45666
		private LuaFunction m_ThearchyUIController_OnReturn_hotfix;

		// Token: 0x0400B263 RID: 45667
		private LuaFunction m_ThearchyUIController_OnShowHelp_hotfix;

		// Token: 0x0400B264 RID: 45668
		private LuaFunction m_ThearchyUIController_OnAddTicket_hotfix;

		// Token: 0x0400B265 RID: 45669
		private LuaFunction m_ThearchyUIController_OnShowTeam_hotfix;

		// Token: 0x0400B266 RID: 45670
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B267 RID: 45671
		private LuaFunction m_ThearchyUIController_OnStartThearchyLevelConfigDataThearchyTrialLevelInfo_hotfix;

		// Token: 0x0400B268 RID: 45672
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B269 RID: 45673
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000FC8 RID: 4040
		public new class LuaExportHelper
		{
			// Token: 0x06014328 RID: 82728 RVA: 0x005246D8 File Offset: 0x005228D8
			public LuaExportHelper(ThearchyUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014329 RID: 82729 RVA: 0x005246E8 File Offset: 0x005228E8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601432A RID: 82730 RVA: 0x005246F8 File Offset: 0x005228F8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601432B RID: 82731 RVA: 0x00524708 File Offset: 0x00522908
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601432C RID: 82732 RVA: 0x00524718 File Offset: 0x00522918
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0601432D RID: 82733 RVA: 0x00524728 File Offset: 0x00522928
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0601432E RID: 82734 RVA: 0x00524738 File Offset: 0x00522938
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0601432F RID: 82735 RVA: 0x00524748 File Offset: 0x00522948
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014330 RID: 82736 RVA: 0x00524758 File Offset: 0x00522958
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014331 RID: 82737 RVA: 0x00524768 File Offset: 0x00522968
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014332 RID: 82738 RVA: 0x00524778 File Offset: 0x00522978
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014333 RID: 82739 RVA: 0x00524788 File Offset: 0x00522988
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014334 RID: 82740 RVA: 0x00524798 File Offset: 0x00522998
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014335 RID: 82741 RVA: 0x005247A8 File Offset: 0x005229A8
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014336 RID: 82742 RVA: 0x005247B8 File Offset: 0x005229B8
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06014337 RID: 82743 RVA: 0x005247C8 File Offset: 0x005229C8
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06014338 RID: 82744 RVA: 0x005247D8 File Offset: 0x005229D8
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06014339 RID: 82745 RVA: 0x005247E8 File Offset: 0x005229E8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601433A RID: 82746 RVA: 0x005247F8 File Offset: 0x005229F8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601433B RID: 82747 RVA: 0x00524808 File Offset: 0x00522A08
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601433C RID: 82748 RVA: 0x00524818 File Offset: 0x00522A18
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0601433D RID: 82749 RVA: 0x00524828 File Offset: 0x00522A28
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0601433E RID: 82750 RVA: 0x00524838 File Offset: 0x00522A38
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0601433F RID: 82751 RVA: 0x00524848 File Offset: 0x00522A48
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003C2A RID: 15402
			// (get) Token: 0x06014340 RID: 82752 RVA: 0x00524858 File Offset: 0x00522A58
			// (set) Token: 0x06014341 RID: 82753 RVA: 0x00524868 File Offset: 0x00522A68
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

			// Token: 0x17003C2B RID: 15403
			// (get) Token: 0x06014342 RID: 82754 RVA: 0x00524878 File Offset: 0x00522A78
			// (set) Token: 0x06014343 RID: 82755 RVA: 0x00524888 File Offset: 0x00522A88
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

			// Token: 0x17003C2C RID: 15404
			// (get) Token: 0x06014344 RID: 82756 RVA: 0x00524898 File Offset: 0x00522A98
			// (set) Token: 0x06014345 RID: 82757 RVA: 0x005248A8 File Offset: 0x00522AA8
			public ThearchyUIController m_thearchyUIController
			{
				get
				{
					return this.m_owner.m_thearchyUIController;
				}
				set
				{
					this.m_owner.m_thearchyUIController = value;
				}
			}

			// Token: 0x17003C2D RID: 15405
			// (get) Token: 0x06014346 RID: 82758 RVA: 0x005248B8 File Offset: 0x00522AB8
			// (set) Token: 0x06014347 RID: 82759 RVA: 0x005248C8 File Offset: 0x00522AC8
			public PlayerResourceUIController m_playerResourceUIController
			{
				get
				{
					return this.m_owner.m_playerResourceUIController;
				}
				set
				{
					this.m_owner.m_playerResourceUIController = value;
				}
			}

			// Token: 0x17003C2E RID: 15406
			// (get) Token: 0x06014348 RID: 82760 RVA: 0x005248D8 File Offset: 0x00522AD8
			// (set) Token: 0x06014349 RID: 82761 RVA: 0x005248E8 File Offset: 0x00522AE8
			public ConfigDataThearchyTrialInfo m_thearchyTrialInfo
			{
				get
				{
					return this.m_owner.m_thearchyTrialInfo;
				}
				set
				{
					this.m_owner.m_thearchyTrialInfo = value;
				}
			}

			// Token: 0x17003C2F RID: 15407
			// (get) Token: 0x0601434A RID: 82762 RVA: 0x005248F8 File Offset: 0x00522AF8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003C30 RID: 15408
			// (get) Token: 0x0601434B RID: 82763 RVA: 0x00524908 File Offset: 0x00522B08
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601434C RID: 82764 RVA: 0x00524918 File Offset: 0x00522B18
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0601434D RID: 82765 RVA: 0x00524928 File Offset: 0x00522B28
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0601434E RID: 82766 RVA: 0x00524938 File Offset: 0x00522B38
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0601434F RID: 82767 RVA: 0x00524948 File Offset: 0x00522B48
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06014350 RID: 82768 RVA: 0x00524958 File Offset: 0x00522B58
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014351 RID: 82769 RVA: 0x00524968 File Offset: 0x00522B68
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014352 RID: 82770 RVA: 0x00524978 File Offset: 0x00522B78
			public void InitThearchyUIController()
			{
				this.m_owner.InitThearchyUIController();
			}

			// Token: 0x06014353 RID: 82771 RVA: 0x00524988 File Offset: 0x00522B88
			public void UninitThearchyUIController()
			{
				this.m_owner.UninitThearchyUIController();
			}

			// Token: 0x06014354 RID: 82772 RVA: 0x00524998 File Offset: 0x00522B98
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014355 RID: 82773 RVA: 0x005249A8 File Offset: 0x00522BA8
			public void ThearchyUIController_OnReturn()
			{
				this.m_owner.ThearchyUIController_OnReturn();
			}

			// Token: 0x06014356 RID: 82774 RVA: 0x005249B8 File Offset: 0x00522BB8
			public void ThearchyUIController_OnShowHelp()
			{
				this.m_owner.ThearchyUIController_OnShowHelp();
			}

			// Token: 0x06014357 RID: 82775 RVA: 0x005249C8 File Offset: 0x00522BC8
			public void ThearchyUIController_OnAddTicket()
			{
				this.m_owner.ThearchyUIController_OnAddTicket();
			}

			// Token: 0x06014358 RID: 82776 RVA: 0x005249D8 File Offset: 0x00522BD8
			public void ThearchyUIController_OnShowTeam()
			{
				this.m_owner.ThearchyUIController_OnShowTeam();
			}

			// Token: 0x06014359 RID: 82777 RVA: 0x005249E8 File Offset: 0x00522BE8
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601435A RID: 82778 RVA: 0x005249F8 File Offset: 0x00522BF8
			public void ThearchyUIController_OnStartThearchyLevel(ConfigDataThearchyTrialLevelInfo levelInfo)
			{
				this.m_owner.ThearchyUIController_OnStartThearchyLevel(levelInfo);
			}

			// Token: 0x0400B26A RID: 45674
			private ThearchyUITask m_owner;
		}
	}
}
