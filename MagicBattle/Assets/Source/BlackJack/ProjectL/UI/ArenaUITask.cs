using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A37 RID: 2615
	[HotFix]
	public class ArenaUITask : UITask
	{
		// Token: 0x0600A05D RID: 41053 RVA: 0x002D36C0 File Offset: 0x002D18C0
		public ArenaUITask(string name) : base(name)
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

		// Token: 0x0600A05E RID: 41054 RVA: 0x002D38C0 File Offset: 0x002D1AC0
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

		// Token: 0x0600A05F RID: 41055 RVA: 0x002D394C File Offset: 0x002D1B4C
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

		// Token: 0x0600A060 RID: 41056 RVA: 0x002D39D8 File Offset: 0x002D1BD8
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
				ArenaUIType structParam = uiintentCustom.GetStructParam<ArenaUIType>("ArenaUIType");
				if (structParam != ArenaUIType.None)
				{
					this.m_arenaUIType = structParam;
				}
				bool structParam2 = uiintentCustom.GetStructParam<bool>("IsBattleReport");
				uiintentCustom.SetParam("ArenaUIType", ArenaUIType.None);
				uiintentCustom.SetParam("IsBattleReport", false);
				if (structParam2)
				{
					if (this.m_arenaUIType == ArenaUIType.Online)
					{
						this.m_onlinePanelType = OnlineArenaPanelType.BattleReport;
					}
					else if (this.m_arenaUIType == ArenaUIType.Offline)
					{
						this.m_offlinePanelType = OfflineArenaPanelType.BattleReport;
					}
				}
			}
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x002D3AD0 File Offset: 0x002D1CD0
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.CollectPlayerHeadAssets(projectLPlayerContext.GetPlayerHeadIcon());
			if (this.m_arenaUIType == ArenaUIType.Online)
			{
				this.CollectOnlineArenaAssets();
			}
			else if (this.m_arenaUIType == ArenaUIType.Offline)
			{
				this.CollectOfflineArenaAssets();
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x002D3B90 File Offset: 0x002D1D90
		private void CollectPlayerHeadAssets(int playerHeadIconId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPlayerHeadAssetsInt32_hotfix != null)
			{
				this.m_CollectPlayerHeadAssetsInt32_hotfix.call(new object[]
				{
					this,
					playerHeadIconId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(playerHeadIconId)));
			base.CollectAsset(UIUtility.GetPlayerHeadFrameImageName(HeadIconTools.GetHeadFrame(playerHeadIconId)));
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x002D3C24 File Offset: 0x002D1E24
		private void CollectHeroModelAssets(List<BattleHero> heros)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectHeroModelAssetsList`1_hotfix != null)
			{
				this.m_CollectHeroModelAssetsList`1_hotfix.call(new object[]
				{
					this,
					heros
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heros == null)
			{
				return;
			}
			foreach (BattleHero hero in heros)
			{
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero));
			}
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x002D3CEC File Offset: 0x002D1EEC
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
			this.InitArenaUIController();
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x002D3D58 File Offset: 0x002D1F58
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
			this.UninitArenaUIController();
		}

		// Token: 0x0600A066 RID: 41062 RVA: 0x002D3DC4 File Offset: 0x002D1FC4
		protected override void RegisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterPlayerContextEvents_hotfix != null)
			{
				this.m_RegisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.RegisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaFlushOpponentsNtf += this.PlayerContext_OnArenaFlushOpponentsNtf;
				projectLPlayerContext.EventOnRealTimePVPMatchupNtf += this.PlayerContext_OnRealTimePVPMatchupNtf;
			}
		}

		// Token: 0x0600A067 RID: 41063 RVA: 0x002D3E64 File Offset: 0x002D2064
		protected override void UnregisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterPlayerContextEvents_hotfix != null)
			{
				this.m_UnregisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UnregisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaFlushOpponentsNtf -= this.PlayerContext_OnArenaFlushOpponentsNtf;
				projectLPlayerContext.EventOnRealTimePVPMatchupNtf -= this.PlayerContext_OnRealTimePVPMatchupNtf;
			}
		}

		// Token: 0x0600A068 RID: 41064 RVA: 0x002D3F04 File Offset: 0x002D2104
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
			if (this.m_arenaDefendUITask != null)
			{
				this.m_arenaDefendUITask.Stop();
				this.m_arenaDefendUITask = null;
			}
			base.OnStop();
		}

		// Token: 0x0600A069 RID: 41065 RVA: 0x002D3F88 File Offset: 0x002D2188
		private void InitArenaUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaUIController_hotfix != null)
			{
				this.m_InitArenaUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_arenaUIController = (this.m_uiCtrlArray[0] as ArenaUIController);
				}
				if (!(this.m_arenaUIController != null))
				{
					global::Debug.LogError("ArenaUIController is null");
					return;
				}
				this.m_arenaUIController.EventOnDefend += this.ArenaUIController_OnDefend;
				this.m_arenaUIController.EventOnReturn += this.ArenaUIController_OnReturn;
				this.m_arenaUIController.EventOnShowHelp += this.ArenaUIController_OnShowHelp;
				this.m_arenaUIController.EventOnShowBuyArenaTicket += this.ArenaUIController_OnShowBuyArenaTicket;
				this.m_arenaUIController.EventOnBuyArenaTicket += this.ArenaUIController_OnBuyArenaTicket;
				this.m_arenaUIController.EventOnSwitchOnlineOffline += this.ArenaUIController_OnSwitchOnlineOffline;
				this.m_arenaUIController.EventOnShowOfflinePanel += this.ArenaUIController_OnShowOfflinePanel;
				this.m_arenaUIController.EventOnGainOfflineVictoryPointsReward += this.ArenaUIController_OnGainOfflineVictoryPointsReward;
				this.m_arenaUIController.EventOnShowOfflineArenaOpponent += this.ArenaUIController_OnShowOfflineArenaOpponent;
				this.m_arenaUIController.EventOnAttackOfflineArenaOpponent += this.ArenaUIController_OnAttackOfflineArenaOpponent;
				this.m_arenaUIController.EventOnShowRevengeOfflineArenaOpponent += this.ArenaUIController_OnShowRevengeOfflineArenaOpponent;
				this.m_arenaUIController.EventOnRevengeOfflineArenaOpponent += this.ArenaUIController_OnRevengeOfflineArenaOpponent;
				this.m_arenaUIController.EventOnOfflineBattleReportReplay += this.ArenaUIController_OnOfflineBattleReportReplay;
				this.m_arenaUIController.EventOnShowOnlinePanel += this.ArenaUIController_OnShowOnlinePanel;
				this.m_arenaUIController.EventOnGainOnlineWeekWinReward += this.ArenaUIController_OnGainOnlineWeekWinReward;
				this.m_arenaUIController.EventOnOnlineBattleReportReplay += this.ArenaUIController_OnOnlineBattleReportReplay;
				this.m_arenaUIController.EventOnLadderChallenge += this.ArenaUIController_OnLadderChallenge;
				this.m_arenaUIController.EventOnCasualChallenge += this.ArenaUIController_OnCasualChallenge;
				this.m_arenaUIController.EventOnMatchingCancel += this.ArenaUIController_OnMatchingCancel;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					global::Debug.LogError("PlayerResourceUIController is null");
					return;
				}
				this.m_playerResourceUIController.EventOnAddCrystal += this.PlayerResourceUIController_OnAddCrystal;
			}
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x002D425C File Offset: 0x002D245C
		private void UninitArenaUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitArenaUIController_hotfix != null)
			{
				this.m_UninitArenaUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaUIController != null)
			{
				this.m_arenaUIController.EventOnDefend -= this.ArenaUIController_OnDefend;
				this.m_arenaUIController.EventOnReturn -= this.ArenaUIController_OnReturn;
				this.m_arenaUIController.EventOnShowHelp -= this.ArenaUIController_OnShowHelp;
				this.m_arenaUIController.EventOnShowBuyArenaTicket -= this.ArenaUIController_OnShowBuyArenaTicket;
				this.m_arenaUIController.EventOnBuyArenaTicket -= this.ArenaUIController_OnBuyArenaTicket;
				this.m_arenaUIController.EventOnSwitchOnlineOffline -= this.ArenaUIController_OnSwitchOnlineOffline;
				this.m_arenaUIController.EventOnShowOfflinePanel -= this.ArenaUIController_OnShowOfflinePanel;
				this.m_arenaUIController.EventOnGainOfflineVictoryPointsReward -= this.ArenaUIController_OnGainOfflineVictoryPointsReward;
				this.m_arenaUIController.EventOnShowOfflineArenaOpponent -= this.ArenaUIController_OnShowOfflineArenaOpponent;
				this.m_arenaUIController.EventOnAttackOfflineArenaOpponent -= this.ArenaUIController_OnAttackOfflineArenaOpponent;
				this.m_arenaUIController.EventOnShowRevengeOfflineArenaOpponent -= this.ArenaUIController_OnShowRevengeOfflineArenaOpponent;
				this.m_arenaUIController.EventOnRevengeOfflineArenaOpponent -= this.ArenaUIController_OnRevengeOfflineArenaOpponent;
				this.m_arenaUIController.EventOnOfflineBattleReportReplay -= this.ArenaUIController_OnOfflineBattleReportReplay;
				this.m_arenaUIController.EventOnShowOnlinePanel -= this.ArenaUIController_OnShowOnlinePanel;
				this.m_arenaUIController.EventOnGainOnlineWeekWinReward -= this.ArenaUIController_OnGainOnlineWeekWinReward;
				this.m_arenaUIController.EventOnOnlineBattleReportReplay -= this.ArenaUIController_OnOnlineBattleReportReplay;
				this.m_arenaUIController.EventOnLadderChallenge -= this.ArenaUIController_OnLadderChallenge;
				this.m_arenaUIController.EventOnCasualChallenge -= this.ArenaUIController_OnCasualChallenge;
				this.m_arenaUIController.EventOnMatchingCancel -= this.ArenaUIController_OnMatchingCancel;
				this.m_arenaUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController.EventOnAddCrystal -= this.PlayerResourceUIController_OnAddCrystal;
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x002D44B8 File Offset: 0x002D26B8
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

		// Token: 0x0600A06C RID: 41068 RVA: 0x002D4520 File Offset: 0x002D2720
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
			base.OnTick();
			if (this.m_arenaUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				if (this.m_arenaUIType == ArenaUIType.Offline)
				{
					if (this.m_offlinePanelType == OfflineArenaPanelType.Clash)
					{
						this.UpdateOfflineArenaOpponentRefreshTime();
					}
				}
				else if (this.m_arenaUIType == ArenaUIType.Online && this.m_onlinePanelType == OnlineArenaPanelType.Clash)
				{
					this.UpdateOnlineMatchingTime();
					this.UpdateLadderMode();
				}
			}
			if (this.m_isNeedCheckOnline)
			{
				CommonUITask.TickCheckOnline();
			}
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x002D4610 File Offset: 0x002D2810
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
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (this.m_isSwitchingOfflineOnline)
				{
					this.m_isSwitchingOfflineOnline = false;
					this.m_arenaUIController.SwitchOfflineOnline(this.m_arenaUIType);
				}
				else
				{
					bool canSwitchOnline = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_RealTimePVP);
					this.m_arenaUIController.Open(this.m_arenaUIType, canSwitchOnline);
				}
				if (this.m_arenaUIType == ArenaUIType.Offline)
				{
					this.AutoGetOfflineVictoryPointReward();
				}
				else if (this.m_arenaUIType == ArenaUIType.Online)
				{
					this.AutoGetOnlineWeekWinReward();
				}
				this.UpdateBattlePower();
			}
			this.UpdatePlayerInfo();
			if (this.m_arenaUIType == ArenaUIType.Online)
			{
				this.UpdateOnlineArena();
			}
			else if (this.m_arenaUIType == ArenaUIType.Offline)
			{
				this.UpdateOfflineArena();
			}
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x002D472C File Offset: 0x002D292C
		private void UpdatePlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdatePlayerInfo_hotfix != null)
			{
				this.m_UpdatePlayerInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_arenaUIController.SetPlayerName(projectLPlayerContext.GetPlayerName());
			this.m_arenaUIController.SetPlayerHeadIcon(projectLPlayerContext.GetPlayerHeadIcon());
			this.m_arenaUIController.SetPlayerLevel(projectLPlayerContext.GetPlayerLevel());
			this.m_arenaUIController.SetArenaHonor(projectLPlayerContext.GetArenaHonour());
			this.m_arenaUIController.SetArenaTicket(projectLPlayerContext.GetArenaTicketCount(), configDataLoader.ConfigableConstId_ArenaGivenTicketMaxNums);
			this.m_playerResourceUIController.UpdatePlayerResource();
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x002D4814 File Offset: 0x002D2A14
		private void UpdateBattlePower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattlePower_hotfix != null)
			{
				this.m_UpdateBattlePower_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<Hero> list = new List<Hero>(projectLPlayerContext.GetHeros());
			List<Hero> list2 = list;
			if (ArenaUITask.<>f__mg$cache0 == null)
			{
				ArenaUITask.<>f__mg$cache0 = new Comparison<Hero>(ArenaUITask.CompareHeroBattlePower);
			}
			list2.Sort(ArenaUITask.<>f__mg$cache0);
			int num = 0;
			int num2 = 0;
			while (num2 < list.Count && num2 < 5)
			{
				num += list[num2].BattlePower;
				num2++;
			}
			this.m_arenaUIController.SetBattlePower(num);
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x002D48F0 File Offset: 0x002D2AF0
		private static int CompareHeroBattlePower(Hero h1, Hero h2)
		{
			return h2.BattlePower - h1.BattlePower;
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x002D4900 File Offset: 0x002D2B00
		private void StartArenaBattleReportBasicDataGetNetTask(ArenaUIType arenaUIType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleReportBasicDataGetNetTaskArenaUIType_hotfix != null)
			{
				this.m_StartArenaBattleReportBasicDataGetNetTaskArenaUIType_hotfix.call(new object[]
				{
					this,
					arenaUIType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaUIType arenaUIType = arenaUIType2;
			ArenaUITask $this = this;
			if (arenaUIType == ArenaUIType.Offline)
			{
				ArenaBattleReportBasicDataGetNetTask arenaBattleReportBasicDataGetNetTask = new ArenaBattleReportBasicDataGetNetTask();
				arenaBattleReportBasicDataGetNetTask.EventOnStop += delegate(Task task)
				{
					ArenaBattleReportBasicDataGetNetTask arenaBattleReportBasicDataGetNetTask2 = task as ArenaBattleReportBasicDataGetNetTask;
					if (arenaBattleReportBasicDataGetNetTask2.Result == 0)
					{
						$this.m_arenaUIType = arenaUIType;
						$this.m_isOpeningUI = ($this.m_isSwitchingOfflineOnline = true);
						$this.StartUpdatePipeLine(null, false, false, true);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(arenaBattleReportBasicDataGetNetTask2.Result, 2f, null, true);
					}
				};
				arenaBattleReportBasicDataGetNetTask.Start(null);
			}
			else if (arenaUIType == ArenaUIType.Online)
			{
				this.m_arenaUIType = arenaUIType;
				this.m_isOpeningUI = (this.m_isSwitchingOfflineOnline = true);
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x002D49E8 File Offset: 0x002D2BE8
		private void PlayerResourceUIController_OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerResourceUIController_OnAddCrystal_hotfix != null)
			{
				this.m_PlayerResourceUIController_OnAddCrystal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x002D4A60 File Offset: 0x002D2C60
		private void ArenaUIController_OnDefend()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnDefend_hotfix != null)
			{
				this.m_ArenaUIController_OnDefend_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(ArenaDefendUITask).Name, null);
				this.m_arenaDefendUITask = (UIManager.Instance.StartUITask(intent, true, false, new Action(this.ArenaDefendUITask_OnLoadAllResCompleted)) as ArenaDefendUITask);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x002D4AE4 File Offset: 0x002D2CE4
		private void ArenaDefendUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ArenaDefendUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ArenaDefendUITask));
			if (uitaskBase != null)
			{
				this.m_isNeedCheckOnline = false;
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x002D4B78 File Offset: 0x002D2D78
		private void ArenaUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnReturn_hotfix != null)
			{
				this.m_ArenaUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_canFlushOfflineTopRankPlayers = true;
				this.m_canFlushOnlineGlobalTopRankPlayers = true;
				this.m_canFlushOnlineLocalTopRankPlayers = true;
				this.m_offlinePanelType = OfflineArenaPanelType.Clash;
				this.m_onlinePanelType = OnlineArenaPanelType.Clash;
				this.m_isNeedCheckOnline = false;
				base.Pause();
				UIManager.Instance.ReturnUITaskWithTaskName(typeof(WorldUITask).Name);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x002D4BFC File Offset: 0x002D2DFC
		private void ArenaUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnShowHelp_hotfix != null)
			{
				this.m_ArenaUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaUIType == ArenaUIType.Online)
			{
				CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_RealtimeArena);
			}
			else if (this.m_arenaUIType == ArenaUIType.Offline)
			{
				CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Arena);
			}
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x002D4C90 File Offset: 0x002D2E90
		private void ArenaUIController_OnShowBuyArenaTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnShowBuyArenaTicket_hotfix != null)
			{
				this.m_ArenaUIController_OnShowBuyArenaTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = configDataLoader.GetAllConfigDataBuyArenaTicketInfo().Count<KeyValuePair<int, ConfigDataBuyArenaTicketInfo>>();
			ConfigDataBuyArenaTicketInfo configDataBuyArenaTicketInfo;
			if (projectLPlayerContext.GetBuyArenaTicketsNums() + 1 >= num)
			{
				configDataBuyArenaTicketInfo = configDataLoader.GetConfigDataBuyArenaTicketInfo(num);
			}
			else
			{
				configDataBuyArenaTicketInfo = configDataLoader.GetConfigDataBuyArenaTicketInfo(projectLPlayerContext.GetBuyArenaTicketsNums() + 1);
			}
			if (configDataBuyArenaTicketInfo != null)
			{
				int ticketCount = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_BuyArenaTicketCount);
				this.m_arenaUIController.ShowBuyArenaTicket(ticketCount, configDataBuyArenaTicketInfo.Price);
			}
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x002D4D6C File Offset: 0x002D2F6C
		private void ArenaUIController_OnBuyArenaTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnBuyArenaTicket_hotfix != null)
			{
				this.m_ArenaUIController_OnBuyArenaTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanBuyArenaTickets();
			if (num == 0)
			{
				ArenaTicketsBuyNetTask arenaTicketsBuyNetTask = new ArenaTicketsBuyNetTask();
				arenaTicketsBuyNetTask.EventOnStop += delegate(Task task)
				{
					ArenaTicketsBuyNetTask arenaTicketsBuyNetTask2 = task as ArenaTicketsBuyNetTask;
					if (arenaTicketsBuyNetTask2.Result == 0)
					{
						this.m_arenaUIController.HideBuyArenaTicket();
						this.UpdateView();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(arenaTicketsBuyNetTask2.Result, 2f, null, true);
					}
				};
				arenaTicketsBuyNetTask.Start(null);
			}
			else if (num == -401)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
				{
					if (dialogResult == DialogBoxResult.Ok)
					{
						StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
					}
				}, (StringTableId)0, (StringTableId)0);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x002D4E50 File Offset: 0x002D3050
		private void ArenaUIController_OnSwitchOnlineOffline()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnSwitchOnlineOffline_hotfix != null)
			{
				this.m_ArenaUIController_OnSwitchOnlineOffline_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_arenaUIType == ArenaUIType.Online)
			{
				if (projectLPlayerContext.IsArenaInSettleTime())
				{
					CommonUIController.Instance.ShowErrorMessage(-2017, 2f, null, true);
					return;
				}
				if (projectLPlayerContext.IsNeedGetArenaPlayerInfo())
				{
					ArenaPlayerInfoGetNetTask arenaPlayerInfoGetNetTask = new ArenaPlayerInfoGetNetTask();
					arenaPlayerInfoGetNetTask.EventOnStop += delegate(Task task)
					{
						ArenaPlayerInfoGetNetTask arenaPlayerInfoGetNetTask2 = task as ArenaPlayerInfoGetNetTask;
						if (arenaPlayerInfoGetNetTask2.Result == 0)
						{
							this.StartArenaBattleReportBasicDataGetNetTask(ArenaUIType.Offline);
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(arenaPlayerInfoGetNetTask2.Result, 2f, null, true);
						}
					};
					arenaPlayerInfoGetNetTask.Start(null);
					return;
				}
				this.m_arenaUIType = ArenaUIType.Offline;
			}
			else
			{
				if (projectLPlayerContext.IsNeedGetRealTimePVPPlayerInfo())
				{
					this.StartRealTimePVPGetInfoNetTask(delegate(int result)
					{
						if (result == 0)
						{
							this.StartArenaBattleReportBasicDataGetNetTask(ArenaUIType.Online);
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
						}
					});
					return;
				}
				this.m_arenaUIType = ArenaUIType.Online;
			}
			this.m_isOpeningUI = (this.m_isSwitchingOfflineOnline = true);
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x002D4F68 File Offset: 0x002D3168
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

		// Token: 0x0600A07B RID: 41083 RVA: 0x002D501C File Offset: 0x002D321C
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
			this.UpdateView();
			if (this.m_arenaUIType == ArenaUIType.Offline)
			{
				this.AutoGetOfflineVictoryPointReward();
			}
			else if (this.m_arenaUIType == ArenaUIType.Online)
			{
				this.AutoGetOnlineWeekWinReward();
			}
		}

		// Token: 0x140001DC RID: 476
		// (add) Token: 0x0600A07C RID: 41084 RVA: 0x002D50C4 File Offset: 0x002D32C4
		// (remove) Token: 0x0600A07D RID: 41085 RVA: 0x002D5160 File Offset: 0x002D3360
		public event Action<bool> EventOnStartArenaBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartArenaBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnStartArenaBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnStartArenaBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnStartArenaBattle, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartArenaBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartArenaBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnStartArenaBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnStartArenaBattle, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001DD RID: 477
		// (add) Token: 0x0600A07E RID: 41086 RVA: 0x002D51FC File Offset: 0x002D33FC
		// (remove) Token: 0x0600A07F RID: 41087 RVA: 0x002D5298 File Offset: 0x002D3498
		public event Action<ArenaBattleReport> EventOnStartArenaBattleReplay
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartArenaBattleReplayAction`1_hotfix != null)
				{
					this.m_add_EventOnStartArenaBattleReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaBattleReport> action = this.EventOnStartArenaBattleReplay;
				Action<ArenaBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaBattleReport>>(ref this.EventOnStartArenaBattleReplay, (Action<ArenaBattleReport>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartArenaBattleReplayAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartArenaBattleReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaBattleReport> action = this.EventOnStartArenaBattleReplay;
				Action<ArenaBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaBattleReport>>(ref this.EventOnStartArenaBattleReplay, (Action<ArenaBattleReport>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001DE RID: 478
		// (add) Token: 0x0600A080 RID: 41088 RVA: 0x002D5334 File Offset: 0x002D3534
		// (remove) Token: 0x0600A081 RID: 41089 RVA: 0x002D53D0 File Offset: 0x002D35D0
		public event Action<RealTimePVPBattleReport> EventOnStartRealTimePVPBattleReplay
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartRealTimePVPBattleReplayAction`1_hotfix != null)
				{
					this.m_add_EventOnStartRealTimePVPBattleReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RealTimePVPBattleReport> action = this.EventOnStartRealTimePVPBattleReplay;
				Action<RealTimePVPBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RealTimePVPBattleReport>>(ref this.EventOnStartRealTimePVPBattleReplay, (Action<RealTimePVPBattleReport>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartRealTimePVPBattleReplayAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartRealTimePVPBattleReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RealTimePVPBattleReport> action = this.EventOnStartRealTimePVPBattleReplay;
				Action<RealTimePVPBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RealTimePVPBattleReport>>(ref this.EventOnStartRealTimePVPBattleReplay, (Action<RealTimePVPBattleReport>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600A082 RID: 41090 RVA: 0x002D546C File Offset: 0x002D366C
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

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x002D54E0 File Offset: 0x002D36E0
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

		// Token: 0x0600A084 RID: 41092 RVA: 0x002D5554 File Offset: 0x002D3754
		private void CollectOfflineArenaAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectOfflineArenaAssets_hotfix != null)
			{
				this.m_CollectOfflineArenaAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (this.m_offlinePanelType == OfflineArenaPanelType.Clash)
			{
				this.m_arenaOpponents.Clear();
				this.m_arenaOpponents.AddRange(projectLPlayerContext.GetArenaOpponents());
				foreach (ArenaOpponent arenaOpponent in this.m_arenaOpponents)
				{
					this.CollectPlayerHeadAssets(arenaOpponent.HeadIcon);
				}
			}
			else if (this.m_offlinePanelType == OfflineArenaPanelType.BattleReport)
			{
				this.m_offlineArenaBattleReport.Clear();
				this.m_offlineArenaBattleReport.AddRange(projectLPlayerContext.GetAllArenaBattleReports());
				List<ArenaBattleReport> offlineArenaBattleReport = this.m_offlineArenaBattleReport;
				if (ArenaUITask.<>f__mg$cache1 == null)
				{
					ArenaUITask.<>f__mg$cache1 = new Comparison<ArenaBattleReport>(ArenaUITask.CompareArenaBattleReportsByCreateTime);
				}
				offlineArenaBattleReport.Sort(ArenaUITask.<>f__mg$cache1);
				foreach (ArenaBattleReport arenaBattleReport in this.m_offlineArenaBattleReport)
				{
					this.CollectPlayerHeadAssets(arenaBattleReport.OpponentHeadIcon);
				}
			}
			else if (this.m_offlinePanelType == OfflineArenaPanelType.Ranking)
			{
			}
			foreach (KeyValuePair<int, ConfigDataArenaLevelInfo> keyValuePair in configDataLoader.GetAllConfigDataArenaLevelInfo())
			{
				base.CollectSpriteAsset(keyValuePair.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataArenaVictoryPointsRewardInfo> keyValuePair2 in configDataLoader.GetAllConfigDataArenaVictoryPointsRewardInfo())
			{
				foreach (Goods goods in keyValuePair2.Value.Reward)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				}
			}
			foreach (KeyValuePair<int, ConfigDataArenaLevelInfo> keyValuePair3 in configDataLoader.GetAllConfigDataArenaLevelInfo())
			{
				ConfigDataMailInfo configDataMailInfo = configDataLoader.GetConfigDataMailInfo(keyValuePair3.Value.LevelRewardMailTemplateId);
				if (configDataMailInfo != null)
				{
					foreach (Goods goods2 in configDataMailInfo.Attachments)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
					}
				}
			}
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x002D58D0 File Offset: 0x002D3AD0
		private void UpdateOfflineArena()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOfflineArena_hotfix != null)
			{
				this.m_UpdateOfflineArena_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.IsArenaInSettleTime();
			this.m_arenaUIController.SetOfflineInSettleTime(flag);
			this.m_arenaUIController.ShowOfflinePanel(this.m_offlinePanelType);
			this.m_arenaUIController.SetOfflineArenaPointsAndLevel(projectLPlayerContext.GetPlayerArenaPoints(), projectLPlayerContext.GetPlayerArenaLevelId());
			this.m_arenaUIController.SetOfflineWeekWin(projectLPlayerContext.GetArenaThisWeekVictoryNums(), projectLPlayerContext.GetArenaThisWeekTotalBattleNums());
			int num = 0;
			foreach (KeyValuePair<int, ConfigDataArenaVictoryPointsRewardInfo> keyValuePair in configDataLoader.GetAllConfigDataArenaVictoryPointsRewardInfo())
			{
				int key = keyValuePair.Key;
				int idx = key - 1;
				this.m_arenaUIController.SetOfflineVictoryPointsRewardStatus(idx, keyValuePair.Value.VictoryPoints, projectLPlayerContext.GetArenaVictoryPointsRewardStatus(key));
				if (keyValuePair.Value.VictoryPoints > num)
				{
					num = keyValuePair.Value.VictoryPoints;
				}
			}
			this.m_arenaUIController.SetOfflineVictoryPointsRewardProgress(projectLPlayerContext.GetPlayerArenaVictoryPoints(), num);
			if (this.m_offlinePanelType == OfflineArenaPanelType.Clash)
			{
				if (!flag)
				{
					this.m_arenaUIController.SetOfflineArenaOpponents(this.m_arenaOpponents, false);
					this.UpdateOfflineArenaOpponentRefreshTime();
				}
			}
			else if (this.m_offlinePanelType == OfflineArenaPanelType.BattleReport)
			{
				this.m_arenaUIController.SetOfflineArenaBattleReports(this.m_offlineArenaBattleReport);
			}
			else if (this.m_offlinePanelType == OfflineArenaPanelType.Ranking)
			{
				this.m_arenaUIController.SetOfflineArenaRankings(projectLPlayerContext.GetPlayerArenaRank(), projectLPlayerContext.GetArenaTopRankPlayers());
			}
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x002D5AC4 File Offset: 0x002D3CC4
		private void UpdateOfflineArenaOpponentRefreshTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOfflineArenaOpponentRefreshTime_hotfix != null)
			{
				this.m_UpdateOfflineArenaOpponentRefreshTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan offlineArenaOpponentsRefreshTime = projectLPlayerContext.GetArenaOpponentNextFlushTime() - projectLPlayerContext.GetServerTime();
			if (offlineArenaOpponentsRefreshTime.Ticks < 0L)
			{
				offlineArenaOpponentsRefreshTime = TimeSpan.Zero;
			}
			this.m_arenaUIController.SetOfflineArenaOpponentsRefreshTime(offlineArenaOpponentsRefreshTime);
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x002D5B68 File Offset: 0x002D3D68
		private static int CompareArenaBattleReportsByCreateTime(ArenaBattleReport r0, ArenaBattleReport r1)
		{
			if (r0 == r1)
			{
				return 0;
			}
			if (r0.CreateTime != r1.CreateTime)
			{
				if (r0.CreateTime < r1.CreateTime)
				{
					return 1;
				}
				if (r0.CreateTime > r1.CreateTime)
				{
					return -1;
				}
			}
			return (int)(r1.InstanceId - r0.InstanceId);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x002D5BC4 File Offset: 0x002D3DC4
		private static int CompareRealTimePVPBattleReportsByCreateTime(RealTimePVPBattleReport r0, RealTimePVPBattleReport r1)
		{
			if (r0 == r1)
			{
				return 0;
			}
			if (r0.CreateTime != r1.CreateTime)
			{
				if (r0.CreateTime < r1.CreateTime)
				{
					return 1;
				}
				if (r0.CreateTime > r1.CreateTime)
				{
					return -1;
				}
			}
			return (int)(r1.InstanceId - r0.InstanceId);
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x002D5C30 File Offset: 0x002D3E30
		private static bool IsBattleReportAttackerGiveup(ArenaBattleReport battleReport)
		{
			return battleReport != null && battleReport.Commands.Count > 0 && battleReport.Commands[0].Type == BattleCommandType.Giveup;
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x002D5C64 File Offset: 0x002D3E64
		private void FlushOfflineTopRankPlayers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushOfflineTopRankPlayers_hotfix != null)
			{
				this.m_FlushOfflineTopRankPlayers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_canFlushOfflineTopRankPlayers)
			{
				this.m_canFlushOfflineTopRankPlayers = false;
				ArenaTopRankPlayersGetNetTask arenaTopRankPlayersGetNetTask = new ArenaTopRankPlayersGetNetTask();
				arenaTopRankPlayersGetNetTask.EventOnStop += delegate(Task task)
				{
					ArenaTopRankPlayersGetNetTask arenaTopRankPlayersGetNetTask2 = task as ArenaTopRankPlayersGetNetTask;
					if (arenaTopRankPlayersGetNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(arenaTopRankPlayersGetNetTask2.Result, 2f, null, true);
					}
					if (arenaTopRankPlayersGetNetTask2.Result != -99)
					{
						base.StartUpdatePipeLine(null, false, false, true);
					}
				};
				arenaTopRankPlayersGetNetTask.Start(null);
			}
			else
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x002D5D08 File Offset: 0x002D3F08
		private void AutoGetOfflineVictoryPointReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoGetOfflineVictoryPointReward_hotfix != null)
			{
				this.m_AutoGetOfflineVictoryPointReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (KeyValuePair<int, ConfigDataArenaVictoryPointsRewardInfo> keyValuePair in configDataLoader.GetAllConfigDataArenaVictoryPointsRewardInfo())
			{
				if (projectLPlayerContext.GetArenaVictoryPointsRewardStatus(keyValuePair.Key) == GainRewardStatus.CanGet)
				{
					this.ArenaUIController_OnGainOfflineVictoryPointsReward(keyValuePair.Key);
					break;
				}
			}
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x002D5DF4 File Offset: 0x002D3FF4
		private void ArenaUIController_OnShowOfflinePanel(OfflineArenaPanelType panelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnShowOfflinePanelOfflineArenaPanelType_hotfix != null)
			{
				this.m_ArenaUIController_OnShowOfflinePanelOfflineArenaPanelType_hotfix.call(new object[]
				{
					this,
					panelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlinePanelType = panelType;
			if (panelType == OfflineArenaPanelType.Clash)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (panelType == OfflineArenaPanelType.BattleReport)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (panelType == OfflineArenaPanelType.Ranking)
			{
				this.FlushOfflineTopRankPlayers();
			}
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x002D5EA8 File Offset: 0x002D40A8
		private void ArenaUIController_OnGainOfflineVictoryPointsReward(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnGainOfflineVictoryPointsRewardInt32_hotfix != null)
			{
				this.m_ArenaUIController_OnGainOfflineVictoryPointsRewardInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanGetArenaVictoryPointsReward(idx);
			if (num == 0)
			{
				ArenaVictoryPointsRewardGainNetTask arenaVictoryPointsRewardGainNetTask = new ArenaVictoryPointsRewardGainNetTask(idx);
				arenaVictoryPointsRewardGainNetTask.EventOnStop += delegate(Task task)
				{
					ArenaVictoryPointsRewardGainNetTask arenaVictoryPointsRewardGainNetTask2 = task as ArenaVictoryPointsRewardGainNetTask;
					if (arenaVictoryPointsRewardGainNetTask2.Result == 0)
					{
						ChestUITask chestUITask = ChestUITask.StartUITask(arenaVictoryPointsRewardGainNetTask2.Reward, false, false);
						if (this.m_chestUITask == null)
						{
							this.m_chestUITask = chestUITask;
							this.m_chestUITask.EventOnStop += this.ChestUITask_OnStop;
							this.m_chestUITask.EventOnClose += this.ChestUITask_OnClose;
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(arenaVictoryPointsRewardGainNetTask2.Result, 2f, null, true);
					}
				};
				arenaVictoryPointsRewardGainNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x002D5F8C File Offset: 0x002D418C
		private void ArenaUIController_OnShowOfflineArenaOpponent(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnShowOfflineArenaOpponentInt32_hotfix != null)
			{
				this.m_ArenaUIController_OnShowOfflineArenaOpponentInt32_hotfix.call(new object[]
				{
					this,
					idx2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int idx = idx2;
			ArenaUITask $this = this;
			if (this.m_arenaOpponents.Count >= idx)
			{
				ArenaOpponentViewNetTask arenaOpponentViewNetTask = new ArenaOpponentViewNetTask(idx);
				arenaOpponentViewNetTask.EventOnStop += delegate(Task task)
				{
					ArenaOpponentViewNetTask returnTask = task as ArenaOpponentViewNetTask;
					if (returnTask.Result == 0)
					{
						$this.m_curArenaOpponentIndex = idx;
						List<BattleHero> heros = new List<BattleHero>();
						foreach (ProBattleHero pbBattleHero in returnTask.Heros)
						{
							heros.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero));
						}
						$this.ClearAssetList();
						$this.CollectPlayerHeadAssets($this.m_arenaOpponents[idx].HeadIcon);
						$this.CollectHeroModelAssets(heros);
						$this.StartLoadCustomAssets(delegate
						{
							<ArenaUIController_OnShowOfflineArenaOpponent>c__AnonStorey.m_arenaUIController.ShowArenaOpponent(<ArenaUIController_OnShowOfflineArenaOpponent>c__AnonStorey.m_arenaOpponents[idx], heros, returnTask.BattlePower, false);
						});
					}
					else
					{
						$this.m_curArenaOpponentIndex = -1;
						CommonUIController.Instance.ShowErrorMessage(returnTask.Result, 2f, null, true);
					}
				};
				arenaOpponentViewNetTask.Start(null);
			}
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x002D604C File Offset: 0x002D424C
		private void ArenaUIController_OnAttackOfflineArenaOpponent(bool autoBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnAttackOfflineArenaOpponentBoolean_hotfix != null)
			{
				this.m_ArenaUIController_OnAttackOfflineArenaOpponentBoolean_hotfix.call(new object[]
				{
					this,
					autoBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curArenaOpponentIndex < 0)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackArenaOpponent();
			if (num == 0)
			{
				ArenaOpponentAttackNetTask arenaOpponentAttackNetTask = new ArenaOpponentAttackNetTask(autoBattle);
				arenaOpponentAttackNetTask.EventOnStop += delegate(Task task)
				{
					ArenaOpponentAttackNetTask arenaOpponentAttackNetTask2 = task as ArenaOpponentAttackNetTask;
					if (arenaOpponentAttackNetTask2.Result == 0)
					{
						if (this.EventOnStartArenaBattle != null)
						{
							this.EventOnStartArenaBattle(false);
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(arenaOpponentAttackNetTask2.Result, 2f, null, true);
					}
				};
				arenaOpponentAttackNetTask.Start(null);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x002D6118 File Offset: 0x002D4318
		private void ArenaUIController_OnShowRevengeOfflineArenaOpponent(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnShowRevengeOfflineArenaOpponentArenaBattleReport_hotfix != null)
			{
				this.m_ArenaUIController_OnShowRevengeOfflineArenaOpponentArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaBattleReport battleReport = battleReport2;
			ArenaUITask $this = this;
			ArenaRevengeOpponentGetNetTask arenaRevengeOpponentGetNetTask = new ArenaRevengeOpponentGetNetTask(battleReport.InstanceId);
			arenaRevengeOpponentGetNetTask.EventOnStop += delegate(Task task)
			{
				ArenaRevengeOpponentGetNetTask returnTask = task as ArenaRevengeOpponentGetNetTask;
				if (returnTask.Result == 0)
				{
					$this.m_curArenaBattleReport = battleReport;
					List<BattleHero> heros = new List<BattleHero>();
					foreach (ProBattleHero pbBattleHero in returnTask.Heros)
					{
						heros.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero));
					}
					ArenaOpponent opponent = ArenaOpponent.PBArenaOpponentToArenaOpponent(returnTask.ArenaOpponent);
					$this.ClearAssetList();
					$this.CollectPlayerHeadAssets(returnTask.ArenaOpponent.HeadIcon);
					$this.CollectHeroModelAssets(heros);
					$this.StartLoadCustomAssets(delegate
					{
						<ArenaUIController_OnShowRevengeOfflineArenaOpponent>c__AnonStorey.m_arenaUIController.ShowArenaOpponent(opponent, heros, returnTask.BattlePower, true);
					});
				}
				else
				{
					$this.m_curArenaBattleReport = null;
					CommonUIController.Instance.ShowErrorMessage(returnTask.Result, 2f, null, true);
				}
			};
			arenaRevengeOpponentGetNetTask.Start(null);
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x002D61C8 File Offset: 0x002D43C8
		private void ArenaUIController_OnRevengeOfflineArenaOpponent(bool autoBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnRevengeOfflineArenaOpponentBoolean_hotfix != null)
			{
				this.m_ArenaUIController_OnRevengeOfflineArenaOpponentBoolean_hotfix.call(new object[]
				{
					this,
					autoBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curArenaBattleReport == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanRevengeArenaOpponent(this.m_curArenaBattleReport.InstanceId);
			if (num == 0)
			{
				ArenaOpponentRevengeNetTask arenaOpponentRevengeNetTask = new ArenaOpponentRevengeNetTask(this.m_curArenaBattleReport.InstanceId, autoBattle);
				arenaOpponentRevengeNetTask.EventOnStop += delegate(Task task)
				{
					ArenaOpponentRevengeNetTask arenaOpponentRevengeNetTask2 = task as ArenaOpponentRevengeNetTask;
					if (arenaOpponentRevengeNetTask2.Result == 0)
					{
						if (this.EventOnStartArenaBattle != null)
						{
							this.EventOnStartArenaBattle(true);
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(arenaOpponentRevengeNetTask2.Result, 2f, null, true);
					}
				};
				arenaOpponentRevengeNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x002D62CC File Offset: 0x002D44CC
		private void ArenaUIController_OnOfflineBattleReportReplay(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnOfflineBattleReportReplayArenaBattleReport_hotfix != null)
			{
				this.m_ArenaUIController_OnOfflineBattleReportReplayArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaBattleReport battleReport = battleReport2;
			ArenaUITask $this = this;
			if (battleReport.BattleType == BattleType.None)
			{
				ArenaBattleReportPlayBackDataGetNetTask arenaBattleReportPlayBackDataGetNetTask = new ArenaBattleReportPlayBackDataGetNetTask(battleReport.InstanceId);
				arenaBattleReportPlayBackDataGetNetTask.EventOnStop += delegate(Task task)
				{
					ArenaBattleReportPlayBackDataGetNetTask arenaBattleReportPlayBackDataGetNetTask2 = task as ArenaBattleReportPlayBackDataGetNetTask;
					if (arenaBattleReportPlayBackDataGetNetTask2.Result == 0)
					{
						if (ArenaUITask.IsBattleReportAttackerGiveup(battleReport))
						{
							CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_ArenaAttackerGiveup, 2f, null, true);
						}
						else if ($this.EventOnStartArenaBattleReplay != null)
						{
							$this.EventOnStartArenaBattleReplay(battleReport);
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(arenaBattleReportPlayBackDataGetNetTask2.Result, 2f, null, true);
					}
				};
				arenaBattleReportPlayBackDataGetNetTask.Start(null);
			}
			else if (ArenaUITask.IsBattleReportAttackerGiveup(battleReport))
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_ArenaAttackerGiveup, 2f, null, true);
			}
			else if (this.EventOnStartArenaBattleReplay != null)
			{
				this.EventOnStartArenaBattleReplay(battleReport);
			}
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x002D63D8 File Offset: 0x002D45D8
		private void PlayerContext_OnArenaFlushOpponentsNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnArenaFlushOpponentsNtf_hotfix != null)
			{
				this.m_PlayerContext_OnArenaFlushOpponentsNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_offlinePanelType == OfflineArenaPanelType.Clash)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x002D6450 File Offset: 0x002D4650
		private void CollectOnlineArenaAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectOnlineArenaAssets_hotfix != null)
			{
				this.m_CollectOnlineArenaAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_onlinePanelType != OnlineArenaPanelType.Clash)
			{
				if (this.m_onlinePanelType == OnlineArenaPanelType.BattleReport)
				{
					this.m_onlineArenaBattleReport.Clear();
					this.m_onlineArenaBattleReport.AddRange(projectLPlayerContext.GetRealTimePVPBattleReports());
					List<RealTimePVPBattleReport> onlineArenaBattleReport = this.m_onlineArenaBattleReport;
					if (ArenaUITask.<>f__mg$cache2 == null)
					{
						ArenaUITask.<>f__mg$cache2 = new Comparison<RealTimePVPBattleReport>(ArenaUITask.CompareRealTimePVPBattleReportsByCreateTime);
					}
					onlineArenaBattleReport.Sort(ArenaUITask.<>f__mg$cache2);
					foreach (RealTimePVPBattleReport realTimePVPBattleReport in this.m_onlineArenaBattleReport)
					{
						foreach (RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData in realTimePVPBattleReport.PlayerDatas)
						{
							if (!projectLPlayerContext.IsMe(realTimePVPBattleReportPlayerData.UserId))
							{
								this.CollectPlayerHeadAssets(realTimePVPBattleReportPlayerData.HeadIcon);
							}
						}
					}
				}
				else if (this.m_onlinePanelType == OnlineArenaPanelType.Dan)
				{
					foreach (KeyValuePair<int, ConfigDataRealTimePVPDanRewardInfo> keyValuePair in configDataLoader.GetAllConfigDataRealTimePVPDanRewardInfo())
					{
						ConfigDataMailInfo configDataMailInfo = configDataLoader.GetConfigDataMailInfo(keyValuePair.Value.DanRewardMailTemplateId);
						if (configDataMailInfo != null)
						{
							foreach (Goods goods in configDataMailInfo.Attachments)
							{
								base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
							}
						}
					}
				}
				else if (this.m_onlinePanelType == OnlineArenaPanelType.LocalRanking || this.m_onlinePanelType == OnlineArenaPanelType.GlobalRanking)
				{
				}
			}
			foreach (KeyValuePair<int, ConfigDataRealTimePVPDanInfo> keyValuePair2 in configDataLoader.GetAllConfigDataRealTimePVPDanInfo())
			{
				base.CollectSpriteAsset(keyValuePair2.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataRealTimePVPWinsBonusInfo> keyValuePair3 in configDataLoader.GetAllConfigDataRealTimePVPWinsBonusInfo())
			{
				foreach (Goods goods2 in keyValuePair3.Value.Bonus)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
				}
			}
			foreach (KeyValuePair<int, ConfigDataRealTimePVPRankingRewardInfo> keyValuePair4 in configDataLoader.GetAllConfigDataRealTimePVPRankingRewardInfo())
			{
				ConfigDataMailInfo configDataMailInfo2 = configDataLoader.GetConfigDataMailInfo(keyValuePair4.Value.RankingRewardMailTemplateId);
				if (configDataMailInfo2 != null)
				{
					foreach (Goods goods3 in configDataMailInfo2.Attachments)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods3.GoodsType, goods3.Id));
					}
				}
			}
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x002D6878 File Offset: 0x002D4A78
		private void UpdateOnlineArena()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOnlineArena_hotfix != null)
			{
				this.m_UpdateOnlineArena_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int playerRealTimePVPDan = projectLPlayerContext.GetPlayerRealTimePVPDan();
			bool flag = projectLPlayerContext.IsRealTimePVPPromotion();
			RewardPlayerStatus beforeRewardPlayerStatus = projectLPlayerContext.GetBeforeRewardPlayerStatus();
			if (beforeRewardPlayerStatus.RealTimePVPDan != 0)
			{
				if (flag && beforeRewardPlayerStatus.RealtTimePVPBattleMode == BattleMode.Default && projectLPlayerContext.GetRealTimePVPPromotionBattleReports().Count <= 0)
				{
					this.m_arenaUIController.ShowPromoteBattle(playerRealTimePVPDan);
				}
				if (playerRealTimePVPDan > beforeRewardPlayerStatus.RealTimePVPDan && beforeRewardPlayerStatus.RealTimePVPIsPromotion)
				{
					this.m_arenaUIController.ShowPromoteSucceed(playerRealTimePVPDan);
				}
				beforeRewardPlayerStatus.RealTimePVPDan = 0;
			}
			this.m_arenaUIController.ShowGlobalRankingToggle(configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVP_ClientGlobalRankingEnable) != 0);
			this.m_arenaUIController.ShowOnlinePanel(this.m_onlinePanelType);
			this.m_arenaUIController.SetOnlineScoreAndDan(projectLPlayerContext.GetPlayerRealTimePVPScore(), playerRealTimePVPDan);
			int num = 0;
			foreach (KeyValuePair<int, ConfigDataRealTimePVPWinsBonusInfo> keyValuePair in configDataLoader.GetAllConfigDataRealTimePVPWinsBonusInfo())
			{
				int key = keyValuePair.Key;
				int idx = key - 1;
				this.m_arenaUIController.SetOnlineWeekWinRewardStatus(idx, keyValuePair.Value.Wins, projectLPlayerContext.GetRealTimePVPWinsBonusStatus(key));
				if (keyValuePair.Value.Wins > num)
				{
					num = keyValuePair.Value.Wins;
				}
			}
			RealTimePVPMatchStats realTimePVPLadderMatchStats = projectLPlayerContext.GetRealTimePVPLadderMatchStats();
			RealTimePVPMatchStats realTimePVPFriendlyMatchStats = projectLPlayerContext.GetRealTimePVPFriendlyMatchStats();
			this.m_arenaUIController.SetOnlineWeekWinRewardProgress(realTimePVPLadderMatchStats.Wins + realTimePVPFriendlyMatchStats.Wins, num);
			if (this.m_onlinePanelType == OnlineArenaPanelType.Clash)
			{
				this.m_arenaUIController.SetLadderOpenTime(configDataLoader.UtilityGetConfigableConstString(ConfigableConstId.ConfigableConstId_RealTimePVPAvailableTime));
				this.m_arenaUIController.SetLadderWeekWin(realTimePVPLadderMatchStats.Wins, realTimePVPLadderMatchStats.Matches);
				this.UpdateLadderMode();
				if (flag)
				{
					this.m_onlineArenaPromotionBattleReport.Clear();
					this.m_onlineArenaPromotionBattleReport.AddRange(projectLPlayerContext.GetRealTimePVPPromotionBattleReports());
					List<RealTimePVPBattleReport> onlineArenaPromotionBattleReport = this.m_onlineArenaPromotionBattleReport;
					if (ArenaUITask.<>f__mg$cache3 == null)
					{
						ArenaUITask.<>f__mg$cache3 = new Comparison<RealTimePVPBattleReport>(ArenaUITask.CompareRealTimePVPBattleReportsByCreateTime);
					}
					onlineArenaPromotionBattleReport.Sort(ArenaUITask.<>f__mg$cache3);
					this.m_onlineArenaPromotionBattleReport.Reverse();
					this.m_arenaUIController.SetPromoteBattleStatus(playerRealTimePVPDan, this.m_onlineArenaPromotionBattleReport);
				}
			}
			else if (this.m_onlinePanelType == OnlineArenaPanelType.BattleReport)
			{
				this.m_arenaUIController.SetOnlineArenaBattleReports(this.m_onlineArenaBattleReport);
			}
			else if (this.m_onlinePanelType == OnlineArenaPanelType.Dan)
			{
				if (this.m_realTimePVPDans.Count == 0)
				{
					foreach (KeyValuePair<int, ConfigDataRealTimePVPDanInfo> keyValuePair2 in configDataLoader.GetAllConfigDataRealTimePVPDanInfo())
					{
						this.m_realTimePVPDans.Add(keyValuePair2.Value);
					}
				}
				this.m_arenaUIController.SetOnlineDans(this.m_realTimePVPDans, projectLPlayerContext.GetPlayerRealTimePVPDan());
			}
			else if (this.m_onlinePanelType == OnlineArenaPanelType.LocalRanking)
			{
				this.m_arenaUIController.SetOnlineArenaRankings(projectLPlayerContext.GetPlayerRealTimePVPRank(false), projectLPlayerContext.GetRealTimePVPLeaderboardPlayerInfos(false), projectLPlayerContext.GetRealTimePVPLeaderboardUserSummarys(false), false);
			}
			else if (this.m_onlinePanelType == OnlineArenaPanelType.GlobalRanking)
			{
				this.m_arenaUIController.SetOnlineArenaRankings(projectLPlayerContext.GetPlayerRealTimePVPRank(true), projectLPlayerContext.GetRealTimePVPLeaderboardPlayerInfos(true), projectLPlayerContext.GetRealTimePVPLeaderboardUserSummarys(true), true);
			}
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x002D6C40 File Offset: 0x002D4E40
		private void UpdateOnlineMatchingTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOnlineMatchingTime_hotfix != null)
			{
				this.m_UpdateOnlineMatchingTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_matchingUIBeginTime != DateTime.MinValue)
			{
				DateTime now = DateTime.Now;
				TimeSpan matchingNowTime = now - this.m_matchingUIBeginTime;
				this.m_arenaUIController.SetMatchingNowTime(matchingNowTime);
				if (this.m_matchingReqSendTime != DateTime.MinValue && now >= this.m_matchingReqSendTime)
				{
					this.StartRealTimePVPWaitingForOpponentNetTask(this.m_matchingBattleMode);
					this.m_matchingReqSendTime = DateTime.MinValue;
				}
			}
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x002D6D14 File Offset: 0x002D4F14
		private void UpdateLadderMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateLadderMode_hotfix != null)
			{
				this.m_UpdateLadderMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool isOpened = projectLPlayerContext.IsRealTimePVPArenaAvailable(BattleMode.Default) == 0;
			bool isPromote = projectLPlayerContext.IsRealTimePVPPromotion();
			this.m_arenaUIController.SetLadderMode(isOpened, isPromote);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x002D6DA4 File Offset: 0x002D4FA4
		private static bool IsBattleReportPlayerGiveup(RealTimePVPBattleReport battleReport, out int playerIndex)
		{
			playerIndex = 0;
			if (battleReport != null && battleReport.Commands.Count > 0 && battleReport.Commands[0].Type == BattleCommandType.Giveup)
			{
				playerIndex = battleReport.Commands[0].SkillIndex;
				return true;
			}
			return false;
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x002D6DF8 File Offset: 0x002D4FF8
		private void FlushOnlineTopRankPlayers(bool isGlobal)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushOnlineTopRankPlayersBoolean_hotfix != null)
			{
				this.m_FlushOnlineTopRankPlayersBoolean_hotfix.call(new object[]
				{
					this,
					isGlobal2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isGlobal = isGlobal2;
			ArenaUITask $this = this;
			if (isGlobal)
			{
				if (!this.m_canFlushOnlineGlobalTopRankPlayers)
				{
					base.StartUpdatePipeLine(null, false, false, true);
					return;
				}
				this.m_canFlushOnlineGlobalTopRankPlayers = false;
			}
			else
			{
				if (!this.m_canFlushOnlineLocalTopRankPlayers)
				{
					base.StartUpdatePipeLine(null, false, false, true);
					return;
				}
				this.m_canFlushOnlineLocalTopRankPlayers = false;
			}
			this.StartRealTimePVPGetInfoNetTask(delegate(int result)
			{
				if (result == 0)
				{
					$this.StartRealTimePVPGetTopPlayersNetTask(isGlobal);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
			});
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x002D6EE4 File Offset: 0x002D50E4
		private void StartRealTimePVPGetInfoNetTask(Action<int> onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRealTimePVPGetInfoNetTaskAction`1_hotfix != null)
			{
				this.m_StartRealTimePVPGetInfoNetTaskAction`1_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<int> onEnd = onEnd2;
			RealTimePVPGetInfoNetTask realTimePVPGetInfoNetTask = new RealTimePVPGetInfoNetTask();
			realTimePVPGetInfoNetTask.EventOnStop += delegate(Task task)
			{
				RealTimePVPGetInfoNetTask realTimePVPGetInfoNetTask2 = task as RealTimePVPGetInfoNetTask;
				if (onEnd != null)
				{
					onEnd(realTimePVPGetInfoNetTask2.Result);
				}
			};
			realTimePVPGetInfoNetTask.Start(null);
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x002D6F84 File Offset: 0x002D5184
		private void StartRealTimePVPGetTopPlayersNetTask(bool isGlobal)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRealTimePVPGetTopPlayersNetTaskBoolean_hotfix != null)
			{
				this.m_StartRealTimePVPGetTopPlayersNetTaskBoolean_hotfix.call(new object[]
				{
					this,
					isGlobal
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int topN = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPTopRankPlayerNums);
			RealTimePVPGetTopPlayersNetTask realTimePVPGetTopPlayersNetTask = new RealTimePVPGetTopPlayersNetTask(topN, isGlobal);
			realTimePVPGetTopPlayersNetTask.EventOnStop += delegate(Task task)
			{
				RealTimePVPGetTopPlayersNetTask realTimePVPGetTopPlayersNetTask2 = task as RealTimePVPGetTopPlayersNetTask;
				if (realTimePVPGetTopPlayersNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(realTimePVPGetTopPlayersNetTask2.Result, 2f, null, true);
				}
				if (realTimePVPGetTopPlayersNetTask2.Result != -99)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
			};
			realTimePVPGetTopPlayersNetTask.Start(null);
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x002D7034 File Offset: 0x002D5234
		private void AutoGetOnlineWeekWinReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoGetOnlineWeekWinReward_hotfix != null)
			{
				this.m_AutoGetOnlineWeekWinReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (KeyValuePair<int, ConfigDataRealTimePVPWinsBonusInfo> keyValuePair in configDataLoader.GetAllConfigDataRealTimePVPWinsBonusInfo())
			{
				if (projectLPlayerContext.GetRealTimePVPWinsBonusStatus(keyValuePair.Key) == GainRewardStatus.CanGet)
				{
					this.ArenaUIController_OnGainOnlineWeekWinReward(keyValuePair.Key);
					break;
				}
			}
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x002D7120 File Offset: 0x002D5320
		private void StartRealTimePVPWaitingForOpponentNetTask(BattleMode mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRealTimePVPWaitingForOpponentNetTaskBattleMode_hotfix != null)
			{
				this.m_StartRealTimePVPWaitingForOpponentNetTaskBattleMode_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RealTimePVPWaitingForOpponentNetTask realTimePVPWaitingForOpponentNetTask = new RealTimePVPWaitingForOpponentNetTask(mode);
			realTimePVPWaitingForOpponentNetTask.EventOnStop += delegate(Task task)
			{
				RealTimePVPWaitingForOpponentNetTask realTimePVPWaitingForOpponentNetTask2 = task as RealTimePVPWaitingForOpponentNetTask;
				if (realTimePVPWaitingForOpponentNetTask2.Result == 0)
				{
					this.m_arenaUIController.SetMatchingPredictTime(TimeSpan.FromMilliseconds((double)realTimePVPWaitingForOpponentNetTask2.ExpectedWaitingTime));
					this.m_isNeedCheckOnline = true;
				}
				else
				{
					this.m_matchingUIBeginTime = (this.m_matchingReqSendTime = DateTime.MinValue);
					this.m_arenaUIController.HideMatchingNow();
					CommonUIController.Instance.ShowErrorMessage(realTimePVPWaitingForOpponentNetTask2.Result, 2f, null, true);
				}
			};
			realTimePVPWaitingForOpponentNetTask.Start(null);
		}

		// Token: 0x0600A09E RID: 41118 RVA: 0x002D71B4 File Offset: 0x002D53B4
		private void StartMatchiing(BattleMode mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartMatchiingBattleMode_hotfix != null)
			{
				this.m_StartMatchiingBattleMode_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_matchingBattleMode = mode;
			this.m_arenaUIController.ShowMatchingNow();
			this.m_arenaUIController.SetMatchingNowTime(TimeSpan.Zero);
			this.m_arenaUIController.SetMatchingPredictTime(TimeSpan.MinValue);
			this.m_matchingUIBeginTime = (this.m_matchingReqSendTime = DateTime.Now);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsRealTimePVPWillMatchBot(mode))
			{
				float num = (float)UnityEngine.Random.Range(5, 10);
				this.m_matchingReqSendTime += TimeSpan.FromSeconds((double)num);
			}
		}

		// Token: 0x0600A09F RID: 41119 RVA: 0x002D72A8 File Offset: 0x002D54A8
		private void ArenaUIController_OnShowOnlinePanel(OnlineArenaPanelType panelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnShowOnlinePanelOnlineArenaPanelType_hotfix != null)
			{
				this.m_ArenaUIController_OnShowOnlinePanelOnlineArenaPanelType_hotfix.call(new object[]
				{
					this,
					panelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlinePanelType = panelType;
			if (panelType == OnlineArenaPanelType.Clash)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (panelType == OnlineArenaPanelType.BattleReport)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (panelType == OnlineArenaPanelType.Dan)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (panelType == OnlineArenaPanelType.LocalRanking)
			{
				this.FlushOnlineTopRankPlayers(false);
			}
			else if (panelType == OnlineArenaPanelType.GlobalRanking)
			{
				this.FlushOnlineTopRankPlayers(true);
			}
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x002D7384 File Offset: 0x002D5584
		private void ArenaUIController_OnGainOnlineWeekWinReward(int bonusId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnGainOnlineWeekWinRewardInt32_hotfix != null)
			{
				this.m_ArenaUIController_OnGainOnlineWeekWinRewardInt32_hotfix.call(new object[]
				{
					this,
					bonusId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CheckRealTimePVPAcquireWinsBonus(bonusId);
			if (num == 0)
			{
				RealTimePVPAcquireWinsBonusNetTask realTimePVPAcquireWinsBonusNetTask = new RealTimePVPAcquireWinsBonusNetTask(bonusId);
				realTimePVPAcquireWinsBonusNetTask.EventOnStop += delegate(Task task)
				{
					RealTimePVPAcquireWinsBonusNetTask realTimePVPAcquireWinsBonusNetTask2 = task as RealTimePVPAcquireWinsBonusNetTask;
					if (realTimePVPAcquireWinsBonusNetTask2.Result == 0)
					{
						ChestUITask chestUITask = ChestUITask.StartUITask(realTimePVPAcquireWinsBonusNetTask2.Reward, false, false);
						if (this.m_chestUITask == null)
						{
							this.m_chestUITask = chestUITask;
							this.m_chestUITask.EventOnStop += this.ChestUITask_OnStop;
							this.m_chestUITask.EventOnClose += this.ChestUITask_OnClose;
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(realTimePVPAcquireWinsBonusNetTask2.Result, 2f, null, true);
					}
				};
				realTimePVPAcquireWinsBonusNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x002D7468 File Offset: 0x002D5668
		private void ArenaUIController_OnOnlineBattleReportReplay(RealTimePVPBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnOnlineBattleReportReplayRealTimePVPBattleReport_hotfix != null)
			{
				this.m_ArenaUIController_OnOnlineBattleReportReplayRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num;
			if (ArenaUITask.IsBattleReportPlayerGiveup(battleReport, out num))
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_RealTimePVPPlayerGiveup);
				string name = battleReport.PlayerDatas[num].Name;
				CommonUIController.Instance.ShowMessage(string.Format(format, name), 2f, null, true);
			}
			else if (this.EventOnStartRealTimePVPBattleReplay != null)
			{
				this.EventOnStartRealTimePVPBattleReplay(battleReport);
			}
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x002D7544 File Offset: 0x002D5744
		private void ArenaUIController_OnLadderChallenge()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnLadderChallenge_hotfix != null)
			{
				this.m_ArenaUIController_OnLadderChallenge_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartMatchiing(BattleMode.Default);
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x002D75AC File Offset: 0x002D57AC
		private void ArenaUIController_OnCasualChallenge()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnCasualChallenge_hotfix != null)
			{
				this.m_ArenaUIController_OnCasualChallenge_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartMatchiing(BattleMode.Friendly);
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x002D7614 File Offset: 0x002D5814
		private void ArenaUIController_OnMatchingCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUIController_OnMatchingCancel_hotfix != null)
			{
				this.m_ArenaUIController_OnMatchingCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaUIController.IsMatchingNowPredictTimeActive())
			{
				RealTimePVPCancelWaitingForOpponentNetTask realTimePVPCancelWaitingForOpponentNetTask = new RealTimePVPCancelWaitingForOpponentNetTask();
				realTimePVPCancelWaitingForOpponentNetTask.EventOnStop += delegate(Task task)
				{
					RealTimePVPCancelWaitingForOpponentNetTask realTimePVPCancelWaitingForOpponentNetTask2 = task as RealTimePVPCancelWaitingForOpponentNetTask;
					if (realTimePVPCancelWaitingForOpponentNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(realTimePVPCancelWaitingForOpponentNetTask2.Result, 2f, null, true);
					}
					this.m_arenaUIController.HideMatchingNow();
					this.m_matchingUIBeginTime = (this.m_matchingReqSendTime = DateTime.MinValue);
				};
				realTimePVPCancelWaitingForOpponentNetTask.Start(null);
			}
			else
			{
				this.m_arenaUIController.HideMatchingNow();
				this.m_matchingUIBeginTime = (this.m_matchingReqSendTime = DateTime.MinValue);
			}
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x002D76C8 File Offset: 0x002D58C8
		private void PlayerContext_OnRealTimePVPMatchupNtf(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnRealTimePVPMatchupNtfInt32_hotfix != null)
			{
				this.m_PlayerContext_OnRealTimePVPMatchupNtfInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result != 0)
			{
				this.m_arenaUIController.ShowMatchingFailed();
				this.m_arenaUIController.HideMatchingNow();
				this.m_matchingUIBeginTime = (this.m_matchingReqSendTime = DateTime.MinValue);
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x002D7770 File Offset: 0x002D5970
		// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x002D7790 File Offset: 0x002D5990
		[DoNotToLua]
		public new ArenaUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x002D779C File Offset: 0x002D599C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x002D77A8 File Offset: 0x002D59A8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x002D77B0 File Offset: 0x002D59B0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x002D77B8 File Offset: 0x002D59B8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x002D77C4 File Offset: 0x002D59C4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x002D77D0 File Offset: 0x002D59D0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x002D77DC File Offset: 0x002D59DC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x002D77E4 File Offset: 0x002D59E4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x002D77EC File Offset: 0x002D59EC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x002D77F4 File Offset: 0x002D59F4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x002D77FC File Offset: 0x002D59FC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x002D7804 File Offset: 0x002D5A04
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x002D780C File Offset: 0x002D5A0C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x002D7814 File Offset: 0x002D5A14
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x002D7820 File Offset: 0x002D5A20
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x002D782C File Offset: 0x002D5A2C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x002D7838 File Offset: 0x002D5A38
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x002D7844 File Offset: 0x002D5A44
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x002D784C File Offset: 0x002D5A4C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x002D7854 File Offset: 0x002D5A54
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x002D785C File Offset: 0x002D5A5C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x002D7864 File Offset: 0x002D5A64
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x002D786C File Offset: 0x002D5A6C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x002D7874 File Offset: 0x002D5A74
		private void __callDele_EventOnStartArenaBattle(bool obj)
		{
			Action<bool> eventOnStartArenaBattle = this.EventOnStartArenaBattle;
			if (eventOnStartArenaBattle != null)
			{
				eventOnStartArenaBattle(obj);
			}
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x002D7898 File Offset: 0x002D5A98
		private void __clearDele_EventOnStartArenaBattle(bool obj)
		{
			this.EventOnStartArenaBattle = null;
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x002D78A4 File Offset: 0x002D5AA4
		private void __callDele_EventOnStartArenaBattleReplay(ArenaBattleReport obj)
		{
			Action<ArenaBattleReport> eventOnStartArenaBattleReplay = this.EventOnStartArenaBattleReplay;
			if (eventOnStartArenaBattleReplay != null)
			{
				eventOnStartArenaBattleReplay(obj);
			}
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x002D78C8 File Offset: 0x002D5AC8
		private void __clearDele_EventOnStartArenaBattleReplay(ArenaBattleReport obj)
		{
			this.EventOnStartArenaBattleReplay = null;
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x002D78D4 File Offset: 0x002D5AD4
		private void __callDele_EventOnStartRealTimePVPBattleReplay(RealTimePVPBattleReport obj)
		{
			Action<RealTimePVPBattleReport> eventOnStartRealTimePVPBattleReplay = this.EventOnStartRealTimePVPBattleReplay;
			if (eventOnStartRealTimePVPBattleReplay != null)
			{
				eventOnStartRealTimePVPBattleReplay(obj);
			}
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x002D78F8 File Offset: 0x002D5AF8
		private void __clearDele_EventOnStartRealTimePVPBattleReplay(RealTimePVPBattleReport obj)
		{
			this.EventOnStartRealTimePVPBattleReplay = null;
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x002D7DD8 File Offset: 0x002D5FD8
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectPlayerHeadAssetsInt32_hotfix = (luaObj.RawGet("CollectPlayerHeadAssets") as LuaFunction);
					this.m_CollectHeroModelAssetsList`1_hotfix = (luaObj.RawGet("CollectHeroModelAssets") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_InitArenaUIController_hotfix = (luaObj.RawGet("InitArenaUIController") as LuaFunction);
					this.m_UninitArenaUIController_hotfix = (luaObj.RawGet("UninitArenaUIController") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdatePlayerInfo_hotfix = (luaObj.RawGet("UpdatePlayerInfo") as LuaFunction);
					this.m_UpdateBattlePower_hotfix = (luaObj.RawGet("UpdateBattlePower") as LuaFunction);
					this.m_StartArenaBattleReportBasicDataGetNetTaskArenaUIType_hotfix = (luaObj.RawGet("StartArenaBattleReportBasicDataGetNetTask") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddCrystal_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddCrystal") as LuaFunction);
					this.m_ArenaUIController_OnDefend_hotfix = (luaObj.RawGet("ArenaUIController_OnDefend") as LuaFunction);
					this.m_ArenaDefendUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ArenaDefendUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_ArenaUIController_OnReturn_hotfix = (luaObj.RawGet("ArenaUIController_OnReturn") as LuaFunction);
					this.m_ArenaUIController_OnShowHelp_hotfix = (luaObj.RawGet("ArenaUIController_OnShowHelp") as LuaFunction);
					this.m_ArenaUIController_OnShowBuyArenaTicket_hotfix = (luaObj.RawGet("ArenaUIController_OnShowBuyArenaTicket") as LuaFunction);
					this.m_ArenaUIController_OnBuyArenaTicket_hotfix = (luaObj.RawGet("ArenaUIController_OnBuyArenaTicket") as LuaFunction);
					this.m_ArenaUIController_OnSwitchOnlineOffline_hotfix = (luaObj.RawGet("ArenaUIController_OnSwitchOnlineOffline") as LuaFunction);
					this.m_ChestUITask_OnStopTask_hotfix = (luaObj.RawGet("ChestUITask_OnStop") as LuaFunction);
					this.m_ChestUITask_OnClose_hotfix = (luaObj.RawGet("ChestUITask_OnClose") as LuaFunction);
					this.m_add_EventOnStartArenaBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnStartArenaBattle") as LuaFunction);
					this.m_remove_EventOnStartArenaBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartArenaBattle") as LuaFunction);
					this.m_add_EventOnStartArenaBattleReplayAction`1_hotfix = (luaObj.RawGet("add_EventOnStartArenaBattleReplay") as LuaFunction);
					this.m_remove_EventOnStartArenaBattleReplayAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartArenaBattleReplay") as LuaFunction);
					this.m_add_EventOnStartRealTimePVPBattleReplayAction`1_hotfix = (luaObj.RawGet("add_EventOnStartRealTimePVPBattleReplay") as LuaFunction);
					this.m_remove_EventOnStartRealTimePVPBattleReplayAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartRealTimePVPBattleReplay") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_CollectOfflineArenaAssets_hotfix = (luaObj.RawGet("CollectOfflineArenaAssets") as LuaFunction);
					this.m_UpdateOfflineArena_hotfix = (luaObj.RawGet("UpdateOfflineArena") as LuaFunction);
					this.m_UpdateOfflineArenaOpponentRefreshTime_hotfix = (luaObj.RawGet("UpdateOfflineArenaOpponentRefreshTime") as LuaFunction);
					this.m_FlushOfflineTopRankPlayers_hotfix = (luaObj.RawGet("FlushOfflineTopRankPlayers") as LuaFunction);
					this.m_AutoGetOfflineVictoryPointReward_hotfix = (luaObj.RawGet("AutoGetOfflineVictoryPointReward") as LuaFunction);
					this.m_ArenaUIController_OnShowOfflinePanelOfflineArenaPanelType_hotfix = (luaObj.RawGet("ArenaUIController_OnShowOfflinePanel") as LuaFunction);
					this.m_ArenaUIController_OnGainOfflineVictoryPointsRewardInt32_hotfix = (luaObj.RawGet("ArenaUIController_OnGainOfflineVictoryPointsReward") as LuaFunction);
					this.m_ArenaUIController_OnShowOfflineArenaOpponentInt32_hotfix = (luaObj.RawGet("ArenaUIController_OnShowOfflineArenaOpponent") as LuaFunction);
					this.m_ArenaUIController_OnAttackOfflineArenaOpponentBoolean_hotfix = (luaObj.RawGet("ArenaUIController_OnAttackOfflineArenaOpponent") as LuaFunction);
					this.m_ArenaUIController_OnShowRevengeOfflineArenaOpponentArenaBattleReport_hotfix = (luaObj.RawGet("ArenaUIController_OnShowRevengeOfflineArenaOpponent") as LuaFunction);
					this.m_ArenaUIController_OnRevengeOfflineArenaOpponentBoolean_hotfix = (luaObj.RawGet("ArenaUIController_OnRevengeOfflineArenaOpponent") as LuaFunction);
					this.m_ArenaUIController_OnOfflineBattleReportReplayArenaBattleReport_hotfix = (luaObj.RawGet("ArenaUIController_OnOfflineBattleReportReplay") as LuaFunction);
					this.m_PlayerContext_OnArenaFlushOpponentsNtf_hotfix = (luaObj.RawGet("PlayerContext_OnArenaFlushOpponentsNtf") as LuaFunction);
					this.m_CollectOnlineArenaAssets_hotfix = (luaObj.RawGet("CollectOnlineArenaAssets") as LuaFunction);
					this.m_UpdateOnlineArena_hotfix = (luaObj.RawGet("UpdateOnlineArena") as LuaFunction);
					this.m_UpdateOnlineMatchingTime_hotfix = (luaObj.RawGet("UpdateOnlineMatchingTime") as LuaFunction);
					this.m_UpdateLadderMode_hotfix = (luaObj.RawGet("UpdateLadderMode") as LuaFunction);
					this.m_FlushOnlineTopRankPlayersBoolean_hotfix = (luaObj.RawGet("FlushOnlineTopRankPlayers") as LuaFunction);
					this.m_StartRealTimePVPGetInfoNetTaskAction`1_hotfix = (luaObj.RawGet("StartRealTimePVPGetInfoNetTask") as LuaFunction);
					this.m_StartRealTimePVPGetTopPlayersNetTaskBoolean_hotfix = (luaObj.RawGet("StartRealTimePVPGetTopPlayersNetTask") as LuaFunction);
					this.m_AutoGetOnlineWeekWinReward_hotfix = (luaObj.RawGet("AutoGetOnlineWeekWinReward") as LuaFunction);
					this.m_StartRealTimePVPWaitingForOpponentNetTaskBattleMode_hotfix = (luaObj.RawGet("StartRealTimePVPWaitingForOpponentNetTask") as LuaFunction);
					this.m_StartMatchiingBattleMode_hotfix = (luaObj.RawGet("StartMatchiing") as LuaFunction);
					this.m_ArenaUIController_OnShowOnlinePanelOnlineArenaPanelType_hotfix = (luaObj.RawGet("ArenaUIController_OnShowOnlinePanel") as LuaFunction);
					this.m_ArenaUIController_OnGainOnlineWeekWinRewardInt32_hotfix = (luaObj.RawGet("ArenaUIController_OnGainOnlineWeekWinReward") as LuaFunction);
					this.m_ArenaUIController_OnOnlineBattleReportReplayRealTimePVPBattleReport_hotfix = (luaObj.RawGet("ArenaUIController_OnOnlineBattleReportReplay") as LuaFunction);
					this.m_ArenaUIController_OnLadderChallenge_hotfix = (luaObj.RawGet("ArenaUIController_OnLadderChallenge") as LuaFunction);
					this.m_ArenaUIController_OnCasualChallenge_hotfix = (luaObj.RawGet("ArenaUIController_OnCasualChallenge") as LuaFunction);
					this.m_ArenaUIController_OnMatchingCancel_hotfix = (luaObj.RawGet("ArenaUIController_OnMatchingCancel") as LuaFunction);
					this.m_PlayerContext_OnRealTimePVPMatchupNtfInt32_hotfix = (luaObj.RawGet("PlayerContext_OnRealTimePVPMatchupNtf") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x002D8530 File Offset: 0x002D6730
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006BE0 RID: 27616
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ArenaUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Arena_ABS/Prefab/ArenaUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ArenaChestUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/ChestUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006BE1 RID: 27617
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ArenaUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ArenaUIController"),
				m_ctrlName = "ArenaUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ArenaUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "PlayerResourceUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ArenaChestUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ChestUIController"),
				m_ctrlName = "ChestUIController"
			}
		};

		// Token: 0x04006BE2 RID: 27618
		private ArenaUIController m_arenaUIController;

		// Token: 0x04006BE3 RID: 27619
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04006BE4 RID: 27620
		private ArenaDefendUITask m_arenaDefendUITask;

		// Token: 0x04006BE5 RID: 27621
		private ChestUITask m_chestUITask;

		// Token: 0x04006BE6 RID: 27622
		private List<ConfigDataRealTimePVPDanInfo> m_realTimePVPDans = new List<ConfigDataRealTimePVPDanInfo>();

		// Token: 0x04006BE7 RID: 27623
		private List<ArenaOpponent> m_arenaOpponents = new List<ArenaOpponent>();

		// Token: 0x04006BE8 RID: 27624
		private List<ArenaBattleReport> m_offlineArenaBattleReport = new List<ArenaBattleReport>();

		// Token: 0x04006BE9 RID: 27625
		private List<RealTimePVPBattleReport> m_onlineArenaBattleReport = new List<RealTimePVPBattleReport>();

		// Token: 0x04006BEA RID: 27626
		private List<RealTimePVPBattleReport> m_onlineArenaPromotionBattleReport = new List<RealTimePVPBattleReport>();

		// Token: 0x04006BEB RID: 27627
		private OfflineArenaPanelType m_offlinePanelType;

		// Token: 0x04006BEC RID: 27628
		private OnlineArenaPanelType m_onlinePanelType;

		// Token: 0x04006BED RID: 27629
		private ArenaUIType m_arenaUIType = ArenaUIType.Offline;

		// Token: 0x04006BEE RID: 27630
		private int m_curArenaOpponentIndex = -1;

		// Token: 0x04006BEF RID: 27631
		private ArenaBattleReport m_curArenaBattleReport;

		// Token: 0x04006BF0 RID: 27632
		private bool m_canFlushOfflineTopRankPlayers = true;

		// Token: 0x04006BF1 RID: 27633
		private bool m_canFlushOnlineGlobalTopRankPlayers = true;

		// Token: 0x04006BF2 RID: 27634
		private bool m_canFlushOnlineLocalTopRankPlayers = true;

		// Token: 0x04006BF3 RID: 27635
		private bool m_isSwitchingOfflineOnline;

		// Token: 0x04006BF4 RID: 27636
		private int m_nowSeconds;

		// Token: 0x04006BF5 RID: 27637
		private DateTime m_matchingUIBeginTime = DateTime.MinValue;

		// Token: 0x04006BF6 RID: 27638
		private DateTime m_matchingReqSendTime = DateTime.MinValue;

		// Token: 0x04006BF7 RID: 27639
		private BattleMode m_matchingBattleMode;

		// Token: 0x04006BF8 RID: 27640
		private bool m_isNeedCheckOnline;

		// Token: 0x04006BF9 RID: 27641
		[DoNotToLua]
		private ArenaUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006BFA RID: 27642
		[CompilerGenerated]
		private static Comparison<Hero> <>f__mg$cache0;

		// Token: 0x04006BFB RID: 27643
		[CompilerGenerated]
		private static Comparison<ArenaBattleReport> <>f__mg$cache1;

		// Token: 0x04006BFC RID: 27644
		[CompilerGenerated]
		private static Comparison<RealTimePVPBattleReport> <>f__mg$cache2;

		// Token: 0x04006BFD RID: 27645
		[CompilerGenerated]
		private static Comparison<RealTimePVPBattleReport> <>f__mg$cache3;

		// Token: 0x04006BFE RID: 27646
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006BFF RID: 27647
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006C00 RID: 27648
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04006C01 RID: 27649
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04006C02 RID: 27650
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04006C03 RID: 27651
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04006C04 RID: 27652
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04006C05 RID: 27653
		private LuaFunction m_CollectPlayerHeadAssetsInt32_hotfix;

		// Token: 0x04006C06 RID: 27654
		private LuaFunction m_CollectHeroModelAssetsList;

		// Token: 0x04006C07 RID: 27655
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006C08 RID: 27656
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006C09 RID: 27657
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x04006C0A RID: 27658
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x04006C0B RID: 27659
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04006C0C RID: 27660
		private LuaFunction m_InitArenaUIController_hotfix;

		// Token: 0x04006C0D RID: 27661
		private LuaFunction m_UninitArenaUIController_hotfix;

		// Token: 0x04006C0E RID: 27662
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04006C0F RID: 27663
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04006C10 RID: 27664
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006C11 RID: 27665
		private LuaFunction m_UpdatePlayerInfo_hotfix;

		// Token: 0x04006C12 RID: 27666
		private LuaFunction m_UpdateBattlePower_hotfix;

		// Token: 0x04006C13 RID: 27667
		private LuaFunction m_StartArenaBattleReportBasicDataGetNetTaskArenaUIType_hotfix;

		// Token: 0x04006C14 RID: 27668
		private LuaFunction m_PlayerResourceUIController_OnAddCrystal_hotfix;

		// Token: 0x04006C15 RID: 27669
		private LuaFunction m_ArenaUIController_OnDefend_hotfix;

		// Token: 0x04006C16 RID: 27670
		private LuaFunction m_ArenaDefendUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04006C17 RID: 27671
		private LuaFunction m_ArenaUIController_OnReturn_hotfix;

		// Token: 0x04006C18 RID: 27672
		private LuaFunction m_ArenaUIController_OnShowHelp_hotfix;

		// Token: 0x04006C19 RID: 27673
		private LuaFunction m_ArenaUIController_OnShowBuyArenaTicket_hotfix;

		// Token: 0x04006C1A RID: 27674
		private LuaFunction m_ArenaUIController_OnBuyArenaTicket_hotfix;

		// Token: 0x04006C1B RID: 27675
		private LuaFunction m_ArenaUIController_OnSwitchOnlineOffline_hotfix;

		// Token: 0x04006C1C RID: 27676
		private LuaFunction m_ChestUITask_OnStopTask_hotfix;

		// Token: 0x04006C1D RID: 27677
		private LuaFunction m_ChestUITask_OnClose_hotfix;

		// Token: 0x04006C1E RID: 27678
		private LuaFunction m_add_EventOnStartArenaBattleAction;

		// Token: 0x04006C1F RID: 27679
		private LuaFunction m_remove_EventOnStartArenaBattleAction;

		// Token: 0x04006C20 RID: 27680
		private LuaFunction m_add_EventOnStartArenaBattleReplayAction;

		// Token: 0x04006C21 RID: 27681
		private LuaFunction m_remove_EventOnStartArenaBattleReplayAction;

		// Token: 0x04006C22 RID: 27682
		private LuaFunction m_add_EventOnStartRealTimePVPBattleReplayAction;

		// Token: 0x04006C23 RID: 27683
		private LuaFunction m_remove_EventOnStartRealTimePVPBattleReplayAction;

		// Token: 0x04006C24 RID: 27684
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04006C25 RID: 27685
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x04006C26 RID: 27686
		private LuaFunction m_CollectOfflineArenaAssets_hotfix;

		// Token: 0x04006C27 RID: 27687
		private LuaFunction m_UpdateOfflineArena_hotfix;

		// Token: 0x04006C28 RID: 27688
		private LuaFunction m_UpdateOfflineArenaOpponentRefreshTime_hotfix;

		// Token: 0x04006C29 RID: 27689
		private LuaFunction m_FlushOfflineTopRankPlayers_hotfix;

		// Token: 0x04006C2A RID: 27690
		private LuaFunction m_AutoGetOfflineVictoryPointReward_hotfix;

		// Token: 0x04006C2B RID: 27691
		private LuaFunction m_ArenaUIController_OnShowOfflinePanelOfflineArenaPanelType_hotfix;

		// Token: 0x04006C2C RID: 27692
		private LuaFunction m_ArenaUIController_OnGainOfflineVictoryPointsRewardInt32_hotfix;

		// Token: 0x04006C2D RID: 27693
		private LuaFunction m_ArenaUIController_OnShowOfflineArenaOpponentInt32_hotfix;

		// Token: 0x04006C2E RID: 27694
		private LuaFunction m_ArenaUIController_OnAttackOfflineArenaOpponentBoolean_hotfix;

		// Token: 0x04006C2F RID: 27695
		private LuaFunction m_ArenaUIController_OnShowRevengeOfflineArenaOpponentArenaBattleReport_hotfix;

		// Token: 0x04006C30 RID: 27696
		private LuaFunction m_ArenaUIController_OnRevengeOfflineArenaOpponentBoolean_hotfix;

		// Token: 0x04006C31 RID: 27697
		private LuaFunction m_ArenaUIController_OnOfflineBattleReportReplayArenaBattleReport_hotfix;

		// Token: 0x04006C32 RID: 27698
		private LuaFunction m_PlayerContext_OnArenaFlushOpponentsNtf_hotfix;

		// Token: 0x04006C33 RID: 27699
		private LuaFunction m_CollectOnlineArenaAssets_hotfix;

		// Token: 0x04006C34 RID: 27700
		private LuaFunction m_UpdateOnlineArena_hotfix;

		// Token: 0x04006C35 RID: 27701
		private LuaFunction m_UpdateOnlineMatchingTime_hotfix;

		// Token: 0x04006C36 RID: 27702
		private LuaFunction m_UpdateLadderMode_hotfix;

		// Token: 0x04006C37 RID: 27703
		private LuaFunction m_FlushOnlineTopRankPlayersBoolean_hotfix;

		// Token: 0x04006C38 RID: 27704
		private LuaFunction m_StartRealTimePVPGetInfoNetTaskAction;

		// Token: 0x04006C39 RID: 27705
		private LuaFunction m_StartRealTimePVPGetTopPlayersNetTaskBoolean_hotfix;

		// Token: 0x04006C3A RID: 27706
		private LuaFunction m_AutoGetOnlineWeekWinReward_hotfix;

		// Token: 0x04006C3B RID: 27707
		private LuaFunction m_StartRealTimePVPWaitingForOpponentNetTaskBattleMode_hotfix;

		// Token: 0x04006C3C RID: 27708
		private LuaFunction m_StartMatchiingBattleMode_hotfix;

		// Token: 0x04006C3D RID: 27709
		private LuaFunction m_ArenaUIController_OnShowOnlinePanelOnlineArenaPanelType_hotfix;

		// Token: 0x04006C3E RID: 27710
		private LuaFunction m_ArenaUIController_OnGainOnlineWeekWinRewardInt32_hotfix;

		// Token: 0x04006C3F RID: 27711
		private LuaFunction m_ArenaUIController_OnOnlineBattleReportReplayRealTimePVPBattleReport_hotfix;

		// Token: 0x04006C40 RID: 27712
		private LuaFunction m_ArenaUIController_OnLadderChallenge_hotfix;

		// Token: 0x04006C41 RID: 27713
		private LuaFunction m_ArenaUIController_OnCasualChallenge_hotfix;

		// Token: 0x04006C42 RID: 27714
		private LuaFunction m_ArenaUIController_OnMatchingCancel_hotfix;

		// Token: 0x04006C43 RID: 27715
		private LuaFunction m_PlayerContext_OnRealTimePVPMatchupNtfInt32_hotfix;

		// Token: 0x02000A38 RID: 2616
		public new class LuaExportHelper
		{
			// Token: 0x0600A0D5 RID: 41173 RVA: 0x002D8598 File Offset: 0x002D6798
			public LuaExportHelper(ArenaUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A0D6 RID: 41174 RVA: 0x002D85A8 File Offset: 0x002D67A8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600A0D7 RID: 41175 RVA: 0x002D85B8 File Offset: 0x002D67B8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600A0D8 RID: 41176 RVA: 0x002D85C8 File Offset: 0x002D67C8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600A0D9 RID: 41177 RVA: 0x002D85D8 File Offset: 0x002D67D8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600A0DA RID: 41178 RVA: 0x002D85E8 File Offset: 0x002D67E8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600A0DB RID: 41179 RVA: 0x002D85F8 File Offset: 0x002D67F8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600A0DC RID: 41180 RVA: 0x002D8608 File Offset: 0x002D6808
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A0DD RID: 41181 RVA: 0x002D8618 File Offset: 0x002D6818
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600A0DE RID: 41182 RVA: 0x002D8628 File Offset: 0x002D6828
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600A0DF RID: 41183 RVA: 0x002D8638 File Offset: 0x002D6838
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600A0E0 RID: 41184 RVA: 0x002D8648 File Offset: 0x002D6848
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600A0E1 RID: 41185 RVA: 0x002D8658 File Offset: 0x002D6858
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600A0E2 RID: 41186 RVA: 0x002D8668 File Offset: 0x002D6868
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600A0E3 RID: 41187 RVA: 0x002D8678 File Offset: 0x002D6878
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600A0E4 RID: 41188 RVA: 0x002D8688 File Offset: 0x002D6888
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600A0E5 RID: 41189 RVA: 0x002D8698 File Offset: 0x002D6898
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600A0E6 RID: 41190 RVA: 0x002D86A8 File Offset: 0x002D68A8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600A0E7 RID: 41191 RVA: 0x002D86B8 File Offset: 0x002D68B8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600A0E8 RID: 41192 RVA: 0x002D86C8 File Offset: 0x002D68C8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600A0E9 RID: 41193 RVA: 0x002D86D8 File Offset: 0x002D68D8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600A0EA RID: 41194 RVA: 0x002D86E8 File Offset: 0x002D68E8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600A0EB RID: 41195 RVA: 0x002D86F8 File Offset: 0x002D68F8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600A0EC RID: 41196 RVA: 0x002D8708 File Offset: 0x002D6908
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600A0ED RID: 41197 RVA: 0x002D8718 File Offset: 0x002D6918
			public void __callDele_EventOnStartArenaBattle(bool obj)
			{
				this.m_owner.__callDele_EventOnStartArenaBattle(obj);
			}

			// Token: 0x0600A0EE RID: 41198 RVA: 0x002D8728 File Offset: 0x002D6928
			public void __clearDele_EventOnStartArenaBattle(bool obj)
			{
				this.m_owner.__clearDele_EventOnStartArenaBattle(obj);
			}

			// Token: 0x0600A0EF RID: 41199 RVA: 0x002D8738 File Offset: 0x002D6938
			public void __callDele_EventOnStartArenaBattleReplay(ArenaBattleReport obj)
			{
				this.m_owner.__callDele_EventOnStartArenaBattleReplay(obj);
			}

			// Token: 0x0600A0F0 RID: 41200 RVA: 0x002D8748 File Offset: 0x002D6948
			public void __clearDele_EventOnStartArenaBattleReplay(ArenaBattleReport obj)
			{
				this.m_owner.__clearDele_EventOnStartArenaBattleReplay(obj);
			}

			// Token: 0x0600A0F1 RID: 41201 RVA: 0x002D8758 File Offset: 0x002D6958
			public void __callDele_EventOnStartRealTimePVPBattleReplay(RealTimePVPBattleReport obj)
			{
				this.m_owner.__callDele_EventOnStartRealTimePVPBattleReplay(obj);
			}

			// Token: 0x0600A0F2 RID: 41202 RVA: 0x002D8768 File Offset: 0x002D6968
			public void __clearDele_EventOnStartRealTimePVPBattleReplay(RealTimePVPBattleReport obj)
			{
				this.m_owner.__clearDele_EventOnStartRealTimePVPBattleReplay(obj);
			}

			// Token: 0x170020BA RID: 8378
			// (get) Token: 0x0600A0F3 RID: 41203 RVA: 0x002D8778 File Offset: 0x002D6978
			// (set) Token: 0x0600A0F4 RID: 41204 RVA: 0x002D8788 File Offset: 0x002D6988
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

			// Token: 0x170020BB RID: 8379
			// (get) Token: 0x0600A0F5 RID: 41205 RVA: 0x002D8798 File Offset: 0x002D6998
			// (set) Token: 0x0600A0F6 RID: 41206 RVA: 0x002D87A8 File Offset: 0x002D69A8
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

			// Token: 0x170020BC RID: 8380
			// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x002D87B8 File Offset: 0x002D69B8
			// (set) Token: 0x0600A0F8 RID: 41208 RVA: 0x002D87C8 File Offset: 0x002D69C8
			public ArenaUIController m_arenaUIController
			{
				get
				{
					return this.m_owner.m_arenaUIController;
				}
				set
				{
					this.m_owner.m_arenaUIController = value;
				}
			}

			// Token: 0x170020BD RID: 8381
			// (get) Token: 0x0600A0F9 RID: 41209 RVA: 0x002D87D8 File Offset: 0x002D69D8
			// (set) Token: 0x0600A0FA RID: 41210 RVA: 0x002D87E8 File Offset: 0x002D69E8
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

			// Token: 0x170020BE RID: 8382
			// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x002D87F8 File Offset: 0x002D69F8
			// (set) Token: 0x0600A0FC RID: 41212 RVA: 0x002D8808 File Offset: 0x002D6A08
			public ArenaDefendUITask m_arenaDefendUITask
			{
				get
				{
					return this.m_owner.m_arenaDefendUITask;
				}
				set
				{
					this.m_owner.m_arenaDefendUITask = value;
				}
			}

			// Token: 0x170020BF RID: 8383
			// (get) Token: 0x0600A0FD RID: 41213 RVA: 0x002D8818 File Offset: 0x002D6A18
			// (set) Token: 0x0600A0FE RID: 41214 RVA: 0x002D8828 File Offset: 0x002D6A28
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

			// Token: 0x170020C0 RID: 8384
			// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x002D8838 File Offset: 0x002D6A38
			// (set) Token: 0x0600A100 RID: 41216 RVA: 0x002D8848 File Offset: 0x002D6A48
			public List<ConfigDataRealTimePVPDanInfo> m_realTimePVPDans
			{
				get
				{
					return this.m_owner.m_realTimePVPDans;
				}
				set
				{
					this.m_owner.m_realTimePVPDans = value;
				}
			}

			// Token: 0x170020C1 RID: 8385
			// (get) Token: 0x0600A101 RID: 41217 RVA: 0x002D8858 File Offset: 0x002D6A58
			// (set) Token: 0x0600A102 RID: 41218 RVA: 0x002D8868 File Offset: 0x002D6A68
			public List<ArenaOpponent> m_arenaOpponents
			{
				get
				{
					return this.m_owner.m_arenaOpponents;
				}
				set
				{
					this.m_owner.m_arenaOpponents = value;
				}
			}

			// Token: 0x170020C2 RID: 8386
			// (get) Token: 0x0600A103 RID: 41219 RVA: 0x002D8878 File Offset: 0x002D6A78
			// (set) Token: 0x0600A104 RID: 41220 RVA: 0x002D8888 File Offset: 0x002D6A88
			public List<ArenaBattleReport> m_offlineArenaBattleReport
			{
				get
				{
					return this.m_owner.m_offlineArenaBattleReport;
				}
				set
				{
					this.m_owner.m_offlineArenaBattleReport = value;
				}
			}

			// Token: 0x170020C3 RID: 8387
			// (get) Token: 0x0600A105 RID: 41221 RVA: 0x002D8898 File Offset: 0x002D6A98
			// (set) Token: 0x0600A106 RID: 41222 RVA: 0x002D88A8 File Offset: 0x002D6AA8
			public List<RealTimePVPBattleReport> m_onlineArenaBattleReport
			{
				get
				{
					return this.m_owner.m_onlineArenaBattleReport;
				}
				set
				{
					this.m_owner.m_onlineArenaBattleReport = value;
				}
			}

			// Token: 0x170020C4 RID: 8388
			// (get) Token: 0x0600A107 RID: 41223 RVA: 0x002D88B8 File Offset: 0x002D6AB8
			// (set) Token: 0x0600A108 RID: 41224 RVA: 0x002D88C8 File Offset: 0x002D6AC8
			public List<RealTimePVPBattleReport> m_onlineArenaPromotionBattleReport
			{
				get
				{
					return this.m_owner.m_onlineArenaPromotionBattleReport;
				}
				set
				{
					this.m_owner.m_onlineArenaPromotionBattleReport = value;
				}
			}

			// Token: 0x170020C5 RID: 8389
			// (get) Token: 0x0600A109 RID: 41225 RVA: 0x002D88D8 File Offset: 0x002D6AD8
			// (set) Token: 0x0600A10A RID: 41226 RVA: 0x002D88E8 File Offset: 0x002D6AE8
			public OfflineArenaPanelType m_offlinePanelType
			{
				get
				{
					return this.m_owner.m_offlinePanelType;
				}
				set
				{
					this.m_owner.m_offlinePanelType = value;
				}
			}

			// Token: 0x170020C6 RID: 8390
			// (get) Token: 0x0600A10B RID: 41227 RVA: 0x002D88F8 File Offset: 0x002D6AF8
			// (set) Token: 0x0600A10C RID: 41228 RVA: 0x002D8908 File Offset: 0x002D6B08
			public OnlineArenaPanelType m_onlinePanelType
			{
				get
				{
					return this.m_owner.m_onlinePanelType;
				}
				set
				{
					this.m_owner.m_onlinePanelType = value;
				}
			}

			// Token: 0x170020C7 RID: 8391
			// (get) Token: 0x0600A10D RID: 41229 RVA: 0x002D8918 File Offset: 0x002D6B18
			// (set) Token: 0x0600A10E RID: 41230 RVA: 0x002D8928 File Offset: 0x002D6B28
			public ArenaUIType m_arenaUIType
			{
				get
				{
					return this.m_owner.m_arenaUIType;
				}
				set
				{
					this.m_owner.m_arenaUIType = value;
				}
			}

			// Token: 0x170020C8 RID: 8392
			// (get) Token: 0x0600A10F RID: 41231 RVA: 0x002D8938 File Offset: 0x002D6B38
			// (set) Token: 0x0600A110 RID: 41232 RVA: 0x002D8948 File Offset: 0x002D6B48
			public int m_curArenaOpponentIndex
			{
				get
				{
					return this.m_owner.m_curArenaOpponentIndex;
				}
				set
				{
					this.m_owner.m_curArenaOpponentIndex = value;
				}
			}

			// Token: 0x170020C9 RID: 8393
			// (get) Token: 0x0600A111 RID: 41233 RVA: 0x002D8958 File Offset: 0x002D6B58
			// (set) Token: 0x0600A112 RID: 41234 RVA: 0x002D8968 File Offset: 0x002D6B68
			public ArenaBattleReport m_curArenaBattleReport
			{
				get
				{
					return this.m_owner.m_curArenaBattleReport;
				}
				set
				{
					this.m_owner.m_curArenaBattleReport = value;
				}
			}

			// Token: 0x170020CA RID: 8394
			// (get) Token: 0x0600A113 RID: 41235 RVA: 0x002D8978 File Offset: 0x002D6B78
			// (set) Token: 0x0600A114 RID: 41236 RVA: 0x002D8988 File Offset: 0x002D6B88
			public bool m_canFlushOfflineTopRankPlayers
			{
				get
				{
					return this.m_owner.m_canFlushOfflineTopRankPlayers;
				}
				set
				{
					this.m_owner.m_canFlushOfflineTopRankPlayers = value;
				}
			}

			// Token: 0x170020CB RID: 8395
			// (get) Token: 0x0600A115 RID: 41237 RVA: 0x002D8998 File Offset: 0x002D6B98
			// (set) Token: 0x0600A116 RID: 41238 RVA: 0x002D89A8 File Offset: 0x002D6BA8
			public bool m_canFlushOnlineGlobalTopRankPlayers
			{
				get
				{
					return this.m_owner.m_canFlushOnlineGlobalTopRankPlayers;
				}
				set
				{
					this.m_owner.m_canFlushOnlineGlobalTopRankPlayers = value;
				}
			}

			// Token: 0x170020CC RID: 8396
			// (get) Token: 0x0600A117 RID: 41239 RVA: 0x002D89B8 File Offset: 0x002D6BB8
			// (set) Token: 0x0600A118 RID: 41240 RVA: 0x002D89C8 File Offset: 0x002D6BC8
			public bool m_canFlushOnlineLocalTopRankPlayers
			{
				get
				{
					return this.m_owner.m_canFlushOnlineLocalTopRankPlayers;
				}
				set
				{
					this.m_owner.m_canFlushOnlineLocalTopRankPlayers = value;
				}
			}

			// Token: 0x170020CD RID: 8397
			// (get) Token: 0x0600A119 RID: 41241 RVA: 0x002D89D8 File Offset: 0x002D6BD8
			// (set) Token: 0x0600A11A RID: 41242 RVA: 0x002D89E8 File Offset: 0x002D6BE8
			public bool m_isSwitchingOfflineOnline
			{
				get
				{
					return this.m_owner.m_isSwitchingOfflineOnline;
				}
				set
				{
					this.m_owner.m_isSwitchingOfflineOnline = value;
				}
			}

			// Token: 0x170020CE RID: 8398
			// (get) Token: 0x0600A11B RID: 41243 RVA: 0x002D89F8 File Offset: 0x002D6BF8
			// (set) Token: 0x0600A11C RID: 41244 RVA: 0x002D8A08 File Offset: 0x002D6C08
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x170020CF RID: 8399
			// (get) Token: 0x0600A11D RID: 41245 RVA: 0x002D8A18 File Offset: 0x002D6C18
			// (set) Token: 0x0600A11E RID: 41246 RVA: 0x002D8A28 File Offset: 0x002D6C28
			public DateTime m_matchingUIBeginTime
			{
				get
				{
					return this.m_owner.m_matchingUIBeginTime;
				}
				set
				{
					this.m_owner.m_matchingUIBeginTime = value;
				}
			}

			// Token: 0x170020D0 RID: 8400
			// (get) Token: 0x0600A11F RID: 41247 RVA: 0x002D8A38 File Offset: 0x002D6C38
			// (set) Token: 0x0600A120 RID: 41248 RVA: 0x002D8A48 File Offset: 0x002D6C48
			public DateTime m_matchingReqSendTime
			{
				get
				{
					return this.m_owner.m_matchingReqSendTime;
				}
				set
				{
					this.m_owner.m_matchingReqSendTime = value;
				}
			}

			// Token: 0x170020D1 RID: 8401
			// (get) Token: 0x0600A121 RID: 41249 RVA: 0x002D8A58 File Offset: 0x002D6C58
			// (set) Token: 0x0600A122 RID: 41250 RVA: 0x002D8A68 File Offset: 0x002D6C68
			public BattleMode m_matchingBattleMode
			{
				get
				{
					return this.m_owner.m_matchingBattleMode;
				}
				set
				{
					this.m_owner.m_matchingBattleMode = value;
				}
			}

			// Token: 0x170020D2 RID: 8402
			// (get) Token: 0x0600A123 RID: 41251 RVA: 0x002D8A78 File Offset: 0x002D6C78
			// (set) Token: 0x0600A124 RID: 41252 RVA: 0x002D8A88 File Offset: 0x002D6C88
			public bool m_isNeedCheckOnline
			{
				get
				{
					return this.m_owner.m_isNeedCheckOnline;
				}
				set
				{
					this.m_owner.m_isNeedCheckOnline = value;
				}
			}

			// Token: 0x170020D3 RID: 8403
			// (get) Token: 0x0600A125 RID: 41253 RVA: 0x002D8A98 File Offset: 0x002D6C98
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170020D4 RID: 8404
			// (get) Token: 0x0600A126 RID: 41254 RVA: 0x002D8AA8 File Offset: 0x002D6CA8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600A127 RID: 41255 RVA: 0x002D8AB8 File Offset: 0x002D6CB8
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600A128 RID: 41256 RVA: 0x002D8AC8 File Offset: 0x002D6CC8
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600A129 RID: 41257 RVA: 0x002D8AD8 File Offset: 0x002D6CD8
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600A12A RID: 41258 RVA: 0x002D8AE8 File Offset: 0x002D6CE8
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A12B RID: 41259 RVA: 0x002D8AF8 File Offset: 0x002D6CF8
			public void CollectPlayerHeadAssets(int playerHeadIconId)
			{
				this.m_owner.CollectPlayerHeadAssets(playerHeadIconId);
			}

			// Token: 0x0600A12C RID: 41260 RVA: 0x002D8B08 File Offset: 0x002D6D08
			public void CollectHeroModelAssets(List<BattleHero> heros)
			{
				this.m_owner.CollectHeroModelAssets(heros);
			}

			// Token: 0x0600A12D RID: 41261 RVA: 0x002D8B18 File Offset: 0x002D6D18
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600A12E RID: 41262 RVA: 0x002D8B28 File Offset: 0x002D6D28
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600A12F RID: 41263 RVA: 0x002D8B38 File Offset: 0x002D6D38
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x0600A130 RID: 41264 RVA: 0x002D8B48 File Offset: 0x002D6D48
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x0600A131 RID: 41265 RVA: 0x002D8B58 File Offset: 0x002D6D58
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600A132 RID: 41266 RVA: 0x002D8B68 File Offset: 0x002D6D68
			public void InitArenaUIController()
			{
				this.m_owner.InitArenaUIController();
			}

			// Token: 0x0600A133 RID: 41267 RVA: 0x002D8B78 File Offset: 0x002D6D78
			public void UninitArenaUIController()
			{
				this.m_owner.UninitArenaUIController();
			}

			// Token: 0x0600A134 RID: 41268 RVA: 0x002D8B88 File Offset: 0x002D6D88
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600A135 RID: 41269 RVA: 0x002D8B98 File Offset: 0x002D6D98
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600A136 RID: 41270 RVA: 0x002D8BA8 File Offset: 0x002D6DA8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600A137 RID: 41271 RVA: 0x002D8BB8 File Offset: 0x002D6DB8
			public void UpdatePlayerInfo()
			{
				this.m_owner.UpdatePlayerInfo();
			}

			// Token: 0x0600A138 RID: 41272 RVA: 0x002D8BC8 File Offset: 0x002D6DC8
			public void UpdateBattlePower()
			{
				this.m_owner.UpdateBattlePower();
			}

			// Token: 0x0600A139 RID: 41273 RVA: 0x002D8BD8 File Offset: 0x002D6DD8
			public static int CompareHeroBattlePower(Hero h1, Hero h2)
			{
				return ArenaUITask.CompareHeroBattlePower(h1, h2);
			}

			// Token: 0x0600A13A RID: 41274 RVA: 0x002D8BE4 File Offset: 0x002D6DE4
			public void StartArenaBattleReportBasicDataGetNetTask(ArenaUIType arenaUIType)
			{
				this.m_owner.StartArenaBattleReportBasicDataGetNetTask(arenaUIType);
			}

			// Token: 0x0600A13B RID: 41275 RVA: 0x002D8BF4 File Offset: 0x002D6DF4
			public void PlayerResourceUIController_OnAddCrystal()
			{
				this.m_owner.PlayerResourceUIController_OnAddCrystal();
			}

			// Token: 0x0600A13C RID: 41276 RVA: 0x002D8C04 File Offset: 0x002D6E04
			public void ArenaUIController_OnDefend()
			{
				this.m_owner.ArenaUIController_OnDefend();
			}

			// Token: 0x0600A13D RID: 41277 RVA: 0x002D8C14 File Offset: 0x002D6E14
			public void ArenaDefendUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ArenaDefendUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600A13E RID: 41278 RVA: 0x002D8C24 File Offset: 0x002D6E24
			public void ArenaUIController_OnReturn()
			{
				this.m_owner.ArenaUIController_OnReturn();
			}

			// Token: 0x0600A13F RID: 41279 RVA: 0x002D8C34 File Offset: 0x002D6E34
			public void ArenaUIController_OnShowHelp()
			{
				this.m_owner.ArenaUIController_OnShowHelp();
			}

			// Token: 0x0600A140 RID: 41280 RVA: 0x002D8C44 File Offset: 0x002D6E44
			public void ArenaUIController_OnShowBuyArenaTicket()
			{
				this.m_owner.ArenaUIController_OnShowBuyArenaTicket();
			}

			// Token: 0x0600A141 RID: 41281 RVA: 0x002D8C54 File Offset: 0x002D6E54
			public void ArenaUIController_OnBuyArenaTicket()
			{
				this.m_owner.ArenaUIController_OnBuyArenaTicket();
			}

			// Token: 0x0600A142 RID: 41282 RVA: 0x002D8C64 File Offset: 0x002D6E64
			public void ArenaUIController_OnSwitchOnlineOffline()
			{
				this.m_owner.ArenaUIController_OnSwitchOnlineOffline();
			}

			// Token: 0x0600A143 RID: 41283 RVA: 0x002D8C74 File Offset: 0x002D6E74
			public void ChestUITask_OnStop(Task task)
			{
				this.m_owner.ChestUITask_OnStop(task);
			}

			// Token: 0x0600A144 RID: 41284 RVA: 0x002D8C84 File Offset: 0x002D6E84
			public void ChestUITask_OnClose()
			{
				this.m_owner.ChestUITask_OnClose();
			}

			// Token: 0x0600A145 RID: 41285 RVA: 0x002D8C94 File Offset: 0x002D6E94
			public void CollectOfflineArenaAssets()
			{
				this.m_owner.CollectOfflineArenaAssets();
			}

			// Token: 0x0600A146 RID: 41286 RVA: 0x002D8CA4 File Offset: 0x002D6EA4
			public void UpdateOfflineArena()
			{
				this.m_owner.UpdateOfflineArena();
			}

			// Token: 0x0600A147 RID: 41287 RVA: 0x002D8CB4 File Offset: 0x002D6EB4
			public void UpdateOfflineArenaOpponentRefreshTime()
			{
				this.m_owner.UpdateOfflineArenaOpponentRefreshTime();
			}

			// Token: 0x0600A148 RID: 41288 RVA: 0x002D8CC4 File Offset: 0x002D6EC4
			public static int CompareArenaBattleReportsByCreateTime(ArenaBattleReport r0, ArenaBattleReport r1)
			{
				return ArenaUITask.CompareArenaBattleReportsByCreateTime(r0, r1);
			}

			// Token: 0x0600A149 RID: 41289 RVA: 0x002D8CD0 File Offset: 0x002D6ED0
			public static int CompareRealTimePVPBattleReportsByCreateTime(RealTimePVPBattleReport r0, RealTimePVPBattleReport r1)
			{
				return ArenaUITask.CompareRealTimePVPBattleReportsByCreateTime(r0, r1);
			}

			// Token: 0x0600A14A RID: 41290 RVA: 0x002D8CDC File Offset: 0x002D6EDC
			public static bool IsBattleReportAttackerGiveup(ArenaBattleReport battleReport)
			{
				return ArenaUITask.IsBattleReportAttackerGiveup(battleReport);
			}

			// Token: 0x0600A14B RID: 41291 RVA: 0x002D8CE4 File Offset: 0x002D6EE4
			public void FlushOfflineTopRankPlayers()
			{
				this.m_owner.FlushOfflineTopRankPlayers();
			}

			// Token: 0x0600A14C RID: 41292 RVA: 0x002D8CF4 File Offset: 0x002D6EF4
			public void AutoGetOfflineVictoryPointReward()
			{
				this.m_owner.AutoGetOfflineVictoryPointReward();
			}

			// Token: 0x0600A14D RID: 41293 RVA: 0x002D8D04 File Offset: 0x002D6F04
			public void ArenaUIController_OnShowOfflinePanel(OfflineArenaPanelType panelType)
			{
				this.m_owner.ArenaUIController_OnShowOfflinePanel(panelType);
			}

			// Token: 0x0600A14E RID: 41294 RVA: 0x002D8D14 File Offset: 0x002D6F14
			public void ArenaUIController_OnGainOfflineVictoryPointsReward(int idx)
			{
				this.m_owner.ArenaUIController_OnGainOfflineVictoryPointsReward(idx);
			}

			// Token: 0x0600A14F RID: 41295 RVA: 0x002D8D24 File Offset: 0x002D6F24
			public void ArenaUIController_OnShowOfflineArenaOpponent(int idx)
			{
				this.m_owner.ArenaUIController_OnShowOfflineArenaOpponent(idx);
			}

			// Token: 0x0600A150 RID: 41296 RVA: 0x002D8D34 File Offset: 0x002D6F34
			public void ArenaUIController_OnAttackOfflineArenaOpponent(bool autoBattle)
			{
				this.m_owner.ArenaUIController_OnAttackOfflineArenaOpponent(autoBattle);
			}

			// Token: 0x0600A151 RID: 41297 RVA: 0x002D8D44 File Offset: 0x002D6F44
			public void ArenaUIController_OnShowRevengeOfflineArenaOpponent(ArenaBattleReport battleReport)
			{
				this.m_owner.ArenaUIController_OnShowRevengeOfflineArenaOpponent(battleReport);
			}

			// Token: 0x0600A152 RID: 41298 RVA: 0x002D8D54 File Offset: 0x002D6F54
			public void ArenaUIController_OnRevengeOfflineArenaOpponent(bool autoBattle)
			{
				this.m_owner.ArenaUIController_OnRevengeOfflineArenaOpponent(autoBattle);
			}

			// Token: 0x0600A153 RID: 41299 RVA: 0x002D8D64 File Offset: 0x002D6F64
			public void ArenaUIController_OnOfflineBattleReportReplay(ArenaBattleReport battleReport)
			{
				this.m_owner.ArenaUIController_OnOfflineBattleReportReplay(battleReport);
			}

			// Token: 0x0600A154 RID: 41300 RVA: 0x002D8D74 File Offset: 0x002D6F74
			public void PlayerContext_OnArenaFlushOpponentsNtf()
			{
				this.m_owner.PlayerContext_OnArenaFlushOpponentsNtf();
			}

			// Token: 0x0600A155 RID: 41301 RVA: 0x002D8D84 File Offset: 0x002D6F84
			public void CollectOnlineArenaAssets()
			{
				this.m_owner.CollectOnlineArenaAssets();
			}

			// Token: 0x0600A156 RID: 41302 RVA: 0x002D8D94 File Offset: 0x002D6F94
			public void UpdateOnlineArena()
			{
				this.m_owner.UpdateOnlineArena();
			}

			// Token: 0x0600A157 RID: 41303 RVA: 0x002D8DA4 File Offset: 0x002D6FA4
			public void UpdateOnlineMatchingTime()
			{
				this.m_owner.UpdateOnlineMatchingTime();
			}

			// Token: 0x0600A158 RID: 41304 RVA: 0x002D8DB4 File Offset: 0x002D6FB4
			public void UpdateLadderMode()
			{
				this.m_owner.UpdateLadderMode();
			}

			// Token: 0x0600A159 RID: 41305 RVA: 0x002D8DC4 File Offset: 0x002D6FC4
			public static bool IsBattleReportPlayerGiveup(RealTimePVPBattleReport battleReport, out int playerIndex)
			{
				return ArenaUITask.IsBattleReportPlayerGiveup(battleReport, out playerIndex);
			}

			// Token: 0x0600A15A RID: 41306 RVA: 0x002D8DD0 File Offset: 0x002D6FD0
			public void FlushOnlineTopRankPlayers(bool isGlobal)
			{
				this.m_owner.FlushOnlineTopRankPlayers(isGlobal);
			}

			// Token: 0x0600A15B RID: 41307 RVA: 0x002D8DE0 File Offset: 0x002D6FE0
			public void StartRealTimePVPGetInfoNetTask(Action<int> onEnd)
			{
				this.m_owner.StartRealTimePVPGetInfoNetTask(onEnd);
			}

			// Token: 0x0600A15C RID: 41308 RVA: 0x002D8DF0 File Offset: 0x002D6FF0
			public void StartRealTimePVPGetTopPlayersNetTask(bool isGlobal)
			{
				this.m_owner.StartRealTimePVPGetTopPlayersNetTask(isGlobal);
			}

			// Token: 0x0600A15D RID: 41309 RVA: 0x002D8E00 File Offset: 0x002D7000
			public void AutoGetOnlineWeekWinReward()
			{
				this.m_owner.AutoGetOnlineWeekWinReward();
			}

			// Token: 0x0600A15E RID: 41310 RVA: 0x002D8E10 File Offset: 0x002D7010
			public void StartRealTimePVPWaitingForOpponentNetTask(BattleMode mode)
			{
				this.m_owner.StartRealTimePVPWaitingForOpponentNetTask(mode);
			}

			// Token: 0x0600A15F RID: 41311 RVA: 0x002D8E20 File Offset: 0x002D7020
			public void StartMatchiing(BattleMode mode)
			{
				this.m_owner.StartMatchiing(mode);
			}

			// Token: 0x0600A160 RID: 41312 RVA: 0x002D8E30 File Offset: 0x002D7030
			public void ArenaUIController_OnShowOnlinePanel(OnlineArenaPanelType panelType)
			{
				this.m_owner.ArenaUIController_OnShowOnlinePanel(panelType);
			}

			// Token: 0x0600A161 RID: 41313 RVA: 0x002D8E40 File Offset: 0x002D7040
			public void ArenaUIController_OnGainOnlineWeekWinReward(int bonusId)
			{
				this.m_owner.ArenaUIController_OnGainOnlineWeekWinReward(bonusId);
			}

			// Token: 0x0600A162 RID: 41314 RVA: 0x002D8E50 File Offset: 0x002D7050
			public void ArenaUIController_OnOnlineBattleReportReplay(RealTimePVPBattleReport battleReport)
			{
				this.m_owner.ArenaUIController_OnOnlineBattleReportReplay(battleReport);
			}

			// Token: 0x0600A163 RID: 41315 RVA: 0x002D8E60 File Offset: 0x002D7060
			public void ArenaUIController_OnLadderChallenge()
			{
				this.m_owner.ArenaUIController_OnLadderChallenge();
			}

			// Token: 0x0600A164 RID: 41316 RVA: 0x002D8E70 File Offset: 0x002D7070
			public void ArenaUIController_OnCasualChallenge()
			{
				this.m_owner.ArenaUIController_OnCasualChallenge();
			}

			// Token: 0x0600A165 RID: 41317 RVA: 0x002D8E80 File Offset: 0x002D7080
			public void ArenaUIController_OnMatchingCancel()
			{
				this.m_owner.ArenaUIController_OnMatchingCancel();
			}

			// Token: 0x0600A166 RID: 41318 RVA: 0x002D8E90 File Offset: 0x002D7090
			public void PlayerContext_OnRealTimePVPMatchupNtf(int result)
			{
				this.m_owner.PlayerContext_OnRealTimePVPMatchupNtf(result);
			}

			// Token: 0x04006C44 RID: 27716
			private ArenaUITask m_owner;
		}
	}
}
