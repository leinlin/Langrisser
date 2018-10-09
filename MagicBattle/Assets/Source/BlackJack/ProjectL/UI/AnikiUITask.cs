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
	// Token: 0x020009D0 RID: 2512
	[HotFix]
	public class AnikiUITask : UITask
	{
		// Token: 0x06009300 RID: 37632 RVA: 0x002A6A64 File Offset: 0x002A4C64
		public AnikiUITask(string name) : base(name)
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

		// Token: 0x06009301 RID: 37633 RVA: 0x002A6B90 File Offset: 0x002A4D90
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

		// Token: 0x06009302 RID: 37634 RVA: 0x002A6C1C File Offset: 0x002A4E1C
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

		// Token: 0x06009303 RID: 37635 RVA: 0x002A6CA8 File Offset: 0x002A4EA8
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
			this.m_anikiGymInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_anikiGymInfo = uiintentCustom.GetClassParam<ConfigDataAnikiGymInfo>("AnikiGymInfo");
			}
			if (this.m_anikiGymInfo != null && !projectLPlayerContext.IsAnikiGymOpened(this.m_anikiGymInfo.ID))
			{
				this.m_anikiGymInfo = null;
			}
			if (this.m_anikiGymInfo == null)
			{
				foreach (KeyValuePair<int, ConfigDataAnikiGymInfo> keyValuePair in configDataLoader.GetAllConfigDataAnikiGymInfo())
				{
					if (projectLPlayerContext.IsAnikiGymOpened(keyValuePair.Key))
					{
						this.m_anikiGymInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x002A6E00 File Offset: 0x002A5000
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			base.ClearAssetList();
			foreach (KeyValuePair<int, ConfigDataAnikiGymInfo> keyValuePair in configDataLoader.GetAllConfigDataAnikiGymInfo())
			{
				base.CollectSpriteAsset(keyValuePair.Value.Icon);
			}
			List<Goods> list = new List<Goods>();
			foreach (KeyValuePair<int, ConfigDataAnikiLevelInfo> keyValuePair2 in configDataLoader.GetAllConfigDataAnikiLevelInfo())
			{
				ConfigDataAnikiLevelInfo value = keyValuePair2.Value;
				base.CollectSpriteAsset(value.Icon1);
				base.CollectSpriteAsset(value.Icon2);
				list.Clear();
				UIUtility.AppendRandomDropRewardGoodsToList(value.Drop_ID, list);
				foreach (Goods goods in list)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06009305 RID: 37637 RVA: 0x002A6FBC File Offset: 0x002A51BC
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
			this.InitAnikiUIController();
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x002A7028 File Offset: 0x002A5228
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
			this.UninitAnikiUIController();
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x002A7094 File Offset: 0x002A5294
		private void InitAnikiUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAnikiUIController_hotfix != null)
			{
				this.m_InitAnikiUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_anikiUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_anikiUIController = (this.m_uiCtrlArray[0] as AnikiUIController);
				}
				if (!(this.m_anikiUIController != null))
				{
					Debug.LogError("AnikiUIController is null");
					return;
				}
				this.m_anikiUIController.EventOnReturn += this.AnikiUIController_OnReturn;
				this.m_anikiUIController.EventOnShowHelp += this.AnikiUIController_OnShowHelp;
				this.m_anikiUIController.EventOnAddTicket += this.AnikiUIController_OnAddTicket;
				this.m_anikiUIController.EventOnShowTeam += this.AnikiUIController_OnShowTeam;
				this.m_anikiUIController.EventOnSelectAnikiGym += this.AnikiUIController_OnSelectAnikiGym;
				this.m_anikiUIController.EventOnStartAnikiLevel += this.AnikiUIController_OnStartAnikiLevel;
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

		// Token: 0x06009308 RID: 37640 RVA: 0x002A7224 File Offset: 0x002A5424
		private void UninitAnikiUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitAnikiUIController_hotfix != null)
			{
				this.m_UninitAnikiUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_anikiUIController != null)
			{
				this.m_anikiUIController.EventOnReturn -= this.AnikiUIController_OnReturn;
				this.m_anikiUIController.EventOnShowHelp -= this.AnikiUIController_OnShowHelp;
				this.m_anikiUIController.EventOnAddTicket -= this.AnikiUIController_OnAddTicket;
				this.m_anikiUIController.EventOnShowTeam -= this.AnikiUIController_OnShowTeam;
				this.m_anikiUIController.EventOnSelectAnikiGym -= this.AnikiUIController_OnSelectAnikiGym;
				this.m_anikiUIController.EventOnStartAnikiLevel -= this.AnikiUIController_OnStartAnikiLevel;
				this.m_anikiUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x002A7340 File Offset: 0x002A5540
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
				this.m_anikiUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.m_anikiUIController.SetDailyRewardCount(projectLPlayerContext.GetAnikiDailyRewardRestCount(), projectLPlayerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_AnikiGym));
			this.m_anikiUIController.ClearAnikiGymListItems();
			foreach (KeyValuePair<int, ConfigDataAnikiGymInfo> keyValuePair in configDataLoader.GetAllConfigDataAnikiGymInfo())
			{
				this.m_anikiUIController.AddAnikiGymListItem(keyValuePair.Value, projectLPlayerContext.IsAnikiGymOpened(keyValuePair.Key));
			}
			if (this.m_anikiGymInfo != null)
			{
				this.m_anikiUIController.SetSelectedAnikiGym(this.m_anikiGymInfo);
				this.UpdateAnikiLevels(this.m_anikiGymInfo);
			}
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x002A7494 File Offset: 0x002A5694
		private void UpdateAnikiLevels(ConfigDataAnikiGymInfo anikiGymInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateAnikiLevelsConfigDataAnikiGymInfo_hotfix != null)
			{
				this.m_UpdateAnikiLevelsConfigDataAnikiGymInfo_hotfix.call(new object[]
				{
					this,
					anikiGymInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_anikiUIController.SetAllAnikiLevelListItem(anikiGymInfo.m_levelInfos);
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x002A7518 File Offset: 0x002A5718
		private void AnikiUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUIController_OnReturn_hotfix != null)
			{
				this.m_AnikiUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x0600930C RID: 37644 RVA: 0x002A759C File Offset: 0x002A579C
		private void AnikiUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUIController_OnShowHelp_hotfix != null)
			{
				this.m_AnikiUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Aniki);
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x002A7608 File Offset: 0x002A5808
		private void AnikiUIController_OnAddTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUIController_OnAddTicket_hotfix != null)
			{
				this.m_AnikiUIController_OnAddTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x002A7668 File Offset: 0x002A5868
		private void AnikiUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUIController_OnShowTeam_hotfix != null)
			{
				this.m_AnikiUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_AnikiGym, this.m_anikiGymInfo.ID, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x002A76EC File Offset: 0x002A58EC
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

		// Token: 0x06009310 RID: 37648 RVA: 0x002A7778 File Offset: 0x002A5978
		private void AnikiUIController_OnSelectAnikiGym(ConfigDataAnikiGymInfo anikiGymInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUIController_OnSelectAnikiGymConfigDataAnikiGymInfo_hotfix != null)
			{
				this.m_AnikiUIController_OnSelectAnikiGymConfigDataAnikiGymInfo_hotfix.call(new object[]
				{
					this,
					anikiGymInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_anikiGymInfo = anikiGymInfo;
			this.UpdateAnikiLevels(anikiGymInfo);
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x002A77F8 File Offset: 0x002A59F8
		private void AnikiUIController_OnStartAnikiLevel(ConfigDataAnikiLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUIController_OnStartAnikiLevelConfigDataAnikiLevelInfo_hotfix != null)
			{
				this.m_AnikiUIController_OnStartAnikiLevelConfigDataAnikiLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackAnikiLevel(levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.AnikiGym, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06009312 RID: 37650 RVA: 0x002A78A8 File Offset: 0x002A5AA8
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

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06009313 RID: 37651 RVA: 0x002A791C File Offset: 0x002A5B1C
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

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06009314 RID: 37652 RVA: 0x002A7990 File Offset: 0x002A5B90
		// (set) Token: 0x06009315 RID: 37653 RVA: 0x002A79B0 File Offset: 0x002A5BB0
		[DoNotToLua]
		public new AnikiUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AnikiUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x002A79BC File Offset: 0x002A5BBC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x002A79C8 File Offset: 0x002A5BC8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x002A79D0 File Offset: 0x002A5BD0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x002A79D8 File Offset: 0x002A5BD8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x002A79E4 File Offset: 0x002A5BE4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x002A79F0 File Offset: 0x002A5BF0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600931C RID: 37660 RVA: 0x002A79FC File Offset: 0x002A5BFC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x002A7A04 File Offset: 0x002A5C04
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x002A7A0C File Offset: 0x002A5C0C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x002A7A14 File Offset: 0x002A5C14
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x002A7A1C File Offset: 0x002A5C1C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x002A7A24 File Offset: 0x002A5C24
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x002A7A2C File Offset: 0x002A5C2C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x002A7A34 File Offset: 0x002A5C34
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x002A7A40 File Offset: 0x002A5C40
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x002A7A4C File Offset: 0x002A5C4C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x002A7A58 File Offset: 0x002A5C58
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x002A7A64 File Offset: 0x002A5C64
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x002A7A6C File Offset: 0x002A5C6C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x002A7A74 File Offset: 0x002A5C74
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x002A7A7C File Offset: 0x002A5C7C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x002A7A84 File Offset: 0x002A5C84
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600932C RID: 37676 RVA: 0x002A7A8C File Offset: 0x002A5C8C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x002A7AF4 File Offset: 0x002A5CF4
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
					this.m_InitAnikiUIController_hotfix = (luaObj.RawGet("InitAnikiUIController") as LuaFunction);
					this.m_UninitAnikiUIController_hotfix = (luaObj.RawGet("UninitAnikiUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateAnikiLevelsConfigDataAnikiGymInfo_hotfix = (luaObj.RawGet("UpdateAnikiLevels") as LuaFunction);
					this.m_AnikiUIController_OnReturn_hotfix = (luaObj.RawGet("AnikiUIController_OnReturn") as LuaFunction);
					this.m_AnikiUIController_OnShowHelp_hotfix = (luaObj.RawGet("AnikiUIController_OnShowHelp") as LuaFunction);
					this.m_AnikiUIController_OnAddTicket_hotfix = (luaObj.RawGet("AnikiUIController_OnAddTicket") as LuaFunction);
					this.m_AnikiUIController_OnShowTeam_hotfix = (luaObj.RawGet("AnikiUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_AnikiUIController_OnSelectAnikiGymConfigDataAnikiGymInfo_hotfix = (luaObj.RawGet("AnikiUIController_OnSelectAnikiGym") as LuaFunction);
					this.m_AnikiUIController_OnStartAnikiLevelConfigDataAnikiLevelInfo_hotfix = (luaObj.RawGet("AnikiUIController_OnStartAnikiLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009330 RID: 37680 RVA: 0x002A7D9C File Offset: 0x002A5F9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006681 RID: 26241
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "AnikiUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Aniki_ABS/Prefab/AnikiUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006682 RID: 26242
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "AnikiUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.AnikiUIController"),
				m_ctrlName = "AnikiUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "AnikiUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "AnikiPlayerResourceUIController"
			}
		};

		// Token: 0x04006683 RID: 26243
		private AnikiUIController m_anikiUIController;

		// Token: 0x04006684 RID: 26244
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04006685 RID: 26245
		private ConfigDataAnikiGymInfo m_anikiGymInfo;

		// Token: 0x04006686 RID: 26246
		[DoNotToLua]
		private AnikiUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006687 RID: 26247
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006688 RID: 26248
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006689 RID: 26249
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400668A RID: 26250
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400668B RID: 26251
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400668C RID: 26252
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400668D RID: 26253
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400668E RID: 26254
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400668F RID: 26255
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006690 RID: 26256
		private LuaFunction m_InitAnikiUIController_hotfix;

		// Token: 0x04006691 RID: 26257
		private LuaFunction m_UninitAnikiUIController_hotfix;

		// Token: 0x04006692 RID: 26258
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006693 RID: 26259
		private LuaFunction m_UpdateAnikiLevelsConfigDataAnikiGymInfo_hotfix;

		// Token: 0x04006694 RID: 26260
		private LuaFunction m_AnikiUIController_OnReturn_hotfix;

		// Token: 0x04006695 RID: 26261
		private LuaFunction m_AnikiUIController_OnShowHelp_hotfix;

		// Token: 0x04006696 RID: 26262
		private LuaFunction m_AnikiUIController_OnAddTicket_hotfix;

		// Token: 0x04006697 RID: 26263
		private LuaFunction m_AnikiUIController_OnShowTeam_hotfix;

		// Token: 0x04006698 RID: 26264
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04006699 RID: 26265
		private LuaFunction m_AnikiUIController_OnSelectAnikiGymConfigDataAnikiGymInfo_hotfix;

		// Token: 0x0400669A RID: 26266
		private LuaFunction m_AnikiUIController_OnStartAnikiLevelConfigDataAnikiLevelInfo_hotfix;

		// Token: 0x0400669B RID: 26267
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400669C RID: 26268
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x020009D1 RID: 2513
		public new class LuaExportHelper
		{
			// Token: 0x06009331 RID: 37681 RVA: 0x002A7E04 File Offset: 0x002A6004
			public LuaExportHelper(AnikiUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009332 RID: 37682 RVA: 0x002A7E14 File Offset: 0x002A6014
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06009333 RID: 37683 RVA: 0x002A7E24 File Offset: 0x002A6024
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06009334 RID: 37684 RVA: 0x002A7E34 File Offset: 0x002A6034
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06009335 RID: 37685 RVA: 0x002A7E44 File Offset: 0x002A6044
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06009336 RID: 37686 RVA: 0x002A7E54 File Offset: 0x002A6054
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06009337 RID: 37687 RVA: 0x002A7E64 File Offset: 0x002A6064
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06009338 RID: 37688 RVA: 0x002A7E74 File Offset: 0x002A6074
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06009339 RID: 37689 RVA: 0x002A7E84 File Offset: 0x002A6084
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600933A RID: 37690 RVA: 0x002A7E94 File Offset: 0x002A6094
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600933B RID: 37691 RVA: 0x002A7EA4 File Offset: 0x002A60A4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600933C RID: 37692 RVA: 0x002A7EB4 File Offset: 0x002A60B4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600933D RID: 37693 RVA: 0x002A7EC4 File Offset: 0x002A60C4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600933E RID: 37694 RVA: 0x002A7ED4 File Offset: 0x002A60D4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600933F RID: 37695 RVA: 0x002A7EE4 File Offset: 0x002A60E4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06009340 RID: 37696 RVA: 0x002A7EF4 File Offset: 0x002A60F4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06009341 RID: 37697 RVA: 0x002A7F04 File Offset: 0x002A6104
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06009342 RID: 37698 RVA: 0x002A7F14 File Offset: 0x002A6114
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06009343 RID: 37699 RVA: 0x002A7F24 File Offset: 0x002A6124
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06009344 RID: 37700 RVA: 0x002A7F34 File Offset: 0x002A6134
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06009345 RID: 37701 RVA: 0x002A7F44 File Offset: 0x002A6144
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06009346 RID: 37702 RVA: 0x002A7F54 File Offset: 0x002A6154
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06009347 RID: 37703 RVA: 0x002A7F64 File Offset: 0x002A6164
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06009348 RID: 37704 RVA: 0x002A7F74 File Offset: 0x002A6174
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17001E6A RID: 7786
			// (get) Token: 0x06009349 RID: 37705 RVA: 0x002A7F84 File Offset: 0x002A6184
			// (set) Token: 0x0600934A RID: 37706 RVA: 0x002A7F94 File Offset: 0x002A6194
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

			// Token: 0x17001E6B RID: 7787
			// (get) Token: 0x0600934B RID: 37707 RVA: 0x002A7FA4 File Offset: 0x002A61A4
			// (set) Token: 0x0600934C RID: 37708 RVA: 0x002A7FB4 File Offset: 0x002A61B4
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

			// Token: 0x17001E6C RID: 7788
			// (get) Token: 0x0600934D RID: 37709 RVA: 0x002A7FC4 File Offset: 0x002A61C4
			// (set) Token: 0x0600934E RID: 37710 RVA: 0x002A7FD4 File Offset: 0x002A61D4
			public AnikiUIController m_anikiUIController
			{
				get
				{
					return this.m_owner.m_anikiUIController;
				}
				set
				{
					this.m_owner.m_anikiUIController = value;
				}
			}

			// Token: 0x17001E6D RID: 7789
			// (get) Token: 0x0600934F RID: 37711 RVA: 0x002A7FE4 File Offset: 0x002A61E4
			// (set) Token: 0x06009350 RID: 37712 RVA: 0x002A7FF4 File Offset: 0x002A61F4
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

			// Token: 0x17001E6E RID: 7790
			// (get) Token: 0x06009351 RID: 37713 RVA: 0x002A8004 File Offset: 0x002A6204
			// (set) Token: 0x06009352 RID: 37714 RVA: 0x002A8014 File Offset: 0x002A6214
			public ConfigDataAnikiGymInfo m_anikiGymInfo
			{
				get
				{
					return this.m_owner.m_anikiGymInfo;
				}
				set
				{
					this.m_owner.m_anikiGymInfo = value;
				}
			}

			// Token: 0x17001E6F RID: 7791
			// (get) Token: 0x06009353 RID: 37715 RVA: 0x002A8024 File Offset: 0x002A6224
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001E70 RID: 7792
			// (get) Token: 0x06009354 RID: 37716 RVA: 0x002A8034 File Offset: 0x002A6234
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06009355 RID: 37717 RVA: 0x002A8044 File Offset: 0x002A6244
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06009356 RID: 37718 RVA: 0x002A8054 File Offset: 0x002A6254
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06009357 RID: 37719 RVA: 0x002A8064 File Offset: 0x002A6264
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06009358 RID: 37720 RVA: 0x002A8074 File Offset: 0x002A6274
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06009359 RID: 37721 RVA: 0x002A8084 File Offset: 0x002A6284
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600935A RID: 37722 RVA: 0x002A8094 File Offset: 0x002A6294
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600935B RID: 37723 RVA: 0x002A80A4 File Offset: 0x002A62A4
			public void InitAnikiUIController()
			{
				this.m_owner.InitAnikiUIController();
			}

			// Token: 0x0600935C RID: 37724 RVA: 0x002A80B4 File Offset: 0x002A62B4
			public void UninitAnikiUIController()
			{
				this.m_owner.UninitAnikiUIController();
			}

			// Token: 0x0600935D RID: 37725 RVA: 0x002A80C4 File Offset: 0x002A62C4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600935E RID: 37726 RVA: 0x002A80D4 File Offset: 0x002A62D4
			public void UpdateAnikiLevels(ConfigDataAnikiGymInfo anikiGymInfo)
			{
				this.m_owner.UpdateAnikiLevels(anikiGymInfo);
			}

			// Token: 0x0600935F RID: 37727 RVA: 0x002A80E4 File Offset: 0x002A62E4
			public void AnikiUIController_OnReturn()
			{
				this.m_owner.AnikiUIController_OnReturn();
			}

			// Token: 0x06009360 RID: 37728 RVA: 0x002A80F4 File Offset: 0x002A62F4
			public void AnikiUIController_OnShowHelp()
			{
				this.m_owner.AnikiUIController_OnShowHelp();
			}

			// Token: 0x06009361 RID: 37729 RVA: 0x002A8104 File Offset: 0x002A6304
			public void AnikiUIController_OnAddTicket()
			{
				this.m_owner.AnikiUIController_OnAddTicket();
			}

			// Token: 0x06009362 RID: 37730 RVA: 0x002A8114 File Offset: 0x002A6314
			public void AnikiUIController_OnShowTeam()
			{
				this.m_owner.AnikiUIController_OnShowTeam();
			}

			// Token: 0x06009363 RID: 37731 RVA: 0x002A8124 File Offset: 0x002A6324
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06009364 RID: 37732 RVA: 0x002A8134 File Offset: 0x002A6334
			public void AnikiUIController_OnSelectAnikiGym(ConfigDataAnikiGymInfo anikiGymInfo)
			{
				this.m_owner.AnikiUIController_OnSelectAnikiGym(anikiGymInfo);
			}

			// Token: 0x06009365 RID: 37733 RVA: 0x002A8144 File Offset: 0x002A6344
			public void AnikiUIController_OnStartAnikiLevel(ConfigDataAnikiLevelInfo levelInfo)
			{
				this.m_owner.AnikiUIController_OnStartAnikiLevel(levelInfo);
			}

			// Token: 0x0400669D RID: 26269
			private AnikiUITask m_owner;
		}
	}
}
