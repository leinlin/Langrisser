using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AC2 RID: 2754
	[HotFix]
	public class BattleResultUITask : UITask
	{
		// Token: 0x0600B1B1 RID: 45489 RVA: 0x00313008 File Offset: 0x00311208
		public BattleResultUITask(string name) : base(name)
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

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x003130FC File Offset: 0x003112FC
		public static BattleResultUITask StartUITask(BattleType battleType, List<int> heroIds, int stars, int starTurnMax, int starDeadMax, int turn, BattleReward battleReward, bool isFirstWin, List<int> gotAchievements, BattleLevelAchievement[] achievements)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<Hero> list = new List<Hero>();
			foreach (int heroId in heroIds)
			{
				Hero hero = projectLPlayerContext.GetHero(heroId);
				if (hero != null && list.Count < 5)
				{
					list.Add(hero);
				}
			}
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BattleResultUITask).Name, null);
			uiintentCustom.SetParam("BattleType", battleType);
			uiintentCustom.SetParam("HeroList", list);
			uiintentCustom.SetParam("Stars", stars);
			uiintentCustom.SetParam("StarTurnMax", starTurnMax);
			uiintentCustom.SetParam("StarDeadMax", starDeadMax);
			uiintentCustom.SetParam("Turn", turn);
			uiintentCustom.SetParam("BattleReward", battleReward);
			uiintentCustom.SetParam("IsFirstWin", isFirstWin);
			uiintentCustom.SetParam("GotAchievements", gotAchievements);
			uiintentCustom.SetParam("Achievements", achievements);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as BattleResultUITask;
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x00313258 File Offset: 0x00311458
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

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x003132E4 File Offset: 0x003114E4
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

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x00313370 File Offset: 0x00311570
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
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_battleType = uiintentCustom.GetStructParam<BattleType>("BattleType");
				this.m_heros = uiintentCustom.GetClassParam<List<Hero>>("HeroList");
				this.m_stars = uiintentCustom.GetStructParam<int>("Stars");
				this.m_starTurnMax = uiintentCustom.GetStructParam<int>("StarTurnMax");
				this.m_starDeadMax = uiintentCustom.GetStructParam<int>("StarDeadMax");
				this.m_turn = uiintentCustom.GetStructParam<int>("Turn");
				this.m_battleReward = uiintentCustom.GetClassParam<BattleReward>("BattleReward");
				this.m_isFirstWin = uiintentCustom.GetStructParam<bool>("IsFirstWin");
				this.m_gotAchievements = uiintentCustom.GetClassParam<List<int>>("GotAchievements");
				this.m_achievements = uiintentCustom.GetClassParam<BattleLevelAchievement[]>("Achievements");
			}
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x00313498 File Offset: 0x00311698
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
			if (this.m_heros != null)
			{
				foreach (Hero hero in this.m_heros)
				{
					ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
					if (charImageInfo != null)
					{
						base.CollectSpriteAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x00313594 File Offset: 0x00311794
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
			if (this.m_battleResultUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_battleResultUIController = (this.m_uiCtrlArray[0] as BattleResultUIController);
				}
				if (!(this.m_battleResultUIController != null))
				{
					Debug.LogError("BattleResultUIController is null");
					return;
				}
				this.m_battleResultUIController.EventOnClose += this.BattleResultUIController_OnClose;
			}
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x00313664 File Offset: 0x00311864
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
			if (this.m_battleResultUIController != null)
			{
				this.m_battleResultUIController.EventOnClose -= this.BattleResultUIController_OnClose;
				this.m_battleResultUIController = null;
			}
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x003136FC File Offset: 0x003118FC
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
				this.m_battleResultUIController.ShowBattleResult(this.m_battleType, this.m_heros, this.m_stars, this.m_starTurnMax, this.m_starDeadMax, this.m_turn, this.m_battleReward, this.m_gotAchievements, this.m_achievements);
			}
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x003137A8 File Offset: 0x003119A8
		private void BattleResultUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultUIController_OnClose_hotfix != null)
			{
				this.m_BattleResultUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.m_battleReward != null && !this.m_battleReward.IsChestGoodsEmpty())
			{
				this.StartChestUITask();
			}
			else if (this.m_battleType == BattleType.UnchartedScore_ChallengeLevel || this.m_battleType == BattleType.UnchartedScore_ScoreLevel)
			{
				this.StartBattleResultScoreUITask();
			}
			else if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x00313870 File Offset: 0x00311A70
		private void StartChestUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartChestUITask_hotfix != null)
			{
				this.m_StartChestUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChestUITask chestUITask = ChestUITask.StartUITask(this.m_battleReward, this.m_isFirstWin, false);
			if (this.m_chestUITask == null)
			{
				this.m_chestUITask = chestUITask;
				this.m_chestUITask.EventOnStop += this.ChestUITask_OnStop;
				this.m_chestUITask.EventOnClose += this.ChestUITask_OnClose;
			}
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x00313924 File Offset: 0x00311B24
		private void ChestUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChestUITask_OnStopTask_hotfix != null)
			{
				this.m_ChestUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chestUITask == task)
			{
				this.m_chestUITask.EventOnStop -= this.ChestUITask_OnStop;
				this.m_chestUITask.EventOnClose -= this.ChestUITask_OnClose;
				this.m_chestUITask = null;
			}
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x003139D8 File Offset: 0x00311BD8
		private void ChestUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChestUITask_OnClose_hotfix != null)
			{
				this.m_ChestUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chestUITask != null)
			{
				this.ChestUITask_OnStop(this.m_chestUITask);
			}
			if (this.m_battleType == BattleType.UnchartedScore_ChallengeLevel || this.m_battleType == BattleType.UnchartedScore_ScoreLevel)
			{
				this.StartBattleResultScoreUITask();
			}
			else if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x00313A8C File Offset: 0x00311C8C
		private void StartBattleResultScoreUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleResultScoreUITask_hotfix != null)
			{
				this.m_StartBattleResultScoreUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultScoreUITask battleResultScoreUITask = BattleResultScoreUITask.StartUITask(this.m_battleReward);
			if (this.m_battleResultScoreUITask == null)
			{
				this.m_battleResultScoreUITask = battleResultScoreUITask;
				this.m_battleResultScoreUITask.EventOnStop += this.BattleResultScoreUITask_OnStop;
				this.m_battleResultScoreUITask.EventOnClose += this.BattleResultScoreUITask_OnClose;
			}
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x00313B38 File Offset: 0x00311D38
		private void BattleResultScoreUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultScoreUITask_OnStopTask_hotfix != null)
			{
				this.m_BattleResultScoreUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleResultScoreUITask == task)
			{
				this.m_battleResultScoreUITask.EventOnStop -= this.BattleResultScoreUITask_OnStop;
				this.m_battleResultScoreUITask.EventOnClose -= this.BattleResultScoreUITask_OnClose;
				this.m_battleResultScoreUITask = null;
			}
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x00313BEC File Offset: 0x00311DEC
		private void BattleResultScoreUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultScoreUITask_OnClose_hotfix != null)
			{
				this.m_BattleResultScoreUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleResultScoreUITask != null)
			{
				this.BattleResultScoreUITask_OnStop(this.m_battleResultScoreUITask);
			}
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x1400021B RID: 539
		// (add) Token: 0x0600B1C1 RID: 45505 RVA: 0x00313C7C File Offset: 0x00311E7C
		// (remove) Token: 0x0600B1C2 RID: 45506 RVA: 0x00313D18 File Offset: 0x00311F18
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600B1C3 RID: 45507 RVA: 0x00313DB4 File Offset: 0x00311FB4
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

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x00313E28 File Offset: 0x00312028
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

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600B1C5 RID: 45509 RVA: 0x00313E9C File Offset: 0x0031209C
		// (set) Token: 0x0600B1C6 RID: 45510 RVA: 0x00313EBC File Offset: 0x003120BC
		[DoNotToLua]
		public new BattleResultUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleResultUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x00313EC8 File Offset: 0x003120C8
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x00313ED4 File Offset: 0x003120D4
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x00313EDC File Offset: 0x003120DC
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x00313EE4 File Offset: 0x003120E4
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x00313EF0 File Offset: 0x003120F0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x00313EFC File Offset: 0x003120FC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x00313F08 File Offset: 0x00312108
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x00313F10 File Offset: 0x00312110
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x00313F18 File Offset: 0x00312118
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x00313F20 File Offset: 0x00312120
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x00313F28 File Offset: 0x00312128
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x00313F30 File Offset: 0x00312130
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x00313F38 File Offset: 0x00312138
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x00313F40 File Offset: 0x00312140
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x00313F4C File Offset: 0x0031214C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x00313F58 File Offset: 0x00312158
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600B1D7 RID: 45527 RVA: 0x00313F64 File Offset: 0x00312164
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x00313F70 File Offset: 0x00312170
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x00313F78 File Offset: 0x00312178
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x00313F80 File Offset: 0x00312180
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x00313F88 File Offset: 0x00312188
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x00313F90 File Offset: 0x00312190
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x00313F98 File Offset: 0x00312198
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x00313FA0 File Offset: 0x003121A0
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x00313FC0 File Offset: 0x003121C0
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x00313FCC File Offset: 0x003121CC
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_BattleResultUIController_OnClose_hotfix = (luaObj.RawGet("BattleResultUIController_OnClose") as LuaFunction);
					this.m_StartChestUITask_hotfix = (luaObj.RawGet("StartChestUITask") as LuaFunction);
					this.m_ChestUITask_OnStopTask_hotfix = (luaObj.RawGet("ChestUITask_OnStop") as LuaFunction);
					this.m_ChestUITask_OnClose_hotfix = (luaObj.RawGet("ChestUITask_OnClose") as LuaFunction);
					this.m_StartBattleResultScoreUITask_hotfix = (luaObj.RawGet("StartBattleResultScoreUITask") as LuaFunction);
					this.m_BattleResultScoreUITask_OnStopTask_hotfix = (luaObj.RawGet("BattleResultScoreUITask_OnStop") as LuaFunction);
					this.m_BattleResultScoreUITask_OnClose_hotfix = (luaObj.RawGet("BattleResultScoreUITask_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x0031425C File Offset: 0x0031245C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleResultUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007396 RID: 29590
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleResultUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleResultUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007397 RID: 29591
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleResultUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleResultUIController"),
				m_ctrlName = "BattleResultUIController"
			}
		};

		// Token: 0x04007398 RID: 29592
		private BattleResultUIController m_battleResultUIController;

		// Token: 0x04007399 RID: 29593
		private BattleType m_battleType;

		// Token: 0x0400739A RID: 29594
		private List<Hero> m_heros;

		// Token: 0x0400739B RID: 29595
		private int m_stars;

		// Token: 0x0400739C RID: 29596
		private int m_starTurnMax;

		// Token: 0x0400739D RID: 29597
		private int m_starDeadMax;

		// Token: 0x0400739E RID: 29598
		private int m_turn;

		// Token: 0x0400739F RID: 29599
		private BattleReward m_battleReward;

		// Token: 0x040073A0 RID: 29600
		private bool m_isFirstWin;

		// Token: 0x040073A1 RID: 29601
		private List<int> m_gotAchievements;

		// Token: 0x040073A2 RID: 29602
		private BattleLevelAchievement[] m_achievements;

		// Token: 0x040073A3 RID: 29603
		private ChestUITask m_chestUITask;

		// Token: 0x040073A4 RID: 29604
		private BattleResultScoreUITask m_battleResultScoreUITask;

		// Token: 0x040073A5 RID: 29605
		[DoNotToLua]
		private BattleResultUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040073A6 RID: 29606
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040073A7 RID: 29607
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040073A8 RID: 29608
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040073A9 RID: 29609
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040073AA RID: 29610
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x040073AB RID: 29611
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x040073AC RID: 29612
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040073AD RID: 29613
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040073AE RID: 29614
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040073AF RID: 29615
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040073B0 RID: 29616
		private LuaFunction m_BattleResultUIController_OnClose_hotfix;

		// Token: 0x040073B1 RID: 29617
		private LuaFunction m_StartChestUITask_hotfix;

		// Token: 0x040073B2 RID: 29618
		private LuaFunction m_ChestUITask_OnStopTask_hotfix;

		// Token: 0x040073B3 RID: 29619
		private LuaFunction m_ChestUITask_OnClose_hotfix;

		// Token: 0x040073B4 RID: 29620
		private LuaFunction m_StartBattleResultScoreUITask_hotfix;

		// Token: 0x040073B5 RID: 29621
		private LuaFunction m_BattleResultScoreUITask_OnStopTask_hotfix;

		// Token: 0x040073B6 RID: 29622
		private LuaFunction m_BattleResultScoreUITask_OnClose_hotfix;

		// Token: 0x040073B7 RID: 29623
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040073B8 RID: 29624
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040073B9 RID: 29625
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040073BA RID: 29626
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000AC3 RID: 2755
		public new class LuaExportHelper
		{
			// Token: 0x0600B1E2 RID: 45538 RVA: 0x003142C4 File Offset: 0x003124C4
			public LuaExportHelper(BattleResultUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B1E3 RID: 45539 RVA: 0x003142D4 File Offset: 0x003124D4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600B1E4 RID: 45540 RVA: 0x003142E4 File Offset: 0x003124E4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600B1E5 RID: 45541 RVA: 0x003142F4 File Offset: 0x003124F4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600B1E6 RID: 45542 RVA: 0x00314304 File Offset: 0x00312504
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600B1E7 RID: 45543 RVA: 0x00314314 File Offset: 0x00312514
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600B1E8 RID: 45544 RVA: 0x00314324 File Offset: 0x00312524
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600B1E9 RID: 45545 RVA: 0x00314334 File Offset: 0x00312534
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600B1EA RID: 45546 RVA: 0x00314344 File Offset: 0x00312544
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600B1EB RID: 45547 RVA: 0x00314354 File Offset: 0x00312554
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600B1EC RID: 45548 RVA: 0x00314364 File Offset: 0x00312564
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600B1ED RID: 45549 RVA: 0x00314374 File Offset: 0x00312574
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600B1EE RID: 45550 RVA: 0x00314384 File Offset: 0x00312584
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600B1EF RID: 45551 RVA: 0x00314394 File Offset: 0x00312594
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600B1F0 RID: 45552 RVA: 0x003143A4 File Offset: 0x003125A4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600B1F1 RID: 45553 RVA: 0x003143B4 File Offset: 0x003125B4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600B1F2 RID: 45554 RVA: 0x003143C4 File Offset: 0x003125C4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600B1F3 RID: 45555 RVA: 0x003143D4 File Offset: 0x003125D4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600B1F4 RID: 45556 RVA: 0x003143E4 File Offset: 0x003125E4
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600B1F5 RID: 45557 RVA: 0x003143F4 File Offset: 0x003125F4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600B1F6 RID: 45558 RVA: 0x00314404 File Offset: 0x00312604
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600B1F7 RID: 45559 RVA: 0x00314414 File Offset: 0x00312614
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600B1F8 RID: 45560 RVA: 0x00314424 File Offset: 0x00312624
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600B1F9 RID: 45561 RVA: 0x00314434 File Offset: 0x00312634
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600B1FA RID: 45562 RVA: 0x00314444 File Offset: 0x00312644
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600B1FB RID: 45563 RVA: 0x00314454 File Offset: 0x00312654
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002404 RID: 9220
			// (get) Token: 0x0600B1FC RID: 45564 RVA: 0x00314464 File Offset: 0x00312664
			// (set) Token: 0x0600B1FD RID: 45565 RVA: 0x00314474 File Offset: 0x00312674
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

			// Token: 0x17002405 RID: 9221
			// (get) Token: 0x0600B1FE RID: 45566 RVA: 0x00314484 File Offset: 0x00312684
			// (set) Token: 0x0600B1FF RID: 45567 RVA: 0x00314494 File Offset: 0x00312694
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

			// Token: 0x17002406 RID: 9222
			// (get) Token: 0x0600B200 RID: 45568 RVA: 0x003144A4 File Offset: 0x003126A4
			// (set) Token: 0x0600B201 RID: 45569 RVA: 0x003144B4 File Offset: 0x003126B4
			public BattleResultUIController m_battleResultUIController
			{
				get
				{
					return this.m_owner.m_battleResultUIController;
				}
				set
				{
					this.m_owner.m_battleResultUIController = value;
				}
			}

			// Token: 0x17002407 RID: 9223
			// (get) Token: 0x0600B202 RID: 45570 RVA: 0x003144C4 File Offset: 0x003126C4
			// (set) Token: 0x0600B203 RID: 45571 RVA: 0x003144D4 File Offset: 0x003126D4
			public BattleType m_battleType
			{
				get
				{
					return this.m_owner.m_battleType;
				}
				set
				{
					this.m_owner.m_battleType = value;
				}
			}

			// Token: 0x17002408 RID: 9224
			// (get) Token: 0x0600B204 RID: 45572 RVA: 0x003144E4 File Offset: 0x003126E4
			// (set) Token: 0x0600B205 RID: 45573 RVA: 0x003144F4 File Offset: 0x003126F4
			public List<Hero> m_heros
			{
				get
				{
					return this.m_owner.m_heros;
				}
				set
				{
					this.m_owner.m_heros = value;
				}
			}

			// Token: 0x17002409 RID: 9225
			// (get) Token: 0x0600B206 RID: 45574 RVA: 0x00314504 File Offset: 0x00312704
			// (set) Token: 0x0600B207 RID: 45575 RVA: 0x00314514 File Offset: 0x00312714
			public int m_stars
			{
				get
				{
					return this.m_owner.m_stars;
				}
				set
				{
					this.m_owner.m_stars = value;
				}
			}

			// Token: 0x1700240A RID: 9226
			// (get) Token: 0x0600B208 RID: 45576 RVA: 0x00314524 File Offset: 0x00312724
			// (set) Token: 0x0600B209 RID: 45577 RVA: 0x00314534 File Offset: 0x00312734
			public int m_starTurnMax
			{
				get
				{
					return this.m_owner.m_starTurnMax;
				}
				set
				{
					this.m_owner.m_starTurnMax = value;
				}
			}

			// Token: 0x1700240B RID: 9227
			// (get) Token: 0x0600B20A RID: 45578 RVA: 0x00314544 File Offset: 0x00312744
			// (set) Token: 0x0600B20B RID: 45579 RVA: 0x00314554 File Offset: 0x00312754
			public int m_starDeadMax
			{
				get
				{
					return this.m_owner.m_starDeadMax;
				}
				set
				{
					this.m_owner.m_starDeadMax = value;
				}
			}

			// Token: 0x1700240C RID: 9228
			// (get) Token: 0x0600B20C RID: 45580 RVA: 0x00314564 File Offset: 0x00312764
			// (set) Token: 0x0600B20D RID: 45581 RVA: 0x00314574 File Offset: 0x00312774
			public int m_turn
			{
				get
				{
					return this.m_owner.m_turn;
				}
				set
				{
					this.m_owner.m_turn = value;
				}
			}

			// Token: 0x1700240D RID: 9229
			// (get) Token: 0x0600B20E RID: 45582 RVA: 0x00314584 File Offset: 0x00312784
			// (set) Token: 0x0600B20F RID: 45583 RVA: 0x00314594 File Offset: 0x00312794
			public BattleReward m_battleReward
			{
				get
				{
					return this.m_owner.m_battleReward;
				}
				set
				{
					this.m_owner.m_battleReward = value;
				}
			}

			// Token: 0x1700240E RID: 9230
			// (get) Token: 0x0600B210 RID: 45584 RVA: 0x003145A4 File Offset: 0x003127A4
			// (set) Token: 0x0600B211 RID: 45585 RVA: 0x003145B4 File Offset: 0x003127B4
			public bool m_isFirstWin
			{
				get
				{
					return this.m_owner.m_isFirstWin;
				}
				set
				{
					this.m_owner.m_isFirstWin = value;
				}
			}

			// Token: 0x1700240F RID: 9231
			// (get) Token: 0x0600B212 RID: 45586 RVA: 0x003145C4 File Offset: 0x003127C4
			// (set) Token: 0x0600B213 RID: 45587 RVA: 0x003145D4 File Offset: 0x003127D4
			public List<int> m_gotAchievements
			{
				get
				{
					return this.m_owner.m_gotAchievements;
				}
				set
				{
					this.m_owner.m_gotAchievements = value;
				}
			}

			// Token: 0x17002410 RID: 9232
			// (get) Token: 0x0600B214 RID: 45588 RVA: 0x003145E4 File Offset: 0x003127E4
			// (set) Token: 0x0600B215 RID: 45589 RVA: 0x003145F4 File Offset: 0x003127F4
			public BattleLevelAchievement[] m_achievements
			{
				get
				{
					return this.m_owner.m_achievements;
				}
				set
				{
					this.m_owner.m_achievements = value;
				}
			}

			// Token: 0x17002411 RID: 9233
			// (get) Token: 0x0600B216 RID: 45590 RVA: 0x00314604 File Offset: 0x00312804
			// (set) Token: 0x0600B217 RID: 45591 RVA: 0x00314614 File Offset: 0x00312814
			public ChestUITask m_chestUITask
			{
				get
				{
					return this.m_owner.m_chestUITask;
				}
				set
				{
					this.m_owner.m_chestUITask = value;
				}
			}

			// Token: 0x17002412 RID: 9234
			// (get) Token: 0x0600B218 RID: 45592 RVA: 0x00314624 File Offset: 0x00312824
			// (set) Token: 0x0600B219 RID: 45593 RVA: 0x00314634 File Offset: 0x00312834
			public BattleResultScoreUITask m_battleResultScoreUITask
			{
				get
				{
					return this.m_owner.m_battleResultScoreUITask;
				}
				set
				{
					this.m_owner.m_battleResultScoreUITask = value;
				}
			}

			// Token: 0x17002413 RID: 9235
			// (get) Token: 0x0600B21A RID: 45594 RVA: 0x00314644 File Offset: 0x00312844
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002414 RID: 9236
			// (get) Token: 0x0600B21B RID: 45595 RVA: 0x00314654 File Offset: 0x00312854
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600B21C RID: 45596 RVA: 0x00314664 File Offset: 0x00312864
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600B21D RID: 45597 RVA: 0x00314674 File Offset: 0x00312874
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600B21E RID: 45598 RVA: 0x00314684 File Offset: 0x00312884
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600B21F RID: 45599 RVA: 0x00314694 File Offset: 0x00312894
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600B220 RID: 45600 RVA: 0x003146A4 File Offset: 0x003128A4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600B221 RID: 45601 RVA: 0x003146B4 File Offset: 0x003128B4
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600B222 RID: 45602 RVA: 0x003146C4 File Offset: 0x003128C4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600B223 RID: 45603 RVA: 0x003146D4 File Offset: 0x003128D4
			public void BattleResultUIController_OnClose()
			{
				this.m_owner.BattleResultUIController_OnClose();
			}

			// Token: 0x0600B224 RID: 45604 RVA: 0x003146E4 File Offset: 0x003128E4
			public void StartChestUITask()
			{
				this.m_owner.StartChestUITask();
			}

			// Token: 0x0600B225 RID: 45605 RVA: 0x003146F4 File Offset: 0x003128F4
			public void ChestUITask_OnStop(Task task)
			{
				this.m_owner.ChestUITask_OnStop(task);
			}

			// Token: 0x0600B226 RID: 45606 RVA: 0x00314704 File Offset: 0x00312904
			public void ChestUITask_OnClose()
			{
				this.m_owner.ChestUITask_OnClose();
			}

			// Token: 0x0600B227 RID: 45607 RVA: 0x00314714 File Offset: 0x00312914
			public void StartBattleResultScoreUITask()
			{
				this.m_owner.StartBattleResultScoreUITask();
			}

			// Token: 0x0600B228 RID: 45608 RVA: 0x00314724 File Offset: 0x00312924
			public void BattleResultScoreUITask_OnStop(Task task)
			{
				this.m_owner.BattleResultScoreUITask_OnStop(task);
			}

			// Token: 0x0600B229 RID: 45609 RVA: 0x00314734 File Offset: 0x00312934
			public void BattleResultScoreUITask_OnClose()
			{
				this.m_owner.BattleResultScoreUITask_OnClose();
			}

			// Token: 0x040073BB RID: 29627
			private BattleResultUITask m_owner;
		}
	}
}
