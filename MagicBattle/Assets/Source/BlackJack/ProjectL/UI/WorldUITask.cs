using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001039 RID: 4153
	[HotFix]
	public class WorldUITask : UITask, IClientWorldListener
	{
		// Token: 0x0601525B RID: 86619 RVA: 0x005585F4 File Offset: 0x005567F4
		public WorldUITask(string name) : base(name)
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
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

		// Token: 0x0601525C RID: 86620 RVA: 0x0055877C File Offset: 0x0055697C
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
			ConfigDataWorldMapInfo currentWorldMapInfo = projectLPlayerContext.GetCurrentWorldMapInfo();
			if (currentWorldMapInfo != null)
			{
				base.CollectAsset(currentWorldMapInfo.WorldMap);
				foreach (ConfigDataRegionInfo configDataRegionInfo in currentWorldMapInfo.m_regionInfos)
				{
					foreach (ConfigDataWaypointInfo configDataWaypointInfo in configDataRegionInfo.m_waypointInfos)
					{
						base.CollectAsset(configDataWaypointInfo.Model);
						base.CollectSpriteAsset(configDataWaypointInfo.Background);
					}
				}
			}
			projectLPlayerContext.UpdateCurrentWaypointEvents();
			this.CollectEventAssets();
			this.CollectPlayerAssets();
			this.CollectMonthCardAssets();
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601525D RID: 86621 RVA: 0x0055889C File Offset: 0x00556A9C
		private void CollectPlayerAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPlayerAssets_hotfix != null)
			{
				this.m_CollectPlayerAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait()));
			Hero hero = projectLPlayerContext.GetHero(projectLPlayerContext.GetPlayerHeadPortrait());
			if (hero != null)
			{
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero));
			}
		}

		// Token: 0x0601525E RID: 86622 RVA: 0x0055893C File Offset: 0x00556B3C
		private void CollectEventAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEventAssets_hotfix != null)
			{
				this.m_CollectEventAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (KeyValuePair<int, ProjectLPlayerContext.CurrentWaypointEvent> keyValuePair in projectLPlayerContext.GetCurrentWaypointEvents())
			{
				ConfigDataEventInfo eventInfo = keyValuePair.Value.EventInfo;
				base.CollectAsset(eventInfo.Model);
				base.CollectAsset(eventInfo.MapIcon);
				base.CollectSpriteAsset(eventInfo.Icon);
			}
		}

		// Token: 0x0601525F RID: 86623 RVA: 0x00558A28 File Offset: 0x00556C28
		private void CollectMonthCardAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectMonthCardAssets_hotfix != null)
			{
				this.m_CollectMonthCardAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<MonthCard> allValidMonthCards = projectLPlayerContext.GetAllValidMonthCards();
			foreach (MonthCard monthCard in allValidMonthCards)
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null)
				{
					base.CollectSpriteAsset(configDataMonthCardInfo.Icon);
				}
			}
		}

		// Token: 0x06015260 RID: 86624 RVA: 0x00558B10 File Offset: 0x00556D10
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitLayerStateOnLoadAllResCompleted();
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x06015261 RID: 86625 RVA: 0x00558BB0 File Offset: 0x00556DB0
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
			this.InitWorldMapUIController();
			this.InitWorldUIController();
			NoticeUITask.StartUITask(string.Empty, string.Empty, ChatChannel.World, false);
			Utility.LogMemorySize("WorldUITask.InitAllUIControllers");
		}

		// Token: 0x06015262 RID: 86626 RVA: 0x00558C40 File Offset: 0x00556E40
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
			this.UninitWorldMapUIController();
			this.UninitWorldUIController();
		}

		// Token: 0x06015263 RID: 86627 RVA: 0x00558CB4 File Offset: 0x00556EB4
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
				projectLPlayerContext.EventOnMailsChangedNtf += this.PlayerContext_OnMailsChangedNtf;
				projectLPlayerContext.EventOnMailReadAck += this.PlayerContext_OnMailReadAck;
				projectLPlayerContext.EventOnFriendInviteNtf += this.PlayerContext_OnFriendInviteNtf;
				projectLPlayerContext.EventOnPlayerInfoChangeNtf += this.PlayerContext_OnPlayerInfoChangeNtf;
				projectLPlayerContext.EventOnFriendshipPointsReceivedNtf += this.PlayerContext_OnFriendshipPointsReceivedNtf;
				this.m_playerContext.EventOnGiftStoreBuyGoodsNtf += this.PlayerContext_EventOnGiftStoreBuyGoodsNtf;
			}
		}

		// Token: 0x06015264 RID: 86628 RVA: 0x00558DA4 File Offset: 0x00556FA4
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
				projectLPlayerContext.EventOnMailsChangedNtf -= this.PlayerContext_OnMailsChangedNtf;
				projectLPlayerContext.EventOnMailReadAck -= this.PlayerContext_OnMailReadAck;
				projectLPlayerContext.EventOnFriendInviteNtf -= this.PlayerContext_OnFriendInviteNtf;
				projectLPlayerContext.EventOnPlayerInfoChangeNtf -= this.PlayerContext_OnPlayerInfoChangeNtf;
				projectLPlayerContext.EventOnFriendshipPointsReceivedNtf -= this.PlayerContext_OnFriendshipPointsReceivedNtf;
				this.m_playerContext.EventOnGiftStoreBuyGoodsNtf += this.PlayerContext_EventOnGiftStoreBuyGoodsNtf;
			}
		}

		// Token: 0x06015265 RID: 86629 RVA: 0x00558E94 File Offset: 0x00557094
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
			global::Debug.Log("WorldUITask.OnStart");
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			global::Debug.Log(string.Format("userId:{0}, name:{1}", projectLPlayerContext.GetUserId(), projectLPlayerContext.GetPlayerName()));
			global::Debug.Log(string.Format("level:{0}, crystal:{1}, gold:{2}, energy:{3}", new object[]
			{
				projectLPlayerContext.GetPlayerLevel(),
				projectLPlayerContext.GetCrystal(),
				projectLPlayerContext.GetGold(),
				projectLPlayerContext.GetEnergy()
			}));
			if (projectLPlayerContext.GetRoomIndex() < 0)
			{
				ChatEnterRoomNetTask chatEnterRoomNetTask = new ChatEnterRoomNetTask(-1);
				chatEnterRoomNetTask.Start(null);
			}
			if (projectLPlayerContext.IsNeedGetFriendSocialRelation())
			{
				projectLPlayerContext.SetNeedGetFriendSocialRelation(false);
				GetFriendSocialRelationNetTask getFriendSocialRelationNetTask = new GetFriendSocialRelationNetTask((FriendSocialRelationFlag)11);
				getFriendSocialRelationNetTask.Start(null);
			}
			WorldUITask.s_instance = this;
			return base.OnStart(intent);
		}

		// Token: 0x06015266 RID: 86630 RVA: 0x00558FDC File Offset: 0x005571DC
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
			this.m_isResuming = true;
			this.m_clientWorld.ShowWorld(true);
			this.m_clientWorld.WorldCamera.EnableTouchMove(true);
			return base.OnResume(intent);
		}

		// Token: 0x06015267 RID: 86631 RVA: 0x00559084 File Offset: 0x00557284
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
			WorldUITask.StopSubUITask(typeof(WorldEventMissionUITask));
			WorldUITask.StopSubUITask(typeof(BuyEnergyUITask));
			WorldUITask.StopSubUITask(typeof(EnergyStatusUITask));
			WorldUITask.StopSubUITask(typeof(GetPathUITask));
			WorldUITask.StopSubUITask(typeof(AppScoreUITask));
			WorldUITask.StopSubUITask(typeof(MonthCardInfoUITask));
			WorldUITask.StopSubUITask(typeof(DialogUITask));
			WorldUITask.StopSubUITask(typeof(GoddessDialogUITask));
			WorldUITask.StopSubUITask(typeof(HeroListUITask));
			WorldUITask.StopSubUITask(typeof(HeroJobTransferUITask));
			WorldUITask.StopSubUITask(typeof(HeroCommentUITask));
			WorldUITask.StopSubUITask(typeof(EquipmentDepotUITask));
			WorldUITask.StopSubUITask(typeof(EquipmentForgeUITask));
			WorldUITask.StopSubUITask(typeof(BagListUITask));
			WorldUITask.StopSubUITask(typeof(BagFullUITask));
			WorldUITask.StopSubUITask(typeof(MissionUITask));
			WorldUITask.StopSubUITask(typeof(SelectCardUITask));
			WorldUITask.StopSubUITask(typeof(HeroBreakEffectUITask));
			WorldUITask.StopSubUITask(typeof(HeroBreakRarityUpUITask));
			WorldUITask.StopSubUITask(typeof(StoreUITask));
			WorldUITask.StopSubUITask(typeof(FriendUITask));
			WorldUITask.StopSubUITask(typeof(FettersUITask));
			WorldUITask.StopSubUITask(typeof(DrillUITask));
			WorldUITask.StopSubUITask(typeof(HeroSoldierSkinUITask));
			WorldUITask.StopSubUITask(typeof(GuildUITask));
			WorldUITask.StopSubUITask(typeof(GuildManagementUITask));
			WorldUITask.StopSubUITask(typeof(GuildGameListUITask));
			WorldUITask.StopSubUITask(typeof(GuildRaidUITask));
			WorldUITask.StopSubUITask(typeof(GuildMassiveCombatUITask));
			WorldUITask.StopSubUITask(typeof(GuildStoreUITask));
			WorldUITask.StopSubUITask(typeof(NormalItemBuyUITask));
			WorldUITask.StopSubUITask(typeof(RiftUITask));
			WorldUITask.StopSubUITask(typeof(BattleLevelInfoUITask));
			WorldUITask.StopSubUITask(typeof(RaidLevelUITask));
			WorldUITask.StopSubUITask(typeof(HeroDungeonUITask));
			WorldUITask.StopSubUITask(typeof(UnchartedUITask));
			WorldUITask.StopSubUITask(typeof(ThearchyUITask));
			WorldUITask.StopSubUITask(typeof(AnikiUITask));
			WorldUITask.StopSubUITask(typeof(TreasureMapUITask));
			WorldUITask.StopSubUITask(typeof(MemoryCorridorUITask));
			WorldUITask.StopSubUITask(typeof(HeroTrainningUITask));
			WorldUITask.StopSubUITask(typeof(HeroPhantomUITask));
			WorldUITask.StopSubUITask(typeof(CooperateBattleUITask));
			WorldUITask.StopSubUITask(typeof(UnchartedScoreUITask));
			WorldUITask.StopSubUITask(typeof(ClimbTowerUITask));
			WorldUITask.StopSubUITask(typeof(ClimbTowerLevelInfoUITask));
			WorldUITask.StopSubUITask(typeof(ClimbTowerRaidUITask));
			WorldUITask.StopSubUITask(typeof(TeamUITask));
			WorldUITask.StopSubUITask(typeof(TeamRoomInfoUITask));
			WorldUITask.StopSubUITask(typeof(TeamRoomInviteUITask));
			WorldUITask.StopSubUITask(typeof(ArenaSelectUITask));
			WorldUITask.StopSubUITask(typeof(ArenaUITask));
			WorldUITask.StopSubUITask(typeof(ArenaDefendUITask));
			WorldUITask.StopSubUITask(typeof(OpenServiceActivityUITask));
			WorldUITask.StopSubUITask(typeof(ActivityUITask));
			WorldUITask.StopSubUITask(typeof(RaffleUITask));
			WorldUITask.StopSubUITask(typeof(PlayerInfoUITask));
			WorldUITask.StopSubUITask(typeof(MailUITask));
			WorldUITask.StopSubUITask(typeof(WaitPVPInviteUITask));
			WorldUITask.StopSubUITask(typeof(RankingUITask));
			WorldUITask.StopSubUITask(typeof(SignUITask));
			WorldUITask.StopSubUITask(typeof(TestUITask));
			WorldUITask.StopSubUITask(typeof(ActivityNoticeUITask));
			WorldUITask.StopSubUITask(typeof(ARUITask));
			WorldUITask.StopSubUITask(typeof(ArchiveUITask));
			WorldUITask.StopSubUITask(typeof(UserGuideUITask));
			WorldUITask.StopSubUITask(typeof(UserGuideDialogUITask));
			WorldUITask.StopSubUITask(typeof(PlayerSettingUITask));
			WorldUITask.StopSubUITask(typeof(PlayerLevelUpUITask));
			WorldUITask.StopSubUITask(typeof(PlayerSimpleInfoUITask));
			WorldUITask.StopSubUITask(typeof(BusinessCardUITask));
			WorldUITask.StopSubUITask(typeof(ChestUITask));
			WorldUITask.StopSubUITask(typeof(GetRewardGoodsUITask));
			WorldUITask.StopSubUITask(typeof(InstructionUITask));
			WorldUITask.StopSubUITask(typeof(RewardGoodsDescUITask));
			WorldUITask.StopSubUITask(typeof(HeroSkinChangeUITask));
			WorldUITask.StopSubUITask(typeof(StoreSoldierSkinDetailUITask));
			this.DestroyClientWorld();
			WorldUITask.s_instance = null;
			base.OnStop();
		}

		// Token: 0x06015268 RID: 86632 RVA: 0x0055957C File Offset: 0x0055777C
		private static void StopSubUITask(Type taskType)
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(taskType);
			if (uitaskBase != null)
			{
				uitaskBase.Stop();
			}
		}

		// Token: 0x06015269 RID: 86633 RVA: 0x0055959C File Offset: 0x0055779C
		protected override void HideAllView()
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
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase != null && sceneLayerBase.State == SceneLayerBase.LayerState.InStack && sceneLayerBase != this.MainLayer)
				{
					SceneManager.Instance.PopLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x0601526A RID: 86634 RVA: 0x00559668 File Offset: 0x00557868
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
			if (this.m_worldUIController == null || this.m_clientWorld == null)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			this.m_clientWorld.Tick(deltaTime);
			this.m_worldUIController.SetFog(this.m_clientWorld.WorldCamera.GetZoomFactor());
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.OnSlowTick();
			}
			if (this.m_isResumeNeedNextWorldStep)
			{
				this.m_isResumeNeedNextWorldStep = false;
				this.NextWorldStep(true);
			}
		}

		// Token: 0x0601526B RID: 86635 RVA: 0x00559758 File Offset: 0x00557958
		private void InitWorldMapUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitWorldMapUIController_hotfix != null)
			{
				this.m_InitWorldMapUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldMapUIController == null)
			{
				this.m_worldMapUIController = GameObjectUtility.AddControllerToGameObject<WorldMapUIController>(Utility.FindChildGameObject(this.MainLayer.LayerPrefabRoot, "Canvas/WorldMapHitImage", true));
				this.m_worldMapUIController.EventOnPointerDown += this.WorldMapUIController_OnPointerDown;
				this.m_worldMapUIController.EventOnPointerUp += this.WorldMapUIController_OnPointerUp;
				this.m_worldMapUIController.EventOnClick += this.WorldMapUIController_OnPointerClick;
			}
		}

		// Token: 0x0601526C RID: 86636 RVA: 0x00559830 File Offset: 0x00557A30
		private void UninitWorldMapUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitWorldMapUIController_hotfix != null)
			{
				this.m_UninitWorldMapUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldMapUIController != null)
			{
				this.m_worldMapUIController.EventOnPointerDown -= this.WorldMapUIController_OnPointerDown;
				this.m_worldMapUIController.EventOnPointerUp -= this.WorldMapUIController_OnPointerUp;
				this.m_worldMapUIController.EventOnClick -= this.WorldMapUIController_OnPointerClick;
				this.m_worldMapUIController = null;
			}
		}

		// Token: 0x0601526D RID: 86637 RVA: 0x005598F0 File Offset: 0x00557AF0
		private void InitWorldUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitWorldUIController_hotfix != null)
			{
				this.m_InitWorldUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_worldUIController = (this.m_uiCtrlArray[0] as WorldUIController);
					WorldUITask.s_isShowWorldUI = true;
				}
				if (!(this.m_worldUIController != null))
				{
					global::Debug.LogError("WorldUIController is null");
					return;
				}
				this.m_worldUIController.EventOnShowMainButtonBar += this.WorldUIController_OnShowMainButtonBar;
				this.m_worldUIController.EventOnShowPlayerInfo += this.WorldUIController_OnShowPlayerInfo;
				this.m_worldUIController.EventOnCompass += this.WorldUIController_OnCompass;
				this.m_worldUIController.EventOnCurrentScenario += this.WorldUIController_OnCurrentScenario;
				this.m_worldUIController.EventOnUnlockScenarioGotoRiftLevel += this.WorldUIController_OnUnlockScenarioGotoRiftLevel;
				this.m_worldUIController.EventOnGotoEvent += this.WorldUIController_OnGotoEvent;
				this.m_worldUIController.EventOnStartPastScenario += this.WorldUIController_OnStartPastScenario;
				this.m_worldUIController.EventOnClosePastScenarioList += this.WorldUIController_OnClosePastScenarioList;
				this.m_worldUIController.EventOnShowHero += this.WorldUIController_OnShowHero;
				this.m_worldUIController.EventOnShowBag += this.WorldUIController_OnShowBag;
				this.m_worldUIController.EventOnShowMisision += this.WorldUIController_OnShowMission;
				this.m_worldUIController.EventOnShowFetter += this.WorldUIController_OnShowFetter;
				this.m_worldUIController.EventOnShowStore += this.WorldUIController_OnShowStore;
				this.m_worldUIController.EventOnShowSelectCard += this.WorldUIController_OnShowSelectCard;
				this.m_worldUIController.EventOnShowDrill += this.WorldUIController_OnShowDrill;
				this.m_worldUIController.EventOnShowFriend += this.WorldUIController_OnShowFriend;
				this.m_worldUIController.EventOnShowGuild += this.WorldUIController_OnShowGuild;
				this.m_worldUIController.EventOnShowEvent += this.WorldUIController_OnShowEvent;
				this.m_worldUIController.EventOnShowUncharted += this.WorldUIController_OnShowUncharted;
				this.m_worldUIController.EventOnShowArena += this.WorldUIController_OnShowArena;
				this.m_worldUIController.EventOnShowRift += this.WorldUIController_OnShowRift;
				this.m_worldUIController.EventOnShowTest += this.WorldUIController_OnShowTest;
				this.m_worldUIController.EventOnShowCooperateBattle += this.WorldUIController_OnShowCooperateBattle;
				this.m_worldUIController.EventOnShowMail += this.WorldUIController_OnShowMail;
				this.m_worldUIController.EventOnShowChat += this.WorldUIController_OnShowChat;
				this.m_worldUIController.EventOnShowRanking += this.WorldUIController_OnShowRanking;
				this.m_worldUIController.EventOnShowAnnouncement += this.WorldUIController_OnShowActivity;
				this.m_worldUIController.EventOnOpenWebInvestigation += this.WorldUIController_OnOpenWebInvestigation;
				this.m_worldUIController.EventOnShowOpenServiceActivity += this.WorldUIController_OnShowOpenServiceActivity;
				this.m_worldUIController.EventOnYYBButtonClick += this.WorldUIController_OnYYBButtonClick;
				this.m_worldUIController.EventOnOppoButtonClick += this.WorldUIController_OnOppoButtonClick;
				this.m_worldUIController.EventOnMonthCardButtonClick += this.WorldUIController_OnMonthCardButtonClick;
				this.m_worldUIController.EventOnRefreshMonthCardPanel += this.WorldUIController_OnRefreshMonthCardPanel;
				this.m_worldUIController.EventOnMonthCardItemClick += this.WorldUIController_OnMonthCardItemClick;
				this.m_worldUIController.EventOnMonthCardItemBuyClick += this.WorldUIController_OnMonthCardItemBuyClick;
				PDSDK.m_eventDoQuestionSucceed = new Action(this.PDSDK_OnDoQuestionSucceed);
				PDSDK.m_eventDoQuestionFailed = new Action(this.PDSDK_OnDoQuestionFailed);
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					projectLPlayerContext.EventOnFriendInviteAcceptNtf += this.PlayerContext_OnFriendInviteAcceptNtf;
					projectLPlayerContext.EventOnChatMessageNtf += this.PlayerContext_OnChatMessageNtf;
					projectLPlayerContext.EventOnTeamRoomInviteNtf += this.PlayerContext_OnTeamRoomInviteNtf;
					projectLPlayerContext.EventOnBattlePracticeInvitedNtf += this.PlayerContext_OnBattlePracticeInvitedNtf;
					projectLPlayerContext.EventOnBattleRoomTeamBattleJoinNtf += this.PlayerContext_OnBattleRoomTeamBattleJoinNtf;
					projectLPlayerContext.EventOnBattleRoomPVPBattleJoinNtf += this.PlayerContext_OnBattleRoomPVPBattleJoinNtf;
					projectLPlayerContext.EventOnBattleRoomRealTimePVPBattleJoinNtf += this.PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf;
					projectLPlayerContext.EventOnBattleRoomGuildMassiveCombatBattleJoinNtf += this.PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf;
					projectLPlayerContext.EventOnPlayerInfoInitEnd += this.PlayerContext_OnPlayerInfoInitEnd;
				}
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
				this.m_playerResourceUIController.EventOnAddGold += this.PlayerResourceUIController_OnAddGold;
				this.m_playerResourceUIController.EventOnAddCrystal += this.PlayerResourceUIController_OnAddCrystal;
			}
		}

		// Token: 0x0601526E RID: 86638 RVA: 0x00559E2C File Offset: 0x0055802C
		private void UninitWorldUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitWorldUIController_hotfix != null)
			{
				this.m_UninitWorldUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldUIController != null)
			{
				this.m_worldUIController.EventOnShowMainButtonBar -= this.WorldUIController_OnShowMainButtonBar;
				this.m_worldUIController.EventOnShowPlayerInfo -= this.WorldUIController_OnShowPlayerInfo;
				this.m_worldUIController.EventOnCompass -= this.WorldUIController_OnCompass;
				this.m_worldUIController.EventOnCurrentScenario -= this.WorldUIController_OnCurrentScenario;
				this.m_worldUIController.EventOnUnlockScenarioGotoRiftLevel -= this.WorldUIController_OnUnlockScenarioGotoRiftLevel;
				this.m_worldUIController.EventOnGotoEvent -= this.WorldUIController_OnGotoEvent;
				this.m_worldUIController.EventOnStartPastScenario -= this.WorldUIController_OnStartPastScenario;
				this.m_worldUIController.EventOnClosePastScenarioList -= this.WorldUIController_OnClosePastScenarioList;
				this.m_worldUIController.EventOnShowHero -= this.WorldUIController_OnShowHero;
				this.m_worldUIController.EventOnShowBag -= this.WorldUIController_OnShowBag;
				this.m_worldUIController.EventOnShowMisision -= this.WorldUIController_OnShowMission;
				this.m_worldUIController.EventOnShowFetter -= this.WorldUIController_OnShowFetter;
				this.m_worldUIController.EventOnShowStore -= this.WorldUIController_OnShowStore;
				this.m_worldUIController.EventOnShowSelectCard -= this.WorldUIController_OnShowSelectCard;
				this.m_worldUIController.EventOnShowDrill -= this.WorldUIController_OnShowDrill;
				this.m_worldUIController.EventOnShowFriend -= this.WorldUIController_OnShowFriend;
				this.m_worldUIController.EventOnShowGuild += this.WorldUIController_OnShowGuild;
				this.m_worldUIController.EventOnShowEvent -= this.WorldUIController_OnShowEvent;
				this.m_worldUIController.EventOnShowUncharted -= this.WorldUIController_OnShowUncharted;
				this.m_worldUIController.EventOnShowArena -= this.WorldUIController_OnShowArena;
				this.m_worldUIController.EventOnShowRift -= this.WorldUIController_OnShowRift;
				this.m_worldUIController.EventOnShowTest -= this.WorldUIController_OnShowTest;
				this.m_worldUIController.EventOnShowMail -= this.WorldUIController_OnShowMail;
				this.m_worldUIController.EventOnShowChat -= this.WorldUIController_OnShowChat;
				this.m_worldUIController.EventOnShowAnnouncement -= this.WorldUIController_OnShowActivity;
				this.m_worldUIController.EventOnOpenWebInvestigation -= this.WorldUIController_OnOpenWebInvestigation;
				this.m_worldUIController.EventOnShowOpenServiceActivity -= this.WorldUIController_OnShowOpenServiceActivity;
				this.m_worldUIController.EventOnMonthCardButtonClick -= this.WorldUIController_OnMonthCardButtonClick;
				this.m_worldUIController.EventOnRefreshMonthCardPanel -= this.WorldUIController_OnRefreshMonthCardPanel;
				this.m_worldUIController.EventOnMonthCardItemClick -= this.WorldUIController_OnMonthCardItemClick;
				this.m_worldUIController.EventOnMonthCardItemBuyClick -= this.WorldUIController_OnMonthCardItemBuyClick;
				this.m_worldUIController.EventOnYYBButtonClick -= this.WorldUIController_OnYYBButtonClick;
				this.m_worldUIController.EventOnOppoButtonClick -= this.WorldUIController_OnOppoButtonClick;
				this.m_worldUIController = null;
				PDSDK.m_eventDoQuestionSucceed = null;
				PDSDK.m_eventDoQuestionFailed = null;
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					projectLPlayerContext.EventOnFriendInviteAcceptNtf -= this.PlayerContext_OnFriendInviteAcceptNtf;
					projectLPlayerContext.EventOnChatMessageNtf -= this.PlayerContext_OnChatMessageNtf;
					projectLPlayerContext.EventOnTeamRoomInviteNtf -= this.PlayerContext_OnTeamRoomInviteNtf;
					projectLPlayerContext.EventOnBattlePracticeInvitedNtf -= this.PlayerContext_OnBattlePracticeInvitedNtf;
					projectLPlayerContext.EventOnBattleRoomTeamBattleJoinNtf -= this.PlayerContext_OnBattleRoomTeamBattleJoinNtf;
					projectLPlayerContext.EventOnBattleRoomPVPBattleJoinNtf -= this.PlayerContext_OnBattleRoomPVPBattleJoinNtf;
					projectLPlayerContext.EventOnBattleRoomRealTimePVPBattleJoinNtf -= this.PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf;
					projectLPlayerContext.EventOnBattleRoomGuildMassiveCombatBattleJoinNtf -= this.PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf;
					projectLPlayerContext.EventOnPlayerInfoInitEnd -= this.PlayerContext_OnPlayerInfoInitEnd;
				}
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController.EventOnAddGold -= this.PlayerResourceUIController_OnAddGold;
				this.m_playerResourceUIController.EventOnAddCrystal -= this.PlayerResourceUIController_OnAddCrystal;
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x0601526F RID: 86639 RVA: 0x0055A2A8 File Offset: 0x005584A8
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
				this.m_worldUIController.ShowOrHide(WorldUITask.s_isShowWorldUI);
				InviteNotifyUITask.CheckPendingInviteInfo();
			}
			this.m_worldUIController.ShowMainButtonBar(WorldUITask.s_showMainButtonBar && WorldUITask.s_isShowWorldUI);
			if (this.m_clientWorld == null)
			{
				this.CreateClientWorld();
				Shader.WarmupAllShaders();
				this.CheckInBattleRoom();
			}
			if (this.m_isResuming)
			{
				this.m_isResuming = false;
				this.m_isResumeNeedNextWorldStep = true;
				this.m_clientWorld.UpdateEventActorState();
			}
			this.UpdatePlayerInfo();
			this.UpdateCurrentScenario();
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.UpdateRedMarks();
			this.UpdateMonthCardInfo();
			if (this.m_clientWorld != null)
			{
				this.m_clientWorld.OnPlayerIconUpdate();
			}
		}

		// Token: 0x06015270 RID: 86640 RVA: 0x0055A3C0 File Offset: 0x005585C0
		private void UpdateRedMarks()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRedMarks_hotfix != null)
			{
				this.m_UpdateRedMarks_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateNewMailCount();
			this.UpdateNewChatCount();
			this.UpdateHeroRedMark();
			this.UpdateWorldEventRedMark();
			this.UpdateMissionRedMark();
			this.UpdateActivityRedMark();
			this.UpdateFriendRedMark();
			this.UpdateInvestigationButton();
			this.UpdateCooperateBattleButton();
			this.UpdateOpenServiceActivityButton();
			this.UpdateDrillRedMark();
			this.UpdateFetterRedMark();
		}

		// Token: 0x06015271 RID: 86641 RVA: 0x0055A468 File Offset: 0x00558668
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.SetPlayerName(projectLPlayerContext.GetPlayerName());
			this.m_worldUIController.SetPlayerLevel(projectLPlayerContext.GetPlayerLevel());
			this.m_worldUIController.SetPlayerVip(projectLPlayerContext.GetPlayerVip());
			this.m_worldUIController.SetPlayerExp(projectLPlayerContext.GetPlayerExp(), projectLPlayerContext.GetPlayerNextLevelExp());
			this.m_worldUIController.SetPlayerHeadIcon(projectLPlayerContext.GetPlayerHeadIcon());
		}

		// Token: 0x06015272 RID: 86642 RVA: 0x0055A534 File Offset: 0x00558734
		private void UpdateCurrentScenario()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCurrentScenario_hotfix != null)
			{
				this.m_UpdateCurrentScenario_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataScenarioInfo currentScenarioInfo = projectLPlayerContext.GetCurrentScenarioInfo();
			this.m_worldUIController.SetCurrentScenario(currentScenarioInfo);
		}

		// Token: 0x06015273 RID: 86643 RVA: 0x0055A5B8 File Offset: 0x005587B8
		private void UpdateHeroRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroRedMark_hotfix != null)
			{
				this.m_UpdateHeroRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.ShowHeroRedMark(projectLPlayerContext.IsWorldHeroTabShowRedIcon());
		}

		// Token: 0x06015274 RID: 86644 RVA: 0x0055A63C File Offset: 0x0055883C
		private void UpdateMissionRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMissionRedMark_hotfix != null)
			{
				this.m_UpdateMissionRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.ShowMissionRedMark(projectLPlayerContext.IsExistMissionCompleted());
		}

		// Token: 0x06015275 RID: 86645 RVA: 0x0055A6C0 File Offset: 0x005588C0
		private void UpdateActivityRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateActivityRedMark_hotfix != null)
			{
				this.m_UpdateActivityRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.ShowActivityRedMark(projectLPlayerContext.IsActivityRedPointShow());
		}

		// Token: 0x06015276 RID: 86646 RVA: 0x0055A744 File Offset: 0x00558944
		private void UpdateFriendRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFriendRedMark_hotfix != null)
			{
				this.m_UpdateFriendRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.ShowFriendRedMark(projectLPlayerContext.IsFriendRedMarkShow());
		}

		// Token: 0x06015277 RID: 86647 RVA: 0x0055A7C8 File Offset: 0x005589C8
		private void UpdateDrillRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDrillRedMark_hotfix != null)
			{
				this.m_UpdateDrillRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = false;
			IEnumerable<KeyValuePair<int, ConfigDataTrainingRoomInfo>> allConfigDataTrainingRoomInfo = this.m_configDataLoader.GetAllConfigDataTrainingRoomInfo();
			foreach (KeyValuePair<int, ConfigDataTrainingRoomInfo> keyValuePair in allConfigDataTrainingRoomInfo)
			{
				int id = keyValuePair.Value.ID;
				TrainingRoom trainingRoomById = projectLPlayerContext.GetTrainingRoomById(id);
				if (projectLPlayerContext.CanTrainingRoomLevelup(trainingRoomById))
				{
					flag = true;
					break;
				}
			}
			this.m_worldUIController.ShowDrillRedMark(flag || projectLPlayerContext.HaveFinishedAssistantTask());
		}

		// Token: 0x06015278 RID: 86648 RVA: 0x0055A8D4 File Offset: 0x00558AD4
		private void UpdateFetterRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFetterRedMark_hotfix != null)
			{
				this.m_UpdateFetterRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool show = projectLPlayerContext.IsShowFetterRedMark();
			this.m_worldUIController.ShowFetterRedMark(show);
		}

		// Token: 0x06015279 RID: 86649 RVA: 0x0055A958 File Offset: 0x00558B58
		private void UpdateGuildRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGuildRedMark_hotfix != null)
			{
				this.m_UpdateGuildRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool show = false;
			string guildId = projectLPlayerContext.GetGuildId();
			if (string.IsNullOrEmpty(guildId))
			{
				show = (projectLPlayerContext.GetGuildJoinInvitationList().Count > 0);
			}
			else
			{
				Guild guildInfo = projectLPlayerContext.GetGuildInfo();
				if (guildInfo != null)
				{
					show = (!guildInfo.IsMemberFull && projectLPlayerContext.GetGuildJoinApplyList().Count > 0);
				}
			}
			this.m_worldUIController.ShowGuildRedMark(show);
		}

		// Token: 0x0601527A RID: 86650 RVA: 0x0055AA2C File Offset: 0x00558C2C
		private void UpdateWorldEventRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateWorldEventRedMark_hotfix != null)
			{
				this.m_UpdateWorldEventRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_worldUIController.ShowEventRedMark(this.HasRandomEvent());
		}

		// Token: 0x0601527B RID: 86651 RVA: 0x0055AAA0 File Offset: 0x00558CA0
		private void UpdateInvestigationButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateInvestigationButton_hotfix != null)
			{
				this.m_UpdateInvestigationButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_worldUIController.UpdateInvestigationButton();
		}

		// Token: 0x0601527C RID: 86652 RVA: 0x0055AB0C File Offset: 0x00558D0C
		private void UpdateOpenServiceActivityButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOpenServiceActivityButton_hotfix != null)
			{
				this.m_UpdateOpenServiceActivityButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_worldUIController.UpdateOpenServiceActivityButton();
		}

		// Token: 0x0601527D RID: 86653 RVA: 0x0055AB78 File Offset: 0x00558D78
		private void UpdateCooperateBattleButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCooperateBattleButton_hotfix != null)
			{
				this.m_UpdateCooperateBattleButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = null;
			if (projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_CooperateBattle))
			{
				configDataCooperateBattleInfo = projectLPlayerContext.GetFirstOpenedCooperateBattle();
			}
			this.m_worldUIController.ShowCooperateBattleButton(configDataCooperateBattleInfo != null);
		}

		// Token: 0x0601527E RID: 86654 RVA: 0x0055AC10 File Offset: 0x00558E10
		private void UpdateMonthCardInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMonthCardInfo_hotfix != null)
			{
				this.m_UpdateMonthCardInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.UpdateMonthCardOpen(projectLPlayerContext.HasValidMonthCards());
		}

		// Token: 0x0601527F RID: 86655 RVA: 0x0055AC94 File Offset: 0x00558E94
		private void OnSlowTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSlowTick_hotfix != null)
			{
				this.m_OnSlowTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateActivityRedMark();
			this.UpdateCooperateBattleButton();
			this.UpdateDrillRedMark();
			this.UpdateGuildRedMark();
		}

		// Token: 0x06015280 RID: 86656 RVA: 0x0055AD0C File Offset: 0x00558F0C
		private void ShowEventList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEventList_hotfix != null)
			{
				this.m_ShowEventList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientWorld == null)
			{
				return;
			}
			this.m_worldUIController.ClearRandomEventList();
			foreach (ClientWorldEventActor clientWorldEventActor in this.m_clientWorld.GetEventActors())
			{
				if (clientWorldEventActor.RandomEvent != null)
				{
					this.m_worldUIController.AddRandomEvent(clientWorldEventActor.LocateWaypointInfo, clientWorldEventActor.RandomEvent);
				}
			}
			this.m_worldUIController.ShowEventList();
		}

		// Token: 0x06015281 RID: 86657 RVA: 0x0055AE00 File Offset: 0x00559000
		private bool HasRandomEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasRandomEvent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasRandomEvent_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldEventActor clientWorldEventActor in this.m_clientWorld.GetEventActors())
			{
				if (clientWorldEventActor.RandomEvent != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06015282 RID: 86658 RVA: 0x0055AED0 File Offset: 0x005590D0
		private void UpdateNewChatCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateNewChatCount_hotfix != null)
			{
				this.m_UpdateNewChatCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.GetGroupUnreadChatMsgCount();
			num += projectLPlayerContext.GetPrivateUnreadChatMsgCount();
			this.m_worldUIController.UpdateNewChatCount(num);
		}

		// Token: 0x06015283 RID: 86659 RVA: 0x0055AF60 File Offset: 0x00559160
		private void UpdateNewMailCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateNewMailCount_hotfix != null)
			{
				this.m_UpdateNewMailCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int unReadMailCount = projectLPlayerContext.GetUnReadMailCount();
			this.m_worldUIController.UpdateUnreadMailCount(unReadMailCount);
		}

		// Token: 0x06015284 RID: 86660 RVA: 0x0055AFE4 File Offset: 0x005591E4
		private void CreateClientWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateClientWorld_hotfix != null)
			{
				this.m_CreateClientWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientWorld == null)
			{
				this.m_clientWorld = new ClientWorld();
				this.m_clientWorld.Initialize(this, this.MainLayer.LayerPrefabRoot);
				CommonUIController.Instance.TestUI.InitializeWorld(this.m_clientWorld);
			}
			this.StartClientWorld();
		}

		// Token: 0x06015285 RID: 86661 RVA: 0x0055B08C File Offset: 0x0055928C
		private void DestroyClientWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyClientWorld_hotfix != null)
			{
				this.m_DestroyClientWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientWorld != null)
			{
				this.m_clientWorld.Dispose();
				this.m_clientWorld = null;
				CommonUIController.Instance.TestUI.UninitializeWorld();
			}
		}

		// Token: 0x06015286 RID: 86662 RVA: 0x0055B118 File Offset: 0x00559318
		private void StartClientWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClientWorld_hotfix != null)
			{
				this.m_StartClientWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataWorldMapInfo currentWorldMapInfo = projectLPlayerContext.GetCurrentWorldMapInfo();
			this.m_clientWorld.Start(currentWorldMapInfo);
			this.NextWorldStep(true);
		}

		// Token: 0x06015287 RID: 86663 RVA: 0x0055B1A4 File Offset: 0x005593A4
		private void NextWorldStep(bool checkWorldUIGetReady = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextWorldStepBoolean_hotfix != null)
			{
				this.m_NextWorldStepBoolean_hotfix.call(new object[]
				{
					this,
					checkWorldUIGetReady
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("WorldUITask.NextWorldStep");
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsProtagonistExist())
			{
				if (!LocalConfig.Instance.Data.IsFastEnterGame)
				{
					this.StartGoddessDialogUITask();
				}
				else
				{
					this.GoddessDialogUITask_OnClose(1);
				}
			}
			else if (!projectLPlayerContext.IsScenarioFinished(this.m_configDataLoader.ConfigableConstId_FirstScenarioId) && !LocalConfig.Instance.Data.IsFastEnterGame)
			{
				this.ClickFirstWaypoint();
			}
			else if (projectLPlayerContext.Happening.Step != HappeningStep.None)
			{
				this.NextHappeningStep();
			}
			else if (!this.CheckReturnToBeforeBattleUI())
			{
				if (checkWorldUIGetReady)
				{
					this.WorldUIGetReady();
				}
			}
		}

		// Token: 0x06015288 RID: 86664 RVA: 0x0055B2D0 File Offset: 0x005594D0
		private void WorldUIGetReady()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIGetReady_hotfix != null)
			{
				this.m_WorldUIGetReady_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("WorldUITask.WorldUIGetReady");
			this.CheckOpenRiftChapter();
			this.CheckOrderReward();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsDataError())
			{
				global::Debug.Log("DataError");
			}
			this.m_worldUIController.UpdateGameFunctionOpen();
			UserGuideUITask.OnWorldUIGetReady();
			PDSDK.Instance.printGameEventLog("34", string.Empty);
		}

		// Token: 0x06015289 RID: 86665 RVA: 0x0055B390 File Offset: 0x00559590
		private void ClickFirstWaypoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickFirstWaypoint_hotfix != null)
			{
				this.m_ClickFirstWaypoint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataWorldMapInfo currentWorldMapInfo = projectLPlayerContext.GetCurrentWorldMapInfo();
			this.OnWaypointClick(currentWorldMapInfo.m_startWaypointInfo);
		}

		// Token: 0x0601528A RID: 86666 RVA: 0x0055B414 File Offset: 0x00559614
		private void StartSetProtagonistNetTask(int protagonistId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartSetProtagonistNetTaskInt32_hotfix != null)
			{
				this.m_StartSetProtagonistNetTaskInt32_hotfix.call(new object[]
				{
					this,
					protagonistId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.FadeOut(0f, Color.white, null);
			SetProtagonistNetTask setProtagonistNetTask = new SetProtagonistNetTask(protagonistId);
			setProtagonistNetTask.EventOnStop += delegate(Task task)
			{
				SetProtagonistNetTask setProtagonistNetTask2 = task as SetProtagonistNetTask;
				if (setProtagonistNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(setProtagonistNetTask2.Result, 2f, null, true);
				}
				if (setProtagonistNetTask2.Result != -99)
				{
					base.ClearAssetList();
					this.CollectPlayerAssets();
					base.StartLoadCustomAssets(delegate
					{
						CommonUIController.Instance.FadeIn(0.5f, Color.white, null);
						this.UpdateView();
						this.NextWorldStep(true);
					});
				}
			};
			setProtagonistNetTask.Start(null);
		}

		// Token: 0x0601528B RID: 86667 RVA: 0x0055B4BC File Offset: 0x005596BC
		private void WorldUIController_OnShowMainButtonBar(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowMainButtonBarBoolean_hotfix != null)
			{
				this.m_WorldUIController_OnShowMainButtonBarBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			WorldUITask.s_showMainButtonBar = show;
		}

		// Token: 0x0601528C RID: 86668 RVA: 0x0055B534 File Offset: 0x00559734
		private void WorldUIController_OnShowPlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowPlayerInfo_hotfix != null)
			{
				this.m_WorldUIController_OnShowPlayerInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartPlayerInfoUITask();
		}

		// Token: 0x0601528D RID: 86669 RVA: 0x0055B59C File Offset: 0x0055979C
		private void WorldUIController_OnCompass()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnCompass_hotfix != null)
			{
				this.m_WorldUIController_OnCompass_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld.WorldCamera.SmoothLook(this.m_clientWorld.GetPlayerActor().Position, null);
		}

		// Token: 0x0601528E RID: 86670 RVA: 0x0055B620 File Offset: 0x00559820
		private void WorldUIController_OnCurrentScenario()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnCurrentScenario_hotfix != null)
			{
				this.m_WorldUIController_OnCurrentScenario_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataScenarioInfo currentScenarioInfo = projectLPlayerContext.GetCurrentScenarioInfo();
			if (currentScenarioInfo != null)
			{
				ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(currentScenarioInfo.Waypoint_ID);
				if (waypoint != null)
				{
					this.m_clientWorld.WorldCamera.SmoothLook(waypoint.Position, null);
				}
			}
		}

		// Token: 0x0601528F RID: 86671 RVA: 0x0055B6CC File Offset: 0x005598CC
		private void WorldUIController_OnUnlockScenarioGotoRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnUnlockScenarioGotoRiftLevelConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_WorldUIController_OnUnlockScenarioGotoRiftLevelConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					riftLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CanAttackRiftLevel(riftLevelInfo.ID) == 0)
			{
				this.StartRiftUITask(riftLevelInfo, true, false, null, null);
			}
			else
			{
				this.StartRiftUITask(riftLevelInfo, false, false, null, null);
			}
		}

		// Token: 0x06015290 RID: 86672 RVA: 0x0055B77C File Offset: 0x0055997C
		private void WorldUIController_OnGotoEvent(ConfigDataWaypointInfo waypointInfo, ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnGotoEventConfigDataWaypointInfoConfigDataEventInfo_hotfix != null)
			{
				this.m_WorldUIController_OnGotoEventConfigDataWaypointInfoConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo2,
					eventInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataWaypointInfo waypointInfo = waypointInfo2;
			ConfigDataEventInfo eventInfo = eventInfo2;
			WorldUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackEventWaypoint(waypointInfo.ID);
			if (num == 0)
			{
				this.m_worldUIController.HideEventList(delegate
				{
					ClientWorldWaypoint waypoint = $this.m_clientWorld.GetWaypoint(waypointInfo.ID);
					if (waypoint != null)
					{
						CommonUIController.Instance.EnableInput(false);
						$this.m_clientWorld.WorldCamera.SmoothLook(waypoint.Position, delegate
						{
							CommonUIController.Instance.EnableInput(true);
							$this.StartWaypointEvent(waypointInfo, null, eventInfo);
						});
					}
				});
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x06015291 RID: 86673 RVA: 0x0055B868 File Offset: 0x00559A68
		private void WorldUIController_OnStartPastScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnStartPastScenarioConfigDataScenarioInfo_hotfix != null)
			{
				this.m_WorldUIController_OnStartPastScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackScenario(scenarioInfo.ID);
			if (num == 0)
			{
				this.m_worldUIController.HidePastScenarioList();
				this.StartScenario(scenarioInfo, projectLPlayerContext.Happening.PrevWaypointInfo);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x06015292 RID: 86674 RVA: 0x0055B92C File Offset: 0x00559B2C
		private void WorldUIController_OnClosePastScenarioList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnClosePastScenarioList_hotfix != null)
			{
				this.m_WorldUIController_OnClosePastScenarioList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MoveToPrevWaypoint(false);
		}

		// Token: 0x06015293 RID: 86675 RVA: 0x0055B994 File Offset: 0x00559B94
		private void WorldUIController_OnShowEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowEvent_hotfix != null)
			{
				this.m_WorldUIController_OnShowEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasRandomEvent())
			{
				this.ShowEventList();
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_World_NoEvent, 2f, null, true);
			}
		}

		// Token: 0x06015294 RID: 86676 RVA: 0x0055BA20 File Offset: 0x00559C20
		private void WorldUIController_OnShowHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowHero_hotfix != null)
			{
				this.m_WorldUIController_OnShowHero_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartHeroUITask(null);
		}

		// Token: 0x06015295 RID: 86677 RVA: 0x0055BA88 File Offset: 0x00559C88
		private void WorldUIController_OnShowBag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowBag_hotfix != null)
			{
				this.m_WorldUIController_OnShowBag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBagUITask();
		}

		// Token: 0x06015296 RID: 86678 RVA: 0x0055BAF0 File Offset: 0x00559CF0
		private void WorldUIController_OnShowMission()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowMission_hotfix != null)
			{
				this.m_WorldUIController_OnShowMission_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartMissionUITask(null);
		}

		// Token: 0x06015297 RID: 86679 RVA: 0x0055BB58 File Offset: 0x00559D58
		private void WorldUIController_OnShowFetter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowFetter_hotfix != null)
			{
				this.m_WorldUIController_OnShowFetter_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Fetters))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_Fetters), 2f, null, true);
			}
			else
			{
				this.StartFettersUITask(null, null);
			}
		}

		// Token: 0x06015298 RID: 86680 RVA: 0x0055BBFC File Offset: 0x00559DFC
		private void WorldUIController_OnShowStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowStore_hotfix != null)
			{
				this.m_WorldUIController_OnShowStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartStoreUITask(StoreId.StoreId_None, null);
		}

		// Token: 0x06015299 RID: 86681 RVA: 0x0055BC64 File Offset: 0x00559E64
		private void WorldUIController_OnShowSelectCard()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowSelectCard_hotfix != null)
			{
				this.m_WorldUIController_OnShowSelectCard_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartSelectCardUITask(0, null);
		}

		// Token: 0x0601529A RID: 86682 RVA: 0x0055BCCC File Offset: 0x00559ECC
		private void WorldUIController_OnShowDrill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowDrill_hotfix != null)
			{
				this.m_WorldUIController_OnShowDrill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TrainingGround))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_TrainingGround), 2f, null, true);
			}
			else
			{
				this.StartDrillUITask(0, null);
			}
		}

		// Token: 0x0601529B RID: 86683 RVA: 0x0055BD70 File Offset: 0x00559F70
		private void WorldUIController_OnShowFriend()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowFriend_hotfix != null)
			{
				this.m_WorldUIController_OnShowFriend_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartFriendUITask(null);
		}

		// Token: 0x0601529C RID: 86684 RVA: 0x0055BDD8 File Offset: 0x00559FD8
		private void WorldUIController_OnShowGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowGuild_hotfix != null)
			{
				this.m_WorldUIController_OnShowGuild_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int value = this.m_configDataLoader.GetConfigDataConfigableConst(270).Value;
			if (this.m_playerContext.GetPlayerLevel() < value)
			{
				string text = this.m_configDataLoader.GetConfigDataStringTable(14004).Value;
				text = string.Format(text, value);
				CommonUIController.Instance.ShowMessage(text, 2f, null, true);
				return;
			}
			this.StartGuildUITask(null, false);
		}

		// Token: 0x0601529D RID: 86685 RVA: 0x0055BEA0 File Offset: 0x0055A0A0
		private void WorldUIController_OnShowUncharted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowUncharted_hotfix != null)
			{
				this.m_WorldUIController_OnShowUncharted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartUnchartedUITask(BattleType.None, 0, 0, null);
		}

		// Token: 0x0601529E RID: 86686 RVA: 0x0055BF0C File Offset: 0x0055A10C
		private void WorldUIController_OnShowArena()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowArena_hotfix != null)
			{
				this.m_WorldUIController_OnShowArena_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ArenaBattle))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_ArenaBattle), 2f, null, true);
			}
			else
			{
				this.StartArenaSelectUITask(ArenaUIType.None, false, null);
			}
		}

		// Token: 0x0601529F RID: 86687 RVA: 0x0055BFB0 File Offset: 0x0055A1B0
		private void WorldUIController_OnShowRift()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowRift_hotfix != null)
			{
				this.m_WorldUIController_OnShowRift_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartRiftUITask(null, false, true, null, null);
		}

		// Token: 0x060152A0 RID: 86688 RVA: 0x0055C01C File Offset: 0x0055A21C
		private void WorldUIController_OnShowTest()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowTest_hotfix != null)
			{
				this.m_WorldUIController_OnShowTest_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartTestUITask();
		}

		// Token: 0x060152A1 RID: 86689 RVA: 0x0055C084 File Offset: 0x0055A284
		private void WorldUIController_OnShowCooperateBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowCooperateBattle_hotfix != null)
			{
				this.m_WorldUIController_OnShowCooperateBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_CooperateBattle))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_CooperateBattle), 2f, null, true);
			}
			else
			{
				ConfigDataCooperateBattleInfo firstOpenedCooperateBattle = projectLPlayerContext.GetFirstOpenedCooperateBattle();
				if (firstOpenedCooperateBattle != null)
				{
					this.StartCooperateBattleUITask(firstOpenedCooperateBattle, null);
				}
			}
		}

		// Token: 0x060152A2 RID: 86690 RVA: 0x0055C134 File Offset: 0x0055A334
		private void WorldUIController_OnShowMail()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowMail_hotfix != null)
			{
				this.m_WorldUIController_OnShowMail_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartMailUITask();
		}

		// Token: 0x060152A3 RID: 86691 RVA: 0x0055C19C File Offset: 0x0055A39C
		private void WorldUIController_OnShowChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowChat_hotfix != null)
			{
				this.m_WorldUIController_OnShowChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUITask.StartChatUITaskWithNormalMode(this.m_currIntent);
		}

		// Token: 0x060152A4 RID: 86692 RVA: 0x0055C208 File Offset: 0x0055A408
		private void WorldUIController_OnShowRanking()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowRanking_hotfix != null)
			{
				this.m_WorldUIController_OnShowRanking_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartRankingUITask();
		}

		// Token: 0x060152A5 RID: 86693 RVA: 0x0055C270 File Offset: 0x0055A470
		private void WorldUIController_OnShowActivity()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowActivity_hotfix != null)
			{
				this.m_WorldUIController_OnShowActivity_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartActivityUITask(0);
		}

		// Token: 0x060152A6 RID: 86694 RVA: 0x0055C2D8 File Offset: 0x0055A4D8
		private void WorldUIController_OnShowOpenServiceActivity()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowOpenServiceActivity_hotfix != null)
			{
				this.m_WorldUIController_OnShowOpenServiceActivity_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartOpenServiceActivityUITask();
		}

		// Token: 0x060152A7 RID: 86695 RVA: 0x0055C340 File Offset: 0x0055A540
		private void WorldUIController_OnMonthCardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnMonthCardButtonClick_hotfix != null)
			{
				this.m_WorldUIController_OnMonthCardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_worldUIController.OpenMonthCardPanel(projectLPlayerContext.GetAllValidMonthCards());
		}

		// Token: 0x060152A8 RID: 86696 RVA: 0x0055C3C4 File Offset: 0x0055A5C4
		private void WorldUIController_OnRefreshMonthCardPanel(bool curIsOpenState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnRefreshMonthCardPanelBoolean_hotfix != null)
			{
				this.m_WorldUIController_OnRefreshMonthCardPanelBoolean_hotfix.call(new object[]
				{
					this,
					curIsOpenState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (curIsOpenState)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				this.m_worldUIController.OpenMonthCardPanel(projectLPlayerContext.GetAllValidMonthCards());
			}
		}

		// Token: 0x060152A9 RID: 86697 RVA: 0x0055C45C File Offset: 0x0055A65C
		private void WorldUIController_OnMonthCardItemClick(int cardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnMonthCardItemClickInt32_hotfix != null)
			{
				this.m_WorldUIController_OnMonthCardItemClickInt32_hotfix.call(new object[]
				{
					this,
					cardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MonthCardInfoUITask.StartUITask(cardId, this.m_currIntent);
		}

		// Token: 0x060152AA RID: 86698 RVA: 0x0055C4DC File Offset: 0x0055A6DC
		private void WorldUIController_OnMonthCardItemBuyClick(int cardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnMonthCardItemBuyClickInt32_hotfix != null)
			{
				this.m_WorldUIController_OnMonthCardItemBuyClickInt32_hotfix.call(new object[]
				{
					this,
					cardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGiftStoreItemInfo configDataGiftStoreItemInfo = null;
			foreach (KeyValuePair<int, ConfigDataGiftStoreItemInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataGiftStoreItemInfo())
			{
				ConfigDataGiftStoreItemInfo value = keyValuePair.Value;
				if (value.ItemType == GoodsType.GoodsType_MonthCard && value.ItemId == cardId)
				{
					if (UIUtility.IsIosSubscribe(value.IsAppleSubscribe))
					{
						ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
						if (projectLPlayerContext.GetMonthCardLeftTime(cardId).Ticks > 0L)
						{
							CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_StillInSubscribeTime, 2f, null, true);
							return;
						}
					}
					configDataGiftStoreItemInfo = value;
					break;
				}
			}
			if (configDataGiftStoreItemInfo != null)
			{
				StoreUITask.StartUITask(this.m_currIntent, configDataGiftStoreItemInfo.StoreId, new int?(configDataGiftStoreItemInfo.ID), false);
			}
		}

		// Token: 0x060152AB RID: 86699 RVA: 0x0055C638 File Offset: 0x0055A838
		private void WorldUIController_OnOpenWebInvestigation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnOpenWebInvestigation_hotfix != null)
			{
				this.m_WorldUIController_OnOpenWebInvestigation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			SurveyStatus currentSurveyStatus = projectLPlayerContext.GetCurrentSurveyStatus();
			if (currentSurveyStatus == SurveyStatus.UnOpen)
			{
				OpenSurveyNetTask openSurveyNetTask = new OpenSurveyNetTask();
				openSurveyNetTask.EventOnStop += delegate(Task task)
				{
					OpenSurveyNetTask openSurveyNetTask2 = task as OpenSurveyNetTask;
					if (openSurveyNetTask2.Result == 0)
					{
						PDSDK.Instance.OpenInvestigation(1);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(openSurveyNetTask2.Result, 2f, null, true);
					}
				};
				openSurveyNetTask.Start(null);
			}
			else if (currentSurveyStatus == SurveyStatus.Open)
			{
				PDSDK.Instance.OpenInvestigation(1);
			}
		}

		// Token: 0x060152AC RID: 86700 RVA: 0x0055C700 File Offset: 0x0055A900
		private void WorldUIController_OnYYBButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnYYBButtonClick_hotfix != null)
			{
				this.m_WorldUIController_OnYYBButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.doSetExtData(string.Empty, "YsdkForum");
		}

		// Token: 0x060152AD RID: 86701 RVA: 0x0055C778 File Offset: 0x0055A978
		private void WorldUIController_OnOppoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnOppoButtonClick_hotfix != null)
			{
				this.m_WorldUIController_OnOppoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.doSetExtData(string.Empty, "OppoForum");
		}

		// Token: 0x060152AE RID: 86702 RVA: 0x0055C7F0 File Offset: 0x0055A9F0
		private void PDSDK_OnDoQuestionSucceed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnDoQuestionSucceed_hotfix != null)
			{
				this.m_PDSDK_OnDoQuestionSucceed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanGainSurveyReward();
			if (num == 0)
			{
				GetSurveyRewardNetTask getSurveyRewardNetTask = new GetSurveyRewardNetTask();
				getSurveyRewardNetTask.EventOnStop += delegate(Task task)
				{
					GetSurveyRewardNetTask getSurveyRewardNetTask2 = task as GetSurveyRewardNetTask;
					if (getSurveyRewardNetTask2.Result == 0)
					{
						this.UpdateView();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(getSurveyRewardNetTask2.Result, 2f, null, true);
					}
				};
				getSurveyRewardNetTask.Start(null);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x060152AF RID: 86703 RVA: 0x0055C8A4 File Offset: 0x0055AAA4
		private void PDSDK_OnDoQuestionFailed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnDoQuestionFailed_hotfix != null)
			{
				this.m_PDSDK_OnDoQuestionFailed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateView();
		}

		// Token: 0x060152B0 RID: 86704 RVA: 0x0055C90C File Offset: 0x0055AB0C
		public void WorldUIController_OnShowSign()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowSign_hotfix != null)
			{
				this.m_WorldUIController_OnShowSign_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartSignUITask();
		}

		// Token: 0x060152B1 RID: 86705 RVA: 0x0055C974 File Offset: 0x0055AB74
		public void WorldUIController_OnShowActivityNotice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUIController_OnShowActivityNotice_hotfix != null)
			{
				this.m_WorldUIController_OnShowActivityNotice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartActivityNoticeUITask();
		}

		// Token: 0x060152B2 RID: 86706 RVA: 0x0055C9DC File Offset: 0x0055ABDC
		public static void WorldUIController_ShowHide(bool isShow, bool saveShowState = true)
		{
			if (WorldUITask.s_instance != null)
			{
				WorldUITask.s_instance.m_worldUIController.ShowOrHide(isShow);
			}
			if (saveShowState)
			{
				WorldUITask.s_isShowWorldUI = isShow;
			}
		}

		// Token: 0x060152B3 RID: 86707 RVA: 0x0055CA04 File Offset: 0x0055AC04
		public static void ShowWorld(bool show)
		{
			if (WorldUITask.s_instance != null)
			{
				WorldUITask.s_instance.m_clientWorld.ShowWorld(show);
			}
		}

		// Token: 0x060152B4 RID: 86708 RVA: 0x0055CA20 File Offset: 0x0055AC20
		private void GetRewardGoodsUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardGoodsUITask_OnStopTask_hotfix != null)
			{
				this.m_GetRewardGoodsUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_getRewardGoodsUITask == task)
			{
				this.m_getRewardGoodsUITask.EventOnStop -= this.GetRewardGoodsUITask_OnStop;
				this.m_getRewardGoodsUITask.EventOnClose -= this.GetRewardGoodsUITask_OnClose;
				this.m_getRewardGoodsUITask = null;
			}
		}

		// Token: 0x060152B5 RID: 86709 RVA: 0x0055CAD4 File Offset: 0x0055ACD4
		private void GetRewardGoodsUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardGoodsUITask_OnClose_hotfix != null)
			{
				this.m_GetRewardGoodsUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_getRewardGoodsUITask != null)
			{
				this.GetRewardGoodsUITask_OnStop(this.m_getRewardGoodsUITask);
			}
			this.UpdateView();
			this.CheckChangeCurrentScenario(false);
		}

		// Token: 0x060152B6 RID: 86710 RVA: 0x0055CB5C File Offset: 0x0055AD5C
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

		// Token: 0x060152B7 RID: 86711 RVA: 0x0055CC10 File Offset: 0x0055AE10
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
			this.CheckChangeCurrentScenario(false);
		}

		// Token: 0x060152B8 RID: 86712 RVA: 0x0055CC98 File Offset: 0x0055AE98
		private void WorldMapUIController_OnPointerDown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldMapUIController_OnPointerDown_hotfix != null)
			{
				this.m_WorldMapUIController_OnPointerDown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060152B9 RID: 86713 RVA: 0x0055CCF8 File Offset: 0x0055AEF8
		private void WorldMapUIController_OnPointerUp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldMapUIController_OnPointerUp_hotfix != null)
			{
				this.m_WorldMapUIController_OnPointerUp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060152BA RID: 86714 RVA: 0x0055CD58 File Offset: 0x0055AF58
		private void WorldMapUIController_OnPointerClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldMapUIController_OnPointerClick_hotfix != null)
			{
				this.m_WorldMapUIController_OnPointerClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060152BB RID: 86715 RVA: 0x0055CDB8 File Offset: 0x0055AFB8
		private void PlayerResourceUIController_OnAddGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerResourceUIController_OnAddGold_hotfix != null)
			{
				this.m_PlayerResourceUIController_OnAddGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this._StartGetPathTargetUITask(new GetPathData
			{
				PathType = GetPathType.GetPathType_Store2
			}, this.m_currIntent, null);
		}

		// Token: 0x060152BC RID: 86716 RVA: 0x0055CE34 File Offset: 0x0055B034
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
			this._StartGetPathTargetUITask(new GetPathData
			{
				PathType = GetPathType.GetPathType_Store5
			}, this.m_currIntent, null);
		}

		// Token: 0x060152BD RID: 86717 RVA: 0x0055CEB0 File Offset: 0x0055B0B0
		private void PlayerContext_OnMailsChangedNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnMailsChangedNtf_hotfix != null)
			{
				this.m_PlayerContext_OnMailsChangedNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateNewMailCount();
		}

		// Token: 0x060152BE RID: 86718 RVA: 0x0055CF18 File Offset: 0x0055B118
		private void PlayerContext_OnFriendInviteNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnFriendInviteNtf_hotfix != null)
			{
				this.m_PlayerContext_OnFriendInviteNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateFriendRedMark();
		}

		// Token: 0x060152BF RID: 86719 RVA: 0x0055CF80 File Offset: 0x0055B180
		private void PlayerContext_OnFriendInviteAcceptNtf(UserSummary userSummy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnFriendInviteAcceptNtfUserSummary_hotfix != null)
			{
				this.m_PlayerContext_OnFriendInviteAcceptNtfUserSummary_hotfix.call(new object[]
				{
					this,
					userSummy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string txt = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_FriendInviteAccept), userSummy.Name);
			CommonUIController.Instance.ShowMessage(txt, 2f, null, false);
		}

		// Token: 0x060152C0 RID: 86720 RVA: 0x0055D020 File Offset: 0x0055B220
		private void PlayerContext_OnFriendshipPointsReceivedNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnFriendshipPointsReceivedNtf_hotfix != null)
			{
				this.m_PlayerContext_OnFriendshipPointsReceivedNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateFriendRedMark();
		}

		// Token: 0x060152C1 RID: 86721 RVA: 0x0055D088 File Offset: 0x0055B288
		private void PlayerContext_EventOnGiftStoreBuyGoodsNtf(string OrderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_EventOnGiftStoreBuyGoodsNtfString_hotfix != null)
			{
				this.m_PlayerContext_EventOnGiftStoreBuyGoodsNtfString_hotfix.call(new object[]
				{
					this,
					OrderId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_currPipeLineCtx.m_isRuning)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x060152C2 RID: 86722 RVA: 0x0055D114 File Offset: 0x0055B314
		private void PlayerContext_OnChatMessageNtf(ChatMessage msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix != null)
			{
				this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsProtagonistExist())
			{
				return;
			}
			if (msg.ChatContentType != ChatContentType.EnterRoomInfo)
			{
				this.UpdateNewChatCount();
			}
			if (msg.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = msg as ChatTextMessage;
				if (msg.ChannelId == ChatChannel.Sys)
				{
					if (WorldUITask.s_instance.State == Task.TaskState.Paused)
					{
						NoticeUITask.StartUITask(chatTextMessage.Text, "InOther", msg.ChannelId, false);
					}
					else
					{
						NoticeUITask.StartUITask(chatTextMessage.Text, "InWorld", msg.ChannelId, false);
					}
				}
				else if (msg.ChannelId == ChatChannel.World)
				{
					if (WorldUITask.s_instance.State == Task.TaskState.Paused)
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatTextMessage.SrcName, chatTextMessage.Text), "InOther", msg.ChannelId, false);
					}
					else
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatTextMessage.SrcName, chatTextMessage.Text), "InWorld", msg.ChannelId, false);
					}
				}
				else if (msg.ChannelId == ChatChannel.Guild && msg.ChatSrcType == ChatSrcType.Player)
				{
					if (WorldUITask.s_instance.State == Task.TaskState.Paused)
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatTextMessage.SrcName, chatTextMessage.Text), "InOther", msg.ChannelId, false);
					}
					else
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatTextMessage.SrcName, chatTextMessage.Text), "InWorld", msg.ChannelId, false);
					}
				}
			}
			else if (msg.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = msg as ChatVoiceMessage;
				if (msg.ChannelId == ChatChannel.Sys)
				{
					if (WorldUITask.s_instance.State == Task.TaskState.Paused)
					{
						NoticeUITask.StartUITask(chatVoiceMessage.TranslateText, "InOther", msg.ChannelId, true);
					}
					else
					{
						NoticeUITask.StartUITask(chatVoiceMessage.TranslateText, "InWorld", msg.ChannelId, true);
					}
				}
				else if (msg.ChannelId == ChatChannel.World)
				{
					if (WorldUITask.s_instance.State == Task.TaskState.Paused)
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatVoiceMessage.SrcName, chatVoiceMessage.TranslateText), "InOther", msg.ChannelId, true);
					}
					else
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatVoiceMessage.SrcName, chatVoiceMessage.TranslateText), "InWorld", msg.ChannelId, true);
					}
				}
				else if (msg.ChannelId == ChatChannel.Guild && msg.ChatSrcType == ChatSrcType.Player)
				{
					if (WorldUITask.s_instance.State == Task.TaskState.Paused)
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatVoiceMessage.SrcName, chatVoiceMessage.TranslateText), "InOther", msg.ChannelId, true);
					}
					else
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatVoiceMessage.SrcName, chatVoiceMessage.TranslateText), "InWorld", msg.ChannelId, true);
					}
				}
			}
		}

		// Token: 0x060152C3 RID: 86723 RVA: 0x0055D460 File Offset: 0x0055B660
		private void PlayerContext_OnMailReadAck(int obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnMailReadAckInt32_hotfix != null)
			{
				this.m_PlayerContext_OnMailReadAckInt32_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateNewMailCount();
		}

		// Token: 0x060152C4 RID: 86724 RVA: 0x0055D4D8 File Offset: 0x0055B6D8
		private void PlayerContext_OnPlayerInfoChangeNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnPlayerInfoChangeNtf_hotfix != null)
			{
				this.m_PlayerContext_OnPlayerInfoChangeNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateRedMarks();
		}

		// Token: 0x060152C5 RID: 86725 RVA: 0x0055D540 File Offset: 0x0055B740
		private void PlayerContext_OnTeamRoomInviteNtf(TeamRoomInviteInfo inviteInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomInviteNtfTeamRoomInviteInfo_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomInviteNtfTeamRoomInviteInfo_hotfix.call(new object[]
				{
					this,
					inviteInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			InviteNotifyUITask.StartUITask();
		}

		// Token: 0x060152C6 RID: 86726 RVA: 0x0055D5B8 File Offset: 0x0055B7B8
		private void PlayerContext_OnBattlePracticeInvitedNtf(PVPInviteInfo inviteInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattlePracticeInvitedNtfPVPInviteInfo_hotfix != null)
			{
				this.m_PlayerContext_OnBattlePracticeInvitedNtfPVPInviteInfo_hotfix.call(new object[]
				{
					this,
					inviteInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			InviteNotifyUITask.StartUITask();
		}

		// Token: 0x060152C7 RID: 86727 RVA: 0x0055D630 File Offset: 0x0055B830
		private void PlayerContext_OnBattleRoomTeamBattleJoinNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomTeamBattleJoinNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomTeamBattleJoinNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBattleRoomBattle();
		}

		// Token: 0x060152C8 RID: 86728 RVA: 0x0055D698 File Offset: 0x0055B898
		private void PlayerContext_OnBattleRoomPVPBattleJoinNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomPVPBattleJoinNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomPVPBattleJoinNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBattleRoomBattle();
		}

		// Token: 0x060152C9 RID: 86729 RVA: 0x0055D700 File Offset: 0x0055B900
		private void PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBattleRoomBattle();
		}

		// Token: 0x060152CA RID: 86730 RVA: 0x0055D768 File Offset: 0x0055B968
		private void PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBattleRoomBattle();
		}

		// Token: 0x060152CB RID: 86731 RVA: 0x0055D7D0 File Offset: 0x0055B9D0
		private void PlayerContext_OnPlayerInfoInitEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix != null)
			{
				this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.State == Task.TaskState.Running)
			{
				this.UpdateView();
			}
			this.CheckOrderReward();
			if (!this.CheckInBattleRoom())
			{
				InviteNotifyUITask.CheckPendingInviteInfo();
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x060152CC RID: 86732 RVA: 0x0055D860 File Offset: 0x0055BA60
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

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x060152CD RID: 86733 RVA: 0x0055D8D4 File Offset: 0x0055BAD4
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

		// Token: 0x060152CE RID: 86734 RVA: 0x0055D948 File Offset: 0x0055BB48
		public ClientWorld GetClientWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClientWorld_hotfix != null)
			{
				return (ClientWorld)this.m_GetClientWorld_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_clientWorld;
		}

		// Token: 0x060152CF RID: 86735 RVA: 0x0055D9BC File Offset: 0x0055BBBC
		private void StartScenario(ConfigDataScenarioInfo scenarioInfo, ConfigDataWaypointInfo prevWaypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartScenarioConfigDataScenarioInfoConfigDataWaypointInfo_hotfix != null)
			{
				this.m_StartScenarioConfigDataScenarioInfoConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo2,
					prevWaypointInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScenarioInfo scenarioInfo = scenarioInfo2;
			WorldUITask $this = this;
			if (scenarioInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.Happening.Clear();
			projectLPlayerContext.Happening.WaypointInfo = scenarioInfo.m_waypointInfo;
			projectLPlayerContext.Happening.PrevWaypointInfo = prevWaypointInfo;
			projectLPlayerContext.Happening.ScenarioInfo = scenarioInfo;
			this.m_clientWorld.ShowWorld(false);
			this.m_worldUIController.ShowEnterScenario(scenarioInfo, delegate
			{
				if (!UIUtility.IsUITaskRunning(typeof(TeamRoomInfoUITask)))
				{
					CommonUIController.Instance.FadeOut(0f, Color.black, null);
					$this.StartHappening(BattleType.Scenario, scenarioInfo.m_battleInfo, scenarioInfo.MonsterLevel, scenarioInfo.m_dialogInfoBefore, scenarioInfo.m_dialogInfoAfter);
				}
				else
				{
					$this.m_clientWorld.ShowWorld(true);
				}
			});
		}

		// Token: 0x060152D0 RID: 86736 RVA: 0x0055DAD4 File Offset: 0x0055BCD4
		private void StartWaypointEvent(ConfigDataWaypointInfo waypointInfo, ConfigDataWaypointInfo prevWaypointInfo, ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartWaypointEventConfigDataWaypointInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix != null)
			{
				this.m_StartWaypointEventConfigDataWaypointInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					prevWaypointInfo,
					eventInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEventInfo eventInfo = eventInfo2;
			WorldUITask $this = this;
			if (waypointInfo == null || eventInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.Happening.Clear();
			projectLPlayerContext.Happening.WaypointInfo = waypointInfo;
			projectLPlayerContext.Happening.PrevWaypointInfo = prevWaypointInfo;
			projectLPlayerContext.Happening.EventInfo = eventInfo;
			if (eventInfo.FuncType != EventFuncType.EventFuncType_Shop)
			{
				if (eventInfo.FuncType == EventFuncType.EventFuncType_Monster)
				{
					this.m_worldUIController.ShowEnterMonster(eventInfo.m_battleInfo, delegate
					{
						$this.StartHappening(BattleType.WayPoint, eventInfo.m_battleInfo, eventInfo.MonsterLevel, eventInfo.m_dialogInfoBefore, eventInfo.m_dialogInfoAfter);
					});
				}
				else if (eventInfo.FuncType == EventFuncType.EventFuncType_Mission)
				{
					this.StartWorldEventMissionUITask(eventInfo);
				}
				else if (eventInfo.FuncType == EventFuncType.EventFuncType_Dialog)
				{
					this.StartHappening(BattleType.None, null, 0, eventInfo.m_dialogInfoBefore, eventInfo.m_dialogInfoAfter);
				}
				else if (eventInfo.FuncType == EventFuncType.EventFuncType_Treasure)
				{
					this.StartHappening(BattleType.None, null, 0, eventInfo.m_dialogInfoBefore, eventInfo.m_dialogInfoAfter);
				}
			}
		}

		// Token: 0x060152D1 RID: 86737 RVA: 0x0055DCA4 File Offset: 0x0055BEA4
		private void StartBattleRoomBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomBattle_hotfix != null)
			{
				this.m_StartBattleRoomBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("WorldUITask.StartBattleRoomBattle");
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsInBattleRoom())
			{
				global::Debug.LogError("WorldUITask.StartBattleRoomBattle fail, not in battle Room");
				return;
			}
			BattleRoom battleRoom = projectLPlayerContext.GetBattleRoom();
			if (battleRoom == null)
			{
				global::Debug.LogError("WorldUITask.StartBattleRoomBattle fail, battleRoom is null");
				return;
			}
			global::Debug.Log(string.Format("BattleRoomType:{0}, RoomId:{1}, BattleId:{2}", battleRoom.BattleRoomType, battleRoom.RoomId, battleRoom.BattleId));
			if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				GameFunctionType gameFunctionType = battleRoom.GameFunctionType;
				int locationId = battleRoom.LocationId;
				if (gameFunctionType == GameFunctionType.GameFunctionType_ThearchyTrial)
				{
					this._StartBattleHappening(BattleType.ThearchyTrial, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_AnikiGym)
				{
					this._StartBattleHappening(BattleType.AnikiGym, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_MemoryCorridor)
				{
					this._StartBattleHappening(BattleType.MemoryCorridor, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_HeroTrainning)
				{
					this._StartBattleHappening(BattleType.HeroTrainning, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_CooperateBattle)
				{
					this._StartBattleHappening(BattleType.CooperateBattle, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
				{
					this._StartBattleHappening(BattleType.UnchartedScore_ScoreLevel, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel)
				{
					this._StartBattleHappening(BattleType.UnchartedScore_ChallengeLevel, locationId);
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_GuildMassiveCombat)
				{
					this._StartBattleHappening(BattleType.GuildMassiveCombat, locationId);
				}
			}
			else if (battleRoom.BattleRoomType == BattleRoomType.PVP)
			{
				ConfigDataPVPBattleInfo configDataPVPBattleInfo = this.m_configDataLoader.GetConfigDataPVPBattleInfo(battleRoom.BattleId);
				if (configDataPVPBattleInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleRoomBattle fail, PVPBattleInfo is null, BattleId:" + battleRoom.BattleId);
					return;
				}
				projectLPlayerContext.SetCurrentPVPBattle(configDataPVPBattleInfo);
				this.FadeOutAndStartBattleUITask();
			}
			else if (battleRoom.IsRealTimePVPBattleRoomType())
			{
				ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = this.m_configDataLoader.GetConfigDataRealTimePVPBattleInfo(battleRoom.BattleId);
				if (configDataRealTimePVPBattleInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleRoomBattle fail, RealTimePVPBattleInfo is null, BattleId:" + battleRoom.BattleId);
					return;
				}
				projectLPlayerContext.SetCurrentRealTimePVPBattle(configDataRealTimePVPBattleInfo);
				this.FadeOutAndStartBattleUITask();
			}
		}

		// Token: 0x060152D2 RID: 86738 RVA: 0x0055DEF0 File Offset: 0x0055C0F0
		public static void StartBattleHappening(BattleType battleType, int locationId)
		{
			if (WorldUITask.s_instance != null)
			{
				WorldUITask.s_instance._StartBattleHappening(battleType, locationId);
			}
		}

		// Token: 0x060152D3 RID: 86739 RVA: 0x0055DF0C File Offset: 0x0055C10C
		private bool _StartBattleHappening(BattleType battleType, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__StartBattleHappeningBattleTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m__StartBattleHappeningBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					battleType,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Happening happening = projectLPlayerContext.Happening;
			happening.Clear();
			if (battleType == BattleType.WayPoint)
			{
				ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(levelId);
				if (configDataWaypointInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, WaypointInfo is null, Id:" + levelId);
					return false;
				}
				ConfigDataEventInfo currentWaypointEventInfo = projectLPlayerContext.GetCurrentWaypointEventInfo(configDataWaypointInfo.ID);
				if (currentWaypointEventInfo == null)
				{
					return false;
				}
				happening.WaypointInfo = configDataWaypointInfo;
				happening.EventInfo = currentWaypointEventInfo;
				this.StartHappening(battleType, currentWaypointEventInfo.m_battleInfo, currentWaypointEventInfo.MonsterLevel, currentWaypointEventInfo.m_dialogInfoBefore, currentWaypointEventInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.Scenario)
			{
				ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(levelId);
				if (configDataScenarioInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, ScenarioInfo is null, Id:" + levelId);
					return false;
				}
				happening.WaypointInfo = configDataScenarioInfo.m_waypointInfo;
				happening.ScenarioInfo = configDataScenarioInfo;
				this.StartHappening(battleType, configDataScenarioInfo.m_battleInfo, configDataScenarioInfo.MonsterLevel, configDataScenarioInfo.m_dialogInfoBefore, configDataScenarioInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.Rift)
			{
				ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
				if (configDataRiftLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, RiftLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.RiftLevelInfo = configDataRiftLevelInfo;
				this.StartHappening(battleType, configDataRiftLevelInfo.m_battleInfo, configDataRiftLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.HeroDungeon)
			{
				ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
				if (configDataHeroDungeonLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, HeroDungeonLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.HeroDungeonLevelInfo = configDataHeroDungeonLevelInfo;
				this.StartHappening(battleType, configDataHeroDungeonLevelInfo.m_battleInfo, configDataHeroDungeonLevelInfo.MonsterLevel, configDataHeroDungeonLevelInfo.m_dialogInfoBefore, configDataHeroDungeonLevelInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.ThearchyTrial)
			{
				ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
				if (configDataThearchyTrialLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, ThearchyTrialLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.ThearchyLevelInfo = configDataThearchyTrialLevelInfo;
				this.StartHappening(battleType, configDataThearchyTrialLevelInfo.m_battleInfo, configDataThearchyTrialLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.AnikiGym)
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(levelId);
				if (configDataAnikiLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, AnikiLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.AnikiLevelInfo = configDataAnikiLevelInfo;
				this.StartHappening(battleType, configDataAnikiLevelInfo.m_battleInfo, configDataAnikiLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.TreasureMap)
			{
				ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = this.m_configDataLoader.GetConfigDataTreasureLevelInfo(levelId);
				if (configDataTreasureLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, TreasureLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.TreasureLevelInfo = configDataTreasureLevelInfo;
				this.StartHappening(battleType, configDataTreasureLevelInfo.m_battleInfo, configDataTreasureLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.MemoryCorridor)
			{
				ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
				if (configDataMemoryCorridorLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, MemoryCorridorLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.MemoryCorridorLevelInfo = configDataMemoryCorridorLevelInfo;
				this.StartHappening(battleType, configDataMemoryCorridorLevelInfo.m_battleInfo, configDataMemoryCorridorLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.HeroTrainning)
			{
				ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
				if (configDataHeroTrainningLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, HeroTrainningLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.HeroTrainningLevelInfo = configDataHeroTrainningLevelInfo;
				this.StartHappening(battleType, configDataHeroTrainningLevelInfo.m_battleInfo, configDataHeroTrainningLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.HeroPhantom)
			{
				ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(levelId);
				if (configDataHeroPhantomLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, HeroPhantomLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.HeroPhantomLevelInfo = configDataHeroPhantomLevelInfo;
				this.StartHappening(battleType, configDataHeroPhantomLevelInfo.m_battleInfo, configDataHeroPhantomLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.CooperateBattle)
			{
				ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(levelId);
				if (configDataCooperateBattleLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, CooperateBattleLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.CooperateBattleLevelInfo = configDataCooperateBattleLevelInfo;
				this.StartHappening(battleType, configDataCooperateBattleLevelInfo.m_battleInfo, configDataCooperateBattleLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.UnchartedScore_ScoreLevel)
			{
				ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.m_configDataLoader.GetConfigDataScoreLevelInfo(levelId);
				if (configDataScoreLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, ScoreLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.ScoreLevelInfo = configDataScoreLevelInfo;
				this.StartHappening(battleType, configDataScoreLevelInfo.BattleInfo, configDataScoreLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.UnchartedScore_ChallengeLevel)
			{
				ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = this.m_configDataLoader.GetConfigDataChallengeLevelInfo(levelId);
				if (configDataChallengeLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, ChallengeLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.ChallengeLevelInfo = configDataChallengeLevelInfo;
				this.StartHappening(battleType, configDataChallengeLevelInfo.BattleInfo, configDataChallengeLevelInfo.MonsterLevel, configDataChallengeLevelInfo.m_dialogInfoBefore, configDataChallengeLevelInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.ClimbTower)
			{
				GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(levelId);
				if (climbTowerFloor == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, GlobalClimbTowerFloor is null, Id:" + levelId);
					return false;
				}
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(levelId);
				if (configDataTowerFloorInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, TowerFloorInfo is null, Id:" + levelId);
					return false;
				}
				ConfigDataTowerLevelInfo configDataTowerLevelInfo = this.m_configDataLoader.GetConfigDataTowerLevelInfo(climbTowerFloor.LevelId);
				if (configDataTowerLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, TowerLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.TowerFloorInfo = configDataTowerFloorInfo;
				this.StartHappening(battleType, configDataTowerLevelInfo.BattleInfo, configDataTowerFloorInfo.MonsterLevel, null, null);
			}
			else
			{
				if (battleType != BattleType.GuildMassiveCombat)
				{
					return false;
				}
				ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatLevelInfo(levelId);
				if (configDataGuildMassiveCombatLevelInfo == null)
				{
					global::Debug.LogError("WorldUITask.StartBattleHappening fail, GuildMassiveCombatLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.GuildMassiveCombatLevelInfo = configDataGuildMassiveCombatLevelInfo;
				this.StartHappening(battleType, configDataGuildMassiveCombatLevelInfo.m_battleInfo, configDataGuildMassiveCombatLevelInfo.m_strongholdInfo.EnemyLevel, null, null);
			}
			return true;
		}

		// Token: 0x060152D4 RID: 86740 RVA: 0x0055E590 File Offset: 0x0055C790
		private void StartHappening(BattleType battleType, ConfigDataBattleInfo battleInfo, int monsterLevel, ConfigDataDialogInfo dialogBefore = null, ConfigDataDialogInfo dialogAfter = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHappeningBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix != null)
			{
				this.m_StartHappeningBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					battleType,
					battleInfo,
					monsterLevel,
					dialogBefore,
					dialogAfter
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.Happening.InitBattleAndDialog(battleType, battleInfo, monsterLevel, dialogBefore, dialogAfter);
			this.NextHappeningStep();
		}

		// Token: 0x060152D5 RID: 86741 RVA: 0x0055E668 File Offset: 0x0055C868
		private void NextHappeningStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextHappeningStep_hotfix != null)
			{
				this.m_NextHappeningStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Happening happening = projectLPlayerContext.Happening;
			ConfigDataRiftLevelInfo riftLevelInfo = happening.RiftLevelInfo;
			ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo = happening.HeroDungeonLevelInfo;
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo = happening.HeroPhantomLevelInfo;
			ConfigDataThearchyTrialLevelInfo thearchyLevelInfo = happening.ThearchyLevelInfo;
			ConfigDataAnikiLevelInfo anikiLevelInfo = happening.AnikiLevelInfo;
			ConfigDataTreasureLevelInfo treasureLevelInfo = happening.TreasureLevelInfo;
			ConfigDataMemoryCorridorLevelInfo memoryCorridorLevelInfo = happening.MemoryCorridorLevelInfo;
			ConfigDataHeroTrainningLevelInfo heroTrainningLevelInfo = happening.HeroTrainningLevelInfo;
			ConfigDataCooperateBattleLevelInfo cooperateBattleLevelInfo = happening.CooperateBattleLevelInfo;
			ConfigDataScoreLevelInfo scoreLevelInfo = happening.ScoreLevelInfo;
			ConfigDataChallengeLevelInfo challengeLevelInfo = happening.ChallengeLevelInfo;
			ConfigDataTowerFloorInfo towerFloorInfo = happening.TowerFloorInfo;
			ConfigDataGuildMassiveCombatLevelInfo guildMassiveCombatLevelInfo = happening.GuildMassiveCombatLevelInfo;
			happening.NextStep();
			if (happening.Step == HappeningStep.DialogBefore)
			{
				this.StartDialogUITask(happening.DialogInfoBefore);
			}
			else if (happening.Step == HappeningStep.Battle)
			{
				this.StartBattleUITask(happening.BattleInfo, happening.BattleType);
			}
			else if (happening.Step == HappeningStep.DialogAfter)
			{
				this.StartDialogUITask(happening.DialogInfoAfter);
			}
			else if (happening.Step == HappeningStep.MoveToWaypoint)
			{
				this.m_isResumeNeedNextWorldStep = false;
				if (happening.ScenarioInfo != null)
				{
					this.StartLevelScenarioHandleNetTask(happening.ScenarioInfo.ID, null);
				}
				else
				{
					this.StartLevelWayPointMoveNetTask(happening.WaypointInfo.ID, null);
				}
			}
			else
			{
				if (happening.Step == HappeningStep.MoveToPrevWaypoint)
				{
					this.MoveToPrevWaypoint(true);
				}
				happening.RiftLevelInfo = riftLevelInfo;
				happening.HeroDungeonLevelInfo = heroDungeonLevelInfo;
				happening.HeroPhantomLevelInfo = heroPhantomLevelInfo;
				happening.ThearchyLevelInfo = thearchyLevelInfo;
				happening.AnikiLevelInfo = anikiLevelInfo;
				happening.TreasureLevelInfo = treasureLevelInfo;
				happening.MemoryCorridorLevelInfo = memoryCorridorLevelInfo;
				happening.HeroTrainningLevelInfo = heroTrainningLevelInfo;
				happening.CooperateBattleLevelInfo = cooperateBattleLevelInfo;
				happening.ScoreLevelInfo = scoreLevelInfo;
				happening.ChallengeLevelInfo = challengeLevelInfo;
				happening.TowerFloorInfo = towerFloorInfo;
				happening.GuildMassiveCombatLevelInfo = guildMassiveCombatLevelInfo;
				if (!this.CheckReturnToBeforeBattleUI())
				{
					happening.Clear();
					projectLPlayerContext.CurrentBattle.Clear();
					this.CheckChangeCurrentScenario(true);
				}
			}
		}

		// Token: 0x060152D6 RID: 86742 RVA: 0x0055E894 File Offset: 0x0055CA94
		public static void HandleAttackFailResult(int result, UIIntent currIntent)
		{
			global::Debug.Log("WorldUITask.HandleAttackFailResult, result:" + result);
			if (result != 0)
			{
				if (result == -500)
				{
					BagFullUITask.StartUITask(currIntent);
				}
				else if (result == -402)
				{
					BuyEnergyUITask.StartUITask(true);
				}
				else if (result == -900)
				{
					BattleCancelNetTask battleCancelNetTask = new BattleCancelNetTask();
					battleCancelNetTask.Start(null);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
			}
		}

		// Token: 0x060152D7 RID: 86743 RVA: 0x0055E920 File Offset: 0x0055CB20
		private void StartLevelWayPointMoveNetTask(int waypointId, Action<int> onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLevelWayPointMoveNetTaskInt32Action`1_hotfix != null)
			{
				this.m_StartLevelWayPointMoveNetTaskInt32Action`1_hotfix.call(new object[]
				{
					this,
					waypointId,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<int> onEnd = onEnd2;
			WorldUITask $this = this;
			LevelWayPointMoveNetTask levelWayPointMoveNetTask = new LevelWayPointMoveNetTask(waypointId);
			levelWayPointMoveNetTask.EventOnStop += delegate(Task task)
			{
				LevelWayPointMoveNetTask levelWayPointMoveNetTask2 = task as LevelWayPointMoveNetTask;
				$this.OnLevelWayPointMoveNetTaskResult(levelWayPointMoveNetTask2.Result, levelWayPointMoveNetTask2.Reward, onEnd);
			};
			levelWayPointMoveNetTask.Start(null);
		}

		// Token: 0x060152D8 RID: 86744 RVA: 0x0055E9D8 File Offset: 0x0055CBD8
		private void StartLevelScenarioHandleNetTask(int scenarioId, Action<int> onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLevelScenarioHandleNetTaskInt32Action`1_hotfix != null)
			{
				this.m_StartLevelScenarioHandleNetTaskInt32Action`1_hotfix.call(new object[]
				{
					this,
					scenarioId,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<int> onEnd = onEnd2;
			WorldUITask $this = this;
			LevelScenarioHandleNetTask levelScenarioHandleNetTask = new LevelScenarioHandleNetTask(scenarioId);
			levelScenarioHandleNetTask.EventOnStop += delegate(Task task)
			{
				LevelScenarioHandleNetTask levelScenarioHandleNetTask2 = task as LevelScenarioHandleNetTask;
				$this.OnLevelWayPointMoveNetTaskResult(levelScenarioHandleNetTask2.Result, levelScenarioHandleNetTask2.Reward, onEnd);
			};
			levelScenarioHandleNetTask.Start(null);
		}

		// Token: 0x060152D9 RID: 86745 RVA: 0x0055EA90 File Offset: 0x0055CC90
		private void OnLevelWayPointMoveNetTaskResult(int result, BattleReward reward, Action<int> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelWayPointMoveNetTaskResultInt32BattleRewardAction`1_hotfix != null)
			{
				this.m_OnLevelWayPointMoveNetTaskResultInt32BattleRewardAction`1_hotfix.call(new object[]
				{
					this,
					result2,
					reward2,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleReward reward = reward2;
			Action<int> onEnd = onEnd2;
			int result = result2;
			WorldUITask $this = this;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (result == 0 || result == -1204)
			{
				playerContext.UpdateCurrentWaypointEvents();
				base.ClearAssetList();
				this.CollectEventAssets();
				base.StartLoadCustomAssets(delegate
				{
					$this.m_clientWorld.OnWaypointUpdate();
					$this.UpdateWorldEventRedMark();
					if (!reward.IsEmpty())
					{
						bool isChest = playerContext.Happening.EventInfo != null && playerContext.Happening.EventInfo.FuncType == EventFuncType.EventFuncType_Treasure;
						$this.ShowWaypointReward(reward, isChest);
					}
					if (onEnd != null)
					{
						onEnd(result);
					}
				});
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
			}
		}

		// Token: 0x060152DA RID: 86746 RVA: 0x0055EBB8 File Offset: 0x0055CDB8
		private void ShowWaypointReward(BattleReward reward, bool isChest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaypointRewardBattleRewardBoolean_hotfix != null)
			{
				this.m_ShowWaypointRewardBattleRewardBoolean_hotfix.call(new object[]
				{
					this,
					reward,
					isChest
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (reward == null)
			{
				return;
			}
			if (isChest)
			{
				ChestUITask chestUITask = ChestUITask.StartUITask(reward, false, false);
				if (this.m_chestUITask == null)
				{
					this.m_chestUITask = chestUITask;
					this.m_chestUITask.EventOnStop += this.ChestUITask_OnStop;
					this.m_chestUITask.EventOnClose += this.ChestUITask_OnClose;
				}
			}
			else
			{
				GetRewardGoodsUITask getRewardGoodsUITask = GetRewardGoodsUITask.StartUITask(reward.Goods);
				if (this.m_getRewardGoodsUITask == null)
				{
					this.m_getRewardGoodsUITask = getRewardGoodsUITask;
					this.m_getRewardGoodsUITask.EventOnStop += this.GetRewardGoodsUITask_OnStop;
					this.m_getRewardGoodsUITask.EventOnClose += this.GetRewardGoodsUITask_OnClose;
				}
			}
		}

		// Token: 0x060152DB RID: 86747 RVA: 0x0055ECE0 File Offset: 0x0055CEE0
		private bool CheckChangeCurrentScenario(bool checkWorldUIGetReady = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckChangeCurrentScenarioBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckChangeCurrentScenarioBoolean_hotfix.call(new object[]
				{
					this,
					checkWorldUIGetReady
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CheckChangeCurrentScenario())
			{
				ConfigDataScenarioInfo currentScenarioInfo = projectLPlayerContext.GetCurrentScenarioInfo();
				this.m_worldUIController.StartCoroutine(this.Co_ChangeCurrentScenario(currentScenarioInfo, checkWorldUIGetReady));
				return true;
			}
			this.NextWorldStep(checkWorldUIGetReady);
			return false;
		}

		// Token: 0x060152DC RID: 86748 RVA: 0x0055ED9C File Offset: 0x0055CF9C
		[DebuggerHidden]
		private IEnumerator Co_ChangeCurrentScenario(ConfigDataScenarioInfo scenario, bool checkWorldUIGetReady)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ChangeCurrentScenarioConfigDataScenarioInfoBoolean_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ChangeCurrentScenarioConfigDataScenarioInfoBoolean_hotfix.call(new object[]
				{
					this,
					scenario,
					checkWorldUIGetReady
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			WorldUITask.<Co_ChangeCurrentScenario>c__Iterator0 <Co_ChangeCurrentScenario>c__Iterator = new WorldUITask.<Co_ChangeCurrentScenario>c__Iterator0();
			<Co_ChangeCurrentScenario>c__Iterator.scenario = scenario;
			<Co_ChangeCurrentScenario>c__Iterator.checkWorldUIGetReady = checkWorldUIGetReady;
			<Co_ChangeCurrentScenario>c__Iterator.$this = this;
			return <Co_ChangeCurrentScenario>c__Iterator;
		}

		// Token: 0x060152DD RID: 86749 RVA: 0x0055EE44 File Offset: 0x0055D044
		private bool CheckOpenRiftChapter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOpenRiftChapter_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckOpenRiftChapter_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CheckChangeLastOpenedRiftChapter())
			{
				ConfigDataRiftChapterInfo lastOpenedRiftChapterInfo = projectLPlayerContext.GetLastOpenedRiftChapterInfo();
				if (lastOpenedRiftChapterInfo != null && lastOpenedRiftChapterInfo.ID != this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Rift_FirstChapterId))
				{
					string txt = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Rift_ChapterOpen), lastOpenedRiftChapterInfo.Desc);
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060152DE RID: 86750 RVA: 0x0055EF2C File Offset: 0x0055D12C
		private void CheckOrderReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOrderReward_hotfix != null)
			{
				this.m_CheckOrderReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.CheckOrderReward();
		}

		// Token: 0x060152DF RID: 86751 RVA: 0x0055EF94 File Offset: 0x0055D194
		private bool CheckReturnToBeforeBattleUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckReturnToBeforeBattleUI_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckReturnToBeforeBattleUI_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Happening happening = projectLPlayerContext.Happening;
			bool flag = false;
			if (projectLPlayerContext.IsTeamRoomInviteAgain())
			{
				this.StartTeamUITask();
				flag = true;
			}
			else if (projectLPlayerContext.IsInTeamRoom())
			{
				this.CheckOpenTeamRoomInfoUI();
				flag = true;
			}
			else if (happening.RiftLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.white, null);
				this.StartRiftUITask(happening.RiftLevelInfo, false, true, null, null);
				flag = true;
			}
			else if (happening.HeroDungeonLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartFettersUITask(happening.HeroDungeonLevelInfo, null);
				flag = true;
			}
			else if (happening.HeroPhantomLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.HeroPhantom, happening.HeroPhantomLevelInfo.m_groupInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.ThearchyLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.ThearchyTrial, happening.ThearchyLevelInfo.m_groupInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.AnikiLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.AnikiGym, happening.AnikiLevelInfo.m_groupInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.TreasureLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.TreasureMap, 0, 0, null);
				flag = true;
			}
			else if (happening.MemoryCorridorLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.MemoryCorridor, happening.MemoryCorridorLevelInfo.m_groupInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.HeroTrainningLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.HeroTrainning, happening.HeroTrainningLevelInfo.m_groupInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.CooperateBattleLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.CooperateBattle, happening.CooperateBattleLevelInfo.m_groupInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.ScoreLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.UnchartedScore_ScoreLevel, happening.ScoreLevelInfo.UnchartedScoreInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.ChallengeLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.UnchartedScore_ChallengeLevel, happening.ChallengeLevelInfo.UnchartedScoreInfo.ID, 0, null);
				flag = true;
			}
			else if (happening.TowerFloorInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartUnchartedUITask(BattleType.ClimbTower, 0, 0, null);
				flag = true;
			}
			else if (happening.GuildMassiveCombatLevelInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				this.StartGuildUITask(null, true);
				flag = true;
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				bool isBattleReport = projectLPlayerContext.CurrentBattle.ArenaBattleReport != null || projectLPlayerContext.CurrentBattle.IsArenaRevenge;
				this.StartArenaSelectUITask(ArenaUIType.Offline, isBattleReport, null);
				flag = true;
			}
			else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo != null)
			{
				CommonUIController.Instance.FadeOut(0f, Color.black, null);
				bool isBattleReport2 = projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null;
				this.StartArenaSelectUITask(ArenaUIType.Online, isBattleReport2, null);
				flag = true;
			}
			if (flag)
			{
				happening.Clear();
				projectLPlayerContext.CurrentBattle.Clear();
			}
			return flag;
		}

		// Token: 0x060152E0 RID: 86752 RVA: 0x0055F400 File Offset: 0x0055D600
		private bool CheckOpenTeamRoomInfoUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOpenTeamRoomInfoUI_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckOpenTeamRoomInfoUI_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsInTeamRoom())
			{
				return false;
			}
			TeamRoomGetNetTask teamRoomGetNetTask = new TeamRoomGetNetTask();
			teamRoomGetNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomGetNetTask teamRoomGetNetTask2 = task as TeamRoomGetNetTask;
				if (teamRoomGetNetTask2.Result == 0)
				{
					this.StartTeamRoomInfoUITask();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomGetNetTask2.Result, 2f, null, true);
				}
			};
			teamRoomGetNetTask.Start(null);
			return true;
		}

		// Token: 0x060152E1 RID: 86753 RVA: 0x0055F4AC File Offset: 0x0055D6AC
		private void StartTeamRoomInfoUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamRoomInfoUITask_hotfix != null)
			{
				this.m_StartTeamRoomInfoUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(TeamRoomInfoUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x060152E2 RID: 86754 RVA: 0x0055F538 File Offset: 0x0055D738
		private bool CheckInBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckInBattleRoom_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckInBattleRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsInBattleRoom())
			{
				return false;
			}
			BattleRoomGetNetTask battleRoomGetNetTask = new BattleRoomGetNetTask();
			battleRoomGetNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomGetNetTask battleRoomGetNetTask2 = task as BattleRoomGetNetTask;
				if (battleRoomGetNetTask2.Result == 0)
				{
					this.StartBattleRoomBattle();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(battleRoomGetNetTask2.Result, 2f, null, true);
				}
			};
			battleRoomGetNetTask.Start(null);
			return true;
		}

		// Token: 0x060152E3 RID: 86755 RVA: 0x0055F5E4 File Offset: 0x0055D7E4
		private void MoveToPrevWaypoint(bool moveCamera = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveToPrevWaypointBoolean_hotfix != null)
			{
				this.m_MoveToPrevWaypointBoolean_hotfix.call(new object[]
				{
					this,
					moveCamera2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool moveCamera = moveCamera2;
			WorldUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataWaypointInfo playerCurrentWaypointInfo = projectLPlayerContext.GetPlayerCurrentWaypointInfo();
			ConfigDataWaypointInfo prevWaypointInfo = projectLPlayerContext.Happening.PrevWaypointInfo;
			ConfigDataScenarioInfo currentScenarioInfo = projectLPlayerContext.GetCurrentScenarioInfo();
			ClientWorldPlayerActor playerActor = this.m_clientWorld.GetPlayerActor();
			ConfigDataEventInfo configDataEventInfo = null;
			if (prevWaypointInfo != null)
			{
				configDataEventInfo = projectLPlayerContext.GetCurrentWaypointEventInfo(prevWaypointInfo.ID);
			}
			if (prevWaypointInfo != null && playerCurrentWaypointInfo != prevWaypointInfo && configDataEventInfo == null && (currentScenarioInfo == null || currentScenarioInfo.m_waypointInfo != prevWaypointInfo))
			{
				this.StartLevelWayPointMoveNetTask(prevWaypointInfo.ID, delegate(int result)
				{
					if (moveCamera && result == 0)
					{
						$this.m_clientWorld.WorldCamera.Look(playerActor.Position);
					}
				});
			}
			else
			{
				playerActor.Locate(this.m_playerContext.GetPlayerCurrentWaypointInfo(), playerActor.Direction);
			}
		}

		// Token: 0x060152E4 RID: 86756 RVA: 0x0055F724 File Offset: 0x0055D924
		private static void StartBattleArmyRandomSeedGetNetTask(int battleId, Action<int> onEnd = null)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsInBattleRoom())
			{
				if (onEnd != null)
				{
					onEnd(0);
				}
				return;
			}
			if (projectLPlayerContext.Happening.TowerFloorInfo != null)
			{
				GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(projectLPlayerContext.Happening.TowerFloorInfo.ID);
				if (climbTowerFloor != null)
				{
					projectLPlayerContext.SetBattleArmyRandomSeed(climbTowerFloor.ArmyRandomSeed);
				}
				if (onEnd != null)
				{
					onEnd(0);
				}
				return;
			}
			if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
			{
				GuildMassiveCombatStronghold guildMassiveCombatStronghold = projectLPlayerContext.GetGuildMassiveCombatStronghold(projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo.ID);
				if (guildMassiveCombatStronghold != null)
				{
					projectLPlayerContext.SetBattleArmyRandomSeed(guildMassiveCombatStronghold.RandomSeed);
				}
				if (onEnd != null)
				{
					onEnd(0);
				}
				return;
			}
			if (projectLPlayerContext.Happening.Step == HappeningStep.Battle)
			{
				BattleArmyRandomSeedGetNetTask battleArmyRandomSeedGetNetTask = new BattleArmyRandomSeedGetNetTask(battleId);
				battleArmyRandomSeedGetNetTask.EventOnStop += delegate(Task task)
				{
					BattleArmyRandomSeedGetNetTask battleArmyRandomSeedGetNetTask2 = task as BattleArmyRandomSeedGetNetTask;
					if (battleArmyRandomSeedGetNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(battleArmyRandomSeedGetNetTask2.Result, 2f, null, true);
					}
					if (onEnd != null)
					{
						onEnd(battleArmyRandomSeedGetNetTask2.Result);
					}
				};
				battleArmyRandomSeedGetNetTask.Start(null);
			}
			else if (onEnd != null)
			{
				onEnd(0);
			}
		}

		// Token: 0x060152E5 RID: 86757 RVA: 0x0055F864 File Offset: 0x0055DA64
		private static void StartDanmakuGetNetTaskNetTask(Action<int> onEnd = null)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			GameFunctionType gameFunctionType = GameFunctionType.GameFunctionType_None;
			int locationId = 0;
			projectLPlayerContext.Happening.GetGameFunctionTypeAndLocationId(out gameFunctionType, out locationId);
			if (gameFunctionType != GameFunctionType.GameFunctionType_None)
			{
				int num = projectLPlayerContext.CanGetLevelDanmaku((int)gameFunctionType, locationId);
				if (num == 0)
				{
					DanmakuGetNetTask danmakuGetNetTask = new DanmakuGetNetTask((int)gameFunctionType, locationId);
					danmakuGetNetTask.EventOnStop += delegate(Task task)
					{
						DanmakuGetNetTask danmakuGetNetTask2 = task as DanmakuGetNetTask;
						if (danmakuGetNetTask2.Result != 0)
						{
							CommonUIController.Instance.ShowErrorMessage(danmakuGetNetTask2.Result, 2f, null, true);
						}
						if (onEnd != null)
						{
							onEnd(danmakuGetNetTask2.Result);
						}
					};
					danmakuGetNetTask.Start(null);
				}
				else if (onEnd != null)
				{
					onEnd(num);
				}
			}
			else if (onEnd != null)
			{
				onEnd(0);
			}
		}

		// Token: 0x060152E6 RID: 86758 RVA: 0x0055F918 File Offset: 0x0055DB18
		public void OnWaypointClick(ConfigDataWaypointInfo waypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWaypointClickConfigDataWaypointInfo_hotfix != null)
			{
				this.m_OnWaypointClickConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataWaypointInfo waypointInfo = waypointInfo2;
			WorldUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Scenario)
			{
				ConfigDataScenarioInfo currentScenarioInfo = projectLPlayerContext.GetCurrentScenarioInfo();
				if (currentScenarioInfo != null && currentScenarioInfo.m_waypointInfo == waypointInfo && projectLPlayerContext.CanUnlockScenario(currentScenarioInfo.ID) != 0)
				{
					this.m_worldUIController.ShowUnlockScenario(currentScenarioInfo);
					return;
				}
			}
			else if (waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Event)
			{
				ConfigDataEventInfo currentWaypointEventInfo = projectLPlayerContext.GetCurrentWaypointEventInfo(waypointInfo.ID);
				if (currentWaypointEventInfo != null)
				{
					int num = projectLPlayerContext.CanAttackEventWaypoint(waypointInfo.ID);
					if (num != 0)
					{
						WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
						return;
					}
				}
			}
			this.m_movePath.Clear();
			if (!this.m_clientWorld.FindPath(this.m_clientWorld.GetPlayerActor().LocateWaypointInfo.ID, waypointInfo.ID, this.m_movePath, true) && this.m_clientWorld.FindPath(this.m_clientWorld.GetPlayerActor().LocateWaypointInfo.ID, waypointInfo.ID, this.m_movePath, false))
			{
				for (int i = 0; i < this.m_movePath.Count; i++)
				{
					ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(this.m_movePath[i]);
					if (waypoint == null || (waypoint.GetStatus() != WayPointStatus.Public && waypoint.GetStatus() != WayPointStatus.Arrived))
					{
						if (i > 0)
						{
							ClientWorldWaypoint waypoint2 = this.m_clientWorld.GetWaypoint(this.m_movePath[i - 1]);
							if (waypoint2 != null)
							{
								waypointInfo = waypoint2.WaypointInfo;
							}
						}
						this.m_movePath.RemoveRange(i, this.m_movePath.Count - i);
						break;
					}
				}
			}
			if (this.m_movePath.Count <= 0 && this.m_clientWorld.GetPlayerActor().LocateWaypointInfo.Waypoints_ID.Count <= 0)
			{
				this.m_movePath.Add(waypointInfo.ID);
			}
			if (this.m_movePath.Count > 0)
			{
				for (int j = 0; j < this.m_movePath.Count; j++)
				{
					if (this.m_clientWorld.GetEventActorAt(this.m_movePath[j]) != null)
					{
						ClientWorldWaypoint waypoint3 = this.m_clientWorld.GetWaypoint(this.m_movePath[j]);
						if (waypoint3 != null && waypoint3.GetStatus() == WayPointStatus.Public)
						{
							ClientWorldWaypoint waypoint4 = this.m_clientWorld.GetWaypoint(this.m_movePath[j]);
							if (waypoint4 != null)
							{
								waypointInfo = waypoint4.WaypointInfo;
							}
							if (j < this.m_movePath.Count)
							{
								this.m_movePath.RemoveRange(j + 1, this.m_movePath.Count - j - 1);
							}
						}
					}
				}
				ConfigDataWaypointInfo prevWaypoint = null;
				if (this.m_movePath.Count > 1)
				{
					int waypointId = this.m_movePath[this.m_movePath.Count - 2];
					ClientWorldWaypoint waypoint5 = this.m_clientWorld.GetWaypoint(waypointId);
					if (waypoint5 != null)
					{
						prevWaypoint = waypoint5.WaypointInfo;
					}
				}
				CommonUIController.Instance.EnableInput(false);
				int num2 = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_PlayerTeleportDistance);
				if (this.m_movePath.Count <= num2)
				{
					this.m_clientWorld.GetPlayerActor().MovePath(this.m_movePath, delegate
					{
						CommonUIController.Instance.EnableInput(true);
						$this.PlayerArriveWaypoint(waypointInfo, prevWaypoint);
					});
				}
				else
				{
					this.m_clientWorld.GetPlayerActor().Teleport(waypointInfo.ID, delegate
					{
						CommonUIController.Instance.EnableInput(true);
						$this.PlayerArriveWaypoint(waypointInfo, prevWaypoint);
					});
				}
			}
		}

		// Token: 0x060152E7 RID: 86759 RVA: 0x0055FD80 File Offset: 0x0055DF80
		private void PlayerArriveWaypoint(ConfigDataWaypointInfo waypointInfo, ConfigDataWaypointInfo prevWaypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerArriveWaypointConfigDataWaypointInfoConfigDataWaypointInfo_hotfix != null)
			{
				this.m_PlayerArriveWaypointConfigDataWaypointInfoConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					prevWaypointInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Scenario)
			{
				ConfigDataScenarioInfo currentScenarioInfo = projectLPlayerContext.GetCurrentScenarioInfo();
				if (currentScenarioInfo != null && currentScenarioInfo.m_waypointInfo == waypointInfo)
				{
					if (projectLPlayerContext.CanUnlockScenario(currentScenarioInfo.ID) != 0)
					{
						this.m_worldUIController.ShowUnlockScenario(currentScenarioInfo);
						return;
					}
					int num = projectLPlayerContext.CanAttackScenario(currentScenarioInfo.ID);
					if (num == 0)
					{
						this.StartScenario(currentScenarioInfo, prevWaypointInfo);
						return;
					}
					WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
					return;
				}
				else if (this.ShowPastScenarioList(waypointInfo))
				{
					if (waypointInfo != projectLPlayerContext.GetPlayerCurrentWaypointInfo())
					{
						this.StartLevelWayPointMoveNetTask(waypointInfo.ID, null);
					}
					return;
				}
			}
			else if (waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Event)
			{
				ConfigDataEventInfo currentWaypointEventInfo = projectLPlayerContext.GetCurrentWaypointEventInfo(waypointInfo.ID);
				if (currentWaypointEventInfo != null)
				{
					int num2 = projectLPlayerContext.CanAttackEventWaypoint(waypointInfo.ID);
					if (num2 == 0)
					{
						this.StartWaypointEvent(waypointInfo, prevWaypointInfo, currentWaypointEventInfo);
						return;
					}
					WorldUITask.HandleAttackFailResult(num2, this.m_currIntent);
					return;
				}
			}
			if (waypointInfo != projectLPlayerContext.GetPlayerCurrentWaypointInfo())
			{
				this.StartLevelWayPointMoveNetTask(waypointInfo.ID, null);
			}
		}

		// Token: 0x060152E8 RID: 86760 RVA: 0x0055FF14 File Offset: 0x0055E114
		private bool ShowPastScenarioList(ConfigDataWaypointInfo waypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPastScenarioListConfigDataWaypointInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ShowPastScenarioListConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (waypointInfo == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = false;
			this.m_worldUIController.ClearPastScenarioList();
			foreach (KeyValuePair<int, ConfigDataScenarioInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataScenarioInfo())
			{
				if (keyValuePair.Value.m_waypointInfo == waypointInfo && projectLPlayerContext.IsScenarioFinished(keyValuePair.Value.ID))
				{
					this.m_worldUIController.AddPastScenario(keyValuePair.Value);
					flag = true;
				}
			}
			if (flag)
			{
				projectLPlayerContext.Happening.Clear();
				projectLPlayerContext.Happening.PrevWaypointInfo = waypointInfo;
				this.m_worldUIController.ShowPastScenarioList();
			}
			return flag;
		}

		// Token: 0x060152E9 RID: 86761 RVA: 0x00560068 File Offset: 0x0055E268
		public void OnScreenEffect(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScreenEffectString_hotfix != null)
			{
				this.m_OnScreenEffectString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060152EA RID: 86762 RVA: 0x005600D8 File Offset: 0x0055E2D8
		private void StartShowFadeOutLoadingFadeIn(Action fadeOutEnd, FadeStyle style = FadeStyle.Black)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartShowFadeOutLoadingFadeInActionFadeStyle_hotfix != null)
			{
				this.m_StartShowFadeOutLoadingFadeInActionFadeStyle_hotfix.call(new object[]
				{
					this,
					fadeOutEnd,
					style
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isResumeNeedNextWorldStep = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(fadeOutEnd, style, -1f, -1f);
		}

		// Token: 0x060152EB RID: 86763 RVA: 0x00560178 File Offset: 0x0055E378
		private void HideFadeOutLoadingFadeIn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideFadeOutLoadingFadeIn_hotfix != null)
			{
				this.m_HideFadeOutLoadingFadeIn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
		}

		// Token: 0x060152EC RID: 86764 RVA: 0x005601E4 File Offset: 0x0055E3E4
		private void StartPlayerInfoUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartPlayerInfoUITask_hotfix != null)
			{
				this.m_StartPlayerInfoUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(PlayerInfoUITask).Name, null);
			PlayerInfoUITask playerInfoUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.PlayerInfoUITask_OnLoadAllResCompleted)) as PlayerInfoUITask;
			if (this.m_playerInfoUITask == null)
			{
				this.m_playerInfoUITask = playerInfoUITask;
				this.m_playerInfoUITask.EventOnStop += this.PlayerInfoUITask_OnStop;
				this.m_playerInfoUITask.EventOnClose += this.PlayerInfoUITask_OnClose;
			}
		}

		// Token: 0x060152ED RID: 86765 RVA: 0x005602C0 File Offset: 0x0055E4C0
		private void PlayerInfoUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_PlayerInfoUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(PlayerInfoUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152EE RID: 86766 RVA: 0x0056033C File Offset: 0x0055E53C
		private void PlayerInfoUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUITask_OnStopTask_hotfix != null)
			{
				this.m_PlayerInfoUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerInfoUITask == task)
			{
				this.m_playerInfoUITask.EventOnStop -= this.PlayerInfoUITask_OnStop;
				this.m_playerInfoUITask.EventOnClose -= this.PlayerInfoUITask_OnClose;
				this.m_playerInfoUITask = null;
			}
		}

		// Token: 0x060152EF RID: 86767 RVA: 0x005603F0 File Offset: 0x0055E5F0
		private void PlayerInfoUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUITask_OnClose_hotfix != null)
			{
				this.m_PlayerInfoUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			this.CollectPlayerAssets();
			base.StartLoadCustomAssets(new Action(this.UpdateView));
		}

		// Token: 0x060152F0 RID: 86768 RVA: 0x00560470 File Offset: 0x0055E670
		private void StartAppScoreUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartAppScoreUITask_hotfix != null)
			{
				this.m_StartAppScoreUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(AppScoreUITask).Name, null);
			AppScoreUITask appScoreUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.AppScoreUITask_OnLoadAllResCompleted)) as AppScoreUITask;
			if (this.m_appScoreUITask == null)
			{
				this.m_appScoreUITask = appScoreUITask;
				this.m_appScoreUITask.EventOnStop += this.AppScoreUITask_OnStop;
				this.m_appScoreUITask.EventOnClose += this.AppScoreUITask_OnClose;
			}
		}

		// Token: 0x060152F1 RID: 86769 RVA: 0x0056054C File Offset: 0x0055E74C
		private void AppScoreUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppScoreUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_AppScoreUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(AppScoreUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152F2 RID: 86770 RVA: 0x005605C8 File Offset: 0x0055E7C8
		private void AppScoreUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppScoreUITask_OnStopTask_hotfix != null)
			{
				this.m_AppScoreUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_appScoreUITask == task)
			{
				this.m_appScoreUITask.EventOnStop -= this.AppScoreUITask_OnStop;
				this.m_appScoreUITask.EventOnClose -= this.AppScoreUITask_OnClose;
				this.m_appScoreUITask = null;
			}
		}

		// Token: 0x060152F3 RID: 86771 RVA: 0x0056067C File Offset: 0x0055E87C
		private void AppScoreUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppScoreUITask_OnClose_hotfix != null)
			{
				this.m_AppScoreUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.NextWorldStep(true);
		}

		// Token: 0x060152F4 RID: 86772 RVA: 0x005606E4 File Offset: 0x0055E8E4
		private void StartSignUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartSignUITask_hotfix != null)
			{
				this.m_StartSignUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(SignUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, new Action(this.SignUITask_OnLoadAllResCompleted));
		}

		// Token: 0x060152F5 RID: 86773 RVA: 0x0056077C File Offset: 0x0055E97C
		private void SignUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SignUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_SignUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(SignUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152F6 RID: 86774 RVA: 0x0056080C File Offset: 0x0055EA0C
		private void StartActivityNoticeUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartActivityNoticeUITask_hotfix != null)
			{
				this.m_StartActivityNoticeUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(ActivityNoticeUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, new Action(this.ActivityNoticeUITask_OnLoadAllResCompleted));
		}

		// Token: 0x060152F7 RID: 86775 RVA: 0x005608A4 File Offset: 0x0055EAA4
		private void ActivityNoticeUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityNoticeUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ActivityNoticeUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ActivityNoticeUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152F8 RID: 86776 RVA: 0x00560934 File Offset: 0x0055EB34
		private void StartHeroUITask(UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroUITaskUIIntent_hotfix != null)
			{
				this.m_StartHeroUITaskUIIntent_hotfix.call(new object[]
				{
					this,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(HeroListUITask).Name, null);
			intent.SetParam("IsInitState", true);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.HeroUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x060152F9 RID: 86777 RVA: 0x00560A04 File Offset: 0x0055EC04
		private void HeroUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_HeroUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroListUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152FA RID: 86778 RVA: 0x00560A98 File Offset: 0x0055EC98
		private void StartBagUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBagUITask_hotfix != null)
			{
				this.m_StartBagUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(BagListUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.BagUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x060152FB RID: 86779 RVA: 0x00560B3C File Offset: 0x0055ED3C
		private void BagUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_BagUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(BagListUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152FC RID: 86780 RVA: 0x00560BD0 File Offset: 0x0055EDD0
		private void StartMissionUITask(UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartMissionUITaskUIIntent_hotfix != null)
			{
				this.m_StartMissionUITaskUIIntent_hotfix.call(new object[]
				{
					this,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(MissionUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.MissionUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x060152FD RID: 86781 RVA: 0x00560C8C File Offset: 0x0055EE8C
		private void MissionUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MissionUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_MissionUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(MissionUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060152FE RID: 86782 RVA: 0x00560D20 File Offset: 0x0055EF20
		private void StartOpenServiceActivityUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartOpenServiceActivityUITask_hotfix != null)
			{
				this.m_StartOpenServiceActivityUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(OpenServiceActivityUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.OpenServiceActivityUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x060152FF RID: 86783 RVA: 0x00560DC4 File Offset: 0x0055EFC4
		private void OpenServiceActivityUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenServiceActivityUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_OpenServiceActivityUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(OpenServiceActivityUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015300 RID: 86784 RVA: 0x00560E58 File Offset: 0x0055F058
		private void StartFettersUITask(ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo = null, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartFettersUITaskConfigDataHeroDungeonLevelInfoUIIntent_hotfix != null)
			{
				this.m_StartFettersUITaskConfigDataHeroDungeonLevelInfoUIIntent_hotfix.call(new object[]
				{
					this,
					heroDungeonLevelInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(FettersUITask).Name, null);
			if (heroDungeonLevelInfo != null)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				ConfigDataHeroInformationInfo configDataHeroInformationInfo = this.m_configDataLoader.GetConfigDataHeroInformationInfo(heroDungeonLevelInfo.m_chapterId);
				if (configDataHeroInformationInfo != null)
				{
					Hero hero = projectLPlayerContext.GetHero(configDataHeroInformationInfo.m_heroInfo.ID);
					intent.SetParam("BattleType", BattleType.HeroDungeon);
					intent.SetParam("Hero", hero);
				}
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				FettersUITask fettersUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.FettersUITask_OnLoadAllResCompleted)) as FettersUITask;
				if (this.m_fettersUITask == null)
				{
					this.m_fettersUITask = fettersUITask;
					this.m_fettersUITask.EventOnStop += this.FettersUITask_OnStop;
					this.m_fettersUITask.EventOnStartHeroDungeon += this.FetterUITask_StartHeroDungeon;
				}
			}, FadeStyle.Black);
		}

		// Token: 0x06015301 RID: 86785 RVA: 0x00560F88 File Offset: 0x0055F188
		private void FettersUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUITask_OnStopTask_hotfix != null)
			{
				this.m_FettersUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fettersUITask == task)
			{
				this.m_fettersUITask.EventOnStop -= this.FettersUITask_OnStop;
				this.m_fettersUITask.EventOnStartHeroDungeon -= this.FetterUITask_StartHeroDungeon;
				this.m_fettersUITask = null;
			}
		}

		// Token: 0x06015302 RID: 86786 RVA: 0x0056103C File Offset: 0x0055F23C
		private void FettersUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_FettersUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(FettersUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015303 RID: 86787 RVA: 0x005610D0 File Offset: 0x0055F2D0
		private void FetterUITask_StartHeroDungeon(Hero hero, UIIntent fromIntent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FetterUITask_StartHeroDungeonHeroUIIntent_hotfix != null)
			{
				this.m_FetterUITask_StartHeroDungeonHeroUIIntent_hotfix.call(new object[]
				{
					this,
					hero,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartHeroDungeonUITask(null, false, hero, fromIntent);
		}

		// Token: 0x06015304 RID: 86788 RVA: 0x0056115C File Offset: 0x0055F35C
		private void StartArenaSelectUITask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaSelectUITaskArenaUITypeBooleanUIIntent_hotfix != null)
			{
				this.m_StartArenaSelectUITaskArenaUITypeBooleanUIIntent_hotfix.call(new object[]
				{
					this,
					arenaUIType,
					isBattleReport,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(ArenaSelectUITask).Name, null);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_RealTimePVP))
			{
				if (arenaUIType != ArenaUIType.None)
				{
					uiintentReturnable.SetParam("ArenaUIType", arenaUIType);
					uiintentReturnable.SetParam("IsBattleReport", isBattleReport);
				}
				ArenaSelectUITask arenaSelectUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.ArenaSelectUITask_OnLoadAllResCompleted)) as ArenaSelectUITask;
				if (this.m_arenaSelectUITask == null)
				{
					this.m_arenaSelectUITask = arenaSelectUITask;
					this.m_arenaSelectUITask.EventOnStop += this.ArenaSelectUITask_OnStop;
					this.m_arenaSelectUITask.EventOnShowArena += this.ArenaSelectUITask_OnShowArena;
				}
			}
			else if (arenaUIType == ArenaUIType.Online)
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_RealTimePVP), 2f, null, true);
			}
			else
			{
				this.InitAndStartArenaUITask(ArenaUIType.Offline, isBattleReport, fromIntent);
			}
		}

		// Token: 0x06015305 RID: 86789 RVA: 0x005612E8 File Offset: 0x0055F4E8
		private void ArenaSelectUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaSelectUITask_OnStopTask_hotfix != null)
			{
				this.m_ArenaSelectUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaSelectUITask == task)
			{
				this.m_arenaSelectUITask.EventOnStop -= this.ArenaSelectUITask_OnStop;
				this.m_arenaSelectUITask.EventOnShowArena -= this.ArenaSelectUITask_OnShowArena;
				this.m_arenaSelectUITask = null;
			}
		}

		// Token: 0x06015306 RID: 86790 RVA: 0x0056139C File Offset: 0x0055F59C
		private void ArenaSelectUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaSelectUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ArenaSelectUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ArenaSelectUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015307 RID: 86791 RVA: 0x00561418 File Offset: 0x0055F618
		private void ArenaSelectUITask_OnShowArena(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaSelectUITask_OnShowArenaArenaUITypeBooleanUIIntent_hotfix != null)
			{
				this.m_ArenaSelectUITask_OnShowArenaArenaUITypeBooleanUIIntent_hotfix.call(new object[]
				{
					this,
					arenaUIType,
					isBattleReport,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitAndStartArenaUITask(arenaUIType, isBattleReport, fromIntent);
		}

		// Token: 0x06015308 RID: 86792 RVA: 0x005614B4 File Offset: 0x0055F6B4
		private void StartArenaUITask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaUITaskArenaUITypeBooleanUIIntent_hotfix != null)
			{
				this.m_StartArenaUITaskArenaUITypeBooleanUIIntent_hotfix.call(new object[]
				{
					this,
					arenaUIType,
					isBattleReport,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(ArenaUITask).Name, null);
			uiintentReturnable.SetParam("ArenaUIType", arenaUIType);
			uiintentReturnable.SetParam("IsBattleReport", isBattleReport);
			ArenaUITask arenaUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.ArenaUITask_OnLoadAllResCompleted)) as ArenaUITask;
			if (this.m_arenaUITask == null)
			{
				this.m_arenaUITask = arenaUITask;
				this.m_arenaUITask.EventOnStop += this.ArenaUITask_OnStop;
				this.m_arenaUITask.EventOnStartArenaBattle += this.ArenaUITask_OnStartArenaBattle;
				this.m_arenaUITask.EventOnStartArenaBattleReplay += this.ArenaUITask_OnStartArenaBattleReplay;
				this.m_arenaUITask.EventOnStartRealTimePVPBattleReplay += this.ArenaUITask_OnStartRealTimePVPBattleReplay;
			}
		}

		// Token: 0x06015309 RID: 86793 RVA: 0x00561618 File Offset: 0x0055F818
		private void ArenaUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ArenaUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ArenaUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601530A RID: 86794 RVA: 0x005616AC File Offset: 0x0055F8AC
		private void ArenaUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUITask_OnStopTask_hotfix != null)
			{
				this.m_ArenaUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaUITask == task)
			{
				this.m_arenaUITask.EventOnStop -= this.ArenaUITask_OnStop;
				this.m_arenaUITask.EventOnStartArenaBattle -= this.ArenaUITask_OnStartArenaBattle;
				this.m_arenaUITask.EventOnStartArenaBattleReplay -= this.ArenaUITask_OnStartArenaBattleReplay;
				this.m_arenaUITask.EventOnStartRealTimePVPBattleReplay -= this.ArenaUITask_OnStartRealTimePVPBattleReplay;
				this.m_arenaUITask = null;
			}
		}

		// Token: 0x0601530B RID: 86795 RVA: 0x0056178C File Offset: 0x0055F98C
		private void ArenaUITask_OnStartArenaBattle(bool isRevenge)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUITask_OnStartArenaBattleBoolean_hotfix != null)
			{
				this.m_ArenaUITask_OnStartArenaBattleBoolean_hotfix.call(new object[]
				{
					this,
					isRevenge
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartArenaBattleUITask(isRevenge);
		}

		// Token: 0x0601530C RID: 86796 RVA: 0x00561804 File Offset: 0x0055FA04
		private void ArenaUITask_OnStartArenaBattleReplay(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUITask_OnStartArenaBattleReplayArenaBattleReport_hotfix != null)
			{
				this.m_ArenaUITask_OnStartArenaBattleReplayArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartArenaReplayBattleUITask(battleReport);
		}

		// Token: 0x0601530D RID: 86797 RVA: 0x0056187C File Offset: 0x0055FA7C
		private void ArenaUITask_OnStartRealTimePVPBattleReplay(RealTimePVPBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaUITask_OnStartRealTimePVPBattleReplayRealTimePVPBattleReport_hotfix != null)
			{
				this.m_ArenaUITask_OnStartRealTimePVPBattleReplayRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartRealTimePVPReplayBattleUITask(battleReport);
		}

		// Token: 0x0601530E RID: 86798 RVA: 0x005618F4 File Offset: 0x0055FAF4
		private void InitAndStartArenaUITask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAndStartArenaUITaskArenaUITypeBooleanUIIntent_hotfix != null)
			{
				this.m_InitAndStartArenaUITaskArenaUITypeBooleanUIIntent_hotfix.call(new object[]
				{
					this,
					arenaUIType2,
					isBattleReport2,
					fromIntent2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaUIType arenaUIType = arenaUIType2;
			bool isBattleReport = isBattleReport2;
			UIIntent fromIntent = fromIntent2;
			WorldUITask $this = this;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (arenaUIType == ArenaUIType.Offline)
			{
				if (playerContext.IsArenaInSettleTime())
				{
					CommonUIController.Instance.ShowErrorMessage(-2017, 2f, null, true);
					return;
				}
				this.StartShowFadeOutLoadingFadeIn(delegate
				{
					if (playerContext.IsNeedGetArenaPlayerInfo())
					{
						ArenaPlayerInfoGetNetTask arenaPlayerInfoGetNetTask = new ArenaPlayerInfoGetNetTask();
						arenaPlayerInfoGetNetTask.EventOnStop += delegate(Task task)
						{
							ArenaPlayerInfoGetNetTask arenaPlayerInfoGetNetTask2 = task as ArenaPlayerInfoGetNetTask;
							if (arenaPlayerInfoGetNetTask2.Result == 0)
							{
								$this.StartArenaBattleReportBasicDataGetNetTask(arenaUIType, isBattleReport, fromIntent);
							}
							else
							{
								$this.HideFadeOutLoadingFadeIn();
								CommonUIController.Instance.ShowErrorMessage(arenaPlayerInfoGetNetTask2.Result, 2f, null, true);
							}
						};
						arenaPlayerInfoGetNetTask.Start(null);
					}
					else
					{
						$this.StartArenaUITask(arenaUIType, isBattleReport, fromIntent);
					}
				}, FadeStyle.Black);
			}
			else if (arenaUIType == ArenaUIType.Online)
			{
				this.StartShowFadeOutLoadingFadeIn(delegate
				{
					if (playerContext.IsNeedGetRealTimePVPPlayerInfo())
					{
						RealTimePVPGetInfoNetTask realTimePVPGetInfoNetTask = new RealTimePVPGetInfoNetTask();
						realTimePVPGetInfoNetTask.EventOnStop += delegate(Task task)
						{
							RealTimePVPGetInfoNetTask realTimePVPGetInfoNetTask2 = task as RealTimePVPGetInfoNetTask;
							if (realTimePVPGetInfoNetTask2.Result == 0)
							{
								$this.StartArenaBattleReportBasicDataGetNetTask(arenaUIType, isBattleReport, fromIntent);
							}
							else
							{
								$this.HideFadeOutLoadingFadeIn();
								CommonUIController.Instance.ShowErrorMessage(realTimePVPGetInfoNetTask2.Result, 2f, null, true);
							}
						};
						realTimePVPGetInfoNetTask.Start(null);
					}
					else
					{
						$this.StartArenaUITask(arenaUIType, isBattleReport, fromIntent);
					}
				}, FadeStyle.Black);
			}
		}

		// Token: 0x0601530F RID: 86799 RVA: 0x00561A28 File Offset: 0x0055FC28
		private void StartArenaBattleReportBasicDataGetNetTask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleReportBasicDataGetNetTaskArenaUITypeBooleanUIIntent_hotfix != null)
			{
				this.m_StartArenaBattleReportBasicDataGetNetTaskArenaUITypeBooleanUIIntent_hotfix.call(new object[]
				{
					this,
					arenaUIType2,
					isBattleReport2,
					fromIntent2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaUIType arenaUIType = arenaUIType2;
			bool isBattleReport = isBattleReport2;
			UIIntent fromIntent = fromIntent2;
			WorldUITask $this = this;
			if (arenaUIType == ArenaUIType.Offline)
			{
				ArenaBattleReportBasicDataGetNetTask arenaBattleReportBasicDataGetNetTask = new ArenaBattleReportBasicDataGetNetTask();
				arenaBattleReportBasicDataGetNetTask.EventOnStop += delegate(Task task)
				{
					ArenaBattleReportBasicDataGetNetTask arenaBattleReportBasicDataGetNetTask2 = task as ArenaBattleReportBasicDataGetNetTask;
					if (arenaBattleReportBasicDataGetNetTask2.Result == 0)
					{
						$this.StartArenaUITask(arenaUIType, isBattleReport, fromIntent);
					}
					else
					{
						$this.HideFadeOutLoadingFadeIn();
						CommonUIController.Instance.ShowErrorMessage(arenaBattleReportBasicDataGetNetTask2.Result, 2f, null, true);
					}
				};
				arenaBattleReportBasicDataGetNetTask.Start(null);
			}
			else if (arenaUIType == ArenaUIType.Online)
			{
				this.StartArenaUITask(arenaUIType, isBattleReport, fromIntent);
			}
		}

		// Token: 0x06015310 RID: 86800 RVA: 0x00561B30 File Offset: 0x0055FD30
		private void StartStoreUITask(StoreId storeId = StoreId.StoreId_None, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartStoreUITaskStoreIdUIIntent_hotfix != null)
			{
				this.m_StartStoreUITaskStoreIdUIIntent_hotfix.call(new object[]
				{
					this,
					storeId,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(StoreUITask).Name, null);
			if (storeId != StoreId.StoreId_None)
			{
				intent.SetParam("StoreInfoID", (int)storeId);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.StoreUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015311 RID: 86801 RVA: 0x00561C18 File Offset: 0x0055FE18
		private void StoreUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_StoreUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(StoreUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015312 RID: 86802 RVA: 0x00561CAC File Offset: 0x0055FEAC
		private void StartSelectCardUITask(int cardPoolId = 0, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartSelectCardUITaskInt32UIIntent_hotfix != null)
			{
				this.m_StartSelectCardUITaskInt32UIIntent_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(SelectCardUITask).Name, null);
			if (cardPoolId > 0)
			{
				intent.SetParam("CardPoolID", cardPoolId);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.SelectCardUITask_OnLoadAllResCompleted));
			}, FadeStyle.White);
		}

		// Token: 0x06015313 RID: 86803 RVA: 0x00561D94 File Offset: 0x0055FF94
		private void SelectCardUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_SelectCardUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(SelectCardUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015314 RID: 86804 RVA: 0x00561E28 File Offset: 0x00560028
		private void StartDrillUITask(int drillState = 0, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartDrillUITaskInt32UIIntent_hotfix != null)
			{
				this.m_StartDrillUITaskInt32UIIntent_hotfix.call(new object[]
				{
					this,
					drillState,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(DrillUITask).Name, null);
			intent.SetParam("DrillState", drillState);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.DrillUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015315 RID: 86805 RVA: 0x00561F08 File Offset: 0x00560108
		private void DrillUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_DrillUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(DrillUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015316 RID: 86806 RVA: 0x00561F9C File Offset: 0x0056019C
		private void StartFriendUITask(UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartFriendUITaskUIIntent_hotfix != null)
			{
				this.m_StartFriendUITaskUIIntent_hotfix.call(new object[]
				{
					this,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(FriendUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.FriendUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015317 RID: 86807 RVA: 0x00562058 File Offset: 0x00560258
		private void StartGuildUITask(UIIntent fromIntent = null, bool goToGuildMassiveCombat = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGuildUITaskUIIntentBoolean_hotfix != null)
			{
				this.m_StartGuildUITaskUIIntentBoolean_hotfix.call(new object[]
				{
					this,
					fromIntent2,
					goToGuildMassiveCombat2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntent fromIntent = fromIntent2;
			bool goToGuildMassiveCombat = goToGuildMassiveCombat2;
			WorldUITask $this = this;
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext.GetGuildId() == null)
				{
					UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? $this.m_currIntent, typeof(GuildUITask).Name, null);
					UIManager.Instance.StartUITask(intent, true, false, delegate
					{
						$this.HideFadeOutLoadingFadeIn();
						UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GuildUITask));
						if (uitaskBase != null)
						{
							uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
						}
					});
				}
				else
				{
					UIIntentReturnable uiintentReturnable = new UIIntentReturnable(fromIntent ?? $this.m_currIntent, typeof(GuildManagementUITask).Name, null);
					if (goToGuildMassiveCombat)
					{
						uiintentReturnable.SetParam("GoToGuildMassiveCombat", true);
					}
					UIManager.Instance.StartUITask(uiintentReturnable, true, false, delegate
					{
						$this.HideFadeOutLoadingFadeIn();
						GuildManagementUITask.GuildManagementUITask_OnLoadAllResCompleted();
					});
				}
			}, FadeStyle.Black);
		}

		// Token: 0x06015318 RID: 86808 RVA: 0x00562108 File Offset: 0x00560308
		private void FriendUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_FriendUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(FriendUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015319 RID: 86809 RVA: 0x0056219C File Offset: 0x0056039C
		private void StartMailUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartMailUITask_hotfix != null)
			{
				this.m_StartMailUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateNewMailCount();
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(MailUITask).Name, null);
			UIManager.Instance.StartUITaskWithPrepare(intent, delegate(bool isSucceed)
			{
				if (isSucceed)
				{
					base.Pause();
					this.m_clientWorld.ShowWorld(false);
				}
				else
				{
					global::Debug.LogError("WorldUITask.StartMailUITask Fail");
				}
			}, true);
		}

		// Token: 0x0601531A RID: 86810 RVA: 0x00562238 File Offset: 0x00560438
		private void StartRankingUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRankingUITask_hotfix != null)
			{
				this.m_StartRankingUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int errorCode = 0;
			if (!projectLPlayerContext.IsAbleQueryRankingListInfo(RankingListType.TopHero, out errorCode))
			{
				CommonUIController.Instance.ShowErrorMessage(errorCode, 2f, null, true);
				return;
			}
			RankingUITask.StartRankingUITask(delegate(bool res)
			{
				if (res)
				{
					base.Pause();
					this.m_clientWorld.ShowWorld(false);
				}
				else
				{
					global::Debug.LogError("WorldUITask.StartRankingUITask Fail");
				}
			}, this.m_currIntent, RankingListType.TopHero);
		}

		// Token: 0x0601531B RID: 86811 RVA: 0x005622E4 File Offset: 0x005604E4
		private void StartActivityUITask(int activityId = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartActivityUITaskInt32_hotfix != null)
			{
				this.m_StartActivityUITaskInt32_hotfix.call(new object[]
				{
					this,
					activityId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(ActivityUITask).Name, null);
			if (activityId > 0)
			{
				intent.SetParam("ActivityId", activityId);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.ActivityUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601531C RID: 86812 RVA: 0x005623B4 File Offset: 0x005605B4
		private void ActivityUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ActivityUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ActivityUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601531D RID: 86813 RVA: 0x00562448 File Offset: 0x00560648
		private void StartTeamUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamUITask_hotfix != null)
			{
				this.m_StartTeamUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(TeamUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601531E RID: 86814 RVA: 0x005624EC File Offset: 0x005606EC
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
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TeamUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601531F RID: 86815 RVA: 0x00562574 File Offset: 0x00560774
		private void StartTestUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTestUITask_hotfix != null)
			{
				this.m_StartTestUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(TestUITask).Name, null);
			TestUITask testUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.TestUITask_OnLoadAllResCompleted)) as TestUITask;
			if (this.m_testUITask == null)
			{
				this.m_testUITask = testUITask;
				this.m_testUITask.EventOnStop += this.TestUITask_OnStop;
				this.m_testUITask.EventOnStartBattle += this.TestUITask_OnStartBattle;
			}
		}

		// Token: 0x06015320 RID: 86816 RVA: 0x00562650 File Offset: 0x00560850
		private void TestUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUITask_OnStopTask_hotfix != null)
			{
				this.m_TestUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_testUITask == task)
			{
				this.m_testUITask.EventOnStop -= this.TestUITask_OnStop;
				this.m_testUITask.EventOnStartBattle -= this.TestUITask_OnStartBattle;
				this.m_testUITask = null;
			}
		}

		// Token: 0x06015321 RID: 86817 RVA: 0x00562704 File Offset: 0x00560904
		private void TestUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_TestUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TestUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015322 RID: 86818 RVA: 0x00562788 File Offset: 0x00560988
		private void TestUITask_OnStartBattle(ConfigDataBattleInfo battleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUITask_OnStartBattleConfigDataBattleInfo_hotfix != null)
			{
				this.m_TestUITask_OnStartBattleConfigDataBattleInfo_hotfix.call(new object[]
				{
					this,
					battleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBattleUITask(battleInfo, BattleType.None);
		}

		// Token: 0x06015323 RID: 86819 RVA: 0x00562800 File Offset: 0x00560A00
		private void StartUnchartedUITask(BattleType battleType = BattleType.None, int chapterId = 0, int tabIndex = 0, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUnchartedUITaskBattleTypeInt32Int32UIIntent_hotfix != null)
			{
				this.m_StartUnchartedUITaskBattleTypeInt32Int32UIIntent_hotfix.call(new object[]
				{
					this,
					battleType,
					chapterId,
					tabIndex,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(UnchartedUITask).Name, null);
			if (battleType != BattleType.None)
			{
				intent.SetParam("BattleType", battleType);
				intent.SetParam("ChapterId", chapterId);
			}
			if (tabIndex != 0)
			{
				intent.SetParam("TabIndex", tabIndex);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UnchartedUITask unchartedUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.UnchartedUITask_OnLoadAllResCompleted)) as UnchartedUITask;
				if (this.m_unchartedUITask == null)
				{
					this.m_unchartedUITask = unchartedUITask;
					this.m_unchartedUITask.EventOnStop += this.UnchartedUITask_OnStop;
				}
			}, FadeStyle.Black);
		}

		// Token: 0x06015324 RID: 86820 RVA: 0x00562938 File Offset: 0x00560B38
		private void UnchartedUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedUITask_OnStopTask_hotfix != null)
			{
				this.m_UnchartedUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedUITask == task)
			{
				this.m_unchartedUITask.EventOnStop -= this.UnchartedUITask_OnStop;
				this.m_unchartedUITask = null;
			}
		}

		// Token: 0x06015325 RID: 86821 RVA: 0x005629D4 File Offset: 0x00560BD4
		private void UnchartedUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_UnchartedUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(UnchartedUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015326 RID: 86822 RVA: 0x00562A68 File Offset: 0x00560C68
		public static void StartUnchartedSubUITask(BattleType battleType, int chapterId, UIIntent fromIntent)
		{
			if (WorldUITask.s_instance != null)
			{
				WorldUITask.s_instance._StartUnchartedSubUITask(battleType, chapterId, fromIntent);
			}
		}

		// Token: 0x06015327 RID: 86823 RVA: 0x00562A84 File Offset: 0x00560C84
		private void _StartUnchartedSubUITask(BattleType battleType, int chapterId, UIIntent fromIntent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__StartUnchartedSubUITaskBattleTypeInt32UIIntent_hotfix != null)
			{
				this.m__StartUnchartedSubUITaskBattleTypeInt32UIIntent_hotfix.call(new object[]
				{
					this,
					battleType,
					chapterId,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (battleType == BattleType.AnikiGym)
			{
				ConfigDataAnikiGymInfo configDataAnikiGymInfo = configDataLoader.GetConfigDataAnikiGymInfo(chapterId);
				this.StartAnikiUITask(configDataAnikiGymInfo, fromIntent);
			}
			else if (battleType == BattleType.ThearchyTrial)
			{
				ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = configDataLoader.GetConfigDataThearchyTrialInfo(chapterId);
				this.StartThearchyUITask(configDataThearchyTrialInfo, fromIntent);
			}
			else if (battleType == BattleType.TreasureMap)
			{
				this.StartTreasureMapUITask(fromIntent);
			}
			else if (battleType == BattleType.MemoryCorridor)
			{
				ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = configDataLoader.GetConfigDataMemoryCorridorInfo(chapterId);
				this.StartMemoryCorridorUITask(configDataMemoryCorridorInfo, fromIntent);
			}
			else if (battleType == BattleType.HeroTrainning)
			{
				ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = configDataLoader.GetConfigDataHeroTrainningInfo(chapterId);
				this.StartHeroTrainningUITask(configDataHeroTrainningInfo, fromIntent);
			}
			else if (battleType == BattleType.CooperateBattle)
			{
				ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = configDataLoader.GetConfigDataCooperateBattleInfo(chapterId);
				this.StartCooperateBattleUITask(configDataCooperateBattleInfo, fromIntent);
			}
			else if (battleType == BattleType.HeroPhantom)
			{
				ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = configDataLoader.GetConfigDataHeroPhantomInfo(chapterId);
				this.StartHeroPhantomUITask(configDataHeroPhantomInfo, fromIntent);
			}
			else if (battleType == BattleType.UnchartedScore_ScoreLevel)
			{
				ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = configDataLoader.GetConfigDataUnchartedScoreInfo(chapterId);
				this.StartUnchartedScoreUITask(configDataUnchartedScoreInfo, battleType, fromIntent);
			}
			else if (battleType == BattleType.UnchartedScore_ChallengeLevel)
			{
				ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo2 = configDataLoader.GetConfigDataUnchartedScoreInfo(chapterId);
				this.StartUnchartedScoreUITask(configDataUnchartedScoreInfo2, battleType, fromIntent);
			}
			else if (battleType == BattleType.ClimbTower)
			{
				this.StartClimbTowerUITask(fromIntent);
			}
		}

		// Token: 0x06015328 RID: 86824 RVA: 0x00562C38 File Offset: 0x00560E38
		private void StartRiftUITask(ConfigDataRiftLevelInfo levelInfo, bool openLevelInfo, bool needReturnToChapter = true, UIIntent fromIntent = null, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRiftUITaskConfigDataRiftLevelInfoBooleanBooleanUIIntentNeedGoods_hotfix != null)
			{
				this.m_StartRiftUITaskConfigDataRiftLevelInfoBooleanBooleanUIIntentNeedGoods_hotfix.call(new object[]
				{
					this,
					levelInfo,
					openLevelInfo,
					needReturnToChapter,
					fromIntent,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(RiftUITask).Name, null);
			intent.SetParam("RiftNeedReturnToChapter", needReturnToChapter);
			if (levelInfo != null)
			{
				intent.SetParam("ChapterInfo", levelInfo.m_chapterInfo);
				if (openLevelInfo)
				{
					intent.SetParam("RiftLevelInfo", levelInfo);
				}
			}
			if (needGoods != null)
			{
				intent.SetParam("RaidNeedGoods", needGoods);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				RiftUITask riftUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.RiftUITask_OnLoadAllResCompleted)) as RiftUITask;
				if (this.m_riftUITask == null)
				{
					this.m_riftUITask = riftUITask;
					this.m_riftUITask.EventOnStop += this.RiftUITask_OnStop;
					this.m_riftUITask.EventOnGoToScenario += this.RiftUITask_GoToScenario;
				}
			}, FadeStyle.White);
		}

		// Token: 0x06015329 RID: 86825 RVA: 0x00562D94 File Offset: 0x00560F94
		private void RiftUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftUITask_OnStopTask_hotfix != null)
			{
				this.m_RiftUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftUITask == task)
			{
				this.m_riftUITask.EventOnStop -= this.RiftUITask_OnStop;
				this.m_riftUITask.EventOnGoToScenario -= this.RiftUITask_GoToScenario;
				this.m_riftUITask = null;
			}
		}

		// Token: 0x0601532A RID: 86826 RVA: 0x00562E48 File Offset: 0x00561048
		private void RiftUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_RiftUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(RiftUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601532B RID: 86827 RVA: 0x00562EDC File Offset: 0x005610DC
		private void RiftUITask_GoToScenario(int scenarioID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftUITask_GoToScenarioInt32_hotfix != null)
			{
				this.m_RiftUITask_GoToScenarioInt32_hotfix.call(new object[]
				{
					this,
					scenarioID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(scenarioID);
			if (configDataScenarioInfo != null)
			{
				ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(configDataScenarioInfo.Waypoint_ID);
				if (waypoint != null)
				{
					this.m_clientWorld.WorldCamera.SmoothLook(waypoint.Position, null);
				}
			}
		}

		// Token: 0x0601532C RID: 86828 RVA: 0x00562F90 File Offset: 0x00561190
		private void StartHeroDungeonUITask(ConfigDataHeroDungeonLevelInfo levelInfo, bool openLevelInfo, Hero hero = null, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonUITaskConfigDataHeroDungeonLevelInfoBooleanHeroUIIntent_hotfix != null)
			{
				this.m_StartHeroDungeonUITaskConfigDataHeroDungeonLevelInfoBooleanHeroUIIntent_hotfix.call(new object[]
				{
					this,
					levelInfo,
					openLevelInfo,
					hero,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(HeroDungeonUITask).Name, null);
			if (hero != null)
			{
				ConfigDataHeroInformationInfo configDataHeroInformationInfo = this.m_configDataLoader.GetConfigDataHeroInformationInfo(hero.HeroInfo.HeroInformation_ID);
				if (configDataHeroInformationInfo != null)
				{
					intent.SetParam("HeroInformationInfo", configDataHeroInformationInfo);
				}
			}
			if (levelInfo != null)
			{
				ConfigDataHeroInformationInfo configDataHeroInformationInfo2 = this.m_configDataLoader.GetConfigDataHeroInformationInfo(levelInfo.m_chapterId);
				if (configDataHeroInformationInfo2 != null)
				{
					intent.SetParam("HeroInformationInfo", configDataHeroInformationInfo2);
				}
				if (openLevelInfo)
				{
					intent.SetParam("HeroDungeonLevelInfo", levelInfo);
				}
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.HeroDungeonUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601532D RID: 86829 RVA: 0x005630F4 File Offset: 0x005612F4
		private void HeroDungeonUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDungeonUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_HeroDungeonUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroDungeonUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601532E RID: 86830 RVA: 0x00563188 File Offset: 0x00561388
		private void StartHeroPhantomUITask(ConfigDataHeroPhantomInfo heroPhantomInfo, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroPhantomUITaskConfigDataHeroPhantomInfoUIIntent_hotfix != null)
			{
				this.m_StartHeroPhantomUITaskConfigDataHeroPhantomInfoUIIntent_hotfix.call(new object[]
				{
					this,
					heroPhantomInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(HeroPhantomUITask).Name, null);
			if (heroPhantomInfo != null)
			{
				intent.SetParam("HeroPhantomInfo", heroPhantomInfo);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.HeroPhantomUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601532F RID: 86831 RVA: 0x00563268 File Offset: 0x00561468
		private void HeroPhantomUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroPhantomUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_HeroPhantomUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroPhantomUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015330 RID: 86832 RVA: 0x005632FC File Offset: 0x005614FC
		private void StartThearchyUITask(ConfigDataThearchyTrialInfo thearchyTrialInfo, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartThearchyUITaskConfigDataThearchyTrialInfoUIIntent_hotfix != null)
			{
				this.m_StartThearchyUITaskConfigDataThearchyTrialInfoUIIntent_hotfix.call(new object[]
				{
					this,
					thearchyTrialInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(ThearchyUITask).Name, null);
			if (thearchyTrialInfo != null)
			{
				intent.SetParam("ThearchyTrialInfo", thearchyTrialInfo);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.ThearchyUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015331 RID: 86833 RVA: 0x005633DC File Offset: 0x005615DC
		private void ThearchyUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ThearchyUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ThearchyUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015332 RID: 86834 RVA: 0x00563470 File Offset: 0x00561670
		private void StartAnikiUITask(ConfigDataAnikiGymInfo anikiGymInfo, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartAnikiUITaskConfigDataAnikiGymInfoUIIntent_hotfix != null)
			{
				this.m_StartAnikiUITaskConfigDataAnikiGymInfoUIIntent_hotfix.call(new object[]
				{
					this,
					anikiGymInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(AnikiUITask).Name, null);
			if (anikiGymInfo != null)
			{
				intent.SetParam("AnikiGymInfo", anikiGymInfo);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.AnikiUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015333 RID: 86835 RVA: 0x00563550 File Offset: 0x00561750
		private void AnikiUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_AnikiUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(AnikiUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015334 RID: 86836 RVA: 0x005635E4 File Offset: 0x005617E4
		private void StartTreasureMapUITask(UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTreasureMapUITaskUIIntent_hotfix != null)
			{
				this.m_StartTreasureMapUITaskUIIntent_hotfix.call(new object[]
				{
					this,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(TreasureMapUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TreasureMapUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015335 RID: 86837 RVA: 0x005636A0 File Offset: 0x005618A0
		private void TreasureMapUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TreasureMapUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_TreasureMapUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TreasureMapUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015336 RID: 86838 RVA: 0x00563734 File Offset: 0x00561934
		private void StartMemoryCorridorUITask(ConfigDataMemoryCorridorInfo memoryCorridorInfo, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartMemoryCorridorUITaskConfigDataMemoryCorridorInfoUIIntent_hotfix != null)
			{
				this.m_StartMemoryCorridorUITaskConfigDataMemoryCorridorInfoUIIntent_hotfix.call(new object[]
				{
					this,
					memoryCorridorInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(MemoryCorridorUITask).Name, null);
			if (memoryCorridorInfo != null)
			{
				intent.SetParam("MemoryCorridorInfo", memoryCorridorInfo);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.MemoryCorridorUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015337 RID: 86839 RVA: 0x00563814 File Offset: 0x00561A14
		private void MemoryCorridorUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_MemoryCorridorUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(MemoryCorridorUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015338 RID: 86840 RVA: 0x005638A8 File Offset: 0x00561AA8
		private void StartHeroTrainningUITask(ConfigDataHeroTrainningInfo heroTrainningInfo, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroTrainningUITaskConfigDataHeroTrainningInfoUIIntent_hotfix != null)
			{
				this.m_StartHeroTrainningUITaskConfigDataHeroTrainningInfoUIIntent_hotfix.call(new object[]
				{
					this,
					heroTrainningInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(HeroTrainningUITask).Name, null);
			if (heroTrainningInfo != null)
			{
				intent.SetParam("HeroTrainningInfo", heroTrainningInfo);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.HeroTrainningUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x06015339 RID: 86841 RVA: 0x00563988 File Offset: 0x00561B88
		private void HeroTrainningUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroTrainningUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_HeroTrainningUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroTrainningUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601533A RID: 86842 RVA: 0x00563A1C File Offset: 0x00561C1C
		private void StartCooperateBattleUITask(ConfigDataCooperateBattleInfo cooperateBattleInfo, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCooperateBattleUITaskConfigDataCooperateBattleInfoUIIntent_hotfix != null)
			{
				this.m_StartCooperateBattleUITaskConfigDataCooperateBattleInfoUIIntent_hotfix.call(new object[]
				{
					this,
					cooperateBattleInfo,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(CooperateBattleUITask).Name, null);
			if (cooperateBattleInfo != null)
			{
				intent.SetParam("CooperateBattleInfo", cooperateBattleInfo);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.CooperateBattleUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601533B RID: 86843 RVA: 0x00563AFC File Offset: 0x00561CFC
		private void CooperateBattleUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_CooperateBattleUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(CooperateBattleUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601533C RID: 86844 RVA: 0x00563B90 File Offset: 0x00561D90
		private void StartUnchartedScoreUITask(ConfigDataUnchartedScoreInfo unchartedScoreInfo, BattleType battleType, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUnchartedScoreUITaskConfigDataUnchartedScoreInfoBattleTypeUIIntent_hotfix != null)
			{
				this.m_StartUnchartedScoreUITaskConfigDataUnchartedScoreInfoBattleTypeUIIntent_hotfix.call(new object[]
				{
					this,
					unchartedScoreInfo,
					battleType,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(UnchartedScoreUITask).Name, null);
			if (unchartedScoreInfo != null)
			{
				intent.SetParam("UnchartedScoreInfo", unchartedScoreInfo);
			}
			if (battleType != BattleType.None)
			{
				intent.SetParam("BattleType", battleType);
			}
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.UnchartedScoreUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601533D RID: 86845 RVA: 0x00563C9C File Offset: 0x00561E9C
		private void UnchartedScoreUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_UnchartedScoreUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(UnchartedScoreUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601533E RID: 86846 RVA: 0x00563D30 File Offset: 0x00561F30
		private void StartClimbTowerUITask(UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClimbTowerUITaskUIIntent_hotfix != null)
			{
				this.m_StartClimbTowerUITaskUIIntent_hotfix.call(new object[]
				{
					this,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(fromIntent ?? this.m_currIntent, typeof(ClimbTowerUITask).Name, null);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.ClimbTowerUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black);
		}

		// Token: 0x0601533F RID: 86847 RVA: 0x00563DEC File Offset: 0x00561FEC
		private void ClimbTowerUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_ClimbTowerUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ClimbTowerUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015340 RID: 86848 RVA: 0x00563E80 File Offset: 0x00562080
		private void StartWorldEventMissionUITask(ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartWorldEventMissionUITaskConfigDataEventInfo_hotfix != null)
			{
				this.m_StartWorldEventMissionUITaskConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					eventInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventInfo == null)
			{
				return;
			}
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(WorldEventMissionUITask).Name, null);
			uiintentCustom.SetParam("EventInfo", eventInfo);
			WorldEventMissionUITask worldEventMissionUITask = UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as WorldEventMissionUITask;
			if (this.m_worldEventMissionUITask == null)
			{
				this.m_worldEventMissionUITask = worldEventMissionUITask;
				this.m_worldEventMissionUITask.EventOnStop += this.WorldEventMissionUITask_OnStop;
				this.m_worldEventMissionUITask.EventOnEnterMission += this.WorldEventMissionUITask_OnEnterMission;
				this.m_worldEventMissionUITask.EventOnClose += this.WorldEventMissionUITask_OnClose;
			}
		}

		// Token: 0x06015341 RID: 86849 RVA: 0x00563F84 File Offset: 0x00562184
		private void WorldEventMissionUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldEventMissionUITask_OnStopTask_hotfix != null)
			{
				this.m_WorldEventMissionUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldEventMissionUITask == task)
			{
				this.m_worldEventMissionUITask.EventOnStop -= this.WorldEventMissionUITask_OnStop;
				this.m_worldEventMissionUITask.EventOnEnterMission -= this.WorldEventMissionUITask_OnEnterMission;
				this.m_worldEventMissionUITask.EventOnClose -= this.WorldEventMissionUITask_OnClose;
				this.m_worldEventMissionUITask = null;
			}
		}

		// Token: 0x06015342 RID: 86850 RVA: 0x0056404C File Offset: 0x0056224C
		private void WorldEventMissionUITask_OnEnterMission()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldEventMissionUITask_OnEnterMission_hotfix != null)
			{
				this.m_WorldEventMissionUITask_OnEnterMission_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataEventInfo eventInfo = projectLPlayerContext.Happening.EventInfo;
			if (eventInfo != null)
			{
				this.StartHappening(BattleType.WayPoint, eventInfo.m_battleInfo, eventInfo.MonsterLevel, eventInfo.m_dialogInfoBefore, eventInfo.m_dialogInfoAfter);
			}
		}

		// Token: 0x06015343 RID: 86851 RVA: 0x005640F0 File Offset: 0x005622F0
		private void WorldEventMissionUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldEventMissionUITask_OnClose_hotfix != null)
			{
				this.m_WorldEventMissionUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MoveToPrevWaypoint(false);
		}

		// Token: 0x06015344 RID: 86852 RVA: 0x00564158 File Offset: 0x00562358
		private void StartGoddessDialogUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGoddessDialogUITask_hotfix != null)
			{
				this.m_StartGoddessDialogUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Utility.LogMemorySize("WorldUITask.StartGoddessDialogUITask");
			CommonUIController.Instance.FadeOut(0f, Color.white, null);
			base.Pause();
			this.m_clientWorld.ShowWorld(false);
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(GoddessDialogUITask).Name, null);
			GoddessDialogUITask goddessDialogUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.GoddessDialogUITask_OnLoadAllResCompleted)) as GoddessDialogUITask;
			if (this.m_goddessDialogUITask == null)
			{
				this.m_goddessDialogUITask = goddessDialogUITask;
				this.m_goddessDialogUITask.EventOnClose += this.GoddessDialogUITask_OnClose;
			}
		}

		// Token: 0x06015345 RID: 86853 RVA: 0x00564250 File Offset: 0x00562450
		private void GoddessDialogUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_GoddessDialogUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GoddessDialogUITask));
			if (uitaskBase != null)
			{
				CommonUIController.Instance.FadeIn(2f, Color.white, null);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015346 RID: 86854 RVA: 0x005642E4 File Offset: 0x005624E4
		private void GoddessDialogUITask_OnClose(int protagonistId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUITask_OnCloseInt32_hotfix != null)
			{
				this.m_GoddessDialogUITask_OnCloseInt32_hotfix.call(new object[]
				{
					this,
					protagonistId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isResumeNeedNextWorldStep = false;
			if (this.m_goddessDialogUITask != null)
			{
				this.m_goddessDialogUITask.EventOnClose -= this.GoddessDialogUITask_OnClose;
				this.m_goddessDialogUITask = null;
			}
			this.StartSetProtagonistNetTask(protagonistId);
		}

		// Token: 0x06015347 RID: 86855 RVA: 0x0056438C File Offset: 0x0056258C
		private void StartDialogUITask(ConfigDataDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartDialogUITaskConfigDataDialogInfo_hotfix != null)
			{
				this.m_StartDialogUITaskConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(DialogUITask).Name, null);
			intent.SetParam("DialogInfo", dialogInfo);
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				DialogUITask dialogUITask = UIManager.Instance.StartUITask(intent, true, false, new Action(this.DialogUITask_OnLoadAllResCompleted)) as DialogUITask;
				if (this.m_dialogUITask == null)
				{
					this.m_dialogUITask = dialogUITask;
					this.m_dialogUITask.EventOnClose += this.DialogUITask_OnClose;
				}
			}, FadeStyle.Black);
		}

		// Token: 0x06015348 RID: 86856 RVA: 0x00564458 File Offset: 0x00562658
		private void DialogUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DialogUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_DialogUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(DialogUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				this.m_clientWorld.ShowWorld(false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06015349 RID: 86857 RVA: 0x005644EC File Offset: 0x005626EC
		private void DialogUITask_OnClose(bool isSkip)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DialogUITask_OnCloseBoolean_hotfix != null)
			{
				this.m_DialogUITask_OnCloseBoolean_hotfix.call(new object[]
				{
					this,
					isSkip
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogUITask != null)
			{
				this.m_dialogUITask.EventOnClose -= this.DialogUITask_OnClose;
				this.m_dialogUITask = null;
			}
			this.NextHappeningStep();
		}

		// Token: 0x0601534A RID: 86858 RVA: 0x0056458C File Offset: 0x0056278C
		private void StartBattleUITask(ConfigDataBattleInfo battleInfo, BattleType battleType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleUITaskConfigDataBattleInfoBattleType_hotfix != null)
			{
				this.m_StartBattleUITaskConfigDataBattleInfoBattleType_hotfix.call(new object[]
				{
					this,
					battleInfo2,
					battleType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBattleInfo battleInfo = battleInfo2;
			WorldUITask $this = this;
			if (battleInfo == null)
			{
				return;
			}
			global::Debug.Log(string.Format("WorldUITask.StartBattleUITask BattleId:{0}, BattleType:{1}", battleInfo.ID, battleType));
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			playerContext.SetCurrentBattle(battleInfo, battleType);
			WorldUITask.HideInviteAndChatUITask();
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				WorldUITask.StartBattleArmyRandomSeedGetNetTask(battleInfo.ID, delegate(int result)
				{
					if (result != -99)
					{
						if (playerContext.CanUseDanmaku())
						{
							WorldUITask.StartDanmakuGetNetTaskNetTask(delegate(int result2)
							{
								if (result2 != -99)
								{
									$this.Stop();
									WorldUITask.UnloadAssetsAndStartBattleUITask();
								}
							});
						}
						else
						{
							$this.Stop();
							WorldUITask.UnloadAssetsAndStartBattleUITask();
						}
					}
				});
			}, FadeStyle.Black);
		}

		// Token: 0x0601534B RID: 86859 RVA: 0x00564690 File Offset: 0x00562890
		private static void HideInviteAndChatUITask()
		{
			InviteNotifyUITask.StopUITask();
			ChatUITask.PauseUITask();
		}

		// Token: 0x0601534C RID: 86860 RVA: 0x0056469C File Offset: 0x0056289C
		private static void UnloadAssetsAndStartBattleUITask()
		{
			CommonUIController.Instance.StartCoroutine(WorldUITask.Co_UnloadAssetsAndStartBattleUITask());
		}

		// Token: 0x0601534D RID: 86861 RVA: 0x005646B0 File Offset: 0x005628B0
		private static IEnumerator Co_UnloadAssetsAndStartBattleUITask()
		{
			for (int i = 0; i < 3; i++)
			{
				ResourceManager.Instance.UnloadUnusedAssets();
				yield return Resources.UnloadUnusedAssets();
			}
			UIIntent intent = new UIIntent(typeof(BattleUITask).Name, null);
			UIManager instance = UIManager.Instance;
			UIIntent intent2 = intent;
			bool pushIntentToStack = true;
			bool clearIntentStack = true;
			if (WorldUITask.<>f__mg$cache0 == null)
			{
				WorldUITask.<>f__mg$cache0 = new Action(WorldUITask.BattleUITask_OnLoadAllResCompleted);
			}
			instance.StartUITask(intent2, pushIntentToStack, clearIntentStack, WorldUITask.<>f__mg$cache0);
			yield break;
		}

		// Token: 0x0601534E RID: 86862 RVA: 0x005646C4 File Offset: 0x005628C4
		private static void BattleUITask_OnLoadAllResCompleted()
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(BattleUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601534F RID: 86863 RVA: 0x005646F0 File Offset: 0x005628F0
		private void StartArenaBattleUITask(bool isRevenge)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleUITaskBoolean_hotfix != null)
			{
				this.m_StartArenaBattleUITaskBoolean_hotfix.call(new object[]
				{
					this,
					isRevenge
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = projectLPlayerContext.GetArenaOpponentDefensiveBattleInfo();
			if (arenaOpponentDefensiveBattleInfo == null)
			{
				global::Debug.LogError("WorldUITask.StartArenaBattleUITask fail, defensiveInfo is null");
				return;
			}
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_configDataLoader.GetConfigDataArenaBattleInfo(arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.BattleId);
			if (configDataArenaBattleInfo == null)
			{
				global::Debug.LogError(string.Format("WorldUITask.StartArenaBattleUITask fail, arenaBattleInfo is null, BattleId:{0}", arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.BattleId));
				return;
			}
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = this.m_configDataLoader.GetConfigDataArenaDefendRuleInfo(arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.ArenaDefenderRuleId);
			if (configDataArenaDefendRuleInfo == null)
			{
				global::Debug.LogError(string.Format("WorldUITask.StartArenaBattleUITask fail, defendRuleInfo is null, RuleId:{0}", arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.ArenaDefenderRuleId));
				return;
			}
			global::Debug.Log(string.Format("WorldUITask.StartArenaBattleUITask BattleId:{0}, RuleId:{1}", configDataArenaBattleInfo.ID, configDataArenaDefendRuleInfo.ID));
			projectLPlayerContext.SetCurrentArenaBattle(configDataArenaBattleInfo, configDataArenaDefendRuleInfo, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.PlayerLevel, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.DefenderHeroes, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.Techs, isRevenge);
			projectLPlayerContext.SetArenaBattleRandomSeed(arenaOpponentDefensiveBattleInfo.BattleRandomSeed);
			this.FadeOutAndStartBattleUITask();
		}

		// Token: 0x06015350 RID: 86864 RVA: 0x00564864 File Offset: 0x00562A64
		private void StartArenaReplayBattleUITask(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaReplayBattleUITaskArenaBattleReport_hotfix != null)
			{
				this.m_StartArenaReplayBattleUITaskArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_configDataLoader.GetConfigDataArenaBattleInfo(battleReport.BattleId);
			if (configDataArenaBattleInfo == null)
			{
				global::Debug.LogError(string.Format("WorldUITask.StartArenaReplayBattleUITask fail, arenaBattleInfo is null, BattleId:{0}", battleReport.BattleId));
				return;
			}
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = this.m_configDataLoader.GetConfigDataArenaDefendRuleInfo(battleReport.ArenaDefenderRuleId);
			if (configDataArenaDefendRuleInfo == null)
			{
				global::Debug.LogError(string.Format("WorldUITask.StartArenaReplayBattleUITask fail, defendRuleInfo is null, RuleId:{0}", battleReport.ArenaDefenderRuleId));
				return;
			}
			global::Debug.Log(string.Format("WorldUITask.StartArenaReplayBattleUITask BattleId:{0}, RuleId:{1}", configDataArenaBattleInfo.ID, configDataArenaDefendRuleInfo.ID));
			projectLPlayerContext.SetCurrentArenaBattle(configDataArenaBattleInfo, configDataArenaDefendRuleInfo, battleReport.DefenderLevel, battleReport.DefenderHeroes, battleReport.DefenderTechs, false);
			projectLPlayerContext.SetCurrentArenaBattleReport(battleReport);
			projectLPlayerContext.SetArenaBattleRandomSeed(battleReport.RandomSeed);
			this.FadeOutAndStartBattleUITask();
		}

		// Token: 0x06015351 RID: 86865 RVA: 0x005649A4 File Offset: 0x00562BA4
		private void StartRealTimePVPReplayBattleUITask(RealTimePVPBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRealTimePVPReplayBattleUITaskRealTimePVPBattleReport_hotfix != null)
			{
				this.m_StartRealTimePVPReplayBattleUITaskRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = this.m_configDataLoader.GetConfigDataRealTimePVPBattleInfo(battleReport.BattleId);
			if (configDataRealTimePVPBattleInfo == null)
			{
				global::Debug.LogError(string.Format("WorldUITask.StartRealTimePVPReplayBattleUITask fail, realtimePVPBattleInfo is null, BattleId:{0}", battleReport.BattleId));
				return;
			}
			global::Debug.Log(string.Format("WorldUITask.StartRealTimePVPReplayBattleUITask BattleId:{0}", configDataRealTimePVPBattleInfo.ID));
			projectLPlayerContext.SetCurrentRealTimePVPBattle(configDataRealTimePVPBattleInfo);
			projectLPlayerContext.SetCurrentRealTimePVPBattleReport(battleReport);
			projectLPlayerContext.SetBattleRandomSeed(battleReport.RandomSeed);
			this.FadeOutAndStartBattleUITask();
		}

		// Token: 0x06015352 RID: 86866 RVA: 0x00564A94 File Offset: 0x00562C94
		private void FadeOutAndStartBattleUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeOutAndStartBattleUITask_hotfix != null)
			{
				this.m_FadeOutAndStartBattleUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			WorldUITask.HideInviteAndChatUITask();
			this.StartShowFadeOutLoadingFadeIn(delegate
			{
				base.Stop();
				WorldUITask.UnloadAssetsAndStartBattleUITask();
			}, FadeStyle.Black);
		}

		// Token: 0x06015353 RID: 86867 RVA: 0x00564B0C File Offset: 0x00562D0C
		[DoNotToLua]
		public static int CanGotoGetPath(GetPathData getPathInfo, ref FadeStyle fadeStyle)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = 0;
			switch (getPathInfo.PathType)
			{
			case GetPathType.GetPathType_Rift:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Rift))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_Rift), 2f, null, true);
					return 1;
				}
				if (getPathInfo.ID > 0)
				{
					num = projectLPlayerContext.CanAttackRiftLevel(getPathInfo.ID);
				}
				fadeStyle = FadeStyle.White;
				break;
			case GetPathType.GetPathType_Aniki:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AnikiGym))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_AnikiGym), 2f, null, true);
					return 1;
				}
				if (getPathInfo.ID > 0)
				{
					num = projectLPlayerContext.CanAttackAnikiLevel(getPathInfo.ID);
				}
				break;
			case GetPathType.GetPathType_ThearchyTrial:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ThearchyTrial))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_ThearchyTrial), 2f, null, true);
					return 1;
				}
				if (getPathInfo.ID > 0)
				{
					num = projectLPlayerContext.CanAttackThearchyLevel(getPathInfo.ID);
				}
				break;
			case GetPathType.GetPathType_Summon1:
			case GetPathType.GetPathType_Summon2:
			case GetPathType.GetPathType_Summon3:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SelectCard))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_SelectCard), 2f, null, true);
					return 1;
				}
				fadeStyle = FadeStyle.White;
				break;
			case GetPathType.GetPathType_MemoryCorridor:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_MemoryCorridor))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_MemoryCorridor), 2f, null, true);
					return 1;
				}
				if (getPathInfo.ID > 0)
				{
					num = projectLPlayerContext.CanAttackMemoryCorridorLevel(getPathInfo.ID);
				}
				break;
			case GetPathType.GetPathType_HeroTraining:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroTrainning))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_HeroTrainning), 2f, null, true);
					return 1;
				}
				if (getPathInfo.ID > 0)
				{
					num = projectLPlayerContext.CanAttackHeroTrainningLevel(getPathInfo.ID);
				}
				break;
			case GetPathType.GetPathType_Drill1:
			case GetPathType.GetPathType_Drill2:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TrainingGround))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_TrainingGround), 2f, null, true);
					return 1;
				}
				break;
			case GetPathType.GetPathType_Fetter:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Fetters))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_Fetters), 2f, null, true);
					return 1;
				}
				break;
			case GetPathType.GetPathType_Arena:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ArenaBattle))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_ArenaBattle), 2f, null, true);
					return 1;
				}
				if (projectLPlayerContext.IsArenaInSettleTime())
				{
					CommonUIController.Instance.ShowErrorMessage(-2017, 2f, null, true);
					return 1;
				}
				break;
			case GetPathType.GetPathType_TreasureMap:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TreasureMap))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_TreasureMap), 2f, null, true);
					return 1;
				}
				break;
			case GetPathType.GetPathType_HeroDungeon:
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroDungeon))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_HeroDungeon), 2f, null, true);
					return 1;
				}
				if (getPathInfo.ID > 0)
				{
					num = projectLPlayerContext.CanAttackHeroDungeonLevel(getPathInfo.ID);
					if (num == -2905)
					{
						num = 0;
					}
				}
				break;
			case GetPathType.GetPathType_Store8:
				if (projectLPlayerContext.GetAllStarLvlMaxHeroFragements().Count <= 0 && !LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction)
				{
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					CommonUIController.Instance.ShowMessage(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_MemoryStoreNotOpen), 2f, null, true);
					return 1;
				}
				break;
			}
			return num;
		}

		// Token: 0x06015354 RID: 86868 RVA: 0x00564ED8 File Offset: 0x005630D8
		public static void StartGetPathTargetUITask(GetPathData getPath, UIIntent fromIntent, NeedGoods needGoods = null)
		{
			if (WorldUITask.s_instance != null)
			{
				WorldUITask.s_instance._StartGetPathTargetUITask(getPath, fromIntent, needGoods);
			}
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x00564EF4 File Offset: 0x005630F4
		private void _StartGetPathTargetUITask(GetPathData getPath, UIIntent fromIntent, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__StartGetPathTargetUITaskGetPathDataUIIntentNeedGoods_hotfix != null)
			{
				this.m__StartGetPathTargetUITaskGetPathDataUIIntentNeedGoods_hotfix.call(new object[]
				{
					this,
					getPath,
					fromIntent,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (getPath.PathType)
			{
			case GetPathType.GetPathType_Rift:
				if (getPath.ID > 0)
				{
					ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(getPath.ID);
					if (configDataRiftLevelInfo != null)
					{
						this.StartRiftUITask(configDataRiftLevelInfo, true, false, fromIntent, needGoods);
					}
				}
				else
				{
					this.StartRiftUITask(null, false, true, null, null);
				}
				break;
			case GetPathType.GetPathType_Aniki:
				if (getPath.ID > 0)
				{
					ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(getPath.ID);
					if (configDataAnikiLevelInfo != null)
					{
						this.StartAnikiUITask(configDataAnikiLevelInfo.m_groupInfo, fromIntent);
					}
				}
				else
				{
					this.StartAnikiUITask(null, fromIntent);
				}
				break;
			case GetPathType.GetPathType_ThearchyTrial:
				if (getPath.ID > 0)
				{
					ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(getPath.ID);
					if (configDataThearchyTrialLevelInfo != null)
					{
						this.StartThearchyUITask(configDataThearchyTrialLevelInfo.m_groupInfo, fromIntent);
					}
				}
				else
				{
					this.StartThearchyUITask(null, fromIntent);
				}
				break;
			case GetPathType.GetPathType_Store1:
				this.StartStoreUITask(StoreId.StoreId_BlackMarket, fromIntent);
				break;
			case GetPathType.GetPathType_Store2:
				this.StartStoreUITask(StoreId.StoreId_Crystal, fromIntent);
				break;
			case GetPathType.GetPathType_Store3:
				this.StartStoreUITask(StoreId.StoreId_Honor, fromIntent);
				break;
			case GetPathType.GetPathType_Summon1:
				this.StartSelectCardUITask(1, fromIntent);
				break;
			case GetPathType.GetPathType_Summon2:
				this.StartSelectCardUITask(2, fromIntent);
				break;
			case GetPathType.GetPathType_MemoryCorridor:
				if (getPath.ID > 0)
				{
					ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(getPath.ID);
					if (configDataMemoryCorridorLevelInfo != null)
					{
						this.StartMemoryCorridorUITask(configDataMemoryCorridorLevelInfo.m_groupInfo, fromIntent);
					}
				}
				else
				{
					this.StartMemoryCorridorUITask(null, fromIntent);
				}
				break;
			case GetPathType.GetPathType_HeroTraining:
				if (getPath.ID > 0)
				{
					ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(getPath.ID);
					if (configDataHeroTrainningLevelInfo != null)
					{
						this.StartHeroTrainningUITask(configDataHeroTrainningLevelInfo.m_groupInfo, fromIntent);
					}
				}
				else
				{
					this.StartHeroTrainningUITask(null, fromIntent);
				}
				break;
			case GetPathType.GetPathType_Store4:
				this.StartStoreUITask(StoreId.StoreId_Friendship, fromIntent);
				break;
			case GetPathType.GetPathType_Summon3:
				this.StartSelectCardUITask(3, fromIntent);
				break;
			case GetPathType.GetPathType_HeroList:
				this.StartHeroUITask(fromIntent);
				break;
			case GetPathType.GetPathType_Drill1:
				this.StartDrillUITask(0, fromIntent);
				break;
			case GetPathType.GetPathType_Drill2:
				this.StartDrillUITask(1, fromIntent);
				break;
			case GetPathType.GetPathType_Fetter:
				this.StartFettersUITask(null, fromIntent);
				break;
			case GetPathType.GetPathType_World:
				this.StartShowFadeOutLoadingFadeIn(delegate
				{
					this.HideFadeOutLoadingFadeIn();
					UIManager.Instance.ReturnUITask(this.m_currIntent);
				}, FadeStyle.Black);
				break;
			case GetPathType.GetPathType_Arena:
				this.StartArenaSelectUITask(ArenaUIType.Offline, false, fromIntent);
				break;
			case GetPathType.GetPathType_Uncharted1:
				this.StartUnchartedUITask(BattleType.None, 0, 1, fromIntent);
				break;
			case GetPathType.GetPathType_Uncharted2:
				this.StartUnchartedUITask(BattleType.None, 0, 2, fromIntent);
				break;
			case GetPathType.GetPathType_Friend:
				this.StartFriendUITask(fromIntent);
				break;
			case GetPathType.GetPathType_TreasureMap:
				this.StartUnchartedUITask(BattleType.TreasureMap, 0, 0, fromIntent);
				break;
			case GetPathType.GetPathType_Mission:
				this.StartMissionUITask(fromIntent);
				break;
			case GetPathType.GetPathType_HeroDungeon:
				if (getPath.ID > 0)
				{
					ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(getPath.ID);
					if (configDataHeroDungeonLevelInfo != null)
					{
						this.StartHeroDungeonUITask(configDataHeroDungeonLevelInfo, true, null, fromIntent);
					}
				}
				break;
			case GetPathType.GetPathType_Store5:
				this.StartStoreUITask(StoreId.StoreId_Recharge, fromIntent);
				break;
			case GetPathType.GetPathType_Store6:
				this.StartStoreUITask(StoreId.StoreId_Gift, fromIntent);
				break;
			case GetPathType.GetPathType_Activity:
				this.StartActivityUITask(getPath.ID);
				break;
			case GetPathType.GetPathType_Store7:
				this.StartStoreUITask(StoreId.StoreId_Equipment, fromIntent);
				break;
			case GetPathType.GetPathType_Store8:
				this.StartStoreUITask(StoreId.StoreId_Memory, fromIntent);
				break;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x06015356 RID: 86870 RVA: 0x005652E4 File Offset: 0x005634E4
		// (set) Token: 0x06015357 RID: 86871 RVA: 0x00565304 File Offset: 0x00563504
		[DoNotToLua]
		public new WorldUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06015358 RID: 86872 RVA: 0x00565310 File Offset: 0x00563510
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06015359 RID: 86873 RVA: 0x0056531C File Offset: 0x0056351C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601535A RID: 86874 RVA: 0x00565324 File Offset: 0x00563524
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0601535B RID: 86875 RVA: 0x0056532C File Offset: 0x0056352C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601535C RID: 86876 RVA: 0x00565338 File Offset: 0x00563538
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601535D RID: 86877 RVA: 0x00565344 File Offset: 0x00563544
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601535E RID: 86878 RVA: 0x00565350 File Offset: 0x00563550
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601535F RID: 86879 RVA: 0x00565358 File Offset: 0x00563558
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06015360 RID: 86880 RVA: 0x00565360 File Offset: 0x00563560
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06015361 RID: 86881 RVA: 0x00565368 File Offset: 0x00563568
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06015362 RID: 86882 RVA: 0x00565370 File Offset: 0x00563570
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06015363 RID: 86883 RVA: 0x00565378 File Offset: 0x00563578
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06015364 RID: 86884 RVA: 0x00565380 File Offset: 0x00563580
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06015365 RID: 86885 RVA: 0x00565388 File Offset: 0x00563588
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06015366 RID: 86886 RVA: 0x00565394 File Offset: 0x00563594
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06015367 RID: 86887 RVA: 0x005653A0 File Offset: 0x005635A0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06015368 RID: 86888 RVA: 0x005653AC File Offset: 0x005635AC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06015369 RID: 86889 RVA: 0x005653B8 File Offset: 0x005635B8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0601536A RID: 86890 RVA: 0x005653C0 File Offset: 0x005635C0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0601536B RID: 86891 RVA: 0x005653C8 File Offset: 0x005635C8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0601536C RID: 86892 RVA: 0x005653D0 File Offset: 0x005635D0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601536D RID: 86893 RVA: 0x005653D8 File Offset: 0x005635D8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0601536E RID: 86894 RVA: 0x005653E0 File Offset: 0x005635E0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601537A RID: 86906 RVA: 0x0056561C File Offset: 0x0056381C
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectPlayerAssets_hotfix = (luaObj.RawGet("CollectPlayerAssets") as LuaFunction);
					this.m_CollectEventAssets_hotfix = (luaObj.RawGet("CollectEventAssets") as LuaFunction);
					this.m_CollectMonthCardAssets_hotfix = (luaObj.RawGet("CollectMonthCardAssets") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_HideAllView_hotfix = (luaObj.RawGet("HideAllView") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_InitWorldMapUIController_hotfix = (luaObj.RawGet("InitWorldMapUIController") as LuaFunction);
					this.m_UninitWorldMapUIController_hotfix = (luaObj.RawGet("UninitWorldMapUIController") as LuaFunction);
					this.m_InitWorldUIController_hotfix = (luaObj.RawGet("InitWorldUIController") as LuaFunction);
					this.m_UninitWorldUIController_hotfix = (luaObj.RawGet("UninitWorldUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateRedMarks_hotfix = (luaObj.RawGet("UpdateRedMarks") as LuaFunction);
					this.m_UpdatePlayerInfo_hotfix = (luaObj.RawGet("UpdatePlayerInfo") as LuaFunction);
					this.m_UpdateCurrentScenario_hotfix = (luaObj.RawGet("UpdateCurrentScenario") as LuaFunction);
					this.m_UpdateHeroRedMark_hotfix = (luaObj.RawGet("UpdateHeroRedMark") as LuaFunction);
					this.m_UpdateMissionRedMark_hotfix = (luaObj.RawGet("UpdateMissionRedMark") as LuaFunction);
					this.m_UpdateActivityRedMark_hotfix = (luaObj.RawGet("UpdateActivityRedMark") as LuaFunction);
					this.m_UpdateFriendRedMark_hotfix = (luaObj.RawGet("UpdateFriendRedMark") as LuaFunction);
					this.m_UpdateDrillRedMark_hotfix = (luaObj.RawGet("UpdateDrillRedMark") as LuaFunction);
					this.m_UpdateFetterRedMark_hotfix = (luaObj.RawGet("UpdateFetterRedMark") as LuaFunction);
					this.m_UpdateGuildRedMark_hotfix = (luaObj.RawGet("UpdateGuildRedMark") as LuaFunction);
					this.m_UpdateWorldEventRedMark_hotfix = (luaObj.RawGet("UpdateWorldEventRedMark") as LuaFunction);
					this.m_UpdateInvestigationButton_hotfix = (luaObj.RawGet("UpdateInvestigationButton") as LuaFunction);
					this.m_UpdateOpenServiceActivityButton_hotfix = (luaObj.RawGet("UpdateOpenServiceActivityButton") as LuaFunction);
					this.m_UpdateCooperateBattleButton_hotfix = (luaObj.RawGet("UpdateCooperateBattleButton") as LuaFunction);
					this.m_UpdateMonthCardInfo_hotfix = (luaObj.RawGet("UpdateMonthCardInfo") as LuaFunction);
					this.m_OnSlowTick_hotfix = (luaObj.RawGet("OnSlowTick") as LuaFunction);
					this.m_ShowEventList_hotfix = (luaObj.RawGet("ShowEventList") as LuaFunction);
					this.m_HasRandomEvent_hotfix = (luaObj.RawGet("HasRandomEvent") as LuaFunction);
					this.m_UpdateNewChatCount_hotfix = (luaObj.RawGet("UpdateNewChatCount") as LuaFunction);
					this.m_UpdateNewMailCount_hotfix = (luaObj.RawGet("UpdateNewMailCount") as LuaFunction);
					this.m_CreateClientWorld_hotfix = (luaObj.RawGet("CreateClientWorld") as LuaFunction);
					this.m_DestroyClientWorld_hotfix = (luaObj.RawGet("DestroyClientWorld") as LuaFunction);
					this.m_StartClientWorld_hotfix = (luaObj.RawGet("StartClientWorld") as LuaFunction);
					this.m_NextWorldStepBoolean_hotfix = (luaObj.RawGet("NextWorldStep") as LuaFunction);
					this.m_WorldUIGetReady_hotfix = (luaObj.RawGet("WorldUIGetReady") as LuaFunction);
					this.m_ClickFirstWaypoint_hotfix = (luaObj.RawGet("ClickFirstWaypoint") as LuaFunction);
					this.m_StartSetProtagonistNetTaskInt32_hotfix = (luaObj.RawGet("StartSetProtagonistNetTask") as LuaFunction);
					this.m_WorldUIController_OnShowMainButtonBarBoolean_hotfix = (luaObj.RawGet("WorldUIController_OnShowMainButtonBar") as LuaFunction);
					this.m_WorldUIController_OnShowPlayerInfo_hotfix = (luaObj.RawGet("WorldUIController_OnShowPlayerInfo") as LuaFunction);
					this.m_WorldUIController_OnCompass_hotfix = (luaObj.RawGet("WorldUIController_OnCompass") as LuaFunction);
					this.m_WorldUIController_OnCurrentScenario_hotfix = (luaObj.RawGet("WorldUIController_OnCurrentScenario") as LuaFunction);
					this.m_WorldUIController_OnUnlockScenarioGotoRiftLevelConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("WorldUIController_OnUnlockScenarioGotoRiftLevel") as LuaFunction);
					this.m_WorldUIController_OnGotoEventConfigDataWaypointInfoConfigDataEventInfo_hotfix = (luaObj.RawGet("WorldUIController_OnGotoEvent") as LuaFunction);
					this.m_WorldUIController_OnStartPastScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("WorldUIController_OnStartPastScenario") as LuaFunction);
					this.m_WorldUIController_OnClosePastScenarioList_hotfix = (luaObj.RawGet("WorldUIController_OnClosePastScenarioList") as LuaFunction);
					this.m_WorldUIController_OnShowEvent_hotfix = (luaObj.RawGet("WorldUIController_OnShowEvent") as LuaFunction);
					this.m_WorldUIController_OnShowHero_hotfix = (luaObj.RawGet("WorldUIController_OnShowHero") as LuaFunction);
					this.m_WorldUIController_OnShowBag_hotfix = (luaObj.RawGet("WorldUIController_OnShowBag") as LuaFunction);
					this.m_WorldUIController_OnShowMission_hotfix = (luaObj.RawGet("WorldUIController_OnShowMission") as LuaFunction);
					this.m_WorldUIController_OnShowFetter_hotfix = (luaObj.RawGet("WorldUIController_OnShowFetter") as LuaFunction);
					this.m_WorldUIController_OnShowStore_hotfix = (luaObj.RawGet("WorldUIController_OnShowStore") as LuaFunction);
					this.m_WorldUIController_OnShowSelectCard_hotfix = (luaObj.RawGet("WorldUIController_OnShowSelectCard") as LuaFunction);
					this.m_WorldUIController_OnShowDrill_hotfix = (luaObj.RawGet("WorldUIController_OnShowDrill") as LuaFunction);
					this.m_WorldUIController_OnShowFriend_hotfix = (luaObj.RawGet("WorldUIController_OnShowFriend") as LuaFunction);
					this.m_WorldUIController_OnShowGuild_hotfix = (luaObj.RawGet("WorldUIController_OnShowGuild") as LuaFunction);
					this.m_WorldUIController_OnShowUncharted_hotfix = (luaObj.RawGet("WorldUIController_OnShowUncharted") as LuaFunction);
					this.m_WorldUIController_OnShowArena_hotfix = (luaObj.RawGet("WorldUIController_OnShowArena") as LuaFunction);
					this.m_WorldUIController_OnShowRift_hotfix = (luaObj.RawGet("WorldUIController_OnShowRift") as LuaFunction);
					this.m_WorldUIController_OnShowTest_hotfix = (luaObj.RawGet("WorldUIController_OnShowTest") as LuaFunction);
					this.m_WorldUIController_OnShowCooperateBattle_hotfix = (luaObj.RawGet("WorldUIController_OnShowCooperateBattle") as LuaFunction);
					this.m_WorldUIController_OnShowMail_hotfix = (luaObj.RawGet("WorldUIController_OnShowMail") as LuaFunction);
					this.m_WorldUIController_OnShowChat_hotfix = (luaObj.RawGet("WorldUIController_OnShowChat") as LuaFunction);
					this.m_WorldUIController_OnShowRanking_hotfix = (luaObj.RawGet("WorldUIController_OnShowRanking") as LuaFunction);
					this.m_WorldUIController_OnShowActivity_hotfix = (luaObj.RawGet("WorldUIController_OnShowActivity") as LuaFunction);
					this.m_WorldUIController_OnShowOpenServiceActivity_hotfix = (luaObj.RawGet("WorldUIController_OnShowOpenServiceActivity") as LuaFunction);
					this.m_WorldUIController_OnMonthCardButtonClick_hotfix = (luaObj.RawGet("WorldUIController_OnMonthCardButtonClick") as LuaFunction);
					this.m_WorldUIController_OnRefreshMonthCardPanelBoolean_hotfix = (luaObj.RawGet("WorldUIController_OnRefreshMonthCardPanel") as LuaFunction);
					this.m_WorldUIController_OnMonthCardItemClickInt32_hotfix = (luaObj.RawGet("WorldUIController_OnMonthCardItemClick") as LuaFunction);
					this.m_WorldUIController_OnMonthCardItemBuyClickInt32_hotfix = (luaObj.RawGet("WorldUIController_OnMonthCardItemBuyClick") as LuaFunction);
					this.m_WorldUIController_OnOpenWebInvestigation_hotfix = (luaObj.RawGet("WorldUIController_OnOpenWebInvestigation") as LuaFunction);
					this.m_WorldUIController_OnYYBButtonClick_hotfix = (luaObj.RawGet("WorldUIController_OnYYBButtonClick") as LuaFunction);
					this.m_WorldUIController_OnOppoButtonClick_hotfix = (luaObj.RawGet("WorldUIController_OnOppoButtonClick") as LuaFunction);
					this.m_PDSDK_OnDoQuestionSucceed_hotfix = (luaObj.RawGet("PDSDK_OnDoQuestionSucceed") as LuaFunction);
					this.m_PDSDK_OnDoQuestionFailed_hotfix = (luaObj.RawGet("PDSDK_OnDoQuestionFailed") as LuaFunction);
					this.m_WorldUIController_OnShowSign_hotfix = (luaObj.RawGet("WorldUIController_OnShowSign") as LuaFunction);
					this.m_WorldUIController_OnShowActivityNotice_hotfix = (luaObj.RawGet("WorldUIController_OnShowActivityNotice") as LuaFunction);
					this.m_GetRewardGoodsUITask_OnStopTask_hotfix = (luaObj.RawGet("GetRewardGoodsUITask_OnStop") as LuaFunction);
					this.m_GetRewardGoodsUITask_OnClose_hotfix = (luaObj.RawGet("GetRewardGoodsUITask_OnClose") as LuaFunction);
					this.m_ChestUITask_OnStopTask_hotfix = (luaObj.RawGet("ChestUITask_OnStop") as LuaFunction);
					this.m_ChestUITask_OnClose_hotfix = (luaObj.RawGet("ChestUITask_OnClose") as LuaFunction);
					this.m_WorldMapUIController_OnPointerDown_hotfix = (luaObj.RawGet("WorldMapUIController_OnPointerDown") as LuaFunction);
					this.m_WorldMapUIController_OnPointerUp_hotfix = (luaObj.RawGet("WorldMapUIController_OnPointerUp") as LuaFunction);
					this.m_WorldMapUIController_OnPointerClick_hotfix = (luaObj.RawGet("WorldMapUIController_OnPointerClick") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddGold_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddGold") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddCrystal_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddCrystal") as LuaFunction);
					this.m_PlayerContext_OnMailsChangedNtf_hotfix = (luaObj.RawGet("PlayerContext_OnMailsChangedNtf") as LuaFunction);
					this.m_PlayerContext_OnFriendInviteNtf_hotfix = (luaObj.RawGet("PlayerContext_OnFriendInviteNtf") as LuaFunction);
					this.m_PlayerContext_OnFriendInviteAcceptNtfUserSummary_hotfix = (luaObj.RawGet("PlayerContext_OnFriendInviteAcceptNtf") as LuaFunction);
					this.m_PlayerContext_OnFriendshipPointsReceivedNtf_hotfix = (luaObj.RawGet("PlayerContext_OnFriendshipPointsReceivedNtf") as LuaFunction);
					this.m_PlayerContext_EventOnGiftStoreBuyGoodsNtfString_hotfix = (luaObj.RawGet("PlayerContext_EventOnGiftStoreBuyGoodsNtf") as LuaFunction);
					this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix = (luaObj.RawGet("PlayerContext_OnChatMessageNtf") as LuaFunction);
					this.m_PlayerContext_OnMailReadAckInt32_hotfix = (luaObj.RawGet("PlayerContext_OnMailReadAck") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoChangeNtf_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoChangeNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomInviteNtfTeamRoomInviteInfo_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomInviteNtf") as LuaFunction);
					this.m_PlayerContext_OnBattlePracticeInvitedNtfPVPInviteInfo_hotfix = (luaObj.RawGet("PlayerContext_OnBattlePracticeInvitedNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomTeamBattleJoinNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomTeamBattleJoinNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomPVPBattleJoinNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomPVPBattleJoinNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoInitEnd") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_GetClientWorld_hotfix = (luaObj.RawGet("GetClientWorld") as LuaFunction);
					this.m_StartScenarioConfigDataScenarioInfoConfigDataWaypointInfo_hotfix = (luaObj.RawGet("StartScenario") as LuaFunction);
					this.m_StartWaypointEventConfigDataWaypointInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix = (luaObj.RawGet("StartWaypointEvent") as LuaFunction);
					this.m_StartBattleRoomBattle_hotfix = (luaObj.RawGet("StartBattleRoomBattle") as LuaFunction);
					this.m__StartBattleHappeningBattleTypeInt32_hotfix = (luaObj.RawGet("_StartBattleHappening") as LuaFunction);
					this.m_StartHappeningBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix = (luaObj.RawGet("StartHappening") as LuaFunction);
					this.m_NextHappeningStep_hotfix = (luaObj.RawGet("NextHappeningStep") as LuaFunction);
					this.m_StartLevelWayPointMoveNetTaskInt32Action`1_hotfix = (luaObj.RawGet("StartLevelWayPointMoveNetTask") as LuaFunction);
					this.m_StartLevelScenarioHandleNetTaskInt32Action`1_hotfix = (luaObj.RawGet("StartLevelScenarioHandleNetTask") as LuaFunction);
					this.m_OnLevelWayPointMoveNetTaskResultInt32BattleRewardAction`1_hotfix = (luaObj.RawGet("OnLevelWayPointMoveNetTaskResult") as LuaFunction);
					this.m_ShowWaypointRewardBattleRewardBoolean_hotfix = (luaObj.RawGet("ShowWaypointReward") as LuaFunction);
					this.m_CheckChangeCurrentScenarioBoolean_hotfix = (luaObj.RawGet("CheckChangeCurrentScenario") as LuaFunction);
					this.m_Co_ChangeCurrentScenarioConfigDataScenarioInfoBoolean_hotfix = (luaObj.RawGet("Co_ChangeCurrentScenario") as LuaFunction);
					this.m_CheckOpenRiftChapter_hotfix = (luaObj.RawGet("CheckOpenRiftChapter") as LuaFunction);
					this.m_CheckOrderReward_hotfix = (luaObj.RawGet("CheckOrderReward") as LuaFunction);
					this.m_CheckReturnToBeforeBattleUI_hotfix = (luaObj.RawGet("CheckReturnToBeforeBattleUI") as LuaFunction);
					this.m_CheckOpenTeamRoomInfoUI_hotfix = (luaObj.RawGet("CheckOpenTeamRoomInfoUI") as LuaFunction);
					this.m_StartTeamRoomInfoUITask_hotfix = (luaObj.RawGet("StartTeamRoomInfoUITask") as LuaFunction);
					this.m_CheckInBattleRoom_hotfix = (luaObj.RawGet("CheckInBattleRoom") as LuaFunction);
					this.m_MoveToPrevWaypointBoolean_hotfix = (luaObj.RawGet("MoveToPrevWaypoint") as LuaFunction);
					this.m_OnWaypointClickConfigDataWaypointInfo_hotfix = (luaObj.RawGet("OnWaypointClick") as LuaFunction);
					this.m_PlayerArriveWaypointConfigDataWaypointInfoConfigDataWaypointInfo_hotfix = (luaObj.RawGet("PlayerArriveWaypoint") as LuaFunction);
					this.m_ShowPastScenarioListConfigDataWaypointInfo_hotfix = (luaObj.RawGet("ShowPastScenarioList") as LuaFunction);
					this.m_OnScreenEffectString_hotfix = (luaObj.RawGet("OnScreenEffect") as LuaFunction);
					this.m_StartShowFadeOutLoadingFadeInActionFadeStyle_hotfix = (luaObj.RawGet("StartShowFadeOutLoadingFadeIn") as LuaFunction);
					this.m_HideFadeOutLoadingFadeIn_hotfix = (luaObj.RawGet("HideFadeOutLoadingFadeIn") as LuaFunction);
					this.m_StartPlayerInfoUITask_hotfix = (luaObj.RawGet("StartPlayerInfoUITask") as LuaFunction);
					this.m_PlayerInfoUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("PlayerInfoUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_PlayerInfoUITask_OnStopTask_hotfix = (luaObj.RawGet("PlayerInfoUITask_OnStop") as LuaFunction);
					this.m_PlayerInfoUITask_OnClose_hotfix = (luaObj.RawGet("PlayerInfoUITask_OnClose") as LuaFunction);
					this.m_StartAppScoreUITask_hotfix = (luaObj.RawGet("StartAppScoreUITask") as LuaFunction);
					this.m_AppScoreUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("AppScoreUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_AppScoreUITask_OnStopTask_hotfix = (luaObj.RawGet("AppScoreUITask_OnStop") as LuaFunction);
					this.m_AppScoreUITask_OnClose_hotfix = (luaObj.RawGet("AppScoreUITask_OnClose") as LuaFunction);
					this.m_StartSignUITask_hotfix = (luaObj.RawGet("StartSignUITask") as LuaFunction);
					this.m_SignUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("SignUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartActivityNoticeUITask_hotfix = (luaObj.RawGet("StartActivityNoticeUITask") as LuaFunction);
					this.m_ActivityNoticeUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ActivityNoticeUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartHeroUITaskUIIntent_hotfix = (luaObj.RawGet("StartHeroUITask") as LuaFunction);
					this.m_HeroUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("HeroUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartBagUITask_hotfix = (luaObj.RawGet("StartBagUITask") as LuaFunction);
					this.m_BagUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("BagUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartMissionUITaskUIIntent_hotfix = (luaObj.RawGet("StartMissionUITask") as LuaFunction);
					this.m_MissionUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("MissionUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartOpenServiceActivityUITask_hotfix = (luaObj.RawGet("StartOpenServiceActivityUITask") as LuaFunction);
					this.m_OpenServiceActivityUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("OpenServiceActivityUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartFettersUITaskConfigDataHeroDungeonLevelInfoUIIntent_hotfix = (luaObj.RawGet("StartFettersUITask") as LuaFunction);
					this.m_FettersUITask_OnStopTask_hotfix = (luaObj.RawGet("FettersUITask_OnStop") as LuaFunction);
					this.m_FettersUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("FettersUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_FetterUITask_StartHeroDungeonHeroUIIntent_hotfix = (luaObj.RawGet("FetterUITask_StartHeroDungeon") as LuaFunction);
					this.m_StartArenaSelectUITaskArenaUITypeBooleanUIIntent_hotfix = (luaObj.RawGet("StartArenaSelectUITask") as LuaFunction);
					this.m_ArenaSelectUITask_OnStopTask_hotfix = (luaObj.RawGet("ArenaSelectUITask_OnStop") as LuaFunction);
					this.m_ArenaSelectUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ArenaSelectUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_ArenaSelectUITask_OnShowArenaArenaUITypeBooleanUIIntent_hotfix = (luaObj.RawGet("ArenaSelectUITask_OnShowArena") as LuaFunction);
					this.m_StartArenaUITaskArenaUITypeBooleanUIIntent_hotfix = (luaObj.RawGet("StartArenaUITask") as LuaFunction);
					this.m_ArenaUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ArenaUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_ArenaUITask_OnStopTask_hotfix = (luaObj.RawGet("ArenaUITask_OnStop") as LuaFunction);
					this.m_ArenaUITask_OnStartArenaBattleBoolean_hotfix = (luaObj.RawGet("ArenaUITask_OnStartArenaBattle") as LuaFunction);
					this.m_ArenaUITask_OnStartArenaBattleReplayArenaBattleReport_hotfix = (luaObj.RawGet("ArenaUITask_OnStartArenaBattleReplay") as LuaFunction);
					this.m_ArenaUITask_OnStartRealTimePVPBattleReplayRealTimePVPBattleReport_hotfix = (luaObj.RawGet("ArenaUITask_OnStartRealTimePVPBattleReplay") as LuaFunction);
					this.m_InitAndStartArenaUITaskArenaUITypeBooleanUIIntent_hotfix = (luaObj.RawGet("InitAndStartArenaUITask") as LuaFunction);
					this.m_StartArenaBattleReportBasicDataGetNetTaskArenaUITypeBooleanUIIntent_hotfix = (luaObj.RawGet("StartArenaBattleReportBasicDataGetNetTask") as LuaFunction);
					this.m_StartStoreUITaskStoreIdUIIntent_hotfix = (luaObj.RawGet("StartStoreUITask") as LuaFunction);
					this.m_StoreUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("StoreUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartSelectCardUITaskInt32UIIntent_hotfix = (luaObj.RawGet("StartSelectCardUITask") as LuaFunction);
					this.m_SelectCardUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("SelectCardUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartDrillUITaskInt32UIIntent_hotfix = (luaObj.RawGet("StartDrillUITask") as LuaFunction);
					this.m_DrillUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("DrillUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartFriendUITaskUIIntent_hotfix = (luaObj.RawGet("StartFriendUITask") as LuaFunction);
					this.m_StartGuildUITaskUIIntentBoolean_hotfix = (luaObj.RawGet("StartGuildUITask") as LuaFunction);
					this.m_FriendUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("FriendUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartMailUITask_hotfix = (luaObj.RawGet("StartMailUITask") as LuaFunction);
					this.m_StartRankingUITask_hotfix = (luaObj.RawGet("StartRankingUITask") as LuaFunction);
					this.m_StartActivityUITaskInt32_hotfix = (luaObj.RawGet("StartActivityUITask") as LuaFunction);
					this.m_ActivityUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ActivityUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartTeamUITask_hotfix = (luaObj.RawGet("StartTeamUITask") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartTestUITask_hotfix = (luaObj.RawGet("StartTestUITask") as LuaFunction);
					this.m_TestUITask_OnStopTask_hotfix = (luaObj.RawGet("TestUITask_OnStop") as LuaFunction);
					this.m_TestUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TestUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_TestUITask_OnStartBattleConfigDataBattleInfo_hotfix = (luaObj.RawGet("TestUITask_OnStartBattle") as LuaFunction);
					this.m_StartUnchartedUITaskBattleTypeInt32Int32UIIntent_hotfix = (luaObj.RawGet("StartUnchartedUITask") as LuaFunction);
					this.m_UnchartedUITask_OnStopTask_hotfix = (luaObj.RawGet("UnchartedUITask_OnStop") as LuaFunction);
					this.m_UnchartedUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("UnchartedUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m__StartUnchartedSubUITaskBattleTypeInt32UIIntent_hotfix = (luaObj.RawGet("_StartUnchartedSubUITask") as LuaFunction);
					this.m_StartRiftUITaskConfigDataRiftLevelInfoBooleanBooleanUIIntentNeedGoods_hotfix = (luaObj.RawGet("StartRiftUITask") as LuaFunction);
					this.m_RiftUITask_OnStopTask_hotfix = (luaObj.RawGet("RiftUITask_OnStop") as LuaFunction);
					this.m_RiftUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("RiftUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_RiftUITask_GoToScenarioInt32_hotfix = (luaObj.RawGet("RiftUITask_GoToScenario") as LuaFunction);
					this.m_StartHeroDungeonUITaskConfigDataHeroDungeonLevelInfoBooleanHeroUIIntent_hotfix = (luaObj.RawGet("StartHeroDungeonUITask") as LuaFunction);
					this.m_HeroDungeonUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("HeroDungeonUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartHeroPhantomUITaskConfigDataHeroPhantomInfoUIIntent_hotfix = (luaObj.RawGet("StartHeroPhantomUITask") as LuaFunction);
					this.m_HeroPhantomUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("HeroPhantomUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartThearchyUITaskConfigDataThearchyTrialInfoUIIntent_hotfix = (luaObj.RawGet("StartThearchyUITask") as LuaFunction);
					this.m_ThearchyUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ThearchyUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartAnikiUITaskConfigDataAnikiGymInfoUIIntent_hotfix = (luaObj.RawGet("StartAnikiUITask") as LuaFunction);
					this.m_AnikiUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("AnikiUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartTreasureMapUITaskUIIntent_hotfix = (luaObj.RawGet("StartTreasureMapUITask") as LuaFunction);
					this.m_TreasureMapUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TreasureMapUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartMemoryCorridorUITaskConfigDataMemoryCorridorInfoUIIntent_hotfix = (luaObj.RawGet("StartMemoryCorridorUITask") as LuaFunction);
					this.m_MemoryCorridorUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("MemoryCorridorUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartHeroTrainningUITaskConfigDataHeroTrainningInfoUIIntent_hotfix = (luaObj.RawGet("StartHeroTrainningUITask") as LuaFunction);
					this.m_HeroTrainningUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("HeroTrainningUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartCooperateBattleUITaskConfigDataCooperateBattleInfoUIIntent_hotfix = (luaObj.RawGet("StartCooperateBattleUITask") as LuaFunction);
					this.m_CooperateBattleUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("CooperateBattleUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartUnchartedScoreUITaskConfigDataUnchartedScoreInfoBattleTypeUIIntent_hotfix = (luaObj.RawGet("StartUnchartedScoreUITask") as LuaFunction);
					this.m_UnchartedScoreUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("UnchartedScoreUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartClimbTowerUITaskUIIntent_hotfix = (luaObj.RawGet("StartClimbTowerUITask") as LuaFunction);
					this.m_ClimbTowerUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("ClimbTowerUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartWorldEventMissionUITaskConfigDataEventInfo_hotfix = (luaObj.RawGet("StartWorldEventMissionUITask") as LuaFunction);
					this.m_WorldEventMissionUITask_OnStopTask_hotfix = (luaObj.RawGet("WorldEventMissionUITask_OnStop") as LuaFunction);
					this.m_WorldEventMissionUITask_OnEnterMission_hotfix = (luaObj.RawGet("WorldEventMissionUITask_OnEnterMission") as LuaFunction);
					this.m_WorldEventMissionUITask_OnClose_hotfix = (luaObj.RawGet("WorldEventMissionUITask_OnClose") as LuaFunction);
					this.m_StartGoddessDialogUITask_hotfix = (luaObj.RawGet("StartGoddessDialogUITask") as LuaFunction);
					this.m_GoddessDialogUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("GoddessDialogUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_GoddessDialogUITask_OnCloseInt32_hotfix = (luaObj.RawGet("GoddessDialogUITask_OnClose") as LuaFunction);
					this.m_StartDialogUITaskConfigDataDialogInfo_hotfix = (luaObj.RawGet("StartDialogUITask") as LuaFunction);
					this.m_DialogUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("DialogUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_DialogUITask_OnCloseBoolean_hotfix = (luaObj.RawGet("DialogUITask_OnClose") as LuaFunction);
					this.m_StartBattleUITaskConfigDataBattleInfoBattleType_hotfix = (luaObj.RawGet("StartBattleUITask") as LuaFunction);
					this.m_StartArenaBattleUITaskBoolean_hotfix = (luaObj.RawGet("StartArenaBattleUITask") as LuaFunction);
					this.m_StartArenaReplayBattleUITaskArenaBattleReport_hotfix = (luaObj.RawGet("StartArenaReplayBattleUITask") as LuaFunction);
					this.m_StartRealTimePVPReplayBattleUITaskRealTimePVPBattleReport_hotfix = (luaObj.RawGet("StartRealTimePVPReplayBattleUITask") as LuaFunction);
					this.m_FadeOutAndStartBattleUITask_hotfix = (luaObj.RawGet("FadeOutAndStartBattleUITask") as LuaFunction);
					this.m__StartGetPathTargetUITaskGetPathDataUIIntentNeedGoods_hotfix = (luaObj.RawGet("_StartGetPathTargetUITask") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601537B RID: 86907 RVA: 0x00566DF4 File Offset: 0x00564FF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B876 RID: 47222
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "WorldSceneLayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/World_ABS/Prefab/WorldScenePrefab.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "WorldUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/World_ABS/Prefab/WorldUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B877 RID: 47223
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "WorldUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.WorldUIController"),
				m_ctrlName = "WorldUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "WorldUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "PlayerResourceUIController"
			}
		};

		// Token: 0x0400B878 RID: 47224
		private static WorldUITask s_instance;

		// Token: 0x0400B879 RID: 47225
		private static bool s_isShowWorldUI = true;

		// Token: 0x0400B87A RID: 47226
		private WorldUIController m_worldUIController;

		// Token: 0x0400B87B RID: 47227
		private WorldMapUIController m_worldMapUIController;

		// Token: 0x0400B87C RID: 47228
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400B87D RID: 47229
		private ChestUITask m_chestUITask;

		// Token: 0x0400B87E RID: 47230
		private GetRewardGoodsUITask m_getRewardGoodsUITask;

		// Token: 0x0400B87F RID: 47231
		private FettersUITask m_fettersUITask;

		// Token: 0x0400B880 RID: 47232
		private RiftUITask m_riftUITask;

		// Token: 0x0400B881 RID: 47233
		private UnchartedUITask m_unchartedUITask;

		// Token: 0x0400B882 RID: 47234
		private ArenaSelectUITask m_arenaSelectUITask;

		// Token: 0x0400B883 RID: 47235
		private ArenaUITask m_arenaUITask;

		// Token: 0x0400B884 RID: 47236
		private PlayerInfoUITask m_playerInfoUITask;

		// Token: 0x0400B885 RID: 47237
		private AppScoreUITask m_appScoreUITask;

		// Token: 0x0400B886 RID: 47238
		private TestUITask m_testUITask;

		// Token: 0x0400B887 RID: 47239
		private WorldEventMissionUITask m_worldEventMissionUITask;

		// Token: 0x0400B888 RID: 47240
		private DialogUITask m_dialogUITask;

		// Token: 0x0400B889 RID: 47241
		private GoddessDialogUITask m_goddessDialogUITask;

		// Token: 0x0400B88A RID: 47242
		private ClientWorld m_clientWorld;

		// Token: 0x0400B88B RID: 47243
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400B88C RID: 47244
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400B88D RID: 47245
		private int m_nowSeconds;

		// Token: 0x0400B88E RID: 47246
		private bool m_isResuming;

		// Token: 0x0400B88F RID: 47247
		private bool m_isResumeNeedNextWorldStep;

		// Token: 0x0400B890 RID: 47248
		private static bool s_showMainButtonBar = true;

		// Token: 0x0400B891 RID: 47249
		private List<int> m_movePath = new List<int>();

		// Token: 0x0400B892 RID: 47250
		[DoNotToLua]
		private WorldUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B894 RID: 47252
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x0400B895 RID: 47253
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B896 RID: 47254
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B897 RID: 47255
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B898 RID: 47256
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B899 RID: 47257
		private LuaFunction m_CollectPlayerAssets_hotfix;

		// Token: 0x0400B89A RID: 47258
		private LuaFunction m_CollectEventAssets_hotfix;

		// Token: 0x0400B89B RID: 47259
		private LuaFunction m_CollectMonthCardAssets_hotfix;

		// Token: 0x0400B89C RID: 47260
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x0400B89D RID: 47261
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B89E RID: 47262
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B89F RID: 47263
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x0400B8A0 RID: 47264
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x0400B8A1 RID: 47265
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B8A2 RID: 47266
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B8A3 RID: 47267
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400B8A4 RID: 47268
		private LuaFunction m_HideAllView_hotfix;

		// Token: 0x0400B8A5 RID: 47269
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400B8A6 RID: 47270
		private LuaFunction m_InitWorldMapUIController_hotfix;

		// Token: 0x0400B8A7 RID: 47271
		private LuaFunction m_UninitWorldMapUIController_hotfix;

		// Token: 0x0400B8A8 RID: 47272
		private LuaFunction m_InitWorldUIController_hotfix;

		// Token: 0x0400B8A9 RID: 47273
		private LuaFunction m_UninitWorldUIController_hotfix;

		// Token: 0x0400B8AA RID: 47274
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B8AB RID: 47275
		private LuaFunction m_UpdateRedMarks_hotfix;

		// Token: 0x0400B8AC RID: 47276
		private LuaFunction m_UpdatePlayerInfo_hotfix;

		// Token: 0x0400B8AD RID: 47277
		private LuaFunction m_UpdateCurrentScenario_hotfix;

		// Token: 0x0400B8AE RID: 47278
		private LuaFunction m_UpdateHeroRedMark_hotfix;

		// Token: 0x0400B8AF RID: 47279
		private LuaFunction m_UpdateMissionRedMark_hotfix;

		// Token: 0x0400B8B0 RID: 47280
		private LuaFunction m_UpdateActivityRedMark_hotfix;

		// Token: 0x0400B8B1 RID: 47281
		private LuaFunction m_UpdateFriendRedMark_hotfix;

		// Token: 0x0400B8B2 RID: 47282
		private LuaFunction m_UpdateDrillRedMark_hotfix;

		// Token: 0x0400B8B3 RID: 47283
		private LuaFunction m_UpdateFetterRedMark_hotfix;

		// Token: 0x0400B8B4 RID: 47284
		private LuaFunction m_UpdateGuildRedMark_hotfix;

		// Token: 0x0400B8B5 RID: 47285
		private LuaFunction m_UpdateWorldEventRedMark_hotfix;

		// Token: 0x0400B8B6 RID: 47286
		private LuaFunction m_UpdateInvestigationButton_hotfix;

		// Token: 0x0400B8B7 RID: 47287
		private LuaFunction m_UpdateOpenServiceActivityButton_hotfix;

		// Token: 0x0400B8B8 RID: 47288
		private LuaFunction m_UpdateCooperateBattleButton_hotfix;

		// Token: 0x0400B8B9 RID: 47289
		private LuaFunction m_UpdateMonthCardInfo_hotfix;

		// Token: 0x0400B8BA RID: 47290
		private LuaFunction m_OnSlowTick_hotfix;

		// Token: 0x0400B8BB RID: 47291
		private LuaFunction m_ShowEventList_hotfix;

		// Token: 0x0400B8BC RID: 47292
		private LuaFunction m_HasRandomEvent_hotfix;

		// Token: 0x0400B8BD RID: 47293
		private LuaFunction m_UpdateNewChatCount_hotfix;

		// Token: 0x0400B8BE RID: 47294
		private LuaFunction m_UpdateNewMailCount_hotfix;

		// Token: 0x0400B8BF RID: 47295
		private LuaFunction m_CreateClientWorld_hotfix;

		// Token: 0x0400B8C0 RID: 47296
		private LuaFunction m_DestroyClientWorld_hotfix;

		// Token: 0x0400B8C1 RID: 47297
		private LuaFunction m_StartClientWorld_hotfix;

		// Token: 0x0400B8C2 RID: 47298
		private LuaFunction m_NextWorldStepBoolean_hotfix;

		// Token: 0x0400B8C3 RID: 47299
		private LuaFunction m_WorldUIGetReady_hotfix;

		// Token: 0x0400B8C4 RID: 47300
		private LuaFunction m_ClickFirstWaypoint_hotfix;

		// Token: 0x0400B8C5 RID: 47301
		private LuaFunction m_StartSetProtagonistNetTaskInt32_hotfix;

		// Token: 0x0400B8C6 RID: 47302
		private LuaFunction m_WorldUIController_OnShowMainButtonBarBoolean_hotfix;

		// Token: 0x0400B8C7 RID: 47303
		private LuaFunction m_WorldUIController_OnShowPlayerInfo_hotfix;

		// Token: 0x0400B8C8 RID: 47304
		private LuaFunction m_WorldUIController_OnCompass_hotfix;

		// Token: 0x0400B8C9 RID: 47305
		private LuaFunction m_WorldUIController_OnCurrentScenario_hotfix;

		// Token: 0x0400B8CA RID: 47306
		private LuaFunction m_WorldUIController_OnUnlockScenarioGotoRiftLevelConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400B8CB RID: 47307
		private LuaFunction m_WorldUIController_OnGotoEventConfigDataWaypointInfoConfigDataEventInfo_hotfix;

		// Token: 0x0400B8CC RID: 47308
		private LuaFunction m_WorldUIController_OnStartPastScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x0400B8CD RID: 47309
		private LuaFunction m_WorldUIController_OnClosePastScenarioList_hotfix;

		// Token: 0x0400B8CE RID: 47310
		private LuaFunction m_WorldUIController_OnShowEvent_hotfix;

		// Token: 0x0400B8CF RID: 47311
		private LuaFunction m_WorldUIController_OnShowHero_hotfix;

		// Token: 0x0400B8D0 RID: 47312
		private LuaFunction m_WorldUIController_OnShowBag_hotfix;

		// Token: 0x0400B8D1 RID: 47313
		private LuaFunction m_WorldUIController_OnShowMission_hotfix;

		// Token: 0x0400B8D2 RID: 47314
		private LuaFunction m_WorldUIController_OnShowFetter_hotfix;

		// Token: 0x0400B8D3 RID: 47315
		private LuaFunction m_WorldUIController_OnShowStore_hotfix;

		// Token: 0x0400B8D4 RID: 47316
		private LuaFunction m_WorldUIController_OnShowSelectCard_hotfix;

		// Token: 0x0400B8D5 RID: 47317
		private LuaFunction m_WorldUIController_OnShowDrill_hotfix;

		// Token: 0x0400B8D6 RID: 47318
		private LuaFunction m_WorldUIController_OnShowFriend_hotfix;

		// Token: 0x0400B8D7 RID: 47319
		private LuaFunction m_WorldUIController_OnShowGuild_hotfix;

		// Token: 0x0400B8D8 RID: 47320
		private LuaFunction m_WorldUIController_OnShowUncharted_hotfix;

		// Token: 0x0400B8D9 RID: 47321
		private LuaFunction m_WorldUIController_OnShowArena_hotfix;

		// Token: 0x0400B8DA RID: 47322
		private LuaFunction m_WorldUIController_OnShowRift_hotfix;

		// Token: 0x0400B8DB RID: 47323
		private LuaFunction m_WorldUIController_OnShowTest_hotfix;

		// Token: 0x0400B8DC RID: 47324
		private LuaFunction m_WorldUIController_OnShowCooperateBattle_hotfix;

		// Token: 0x0400B8DD RID: 47325
		private LuaFunction m_WorldUIController_OnShowMail_hotfix;

		// Token: 0x0400B8DE RID: 47326
		private LuaFunction m_WorldUIController_OnShowChat_hotfix;

		// Token: 0x0400B8DF RID: 47327
		private LuaFunction m_WorldUIController_OnShowRanking_hotfix;

		// Token: 0x0400B8E0 RID: 47328
		private LuaFunction m_WorldUIController_OnShowActivity_hotfix;

		// Token: 0x0400B8E1 RID: 47329
		private LuaFunction m_WorldUIController_OnShowOpenServiceActivity_hotfix;

		// Token: 0x0400B8E2 RID: 47330
		private LuaFunction m_WorldUIController_OnMonthCardButtonClick_hotfix;

		// Token: 0x0400B8E3 RID: 47331
		private LuaFunction m_WorldUIController_OnRefreshMonthCardPanelBoolean_hotfix;

		// Token: 0x0400B8E4 RID: 47332
		private LuaFunction m_WorldUIController_OnMonthCardItemClickInt32_hotfix;

		// Token: 0x0400B8E5 RID: 47333
		private LuaFunction m_WorldUIController_OnMonthCardItemBuyClickInt32_hotfix;

		// Token: 0x0400B8E6 RID: 47334
		private LuaFunction m_WorldUIController_OnOpenWebInvestigation_hotfix;

		// Token: 0x0400B8E7 RID: 47335
		private LuaFunction m_WorldUIController_OnYYBButtonClick_hotfix;

		// Token: 0x0400B8E8 RID: 47336
		private LuaFunction m_WorldUIController_OnOppoButtonClick_hotfix;

		// Token: 0x0400B8E9 RID: 47337
		private LuaFunction m_PDSDK_OnDoQuestionSucceed_hotfix;

		// Token: 0x0400B8EA RID: 47338
		private LuaFunction m_PDSDK_OnDoQuestionFailed_hotfix;

		// Token: 0x0400B8EB RID: 47339
		private LuaFunction m_WorldUIController_OnShowSign_hotfix;

		// Token: 0x0400B8EC RID: 47340
		private LuaFunction m_WorldUIController_OnShowActivityNotice_hotfix;

		// Token: 0x0400B8ED RID: 47341
		private LuaFunction m_GetRewardGoodsUITask_OnStopTask_hotfix;

		// Token: 0x0400B8EE RID: 47342
		private LuaFunction m_GetRewardGoodsUITask_OnClose_hotfix;

		// Token: 0x0400B8EF RID: 47343
		private LuaFunction m_ChestUITask_OnStopTask_hotfix;

		// Token: 0x0400B8F0 RID: 47344
		private LuaFunction m_ChestUITask_OnClose_hotfix;

		// Token: 0x0400B8F1 RID: 47345
		private LuaFunction m_WorldMapUIController_OnPointerDown_hotfix;

		// Token: 0x0400B8F2 RID: 47346
		private LuaFunction m_WorldMapUIController_OnPointerUp_hotfix;

		// Token: 0x0400B8F3 RID: 47347
		private LuaFunction m_WorldMapUIController_OnPointerClick_hotfix;

		// Token: 0x0400B8F4 RID: 47348
		private LuaFunction m_PlayerResourceUIController_OnAddGold_hotfix;

		// Token: 0x0400B8F5 RID: 47349
		private LuaFunction m_PlayerResourceUIController_OnAddCrystal_hotfix;

		// Token: 0x0400B8F6 RID: 47350
		private LuaFunction m_PlayerContext_OnMailsChangedNtf_hotfix;

		// Token: 0x0400B8F7 RID: 47351
		private LuaFunction m_PlayerContext_OnFriendInviteNtf_hotfix;

		// Token: 0x0400B8F8 RID: 47352
		private LuaFunction m_PlayerContext_OnFriendInviteAcceptNtfUserSummary_hotfix;

		// Token: 0x0400B8F9 RID: 47353
		private LuaFunction m_PlayerContext_OnFriendshipPointsReceivedNtf_hotfix;

		// Token: 0x0400B8FA RID: 47354
		private LuaFunction m_PlayerContext_EventOnGiftStoreBuyGoodsNtfString_hotfix;

		// Token: 0x0400B8FB RID: 47355
		private LuaFunction m_PlayerContext_OnChatMessageNtfChatMessage_hotfix;

		// Token: 0x0400B8FC RID: 47356
		private LuaFunction m_PlayerContext_OnMailReadAckInt32_hotfix;

		// Token: 0x0400B8FD RID: 47357
		private LuaFunction m_PlayerContext_OnPlayerInfoChangeNtf_hotfix;

		// Token: 0x0400B8FE RID: 47358
		private LuaFunction m_PlayerContext_OnTeamRoomInviteNtfTeamRoomInviteInfo_hotfix;

		// Token: 0x0400B8FF RID: 47359
		private LuaFunction m_PlayerContext_OnBattlePracticeInvitedNtfPVPInviteInfo_hotfix;

		// Token: 0x0400B900 RID: 47360
		private LuaFunction m_PlayerContext_OnBattleRoomTeamBattleJoinNtf_hotfix;

		// Token: 0x0400B901 RID: 47361
		private LuaFunction m_PlayerContext_OnBattleRoomPVPBattleJoinNtf_hotfix;

		// Token: 0x0400B902 RID: 47362
		private LuaFunction m_PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf_hotfix;

		// Token: 0x0400B903 RID: 47363
		private LuaFunction m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf_hotfix;

		// Token: 0x0400B904 RID: 47364
		private LuaFunction m_PlayerContext_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x0400B905 RID: 47365
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B906 RID: 47366
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x0400B907 RID: 47367
		private LuaFunction m_GetClientWorld_hotfix;

		// Token: 0x0400B908 RID: 47368
		private LuaFunction m_StartScenarioConfigDataScenarioInfoConfigDataWaypointInfo_hotfix;

		// Token: 0x0400B909 RID: 47369
		private LuaFunction m_StartWaypointEventConfigDataWaypointInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix;

		// Token: 0x0400B90A RID: 47370
		private LuaFunction m_StartBattleRoomBattle_hotfix;

		// Token: 0x0400B90B RID: 47371
		private LuaFunction m__StartBattleHappeningBattleTypeInt32_hotfix;

		// Token: 0x0400B90C RID: 47372
		private LuaFunction m_StartHappeningBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix;

		// Token: 0x0400B90D RID: 47373
		private LuaFunction m_NextHappeningStep_hotfix;

		// Token: 0x0400B90E RID: 47374
		private LuaFunction m_StartLevelWayPointMoveNetTaskInt32Action;

		// Token: 0x0400B90F RID: 47375
		private LuaFunction m_StartLevelScenarioHandleNetTaskInt32Action;

		// Token: 0x0400B910 RID: 47376
		private LuaFunction m_OnLevelWayPointMoveNetTaskResultInt32BattleRewardAction;

		// Token: 0x0400B911 RID: 47377
		private LuaFunction m_ShowWaypointRewardBattleRewardBoolean_hotfix;

		// Token: 0x0400B912 RID: 47378
		private LuaFunction m_CheckChangeCurrentScenarioBoolean_hotfix;

		// Token: 0x0400B913 RID: 47379
		private LuaFunction m_Co_ChangeCurrentScenarioConfigDataScenarioInfoBoolean_hotfix;

		// Token: 0x0400B914 RID: 47380
		private LuaFunction m_CheckOpenRiftChapter_hotfix;

		// Token: 0x0400B915 RID: 47381
		private LuaFunction m_CheckOrderReward_hotfix;

		// Token: 0x0400B916 RID: 47382
		private LuaFunction m_CheckReturnToBeforeBattleUI_hotfix;

		// Token: 0x0400B917 RID: 47383
		private LuaFunction m_CheckOpenTeamRoomInfoUI_hotfix;

		// Token: 0x0400B918 RID: 47384
		private LuaFunction m_StartTeamRoomInfoUITask_hotfix;

		// Token: 0x0400B919 RID: 47385
		private LuaFunction m_CheckInBattleRoom_hotfix;

		// Token: 0x0400B91A RID: 47386
		private LuaFunction m_MoveToPrevWaypointBoolean_hotfix;

		// Token: 0x0400B91B RID: 47387
		private LuaFunction m_OnWaypointClickConfigDataWaypointInfo_hotfix;

		// Token: 0x0400B91C RID: 47388
		private LuaFunction m_PlayerArriveWaypointConfigDataWaypointInfoConfigDataWaypointInfo_hotfix;

		// Token: 0x0400B91D RID: 47389
		private LuaFunction m_ShowPastScenarioListConfigDataWaypointInfo_hotfix;

		// Token: 0x0400B91E RID: 47390
		private LuaFunction m_OnScreenEffectString_hotfix;

		// Token: 0x0400B91F RID: 47391
		private LuaFunction m_StartShowFadeOutLoadingFadeInActionFadeStyle_hotfix;

		// Token: 0x0400B920 RID: 47392
		private LuaFunction m_HideFadeOutLoadingFadeIn_hotfix;

		// Token: 0x0400B921 RID: 47393
		private LuaFunction m_StartPlayerInfoUITask_hotfix;

		// Token: 0x0400B922 RID: 47394
		private LuaFunction m_PlayerInfoUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B923 RID: 47395
		private LuaFunction m_PlayerInfoUITask_OnStopTask_hotfix;

		// Token: 0x0400B924 RID: 47396
		private LuaFunction m_PlayerInfoUITask_OnClose_hotfix;

		// Token: 0x0400B925 RID: 47397
		private LuaFunction m_StartAppScoreUITask_hotfix;

		// Token: 0x0400B926 RID: 47398
		private LuaFunction m_AppScoreUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B927 RID: 47399
		private LuaFunction m_AppScoreUITask_OnStopTask_hotfix;

		// Token: 0x0400B928 RID: 47400
		private LuaFunction m_AppScoreUITask_OnClose_hotfix;

		// Token: 0x0400B929 RID: 47401
		private LuaFunction m_StartSignUITask_hotfix;

		// Token: 0x0400B92A RID: 47402
		private LuaFunction m_SignUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B92B RID: 47403
		private LuaFunction m_StartActivityNoticeUITask_hotfix;

		// Token: 0x0400B92C RID: 47404
		private LuaFunction m_ActivityNoticeUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B92D RID: 47405
		private LuaFunction m_StartHeroUITaskUIIntent_hotfix;

		// Token: 0x0400B92E RID: 47406
		private LuaFunction m_HeroUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B92F RID: 47407
		private LuaFunction m_StartBagUITask_hotfix;

		// Token: 0x0400B930 RID: 47408
		private LuaFunction m_BagUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B931 RID: 47409
		private LuaFunction m_StartMissionUITaskUIIntent_hotfix;

		// Token: 0x0400B932 RID: 47410
		private LuaFunction m_MissionUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B933 RID: 47411
		private LuaFunction m_StartOpenServiceActivityUITask_hotfix;

		// Token: 0x0400B934 RID: 47412
		private LuaFunction m_OpenServiceActivityUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B935 RID: 47413
		private LuaFunction m_StartFettersUITaskConfigDataHeroDungeonLevelInfoUIIntent_hotfix;

		// Token: 0x0400B936 RID: 47414
		private LuaFunction m_FettersUITask_OnStopTask_hotfix;

		// Token: 0x0400B937 RID: 47415
		private LuaFunction m_FettersUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B938 RID: 47416
		private LuaFunction m_FetterUITask_StartHeroDungeonHeroUIIntent_hotfix;

		// Token: 0x0400B939 RID: 47417
		private LuaFunction m_StartArenaSelectUITaskArenaUITypeBooleanUIIntent_hotfix;

		// Token: 0x0400B93A RID: 47418
		private LuaFunction m_ArenaSelectUITask_OnStopTask_hotfix;

		// Token: 0x0400B93B RID: 47419
		private LuaFunction m_ArenaSelectUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B93C RID: 47420
		private LuaFunction m_ArenaSelectUITask_OnShowArenaArenaUITypeBooleanUIIntent_hotfix;

		// Token: 0x0400B93D RID: 47421
		private LuaFunction m_StartArenaUITaskArenaUITypeBooleanUIIntent_hotfix;

		// Token: 0x0400B93E RID: 47422
		private LuaFunction m_ArenaUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B93F RID: 47423
		private LuaFunction m_ArenaUITask_OnStopTask_hotfix;

		// Token: 0x0400B940 RID: 47424
		private LuaFunction m_ArenaUITask_OnStartArenaBattleBoolean_hotfix;

		// Token: 0x0400B941 RID: 47425
		private LuaFunction m_ArenaUITask_OnStartArenaBattleReplayArenaBattleReport_hotfix;

		// Token: 0x0400B942 RID: 47426
		private LuaFunction m_ArenaUITask_OnStartRealTimePVPBattleReplayRealTimePVPBattleReport_hotfix;

		// Token: 0x0400B943 RID: 47427
		private LuaFunction m_InitAndStartArenaUITaskArenaUITypeBooleanUIIntent_hotfix;

		// Token: 0x0400B944 RID: 47428
		private LuaFunction m_StartArenaBattleReportBasicDataGetNetTaskArenaUITypeBooleanUIIntent_hotfix;

		// Token: 0x0400B945 RID: 47429
		private LuaFunction m_StartStoreUITaskStoreIdUIIntent_hotfix;

		// Token: 0x0400B946 RID: 47430
		private LuaFunction m_StoreUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B947 RID: 47431
		private LuaFunction m_StartSelectCardUITaskInt32UIIntent_hotfix;

		// Token: 0x0400B948 RID: 47432
		private LuaFunction m_SelectCardUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B949 RID: 47433
		private LuaFunction m_StartDrillUITaskInt32UIIntent_hotfix;

		// Token: 0x0400B94A RID: 47434
		private LuaFunction m_DrillUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B94B RID: 47435
		private LuaFunction m_StartFriendUITaskUIIntent_hotfix;

		// Token: 0x0400B94C RID: 47436
		private LuaFunction m_StartGuildUITaskUIIntentBoolean_hotfix;

		// Token: 0x0400B94D RID: 47437
		private LuaFunction m_FriendUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B94E RID: 47438
		private LuaFunction m_StartMailUITask_hotfix;

		// Token: 0x0400B94F RID: 47439
		private LuaFunction m_StartRankingUITask_hotfix;

		// Token: 0x0400B950 RID: 47440
		private LuaFunction m_StartActivityUITaskInt32_hotfix;

		// Token: 0x0400B951 RID: 47441
		private LuaFunction m_ActivityUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B952 RID: 47442
		private LuaFunction m_StartTeamUITask_hotfix;

		// Token: 0x0400B953 RID: 47443
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B954 RID: 47444
		private LuaFunction m_StartTestUITask_hotfix;

		// Token: 0x0400B955 RID: 47445
		private LuaFunction m_TestUITask_OnStopTask_hotfix;

		// Token: 0x0400B956 RID: 47446
		private LuaFunction m_TestUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B957 RID: 47447
		private LuaFunction m_TestUITask_OnStartBattleConfigDataBattleInfo_hotfix;

		// Token: 0x0400B958 RID: 47448
		private LuaFunction m_StartUnchartedUITaskBattleTypeInt32Int32UIIntent_hotfix;

		// Token: 0x0400B959 RID: 47449
		private LuaFunction m_UnchartedUITask_OnStopTask_hotfix;

		// Token: 0x0400B95A RID: 47450
		private LuaFunction m_UnchartedUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B95B RID: 47451
		private LuaFunction m__StartUnchartedSubUITaskBattleTypeInt32UIIntent_hotfix;

		// Token: 0x0400B95C RID: 47452
		private LuaFunction m_StartRiftUITaskConfigDataRiftLevelInfoBooleanBooleanUIIntentNeedGoods_hotfix;

		// Token: 0x0400B95D RID: 47453
		private LuaFunction m_RiftUITask_OnStopTask_hotfix;

		// Token: 0x0400B95E RID: 47454
		private LuaFunction m_RiftUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B95F RID: 47455
		private LuaFunction m_RiftUITask_GoToScenarioInt32_hotfix;

		// Token: 0x0400B960 RID: 47456
		private LuaFunction m_StartHeroDungeonUITaskConfigDataHeroDungeonLevelInfoBooleanHeroUIIntent_hotfix;

		// Token: 0x0400B961 RID: 47457
		private LuaFunction m_HeroDungeonUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B962 RID: 47458
		private LuaFunction m_StartHeroPhantomUITaskConfigDataHeroPhantomInfoUIIntent_hotfix;

		// Token: 0x0400B963 RID: 47459
		private LuaFunction m_HeroPhantomUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B964 RID: 47460
		private LuaFunction m_StartThearchyUITaskConfigDataThearchyTrialInfoUIIntent_hotfix;

		// Token: 0x0400B965 RID: 47461
		private LuaFunction m_ThearchyUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B966 RID: 47462
		private LuaFunction m_StartAnikiUITaskConfigDataAnikiGymInfoUIIntent_hotfix;

		// Token: 0x0400B967 RID: 47463
		private LuaFunction m_AnikiUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B968 RID: 47464
		private LuaFunction m_StartTreasureMapUITaskUIIntent_hotfix;

		// Token: 0x0400B969 RID: 47465
		private LuaFunction m_TreasureMapUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B96A RID: 47466
		private LuaFunction m_StartMemoryCorridorUITaskConfigDataMemoryCorridorInfoUIIntent_hotfix;

		// Token: 0x0400B96B RID: 47467
		private LuaFunction m_MemoryCorridorUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B96C RID: 47468
		private LuaFunction m_StartHeroTrainningUITaskConfigDataHeroTrainningInfoUIIntent_hotfix;

		// Token: 0x0400B96D RID: 47469
		private LuaFunction m_HeroTrainningUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B96E RID: 47470
		private LuaFunction m_StartCooperateBattleUITaskConfigDataCooperateBattleInfoUIIntent_hotfix;

		// Token: 0x0400B96F RID: 47471
		private LuaFunction m_CooperateBattleUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B970 RID: 47472
		private LuaFunction m_StartUnchartedScoreUITaskConfigDataUnchartedScoreInfoBattleTypeUIIntent_hotfix;

		// Token: 0x0400B971 RID: 47473
		private LuaFunction m_UnchartedScoreUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B972 RID: 47474
		private LuaFunction m_StartClimbTowerUITaskUIIntent_hotfix;

		// Token: 0x0400B973 RID: 47475
		private LuaFunction m_ClimbTowerUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B974 RID: 47476
		private LuaFunction m_StartWorldEventMissionUITaskConfigDataEventInfo_hotfix;

		// Token: 0x0400B975 RID: 47477
		private LuaFunction m_WorldEventMissionUITask_OnStopTask_hotfix;

		// Token: 0x0400B976 RID: 47478
		private LuaFunction m_WorldEventMissionUITask_OnEnterMission_hotfix;

		// Token: 0x0400B977 RID: 47479
		private LuaFunction m_WorldEventMissionUITask_OnClose_hotfix;

		// Token: 0x0400B978 RID: 47480
		private LuaFunction m_StartGoddessDialogUITask_hotfix;

		// Token: 0x0400B979 RID: 47481
		private LuaFunction m_GoddessDialogUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B97A RID: 47482
		private LuaFunction m_GoddessDialogUITask_OnCloseInt32_hotfix;

		// Token: 0x0400B97B RID: 47483
		private LuaFunction m_StartDialogUITaskConfigDataDialogInfo_hotfix;

		// Token: 0x0400B97C RID: 47484
		private LuaFunction m_DialogUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B97D RID: 47485
		private LuaFunction m_DialogUITask_OnCloseBoolean_hotfix;

		// Token: 0x0400B97E RID: 47486
		private LuaFunction m_StartBattleUITaskConfigDataBattleInfoBattleType_hotfix;

		// Token: 0x0400B97F RID: 47487
		private LuaFunction m_StartArenaBattleUITaskBoolean_hotfix;

		// Token: 0x0400B980 RID: 47488
		private LuaFunction m_StartArenaReplayBattleUITaskArenaBattleReport_hotfix;

		// Token: 0x0400B981 RID: 47489
		private LuaFunction m_StartRealTimePVPReplayBattleUITaskRealTimePVPBattleReport_hotfix;

		// Token: 0x0400B982 RID: 47490
		private LuaFunction m_FadeOutAndStartBattleUITask_hotfix;

		// Token: 0x0400B983 RID: 47491
		private LuaFunction m__StartGetPathTargetUITaskGetPathDataUIIntentNeedGoods_hotfix;

		// Token: 0x0200103A RID: 4154
		public new class LuaExportHelper
		{
			// Token: 0x0601537C RID: 86908 RVA: 0x00566E5C File Offset: 0x0056505C
			public LuaExportHelper(WorldUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601537D RID: 86909 RVA: 0x00566E6C File Offset: 0x0056506C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601537E RID: 86910 RVA: 0x00566E7C File Offset: 0x0056507C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601537F RID: 86911 RVA: 0x00566E8C File Offset: 0x0056508C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06015380 RID: 86912 RVA: 0x00566E9C File Offset: 0x0056509C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06015381 RID: 86913 RVA: 0x00566EAC File Offset: 0x005650AC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06015382 RID: 86914 RVA: 0x00566EBC File Offset: 0x005650BC
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06015383 RID: 86915 RVA: 0x00566ECC File Offset: 0x005650CC
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06015384 RID: 86916 RVA: 0x00566EDC File Offset: 0x005650DC
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06015385 RID: 86917 RVA: 0x00566EEC File Offset: 0x005650EC
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06015386 RID: 86918 RVA: 0x00566EFC File Offset: 0x005650FC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06015387 RID: 86919 RVA: 0x00566F0C File Offset: 0x0056510C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06015388 RID: 86920 RVA: 0x00566F1C File Offset: 0x0056511C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06015389 RID: 86921 RVA: 0x00566F2C File Offset: 0x0056512C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601538A RID: 86922 RVA: 0x00566F3C File Offset: 0x0056513C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601538B RID: 86923 RVA: 0x00566F4C File Offset: 0x0056514C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601538C RID: 86924 RVA: 0x00566F5C File Offset: 0x0056515C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0601538D RID: 86925 RVA: 0x00566F6C File Offset: 0x0056516C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601538E RID: 86926 RVA: 0x00566F7C File Offset: 0x0056517C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601538F RID: 86927 RVA: 0x00566F8C File Offset: 0x0056518C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06015390 RID: 86928 RVA: 0x00566F9C File Offset: 0x0056519C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06015391 RID: 86929 RVA: 0x00566FAC File Offset: 0x005651AC
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06015392 RID: 86930 RVA: 0x00566FBC File Offset: 0x005651BC
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06015393 RID: 86931 RVA: 0x00566FCC File Offset: 0x005651CC
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003E28 RID: 15912
			// (get) Token: 0x06015394 RID: 86932 RVA: 0x00566FDC File Offset: 0x005651DC
			// (set) Token: 0x06015395 RID: 86933 RVA: 0x00566FEC File Offset: 0x005651EC
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

			// Token: 0x17003E29 RID: 15913
			// (get) Token: 0x06015396 RID: 86934 RVA: 0x00566FFC File Offset: 0x005651FC
			// (set) Token: 0x06015397 RID: 86935 RVA: 0x0056700C File Offset: 0x0056520C
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

			// Token: 0x17003E2A RID: 15914
			// (get) Token: 0x06015398 RID: 86936 RVA: 0x0056701C File Offset: 0x0056521C
			// (set) Token: 0x06015399 RID: 86937 RVA: 0x00567024 File Offset: 0x00565224
			public static WorldUITask s_instance
			{
				get
				{
					return WorldUITask.s_instance;
				}
				set
				{
					WorldUITask.s_instance = value;
				}
			}

			// Token: 0x17003E2B RID: 15915
			// (get) Token: 0x0601539A RID: 86938 RVA: 0x0056702C File Offset: 0x0056522C
			// (set) Token: 0x0601539B RID: 86939 RVA: 0x00567034 File Offset: 0x00565234
			public static bool s_isShowWorldUI
			{
				get
				{
					return WorldUITask.s_isShowWorldUI;
				}
				set
				{
					WorldUITask.s_isShowWorldUI = value;
				}
			}

			// Token: 0x17003E2C RID: 15916
			// (get) Token: 0x0601539C RID: 86940 RVA: 0x0056703C File Offset: 0x0056523C
			// (set) Token: 0x0601539D RID: 86941 RVA: 0x0056704C File Offset: 0x0056524C
			public WorldUIController m_worldUIController
			{
				get
				{
					return this.m_owner.m_worldUIController;
				}
				set
				{
					this.m_owner.m_worldUIController = value;
				}
			}

			// Token: 0x17003E2D RID: 15917
			// (get) Token: 0x0601539E RID: 86942 RVA: 0x0056705C File Offset: 0x0056525C
			// (set) Token: 0x0601539F RID: 86943 RVA: 0x0056706C File Offset: 0x0056526C
			public WorldMapUIController m_worldMapUIController
			{
				get
				{
					return this.m_owner.m_worldMapUIController;
				}
				set
				{
					this.m_owner.m_worldMapUIController = value;
				}
			}

			// Token: 0x17003E2E RID: 15918
			// (get) Token: 0x060153A0 RID: 86944 RVA: 0x0056707C File Offset: 0x0056527C
			// (set) Token: 0x060153A1 RID: 86945 RVA: 0x0056708C File Offset: 0x0056528C
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

			// Token: 0x17003E2F RID: 15919
			// (get) Token: 0x060153A2 RID: 86946 RVA: 0x0056709C File Offset: 0x0056529C
			// (set) Token: 0x060153A3 RID: 86947 RVA: 0x005670AC File Offset: 0x005652AC
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

			// Token: 0x17003E30 RID: 15920
			// (get) Token: 0x060153A4 RID: 86948 RVA: 0x005670BC File Offset: 0x005652BC
			// (set) Token: 0x060153A5 RID: 86949 RVA: 0x005670CC File Offset: 0x005652CC
			public GetRewardGoodsUITask m_getRewardGoodsUITask
			{
				get
				{
					return this.m_owner.m_getRewardGoodsUITask;
				}
				set
				{
					this.m_owner.m_getRewardGoodsUITask = value;
				}
			}

			// Token: 0x17003E31 RID: 15921
			// (get) Token: 0x060153A6 RID: 86950 RVA: 0x005670DC File Offset: 0x005652DC
			// (set) Token: 0x060153A7 RID: 86951 RVA: 0x005670EC File Offset: 0x005652EC
			public FettersUITask m_fettersUITask
			{
				get
				{
					return this.m_owner.m_fettersUITask;
				}
				set
				{
					this.m_owner.m_fettersUITask = value;
				}
			}

			// Token: 0x17003E32 RID: 15922
			// (get) Token: 0x060153A8 RID: 86952 RVA: 0x005670FC File Offset: 0x005652FC
			// (set) Token: 0x060153A9 RID: 86953 RVA: 0x0056710C File Offset: 0x0056530C
			public RiftUITask m_riftUITask
			{
				get
				{
					return this.m_owner.m_riftUITask;
				}
				set
				{
					this.m_owner.m_riftUITask = value;
				}
			}

			// Token: 0x17003E33 RID: 15923
			// (get) Token: 0x060153AA RID: 86954 RVA: 0x0056711C File Offset: 0x0056531C
			// (set) Token: 0x060153AB RID: 86955 RVA: 0x0056712C File Offset: 0x0056532C
			public UnchartedUITask m_unchartedUITask
			{
				get
				{
					return this.m_owner.m_unchartedUITask;
				}
				set
				{
					this.m_owner.m_unchartedUITask = value;
				}
			}

			// Token: 0x17003E34 RID: 15924
			// (get) Token: 0x060153AC RID: 86956 RVA: 0x0056713C File Offset: 0x0056533C
			// (set) Token: 0x060153AD RID: 86957 RVA: 0x0056714C File Offset: 0x0056534C
			public ArenaSelectUITask m_arenaSelectUITask
			{
				get
				{
					return this.m_owner.m_arenaSelectUITask;
				}
				set
				{
					this.m_owner.m_arenaSelectUITask = value;
				}
			}

			// Token: 0x17003E35 RID: 15925
			// (get) Token: 0x060153AE RID: 86958 RVA: 0x0056715C File Offset: 0x0056535C
			// (set) Token: 0x060153AF RID: 86959 RVA: 0x0056716C File Offset: 0x0056536C
			public ArenaUITask m_arenaUITask
			{
				get
				{
					return this.m_owner.m_arenaUITask;
				}
				set
				{
					this.m_owner.m_arenaUITask = value;
				}
			}

			// Token: 0x17003E36 RID: 15926
			// (get) Token: 0x060153B0 RID: 86960 RVA: 0x0056717C File Offset: 0x0056537C
			// (set) Token: 0x060153B1 RID: 86961 RVA: 0x0056718C File Offset: 0x0056538C
			public PlayerInfoUITask m_playerInfoUITask
			{
				get
				{
					return this.m_owner.m_playerInfoUITask;
				}
				set
				{
					this.m_owner.m_playerInfoUITask = value;
				}
			}

			// Token: 0x17003E37 RID: 15927
			// (get) Token: 0x060153B2 RID: 86962 RVA: 0x0056719C File Offset: 0x0056539C
			// (set) Token: 0x060153B3 RID: 86963 RVA: 0x005671AC File Offset: 0x005653AC
			public AppScoreUITask m_appScoreUITask
			{
				get
				{
					return this.m_owner.m_appScoreUITask;
				}
				set
				{
					this.m_owner.m_appScoreUITask = value;
				}
			}

			// Token: 0x17003E38 RID: 15928
			// (get) Token: 0x060153B4 RID: 86964 RVA: 0x005671BC File Offset: 0x005653BC
			// (set) Token: 0x060153B5 RID: 86965 RVA: 0x005671CC File Offset: 0x005653CC
			public TestUITask m_testUITask
			{
				get
				{
					return this.m_owner.m_testUITask;
				}
				set
				{
					this.m_owner.m_testUITask = value;
				}
			}

			// Token: 0x17003E39 RID: 15929
			// (get) Token: 0x060153B6 RID: 86966 RVA: 0x005671DC File Offset: 0x005653DC
			// (set) Token: 0x060153B7 RID: 86967 RVA: 0x005671EC File Offset: 0x005653EC
			public WorldEventMissionUITask m_worldEventMissionUITask
			{
				get
				{
					return this.m_owner.m_worldEventMissionUITask;
				}
				set
				{
					this.m_owner.m_worldEventMissionUITask = value;
				}
			}

			// Token: 0x17003E3A RID: 15930
			// (get) Token: 0x060153B8 RID: 86968 RVA: 0x005671FC File Offset: 0x005653FC
			// (set) Token: 0x060153B9 RID: 86969 RVA: 0x0056720C File Offset: 0x0056540C
			public DialogUITask m_dialogUITask
			{
				get
				{
					return this.m_owner.m_dialogUITask;
				}
				set
				{
					this.m_owner.m_dialogUITask = value;
				}
			}

			// Token: 0x17003E3B RID: 15931
			// (get) Token: 0x060153BA RID: 86970 RVA: 0x0056721C File Offset: 0x0056541C
			// (set) Token: 0x060153BB RID: 86971 RVA: 0x0056722C File Offset: 0x0056542C
			public GoddessDialogUITask m_goddessDialogUITask
			{
				get
				{
					return this.m_owner.m_goddessDialogUITask;
				}
				set
				{
					this.m_owner.m_goddessDialogUITask = value;
				}
			}

			// Token: 0x17003E3C RID: 15932
			// (get) Token: 0x060153BC RID: 86972 RVA: 0x0056723C File Offset: 0x0056543C
			// (set) Token: 0x060153BD RID: 86973 RVA: 0x0056724C File Offset: 0x0056544C
			public ClientWorld m_clientWorld
			{
				get
				{
					return this.m_owner.m_clientWorld;
				}
				set
				{
					this.m_owner.m_clientWorld = value;
				}
			}

			// Token: 0x17003E3D RID: 15933
			// (get) Token: 0x060153BE RID: 86974 RVA: 0x0056725C File Offset: 0x0056545C
			// (set) Token: 0x060153BF RID: 86975 RVA: 0x0056726C File Offset: 0x0056546C
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17003E3E RID: 15934
			// (get) Token: 0x060153C0 RID: 86976 RVA: 0x0056727C File Offset: 0x0056547C
			// (set) Token: 0x060153C1 RID: 86977 RVA: 0x0056728C File Offset: 0x0056548C
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17003E3F RID: 15935
			// (get) Token: 0x060153C2 RID: 86978 RVA: 0x0056729C File Offset: 0x0056549C
			// (set) Token: 0x060153C3 RID: 86979 RVA: 0x005672AC File Offset: 0x005654AC
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

			// Token: 0x17003E40 RID: 15936
			// (get) Token: 0x060153C4 RID: 86980 RVA: 0x005672BC File Offset: 0x005654BC
			// (set) Token: 0x060153C5 RID: 86981 RVA: 0x005672CC File Offset: 0x005654CC
			public bool m_isResuming
			{
				get
				{
					return this.m_owner.m_isResuming;
				}
				set
				{
					this.m_owner.m_isResuming = value;
				}
			}

			// Token: 0x17003E41 RID: 15937
			// (get) Token: 0x060153C6 RID: 86982 RVA: 0x005672DC File Offset: 0x005654DC
			// (set) Token: 0x060153C7 RID: 86983 RVA: 0x005672EC File Offset: 0x005654EC
			public bool m_isResumeNeedNextWorldStep
			{
				get
				{
					return this.m_owner.m_isResumeNeedNextWorldStep;
				}
				set
				{
					this.m_owner.m_isResumeNeedNextWorldStep = value;
				}
			}

			// Token: 0x17003E42 RID: 15938
			// (get) Token: 0x060153C8 RID: 86984 RVA: 0x005672FC File Offset: 0x005654FC
			// (set) Token: 0x060153C9 RID: 86985 RVA: 0x00567304 File Offset: 0x00565504
			public static bool s_showMainButtonBar
			{
				get
				{
					return WorldUITask.s_showMainButtonBar;
				}
				set
				{
					WorldUITask.s_showMainButtonBar = value;
				}
			}

			// Token: 0x17003E43 RID: 15939
			// (get) Token: 0x060153CA RID: 86986 RVA: 0x0056730C File Offset: 0x0056550C
			// (set) Token: 0x060153CB RID: 86987 RVA: 0x0056731C File Offset: 0x0056551C
			public List<int> m_movePath
			{
				get
				{
					return this.m_owner.m_movePath;
				}
				set
				{
					this.m_owner.m_movePath = value;
				}
			}

			// Token: 0x17003E44 RID: 15940
			// (get) Token: 0x060153CC RID: 86988 RVA: 0x0056732C File Offset: 0x0056552C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003E45 RID: 15941
			// (get) Token: 0x060153CD RID: 86989 RVA: 0x0056733C File Offset: 0x0056553C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060153CE RID: 86990 RVA: 0x0056734C File Offset: 0x0056554C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060153CF RID: 86991 RVA: 0x0056735C File Offset: 0x0056555C
			public void CollectPlayerAssets()
			{
				this.m_owner.CollectPlayerAssets();
			}

			// Token: 0x060153D0 RID: 86992 RVA: 0x0056736C File Offset: 0x0056556C
			public void CollectEventAssets()
			{
				this.m_owner.CollectEventAssets();
			}

			// Token: 0x060153D1 RID: 86993 RVA: 0x0056737C File Offset: 0x0056557C
			public void CollectMonthCardAssets()
			{
				this.m_owner.CollectMonthCardAssets();
			}

			// Token: 0x060153D2 RID: 86994 RVA: 0x0056738C File Offset: 0x0056558C
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x060153D3 RID: 86995 RVA: 0x0056739C File Offset: 0x0056559C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060153D4 RID: 86996 RVA: 0x005673AC File Offset: 0x005655AC
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060153D5 RID: 86997 RVA: 0x005673BC File Offset: 0x005655BC
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x060153D6 RID: 86998 RVA: 0x005673CC File Offset: 0x005655CC
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x060153D7 RID: 86999 RVA: 0x005673DC File Offset: 0x005655DC
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060153D8 RID: 87000 RVA: 0x005673EC File Offset: 0x005655EC
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060153D9 RID: 87001 RVA: 0x005673FC File Offset: 0x005655FC
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x060153DA RID: 87002 RVA: 0x0056740C File Offset: 0x0056560C
			public static void StopSubUITask(Type taskType)
			{
				WorldUITask.StopSubUITask(taskType);
			}

			// Token: 0x060153DB RID: 87003 RVA: 0x00567414 File Offset: 0x00565614
			public void HideAllView()
			{
				this.m_owner.HideAllView();
			}

			// Token: 0x060153DC RID: 87004 RVA: 0x00567424 File Offset: 0x00565624
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x060153DD RID: 87005 RVA: 0x00567434 File Offset: 0x00565634
			public void InitWorldMapUIController()
			{
				this.m_owner.InitWorldMapUIController();
			}

			// Token: 0x060153DE RID: 87006 RVA: 0x00567444 File Offset: 0x00565644
			public void UninitWorldMapUIController()
			{
				this.m_owner.UninitWorldMapUIController();
			}

			// Token: 0x060153DF RID: 87007 RVA: 0x00567454 File Offset: 0x00565654
			public void InitWorldUIController()
			{
				this.m_owner.InitWorldUIController();
			}

			// Token: 0x060153E0 RID: 87008 RVA: 0x00567464 File Offset: 0x00565664
			public void UninitWorldUIController()
			{
				this.m_owner.UninitWorldUIController();
			}

			// Token: 0x060153E1 RID: 87009 RVA: 0x00567474 File Offset: 0x00565674
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060153E2 RID: 87010 RVA: 0x00567484 File Offset: 0x00565684
			public void UpdateRedMarks()
			{
				this.m_owner.UpdateRedMarks();
			}

			// Token: 0x060153E3 RID: 87011 RVA: 0x00567494 File Offset: 0x00565694
			public void UpdatePlayerInfo()
			{
				this.m_owner.UpdatePlayerInfo();
			}

			// Token: 0x060153E4 RID: 87012 RVA: 0x005674A4 File Offset: 0x005656A4
			public void UpdateCurrentScenario()
			{
				this.m_owner.UpdateCurrentScenario();
			}

			// Token: 0x060153E5 RID: 87013 RVA: 0x005674B4 File Offset: 0x005656B4
			public void UpdateHeroRedMark()
			{
				this.m_owner.UpdateHeroRedMark();
			}

			// Token: 0x060153E6 RID: 87014 RVA: 0x005674C4 File Offset: 0x005656C4
			public void UpdateMissionRedMark()
			{
				this.m_owner.UpdateMissionRedMark();
			}

			// Token: 0x060153E7 RID: 87015 RVA: 0x005674D4 File Offset: 0x005656D4
			public void UpdateActivityRedMark()
			{
				this.m_owner.UpdateActivityRedMark();
			}

			// Token: 0x060153E8 RID: 87016 RVA: 0x005674E4 File Offset: 0x005656E4
			public void UpdateFriendRedMark()
			{
				this.m_owner.UpdateFriendRedMark();
			}

			// Token: 0x060153E9 RID: 87017 RVA: 0x005674F4 File Offset: 0x005656F4
			public void UpdateDrillRedMark()
			{
				this.m_owner.UpdateDrillRedMark();
			}

			// Token: 0x060153EA RID: 87018 RVA: 0x00567504 File Offset: 0x00565704
			public void UpdateFetterRedMark()
			{
				this.m_owner.UpdateFetterRedMark();
			}

			// Token: 0x060153EB RID: 87019 RVA: 0x00567514 File Offset: 0x00565714
			public void UpdateGuildRedMark()
			{
				this.m_owner.UpdateGuildRedMark();
			}

			// Token: 0x060153EC RID: 87020 RVA: 0x00567524 File Offset: 0x00565724
			public void UpdateWorldEventRedMark()
			{
				this.m_owner.UpdateWorldEventRedMark();
			}

			// Token: 0x060153ED RID: 87021 RVA: 0x00567534 File Offset: 0x00565734
			public void UpdateInvestigationButton()
			{
				this.m_owner.UpdateInvestigationButton();
			}

			// Token: 0x060153EE RID: 87022 RVA: 0x00567544 File Offset: 0x00565744
			public void UpdateOpenServiceActivityButton()
			{
				this.m_owner.UpdateOpenServiceActivityButton();
			}

			// Token: 0x060153EF RID: 87023 RVA: 0x00567554 File Offset: 0x00565754
			public void UpdateCooperateBattleButton()
			{
				this.m_owner.UpdateCooperateBattleButton();
			}

			// Token: 0x060153F0 RID: 87024 RVA: 0x00567564 File Offset: 0x00565764
			public void UpdateMonthCardInfo()
			{
				this.m_owner.UpdateMonthCardInfo();
			}

			// Token: 0x060153F1 RID: 87025 RVA: 0x00567574 File Offset: 0x00565774
			public void OnSlowTick()
			{
				this.m_owner.OnSlowTick();
			}

			// Token: 0x060153F2 RID: 87026 RVA: 0x00567584 File Offset: 0x00565784
			public void ShowEventList()
			{
				this.m_owner.ShowEventList();
			}

			// Token: 0x060153F3 RID: 87027 RVA: 0x00567594 File Offset: 0x00565794
			public bool HasRandomEvent()
			{
				return this.m_owner.HasRandomEvent();
			}

			// Token: 0x060153F4 RID: 87028 RVA: 0x005675A4 File Offset: 0x005657A4
			public void UpdateNewChatCount()
			{
				this.m_owner.UpdateNewChatCount();
			}

			// Token: 0x060153F5 RID: 87029 RVA: 0x005675B4 File Offset: 0x005657B4
			public void UpdateNewMailCount()
			{
				this.m_owner.UpdateNewMailCount();
			}

			// Token: 0x060153F6 RID: 87030 RVA: 0x005675C4 File Offset: 0x005657C4
			public void CreateClientWorld()
			{
				this.m_owner.CreateClientWorld();
			}

			// Token: 0x060153F7 RID: 87031 RVA: 0x005675D4 File Offset: 0x005657D4
			public void DestroyClientWorld()
			{
				this.m_owner.DestroyClientWorld();
			}

			// Token: 0x060153F8 RID: 87032 RVA: 0x005675E4 File Offset: 0x005657E4
			public void StartClientWorld()
			{
				this.m_owner.StartClientWorld();
			}

			// Token: 0x060153F9 RID: 87033 RVA: 0x005675F4 File Offset: 0x005657F4
			public void NextWorldStep(bool checkWorldUIGetReady)
			{
				this.m_owner.NextWorldStep(checkWorldUIGetReady);
			}

			// Token: 0x060153FA RID: 87034 RVA: 0x00567604 File Offset: 0x00565804
			public void WorldUIGetReady()
			{
				this.m_owner.WorldUIGetReady();
			}

			// Token: 0x060153FB RID: 87035 RVA: 0x00567614 File Offset: 0x00565814
			public void ClickFirstWaypoint()
			{
				this.m_owner.ClickFirstWaypoint();
			}

			// Token: 0x060153FC RID: 87036 RVA: 0x00567624 File Offset: 0x00565824
			public void StartSetProtagonistNetTask(int protagonistId)
			{
				this.m_owner.StartSetProtagonistNetTask(protagonistId);
			}

			// Token: 0x060153FD RID: 87037 RVA: 0x00567634 File Offset: 0x00565834
			public void WorldUIController_OnShowMainButtonBar(bool show)
			{
				this.m_owner.WorldUIController_OnShowMainButtonBar(show);
			}

			// Token: 0x060153FE RID: 87038 RVA: 0x00567644 File Offset: 0x00565844
			public void WorldUIController_OnShowPlayerInfo()
			{
				this.m_owner.WorldUIController_OnShowPlayerInfo();
			}

			// Token: 0x060153FF RID: 87039 RVA: 0x00567654 File Offset: 0x00565854
			public void WorldUIController_OnCompass()
			{
				this.m_owner.WorldUIController_OnCompass();
			}

			// Token: 0x06015400 RID: 87040 RVA: 0x00567664 File Offset: 0x00565864
			public void WorldUIController_OnCurrentScenario()
			{
				this.m_owner.WorldUIController_OnCurrentScenario();
			}

			// Token: 0x06015401 RID: 87041 RVA: 0x00567674 File Offset: 0x00565874
			public void WorldUIController_OnUnlockScenarioGotoRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo)
			{
				this.m_owner.WorldUIController_OnUnlockScenarioGotoRiftLevel(riftLevelInfo);
			}

			// Token: 0x06015402 RID: 87042 RVA: 0x00567684 File Offset: 0x00565884
			public void WorldUIController_OnGotoEvent(ConfigDataWaypointInfo waypointInfo, ConfigDataEventInfo eventInfo)
			{
				this.m_owner.WorldUIController_OnGotoEvent(waypointInfo, eventInfo);
			}

			// Token: 0x06015403 RID: 87043 RVA: 0x00567694 File Offset: 0x00565894
			public void WorldUIController_OnStartPastScenario(ConfigDataScenarioInfo scenarioInfo)
			{
				this.m_owner.WorldUIController_OnStartPastScenario(scenarioInfo);
			}

			// Token: 0x06015404 RID: 87044 RVA: 0x005676A4 File Offset: 0x005658A4
			public void WorldUIController_OnClosePastScenarioList()
			{
				this.m_owner.WorldUIController_OnClosePastScenarioList();
			}

			// Token: 0x06015405 RID: 87045 RVA: 0x005676B4 File Offset: 0x005658B4
			public void WorldUIController_OnShowEvent()
			{
				this.m_owner.WorldUIController_OnShowEvent();
			}

			// Token: 0x06015406 RID: 87046 RVA: 0x005676C4 File Offset: 0x005658C4
			public void WorldUIController_OnShowHero()
			{
				this.m_owner.WorldUIController_OnShowHero();
			}

			// Token: 0x06015407 RID: 87047 RVA: 0x005676D4 File Offset: 0x005658D4
			public void WorldUIController_OnShowBag()
			{
				this.m_owner.WorldUIController_OnShowBag();
			}

			// Token: 0x06015408 RID: 87048 RVA: 0x005676E4 File Offset: 0x005658E4
			public void WorldUIController_OnShowMission()
			{
				this.m_owner.WorldUIController_OnShowMission();
			}

			// Token: 0x06015409 RID: 87049 RVA: 0x005676F4 File Offset: 0x005658F4
			public void WorldUIController_OnShowFetter()
			{
				this.m_owner.WorldUIController_OnShowFetter();
			}

			// Token: 0x0601540A RID: 87050 RVA: 0x00567704 File Offset: 0x00565904
			public void WorldUIController_OnShowStore()
			{
				this.m_owner.WorldUIController_OnShowStore();
			}

			// Token: 0x0601540B RID: 87051 RVA: 0x00567714 File Offset: 0x00565914
			public void WorldUIController_OnShowSelectCard()
			{
				this.m_owner.WorldUIController_OnShowSelectCard();
			}

			// Token: 0x0601540C RID: 87052 RVA: 0x00567724 File Offset: 0x00565924
			public void WorldUIController_OnShowDrill()
			{
				this.m_owner.WorldUIController_OnShowDrill();
			}

			// Token: 0x0601540D RID: 87053 RVA: 0x00567734 File Offset: 0x00565934
			public void WorldUIController_OnShowFriend()
			{
				this.m_owner.WorldUIController_OnShowFriend();
			}

			// Token: 0x0601540E RID: 87054 RVA: 0x00567744 File Offset: 0x00565944
			public void WorldUIController_OnShowGuild()
			{
				this.m_owner.WorldUIController_OnShowGuild();
			}

			// Token: 0x0601540F RID: 87055 RVA: 0x00567754 File Offset: 0x00565954
			public void WorldUIController_OnShowUncharted()
			{
				this.m_owner.WorldUIController_OnShowUncharted();
			}

			// Token: 0x06015410 RID: 87056 RVA: 0x00567764 File Offset: 0x00565964
			public void WorldUIController_OnShowArena()
			{
				this.m_owner.WorldUIController_OnShowArena();
			}

			// Token: 0x06015411 RID: 87057 RVA: 0x00567774 File Offset: 0x00565974
			public void WorldUIController_OnShowRift()
			{
				this.m_owner.WorldUIController_OnShowRift();
			}

			// Token: 0x06015412 RID: 87058 RVA: 0x00567784 File Offset: 0x00565984
			public void WorldUIController_OnShowTest()
			{
				this.m_owner.WorldUIController_OnShowTest();
			}

			// Token: 0x06015413 RID: 87059 RVA: 0x00567794 File Offset: 0x00565994
			public void WorldUIController_OnShowCooperateBattle()
			{
				this.m_owner.WorldUIController_OnShowCooperateBattle();
			}

			// Token: 0x06015414 RID: 87060 RVA: 0x005677A4 File Offset: 0x005659A4
			public void WorldUIController_OnShowMail()
			{
				this.m_owner.WorldUIController_OnShowMail();
			}

			// Token: 0x06015415 RID: 87061 RVA: 0x005677B4 File Offset: 0x005659B4
			public void WorldUIController_OnShowChat()
			{
				this.m_owner.WorldUIController_OnShowChat();
			}

			// Token: 0x06015416 RID: 87062 RVA: 0x005677C4 File Offset: 0x005659C4
			public void WorldUIController_OnShowRanking()
			{
				this.m_owner.WorldUIController_OnShowRanking();
			}

			// Token: 0x06015417 RID: 87063 RVA: 0x005677D4 File Offset: 0x005659D4
			public void WorldUIController_OnShowActivity()
			{
				this.m_owner.WorldUIController_OnShowActivity();
			}

			// Token: 0x06015418 RID: 87064 RVA: 0x005677E4 File Offset: 0x005659E4
			public void WorldUIController_OnShowOpenServiceActivity()
			{
				this.m_owner.WorldUIController_OnShowOpenServiceActivity();
			}

			// Token: 0x06015419 RID: 87065 RVA: 0x005677F4 File Offset: 0x005659F4
			public void WorldUIController_OnMonthCardButtonClick()
			{
				this.m_owner.WorldUIController_OnMonthCardButtonClick();
			}

			// Token: 0x0601541A RID: 87066 RVA: 0x00567804 File Offset: 0x00565A04
			public void WorldUIController_OnRefreshMonthCardPanel(bool curIsOpenState)
			{
				this.m_owner.WorldUIController_OnRefreshMonthCardPanel(curIsOpenState);
			}

			// Token: 0x0601541B RID: 87067 RVA: 0x00567814 File Offset: 0x00565A14
			public void WorldUIController_OnMonthCardItemClick(int cardId)
			{
				this.m_owner.WorldUIController_OnMonthCardItemClick(cardId);
			}

			// Token: 0x0601541C RID: 87068 RVA: 0x00567824 File Offset: 0x00565A24
			public void WorldUIController_OnMonthCardItemBuyClick(int cardId)
			{
				this.m_owner.WorldUIController_OnMonthCardItemBuyClick(cardId);
			}

			// Token: 0x0601541D RID: 87069 RVA: 0x00567834 File Offset: 0x00565A34
			public void WorldUIController_OnOpenWebInvestigation()
			{
				this.m_owner.WorldUIController_OnOpenWebInvestigation();
			}

			// Token: 0x0601541E RID: 87070 RVA: 0x00567844 File Offset: 0x00565A44
			public void WorldUIController_OnYYBButtonClick()
			{
				this.m_owner.WorldUIController_OnYYBButtonClick();
			}

			// Token: 0x0601541F RID: 87071 RVA: 0x00567854 File Offset: 0x00565A54
			public void WorldUIController_OnOppoButtonClick()
			{
				this.m_owner.WorldUIController_OnOppoButtonClick();
			}

			// Token: 0x06015420 RID: 87072 RVA: 0x00567864 File Offset: 0x00565A64
			public void PDSDK_OnDoQuestionSucceed()
			{
				this.m_owner.PDSDK_OnDoQuestionSucceed();
			}

			// Token: 0x06015421 RID: 87073 RVA: 0x00567874 File Offset: 0x00565A74
			public void PDSDK_OnDoQuestionFailed()
			{
				this.m_owner.PDSDK_OnDoQuestionFailed();
			}

			// Token: 0x06015422 RID: 87074 RVA: 0x00567884 File Offset: 0x00565A84
			public void GetRewardGoodsUITask_OnStop(Task task)
			{
				this.m_owner.GetRewardGoodsUITask_OnStop(task);
			}

			// Token: 0x06015423 RID: 87075 RVA: 0x00567894 File Offset: 0x00565A94
			public void GetRewardGoodsUITask_OnClose()
			{
				this.m_owner.GetRewardGoodsUITask_OnClose();
			}

			// Token: 0x06015424 RID: 87076 RVA: 0x005678A4 File Offset: 0x00565AA4
			public void ChestUITask_OnStop(Task task)
			{
				this.m_owner.ChestUITask_OnStop(task);
			}

			// Token: 0x06015425 RID: 87077 RVA: 0x005678B4 File Offset: 0x00565AB4
			public void ChestUITask_OnClose()
			{
				this.m_owner.ChestUITask_OnClose();
			}

			// Token: 0x06015426 RID: 87078 RVA: 0x005678C4 File Offset: 0x00565AC4
			public void WorldMapUIController_OnPointerDown()
			{
				this.m_owner.WorldMapUIController_OnPointerDown();
			}

			// Token: 0x06015427 RID: 87079 RVA: 0x005678D4 File Offset: 0x00565AD4
			public void WorldMapUIController_OnPointerUp()
			{
				this.m_owner.WorldMapUIController_OnPointerUp();
			}

			// Token: 0x06015428 RID: 87080 RVA: 0x005678E4 File Offset: 0x00565AE4
			public void WorldMapUIController_OnPointerClick()
			{
				this.m_owner.WorldMapUIController_OnPointerClick();
			}

			// Token: 0x06015429 RID: 87081 RVA: 0x005678F4 File Offset: 0x00565AF4
			public void PlayerResourceUIController_OnAddGold()
			{
				this.m_owner.PlayerResourceUIController_OnAddGold();
			}

			// Token: 0x0601542A RID: 87082 RVA: 0x00567904 File Offset: 0x00565B04
			public void PlayerResourceUIController_OnAddCrystal()
			{
				this.m_owner.PlayerResourceUIController_OnAddCrystal();
			}

			// Token: 0x0601542B RID: 87083 RVA: 0x00567914 File Offset: 0x00565B14
			public void PlayerContext_OnMailsChangedNtf()
			{
				this.m_owner.PlayerContext_OnMailsChangedNtf();
			}

			// Token: 0x0601542C RID: 87084 RVA: 0x00567924 File Offset: 0x00565B24
			public void PlayerContext_OnFriendInviteNtf()
			{
				this.m_owner.PlayerContext_OnFriendInviteNtf();
			}

			// Token: 0x0601542D RID: 87085 RVA: 0x00567934 File Offset: 0x00565B34
			public void PlayerContext_OnFriendInviteAcceptNtf(UserSummary userSummy)
			{
				this.m_owner.PlayerContext_OnFriendInviteAcceptNtf(userSummy);
			}

			// Token: 0x0601542E RID: 87086 RVA: 0x00567944 File Offset: 0x00565B44
			public void PlayerContext_OnFriendshipPointsReceivedNtf()
			{
				this.m_owner.PlayerContext_OnFriendshipPointsReceivedNtf();
			}

			// Token: 0x0601542F RID: 87087 RVA: 0x00567954 File Offset: 0x00565B54
			public void PlayerContext_EventOnGiftStoreBuyGoodsNtf(string OrderId)
			{
				this.m_owner.PlayerContext_EventOnGiftStoreBuyGoodsNtf(OrderId);
			}

			// Token: 0x06015430 RID: 87088 RVA: 0x00567964 File Offset: 0x00565B64
			public void PlayerContext_OnChatMessageNtf(ChatMessage msg)
			{
				this.m_owner.PlayerContext_OnChatMessageNtf(msg);
			}

			// Token: 0x06015431 RID: 87089 RVA: 0x00567974 File Offset: 0x00565B74
			public void PlayerContext_OnMailReadAck(int obj)
			{
				this.m_owner.PlayerContext_OnMailReadAck(obj);
			}

			// Token: 0x06015432 RID: 87090 RVA: 0x00567984 File Offset: 0x00565B84
			public void PlayerContext_OnPlayerInfoChangeNtf()
			{
				this.m_owner.PlayerContext_OnPlayerInfoChangeNtf();
			}

			// Token: 0x06015433 RID: 87091 RVA: 0x00567994 File Offset: 0x00565B94
			public void PlayerContext_OnTeamRoomInviteNtf(TeamRoomInviteInfo inviteInfo)
			{
				this.m_owner.PlayerContext_OnTeamRoomInviteNtf(inviteInfo);
			}

			// Token: 0x06015434 RID: 87092 RVA: 0x005679A4 File Offset: 0x00565BA4
			public void PlayerContext_OnBattlePracticeInvitedNtf(PVPInviteInfo inviteInfo)
			{
				this.m_owner.PlayerContext_OnBattlePracticeInvitedNtf(inviteInfo);
			}

			// Token: 0x06015435 RID: 87093 RVA: 0x005679B4 File Offset: 0x00565BB4
			public void PlayerContext_OnBattleRoomTeamBattleJoinNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomTeamBattleJoinNtf();
			}

			// Token: 0x06015436 RID: 87094 RVA: 0x005679C4 File Offset: 0x00565BC4
			public void PlayerContext_OnBattleRoomPVPBattleJoinNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomPVPBattleJoinNtf();
			}

			// Token: 0x06015437 RID: 87095 RVA: 0x005679D4 File Offset: 0x00565BD4
			public void PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf();
			}

			// Token: 0x06015438 RID: 87096 RVA: 0x005679E4 File Offset: 0x00565BE4
			public void PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf();
			}

			// Token: 0x06015439 RID: 87097 RVA: 0x005679F4 File Offset: 0x00565BF4
			public void PlayerContext_OnPlayerInfoInitEnd()
			{
				this.m_owner.PlayerContext_OnPlayerInfoInitEnd();
			}

			// Token: 0x0601543A RID: 87098 RVA: 0x00567A04 File Offset: 0x00565C04
			public void StartScenario(ConfigDataScenarioInfo scenarioInfo, ConfigDataWaypointInfo prevWaypointInfo)
			{
				this.m_owner.StartScenario(scenarioInfo, prevWaypointInfo);
			}

			// Token: 0x0601543B RID: 87099 RVA: 0x00567A14 File Offset: 0x00565C14
			public void StartWaypointEvent(ConfigDataWaypointInfo waypointInfo, ConfigDataWaypointInfo prevWaypointInfo, ConfigDataEventInfo eventInfo)
			{
				this.m_owner.StartWaypointEvent(waypointInfo, prevWaypointInfo, eventInfo);
			}

			// Token: 0x0601543C RID: 87100 RVA: 0x00567A24 File Offset: 0x00565C24
			public void StartBattleRoomBattle()
			{
				this.m_owner.StartBattleRoomBattle();
			}

			// Token: 0x0601543D RID: 87101 RVA: 0x00567A34 File Offset: 0x00565C34
			public bool _StartBattleHappening(BattleType battleType, int levelId)
			{
				return this.m_owner._StartBattleHappening(battleType, levelId);
			}

			// Token: 0x0601543E RID: 87102 RVA: 0x00567A44 File Offset: 0x00565C44
			public void StartHappening(BattleType battleType, ConfigDataBattleInfo battleInfo, int monsterLevel, ConfigDataDialogInfo dialogBefore, ConfigDataDialogInfo dialogAfter)
			{
				this.m_owner.StartHappening(battleType, battleInfo, monsterLevel, dialogBefore, dialogAfter);
			}

			// Token: 0x0601543F RID: 87103 RVA: 0x00567A58 File Offset: 0x00565C58
			public void NextHappeningStep()
			{
				this.m_owner.NextHappeningStep();
			}

			// Token: 0x06015440 RID: 87104 RVA: 0x00567A68 File Offset: 0x00565C68
			public void StartLevelWayPointMoveNetTask(int waypointId, Action<int> onEnd)
			{
				this.m_owner.StartLevelWayPointMoveNetTask(waypointId, onEnd);
			}

			// Token: 0x06015441 RID: 87105 RVA: 0x00567A78 File Offset: 0x00565C78
			public void StartLevelScenarioHandleNetTask(int scenarioId, Action<int> onEnd)
			{
				this.m_owner.StartLevelScenarioHandleNetTask(scenarioId, onEnd);
			}

			// Token: 0x06015442 RID: 87106 RVA: 0x00567A88 File Offset: 0x00565C88
			public void OnLevelWayPointMoveNetTaskResult(int result, BattleReward reward, Action<int> onEnd)
			{
				this.m_owner.OnLevelWayPointMoveNetTaskResult(result, reward, onEnd);
			}

			// Token: 0x06015443 RID: 87107 RVA: 0x00567A98 File Offset: 0x00565C98
			public void ShowWaypointReward(BattleReward reward, bool isChest)
			{
				this.m_owner.ShowWaypointReward(reward, isChest);
			}

			// Token: 0x06015444 RID: 87108 RVA: 0x00567AA8 File Offset: 0x00565CA8
			public bool CheckChangeCurrentScenario(bool checkWorldUIGetReady)
			{
				return this.m_owner.CheckChangeCurrentScenario(checkWorldUIGetReady);
			}

			// Token: 0x06015445 RID: 87109 RVA: 0x00567AB8 File Offset: 0x00565CB8
			public IEnumerator Co_ChangeCurrentScenario(ConfigDataScenarioInfo scenario, bool checkWorldUIGetReady)
			{
				return this.m_owner.Co_ChangeCurrentScenario(scenario, checkWorldUIGetReady);
			}

			// Token: 0x06015446 RID: 87110 RVA: 0x00567AC8 File Offset: 0x00565CC8
			public bool CheckOpenRiftChapter()
			{
				return this.m_owner.CheckOpenRiftChapter();
			}

			// Token: 0x06015447 RID: 87111 RVA: 0x00567AD8 File Offset: 0x00565CD8
			public void CheckOrderReward()
			{
				this.m_owner.CheckOrderReward();
			}

			// Token: 0x06015448 RID: 87112 RVA: 0x00567AE8 File Offset: 0x00565CE8
			public bool CheckReturnToBeforeBattleUI()
			{
				return this.m_owner.CheckReturnToBeforeBattleUI();
			}

			// Token: 0x06015449 RID: 87113 RVA: 0x00567AF8 File Offset: 0x00565CF8
			public bool CheckOpenTeamRoomInfoUI()
			{
				return this.m_owner.CheckOpenTeamRoomInfoUI();
			}

			// Token: 0x0601544A RID: 87114 RVA: 0x00567B08 File Offset: 0x00565D08
			public void StartTeamRoomInfoUITask()
			{
				this.m_owner.StartTeamRoomInfoUITask();
			}

			// Token: 0x0601544B RID: 87115 RVA: 0x00567B18 File Offset: 0x00565D18
			public bool CheckInBattleRoom()
			{
				return this.m_owner.CheckInBattleRoom();
			}

			// Token: 0x0601544C RID: 87116 RVA: 0x00567B28 File Offset: 0x00565D28
			public void MoveToPrevWaypoint(bool moveCamera)
			{
				this.m_owner.MoveToPrevWaypoint(moveCamera);
			}

			// Token: 0x0601544D RID: 87117 RVA: 0x00567B38 File Offset: 0x00565D38
			public static void StartBattleArmyRandomSeedGetNetTask(int battleId, Action<int> onEnd)
			{
				WorldUITask.StartBattleArmyRandomSeedGetNetTask(battleId, onEnd);
			}

			// Token: 0x0601544E RID: 87118 RVA: 0x00567B44 File Offset: 0x00565D44
			public static void StartDanmakuGetNetTaskNetTask(Action<int> onEnd)
			{
				WorldUITask.StartDanmakuGetNetTaskNetTask(onEnd);
			}

			// Token: 0x0601544F RID: 87119 RVA: 0x00567B4C File Offset: 0x00565D4C
			public void PlayerArriveWaypoint(ConfigDataWaypointInfo waypointInfo, ConfigDataWaypointInfo prevWaypointInfo)
			{
				this.m_owner.PlayerArriveWaypoint(waypointInfo, prevWaypointInfo);
			}

			// Token: 0x06015450 RID: 87120 RVA: 0x00567B5C File Offset: 0x00565D5C
			public bool ShowPastScenarioList(ConfigDataWaypointInfo waypointInfo)
			{
				return this.m_owner.ShowPastScenarioList(waypointInfo);
			}

			// Token: 0x06015451 RID: 87121 RVA: 0x00567B6C File Offset: 0x00565D6C
			public void StartShowFadeOutLoadingFadeIn(Action fadeOutEnd, FadeStyle style)
			{
				this.m_owner.StartShowFadeOutLoadingFadeIn(fadeOutEnd, style);
			}

			// Token: 0x06015452 RID: 87122 RVA: 0x00567B7C File Offset: 0x00565D7C
			public void HideFadeOutLoadingFadeIn()
			{
				this.m_owner.HideFadeOutLoadingFadeIn();
			}

			// Token: 0x06015453 RID: 87123 RVA: 0x00567B8C File Offset: 0x00565D8C
			public void StartPlayerInfoUITask()
			{
				this.m_owner.StartPlayerInfoUITask();
			}

			// Token: 0x06015454 RID: 87124 RVA: 0x00567B9C File Offset: 0x00565D9C
			public void PlayerInfoUITask_OnLoadAllResCompleted()
			{
				this.m_owner.PlayerInfoUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015455 RID: 87125 RVA: 0x00567BAC File Offset: 0x00565DAC
			public void PlayerInfoUITask_OnStop(Task task)
			{
				this.m_owner.PlayerInfoUITask_OnStop(task);
			}

			// Token: 0x06015456 RID: 87126 RVA: 0x00567BBC File Offset: 0x00565DBC
			public void PlayerInfoUITask_OnClose()
			{
				this.m_owner.PlayerInfoUITask_OnClose();
			}

			// Token: 0x06015457 RID: 87127 RVA: 0x00567BCC File Offset: 0x00565DCC
			public void StartAppScoreUITask()
			{
				this.m_owner.StartAppScoreUITask();
			}

			// Token: 0x06015458 RID: 87128 RVA: 0x00567BDC File Offset: 0x00565DDC
			public void AppScoreUITask_OnLoadAllResCompleted()
			{
				this.m_owner.AppScoreUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015459 RID: 87129 RVA: 0x00567BEC File Offset: 0x00565DEC
			public void AppScoreUITask_OnStop(Task task)
			{
				this.m_owner.AppScoreUITask_OnStop(task);
			}

			// Token: 0x0601545A RID: 87130 RVA: 0x00567BFC File Offset: 0x00565DFC
			public void AppScoreUITask_OnClose()
			{
				this.m_owner.AppScoreUITask_OnClose();
			}

			// Token: 0x0601545B RID: 87131 RVA: 0x00567C0C File Offset: 0x00565E0C
			public void StartSignUITask()
			{
				this.m_owner.StartSignUITask();
			}

			// Token: 0x0601545C RID: 87132 RVA: 0x00567C1C File Offset: 0x00565E1C
			public void SignUITask_OnLoadAllResCompleted()
			{
				this.m_owner.SignUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601545D RID: 87133 RVA: 0x00567C2C File Offset: 0x00565E2C
			public void StartActivityNoticeUITask()
			{
				this.m_owner.StartActivityNoticeUITask();
			}

			// Token: 0x0601545E RID: 87134 RVA: 0x00567C3C File Offset: 0x00565E3C
			public void ActivityNoticeUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ActivityNoticeUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601545F RID: 87135 RVA: 0x00567C4C File Offset: 0x00565E4C
			public void StartHeroUITask(UIIntent fromIntent)
			{
				this.m_owner.StartHeroUITask(fromIntent);
			}

			// Token: 0x06015460 RID: 87136 RVA: 0x00567C5C File Offset: 0x00565E5C
			public void HeroUITask_OnLoadAllResCompleted()
			{
				this.m_owner.HeroUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015461 RID: 87137 RVA: 0x00567C6C File Offset: 0x00565E6C
			public void StartBagUITask()
			{
				this.m_owner.StartBagUITask();
			}

			// Token: 0x06015462 RID: 87138 RVA: 0x00567C7C File Offset: 0x00565E7C
			public void BagUITask_OnLoadAllResCompleted()
			{
				this.m_owner.BagUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015463 RID: 87139 RVA: 0x00567C8C File Offset: 0x00565E8C
			public void StartMissionUITask(UIIntent fromIntent)
			{
				this.m_owner.StartMissionUITask(fromIntent);
			}

			// Token: 0x06015464 RID: 87140 RVA: 0x00567C9C File Offset: 0x00565E9C
			public void MissionUITask_OnLoadAllResCompleted()
			{
				this.m_owner.MissionUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015465 RID: 87141 RVA: 0x00567CAC File Offset: 0x00565EAC
			public void StartOpenServiceActivityUITask()
			{
				this.m_owner.StartOpenServiceActivityUITask();
			}

			// Token: 0x06015466 RID: 87142 RVA: 0x00567CBC File Offset: 0x00565EBC
			public void OpenServiceActivityUITask_OnLoadAllResCompleted()
			{
				this.m_owner.OpenServiceActivityUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015467 RID: 87143 RVA: 0x00567CCC File Offset: 0x00565ECC
			public void StartFettersUITask(ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo, UIIntent fromIntent)
			{
				this.m_owner.StartFettersUITask(heroDungeonLevelInfo, fromIntent);
			}

			// Token: 0x06015468 RID: 87144 RVA: 0x00567CDC File Offset: 0x00565EDC
			public void FettersUITask_OnStop(Task task)
			{
				this.m_owner.FettersUITask_OnStop(task);
			}

			// Token: 0x06015469 RID: 87145 RVA: 0x00567CEC File Offset: 0x00565EEC
			public void FettersUITask_OnLoadAllResCompleted()
			{
				this.m_owner.FettersUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601546A RID: 87146 RVA: 0x00567CFC File Offset: 0x00565EFC
			public void FetterUITask_StartHeroDungeon(Hero hero, UIIntent fromIntent)
			{
				this.m_owner.FetterUITask_StartHeroDungeon(hero, fromIntent);
			}

			// Token: 0x0601546B RID: 87147 RVA: 0x00567D0C File Offset: 0x00565F0C
			public void StartArenaSelectUITask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent)
			{
				this.m_owner.StartArenaSelectUITask(arenaUIType, isBattleReport, fromIntent);
			}

			// Token: 0x0601546C RID: 87148 RVA: 0x00567D1C File Offset: 0x00565F1C
			public void ArenaSelectUITask_OnStop(Task task)
			{
				this.m_owner.ArenaSelectUITask_OnStop(task);
			}

			// Token: 0x0601546D RID: 87149 RVA: 0x00567D2C File Offset: 0x00565F2C
			public void ArenaSelectUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ArenaSelectUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601546E RID: 87150 RVA: 0x00567D3C File Offset: 0x00565F3C
			public void ArenaSelectUITask_OnShowArena(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent)
			{
				this.m_owner.ArenaSelectUITask_OnShowArena(arenaUIType, isBattleReport, fromIntent);
			}

			// Token: 0x0601546F RID: 87151 RVA: 0x00567D4C File Offset: 0x00565F4C
			public void StartArenaUITask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent)
			{
				this.m_owner.StartArenaUITask(arenaUIType, isBattleReport, fromIntent);
			}

			// Token: 0x06015470 RID: 87152 RVA: 0x00567D5C File Offset: 0x00565F5C
			public void ArenaUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ArenaUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015471 RID: 87153 RVA: 0x00567D6C File Offset: 0x00565F6C
			public void ArenaUITask_OnStop(Task task)
			{
				this.m_owner.ArenaUITask_OnStop(task);
			}

			// Token: 0x06015472 RID: 87154 RVA: 0x00567D7C File Offset: 0x00565F7C
			public void ArenaUITask_OnStartArenaBattle(bool isRevenge)
			{
				this.m_owner.ArenaUITask_OnStartArenaBattle(isRevenge);
			}

			// Token: 0x06015473 RID: 87155 RVA: 0x00567D8C File Offset: 0x00565F8C
			public void ArenaUITask_OnStartArenaBattleReplay(ArenaBattleReport battleReport)
			{
				this.m_owner.ArenaUITask_OnStartArenaBattleReplay(battleReport);
			}

			// Token: 0x06015474 RID: 87156 RVA: 0x00567D9C File Offset: 0x00565F9C
			public void ArenaUITask_OnStartRealTimePVPBattleReplay(RealTimePVPBattleReport battleReport)
			{
				this.m_owner.ArenaUITask_OnStartRealTimePVPBattleReplay(battleReport);
			}

			// Token: 0x06015475 RID: 87157 RVA: 0x00567DAC File Offset: 0x00565FAC
			public void InitAndStartArenaUITask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent)
			{
				this.m_owner.InitAndStartArenaUITask(arenaUIType, isBattleReport, fromIntent);
			}

			// Token: 0x06015476 RID: 87158 RVA: 0x00567DBC File Offset: 0x00565FBC
			public void StartArenaBattleReportBasicDataGetNetTask(ArenaUIType arenaUIType, bool isBattleReport, UIIntent fromIntent)
			{
				this.m_owner.StartArenaBattleReportBasicDataGetNetTask(arenaUIType, isBattleReport, fromIntent);
			}

			// Token: 0x06015477 RID: 87159 RVA: 0x00567DCC File Offset: 0x00565FCC
			public void StartStoreUITask(StoreId storeId, UIIntent fromIntent)
			{
				this.m_owner.StartStoreUITask(storeId, fromIntent);
			}

			// Token: 0x06015478 RID: 87160 RVA: 0x00567DDC File Offset: 0x00565FDC
			public void StoreUITask_OnLoadAllResCompleted()
			{
				this.m_owner.StoreUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015479 RID: 87161 RVA: 0x00567DEC File Offset: 0x00565FEC
			public void StartSelectCardUITask(int cardPoolId, UIIntent fromIntent)
			{
				this.m_owner.StartSelectCardUITask(cardPoolId, fromIntent);
			}

			// Token: 0x0601547A RID: 87162 RVA: 0x00567DFC File Offset: 0x00565FFC
			public void SelectCardUITask_OnLoadAllResCompleted()
			{
				this.m_owner.SelectCardUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601547B RID: 87163 RVA: 0x00567E0C File Offset: 0x0056600C
			public void StartDrillUITask(int drillState, UIIntent fromIntent)
			{
				this.m_owner.StartDrillUITask(drillState, fromIntent);
			}

			// Token: 0x0601547C RID: 87164 RVA: 0x00567E1C File Offset: 0x0056601C
			public void DrillUITask_OnLoadAllResCompleted()
			{
				this.m_owner.DrillUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601547D RID: 87165 RVA: 0x00567E2C File Offset: 0x0056602C
			public void StartFriendUITask(UIIntent fromIntent)
			{
				this.m_owner.StartFriendUITask(fromIntent);
			}

			// Token: 0x0601547E RID: 87166 RVA: 0x00567E3C File Offset: 0x0056603C
			public void StartGuildUITask(UIIntent fromIntent, bool goToGuildMassiveCombat)
			{
				this.m_owner.StartGuildUITask(fromIntent, goToGuildMassiveCombat);
			}

			// Token: 0x0601547F RID: 87167 RVA: 0x00567E4C File Offset: 0x0056604C
			public void FriendUITask_OnLoadAllResCompleted()
			{
				this.m_owner.FriendUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015480 RID: 87168 RVA: 0x00567E5C File Offset: 0x0056605C
			public void StartMailUITask()
			{
				this.m_owner.StartMailUITask();
			}

			// Token: 0x06015481 RID: 87169 RVA: 0x00567E6C File Offset: 0x0056606C
			public void StartRankingUITask()
			{
				this.m_owner.StartRankingUITask();
			}

			// Token: 0x06015482 RID: 87170 RVA: 0x00567E7C File Offset: 0x0056607C
			public void StartActivityUITask(int activityId)
			{
				this.m_owner.StartActivityUITask(activityId);
			}

			// Token: 0x06015483 RID: 87171 RVA: 0x00567E8C File Offset: 0x0056608C
			public void ActivityUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ActivityUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015484 RID: 87172 RVA: 0x00567E9C File Offset: 0x0056609C
			public void StartTeamUITask()
			{
				this.m_owner.StartTeamUITask();
			}

			// Token: 0x06015485 RID: 87173 RVA: 0x00567EAC File Offset: 0x005660AC
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015486 RID: 87174 RVA: 0x00567EBC File Offset: 0x005660BC
			public void StartTestUITask()
			{
				this.m_owner.StartTestUITask();
			}

			// Token: 0x06015487 RID: 87175 RVA: 0x00567ECC File Offset: 0x005660CC
			public void TestUITask_OnStop(Task task)
			{
				this.m_owner.TestUITask_OnStop(task);
			}

			// Token: 0x06015488 RID: 87176 RVA: 0x00567EDC File Offset: 0x005660DC
			public void TestUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TestUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015489 RID: 87177 RVA: 0x00567EEC File Offset: 0x005660EC
			public void TestUITask_OnStartBattle(ConfigDataBattleInfo battleInfo)
			{
				this.m_owner.TestUITask_OnStartBattle(battleInfo);
			}

			// Token: 0x0601548A RID: 87178 RVA: 0x00567EFC File Offset: 0x005660FC
			public void StartUnchartedUITask(BattleType battleType, int chapterId, int tabIndex, UIIntent fromIntent)
			{
				this.m_owner.StartUnchartedUITask(battleType, chapterId, tabIndex, fromIntent);
			}

			// Token: 0x0601548B RID: 87179 RVA: 0x00567F10 File Offset: 0x00566110
			public void UnchartedUITask_OnStop(Task task)
			{
				this.m_owner.UnchartedUITask_OnStop(task);
			}

			// Token: 0x0601548C RID: 87180 RVA: 0x00567F20 File Offset: 0x00566120
			public void UnchartedUITask_OnLoadAllResCompleted()
			{
				this.m_owner.UnchartedUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601548D RID: 87181 RVA: 0x00567F30 File Offset: 0x00566130
			public void _StartUnchartedSubUITask(BattleType battleType, int chapterId, UIIntent fromIntent)
			{
				this.m_owner._StartUnchartedSubUITask(battleType, chapterId, fromIntent);
			}

			// Token: 0x0601548E RID: 87182 RVA: 0x00567F40 File Offset: 0x00566140
			public void StartRiftUITask(ConfigDataRiftLevelInfo levelInfo, bool openLevelInfo, bool needReturnToChapter, UIIntent fromIntent, NeedGoods needGoods)
			{
				this.m_owner.StartRiftUITask(levelInfo, openLevelInfo, needReturnToChapter, fromIntent, needGoods);
			}

			// Token: 0x0601548F RID: 87183 RVA: 0x00567F54 File Offset: 0x00566154
			public void RiftUITask_OnStop(Task task)
			{
				this.m_owner.RiftUITask_OnStop(task);
			}

			// Token: 0x06015490 RID: 87184 RVA: 0x00567F64 File Offset: 0x00566164
			public void RiftUITask_OnLoadAllResCompleted()
			{
				this.m_owner.RiftUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015491 RID: 87185 RVA: 0x00567F74 File Offset: 0x00566174
			public void RiftUITask_GoToScenario(int scenarioID)
			{
				this.m_owner.RiftUITask_GoToScenario(scenarioID);
			}

			// Token: 0x06015492 RID: 87186 RVA: 0x00567F84 File Offset: 0x00566184
			public void StartHeroDungeonUITask(ConfigDataHeroDungeonLevelInfo levelInfo, bool openLevelInfo, Hero hero, UIIntent fromIntent)
			{
				this.m_owner.StartHeroDungeonUITask(levelInfo, openLevelInfo, hero, fromIntent);
			}

			// Token: 0x06015493 RID: 87187 RVA: 0x00567F98 File Offset: 0x00566198
			public void HeroDungeonUITask_OnLoadAllResCompleted()
			{
				this.m_owner.HeroDungeonUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015494 RID: 87188 RVA: 0x00567FA8 File Offset: 0x005661A8
			public void StartHeroPhantomUITask(ConfigDataHeroPhantomInfo heroPhantomInfo, UIIntent fromIntent)
			{
				this.m_owner.StartHeroPhantomUITask(heroPhantomInfo, fromIntent);
			}

			// Token: 0x06015495 RID: 87189 RVA: 0x00567FB8 File Offset: 0x005661B8
			public void HeroPhantomUITask_OnLoadAllResCompleted()
			{
				this.m_owner.HeroPhantomUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015496 RID: 87190 RVA: 0x00567FC8 File Offset: 0x005661C8
			public void StartThearchyUITask(ConfigDataThearchyTrialInfo thearchyTrialInfo, UIIntent fromIntent)
			{
				this.m_owner.StartThearchyUITask(thearchyTrialInfo, fromIntent);
			}

			// Token: 0x06015497 RID: 87191 RVA: 0x00567FD8 File Offset: 0x005661D8
			public void ThearchyUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ThearchyUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06015498 RID: 87192 RVA: 0x00567FE8 File Offset: 0x005661E8
			public void StartAnikiUITask(ConfigDataAnikiGymInfo anikiGymInfo, UIIntent fromIntent)
			{
				this.m_owner.StartAnikiUITask(anikiGymInfo, fromIntent);
			}

			// Token: 0x06015499 RID: 87193 RVA: 0x00567FF8 File Offset: 0x005661F8
			public void AnikiUITask_OnLoadAllResCompleted()
			{
				this.m_owner.AnikiUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601549A RID: 87194 RVA: 0x00568008 File Offset: 0x00566208
			public void StartTreasureMapUITask(UIIntent fromIntent)
			{
				this.m_owner.StartTreasureMapUITask(fromIntent);
			}

			// Token: 0x0601549B RID: 87195 RVA: 0x00568018 File Offset: 0x00566218
			public void TreasureMapUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TreasureMapUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601549C RID: 87196 RVA: 0x00568028 File Offset: 0x00566228
			public void StartMemoryCorridorUITask(ConfigDataMemoryCorridorInfo memoryCorridorInfo, UIIntent fromIntent)
			{
				this.m_owner.StartMemoryCorridorUITask(memoryCorridorInfo, fromIntent);
			}

			// Token: 0x0601549D RID: 87197 RVA: 0x00568038 File Offset: 0x00566238
			public void MemoryCorridorUITask_OnLoadAllResCompleted()
			{
				this.m_owner.MemoryCorridorUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601549E RID: 87198 RVA: 0x00568048 File Offset: 0x00566248
			public void StartHeroTrainningUITask(ConfigDataHeroTrainningInfo heroTrainningInfo, UIIntent fromIntent)
			{
				this.m_owner.StartHeroTrainningUITask(heroTrainningInfo, fromIntent);
			}

			// Token: 0x0601549F RID: 87199 RVA: 0x00568058 File Offset: 0x00566258
			public void HeroTrainningUITask_OnLoadAllResCompleted()
			{
				this.m_owner.HeroTrainningUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154A0 RID: 87200 RVA: 0x00568068 File Offset: 0x00566268
			public void StartCooperateBattleUITask(ConfigDataCooperateBattleInfo cooperateBattleInfo, UIIntent fromIntent)
			{
				this.m_owner.StartCooperateBattleUITask(cooperateBattleInfo, fromIntent);
			}

			// Token: 0x060154A1 RID: 87201 RVA: 0x00568078 File Offset: 0x00566278
			public void CooperateBattleUITask_OnLoadAllResCompleted()
			{
				this.m_owner.CooperateBattleUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154A2 RID: 87202 RVA: 0x00568088 File Offset: 0x00566288
			public void StartUnchartedScoreUITask(ConfigDataUnchartedScoreInfo unchartedScoreInfo, BattleType battleType, UIIntent fromIntent)
			{
				this.m_owner.StartUnchartedScoreUITask(unchartedScoreInfo, battleType, fromIntent);
			}

			// Token: 0x060154A3 RID: 87203 RVA: 0x00568098 File Offset: 0x00566298
			public void UnchartedScoreUITask_OnLoadAllResCompleted()
			{
				this.m_owner.UnchartedScoreUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154A4 RID: 87204 RVA: 0x005680A8 File Offset: 0x005662A8
			public void StartClimbTowerUITask(UIIntent fromIntent)
			{
				this.m_owner.StartClimbTowerUITask(fromIntent);
			}

			// Token: 0x060154A5 RID: 87205 RVA: 0x005680B8 File Offset: 0x005662B8
			public void ClimbTowerUITask_OnLoadAllResCompleted()
			{
				this.m_owner.ClimbTowerUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154A6 RID: 87206 RVA: 0x005680C8 File Offset: 0x005662C8
			public void StartWorldEventMissionUITask(ConfigDataEventInfo eventInfo)
			{
				this.m_owner.StartWorldEventMissionUITask(eventInfo);
			}

			// Token: 0x060154A7 RID: 87207 RVA: 0x005680D8 File Offset: 0x005662D8
			public void WorldEventMissionUITask_OnStop(Task task)
			{
				this.m_owner.WorldEventMissionUITask_OnStop(task);
			}

			// Token: 0x060154A8 RID: 87208 RVA: 0x005680E8 File Offset: 0x005662E8
			public void WorldEventMissionUITask_OnEnterMission()
			{
				this.m_owner.WorldEventMissionUITask_OnEnterMission();
			}

			// Token: 0x060154A9 RID: 87209 RVA: 0x005680F8 File Offset: 0x005662F8
			public void WorldEventMissionUITask_OnClose()
			{
				this.m_owner.WorldEventMissionUITask_OnClose();
			}

			// Token: 0x060154AA RID: 87210 RVA: 0x00568108 File Offset: 0x00566308
			public void StartGoddessDialogUITask()
			{
				this.m_owner.StartGoddessDialogUITask();
			}

			// Token: 0x060154AB RID: 87211 RVA: 0x00568118 File Offset: 0x00566318
			public void GoddessDialogUITask_OnLoadAllResCompleted()
			{
				this.m_owner.GoddessDialogUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154AC RID: 87212 RVA: 0x00568128 File Offset: 0x00566328
			public void GoddessDialogUITask_OnClose(int protagonistId)
			{
				this.m_owner.GoddessDialogUITask_OnClose(protagonistId);
			}

			// Token: 0x060154AD RID: 87213 RVA: 0x00568138 File Offset: 0x00566338
			public void StartDialogUITask(ConfigDataDialogInfo dialogInfo)
			{
				this.m_owner.StartDialogUITask(dialogInfo);
			}

			// Token: 0x060154AE RID: 87214 RVA: 0x00568148 File Offset: 0x00566348
			public void DialogUITask_OnLoadAllResCompleted()
			{
				this.m_owner.DialogUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154AF RID: 87215 RVA: 0x00568158 File Offset: 0x00566358
			public void DialogUITask_OnClose(bool isSkip)
			{
				this.m_owner.DialogUITask_OnClose(isSkip);
			}

			// Token: 0x060154B0 RID: 87216 RVA: 0x00568168 File Offset: 0x00566368
			public void StartBattleUITask(ConfigDataBattleInfo battleInfo, BattleType battleType)
			{
				this.m_owner.StartBattleUITask(battleInfo, battleType);
			}

			// Token: 0x060154B1 RID: 87217 RVA: 0x00568178 File Offset: 0x00566378
			public static void HideInviteAndChatUITask()
			{
				WorldUITask.HideInviteAndChatUITask();
			}

			// Token: 0x060154B2 RID: 87218 RVA: 0x00568180 File Offset: 0x00566380
			public static void UnloadAssetsAndStartBattleUITask()
			{
				WorldUITask.UnloadAssetsAndStartBattleUITask();
			}

			// Token: 0x060154B3 RID: 87219 RVA: 0x00568188 File Offset: 0x00566388
			public static IEnumerator Co_UnloadAssetsAndStartBattleUITask()
			{
				return WorldUITask.Co_UnloadAssetsAndStartBattleUITask();
			}

			// Token: 0x060154B4 RID: 87220 RVA: 0x00568190 File Offset: 0x00566390
			public static void BattleUITask_OnLoadAllResCompleted()
			{
				WorldUITask.BattleUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060154B5 RID: 87221 RVA: 0x00568198 File Offset: 0x00566398
			public void StartArenaBattleUITask(bool isRevenge)
			{
				this.m_owner.StartArenaBattleUITask(isRevenge);
			}

			// Token: 0x060154B6 RID: 87222 RVA: 0x005681A8 File Offset: 0x005663A8
			public void StartArenaReplayBattleUITask(ArenaBattleReport battleReport)
			{
				this.m_owner.StartArenaReplayBattleUITask(battleReport);
			}

			// Token: 0x060154B7 RID: 87223 RVA: 0x005681B8 File Offset: 0x005663B8
			public void StartRealTimePVPReplayBattleUITask(RealTimePVPBattleReport battleReport)
			{
				this.m_owner.StartRealTimePVPReplayBattleUITask(battleReport);
			}

			// Token: 0x060154B8 RID: 87224 RVA: 0x005681C8 File Offset: 0x005663C8
			public void FadeOutAndStartBattleUITask()
			{
				this.m_owner.FadeOutAndStartBattleUITask();
			}

			// Token: 0x060154B9 RID: 87225 RVA: 0x005681D8 File Offset: 0x005663D8
			public void _StartGetPathTargetUITask(GetPathData getPath, UIIntent fromIntent, NeedGoods needGoods)
			{
				this.m_owner._StartGetPathTargetUITask(getPath, fromIntent, needGoods);
			}

			// Token: 0x0400B984 RID: 47492
			private WorldUITask m_owner;
		}
	}
}
