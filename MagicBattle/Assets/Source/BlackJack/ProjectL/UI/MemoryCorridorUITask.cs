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
	// Token: 0x02000E75 RID: 3701
	[HotFix]
	public class MemoryCorridorUITask : UITask
	{
		// Token: 0x06011F71 RID: 73585 RVA: 0x004A3260 File Offset: 0x004A1460
		public MemoryCorridorUITask(string name) : base(name)
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

		// Token: 0x06011F72 RID: 73586 RVA: 0x004A338C File Offset: 0x004A158C
		protected override void Finalize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Finalize_hotfix != null)
			{
				this.m_Finalize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06011F73 RID: 73587 RVA: 0x004A3408 File Offset: 0x004A1608
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

		// Token: 0x06011F74 RID: 73588 RVA: 0x004A3494 File Offset: 0x004A1694
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

		// Token: 0x06011F75 RID: 73589 RVA: 0x004A3520 File Offset: 0x004A1720
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
			this.m_memoryCorridorInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_memoryCorridorInfo = uiintentCustom.GetClassParam<ConfigDataMemoryCorridorInfo>("MemoryCorridorInfo");
			}
			if (this.m_memoryCorridorInfo != null && !projectLPlayerContext.IsMemoryCorridorOpened(this.m_memoryCorridorInfo.ID))
			{
				this.m_memoryCorridorInfo = null;
			}
			if (this.m_memoryCorridorInfo == null)
			{
				foreach (KeyValuePair<int, ConfigDataMemoryCorridorInfo> keyValuePair in configDataLoader.GetAllConfigDataMemoryCorridorInfo())
				{
					if (projectLPlayerContext.IsMemoryCorridorOpened(keyValuePair.Key))
					{
						this.m_memoryCorridorInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x06011F76 RID: 73590 RVA: 0x004A3678 File Offset: 0x004A1878
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
			if (this.m_memoryCorridorInfo != null)
			{
				base.CollectAsset(this.m_memoryCorridorInfo.Model);
				base.CollectSpriteAsset(this.m_memoryCorridorInfo.Background);
				List<Goods> list = new List<Goods>();
				foreach (ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo in this.m_memoryCorridorInfo.m_levelInfos)
				{
					base.CollectSpriteAsset(configDataMemoryCorridorLevelInfo.Icon);
					list.Clear();
					UIUtility.AppendRandomDropRewardGoodsToList(configDataMemoryCorridorLevelInfo.Drop_ID, list);
					foreach (Goods goods in list)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011F77 RID: 73591 RVA: 0x004A37E8 File Offset: 0x004A19E8
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
			this.InitMemoryCorridorUIController();
		}

		// Token: 0x06011F78 RID: 73592 RVA: 0x004A3854 File Offset: 0x004A1A54
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
			this.UninitMemoryCorridorUIController();
		}

		// Token: 0x06011F79 RID: 73593 RVA: 0x004A38C0 File Offset: 0x004A1AC0
		private void InitMemoryCorridorUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMemoryCorridorUIController_hotfix != null)
			{
				this.m_InitMemoryCorridorUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_memoryCorridorUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_memoryCorridorUIController = (this.m_uiCtrlArray[0] as MemoryCorridorUIController);
				}
				if (!(this.m_memoryCorridorUIController != null))
				{
					Debug.LogError("MemoryCorridorUIController is null");
					return;
				}
				this.m_memoryCorridorUIController.EventOnReturn += this.MemoryCorridorUIController_OnReturn;
				this.m_memoryCorridorUIController.EventOnShowHelp += this.MemoryCorridorUIController_OnShowHelp;
				this.m_memoryCorridorUIController.EventOnAddTicket += this.MemoryCorridorUIController_OnAddTicket;
				this.m_memoryCorridorUIController.EventOnShowTeam += this.MemoryCorridorUIController_OnShowTeam;
				this.m_memoryCorridorUIController.EventOnStartMemoryCorridorLevel += this.MemoryCorridorUIController_OnStartMemoryCorridorLevel;
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

		// Token: 0x06011F7A RID: 73594 RVA: 0x004A3A3C File Offset: 0x004A1C3C
		private void UninitMemoryCorridorUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitMemoryCorridorUIController_hotfix != null)
			{
				this.m_UninitMemoryCorridorUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_memoryCorridorUIController != null)
			{
				this.m_memoryCorridorUIController.EventOnReturn -= this.MemoryCorridorUIController_OnReturn;
				this.m_memoryCorridorUIController.EventOnShowHelp -= this.MemoryCorridorUIController_OnShowHelp;
				this.m_memoryCorridorUIController.EventOnAddTicket -= this.MemoryCorridorUIController_OnAddTicket;
				this.m_memoryCorridorUIController.EventOnShowTeam -= this.MemoryCorridorUIController_OnShowTeam;
				this.m_memoryCorridorUIController.EventOnStartMemoryCorridorLevel -= this.MemoryCorridorUIController_OnStartMemoryCorridorLevel;
				this.m_memoryCorridorUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06011F7B RID: 73595 RVA: 0x004A3B40 File Offset: 0x004A1D40
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011F7C RID: 73596 RVA: 0x004A3BA8 File Offset: 0x004A1DA8
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
				this.m_memoryCorridorUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.m_memoryCorridorUIController.SetDailyRewardCount(projectLPlayerContext.GetMemoryCorridorDailyRewardRestCount(), projectLPlayerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_MemoryCorridor));
			if (this.m_memoryCorridorInfo != null)
			{
				this.m_memoryCorridorUIController.SetMemoryCorridor(this.m_memoryCorridorInfo);
				this.m_memoryCorridorUIController.ClearMemoryCorridorLevelListItems();
				this.m_memoryCorridorUIController.AddAllMemoryCorridorLevelListItems(this.m_memoryCorridorInfo.m_levelInfos);
			}
		}

		// Token: 0x06011F7D RID: 73597 RVA: 0x004A3C90 File Offset: 0x004A1E90
		private void MemoryCorridorUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorUIController_OnReturn_hotfix != null)
			{
				this.m_MemoryCorridorUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x06011F7E RID: 73598 RVA: 0x004A3D14 File Offset: 0x004A1F14
		private void MemoryCorridorUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorUIController_OnShowHelp_hotfix != null)
			{
				this.m_MemoryCorridorUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_MemoryCorridor);
		}

		// Token: 0x06011F7F RID: 73599 RVA: 0x004A3D80 File Offset: 0x004A1F80
		private void MemoryCorridorUIController_OnAddTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorUIController_OnAddTicket_hotfix != null)
			{
				this.m_MemoryCorridorUIController_OnAddTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011F80 RID: 73600 RVA: 0x004A3DE0 File Offset: 0x004A1FE0
		private void MemoryCorridorUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorUIController_OnShowTeam_hotfix != null)
			{
				this.m_MemoryCorridorUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_MemoryCorridor, this.m_memoryCorridorInfo.ID, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06011F81 RID: 73601 RVA: 0x004A3E64 File Offset: 0x004A2064
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

		// Token: 0x06011F82 RID: 73602 RVA: 0x004A3EF0 File Offset: 0x004A20F0
		private void MemoryCorridorUIController_OnStartMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorUIController_OnStartMemoryCorridorLevelConfigDataMemoryCorridorLevelInfo_hotfix != null)
			{
				this.m_MemoryCorridorUIController_OnStartMemoryCorridorLevelConfigDataMemoryCorridorLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackMemoryCorridorLevel(levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.MemoryCorridor, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x06011F83 RID: 73603 RVA: 0x004A3FA4 File Offset: 0x004A21A4
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

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x06011F84 RID: 73604 RVA: 0x004A4018 File Offset: 0x004A2218
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

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x06011F85 RID: 73605 RVA: 0x004A408C File Offset: 0x004A228C
		// (set) Token: 0x06011F86 RID: 73606 RVA: 0x004A40AC File Offset: 0x004A22AC
		[DoNotToLua]
		public new MemoryCorridorUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MemoryCorridorUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011F87 RID: 73607 RVA: 0x004A40B8 File Offset: 0x004A22B8
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011F88 RID: 73608 RVA: 0x004A40C4 File Offset: 0x004A22C4
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011F89 RID: 73609 RVA: 0x004A40CC File Offset: 0x004A22CC
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06011F8A RID: 73610 RVA: 0x004A40D4 File Offset: 0x004A22D4
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06011F8B RID: 73611 RVA: 0x004A40E0 File Offset: 0x004A22E0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06011F8C RID: 73612 RVA: 0x004A40EC File Offset: 0x004A22EC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06011F8D RID: 73613 RVA: 0x004A40F8 File Offset: 0x004A22F8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011F8E RID: 73614 RVA: 0x004A4100 File Offset: 0x004A2300
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06011F8F RID: 73615 RVA: 0x004A4108 File Offset: 0x004A2308
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06011F90 RID: 73616 RVA: 0x004A4110 File Offset: 0x004A2310
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06011F91 RID: 73617 RVA: 0x004A4118 File Offset: 0x004A2318
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06011F92 RID: 73618 RVA: 0x004A4120 File Offset: 0x004A2320
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06011F93 RID: 73619 RVA: 0x004A4128 File Offset: 0x004A2328
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06011F94 RID: 73620 RVA: 0x004A4130 File Offset: 0x004A2330
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06011F95 RID: 73621 RVA: 0x004A413C File Offset: 0x004A233C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06011F96 RID: 73622 RVA: 0x004A4148 File Offset: 0x004A2348
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06011F97 RID: 73623 RVA: 0x004A4154 File Offset: 0x004A2354
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06011F98 RID: 73624 RVA: 0x004A4160 File Offset: 0x004A2360
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06011F99 RID: 73625 RVA: 0x004A4168 File Offset: 0x004A2368
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06011F9A RID: 73626 RVA: 0x004A4170 File Offset: 0x004A2370
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06011F9B RID: 73627 RVA: 0x004A4178 File Offset: 0x004A2378
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06011F9C RID: 73628 RVA: 0x004A4180 File Offset: 0x004A2380
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011F9D RID: 73629 RVA: 0x004A4188 File Offset: 0x004A2388
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06011FA0 RID: 73632 RVA: 0x004A41F0 File Offset: 0x004A23F0
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
					this.m_Finalize_hotfix = (luaObj.RawGet("Finalize") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitMemoryCorridorUIController_hotfix = (luaObj.RawGet("InitMemoryCorridorUIController") as LuaFunction);
					this.m_UninitMemoryCorridorUIController_hotfix = (luaObj.RawGet("UninitMemoryCorridorUIController") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_MemoryCorridorUIController_OnReturn_hotfix = (luaObj.RawGet("MemoryCorridorUIController_OnReturn") as LuaFunction);
					this.m_MemoryCorridorUIController_OnShowHelp_hotfix = (luaObj.RawGet("MemoryCorridorUIController_OnShowHelp") as LuaFunction);
					this.m_MemoryCorridorUIController_OnAddTicket_hotfix = (luaObj.RawGet("MemoryCorridorUIController_OnAddTicket") as LuaFunction);
					this.m_MemoryCorridorUIController_OnShowTeam_hotfix = (luaObj.RawGet("MemoryCorridorUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_MemoryCorridorUIController_OnStartMemoryCorridorLevelConfigDataMemoryCorridorLevelInfo_hotfix = (luaObj.RawGet("MemoryCorridorUIController_OnStartMemoryCorridorLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011FA1 RID: 73633 RVA: 0x004A4498 File Offset: 0x004A2698
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A2E7 RID: 41703
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "MemoryCorridorUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/MemoryCorridor_ABS/Prefab/MemoryCorridorUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A2E8 RID: 41704
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "MemoryCorridorUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.MemoryCorridorUIController"),
				m_ctrlName = "MemoryCorridorUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "MemoryCorridorUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "MemoryCorridorPlayerResourceUIController"
			}
		};

		// Token: 0x0400A2E9 RID: 41705
		private MemoryCorridorUIController m_memoryCorridorUIController;

		// Token: 0x0400A2EA RID: 41706
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400A2EB RID: 41707
		private ConfigDataMemoryCorridorInfo m_memoryCorridorInfo;

		// Token: 0x0400A2EC RID: 41708
		[DoNotToLua]
		private MemoryCorridorUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A2ED RID: 41709
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A2EE RID: 41710
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A2EF RID: 41711
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A2F0 RID: 41712
		private LuaFunction m_Finalize_hotfix;

		// Token: 0x0400A2F1 RID: 41713
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A2F2 RID: 41714
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A2F3 RID: 41715
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400A2F4 RID: 41716
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A2F5 RID: 41717
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A2F6 RID: 41718
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A2F7 RID: 41719
		private LuaFunction m_InitMemoryCorridorUIController_hotfix;

		// Token: 0x0400A2F8 RID: 41720
		private LuaFunction m_UninitMemoryCorridorUIController_hotfix;

		// Token: 0x0400A2F9 RID: 41721
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x0400A2FA RID: 41722
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A2FB RID: 41723
		private LuaFunction m_MemoryCorridorUIController_OnReturn_hotfix;

		// Token: 0x0400A2FC RID: 41724
		private LuaFunction m_MemoryCorridorUIController_OnShowHelp_hotfix;

		// Token: 0x0400A2FD RID: 41725
		private LuaFunction m_MemoryCorridorUIController_OnAddTicket_hotfix;

		// Token: 0x0400A2FE RID: 41726
		private LuaFunction m_MemoryCorridorUIController_OnShowTeam_hotfix;

		// Token: 0x0400A2FF RID: 41727
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400A300 RID: 41728
		private LuaFunction m_MemoryCorridorUIController_OnStartMemoryCorridorLevelConfigDataMemoryCorridorLevelInfo_hotfix;

		// Token: 0x0400A301 RID: 41729
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A302 RID: 41730
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E76 RID: 3702
		public new class LuaExportHelper
		{
			// Token: 0x06011FA2 RID: 73634 RVA: 0x004A4500 File Offset: 0x004A2700
			public LuaExportHelper(MemoryCorridorUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011FA3 RID: 73635 RVA: 0x004A4510 File Offset: 0x004A2710
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06011FA4 RID: 73636 RVA: 0x004A4520 File Offset: 0x004A2720
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011FA5 RID: 73637 RVA: 0x004A4530 File Offset: 0x004A2730
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06011FA6 RID: 73638 RVA: 0x004A4540 File Offset: 0x004A2740
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06011FA7 RID: 73639 RVA: 0x004A4550 File Offset: 0x004A2750
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011FA8 RID: 73640 RVA: 0x004A4560 File Offset: 0x004A2760
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011FA9 RID: 73641 RVA: 0x004A4570 File Offset: 0x004A2770
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011FAA RID: 73642 RVA: 0x004A4580 File Offset: 0x004A2780
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06011FAB RID: 73643 RVA: 0x004A4590 File Offset: 0x004A2790
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06011FAC RID: 73644 RVA: 0x004A45A0 File Offset: 0x004A27A0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06011FAD RID: 73645 RVA: 0x004A45B0 File Offset: 0x004A27B0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06011FAE RID: 73646 RVA: 0x004A45C0 File Offset: 0x004A27C0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06011FAF RID: 73647 RVA: 0x004A45D0 File Offset: 0x004A27D0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06011FB0 RID: 73648 RVA: 0x004A45E0 File Offset: 0x004A27E0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06011FB1 RID: 73649 RVA: 0x004A45F0 File Offset: 0x004A27F0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06011FB2 RID: 73650 RVA: 0x004A4600 File Offset: 0x004A2800
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06011FB3 RID: 73651 RVA: 0x004A4610 File Offset: 0x004A2810
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06011FB4 RID: 73652 RVA: 0x004A4620 File Offset: 0x004A2820
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06011FB5 RID: 73653 RVA: 0x004A4630 File Offset: 0x004A2830
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06011FB6 RID: 73654 RVA: 0x004A4640 File Offset: 0x004A2840
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06011FB7 RID: 73655 RVA: 0x004A4650 File Offset: 0x004A2850
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011FB8 RID: 73656 RVA: 0x004A4660 File Offset: 0x004A2860
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011FB9 RID: 73657 RVA: 0x004A4670 File Offset: 0x004A2870
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170036E8 RID: 14056
			// (get) Token: 0x06011FBA RID: 73658 RVA: 0x004A4680 File Offset: 0x004A2880
			// (set) Token: 0x06011FBB RID: 73659 RVA: 0x004A4690 File Offset: 0x004A2890
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

			// Token: 0x170036E9 RID: 14057
			// (get) Token: 0x06011FBC RID: 73660 RVA: 0x004A46A0 File Offset: 0x004A28A0
			// (set) Token: 0x06011FBD RID: 73661 RVA: 0x004A46B0 File Offset: 0x004A28B0
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

			// Token: 0x170036EA RID: 14058
			// (get) Token: 0x06011FBE RID: 73662 RVA: 0x004A46C0 File Offset: 0x004A28C0
			// (set) Token: 0x06011FBF RID: 73663 RVA: 0x004A46D0 File Offset: 0x004A28D0
			public MemoryCorridorUIController m_memoryCorridorUIController
			{
				get
				{
					return this.m_owner.m_memoryCorridorUIController;
				}
				set
				{
					this.m_owner.m_memoryCorridorUIController = value;
				}
			}

			// Token: 0x170036EB RID: 14059
			// (get) Token: 0x06011FC0 RID: 73664 RVA: 0x004A46E0 File Offset: 0x004A28E0
			// (set) Token: 0x06011FC1 RID: 73665 RVA: 0x004A46F0 File Offset: 0x004A28F0
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

			// Token: 0x170036EC RID: 14060
			// (get) Token: 0x06011FC2 RID: 73666 RVA: 0x004A4700 File Offset: 0x004A2900
			// (set) Token: 0x06011FC3 RID: 73667 RVA: 0x004A4710 File Offset: 0x004A2910
			public ConfigDataMemoryCorridorInfo m_memoryCorridorInfo
			{
				get
				{
					return this.m_owner.m_memoryCorridorInfo;
				}
				set
				{
					this.m_owner.m_memoryCorridorInfo = value;
				}
			}

			// Token: 0x170036ED RID: 14061
			// (get) Token: 0x06011FC4 RID: 73668 RVA: 0x004A4720 File Offset: 0x004A2920
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170036EE RID: 14062
			// (get) Token: 0x06011FC5 RID: 73669 RVA: 0x004A4730 File Offset: 0x004A2930
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06011FC6 RID: 73670 RVA: 0x004A4740 File Offset: 0x004A2940
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011FC7 RID: 73671 RVA: 0x004A4750 File Offset: 0x004A2950
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06011FC8 RID: 73672 RVA: 0x004A4760 File Offset: 0x004A2960
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06011FC9 RID: 73673 RVA: 0x004A4770 File Offset: 0x004A2970
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06011FCA RID: 73674 RVA: 0x004A4780 File Offset: 0x004A2980
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06011FCB RID: 73675 RVA: 0x004A4790 File Offset: 0x004A2990
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06011FCC RID: 73676 RVA: 0x004A47A0 File Offset: 0x004A29A0
			public void InitMemoryCorridorUIController()
			{
				this.m_owner.InitMemoryCorridorUIController();
			}

			// Token: 0x06011FCD RID: 73677 RVA: 0x004A47B0 File Offset: 0x004A29B0
			public void UninitMemoryCorridorUIController()
			{
				this.m_owner.UninitMemoryCorridorUIController();
			}

			// Token: 0x06011FCE RID: 73678 RVA: 0x004A47C0 File Offset: 0x004A29C0
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06011FCF RID: 73679 RVA: 0x004A47D0 File Offset: 0x004A29D0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06011FD0 RID: 73680 RVA: 0x004A47E0 File Offset: 0x004A29E0
			public void MemoryCorridorUIController_OnReturn()
			{
				this.m_owner.MemoryCorridorUIController_OnReturn();
			}

			// Token: 0x06011FD1 RID: 73681 RVA: 0x004A47F0 File Offset: 0x004A29F0
			public void MemoryCorridorUIController_OnShowHelp()
			{
				this.m_owner.MemoryCorridorUIController_OnShowHelp();
			}

			// Token: 0x06011FD2 RID: 73682 RVA: 0x004A4800 File Offset: 0x004A2A00
			public void MemoryCorridorUIController_OnAddTicket()
			{
				this.m_owner.MemoryCorridorUIController_OnAddTicket();
			}

			// Token: 0x06011FD3 RID: 73683 RVA: 0x004A4810 File Offset: 0x004A2A10
			public void MemoryCorridorUIController_OnShowTeam()
			{
				this.m_owner.MemoryCorridorUIController_OnShowTeam();
			}

			// Token: 0x06011FD4 RID: 73684 RVA: 0x004A4820 File Offset: 0x004A2A20
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06011FD5 RID: 73685 RVA: 0x004A4830 File Offset: 0x004A2A30
			public void MemoryCorridorUIController_OnStartMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo)
			{
				this.m_owner.MemoryCorridorUIController_OnStartMemoryCorridorLevel(levelInfo);
			}

			// Token: 0x0400A303 RID: 41731
			private MemoryCorridorUITask m_owner;
		}
	}
}
