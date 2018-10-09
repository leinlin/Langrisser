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
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AD8 RID: 2776
	[HotFix]
	public class BattleUITask : UITask, IClientBattleListener
	{
		// Token: 0x0600B6F4 RID: 46836 RVA: 0x00326D60 File Offset: 0x00324F60
		public BattleUITask(string name) : base(name)
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
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

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x00327444 File Offset: 0x00325644
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
			this.m_trainingTechs = projectLPlayerContext.GetTrainingGroundAvailableTechs();
			if (this.m_loadState == BattleLoadState.Prepare)
			{
				this.CollectBattlePrepareAssets();
			}
			else if (this.m_loadState == BattleLoadState.StartBattle)
			{
				this.CollectBattleAssets();
			}
			base.CollectAsset(UIUtility.GetUIPrefabPath<BigExpressionController>());
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x0032750C File Offset: 0x0032570C
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

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x003275AC File Offset: 0x003257AC
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
			this.CreateClientBattle();
			this.InitBattleSceneUIController();
			this.InitBattlePrepareUIController();
			this.InitBattleUIController();
			this.InitCombatUIController();
			this.InitPreCombatUIController();
			this.InitBattleRoomUIController();
			this.InitBattleCommonUIController();
			UIUtility.ActivateLayer(this.m_battleRoomUIController, false);
			UIUtility.ActivateLayer(this.m_battleUIController, false);
			UIUtility.ActivateLayer(this.m_battleDanmakuUIController, false);
			UIUtility.ActivateLayer(this.m_battleActorInfoUIController, false);
			UIUtility.ActivateLayer(this.m_actionOrderUIController, false);
			UIUtility.ActivateLayer(this.m_battlePrepareUIController, false);
			UIUtility.ActivateLayer(this.m_pvpBattlePrepareUIController, false);
			UIUtility.ActivateLayer(this.m_battlePrepareActorInfoUIController, false);
			UIUtility.ActivateLayer(this.m_battlePauseUIController, false);
			UIUtility.ActivateLayer(this.m_battleTreasureDialogUIController, false);
			UIUtility.ActivateLayer(this.m_combatUIController, false);
			UIUtility.ActivateLayer(this.m_preCombatUIController, false);
			UIUtility.ActivateLayer(this.m_battleCommonUIController, true);
			Utility.LogMemorySize("BattleUITask.InitAllUIControllers");
		}

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x003276E8 File Offset: 0x003258E8
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
			this.UninitBattleSceneUIController();
			this.UninitBattlePrepareUIController();
			this.UninitBattleUIController();
			this.UninitCombatUIController();
			this.UninitPreCombatUIController();
			this.UninitBattleRoomUIController();
			this.UninitBattleCommonUIController();
			this.DestroyClientBattle();
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00327780 File Offset: 0x00325980
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_isStartBattleAutoBattle = LocalConfig.Instance.IsAutoBattle(projectLPlayerContext.Happening.BattleType);
			this.m_isStartInBattleRoom = (projectLPlayerContext.IsInBattleRoom() && projectLPlayerContext.GetBattleRoom() != null);
			global::Debug.Log("BattleUITask.OnStart");
			global::Debug.Log(string.Format("BattleType:{0}", projectLPlayerContext.CurrentBattle.BattleType));
			if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				global::Debug.Log(string.Format("BattleId:{0}", projectLPlayerContext.CurrentBattle.BattleInfo.ID));
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				global::Debug.Log(string.Format("ArenaBattleId:{0}", projectLPlayerContext.CurrentBattle.ArenaBattleInfo.ID));
			}
			else if (projectLPlayerContext.CurrentBattle.PVPBattleInfo != null)
			{
				global::Debug.Log(string.Format("PVPBattleId:{0}", projectLPlayerContext.CurrentBattle.PVPBattleInfo.ID));
			}
			else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo != null)
			{
				global::Debug.Log(string.Format("RealTimePVPBattleId:{0}", projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo.ID));
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				global::Debug.Log(string.Format("BattleRoomType:{0}, RoomId:{1}, BattleId:{2}", battleRoom.BattleRoomType, battleRoom.RoomId, battleRoom.BattleId));
				for (int i = 0; i < battleRoom.Players.Count; i++)
				{
					BattleRoomPlayer battleRoomPlayer = battleRoom.Players[i];
					global::Debug.Log(string.Format("Player{0}:{1}, UserId:{2}, SessionId:{3}", new object[]
					{
						i,
						battleRoomPlayer.Name,
						battleRoomPlayer.UserId,
						battleRoomPlayer.SessionId
					}));
				}
				global::Debug.Log(string.Format("MyPlayerIndex:{0}", battleRoom.MyPlayerIndex));
			}
			if (battleRoom != null)
			{
				this.m_isStartBattleAutoBattle = (battleRoom.GetMyPlayer().PlayerBattleStatus == PlayerBattleStatus.Auto);
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null || projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				this.m_isStartBattleAutoBattle = false;
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				this.m_isStartBattleAutoBattle = projectLPlayerContext.IsArenaAutoBattle();
			}
			else if (this.m_isStartBattleAutoBattle)
			{
				if (projectLPlayerContext.Happening.ScenarioInfo != null)
				{
					if (!projectLPlayerContext.IsScenarioFinished(projectLPlayerContext.Happening.ScenarioInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.EventInfo != null)
				{
					this.m_isStartBattleAutoBattle = false;
				}
				else if (projectLPlayerContext.Happening.RiftLevelInfo != null)
				{
					if (projectLPlayerContext.GetRiftLevelChallengeNum(projectLPlayerContext.Happening.RiftLevelInfo.ID) <= 0)
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.HeroDungeonLevelInfo != null)
				{
					if (projectLPlayerContext.GetHeroDungeonLevelChallengeNum(projectLPlayerContext.Happening.HeroDungeonLevelInfo) <= 0)
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.ThearchyLevelInfo != null)
				{
					if (!projectLPlayerContext.IsThearchyTrialLevelFinished(projectLPlayerContext.Happening.ThearchyLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.AnikiLevelInfo != null)
				{
					if (!projectLPlayerContext.IsAnikiLevelFinished(projectLPlayerContext.Happening.AnikiLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.TreasureLevelInfo != null)
				{
					if (!projectLPlayerContext.IsTreasureLevelFinished(projectLPlayerContext.Happening.TreasureLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.MemoryCorridorLevelInfo != null)
				{
					if (!projectLPlayerContext.IsMemoryCorridorLevelFinished(projectLPlayerContext.Happening.MemoryCorridorLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.HeroTrainningLevelInfo != null)
				{
					if (!projectLPlayerContext.IsHeroTrainningLevelFinished(projectLPlayerContext.Happening.HeroTrainningLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.HeroPhantomLevelInfo != null)
				{
					if (!projectLPlayerContext.IsHeroPhantomLevelFinihed(projectLPlayerContext.Happening.HeroPhantomLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.ScoreLevelInfo != null)
				{
					if (!projectLPlayerContext.IsUnchartedScoreLevelFinished(projectLPlayerContext.Happening.ScoreLevelInfo.UnchartedScoreInfo.ID, projectLPlayerContext.Happening.ScoreLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.ChallengeLevelInfo != null)
				{
					if (!projectLPlayerContext.IsUnchartedChallengeLevelFinished(projectLPlayerContext.Happening.ChallengeLevelInfo.UnchartedScoreInfo.ID, projectLPlayerContext.Happening.ChallengeLevelInfo.ID))
					{
						this.m_isStartBattleAutoBattle = false;
					}
				}
				else if (projectLPlayerContext.Happening.TowerFloorInfo != null)
				{
					this.m_isStartBattleAutoBattle = false;
				}
				else if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
				{
				}
				if (projectLPlayerContext.Happening.BattleInfo == null)
				{
					this.m_isStartBattleAutoBattle = false;
				}
				if (projectLPlayerContext.Happening.BattleInfo != null && UserGuideUITask.IsUserGuideBattle(projectLPlayerContext.Happening.BattleInfo.ID))
				{
					this.m_isStartBattleAutoBattle = false;
				}
				LocalConfig.Instance.SetAutoBattle(projectLPlayerContext.Happening.BattleType, this.m_isStartBattleAutoBattle);
				LocalConfig.Instance.Save();
			}
			this.m_battlePerformState = BattlePerformState.InBattle;
			if (!projectLPlayerContext.IsNeedRebuildBattle() && !this.m_isStartBattleAutoBattle && projectLPlayerContext.Happening.BattleInfo != null && projectLPlayerContext.Happening.BattleInfo.m_beforePerformBattleInfo != null)
			{
				projectLPlayerContext.CurrentBattle.BattleInfo = projectLPlayerContext.Happening.BattleInfo.m_beforePerformBattleInfo;
				this.m_battlePerformState = BattlePerformState.Before;
			}
			return base.OnStart(intent);
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x00327E2C File Offset: 0x0032602C
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
			NoticeUITask.m_isEnableClick = true;
			BattleUITask.StopSubUITask(typeof(BattleDialogUITask));
			BattleUITask.StopSubUITask(typeof(BattleResultUITask));
			BattleUITask.StopSubUITask(typeof(BattleResultScoreUITask));
			BattleUITask.StopSubUITask(typeof(BattleLoseUITask));
			BattleUITask.StopSubUITask(typeof(BattleReportEndUITask));
			BattleUITask.StopSubUITask(typeof(UserGuideUITask));
			BattleUITask.StopSubUITask(typeof(UserGuideDialogUITask));
			BattleUITask.StopSubUITask(typeof(PlayerSettingUITask));
			BattleUITask.StopSubUITask(typeof(PlayerLevelUpUITask));
			BattleUITask.StopSubUITask(typeof(PlayerSimpleInfoUITask));
			BattleUITask.StopSubUITask(typeof(BusinessCardUITask));
			BattleUITask.StopSubUITask(typeof(ChestUITask));
			BattleUITask.StopSubUITask(typeof(GetRewardGoodsUITask));
			BattleUITask.StopSubUITask(typeof(InstructionUITask));
			BattleUITask.StopSubUITask(typeof(RewardGoodsDescUITask));
			BattleUITask.StopSubUITask(typeof(VoiceRecordUITask));
			BattleUITask.StopSubUITask(typeof(HeroSkinChangeUITask));
			BattleUITask.StopSubUITask(typeof(StoreSoldierSkinDetailUITask));
			base.OnStop();
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x00327FA8 File Offset: 0x003261A8
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

		// Token: 0x0600B6FC RID: 46844 RVA: 0x00328074 File Offset: 0x00326274
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
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x003280D4 File Offset: 0x003262D4
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loadState == BattleLoadState.Prepare)
			{
				this.m_loadState = BattleLoadState.None;
				this.PrepareClientBattle(true);
				this.ProcessBattlePreparePendingNtfs(false);
				InviteNotifyUITask.CheckPendingInviteInfo();
				Shader.WarmupAllShaders();
			}
			else if (this.m_loadState == BattleLoadState.StartBattle)
			{
				this.m_loadState = BattleLoadState.None;
				this.StartClientBattle();
				this.ProcessBattlePendingNtfs();
				Shader.WarmupAllShaders();
			}
			base.PostUpdateView();
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x00328190 File Offset: 0x00326390
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
			if (this.m_clientBattle == null)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			this.m_clientBattle.Tick(deltaTime);
			if (!this.IsLoading())
			{
				int second = DateTime.Now.Second;
				if (second != this.m_nowSeconds)
				{
					this.m_nowSeconds = second;
					if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
					{
						this.UpdateBattleRoomPrepareTimeout();
						this.UpdateRealtimePVPBattlePrepareTimeout();
					}
					else
					{
						this.UpdateBattleRoomMyActionCountdown();
						this.UpdateBattleRoomOtherActionCountdown();
					}
				}
				if (this.m_pendingHeroSetupNtfs.Count > 0)
				{
					this.ProcessBattlePreparePendingNtfs(true);
				}
			}
			if (this.m_isStartInBattleRoom)
			{
				CommonUITask.TickCheckOnline();
			}
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x00328298 File Offset: 0x00326498
		private static void StopSubUITask(Type taskType)
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(taskType);
			if (uitaskBase != null)
			{
				uitaskBase.Stop();
			}
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x003282B8 File Offset: 0x003264B8
		private bool IsLoading()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLoading_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLoading_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.IsPipeLineRunning() || base.IsLoadingCustomAssets();
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x00328338 File Offset: 0x00326538
		private void CreateClientBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateClientBattle_hotfix != null)
			{
				this.m_CreateClientBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle == null)
			{
				this.m_clientBattle = new ClientBattle();
				this.m_clientBattle.Initialize(this, this.MainLayer.LayerPrefabRoot);
				CommonUIController.Instance.TestUI.InitializeBattle(this.m_clientBattle);
			}
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x003283DC File Offset: 0x003265DC
		private void DestroyClientBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyClientBattle_hotfix != null)
			{
				this.m_DestroyClientBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle != null)
			{
				this.m_clientBattle.Dispose();
				this.m_clientBattle = null;
				CommonUIController.Instance.TestUI.UninitializeBattle();
			}
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x00328468 File Offset: 0x00326668
		private void PrepareClientBattle(bool prepareBattleUI = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareClientBattleBoolean_hotfix != null)
			{
				this.m_PrepareClientBattleBoolean_hotfix.call(new object[]
				{
					this,
					prepareBattleUI
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("BattleUITask.PrepareClientBattle");
			this.m_clientBattle.Clear();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			int myPlayerIndex = this.GetMyPlayerIndex();
			if (currentBattle.BattleInfo != null)
			{
				this.m_clientBattle.CreateMap(currentBattle.BattleInfo, currentBattle.BattleType, myPlayerIndex);
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				int myPlayerTeam = 0;
				if (this.IsMeArenaBattleTeam1())
				{
					myPlayerTeam = 1;
				}
				this.m_clientBattle.CreateArenaMap(currentBattle.ArenaBattleInfo, myPlayerTeam);
			}
			else if (currentBattle.PVPBattleInfo != null)
			{
				this.m_clientBattle.CreatePVPMap(currentBattle.PVPBattleInfo, myPlayerIndex);
			}
			else if (currentBattle.RealTimePVPBattleInfo != null)
			{
				this.m_clientBattle.CreateRealTimePVPMap(currentBattle.RealTimePVPBattleInfo, myPlayerIndex);
			}
			if (this.IsBattlePrepareDisableCameraMove())
			{
				this.m_clientBattle.BattleCamera.SetOrthographicSize((float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPBattleCameraSize) * 0.01f);
				this.m_clientBattle.BattleCamera.EnableTouchMove(false);
			}
			if (prepareBattleUI)
			{
				this.PrepareBattleUI();
			}
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x003285F4 File Offset: 0x003267F4
		private void StartClientBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClientBattle_hotfix != null)
			{
				this.m_StartClientBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_battlePerformState == BattlePerformState.InBattle)
			{
				projectLPlayerContext.SetBattleBase(this.m_clientBattle.Battle);
			}
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			BattleRoom battleRoom = this.GetBattleRoom();
			global::Debug.Log("BattleUITask.StartClientBattle");
			global::Debug.Log(string.Format("BattleType:{0}, BattlePerformState:{1}", currentBattle.BattleType, this.m_battlePerformState));
			if (this.m_battlePerformState == BattlePerformState.InBattle)
			{
				global::Debug.Log(string.Format("RandomSeed:{0}, ArmyRandomSeed:{1}, ArenaRandomSeed:{2}", projectLPlayerContext.GetBattleRandomSeed(), projectLPlayerContext.GetBattleArmyRandomSeed(), projectLPlayerContext.GetArenaBattleRandomSeed()));
			}
			this.m_battlePrepareUIController.ClearHeros();
			this.m_battlePrepareUIController.ClearStageActors();
			this.m_battlePrepareUIController.ClearBattleTreasures();
			this.m_clientBattle.Battle.EnableLogBattleCommands(true);
			this.m_clientBattle.Battle.EnableChecksum(true);
			if (currentBattle.BattleInfo != null)
			{
				int monsterLevel = projectLPlayerContext.Happening.MonsterLevel;
				int starTurnMax;
				int starDeadMax;
				projectLPlayerContext.Happening.GetStarCondition(out starTurnMax, out starDeadMax);
				List<ConfigDataBattleAchievementRelatedInfo> list = null;
				BattleLevelAchievement[] battleLevelAchievements = projectLPlayerContext.Happening.GetBattleLevelAchievements();
				if (battleLevelAchievements != null)
				{
					list = new List<ConfigDataBattleAchievementRelatedInfo>();
					foreach (BattleLevelAchievement battleLevelAchievement in battleLevelAchievements)
					{
						list.Add(battleLevelAchievement.m_achievementRelatedInfo);
					}
				}
				BattlePlayer[] array2;
				if (battleRoom != null)
				{
					array2 = new BattlePlayer[battleRoom.Players.Count];
					for (int j = 0; j < battleRoom.Players.Count; j++)
					{
						array2[j] = BattleUtility.CreateBattlePlayer(this.m_configDataLoader, this.GetPlayerLevel(0, j), this.GetPlayerTrainingTechs(0, j, false), this.GetPlayerSessionId(j));
					}
				}
				else
				{
					array2 = new BattlePlayer[]
					{
						BattleUtility.CreateBattlePlayer(this.m_configDataLoader, this.GetPlayerLevel(0, -1), this.GetPlayerTrainingTechs(0, -1, false), this.GetPlayerSessionId(0))
					};
				}
				this.m_clientBattle.Start(this.GetBattleTeamSetup(0), this.GetBattleTeamSetup(1), array2, projectLPlayerContext.GetBattleRandomSeed(), projectLPlayerContext.GetBattleArmyRandomSeed(), monsterLevel, starTurnMax, starDeadMax, list, projectLPlayerContext.GetGainBattleTreasrueIds());
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				BattlePlayer[] array3 = new BattlePlayer[2];
				for (int k = 0; k < 2; k++)
				{
					array3[k] = BattleUtility.CreateBattlePlayer(this.m_configDataLoader, this.GetPlayerLevel(k, -1), this.GetPlayerTrainingTechs(k, -1, false), this.GetPlayerSessionId(k));
				}
				this.m_clientBattle.StartArena(this.GetBattleTeamSetup(0), this.GetBattleTeamSetup(1), array3, projectLPlayerContext.GetArenaBattleRandomSeed(), currentBattle.ArenaDefendRuleInfo);
			}
			else if (currentBattle.PVPBattleInfo != null)
			{
				BattlePlayer[] array4 = new BattlePlayer[2];
				for (int l = 0; l < 2; l++)
				{
					array4[l] = BattleUtility.CreateBattlePlayer(this.m_configDataLoader, this.GetPlayerLevel(l, l), this.GetPlayerTrainingTechs(l, l, false), this.GetPlayerSessionId(l));
				}
				int myPlayerIndex = this.GetMyPlayerIndex();
				this.m_clientBattle.StartPVP(this.GetBattleTeamSetup(myPlayerIndex), this.GetBattleTeamSetup(1 - myPlayerIndex), array4, projectLPlayerContext.GetBattleRandomSeed());
			}
			else if (currentBattle.RealTimePVPBattleInfo != null)
			{
				BattlePlayer[] array5 = new BattlePlayer[2];
				for (int m = 0; m < 2; m++)
				{
					array5[m] = BattleUtility.CreateBattlePlayer(this.m_configDataLoader, this.GetPlayerLevel(m, m), this.GetPlayerTrainingTechs(m, m, false), this.GetPlayerSessionId(m));
				}
				int myPlayerIndex2 = this.GetMyPlayerIndex();
				this.m_clientBattle.StartRealTimePVP(this.GetBattleTeamSetup(myPlayerIndex2), this.GetBattleTeamSetup(1 - myPlayerIndex2), array5, projectLPlayerContext.GetBattleRandomSeed());
			}
			if (currentBattle.ArenaBattleInfo != null)
			{
				if (currentBattle.ArenaBattleReport == null)
				{
					this.m_clientBattle.SetEnforceActionOrderHeros(this.m_arenaAttackerHeroIds);
					LocalAccountConfig.Instance.SetArenaAttackerHeroIds(this.m_arenaAttackerHeroIds);
				}
			}
			else
			{
				this.m_clientBattle.SetEnforceActionOrderHeros(this.m_userGuideEnforceHeroIds);
			}
			if (battleRoom != null)
			{
				this.m_clientBattle.SetAutoBattle(battleRoom.GetMyPlayer().PlayerBattleStatus == PlayerBattleStatus.Auto);
			}
			else
			{
				this.m_clientBattle.SetAutoBattle(this.m_isStartBattleAutoBattle);
			}
			if (this.m_battlePerformState == BattlePerformState.InBattle)
			{
				this.m_clientBattle.SetFastBattle(LocalConfig.Instance.Data.IsFasBattle);
				this.m_clientBattle.SetSkipCombatMode((SkipCombatMode)LocalConfig.Instance.Data.SkipCombatMode);
			}
			else
			{
				this.m_clientBattle.SetFastBattle(false);
				this.m_clientBattle.SetSkipCombatMode(SkipCombatMode.None);
			}
			this.StartBattleUI();
			if (projectLPlayerContext.IsNeedRebuildBattle())
			{
				global::Debug.Log("ClientBattle.RebuildBattle");
				if (battleRoom != null)
				{
					this.m_clientBattle.RebuildBattle(battleRoom.BattleCommands, 0, int.MaxValue);
					battleRoom.BattleCommands.Clear();
				}
				else if (this.m_regretCurrentStep >= 0)
				{
					this.m_clientBattle.RebuildBattle(this.m_regretBattleCommands, 0, this.m_regretCurrentStep);
				}
				else if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
				{
					this.m_clientBattle.RebuildBattle(LocalProcessingBattle.Instance.Data);
				}
				else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
				{
					this.m_clientBattle.RebuildBattle(LocalProcessingBattle.ArenaInstance.Data);
				}
				projectLPlayerContext.SetNeedRebuildBattle(false);
			}
			else if (currentBattle.ArenaBattleReport != null)
			{
				foreach (BattleCommand cmd in currentBattle.ArenaBattleReport.Commands)
				{
					this.m_clientBattle.Battle.AddBattleCommand(cmd);
				}
				this.m_clientBattle.FirstStep();
			}
			else if (currentBattle.RealTimePVPBattleReport != null)
			{
				foreach (BattleCommand cmd2 in currentBattle.RealTimePVPBattleReport.Commands)
				{
					this.m_clientBattle.Battle.AddBattleCommand(cmd2);
				}
				this.m_clientBattle.FirstStep();
			}
			else
			{
				this.m_regretSteps.Clear();
				if (battleRoom != null)
				{
					this.SendBattleRoomInitLog();
				}
				this.m_clientBattle.FirstStep();
			}
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x00328CD4 File Offset: 0x00326ED4
		private void StopBattle(bool win, bool skipPerform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleBooleanBoolean_hotfix != null)
			{
				this.m_StopBattleBooleanBoolean_hotfix.call(new object[]
				{
					this,
					win,
					skipPerform
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("BattleUITask.StopBattle, win:" + win);
			this.SetUIStateNone();
			this.m_battleSceneUIController.StopBattle();
			this.m_battleMapUIController.StopBattle();
			this.m_preCombatUIController.Close();
			this.HideActorInfo();
			if (this.m_battlePauseUIController.IsOpened())
			{
				this.BattlePauseUIController_OnClose();
			}
			ChatUITask.PauseUITask();
			this.ResetActorEffect();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_battlePerformState == BattlePerformState.Before)
			{
				if (projectLPlayerContext.CurrentBattle.BattleInfo.m_afterPerformBattleInfo != null && !skipPerform)
				{
					projectLPlayerContext.CurrentBattle.BattleInfo = projectLPlayerContext.CurrentBattle.BattleInfo.m_afterPerformBattleInfo;
				}
				else
				{
					this.m_battlePerformState = BattlePerformState.InBattle;
					projectLPlayerContext.CurrentBattle.BattleInfo = projectLPlayerContext.Happening.BattleInfo;
				}
				CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
				{
					this.StartBattlePrepareLoadState();
				}, FadeStyle.Black, -1f, -1f);
			}
			else if (this.m_battlePerformState == BattlePerformState.InBattle)
			{
				if (Application.isEditor && this.m_clientBattle.Battle.State == BattleState.Stop)
				{
					this.CheckBattleResult();
				}
				this.m_battleReport = this.BuildBattleReport();
				this.m_battleStopTurn = this.m_clientBattle.Battle.Turn;
				bool flag = this.m_isStartBattleAutoBattle && this.m_clientBattle.IsAutoBattle;
				if (win && !flag && projectLPlayerContext.Happening.BattleInfo != null && projectLPlayerContext.Happening.BattleInfo.m_afterPerformBattleInfo != null && !skipPerform)
				{
					this.m_battlePerformState = BattlePerformState.After;
					projectLPlayerContext.CurrentBattle.BattleInfo = projectLPlayerContext.Happening.BattleInfo.m_afterPerformBattleInfo;
					CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
					{
						this.StartBattlePrepareLoadState();
					}, FadeStyle.Black, -1f, -1f);
				}
				else if (projectLPlayerContext.IsCurrentBattleFirstBattle())
				{
					this.BattleUIController_OnWinOrLoseEnd();
				}
				else if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
				{
					if (this.m_clientBattle.Battle.IsGiveupBattle())
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_ArenaAttackerGiveup, 2f, null, true);
					}
					this.ShowBattleReportEnd(projectLPlayerContext.CurrentBattle.ArenaBattleReport);
				}
				else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
				{
					if (this.m_clientBattle.Battle.IsGiveupBattle())
					{
						string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_RealTimePVPPlayerGiveup);
						string name = projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport.PlayerDatas[this.m_clientBattle.Battle.GetGiveupBattlePlayerIndex()].Name;
						CommonUIController.Instance.ShowMessage(string.Format(format, name), 2f, null, true);
					}
					this.ShowBattleReportEnd(projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport);
				}
				else
				{
					this.m_battleUIController.StopBattle(win);
					UIUtility.ActivateLayer(this.m_battleRoomUIController, false);
				}
			}
			else if (this.m_battlePerformState == BattlePerformState.After)
			{
				if (projectLPlayerContext.CurrentBattle.BattleInfo.m_afterPerformBattleInfo != null && !skipPerform)
				{
					projectLPlayerContext.CurrentBattle.BattleInfo = projectLPlayerContext.CurrentBattle.BattleInfo.m_afterPerformBattleInfo;
					CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
					{
						this.StartBattlePrepareLoadState();
					}, FadeStyle.Black, -1f, -1f);
				}
				else
				{
					this.m_battlePerformState = BattlePerformState.None;
					this.m_battleUIController.StopBattle(true);
					UIUtility.ActivateLayer(this.m_battleRoomUIController, false);
				}
			}
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x003290D8 File Offset: 0x003272D8
		private void SendBattleRoomInitLog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendBattleRoomInitLog_hotfix != null)
			{
				this.m_SendBattleRoomInitLog_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsNeedBattleReportLog)
			{
				return;
			}
			int num = 0;
			if (battleRoom.IsAnyPVPBattleRoomType())
			{
				num = this.GetMyPlayerIndex();
			}
			BattleRoomBattleLog battleRoomBattleLog = new BattleRoomBattleLog();
			battleRoomBattleLog.RoomId = battleRoom.RoomId;
			battleRoomBattleLog.BattleRoomType = (int)battleRoom.BattleRoomType;
			battleRoomBattleLog.BattleId = battleRoom.BattleId;
			battleRoomBattleLog.RandomNumberSeed = projectLPlayerContext.GetBattleRandomSeed();
			battleRoomBattleLog.ArmyRandomNumberSeed = projectLPlayerContext.GetBattleArmyRandomSeed();
			battleRoomBattleLog.Team0 = this.GetBattleTeamSetup(num).m_actors;
			battleRoomBattleLog.Team1 = this.GetBattleTeamSetup(1 - num).m_actors;
			battleRoomBattleLog.Players = new List<BattlePlayer>();
			if (this.m_clientBattle.Battle.BattlePlayers != null)
			{
				battleRoomBattleLog.Players.AddRange(this.m_clientBattle.Battle.BattlePlayers);
			}
			BattleRoomPlayer myPlayer = battleRoom.GetMyPlayer();
			string owner = string.Format("Client_{0}_{1}_{2}", myPlayer.SessionId, projectLPlayerContext.GetUserId(), projectLPlayerContext.GetPlayerName());
			string log = CommonReportLog.BattleRoomBattle(battleRoomBattleLog, owner);
			projectLPlayerContext.SendBattleRoomBattleLogReq(log);
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x00329258 File Offset: 0x00327458
		private BattleTeamSetup GetBattleTeamSetup(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleTeamSetupInt32_hotfix != null)
			{
				return (BattleTeamSetup)this.m_GetBattleTeamSetupInt32_hotfix.call(new object[]
				{
					this,
					team
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == 0)
			{
				return this.m_battleTeamSetup0;
			}
			if (team == 1)
			{
				return this.m_battleTeamSetup1;
			}
			return null;
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x003292F0 File Offset: 0x003274F0
		private List<GridPosition> GetTeamPositions(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamPositionsInt32_hotfix != null)
			{
				return (List<GridPosition>)this.m_GetTeamPositionsInt32_hotfix.call(new object[]
				{
					this,
					team
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == 0)
			{
				return this.m_teamPositions0;
			}
			if (team == 1)
			{
				return this.m_teamPositions1;
			}
			return null;
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x00329388 File Offset: 0x00327588
		private void SetCombatHp(int teamNumber)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCombatHpInt32_hotfix != null)
			{
				this.m_SetCombatHpInt32_hotfix.call(new object[]
				{
					this,
					teamNumber
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatTeam team = this.m_clientBattle.Battle.Combat.GetTeam(teamNumber);
			int num = 0;
			int heroHpMax = 0;
			int soldierHp = team.ComputeSoldierTotalHealthPoint();
			int healthPointMax = team.BattleActor.SoldierBattleProperty.HealthPointMax;
			CombatActor hero = team.GetHero();
			if (hero != null)
			{
				num = hero.HealthPoint;
				heroHpMax = hero.HealthPointMax;
				if (num <= 0)
				{
					soldierHp = 0;
				}
			}
			this.m_combatUIController.SetHealthPoint(teamNumber, num, heroHpMax, soldierHp, healthPointMax);
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x00329468 File Offset: 0x00327668
		private void ExitBattleReturnToWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExitBattleReturnToWorld_hotfix != null)
			{
				this.m_ExitBattleReturnToWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("BattleUITask.ExitBattleReturnToWorld");
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_isSendBattleCheatGMCommand)
			{
				this.m_isSendBattleCheatGMCommand = false;
				this.SendBattleCheatGMCommand(false);
			}
			if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				LocalProcessingBattle.Instance.Delete();
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				LocalProcessingBattle.ArenaInstance.Delete();
			}
			FadeStyle style = FadeStyle.Black;
			float fadeOutTime = -1f;
			float fadeInTime = -1f;
			if (!projectLPlayerContext.IsProtagonistExist())
			{
				style = FadeStyle.White;
				fadeOutTime = 0.5f;
				fadeInTime = 1.5f;
			}
			else if (projectLPlayerContext.Happening.RiftLevelInfo != null)
			{
				style = FadeStyle.White;
			}
			InviteNotifyUITask.StopUITask();
			ChatUITask.PauseUITask();
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				base.Stop();
				BattleUITask.UnloadAssetsAndStartWorldUITask();
			}, style, fadeOutTime, fadeInTime);
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x00329598 File Offset: 0x00327798
		private static void UnloadAssetsAndStartWorldUITask()
		{
			CommonUIController.Instance.StartCoroutine(BattleUITask.Co_UnloadAssetsAndStartWorldUITask());
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x003295AC File Offset: 0x003277AC
		private static IEnumerator Co_UnloadAssetsAndStartWorldUITask()
		{
			for (int i = 0; i < 3; i++)
			{
				ResourceManager.Instance.UnloadUnusedAssets();
				yield return Resources.UnloadUnusedAssets();
			}
			UIIntent intent = new UIIntent(typeof(WorldUITask).Name, null);
			UIManager instance = UIManager.Instance;
			UIIntent intent2 = intent;
			bool pushIntentToStack = true;
			bool clearIntentStack = true;
			if (BattleUITask.<>f__mg$cache0 == null)
			{
				BattleUITask.<>f__mg$cache0 = new Action(BattleUITask.WorldUITask_OnLoadAllResCompleted);
			}
			instance.StartUITask(intent2, pushIntentToStack, clearIntentStack, BattleUITask.<>f__mg$cache0);
			yield break;
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x003295C0 File Offset: 0x003277C0
		private static void WorldUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(WorldUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600B70E RID: 46862 RVA: 0x003295F4 File Offset: 0x003277F4
		private void ShowErrorMessageAndExitBattle(int errorCode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowErrorMessageAndExitBattleInt32_hotfix != null)
			{
				this.m_ShowErrorMessageAndExitBattleInt32_hotfix.call(new object[]
				{
					this,
					errorCode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
			CommonUIController.Instance.ShowErrorMessage(errorCode, 2f, delegate
			{
				this.ExitBattleReturnToWorld();
			}, true);
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x003296A0 File Offset: 0x003278A0
		private void ShowErrorMessageAndExitBattle(StringTableId strId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowErrorMessageAndExitBattleStringTableId_hotfix != null)
			{
				this.m_ShowErrorMessageAndExitBattleStringTableId_hotfix.call(new object[]
				{
					this,
					strId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
			CommonUIController.Instance.ShowMessage(strId, 2f, delegate()
			{
				this.ExitBattleReturnToWorld();
			}, true);
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x0032974C File Offset: 0x0032794C
		private void SaveProcessingBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveProcessingBattle_hotfix != null)
			{
				this.m_SaveProcessingBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_disableSaveProcessingBattle)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			LocalProcessingBattle localProcessingBattle = null;
			ProcessingBattle processingBattle = projectLPlayerContext.GetProcessingBattle();
			if (processingBattle.Type != BattleType.None)
			{
				localProcessingBattle = LocalProcessingBattle.Instance;
				localProcessingBattle.Data.Clear();
				localProcessingBattle.Data.Type = (int)processingBattle.Type;
				localProcessingBattle.Data.TypeId = processingBattle.TypeId;
				localProcessingBattle.Data.RegretCount = projectLPlayerContext.GetRemainBattleRegretCount();
				localProcessingBattle.Data.RandomSeed = projectLPlayerContext.GetBattleRandomSeed();
				localProcessingBattle.Data.ArmyRandomSeed = projectLPlayerContext.GetBattleArmyRandomSeed();
			}
			else
			{
				if (projectLPlayerContext.GetArenaBattleStatus() != ArenaBattleStatus.Fighting)
				{
					return;
				}
				localProcessingBattle = LocalProcessingBattle.ArenaInstance;
				localProcessingBattle.Data.Clear();
				localProcessingBattle.Data.Type = 5;
				localProcessingBattle.Data.TypeId = projectLPlayerContext.GetArenaBattleId();
				localProcessingBattle.Data.RandomSeed = projectLPlayerContext.GetArenaBattleRandomSeed();
			}
			localProcessingBattle.Data.Version = this.m_configDataLoader.UtilityGetVersion(VersionInfoId.VersionInfoId_BattleReport);
			localProcessingBattle.Data.Step = this.m_clientBattle.Battle.Step;
			LinkedList<BattleCommand> logBattleCommands = this.m_clientBattle.Battle.GetLogBattleCommands();
			localProcessingBattle.Data.BattleCommands = new LocalProcessingBattleData.LocalBattleCommand[logBattleCommands.Count];
			int num = 0;
			foreach (BattleCommand cmd in logBattleCommands)
			{
				LocalProcessingBattleData.LocalBattleCommand localBattleCommand = new LocalProcessingBattleData.LocalBattleCommand();
				localBattleCommand.FromBattleCommand(cmd);
				localProcessingBattle.Data.BattleCommands[num++] = localBattleCommand;
			}
			localProcessingBattle.Save();
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x00329968 File Offset: 0x00327B68
		private void BattlePrepareBeforeShowResult()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareBeforeShowResult_hotfix != null)
			{
				this.m_BattlePrepareBeforeShowResult_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BuildBattleTeamSetups();
			this.StartBattleUI();
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x003299D4 File Offset: 0x00327BD4
		private bool IsMeArenaBattleTeam1()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMeArenaBattleTeam1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMeArenaBattleTeam1_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.CurrentBattle.ArenaBattleReport != null && projectLPlayerContext.IsMe(projectLPlayerContext.CurrentBattle.ArenaBattleReport.DefenderUserId);
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x00329A80 File Offset: 0x00327C80
		private bool CanUseChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseChat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUseChat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null && battleRoom.IsRealTimePVPBattleRoomType())
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return !projectLPlayerContext.IsCurrentBattleFirstBattle() && (projectLPlayerContext.CurrentBattle.BattleInfo == null || !UserGuideUITask.IsUserGuideBattle(projectLPlayerContext.CurrentBattle.BattleInfo.ID));
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x00329B50 File Offset: 0x00327D50
		private bool CanUseDanmaku()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseDanmaku_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUseDanmaku_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isStartInBattleRoom)
			{
				return false;
			}
			if (this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_IsShowClientDanmakuIcon) == 0)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.CanUseDanmaku())
			{
				return false;
			}
			GameFunctionType gameFunctionType = GameFunctionType.GameFunctionType_None;
			int locationId = 0;
			projectLPlayerContext.Happening.GetGameFunctionTypeAndLocationId(out gameFunctionType, out locationId);
			return gameFunctionType != GameFunctionType.GameFunctionType_None && projectLPlayerContext.CanGetLevelDanmaku((int)gameFunctionType, locationId) == 0;
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x0600B715 RID: 46869 RVA: 0x00329C28 File Offset: 0x00327E28
		public ClientBattle ClientBattle
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ClientBattle_hotfix != null)
				{
					return (ClientBattle)this.m_get_ClientBattle_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_clientBattle;
			}
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x00329C9C File Offset: 0x00327E9C
		private void BattlePauseUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePauseUIController_OnClose_hotfix != null)
			{
				this.m_BattlePauseUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle.Pause(false);
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.Pause(false);
			}
			this.m_battlePauseUIController.Close();
			if (this.m_battlePerformState == BattlePerformState.InBattle)
			{
				this.m_clientBattle.SetSkipCombatMode((SkipCombatMode)LocalConfig.Instance.Data.SkipCombatMode);
				this.m_battleUIController.SetSkipCombatMode((SkipCombatMode)LocalConfig.Instance.Data.SkipCombatMode);
			}
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x00329D70 File Offset: 0x00327F70
		private void BattlePauseUIController_OnShowPlayerSetting()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePauseUIController_OnShowPlayerSetting_hotfix != null)
			{
				this.m_BattlePauseUIController_OnShowPlayerSetting_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(PlayerSettingUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x00329DFC File Offset: 0x00327FFC
		private void BattlePauseUIController_OnExit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePauseUIController_OnExit_hotfix != null)
			{
				this.m_BattlePauseUIController_OnExit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePauseUIController.Close();
			BattleRoom battleRoom = this.GetBattleRoom();
			bool flag = UIUtility.IsLayerActive(this.m_battlePrepareUIController);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null || projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_ConfirmExitBattle, new Action<DialogBoxResult>(this.ExitBattleDialogBoxCallback), (StringTableId)0, (StringTableId)0);
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_ConfirmExitArenaBattleCostTicket, new Action<DialogBoxResult>(this.ExitBattleDialogBoxCallback), (StringTableId)0, (StringTableId)0);
			}
			else if (battleRoom != null && battleRoom.IsRealTimePVPBattleRoomType())
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_ConfirmExitPVPBattleCostScore, new Action<DialogBoxResult>(this.ExitBattleDialogBoxCallback), (StringTableId)0, (StringTableId)0);
			}
			else if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null && (!flag || battleRoom != null))
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_ConfirmExitGuildMassiveCombatBattle, new Action<DialogBoxResult>(this.ExitBattleDialogBoxCallback), (StringTableId)0, (StringTableId)0);
			}
			else
			{
				int currentBattleFailEnergyCost = projectLPlayerContext.GetCurrentBattleFailEnergyCost();
				bool flag2 = currentBattleFailEnergyCost > 0 && (this.m_clientBattle.State != ClientBattleState.Prepare || (battleRoom != null && battleRoom.BattleRoomType == BattleRoomType.Team));
				if (flag2)
				{
					string msgText = string.Empty;
					if (projectLPlayerContext.Happening.TreasureLevelInfo != null)
					{
						msgText = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_ConfirmExitTreasureMapBattleCostEnergy), currentBattleFailEnergyCost);
					}
					else
					{
						msgText = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_ConfirmExitBattleCostEnergy), currentBattleFailEnergyCost);
					}
					CommonUIController.Instance.ShowDialogBox(msgText, new Action<DialogBoxResult>(this.ExitBattleDialogBoxCallback), string.Empty, null);
				}
				else
				{
					CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_ConfirmExitBattle, new Action<DialogBoxResult>(this.ExitBattleDialogBoxCallback), (StringTableId)0, (StringTableId)0);
				}
			}
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x0032A05C File Offset: 0x0032825C
		private void ExitBattleDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExitBattleDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_ExitBattleDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle.Pause(false);
			this.m_battlePrepareUIController.Pause(false);
			if (r != DialogBoxResult.Ok)
			{
				return;
			}
			global::Debug.Log("BattleUITask.ExitBattleDialogBoxCallback, result:" + r);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
			{
				this.ExitBattleReturnToWorld();
			}
			else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				this.ExitBattleReturnToWorld();
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
				if (this.m_clientBattle.State == ClientBattleState.Prepare)
				{
					this.BattlePrepareBeforeShowResult();
				}
				this.m_clientBattle.Battle.AddGiveupLogBattleCommand(0);
				this.m_clientBattle.Stop(false, true);
			}
			else if (battleRoom != null)
			{
				projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
				if (battleRoom.BattleReward == null)
				{
					this.StartBattleRoomQuitNetTask();
				}
				else
				{
					this.ExitBattleReturnToWorld();
				}
			}
			else if (this.m_clientBattle.State == ClientBattleState.Prepare)
			{
				projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
				projectLPlayerContext.ClearLevelDanmaku();
				this.ExitBattleReturnToWorld();
			}
			else if (projectLPlayerContext.Happening.Step == HappeningStep.Battle)
			{
				projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
				this.StartBattleCancelNetTask();
			}
			else
			{
				this.ExitBattleReturnToWorld();
			}
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x0032A234 File Offset: 0x00328434
		private void TestUI_ExitBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUI_ExitBattle_hotfix != null)
			{
				this.m_TestUI_ExitBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ExitBattleReturnToWorld();
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x0032A29C File Offset: 0x0032849C
		private void TestUI_RestartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUI_RestartBattle_hotfix != null)
			{
				this.m_TestUI_RestartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PrepareClientBattle(false);
			this.StartClientBattle();
		}

		// Token: 0x0600B71C RID: 46876 RVA: 0x0032A30C File Offset: 0x0032850C
		private void TestUI_ReplayBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUI_ReplayBattle_hotfix != null)
			{
				this.m_TestUI_ReplayBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleCommand> list = new List<BattleCommand>(this.m_clientBattle.Battle.GetLogBattleCommands());
			this.PrepareClientBattle(false);
			this.StartClientBattle();
			foreach (BattleCommand cmd in list)
			{
				this.m_clientBattle.Battle.AddBattleCommand(cmd);
			}
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x0032A3E4 File Offset: 0x003285E4
		private void TestUI_StopBattle(bool win)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUI_StopBattleBoolean_hotfix != null)
			{
				this.m_TestUI_StopBattleBoolean_hotfix.call(new object[]
				{
					this,
					win
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			if (this.m_clientBattle.State != ClientBattleState.Play)
			{
				return;
			}
			this.SendBattleCheatGMCommand(true);
			this.m_isSendBattleCheatGMCommand = true;
			this.m_clientBattle.Stop(win, false);
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x0032A48C File Offset: 0x0032868C
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
			if (projectLPlayerContext.IsCurrentBattleFirstBattle())
			{
				return;
			}
			if (msg.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = msg as ChatTextMessage;
				if (msg.ChannelId == ChatChannel.Sys)
				{
					NoticeUITask.StartUITask(chatTextMessage.Text, "InBattle", msg.ChannelId, false);
				}
				else if (msg.ChannelId == ChatChannel.World)
				{
					NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatTextMessage.SrcName, chatTextMessage.Text), "InBattle", msg.ChannelId, false);
				}
				else if (msg.ChannelId == ChatChannel.Guild)
				{
					if (msg.ChatSrcType == ChatSrcType.Player)
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatTextMessage.SrcName, chatTextMessage.Text), "InBattle", msg.ChannelId, false);
					}
				}
				else if (msg.ChannelId == ChatChannel.Team)
				{
					BattleRoom battleRoom = this.GetBattleRoom();
					if (battleRoom != null)
					{
						int num = battleRoom.FindPlayerIndex(msg.SrcGameUserID);
						if (num >= 0)
						{
							projectLPlayerContext.GetChatComponent().SetRecentTeamMsgRead();
							this.m_battleRoomUIController.ShowPlayerChat(num, chatTextMessage.Text);
						}
					}
				}
			}
			else if (msg.ChatContentType == ChatContentType.CustomBigExpression)
			{
				ChatTextMessage chatTextMessage2 = msg as ChatTextMessage;
				if (msg.ChannelId == ChatChannel.Team)
				{
					BattleRoom battleRoom2 = this.GetBattleRoom();
					if (battleRoom2 != null)
					{
						int num2 = battleRoom2.FindPlayerIndex(msg.SrcGameUserID);
						if (num2 >= 0)
						{
							int id = int.Parse(chatTextMessage2.Text);
							this.m_battleRoomUIController.ShowPlayerExpression(num2, id);
						}
					}
				}
			}
			else if (msg.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = msg as ChatVoiceMessage;
				if (msg.ChannelId == ChatChannel.Sys)
				{
					NoticeUITask.StartUITask(chatVoiceMessage.TranslateText, "InBattle", msg.ChannelId, true);
				}
				else if (msg.ChannelId == ChatChannel.World)
				{
					NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatVoiceMessage.SrcName, chatVoiceMessage.TranslateText), "InBattle", msg.ChannelId, true);
				}
				else if (msg.ChannelId == ChatChannel.Guild)
				{
					if (msg.ChatSrcType == ChatSrcType.Player)
					{
						NoticeUITask.StartUITask(string.Format("[{0}] {1}", chatVoiceMessage.SrcName, chatVoiceMessage.TranslateText), "InBattle", msg.ChannelId, true);
					}
				}
				else if (msg.ChannelId == ChatChannel.Team)
				{
					BattleRoom battleRoom3 = this.GetBattleRoom();
					if (battleRoom3 != null)
					{
						int num3 = battleRoom3.FindPlayerIndex(msg.SrcGameUserID);
						if (num3 >= 0)
						{
							projectLPlayerContext.GetChatComponent().SetRecentTeamMsgRead();
							this.m_battleRoomUIController.ShowPlayerVoice(num3, chatVoiceMessage);
						}
					}
				}
			}
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x0032A78C File Offset: 0x0032898C
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

		// Token: 0x0600B720 RID: 46880 RVA: 0x0032A804 File Offset: 0x00328A04
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

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x0600B721 RID: 46881 RVA: 0x0032A87C File Offset: 0x00328A7C
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

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x0600B722 RID: 46882 RVA: 0x0032A8F0 File Offset: 0x00328AF0
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

		// Token: 0x0600B723 RID: 46883 RVA: 0x0032A964 File Offset: 0x00328B64
		private void CollectBattlePrepareAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattlePrepareAssets_hotfix != null)
			{
				this.m_CollectBattlePrepareAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.ClearAlreadyCollectAssets();
			this.m_playerBattleHeros.Clear();
			foreach (Hero hero in projectLPlayerContext.GetHeros())
			{
				BattleHero item = projectLPlayerContext.CreateBattleHeroFromMyHero(hero);
				this.m_playerBattleHeros.Add(item);
			}
			List<BattleHero> playerBattleHeros = this.m_playerBattleHeros;
			if (BattleUITask.<>f__mg$cache1 == null)
			{
				BattleUITask.<>f__mg$cache1 = new Comparison<BattleHero>(BattleUITask.CompareHero);
			}
			playerBattleHeros.Sort(BattleUITask.<>f__mg$cache1);
			if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				ConfigDataBattleInfo battleInfo = projectLPlayerContext.CurrentBattle.BattleInfo;
				this.CollectBattlefieldAssets(battleInfo.m_battlefieldInfo);
				foreach (ConfigDataBattleTreasureInfo configDataBattleTreasureInfo in battleInfo.m_battleTreasureInfos)
				{
					base.CollectAsset(configDataBattleTreasureInfo.Model);
				}
				foreach (ConfigDataBattleEventTriggerInfo eventTriggerInfo in battleInfo.m_battleEventTriggerInfos)
				{
					this.CollectBattleEventAssets(eventTriggerInfo);
				}
				this.CollectBattlePerformAssets(battleInfo.m_battlePerformInfo);
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				ConfigDataArenaBattleInfo arenaBattleInfo = projectLPlayerContext.CurrentBattle.ArenaBattleInfo;
				this.CollectBattlefieldAssets(arenaBattleInfo.m_battlefieldInfo);
				foreach (ConfigDataBattleEventTriggerInfo eventTriggerInfo2 in arenaBattleInfo.m_battleEventTriggerInfos)
				{
					this.CollectBattleEventAssets(eventTriggerInfo2);
				}
			}
			else if (projectLPlayerContext.CurrentBattle.PVPBattleInfo != null)
			{
				ConfigDataPVPBattleInfo pvpbattleInfo = projectLPlayerContext.CurrentBattle.PVPBattleInfo;
				this.CollectBattlefieldAssets(pvpbattleInfo.m_battlefieldInfo);
				foreach (ConfigDataBattleEventTriggerInfo eventTriggerInfo3 in pvpbattleInfo.m_battleEventTriggerInfos)
				{
					this.CollectBattleEventAssets(eventTriggerInfo3);
				}
			}
			else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo != null)
			{
				ConfigDataRealTimePVPBattleInfo realTimePVPBattleInfo = projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo;
				this.CollectBattlefieldAssets(realTimePVPBattleInfo.m_battlefieldInfo);
				foreach (ConfigDataBattleEventTriggerInfo eventTriggerInfo4 in realTimePVPBattleInfo.m_battleEventTriggerInfos)
				{
					this.CollectBattleEventAssets(eventTriggerInfo4);
				}
			}
			List<BattleHero> list = new List<BattleHero>();
			List<BattleHero> list2 = new List<BattleHero>();
			this.CollectBattlePrepareHeros(list, list2);
			int num = 0;
			if (this.IsMeArenaBattleTeam1())
			{
				num = 1;
			}
			foreach (BattleHero hero2 in list)
			{
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero2));
				base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(hero2, num));
			}
			foreach (BattleHero hero3 in list2)
			{
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero3));
				base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(hero3, 1 - num));
			}
			BattleLevelAchievement[] battleLevelAchievements = projectLPlayerContext.Happening.GetBattleLevelAchievements();
			if (battleLevelAchievements != null)
			{
				foreach (BattleLevelAchievement battleLevelAchievement in battleLevelAchievements)
				{
					foreach (Goods goods in battleLevelAchievement.m_rewards)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			this.ClearAlreadyCollectAssets();
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x0032ADAC File Offset: 0x00328FAC
		private void CollectBattleAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattleAssets_hotfix != null)
			{
				this.m_CollectBattleAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			this.ClearAlreadyCollectAssets();
			int num = 0;
			for (int i = 0; i < 2; i++)
			{
				BattleTeamSetup battleTeamSetup = this.GetBattleTeamSetup(i);
				int num2 = i;
				if (this.IsMeArenaBattleTeam1())
				{
					num2 = 1 - num2;
				}
				foreach (BattleActorSetup battleActorSetup in battleTeamSetup.m_actors)
				{
					this.CollectCharImageAssets(battleActorSetup.HeroInfo.GetCharImageInfo(battleActorSetup.HeroStar), battleActorSetup.HeroCharImageSkinResourceInfo);
					this.CollectHeroAssets(battleActorSetup.JobConnectionInfo, battleActorSetup.HeroModelSkinResourceInfo, battleActorSetup.HeroStar);
					this.CollectSoldierAssets(battleActorSetup.SoldierInfo, battleActorSetup.SoldierModelSkinResourceInfo);
					if (battleActorSetup.SkillInfos != null)
					{
						foreach (ConfigDataSkillInfo skillInfo in battleActorSetup.SkillInfos)
						{
							this.CollectSkillAssets(skillInfo);
						}
					}
					ConfigDataSkillInfo talentSkillInfo = battleActorSetup.JobConnectionInfo.GetTalentSkillInfo(battleActorSetup.HeroStar);
					if (talentSkillInfo != null)
					{
						this.CollectSkillAssets(talentSkillInfo);
					}
					if (battleActorSetup.HeroInfo.m_hiddenSkillInfos != null)
					{
						foreach (ConfigDataSkillInfo skillInfo2 in battleActorSetup.HeroInfo.m_hiddenSkillInfos)
						{
							this.CollectSkillAssets(skillInfo2);
						}
					}
					if (battleActorSetup.JobConnectionInfo.m_jobInfo.m_jobSkillInfos != null)
					{
						foreach (ConfigDataSkillInfo configDataSkillInfo in battleActorSetup.JobConnectionInfo.m_jobInfo.m_jobSkillInfos)
						{
							this.CollectSkillAssets(talentSkillInfo);
						}
					}
					if (battleActorSetup.Equipments != null)
					{
						foreach (BattleActorEquipment battleActorEquipment in battleActorSetup.Equipments)
						{
							ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(battleActorEquipment.GetActiveSkillId());
							this.CollectSkillAssets(configDataSkillInfo2);
						}
					}
					if (battleActorSetup.ResonanceSkillInfos != null)
					{
						foreach (ConfigDataSkillInfo skillInfo3 in battleActorSetup.ResonanceSkillInfos)
						{
							this.CollectSkillAssets(skillInfo3);
						}
					}
					if (battleActorSetup.FetterSkillInfos != null)
					{
						foreach (ConfigDataSkillInfo skillInfo4 in battleActorSetup.FetterSkillInfos)
						{
							this.CollectSkillAssets(skillInfo4);
						}
					}
					if (battleActorSetup.ExtraTalentSkillInfo != null)
					{
						this.CollectSkillAssets(battleActorSetup.ExtraTalentSkillInfo);
					}
					if (battleActorSetup.ExtraPassiveSkillInfos != null)
					{
						foreach (ConfigDataSkillInfo skillInfo5 in battleActorSetup.ExtraPassiveSkillInfos)
						{
							this.CollectSkillAssets(skillInfo5);
						}
					}
				}
				if (battleRoom != null)
				{
					for (int num4 = 0; num4 < battleRoom.Players.Count; num4++)
					{
						this.CollectTrainingTechAssets(this.GetPlayerTrainingTechs(num2, num4, false));
						int playerLevel = this.GetPlayerLevel(num2, num4);
						if (playerLevel > num)
						{
							num = playerLevel;
						}
					}
				}
				else
				{
					this.CollectTrainingTechAssets(this.GetPlayerTrainingTechs(num2, -1, false));
					int playerLevel2 = this.GetPlayerLevel(num2, -1);
					if (playerLevel2 > num)
					{
						num = playerLevel2;
					}
				}
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				ConfigDataPlayerLevelInfo configDataPlayerLevelInfo = this.m_configDataLoader.GetConfigDataPlayerLevelInfo(num);
				if (configDataPlayerLevelInfo != null)
				{
					ConfigDataBuffInfo configDataBuffInfo = this.m_configDataLoader.GetConfigDataBuffInfo(configDataPlayerLevelInfo.ArenaBuffID);
					if (configDataBuffInfo != null)
					{
						this.CollectBuffAssets(configDataBuffInfo);
					}
				}
			}
			if (projectLPlayerContext.CurrentBattle.PVPBattleInfo != null || projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo != null)
			{
				ConfigDataPlayerLevelInfo configDataPlayerLevelInfo2 = this.m_configDataLoader.GetConfigDataPlayerLevelInfo(num);
				if (configDataPlayerLevelInfo2 != null)
				{
					ConfigDataBuffInfo configDataBuffInfo2 = this.m_configDataLoader.GetConfigDataBuffInfo(configDataPlayerLevelInfo2.PVPBuffID);
					if (configDataBuffInfo2 != null)
					{
						this.CollectBuffAssets(configDataBuffInfo2);
					}
				}
			}
			if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
			{
				base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait()));
				base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(projectLPlayerContext.CurrentBattle.ArenaBattleReport.OpponentHeadIcon)));
			}
			if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				foreach (RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData in projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport.PlayerDatas)
				{
					base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(realTimePVPBattleReportPlayerData.HeadIcon)));
				}
			}
			if (battleRoom != null)
			{
				foreach (BattleRoomPlayer battleRoomPlayer in battleRoom.Players)
				{
					base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(battleRoomPlayer.HeadIcon)));
				}
			}
			this.ClearAlreadyCollectAssets();
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x0032B374 File Offset: 0x00329574
		private void CollectBattlePrepareHeros(List<BattleHero> heros0, List<BattleHero> heros1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattlePrepareHerosList`1List`1_hotfix != null)
			{
				this.m_CollectBattlePrepareHerosList`1List`1_hotfix.call(new object[]
				{
					this,
					heros0,
					heros1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			ConfigDataBattleInfo battleInfo = currentBattle.BattleInfo;
			ConfigDataArenaBattleInfo arenaBattleInfo = currentBattle.ArenaBattleInfo;
			BattleRoom battleRoom = this.GetBattleRoom();
			int myStageActorCountMax = this.GetMyStageActorCountMax();
			this.m_userGuideEnforceHeroIds.Clear();
			if (currentBattle.ArenaBattleReport != null)
			{
				heros0.AddRange(currentBattle.ArenaBattleReport.AttackerHeroes);
			}
			else if (currentBattle.RealTimePVPBattleReport != null)
			{
				int myPlayerIndex = this.GetMyPlayerIndex();
				heros0.AddRange(currentBattle.RealTimePVPBattleReport.PlayerDatas[myPlayerIndex].Heroes);
				heros1.AddRange(currentBattle.RealTimePVPBattleReport.PlayerDatas[1 - myPlayerIndex].Heroes);
			}
			else if (battleRoom == null)
			{
				List<int> list = this.UserGuide_GetEnforceHeros();
				if (list != null)
				{
					this.m_userGuideEnforceHeroIds.AddRange(list);
				}
				List<int> list2 = this.SetupMyHeros(battleInfo, myStageActorCountMax, false);
				foreach (int heroId in list2)
				{
					Hero hero = projectLPlayerContext.GetHero(heroId);
					if (hero != null)
					{
						heros0.Add(BattleHero.HeroToBattleHero(hero));
					}
				}
			}
			if (battleInfo != null)
			{
				List<RandomArmyActor> list3 = null;
				if (battleInfo.BattleRandomEnemies_ID.Count > 0)
				{
					this.m_armyRandomNumber.SetSeed(projectLPlayerContext.GetBattleArmyRandomSeed());
					BattleUtility.GetRandomBattleArmyActors(this.m_configDataLoader, battleInfo.BattleRandomEnemies_ID, this.m_armyRandomNumber, out list3);
				}
				for (int i = 0; i < battleInfo.NpcActors.Count; i++)
				{
					BattlePosActor battlePosActor = battleInfo.NpcActors[i];
					Hero defaultHero = projectLPlayerContext.GetDefaultHero(battlePosActor.ID);
					if (defaultHero != null)
					{
						heros0.Add(BattleHero.HeroToBattleHero(defaultHero));
					}
				}
				for (int j = 0; j < battleInfo.EnemyActors.Count; j++)
				{
					BattlePosActor battlePosActor2 = battleInfo.EnemyActors[j];
					int heroId2 = battlePosActor2.ID;
					if (list3 != null && j < list3.Count && list3[j] != null)
					{
						heroId2 = list3[j].HeroID;
					}
					Hero defaultHero2 = projectLPlayerContext.GetDefaultHero(heroId2);
					if (defaultHero2 != null)
					{
						heros1.Add(BattleHero.HeroToBattleHero(defaultHero2));
					}
				}
			}
			else if (arenaBattleInfo != null)
			{
				int num = 0;
				foreach (BattleHero item in currentBattle.ArenaDefenderHeros)
				{
					if (num >= arenaBattleInfo.DefendNumber)
					{
						break;
					}
					heros1.Add(item);
					num++;
				}
			}
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x0032B6D0 File Offset: 0x003298D0
		private void CollectBattlefieldAssets(ConfigDataBattlefieldInfo battlefieldInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix != null)
			{
				this.m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix.call(new object[]
				{
					this,
					battlefieldInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battlefieldInfo == null)
			{
				return;
			}
			base.CollectAsset(battlefieldInfo.BattleMap);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in battlefieldInfo.Terrains)
			{
				hashSet.Add(item);
			}
			foreach (int key in hashSet)
			{
				ConfigDataTerrainInfo configDataTerrainInfo = this.m_configDataLoader.GetConfigDataTerrainInfo(key);
				if (configDataTerrainInfo != null)
				{
					this.CollectTerrainAssets(configDataTerrainInfo);
				}
			}
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x0032B808 File Offset: 0x00329A08
		private void CollectTerrainAssets(ConfigDataTerrainInfo terrainInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectTerrainAssetsConfigDataTerrainInfo_hotfix != null)
			{
				this.m_CollectTerrainAssetsConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					terrainInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (terrainInfo == null)
			{
				return;
			}
			base.CollectAsset(terrainInfo.Background);
			base.CollectAsset(UIUtility.GetSepAlphaTextureName(terrainInfo.Background));
			base.CollectAsset(terrainInfo.Fx);
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x0032B8A8 File Offset: 0x00329AA8
		private void CollectCharImageAssets(ConfigDataCharImageInfo charImageInfo, ConfigDataCharImageSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectCharImageAssetsConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix != null)
			{
				this.m_CollectCharImageAssetsConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo,
					skinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (charImageInfo == null)
			{
				return;
			}
			if (skinResInfo != null && !string.IsNullOrEmpty(skinResInfo.SpineAssetPath))
			{
				base.CollectAsset(skinResInfo.SpineAssetPath);
			}
			else
			{
				base.CollectAsset(charImageInfo.Spine);
			}
			base.CollectSpriteAsset(charImageInfo.Image);
			this.CollectHeadImageAssets(charImageInfo);
			ConfigDataCutsceneInfo skillCutsceneInfo = charImageInfo.m_skillCutsceneInfo;
			if (skillCutsceneInfo != null)
			{
				base.CollectAsset(skillCutsceneInfo.Fx);
				base.CollectAsset(skillCutsceneInfo.Head);
			}
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x0032B99C File Offset: 0x00329B9C
		private void CollectHeadImageAssets(ConfigDataCharImageInfo charImageInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix != null)
			{
				this.m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (charImageInfo == null)
			{
				return;
			}
			base.CollectSpriteAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x0032BA2C File Offset: 0x00329C2C
		private void CollectHeroAssets(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo heroSkinResInfo, int heroStar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectHeroAssetsConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoInt32_hotfix != null)
			{
				this.m_CollectHeroAssetsConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoInt32_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo,
					heroSkinResInfo,
					heroStar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (jobConnectionInfo == null)
			{
				return;
			}
			if (heroSkinResInfo != null)
			{
				this.CollectSkinAssets(heroSkinResInfo);
			}
			else
			{
				base.CollectAsset(jobConnectionInfo.Model);
				base.CollectAsset(jobConnectionInfo.CombatModel);
			}
			this.CollectSkillAssets(jobConnectionInfo.m_jobInfo.m_meleeSkillInfo);
			this.CollectSkillAssets(jobConnectionInfo.m_jobInfo.m_rangeSkillInfo);
			this.CollectSkillAssets(jobConnectionInfo.GetTalentSkillInfo(heroStar));
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x0032BB1C File Offset: 0x00329D1C
		private void CollectSoldierAssets(ConfigDataSoldierInfo soldierInfo, ConfigDataModelSkinResourceInfo soldierSkinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSoldierAssetsConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_CollectSoldierAssetsConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					soldierSkinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null)
			{
				return;
			}
			if (soldierSkinResInfo != null)
			{
				this.CollectSkinAssets(soldierSkinResInfo);
			}
			else
			{
				base.CollectAsset(soldierInfo.Model);
				base.CollectAsset(soldierInfo.CombatModel);
				base.CollectAsset(soldierInfo.Model2);
				base.CollectAsset(soldierInfo.CombatModel2);
			}
			this.CollectSkillAssets(soldierInfo.m_meleeSkillInfo);
			this.CollectSkillAssets(soldierInfo.m_rangeSkillInfo);
			foreach (ConfigDataSkillInfo skillInfo in soldierInfo.m_skillInfos)
			{
				this.CollectSkillAssets(skillInfo);
			}
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x0032BC24 File Offset: 0x00329E24
		private void CollectSkinAssets(ConfigDataModelSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSkinAssetsConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_CollectSkinAssetsConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					skinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skinResInfo == null)
			{
				return;
			}
			base.CollectAsset(skinResInfo.Model);
			base.CollectAsset(skinResInfo.CombatModel);
			this.CollectSkillAssets(skinResInfo.m_meleeSkillInfo);
			this.CollectSkillAssets(skinResInfo.m_rangeSkillInfo);
			this.CollectSkillAssets(skinResInfo.m_skinSkillInfo);
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x0032BCD8 File Offset: 0x00329ED8
		private void CollectSkillAssets(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSkillAssetsConfigDataSkillInfo_hotfix != null)
			{
				this.m_CollectSkillAssetsConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			if (this.IsAlreadyCollectAsset(skillInfo))
			{
				return;
			}
			base.CollectFxAsset(skillInfo.Effect_Cast1);
			base.CollectFxAsset(skillInfo.Effect_Cast1_Far);
			base.CollectFxAsset(skillInfo.Effect_Cast2);
			base.CollectFxAsset(skillInfo.Effect_Cast2_Far);
			base.CollectFxAsset(skillInfo.Effect_Magic1);
			base.CollectFxAsset(skillInfo.Effect_Magic1_Far);
			base.CollectFxAsset(skillInfo.Effect_Magic2);
			base.CollectFxAsset(skillInfo.Effect_Magic2_Far);
			base.CollectFxAsset(skillInfo.Effect_Sing);
			base.CollectFxAsset(skillInfo.Effect_Hit);
			base.CollectFxAsset(skillInfo.Effect_PreCast);
			if (skillInfo.m_buffInfos != null)
			{
				foreach (ConfigDataBuffInfo buffInfo in skillInfo.m_buffInfos)
				{
					this.CollectBuffAssets(buffInfo);
				}
			}
			if (skillInfo.m_passiveBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo buffInfo2 in skillInfo.m_passiveBuffInfos)
				{
					this.CollectBuffAssets(buffInfo2);
				}
			}
			if (skillInfo.m_selfBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo buffInfo3 in skillInfo.m_selfBuffInfos)
				{
					this.CollectBuffAssets(buffInfo3);
				}
			}
			if (skillInfo.SkillType == SkillType.SkillType_Shoot)
			{
				ConfigDataFlyObjectInfo configDataFlyObjectInfo = this.m_configDataLoader.GetConfigDataFlyObjectInfo(skillInfo.SkillTypeParam1);
				if (configDataFlyObjectInfo != null)
				{
					base.CollectAsset(configDataFlyObjectInfo.Model);
				}
			}
			else if (skillInfo.SkillType == SkillType.SkillType_BF_Summon)
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(skillInfo.SkillTypeParam1);
				if (configDataHeroInfo != null)
				{
					this.CollectDefaultHeroAssets(configDataHeroInfo);
				}
			}
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x0032BEEC File Offset: 0x0032A0EC
		private void CollectBuffAssets(ConfigDataBuffInfo buffInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffAssetsConfigDataBuffInfo_hotfix != null)
			{
				this.m_CollectBuffAssetsConfigDataBuffInfo_hotfix.call(new object[]
				{
					this,
					buffInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffInfo == null)
			{
				return;
			}
			if (this.IsAlreadyCollectAsset(buffInfo))
			{
				return;
			}
			base.CollectFxAsset(buffInfo.Effect_Attach);
			base.CollectFxAsset(buffInfo.Effect_Process);
			base.CollectFxAsset(buffInfo.Effect_Acting);
			base.CollectFxAsset(buffInfo.Effect_ActingTarget);
			if (buffInfo.BuffType == BuffType.BuffType_AddBuff || buffInfo.BuffType == BuffType.BuffType_AddBuffSuper)
			{
				foreach (int key in buffInfo.BuffTypeParam4)
				{
					ConfigDataBuffInfo configDataBuffInfo = this.m_configDataLoader.GetConfigDataBuffInfo(key);
					this.CollectBuffAssets(configDataBuffInfo);
				}
			}
			else if (buffInfo.BuffType == BuffType.BuffType_RemoveDebuff || buffInfo.BuffType == BuffType.BuffType_Removebuff)
			{
				foreach (int key2 in buffInfo.BuffTypeParam4)
				{
					ConfigDataBuffInfo configDataBuffInfo2 = this.m_configDataLoader.GetConfigDataBuffInfo(key2);
					this.CollectBuffAssets(configDataBuffInfo2);
				}
			}
			else if (buffInfo.BuffType == BuffType.BuffType_Punch || buffInfo.BuffType == BuffType.BuffType_Drag)
			{
				ConfigDataBuffInfo configDataBuffInfo3 = this.m_configDataLoader.GetConfigDataBuffInfo(buffInfo.BuffTypeParam3);
				this.CollectBuffAssets(configDataBuffInfo3);
			}
			else if (buffInfo.BuffType == BuffType.BuffType_CombatAttachBuff || buffInfo.BuffType == BuffType.BuffType_DamageAttachBuff)
			{
				foreach (int key3 in buffInfo.BuffTypeParam6)
				{
					ConfigDataBuffInfo configDataBuffInfo4 = this.m_configDataLoader.GetConfigDataBuffInfo(key3);
					this.CollectBuffAssets(configDataBuffInfo4);
				}
			}
			else if (buffInfo.BuffType == BuffType.BuffType_BFSkill)
			{
				foreach (int key4 in buffInfo.BuffTypeParam4)
				{
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(key4);
					this.CollectSkillAssets(configDataSkillInfo);
				}
			}
			else if (buffInfo.BuffType == BuffType.BuffType_BFSkillAttachBuff)
			{
				foreach (int key5 in buffInfo.BuffTypeParam4)
				{
					ConfigDataBuffInfo configDataBuffInfo5 = this.m_configDataLoader.GetConfigDataBuffInfo(key5);
					this.CollectBuffAssets(configDataBuffInfo5);
				}
			}
			else if (buffInfo.IsAuraBuff())
			{
				foreach (int key6 in buffInfo.BuffTypeParam6)
				{
					ConfigDataBuffInfo configDataBuffInfo6 = this.m_configDataLoader.GetConfigDataBuffInfo(key6);
					this.CollectBuffAssets(configDataBuffInfo6);
				}
			}
			else if (buffInfo.BuffType == BuffType.BuffType_BuffPack)
			{
				foreach (int key7 in buffInfo.BuffTypeParam4)
				{
					ConfigDataBuffInfo configDataBuffInfo7 = this.m_configDataLoader.GetConfigDataBuffInfo(key7);
					this.CollectBuffAssets(configDataBuffInfo7);
				}
			}
			if (buffInfo.CDBuff_ID != 0)
			{
				ConfigDataBuffInfo configDataBuffInfo8 = this.m_configDataLoader.GetConfigDataBuffInfo(buffInfo.CDBuff_ID);
				this.CollectBuffAssets(configDataBuffInfo8);
			}
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x0032C324 File Offset: 0x0032A524
		private void CollectDefaultHeroAssets(ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectDefaultHeroAssetsConfigDataHeroInfo_hotfix != null)
			{
				this.m_CollectDefaultHeroAssetsConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					heroInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroInfo == null)
			{
				return;
			}
			if (this.IsAlreadyCollectAsset(heroInfo))
			{
				return;
			}
			this.CollectCharImageAssets(heroInfo.GetCharImageInfo(heroInfo.GetRank(heroInfo.Star)), null);
			this.CollectHeroAssets(heroInfo.m_jobConnectionInfo, null, heroInfo.Star);
			this.CollectSoldierAssets(heroInfo.m_soldierInfo, null);
			foreach (ConfigDataSkillInfo skillInfo in heroInfo.m_skillInfos)
			{
				this.CollectSkillAssets(skillInfo);
			}
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x0032C408 File Offset: 0x0032A608
		private void CollectBattleEventAssets(ConfigDataBattleEventTriggerInfo eventTriggerInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattleEventAssetsConfigDataBattleEventTriggerInfo_hotfix != null)
			{
				this.m_CollectBattleEventAssetsConfigDataBattleEventTriggerInfo_hotfix.call(new object[]
				{
					this,
					eventTriggerInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ConfigDataBattleEventActionInfo eventActionInfo in eventTriggerInfo.m_battleEventActionInfos)
			{
				this.CollectBattleEventActionAssets(eventActionInfo);
			}
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x0032C4A0 File Offset: 0x0032A6A0
		private void CollectBattleEventActionAssets(ConfigDataBattleEventActionInfo eventActionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattleEventActionAssetsConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_CollectBattleEventActionAssetsConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					eventActionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventActionInfo == null)
			{
				return;
			}
			if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_Perform)
			{
				ConfigDataBattlePerformInfo configDataBattlePerformInfo = this.m_configDataLoader.GetConfigDataBattlePerformInfo(eventActionInfo.Param1FirstValue());
				if (configDataBattlePerformInfo != null)
				{
					this.CollectBattlePerformAssets(configDataBattlePerformInfo);
				}
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_Relief)
			{
				foreach (int key in eventActionInfo.Param2)
				{
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(key);
					if (configDataHeroInfo != null)
					{
						this.CollectDefaultHeroAssets(configDataHeroInfo);
					}
				}
				foreach (int key2 in eventActionInfo.ReliefRandomArmies_ID)
				{
					ConfigDataBattleRandomArmyInfo configDataBattleRandomArmyInfo = this.m_configDataLoader.GetConfigDataBattleRandomArmyInfo(key2);
					if (configDataBattleRandomArmyInfo != null)
					{
						foreach (RandomArmyActor randomArmyActor in configDataBattleRandomArmyInfo.RandomArmyActors)
						{
							ConfigDataHeroInfo configDataHeroInfo2 = this.m_configDataLoader.GetConfigDataHeroInfo(randomArmyActor.HeroID);
							if (configDataHeroInfo2 != null)
							{
								this.CollectDefaultHeroAssets(configDataHeroInfo2);
							}
						}
					}
				}
				base.CollectAsset(eventActionInfo.Param5);
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_ChangeTeam)
			{
				foreach (int key3 in eventActionInfo.Param1)
				{
					ConfigDataHeroInfo configDataHeroInfo3 = this.m_configDataLoader.GetConfigDataHeroInfo(key3);
					if (configDataHeroInfo3 != null)
					{
						this.CollectDefaultHeroAssets(configDataHeroInfo3);
					}
				}
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_Retreat)
			{
				base.CollectAsset(eventActionInfo.Param5);
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_RetreatPosition)
			{
				base.CollectAsset(eventActionInfo.Param5);
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_AttachBuff)
			{
				foreach (int key4 in eventActionInfo.Param2)
				{
					ConfigDataBuffInfo configDataBuffInfo = this.m_configDataLoader.GetConfigDataBuffInfo(key4);
					if (configDataBuffInfo != null)
					{
						this.CollectBuffAssets(configDataBuffInfo);
					}
				}
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_ChangeTerrain)
			{
				ConfigDataTerrainInfo configDataTerrainInfo = this.m_configDataLoader.GetConfigDataTerrainInfo(eventActionInfo.Param1FirstValue());
				if (configDataTerrainInfo != null)
				{
					this.CollectTerrainAssets(configDataTerrainInfo);
				}
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_Replace)
			{
				int key5 = eventActionInfo.Param2FirstValue();
				ConfigDataHeroInfo configDataHeroInfo4 = this.m_configDataLoader.GetConfigDataHeroInfo(key5);
				if (configDataHeroInfo4 != null)
				{
					this.CollectDefaultHeroAssets(configDataHeroInfo4);
				}
				base.CollectAsset(eventActionInfo.Param5);
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_RemoveBuff)
			{
				base.CollectAsset(eventActionInfo.Param5);
			}
			else if (eventActionInfo.ActionType == BattleEventActionType.BattleEventActionType_AttachBuffPosition)
			{
				foreach (int key6 in eventActionInfo.Param2)
				{
					ConfigDataBuffInfo configDataBuffInfo2 = this.m_configDataLoader.GetConfigDataBuffInfo(key6);
					if (configDataBuffInfo2 != null)
					{
						this.CollectBuffAssets(configDataBuffInfo2);
					}
				}
			}
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x0032C8BC File Offset: 0x0032AABC
		private void CollectBattlePerformAssets(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo == null)
			{
				return;
			}
			while (performInfo != null)
			{
				this._CollectBattlePerformAssets(performInfo);
				performInfo = performInfo.m_nextPerformInfo;
			}
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x0032C950 File Offset: 0x0032AB50
		private void _CollectBattlePerformAssets(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m__CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo == null)
			{
				return;
			}
			if (performInfo.PerformType == BattlePerformType.BattlePerformType_PlayFx || performInfo.PerformType == BattlePerformType.BattlePerformType_PlayActorFx || performInfo.PerformType == BattlePerformType.BattlePerformType_CreateActor || performInfo.PerformType == BattlePerformType.BattlePerformType_CreateActorNear || performInfo.PerformType == BattlePerformType.BattlePerformType_RemoveActor)
			{
				base.CollectAsset(performInfo.Param5);
			}
			if (performInfo.PerformType == BattlePerformType.BattlePerformType_CreateActor || performInfo.PerformType == BattlePerformType.BattlePerformType_CreateActorNear)
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(performInfo.Param2);
				if (configDataHeroInfo != null)
				{
					this.CollectDefaultHeroAssets(configDataHeroInfo);
				}
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ChangeTerrain)
			{
				ConfigDataTerrainInfo configDataTerrainInfo = this.m_configDataLoader.GetConfigDataTerrainInfo(performInfo.Param1);
				if (configDataTerrainInfo != null)
				{
					this.CollectTerrainAssets(configDataTerrainInfo);
				}
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorSkill && performInfo.Param4.Count > 0)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(performInfo.Param4[0]);
				if (configDataSkillInfo != null)
				{
					this.CollectSkillAssets(configDataSkillInfo);
				}
			}
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x0032CAC4 File Offset: 0x0032ACC4
		private void CollectTrainingTechAssets(List<TrainingTech> techs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectTrainingTechAssetsList`1_hotfix != null)
			{
				this.m_CollectTrainingTechAssetsList`1_hotfix.call(new object[]
				{
					this,
					techs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (techs == null)
			{
				return;
			}
			foreach (TrainingTech trainingTech in techs)
			{
				if (trainingTech.Config != null)
				{
					foreach (TrainingTechInfo trainingTechInfo in trainingTech.Infos)
					{
						ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(trainingTechInfo.SoldierSkillID);
						if (configDataSkillInfo != null)
						{
							this.CollectSkillAssets(configDataSkillInfo);
						}
					}
				}
			}
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x0032CBF4 File Offset: 0x0032ADF4
		private bool IsAlreadyCollectAsset(object obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAlreadyCollectAssetObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAlreadyCollectAssetObject_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_collectAssetObjects.Contains(obj))
			{
				return true;
			}
			this.m_collectAssetObjects.Add(obj);
			return false;
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x0032CC90 File Offset: 0x0032AE90
		private void ClearAlreadyCollectAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAlreadyCollectAssets_hotfix != null)
			{
				this.m_ClearAlreadyCollectAssets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_collectAssetObjects.Clear();
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x0032CCFC File Offset: 0x0032AEFC
		private void StartBattleUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleUI_hotfix != null)
			{
				this.m_StartBattleUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("BattleUITask.StartBattleUI");
			UIUtility.ActivateLayer(this.m_battlePrepareUIController, false);
			UIUtility.ActivateLayer(this.m_pvpBattlePrepareUIController, false);
			UIUtility.ActivateLayer(this.m_battlePrepareActorInfoUIController, false);
			UIUtility.ActivateLayer(this.m_battleUIController, true);
			UIUtility.ActivateLayer(this.m_battleTreasureDialogUIController, false);
			UIUtility.ActivateLayer(this.m_preCombatUIController, false);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			BattleRoom battleRoom = this.GetBattleRoom();
			this.m_showDangerRegionTeam = -1;
			this.m_showDangerRegionActorIds.Clear();
			if (this.m_battlePauseUIController.IsOpened())
			{
				this.BattlePauseUIController_OnClose();
			}
			this.m_battleActorInfoUIController.Close();
			this.SetUIStateNone();
			this.m_battleUIController.StartBattle();
			this.m_battleUIController.SetActionOrderType(this.m_clientBattle.Battle.ActionOrderType);
			this.m_battleUIController.SetFastBattle(this.m_clientBattle.IsFastBattle);
			this.m_battleUIController.SetSkipCombatMode(this.m_clientBattle.SkipCombatMode);
			if (battleRoom != null)
			{
				this.m_battleRoomUIController.StartBattle();
			}
			this.m_battleUIController.ShowChatButton(this.CanUseChat());
			this.m_battleUIController.ShowDanmakuToggle(this.CanUseDanmaku());
			if (currentBattle.ArenaBattleReport != null || currentBattle.RealTimePVPBattleReport != null)
			{
				this.m_battleUIController.SetAutoBattle(false);
				this.m_battleUIController.HideAutoBattleButton();
				this.m_combatUIController.SetAutoBattle(false);
				this.m_battleUIController.SetArenaAutoBattle(false);
				this.m_combatUIController.SetArenaAutoBattle(false);
			}
			else if (currentBattle.ArenaBattleInfo != null && projectLPlayerContext.IsArenaAutoBattle())
			{
				this.m_battleUIController.SetAutoBattle(false);
				this.m_battleUIController.HideAutoBattleButton();
				this.m_combatUIController.SetAutoBattle(false);
				this.m_battleUIController.SetArenaAutoBattle(true);
				this.m_combatUIController.SetArenaAutoBattle(true);
			}
			else
			{
				this.m_battleUIController.SetAutoBattle(this.m_clientBattle.IsAutoBattle);
				this.m_combatUIController.SetAutoBattle(this.m_clientBattle.IsAutoBattle);
				this.m_battleUIController.SetArenaAutoBattle(false);
				this.m_combatUIController.SetArenaAutoBattle(false);
			}
			this.m_battleUIController.SetShowDanger(false);
			if (this.m_battlePerformState == BattlePerformState.InBattle)
			{
				this.m_saveShowTopUI = (this.m_saveShowBottomUI = true);
				this.m_battleUIController.ShowTopUI(true);
				this.m_battleUIController.ShowBottomUI(true);
			}
			else
			{
				this.m_saveShowTopUI = (this.m_saveShowBottomUI = false);
				this.m_battleUIController.ShowTopUI(false);
				this.m_battleUIController.ShowBottomUI(false);
			}
			this.m_battleSceneUIController.StartBattle();
			this.m_battleMapUIController.StartBattle();
			this.m_activeActor = null;
			this.m_skillIndex = -1;
			this.m_isBattleCutsceneFade = false;
			this.m_isCombatCutsceneFade = false;
			this.m_myActionTimeout = DateTime.MinValue;
			this.m_otherActionTimeout = DateTime.MinValue;
			this.m_isMyActionTimeoutActive = false;
			this.m_isActionTimeoutAutoBattle = false;
			this.m_isAutoBattleOnce = false;
			if (!this.IsRegretActive())
			{
				if (currentBattle.BattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.BattleInfo.BattleMusic);
				}
				else if (currentBattle.ArenaBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.ArenaBattleInfo.BattleMusic);
				}
				else if (currentBattle.PVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.PVPBattleInfo.BattleMusic);
				}
				else if (currentBattle.RealTimePVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.RealTimePVPBattleInfo.BattleMusic);
				}
				if (battleRoom != null && battleRoom.IsRealTimePVPBattleRoomType())
				{
					CommonUIController.Instance.FadeIn(0.3f, Color.black, null);
				}
			}
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x0032D100 File Offset: 0x0032B300
		private void ClientActorTryMoveTo(ClientBattleActor ca, GridPosition p, int finalDir = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClientActorTryMoveToClientBattleActorGridPositionInt32_hotfix != null)
			{
				this.m_ClientActorTryMoveToClientBattleActorGridPositionInt32_hotfix.call(new object[]
				{
					this,
					ca,
					p,
					finalDir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null)
			{
				return;
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			if (ca.BattleActor.FindPath(ca.Position, p, 10000, 1, list, false))
			{
				int num = ca.Direction;
				for (int i = 1; i < list.Count; i++)
				{
					int num2 = list[i].x - list[i - 1].x;
					if (num2 > 0)
					{
						num = 1;
					}
					else if (num2 < 0)
					{
						num = -1;
					}
					this.m_clientBattle.BattleActorTryMove(ca.BattleActor, list[i], num);
				}
				if (finalDir != 0 && num != finalDir)
				{
					this.m_clientBattle.BattleActorTryMove(ca.BattleActor, list[list.Count - 1], finalDir);
				}
			}
			else
			{
				global::Debug.LogWarning("BattleUITask.ClientActorTryMoveTo error, Position: " + p.ToString());
			}
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x0032D298 File Offset: 0x0032B498
		private void AddCommandIfMoved(ClientBattleActor ca)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddCommandIfMovedClientBattleActor_hotfix != null)
			{
				this.m_AddCommandIfMovedClientBattleActor_hotfix.call(new object[]
				{
					this,
					ca
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null)
			{
				return;
			}
			if (ca.Position != this.m_activeActorInitPosition)
			{
				BattleCommand battleCommand = ca.BattleActor.CreateBattleCommand(BattleCommandType.Move);
				battleCommand.TargetPosition = ca.Position;
				this.m_clientBattle.IgnoreMoveStep(battleCommand.Step);
			}
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x0032D350 File Offset: 0x0032B550
		private GridPosition FindAttackPosition(int attackDistance, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindAttackPositionInt32GridPosition_hotfix != null)
			{
				return (GridPosition)this.m_FindAttackPositionInt32GridPosition_hotfix.call(new object[]
				{
					this,
					attackDistance,
					targetPos
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return GridPosition.Null;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			BattleActor battleActor = this.m_activeActor.BattleActor;
			GridPosition result = GridPosition.Null;
			int num = 10000;
			int num2 = -10000;
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_clientBattle.Battle.FindAttackRegion(targetPos, attackDistance, 0, list);
			foreach (GridPosition gridPosition in list)
			{
				if (map.GetRegion(gridPosition) == 1)
				{
					BattleActor mapBattleActor = this.GetMapBattleActor(gridPosition);
					if (mapBattleActor == null || mapBattleActor == battleActor)
					{
						int num3 = GridPosition.Distance(this.m_activeActor.Position, gridPosition);
						int num4 = GridPosition.Distance(gridPosition, targetPos);
						if (num3 < num || (num3 == num && num4 > num2))
						{
							num = num3;
							num2 = num4;
							result = gridPosition;
						}
					}
				}
			}
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
			return result;
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x0032D510 File Offset: 0x0032B710
		private bool CanAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAction_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanAction_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_activeActor != null && !this.m_activeActor.HasAct() && !this.m_clientBattle.Battle.HasBattleCommand() && !this.m_clientBattle.IsAutoBattle && !this.m_clientBattle.IsPaused && this.m_clientBattle.State == ClientBattleState.Play;
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x0032D5EC File Offset: 0x0032B7EC
		private BattleActor GetMapBattleActor(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMapBattleActorGridPosition_hotfix != null)
			{
				return (BattleActor)this.m_GetMapBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor result = this.m_clientBattle.Battle.Map.GetActor(p);
			if (this.m_activeActor != null)
			{
				if (p == this.m_activeActorInitPosition)
				{
					result = null;
				}
				if (p == this.m_activeActor.Position)
				{
					result = this.m_activeActor.BattleActor;
				}
			}
			return result;
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x0032D6C0 File Offset: 0x0032B8C0
		private void ResetActorEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetActorEffect_hotfix != null)
			{
				this.m_ResetActorEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
			{
				clientBattleActor.ClearGraphicEffect(GraphicEffect.Highlight_Red);
				bool graphicActionFinishedEffect = this.m_clientBattle.Battle.IsPlay() && !clientBattleActor.IsDead() && clientBattleActor.BattleActor.IsActionFinished() && (this.m_clientBattle.Battle.ActionOrderType != ActionOrderType.Normal || clientBattleActor.TeamNumber == this.m_clientBattle.Battle.GetActionTeam());
				clientBattleActor.SetGraphicActionFinishedEffect(graphicActionFinishedEffect);
			}
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x0032D7E0 File Offset: 0x0032B9E0
		private bool CanUseSkillAtPosition(ClientBattleActor ca, ConfigDataSkillInfo skillInfo, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseSkillAtPositionClientBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUseSkillAtPositionClientBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					ca,
					skillInfo,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null || skillInfo == null)
			{
				return false;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			if (!map.IsValidPosition(p))
			{
				return false;
			}
			if (map.GetRegion(p) != 3)
			{
				return false;
			}
			BattleActor mapBattleActor = this.GetMapBattleActor(p);
			if (!ca.BattleActor.CanUseSkillOnTarget(skillInfo, mapBattleActor))
			{
				return false;
			}
			if (skillInfo.SkillType == SkillType.SkillType_BF_Summon)
			{
				MoveType summonMoveType = this.GetSummonMoveType(skillInfo.SkillTypeParam1);
				if (map.GetMovePointCost(p, summonMoveType) <= 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x0032D900 File Offset: 0x0032BB00
		private void FindMoveRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMoveRegion_hotfix != null)
			{
				this.m_FindMoveRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			BattleActor battleActor = this.m_activeActor.BattleActor;
			battleActor.FindMoveRegion(this.m_activeActorInitPosition, list);
			foreach (GridPosition p in list)
			{
				map.SetRegion(p, 1);
			}
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x0032DA0C File Offset: 0x0032BC0C
		private void ShowMoveAndAttackRegion(BattleActor actor, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMoveAndAttackRegionBattleActorGridPosition_hotfix != null)
			{
				this.m_ShowMoveAndAttackRegionBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			List<GridPosition> list2 = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			actor.FindMoveRegion(startPos, list);
			foreach (GridPosition p in list)
			{
				map.SetRegion(p, 1);
			}
			foreach (GridPosition gridPosition in list)
			{
				BattleActor mapBattleActor = this.GetMapBattleActor(gridPosition);
				if (mapBattleActor == null || mapBattleActor == actor)
				{
					list2.Clear();
					this.m_clientBattle.Battle.FindAttackRegion(gridPosition, actor.GetMaxAttackDistance(), 0, list2);
					foreach (GridPosition p2 in list2)
					{
						if (map.GetRegion(p2) == 0)
						{
							map.SetRegion(p2, 2);
						}
					}
				}
			}
			this.m_battleMapUIController.ShowRegion(startPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list2);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x0032DC2C File Offset: 0x0032BE2C
		private void ShowMoveAndAttackRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMoveAndAttackRegion_hotfix != null)
			{
				this.m_ShowMoveAndAttackRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowMoveAndAttackRegion(this.m_activeActor.BattleActor, this.m_activeActorInitPosition);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x0032DCB0 File Offset: 0x0032BEB0
		private void ShowMoveRegion(BattleActor actor, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMoveRegionBattleActorGridPosition_hotfix != null)
			{
				this.m_ShowMoveRegionBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			actor.FindMoveRegion(startPos, list);
			foreach (GridPosition p in list)
			{
				map.SetRegion(p, 1);
			}
			this.m_battleMapUIController.ShowRegion(startPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x0032DDD0 File Offset: 0x0032BFD0
		private void ShowMoveRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMoveRegion_hotfix != null)
			{
				this.m_ShowMoveRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowMoveRegion(this.m_activeActor.BattleActor, this.m_activeActorInitPosition);
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x0032DE54 File Offset: 0x0032C054
		private void UpdateDangerRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDangerRegion_hotfix != null)
			{
				this.m_UpdateDangerRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_showDangerRegionActorIds.Count > 0)
			{
				this.ShowDangerRegion(this.m_showDangerRegionActorIds);
			}
			else if (this.m_showDangerRegionTeam >= 0)
			{
				this.ShowDangerTeamRegion(this.m_showDangerRegionTeam);
			}
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x0032DEF0 File Offset: 0x0032C0F0
		private void ShowDangerTeamRegion(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDangerTeamRegionInt32_hotfix != null)
			{
				this.m_ShowDangerTeamRegionInt32_hotfix.call(new object[]
				{
					this,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tempIntList.Clear();
			foreach (BattleActor battleActor in this.m_clientBattle.Battle.GetTeam(team).GetActors())
			{
				if (!battleActor.IsDeadOrRetreat())
				{
					this.m_tempIntList.Add(battleActor.Id);
				}
			}
			this.ShowDangerRegion(this.m_tempIntList);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x0032DFF0 File Offset: 0x0032C1F0
		private void ShowDangerRegion(List<int> actorIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDangerRegionList`1_hotfix != null)
			{
				this.m_ShowDangerRegionList`1_hotfix.call(new object[]
				{
					this,
					actorIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actorIds.Count <= 0)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			BattleActor actor = null;
			if (this.m_activeActor != null && this.m_activeActor.Position != this.m_activeActorInitPosition)
			{
				actor = map.GetActor(this.m_activeActor.Position);
				map.SetActor(this.m_activeActorInitPosition, null);
				map.SetActor(this.m_activeActor.Position, this.m_activeActor.BattleActor);
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			List<GridPosition> list2 = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_dangerRegion.Clear();
			foreach (int id in actorIds)
			{
				BattleActor actorById = this.m_clientBattle.Battle.GetActorById(id);
				if (actorById != null)
				{
					if (!actorById.IsDeadOrRetreat())
					{
						list.Clear();
						actorById.FindMoveRegion(actorById.Position, list);
						foreach (GridPosition gridPosition in list)
						{
							BattleActor mapBattleActor = this.GetMapBattleActor(gridPosition);
							if (mapBattleActor == null || mapBattleActor == actorById)
							{
								list2.Clear();
								this.m_clientBattle.Battle.FindAttackRegion(gridPosition, actorById.GetMaxAttackDistance(), 0, list2);
								foreach (GridPosition item in list2)
								{
									this.m_dangerRegion.Add(item);
								}
							}
						}
					}
				}
			}
			if (this.m_activeActor != null && this.m_activeActor.Position != this.m_activeActorInitPosition)
			{
				map.SetActor(this.m_activeActorInitPosition, this.m_activeActor.BattleActor);
				map.SetActor(this.m_activeActor.Position, actor);
			}
			this.m_battleMapUIController.ShowDangerRegion(this.m_dangerRegion);
			this.m_dangerRegion.Clear();
			this.m_clientBattle.Battle.FreeTempGridPositionList(list2);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x0032E31C File Offset: 0x0032C51C
		private void ShowMovePath(ClientBattleActor ca, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMovePathClientBattleActorGridPosition_hotfix != null)
			{
				this.m_ShowMovePathClientBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					ca,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null)
			{
				return;
			}
			this.m_battleMapUIController.HideMovePath();
			if (ca.Position == startPos)
			{
				return;
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			BattleActor battleActor = ca.BattleActor;
			if (battleActor.FindPath(startPos, ca.Position, battleActor.GetMovePoint(), 1, list, false))
			{
				this.m_battleMapUIController.ShowMovePath(list);
			}
			else
			{
				global::Debug.LogWarning("BattleUITask.ShowMovePath error, wrong position " + ca.Position.ToString());
			}
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x0032E438 File Offset: 0x0032C638
		private MoveType GetSummonMoveType(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSummonMoveTypeInt32_hotfix != null)
			{
				return (MoveType)this.m_GetSummonMoveTypeInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			return BattleActor.ComputeDefaultMoveType(configDataHeroInfo);
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x0032E4C8 File Offset: 0x0032C6C8
		private void ShowSkillRegion(BattleActor actor, int skillIndex, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillRegionBattleActorInt32GridPosition_hotfix != null)
			{
				this.m_ShowSkillRegionBattleActorInt32GridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					skillIndex,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			BattleSkillState skillState = actor.GetSkillState(skillIndex);
			if (skillState == null)
			{
				return;
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_clientBattle.Battle.FindAttackRegion(startPos, actor.GetSkillDistance(skillState.m_skillInfo), skillState.m_skillInfo.CastSkillShape, list);
			foreach (GridPosition p in list)
			{
				map.SetRegion(p, 3);
			}
			this.m_battleMapUIController.ShowRegion(startPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x0032E628 File Offset: 0x0032C828
		private void ShowSkillRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillRegion_hotfix != null)
			{
				this.m_ShowSkillRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowSkillRegion(this.m_activeActor.BattleActor, this.m_skillIndex, this.m_activeActor.Position);
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x0032E6B8 File Offset: 0x0032C8B8
		private void ShowSkillRange(BattleActor actor, int skillIndex, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillRangeBattleActorInt32GridPosition_hotfix != null)
			{
				this.m_ShowSkillRangeBattleActorInt32GridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					skillIndex,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			BattleSkillState skillState = actor.GetSkillState(skillIndex);
			if (skillState == null)
			{
				return;
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_clientBattle.Battle.FindAttackRegion(targetPos, skillState.m_skillInfo.BF_Range - 1, skillState.m_skillInfo.BF_RangeShape, list);
			foreach (GridPosition p in list)
			{
				map.SetRegion(p, 2);
			}
			this.m_battleMapUIController.ShowRegion(targetPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
			this.ResetActorEffect();
			foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
			{
				if (map.GetRegion(clientBattleActor.Position) == 2)
				{
					BattleActor battleActor = clientBattleActor.BattleActor;
					if (actor.IsBattlefiledSkillApplyTarget(skillState.m_skillInfo, battleActor))
					{
						clientBattleActor.SetGraphicEffect(GraphicEffect.Highlight_Red, 0f, 0f);
					}
				}
			}
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x0032E8B8 File Offset: 0x0032CAB8
		private void ShowSkillRange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillRange_hotfix != null)
			{
				this.m_ShowSkillRange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowSkillRange(this.m_activeActor.BattleActor, this.m_skillIndex, this.m_skillTargetPosition);
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x0032E944 File Offset: 0x0032CB44
		private void ShowTeleportRegion(BattleActor actor, int skillIndex, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTeleportRegionBattleActorInt32GridPosition_hotfix != null)
			{
				this.m_ShowTeleportRegionBattleActorInt32GridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					skillIndex,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			BattleSkillState skillState = actor.GetSkillState(skillIndex);
			if (skillState == null)
			{
				return;
			}
			BattleActor mapBattleActor = this.GetMapBattleActor(targetPos);
			if (mapBattleActor == null)
			{
				return;
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_clientBattle.Battle.FindAttackRegion(targetPos, skillState.m_skillInfo.SkillTypeParam1, 0, list);
			foreach (GridPosition p in list)
			{
				if (map.GetMovePointCost(p, mapBattleActor.GetMoveType()) > 0)
				{
					map.SetRegion(p, 4);
				}
			}
			this.m_battleMapUIController.ShowRegion(targetPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x0032EAC4 File Offset: 0x0032CCC4
		private void ShowTeleportRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTeleportRegion_hotfix != null)
			{
				this.m_ShowTeleportRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowTeleportRegion(this.m_activeActor.BattleActor, this.m_skillIndex, this.m_skillTargetPosition);
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x0032EB50 File Offset: 0x0032CD50
		private void ShowAttackTargets(BattleActor actor, GridPosition goalPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAttackTargetsBattleActorGridPosition_hotfix != null)
			{
				this.m_ShowAttackTargetsBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					goalPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			this.m_battleSceneUIController.HideTargetIcons();
			BattleMap map = this.m_clientBattle.Battle.Map;
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_tempIntList.Clear();
			foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
			{
				if (map.GetRegion(clientBattleActor.Position) == 2)
				{
					BattleActor battleActor = clientBattleActor.BattleActor;
					if (battleActor.TeamNumber != actor.TeamNumber)
					{
						if (!battleActor.IsDeadOrRetreat())
						{
							list.Add(clientBattleActor.Position);
							bool isMagic = this.m_clientBattle.IsCombatMagicAttack(actor, battleActor, null);
							this.m_tempIntList.Add(this.m_clientBattle.ComputeCombatArmyRelationValue(actor, clientBattleActor.BattleActor, isMagic));
						}
					}
				}
			}
			this.m_battleSceneUIController.ShowTargetIcons(list, this.m_tempIntList, null, goalPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x0032ED04 File Offset: 0x0032CF04
		private void ShowSkillTargets(ClientBattleActor ca, int skillIndex, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillTargetsClientBattleActorInt32GridPosition_hotfix != null)
			{
				this.m_ShowSkillTargetsClientBattleActorInt32GridPosition_hotfix.call(new object[]
				{
					this,
					ca,
					skillIndex,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null)
			{
				return;
			}
			this.m_battleSceneUIController.HideTargetIcons();
			BattleMap map = this.m_clientBattle.Battle.Map;
			BattleSkillState skillState = ca.BattleActor.GetSkillState(skillIndex);
			if (skillState == null)
			{
				return;
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			for (int i = 0; i < map.Height; i++)
			{
				for (int j = 0; j < map.Width; j++)
				{
					GridPosition gridPosition = new GridPosition(j, i);
					if (this.CanUseSkillAtPosition(ca, skillState.m_skillInfo, gridPosition))
					{
						list.Add(gridPosition);
					}
				}
			}
			this.m_battleSceneUIController.ShowTargetIcons(list, null, skillState.m_skillInfo, startPos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B751 RID: 46929 RVA: 0x0032EE60 File Offset: 0x0032D060
		private void ShowSkillTargets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillTargets_hotfix != null)
			{
				this.m_ShowSkillTargets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowSkillTargets(this.m_activeActor, this.m_skillIndex, this.m_activeActorInitPosition);
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x0032EEE4 File Offset: 0x0032D0E4
		private void ShowBattleTreasureDialog(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_ShowBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.ActivateLayer(this.m_battleTreasureDialogUIController, true);
			this.m_battleTreasureDialogUIController.Open(null);
			this.m_battleTreasureDialogUIController.SetWords(treasureInfo.Desc);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x0032EF80 File Offset: 0x0032D180
		private void ShowBattleTreasureReward(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_ShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetRewardGoodsUITask getRewardGoodsUITask = GetRewardGoodsUITask.StartUITask(treasureInfo.Reward);
			if (this.m_getRewardGoodsUITask == null)
			{
				this.m_getRewardGoodsUITask = getRewardGoodsUITask;
				this.m_getRewardGoodsUITask.EventOnStop += this.GetRewardGoodsUITask_OnStop;
				this.m_getRewardGoodsUITask.EventOnClose += this.GetRewardGoodsUITask_OnClose;
			}
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x0032F03C File Offset: 0x0032D23C
		private void ShowPreCombat(BattleActor a0, BattleActor a1, ConfigDataSkillInfo attackerSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPreCombatBattleActorBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_ShowPreCombatBattleActorBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a0,
					a1,
					attackerSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleUIController.ShowTopUI(false);
			this.m_battleUIController.HideSkills();
			ConfigDataTerrainInfo terrain = this.m_clientBattle.Battle.Map.GetTerrain(this.m_clientBattle.GetActor(a0).Position);
			ConfigDataTerrainInfo terrain2 = this.m_clientBattle.Battle.Map.GetTerrain(this.m_clientBattle.GetActor(a1).Position);
			bool flag = this.m_clientBattle.IsCombatMagicAttack(a0, a1, attackerSkillInfo);
			bool isMagicAttack = this.m_clientBattle.IsCombatMagicAttack(a1, a0, null);
			int armyRelationValue = this.m_clientBattle.ComputeCombatArmyRelationValue(a0, a1, flag);
			this.m_preCombatUIController.SetBattleActorInfo(a0, a1, terrain, terrain2, flag, isMagicAttack, armyRelationValue, attackerSkillInfo, 0);
			this.m_preCombatUIController.Open();
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x0032F180 File Offset: 0x0032D380
		private void ShowFastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				this.m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a0,
					a1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_preCombatUIController.IsOpened())
			{
				this.m_preCombatUIController.OpenAndShowFastCombat(a0, a1);
			}
			else
			{
				this.m_preCombatUIController.ShowFastCombat(a0, a1);
			}
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x0032F230 File Offset: 0x0032D430
		private void ShowActorInfo(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowActorInfoBattleActor_hotfix != null)
			{
				this.m_ShowActorInfoBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_battleActorInfoUIController.IsOpened())
			{
				this.m_saveShowTopUI = this.m_battleUIController.IsShowTopUI();
				this.m_saveShowBottomUI = this.m_battleUIController.IsShowBottomUI();
			}
			this.m_battleUIController.ShowBottomUI(false);
			this.m_battleUIController.ShowActorSimpleInfo(false);
			this.m_battleActorInfoUIController.SetActorInfo(a, this.m_clientBattle.GetMyPlayerTeamNumber());
			this.m_battleActorInfoUIController.Open();
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x0032F30C File Offset: 0x0032D50C
		private void HideActorInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideActorInfo_hotfix != null)
			{
				this.m_HideActorInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleActorInfoUIController.IsOpened())
			{
				this.m_battleActorInfoUIController.Close();
				this.m_battleUIController.ShowBottomUI(this.m_saveShowBottomUI);
			}
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x0032F398 File Offset: 0x0032D598
		private void ShowSelectionMarkAndTerrain(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectionMarkAndTerrainGridPosition_hotfix != null)
			{
				this.m_ShowSelectionMarkAndTerrainGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleSceneUIController.ShowSelectionMark(p);
			this.m_battleUIController.ShowTerrainInfo(this.m_clientBattle.Battle.Map.GetTerrain(p));
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x0032F438 File Offset: 0x0032D638
		private void SetUIStateNone()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateNone_hotfix != null)
			{
				this.m_SetUIStateNone_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleMapUIController.HideRegion();
			this.m_battleMapUIController.HideMovePath();
			this.m_battleSceneUIController.HideSelectionMark();
			this.m_battleSceneUIController.HideTargetIcons();
			this.m_battleSceneUIController.HideCanActionIcons();
			this.m_battleSceneUIController.SetActiveActor(null);
			this.m_battleUIController.HideSkills();
			this.m_battleUIController.HideTerrainInfo();
			this.m_battleUIController.HideArmyRelationDesc();
			this.m_battleUIController.ShowUseOrCancelSkill(false);
			this.m_battleUIController.ShowEndAction(false);
			this.m_battleUIController.ShowEndAllAction(false);
			this.m_battleUIController.ShowActorSimpleInfo(false);
			this.m_battleUIController.ShowTurnStatus(false);
			this.m_battleUIController.ShowRegretButton(false);
			if (!this.IsRegretActive())
			{
				this.m_battleUIController.ShowRegretPanel(false);
			}
			this.ResetActorEffect();
			if (this.m_activeActor != null)
			{
				this.m_activeActor.StopIdleRun();
				this.m_activeActor = null;
			}
			this.m_uiState = BattleUIState.None;
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x0032F588 File Offset: 0x0032D788
		private void SetUIStateSelectActionActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateSelectActionActor_hotfix != null)
			{
				this.m_SetUIStateSelectActionActor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleMapUIController.HideRegion();
			this.m_battleMapUIController.HideMovePath();
			this.m_battleSceneUIController.HideTargetIcons();
			this.m_battleSceneUIController.SetActiveActor(null);
			this.m_battleUIController.HideSkills();
			this.m_battleUIController.ShowUseOrCancelSkill(false);
			this.m_battleUIController.ShowEndAction(false);
			this.m_battleUIController.ShowActorSimpleInfo(false);
			this.m_battleUIController.ShowArmyRelationButton();
			this.ResetActorEffect();
			if (this.m_activeActor != null)
			{
				this.m_activeActor.StopIdleRun();
				this.m_activeActor = null;
			}
			this.m_uiState = BattleUIState.SelectActionActor;
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x0032F67C File Offset: 0x0032D87C
		private void SetUIStateMove()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateMove_hotfix != null)
			{
				this.m_SetUIStateMove_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowMoveAndAttackRegion();
			this.ShowAttackTargets(this.m_activeActor.BattleActor, this.m_activeActor.Position);
			this.m_battleUIController.ShowEndAllAction(!this.m_isStartInBattleRoom);
			if (this.CanUseRegret())
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				int remainBattleRegretCount = projectLPlayerContext.GetRemainBattleRegretCount();
				int maxCount = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_BattleRegretCountMax);
				this.m_battleUIController.ShowRegretButton(true);
				this.m_battleUIController.SetRegretCount(remainBattleRegretCount, maxCount);
			}
			else
			{
				this.m_battleUIController.ShowRegretButton(false);
			}
			this.ShowSkills();
			this.m_battleSceneUIController.SetActiveActor(this.m_activeActor);
			this.m_uiState = BattleUIState.Move;
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x0032F79C File Offset: 0x0032D99C
		private void ShowSkills()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkills_hotfix != null)
			{
				this.m_ShowSkills_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isActiveSkillBanned = this.m_activeActor.BattleActor.HasFightTag(FightTag.FightTag_BanActiveSkill);
			bool isPassiveSkillBanned = this.m_activeActor.BattleActor.HasFightTag(FightTag.FightTag_BanPassiveSkill);
			this.m_battleUIController.ShowSkills(this.m_activeActor.BattleActor.GetSkillStates(), isActiveSkillBanned, isPassiveSkillBanned);
			this.m_battleUIController.ShowTopUI(true);
			this.m_battleUIController.ShowEndAction(true);
			this.m_battleUIController.ShowActorSimpleInfo(true);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x0032F864 File Offset: 0x0032DA64
		private void SetUIStateExtraMove()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateExtraMove_hotfix != null)
			{
				this.m_SetUIStateExtraMove_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowMoveRegion();
			this.m_battleUIController.ShowEndAllAction(!this.m_isStartInBattleRoom);
			this.m_battleUIController.HideSkills();
			this.m_battleUIController.ShowEndAction(true);
			this.m_battleUIController.ShowActorSimpleInfo(true);
			this.m_battleSceneUIController.SetActiveActor(this.m_activeActor);
			this.m_uiState = BattleUIState.ExtraMove;
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x0032F928 File Offset: 0x0032DB28
		private void SetUIStateSelectSkillTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateSelectSkillTarget_hotfix != null)
			{
				this.m_SetUIStateSelectSkillTarget_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			this.ShowSkillRegion();
			this.ShowSkillTargets();
			this.m_battleUIController.SetCurrentSkill(this.m_activeActor.BattleActor.GetSkillState(this.m_skillIndex));
			this.ResetActorEffect();
			this.m_uiState = BattleUIState.SelectSkillTarget;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x0032F9D0 File Offset: 0x0032DBD0
		private void SetUIStateConfirmSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateConfirmSkill_hotfix != null)
			{
				this.m_SetUIStateConfirmSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			BattleSkillState skillState = this.m_activeActor.BattleActor.GetSkillState(this.m_skillIndex);
			if (skillState == null)
			{
				return;
			}
			this.ShowSkillRange();
			this.m_battleSceneUIController.HideTargetIcons();
			if (skillState.m_skillInfo.IsBattlefieldSkill())
			{
				this.m_battleUIController.ShowUseSkill(true);
				this.m_battleUIController.ShowSkillHint(StringTableId.StringTableId_Battle_ConfirmSkill, 0f);
			}
			else
			{
				this.m_battleUIController.ShowUseOrCancelSkill(false);
				this.ShowPreCombat(this.m_activeActor.BattleActor, this.GetMapBattleActor(this.m_skillTargetPosition), skillState.m_skillInfo);
			}
			this.m_uiState = BattleUIState.ConfirmSkill;
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x0032FAD8 File Offset: 0x0032DCD8
		private void SetUIStateSelectTeleportPosition1()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateSelectTeleportPosition1_hotfix != null)
			{
				this.m_SetUIStateSelectTeleportPosition1_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleMapUIController.HideRegion();
			this.m_battleSceneUIController.HideTargetIcons();
			this.m_battleUIController.ShowUseOrCancelSkill(false);
			this.m_battleUIController.HideSkillHint();
			this.ResetActorEffect();
			this.m_uiState = BattleUIState.SelectTeleportPosition;
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x0032FB74 File Offset: 0x0032DD74
		private void SetUIStateSelectTeleportPosition2()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateSelectTeleportPosition2_hotfix != null)
			{
				this.m_SetUIStateSelectTeleportPosition2_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowTeleportRegion();
			this.m_battleMapUIController.HideMovePath();
			this.m_battleUIController.ShowSkillHint(StringTableId.StringTableId_Battle_SelectTeleport, 0f);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x0032FBFC File Offset: 0x0032DDFC
		private void SetUIStateWaitOtherPlayer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateWaitOtherPlayer_hotfix != null)
			{
				this.m_SetUIStateWaitOtherPlayer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetUIStateNone();
			this.m_uiState = BattleUIState.WaitOtherPlayer;
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x0032FC6C File Offset: 0x0032DE6C
		private void ShowCanActionActorsUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCanActionActorsUI_hotfix != null)
			{
				this.m_ShowCanActionActorsUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int myPlayerIndex = this.m_clientBattle.GetMyPlayerIndex();
			int myPlayerTeamNumber = this.m_clientBattle.GetMyPlayerTeamNumber();
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
			{
				if (clientBattleActor.TeamNumber == myPlayerTeamNumber && clientBattleActor.BattleActor.CanAction() && !clientBattleActor.BattleActor.IsAINpc() && clientBattleActor.BattleActor.PlayerIndex == myPlayerIndex)
				{
					list.Add(clientBattleActor.Position);
				}
			}
			this.m_battleSceneUIController.ShowCanActionIcons(list);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
			this.m_battleUIController.ShowTurnStatus(true);
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x0032FDB8 File Offset: 0x0032DFB8
		private void HideCanActionActorsUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideCanActionActorsUI_hotfix != null)
			{
				this.m_HideCanActionActorsUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleSceneUIController.HideCanActionIcons();
			this.m_battleUIController.ShowTurnStatus(false);
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x0032FE30 File Offset: 0x0032E030
		private void DoAutoBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoAutoBattle_hotfix != null)
			{
				this.m_DoAutoBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State != ClientBattleState.Play)
			{
				return;
			}
			if (this.m_activeActor != null)
			{
				foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
				{
					clientBattleActor.CancelTeleportDisappear();
				}
				this.ClientActorTryMoveTo(this.m_activeActor, this.m_activeActorInitPosition, this.m_activeActorInitDirection);
			}
			if (this.m_uiState != BattleUIState.None)
			{
				BattleActor actionActor = this.m_clientBattle.Battle.GetActionActor();
				if (actionActor != null)
				{
					bool flag = false;
					if (actionActor.PlayerIndex >= 0)
					{
						if (actionActor.PlayerIndex == this.m_clientBattle.GetMyPlayerIndex())
						{
							flag = true;
						}
					}
					else if (actionActor.IsPlayerActor())
					{
						flag = true;
					}
					if (flag)
					{
						this.m_clientBattle.Battle.ChangeActionActor(actionActor);
					}
				}
			}
			this.HideActorInfo();
			this.SetUIStateNone();
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x0032FF98 File Offset: 0x0032E198
		private void SetAutoBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAutoBattleBoolean_hotfix != null)
			{
				this.m_SetAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleUIController.SetAutoBattle(on);
			this.m_combatUIController.SetAutoBattle(on);
			this.m_clientBattle.SetAutoBattle(on);
			if (on)
			{
				this.DoAutoBattle();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			LocalConfig.Instance.SetAutoBattle(projectLPlayerContext.Happening.BattleType, on);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x0033006C File Offset: 0x0032E26C
		private void CameraFocusActor(int actorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CameraFocusActorInt32_hotfix != null)
			{
				this.m_CameraFocusActorInt32_hotfix.call(new object[]
				{
					this,
					actorId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor actorById = this.m_clientBattle.Battle.GetActorById(actorId);
			if (actorById != null)
			{
				this.m_clientBattle.CameraFocusPosition(actorById.Position);
			}
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x00330108 File Offset: 0x0032E308
		private void BattleUIController_OnAutoBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnAutoBattleBoolean_hotfix != null)
			{
				this.m_BattleUIController_OnAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isStartInBattleRoom)
			{
				this.BattleRoomSetAutoBattle(on);
			}
			else
			{
				this.SetAutoBattle(on);
			}
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x00330198 File Offset: 0x0032E398
		private void BattleUIController_OnFastBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnFastBattleBoolean_hotfix != null)
			{
				this.m_BattleUIController_OnFastBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleUIController.SetFastBattle(on);
			this.m_clientBattle.SetFastBattle(on);
			LocalConfig.Instance.Data.IsFasBattle = on;
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x0033023C File Offset: 0x0032E43C
		private void BattleUIController_OnSkipCombat(SkipCombatMode mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnSkipCombatSkipCombatMode_hotfix != null)
			{
				this.m_BattleUIController_OnSkipCombatSkipCombatMode_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleUIController.SetSkipCombatMode(mode);
			this.m_clientBattle.SetSkipCombatMode(mode);
			LocalConfig.Instance.Data.SkipCombatMode = (int)mode;
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x003302E0 File Offset: 0x0032E4E0
		private void BattleUIController_OnShowDanger(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowDangerBoolean_hotfix != null)
			{
				this.m_BattleUIController_OnShowDangerBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State != ClientBattleState.Play)
			{
				return;
			}
			this.m_battleUIController.SetShowDanger(on);
			this.m_showDangerRegionActorIds.Clear();
			if (on)
			{
				this.m_showDangerRegionTeam = 1 - this.m_clientBattle.GetMyPlayerTeamNumber();
				this.UpdateDangerRegion();
			}
			else
			{
				this.m_showDangerRegionTeam = -1;
				this.m_battleMapUIController.HideDangerRegion();
			}
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x003303B0 File Offset: 0x0032E5B0
		private void BattleUIController_OnEndAllAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnEndAllAction_hotfix != null)
			{
				this.m_BattleUIController_OnEndAllAction_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State != ClientBattleState.Play)
			{
				return;
			}
			this.HideActorInfo();
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_EndAllAction, new Action<DialogBoxResult>(this.EndAllActionDialogBoxCallback), (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x00330448 File Offset: 0x0032E648
		private void EndAllActionDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EndAllActionDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_EndAllActionDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok && (this.m_uiState == BattleUIState.Move || this.m_uiState == BattleUIState.ExtraMove || this.m_uiState == BattleUIState.SelectActionActor))
			{
				if (this.m_activeActor != null)
				{
					this.AddCommandIfMoved(this.m_activeActor);
					this.m_activeActor.BattleActor.CreateBattleCommand(BattleCommandType.Done);
				}
				this.m_clientBattle.EndAllAction(0);
				this.SetUIStateNone();
			}
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x00330520 File Offset: 0x0032E720
		private void BattleUIController_OnEndAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnEndAction_hotfix != null)
			{
				this.m_BattleUIController_OnEndAction_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.CanAction())
			{
				return;
			}
			if (this.m_uiState == BattleUIState.Move || this.m_uiState == BattleUIState.ExtraMove)
			{
				this.AddCommandIfMoved(this.m_activeActor);
				this.m_activeActor.BattleActor.CreateBattleCommand(BattleCommandType.Done);
				this.SetUIStateNone();
				this.SendBattleCommands();
			}
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x003305D0 File Offset: 0x0032E7D0
		private void BattleUIController_OnShowActorInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowActorInfo_hotfix != null)
			{
				this.m_BattleUIController_OnShowActorInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor != null)
			{
				this.ShowActorInfo(this.m_activeActor.BattleActor);
			}
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x0033064C File Offset: 0x0032E84C
		private void BattleUIController_OnSelectSkill(int skillIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnSelectSkillInt32_hotfix != null)
			{
				this.m_BattleUIController_OnSelectSkillInt32_hotfix.call(new object[]
				{
					this,
					skillIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.CanAction())
			{
				return;
			}
			BattleSkillState skillState = this.m_activeActor.BattleActor.GetSkillState(skillIndex);
			if (skillState == null)
			{
				return;
			}
			if (this.m_uiState == BattleUIState.Move)
			{
				if (skillState.m_skillInfo.IsPassiveSkill())
				{
					this.m_battleUIController.ShowSkillHint(StringTableId.StringTableId_Battle_CanNotUsePassiveSkill, 1f);
					AudioUtility.PlaySound(SoundTableId.SoundTableId_Error);
					return;
				}
				if (this.m_activeActor.BattleActor.HasFightTag(FightTag.FightTag_BanActiveSkill))
				{
					this.m_battleUIController.ShowSkillHint(StringTableId.StringTableId_Battle_SkillIsBanned, 1f);
					AudioUtility.PlaySound(SoundTableId.SoundTableId_Error);
					return;
				}
				if (skillState.m_cooldown > 0)
				{
					this.m_battleUIController.ShowSkillHint(StringTableId.StringTableId_Battle_SkillIsCooldown, 1f);
					AudioUtility.PlaySound(SoundTableId.SoundTableId_Error);
					return;
				}
				this.m_skillIndex = skillIndex;
				this.SetUIStateSelectSkillTarget();
				if (this.m_activeActor.BattleActor.GetSkillDistance(skillState.m_skillInfo) <= 0)
				{
					this.OnBattleMapClick(this.m_activeActor.Position, false);
				}
			}
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x003307B0 File Offset: 0x0032E9B0
		private void BattleUIController_OnUseSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnUseSkill_hotfix != null)
			{
				this.m_BattleUIController_OnUseSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.CanAction())
			{
				return;
			}
			BattleActor battleActor = this.m_activeActor.BattleActor;
			BattleSkillState skillState = battleActor.GetSkillState(this.m_skillIndex);
			if (skillState == null)
			{
				return;
			}
			if (this.m_uiState == BattleUIState.ConfirmSkill)
			{
				if (skillState.m_skillInfo.SkillType == SkillType.SkillType_BF_Teleport)
				{
					this.m_clientBattle.OnBattleActorSkill(battleActor, skillState.m_skillInfo, this.m_skillTargetPosition);
					this.m_clientBattle.OnBattleActorTeleportDisappear(this.GetMapBattleActor(this.m_skillTargetPosition), skillState.m_skillInfo, this.m_skillTargetPosition2);
					this.SetUIStateSelectTeleportPosition1();
				}
				else
				{
					this.AddCommandIfMoved(this.m_activeActor);
					BattleCommand battleCommand = battleActor.CreateBattleCommand(BattleCommandType.Skill);
					battleCommand.SkillIndex = this.m_skillIndex;
					battleCommand.TargetPosition = this.m_skillTargetPosition;
					this.SetUIStateNone();
					this.SendBattleCommands();
				}
			}
			else if (this.m_uiState == BattleUIState.SelectTeleportPosition)
			{
				this.AddCommandIfMoved(this.m_activeActor);
				BattleCommand battleCommand2 = battleActor.CreateBattleCommand(BattleCommandType.Skill);
				battleCommand2.SkillIndex = this.m_skillIndex;
				battleCommand2.TargetPosition = this.m_skillTargetPosition;
				battleCommand2.TargetPosition2 = this.m_skillTargetPosition2;
				this.m_clientBattle.IgnoreSkillStep(battleCommand2.Step);
				this.m_clientBattle.IgnoreTeleportDisappearStep(battleCommand2.Step);
				this.SetUIStateNone();
				this.SendBattleCommands();
			}
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x00330950 File Offset: 0x0032EB50
		private void BattleUIController_OnCancelSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnCancelSkill_hotfix != null)
			{
				this.m_BattleUIController_OnCancelSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.CanAction())
			{
				return;
			}
			BattleSkillState skillState = this.m_activeActor.BattleActor.GetSkillState(this.m_skillIndex);
			if (skillState == null)
			{
				return;
			}
			if (this.m_uiState == BattleUIState.SelectSkillTarget)
			{
				this.SetUIStateMove();
			}
			else if (this.m_uiState == BattleUIState.ConfirmSkill)
			{
				this.ResetActorEffect();
				if (this.m_activeActor.BattleActor.GetSkillDistance(skillState.m_skillInfo) == 0)
				{
					this.SetUIStateMove();
				}
				else
				{
					this.SetUIStateSelectSkillTarget();
				}
			}
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x00330A30 File Offset: 0x0032EC30
		private void BattleUIController_OnShowChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowChat_hotfix != null)
			{
				this.m_BattleUIController_OnShowChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null && battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				ChatUITask.StartChatUITaskToEnterAppointChannel(ChatChannel.Team, this.m_currIntent, string.Empty);
			}
			else
			{
				ChatUITask.StartChatUITaskWithNormalMode(this.m_currIntent);
			}
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x00330ACC File Offset: 0x0032ECCC
		private void BattleUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowHelp_hotfix != null)
			{
				this.m_BattleUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Battle);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x00330B38 File Offset: 0x0032ED38
		private void BattleUIController_OnPauseBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnPauseBattle_hotfix != null)
			{
				this.m_BattleUIController_OnPauseBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State == ClientBattleState.Play)
			{
				if (!this.m_isStartInBattleRoom)
				{
					this.m_clientBattle.Pause(true);
				}
				this.m_battlePauseUIController.SetTurn(this.m_clientBattle.Battle.Turn, this.m_clientBattle.Battle.TurnMax);
				this.SetupBattlePauseUIAchievements();
				int myPlayerIndex = this.m_clientBattle.GetMyPlayerIndex();
				List<GridPosition> list = new List<GridPosition>();
				List<GridPosition> list2 = new List<GridPosition>();
				List<GridPosition> list3 = new List<GridPosition>();
				foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
				{
					if (!clientBattleActor.IsDead() && clientBattleActor.IsVisible())
					{
						if (clientBattleActor.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
						{
							if (clientBattleActor.BattleActor.IsAINpc() || clientBattleActor.BattleActor.PlayerIndex != myPlayerIndex)
							{
								list3.Add(clientBattleActor.Position);
							}
							else
							{
								list.Add(clientBattleActor.Position);
							}
						}
						else
						{
							list2.Add(clientBattleActor.Position);
						}
					}
				}
				this.m_battlePauseUIController.SetMapActors(list, list2, list3);
				this.m_battlePauseUIController.Open();
			}
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x00330D00 File Offset: 0x0032EF00
		private void BattleUIController_OnShowArmyRelation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowArmyRelation_hotfix != null)
			{
				this.m_BattleUIController_OnShowArmyRelation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_battleUIController.IsArmyRelationDescVisible())
			{
				this.m_battleUIController.ShowArmyRelationDesc();
			}
			else
			{
				this.m_battleUIController.HideArmyRelationDesc();
			}
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x00330D8C File Offset: 0x0032EF8C
		private void BattleUIController_OnPointerDown(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnPointerDownInputButtonVector2_hotfix != null)
			{
				this.m_BattleUIController_OnPointerDownInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x00330E0C File Offset: 0x0032F00C
		private void BattleUIController_OnPointerUp(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnPointerUpInputButtonVector2_hotfix != null)
			{
				this.m_BattleUIController_OnPointerUpInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x00330E8C File Offset: 0x0032F08C
		private void BattleUIController_OnShowCurTurnDanmaku(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowCurTurnDanmakuInt32_hotfix != null)
			{
				this.m_BattleUIController_OnShowCurTurnDanmakuInt32_hotfix.call(new object[]
				{
					this,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.ActivateLayer(this.m_battleDanmakuUIController, true);
			this.m_battleDanmakuUIController.ShowCurTurnDanmaku(turn);
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x00330F14 File Offset: 0x0032F114
		private void BattleUIController_OnCloseCurTurnDanmaku()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnCloseCurTurnDanmaku_hotfix != null)
			{
				this.m_BattleUIController_OnCloseCurTurnDanmaku_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.ActivateLayer(this.m_battleDanmakuUIController, false);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x00330F80 File Offset: 0x0032F180
		private void BattleUIController_OnShowOneDanmaku(DanmakuEntry danmaku)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnShowOneDanmakuDanmakuEntry_hotfix != null)
			{
				this.m_BattleUIController_OnShowOneDanmakuDanmakuEntry_hotfix.call(new object[]
				{
					this,
					danmaku
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDanmakuUIController.ShowOneDanmaku(danmaku);
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x00330FFC File Offset: 0x0032F1FC
		private void BattleUIController_OnPointerClick(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnPointerClickInputButtonVector2_hotfix != null)
			{
				this.m_BattleUIController_OnPointerClickInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (button != PointerEventData.InputButton.Left)
			{
				return;
			}
			if (this.m_clientBattle.IsBattlePerforming())
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
			{
				return;
			}
			if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				return;
			}
			if (this.m_activeActor != null && this.m_activeActor.HasAct())
			{
				return;
			}
			GridPosition p = this.m_clientBattle.ScreenPositionToGridPosition(position);
			bool isDoubleClick = false;
			DateTime now = DateTime.Now;
			if ((now - this.m_battleMapClickTime).TotalMilliseconds <= 300.0)
			{
				isDoubleClick = true;
			}
			this.m_battleMapClickTime = now;
			this.OnBattleMapClick(p, isDoubleClick);
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x0033112C File Offset: 0x0032F32C
		public void OnBattleMapClick(GridPosition p, bool isDoubleClick = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleMapClickGridPositionBoolean_hotfix != null)
			{
				this.m_OnBattleMapClickGridPositionBoolean_hotfix.call(new object[]
				{
					this,
					p,
					isDoubleClick
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State != ClientBattleState.Play)
			{
				return;
			}
			BattleActor mapBattleActor = this.GetMapBattleActor(p);
			if (this.m_clientBattle.Battle.Map.IsValidPosition(p) && this.m_uiState != BattleUIState.ExtraMove)
			{
				this.ShowSelectionMarkAndTerrain(p);
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			int region = map.GetRegion(p);
			int actionTeam = this.m_clientBattle.Battle.GetActionTeam();
			int myPlayerIndex = this.m_clientBattle.GetMyPlayerIndex();
			if (this.m_uiState == BattleUIState.SelectActionActor)
			{
				if (this.ShouldShowActorInfo(mapBattleActor))
				{
					this.ShowActorInfo(mapBattleActor);
					this.ShowMoveAndAttackRegion(mapBattleActor, mapBattleActor.Position);
				}
				else
				{
					if (this.m_battleActorInfoUIController.IsOpened())
					{
						this.HideActorInfo();
						this.m_battleMapUIController.HideRegion();
					}
					if (mapBattleActor != null && mapBattleActor.CanAction() && mapBattleActor.TeamNumber == actionTeam && mapBattleActor.PlayerIndex == myPlayerIndex)
					{
						this.m_clientBattle.Battle.ChangeActionActor(mapBattleActor);
					}
				}
				if (mapBattleActor == null)
				{
					this.ShowCanActionActorsUI();
				}
				else
				{
					this.HideCanActionActorsUI();
				}
			}
			else if (this.m_uiState == BattleUIState.Move)
			{
				if (!this.CanAction())
				{
					return;
				}
				if (p == this.m_activeActor.Position)
				{
					if (p != this.m_activeActorInitPosition)
					{
						this.HideActorInfo();
						if (LocalConfig.Instance.Data.ClickActorEndAction)
						{
							this.BattleUIController_OnEndAction();
						}
					}
					else if (!this.m_battleActorInfoUIController.IsOpened())
					{
						this.ShowActorInfo(this.m_activeActor.BattleActor);
					}
					else
					{
						this.HideActorInfo();
						this.ShowSkills();
					}
				}
				else
				{
					bool flag = false;
					if (region == 1)
					{
						if (mapBattleActor == null || mapBattleActor == this.m_activeActor.BattleActor)
						{
							this.ClientActorTryMoveTo(this.m_activeActor, p, 0);
							flag = true;
						}
					}
					else if (region == 2 && mapBattleActor != null && mapBattleActor.TeamNumber != this.m_activeActor.BattleActor.TeamNumber)
					{
						if (GridPosition.Distance(p, this.m_activeActor.Position) <= this.m_activeActor.BattleActor.GetMaxAttackDistance())
						{
							this.ShowPreCombat(this.m_activeActor.BattleActor, mapBattleActor, null);
							this.m_combatTargetPosition = p;
							flag = true;
						}
						else
						{
							GridPosition gridPosition = this.FindAttackPosition(this.m_activeActor.BattleActor.GetMaxAttackDistance(), p);
							if (gridPosition != GridPosition.Null)
							{
								this.ClientActorTryMoveTo(this.m_activeActor, gridPosition, 0);
								flag = true;
								this.m_preCombatTargetActor = mapBattleActor;
							}
						}
					}
					if (flag)
					{
						if (this.m_battleActorInfoUIController.IsOpened())
						{
							this.HideActorInfo();
							this.m_battleUIController.ShowActorSimpleInfo(true);
						}
					}
					else
					{
						this.m_activeActor.Locate(this.m_activeActorInitPosition, this.m_activeActorInitDirection);
						this.m_battleMapUIController.HideMovePath();
						if (this.ShouldShowActorInfo(mapBattleActor))
						{
							this.SetUIStateSelectActionActor();
							this.ShowActorInfo(mapBattleActor);
							this.ShowMoveAndAttackRegion(mapBattleActor, mapBattleActor.Position);
						}
						else
						{
							this.HideActorInfo();
							if (mapBattleActor != null && mapBattleActor.CanAction() && mapBattleActor.TeamNumber == actionTeam && mapBattleActor.PlayerIndex == myPlayerIndex)
							{
								this.m_clientBattle.Battle.ChangeActionActor(mapBattleActor);
							}
							else
							{
								this.SetUIStateSelectActionActor();
							}
						}
						if (mapBattleActor == null)
						{
							this.ShowCanActionActorsUI();
						}
						else
						{
							this.HideCanActionActorsUI();
						}
					}
				}
			}
			else if (this.m_uiState == BattleUIState.ExtraMove)
			{
				if (!this.CanAction())
				{
					return;
				}
				if (p == this.m_activeActor.Position)
				{
					if (p != this.m_activeActorInitPosition)
					{
						this.HideActorInfo();
						if (LocalConfig.Instance.Data.ClickActorEndAction)
						{
							this.BattleUIController_OnEndAction();
						}
					}
					else if (!this.m_battleActorInfoUIController.IsOpened())
					{
						this.ShowActorInfo(this.m_activeActor.BattleActor);
					}
					else
					{
						this.HideActorInfo();
						this.m_battleUIController.ShowActorSimpleInfo(true);
					}
				}
				else if (region == 1 && (mapBattleActor == null || mapBattleActor == this.m_activeActor.BattleActor))
				{
					if (this.m_battleActorInfoUIController.IsOpened())
					{
						this.HideActorInfo();
						this.m_battleUIController.ShowActorSimpleInfo(true);
					}
					this.ShowSelectionMarkAndTerrain(p);
					this.ClientActorTryMoveTo(this.m_activeActor, p, 0);
				}
			}
			else if (this.m_uiState == BattleUIState.SelectSkillTarget)
			{
				if (!this.CanAction())
				{
					return;
				}
				BattleSkillState skillState = this.m_activeActor.BattleActor.GetSkillState(this.m_skillIndex);
				if (skillState != null)
				{
					if (this.CanUseSkillAtPosition(this.m_activeActor, skillState.m_skillInfo, p))
					{
						this.m_skillTargetPosition = p;
						this.SetUIStateConfirmSkill();
						AudioUtility.PlaySound(SoundTableId.SoundTableId_SelectHero);
					}
					else
					{
						this.m_battleUIController.HighlightSkillHint();
						AudioUtility.PlaySound(SoundTableId.SoundTableId_Error);
					}
				}
			}
			else if (this.m_uiState == BattleUIState.ConfirmSkill)
			{
				if (!this.CanAction())
				{
					return;
				}
				BattleSkillState skillState2 = this.m_activeActor.BattleActor.GetSkillState(this.m_skillIndex);
				if (skillState2 != null)
				{
					if (p == this.m_skillTargetPosition)
					{
						this.BattleUIController_OnUseSkill();
						AudioUtility.PlaySound(SoundTableId.SoundTableId_SelectHero);
					}
					else if (this.CanUseSkillAtPosition(this.m_activeActor, skillState2.m_skillInfo, p))
					{
						this.m_skillTargetPosition = p;
						this.SetUIStateConfirmSkill();
						AudioUtility.PlaySound(SoundTableId.SoundTableId_SelectHero);
					}
					else
					{
						this.m_battleUIController.HighlightSkillHint();
						AudioUtility.PlaySound(SoundTableId.SoundTableId_Error);
					}
				}
			}
			else if (this.m_uiState == BattleUIState.SelectTeleportPosition)
			{
				if (!this.CanAction())
				{
					return;
				}
				if (map.GetRegion(p) == 4 && (mapBattleActor == null || p == this.m_skillTargetPosition))
				{
					this.m_skillTargetPosition2 = p;
					this.BattleUIController_OnUseSkill();
				}
				else
				{
					this.m_battleUIController.HighlightSkillHint();
					AudioUtility.PlaySound(SoundTableId.SoundTableId_Error);
				}
			}
			else if (this.m_uiState == BattleUIState.WaitOtherPlayer)
			{
				if (mapBattleActor != null)
				{
					this.ShowActorInfo(mapBattleActor);
					this.ShowMoveAndAttackRegion(mapBattleActor, mapBattleActor.Position);
				}
				else
				{
					this.HideActorInfo();
					this.m_battleMapUIController.HideRegion();
				}
			}
			else if (this.m_uiState == BattleUIState.Regret)
			{
				if (mapBattleActor != null)
				{
					this.ShowActorInfo(mapBattleActor);
					this.ShowMoveAndAttackRegion(mapBattleActor, mapBattleActor.Position);
				}
				else
				{
					this.HideActorInfo();
					this.m_battleMapUIController.HideRegion();
				}
			}
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x00331838 File Offset: 0x0032FA38
		private bool ShouldShowActorInfo(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShouldShowActorInfoBattleActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ShouldShowActorInfoBattleActor_hotfix.call(new object[]
				{
					this,
					a
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return false;
			}
			int actionTeam = this.m_clientBattle.Battle.GetActionTeam();
			int myPlayerIndex = this.m_clientBattle.GetMyPlayerIndex();
			return !a.CanAction() || a.TeamNumber != actionTeam || a.IsAINpc() || a.PlayerIndex != myPlayerIndex;
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x0033190C File Offset: 0x0032FB0C
		private void BattleUIController_On3DTouch(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_On3DTouchVector2_hotfix != null)
			{
				this.m_BattleUIController_On3DTouchVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State != ClientBattleState.Play)
			{
				return;
			}
			if (this.m_clientBattle.IsBattlePerforming())
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
			{
				return;
			}
			if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				return;
			}
			if (this.m_activeActor != null && this.m_activeActor.HasAct())
			{
				return;
			}
			GridPosition p = this.m_clientBattle.ScreenPositionToGridPosition(pos);
			BattleActor mapBattleActor = this.GetMapBattleActor(p);
			if (mapBattleActor == null)
			{
				return;
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			bool flag = false;
			if (this.m_uiState == BattleUIState.SelectActionActor)
			{
				if (this.ShouldShowActorInfo(mapBattleActor))
				{
					flag = true;
				}
			}
			else if (this.m_uiState == BattleUIState.Move)
			{
				if (map.GetRegion(p) == 0 && this.ShouldShowActorInfo(mapBattleActor))
				{
					flag = true;
				}
			}
			else if (this.m_uiState == BattleUIState.WaitOtherPlayer && mapBattleActor != null)
			{
				flag = true;
			}
			if (flag)
			{
				if (this.m_showDangerRegionActorIds.Contains(mapBattleActor.Id))
				{
					this.m_showDangerRegionActorIds.Remove(mapBattleActor.Id);
				}
				else
				{
					this.m_showDangerRegionActorIds.Add(mapBattleActor.Id);
				}
				int i = 0;
				while (i < this.m_showDangerRegionActorIds.Count)
				{
					BattleActor actorById = this.m_clientBattle.Battle.GetActorById(this.m_showDangerRegionActorIds[i]);
					if (actorById == null || actorById.IsDeadOrRetreat())
					{
						this.m_showDangerRegionActorIds.RemoveAt(i);
					}
					else
					{
						i++;
					}
				}
				if (this.m_showDangerRegionActorIds.Count > 0)
				{
					this.m_showDangerRegionTeam = -1;
					this.m_battleUIController.SetShowDanger(true);
					this.UpdateDangerRegion();
				}
				else
				{
					this.m_battleUIController.SetShowDanger(false);
					this.m_battleMapUIController.HideDangerRegion();
				}
				AudioUtility.PlaySound(this.m_configDataLoader.UtilityGetSound(SoundTableId.SoundTableId_ShowDangerRegion));
			}
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x00331B80 File Offset: 0x0032FD80
		private void PlaySelectHeroSound(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySelectHeroSoundBattleActor_hotfix != null)
			{
				this.m_PlaySelectHeroSoundBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			ConfigDataCharImageInfo charImageInfo = a.HeroInfo.GetCharImageInfo(a.HeroStar);
			if (charImageInfo == null)
			{
				return;
			}
			this.m_tempStringList.Clear();
			if (!string.IsNullOrEmpty(charImageInfo.BattleActionVoice1))
			{
				this.m_tempStringList.Add(charImageInfo.BattleActionVoice1);
			}
			if (!string.IsNullOrEmpty(charImageInfo.BattleActionVoice2))
			{
				this.m_tempStringList.Add(charImageInfo.BattleActionVoice2);
			}
			if (!string.IsNullOrEmpty(charImageInfo.BattleActionVoice3))
			{
				this.m_tempStringList.Add(charImageInfo.BattleActionVoice3);
			}
			if (this.m_tempStringList.Count > 0)
			{
				int index = this.m_clientBattle.RandomNumber.Next(0, this.m_tempStringList.Count);
				AudioUtility.PlaySound(this.m_tempStringList[index]);
			}
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x00331CC0 File Offset: 0x0032FEC0
		private void BattleDialogUITask_OnClose(bool isSkip)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUITask_OnCloseBoolean_hotfix != null)
			{
				this.m_BattleDialogUITask_OnCloseBoolean_hotfix.call(new object[]
				{
					this,
					isSkip
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDialogUITask != null)
			{
				this.m_battleDialogUITask.EventOnClose -= this.BattleDialogUITask_OnClose;
				this.m_battleDialogUITask = null;
			}
			if (this.m_clientBattle.IsWaitBattleDialog())
			{
				this.m_clientBattle.StopBattleDialog(0);
			}
			if (this.m_clientBattle.State != ClientBattleState.Prepare)
			{
				UIUtility.ActivateLayer(this.m_battleUIController, true);
			}
			if (isSkip && (this.m_battlePerformState == BattlePerformState.Before || this.m_battlePerformState == BattlePerformState.After))
			{
				this.m_clientBattle.Stop(true, true);
			}
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x00331DC0 File Offset: 0x0032FFC0
		private void BattleTreasureDialogUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleTreasureDialogUIController_OnClose_hotfix != null)
			{
				this.m_BattleTreasureDialogUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsWaitBattleTreasureDialog())
			{
				UIUtility.ActivateLayer(this.m_battleTreasureDialogUIController, false);
				this.m_clientBattle.StopBattleTreasureDialog();
			}
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x00331E48 File Offset: 0x00330048
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

		// Token: 0x0600B784 RID: 46980 RVA: 0x00331EFC File Offset: 0x003300FC
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
			if (this.m_clientBattle.IsWaitBattleTreasureReward())
			{
				this.m_clientBattle.StopBattleTreasureReward();
			}
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x00331F90 File Offset: 0x00330190
		private void CombatUIController_OnAutoBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatUIController_OnAutoBattleBoolean_hotfix != null)
			{
				this.m_CombatUIController_OnAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BattleUIController_OnAutoBattle(on);
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x00332008 File Offset: 0x00330208
		private void PreCombatUIController_OnOk()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreCombatUIController_OnOk_hotfix != null)
			{
				this.m_PreCombatUIController_OnOk_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_activeActor == null)
			{
				return;
			}
			if (this.m_uiState == BattleUIState.ConfirmSkill)
			{
				this.BattleUIController_OnUseSkill();
			}
			else
			{
				this.AddCommandIfMoved(this.m_activeActor);
				BattleCommand battleCommand = this.m_activeActor.BattleActor.CreateBattleCommand(BattleCommandType.Combat);
				battleCommand.TargetPosition = this.m_combatTargetPosition;
				this.SendBattleCommands();
			}
			this.SetUIStateNone();
			if (!this.m_clientBattle.IsSkippingCombat(false))
			{
				this.m_preCombatUIController.Close();
			}
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x003320E4 File Offset: 0x003302E4
		private void PreCombatUIController_OnCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreCombatUIController_OnCancel_hotfix != null)
			{
				this.m_PreCombatUIController_OnCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_preCombatUIController.Close();
			if (this.m_uiState == BattleUIState.ConfirmSkill)
			{
				this.BattleUIController_OnCancelSkill();
			}
			else
			{
				this.ShowSkills();
			}
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x0033216C File Offset: 0x0033036C
		private void PreCombatUIController_OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreCombatUIController_OnStop_hotfix != null)
			{
				this.m_PreCombatUIController_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_preCombatUIController.Close();
			this.m_clientBattle.StopFastCombat();
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x003321E4 File Offset: 0x003303E4
		private void BattleSceneUIController_OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_BattleSceneUIController_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnScenePointerDown(eventData);
				this.m_battlePrepareUIController.HideArmyRelationDesc();
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnScenePointerDown(eventData);
				this.m_battleUIController.HideArmyRelationDesc();
			}
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x003322A4 File Offset: 0x003304A4
		private void BattleSceneUIController_OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_BattleSceneUIController_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnScenePointerUp(eventData);
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnScenePointerUp(eventData);
			}
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x0033234C File Offset: 0x0033054C
		private void BattleSceneUIController_OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_BattleSceneUIController_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnScenePointerClick(eventData);
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnScenePointerClick(eventData);
			}
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x003323F4 File Offset: 0x003305F4
		private void BattleSceneUIController_OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_BattleSceneUIController_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnSceneBeginDrag(eventData);
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnSceneBeginDrag(eventData);
			}
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x0033249C File Offset: 0x0033069C
		private void BattleSceneUIController_OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_BattleSceneUIController_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnSceneEndDrag(eventData);
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnSceneEndDrag(eventData);
			}
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x00332544 File Offset: 0x00330744
		private void BattleSceneUIController_OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_OnDragPointerEventData_hotfix != null)
			{
				this.m_BattleSceneUIController_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnSceneDrag(eventData);
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnSceneDrag(eventData);
			}
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x003325EC File Offset: 0x003307EC
		private void BattleSceneUIController_On3DTouch(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSceneUIController_On3DTouchVector2_hotfix != null)
			{
				this.m_BattleSceneUIController_On3DTouchVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				this.m_battlePrepareUIController.OnScene3DTouch(p);
			}
			if (UIUtility.IsLayerActive(this.m_battleUIController))
			{
				this.m_battleUIController.OnScene3DTouch(p);
			}
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x00332694 File Offset: 0x00330894
		private void SendBattleCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendBattleCommands_hotfix != null)
			{
				this.m_SendBattleCommands_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isStartInBattleRoom)
			{
				return;
			}
			LinkedList<BattleCommand> tempBattleCommands = this.m_clientBattle.Battle.GetTempBattleCommands();
			if (tempBattleCommands.Count > 0)
			{
				BattleRoomBattleCommandExecuteNetTask battleRoomBattleCommandExecuteNetTask = new BattleRoomBattleCommandExecuteNetTask(tempBattleCommands);
				battleRoomBattleCommandExecuteNetTask.EventOnStop += delegate(Task task)
				{
					BattleRoomBattleCommandExecuteNetTask battleRoomBattleCommandExecuteNetTask2 = task as BattleRoomBattleCommandExecuteNetTask;
					if (battleRoomBattleCommandExecuteNetTask2.Result != 0)
					{
						if (battleRoomBattleCommandExecuteNetTask2.Result == -926)
						{
							this.ShowErrorMessageAndExitBattle(battleRoomBattleCommandExecuteNetTask2.Result);
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(battleRoomBattleCommandExecuteNetTask2.Result, 2f, null, true);
							if (battleRoomBattleCommandExecuteNetTask2.Result == -930 && !battleRoomBattleCommandExecuteNetTask2.IsReloginSuccess)
							{
								this.ReloginUITask_OnReloginSuccess();
							}
						}
					}
				};
				battleRoomBattleCommandExecuteNetTask.Start(null);
			}
			this.m_clientBattle.Battle.ClearTempBattleCommands();
			this.m_clientBattle.Battle.EnableTempBattleCommands(false);
			this.ActivateBattleRoomMyActionCountdown(false);
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x00332768 File Offset: 0x00330968
		private void UpdateBattleRoomPlayerHeroStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattleRoomPlayerHeroStatus_hotfix != null)
			{
				this.m_UpdateBattleRoomPlayerHeroStatus_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (!battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				return;
			}
			for (int i = 0; i < battleRoom.Players.Count; i++)
			{
				int num = 0;
				for (int j = 0; j < battleRoom.BattleRoomPlayerHeroSetup.GetCount(); j++)
				{
					BattleHeroSetupInfo battleHeroSetupInfo = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(j);
					if (battleHeroSetupInfo.PlayerIndex == i && battleHeroSetupInfo.Hero != null)
					{
						bool isAlive = false;
						foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
						{
							if (clientBattleActor.BattleActor.PlayerIndex == i && clientBattleActor.BattleActor.HeroId == battleHeroSetupInfo.Hero.HeroId)
							{
								isAlive = !clientBattleActor.IsDead();
								break;
							}
						}
						this.m_battleRoomUIController.SetPlayerHeroAlive(i, num, isAlive);
						num++;
					}
				}
			}
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x003328E8 File Offset: 0x00330AE8
		private void StartBattleRoomMyActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomMyActionCountdown_hotfix != null)
			{
				this.m_StartBattleRoomMyActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			DateTime dateTime = DateTime.Now;
			if (battleRoom.LastPlayerBeginActionTime != DateTime.MinValue)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				dateTime = projectLPlayerContext.ServerTimeToLocalTime(battleRoom.LastPlayerBeginActionTime);
			}
			if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				this.m_myActionTimeout = dateTime.AddSeconds((double)this.m_configDataLoader.ConfigableConstId_TeamBattleRoomPlayerActionClientTimeOutTime);
			}
			else if (battleRoom.IsAnyPVPBattleRoomType())
			{
				this.m_myActionTimeout = dateTime.AddSeconds((double)this.m_configDataLoader.ConfigableConstId_PVPBattleRoomPlayerActionClientTimeOutTime);
			}
			this.m_isActionTimeoutAutoBattle = false;
			this.m_isAutoBattleOnce = false;
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x003329EC File Offset: 0x00330BEC
		private void StopBattleRoomMyActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleRoomMyActionCountdown_hotfix != null)
			{
				this.m_StopBattleRoomMyActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_myActionTimeout = DateTime.MinValue;
			this.m_isActionTimeoutAutoBattle = false;
			this.m_isAutoBattleOnce = false;
			this.m_isMyActionTimeoutActive = false;
			this.m_battleRoomUIController.HideMyActionCountdown();
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x00332A78 File Offset: 0x00330C78
		private void ActivateBattleRoomMyActionCountdown(bool isActive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivateBattleRoomMyActionCountdownBoolean_hotfix != null)
			{
				this.m_ActivateBattleRoomMyActionCountdownBoolean_hotfix.call(new object[]
				{
					this,
					isActive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isMyActionTimeoutActive = isActive;
			if (isActive)
			{
				this.m_battleRoomUIController.ShowMyActionCountdown();
				this.UpdateBattleRoomMyActionCountdown();
			}
			else
			{
				this.m_battleRoomUIController.HideMyActionCountdown();
			}
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x00332B18 File Offset: 0x00330D18
		private void UpdateBattleRoomMyActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattleRoomMyActionCountdown_hotfix != null)
			{
				this.m_UpdateBattleRoomMyActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isMyActionTimeoutActive)
			{
				return;
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (this.m_myActionTimeout != DateTime.MinValue)
			{
				TimeSpan myActionCountdown = this.m_myActionTimeout - DateTime.Now;
				if (myActionCountdown.Ticks < 0L)
				{
					myActionCountdown = TimeSpan.Zero;
					if (!UIUtility.IsLayerActive(this.m_combatUIController) && !this.m_preCombatUIController.IsFastCombat())
					{
						this.StopBattleRoomMyActionCountdown();
						if (battleRoom.GetMyPlayer().PlayerBattleStatus != PlayerBattleStatus.Auto)
						{
							if (this.m_preCombatUIController.IsOpened())
							{
								this.PreCombatUIController_OnCancel();
							}
							if (this.m_battlePauseUIController.IsOpened())
							{
								this.BattlePauseUIController_OnClose();
							}
							if (battleRoom.IsAnyPVPBattleRoomType())
							{
								global::Debug.Log("BattleUITask.UpdateBattleRoomMyActionCountdown, AutoBattle once");
								this.m_isAutoBattleOnce = true;
								this.DoAutoBattle();
							}
							else
							{
								this.m_isActionTimeoutAutoBattle = true;
								this.BattleUIController_OnAutoBattle(true);
								global::Debug.Log("BattleUITask.UpdateBattleRoomMyActionCountdown, BattleUIController_OnAutoBattle true");
							}
						}
					}
				}
				this.m_battleRoomUIController.SetMyActionCountdown(myActionCountdown);
			}
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x00332C7C File Offset: 0x00330E7C
		private void StartBattleRoomOtherActionCountdown(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomOtherActionCountdownInt32_hotfix != null)
			{
				this.m_StartBattleRoomOtherActionCountdownInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			DateTime dateTime = DateTime.Now;
			if (battleRoom.LastPlayerBeginActionTime != DateTime.MinValue)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				dateTime = projectLPlayerContext.ServerTimeToLocalTime(battleRoom.LastPlayerBeginActionTime);
			}
			if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				this.m_otherActionTimeout = dateTime.AddSeconds((double)this.m_configDataLoader.ConfigableConstId_TeamBattleRoomPlayerActionClientTimeOutTime);
				this.m_battleRoomUIController.SetOtherActionAsTeammate(playerIndex);
			}
			else if (battleRoom.IsAnyPVPBattleRoomType())
			{
				this.m_otherActionTimeout = dateTime.AddSeconds((double)this.m_configDataLoader.ConfigableConstId_PVPBattleRoomPlayerActionClientTimeOutTime);
				this.m_battleRoomUIController.SetOtherActionAsEnemy();
			}
			this.m_isActionTimeoutAutoBattle = false;
			this.m_isAutoBattleOnce = false;
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x00332DA4 File Offset: 0x00330FA4
		private void StopBattleRoomOtherActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleRoomOtherActionCountdown_hotfix != null)
			{
				this.m_StopBattleRoomOtherActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_otherActionTimeout = DateTime.MinValue;
			this.m_battleRoomUIController.HideOtherActionCountdown();
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x00332E1C File Offset: 0x0033101C
		private void ActivateBattleRoomOtherActionCountdown(bool isActive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivateBattleRoomOtherActionCountdownBoolean_hotfix != null)
			{
				this.m_ActivateBattleRoomOtherActionCountdownBoolean_hotfix.call(new object[]
				{
					this,
					isActive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isActive)
			{
				this.m_battleRoomUIController.ShowOtherActionCountdown();
				this.UpdateBattleRoomOtherActionCountdown();
			}
			else
			{
				this.m_battleRoomUIController.HideOtherActionCountdown();
			}
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x00332EB4 File Offset: 0x003310B4
		private void UpdateBattleRoomOtherActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattleRoomOtherActionCountdown_hotfix != null)
			{
				this.m_UpdateBattleRoomOtherActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_otherActionTimeout != DateTime.MinValue)
			{
				TimeSpan otherActionCountdown = this.m_otherActionTimeout - DateTime.Now;
				if (otherActionCountdown.Ticks < 0L)
				{
					otherActionCountdown = TimeSpan.Zero;
				}
				this.m_battleRoomUIController.SetOtherActionCountdown(otherActionCountdown);
			}
		}

		// Token: 0x0600B79A RID: 47002 RVA: 0x00332F5C File Offset: 0x0033115C
		private void BattleRoomSetAutoBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleRoomSetAutoBattleBoolean_hotfix != null)
			{
				this.m_BattleRoomSetAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					on2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool on = on2;
			BattleUITask $this = this;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (!on && this.m_isActionTimeoutAutoBattle)
			{
				return;
			}
			if (battleRoom.BattleReward != null)
			{
				return;
			}
			BattleRoomPlayerStatusChangeNetTask battleRoomPlayerStatusChangeNetTask = new BattleRoomPlayerStatusChangeNetTask((!on) ? PlayerBattleStatus.Normal : PlayerBattleStatus.Auto);
			battleRoomPlayerStatusChangeNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomPlayerStatusChangeNetTask battleRoomPlayerStatusChangeNetTask2 = task as BattleRoomPlayerStatusChangeNetTask;
				if (battleRoomPlayerStatusChangeNetTask2.Result == -926)
				{
					$this.ShowErrorMessageAndExitBattle(battleRoomPlayerStatusChangeNetTask2.Result);
				}
				else if (!battleRoomPlayerStatusChangeNetTask2.IsReloginSuccess)
				{
					if (battleRoomPlayerStatusChangeNetTask2.Result == 0)
					{
						$this.SetAutoBattle(on);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleRoomPlayerStatusChangeNetTask2.Result, 2f, null, true);
					}
				}
			};
			battleRoomPlayerStatusChangeNetTask.Start(null);
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x00333044 File Offset: 0x00331244
		private void ProcessBattlePendingNtfs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ProcessBattlePendingNtfs_hotfix != null)
			{
				this.m_ProcessBattlePendingNtfs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!UIUtility.IsLayerActive(this.m_battleUIController))
			{
				return;
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (battleRoom.BattleCommands.Count > 0)
			{
				this.PlayerContext_OnBattleRoomBattleCommandExecuteNtf(0UL);
			}
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x003330DC File Offset: 0x003312DC
		private void PlayerContext_OnBattleRoomPlayerStatusChangedNtf(ulong playerSessionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomPlayerStatusChangedNtfUInt64_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomPlayerStatusChangedNtfUInt64_hotfix.call(new object[]
				{
					this,
					playerSessionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			int num = battleRoom.FindPlayerIndexBySessiongId(playerSessionId);
			if (num < 0)
			{
				return;
			}
			BattleRoomPlayer battleRoomPlayer = battleRoom.Players[num];
			this.m_battleRoomUIController.SetPlayerStatus(num, battleRoomPlayer.PlayerBattleStatus, battleRoomPlayer.IsOffline);
			if (battleRoom.BattleRoomStatus == BattleRoomStatus.Ready)
			{
				if (num == battleRoom.MyPlayerIndex && battleRoomPlayer.PlayerBattleStatus == PlayerBattleStatus.Ready)
				{
					this.m_battlePrepareUIController.ShowTeamReadyWait(battleRoom.BattleRoomType);
				}
				if (UIUtility.IsLayerActive(this.m_battlePrepareUIController))
				{
					this.UpdateBattleRoomPrepareTimeout();
				}
				if (UIUtility.IsLayerActive(this.m_pvpBattlePrepareUIController))
				{
					this.UpdateRealtimePVPBattlePrepareStatus();
				}
			}
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x003331F0 File Offset: 0x003313F0
		private void PlayerContext_OnBattleRoomPlayerQuitNtf(ulong playerSessionId, BattleRoomQuitReason reason)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomPlayerQuitNtfUInt64BattleRoomQuitReason_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomPlayerQuitNtfUInt64BattleRoomQuitReason_hotfix.call(new object[]
				{
					this,
					playerSessionId,
					reason
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			global::Debug.Log(string.Format("BattleUITask.PlayerContext_OnBattleRoomPlayerQuitNtf sessionId:{0}, reason:{1}", playerSessionId, reason));
			if (battleRoom.FindPlayerIndexBySessiongId(playerSessionId) == battleRoom.MyPlayerIndex)
			{
				if (reason != BattleRoomQuitReason.Client)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_SelfQuitBattle, 2f, null, true);
				}
				if (battleRoom.IsRealTimePVPBattleRoomType())
				{
					if (this.m_clientBattle.State == ClientBattleState.Prepare)
					{
						this.BattlePrepareBeforeShowResult();
					}
					this.m_clientBattle.Stop(false, true);
				}
				else
				{
					this.ExitBattleReturnToWorld();
				}
			}
			else if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				BattleRoomPlayer battleRoomPlayer = battleRoom.FindPlayerBySessionId(playerSessionId);
				if (battleRoomPlayer != null)
				{
					string txt = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_PlayerQuitBattle), battleRoomPlayer.Name);
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				}
			}
			else if (battleRoom.IsAnyPVPBattleRoomType())
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_PVP_OpponentQuitBattle, 2f, null, true);
				if (this.m_clientBattle.State == ClientBattleState.Prepare)
				{
					this.BattlePrepareBeforeShowResult();
				}
				this.m_clientBattle.Stop(true, true);
			}
		}

		// Token: 0x0600B79E RID: 47006 RVA: 0x00333398 File Offset: 0x00331598
		private void PlayerContext_OnBattleRoomBattleCommandExecuteNtf(ulong playerSessionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomBattleCommandExecuteNtfUInt64_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomBattleCommandExecuteNtfUInt64_hotfix.call(new object[]
				{
					this,
					playerSessionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State == ClientBattleState.Prepare)
			{
				return;
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			this.m_battleMapUIController.HideRegion();
			bool flag = this.m_clientBattle.Battle.IsEnableTempBattleCommands();
			if (flag)
			{
				this.m_clientBattle.Battle.EnableTempBattleCommands(false);
				global::Debug.LogWarning("PlayerContext_OnBattleRoomBattleCommandExecuteNtf TempBattleCommands enabled");
			}
			foreach (BattleCommand cmd in battleRoom.BattleCommands)
			{
				this.m_clientBattle.Battle.AddBattleCommand(cmd);
			}
			battleRoom.BattleCommands.Clear();
			if (flag)
			{
				this.m_clientBattle.Battle.EnableTempBattleCommands(true);
			}
			int num = battleRoom.FindPlayerIndexBySessiongId(playerSessionId);
			if (num >= 0)
			{
				if (num == battleRoom.MyPlayerIndex)
				{
					this.ActivateBattleRoomMyActionCountdown(false);
				}
				else
				{
					this.ActivateBattleRoomOtherActionCountdown(false);
				}
			}
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x00333514 File Offset: 0x00331714
		private void PlayerContext_OnBattleRoomTeamBattleFinishNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomTeamBattleFinishNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomTeamBattleFinishNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x00333574 File Offset: 0x00331774
		private void PlayerContext_OnBattleRoomPVPBattleFinishNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomPVPBattleFinishNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomPVPBattleFinishNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x003335D4 File Offset: 0x003317D4
		private void PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x00333634 File Offset: 0x00331834
		private void PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x00333694 File Offset: 0x00331894
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
			if (!this.m_isStartInBattleRoom)
			{
				BattleRoomQuitNetTask battleRoomQuitNetTask = new BattleRoomQuitNetTask();
				battleRoomQuitNetTask.Start(null);
			}
		}

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x00333710 File Offset: 0x00331910
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
			if (this.m_isStartInBattleRoom)
			{
				this.ReloginUITask_OnReloginSuccess();
			}
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x00333784 File Offset: 0x00331984
		private void ReloginUITask_OnReloginSuccess()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReloginUITask_OnReloginSuccess_hotfix != null)
			{
				this.m_ReloginUITask_OnReloginSuccess_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isStartInBattleRoom)
			{
				return;
			}
			this.StopBattleRoomMyActionCountdown();
			this.StopBattleRoomOtherActionCountdown();
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_Reconnect, 2f, null, true);
			BattleRoomGetNetTask battleRoomGetNetTask = new BattleRoomGetNetTask();
			battleRoomGetNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomGetNetTask battleRoomGetNetTask2 = task as BattleRoomGetNetTask;
				if (battleRoomGetNetTask2.Result == 0)
				{
					ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					projectLPlayerContext.SetNeedRebuildBattle(true);
					this.m_clientBattle.Clear();
					this.StartBattlePrepareLoadState();
				}
				else
				{
					this.ShowErrorMessageAndExitBattle(battleRoomGetNetTask2.Result);
				}
			};
			battleRoomGetNetTask.Start(null);
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x00333834 File Offset: 0x00331A34
		private BattleRoom GetBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleRoom_hotfix != null)
			{
				return (BattleRoom)this.m_GetBattleRoom_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isStartInBattleRoom)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				return projectLPlayerContext.GetBattleRoom();
			}
			return null;
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x003338C4 File Offset: 0x00331AC4
		private void UpdateBattleRoomPrepareTimeout()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattleRoomPrepareTimeout_hotfix != null)
			{
				this.m_UpdateBattleRoomPrepareTimeout_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (battleRoom.IsRealTimePVPBattleRoomType())
			{
				return;
			}
			if (battleRoom.BattleRoomStatus != BattleRoomStatus.Ready)
			{
				return;
			}
			if (battleRoom.GetMyPlayer().PlayerBattleStatus == PlayerBattleStatus.Ready)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan ts = battleRoom.ReadyTimeout - projectLPlayerContext.GetServerTime();
			if (ts.Ticks < 0L)
			{
				ts = TimeSpan.Zero;
			}
			this.m_battlePrepareUIController.ShowTeamReadyCountdown(ts);
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x003339A0 File Offset: 0x00331BA0
		private void UpdateRealtimePVPBattlePrepareTimeout()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRealtimePVPBattlePrepareTimeout_hotfix != null)
			{
				this.m_UpdateRealtimePVPBattlePrepareTimeout_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (battleRoom.BattleRoomStatus != BattleRoomStatus.Ready)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan prepareCountdown = TimeSpan.Zero;
			if (battleRoom.BattleRoomType == BattleRoomType.RealTimePVPDefaultMode)
			{
				prepareCountdown = battleRoom.ReadyTimeout - projectLPlayerContext.GetServerTime();
			}
			else if (battleRoom.BattleRoomType == BattleRoomType.RealTimePVPBPMode)
			{
				if (battleRoom.BPStatus == BattleRoomBPStatus.Done)
				{
					return;
				}
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				int num = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPTurnInterval);
				prepareCountdown = battleRoom.LatestTurnChangeDateTime.AddMilliseconds((double)num) - projectLPlayerContext.GetServerTime();
			}
			if (prepareCountdown.Ticks < 0L)
			{
				prepareCountdown = TimeSpan.Zero;
			}
			this.m_pvpBattlePrepareUIController.SetPrepareCountdown(prepareCountdown);
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x00333AC4 File Offset: 0x00331CC4
		private void UpdateRealtimePVPBattlePrepareStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRealtimePVPBattlePrepareStatus_hotfix != null)
			{
				this.m_UpdateRealtimePVPBattlePrepareStatus_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (!battleRoom.IsRealTimePVPBattleRoomType())
			{
				return;
			}
			if (battleRoom.BattleRoomStatus != BattleRoomStatus.Ready)
			{
				return;
			}
			if (battleRoom.BattleRoomType == BattleRoomType.RealTimePVPDefaultMode)
			{
				PlayerBattleStatus playerBattleStatus = battleRoom.GetMyPlayer().PlayerBattleStatus;
				if (playerBattleStatus == PlayerBattleStatus.Normal)
				{
					this.m_pvpBattlePrepareUIController.ShowPickMyHero(0);
					this.UpdateRealtimePVPBattlePrepareTimeout();
					this.m_battlePrepareUIController.EnableHeroOnStage(true);
				}
				else if (playerBattleStatus == PlayerBattleStatus.Ready)
				{
					this.m_pvpBattlePrepareUIController.ShowWaitOpponent();
					this.UpdateRealtimePVPBattlePrepareTimeout();
					this.m_battlePrepareUIController.EnableHeroOnStage(false);
				}
			}
			else if (battleRoom.BattleRoomType == BattleRoomType.RealTimePVPBPMode)
			{
				if (battleRoom.BPStatus == BattleRoomBPStatus.Pick)
				{
					this.m_battlePrepareUIController.SetTurnStageActorCountMax(battleRoom.GetHeroSetupCountMaxInPickTurn(battleRoom.BPTurn));
					int playerIndexInCurrentPickTurn = battleRoom.GetPlayerIndexInCurrentPickTurn();
					if (playerIndexInCurrentPickTurn == battleRoom.MyPlayerIndex)
					{
						int heroSetupCountInCurrentPickTurn = battleRoom.GetHeroSetupCountInCurrentPickTurn();
						this.m_pvpBattlePrepareUIController.ShowPickMyHero(heroSetupCountInCurrentPickTurn);
						int remainHeroSetupCountInCurrentPickTurn = battleRoom.GetRemainHeroSetupCountInCurrentPickTurn();
						this.m_pvpBattlePrepareUIController.SetPrepareConfirmButtonState(remainHeroSetupCountInCurrentPickTurn == 0);
						this.m_pvpBattlePrepareUIController.SetPickHeroCount(heroSetupCountInCurrentPickTurn - remainHeroSetupCountInCurrentPickTurn);
						this.m_battlePrepareUIController.EnableHeroOnStage(true);
					}
					else
					{
						this.m_pvpBattlePrepareUIController.ShowWaitOpponent();
						this.m_battlePrepareUIController.EnableHeroOnStage(false);
					}
					this.UpdateRealtimePVPBattlePrepareTimeout();
					foreach (BattlePrepareStageActor sa in this.m_battlePrepareUIController.GetStageActors())
					{
						this.UpdateStageActorTag(sa);
					}
				}
				else if (battleRoom.BPStatus == BattleRoomBPStatus.Protect)
				{
					this.m_battlePrepareUIController.EnableHeroOnStage(false);
					int heroSetupFlagCount = battleRoom.GetHeroSetupFlagCount(battleRoom.MyPlayerIndex, SetupBattleHeroFlag.Protect);
					if (heroSetupFlagCount == 0)
					{
						this.m_pvpBattlePrepareUIController.ShowProtectIndicator(battleRoom.MyPlayerIndex);
						bool flag = this.m_selectProtectHeroPos != GridPosition.Null;
						this.m_pvpBattlePrepareUIController.SetProtectHeroCount((!flag) ? 0 : 1);
						this.m_pvpBattlePrepareUIController.SetPrepareConfirmButtonState(flag);
						if (LocalAccountConfig.Instance.Data.IsRealtimePVPShowNotice)
						{
							LocalAccountConfig.Instance.Data.IsRealtimePVPShowNotice = false;
							LocalAccountConfig.Instance.Save();
							InstructionUITask.StartUITask("UI/UserGuide_ABS/Prefab/UserGuide_17UIPrefab.prefab");
						}
					}
					else
					{
						this.m_pvpBattlePrepareUIController.ShowWaitOpponent();
					}
					this.UpdateRealtimePVPBattlePrepareTimeout();
					foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
					{
						this.UpdateStageActorTag(battlePrepareStageActor);
						if (battlePrepareStageActor.GetTeam() == 0)
						{
							if (heroSetupFlagCount == 0)
							{
								if (battlePrepareStageActor.GetPosition() == this.m_selectProtectHeroPos)
								{
									battlePrepareStageActor.GetUIController().ShowProtect(true);
									battlePrepareStageActor.SetChooseEffect(false);
								}
								else
								{
									battlePrepareStageActor.SetChooseEffect(true);
								}
							}
							else
							{
								battlePrepareStageActor.SetChooseEffect(false);
							}
						}
					}
				}
				else if (battleRoom.BPStatus == BattleRoomBPStatus.Ban)
				{
					this.m_battlePrepareUIController.EnableHeroOnStage(false);
					int heroSetupFlagCount2 = battleRoom.GetHeroSetupFlagCount(battleRoom.MyPlayerIndex, SetupBattleHeroFlag.Ban);
					if (heroSetupFlagCount2 == 0)
					{
						this.m_pvpBattlePrepareUIController.ShowBanIndicator(1 - battleRoom.MyPlayerIndex);
						bool flag2 = this.m_selectBanHeroPos != GridPosition.Null;
						this.m_pvpBattlePrepareUIController.SetBanHeroCount((!flag2) ? 0 : 1);
						this.m_pvpBattlePrepareUIController.SetPrepareConfirmButtonState(flag2);
					}
					else
					{
						this.m_pvpBattlePrepareUIController.ShowWaitOpponent();
					}
					this.UpdateRealtimePVPBattlePrepareTimeout();
					foreach (BattlePrepareStageActor battlePrepareStageActor2 in this.m_battlePrepareUIController.GetStageActors())
					{
						this.UpdateStageActorTag(battlePrepareStageActor2);
						if (battlePrepareStageActor2.GetTeam() == 1)
						{
							if (heroSetupFlagCount2 == 0 && !battleRoom.IsHeroSetupHasFlag(battlePrepareStageActor2.GetPlayerIndex(), battlePrepareStageActor2.GetHeroId(), SetupBattleHeroFlag.Protect))
							{
								if (battlePrepareStageActor2.GetPosition() == this.m_selectBanHeroPos)
								{
									battlePrepareStageActor2.GetUIController().ShowBan(true);
									battlePrepareStageActor2.SetChooseEffect(false);
								}
								else
								{
									battlePrepareStageActor2.SetChooseEffect(true);
								}
							}
							else
							{
								battlePrepareStageActor2.SetChooseEffect(false);
							}
						}
						else
						{
							battlePrepareStageActor2.SetChooseEffect(false);
						}
					}
				}
				else if (battleRoom.BPStatus == BattleRoomBPStatus.Done)
				{
					this.m_battlePrepareUIController.EnableHeroOnStage(false);
					foreach (BattlePrepareStageActor battlePrepareStageActor3 in this.m_battlePrepareUIController.GetStageActors())
					{
						battlePrepareStageActor3.SetChooseEffect(false);
						this.UpdateStageActorTag(battlePrepareStageActor3);
					}
				}
			}
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x0033400C File Offset: 0x0033220C
		private void UpdateStageActorTag(BattlePrepareStageActor sa)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStageActorTagBattlePrepareStageActor_hotfix != null)
			{
				this.m_UpdateStageActorTagBattlePrepareStageActor_hotfix.call(new object[]
				{
					this,
					sa
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			int heroPos = battleRoom.BattleRoomPlayerHeroSetup.FindHeroPosition(sa.GetPlayerIndex(), sa.GetHeroId());
			BattleHeroSetupInfo battleHeroSetupInfo = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(heroPos);
			sa.GetUIController().ShowProtect(battleHeroSetupInfo != null && battleHeroSetupInfo.HasFlag(SetupBattleHeroFlag.Protect));
			sa.GetUIController().ShowBan(battleHeroSetupInfo != null && battleHeroSetupInfo.HasFlag(SetupBattleHeroFlag.Ban));
			sa.SetGray(battleRoom.BPStatus == BattleRoomBPStatus.Pick && battleHeroSetupInfo != null && battleHeroSetupInfo.HasFlag(SetupBattleHeroFlag.Picked));
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x00334100 File Offset: 0x00332300
		private void ProcessBattlePreparePendingNtfs(bool playFx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ProcessBattlePreparePendingNtfsBoolean_hotfix != null)
			{
				this.m_ProcessBattlePreparePendingNtfsBoolean_hotfix.call(new object[]
				{
					this,
					playFx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!UIUtility.IsLayerActive(this.m_battlePrepareUIController))
			{
				return;
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (battleRoom.BattleRoomStatus == BattleRoomStatus.Fighting)
			{
				this.BattleRoomBattleStart();
			}
			else if (this.m_pendingHeroSetupNtfs.Count > 0)
			{
				List<int> posList = new List<int>(this.m_pendingHeroSetupNtfs);
				this.m_pendingHeroSetupNtfs.Clear();
				this.LoadAndUpdateBattleRoomStageActors(posList, playFx);
			}
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x003341D8 File Offset: 0x003323D8
		private void LoadAndUpdateBattleRoomStageActors(List<int> posList, bool playFx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadAndUpdateBattleRoomStageActorsList`1Boolean_hotfix != null)
			{
				this.m_LoadAndUpdateBattleRoomStageActorsList`1Boolean_hotfix.call(new object[]
				{
					this,
					posList,
					playFx2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool playFx = playFx2;
			BattleUITask $this = this;
			if (posList.Count <= 0)
			{
				return;
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			base.ClearAssetList();
			List<PositionAndBattleHero> posAndHeros = new List<PositionAndBattleHero>();
			foreach (int num in posList)
			{
				BattleHeroSetupInfo battleHeroSetupInfo = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(num);
				if ((battleRoom.BattleRoomType != BattleRoomType.PVP && battleRoom.BattleRoomType != BattleRoomType.RealTimePVPDefaultMode) || battleHeroSetupInfo.PlayerIndex == battleRoom.MyPlayerIndex)
				{
					PositionAndBattleHero item = default(PositionAndBattleHero);
					item.Pos = num;
					item.Hero = battleHeroSetupInfo.Hero;
					posAndHeros.Add(item);
					if (battleHeroSetupInfo.Hero != null)
					{
						int team = 0;
						if (battleRoom.IsAnyPVPBattleRoomType() && battleHeroSetupInfo.PlayerIndex != battleRoom.MyPlayerIndex)
						{
							team = 1;
						}
						base.CollectAsset(UIUtility.GetHeroModelAssetPath(battleHeroSetupInfo.Hero));
						base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(battleHeroSetupInfo.Hero, team));
					}
				}
			}
			base.StartLoadCustomAssets(delegate
			{
				if (UIUtility.IsLayerActive($this.m_battlePrepareUIController))
				{
					foreach (PositionAndBattleHero positionAndBattleHero in posAndHeros)
					{
						$this.UpdateBattleRoomStageActors(positionAndBattleHero.Pos, positionAndBattleHero.Hero, playFx);
					}
					$this.UpdateRealtimePVPBattlePrepareStatus();
				}
			});
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x003343AC File Offset: 0x003325AC
		private void UpdateBattleRoomStageActors(int posIdx, BattleHero hero, bool playFx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattleRoomStageActorsInt32BattleHeroBoolean_hotfix != null)
			{
				this.m_UpdateBattleRoomStageActorsInt32BattleHeroBoolean_hotfix.call(new object[]
				{
					this,
					posIdx,
					hero,
					playFx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			BattleHeroSetupInfo battleHeroSetupInfo = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(posIdx);
			if (battleHeroSetupInfo == null)
			{
				return;
			}
			StagePositionType posType = StagePositionType.Me;
			GridPosition gridPosition = GridPosition.Null;
			int num = 0;
			int playerIndex = battleHeroSetupInfo.PlayerIndex;
			if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				num = 0;
				gridPosition = this.m_teamPositions0[posIdx];
				if (playerIndex == battleRoom.MyPlayerIndex)
				{
					posType = StagePositionType.Me;
				}
				else
				{
					posType = StagePositionType.Teammate;
				}
			}
			else if (battleRoom.IsAnyPVPBattleRoomType())
			{
				int index = battleRoom.BattleRoomPlayerHeroSetup.PVPRoomPositionToTeamPosition(playerIndex, posIdx);
				if (playerIndex == battleRoom.MyPlayerIndex)
				{
					num = 0;
					posType = StagePositionType.Me;
					gridPosition = this.m_teamPositions0[index];
				}
				else
				{
					num = 1;
					gridPosition = this.m_teamPositions1[index];
					posType = StagePositionType.Enemy;
				}
			}
			BattlePrepareStageActor stageActor = this.m_battlePrepareUIController.GetStageActor(gridPosition);
			if (hero != null)
			{
				StageActorTagType heroTagType = this.GetHeroTagType(hero);
				if (this.m_battlePrepareUIController.HeroOnStage(hero, gridPosition, num, posType, playerIndex, heroTagType) != stageActor)
				{
					if (playFx)
					{
						this.m_battleMapUIController.PlayOnStageFx(posType, gridPosition);
						AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
					}
					if (this.m_battlePrepareActorInfoUIController.IsOpened() && this.m_battlePrepareActorInfoUIController.GetHeroId() == hero.HeroId && this.m_battlePrepareActorInfoUIController.GetTeam() == num)
					{
						this.m_battlePrepareActorInfoUIController.SetActorInfo(hero, this.GetPlayerTrainingTechs(stageActor.GetTeam(), stageActor.GetPlayerIndex(), stageActor.IsNpc()), stageActor.GetTeam(), stageActor.IsNpc(), this.m_battlePrepareActorInfoUIController.CanChangeSoldier(), stageActor.GetExtraTalentSkillInfo(), stageActor.GetHeroHp(), stageActor.GetSoldierHp());
					}
				}
			}
			else if (stageActor != null)
			{
				this.m_battlePrepareUIController.ActorOffStage(stageActor);
			}
		}

		// Token: 0x0600B7AE RID: 47022 RVA: 0x003345F4 File Offset: 0x003327F4
		private void BattleRoomBattleStart()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleRoomBattleStart_hotfix != null)
			{
				this.m_BattleRoomBattleStart_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			this.m_pendingHeroSetupNtfs.Clear();
			this.m_battlePrepareUIController.SkipStageActorGraphic(true);
			for (int i = 0; i < battleRoom.BattleRoomPlayerHeroSetup.GetCount(); i++)
			{
				BattleHeroSetupInfo battleHeroSetupInfo = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(i);
				this.UpdateBattleRoomStageActors(i, battleHeroSetupInfo.Hero, false);
			}
			this.m_battlePrepareUIController.SkipStageActorGraphic(false);
			for (int j = 0; j < battleRoom.Players.Count; j++)
			{
				BattleRoomPlayer battleRoomPlayer = battleRoom.Players[j];
				bool isOffline = battleRoomPlayer.IsOffline;
				this.m_battleRoomUIController.SetPlayerStatus(j, battleRoomPlayer.PlayerBattleStatus, battleRoomPlayer.IsOffline);
			}
			this.BuildBattleTeamSetups();
			this.StartBattleLoadState();
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x00334718 File Offset: 0x00332918
		private void PVPBattlePrepareUIController_OnPrepareConfirm()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PVPBattlePrepareUIController_OnPrepareConfirm_hotfix != null)
			{
				this.m_PVPBattlePrepareUIController_OnPrepareConfirm_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (battleRoom.BPStatus == BattleRoomBPStatus.Pick)
			{
				this.StartBattleRoomEndCurrentBPTurnNetTask(delegate
				{
				});
			}
			else if (battleRoom.BPStatus == BattleRoomBPStatus.Protect)
			{
				int num = this.m_teamPositions0.IndexOf(this.m_selectProtectHeroPos);
				if (num >= 0)
				{
					num = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(battleRoom.MyPlayerIndex, num);
					BattleRoomHeroProtectNetTask battleRoomHeroProtectNetTask = new BattleRoomHeroProtectNetTask(num);
					battleRoomHeroProtectNetTask.EventOnStop += delegate(Task task)
					{
						BattleRoomHeroProtectNetTask battleRoomHeroProtectNetTask2 = task as BattleRoomHeroProtectNetTask;
						if (battleRoomHeroProtectNetTask2.Result == 0)
						{
							this.StartBattleRoomEndCurrentBPTurnNetTask(delegate
							{
							});
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(battleRoomHeroProtectNetTask2.Result, 2f, null, true);
						}
					};
					battleRoomHeroProtectNetTask.Start(null);
				}
			}
			else if (battleRoom.BPStatus == BattleRoomBPStatus.Ban)
			{
				int num2 = this.m_teamPositions1.IndexOf(this.m_selectBanHeroPos);
				if (num2 >= 0)
				{
					num2 = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(1 - battleRoom.MyPlayerIndex, num2);
					BattleRoomHeroBanNetTask battleRoomHeroBanNetTask = new BattleRoomHeroBanNetTask(num2);
					battleRoomHeroBanNetTask.EventOnStop += delegate(Task task)
					{
						BattleRoomHeroBanNetTask battleRoomHeroBanNetTask2 = task as BattleRoomHeroBanNetTask;
						if (battleRoomHeroBanNetTask2.Result == 0)
						{
							this.StartBattleRoomEndCurrentBPTurnNetTask(delegate
							{
							});
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(battleRoomHeroBanNetTask2.Result, 2f, null, true);
						}
					};
					battleRoomHeroBanNetTask.Start(null);
				}
			}
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x00334878 File Offset: 0x00332A78
		private void PlayerContext_OnBattleRoomHeroSetupNtf(List<int> posList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomHeroSetupNtfList`1_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomHeroSetupNtfList`1_hotfix.call(new object[]
				{
					this,
					posList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int item in posList)
			{
				if (!this.m_pendingHeroSetupNtfs.Contains(item))
				{
					this.m_pendingHeroSetupNtfs.Add(item);
				}
			}
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x00334948 File Offset: 0x00332B48
		private void PlayerContext_OnBattleRoomDataChangeNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomDataChangeNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomDataChangeNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateRealtimePVPBattlePrepareStatus();
			this.ShowStagePositions();
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x003349B4 File Offset: 0x00332BB4
		private void PlayerContext_OnBattleRoomTeamBattleStartNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomTeamBattleStartNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomTeamBattleStartNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsPipeLineRunning())
			{
				return;
			}
			this.BattleRoomBattleStart();
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x00334A28 File Offset: 0x00332C28
		private void PlayerContext_OnBattleRoomPVPBattleStartNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomPVPBattleStartNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomPVPBattleStartNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsPipeLineRunning())
			{
				return;
			}
			this.BattleRoomBattleStart();
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x00334A9C File Offset: 0x00332C9C
		private void PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BattlePrepareUIController_OnHideActorInfo();
			this.m_pvpBattlePrepareUIController.ShowPrepareCompleteCountdown(delegate
			{
				this.m_clientBattle.BattleCamera.SetOrthographicSize((float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_CameraSize) * 0.01f);
				this.PlayerContext_OnBattleRoomTeamBattleStartNtf();
			});
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x00334B1C File Offset: 0x00332D1C
		private void ShowBattleResult(BattleType battleType, int stars, BattleReward battleReward, bool isFirstWin, List<int> gotAchievements, BattleLevelAchievement[] achievements)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleResultBattleTypeInt32BattleRewardBooleanList`1BattleLevelAchievementbe_hotfix != null)
			{
				this.m_ShowBattleResultBattleTypeInt32BattleRewardBooleanList`1BattleLevelAchievementbe_hotfix.call(new object[]
				{
					this,
					battleType,
					stars,
					battleReward,
					isFirstWin,
					gotAchievements,
					achievements
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
			{
				BattleResultScoreUITask battleResultScoreUITask = BattleResultScoreUITask.StartUITask(battleReward);
				if (this.m_battleResultScoreUITask == null)
				{
					this.m_battleResultScoreUITask = battleResultScoreUITask;
					this.m_battleResultScoreUITask.EventOnStop += this.BattleResultScoreUITask_OnStop;
					this.m_battleResultScoreUITask.EventOnClose += this.BattleResultScoreUITask_OnClose;
				}
			}
			else
			{
				int starTurnMax;
				int starDeadMax;
				projectLPlayerContext.Happening.GetStarCondition(out starTurnMax, out starDeadMax);
				BattleResultUITask battleResultUITask = BattleResultUITask.StartUITask(battleType, this.m_myBattleHeroIds, stars, starTurnMax, starDeadMax, this.m_battleStopTurn, battleReward, isFirstWin, gotAchievements, achievements);
				if (this.m_battleResultUITask == null)
				{
					this.m_battleResultUITask = battleResultUITask;
					this.m_battleResultUITask.EventOnStop += this.BattleResultUITask_OnStop;
					this.m_battleResultUITask.EventOnClose += this.BattleResultUITask_OnClose;
				}
			}
			if (projectLPlayerContext.Happening.RiftLevelInfo != null && projectLPlayerContext.Happening.RiftLevelInfo.ID == 104 && this.m_configDataLoader.ConfigableConstId_IsRequestAppReviewOn > 0)
			{
				AppScoreUITask.ShowAppScoreUI(this.m_currIntent);
			}
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x00334CFC File Offset: 0x00332EFC
		private void ShowBattleLose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleLose_hotfix != null)
			{
				this.m_ShowBattleLose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleLoseUITask battleLoseUITask = BattleLoseUITask.StartUITask();
			if (this.m_battleLoseUITask == null)
			{
				this.m_battleLoseUITask = battleLoseUITask;
				this.m_battleLoseUITask.EventOnStop += this.BattleLoseUITask_OnStop;
				this.m_battleLoseUITask.EventOnClose += this.BattleLoseUITask_OnClose;
			}
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x00334DA4 File Offset: 0x00332FA4
		private void ShowBattleReportEnd(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleReportEndArenaBattleReport_hotfix != null)
			{
				this.m_ShowBattleReportEndArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleReportEndUITask battleReportEndUITask = BattleReportEndUITask.StartUITask(battleReport);
			if (this.m_battleReportEndUITask == null)
			{
				this.m_battleReportEndUITask = battleReportEndUITask;
				this.m_battleReportEndUITask.EventOnStop += this.BattleReportEndUITask_OnStop;
				this.m_battleReportEndUITask.EventOnClose += this.BattleReportEndUITask_OnClose;
				this.m_battleReportEndUITask.EventOnPlayAgain += this.BattleReportEndUITask_OnPlayAgain;
			}
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x00334E74 File Offset: 0x00333074
		private void ShowBattleReportEnd(RealTimePVPBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleReportEndRealTimePVPBattleReport_hotfix != null)
			{
				this.m_ShowBattleReportEndRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleReportEndUITask battleReportEndUITask = BattleReportEndUITask.StartUITask(battleReport);
			if (this.m_battleReportEndUITask == null)
			{
				this.m_battleReportEndUITask = battleReportEndUITask;
				this.m_battleReportEndUITask.EventOnStop += this.BattleReportEndUITask_OnStop;
				this.m_battleReportEndUITask.EventOnClose += this.BattleReportEndUITask_OnClose;
				this.m_battleReportEndUITask.EventOnPlayAgain += this.BattleReportEndUITask_OnPlayAgain;
			}
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x00334F44 File Offset: 0x00333144
		private ProBattleReport BuildBattleReport()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuildBattleReport_hotfix != null)
			{
				return (ProBattleReport)this.m_BuildBattleReport_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProBattleReport proBattleReport = new ProBattleReport();
			LinkedList<BattleCommand> logBattleCommands = this.m_clientBattle.Battle.GetLogBattleCommands();
			foreach (BattleCommand battleCommand in logBattleCommands)
			{
				proBattleReport.MineCommands.Add(BattleCommand.BattleCommandToPBBattleCommand(battleCommand));
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsNeedBattleReportLog)
			{
				CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
				BattleReportLog battleReportLog = new BattleReportLog();
				battleReportLog.UserId = projectLPlayerContext.GetUserId();
				battleReportLog.PlayerName = projectLPlayerContext.GetPlayerName();
				battleReportLog.Type = currentBattle.BattleType;
				if (battleReportLog.Type == BattleType.Scenario)
				{
					battleReportLog.Type = BattleType.WayPoint;
				}
				if (currentBattle.BattleInfo != null)
				{
					battleReportLog.BattleId = currentBattle.BattleInfo.ID;
				}
				else if (currentBattle.ArenaBattleInfo != null)
				{
					battleReportLog.BattleId = currentBattle.ArenaBattleInfo.ID;
				}
				else if (currentBattle.PVPBattleInfo != null)
				{
					battleReportLog.BattleId = currentBattle.PVPBattleInfo.ID;
				}
				else if (currentBattle.RealTimePVPBattleInfo != null)
				{
					battleReportLog.BattleId = currentBattle.RealTimePVPBattleInfo.ID;
				}
				if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
				{
					battleReportLog.RandomNumberSeed = projectLPlayerContext.GetArenaBattleRandomSeed();
				}
				else
				{
					battleReportLog.RandomNumberSeed = projectLPlayerContext.GetBattleRandomSeed();
					battleReportLog.ArmyRandomNumberSeed = projectLPlayerContext.GetBattleArmyRandomSeed();
				}
				battleReportLog.MineTeam = this.GetBattleTeamSetup(0).m_actors;
				battleReportLog.OpponentTeam = this.GetBattleTeamSetup(1).m_actors;
				battleReportLog.Players = new List<BattlePlayer>();
				if (this.m_clientBattle.Battle.BattlePlayers != null)
				{
					battleReportLog.Players.AddRange(this.m_clientBattle.Battle.BattlePlayers);
				}
				battleReportLog.MineCommands = new List<BattleCommand>(logBattleCommands);
				battleReportLog.CheckSums = this.m_clientBattle.Battle.GetChecksums();
				proBattleReport.BattleTeamsSetupLog = CommonReportLog.BattleReport(battleReportLog, "Client");
			}
			return proBattleReport;
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x003351EC File Offset: 0x003333EC
		private bool CheckBattleResult()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckBattleResult_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckBattleResult_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<int> list = new List<int>(this.m_clientBattle.Battle.GetChecksums());
			List<BattleCommand> commands = new List<BattleCommand>(this.m_clientBattle.Battle.GetLogBattleCommands());
			BattleBase battleBase = new BattleBase(this.m_configDataLoader, new NullBattleListener());
			battleBase.EnableChecksum(true);
			BattlePlayer[] battlePlayers = this.m_clientBattle.Battle.BattlePlayers;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			if (currentBattle.BattleInfo != null)
			{
				int monsterLevel = projectLPlayerContext.Happening.MonsterLevel;
				int starTurnMax;
				int starDeadMax;
				projectLPlayerContext.Happening.GetStarCondition(out starTurnMax, out starDeadMax);
				List<ConfigDataBattleAchievementRelatedInfo> list2 = null;
				BattleLevelAchievement[] battleLevelAchievements = projectLPlayerContext.Happening.GetBattleLevelAchievements();
				if (battleLevelAchievements != null)
				{
					list2 = new List<ConfigDataBattleAchievementRelatedInfo>();
					foreach (BattleLevelAchievement battleLevelAchievement in battleLevelAchievements)
					{
						list2.Add(battleLevelAchievement.m_achievementRelatedInfo);
					}
				}
				battleBase.CreateMap(currentBattle.BattleInfo.m_battlefieldInfo);
				battleBase.InitBattleReport(currentBattle.BattleInfo, currentBattle.BattleType, this.GetBattleTeamSetup(0), this.GetBattleTeamSetup(1), battlePlayers, projectLPlayerContext.GetBattleRandomSeed(), projectLPlayerContext.GetBattleArmyRandomSeed(), monsterLevel, commands);
				battleBase.InitStarAndAchievement(starTurnMax, starDeadMax, list2);
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				battleBase.CreateMap(currentBattle.ArenaBattleInfo.m_battlefieldInfo);
				battleBase.InitArenaBattleReport(currentBattle.ArenaBattleInfo, this.GetBattleTeamSetup(0), this.GetBattleTeamSetup(1), battlePlayers, projectLPlayerContext.GetArenaBattleRandomSeed(), currentBattle.ArenaDefendRuleInfo, commands);
			}
			else if (currentBattle.PVPBattleInfo != null)
			{
				battleBase.CreateMap(currentBattle.PVPBattleInfo.m_battlefieldInfo);
				int myPlayerIndex = this.GetMyPlayerIndex();
				battleBase.InitPVPBattleReport(currentBattle.PVPBattleInfo, this.GetBattleTeamSetup(myPlayerIndex), this.GetBattleTeamSetup(1 - myPlayerIndex), battlePlayers, projectLPlayerContext.GetBattleRandomSeed(), commands);
			}
			else if (currentBattle.RealTimePVPBattleInfo != null)
			{
				battleBase.CreateMap(currentBattle.RealTimePVPBattleInfo.m_battlefieldInfo);
				int myPlayerIndex2 = this.GetMyPlayerIndex();
				battleBase.InitRealTimePVPBattleReport(currentBattle.RealTimePVPBattleInfo, this.GetBattleTeamSetup(myPlayerIndex2), this.GetBattleTeamSetup(1 - myPlayerIndex2), battlePlayers, projectLPlayerContext.GetBattleRandomSeed(), commands);
			}
			bool flag = !battleBase.Run(true);
			List<int> checksums = battleBase.GetChecksums();
			if (list.Count == checksums.Count)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j] != checksums[j])
					{
						flag = true;
						break;
					}
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				CommonUIController.Instance.ShowMessage("Battle check error", 10f, null, true);
				global::Debug.LogWarning(string.Format("Battle check error. RandomSeed {0}, ArmyRandomSeed {1}", projectLPlayerContext.GetBattleRandomSeed(), projectLPlayerContext.GetBattleArmyRandomSeed()));
			}
			return !flag;
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x0033553C File Offset: 0x0033373C
		private void SendBattleCheatGMCommand(bool isCheat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendBattleCheatGMCommandBoolean_hotfix != null)
			{
				this.m_SendBattleCheatGMCommandBoolean_hotfix.call(new object[]
				{
					this,
					isCheat
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string cmd = "BATTLE_CHEAT " + ((!isCheat) ? " 0" : "1");
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x003355DC File Offset: 0x003337DC
		private void BattleResultEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultEnd_hotfix != null)
			{
				this.m_BattleResultEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null && battleRoom.BattleRoomType == BattleRoomType.Team && battleRoom.LeaderPlayerIndex == battleRoom.MyPlayerIndex && projectLPlayerContext.GetTeamRoom() != null)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Team_InviteTeammateAgain, new Action<DialogBoxResult>(this.BattleRoomInviteTeammateDialogBoxCallback), (StringTableId)0, (StringTableId)0);
			}
			else
			{
				projectLPlayerContext.SetTeamRoomInviteAgain(false);
				this.ExitBattleReturnToWorld();
			}
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x003356B0 File Offset: 0x003338B0
		private void BattleRoomInviteTeammateDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleRoomInviteTeammateDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_BattleRoomInviteTeammateDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (r == DialogBoxResult.Ok)
			{
				projectLPlayerContext.SetTeamRoomInviteAgain(true);
			}
			else
			{
				projectLPlayerContext.SetTeamRoomInviteAgain(false);
			}
			this.ExitBattleReturnToWorld();
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x00335750 File Offset: 0x00333950
		private void BattleUIController_OnWinOrLoseEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnWinOrLoseEnd_hotfix != null)
			{
				this.m_BattleUIController_OnWinOrLoseEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.State != ClientBattleState.Stop)
			{
				return;
			}
			global::Debug.Log("BattleUITask.BattleUIController_OnWinOrLoseEnd");
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				if (battleRoom.BattleReward != null)
				{
					if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
					{
						this.HandleBattleFinishedNetTaskResult(0, battleRoom.BattleStars > 0, battleRoom.BattleReward, 0, false, null, null);
					}
					else if (battleRoom.BattleRoomType == BattleRoomType.PVP)
					{
						this.ExitBattleReturnToWorld();
					}
					else if (battleRoom.IsRealTimePVPBattleRoomType())
					{
						bool isWin = battleRoom.FindPlayerIndexBySessiongId(battleRoom.PVPWinSessionId) == battleRoom.MyPlayerIndex;
						this.HandleBattleFinishedNetTaskResult(0, isWin, battleRoom.BattleReward, 0, false, null, null);
					}
				}
				else
				{
					global::Debug.LogError("Do not receive BattleRoomXXXBattleFinishNtf, ExitBattleReturnToWorld");
					BattleRoomQuitNetTask battleRoomQuitNetTask = new BattleRoomQuitNetTask();
					battleRoomQuitNetTask.Start(null);
					this.ExitBattleReturnToWorld();
				}
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
			{
				this.ExitBattleReturnToWorld();
			}
			else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				this.ExitBattleReturnToWorld();
			}
			else if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				if (projectLPlayerContext.Happening.Step == HappeningStep.Battle)
				{
					if (projectLPlayerContext.Happening.WaypointInfo != null)
					{
						this.StartWayPointBattleFinishedNetTask(projectLPlayerContext.Happening.WaypointInfo);
					}
					else if (projectLPlayerContext.Happening.RiftLevelInfo != null)
					{
						this.StartRiftLevelBattleFinishedNetTask(projectLPlayerContext.Happening.RiftLevelInfo);
					}
					else if (projectLPlayerContext.Happening.HeroDungeonLevelInfo != null)
					{
						this.StartHeroDungeonLevelBattleFinishedNetTask(projectLPlayerContext.Happening.HeroDungeonLevelInfo);
					}
					else if (projectLPlayerContext.Happening.ThearchyLevelInfo != null)
					{
						this.StartThearchyLevelBattleFinishedNetTask(projectLPlayerContext.Happening.ThearchyLevelInfo);
					}
					else if (projectLPlayerContext.Happening.AnikiLevelInfo != null)
					{
						this.StartAnikiLevelBattleFinishedNetTask(projectLPlayerContext.Happening.AnikiLevelInfo);
					}
					else if (projectLPlayerContext.Happening.TreasureLevelInfo != null)
					{
						this.StartTreasureLevelBattleFinishedNetTask(projectLPlayerContext.Happening.TreasureLevelInfo);
					}
					else if (projectLPlayerContext.Happening.MemoryCorridorLevelInfo != null)
					{
						this.StartMemoryCorridorLevelBattleFinishedNetTask(projectLPlayerContext.Happening.MemoryCorridorLevelInfo);
					}
					else if (projectLPlayerContext.Happening.HeroTrainningLevelInfo != null)
					{
						this.StartHeroTrainningLevelBattleFinishedNetTask(projectLPlayerContext.Happening.HeroTrainningLevelInfo);
					}
					else if (projectLPlayerContext.Happening.HeroPhantomLevelInfo != null)
					{
						this.StartHeroPhantomLevelBattleFinishedNetTask(projectLPlayerContext.Happening.HeroPhantomLevelInfo);
					}
					else if (projectLPlayerContext.Happening.ScoreLevelInfo != null)
					{
						this.StartUnchartedScoreLevelBattleFinishedNetTask(projectLPlayerContext.Happening.ScoreLevelInfo);
					}
					else if (projectLPlayerContext.Happening.ChallengeLevelInfo != null)
					{
						this.StartUnchartedChallengeLevelBattleFinishedNetTask(projectLPlayerContext.Happening.ChallengeLevelInfo);
					}
					else if (projectLPlayerContext.Happening.TowerFloorInfo != null)
					{
						this.StartClimbTowerLevelBattleFinishedNetTask(projectLPlayerContext.Happening.TowerFloorInfo);
					}
					else if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
					{
						this.StartGuildMassiveCombatSinglePVEBattleEndNetTask(projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo);
					}
				}
				else
				{
					this.ExitBattleReturnToWorld();
				}
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				this.StartArenaBattleFinishedNetTask();
			}
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x00335AF8 File Offset: 0x00333CF8
		private void BattleResultUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultUITask_OnStopTask_hotfix != null)
			{
				this.m_BattleResultUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleResultUITask == task)
			{
				this.m_battleResultUITask.EventOnStop -= this.BattleResultUITask_OnStop;
				this.m_battleResultUITask.EventOnClose -= this.BattleResultUITask_OnClose;
				this.m_battleResultUITask = null;
			}
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x00335BAC File Offset: 0x00333DAC
		private void BattleResultUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultUITask_OnClose_hotfix != null)
			{
				this.m_BattleResultUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleResultUITask != null)
			{
				this.BattleResultUITask_OnStop(this.m_battleResultUITask);
			}
			this.BattleResultEnd();
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x00335C2C File Offset: 0x00333E2C
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

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x00335CE0 File Offset: 0x00333EE0
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
			this.BattleResultEnd();
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x00335D60 File Offset: 0x00333F60
		private void BattleLoseUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLoseUITask_OnStopTask_hotfix != null)
			{
				this.m_BattleLoseUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleLoseUITask == task)
			{
				this.m_battleLoseUITask.EventOnStop -= this.BattleLoseUITask_OnStop;
				this.m_battleLoseUITask.EventOnClose -= this.BattleLoseUITask_OnClose;
				this.m_battleLoseUITask = null;
			}
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x00335E14 File Offset: 0x00334014
		private void BattleLoseUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLoseUITask_OnClose_hotfix != null)
			{
				this.m_BattleLoseUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleLoseUITask != null)
			{
				this.BattleLoseUITask_OnStop(this.m_battleLoseUITask);
			}
			this.BattleResultEnd();
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x00335E94 File Offset: 0x00334094
		private void BattleReportEndUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleReportEndUITask_OnStopTask_hotfix != null)
			{
				this.m_BattleReportEndUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleReportEndUITask == task)
			{
				this.m_battleReportEndUITask.EventOnStop -= this.BattleReportEndUITask_OnStop;
				this.m_battleReportEndUITask.EventOnClose -= this.BattleReportEndUITask_OnClose;
				this.m_battleReportEndUITask.EventOnPlayAgain -= this.BattleReportEndUITask_OnPlayAgain;
				this.m_battleReportEndUITask = null;
			}
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x00335F5C File Offset: 0x0033415C
		private void BattleReportEndUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleReportEndUITask_OnClose_hotfix != null)
			{
				this.m_BattleReportEndUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleReportEndUITask != null)
			{
				this.BattleReportEndUITask_OnStop(this.m_battleReportEndUITask);
			}
			this.ExitBattleReturnToWorld();
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x00335FDC File Offset: 0x003341DC
		private void BattleReportEndUITask_OnPlayAgain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleReportEndUITask_OnPlayAgain_hotfix != null)
			{
				this.m_BattleReportEndUITask_OnPlayAgain_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleReportEndUITask != null)
			{
				this.BattleReportEndUITask_OnStop(this.m_battleReportEndUITask);
			}
			this.PrepareClientBattle(false);
			this.StartClientBattle();
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x00336060 File Offset: 0x00334260
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
				projectLPlayerContext.EventOnChatMessageNtf += this.PlayerContext_OnChatMessageNtf;
				projectLPlayerContext.EventOnTeamRoomInviteNtf += this.PlayerContext_OnTeamRoomInviteNtf;
				projectLPlayerContext.EventOnBattlePracticeInvitedNtf += this.PlayerContext_OnBattlePracticeInvitedNtf;
				projectLPlayerContext.EventOnBattleRoomPlayerStatusChangedNtf += this.PlayerContext_OnBattleRoomPlayerStatusChangedNtf;
				projectLPlayerContext.EventOnBattleRoomPlayerQuitNtf += this.PlayerContext_OnBattleRoomPlayerQuitNtf;
				projectLPlayerContext.EventOnBattleRoomHeroSetupNtf += this.PlayerContext_OnBattleRoomHeroSetupNtf;
				projectLPlayerContext.EventOnBattleRoomDataChangeNtf += this.PlayerContext_OnBattleRoomDataChangeNtf;
				projectLPlayerContext.EventOnBattleRoomTeamBattleStartNtf += this.PlayerContext_OnBattleRoomTeamBattleStartNtf;
				projectLPlayerContext.EventOnBattleRoomPVPBattleStartNtf += this.PlayerContext_OnBattleRoomPVPBattleStartNtf;
				projectLPlayerContext.EventOnBattleRoomRealTimePVPBattleStartNtf += this.PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf;
				projectLPlayerContext.EventOnBattleRoomBattleCommandExecuteNtf += this.PlayerContext_OnBattleRoomBattleCommandExecuteNtf;
				projectLPlayerContext.EventOnBattleRoomTeamBattleFinishNtf += this.PlayerContext_OnBattleRoomTeamBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomPVPBattleFinishNtf += this.PlayerContext_OnBattleRoomPVPBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomRealTimePVPBattleFinishNtf += this.PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomGuildMassiveCombatBattleFinishNtf += this.PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomPVPBattleJoinNtf += this.PlayerContext_OnBattleRoomPVPBattleJoinNtf;
				if (this.m_isStartInBattleRoom)
				{
					projectLPlayerContext.EventOnPlayerInfoInitEnd += this.PlayerContext_OnPlayerInfoInitEnd;
				}
			}
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x0033621C File Offset: 0x0033441C
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
				projectLPlayerContext.EventOnChatMessageNtf -= this.PlayerContext_OnChatMessageNtf;
				projectLPlayerContext.EventOnTeamRoomInviteNtf -= this.PlayerContext_OnTeamRoomInviteNtf;
				projectLPlayerContext.EventOnBattlePracticeInvitedNtf -= this.PlayerContext_OnBattlePracticeInvitedNtf;
				projectLPlayerContext.EventOnBattleRoomPlayerStatusChangedNtf -= this.PlayerContext_OnBattleRoomPlayerStatusChangedNtf;
				projectLPlayerContext.EventOnBattleRoomPlayerQuitNtf -= this.PlayerContext_OnBattleRoomPlayerQuitNtf;
				projectLPlayerContext.EventOnBattleRoomHeroSetupNtf -= this.PlayerContext_OnBattleRoomHeroSetupNtf;
				projectLPlayerContext.EventOnBattleRoomDataChangeNtf -= this.PlayerContext_OnBattleRoomDataChangeNtf;
				projectLPlayerContext.EventOnBattleRoomTeamBattleStartNtf -= this.PlayerContext_OnBattleRoomTeamBattleStartNtf;
				projectLPlayerContext.EventOnBattleRoomPVPBattleStartNtf -= this.PlayerContext_OnBattleRoomPVPBattleStartNtf;
				projectLPlayerContext.EventOnBattleRoomRealTimePVPBattleStartNtf -= this.PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf;
				projectLPlayerContext.EventOnBattleRoomBattleCommandExecuteNtf -= this.PlayerContext_OnBattleRoomBattleCommandExecuteNtf;
				projectLPlayerContext.EventOnBattleRoomTeamBattleFinishNtf -= this.PlayerContext_OnBattleRoomTeamBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomPVPBattleFinishNtf -= this.PlayerContext_OnBattleRoomPVPBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomRealTimePVPBattleFinishNtf -= this.PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomGuildMassiveCombatBattleFinishNtf -= this.PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf;
				projectLPlayerContext.EventOnBattleRoomPVPBattleJoinNtf -= this.PlayerContext_OnBattleRoomPVPBattleJoinNtf;
				if (this.m_isStartInBattleRoom)
				{
					projectLPlayerContext.EventOnPlayerInfoInitEnd -= this.PlayerContext_OnPlayerInfoInitEnd;
				}
			}
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x003363D8 File Offset: 0x003345D8
		private void InitBattleSceneUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleSceneUIController_hotfix != null)
			{
				this.m_InitBattleSceneUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = Utility.FindChildGameObject(this.MainLayer.LayerPrefabRoot, "Battle", true);
			GameObject go2 = Utility.FindChildGameObject(this.MainLayer.LayerPrefabRoot, "Combat", true);
			if (this.m_battleMapUIController == null)
			{
				this.m_battleMapUIController = GameObjectUtility.AddControllerToGameObject<BattleMapUIController>(Utility.FindChildGameObject(this.MainLayer.LayerPrefabRoot, "Map", true));
				this.m_battleMapUIController.Initialize(this.m_clientBattle);
			}
			if (this.m_battleSceneUIController == null)
			{
				this.m_battleSceneUIController = GameObjectUtility.AddControllerToGameObject<BattleSceneUIController>(Utility.FindChildGameObject(go, "Canvas", true));
				this.m_battleSceneUIController.Initialize(this.m_clientBattle, this.m_battleMapUIController);
				this.m_battleSceneUIController.EventOnPointerDown += this.BattleSceneUIController_OnPointerDown;
				this.m_battleSceneUIController.EventOnPointerUp += this.BattleSceneUIController_OnPointerUp;
				this.m_battleSceneUIController.EventOnPointerClick += this.BattleSceneUIController_OnPointerClick;
				this.m_battleSceneUIController.EventOnBeginDrag += this.BattleSceneUIController_OnBeginDrag;
				this.m_battleSceneUIController.EventOnEndDrag += this.BattleSceneUIController_OnEndDrag;
				this.m_battleSceneUIController.EventOnDrag += this.BattleSceneUIController_OnDrag;
				this.m_battleSceneUIController.EventOn3DTouch += this.BattleSceneUIController_On3DTouch;
			}
			if (this.m_combatSceneUIController == null)
			{
				this.m_combatSceneUIController = GameObjectUtility.AddControllerToGameObject<CombatSceneUIController>(Utility.FindChildGameObject(go2, "Canvas", true));
				this.m_combatSceneUIController.Initialize();
			}
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x003365BC File Offset: 0x003347BC
		private void UninitBattleSceneUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitBattleSceneUIController_hotfix != null)
			{
				this.m_UninitBattleSceneUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleMapUIController != null)
			{
				this.m_battleMapUIController = null;
			}
			if (this.m_battleSceneUIController != null)
			{
				this.m_battleSceneUIController.EventOnPointerDown -= this.BattleSceneUIController_OnPointerDown;
				this.m_battleSceneUIController.EventOnPointerUp -= this.BattleSceneUIController_OnPointerUp;
				this.m_battleSceneUIController.EventOnPointerClick -= this.BattleSceneUIController_OnPointerClick;
				this.m_battleSceneUIController.EventOnBeginDrag -= this.BattleSceneUIController_OnBeginDrag;
				this.m_battleSceneUIController.EventOnEndDrag -= this.BattleSceneUIController_OnEndDrag;
				this.m_battleSceneUIController.EventOnDrag -= this.BattleSceneUIController_OnDrag;
				this.m_battleSceneUIController.EventOn3DTouch -= this.BattleSceneUIController_On3DTouch;
				this.m_battleSceneUIController = null;
			}
			if (this.m_combatSceneUIController != null)
			{
				this.m_combatSceneUIController = null;
			}
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x00336708 File Offset: 0x00334908
		private void InitBattleUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleUIController_hotfix != null)
			{
				this.m_InitBattleUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 2)
				{
					this.m_battleUIController = (this.m_uiCtrlArray[2] as BattleUIController);
				}
				if (this.m_battleUIController != null)
				{
					this.m_battleUIController.EventOnPauseBattle += this.BattleUIController_OnPauseBattle;
					this.m_battleUIController.EventOnShowArmyRelation += this.BattleUIController_OnShowArmyRelation;
					this.m_battleUIController.EventOnAutoBattle += this.BattleUIController_OnAutoBattle;
					this.m_battleUIController.EventOnFastBattle += this.BattleUIController_OnFastBattle;
					this.m_battleUIController.EventOnSkipCombat += this.BattleUIController_OnSkipCombat;
					this.m_battleUIController.EventOnShowDanger += this.BattleUIController_OnShowDanger;
					this.m_battleUIController.EventOnEndAllAction += this.BattleUIController_OnEndAllAction;
					this.m_battleUIController.EventOnEndAction += this.BattleUIController_OnEndAction;
					this.m_battleUIController.EventOnShowActorInfo += this.BattleUIController_OnShowActorInfo;
					this.m_battleUIController.EventOnSelectSkill += this.BattleUIController_OnSelectSkill;
					this.m_battleUIController.EventOnUseSkill += this.BattleUIController_OnUseSkill;
					this.m_battleUIController.EventOnCancelSkill += this.BattleUIController_OnCancelSkill;
					this.m_battleUIController.EventOnShowChat += this.BattleUIController_OnShowChat;
					this.m_battleUIController.EventOnShowHelp += this.BattleUIController_OnShowHelp;
					this.m_battleUIController.EventOnPointerDown += this.BattleUIController_OnPointerDown;
					this.m_battleUIController.EventOnPointerUp += this.BattleUIController_OnPointerUp;
					this.m_battleUIController.EventOnPointerClick += this.BattleUIController_OnPointerClick;
					this.m_battleUIController.EventOn3DTouch += this.BattleUIController_On3DTouch;
					this.m_battleUIController.EventOnWinOrLoseEnd += this.BattleUIController_OnWinOrLoseEnd;
					this.m_battleUIController.EventOnShowCurTurnDanmaku += this.BattleUIController_OnShowCurTurnDanmaku;
					this.m_battleUIController.EventOnCloseCurTurnDanmaku += this.BattleUIController_OnCloseCurTurnDanmaku;
					this.m_battleUIController.EventOnShowOneDanmaku += this.BattleUIController_OnShowOneDanmaku;
					this.m_battleUIController.EventOnRegretActive += this.BattleUIController_OnRegretActive;
					this.m_battleUIController.EventOnRegretConfirm += this.BattleUIController_OnRegretConfirm;
					this.m_battleUIController.EventOnRegretCancel += this.BattleUIController_OnRegretCancel;
					this.m_battleUIController.EventOnRegretBackward += this.BattleUIController_OnRegretBackward;
					this.m_battleUIController.EventOnRegretForward += this.BattleUIController_OnRegretForward;
				}
				else
				{
					global::Debug.LogError("BattleUIController is null");
				}
				CommonUIController.Instance.TestUI.EventOnExitBattle += this.TestUI_ExitBattle;
				CommonUIController.Instance.TestUI.EventOnRestartBattle += this.TestUI_RestartBattle;
				CommonUIController.Instance.TestUI.EventOnReplayBattle += this.TestUI_ReplayBattle;
				CommonUIController.Instance.TestUI.EventOnStopBattle += this.TestUI_StopBattle;
			}
			if (this.m_battleDanmakuUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 0)
				{
					this.m_battleDanmakuUIController = (this.m_uiCtrlArray[0] as BattleDanmakuUIController);
				}
				if (!(this.m_battleDanmakuUIController != null))
				{
					global::Debug.LogError("BattleActorInfoUIController is null");
				}
			}
			if (this.m_battleActorInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 3)
				{
					this.m_battleActorInfoUIController = (this.m_uiCtrlArray[3] as BattleActorInfoUIController);
				}
				if (!(this.m_battleActorInfoUIController != null))
				{
					global::Debug.LogError("BattleActorInfoUIController is null");
				}
			}
			if (this.m_battlePauseUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 8)
				{
					this.m_battlePauseUIController = (this.m_uiCtrlArray[8] as BattlePauseUIController);
				}
				if (this.m_battlePauseUIController != null)
				{
					this.m_battlePauseUIController.EventOnExit += this.BattlePauseUIController_OnExit;
					this.m_battlePauseUIController.EventOnClose += this.BattlePauseUIController_OnClose;
					this.m_battlePauseUIController.EventOnShowPlayerSetting += this.BattlePauseUIController_OnShowPlayerSetting;
				}
				else
				{
					global::Debug.LogError("BattlePauseUIController is null");
				}
			}
			if (this.m_battleTreasureDialogUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 9)
				{
					this.m_battleTreasureDialogUIController = (this.m_uiCtrlArray[9] as BattleTreasureDialogUIController);
				}
				if (this.m_battleTreasureDialogUIController != null)
				{
					this.m_battleTreasureDialogUIController.EventOnClose += this.BattleTreasureDialogUIController_OnClose;
				}
				else
				{
					global::Debug.LogError("BattleTreasureDialogUIController is null");
				}
			}
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x00336C3C File Offset: 0x00334E3C
		private void UninitBattleUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitBattleUIController_hotfix != null)
			{
				this.m_UninitBattleUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleUIController != null)
			{
				this.m_battleUIController.EventOnPauseBattle -= this.BattleUIController_OnPauseBattle;
				this.m_battleUIController.EventOnShowArmyRelation -= this.BattleUIController_OnShowArmyRelation;
				this.m_battleUIController.EventOnAutoBattle -= this.BattleUIController_OnAutoBattle;
				this.m_battleUIController.EventOnFastBattle -= this.BattleUIController_OnFastBattle;
				this.m_battleUIController.EventOnSkipCombat -= this.BattleUIController_OnSkipCombat;
				this.m_battleUIController.EventOnShowDanger -= this.BattleUIController_OnShowDanger;
				this.m_battleUIController.EventOnEndAllAction -= this.BattleUIController_OnEndAllAction;
				this.m_battleUIController.EventOnEndAction -= this.BattleUIController_OnEndAction;
				this.m_battleUIController.EventOnShowActorInfo -= this.BattleUIController_OnShowActorInfo;
				this.m_battleUIController.EventOnSelectSkill -= this.BattleUIController_OnSelectSkill;
				this.m_battleUIController.EventOnUseSkill -= this.BattleUIController_OnUseSkill;
				this.m_battleUIController.EventOnCancelSkill -= this.BattleUIController_OnCancelSkill;
				this.m_battleUIController.EventOnShowChat -= this.BattleUIController_OnShowChat;
				this.m_battleUIController.EventOnShowHelp -= this.BattleUIController_OnShowHelp;
				this.m_battleUIController.EventOnPointerDown -= this.BattleUIController_OnPointerDown;
				this.m_battleUIController.EventOnPointerUp -= this.BattleUIController_OnPointerUp;
				this.m_battleUIController.EventOnPointerClick -= this.BattleUIController_OnPointerClick;
				this.m_battleUIController.EventOn3DTouch -= this.BattleUIController_On3DTouch;
				this.m_battleUIController.EventOnWinOrLoseEnd -= this.BattleUIController_OnWinOrLoseEnd;
				this.m_battleUIController.EventOnShowCurTurnDanmaku -= this.BattleUIController_OnShowCurTurnDanmaku;
				this.m_battleUIController.EventOnCloseCurTurnDanmaku -= this.BattleUIController_OnCloseCurTurnDanmaku;
				this.m_battleUIController.EventOnShowOneDanmaku -= this.BattleUIController_OnShowOneDanmaku;
				this.m_battleUIController.EventOnRegretActive -= this.BattleUIController_OnRegretActive;
				this.m_battleUIController.EventOnRegretConfirm -= this.BattleUIController_OnRegretConfirm;
				this.m_battleUIController.EventOnRegretCancel -= this.BattleUIController_OnRegretCancel;
				this.m_battleUIController.EventOnRegretBackward -= this.BattleUIController_OnRegretBackward;
				this.m_battleUIController.EventOnRegretForward -= this.BattleUIController_OnRegretForward;
				this.m_battleUIController = null;
				CommonUIController.Instance.TestUI.EventOnExitBattle -= this.TestUI_ExitBattle;
				CommonUIController.Instance.TestUI.EventOnRestartBattle -= this.TestUI_RestartBattle;
				CommonUIController.Instance.TestUI.EventOnReplayBattle -= this.TestUI_ReplayBattle;
				CommonUIController.Instance.TestUI.EventOnStopBattle -= this.TestUI_StopBattle;
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					projectLPlayerContext.SetBattleBase(null);
					if (projectLPlayerContext.IsInBattleRoom())
					{
						projectLPlayerContext.SetQuitBattleRoom();
					}
				}
			}
			if (this.m_battleDanmakuUIController != null)
			{
				this.m_battleDanmakuUIController = null;
			}
			if (this.m_battleActorInfoUIController != null)
			{
				this.m_battleActorInfoUIController = null;
			}
			if (this.m_battlePauseUIController != null)
			{
				this.m_battlePauseUIController.EventOnExit -= this.BattlePauseUIController_OnExit;
				this.m_battlePauseUIController.EventOnClose -= this.BattlePauseUIController_OnClose;
				this.m_battlePauseUIController.EventOnShowPlayerSetting -= this.BattlePauseUIController_OnShowPlayerSetting;
				this.m_battlePauseUIController = null;
			}
			if (this.m_battleTreasureDialogUIController != null)
			{
				this.m_battleTreasureDialogUIController.EventOnClose -= this.BattleTreasureDialogUIController_OnClose;
				this.m_battleTreasureDialogUIController = null;
			}
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x00337078 File Offset: 0x00335278
		private void InitCombatUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCombatUIController_hotfix != null)
			{
				this.m_InitCombatUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_combatUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 10)
				{
					this.m_combatUIController = (this.m_uiCtrlArray[10] as CombatUIController);
				}
				if (this.m_combatUIController != null)
				{
					this.m_combatUIController.Initialize(this.m_clientBattle.CombatFxPlayer);
					this.m_combatUIController.EventOnAutoBattle += this.CombatUIController_OnAutoBattle;
				}
				else
				{
					global::Debug.LogError("CombatUIController is null");
				}
			}
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x0033715C File Offset: 0x0033535C
		private void UninitCombatUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitCombatUIController_hotfix != null)
			{
				this.m_UninitCombatUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_combatUIController != null)
			{
				this.m_combatUIController.EventOnAutoBattle -= this.CombatUIController_OnAutoBattle;
				this.m_combatUIController = null;
			}
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x003371EC File Offset: 0x003353EC
		private void InitPreCombatUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPreCombatUIController_hotfix != null)
			{
				this.m_InitPreCombatUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_preCombatUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 11)
				{
					this.m_preCombatUIController = (this.m_uiCtrlArray[11] as PreCombatUIController);
				}
				if (this.m_preCombatUIController != null)
				{
					this.m_preCombatUIController.Initialize(this.m_clientBattle.BattleFxPlayer);
					this.m_preCombatUIController.EventOnOk += this.PreCombatUIController_OnOk;
					this.m_preCombatUIController.EventOnCancel += this.PreCombatUIController_OnCancel;
					this.m_preCombatUIController.EventOnStop += this.PreCombatUIController_OnStop;
				}
				else
				{
					global::Debug.LogError("PreCombatUIController is null");
				}
			}
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x003372FC File Offset: 0x003354FC
		private void UninitPreCombatUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitPreCombatUIController_hotfix != null)
			{
				this.m_UninitPreCombatUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_preCombatUIController != null)
			{
				this.m_preCombatUIController.EventOnOk -= this.PreCombatUIController_OnOk;
				this.m_preCombatUIController.EventOnCancel -= this.PreCombatUIController_OnCancel;
				this.m_preCombatUIController.EventOnStop -= this.PreCombatUIController_OnStop;
				this.m_preCombatUIController = null;
			}
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x003373BC File Offset: 0x003355BC
		private void InitBattleRoomUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleRoomUIController_hotfix != null)
			{
				this.m_InitBattleRoomUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleRoomUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 1)
				{
					this.m_battleRoomUIController = (this.m_uiCtrlArray[1] as BattleRoomUIController);
				}
				if (this.m_battleRoomUIController != null)
				{
					if (this.m_isStartInBattleRoom)
					{
						VoiceRecordUITask.StartVoiceRecordUITask(this.m_battleRoomUIController.TalkButton.gameObject, ChatChannel.Team);
					}
				}
				else
				{
					global::Debug.LogError("BattleTeamUIController is null");
				}
			}
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x00337490 File Offset: 0x00335690
		private void UninitBattleRoomUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitBattleRoomUIController_hotfix != null)
			{
				this.m_UninitBattleRoomUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleRoomUIController != null)
			{
				this.m_battleRoomUIController = null;
			}
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x00337508 File Offset: 0x00335708
		private void InitBattleCommonUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleCommonUIController_hotfix != null)
			{
				this.m_InitBattleCommonUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleCommonUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 12)
				{
					this.m_battleCommonUIController = (this.m_uiCtrlArray[12] as BattleCommonUIController);
				}
				if (!(this.m_battleCommonUIController != null))
				{
					global::Debug.LogError("BattleCommonUIController is null");
				}
			}
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x003375BC File Offset: 0x003357BC
		private void UninitBattleCommonUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitBattleCommonUIController_hotfix != null)
			{
				this.m_UninitBattleCommonUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleCommonUIController != null)
			{
				this.m_battleCommonUIController = null;
			}
		}

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x00337634 File Offset: 0x00335834
		private void InitBattlePrepareUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattlePrepareUIController_hotfix != null)
			{
				this.m_InitBattlePrepareUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battlePrepareUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 4)
				{
					this.m_battlePrepareUIController = (this.m_uiCtrlArray[4] as BattlePrepareUIController);
				}
				if (this.m_battlePrepareUIController != null)
				{
					this.m_battlePrepareUIController.Initialize(this.m_clientBattle);
					this.m_battlePrepareUIController.EventOnPauseBattle += this.BattlePrepareUIController_OnPauseBattle;
					this.m_battlePrepareUIController.EventOnShowArmyRelation += this.BattlePrepareUIController_OnShowArmyRelation;
					this.m_battlePrepareUIController.EventOnStart += this.BattlePrepareUIController_OnStart;
					this.m_battlePrepareUIController.EventOnShowActionOrder += this.BattlePrepareUIController_OnShowActionOrder;
					this.m_battlePrepareUIController.EventOnTestOnStage += this.BattlePrepareUIController_OnTestOnStage;
					this.m_battlePrepareUIController.EventOnShowMyActorInfo += this.BattlePrepareUIController_OnShowMyActorInfo;
					this.m_battlePrepareUIController.EventOnHideActorInfo += this.BattlePrepareUIController_OnHideActorInfo;
					this.m_battlePrepareUIController.EventOnStageActorChange += this.BattlePrepareUIController_OnStageActorChange;
					this.m_battlePrepareUIController.EventOnHeroOnStage += this.BattlePrepareUIController_OnHeroOnStage;
					this.m_battlePrepareUIController.EventOnActorOffStage += this.BattlePrepareUIController_OnActorOffStage;
					this.m_battlePrepareUIController.EventOnStageActorMove += this.BattlePrepareUIController_OnStageActorMove;
					this.m_battlePrepareUIController.EventOnStageActorSwap += this.BattlePrepareUIController_OnStageActorSwap;
					this.m_battlePrepareUIController.EventOnShowChat += this.BattlePrepareUIController_OnShowChat;
					this.m_battlePrepareUIController.EventOnShowHelp += this.BattlePrepareUIController_OnShowHelp;
					this.m_battlePrepareUIController.EventOnPointerDown += this.BattlePrepareUIController_OnPointerDown;
					this.m_battlePrepareUIController.EventOnPointerUp += this.BattlePrepareUIController_OnPointerUp;
					this.m_battlePrepareUIController.EventOnPointerClick += this.BattlePrepareUIController_OnPointerClick;
					this.m_battlePrepareUIController.EventOnBeginDragHero += this.BattlePrepareUIController_OnBeginDragHero;
					this.m_battlePrepareUIController.EventOnEndDragHero += this.BattlePrepareUIController_OnEndDragHero;
				}
				else
				{
					global::Debug.LogError("BattlePrepareUIController is null");
				}
			}
			if (this.m_pvpBattlePrepareUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 5)
				{
					this.m_pvpBattlePrepareUIController = (this.m_uiCtrlArray[5] as PVPBattlePrepareUIController);
				}
				if (this.m_pvpBattlePrepareUIController != null)
				{
					this.m_pvpBattlePrepareUIController.EventOnPrepareConfirm += this.PVPBattlePrepareUIController_OnPrepareConfirm;
				}
				else
				{
					global::Debug.LogError("PVPBattlePrepareUIController is null");
				}
			}
			if (this.m_battlePrepareActorInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 6)
				{
					this.m_battlePrepareActorInfoUIController = (this.m_uiCtrlArray[6] as BattlePrepareActorInfoUIController);
				}
				if (this.m_battlePrepareActorInfoUIController != null)
				{
					this.m_battlePrepareActorInfoUIController.EventOnShowSelectSoldierPanel += this.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel;
					this.m_battlePrepareActorInfoUIController.EventOnChangeSkill += this.BattlePrepareActorInfoUIController_OnChangeSkill;
					this.m_battlePrepareActorInfoUIController.EventOnChangeSoldier += this.BattlePrepareActorInfoUIController_OnChangeSoldier;
				}
				else
				{
					global::Debug.LogError("BattlePrepareActorInfoUIController is null");
				}
			}
			if (this.m_actionOrderUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 7)
				{
					this.m_actionOrderUIController = (this.m_uiCtrlArray[7] as ActionOrderUIController);
				}
				if (this.m_actionOrderUIController != null)
				{
					this.m_actionOrderUIController.EventOnConfirm += this.ActionOrderUIController_OnConfirm;
				}
				else
				{
					global::Debug.LogError("BattlePrepareActorInfoUIController is null");
				}
			}
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x00337A18 File Offset: 0x00335C18
		private void UninitBattlePrepareUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitBattlePrepareUIController_hotfix != null)
			{
				this.m_UninitBattlePrepareUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battlePrepareUIController != null)
			{
				this.m_battlePrepareUIController.EventOnPauseBattle -= this.BattlePrepareUIController_OnPauseBattle;
				this.m_battlePrepareUIController.EventOnShowArmyRelation -= this.BattlePrepareUIController_OnShowArmyRelation;
				this.m_battlePrepareUIController.EventOnStart -= this.BattlePrepareUIController_OnStart;
				this.m_battlePrepareUIController.EventOnShowActionOrder -= this.BattlePrepareUIController_OnShowActionOrder;
				this.m_battlePrepareUIController.EventOnTestOnStage -= this.BattlePrepareUIController_OnTestOnStage;
				this.m_battlePrepareUIController.EventOnShowMyActorInfo -= this.BattlePrepareUIController_OnShowMyActorInfo;
				this.m_battlePrepareUIController.EventOnHideActorInfo -= this.BattlePrepareUIController_OnHideActorInfo;
				this.m_battlePrepareUIController.EventOnStageActorChange -= this.BattlePrepareUIController_OnStageActorChange;
				this.m_battlePrepareUIController.EventOnHeroOnStage -= this.BattlePrepareUIController_OnHeroOnStage;
				this.m_battlePrepareUIController.EventOnActorOffStage -= this.BattlePrepareUIController_OnActorOffStage;
				this.m_battlePrepareUIController.EventOnStageActorMove -= this.BattlePrepareUIController_OnStageActorMove;
				this.m_battlePrepareUIController.EventOnStageActorSwap -= this.BattlePrepareUIController_OnStageActorSwap;
				this.m_battlePrepareUIController.EventOnShowChat -= this.BattlePrepareUIController_OnShowChat;
				this.m_battlePrepareUIController.EventOnShowHelp -= this.BattlePrepareUIController_OnShowHelp;
				this.m_battlePrepareUIController.EventOnPointerDown -= this.BattlePrepareUIController_OnPointerDown;
				this.m_battlePrepareUIController.EventOnPointerUp -= this.BattlePrepareUIController_OnPointerUp;
				this.m_battlePrepareUIController.EventOnPointerClick -= this.BattlePrepareUIController_OnPointerClick;
				this.m_battlePrepareUIController.EventOnBeginDragHero -= this.BattlePrepareUIController_OnBeginDragHero;
				this.m_battlePrepareUIController.EventOnEndDragHero -= this.BattlePrepareUIController_OnEndDragHero;
				this.m_battlePrepareUIController.ClearStageActors();
				this.m_battlePrepareUIController = null;
			}
			if (this.m_pvpBattlePrepareUIController != null)
			{
				this.m_pvpBattlePrepareUIController.EventOnPrepareConfirm += this.PVPBattlePrepareUIController_OnPrepareConfirm;
				this.m_pvpBattlePrepareUIController = null;
			}
			if (this.m_battlePrepareActorInfoUIController != null)
			{
				this.m_battlePrepareActorInfoUIController.EventOnShowSelectSoldierPanel -= this.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel;
				this.m_battlePrepareActorInfoUIController.EventOnChangeSkill -= this.BattlePrepareActorInfoUIController_OnChangeSkill;
				this.m_battlePrepareActorInfoUIController.EventOnChangeSoldier -= this.BattlePrepareActorInfoUIController_OnChangeSoldier;
				this.m_battlePrepareActorInfoUIController = null;
			}
			if (this.m_actionOrderUIController != null)
			{
				this.m_actionOrderUIController.EventOnConfirm -= this.ActionOrderUIController_OnConfirm;
				this.m_actionOrderUIController = null;
			}
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x00337D0C File Offset: 0x00335F0C
		public void OnStartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartBattle_hotfix != null)
			{
				this.m_OnStartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			if (currentBattle.BattleInfo != null)
			{
				this.m_battleUIController.ShowObjecive(currentBattle.BattleInfo.WinDesc, currentBattle.BattleInfo.LoseDesc);
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				this.m_battleUIController.ShowObjecive(currentBattle.ArenaDefendRuleInfo.WinDesc, currentBattle.ArenaDefendRuleInfo.LoseDesc);
			}
			else if (currentBattle.PVPBattleInfo != null)
			{
				this.m_battleUIController.ShowObjecive(currentBattle.PVPBattleInfo.WinDesc, currentBattle.PVPBattleInfo.LoseDesc);
			}
			else if (currentBattle.RealTimePVPBattleInfo != null)
			{
				this.m_battleUIController.ShowObjecive(currentBattle.RealTimePVPBattleInfo.WinDesc, currentBattle.RealTimePVPBattleInfo.LoseDesc);
			}
			if (currentBattle.BattleInfo != null && UserGuideUITask.IsUserGuideBattle(currentBattle.BattleInfo.ID))
			{
				this.SetUserGuideBattleSettings();
			}
			this.SaveProcessingBattle();
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x00337E8C File Offset: 0x0033608C
		public void OnStopBattle(bool win, bool skipPerform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopBattleBooleanBoolean_hotfix != null)
			{
				this.m_OnStopBattleBooleanBoolean_hotfix.call(new object[]
				{
					this,
					win,
					skipPerform
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SaveProcessingBattle();
			this.StopBattle(win, skipPerform);
			this.StopBattleRoomMyActionCountdown();
			this.StopBattleRoomOtherActionCountdown();
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x00337F28 File Offset: 0x00336128
		public void OnShowBattleWinCondition(ConfigDataBattleWinConditionInfo winConditionInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix != null)
			{
				this.m_OnShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix.call(new object[]
				{
					this,
					winConditionInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (winConditionInfo.WinConditionType != BattleWinConditionType.BattleWinConditionType_ActorReachPosition)
			{
				this.m_battleSceneUIController.ShowBattleWinCondition(winConditionInfo, targetPos);
			}
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x00337FC8 File Offset: 0x003361C8
		public void OnHideBattleWinCondition(ConfigDataBattleWinConditionInfo winConditionInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix != null)
			{
				this.m_OnHideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix.call(new object[]
				{
					this,
					winConditionInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (winConditionInfo.WinConditionType != BattleWinConditionType.BattleWinConditionType_ActorReachPosition)
			{
				this.m_battleSceneUIController.HideBattleWinCondition(winConditionInfo, targetPos);
			}
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x00338068 File Offset: 0x00336268
		public void OnShowBattleLoseCondition(ConfigDataBattleLoseConditionInfo loseConditionInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix != null)
			{
				this.m_OnShowBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix.call(new object[]
				{
					this,
					loseConditionInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_ActorReachPosition)
			{
			}
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x003380FC File Offset: 0x003362FC
		public void OnHideBattleLoseCondition(ConfigDataBattleLoseConditionInfo loseConditionInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHideBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix != null)
			{
				this.m_OnHideBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix.call(new object[]
				{
					this,
					loseConditionInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_ActorReachPosition)
			{
			}
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x00338190 File Offset: 0x00336390
		public void OnNextTurn(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextTurnInt32_hotfix != null)
			{
				this.m_OnNextTurnInt32_hotfix.call(new object[]
				{
					this,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleUIController.ShowTurnStart(turn, this.m_clientBattle.Battle.TurnMax);
			if (turn != 1)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
				if (currentBattle.BattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.BattleInfo.BattleMusic);
				}
				else if (currentBattle.ArenaBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.ArenaBattleInfo.BattleMusic);
				}
				else if (currentBattle.PVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.PVPBattleInfo.BattleMusic);
				}
				else if (currentBattle.RealTimePVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.RealTimePVPBattleInfo.BattleMusic);
				}
			}
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x003382D8 File Offset: 0x003364D8
		public void OnNextTurnAnimationEnd(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextTurnAnimationEndInt32_hotfix != null)
			{
				this.m_OnNextTurnAnimationEndInt32_hotfix.call(new object[]
				{
					this,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (this.CanUseDanmaku())
			{
				this.m_battleUIController.ShowCurTurnDanmaku(turn);
			}
		}

		// Token: 0x0600B7E0 RID: 47072 RVA: 0x0033837C File Offset: 0x0033657C
		public void OnNextTeam(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextTeamInt32_hotfix != null)
			{
				this.m_OnNextTeamInt32_hotfix.call(new object[]
				{
					this,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (team != this.m_clientBattle.GetMyPlayerTeamNumber())
			{
				this.m_battleUIController.ShowEnemyTurn();
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
				if (currentBattle.BattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.BattleInfo.EnemyBattleMusic);
				}
				else if (currentBattle.ArenaBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.ArenaBattleInfo.DefendBattleMusic);
				}
				else if (currentBattle.PVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.PVPBattleInfo.DefendBattleMusic);
				}
				else if (currentBattle.RealTimePVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.RealTimePVPBattleInfo.DefendBattleMusic);
				}
				BattleRoom battleRoom = this.GetBattleRoom();
				if (battleRoom != null)
				{
					this.StopBattleRoomMyActionCountdown();
					this.StopBattleRoomOtherActionCountdown();
					for (int i = 0; i < battleRoom.Players.Count; i++)
					{
						this.m_battleRoomUIController.SetPlayerAction(i, false);
					}
					foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
					{
						clientBattleActor.ShowPlayerIndex(false);
					}
				}
			}
			this.ResetActorEffect();
		}

		// Token: 0x0600B7E1 RID: 47073 RVA: 0x0033855C File Offset: 0x0033675C
		public void OnNextPlayer(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextPlayerInt32_hotfix != null)
			{
				this.m_OnNextPlayerInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (playerIndex == battleRoom.MyPlayerIndex)
			{
				if (!this.m_clientBattle.IsRebuildingBattle())
				{
					if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
					{
						this.m_battleUIController.ShowMyAction(battleRoom.Players[playerIndex], playerIndex, null);
					}
					else if (battleRoom.IsAnyPVPBattleRoomType())
					{
						this.m_battleUIController.ShowMyAction(battleRoom.Players[playerIndex], -1, null);
					}
					if (this.m_battlePauseUIController.IsOpened())
					{
						this.BattlePauseUIController_OnClose();
					}
					this.StartBattleRoomPlayerActionBeginNetTask();
				}
				if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
				{
					this.StartBattleRoomMyActionCountdown();
				}
				this.StopBattleRoomOtherActionCountdown();
			}
			else if (playerIndex >= 0)
			{
				if (!this.m_clientBattle.IsRebuildingBattle())
				{
					if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
					{
						this.m_battleUIController.ShowTeammateAction(battleRoom.Players[playerIndex], playerIndex, null);
					}
					else if (battleRoom.IsAnyPVPBattleRoomType())
					{
						this.m_battleUIController.ShowEnemyAction(battleRoom.Players[playerIndex]);
					}
				}
				if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
				{
					this.StartBattleRoomOtherActionCountdown(playerIndex);
				}
				this.StopBattleRoomMyActionCountdown();
			}
			else
			{
				this.StopBattleRoomMyActionCountdown();
				this.StopBattleRoomOtherActionCountdown();
			}
			this.HideActorInfo();
			this.m_battleMapUIController.HideRegion();
			for (int i = 0; i < battleRoom.Players.Count; i++)
			{
				this.m_battleRoomUIController.SetPlayerAction(i, i == playerIndex);
			}
			if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				foreach (ClientBattleActor clientBattleActor in this.m_clientBattle.GetActors())
				{
					clientBattleActor.ShowPlayerIndex(playerIndex >= 0 && playerIndex != battleRoom.MyPlayerIndex && clientBattleActor.BattleActor.PlayerIndex == playerIndex);
				}
			}
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x003387C8 File Offset: 0x003369C8
		public void OnNextActor(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextActorBattleActor_hotfix != null)
			{
				this.m_OnNextActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null)
			{
				return;
			}
			if (battleRoom.IsAnyPVPBattleRoomType())
			{
				int playerIndex = actor.PlayerIndex;
				if (playerIndex == battleRoom.MyPlayerIndex)
				{
					this.StartBattleRoomMyActionCountdown();
					this.StopBattleRoomOtherActionCountdown();
				}
				else if (playerIndex >= 0)
				{
					this.StartBattleRoomOtherActionCountdown(playerIndex);
					this.StopBattleRoomMyActionCountdown();
				}
				else
				{
					this.StopBattleRoomMyActionCountdown();
					this.StopBattleRoomOtherActionCountdown();
				}
			}
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x0033889C File Offset: 0x00336A9C
		public void OnClientActorActive(ClientBattleActor a, bool newStep, int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorActiveClientBattleActorBooleanInt32_hotfix != null)
			{
				this.m_OnClientActorActiveClientBattleActorBooleanInt32_hotfix.call(new object[]
				{
					this,
					a,
					newStep,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.CurrentBattle.ArenaBattleReport != null || projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom == null && !flag && !this.IsRegretActive())
			{
				if (newStep)
				{
					if (Application.isEditor && this.FindRegretStepIndex(step) >= 0)
					{
						global::Debug.LogError("BattleUITask.OnClientActorActive error, duplicate step: " + step);
					}
					this.m_regretSteps.Add(new BattleUITask.RegretStep(step, a.BattleActor.Id));
					if (!this.m_clientBattle.IsRebuildingBattle())
					{
						this.SaveProcessingBattle();
					}
				}
				else
				{
					int num = this.FindRegretStepIndex(step);
					if (num >= 0)
					{
						this.m_regretSteps[num] = new BattleUITask.RegretStep(step, a.BattleActor.Id);
					}
				}
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				if (a.BattleActor.IsAIActor())
				{
					a.BattleActor.GenerateAIBattleCommand();
				}
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.UpdateDangerRegion();
			if (a.BattleActor.IsAIActor() || (a.BattleActor.PlayerIndex < 0 && this.m_clientBattle.IsAutoBattle && !flag))
			{
				this.SetUIStateNone();
				a.BattleActor.GenerateAIBattleCommand();
				return;
			}
			if (this.m_clientBattle.Battle.HasBattleCommand() || flag)
			{
				this.SetUIStateNone();
				return;
			}
			if (a.BattleActor.PlayerIndex >= 0 && battleRoom != null)
			{
				if (a.BattleActor.PlayerIndex != battleRoom.MyPlayerIndex)
				{
					this.SetUIStateWaitOtherPlayer();
					this.ActivateBattleRoomOtherActionCountdown(true);
					return;
				}
				this.m_clientBattle.Battle.EnableTempBattleCommands(true);
				if (this.m_clientBattle.IsAutoBattle || this.m_isAutoBattleOnce)
				{
					this.SetUIStateNone();
					a.BattleActor.GenerateAIBattleCommand();
					this.SendBattleCommands();
					return;
				}
			}
			this.m_battleUIController.ShowTopUI(true);
			this.m_battleUIController.ShowBottomUI(true);
			this.m_battleUIController.SetActorSimpleInfo(a.BattleActor);
			a.StartIdleRun();
			this.m_activeActor = a;
			this.m_activeActorInitPosition = a.BattleActor.Position;
			this.m_activeActorInitDirection = a.BattleActor.Direction;
			this.ShowSelectionMarkAndTerrain(a.Position);
			if (this.m_activeActor.BattleActor.IsExtraActionMoving())
			{
				this.SetUIStateExtraMove();
			}
			else
			{
				this.SetUIStateMove();
				if (a.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
				{
					this.PlaySelectHeroSound(a.BattleActor);
				}
			}
			if (battleRoom != null && a.BattleActor.PlayerIndex == battleRoom.MyPlayerIndex)
			{
				this.ActivateBattleRoomMyActionCountdown(true);
			}
			if (BattleUITask.m_onActiveActorEvent != null)
			{
				BattleUITask.m_onActiveActorEvent(a);
			}
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x00338C28 File Offset: 0x00336E28
		public void OnClientActorMove(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorMoveClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorMoveClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_clientBattle.IsRebuildingBattle())
			{
				this.UpdateDangerRegion();
			}
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x00338CB0 File Offset: 0x00336EB0
		public void OnClientActorTryMove(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorTryMoveClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorTryMoveClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiState == BattleUIState.Move)
			{
				this.ShowMovePath(a, this.m_activeActorInitPosition);
				this.UpdateDangerRegion();
			}
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x00338D40 File Offset: 0x00336F40
		public void OnClientActorNoAct(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorNoActClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorNoActClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (a == this.m_activeActor && this.m_uiState == BattleUIState.SelectTeleportPosition)
			{
				this.SetUIStateSelectTeleportPosition2();
			}
			this.ResetActorEffect();
			if (BattleUITask.m_onDeactiveActorEvent != null)
			{
				BattleUITask.m_onDeactiveActorEvent(a);
			}
			if (this.m_preCombatTargetActor != null)
			{
				this.ShowPreCombat(this.m_activeActor.BattleActor, this.m_preCombatTargetActor, null);
				this.m_combatTargetPosition = this.m_preCombatTargetActor.Position;
				this.m_preCombatTargetActor = null;
			}
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x00338E44 File Offset: 0x00337044
		public void OnClientActorTarget(ClientBattleActor a, ConfigDataSkillInfo skillInfo, GridPosition pos, int armyRelationValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorTargetClientBattleActorConfigDataSkillInfoGridPositionInt32_hotfix != null)
			{
				this.m_OnClientActorTargetClientBattleActorConfigDataSkillInfoGridPositionInt32_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					pos,
					armyRelationValue
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleSceneUIController.ShowTargetIcon(pos, armyRelationValue, skillInfo, 0.5f);
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x00338F18 File Offset: 0x00337118
		public void OnClientActorSkill(ClientBattleActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorSkillClientBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnClientActorSkillClientBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x00338F98 File Offset: 0x00337198
		public void OnClientActorSkillEnd(ClientBattleActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorSkillEndClientBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnClientActorSkillEndClientBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (this.m_isBattleCutsceneFade)
			{
				this.m_battleUIController.ShowTopUI(this.m_saveShowTopUI);
				this.m_battleMapUIController.SkillFadeOut(0.3f);
				this.m_isBattleCutsceneFade = false;
			}
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x00339068 File Offset: 0x00337268
		public void OnClientActorSkillHit(ClientBattleActor a, ConfigDataSkillInfo skillInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnClientActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleSceneUIController.OnActorSkillHit(a, skillInfo, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x00339148 File Offset: 0x00337348
		public void OnClientActorBuffHit(ClientBattleActor a, ConfigDataBuffInfo buffInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnClientActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					buffInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleSceneUIController.OnActorBuffHit(a, buffInfo, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x00339228 File Offset: 0x00337428
		public void OnClientActorTerrainHit(ClientBattleActor a, ConfigDataTerrainInfo terrainInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnClientActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					terrainInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleSceneUIController.OnActorTerrainHit(a, terrainInfo, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x00339308 File Offset: 0x00337508
		public void OnClientActorImmune(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorImmuneClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorImmuneClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleSceneUIController.OnActorAttachImmune(a);
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x003393A4 File Offset: 0x003375A4
		public void OnClientActorPassiveSkill(ClientBattleActor a, BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorPassiveSkillClientBattleActorBuffState_hotfix != null)
			{
				this.m_OnClientActorPassiveSkillClientBattleActorBuffState_hotfix.call(new object[]
				{
					this,
					a,
					sourceBuffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (this.m_preCombatUIController.IsOpened())
			{
				int side;
				if (a.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
				{
					side = 0;
				}
				else
				{
					side = 1;
				}
				this.m_preCombatUIController.OnActorPassiveSkill(side, sourceBuffState);
			}
			else
			{
				this.m_battleSceneUIController.OnActorPassiveSkill(a, sourceBuffState);
			}
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x00339494 File Offset: 0x00337694
		public void OnClientActorGuard(ClientBattleActor a, ClientBattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorGuardClientBattleActorClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorGuardClientBattleActorClientBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleSceneUIController.OnActorGuard(a, target);
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x00339540 File Offset: 0x00337740
		public void OnClientActorDie(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorDieClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorDieClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
			{
				this.UpdateBattleRoomPlayerHeroStatus();
			}
			if (!this.m_clientBattle.IsRebuildingBattle())
			{
				this.UpdateDangerRegion();
			}
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x003395E4 File Offset: 0x003377E4
		public void OnClientActorAppear(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClientActorAppearClientBattleActor_hotfix != null)
			{
				this.m_OnClientActorAppearClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_clientBattle.IsRebuildingBattle())
			{
				this.UpdateDangerRegion();
			}
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x0033966C File Offset: 0x0033786C
		public void OnCancelCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelCombat_hotfix != null)
			{
				this.m_OnCancelCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.m_preCombatUIController.Close();
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x003396E8 File Offset: 0x003378E8
		public void OnPreStartCombat(ClientBattleActor a, ClientBattleActor b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPreStartCombatClientBattleActorClientBattleActor_hotfix != null)
			{
				this.m_OnPreStartCombatClientBattleActorClientBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleUIController.ShowTopUI(false);
			this.m_battleUIController.ShowBottomUI(false);
			this.SetUIStateNone();
			if (this.m_isStartInBattleRoom)
			{
				UIUtility.ActivateLayer(this.m_battleRoomUIController, false);
			}
			this.m_combatStartPosition = a.Position;
			this.m_battleMapUIController.HideMovePath();
			this.m_battleMapUIController.ShowZoomFade(this.m_combatStartPosition, 0.5f, true);
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x003397FC File Offset: 0x003379FC
		public void OnStartCombat(ClientBattleActor a, ClientBattleActor b, bool splitScreen)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartCombatClientBattleActorClientBattleActorBoolean_hotfix != null)
			{
				this.m_OnStartCombatClientBattleActorClientBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					b,
					splitScreen
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (this.m_battlePauseUIController.IsOpened())
			{
				this.BattlePauseUIController_OnClose();
			}
			UIUtility.ActivateLayer(this.m_battleUIController, false);
			UIUtility.ActivateLayer(this.m_combatUIController, true);
			CombatTeam team = this.m_clientBattle.Battle.Combat.GetTeam(0);
			CombatTeam team2 = this.m_clientBattle.Battle.Combat.GetTeam(1);
			bool isBoss = team2.SoldierInfo == null;
			this.m_combatUIController.StartCombat(splitScreen, isBoss, this.m_clientBattle.GetMyPlayerTeamNumber());
			this.m_combatUIController.SetCharImageInfo(0, team.HeroInfo.GetCharImageInfo(team.HeroStar), team.BattleActor.HeroCharImageSkinResourceInfo);
			this.m_combatUIController.SetCharImageInfo(1, team2.HeroInfo.GetCharImageInfo(team2.HeroStar), team2.BattleActor.HeroCharImageSkinResourceInfo);
			this.m_combatSceneUIController.StartCombat(team.BattleActor.GetTerrain(), team2.BattleActor.GetTerrain(), splitScreen, a.TeamNumber, this.m_clientBattle.GetMyPlayerTeamNumber());
			this.SetCombatHp(0);
			this.SetCombatHp(1);
			this.m_combatUIController.ForceUpdateChar();
			if (this.m_showDangerRegionTeam >= 0)
			{
				this.m_battleMapUIController.HideDangerRegion();
			}
			UIUtility.SetLongFrame();
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x003399F4 File Offset: 0x00337BF4
		public void OnPreStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPreStopCombat_hotfix != null)
			{
				this.m_OnPreStopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_combatSceneUIController.PreStopCombat();
			if (this.m_isCombatCutsceneFade)
			{
				this.m_combatSceneUIController.SkillFadeOut(0.1f);
				this.m_isCombatCutsceneFade = false;
			}
			this.m_combatUIController.PreStopCombat();
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x00339ABC File Offset: 0x00337CBC
		public void OnStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopCombat_hotfix != null)
			{
				this.m_OnStopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			UIUtility.ActivateLayer(this.m_combatUIController, false);
			UIUtility.ActivateLayer(this.m_battleUIController, true);
			if (this.m_isStartInBattleRoom)
			{
				UIUtility.ActivateLayer(this.m_battleRoomUIController, true);
			}
			this.m_battleUIController.ShowTopUI(true);
			this.m_battleUIController.ShowBottomUI(true);
			this.m_battleMapUIController.ShowZoomFade(this.m_combatStartPosition, 0.5f, false);
			this.m_combatUIController.StopCombat();
			this.m_combatSceneUIController.StopCombat();
			this.UpdateDangerRegion();
			UIUtility.SetLongFrame();
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x00339BCC File Offset: 0x00337DCC
		public void OnPrepareFastCombat(ClientBattleActor a, ClientBattleActor b, ConfigDataSkillInfo attackerSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPrepareFastCombatClientBattleActorClientBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnPrepareFastCombatClientBattleActorClientBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					b,
					attackerSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.m_battlePauseUIController.IsOpened())
			{
				this.BattlePauseUIController_OnClose();
			}
			BattleActor battleActor;
			BattleActor battleActor2;
			int num;
			if (a.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
			{
				battleActor = a.BattleActor;
				battleActor2 = b.BattleActor;
				num = 0;
			}
			else
			{
				battleActor = b.BattleActor;
				battleActor2 = a.BattleActor;
				num = 1;
			}
			ConfigDataTerrainInfo terrain = this.m_clientBattle.Battle.Map.GetTerrain(battleActor.Position);
			ConfigDataTerrainInfo terrain2 = this.m_clientBattle.Battle.Map.GetTerrain(battleActor2.Position);
			bool flag = this.m_clientBattle.IsCombatMagicAttack(battleActor, battleActor2, (num != 0) ? null : attackerSkillInfo);
			bool isMagicAttack = this.m_clientBattle.IsCombatMagicAttack(battleActor2, battleActor, (num != 1) ? null : attackerSkillInfo);
			int armyRelationValue = this.m_clientBattle.ComputeCombatArmyRelationValue(battleActor, battleActor2, flag);
			this.m_preCombatUIController.SetBattleActorInfo(battleActor, battleActor2, terrain, terrain2, flag, isMagicAttack, armyRelationValue, attackerSkillInfo, num);
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x00339D5C File Offset: 0x00337F5C
		public void OnStartFastCombat(FastCombatActorInfo a, FastCombatActorInfo b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				this.m_OnStartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			FastCombatActorInfo a2;
			FastCombatActorInfo a3;
			if (a.m_battleActor.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
			{
				a2 = a;
				a3 = b;
			}
			else
			{
				a2 = b;
				a3 = a;
			}
			this.ShowFastCombat(a2, a3);
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x00339E20 File Offset: 0x00338020
		public void OnCombatActorHit(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skillInfo, int hpModify, int totalDamage, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					attacker,
					skillInfo,
					hpModify,
					totalDamage,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			int hp;
			int healthPointMax;
			if (a.IsHero())
			{
				hp = a.HealthPoint;
				healthPointMax = a.HealthPointMax;
			}
			else
			{
				CombatTeam team = this.m_clientBattle.Battle.Combat.GetTeam(a.TeamNumber);
				hp = team.ComputeSoldierTotalHealthPoint();
				healthPointMax = team.BattleActor.SoldierBattleProperty.HealthPointMax;
			}
			this.m_combatSceneUIController.OnActorHit(a, attacker, skillInfo, hpModify, damageNumberType);
			this.m_combatUIController.ShowDamage(a.TeamNumber, a.IsHero(), hp, healthPointMax, hpModify, totalDamage, this.m_clientBattle.Battle.Combat.GetFrameCount(), damageNumberType);
			this.SetCombatHp(a.TeamNumber);
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x00339FB4 File Offset: 0x003381B4
		public void OnStartSkillCutscene(ConfigDataSkillInfo skillInfo, ConfigDataCutsceneInfo cutsceneInfo, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix != null)
			{
				this.m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix.call(new object[]
				{
					this,
					skillInfo,
					cutsceneInfo,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (this.m_clientBattle.State == ClientBattleState.Combat)
			{
				if (skillInfo.CutsceneType == 1)
				{
					this.m_combatSceneUIController.SkillFadeIn(0.3f, 0.8f);
				}
				else if (skillInfo.CutsceneType == 2)
				{
					this.m_combatSceneUIController.SkillFadeIn(0.3f, 0.4f);
				}
				this.m_combatUIController.ShowCutsceneSkill(skillInfo);
				this.m_isCombatCutsceneFade = true;
			}
			else
			{
				this.m_saveShowTopUI = this.m_battleUIController.IsShowTopUI();
				this.m_battleUIController.ShowTopUI(false);
				if (skillInfo.CutsceneType == 1)
				{
					this.m_battleMapUIController.SkillFadeIn(0.3f, 0.8f);
				}
				else if (skillInfo.CutsceneType == 2)
				{
					this.m_battleMapUIController.SkillFadeIn(0.3f, 0.4f);
				}
				this.m_battleUIController.ShowCutsceneSkill(skillInfo);
				this.m_isBattleCutsceneFade = true;
			}
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x0033A15C File Offset: 0x0033835C
		public void OnStartPassiveSkillCutscene(BuffState sourceBuffState, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix != null)
			{
				this.m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix.call(new object[]
				{
					this,
					sourceBuffState,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			if (this.m_clientBattle.State == ClientBattleState.Combat)
			{
				this.m_combatSceneUIController.SkillFadeIn(0.3f, 0.4f);
				this.m_combatUIController.ShowCutscenePassiveSkill(sourceBuffState);
			}
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x0033A240 File Offset: 0x00338440
		public void OnStopSkillCutscene()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopSkillCutscene_hotfix != null)
			{
				this.m_OnStopSkillCutscene_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x0033A2A0 File Offset: 0x003384A0
		public void OnStartBattleDialog(ConfigDataBattleDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix != null)
			{
				this.m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix.call(new object[]
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
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				this.m_clientBattle.StopBattleDialog(0);
				return;
			}
			if (this.m_isStartBattleAutoBattle && this.m_clientBattle.IsAutoBattle)
			{
				this.m_clientBattle.StopBattleDialog(0);
				return;
			}
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(BattleDialogUITask).Name, null);
			uiintentReturnable.SetParam("BattleDialogInfo", dialogInfo);
			BattleDialogUITask battleDialogUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.BattleDialogUITask_OnLoadAllResCompleted)) as BattleDialogUITask;
			if (this.m_battleDialogUITask == null)
			{
				this.m_battleDialogUITask = battleDialogUITask;
				this.m_battleDialogUITask.EventOnClose += this.BattleDialogUITask_OnClose;
			}
		}

		// Token: 0x0600B7FE RID: 47102 RVA: 0x0033A3CC File Offset: 0x003385CC
		private void BattleDialogUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_BattleDialogUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(BattleDialogUITask));
			if (uitaskBase != null)
			{
				if (this.m_clientBattle.State != ClientBattleState.Prepare)
				{
					UIUtility.ActivateLayer(this.m_battleUIController, false);
				}
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x0033A468 File Offset: 0x00338668
		public void OnStartBattleTreasureDialog(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_OnStartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.ShowBattleTreasureDialog(treasureInfo);
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x0033A4F0 File Offset: 0x003386F0
		public void OnShowBattleTreasureReward(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_OnShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.ShowBattleTreasureReward(treasureInfo);
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x0033A578 File Offset: 0x00338778
		public void OnStartBattlePerform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartBattlePerform_hotfix != null)
			{
				this.m_OnStartBattlePerform_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B802 RID: 47106 RVA: 0x0033A5D8 File Offset: 0x003387D8
		public void OnStopBattlePerform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopBattlePerform_hotfix != null)
			{
				this.m_OnStopBattlePerform_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x0033A638 File Offset: 0x00338838
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
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.m_clientBattle.IsSkippingCombat(true))
			{
				return;
			}
			if (this.IsRegretActive())
			{
				return;
			}
			this.m_battleCommonUIController.PlayScreenEffect(name);
		}

		// Token: 0x14000242 RID: 578
		// (add) Token: 0x0600B804 RID: 47108 RVA: 0x0033A6E4 File Offset: 0x003388E4
		// (remove) Token: 0x0600B805 RID: 47109 RVA: 0x0033A718 File Offset: 0x00338918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ClientBattleActor> m_onActiveActorEvent;

		// Token: 0x14000243 RID: 579
		// (add) Token: 0x0600B806 RID: 47110 RVA: 0x0033A74C File Offset: 0x0033894C
		// (remove) Token: 0x0600B807 RID: 47111 RVA: 0x0033A780 File Offset: 0x00338980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<ClientBattleActor> m_onDeactiveActorEvent;

		// Token: 0x0600B808 RID: 47112 RVA: 0x0033A7B4 File Offset: 0x003389B4
		private void StartBattleTeamSetNetTask(BattleType battleType, int battleId, List<int> heros)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleTeamSetNetTaskBattleTypeInt32List`1_hotfix != null)
			{
				this.m_StartBattleTeamSetNetTaskBattleTypeInt32List`1_hotfix.call(new object[]
				{
					this,
					battleType,
					battleId,
					heros
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<int> battleTeam = projectLPlayerContext.GetBattleTeam(battleType);
			if (BattleUITask.IsListElementsEqual(heros, battleTeam))
			{
				this.StartLevelAttackNetTask();
			}
			else
			{
				BattleTeamSetNetTask battleTeamSetNetTask = new BattleTeamSetNetTask(battleType, battleId, heros);
				battleTeamSetNetTask.EventOnStop += delegate(Task task)
				{
					BattleTeamSetNetTask battleTeamSetNetTask2 = task as BattleTeamSetNetTask;
					if (battleTeamSetNetTask2.Result == 0)
					{
						this.StartLevelAttackNetTask();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleTeamSetNetTask2.Result, 2f, null, true);
					}
				};
				battleTeamSetNetTask.Start(null);
			}
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x0033A898 File Offset: 0x00338A98
		private void StartLevelAttackNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLevelAttackNetTask_hotfix != null)
			{
				this.m_StartLevelAttackNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				if (projectLPlayerContext.Happening.WaypointInfo != null)
				{
					if (projectLPlayerContext.Happening.ScenarioInfo != null)
					{
						this.StartLevelScenarioHandleNetTask(projectLPlayerContext.Happening.ScenarioInfo);
					}
					else
					{
						this.StartLevelWayPointMoveNetTask(projectLPlayerContext.Happening.WaypointInfo);
					}
				}
				else if (projectLPlayerContext.Happening.RiftLevelInfo != null)
				{
					this.StartRiftLevelAttackNetTask(projectLPlayerContext.Happening.RiftLevelInfo);
				}
				else if (projectLPlayerContext.Happening.HeroDungeonLevelInfo != null)
				{
					this.StartHeroDungeonLevelAttackNetTask(projectLPlayerContext.Happening.HeroDungeonLevelInfo);
				}
				else if (projectLPlayerContext.Happening.ThearchyLevelInfo != null)
				{
					this.StartThearchyLevelAttackNetTask(projectLPlayerContext.Happening.ThearchyLevelInfo);
				}
				else if (projectLPlayerContext.Happening.AnikiLevelInfo != null)
				{
					this.StartAnikiLevelAttackNetTask(projectLPlayerContext.Happening.AnikiLevelInfo);
				}
				else if (projectLPlayerContext.Happening.TreasureLevelInfo != null)
				{
					this.StartTreasureLevelAttackNetTask(projectLPlayerContext.Happening.TreasureLevelInfo);
				}
				else if (projectLPlayerContext.Happening.MemoryCorridorLevelInfo != null)
				{
					this.StartMemoryCorridorLevelAttackNetTask(projectLPlayerContext.Happening.MemoryCorridorLevelInfo);
				}
				else if (projectLPlayerContext.Happening.HeroTrainningLevelInfo != null)
				{
					this.StartHeroTrainningLevelAttackNetTask(projectLPlayerContext.Happening.HeroTrainningLevelInfo);
				}
				else if (projectLPlayerContext.Happening.HeroPhantomLevelInfo != null)
				{
					this.StartHeroPhantomLevelAttackNetTask(projectLPlayerContext.Happening.HeroPhantomLevelInfo);
				}
				else if (projectLPlayerContext.Happening.ScoreLevelInfo != null)
				{
					this.StartUnchartedScoreLevelAttackNetTask(projectLPlayerContext.Happening.ScoreLevelInfo);
				}
				else if (projectLPlayerContext.Happening.ChallengeLevelInfo != null)
				{
					this.StartUnchartedChallengeLevelAttackNetTask(projectLPlayerContext.Happening.ChallengeLevelInfo);
				}
				else if (projectLPlayerContext.Happening.TowerFloorInfo != null)
				{
					this.StartClimbTowerLevelAttackNetTask(projectLPlayerContext.Happening.TowerFloorInfo);
				}
				else if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
				{
					this.StartGuildMassiveCombatAttackNetTask(projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo, this.m_myBattleHeroIds);
				}
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				this.StartArenaOpponentAttackFightingNetTask();
			}
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x0033AB48 File Offset: 0x00338D48
		private void StartLevelWayPointMoveNetTask(ConfigDataWaypointInfo waypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLevelWayPointMoveNetTaskConfigDataWaypointInfo_hotfix != null)
			{
				this.m_StartLevelWayPointMoveNetTaskConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LevelWayPointMoveNetTask levelWayPointMoveNetTask = new LevelWayPointMoveNetTask(waypointInfo.ID);
			levelWayPointMoveNetTask.EventOnStop += delegate(Task task)
			{
				LevelWayPointMoveNetTask levelWayPointMoveNetTask2 = task as LevelWayPointMoveNetTask;
				this.HandleLevelAttackNetTaskResult(levelWayPointMoveNetTask2.Result);
			};
			levelWayPointMoveNetTask.Start(null);
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x0033ABE0 File Offset: 0x00338DE0
		private void StartLevelScenarioHandleNetTask(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLevelScenarioHandleNetTaskConfigDataScenarioInfo_hotfix != null)
			{
				this.m_StartLevelScenarioHandleNetTaskConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LevelScenarioHandleNetTask levelScenarioHandleNetTask = new LevelScenarioHandleNetTask(scenarioInfo.ID);
			levelScenarioHandleNetTask.EventOnStop += delegate(Task task)
			{
				LevelScenarioHandleNetTask levelScenarioHandleNetTask2 = task as LevelScenarioHandleNetTask;
				this.HandleLevelAttackNetTaskResult(levelScenarioHandleNetTask2.Result);
			};
			levelScenarioHandleNetTask.Start(null);
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x0033AC78 File Offset: 0x00338E78
		private void StartRiftLevelAttackNetTask(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRiftLevelAttackNetTaskConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_StartRiftLevelAttackNetTaskConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevelAttackNetTask riftLevelAttackNetTask = new RiftLevelAttackNetTask(levelInfo.ID);
			riftLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				RiftLevelAttackNetTask riftLevelAttackNetTask2 = task as RiftLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(riftLevelAttackNetTask2.Result);
			};
			riftLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x0033AD10 File Offset: 0x00338F10
		private void StartHeroDungeonLevelAttackNetTask(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonLevelAttackNetTaskConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_StartHeroDungeonLevelAttackNetTaskConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDungeonLevelAttackNetTask heroDungeonLevelAttackNetTask = new HeroDungeonLevelAttackNetTask(levelInfo.ID);
			heroDungeonLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				HeroDungeonLevelAttackNetTask heroDungeonLevelAttackNetTask2 = task as HeroDungeonLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(heroDungeonLevelAttackNetTask2.Result);
			};
			heroDungeonLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x0033ADA8 File Offset: 0x00338FA8
		private void StartAnikiLevelAttackNetTask(ConfigDataAnikiLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartAnikiLevelAttackNetTaskConfigDataAnikiLevelInfo_hotfix != null)
			{
				this.m_StartAnikiLevelAttackNetTaskConfigDataAnikiLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AnikiLevelAttackNetTask anikiLevelAttackNetTask = new AnikiLevelAttackNetTask(levelInfo.ID);
			anikiLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				AnikiLevelAttackNetTask anikiLevelAttackNetTask2 = task as AnikiLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(anikiLevelAttackNetTask2.Result);
			};
			anikiLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x0033AE40 File Offset: 0x00339040
		private void StartThearchyLevelAttackNetTask(ConfigDataThearchyTrialLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartThearchyLevelAttackNetTaskConfigDataThearchyTrialLevelInfo_hotfix != null)
			{
				this.m_StartThearchyLevelAttackNetTaskConfigDataThearchyTrialLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ThearchyLevelAttackNetTask thearchyLevelAttackNetTask = new ThearchyLevelAttackNetTask(levelInfo.ID);
			thearchyLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				ThearchyLevelAttackNetTask thearchyLevelAttackNetTask2 = task as ThearchyLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(thearchyLevelAttackNetTask2.Result);
			};
			thearchyLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x0033AED8 File Offset: 0x003390D8
		private void StartMemoryCorridorLevelAttackNetTask(ConfigDataMemoryCorridorLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartMemoryCorridorLevelAttackNetTaskConfigDataMemoryCorridorLevelInfo_hotfix != null)
			{
				this.m_StartMemoryCorridorLevelAttackNetTaskConfigDataMemoryCorridorLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MemoryCorridorLevelAttackNetTask memoryCorridorLevelAttackNetTask = new MemoryCorridorLevelAttackNetTask(levelInfo.ID);
			memoryCorridorLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				MemoryCorridorLevelAttackNetTask memoryCorridorLevelAttackNetTask2 = task as MemoryCorridorLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(memoryCorridorLevelAttackNetTask2.Result);
			};
			memoryCorridorLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B811 RID: 47121 RVA: 0x0033AF70 File Offset: 0x00339170
		private void StartHeroTrainningLevelAttackNetTask(ConfigDataHeroTrainningLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroTrainningLevelAttackNetTaskConfigDataHeroTrainningLevelInfo_hotfix != null)
			{
				this.m_StartHeroTrainningLevelAttackNetTaskConfigDataHeroTrainningLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroTrainningLevelAttackNetTask heroTrainningLevelAttackNetTask = new HeroTrainningLevelAttackNetTask(levelInfo.ID);
			heroTrainningLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				HeroTrainningLevelAttackNetTask heroTrainningLevelAttackNetTask2 = task as HeroTrainningLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(heroTrainningLevelAttackNetTask2.Result);
			};
			heroTrainningLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x0033B008 File Offset: 0x00339208
		private void StartHeroPhantomLevelAttackNetTask(ConfigDataHeroPhantomLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroPhantomLevelAttackNetTaskConfigDataHeroPhantomLevelInfo_hotfix != null)
			{
				this.m_StartHeroPhantomLevelAttackNetTaskConfigDataHeroPhantomLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroPhantomLevelAttackNetTask heroPhantomLevelAttackNetTask = new HeroPhantomLevelAttackNetTask(levelInfo.ID);
			heroPhantomLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				HeroPhantomLevelAttackNetTask heroPhantomLevelAttackNetTask2 = task as HeroPhantomLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(heroPhantomLevelAttackNetTask2.Result);
			};
			heroPhantomLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x0033B0A0 File Offset: 0x003392A0
		private void StartTreasureLevelAttackNetTask(ConfigDataTreasureLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTreasureLevelAttackNetTaskConfigDataTreasureLevelInfo_hotfix != null)
			{
				this.m_StartTreasureLevelAttackNetTaskConfigDataTreasureLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TreasureLevelUINetTask treasureLevelUINetTask = new TreasureLevelUINetTask(levelInfo.ID);
			treasureLevelUINetTask.EventOnStop += delegate(Task task)
			{
				TreasureLevelUINetTask treasureLevelUINetTask2 = task as TreasureLevelUINetTask;
				this.HandleLevelAttackNetTaskResult(treasureLevelUINetTask2.Result);
			};
			treasureLevelUINetTask.Start(null);
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x0033B138 File Offset: 0x00339338
		private void StartUnchartedScoreLevelAttackNetTask(ConfigDataScoreLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUnchartedScoreLevelAttackNetTaskConfigDataScoreLevelInfo_hotfix != null)
			{
				this.m_StartUnchartedScoreLevelAttackNetTaskConfigDataScoreLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScoreScoreLevelAttackNetTask unchartedScoreScoreLevelAttackNetTask = new UnchartedScoreScoreLevelAttackNetTask(levelInfo.UnchartedScoreInfo.ID, levelInfo.ID);
			unchartedScoreScoreLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				UnchartedScoreScoreLevelAttackNetTask unchartedScoreScoreLevelAttackNetTask2 = task as UnchartedScoreScoreLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(unchartedScoreScoreLevelAttackNetTask2.Result);
			};
			unchartedScoreScoreLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x0033B1DC File Offset: 0x003393DC
		private void StartUnchartedChallengeLevelAttackNetTask(ConfigDataChallengeLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUnchartedChallengeLevelAttackNetTaskConfigDataChallengeLevelInfo_hotfix != null)
			{
				this.m_StartUnchartedChallengeLevelAttackNetTaskConfigDataChallengeLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScoreChallengeLevelAttackNetTask unchartedScoreChallengeLevelAttackNetTask = new UnchartedScoreChallengeLevelAttackNetTask(levelInfo.UnchartedScoreInfo.ID, levelInfo.ID);
			unchartedScoreChallengeLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				UnchartedScoreChallengeLevelAttackNetTask unchartedScoreChallengeLevelAttackNetTask2 = task as UnchartedScoreChallengeLevelAttackNetTask;
				this.HandleLevelAttackNetTaskResult(unchartedScoreChallengeLevelAttackNetTask2.Result);
			};
			unchartedScoreChallengeLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x0033B280 File Offset: 0x00339480
		private void StartClimbTowerLevelAttackNetTask(ConfigDataTowerFloorInfo floorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClimbTowerLevelAttackNetTaskConfigDataTowerFloorInfo_hotfix != null)
			{
				this.m_StartClimbTowerLevelAttackNetTaskConfigDataTowerFloorInfo_hotfix.call(new object[]
				{
					this,
					floorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerLevelAttackNetTask climbTowerLevelAttackNetTask = new ClimbTowerLevelAttackNetTask(floorInfo.ID);
			climbTowerLevelAttackNetTask.EventOnStop += delegate(Task task)
			{
				ClimbTowerLevelAttackNetTask climbTowerLevelAttackNetTask2 = task as ClimbTowerLevelAttackNetTask;
				if (climbTowerLevelAttackNetTask2.Result == -5403)
				{
					this.ShowErrorMessageAndExitBattle(StringTableId.StringTableId_ClimbTower_Flush);
				}
				else
				{
					this.HandleLevelAttackNetTaskResult(climbTowerLevelAttackNetTask2.Result);
				}
			};
			climbTowerLevelAttackNetTask.Start(null);
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x0033B318 File Offset: 0x00339518
		private void StartGuildMassiveCombatAttackNetTask(ConfigDataGuildMassiveCombatLevelInfo levelInfo, List<int> heroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGuildMassiveCombatAttackNetTaskConfigDataGuildMassiveCombatLevelInfoList`1_hotfix != null)
			{
				this.m_StartGuildMassiveCombatAttackNetTaskConfigDataGuildMassiveCombatLevelInfoList`1_hotfix.call(new object[]
				{
					this,
					levelInfo,
					heroIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildMassiveCombatAttackNetTask guildMassiveCombatAttackNetTask = new GuildMassiveCombatAttackNetTask(levelInfo.ID, heroIds);
			guildMassiveCombatAttackNetTask.EventOnStop += delegate(Task task)
			{
				GuildMassiveCombatAttackNetTask guildMassiveCombatAttackNetTask2 = task as GuildMassiveCombatAttackNetTask;
				this.HandleLevelAttackNetTaskResult(guildMassiveCombatAttackNetTask2.Result);
			};
			guildMassiveCombatAttackNetTask.Start(null);
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x0033B3C0 File Offset: 0x003395C0
		private void StartArenaOpponentAttackFightingNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaOpponentAttackFightingNetTask_hotfix != null)
			{
				this.m_StartArenaOpponentAttackFightingNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaOpponentAttackFightingNetTask arenaOpponentAttackFightingNetTask = new ArenaOpponentAttackFightingNetTask();
			arenaOpponentAttackFightingNetTask.EventOnStop += delegate(Task task)
			{
				ArenaOpponentAttackFightingNetTask arenaOpponentAttackFightingNetTask2 = task as ArenaOpponentAttackFightingNetTask;
				if (arenaOpponentAttackFightingNetTask2.Result == -2018)
				{
					this.ShowErrorMessageAndExitBattle(StringTableId.StringTableId_Arena_CanNotStartArenaBattle);
				}
				else
				{
					this.HandleLevelAttackNetTaskResult(arenaOpponentAttackFightingNetTask2.Result);
				}
			};
			arenaOpponentAttackFightingNetTask.Start(null);
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x0033B440 File Offset: 0x00339640
		private void HandleLevelAttackNetTaskResult(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleLevelAttackNetTaskResultInt32_hotfix != null)
			{
				this.m_HandleLevelAttackNetTaskResultInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result == 0)
			{
				this.StartBattleLoadState();
			}
			else if (result == -900)
			{
				this.BattlePrepareUIController_OnStart();
			}
			else
			{
				this.ShowErrorMessageAndExitBattle(result);
			}
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x0033B4E0 File Offset: 0x003396E0
		private void StartWayPointBattleFinishedNetTask(ConfigDataWaypointInfo wayPointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartWayPointBattleFinishedNetTaskConfigDataWaypointInfo_hotfix != null)
			{
				this.m_StartWayPointBattleFinishedNetTaskConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					wayPointInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LevelWayPointBattleFinishNetTask levelWayPointBattleFinishNetTask = new LevelWayPointBattleFinishNetTask(wayPointInfo.ID, this.m_battleReport);
			levelWayPointBattleFinishNetTask.EventOnStop += delegate(Task task)
			{
				LevelWayPointBattleFinishNetTask levelWayPointBattleFinishNetTask2 = task as LevelWayPointBattleFinishNetTask;
				this.HandleBattleFinishedNetTaskResult(levelWayPointBattleFinishNetTask2.Result, levelWayPointBattleFinishNetTask2.IsWin, levelWayPointBattleFinishNetTask2.Reward, 0, false, null, null);
			};
			levelWayPointBattleFinishNetTask.Start(null);
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x0033B57C File Offset: 0x0033977C
		private void StartRiftLevelBattleFinishedNetTask(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRiftLevelBattleFinishedNetTaskConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_StartRiftLevelBattleFinishedNetTaskConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo levelInfo = levelInfo2;
			BattleUITask $this = this;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			RiftLevelBattleFinishedNetTask riftLevelBattleFinishedNetTask = new RiftLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			riftLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				RiftLevelBattleFinishedNetTask riftLevelBattleFinishedNetTask2 = task as RiftLevelBattleFinishedNetTask;
				if (levelInfo.LevelType == RiftLevelType.RiftLevelType_Scenario)
				{
					$this.HandleBattleFinishedNetTaskResult(riftLevelBattleFinishedNetTask2.Result, riftLevelBattleFinishedNetTask2.Stars > 0, riftLevelBattleFinishedNetTask2.Reward, riftLevelBattleFinishedNetTask2.Stars, riftLevelBattleFinishedNetTask2.IsFirstWin, riftLevelBattleFinishedNetTask2.Achievements, playerContext.Happening.RiftLevelInfo.m_achievements);
				}
				else if (levelInfo.LevelType == RiftLevelType.RiftLevelType_Event)
				{
					$this.HandleBattleFinishedNetTaskResult(riftLevelBattleFinishedNetTask2.Result, riftLevelBattleFinishedNetTask2.Stars > 0, riftLevelBattleFinishedNetTask2.Reward, 0, false, riftLevelBattleFinishedNetTask2.Achievements, playerContext.Happening.RiftLevelInfo.m_achievements);
				}
			};
			riftLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x0033B648 File Offset: 0x00339848
		private void StartHeroDungeonLevelBattleFinishedNetTask(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonLevelBattleFinishedNetTaskConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_StartHeroDungeonLevelBattleFinishedNetTaskConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			HeroDungeonLevelBattleFinishedNetTask heroDungeonLevelBattleFinishedNetTask = new HeroDungeonLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			heroDungeonLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				HeroDungeonLevelBattleFinishedNetTask heroDungeonLevelBattleFinishedNetTask2 = task as HeroDungeonLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(heroDungeonLevelBattleFinishedNetTask2.Result, heroDungeonLevelBattleFinishedNetTask2.Stars > 0, heroDungeonLevelBattleFinishedNetTask2.Reward, heroDungeonLevelBattleFinishedNetTask2.Stars, heroDungeonLevelBattleFinishedNetTask2.IsFirstWin, heroDungeonLevelBattleFinishedNetTask2.Achievements, playerContext.Happening.HeroDungeonLevelInfo.m_achievements);
			};
			heroDungeonLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x0033B708 File Offset: 0x00339908
		private void StartAnikiLevelBattleFinishedNetTask(ConfigDataAnikiLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartAnikiLevelBattleFinishedNetTaskConfigDataAnikiLevelInfo_hotfix != null)
			{
				this.m_StartAnikiLevelBattleFinishedNetTaskConfigDataAnikiLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AnikiLevelBattleFinishedNetTask anikiLevelBattleFinishedNetTask = new AnikiLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			anikiLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				AnikiLevelBattleFinishedNetTask anikiLevelBattleFinishedNetTask2 = task as AnikiLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(anikiLevelBattleFinishedNetTask2.Result, anikiLevelBattleFinishedNetTask2.IsWin, anikiLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			anikiLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x0033B7A4 File Offset: 0x003399A4
		private void StartThearchyLevelBattleFinishedNetTask(ConfigDataThearchyTrialLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartThearchyLevelBattleFinishedNetTaskConfigDataThearchyTrialLevelInfo_hotfix != null)
			{
				this.m_StartThearchyLevelBattleFinishedNetTaskConfigDataThearchyTrialLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ThearchyLevelBattleFinishedNetTask thearchyLevelBattleFinishedNetTask = new ThearchyLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			thearchyLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				ThearchyLevelBattleFinishedNetTask thearchyLevelBattleFinishedNetTask2 = task as ThearchyLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(thearchyLevelBattleFinishedNetTask2.Result, thearchyLevelBattleFinishedNetTask2.IsWin, thearchyLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			thearchyLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x0033B840 File Offset: 0x00339A40
		private void StartTreasureLevelBattleFinishedNetTask(ConfigDataTreasureLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTreasureLevelBattleFinishedNetTaskConfigDataTreasureLevelInfo_hotfix != null)
			{
				this.m_StartTreasureLevelBattleFinishedNetTaskConfigDataTreasureLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TreasureLevelBattleFinishedNetTask treasureLevelBattleFinishedNetTask = new TreasureLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			treasureLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				TreasureLevelBattleFinishedNetTask treasureLevelBattleFinishedNetTask2 = task as TreasureLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(treasureLevelBattleFinishedNetTask2.Result, treasureLevelBattleFinishedNetTask2.IsWin, treasureLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			treasureLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x0033B8DC File Offset: 0x00339ADC
		private void StartMemoryCorridorLevelBattleFinishedNetTask(ConfigDataMemoryCorridorLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartMemoryCorridorLevelBattleFinishedNetTaskConfigDataMemoryCorridorLevelInfo_hotfix != null)
			{
				this.m_StartMemoryCorridorLevelBattleFinishedNetTaskConfigDataMemoryCorridorLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MemoryCorridorLevelBattleFinishedNetTask memoryCorridorLevelBattleFinishedNetTask = new MemoryCorridorLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			memoryCorridorLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				MemoryCorridorLevelBattleFinishedNetTask memoryCorridorLevelBattleFinishedNetTask2 = task as MemoryCorridorLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(memoryCorridorLevelBattleFinishedNetTask2.Result, memoryCorridorLevelBattleFinishedNetTask2.IsWin, memoryCorridorLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			memoryCorridorLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x0033B978 File Offset: 0x00339B78
		private void StartHeroTrainningLevelBattleFinishedNetTask(ConfigDataHeroTrainningLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroTrainningLevelBattleFinishedNetTaskConfigDataHeroTrainningLevelInfo_hotfix != null)
			{
				this.m_StartHeroTrainningLevelBattleFinishedNetTaskConfigDataHeroTrainningLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroTrainningLevelBattleFinishedNetTask heroTrainningLevelBattleFinishedNetTask = new HeroTrainningLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			heroTrainningLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				HeroTrainningLevelBattleFinishedNetTask heroTrainningLevelBattleFinishedNetTask2 = task as HeroTrainningLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(heroTrainningLevelBattleFinishedNetTask2.Result, heroTrainningLevelBattleFinishedNetTask2.IsWin, heroTrainningLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			heroTrainningLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x0033BA14 File Offset: 0x00339C14
		private void StartHeroPhantomLevelBattleFinishedNetTask(ConfigDataHeroPhantomLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroPhantomLevelBattleFinishedNetTaskConfigDataHeroPhantomLevelInfo_hotfix != null)
			{
				this.m_StartHeroPhantomLevelBattleFinishedNetTaskConfigDataHeroPhantomLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			HeroPhantomLevelBattleFinishedNetTask heroPhantomLevelBattleFinishedNetTask = new HeroPhantomLevelBattleFinishedNetTask(levelInfo.ID, this.m_battleReport);
			heroPhantomLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				HeroPhantomLevelBattleFinishedNetTask heroPhantomLevelBattleFinishedNetTask2 = task as HeroPhantomLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(heroPhantomLevelBattleFinishedNetTask2.Result, heroPhantomLevelBattleFinishedNetTask2.IsWin, heroPhantomLevelBattleFinishedNetTask2.Reward, 0, heroPhantomLevelBattleFinishedNetTask2.IsFirstWin, heroPhantomLevelBattleFinishedNetTask2.Achievements, playerContext.Happening.HeroPhantomLevelInfo.m_achievements);
			};
			heroPhantomLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x0033BAD4 File Offset: 0x00339CD4
		private void StartUnchartedScoreLevelBattleFinishedNetTask(ConfigDataScoreLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUnchartedScoreLevelBattleFinishedNetTaskConfigDataScoreLevelInfo_hotfix != null)
			{
				this.m_StartUnchartedScoreLevelBattleFinishedNetTaskConfigDataScoreLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScoreScoreLevelBattleFinishedNetTask unchartedScoreScoreLevelBattleFinishedNetTask = new UnchartedScoreScoreLevelBattleFinishedNetTask(levelInfo.UnchartedScoreInfo.ID, levelInfo.ID, this.m_battleReport);
			unchartedScoreScoreLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				UnchartedScoreScoreLevelBattleFinishedNetTask unchartedScoreScoreLevelBattleFinishedNetTask2 = task as UnchartedScoreScoreLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(unchartedScoreScoreLevelBattleFinishedNetTask2.Result, unchartedScoreScoreLevelBattleFinishedNetTask2.IsWin, unchartedScoreScoreLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			unchartedScoreScoreLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x0033BB7C File Offset: 0x00339D7C
		private void StartUnchartedChallengeLevelBattleFinishedNetTask(ConfigDataChallengeLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUnchartedChallengeLevelBattleFinishedNetTaskConfigDataChallengeLevelInfo_hotfix != null)
			{
				this.m_StartUnchartedChallengeLevelBattleFinishedNetTaskConfigDataChallengeLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScoreChallengeLevelBattleFinishedNetTask unchartedScoreChallengeLevelBattleFinishedNetTask = new UnchartedScoreChallengeLevelBattleFinishedNetTask(levelInfo.UnchartedScoreInfo.ID, levelInfo.ID, this.m_battleReport);
			unchartedScoreChallengeLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				UnchartedScoreChallengeLevelBattleFinishedNetTask unchartedScoreChallengeLevelBattleFinishedNetTask2 = task as UnchartedScoreChallengeLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(unchartedScoreChallengeLevelBattleFinishedNetTask2.Result, unchartedScoreChallengeLevelBattleFinishedNetTask2.IsWin, unchartedScoreChallengeLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			unchartedScoreChallengeLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x0033BC24 File Offset: 0x00339E24
		private void StartClimbTowerLevelBattleFinishedNetTask(ConfigDataTowerFloorInfo floorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClimbTowerLevelBattleFinishedNetTaskConfigDataTowerFloorInfo_hotfix != null)
			{
				this.m_StartClimbTowerLevelBattleFinishedNetTaskConfigDataTowerFloorInfo_hotfix.call(new object[]
				{
					this,
					floorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerLevelBattleFinishedNetTask climbTowerLevelBattleFinishedNetTask = new ClimbTowerLevelBattleFinishedNetTask(floorInfo.ID, this.m_battleReport);
			climbTowerLevelBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				ClimbTowerLevelBattleFinishedNetTask climbTowerLevelBattleFinishedNetTask2 = task as ClimbTowerLevelBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(climbTowerLevelBattleFinishedNetTask2.Result, climbTowerLevelBattleFinishedNetTask2.IsWin, climbTowerLevelBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			climbTowerLevelBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x0033BCC0 File Offset: 0x00339EC0
		private void StartGuildMassiveCombatSinglePVEBattleEndNetTask(ConfigDataGuildMassiveCombatLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGuildMassiveCombatSinglePVEBattleEndNetTaskConfigDataGuildMassiveCombatLevelInfo_hotfix != null)
			{
				this.m_StartGuildMassiveCombatSinglePVEBattleEndNetTaskConfigDataGuildMassiveCombatLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildMassiveCombatSinglePVEBattleEndNetTask guildMassiveCombatSinglePVEBattleEndNetTask = new GuildMassiveCombatSinglePVEBattleEndNetTask(levelInfo.ID, this.m_battleReport);
			guildMassiveCombatSinglePVEBattleEndNetTask.EventOnStop += delegate(Task task)
			{
				GuildMassiveCombatSinglePVEBattleEndNetTask guildMassiveCombatSinglePVEBattleEndNetTask2 = task as GuildMassiveCombatSinglePVEBattleEndNetTask;
				this.HandleBattleFinishedNetTaskResult(guildMassiveCombatSinglePVEBattleEndNetTask2.Result, guildMassiveCombatSinglePVEBattleEndNetTask2.IsWin, guildMassiveCombatSinglePVEBattleEndNetTask2.Reward, 0, false, null, null);
			};
			guildMassiveCombatSinglePVEBattleEndNetTask.Start(null);
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x0033BD5C File Offset: 0x00339F5C
		private void StartArenaBattleFinishedNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleFinishedNetTask_hotfix != null)
			{
				this.m_StartArenaBattleFinishedNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaBattleFinishedNetTask arenaBattleFinishedNetTask = new ArenaBattleFinishedNetTask(this.m_battleReport);
			arenaBattleFinishedNetTask.EventOnStop += delegate(Task task)
			{
				ArenaBattleFinishedNetTask arenaBattleFinishedNetTask2 = task as ArenaBattleFinishedNetTask;
				this.HandleBattleFinishedNetTaskResult(arenaBattleFinishedNetTask2.Result, arenaBattleFinishedNetTask2.IsWin, arenaBattleFinishedNetTask2.Reward, 0, false, null, null);
			};
			arenaBattleFinishedNetTask.Start(null);
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x0033BDE4 File Offset: 0x00339FE4
		private void HandleBattleFinishedNetTaskResult(int result, bool isWin, BattleReward reward, int stars = 0, bool isFirstWin = false, List<int> gotAchievements = null, BattleLevelAchievement[] achievements = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleBattleFinishedNetTaskResultInt32BooleanBattleRewardInt32BooleanList`1BattleLevelAchievementbe_hotfix != null)
			{
				this.m_HandleBattleFinishedNetTaskResultInt32BooleanBattleRewardInt32BooleanList`1BattleLevelAchievementbe_hotfix.call(new object[]
				{
					this,
					result,
					isWin,
					reward,
					stars,
					isFirstWin,
					gotAchievements,
					achievements
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("BattleUITask.HandleBattleFinishedNetTaskResult, result:" + result);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (result == 0)
			{
				BattleType battleType = projectLPlayerContext.CurrentBattle.BattleType;
				if (isWin)
				{
					this.ShowBattleResult(battleType, stars, reward, isFirstWin, gotAchievements, achievements);
				}
				else
				{
					projectLPlayerContext.Happening.Step = HappeningStep.BattleLoseOrCancel;
					if (battleType == BattleType.ArenaAttack)
					{
						this.ShowBattleResult(BattleType.ArenaAttack, 0, reward, false, null, null);
					}
					else if (battleType == BattleType.RealTimePVP)
					{
						this.ShowBattleResult(BattleType.RealTimePVP, 0, reward, false, null, null);
					}
					else
					{
						this.ShowBattleLose();
					}
				}
				if (this.CanUseDanmaku())
				{
					this.StartDanmakuPostNetTask(null);
				}
			}
			else
			{
				this.ShowErrorMessageAndExitBattle(result);
			}
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x0033BF68 File Offset: 0x0033A168
		private void StartBattleCancelNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleCancelNetTask_hotfix != null)
			{
				this.m_StartBattleCancelNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleCancelNetTask battleCancelNetTask = new BattleCancelNetTask();
			battleCancelNetTask.EventOnStop += delegate(Task task)
			{
				BattleCancelNetTask battleCancelNetTask2 = task as BattleCancelNetTask;
				if (battleCancelNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(battleCancelNetTask2.Result, 2f, null, true);
				}
				if (battleCancelNetTask2.Result != -99)
				{
					if (this.CanUseDanmaku())
					{
						this.StartDanmakuPostNetTask(delegate(int result)
						{
							this.ExitBattleReturnToWorld();
						});
					}
					else
					{
						this.ExitBattleReturnToWorld();
					}
				}
			};
			battleCancelNetTask.Start(null);
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x0033BFE8 File Offset: 0x0033A1E8
		private void StartDanmakuPostNetTask(Action<int> onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartDanmakuPostNetTaskAction`1_hotfix != null)
			{
				this.m_StartDanmakuPostNetTaskAction`1_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<int> onEnd = onEnd2;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			GameFunctionType gameFunctionType = GameFunctionType.GameFunctionType_None;
			int locationId = 0;
			playerContext.Happening.GetGameFunctionTypeAndLocationId(out gameFunctionType, out locationId);
			bool flag = true;
			if (gameFunctionType != GameFunctionType.GameFunctionType_None)
			{
				List<PostDanmakuEntry> postedLevelDanmaku = playerContext.GetPostedLevelDanmaku();
				if (postedLevelDanmaku != null && postedLevelDanmaku.Count > 0 && playerContext.CanPostLevelDanmaku((int)gameFunctionType, locationId, postedLevelDanmaku) == 0)
				{
					flag = false;
					DanmakuPostNetTask danmakuPostNetTask = new DanmakuPostNetTask((int)gameFunctionType, locationId, postedLevelDanmaku);
					danmakuPostNetTask.EventOnStop += delegate(Task task)
					{
						DanmakuPostNetTask danmakuPostNetTask2 = task as DanmakuPostNetTask;
						if (danmakuPostNetTask2.Result != 0)
						{
							CommonUIController.Instance.ShowErrorMessage(danmakuPostNetTask2.Result, 2f, null, true);
						}
						playerContext.ClearLevelDanmaku();
						if (onEnd != null)
						{
							onEnd(danmakuPostNetTask2.Result);
						}
					};
					danmakuPostNetTask.Start(null);
				}
			}
			if (flag)
			{
				playerContext.ClearLevelDanmaku();
				if (onEnd != null)
				{
					onEnd(0);
				}
			}
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x0033C130 File Offset: 0x0033A330
		private void StartBattleRoomHeroSetupNetTask(int heroId, int position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomHeroSetupNetTaskInt32Int32_hotfix != null)
			{
				this.m_StartBattleRoomHeroSetupNetTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomHeroSetupNetTask battleRoomHeroSetupNetTask = new BattleRoomHeroSetupNetTask(heroId, position);
			battleRoomHeroSetupNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomHeroSetupNetTask battleRoomHeroSetupNetTask2 = task as BattleRoomHeroSetupNetTask;
				if (battleRoomHeroSetupNetTask2.Result != 0)
				{
					if (battleRoomHeroSetupNetTask2.Result == -926)
					{
						this.ShowErrorMessageAndExitBattle(battleRoomHeroSetupNetTask2.Result);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleRoomHeroSetupNetTask2.Result, 2f, null, true);
					}
				}
			};
			battleRoomHeroSetupNetTask.Start(null);
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x0033C1D4 File Offset: 0x0033A3D4
		private void StartBattleRoomHeroSwapNetTask(int position1, int position2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomHeroSwapNetTaskInt32Int32_hotfix != null)
			{
				this.m_StartBattleRoomHeroSwapNetTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					position1,
					position2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomHeroSwapNetTask battleRoomHeroSwapNetTask = new BattleRoomHeroSwapNetTask(position1, position2);
			battleRoomHeroSwapNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomHeroSwapNetTask battleRoomHeroSwapNetTask2 = task as BattleRoomHeroSwapNetTask;
				if (battleRoomHeroSwapNetTask2.Result != 0)
				{
					if (battleRoomHeroSwapNetTask2.Result == -926)
					{
						this.ShowErrorMessageAndExitBattle(battleRoomHeroSwapNetTask2.Result);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleRoomHeroSwapNetTask2.Result, 2f, null, true);
					}
				}
			};
			battleRoomHeroSwapNetTask.Start(null);
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x0033C278 File Offset: 0x0033A478
		private void StartBattleRoomHeroSetoffNetTask(int position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomHeroSetoffNetTaskInt32_hotfix != null)
			{
				this.m_StartBattleRoomHeroSetoffNetTaskInt32_hotfix.call(new object[]
				{
					this,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomHeroPutdownNetTask battleRoomHeroPutdownNetTask = new BattleRoomHeroPutdownNetTask(position);
			battleRoomHeroPutdownNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomHeroPutdownNetTask battleRoomHeroPutdownNetTask2 = task as BattleRoomHeroPutdownNetTask;
				if (battleRoomHeroPutdownNetTask2.Result != 0)
				{
					if (battleRoomHeroPutdownNetTask2.Result == -926)
					{
						this.ShowErrorMessageAndExitBattle(battleRoomHeroPutdownNetTask2.Result);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleRoomHeroPutdownNetTask2.Result, 2f, null, true);
					}
				}
			};
			battleRoomHeroPutdownNetTask.Start(null);
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x0033C30C File Offset: 0x0033A50C
		private void StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus status, Action onOk)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomPlayerStatusChangeNetTaskPlayerBattleStatusAction_hotfix != null)
			{
				this.m_StartBattleRoomPlayerStatusChangeNetTaskPlayerBattleStatusAction_hotfix.call(new object[]
				{
					this,
					status,
					onOk2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onOk = onOk2;
			BattleUITask $this = this;
			BattleRoomPlayerStatusChangeNetTask battleRoomPlayerStatusChangeNetTask = new BattleRoomPlayerStatusChangeNetTask(status);
			battleRoomPlayerStatusChangeNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomPlayerStatusChangeNetTask battleRoomPlayerStatusChangeNetTask2 = task as BattleRoomPlayerStatusChangeNetTask;
				if (battleRoomPlayerStatusChangeNetTask2.Result == 0)
				{
					if (onOk != null)
					{
						onOk();
					}
				}
				else if (battleRoomPlayerStatusChangeNetTask2.Result == -926)
				{
					$this.ShowErrorMessageAndExitBattle(battleRoomPlayerStatusChangeNetTask2.Result);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(battleRoomPlayerStatusChangeNetTask2.Result, 2f, null, true);
				}
			};
			battleRoomPlayerStatusChangeNetTask.Start(null);
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x0033C3C4 File Offset: 0x0033A5C4
		private void StartBattleRoomQuitNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomQuitNetTask_hotfix != null)
			{
				this.m_StartBattleRoomQuitNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomQuitNetTask battleRoomQuitNetTask = new BattleRoomQuitNetTask();
			battleRoomQuitNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomQuitNetTask battleRoomQuitNetTask2 = task as BattleRoomQuitNetTask;
				if (battleRoomQuitNetTask2.Result != 0)
				{
					if (battleRoomQuitNetTask2.Result == -926)
					{
						this.ShowErrorMessageAndExitBattle(battleRoomQuitNetTask2.Result);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleRoomQuitNetTask2.Result, 2f, null, true);
					}
				}
			};
			battleRoomQuitNetTask.Start(null);
		}

		// Token: 0x0600B830 RID: 47152 RVA: 0x0033C444 File Offset: 0x0033A644
		private void StartBattleRoomEndCurrentBPTurnNetTask(Action onOk)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomEndCurrentBPTurnNetTaskAction_hotfix != null)
			{
				this.m_StartBattleRoomEndCurrentBPTurnNetTaskAction_hotfix.call(new object[]
				{
					this,
					onOk2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onOk = onOk2;
			BattleUITask $this = this;
			BattleRoomEndCurrentBPTurnNetTask battleRoomEndCurrentBPTurnNetTask = new BattleRoomEndCurrentBPTurnNetTask();
			battleRoomEndCurrentBPTurnNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomEndCurrentBPTurnNetTask battleRoomEndCurrentBPTurnNetTask2 = task as BattleRoomEndCurrentBPTurnNetTask;
				if (battleRoomEndCurrentBPTurnNetTask2.Result == 0)
				{
					if (onOk != null)
					{
						onOk();
					}
				}
				else if (battleRoomEndCurrentBPTurnNetTask2.Result == -926)
				{
					$this.ShowErrorMessageAndExitBattle(battleRoomEndCurrentBPTurnNetTask2.Result);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(battleRoomEndCurrentBPTurnNetTask2.Result, 2f, null, true);
				}
			};
			battleRoomEndCurrentBPTurnNetTask.Start(null);
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x0033C4E8 File Offset: 0x0033A6E8
		private void StartBattleRoomPlayerActionBeginNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleRoomPlayerActionBeginNetTask_hotfix != null)
			{
				this.m_StartBattleRoomPlayerActionBeginNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomPlayerActionBeginNetTask battleRoomPlayerActionBeginNetTask = new BattleRoomPlayerActionBeginNetTask();
			battleRoomPlayerActionBeginNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomPlayerActionBeginNetTask battleRoomPlayerActionBeginNetTask2 = task as BattleRoomPlayerActionBeginNetTask;
				if (battleRoomPlayerActionBeginNetTask2.Result != 0)
				{
					if (battleRoomPlayerActionBeginNetTask2.Result == -926)
					{
						this.ShowErrorMessageAndExitBattle(battleRoomPlayerActionBeginNetTask2.Result);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(battleRoomPlayerActionBeginNetTask2.Result, 2f, null, true);
					}
				}
			};
			battleRoomPlayerActionBeginNetTask.Start(null);
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x0033C568 File Offset: 0x0033A768
		public void PrepareBattleUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareBattleUI_hotfix != null)
			{
				this.m_PrepareBattleUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("BattleUITask.PrepareBattleUI");
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				UIUtility.ActivateLayer(this.m_battleRoomUIController, true);
				this.m_battleRoomUIController.AddPlayers(battleRoom);
				this.m_battleRoomUIController.SetCanUseChat(this.CanUseChat());
				if (battleRoom.IsRealTimePVPBattleRoomType())
				{
					UIUtility.ActivateLayer(this.m_pvpBattlePrepareUIController, true);
					this.m_battlePrepareUIController.ShowStartButton(battleRoom.BattleRoomType == BattleRoomType.RealTimePVPDefaultMode);
				}
			}
			UIUtility.ActivateLayer(this.m_battleUIController, false);
			UIUtility.ActivateLayer(this.m_battleDanmakuUIController, false);
			UIUtility.ActivateLayer(this.m_battleActorInfoUIController, false);
			UIUtility.ActivateLayer(this.m_actionOrderUIController, false);
			UIUtility.ActivateLayer(this.m_battlePauseUIController, false);
			UIUtility.ActivateLayer(this.m_battleTreasureDialogUIController, false);
			UIUtility.ActivateLayer(this.m_combatUIController, false);
			UIUtility.ActivateLayer(this.m_preCombatUIController, false);
			UIUtility.ActivateLayer(this.m_battlePrepareUIController, true);
			UIUtility.ActivateLayer(this.m_battlePrepareActorInfoUIController, false);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			bool flag = false;
			if (projectLPlayerContext.IsNeedRebuildBattle())
			{
				if (currentBattle.ArenaBattleInfo != null)
				{
					ArenaBattleStatus arenaBattleStatus = projectLPlayerContext.GetArenaBattleStatus();
					if (arenaBattleStatus != ArenaBattleStatus.Ready)
					{
						if (arenaBattleStatus == ArenaBattleStatus.Fighting)
						{
							flag = true;
						}
					}
				}
				else if (battleRoom != null)
				{
					if (battleRoom.BattleRoomStatus == BattleRoomStatus.Fighting)
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			else if (currentBattle.ArenaBattleReport != null || currentBattle.RealTimePVPBattleReport != null)
			{
				flag = true;
			}
			else if (currentBattle.BattleInfo != null && currentBattle.BattleInfo.m_battlePerformInfo != null)
			{
				flag = true;
			}
			this.m_battleSceneUIController.PrepareBattle();
			this.m_battleMapUIController.PrepareBattle();
			this.m_battlePrepareUIController.PrepareBattle();
			this.m_battlePrepareUIController.SetStageActorCountMax(this.GetMyStageActorCountMax());
			this.m_battlePrepareUIController.ShowActionOrderButton(projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null);
			this.m_battlePrepareUIController.ShowChatButton(this.CanUseChat());
			ConfigDataTowerBattleRuleInfo towerBattleRuleInfo = this.GetTowerBattleRuleInfo();
			if (towerBattleRuleInfo != null)
			{
				this.m_battlePrepareUIController.ShowClimbTowerBattleRule(towerBattleRuleInfo);
			}
			this.SetupStageActors(flag);
			if (!flag && battleRoom == null)
			{
				this.SetupBattlePrepareTreasures();
			}
			List<GridPosition> reachRegion = this.SetupReachRegion(flag);
			this.SetupBattlePauseUIController(reachRegion);
			if (flag)
			{
				if (battleRoom == null)
				{
					this.BuildBattleTeamSetups();
					this.StartBattleLoadState();
				}
			}
			else if (currentBattle.BattleInfo != null && UserGuideUITask.NeedSkipBattlePrepareForUserGuide(currentBattle.BattleInfo.ID))
			{
				this.BattlePrepareUIController_OnStart();
			}
			else
			{
				if (currentBattle.BattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.BattleInfo.PrepareMusic);
				}
				else if (currentBattle.ArenaBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.ArenaBattleInfo.PrepareMusic);
				}
				else if (currentBattle.PVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.PVPBattleInfo.PrepareMusic);
				}
				else if (currentBattle.RealTimePVPBattleInfo != null)
				{
					AudioUtility.PlaySound(currentBattle.RealTimePVPBattleInfo.PrepareMusic);
				}
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				if (battleRoom != null)
				{
					if (battleRoom.IsRealTimePVPBattleRoomType())
					{
						this.m_battleMapUIController.HideStagePositions();
						this.m_pvpBattlePrepareUIController.ShowPrepareState(false);
						if (battleRoom.BattleRoomStatus == BattleRoomStatus.Ready)
						{
							bool isFirst = battleRoom.MyPlayerIndex == 0;
							this.m_pvpBattlePrepareUIController.ShowOrder(isFirst, delegate
							{
								this.ShowStagePositions();
								this.m_pvpBattlePrepareUIController.ShowPrepareState(true);
								this.UpdateRealtimePVPBattlePrepareStatus();
							});
						}
					}
					if (battleRoom.GetMyPlayer().PlayerBattleStatus == PlayerBattleStatus.Ready)
					{
						this.m_battlePrepareUIController.ShowTeamReadyWait(battleRoom.BattleRoomType);
					}
				}
			}
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x0033C94C File Offset: 0x0033AB4C
		private List<GridPosition> SetupReachRegion(bool isSkipBattlePrepare)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupReachRegionBoolean_hotfix != null)
			{
				return (List<GridPosition>)this.m_SetupReachRegionBoolean_hotfix.call(new object[]
				{
					this,
					isSkipBattlePrepare
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			List<GridPosition> list = null;
			if (currentBattle.BattleInfo != null)
			{
				foreach (ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo in currentBattle.BattleInfo.m_battleWinConditionInfos)
				{
					if (configDataBattleWinConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorReachPosition)
					{
						list = new List<GridPosition>();
						foreach (ParamPosition paramPosition in configDataBattleWinConditionInfo.Param3)
						{
							list.Add(new GridPosition(paramPosition.X, paramPosition.Y));
						}
						this.m_battleMapUIController.ShowReachRegion(list);
						break;
					}
					if (!isSkipBattlePrepare)
					{
						GridPosition winConditionTargetPosition = this.GetWinConditionTargetPosition(configDataBattleWinConditionInfo);
						if (winConditionTargetPosition != GridPosition.Null)
						{
							this.m_battleSceneUIController.ShowBattleWinCondition(configDataBattleWinConditionInfo, winConditionTargetPosition);
							break;
						}
					}
				}
				foreach (ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo in currentBattle.BattleInfo.m_battleLoseConditionInfos)
				{
					if (configDataBattleLoseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_ActorReachPosition && list == null)
					{
						list = new List<GridPosition>();
						foreach (ParamPosition paramPosition2 in configDataBattleLoseConditionInfo.Param3)
						{
							list.Add(new GridPosition(paramPosition2.X, paramPosition2.Y));
						}
						this.m_battleMapUIController.ShowReachRegion(list);
						break;
					}
				}
			}
			return list;
		}

		// Token: 0x0600B834 RID: 47156 RVA: 0x0033CB8C File Offset: 0x0033AD8C
		private void SetupBattlePauseUIController(List<GridPosition> reachRegion)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupBattlePauseUIControllerList`1_hotfix != null)
			{
				this.m_SetupBattlePauseUIControllerList`1_hotfix.call(new object[]
				{
					this,
					reachRegion
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			this.m_battlePauseUIController.ClearMapAll();
			this.m_battlePauseUIController.SetMap(this.m_clientBattle.Battle.Map);
			this.m_battlePauseUIController.SetTurn(0, 0);
			if (currentBattle.BattleInfo != null)
			{
				this.m_battlePauseUIController.SetWinLoseConditions(currentBattle.BattleInfo.WinDesc, currentBattle.BattleInfo.LoseDesc);
				this.m_battlePauseUIController.ShowStrategyButton(true);
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				this.m_battlePauseUIController.SetWinLoseConditions(currentBattle.ArenaDefendRuleInfo.WinDesc, currentBattle.ArenaDefendRuleInfo.LoseDesc);
				this.m_battlePauseUIController.ShowStrategyButton(false);
			}
			else if (currentBattle.PVPBattleInfo != null)
			{
				this.m_battlePauseUIController.SetWinLoseConditions(currentBattle.PVPBattleInfo.WinDesc, currentBattle.PVPBattleInfo.LoseDesc);
				this.m_battlePauseUIController.ShowStrategyButton(false);
			}
			else if (currentBattle.RealTimePVPBattleInfo != null)
			{
				this.m_battlePauseUIController.SetWinLoseConditions(currentBattle.RealTimePVPBattleInfo.WinDesc, currentBattle.RealTimePVPBattleInfo.LoseDesc);
				this.m_battlePauseUIController.ShowStrategyButton(false);
			}
			this.SetupBattlePauseUIAchievements();
			if (reachRegion != null)
			{
				this.m_battlePauseUIController.SetMapReachRegion(reachRegion);
			}
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x0033CD50 File Offset: 0x0033AF50
		private void SetupBattlePauseUIAchievements()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupBattlePauseUIAchievements_hotfix != null)
			{
				this.m_SetupBattlePauseUIAchievements_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.RiftLevelInfo != null)
			{
				this.m_battlePauseUIController.SetAchievement(projectLPlayerContext.Happening.RiftLevelInfo.m_achievements, BattleType.Rift);
				this.m_battlePauseUIController.SetAchievementCount(projectLPlayerContext.GetRiftLevelAchievementCount(projectLPlayerContext.Happening.RiftLevelInfo.ID), projectLPlayerContext.Happening.RiftLevelInfo.m_achievements.Length);
				if (projectLPlayerContext.Happening.RiftLevelInfo.LevelType == RiftLevelType.RiftLevelType_Scenario)
				{
					this.m_battlePauseUIController.SetStarCondition(projectLPlayerContext.Happening.BattleType, projectLPlayerContext.Happening.RiftLevelInfo.StarTurnMax, projectLPlayerContext.Happening.RiftLevelInfo.StarDeadMax);
				}
				else
				{
					this.m_battlePauseUIController.SetStarCondition(projectLPlayerContext.Happening.BattleType, -1, -1);
				}
			}
			else if (projectLPlayerContext.Happening.HeroDungeonLevelInfo != null)
			{
				this.m_battlePauseUIController.SetAchievement(projectLPlayerContext.Happening.HeroDungeonLevelInfo.m_achievements, BattleType.HeroDungeon);
				this.m_battlePauseUIController.SetAchievementCount(projectLPlayerContext.GetHeroDungeonLevelAchievementCount(projectLPlayerContext.Happening.HeroDungeonLevelInfo), projectLPlayerContext.Happening.HeroDungeonLevelInfo.m_achievements.Length);
				this.m_battlePauseUIController.SetStarCondition(projectLPlayerContext.Happening.BattleType, projectLPlayerContext.Happening.HeroDungeonLevelInfo.StarTurnMax, projectLPlayerContext.Happening.HeroDungeonLevelInfo.StarDeadMax);
			}
			else if (projectLPlayerContext.Happening.HeroPhantomLevelInfo != null)
			{
				this.m_battlePauseUIController.SetAchievement(projectLPlayerContext.Happening.HeroPhantomLevelInfo.m_achievements, BattleType.HeroPhantom);
				this.m_battlePauseUIController.SetAchievementCount(projectLPlayerContext.GetHeroPhantomLevelCompleteAchievementCount(projectLPlayerContext.Happening.HeroPhantomLevelInfo.ID), projectLPlayerContext.Happening.HeroPhantomLevelInfo.m_achievements.Length);
				this.m_battlePauseUIController.SetStarCondition(projectLPlayerContext.Happening.BattleType, -1, -1);
			}
			else
			{
				this.m_battlePauseUIController.SetAchievement(null, BattleType.None);
				this.m_battlePauseUIController.SetAchievementCount(0, 0);
				this.m_battlePauseUIController.SetStarCondition(projectLPlayerContext.Happening.BattleType, -1, -1);
			}
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x0033CFD4 File Offset: 0x0033B1D4
		private GridPosition GetWinConditionTargetPosition(ConfigDataBattleWinConditionInfo winConditionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix != null)
			{
				return (GridPosition)this.m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix.call(new object[]
				{
					this,
					winConditionInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition result = GridPosition.Null;
			if (winConditionInfo == null)
			{
				return result;
			}
			if (winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillActor)
			{
				if (winConditionInfo.Param1.Count > 0)
				{
					BattlePrepareStageActor stageActorByHeroId = this.m_battlePrepareUIController.GetStageActorByHeroId(winConditionInfo.Param1[0]);
					if (stageActorByHeroId != null)
					{
						result = stageActorByHeroId.GetPosition();
					}
				}
			}
			else if (winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorNotDead)
			{
				if (winConditionInfo.Param1.Count > 0)
				{
					BattlePrepareStageActor stageActorByHeroId2 = this.m_battlePrepareUIController.GetStageActorByHeroId(winConditionInfo.Param1[0]);
					if (stageActorByHeroId2 != null)
					{
						result = stageActorByHeroId2.GetPosition();
					}
				}
			}
			else if (winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorReachPosition && winConditionInfo.Param3.Count > 0)
			{
				result = new GridPosition(winConditionInfo.Param3[0].X, winConditionInfo.Param3[0].Y);
			}
			return result;
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x0033D134 File Offset: 0x0033B334
		private int GetMyStageActorCountMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMyStageActorCountMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMyStageActorCountMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			if (currentBattle.BattleInfo != null)
			{
				return currentBattle.BattleInfo.AllyNumber;
			}
			if (currentBattle.ArenaBattleInfo != null)
			{
				return currentBattle.ArenaBattleInfo.AttackNumber;
			}
			if (currentBattle.PVPBattleInfo != null)
			{
				BattleRoom battleRoom = this.GetBattleRoom();
				if (battleRoom != null)
				{
					if (battleRoom.MyPlayerIndex == 0)
					{
						return currentBattle.PVPBattleInfo.AttackNumber;
					}
					return currentBattle.PVPBattleInfo.DefendNumber;
				}
			}
			else if (currentBattle.RealTimePVPBattleInfo != null)
			{
				BattleRoom battleRoom2 = this.GetBattleRoom();
				if (battleRoom2 != null)
				{
					if (battleRoom2.MyPlayerIndex == 0)
					{
						return currentBattle.RealTimePVPBattleInfo.AttackNumber;
					}
					return currentBattle.RealTimePVPBattleInfo.DefendNumber;
				}
			}
			return 0;
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x0033D264 File Offset: 0x0033B464
		private List<int> SetupMyHeros(ConfigDataBattleInfo battleInfo, int number, bool isSkipBattlePrepare)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupMyHerosConfigDataBattleInfoInt32Boolean_hotfix != null)
			{
				return (List<int>)this.m_SetupMyHerosConfigDataBattleInfoInt32Boolean_hotfix.call(new object[]
				{
					this,
					battleInfo,
					number,
					isSkipBattlePrepare
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<int> list = new List<int>(projectLPlayerContext.GetBattleTeam(projectLPlayerContext.CurrentBattle.BattleType));
			if (!isSkipBattlePrepare)
			{
				List<int> list2 = null;
				GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.GetGuildPlayerMassiveCombatInfo();
				if (guildPlayerMassiveCombatInfo != null)
				{
					list2 = guildPlayerMassiveCombatInfo.UsedHeroIds;
				}
				if (list2 != null)
				{
					foreach (int item in list2)
					{
						list.Remove(item);
					}
				}
				if (battleInfo != null)
				{
					for (int i = 0; i < battleInfo.ImperativeBattleHeroes_ID.Count; i++)
					{
						int num = battleInfo.ImperativeBattleHeroes_ID[i];
						int num2 = list.IndexOf(num);
						if (num2 >= 0)
						{
							list[num2] = 0;
						}
						if (i < list.Count)
						{
							list[i] = num;
						}
						else
						{
							list.Add(num);
						}
					}
				}
				for (int j = 0; j < this.m_userGuideEnforceHeroIds.Count; j++)
				{
					int num3 = this.m_userGuideEnforceHeroIds[j];
					int num4 = list.IndexOf(num3);
					if (num4 >= 0)
					{
						list[num4] = 0;
					}
					if (j < list.Count)
					{
						list[j] = num3;
					}
					else
					{
						list.Add(num3);
					}
				}
				this.FillMyHeros(list, number, list2);
				int num5 = 0;
				while (num5 < this.m_userGuideEnforceHeroIds.Count && num5 < list.Count)
				{
					if (this.m_userGuideEnforceHeroIds[num5] == 999)
					{
						list[num5] = 0;
					}
					num5++;
				}
			}
			return list;
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x0033D4D0 File Offset: 0x0033B6D0
		private void FillMyHeros(List<int> heroIds, int count, List<int> disableHeroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FillMyHerosList`1Int32List`1_hotfix != null)
			{
				this.m_FillMyHerosList`1Int32List`1_hotfix.call(new object[]
				{
					this,
					heroIds,
					count,
					disableHeroIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int num in heroIds)
			{
				if (num != 0)
				{
					count--;
				}
			}
			if (count <= 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				int j;
				for (j = 0; j < heroIds.Count; j++)
				{
					if (heroIds[j] == 0)
					{
						break;
					}
				}
				BattleHero battleHero = null;
				foreach (BattleHero battleHero2 in this.m_playerBattleHeros)
				{
					if (!heroIds.Contains(battleHero2.HeroId))
					{
						if (disableHeroIds == null || !disableHeroIds.Contains(battleHero2.HeroId))
						{
							battleHero = battleHero2;
							break;
						}
					}
				}
				if (battleHero == null)
				{
					break;
				}
				if (j < heroIds.Count)
				{
					heroIds[j] = battleHero.HeroId;
				}
				else
				{
					heroIds.Add(battleHero.HeroId);
				}
			}
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x0033D6B4 File Offset: 0x0033B8B4
		private void SetupStageActors(bool isSkipBattlePrepare)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupStageActorsBoolean_hotfix != null)
			{
				this.m_SetupStageActorsBoolean_hotfix.call(new object[]
				{
					this,
					isSkipBattlePrepare
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			ConfigDataBattleInfo battleInfo = currentBattle.BattleInfo;
			ConfigDataArenaBattleInfo arenaBattleInfo = currentBattle.ArenaBattleInfo;
			ConfigDataPVPBattleInfo pvpbattleInfo = currentBattle.PVPBattleInfo;
			ConfigDataRealTimePVPBattleInfo realTimePVPBattleInfo = currentBattle.RealTimePVPBattleInfo;
			BattleRoom battleRoom = this.GetBattleRoom();
			List<ParamPosition> list = null;
			List<int> list2 = null;
			int num = 0;
			List<ParamPosition> list3 = null;
			List<int> list4 = null;
			if (battleInfo != null)
			{
				list = battleInfo.AllyPositions;
				list2 = battleInfo.AllyDirs;
				num = battleInfo.AllyNumber;
			}
			else if (arenaBattleInfo != null)
			{
				list = arenaBattleInfo.AttackPositions;
				list2 = arenaBattleInfo.AttackDirs;
				num = arenaBattleInfo.AttackNumber;
				list3 = arenaBattleInfo.DefendPositions;
				list4 = arenaBattleInfo.DefendDirs;
			}
			else if (pvpbattleInfo != null)
			{
				if (battleRoom.MyPlayerIndex == 0)
				{
					list = pvpbattleInfo.AttackPositions;
					list2 = pvpbattleInfo.AttackDirs;
					num = pvpbattleInfo.AttackNumber;
					list3 = pvpbattleInfo.DefendPositions;
					list4 = pvpbattleInfo.DefendDirs;
				}
				else
				{
					list = pvpbattleInfo.DefendPositions;
					list2 = pvpbattleInfo.DefendDirs;
					num = pvpbattleInfo.DefendNumber;
					list3 = pvpbattleInfo.AttackPositions;
					list4 = pvpbattleInfo.AttackDirs;
				}
			}
			else if (realTimePVPBattleInfo != null)
			{
				if (this.GetMyPlayerIndex() == 0)
				{
					list = realTimePVPBattleInfo.AttackPositions;
					list2 = realTimePVPBattleInfo.AttackDirs;
					num = realTimePVPBattleInfo.AttackNumber;
					list3 = realTimePVPBattleInfo.DefendPositions;
					list4 = realTimePVPBattleInfo.DefendDirs;
				}
				else
				{
					list = realTimePVPBattleInfo.DefendPositions;
					list2 = realTimePVPBattleInfo.DefendDirs;
					num = realTimePVPBattleInfo.DefendNumber;
					list3 = realTimePVPBattleInfo.AttackPositions;
					list4 = realTimePVPBattleInfo.AttackDirs;
				}
			}
			if (list == null)
			{
				global::Debug.LogError("SetupStageActors error, allyPositions is null.");
			}
			this.m_battlePrepareUIController.ClearHeros();
			this.m_battlePrepareUIController.ClearStageActors();
			this.m_battlePrepareUIController.ClearStagePositions();
			this.m_battlePrepareUIController.SkipStageActorGraphic(isSkipBattlePrepare);
			bool flag = this.m_battlePrepareUIController.IsTestOnStage();
			if (!isSkipBattlePrepare)
			{
				GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.GetGuildPlayerMassiveCombatInfo();
				if (BattleUITask.GetUnchartedScoreInfo() != null)
				{
					List<BattleHero> list5 = new List<BattleHero>();
					foreach (BattleHero battleHero in this.m_playerBattleHeros)
					{
						int heroUnchartedScoreBonus = BattleUITask.GetHeroUnchartedScoreBonus(battleHero);
						if (heroUnchartedScoreBonus > 0)
						{
							list5.Add(battleHero);
						}
					}
					List<BattleHero> list6 = list5;
					if (BattleUITask.<>f__mg$cache2 == null)
					{
						BattleUITask.<>f__mg$cache2 = new Comparison<BattleHero>(BattleUITask.CompareHeroUnchartdScoreBonus);
					}
					list6.Sort(BattleUITask.<>f__mg$cache2);
					foreach (BattleHero hero in list5)
					{
						this.m_battlePrepareUIController.AddHero(hero, StageActorTagType.ScoreBonus);
					}
					foreach (BattleHero battleHero2 in this.m_playerBattleHeros)
					{
						if (!list5.Contains(battleHero2))
						{
							this.m_battlePrepareUIController.AddHero(battleHero2, StageActorTagType.None);
						}
					}
				}
				else if (this.GetTowerBonusHeroGroupInfo() != null)
				{
					foreach (BattleHero hero2 in this.m_playerBattleHeros)
					{
						if (this.IsTowerPowerUpHero(hero2))
						{
							this.m_battlePrepareUIController.AddHero(hero2, StageActorTagType.PowerUp);
						}
					}
					foreach (BattleHero hero3 in this.m_playerBattleHeros)
					{
						if (!this.IsTowerPowerUpHero(hero3))
						{
							this.m_battlePrepareUIController.AddHero(hero3, StageActorTagType.None);
						}
					}
				}
				else if (guildPlayerMassiveCombatInfo != null)
				{
					foreach (BattleHero battleHero3 in this.m_playerBattleHeros)
					{
						if (!guildPlayerMassiveCombatInfo.UsedHeroIds.Contains(battleHero3.HeroId) && this.IsGuildMassiveCombatCampUpHero(battleHero3))
						{
							this.m_battlePrepareUIController.AddHero(battleHero3, StageActorTagType.CampUp);
						}
					}
					foreach (BattleHero battleHero4 in this.m_playerBattleHeros)
					{
						if (!guildPlayerMassiveCombatInfo.UsedHeroIds.Contains(battleHero4.HeroId) && !this.IsGuildMassiveCombatCampUpHero(battleHero4))
						{
							this.m_battlePrepareUIController.AddHero(battleHero4, StageActorTagType.None);
						}
					}
				}
				else
				{
					foreach (BattleHero hero4 in this.m_playerBattleHeros)
					{
						this.m_battlePrepareUIController.AddHero(hero4, StageActorTagType.None);
					}
				}
			}
			this.m_teamPositions0.Clear();
			this.m_teamPositions1.Clear();
			this.m_teamNpcPositions0.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				GridPosition gridPosition = new GridPosition(list[i].X, list[i].Y);
				int dir = 0;
				if (list2.Count > i)
				{
					dir = list2[i];
				}
				this.m_teamPositions0.Add(gridPosition);
				StagePositionType posType = StagePositionType.Me;
				if (battleRoom != null && battleRoom.IsTeamOrGuildMassiveCombatRoomType() && battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(i).PlayerIndex != battleRoom.MyPlayerIndex)
				{
					posType = StagePositionType.Teammate;
				}
				this.m_battlePrepareUIController.AddStagePosition(gridPosition, dir, posType);
			}
			if (pvpbattleInfo != null || realTimePVPBattleInfo != null)
			{
				for (int j = 0; j < list3.Count; j++)
				{
					GridPosition gridPosition2 = new GridPosition(list3[j].X, list3[j].Y);
					int dir2 = 0;
					if (list4.Count > j)
					{
						dir2 = list4[j];
					}
					this.m_battlePrepareUIController.AddStagePosition(gridPosition2, dir2, StagePositionType.Enemy);
					this.m_teamPositions1.Add(gridPosition2);
				}
			}
			if (currentBattle.ArenaBattleReport != null)
			{
				foreach (BattleHero battleHero5 in currentBattle.ArenaBattleReport.AttackerHeroes)
				{
					this.m_battlePrepareUIController.HeroOnStage(battleHero5, this.m_teamPositions0[battleHero5.ActionPositionIndex], 0, StagePositionType.Me, -1, StageActorTagType.None);
				}
			}
			else if (currentBattle.RealTimePVPBattleReport != null)
			{
				int myPlayerIndex = this.GetMyPlayerIndex();
				foreach (BattleHero battleHero6 in currentBattle.RealTimePVPBattleReport.PlayerDatas[myPlayerIndex].Heroes)
				{
					this.m_battlePrepareUIController.HeroOnStage(battleHero6, this.m_teamPositions0[battleHero6.ActionPositionIndex], 0, StagePositionType.Me, -1, StageActorTagType.None);
				}
				foreach (BattleHero battleHero7 in currentBattle.RealTimePVPBattleReport.PlayerDatas[1 - myPlayerIndex].Heroes)
				{
					this.m_battlePrepareUIController.HeroOnStage(battleHero7, this.m_teamPositions1[battleHero7.ActionPositionIndex], 1, StagePositionType.Enemy, -1, StageActorTagType.None);
				}
			}
			else if (battleRoom != null)
			{
				for (int k = 0; k < battleRoom.BattleRoomPlayerHeroSetup.GetCount(); k++)
				{
					BattleHeroSetupInfo battleHeroSetupInfo = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(k);
					if (battleHeroSetupInfo.Hero != null && !this.m_pendingHeroSetupNtfs.Contains(k))
					{
						this.m_pendingHeroSetupNtfs.Add(k);
					}
				}
			}
			else
			{
				List<int> list7 = this.SetupMyHeros(battleInfo, num, isSkipBattlePrepare);
				int num2 = 0;
				int num3 = 0;
				while (num3 < list7.Count && num3 < list.Count)
				{
					if (num2 >= num)
					{
						break;
					}
					GridPosition pos = new GridPosition(list[num3].X, list[num3].Y);
					int dir3 = 0;
					if (list2.Count > num3)
					{
						dir3 = list2[num3];
					}
					int myHeroId = list7[num3];
					BattleHero battleHero8 = this.m_playerBattleHeros.Find((BattleHero x) => x.HeroId == myHeroId);
					if (battleHero8 != null)
					{
						bool flag2 = (battleInfo != null && battleInfo.ImperativeBattleHeroes_ID.Contains(myHeroId)) || this.m_userGuideEnforceHeroIds.Contains(myHeroId);
						StageActorTagType tagType;
						if (flag2)
						{
							tagType = StageActorTagType.Enforce;
						}
						else
						{
							tagType = this.GetHeroTagType(battleHero8);
						}
						this.m_battlePrepareUIController.HeroOnStage(battleHero8, pos, dir3, 0, StagePositionType.Me, tagType, -1, 0, -1);
						num2++;
						if (arenaBattleInfo != null && currentBattle.ArenaBattleReport == null)
						{
							this.LoadArenaAttackerHeroActionValue(battleHero8);
						}
					}
					num3++;
				}
			}
			if (battleInfo != null)
			{
				int monsterLevel = projectLPlayerContext.Happening.MonsterLevel;
				for (int l = 0; l < battleInfo.NpcActors.Count; l++)
				{
					BattlePosActor battlePosActor = battleInfo.NpcActors[l];
					GridPosition gridPosition3 = new GridPosition(battlePosActor.X, battlePosActor.Y);
					this.m_teamNpcPositions0.Add(gridPosition3);
					int dir4 = 0;
					if (battleInfo.NpcDirs.Count > l)
					{
						dir4 = battleInfo.NpcDirs[l];
					}
					int behaviorId = 0;
					if (battleInfo.NpcActorsBehavior.Count > l)
					{
						behaviorId = battleInfo.NpcActorsBehavior[l];
					}
					int groupId = 0;
					if (battleInfo.NpcGroups.Count > l)
					{
						groupId = battleInfo.NpcGroups[l];
					}
					if (flag)
					{
						this.m_battlePrepareUIController.AddStagePosition(gridPosition3, dir4, StagePositionType.Me);
					}
					else
					{
						BattleHero battleHero9 = projectLPlayerContext.CreateDefaultBattleHero(battlePosActor.ID);
						if (battleHero9 != null)
						{
							if (battlePosActor.Level > 0)
							{
								battleHero9.Level = battlePosActor.Level;
							}
							else if (monsterLevel > 0)
							{
								battleHero9.Level = monsterLevel;
							}
							this.m_battlePrepareUIController.HeroOnStage(battleHero9, gridPosition3, dir4, 0, StagePositionType.Me, StageActorTagType.Npc, behaviorId, groupId, -1);
						}
					}
				}
				List<RandomArmyActor> list8 = null;
				if (battleInfo.BattleRandomEnemies_ID.Count > 0)
				{
					this.m_armyRandomNumber.SetSeed(projectLPlayerContext.GetBattleArmyRandomSeed());
					BattleUtility.GetRandomBattleArmyActors(this.m_configDataLoader, battleInfo.BattleRandomEnemies_ID, this.m_armyRandomNumber, out list8);
				}
				List<ConfigDataSkillInfo> list9 = null;
				if (battleInfo.EnemyRandomTalentProbilities.Count > 0)
				{
					this.m_armyRandomNumber.SetSeed(projectLPlayerContext.GetBattleArmyRandomSeed());
					BattleUtility.GetRandomTalentSkills(this.m_configDataLoader, battleInfo.EnemyRandomTalent_ID, battleInfo.EnemyRandomTalentProbilities, this.m_armyRandomNumber, out list9);
				}
				for (int m = 0; m < battleInfo.EnemyActors.Count; m++)
				{
					BattlePosActor battlePosActor2 = battleInfo.EnemyActors[m];
					int heroId = battlePosActor2.ID;
					int level = battlePosActor2.Level;
					int dir5 = 0;
					if (battleInfo.EnemyDirs.Count > m)
					{
						dir5 = battleInfo.EnemyDirs[m];
					}
					int behaviorId2 = 0;
					if (battleInfo.EnemyActorsBehavior.Count > m)
					{
						behaviorId2 = battleInfo.EnemyActorsBehavior[m];
					}
					int groupId2 = 0;
					if (battleInfo.EnemyGroups.Count > m)
					{
						groupId2 = battleInfo.EnemyGroups[m];
					}
					GridPosition gridPosition4 = new GridPosition(battlePosActor2.X, battlePosActor2.Y);
					this.m_teamPositions1.Add(gridPosition4);
					if (list8 != null && m < list8.Count && list8[m] != null)
					{
						heroId = list8[m].HeroID;
						level = list8[m].Level;
						behaviorId2 = list8[m].AI;
					}
					ConfigDataSkillInfo extraTalentSkillInfo = null;
					if (list9 != null && m < list9.Count)
					{
						extraTalentSkillInfo = list9[m];
					}
					if (flag)
					{
						this.m_battlePrepareUIController.AddStagePosition(gridPosition4, dir5, StagePositionType.Enemy);
					}
					else
					{
						BattleHero battleHero10 = projectLPlayerContext.CreateDefaultBattleHero(heroId);
						if (battleHero10 != null)
						{
							if (level > 0)
							{
								battleHero10.Level = level;
							}
							else if (monsterLevel > 0)
							{
								battleHero10.Level = monsterLevel;
							}
							BattlePrepareStageActor battlePrepareStageActor = this.m_battlePrepareUIController.HeroOnStage(battleHero10, gridPosition4, dir5, 1, StagePositionType.Enemy, StageActorTagType.None, behaviorId2, groupId2, -1);
							battlePrepareStageActor.SetExtraTalentSkillInfo(extraTalentSkillInfo);
						}
					}
				}
			}
			else if (arenaBattleInfo != null)
			{
				foreach (ParamPosition paramPosition in list3)
				{
					this.m_teamPositions1.Add(new GridPosition(paramPosition.X, paramPosition.Y));
				}
				int num4 = 0;
				foreach (BattleHero battleHero11 in currentBattle.ArenaDefenderHeros)
				{
					int dir6 = 0;
					if (list4.Count > battleHero11.ActionPositionIndex)
					{
						dir6 = list4[battleHero11.ActionPositionIndex];
					}
					this.m_battlePrepareUIController.HeroOnStage(battleHero11, this.m_teamPositions1[battleHero11.ActionPositionIndex], dir6, 1, StagePositionType.Enemy, StageActorTagType.None, -1, 0, -1);
					num4++;
				}
			}
			this.ShowStagePositions();
			this.UpdateArenaAttackerHeroIds();
			this.m_battlePrepareUIController.CheckStageActorChange();
			this.m_battlePrepareUIController.SkipStageActorGraphic(false);
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x0033E5C4 File Offset: 0x0033C7C4
		private static ConfigDataUnchartedScoreInfo GetUnchartedScoreInfo()
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.ScoreLevelInfo != null)
			{
				return projectLPlayerContext.Happening.ScoreLevelInfo.UnchartedScoreInfo;
			}
			if (projectLPlayerContext.Happening.ChallengeLevelInfo != null)
			{
				return projectLPlayerContext.Happening.ChallengeLevelInfo.UnchartedScoreInfo;
			}
			return null;
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x0033E624 File Offset: 0x0033C824
		private static int GetHeroUnchartedScoreBonus(BattleHero hero)
		{
			if (hero == null)
			{
				return 0;
			}
			ConfigDataUnchartedScoreInfo unchartedScoreInfo = BattleUITask.GetUnchartedScoreInfo();
			if (unchartedScoreInfo == null)
			{
				return 0;
			}
			foreach (Int32Pair int32Pair in unchartedScoreInfo.BonusHeroIdList)
			{
				if (int32Pair.Key == hero.HeroId)
				{
					return int32Pair.Value;
				}
			}
			return 0;
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x0033E6B0 File Offset: 0x0033C8B0
		private ConfigDataTowerBattleRuleInfo GetTowerBattleRuleInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTowerBattleRuleInfo_hotfix != null)
			{
				return (ConfigDataTowerBattleRuleInfo)this.m_GetTowerBattleRuleInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.TowerFloorInfo == null)
			{
				return null;
			}
			GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(projectLPlayerContext.Happening.TowerFloorInfo.ID);
			if (climbTowerFloor == null)
			{
				return null;
			}
			return this.m_configDataLoader.GetConfigDataTowerBattleRuleInfo(climbTowerFloor.RuleId);
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x0033E770 File Offset: 0x0033C970
		private ConfigDataTowerBonusHeroGroupInfo GetTowerBonusHeroGroupInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTowerBonusHeroGroupInfo_hotfix != null)
			{
				return (ConfigDataTowerBonusHeroGroupInfo)this.m_GetTowerBonusHeroGroupInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.TowerFloorInfo == null)
			{
				return null;
			}
			GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(projectLPlayerContext.Happening.TowerFloorInfo.ID);
			if (climbTowerFloor == null)
			{
				return null;
			}
			return this.m_configDataLoader.GetConfigDataTowerBonusHeroGroupInfo(climbTowerFloor.BonusHeroGroupId);
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x0033E830 File Offset: 0x0033CA30
		private bool IsTowerPowerUpHero(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTowerPowerUpHeroBattleHero_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTowerPowerUpHeroBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return false;
			}
			ConfigDataTowerBonusHeroGroupInfo towerBonusHeroGroupInfo = this.GetTowerBonusHeroGroupInfo();
			return towerBonusHeroGroupInfo != null && towerBonusHeroGroupInfo.BonusHeroIdList.Contains(hero.HeroId);
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x0033E8D4 File Offset: 0x0033CAD4
		private GuildPlayerMassiveCombatInfo GetGuildPlayerMassiveCombatInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGuildPlayerMassiveCombatInfo_hotfix != null)
			{
				return (GuildPlayerMassiveCombatInfo)this.m_GetGuildPlayerMassiveCombatInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
			{
				return projectLPlayerContext.GetGuildPlayerMassiveCombatInfo();
			}
			return null;
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x0033E968 File Offset: 0x0033CB68
		private bool IsGuildMassiveCombatCampUpHero(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGuildMassiveCombatCampUpHeroBattleHero_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGuildMassiveCombatCampUpHeroBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
			{
				GuildMassiveCombatStronghold guildMassiveCombatStronghold = projectLPlayerContext.GetGuildMassiveCombatStronghold(projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo.ID);
				if (guildMassiveCombatStronghold != null)
				{
					foreach (int item in guildMassiveCombatStronghold.PreferredHeroTagIds)
					{
						if (hero.HeroInfo.m_heroTagIds.Contains(item))
						{
							return true;
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x0033EA94 File Offset: 0x0033CC94
		private StageActorTagType GetHeroTagType(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroTagTypeBattleHero_hotfix != null)
			{
				return (StageActorTagType)this.m_GetHeroTagTypeBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return StageActorTagType.None;
			}
			if (BattleUITask.GetHeroUnchartedScoreBonus(hero) > 0)
			{
				return StageActorTagType.ScoreBonus;
			}
			if (this.IsTowerPowerUpHero(hero))
			{
				return StageActorTagType.PowerUp;
			}
			if (this.IsGuildMassiveCombatCampUpHero(hero))
			{
				return StageActorTagType.CampUp;
			}
			return StageActorTagType.None;
		}

		// Token: 0x0600B843 RID: 47171 RVA: 0x0033EB44 File Offset: 0x0033CD44
		private void LoadArenaAttackerHeroActionValue(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadArenaAttackerHeroActionValueBattleHero_hotfix != null)
			{
				this.m_LoadArenaAttackerHeroActionValueBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataArenaBattleInfo arenaBattleInfo = projectLPlayerContext.CurrentBattle.ArenaBattleInfo;
			if (arenaBattleInfo == null)
			{
				return;
			}
			int[] arenaAttackerHeroIds = LocalAccountConfig.Instance.Data.ArenaAttackerHeroIds;
			if (arenaAttackerHeroIds == null)
			{
				return;
			}
			int num = Array.IndexOf<int>(arenaAttackerHeroIds, hero.HeroId);
			if (num >= 0)
			{
				hero.ActionValue = arenaBattleInfo.DefendNumber - num;
			}
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x0033EC10 File Offset: 0x0033CE10
		private static int CompareHero(BattleHero h1, BattleHero h2)
		{
			int num = h2.Level - h1.Level;
			if (num != 0)
			{
				return num;
			}
			int num2 = h2.HeroInfo.GetRank(h2.StarLevel) - h1.HeroInfo.GetRank(h1.StarLevel);
			if (num2 != 0)
			{
				return num2;
			}
			int num3 = h2.StarLevel - h1.StarLevel;
			if (num3 != 0)
			{
				return num3;
			}
			return h1.HeroId - h2.HeroId;
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x0033EC84 File Offset: 0x0033CE84
		private static int CompareHeroUnchartdScoreBonus(BattleHero h1, BattleHero h2)
		{
			int heroUnchartedScoreBonus = BattleUITask.GetHeroUnchartedScoreBonus(h1);
			int heroUnchartedScoreBonus2 = BattleUITask.GetHeroUnchartedScoreBonus(h2);
			int num = heroUnchartedScoreBonus2 - heroUnchartedScoreBonus;
			if (num != 0)
			{
				return num;
			}
			return BattleUITask.CompareHero(h1, h2);
		}

		// Token: 0x0600B846 RID: 47174 RVA: 0x0033ECB4 File Offset: 0x0033CEB4
		private void ShowStagePositions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStagePositions_hotfix != null)
			{
				this.m_ShowStagePositions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_battleMapUIController.HideStagePositions();
			for (int i = 0; i < 3; i++)
			{
				StagePositionType stagePositionType = (StagePositionType)i;
				bool flag = true;
				if (stagePositionType == StagePositionType.Enemy && battleRoom != null && battleRoom.IsAnyPVPBattleRoomType())
				{
					flag = false;
				}
				if (flag && stagePositionType == StagePositionType.Me && projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
				{
					flag = false;
				}
				if (flag)
				{
					if (battleRoom != null && battleRoom.BattleRoomType == BattleRoomType.RealTimePVPBPMode)
					{
						if (battleRoom.BPStatus == BattleRoomBPStatus.Pick)
						{
							int playerIndexInCurrentPickTurn = battleRoom.GetPlayerIndexInCurrentPickTurn();
							if (playerIndexInCurrentPickTurn != battleRoom.MyPlayerIndex)
							{
								flag = false;
							}
						}
						else
						{
							flag = false;
						}
						if (flag && battleRoom.GetRemainHeroSetupCountInCurrentPickTurn() == 0)
						{
							flag = false;
						}
					}
					else if (stagePositionType == StagePositionType.Me && this.m_battlePrepareUIController.ComputeStageActorCount() >= this.GetMyStageActorCountMax())
					{
						flag = false;
					}
				}
				foreach (GridPosition gridPosition in this.m_battlePrepareUIController.GetStagePositions(stagePositionType))
				{
					this.m_battleMapUIController.ShowStagePosition(stagePositionType, gridPosition, flag && this.m_battlePrepareUIController.GetStageActor(gridPosition) == null);
				}
			}
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x0033EE80 File Offset: 0x0033D080
		private void SetupBattlePrepareTreasures()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupBattlePrepareTreasures_hotfix != null)
			{
				this.m_SetupBattlePrepareTreasures_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataBattleInfo battleInfo = projectLPlayerContext.CurrentBattle.BattleInfo;
			this.m_battlePrepareUIController.ClearBattleTreasures();
			if (battleInfo != null)
			{
				List<int> gainBattleTreasrueIds = projectLPlayerContext.GetGainBattleTreasrueIds();
				foreach (ConfigDataBattleTreasureInfo configDataBattleTreasureInfo in battleInfo.m_battleTreasureInfos)
				{
					bool isOpened = gainBattleTreasrueIds.Contains(configDataBattleTreasureInfo.ID);
					this.m_battlePrepareUIController.AddBattleTreasure(configDataBattleTreasureInfo, isOpened);
				}
			}
		}

		// Token: 0x0600B848 RID: 47176 RVA: 0x0033EF58 File Offset: 0x0033D158
		private static bool IsListElementsEqual(List<int> list0, List<int> list1)
		{
			if (list0.Count != list1.Count)
			{
				return false;
			}
			for (int i = 0; i < list0.Count; i++)
			{
				if (list0[i] != list1[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600B849 RID: 47177 RVA: 0x0033EFA8 File Offset: 0x0033D1A8
		private void BuildBattleTeamSetups()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuildBattleTeamSetups_hotfix != null)
			{
				this.m_BuildBattleTeamSetups_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool saveHeroList = this.m_battlePerformState == BattlePerformState.InBattle;
			this.BuildBattleTeamSetup(0, saveHeroList);
			this.BuildBattleTeamSetup(1, false);
			BattleRoom battleRoom = this.GetBattleRoom();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.TowerFloorInfo != null)
			{
				int bonusHeroGroupId = 0;
				int battleRuleId = 0;
				if (projectLPlayerContext.IsNeedRebuildBattle())
				{
					ClimberTowerProcessingBattleParamInterface climberTowerProcessingBattleParamInterface = new ClimberTowerProcessingBattleParamInterface(projectLPlayerContext.GetProcessingBattle());
					bonusHeroGroupId = climberTowerProcessingBattleParamInterface.GetBonusHeroGroupId();
					battleRuleId = climberTowerProcessingBattleParamInterface.GetRuleId();
				}
				else
				{
					GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(projectLPlayerContext.Happening.TowerFloorInfo.ID);
					if (climbTowerFloor != null)
					{
						bonusHeroGroupId = climbTowerFloor.BonusHeroGroupId;
						battleRuleId = climbTowerFloor.RuleId;
					}
				}
				BattleUtility.ModifyClimbTowerBattleTeamSetups(this.m_configDataLoader, projectLPlayerContext.Happening.TowerFloorInfo.ID, bonusHeroGroupId, battleRuleId, this.GetBattleTeamSetup(0), this.GetBattleTeamSetup(1));
			}
			else if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
			{
				if (battleRoom != null)
				{
					BattleUtility.ModifyGuildMassiveCombatBattleTeamSetups(this.m_configDataLoader, projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo.m_strongholdInfo.ID, battleRoom.PreferredHeroTagIds, this.GetBattleTeamSetup(0));
				}
				else
				{
					GuildMassiveCombatStronghold guildMassiveCombatStronghold = projectLPlayerContext.GetGuildMassiveCombatStronghold(projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo.ID);
					if (guildMassiveCombatStronghold != null)
					{
						BattleUtility.ModifyGuildMassiveCombatBattleTeamSetups(this.m_configDataLoader, guildMassiveCombatStronghold.ConfigId, guildMassiveCombatStronghold.PreferredHeroTagIds, this.GetBattleTeamSetup(0));
					}
				}
			}
			else if (this.m_battlePrepareUIController.IsTestBattle())
			{
				for (int i = 0; i < 2; i++)
				{
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(this.m_battlePrepareUIController.GetTestSkillId(i));
					ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(this.m_battlePrepareUIController.GetTestTalentId(i));
					foreach (BattleActorSetup battleActorSetup in this.GetBattleTeamSetup(i).m_actors)
					{
						if (configDataSkillInfo != null)
						{
							battleActorSetup.ExtraPassiveSkillInfos = new List<ConfigDataSkillInfo>();
							battleActorSetup.ExtraPassiveSkillInfos.Add(configDataSkillInfo);
						}
						if (configDataSkillInfo2 != null)
						{
							battleActorSetup.ExtraTalentSkillInfo = configDataSkillInfo2;
						}
					}
				}
			}
		}

		// Token: 0x0600B84A RID: 47178 RVA: 0x0033F248 File Offset: 0x0033D448
		private void BuildBattleTeamSetup(int team, bool saveHeroList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuildBattleTeamSetupInt32Boolean_hotfix != null)
			{
				this.m_BuildBattleTeamSetupInt32Boolean_hotfix.call(new object[]
				{
					this,
					team,
					saveHeroList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamSetup battleTeamSetup = this.GetBattleTeamSetup(team);
			List<GridPosition> teamPositions = this.GetTeamPositions(team);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int soldierCount = this.GetSoldierCount(team);
			battleTeamSetup.Clear();
			if (team == 0 && saveHeroList)
			{
				this.m_myBattleHeroIds.Clear();
			}
			BattleRoom battleRoom = this.GetBattleRoom();
			int myPlayerIndex = this.m_clientBattle.GetMyPlayerIndex();
			for (int i = 0; i < teamPositions.Count; i++)
			{
				GridPosition p = teamPositions[i];
				BattlePrepareStageActor stageActor = this.m_battlePrepareUIController.GetStageActor(p);
				BattleActorSetup battleActorSetup = null;
				if (stageActor != null && stageActor.GetTeam() == team)
				{
					battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(this.m_configDataLoader, stageActor.GetHero(), stageActor.GetHero().Level, stageActor.GetBehaviorId(), stageActor.GetGroupId());
					battleActorSetup.Position = stageActor.GetPosition();
					battleActorSetup.Direction = stageActor.GetDirection();
					battleActorSetup.IsNpc = false;
					battleActorSetup.SoldierCount = soldierCount;
					battleActorSetup.ExtraTalentSkillInfo = stageActor.GetExtraTalentSkillInfo();
					if (team == 0)
					{
						battleActorSetup.ActionValue = 0;
					}
					if (battleRoom != null)
					{
						if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
						{
							if (team == 0)
							{
								battleActorSetup.PlayerIndex = battleRoom.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(i).PlayerIndex;
							}
						}
						else if (battleRoom.IsAnyPVPBattleRoomType())
						{
							if (battleRoom.MyPlayerIndex == 0)
							{
								battleActorSetup.PlayerIndex = team;
							}
							else
							{
								battleActorSetup.PlayerIndex = 1 - team;
							}
						}
					}
					else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
					{
						if (this.GetMyPlayerIndex() == 0)
						{
							battleActorSetup.PlayerIndex = team;
						}
						else
						{
							battleActorSetup.PlayerIndex = 1 - team;
						}
					}
					battleTeamSetup.m_actors.Add(battleActorSetup);
				}
				else if (team == 1 && projectLPlayerContext.CurrentBattle.BattleInfo != null && !this.m_battlePrepareUIController.IsTestBattle())
				{
					global::Debug.LogError("BuildBattleTeamSetup error, pos " + p.ToString());
				}
				if (team == 0 && saveHeroList)
				{
					if (battleActorSetup != null && battleActorSetup.PlayerIndex == myPlayerIndex)
					{
						this.m_myBattleHeroIds.Add(battleActorSetup.HeroInfo.ID);
					}
					else
					{
						this.m_myBattleHeroIds.Add(0);
					}
				}
			}
			if (team == 0)
			{
				if (saveHeroList)
				{
					while (this.m_myBattleHeroIds.Count > 0 && this.m_myBattleHeroIds[this.m_myBattleHeroIds.Count - 1] == 0)
					{
						this.m_myBattleHeroIds.RemoveAt(this.m_myBattleHeroIds.Count - 1);
					}
					projectLPlayerContext.SaveBattleHeroIds(this.m_myBattleHeroIds);
				}
				foreach (GridPosition p2 in this.m_teamNpcPositions0)
				{
					BattlePrepareStageActor stageActor2 = this.m_battlePrepareUIController.GetStageActor(p2);
					if (stageActor2 != null && stageActor2.GetTeam() == team)
					{
						BattleActorSetup battleActorSetup2 = BattleUtility.CreateBattleActorSetupFromBattleHero(this.m_configDataLoader, stageActor2.GetHero(), stageActor2.GetHero().Level, stageActor2.GetBehaviorId(), stageActor2.GetGroupId());
						battleActorSetup2.Position = stageActor2.GetPosition();
						battleActorSetup2.Direction = stageActor2.GetDirection();
						battleActorSetup2.IsNpc = true;
						battleActorSetup2.SoldierCount = soldierCount;
						battleTeamSetup.m_actors.Add(battleActorSetup2);
					}
				}
			}
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x0033F658 File Offset: 0x0033D858
		private int GetSoldierCount(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierCountInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battlePrepareUIController.IsTestBattle())
			{
				return this.m_battlePrepareUIController.GetTestSoldierCount(team);
			}
			return this.m_configDataLoader.Const_SoldierCountMax;
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x0033F6FC File Offset: 0x0033D8FC
		private void SetTeamAndStartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamAndStartBattle_hotfix != null)
			{
				this.m_SetTeamAndStartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				if (projectLPlayerContext.Happening.Step == HappeningStep.Battle)
				{
					this.StartBattleTeamSetNetTask(projectLPlayerContext.Happening.BattleType, projectLPlayerContext.Happening.BattleInfo.ID, this.m_myBattleHeroIds);
				}
				else
				{
					projectLPlayerContext.SetBattleRandomSeed((int)DateTime.Now.Ticks);
					projectLPlayerContext.SetBattleArmyRandomSeed((int)DateTime.Now.Ticks + 13579);
					this.StartBattleLoadState();
				}
				LocalProcessingBattle.Instance.Delete();
			}
			else if (projectLPlayerContext.CurrentBattle.ArenaBattleInfo != null)
			{
				this.StartBattleTeamSetNetTask(BattleType.ArenaAttack, projectLPlayerContext.CurrentBattle.ArenaBattleInfo.ID, this.m_myBattleHeroIds);
				LocalProcessingBattle.ArenaInstance.Delete();
			}
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x0033F838 File Offset: 0x0033DA38
		private void StartBattlePrepareLoadState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattlePrepareLoadState_hotfix != null)
			{
				this.m_StartBattlePrepareLoadState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loadState = BattleLoadState.Prepare;
			base.ClearUnusedDynamicResourceCache();
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600B84E RID: 47182 RVA: 0x0033F8B0 File Offset: 0x0033DAB0
		private void StartBattleLoadState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleLoadState_hotfix != null)
			{
				this.m_StartBattleLoadState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loadState = BattleLoadState.StartBattle;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x0033F924 File Offset: 0x0033DB24
		private void ShowMoveAndAttackRegion_Prepare(GridPosition pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMoveAndAttackRegion_PrepareGridPosition_hotfix != null)
			{
				this.m_ShowMoveAndAttackRegion_PrepareGridPosition_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePrepareStageActor stageActor = this.m_battlePrepareUIController.GetStageActor(pos);
			if (stageActor == null)
			{
				return;
			}
			BattleHero hero = stageActor.GetHero();
			int team = stageActor.GetTeam();
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeHeroProperties(hero);
			HeroPropertyComputer heroPropertyComputer2 = new HeroPropertyComputer();
			ConfigDataSoldierInfo selectedSoldierInfo = hero.SelectedSoldierInfo;
			if (selectedSoldierInfo != null)
			{
				heroPropertyComputer2.Init(this.m_configDataLoader);
				heroPropertyComputer2.ComputeSoldierCommandProperties(hero, selectedSoldierInfo, this.GetPlayerTrainingTechs(team, stageActor.GetPlayerIndex(), stageActor.IsNpc()), hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader));
			}
			ConfigDataJobConnectionInfo jobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
			MoveType moveType = BattleActor.ComputeMoveType(jobConnectionInfo.m_jobInfo, selectedSoldierInfo);
			int movePoint;
			if (selectedSoldierInfo == null)
			{
				movePoint = heroPropertyComputer.Property0.MovePoint;
			}
			else
			{
				movePoint = Mathf.Min(heroPropertyComputer.Property0.MovePoint, heroPropertyComputer2.Property0.MovePoint);
			}
			int range;
			if (selectedSoldierInfo == null)
			{
				range = heroPropertyComputer.Property0.AttackDistance;
			}
			else
			{
				range = Mathf.Max(heroPropertyComputer.Property0.AttackDistance, heroPropertyComputer2.Property0.AttackDistance);
			}
			BattleMap map = this.m_clientBattle.Battle.Map;
			map.ClearRegion();
			for (int i = 0; i < map.Height; i++)
			{
				for (int j = 0; j < map.Width; j++)
				{
					map.SetRegion(new GridPosition(j, i), 99);
				}
			}
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
			{
				if (battlePrepareStageActor.GetTeam() != team)
				{
					map.SetRegion(battlePrepareStageActor.GetPosition(), 0);
				}
			}
			List<GridPosition> list = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			List<GridPosition> list2 = this.m_clientBattle.Battle.AllocateTempGridPositionList();
			this.m_clientBattle.Battle.FindMoveRegion(pos, movePoint, moveType, team, 0, 99, list);
			foreach (GridPosition p in list)
			{
				map.SetRegion(p, 1);
			}
			for (int k = 0; k < map.Height; k++)
			{
				for (int l = 0; l < map.Width; l++)
				{
					if (map.GetRegion(new GridPosition(l, k)) == 99)
					{
						map.SetRegion(new GridPosition(l, k), 0);
					}
				}
			}
			foreach (GridPosition gridPosition in list)
			{
				BattlePrepareStageActor stageActor2 = this.m_battlePrepareUIController.GetStageActor(gridPosition);
				if (stageActor2 == null || stageActor2 == stageActor)
				{
					list2.Clear();
					this.m_clientBattle.Battle.FindAttackRegion(gridPosition, range, 0, list2);
					foreach (GridPosition p2 in list2)
					{
						if (map.GetRegion(p2) == 0)
						{
							map.SetRegion(p2, 2);
						}
					}
				}
			}
			this.m_battleMapUIController.ShowRegion(pos);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list2);
			this.m_clientBattle.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600B850 RID: 47184 RVA: 0x0033FD74 File Offset: 0x0033DF74
		private void UpdateArenaAttackerHeroIds()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateArenaAttackerHeroIds_hotfix != null)
			{
				this.m_UpdateArenaAttackerHeroIds_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataArenaBattleInfo arenaBattleInfo = projectLPlayerContext.CurrentBattle.ArenaBattleInfo;
			if (arenaBattleInfo == null || projectLPlayerContext.CurrentBattle.ArenaBattleReport != null)
			{
				return;
			}
			List<BattleHero> list = new List<BattleHero>();
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
			{
				if (battlePrepareStageActor.GetTeam() == 0)
				{
					list.Add(battlePrepareStageActor.GetHero());
				}
			}
			List<BattleHero> list2 = list;
			if (BattleUITask.<>f__mg$cache3 == null)
			{
				BattleUITask.<>f__mg$cache3 = new Comparison<BattleHero>(BattleUITask.CompareHeroActionValue);
			}
			list2.Sort(BattleUITask.<>f__mg$cache3);
			for (int i = 0; i < list.Count; i++)
			{
				list[i].ActionValue = arenaBattleInfo.DefendNumber - i;
			}
			this.m_arenaAttackerHeroIds.Clear();
			foreach (BattleHero battleHero in list)
			{
				this.m_arenaAttackerHeroIds.Add(battleHero.HeroId);
			}
		}

		// Token: 0x0600B851 RID: 47185 RVA: 0x0033FF24 File Offset: 0x0033E124
		private static int CompareHeroActionValue(BattleHero hero0, BattleHero hero1)
		{
			if (hero0.ActionValue != hero1.ActionValue)
			{
				return hero1.ActionValue - hero0.ActionValue;
			}
			return hero0.HeroId - hero1.HeroId;
		}

		// Token: 0x0600B852 RID: 47186 RVA: 0x0033FF54 File Offset: 0x0033E154
		private List<TrainingTech> GetPlayerTrainingTechs(int team, int playerIndex, bool isNpc = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerTrainingTechsInt32Int32Boolean_hotfix != null)
			{
				return (List<TrainingTech>)this.m_GetPlayerTrainingTechsInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					team,
					playerIndex,
					isNpc
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isNpc)
			{
				return null;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (currentBattle.ArenaBattleReport != null)
			{
				if (team == 0)
				{
					return currentBattle.ArenaBattleReport.AttackerTechs;
				}
				if (team == 1)
				{
					return currentBattle.ArenaBattleReport.DefenderTechs;
				}
			}
			else if (currentBattle.RealTimePVPBattleReport != null)
			{
				if (playerIndex >= 0 && playerIndex < currentBattle.RealTimePVPBattleReport.PlayerDatas.Length)
				{
					return currentBattle.RealTimePVPBattleReport.PlayerDatas[playerIndex].Techs;
				}
			}
			else if (currentBattle.BattleInfo != null)
			{
				if (team == 0)
				{
					if (battleRoom == null)
					{
						return this.m_trainingTechs;
					}
					if (playerIndex >= 0 && playerIndex < battleRoom.Players.Count)
					{
						return battleRoom.Players[playerIndex].Techs;
					}
				}
				else if (battleRoom == null && this.m_battlePrepareUIController.IsTestBattle())
				{
					return this.m_trainingTechs;
				}
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				if (team == 0)
				{
					return this.m_trainingTechs;
				}
				if (team == 1)
				{
					return currentBattle.ArenaDefenderTrainTechs;
				}
			}
			else if ((currentBattle.PVPBattleInfo != null || currentBattle.RealTimePVPBattleInfo != null) && battleRoom != null && playerIndex >= 0 && playerIndex < battleRoom.Players.Count)
			{
				return battleRoom.Players[playerIndex].Techs;
			}
			return null;
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x00340170 File Offset: 0x0033E370
		private int GetPlayerLevel(int team, int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					team,
					playerIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CurrentBattle currentBattle = projectLPlayerContext.CurrentBattle;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (currentBattle.ArenaBattleReport != null)
			{
				if (team == 0)
				{
					return currentBattle.ArenaBattleReport.AttackerLevel;
				}
				if (team == 1)
				{
					return currentBattle.ArenaBattleReport.DefenderLevel;
				}
			}
			else if (currentBattle.RealTimePVPBattleReport != null)
			{
				if (playerIndex >= 0 && playerIndex < currentBattle.RealTimePVPBattleReport.PlayerDatas.Length)
				{
					return currentBattle.RealTimePVPBattleReport.PlayerDatas[playerIndex].Level;
				}
			}
			else if (currentBattle.BattleInfo != null)
			{
				if (team == 0)
				{
					if (battleRoom == null)
					{
						return projectLPlayerContext.GetPlayerLevel();
					}
					if (playerIndex >= 0 && playerIndex < battleRoom.Players.Count)
					{
						return battleRoom.Players[playerIndex].Level;
					}
				}
				else if (battleRoom == null && this.m_battlePrepareUIController.IsTestBattle())
				{
					return projectLPlayerContext.GetPlayerLevel();
				}
			}
			else if (currentBattle.ArenaBattleInfo != null)
			{
				if (team == 0)
				{
					return projectLPlayerContext.GetPlayerLevel();
				}
				if (team == 1)
				{
					return currentBattle.ArenaDefenderPlayerLevel;
				}
			}
			else if ((currentBattle.PVPBattleInfo != null || currentBattle.RealTimePVPBattleInfo != null) && battleRoom != null && playerIndex >= 0 && playerIndex < battleRoom.Players.Count)
			{
				return battleRoom.Players[playerIndex].Level;
			}
			return 0;
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x00340374 File Offset: 0x0033E574
		private ulong GetPlayerSessionId(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerSessionIdInt32_hotfix != null)
			{
				return Convert.ToUInt64(this.m_GetPlayerSessionIdInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null && playerIndex >= 0 && playerIndex < battleRoom.Players.Count)
			{
				return battleRoom.Players[playerIndex].SessionId;
			}
			return 0UL;
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x0034042C File Offset: 0x0033E62C
		private int GetMyPlayerIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMyPlayerIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMyPlayerIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int result = -1;
			if (battleRoom != null)
			{
				result = battleRoom.MyPlayerIndex;
			}
			else if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				for (int i = 0; i < projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport.PlayerDatas.Length; i++)
				{
					if (projectLPlayerContext.IsMe(projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport.PlayerDatas[i].UserId))
					{
						result = i;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x00340520 File Offset: 0x0033E720
		private bool IsBattlePrepareDisableCameraMove()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBattlePrepareDisableCameraMove_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBattlePrepareDisableCameraMove_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			return battleRoom != null && battleRoom.IsRealTimePVPBattleRoomType();
		}

		// Token: 0x0600B857 RID: 47191 RVA: 0x003405A4 File Offset: 0x0033E7A4
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
			int num = 0;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
			{
				if (battlePrepareStageActor.GetTeam() == 0 && !battlePrepareStageActor.IsNpc())
				{
					num += projectLPlayerContext.ComputeBattlePower(battlePrepareStageActor.GetHero(), this.GetPlayerTrainingTechs(0, battlePrepareStageActor.GetPlayerIndex(), false));
				}
			}
			this.m_battlePrepareUIController.SetBattlePower(num);
		}

		// Token: 0x0600B858 RID: 47192 RVA: 0x003406A4 File Offset: 0x0033E8A4
		private void BattlePrepareUIController_OnPauseBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnPauseBattle_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnPauseBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareUIController.Pause(true);
			List<GridPosition> list = new List<GridPosition>();
			List<GridPosition> list2 = new List<GridPosition>();
			List<GridPosition> list3 = new List<GridPosition>();
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
			{
				if (battlePrepareStageActor.GetTeam() == 0)
				{
					if (battlePrepareStageActor.IsAINpc() || battlePrepareStageActor.GetPositionType() == StagePositionType.Teammate)
					{
						list3.Add(battlePrepareStageActor.GetPosition());
					}
					else
					{
						list.Add(battlePrepareStageActor.GetPosition());
					}
				}
				else
				{
					list2.Add(battlePrepareStageActor.GetPosition());
				}
			}
			this.m_battlePauseUIController.SetMapActors(list, list2, list3);
			this.m_battlePauseUIController.Open();
		}

		// Token: 0x0600B859 RID: 47193 RVA: 0x003407DC File Offset: 0x0033E9DC
		private void BattlePrepareUIController_OnShowArmyRelation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnShowArmyRelation_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnShowArmyRelation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_battlePrepareUIController.IsArmyRelationDescVisible())
			{
				this.m_battlePrepareUIController.ShowArmyRelationDesc();
			}
			else
			{
				this.m_battlePrepareUIController.HideArmyRelationDesc();
			}
		}

		// Token: 0x0600B85A RID: 47194 RVA: 0x00340868 File Offset: 0x0033EA68
		private void BattlePrepareUIController_OnStart()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnStart_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnStart_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareUIController.HideArmyRelationDesc();
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				BattleRoomPlayer myPlayer = battleRoom.GetMyPlayer();
				if (myPlayer.PlayerBattleStatus != PlayerBattleStatus.Ready)
				{
					this.StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus.Ready, delegate
					{
					});
				}
				return;
			}
			this.BuildBattleTeamSetups();
			if (!this.m_battlePrepareUIController.IsTestOnStage())
			{
				int num = 0;
				foreach (BattleActorSetup battleActorSetup in this.m_battleTeamSetup0.m_actors)
				{
					if (!battleActorSetup.IsNpc)
					{
						num++;
					}
				}
				int myStageActorCountMax = this.GetMyStageActorCountMax();
				if (myStageActorCountMax > 0 && num <= 0)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_NoBattleHero, 2f, null, true);
					return;
				}
				if (num < Math.Min(myStageActorCountMax, this.m_playerBattleHeros.Count))
				{
					CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Battle_BattleHeroNotFull, new Action<DialogBoxResult>(this.HeroNotFullDialogBoxCallback), (StringTableId)0, (StringTableId)0);
					return;
				}
			}
			this.SetTeamAndStartBattle();
		}

		// Token: 0x0600B85B RID: 47195 RVA: 0x003409F8 File Offset: 0x0033EBF8
		private void BattlePrepareUIController_OnShowActionOrder()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnShowActionOrder_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnShowActionOrder_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleHero> list = new List<BattleHero>();
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
			{
				if (battlePrepareStageActor.GetTeam() == 0 && !battlePrepareStageActor.IsNpc())
				{
					list.Add(battlePrepareStageActor.GetHero());
				}
			}
			List<BattleHero> list2 = list;
			if (BattleUITask.<>f__mg$cache4 == null)
			{
				BattleUITask.<>f__mg$cache4 = new Comparison<BattleHero>(BattleUITask.CompareHeroActionValue);
			}
			list2.Sort(BattleUITask.<>f__mg$cache4);
			this.m_actionOrderUIController.SetHeros(list);
			this.m_actionOrderUIController.Open();
		}

		// Token: 0x0600B85C RID: 47196 RVA: 0x00340B08 File Offset: 0x0033ED08
		private void HeroNotFullDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroNotFullDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_HeroNotFullDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				this.SetTeamAndStartBattle();
			}
			else
			{
				foreach (GridPosition p in this.m_teamPositions0)
				{
					if (this.m_battlePrepareUIController.GetStageActor(p) == null)
					{
						this.m_clientBattle.BattleCamera.SmoothLook(this.m_clientBattle.GridPositionToWorldPosition(p));
						break;
					}
				}
			}
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x00340C08 File Offset: 0x0033EE08
		private void BattlePrepareUIController_OnTestOnStage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnTestOnStage_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnTestOnStage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetupStageActors(false);
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x00340C70 File Offset: 0x0033EE70
		private void BattlePrepareUIController_OnShowMyActorInfo(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnShowMyActorInfoBattleHero_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnShowMyActorInfoBattleHero_hotfix.call(new object[]
				{
					this,
					hero2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero2;
			BattleUITask $this = this;
			base.ClearAssetList();
			this.CollectHeadImageAssets(hero.HeroInfo.GetCharImageInfo(hero.StarLevel));
			base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(hero, 0));
			int myPlayerIndex = this.GetMyPlayerIndex();
			base.StartLoadCustomAssets(delegate
			{
				$this.m_battlePrepareActorInfoUIController.SetActorInfo(hero, $this.GetPlayerTrainingTechs(0, myPlayerIndex, false), 0, false, true, null, -1, -1);
				$this.m_battlePrepareActorInfoUIController.Open(false);
				$this.m_battleMapUIController.HideRegion();
			});
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x00340D4C File Offset: 0x0033EF4C
		private void BattlePrepareUIController_OnHideActorInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnHideActorInfo_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnHideActorInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareActorInfoUIController.Close();
			this.m_battleMapUIController.HideRegion();
		}

		// Token: 0x0600B860 RID: 47200 RVA: 0x00340DC4 File Offset: 0x0033EFC4
		private void BattlePrepareUIController_OnStageActorChange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnStageActorChange_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnStageActorChange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateBattlePower();
			this.ShowStagePositions();
		}

		// Token: 0x0600B861 RID: 47201 RVA: 0x00340E30 File Offset: 0x0033F030
		private void BattlePrepareUIController_OnHeroOnStage(BattleHero hero, GridPosition pos, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnHeroOnStageBattleHeroGridPositionInt32_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnHeroOnStageBattleHeroGridPositionInt32_hotfix.call(new object[]
				{
					this,
					hero2,
					pos2,
					team2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero2;
			int team = team2;
			GridPosition pos = pos2;
			BattleUITask $this = this;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				int position = this.GetTeamPositions(team).IndexOf(pos);
				if (battleRoom.IsAnyPVPBattleRoomType())
				{
					position = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(battleRoom.MyPlayerIndex, position);
				}
				if (battleRoom.GetMyPlayer().PlayerBattleStatus != PlayerBattleStatus.Ready)
				{
					this.StartBattleRoomHeroSetupNetTask(hero.HeroId, position);
				}
				else
				{
					this.StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus.Normal, delegate
					{
						$this.StartBattleRoomHeroSetupNetTask(hero.HeroId, position);
					});
				}
			}
			else
			{
				base.ClearAssetList();
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero));
				base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(hero, team));
				base.StartLoadCustomAssets(delegate
				{
					int index = $this.GetTeamPositions(team).IndexOf(pos);
					StagePositionType posType = (team != 0) ? StagePositionType.Enemy : StagePositionType.Me;
					StageActorTagType heroTagType = $this.GetHeroTagType(hero);
					$this.m_battlePrepareUIController.HeroOnStage(hero, $this.GetTeamPositions(team)[index], team, posType, -1, heroTagType);
					$this.UpdateArenaAttackerHeroIds();
					$this.m_battleMapUIController.PlayOnStageFx(StagePositionType.Me, pos);
					AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
				});
			}
		}

		// Token: 0x0600B862 RID: 47202 RVA: 0x00340FC8 File Offset: 0x0033F1C8
		private void BattlePrepareUIController_OnActorOffStage(BattlePrepareStageActor sa)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnActorOffStageBattlePrepareStageActor_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnActorOffStageBattlePrepareStageActor_hotfix.call(new object[]
				{
					this,
					sa
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				if (battleRoom.BattleRoomType == BattleRoomType.Team)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_CanOnlyReplaceHero, 2f, null, true);
				}
				else if (battleRoom.BattleRoomType == BattleRoomType.GuildMassiveCombat)
				{
					if (this.m_battlePrepareUIController.ComputeStageActorCount() > 1)
					{
						int position = this.m_teamPositions0.IndexOf(sa.GetPosition());
						if (battleRoom.GetMyPlayer().PlayerBattleStatus != PlayerBattleStatus.Ready)
						{
							this.StartBattleRoomHeroSetoffNetTask(position);
						}
						else
						{
							this.StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus.Normal, delegate
							{
								this.StartBattleRoomHeroSetoffNetTask(position);
							});
						}
					}
					else
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_AtLeastOneHero, 2f, null, true);
					}
				}
				else if (battleRoom.IsAnyPVPBattleRoomType())
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_PVP_CanOnlyReplaceHero, 2f, null, true);
				}
			}
			else
			{
				this.m_battlePrepareUIController.ActorOffStage(sa);
				this.UpdateArenaAttackerHeroIds();
			}
		}

		// Token: 0x0600B863 RID: 47203 RVA: 0x0034113C File Offset: 0x0033F33C
		private void BattlePrepareUIController_OnStageActorMove(BattlePrepareStageActor sa, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnStageActorMoveBattlePrepareStageActorGridPosition_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnStageActorMoveBattlePrepareStageActorGridPosition_hotfix.call(new object[]
				{
					this,
					sa,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				if (battleRoom.IsAnyPVPBattleRoomType())
				{
					int position1 = this.m_teamPositions0.IndexOf(sa.GetPosition());
					int position2 = this.m_teamPositions0.IndexOf(p);
					position1 = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(battleRoom.MyPlayerIndex, position1);
					position2 = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(battleRoom.MyPlayerIndex, position2);
					if (battleRoom.GetMyPlayer().PlayerBattleStatus != PlayerBattleStatus.Ready)
					{
						this.StartBattleRoomHeroSwapNetTask(position1, position2);
					}
					else
					{
						this.StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus.Normal, delegate
						{
							this.StartBattleRoomHeroSwapNetTask(position1, position2);
						});
					}
				}
			}
			else
			{
				this.m_battlePrepareUIController.ActorOnStageMove(sa, p);
				this.m_battleMapUIController.PlayOnStageFx(sa.GetPositionType(), p);
				AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
			}
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x003412AC File Offset: 0x0033F4AC
		private void BattlePrepareUIController_OnStageActorSwap(BattlePrepareStageActor sa1, BattlePrepareStageActor sa2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnStageActorSwapBattlePrepareStageActorBattlePrepareStageActor_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnStageActorSwapBattlePrepareStageActorBattlePrepareStageActor_hotfix.call(new object[]
				{
					this,
					sa1,
					sa2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoom battleRoom = this.GetBattleRoom();
			if (battleRoom != null)
			{
				int position1 = this.m_teamPositions0.IndexOf(sa1.GetPosition());
				int position2 = this.m_teamPositions0.IndexOf(sa2.GetPosition());
				if (battleRoom.IsAnyPVPBattleRoomType())
				{
					position1 = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(battleRoom.MyPlayerIndex, position1);
					position2 = battleRoom.BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(battleRoom.MyPlayerIndex, position2);
				}
				if (battleRoom.GetMyPlayer().PlayerBattleStatus != PlayerBattleStatus.Ready)
				{
					this.StartBattleRoomHeroSwapNetTask(position1, position2);
				}
				else
				{
					this.StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus.Normal, delegate
					{
						this.StartBattleRoomHeroSwapNetTask(position1, position2);
					});
				}
			}
			else
			{
				this.m_battlePrepareUIController.ActorOnStageExchange(sa1, sa2);
				this.m_battleMapUIController.PlayOnStageFx(sa1.GetPositionType(), sa1.GetPosition());
				AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
			}
		}

		// Token: 0x0600B865 RID: 47205 RVA: 0x00341424 File Offset: 0x0033F624
		private void BattlePrepareUIController_OnUpdateBattlePower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnUpdateBattlePower_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnUpdateBattlePower_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B866 RID: 47206 RVA: 0x00341484 File Offset: 0x0033F684
		private void BattlePrepareUIController_OnShowChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnShowChat_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnShowChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BattleUIController_OnShowChat();
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x003414EC File Offset: 0x0033F6EC
		private void BattlePrepareUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnShowHelp_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Battle);
		}

		// Token: 0x0600B868 RID: 47208 RVA: 0x00341558 File Offset: 0x0033F758
		private void BattlePrepareUIController_OnPointerDown(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnPointerDownInputButtonVector2_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnPointerDownInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition p = this.m_clientBattle.ScreenPositionToGridPosition(position);
			BattlePrepareStageActor stageActor = this.m_battlePrepareUIController.GetStageActor(p);
			if (stageActor != null)
			{
				this.m_clientBattle.BattleCamera.EnableTouchMove(false);
			}
		}

		// Token: 0x0600B869 RID: 47209 RVA: 0x0034160C File Offset: 0x0033F80C
		private void BattlePrepareUIController_OnPointerUp(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnPointerUpInputButtonVector2_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnPointerUpInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsBattlePrepareDisableCameraMove())
			{
				this.m_clientBattle.BattleCamera.EnableTouchMove(true);
			}
		}

		// Token: 0x0600B86A RID: 47210 RVA: 0x003416A8 File Offset: 0x0033F8A8
		public void BattlePrepareUIController_OnPointerClick(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnPointerClickInputButtonVector2_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnPointerClickInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 position = position2;
			BattleUITask $this = this;
			GridPosition p = this.m_clientBattle.ScreenPositionToGridPosition(position);
			BattlePrepareStageActor sa = this.m_battlePrepareUIController.GetStageActor(p);
			if (sa != null)
			{
				bool canChangeSoldier = true;
				BattleRoom battleRoom = this.GetBattleRoom();
				if (battleRoom != null)
				{
					if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
					{
						canChangeSoldier = !sa.IsTeammate();
					}
					else if (battleRoom.BattleRoomType == BattleRoomType.RealTimePVPBPMode)
					{
						if (sa.GetTeam() == 0 && battleRoom.BPStatus == BattleRoomBPStatus.Protect)
						{
							this.BattlePrepareUIController_OnHideActorInfo();
							this.m_selectProtectHeroPos = p;
							this.UpdateRealtimePVPBattlePrepareStatus();
							return;
						}
						if (sa.GetTeam() == 1 && battleRoom.BPStatus == BattleRoomBPStatus.Ban)
						{
							this.BattlePrepareUIController_OnHideActorInfo();
							if (battleRoom.IsHeroSetupHasFlag(sa.GetPlayerIndex(), sa.GetHeroId(), SetupBattleHeroFlag.Protect))
							{
								CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_CanNotBanProtectedHero, 2f, null, true);
							}
							else
							{
								this.m_selectBanHeroPos = p;
								this.UpdateRealtimePVPBattlePrepareStatus();
							}
							return;
						}
						if (battleRoom.IsHeroSetupHasFlag(sa.GetPlayerIndex(), sa.GetHeroId(), SetupBattleHeroFlag.Picked))
						{
							canChangeSoldier = false;
						}
					}
				}
				BattleHero hero = sa.GetHero();
				base.ClearAssetList();
				this.CollectHeadImageAssets(hero.HeroInfo.GetCharImageInfo(hero.StarLevel));
				base.StartLoadCustomAssets(delegate
				{
					$this.m_battlePrepareActorInfoUIController.SetActorInfo(hero, $this.GetPlayerTrainingTechs(sa.GetTeam(), sa.GetPlayerIndex(), sa.IsNpc()), sa.GetTeam(), sa.IsNpc(), canChangeSoldier, sa.GetExtraTalentSkillInfo(), sa.GetHeroHp(), sa.GetSoldierHp());
					$this.m_battlePrepareActorInfoUIController.Open(position.x > (float)Screen.width * 0.5f);
					$this.ShowMoveAndAttackRegion_Prepare(p);
				});
			}
			else
			{
				this.m_battlePrepareActorInfoUIController.Close();
			}
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x003418F4 File Offset: 0x0033FAF4
		private void BattlePrepareUIController_OnBeginDragHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnBeginDragHero_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnBeginDragHero_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x00341954 File Offset: 0x0033FB54
		private void BattlePrepareUIController_OnEndDragHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareUIController_OnEndDragHero_hotfix != null)
			{
				this.m_BattlePrepareUIController_OnEndDragHero_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x003419B4 File Offset: 0x0033FBB4
		private void BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix != null)
			{
				this.m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Hero hero2 = projectLPlayerContext.GetHero(hero.HeroId);
			if (hero2 == null)
			{
				return;
			}
			base.ClearAssetList();
			foreach (int num in hero2.SoldierIds)
			{
				ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(num);
				if (configDataSoldierInfo != null)
				{
					base.CollectAsset(UIUtility.GetSoldierModelAssetPath(hero2, num));
				}
			}
			base.StartLoadCustomAssets(delegate
			{
				this.m_battlePrepareActorInfoUIController.ShowSelectSoldierPanel();
			});
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x00341ACC File Offset: 0x0033FCCC
		private void BattlePrepareActorInfoUIController_OnChangeSkill(BattleHero hero, List<int> skillIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList`1_hotfix != null)
			{
				this.m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList`1_hotfix.call(new object[]
				{
					this,
					hero3,
					skillIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero3;
			BattleUITask $this = this;
			HeroSkillsSelectNetTask heroSkillsSelectNetTask = new HeroSkillsSelectNetTask(hero.HeroId, skillIds);
			heroSkillsSelectNetTask.EventOnStop += delegate(Task task)
			{
				HeroSkillsSelectNetTask heroSkillsSelectNetTask2 = task as HeroSkillsSelectNetTask;
				if (heroSkillsSelectNetTask2.Result == 0)
				{
					if (!$this.m_isStartInBattleRoom)
					{
						ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
						Hero hero2 = projectLPlayerContext.GetHero(hero.HeroId);
						if (hero2 != null)
						{
							hero.SelectedSkillList.Clear();
							hero.SelectedSkillList.AddRange(hero2.SelectedSkills);
							$this.m_battlePrepareActorInfoUIController.SetSkills();
							$this.UpdateBattlePower();
						}
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroSkillsSelectNetTask2.Result, 2f, null, true);
				}
			};
			heroSkillsSelectNetTask.Start(null);
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x00341B8C File Offset: 0x0033FD8C
		private void BattlePrepareActorInfoUIController_OnChangeSoldier(BattleHero hero, int soldierId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix != null)
			{
				this.m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix.call(new object[]
				{
					this,
					hero3,
					soldierId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero3;
			BattleUITask $this = this;
			HeroSoldierSelectNetTask heroSoldierSelectNetTask = new HeroSoldierSelectNetTask(hero.HeroId, soldierId);
			heroSoldierSelectNetTask.EventOnStop += delegate(Task task)
			{
				HeroSoldierSelectNetTask heroSoldierSelectNetTask2 = task as HeroSoldierSelectNetTask;
				if (heroSoldierSelectNetTask2.Result == 0)
				{
					if (!$this.m_isStartInBattleRoom)
					{
						ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
						Hero hero2 = projectLPlayerContext.GetHero(hero.HeroId);
						if (hero2 != null)
						{
							hero.SelectedSoldierId = hero2.SelectedSoldierId;
							hero.SelectedSoldierSkinId = hero2.GetSoldierSkinId(hero2.SelectedSoldierId);
							$this.m_battlePrepareActorInfoUIController.SetSoldier();
							$this.m_battlePrepareUIController.UpdateStageActor(hero);
							$this.UpdateBattlePower();
						}
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroSoldierSelectNetTask2.Result, 2f, null, true);
				}
			};
			heroSoldierSelectNetTask.Start(null);
		}

		// Token: 0x0600B870 RID: 47216 RVA: 0x00341C4C File Offset: 0x0033FE4C
		private void ActionOrderUIController_OnConfirm()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderUIController_OnConfirm_hotfix != null)
			{
				this.m_ActionOrderUIController_OnConfirm_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataArenaBattleInfo arenaBattleInfo = projectLPlayerContext.CurrentBattle.ArenaBattleInfo;
			if (arenaBattleInfo != null)
			{
				foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_battlePrepareUIController.GetStageActors())
				{
					if (battlePrepareStageActor.GetTeam() == 0 && !battlePrepareStageActor.IsNpc())
					{
						BattleHero hero = battlePrepareStageActor.GetHero();
						hero.ActionValue = arenaBattleInfo.DefendNumber - this.m_actionOrderUIController.GetHeroActionOrderIndex(hero);
					}
				}
			}
			this.UpdateArenaAttackerHeroIds();
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x00341D5C File Offset: 0x0033FF5C
		private void SetUIStateRegret()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUIStateRegret_hotfix != null)
			{
				this.m_SetUIStateRegret_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetUIStateNone();
			this.BattleUIController_OnShowDanger(false);
			this.m_battleUIController.ShowRegretPanel(true);
			this.m_uiState = BattleUIState.Regret;
			BattleActor battleActor = this.m_clientBattle.Battle.GetActorById(this.m_regretCameraFocusActorId);
			if (battleActor == null)
			{
				battleActor = this.m_clientBattle.Battle.GetActionActor();
			}
			if (battleActor == null)
			{
				return;
			}
			int teamNumber = battleActor.TeamNumber;
			int num = 0;
			int num2 = 0;
			foreach (BattleActor battleActor2 in this.m_clientBattle.Battle.GetTeam(teamNumber).GetActors())
			{
				if (!battleActor2.IsDeadOrRetreat())
				{
					num++;
					if (battleActor.TeamNumber != this.m_clientBattle.Battle.GetActionTeam())
					{
						ClientBattleActor actor = this.m_clientBattle.GetActor(battleActor2);
						if (actor != null)
						{
							actor.SetGraphicActionFinishedEffect(true);
						}
					}
					else if (battleActor2.CanAction())
					{
						num2++;
					}
				}
			}
			this.m_battleUIController.SetRegretTurnStatus(this.m_clientBattle.Battle.Turn, teamNumber, num2, num);
			bool canBackward = this.m_clientBattle.Battle.Step > 1;
			bool canForward = this.m_clientBattle.Battle.Step <= this.m_regretFinalStep || (this.m_regretCameraFocusActorId != 0 && this.m_regretSteps.Count > 0 && this.m_regretCameraFocusActorId != this.m_regretSteps[this.m_regretSteps.Count - 1].ActorId);
			bool canConfirm = this.m_clientBattle.Battle.Step <= this.m_regretFinalStep;
			this.m_battleUIController.SetRegretButtonStatus(canBackward, canForward, canConfirm);
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x00341FA8 File Offset: 0x003401A8
		private bool IsRegretActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRegretActive_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRegretActive_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_regretFinalStep >= 0;
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x00342020 File Offset: 0x00340220
		private bool CanUseRegret()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseRegret_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUseRegret_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isStartInBattleRoom)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.CurrentBattle.ArenaBattleInfo == null && (projectLPlayerContext.Happening.BattleInfo == null || !UserGuideUITask.IsUserGuideBattle(projectLPlayerContext.Happening.BattleInfo.ID)) && (projectLPlayerContext.IsGameFunctionOpenByMonthCard(GameFunctionType.GameFunctionType_Regret) || this.m_battlePrepareUIController.IsTestBattle());
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x00342104 File Offset: 0x00340304
		private void RegretGotoStep(int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegretGotoStepInt32_hotfix != null)
			{
				this.m_RegretGotoStepInt32_hotfix.call(new object[]
				{
					this,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_regretCurrentStep = step;
			if (step == this.m_clientBattle.Battle.Step - 1)
			{
				return;
			}
			Vector2 position = this.m_clientBattle.BattleCamera.GetPosition();
			if (step < this.m_clientBattle.Battle.Step)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				projectLPlayerContext.SetNeedRebuildBattle(true);
				this.m_isStartBattleAutoBattle = false;
				this.m_clientBattle.ResetMap();
				this.StartClientBattle();
			}
			else
			{
				this.m_clientBattle.RebuildBattle(this.m_regretBattleCommands, this.m_clientBattle.Battle.Step, this.m_regretCurrentStep);
			}
			this.SetUIStateRegret();
			this.m_clientBattle.BattleCamera.Look(position);
			UIUtility.SetLongFrame();
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x00342234 File Offset: 0x00340434
		private int FindRegretStepIndex(int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindRegretStepIndexInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_FindRegretStepIndexInt32_hotfix.call(new object[]
				{
					this,
					step
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_regretSteps.Count; i++)
			{
				if (this.m_regretSteps[i].Step == step)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x003422EC File Offset: 0x003404EC
		private void BattleUIController_OnRegretActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnRegretActive_hotfix != null)
			{
				this.m_BattleUIController_OnRegretActive_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.GetRemainBattleRegretCount() <= 0)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Regret_NoCount, 2f, null, true);
				return;
			}
			if (this.m_activeActor != null)
			{
				this.m_activeActor.Locate(this.m_activeActorInitPosition, this.m_activeActorInitDirection);
			}
			this.m_regretBattleCommands.Clear();
			this.m_regretBattleCommands.AddRange(this.m_clientBattle.Battle.GetLogBattleCommands());
			this.m_regretFinalStep = (this.m_regretCurrentStep = this.m_clientBattle.Battle.Step - 1);
			this.m_regretCameraFocusActorId = 0;
			this.SetUIStateRegret();
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x003423F8 File Offset: 0x003405F8
		private void BattleUIController_OnRegretConfirm()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnRegretConfirm_hotfix != null)
			{
				this.m_BattleUIController_OnRegretConfirm_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int i = 0;
			while (i < this.m_regretSteps.Count)
			{
				if (this.m_regretSteps[i].Step > this.m_clientBattle.Battle.Step)
				{
					this.m_regretSteps.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
			this.m_regretBattleCommands.Clear();
			this.m_regretFinalStep = (this.m_regretCurrentStep = -1);
			this.m_regretCameraFocusActorId = 0;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.UseBattleRegret();
			global::Debug.Log("BattleUIController_OnRegretConfirm, remain count:" + projectLPlayerContext.GetRemainBattleRegretCount());
			this.m_battleUIController.ShowRegretPanel(false);
			this.m_battleUIController.ShowRegretConfirmFx(delegate
			{
				ClientBattleActor actor = this.m_clientBattle.GetActor(this.m_clientBattle.Battle.GetActionActor());
				if (actor != null)
				{
					this.ResetActorEffect();
					this.m_clientBattle.CameraFocusActor(actor);
					this.OnClientActorActive(actor, false, this.m_clientBattle.Battle.Step);
					this.SaveProcessingBattle();
				}
			});
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x00342524 File Offset: 0x00340724
		private void BattleUIController_OnRegretCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnRegretCancel_hotfix != null)
			{
				this.m_BattleUIController_OnRegretCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RegretGotoStep(this.m_regretFinalStep);
			this.m_regretBattleCommands.Clear();
			this.m_regretFinalStep = (this.m_regretCurrentStep = -1);
			this.m_regretCameraFocusActorId = 0;
			this.m_battleUIController.ShowRegretPanel(false);
			ClientBattleActor actor = this.m_clientBattle.GetActor(this.m_clientBattle.Battle.GetActionActor());
			if (actor != null)
			{
				this.ResetActorEffect();
				this.m_clientBattle.CameraFocusActor(actor);
				this.OnClientActorActive(actor, false, this.m_clientBattle.Battle.Step);
			}
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x0034260C File Offset: 0x0034080C
		private void BattleUIController_OnRegretBackward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnRegretBackward_hotfix != null)
			{
				this.m_BattleUIController_OnRegretBackward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_regretCurrentStep > 0)
			{
				int num = this.FindRegretStepIndex(this.m_regretCurrentStep);
				if (num >= 0)
				{
					int actorId = this.m_regretSteps[num].ActorId;
					if (actorId != this.m_regretCameraFocusActorId)
					{
						this.m_regretCameraFocusActorId = actorId;
						this.CameraFocusActor(actorId);
						this.SetUIStateRegret();
						return;
					}
				}
				int num2 = this.m_regretCurrentStep;
				if (num > 0)
				{
					num2 = this.m_regretSteps[num - 1].Step;
				}
				else
				{
					num2--;
				}
				this.RegretGotoStep(num2);
				if (num >= 0)
				{
					this.m_regretCameraFocusActorId = this.m_regretSteps[num].ActorId;
					this.CameraFocusActor(this.m_regretCameraFocusActorId);
				}
			}
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x00342728 File Offset: 0x00340928
		private void BattleUIController_OnRegretForward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUIController_OnRegretForward_hotfix != null)
			{
				this.m_BattleUIController_OnRegretForward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_regretCurrentStep <= this.m_regretFinalStep)
			{
				int num = this.FindRegretStepIndex(this.m_regretCurrentStep);
				if (num >= 0 && num < this.m_regretSteps.Count - 1)
				{
					int actorId = this.m_regretSteps[num + 1].ActorId;
					if (actorId != this.m_regretCameraFocusActorId)
					{
						this.m_regretCameraFocusActorId = actorId;
						this.CameraFocusActor(actorId);
						this.SetUIStateRegret();
						return;
					}
				}
				if (this.m_regretCurrentStep < this.m_regretFinalStep)
				{
					int num2 = this.m_regretCurrentStep;
					if (num >= 0 && num < this.m_regretSteps.Count - 1)
					{
						num2 = this.m_regretSteps[num + 1].Step;
					}
					else
					{
						num2++;
					}
					this.RegretGotoStep(num2);
					num = this.FindRegretStepIndex(this.m_regretCurrentStep);
					if (num >= 0)
					{
						this.m_regretCameraFocusActorId = this.m_regretSteps[num].ActorId;
						this.CameraFocusActor(this.m_regretCameraFocusActorId);
					}
				}
			}
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x00342890 File Offset: 0x00340A90
		private List<int> UserGuide_GetEnforceHeros()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuide_GetEnforceHeros_hotfix != null)
			{
				return (List<int>)this.m_UserGuide_GetEnforceHeros_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.BattleInfo != null)
			{
				return UserGuideUITask.GetEnforceHeros(projectLPlayerContext.CurrentBattle.BattleInfo.ID);
			}
			return null;
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x00342934 File Offset: 0x00340B34
		private void SetUserGuideBattleSettings()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUserGuideBattleSettings_hotfix != null)
			{
				this.m_SetUserGuideBattleSettings_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle.SetAutoBattle(false);
			this.m_battleUIController.HideAutoBattleButton();
			this.m_battleUIController.HidePauseButton();
			this.m_disableSaveProcessingBattle = true;
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x0600B87D RID: 47229 RVA: 0x003429C0 File Offset: 0x00340BC0
		// (set) Token: 0x0600B87E RID: 47230 RVA: 0x003429E0 File Offset: 0x00340BE0
		[DoNotToLua]
		public new BattleUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x003429EC File Offset: 0x00340BEC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x003429F8 File Offset: 0x00340BF8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x00342A00 File Offset: 0x00340C00
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x00342A08 File Offset: 0x00340C08
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x00342A14 File Offset: 0x00340C14
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x00342A20 File Offset: 0x00340C20
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x00342A2C File Offset: 0x00340C2C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x00342A34 File Offset: 0x00340C34
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x00342A3C File Offset: 0x00340C3C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x00342A44 File Offset: 0x00340C44
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600B889 RID: 47241 RVA: 0x00342A4C File Offset: 0x00340C4C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x00342A54 File Offset: 0x00340C54
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600B88B RID: 47243 RVA: 0x00342A5C File Offset: 0x00340C5C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600B88C RID: 47244 RVA: 0x00342A64 File Offset: 0x00340C64
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x00342A70 File Offset: 0x00340C70
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x00342A7C File Offset: 0x00340C7C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x00342A88 File Offset: 0x00340C88
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x00342A94 File Offset: 0x00340C94
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x00342A9C File Offset: 0x00340C9C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x00342AA4 File Offset: 0x00340CA4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x00342AAC File Offset: 0x00340CAC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x00342AB4 File Offset: 0x00340CB4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x00342ABC File Offset: 0x00340CBC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x00342AC4 File Offset: 0x00340CC4
		private static void __callDele_m_onActiveActorEvent(ClientBattleActor obj)
		{
			Action<ClientBattleActor> onActiveActorEvent = BattleUITask.m_onActiveActorEvent;
			if (onActiveActorEvent != null)
			{
				onActiveActorEvent(obj);
			}
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x00342AE4 File Offset: 0x00340CE4
		private static void __clearDele_m_onActiveActorEvent(ClientBattleActor obj)
		{
			BattleUITask.m_onActiveActorEvent = null;
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x00342AEC File Offset: 0x00340CEC
		private static void __callDele_m_onDeactiveActorEvent(ClientBattleActor obj)
		{
			Action<ClientBattleActor> onDeactiveActorEvent = BattleUITask.m_onDeactiveActorEvent;
			if (onDeactiveActorEvent != null)
			{
				onDeactiveActorEvent(obj);
			}
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x00342B0C File Offset: 0x00340D0C
		private static void __clearDele_m_onDeactiveActorEvent(ClientBattleActor obj)
		{
			BattleUITask.m_onDeactiveActorEvent = null;
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x00343464 File Offset: 0x00341664
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
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_HideAllView_hotfix = (luaObj.RawGet("HideAllView") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_IsLoading_hotfix = (luaObj.RawGet("IsLoading") as LuaFunction);
					this.m_CreateClientBattle_hotfix = (luaObj.RawGet("CreateClientBattle") as LuaFunction);
					this.m_DestroyClientBattle_hotfix = (luaObj.RawGet("DestroyClientBattle") as LuaFunction);
					this.m_PrepareClientBattleBoolean_hotfix = (luaObj.RawGet("PrepareClientBattle") as LuaFunction);
					this.m_StartClientBattle_hotfix = (luaObj.RawGet("StartClientBattle") as LuaFunction);
					this.m_StopBattleBooleanBoolean_hotfix = (luaObj.RawGet("StopBattle") as LuaFunction);
					this.m_SendBattleRoomInitLog_hotfix = (luaObj.RawGet("SendBattleRoomInitLog") as LuaFunction);
					this.m_GetBattleTeamSetupInt32_hotfix = (luaObj.RawGet("GetBattleTeamSetup") as LuaFunction);
					this.m_GetTeamPositionsInt32_hotfix = (luaObj.RawGet("GetTeamPositions") as LuaFunction);
					this.m_SetCombatHpInt32_hotfix = (luaObj.RawGet("SetCombatHp") as LuaFunction);
					this.m_ExitBattleReturnToWorld_hotfix = (luaObj.RawGet("ExitBattleReturnToWorld") as LuaFunction);
					this.m_ShowErrorMessageAndExitBattleInt32_hotfix = (luaObj.RawGet("ShowErrorMessageAndExitBattle") as LuaFunction);
					this.m_ShowErrorMessageAndExitBattleStringTableId_hotfix = (luaObj.RawGet("ShowErrorMessageAndExitBattle") as LuaFunction);
					this.m_SaveProcessingBattle_hotfix = (luaObj.RawGet("SaveProcessingBattle") as LuaFunction);
					this.m_BattlePrepareBeforeShowResult_hotfix = (luaObj.RawGet("BattlePrepareBeforeShowResult") as LuaFunction);
					this.m_IsMeArenaBattleTeam1_hotfix = (luaObj.RawGet("IsMeArenaBattleTeam1") as LuaFunction);
					this.m_CanUseChat_hotfix = (luaObj.RawGet("CanUseChat") as LuaFunction);
					this.m_CanUseDanmaku_hotfix = (luaObj.RawGet("CanUseDanmaku") as LuaFunction);
					this.m_get_ClientBattle_hotfix = (luaObj.RawGet("get_ClientBattle") as LuaFunction);
					this.m_BattlePauseUIController_OnClose_hotfix = (luaObj.RawGet("BattlePauseUIController_OnClose") as LuaFunction);
					this.m_BattlePauseUIController_OnShowPlayerSetting_hotfix = (luaObj.RawGet("BattlePauseUIController_OnShowPlayerSetting") as LuaFunction);
					this.m_BattlePauseUIController_OnExit_hotfix = (luaObj.RawGet("BattlePauseUIController_OnExit") as LuaFunction);
					this.m_ExitBattleDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("ExitBattleDialogBoxCallback") as LuaFunction);
					this.m_TestUI_ExitBattle_hotfix = (luaObj.RawGet("TestUI_ExitBattle") as LuaFunction);
					this.m_TestUI_RestartBattle_hotfix = (luaObj.RawGet("TestUI_RestartBattle") as LuaFunction);
					this.m_TestUI_ReplayBattle_hotfix = (luaObj.RawGet("TestUI_ReplayBattle") as LuaFunction);
					this.m_TestUI_StopBattleBoolean_hotfix = (luaObj.RawGet("TestUI_StopBattle") as LuaFunction);
					this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix = (luaObj.RawGet("PlayerContext_OnChatMessageNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomInviteNtfTeamRoomInviteInfo_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomInviteNtf") as LuaFunction);
					this.m_PlayerContext_OnBattlePracticeInvitedNtfPVPInviteInfo_hotfix = (luaObj.RawGet("PlayerContext_OnBattlePracticeInvitedNtf") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_CollectBattlePrepareAssets_hotfix = (luaObj.RawGet("CollectBattlePrepareAssets") as LuaFunction);
					this.m_CollectBattleAssets_hotfix = (luaObj.RawGet("CollectBattleAssets") as LuaFunction);
					this.m_CollectBattlePrepareHerosList`1List`1_hotfix = (luaObj.RawGet("CollectBattlePrepareHeros") as LuaFunction);
					this.m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix = (luaObj.RawGet("CollectBattlefieldAssets") as LuaFunction);
					this.m_CollectTerrainAssetsConfigDataTerrainInfo_hotfix = (luaObj.RawGet("CollectTerrainAssets") as LuaFunction);
					this.m_CollectCharImageAssetsConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix = (luaObj.RawGet("CollectCharImageAssets") as LuaFunction);
					this.m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix = (luaObj.RawGet("CollectHeadImageAssets") as LuaFunction);
					this.m_CollectHeroAssetsConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoInt32_hotfix = (luaObj.RawGet("CollectHeroAssets") as LuaFunction);
					this.m_CollectSoldierAssetsConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("CollectSoldierAssets") as LuaFunction);
					this.m_CollectSkinAssetsConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("CollectSkinAssets") as LuaFunction);
					this.m_CollectSkillAssetsConfigDataSkillInfo_hotfix = (luaObj.RawGet("CollectSkillAssets") as LuaFunction);
					this.m_CollectBuffAssetsConfigDataBuffInfo_hotfix = (luaObj.RawGet("CollectBuffAssets") as LuaFunction);
					this.m_CollectDefaultHeroAssetsConfigDataHeroInfo_hotfix = (luaObj.RawGet("CollectDefaultHeroAssets") as LuaFunction);
					this.m_CollectBattleEventAssetsConfigDataBattleEventTriggerInfo_hotfix = (luaObj.RawGet("CollectBattleEventAssets") as LuaFunction);
					this.m_CollectBattleEventActionAssetsConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("CollectBattleEventActionAssets") as LuaFunction);
					this.m_CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("CollectBattlePerformAssets") as LuaFunction);
					this.m__CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("_CollectBattlePerformAssets") as LuaFunction);
					this.m_CollectTrainingTechAssetsList`1_hotfix = (luaObj.RawGet("CollectTrainingTechAssets") as LuaFunction);
					this.m_IsAlreadyCollectAssetObject_hotfix = (luaObj.RawGet("IsAlreadyCollectAsset") as LuaFunction);
					this.m_ClearAlreadyCollectAssets_hotfix = (luaObj.RawGet("ClearAlreadyCollectAssets") as LuaFunction);
					this.m_StartBattleUI_hotfix = (luaObj.RawGet("StartBattleUI") as LuaFunction);
					this.m_ClientActorTryMoveToClientBattleActorGridPositionInt32_hotfix = (luaObj.RawGet("ClientActorTryMoveTo") as LuaFunction);
					this.m_AddCommandIfMovedClientBattleActor_hotfix = (luaObj.RawGet("AddCommandIfMoved") as LuaFunction);
					this.m_FindAttackPositionInt32GridPosition_hotfix = (luaObj.RawGet("FindAttackPosition") as LuaFunction);
					this.m_CanAction_hotfix = (luaObj.RawGet("CanAction") as LuaFunction);
					this.m_GetMapBattleActorGridPosition_hotfix = (luaObj.RawGet("GetMapBattleActor") as LuaFunction);
					this.m_ResetActorEffect_hotfix = (luaObj.RawGet("ResetActorEffect") as LuaFunction);
					this.m_CanUseSkillAtPositionClientBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("CanUseSkillAtPosition") as LuaFunction);
					this.m_FindMoveRegion_hotfix = (luaObj.RawGet("FindMoveRegion") as LuaFunction);
					this.m_ShowMoveAndAttackRegionBattleActorGridPosition_hotfix = (luaObj.RawGet("ShowMoveAndAttackRegion") as LuaFunction);
					this.m_ShowMoveAndAttackRegion_hotfix = (luaObj.RawGet("ShowMoveAndAttackRegion") as LuaFunction);
					this.m_ShowMoveRegionBattleActorGridPosition_hotfix = (luaObj.RawGet("ShowMoveRegion") as LuaFunction);
					this.m_ShowMoveRegion_hotfix = (luaObj.RawGet("ShowMoveRegion") as LuaFunction);
					this.m_UpdateDangerRegion_hotfix = (luaObj.RawGet("UpdateDangerRegion") as LuaFunction);
					this.m_ShowDangerTeamRegionInt32_hotfix = (luaObj.RawGet("ShowDangerTeamRegion") as LuaFunction);
					this.m_ShowDangerRegionList`1_hotfix = (luaObj.RawGet("ShowDangerRegion") as LuaFunction);
					this.m_ShowMovePathClientBattleActorGridPosition_hotfix = (luaObj.RawGet("ShowMovePath") as LuaFunction);
					this.m_GetSummonMoveTypeInt32_hotfix = (luaObj.RawGet("GetSummonMoveType") as LuaFunction);
					this.m_ShowSkillRegionBattleActorInt32GridPosition_hotfix = (luaObj.RawGet("ShowSkillRegion") as LuaFunction);
					this.m_ShowSkillRegion_hotfix = (luaObj.RawGet("ShowSkillRegion") as LuaFunction);
					this.m_ShowSkillRangeBattleActorInt32GridPosition_hotfix = (luaObj.RawGet("ShowSkillRange") as LuaFunction);
					this.m_ShowSkillRange_hotfix = (luaObj.RawGet("ShowSkillRange") as LuaFunction);
					this.m_ShowTeleportRegionBattleActorInt32GridPosition_hotfix = (luaObj.RawGet("ShowTeleportRegion") as LuaFunction);
					this.m_ShowTeleportRegion_hotfix = (luaObj.RawGet("ShowTeleportRegion") as LuaFunction);
					this.m_ShowAttackTargetsBattleActorGridPosition_hotfix = (luaObj.RawGet("ShowAttackTargets") as LuaFunction);
					this.m_ShowSkillTargetsClientBattleActorInt32GridPosition_hotfix = (luaObj.RawGet("ShowSkillTargets") as LuaFunction);
					this.m_ShowSkillTargets_hotfix = (luaObj.RawGet("ShowSkillTargets") as LuaFunction);
					this.m_ShowBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("ShowBattleTreasureDialog") as LuaFunction);
					this.m_ShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("ShowBattleTreasureReward") as LuaFunction);
					this.m_ShowPreCombatBattleActorBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("ShowPreCombat") as LuaFunction);
					this.m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("ShowFastCombat") as LuaFunction);
					this.m_ShowActorInfoBattleActor_hotfix = (luaObj.RawGet("ShowActorInfo") as LuaFunction);
					this.m_HideActorInfo_hotfix = (luaObj.RawGet("HideActorInfo") as LuaFunction);
					this.m_ShowSelectionMarkAndTerrainGridPosition_hotfix = (luaObj.RawGet("ShowSelectionMarkAndTerrain") as LuaFunction);
					this.m_SetUIStateNone_hotfix = (luaObj.RawGet("SetUIStateNone") as LuaFunction);
					this.m_SetUIStateSelectActionActor_hotfix = (luaObj.RawGet("SetUIStateSelectActionActor") as LuaFunction);
					this.m_SetUIStateMove_hotfix = (luaObj.RawGet("SetUIStateMove") as LuaFunction);
					this.m_ShowSkills_hotfix = (luaObj.RawGet("ShowSkills") as LuaFunction);
					this.m_SetUIStateExtraMove_hotfix = (luaObj.RawGet("SetUIStateExtraMove") as LuaFunction);
					this.m_SetUIStateSelectSkillTarget_hotfix = (luaObj.RawGet("SetUIStateSelectSkillTarget") as LuaFunction);
					this.m_SetUIStateConfirmSkill_hotfix = (luaObj.RawGet("SetUIStateConfirmSkill") as LuaFunction);
					this.m_SetUIStateSelectTeleportPosition1_hotfix = (luaObj.RawGet("SetUIStateSelectTeleportPosition1") as LuaFunction);
					this.m_SetUIStateSelectTeleportPosition2_hotfix = (luaObj.RawGet("SetUIStateSelectTeleportPosition2") as LuaFunction);
					this.m_SetUIStateWaitOtherPlayer_hotfix = (luaObj.RawGet("SetUIStateWaitOtherPlayer") as LuaFunction);
					this.m_ShowCanActionActorsUI_hotfix = (luaObj.RawGet("ShowCanActionActorsUI") as LuaFunction);
					this.m_HideCanActionActorsUI_hotfix = (luaObj.RawGet("HideCanActionActorsUI") as LuaFunction);
					this.m_DoAutoBattle_hotfix = (luaObj.RawGet("DoAutoBattle") as LuaFunction);
					this.m_SetAutoBattleBoolean_hotfix = (luaObj.RawGet("SetAutoBattle") as LuaFunction);
					this.m_CameraFocusActorInt32_hotfix = (luaObj.RawGet("CameraFocusActor") as LuaFunction);
					this.m_BattleUIController_OnAutoBattleBoolean_hotfix = (luaObj.RawGet("BattleUIController_OnAutoBattle") as LuaFunction);
					this.m_BattleUIController_OnFastBattleBoolean_hotfix = (luaObj.RawGet("BattleUIController_OnFastBattle") as LuaFunction);
					this.m_BattleUIController_OnSkipCombatSkipCombatMode_hotfix = (luaObj.RawGet("BattleUIController_OnSkipCombat") as LuaFunction);
					this.m_BattleUIController_OnShowDangerBoolean_hotfix = (luaObj.RawGet("BattleUIController_OnShowDanger") as LuaFunction);
					this.m_BattleUIController_OnEndAllAction_hotfix = (luaObj.RawGet("BattleUIController_OnEndAllAction") as LuaFunction);
					this.m_EndAllActionDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("EndAllActionDialogBoxCallback") as LuaFunction);
					this.m_BattleUIController_OnEndAction_hotfix = (luaObj.RawGet("BattleUIController_OnEndAction") as LuaFunction);
					this.m_BattleUIController_OnShowActorInfo_hotfix = (luaObj.RawGet("BattleUIController_OnShowActorInfo") as LuaFunction);
					this.m_BattleUIController_OnSelectSkillInt32_hotfix = (luaObj.RawGet("BattleUIController_OnSelectSkill") as LuaFunction);
					this.m_BattleUIController_OnUseSkill_hotfix = (luaObj.RawGet("BattleUIController_OnUseSkill") as LuaFunction);
					this.m_BattleUIController_OnCancelSkill_hotfix = (luaObj.RawGet("BattleUIController_OnCancelSkill") as LuaFunction);
					this.m_BattleUIController_OnShowChat_hotfix = (luaObj.RawGet("BattleUIController_OnShowChat") as LuaFunction);
					this.m_BattleUIController_OnShowHelp_hotfix = (luaObj.RawGet("BattleUIController_OnShowHelp") as LuaFunction);
					this.m_BattleUIController_OnPauseBattle_hotfix = (luaObj.RawGet("BattleUIController_OnPauseBattle") as LuaFunction);
					this.m_BattleUIController_OnShowArmyRelation_hotfix = (luaObj.RawGet("BattleUIController_OnShowArmyRelation") as LuaFunction);
					this.m_BattleUIController_OnPointerDownInputButtonVector2_hotfix = (luaObj.RawGet("BattleUIController_OnPointerDown") as LuaFunction);
					this.m_BattleUIController_OnPointerUpInputButtonVector2_hotfix = (luaObj.RawGet("BattleUIController_OnPointerUp") as LuaFunction);
					this.m_BattleUIController_OnShowCurTurnDanmakuInt32_hotfix = (luaObj.RawGet("BattleUIController_OnShowCurTurnDanmaku") as LuaFunction);
					this.m_BattleUIController_OnCloseCurTurnDanmaku_hotfix = (luaObj.RawGet("BattleUIController_OnCloseCurTurnDanmaku") as LuaFunction);
					this.m_BattleUIController_OnShowOneDanmakuDanmakuEntry_hotfix = (luaObj.RawGet("BattleUIController_OnShowOneDanmaku") as LuaFunction);
					this.m_BattleUIController_OnPointerClickInputButtonVector2_hotfix = (luaObj.RawGet("BattleUIController_OnPointerClick") as LuaFunction);
					this.m_OnBattleMapClickGridPositionBoolean_hotfix = (luaObj.RawGet("OnBattleMapClick") as LuaFunction);
					this.m_ShouldShowActorInfoBattleActor_hotfix = (luaObj.RawGet("ShouldShowActorInfo") as LuaFunction);
					this.m_BattleUIController_On3DTouchVector2_hotfix = (luaObj.RawGet("BattleUIController_On3DTouch") as LuaFunction);
					this.m_PlaySelectHeroSoundBattleActor_hotfix = (luaObj.RawGet("PlaySelectHeroSound") as LuaFunction);
					this.m_BattleDialogUITask_OnCloseBoolean_hotfix = (luaObj.RawGet("BattleDialogUITask_OnClose") as LuaFunction);
					this.m_BattleTreasureDialogUIController_OnClose_hotfix = (luaObj.RawGet("BattleTreasureDialogUIController_OnClose") as LuaFunction);
					this.m_GetRewardGoodsUITask_OnStopTask_hotfix = (luaObj.RawGet("GetRewardGoodsUITask_OnStop") as LuaFunction);
					this.m_GetRewardGoodsUITask_OnClose_hotfix = (luaObj.RawGet("GetRewardGoodsUITask_OnClose") as LuaFunction);
					this.m_CombatUIController_OnAutoBattleBoolean_hotfix = (luaObj.RawGet("CombatUIController_OnAutoBattle") as LuaFunction);
					this.m_PreCombatUIController_OnOk_hotfix = (luaObj.RawGet("PreCombatUIController_OnOk") as LuaFunction);
					this.m_PreCombatUIController_OnCancel_hotfix = (luaObj.RawGet("PreCombatUIController_OnCancel") as LuaFunction);
					this.m_PreCombatUIController_OnStop_hotfix = (luaObj.RawGet("PreCombatUIController_OnStop") as LuaFunction);
					this.m_BattleSceneUIController_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("BattleSceneUIController_OnPointerDown") as LuaFunction);
					this.m_BattleSceneUIController_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("BattleSceneUIController_OnPointerUp") as LuaFunction);
					this.m_BattleSceneUIController_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("BattleSceneUIController_OnPointerClick") as LuaFunction);
					this.m_BattleSceneUIController_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("BattleSceneUIController_OnBeginDrag") as LuaFunction);
					this.m_BattleSceneUIController_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("BattleSceneUIController_OnEndDrag") as LuaFunction);
					this.m_BattleSceneUIController_OnDragPointerEventData_hotfix = (luaObj.RawGet("BattleSceneUIController_OnDrag") as LuaFunction);
					this.m_BattleSceneUIController_On3DTouchVector2_hotfix = (luaObj.RawGet("BattleSceneUIController_On3DTouch") as LuaFunction);
					this.m_SendBattleCommands_hotfix = (luaObj.RawGet("SendBattleCommands") as LuaFunction);
					this.m_UpdateBattleRoomPlayerHeroStatus_hotfix = (luaObj.RawGet("UpdateBattleRoomPlayerHeroStatus") as LuaFunction);
					this.m_StartBattleRoomMyActionCountdown_hotfix = (luaObj.RawGet("StartBattleRoomMyActionCountdown") as LuaFunction);
					this.m_StopBattleRoomMyActionCountdown_hotfix = (luaObj.RawGet("StopBattleRoomMyActionCountdown") as LuaFunction);
					this.m_ActivateBattleRoomMyActionCountdownBoolean_hotfix = (luaObj.RawGet("ActivateBattleRoomMyActionCountdown") as LuaFunction);
					this.m_UpdateBattleRoomMyActionCountdown_hotfix = (luaObj.RawGet("UpdateBattleRoomMyActionCountdown") as LuaFunction);
					this.m_StartBattleRoomOtherActionCountdownInt32_hotfix = (luaObj.RawGet("StartBattleRoomOtherActionCountdown") as LuaFunction);
					this.m_StopBattleRoomOtherActionCountdown_hotfix = (luaObj.RawGet("StopBattleRoomOtherActionCountdown") as LuaFunction);
					this.m_ActivateBattleRoomOtherActionCountdownBoolean_hotfix = (luaObj.RawGet("ActivateBattleRoomOtherActionCountdown") as LuaFunction);
					this.m_UpdateBattleRoomOtherActionCountdown_hotfix = (luaObj.RawGet("UpdateBattleRoomOtherActionCountdown") as LuaFunction);
					this.m_BattleRoomSetAutoBattleBoolean_hotfix = (luaObj.RawGet("BattleRoomSetAutoBattle") as LuaFunction);
					this.m_ProcessBattlePendingNtfs_hotfix = (luaObj.RawGet("ProcessBattlePendingNtfs") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomPlayerStatusChangedNtfUInt64_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomPlayerStatusChangedNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomPlayerQuitNtfUInt64BattleRoomQuitReason_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomPlayerQuitNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomBattleCommandExecuteNtfUInt64_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomBattleCommandExecuteNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomTeamBattleFinishNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomTeamBattleFinishNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomPVPBattleFinishNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomPVPBattleFinishNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomPVPBattleJoinNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomPVPBattleJoinNtf") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoInitEnd") as LuaFunction);
					this.m_ReloginUITask_OnReloginSuccess_hotfix = (luaObj.RawGet("ReloginUITask_OnReloginSuccess") as LuaFunction);
					this.m_GetBattleRoom_hotfix = (luaObj.RawGet("GetBattleRoom") as LuaFunction);
					this.m_UpdateBattleRoomPrepareTimeout_hotfix = (luaObj.RawGet("UpdateBattleRoomPrepareTimeout") as LuaFunction);
					this.m_UpdateRealtimePVPBattlePrepareTimeout_hotfix = (luaObj.RawGet("UpdateRealtimePVPBattlePrepareTimeout") as LuaFunction);
					this.m_UpdateRealtimePVPBattlePrepareStatus_hotfix = (luaObj.RawGet("UpdateRealtimePVPBattlePrepareStatus") as LuaFunction);
					this.m_UpdateStageActorTagBattlePrepareStageActor_hotfix = (luaObj.RawGet("UpdateStageActorTag") as LuaFunction);
					this.m_ProcessBattlePreparePendingNtfsBoolean_hotfix = (luaObj.RawGet("ProcessBattlePreparePendingNtfs") as LuaFunction);
					this.m_LoadAndUpdateBattleRoomStageActorsList`1Boolean_hotfix = (luaObj.RawGet("LoadAndUpdateBattleRoomStageActors") as LuaFunction);
					this.m_UpdateBattleRoomStageActorsInt32BattleHeroBoolean_hotfix = (luaObj.RawGet("UpdateBattleRoomStageActors") as LuaFunction);
					this.m_BattleRoomBattleStart_hotfix = (luaObj.RawGet("BattleRoomBattleStart") as LuaFunction);
					this.m_PVPBattlePrepareUIController_OnPrepareConfirm_hotfix = (luaObj.RawGet("PVPBattlePrepareUIController_OnPrepareConfirm") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomHeroSetupNtfList`1_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomHeroSetupNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomDataChangeNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomDataChangeNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomTeamBattleStartNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomTeamBattleStartNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomPVPBattleStartNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomPVPBattleStartNtf") as LuaFunction);
					this.m_PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf") as LuaFunction);
					this.m_ShowBattleResultBattleTypeInt32BattleRewardBooleanList`1BattleLevelAchievementbe_hotfix = (luaObj.RawGet("ShowBattleResult") as LuaFunction);
					this.m_ShowBattleLose_hotfix = (luaObj.RawGet("ShowBattleLose") as LuaFunction);
					this.m_ShowBattleReportEndArenaBattleReport_hotfix = (luaObj.RawGet("ShowBattleReportEnd") as LuaFunction);
					this.m_ShowBattleReportEndRealTimePVPBattleReport_hotfix = (luaObj.RawGet("ShowBattleReportEnd") as LuaFunction);
					this.m_BuildBattleReport_hotfix = (luaObj.RawGet("BuildBattleReport") as LuaFunction);
					this.m_CheckBattleResult_hotfix = (luaObj.RawGet("CheckBattleResult") as LuaFunction);
					this.m_SendBattleCheatGMCommandBoolean_hotfix = (luaObj.RawGet("SendBattleCheatGMCommand") as LuaFunction);
					this.m_BattleResultEnd_hotfix = (luaObj.RawGet("BattleResultEnd") as LuaFunction);
					this.m_BattleRoomInviteTeammateDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("BattleRoomInviteTeammateDialogBoxCallback") as LuaFunction);
					this.m_BattleUIController_OnWinOrLoseEnd_hotfix = (luaObj.RawGet("BattleUIController_OnWinOrLoseEnd") as LuaFunction);
					this.m_BattleResultUITask_OnStopTask_hotfix = (luaObj.RawGet("BattleResultUITask_OnStop") as LuaFunction);
					this.m_BattleResultUITask_OnClose_hotfix = (luaObj.RawGet("BattleResultUITask_OnClose") as LuaFunction);
					this.m_BattleResultScoreUITask_OnStopTask_hotfix = (luaObj.RawGet("BattleResultScoreUITask_OnStop") as LuaFunction);
					this.m_BattleResultScoreUITask_OnClose_hotfix = (luaObj.RawGet("BattleResultScoreUITask_OnClose") as LuaFunction);
					this.m_BattleLoseUITask_OnStopTask_hotfix = (luaObj.RawGet("BattleLoseUITask_OnStop") as LuaFunction);
					this.m_BattleLoseUITask_OnClose_hotfix = (luaObj.RawGet("BattleLoseUITask_OnClose") as LuaFunction);
					this.m_BattleReportEndUITask_OnStopTask_hotfix = (luaObj.RawGet("BattleReportEndUITask_OnStop") as LuaFunction);
					this.m_BattleReportEndUITask_OnClose_hotfix = (luaObj.RawGet("BattleReportEndUITask_OnClose") as LuaFunction);
					this.m_BattleReportEndUITask_OnPlayAgain_hotfix = (luaObj.RawGet("BattleReportEndUITask_OnPlayAgain") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_InitBattleSceneUIController_hotfix = (luaObj.RawGet("InitBattleSceneUIController") as LuaFunction);
					this.m_UninitBattleSceneUIController_hotfix = (luaObj.RawGet("UninitBattleSceneUIController") as LuaFunction);
					this.m_InitBattleUIController_hotfix = (luaObj.RawGet("InitBattleUIController") as LuaFunction);
					this.m_UninitBattleUIController_hotfix = (luaObj.RawGet("UninitBattleUIController") as LuaFunction);
					this.m_InitCombatUIController_hotfix = (luaObj.RawGet("InitCombatUIController") as LuaFunction);
					this.m_UninitCombatUIController_hotfix = (luaObj.RawGet("UninitCombatUIController") as LuaFunction);
					this.m_InitPreCombatUIController_hotfix = (luaObj.RawGet("InitPreCombatUIController") as LuaFunction);
					this.m_UninitPreCombatUIController_hotfix = (luaObj.RawGet("UninitPreCombatUIController") as LuaFunction);
					this.m_InitBattleRoomUIController_hotfix = (luaObj.RawGet("InitBattleRoomUIController") as LuaFunction);
					this.m_UninitBattleRoomUIController_hotfix = (luaObj.RawGet("UninitBattleRoomUIController") as LuaFunction);
					this.m_InitBattleCommonUIController_hotfix = (luaObj.RawGet("InitBattleCommonUIController") as LuaFunction);
					this.m_UninitBattleCommonUIController_hotfix = (luaObj.RawGet("UninitBattleCommonUIController") as LuaFunction);
					this.m_InitBattlePrepareUIController_hotfix = (luaObj.RawGet("InitBattlePrepareUIController") as LuaFunction);
					this.m_UninitBattlePrepareUIController_hotfix = (luaObj.RawGet("UninitBattlePrepareUIController") as LuaFunction);
					this.m_OnStartBattle_hotfix = (luaObj.RawGet("OnStartBattle") as LuaFunction);
					this.m_OnStopBattleBooleanBoolean_hotfix = (luaObj.RawGet("OnStopBattle") as LuaFunction);
					this.m_OnShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix = (luaObj.RawGet("OnShowBattleWinCondition") as LuaFunction);
					this.m_OnHideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix = (luaObj.RawGet("OnHideBattleWinCondition") as LuaFunction);
					this.m_OnShowBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix = (luaObj.RawGet("OnShowBattleLoseCondition") as LuaFunction);
					this.m_OnHideBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix = (luaObj.RawGet("OnHideBattleLoseCondition") as LuaFunction);
					this.m_OnNextTurnInt32_hotfix = (luaObj.RawGet("OnNextTurn") as LuaFunction);
					this.m_OnNextTurnAnimationEndInt32_hotfix = (luaObj.RawGet("OnNextTurnAnimationEnd") as LuaFunction);
					this.m_OnNextTeamInt32_hotfix = (luaObj.RawGet("OnNextTeam") as LuaFunction);
					this.m_OnNextPlayerInt32_hotfix = (luaObj.RawGet("OnNextPlayer") as LuaFunction);
					this.m_OnNextActorBattleActor_hotfix = (luaObj.RawGet("OnNextActor") as LuaFunction);
					this.m_OnClientActorActiveClientBattleActorBooleanInt32_hotfix = (luaObj.RawGet("OnClientActorActive") as LuaFunction);
					this.m_OnClientActorMoveClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorMove") as LuaFunction);
					this.m_OnClientActorTryMoveClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorTryMove") as LuaFunction);
					this.m_OnClientActorNoActClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorNoAct") as LuaFunction);
					this.m_OnClientActorTargetClientBattleActorConfigDataSkillInfoGridPositionInt32_hotfix = (luaObj.RawGet("OnClientActorTarget") as LuaFunction);
					this.m_OnClientActorSkillClientBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnClientActorSkill") as LuaFunction);
					this.m_OnClientActorSkillEndClientBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnClientActorSkillEnd") as LuaFunction);
					this.m_OnClientActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnClientActorSkillHit") as LuaFunction);
					this.m_OnClientActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnClientActorBuffHit") as LuaFunction);
					this.m_OnClientActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnClientActorTerrainHit") as LuaFunction);
					this.m_OnClientActorImmuneClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorImmune") as LuaFunction);
					this.m_OnClientActorPassiveSkillClientBattleActorBuffState_hotfix = (luaObj.RawGet("OnClientActorPassiveSkill") as LuaFunction);
					this.m_OnClientActorGuardClientBattleActorClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorGuard") as LuaFunction);
					this.m_OnClientActorDieClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorDie") as LuaFunction);
					this.m_OnClientActorAppearClientBattleActor_hotfix = (luaObj.RawGet("OnClientActorAppear") as LuaFunction);
					this.m_OnCancelCombat_hotfix = (luaObj.RawGet("OnCancelCombat") as LuaFunction);
					this.m_OnPreStartCombatClientBattleActorClientBattleActor_hotfix = (luaObj.RawGet("OnPreStartCombat") as LuaFunction);
					this.m_OnStartCombatClientBattleActorClientBattleActorBoolean_hotfix = (luaObj.RawGet("OnStartCombat") as LuaFunction);
					this.m_OnPreStopCombat_hotfix = (luaObj.RawGet("OnPreStopCombat") as LuaFunction);
					this.m_OnStopCombat_hotfix = (luaObj.RawGet("OnStopCombat") as LuaFunction);
					this.m_OnPrepareFastCombatClientBattleActorClientBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnPrepareFastCombat") as LuaFunction);
					this.m_OnStartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("OnStartFastCombat") as LuaFunction);
					this.m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnCombatActorHit") as LuaFunction);
					this.m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix = (luaObj.RawGet("OnStartSkillCutscene") as LuaFunction);
					this.m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix = (luaObj.RawGet("OnStartPassiveSkillCutscene") as LuaFunction);
					this.m_OnStopSkillCutscene_hotfix = (luaObj.RawGet("OnStopSkillCutscene") as LuaFunction);
					this.m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix = (luaObj.RawGet("OnStartBattleDialog") as LuaFunction);
					this.m_BattleDialogUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("BattleDialogUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_OnStartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("OnStartBattleTreasureDialog") as LuaFunction);
					this.m_OnShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("OnShowBattleTreasureReward") as LuaFunction);
					this.m_OnStartBattlePerform_hotfix = (luaObj.RawGet("OnStartBattlePerform") as LuaFunction);
					this.m_OnStopBattlePerform_hotfix = (luaObj.RawGet("OnStopBattlePerform") as LuaFunction);
					this.m_OnScreenEffectString_hotfix = (luaObj.RawGet("OnScreenEffect") as LuaFunction);
					this.m_StartBattleTeamSetNetTaskBattleTypeInt32List`1_hotfix = (luaObj.RawGet("StartBattleTeamSetNetTask") as LuaFunction);
					this.m_StartLevelAttackNetTask_hotfix = (luaObj.RawGet("StartLevelAttackNetTask") as LuaFunction);
					this.m_StartLevelWayPointMoveNetTaskConfigDataWaypointInfo_hotfix = (luaObj.RawGet("StartLevelWayPointMoveNetTask") as LuaFunction);
					this.m_StartLevelScenarioHandleNetTaskConfigDataScenarioInfo_hotfix = (luaObj.RawGet("StartLevelScenarioHandleNetTask") as LuaFunction);
					this.m_StartRiftLevelAttackNetTaskConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("StartRiftLevelAttackNetTask") as LuaFunction);
					this.m_StartHeroDungeonLevelAttackNetTaskConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("StartHeroDungeonLevelAttackNetTask") as LuaFunction);
					this.m_StartAnikiLevelAttackNetTaskConfigDataAnikiLevelInfo_hotfix = (luaObj.RawGet("StartAnikiLevelAttackNetTask") as LuaFunction);
					this.m_StartThearchyLevelAttackNetTaskConfigDataThearchyTrialLevelInfo_hotfix = (luaObj.RawGet("StartThearchyLevelAttackNetTask") as LuaFunction);
					this.m_StartMemoryCorridorLevelAttackNetTaskConfigDataMemoryCorridorLevelInfo_hotfix = (luaObj.RawGet("StartMemoryCorridorLevelAttackNetTask") as LuaFunction);
					this.m_StartHeroTrainningLevelAttackNetTaskConfigDataHeroTrainningLevelInfo_hotfix = (luaObj.RawGet("StartHeroTrainningLevelAttackNetTask") as LuaFunction);
					this.m_StartHeroPhantomLevelAttackNetTaskConfigDataHeroPhantomLevelInfo_hotfix = (luaObj.RawGet("StartHeroPhantomLevelAttackNetTask") as LuaFunction);
					this.m_StartTreasureLevelAttackNetTaskConfigDataTreasureLevelInfo_hotfix = (luaObj.RawGet("StartTreasureLevelAttackNetTask") as LuaFunction);
					this.m_StartUnchartedScoreLevelAttackNetTaskConfigDataScoreLevelInfo_hotfix = (luaObj.RawGet("StartUnchartedScoreLevelAttackNetTask") as LuaFunction);
					this.m_StartUnchartedChallengeLevelAttackNetTaskConfigDataChallengeLevelInfo_hotfix = (luaObj.RawGet("StartUnchartedChallengeLevelAttackNetTask") as LuaFunction);
					this.m_StartClimbTowerLevelAttackNetTaskConfigDataTowerFloorInfo_hotfix = (luaObj.RawGet("StartClimbTowerLevelAttackNetTask") as LuaFunction);
					this.m_StartGuildMassiveCombatAttackNetTaskConfigDataGuildMassiveCombatLevelInfoList`1_hotfix = (luaObj.RawGet("StartGuildMassiveCombatAttackNetTask") as LuaFunction);
					this.m_StartArenaOpponentAttackFightingNetTask_hotfix = (luaObj.RawGet("StartArenaOpponentAttackFightingNetTask") as LuaFunction);
					this.m_HandleLevelAttackNetTaskResultInt32_hotfix = (luaObj.RawGet("HandleLevelAttackNetTaskResult") as LuaFunction);
					this.m_StartWayPointBattleFinishedNetTaskConfigDataWaypointInfo_hotfix = (luaObj.RawGet("StartWayPointBattleFinishedNetTask") as LuaFunction);
					this.m_StartRiftLevelBattleFinishedNetTaskConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("StartRiftLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartHeroDungeonLevelBattleFinishedNetTaskConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("StartHeroDungeonLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartAnikiLevelBattleFinishedNetTaskConfigDataAnikiLevelInfo_hotfix = (luaObj.RawGet("StartAnikiLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartThearchyLevelBattleFinishedNetTaskConfigDataThearchyTrialLevelInfo_hotfix = (luaObj.RawGet("StartThearchyLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartTreasureLevelBattleFinishedNetTaskConfigDataTreasureLevelInfo_hotfix = (luaObj.RawGet("StartTreasureLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartMemoryCorridorLevelBattleFinishedNetTaskConfigDataMemoryCorridorLevelInfo_hotfix = (luaObj.RawGet("StartMemoryCorridorLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartHeroTrainningLevelBattleFinishedNetTaskConfigDataHeroTrainningLevelInfo_hotfix = (luaObj.RawGet("StartHeroTrainningLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartHeroPhantomLevelBattleFinishedNetTaskConfigDataHeroPhantomLevelInfo_hotfix = (luaObj.RawGet("StartHeroPhantomLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartUnchartedScoreLevelBattleFinishedNetTaskConfigDataScoreLevelInfo_hotfix = (luaObj.RawGet("StartUnchartedScoreLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartUnchartedChallengeLevelBattleFinishedNetTaskConfigDataChallengeLevelInfo_hotfix = (luaObj.RawGet("StartUnchartedChallengeLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartClimbTowerLevelBattleFinishedNetTaskConfigDataTowerFloorInfo_hotfix = (luaObj.RawGet("StartClimbTowerLevelBattleFinishedNetTask") as LuaFunction);
					this.m_StartGuildMassiveCombatSinglePVEBattleEndNetTaskConfigDataGuildMassiveCombatLevelInfo_hotfix = (luaObj.RawGet("StartGuildMassiveCombatSinglePVEBattleEndNetTask") as LuaFunction);
					this.m_StartArenaBattleFinishedNetTask_hotfix = (luaObj.RawGet("StartArenaBattleFinishedNetTask") as LuaFunction);
					this.m_HandleBattleFinishedNetTaskResultInt32BooleanBattleRewardInt32BooleanList`1BattleLevelAchievementbe_hotfix = (luaObj.RawGet("HandleBattleFinishedNetTaskResult") as LuaFunction);
					this.m_StartBattleCancelNetTask_hotfix = (luaObj.RawGet("StartBattleCancelNetTask") as LuaFunction);
					this.m_StartDanmakuPostNetTaskAction`1_hotfix = (luaObj.RawGet("StartDanmakuPostNetTask") as LuaFunction);
					this.m_StartBattleRoomHeroSetupNetTaskInt32Int32_hotfix = (luaObj.RawGet("StartBattleRoomHeroSetupNetTask") as LuaFunction);
					this.m_StartBattleRoomHeroSwapNetTaskInt32Int32_hotfix = (luaObj.RawGet("StartBattleRoomHeroSwapNetTask") as LuaFunction);
					this.m_StartBattleRoomHeroSetoffNetTaskInt32_hotfix = (luaObj.RawGet("StartBattleRoomHeroSetoffNetTask") as LuaFunction);
					this.m_StartBattleRoomPlayerStatusChangeNetTaskPlayerBattleStatusAction_hotfix = (luaObj.RawGet("StartBattleRoomPlayerStatusChangeNetTask") as LuaFunction);
					this.m_StartBattleRoomQuitNetTask_hotfix = (luaObj.RawGet("StartBattleRoomQuitNetTask") as LuaFunction);
					this.m_StartBattleRoomEndCurrentBPTurnNetTaskAction_hotfix = (luaObj.RawGet("StartBattleRoomEndCurrentBPTurnNetTask") as LuaFunction);
					this.m_StartBattleRoomPlayerActionBeginNetTask_hotfix = (luaObj.RawGet("StartBattleRoomPlayerActionBeginNetTask") as LuaFunction);
					this.m_PrepareBattleUI_hotfix = (luaObj.RawGet("PrepareBattleUI") as LuaFunction);
					this.m_SetupReachRegionBoolean_hotfix = (luaObj.RawGet("SetupReachRegion") as LuaFunction);
					this.m_SetupBattlePauseUIControllerList`1_hotfix = (luaObj.RawGet("SetupBattlePauseUIController") as LuaFunction);
					this.m_SetupBattlePauseUIAchievements_hotfix = (luaObj.RawGet("SetupBattlePauseUIAchievements") as LuaFunction);
					this.m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix = (luaObj.RawGet("GetWinConditionTargetPosition") as LuaFunction);
					this.m_GetMyStageActorCountMax_hotfix = (luaObj.RawGet("GetMyStageActorCountMax") as LuaFunction);
					this.m_SetupMyHerosConfigDataBattleInfoInt32Boolean_hotfix = (luaObj.RawGet("SetupMyHeros") as LuaFunction);
					this.m_FillMyHerosList`1Int32List`1_hotfix = (luaObj.RawGet("FillMyHeros") as LuaFunction);
					this.m_SetupStageActorsBoolean_hotfix = (luaObj.RawGet("SetupStageActors") as LuaFunction);
					this.m_GetTowerBattleRuleInfo_hotfix = (luaObj.RawGet("GetTowerBattleRuleInfo") as LuaFunction);
					this.m_GetTowerBonusHeroGroupInfo_hotfix = (luaObj.RawGet("GetTowerBonusHeroGroupInfo") as LuaFunction);
					this.m_IsTowerPowerUpHeroBattleHero_hotfix = (luaObj.RawGet("IsTowerPowerUpHero") as LuaFunction);
					this.m_GetGuildPlayerMassiveCombatInfo_hotfix = (luaObj.RawGet("GetGuildPlayerMassiveCombatInfo") as LuaFunction);
					this.m_IsGuildMassiveCombatCampUpHeroBattleHero_hotfix = (luaObj.RawGet("IsGuildMassiveCombatCampUpHero") as LuaFunction);
					this.m_GetHeroTagTypeBattleHero_hotfix = (luaObj.RawGet("GetHeroTagType") as LuaFunction);
					this.m_LoadArenaAttackerHeroActionValueBattleHero_hotfix = (luaObj.RawGet("LoadArenaAttackerHeroActionValue") as LuaFunction);
					this.m_ShowStagePositions_hotfix = (luaObj.RawGet("ShowStagePositions") as LuaFunction);
					this.m_SetupBattlePrepareTreasures_hotfix = (luaObj.RawGet("SetupBattlePrepareTreasures") as LuaFunction);
					this.m_BuildBattleTeamSetups_hotfix = (luaObj.RawGet("BuildBattleTeamSetups") as LuaFunction);
					this.m_BuildBattleTeamSetupInt32Boolean_hotfix = (luaObj.RawGet("BuildBattleTeamSetup") as LuaFunction);
					this.m_GetSoldierCountInt32_hotfix = (luaObj.RawGet("GetSoldierCount") as LuaFunction);
					this.m_SetTeamAndStartBattle_hotfix = (luaObj.RawGet("SetTeamAndStartBattle") as LuaFunction);
					this.m_StartBattlePrepareLoadState_hotfix = (luaObj.RawGet("StartBattlePrepareLoadState") as LuaFunction);
					this.m_StartBattleLoadState_hotfix = (luaObj.RawGet("StartBattleLoadState") as LuaFunction);
					this.m_ShowMoveAndAttackRegion_PrepareGridPosition_hotfix = (luaObj.RawGet("ShowMoveAndAttackRegion_Prepare") as LuaFunction);
					this.m_UpdateArenaAttackerHeroIds_hotfix = (luaObj.RawGet("UpdateArenaAttackerHeroIds") as LuaFunction);
					this.m_GetPlayerTrainingTechsInt32Int32Boolean_hotfix = (luaObj.RawGet("GetPlayerTrainingTechs") as LuaFunction);
					this.m_GetPlayerLevelInt32Int32_hotfix = (luaObj.RawGet("GetPlayerLevel") as LuaFunction);
					this.m_GetPlayerSessionIdInt32_hotfix = (luaObj.RawGet("GetPlayerSessionId") as LuaFunction);
					this.m_GetMyPlayerIndex_hotfix = (luaObj.RawGet("GetMyPlayerIndex") as LuaFunction);
					this.m_IsBattlePrepareDisableCameraMove_hotfix = (luaObj.RawGet("IsBattlePrepareDisableCameraMove") as LuaFunction);
					this.m_UpdateBattlePower_hotfix = (luaObj.RawGet("UpdateBattlePower") as LuaFunction);
					this.m_BattlePrepareUIController_OnPauseBattle_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnPauseBattle") as LuaFunction);
					this.m_BattlePrepareUIController_OnShowArmyRelation_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnShowArmyRelation") as LuaFunction);
					this.m_BattlePrepareUIController_OnStart_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnStart") as LuaFunction);
					this.m_BattlePrepareUIController_OnShowActionOrder_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnShowActionOrder") as LuaFunction);
					this.m_HeroNotFullDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("HeroNotFullDialogBoxCallback") as LuaFunction);
					this.m_BattlePrepareUIController_OnTestOnStage_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnTestOnStage") as LuaFunction);
					this.m_BattlePrepareUIController_OnShowMyActorInfoBattleHero_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnShowMyActorInfo") as LuaFunction);
					this.m_BattlePrepareUIController_OnHideActorInfo_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnHideActorInfo") as LuaFunction);
					this.m_BattlePrepareUIController_OnStageActorChange_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnStageActorChange") as LuaFunction);
					this.m_BattlePrepareUIController_OnHeroOnStageBattleHeroGridPositionInt32_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnHeroOnStage") as LuaFunction);
					this.m_BattlePrepareUIController_OnActorOffStageBattlePrepareStageActor_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnActorOffStage") as LuaFunction);
					this.m_BattlePrepareUIController_OnStageActorMoveBattlePrepareStageActorGridPosition_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnStageActorMove") as LuaFunction);
					this.m_BattlePrepareUIController_OnStageActorSwapBattlePrepareStageActorBattlePrepareStageActor_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnStageActorSwap") as LuaFunction);
					this.m_BattlePrepareUIController_OnUpdateBattlePower_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnUpdateBattlePower") as LuaFunction);
					this.m_BattlePrepareUIController_OnShowChat_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnShowChat") as LuaFunction);
					this.m_BattlePrepareUIController_OnShowHelp_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnShowHelp") as LuaFunction);
					this.m_BattlePrepareUIController_OnPointerDownInputButtonVector2_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnPointerDown") as LuaFunction);
					this.m_BattlePrepareUIController_OnPointerUpInputButtonVector2_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnPointerUp") as LuaFunction);
					this.m_BattlePrepareUIController_OnPointerClickInputButtonVector2_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnPointerClick") as LuaFunction);
					this.m_BattlePrepareUIController_OnBeginDragHero_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnBeginDragHero") as LuaFunction);
					this.m_BattlePrepareUIController_OnEndDragHero_hotfix = (luaObj.RawGet("BattlePrepareUIController_OnEndDragHero") as LuaFunction);
					this.m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix = (luaObj.RawGet("BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel") as LuaFunction);
					this.m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList`1_hotfix = (luaObj.RawGet("BattlePrepareActorInfoUIController_OnChangeSkill") as LuaFunction);
					this.m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix = (luaObj.RawGet("BattlePrepareActorInfoUIController_OnChangeSoldier") as LuaFunction);
					this.m_ActionOrderUIController_OnConfirm_hotfix = (luaObj.RawGet("ActionOrderUIController_OnConfirm") as LuaFunction);
					this.m_SetUIStateRegret_hotfix = (luaObj.RawGet("SetUIStateRegret") as LuaFunction);
					this.m_IsRegretActive_hotfix = (luaObj.RawGet("IsRegretActive") as LuaFunction);
					this.m_CanUseRegret_hotfix = (luaObj.RawGet("CanUseRegret") as LuaFunction);
					this.m_RegretGotoStepInt32_hotfix = (luaObj.RawGet("RegretGotoStep") as LuaFunction);
					this.m_FindRegretStepIndexInt32_hotfix = (luaObj.RawGet("FindRegretStepIndex") as LuaFunction);
					this.m_BattleUIController_OnRegretActive_hotfix = (luaObj.RawGet("BattleUIController_OnRegretActive") as LuaFunction);
					this.m_BattleUIController_OnRegretConfirm_hotfix = (luaObj.RawGet("BattleUIController_OnRegretConfirm") as LuaFunction);
					this.m_BattleUIController_OnRegretCancel_hotfix = (luaObj.RawGet("BattleUIController_OnRegretCancel") as LuaFunction);
					this.m_BattleUIController_OnRegretBackward_hotfix = (luaObj.RawGet("BattleUIController_OnRegretBackward") as LuaFunction);
					this.m_BattleUIController_OnRegretForward_hotfix = (luaObj.RawGet("BattleUIController_OnRegretForward") as LuaFunction);
					this.m_UserGuide_GetEnforceHeros_hotfix = (luaObj.RawGet("UserGuide_GetEnforceHeros") as LuaFunction);
					this.m_SetUserGuideBattleSettings_hotfix = (luaObj.RawGet("SetUserGuideBattleSettings") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x00345A1C File Offset: 0x00343C1C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007616 RID: 30230
		private const int BattleDanmakuLayerIndex = 0;

		// Token: 0x04007617 RID: 30231
		private const int BattleRoomLayerIndex = 1;

		// Token: 0x04007618 RID: 30232
		private const int BattleLayerIndex = 2;

		// Token: 0x04007619 RID: 30233
		private const int BattleActorInfoLayerIndex = 3;

		// Token: 0x0400761A RID: 30234
		private const int BattlePrepareLayerIndex = 4;

		// Token: 0x0400761B RID: 30235
		private const int PVPBattlePrepareLayerIndex = 5;

		// Token: 0x0400761C RID: 30236
		private const int BattlePrepareActorInfoLayerIndex = 6;

		// Token: 0x0400761D RID: 30237
		private const int ActionOrderLayerIndex = 7;

		// Token: 0x0400761E RID: 30238
		private const int BattlePauseLayerIndex = 8;

		// Token: 0x0400761F RID: 30239
		private const int BattleTreasureDialogLayerIndex = 9;

		// Token: 0x04007620 RID: 30240
		private const int CombatLayerIndex = 10;

		// Token: 0x04007621 RID: 30241
		private const int PreCombatLayerIndex = 11;

		// Token: 0x04007622 RID: 30242
		private const int BattleCommonLayerIndex = 12;

		// Token: 0x04007623 RID: 30243
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleSceneLayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleScenePrefab.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleDanmakuUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleDanmakuUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleRoomUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleRoomUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleActorInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleActorInfoUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattlePrepareUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattlePrepareUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "PVPBattlePrepareUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/PVPBattlePrepareUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattlePrepareActorInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattlePrepareActorInfoUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ActionOrderUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/ActionOrderUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattlePauseUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattlePauseUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleTreasureDialogUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleTreasureDialogUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "CombatUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/CombatUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "PreCombatUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/PreCombatUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleCommonUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleCommonUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007624 RID: 30244
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleDanmakuUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleDanmakuUIController"),
				m_ctrlName = "BattleDanmakuUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleRoomUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleRoomUIController"),
				m_ctrlName = "BattleRoomUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleUIController"),
				m_ctrlName = "BattleUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleActorInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleActorInfoUIController"),
				m_ctrlName = "BattleActorInfoUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattlePrepareUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattlePrepareUIController"),
				m_ctrlName = "BattlePrepareUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PVPBattlePrepareUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PVPBattlePrepareUIController"),
				m_ctrlName = "PVPBattlePrepareUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattlePrepareActorInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattlePrepareActorInfoUIController"),
				m_ctrlName = "BattlePrepareActorInfoUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ActionOrderUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ActionOrderUIController"),
				m_ctrlName = "ActionOrderUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattlePauseUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattlePauseUIController"),
				m_ctrlName = "BattlePauseUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleTreasureDialogUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleTreasureDialogUIController"),
				m_ctrlName = "BattleTreasureDialogUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "CombatUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.CombatUIController"),
				m_ctrlName = "CombatUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PreCombatUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PreCombatUIController"),
				m_ctrlName = "PreCombatUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleCommonUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleCommonUIController"),
				m_ctrlName = "BattleCommonUIController"
			}
		};

		// Token: 0x04007625 RID: 30245
		private BattleUIController m_battleUIController;

		// Token: 0x04007626 RID: 30246
		private BattleDanmakuUIController m_battleDanmakuUIController;

		// Token: 0x04007627 RID: 30247
		private BattleActorInfoUIController m_battleActorInfoUIController;

		// Token: 0x04007628 RID: 30248
		private BattlePrepareUIController m_battlePrepareUIController;

		// Token: 0x04007629 RID: 30249
		private PVPBattlePrepareUIController m_pvpBattlePrepareUIController;

		// Token: 0x0400762A RID: 30250
		private BattlePrepareActorInfoUIController m_battlePrepareActorInfoUIController;

		// Token: 0x0400762B RID: 30251
		private ActionOrderUIController m_actionOrderUIController;

		// Token: 0x0400762C RID: 30252
		private BattlePauseUIController m_battlePauseUIController;

		// Token: 0x0400762D RID: 30253
		private BattleTreasureDialogUIController m_battleTreasureDialogUIController;

		// Token: 0x0400762E RID: 30254
		private CombatUIController m_combatUIController;

		// Token: 0x0400762F RID: 30255
		private PreCombatUIController m_preCombatUIController;

		// Token: 0x04007630 RID: 30256
		private BattleRoomUIController m_battleRoomUIController;

		// Token: 0x04007631 RID: 30257
		private BattleCommonUIController m_battleCommonUIController;

		// Token: 0x04007632 RID: 30258
		private BattleMapUIController m_battleMapUIController;

		// Token: 0x04007633 RID: 30259
		private BattleSceneUIController m_battleSceneUIController;

		// Token: 0x04007634 RID: 30260
		private CombatSceneUIController m_combatSceneUIController;

		// Token: 0x04007635 RID: 30261
		private GetRewardGoodsUITask m_getRewardGoodsUITask;

		// Token: 0x04007636 RID: 30262
		private BattleDialogUITask m_battleDialogUITask;

		// Token: 0x04007637 RID: 30263
		private BattleResultUITask m_battleResultUITask;

		// Token: 0x04007638 RID: 30264
		private BattleResultScoreUITask m_battleResultScoreUITask;

		// Token: 0x04007639 RID: 30265
		private BattleLoseUITask m_battleLoseUITask;

		// Token: 0x0400763A RID: 30266
		private BattleReportEndUITask m_battleReportEndUITask;

		// Token: 0x0400763B RID: 30267
		private ClientBattle m_clientBattle;

		// Token: 0x0400763C RID: 30268
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400763D RID: 30269
		private BattleUIState m_uiState;

		// Token: 0x0400763E RID: 30270
		private ClientBattleActor m_activeActor;

		// Token: 0x0400763F RID: 30271
		private GridPosition m_activeActorInitPosition;

		// Token: 0x04007640 RID: 30272
		private int m_activeActorInitDirection;

		// Token: 0x04007641 RID: 30273
		private int m_skillIndex;

		// Token: 0x04007642 RID: 30274
		private GridPosition m_skillTargetPosition;

		// Token: 0x04007643 RID: 30275
		private GridPosition m_skillTargetPosition2;

		// Token: 0x04007644 RID: 30276
		private GridPosition m_combatStartPosition;

		// Token: 0x04007645 RID: 30277
		private GridPosition m_combatTargetPosition;

		// Token: 0x04007646 RID: 30278
		private bool m_isBattleCutsceneFade;

		// Token: 0x04007647 RID: 30279
		private bool m_isCombatCutsceneFade;

		// Token: 0x04007648 RID: 30280
		private DateTime m_battleMapClickTime;

		// Token: 0x04007649 RID: 30281
		private int m_showDangerRegionTeam;

		// Token: 0x0400764A RID: 30282
		private List<int> m_showDangerRegionActorIds = new List<int>();

		// Token: 0x0400764B RID: 30283
		private BattleActor m_preCombatTargetActor;

		// Token: 0x0400764C RID: 30284
		private bool m_saveShowTopUI;

		// Token: 0x0400764D RID: 30285
		private bool m_saveShowBottomUI;

		// Token: 0x0400764E RID: 30286
		private bool m_disableSaveProcessingBattle;

		// Token: 0x0400764F RID: 30287
		private BattleTeamSetup m_battleTeamSetup0 = new BattleTeamSetup();

		// Token: 0x04007650 RID: 30288
		private BattleTeamSetup m_battleTeamSetup1 = new BattleTeamSetup();

		// Token: 0x04007651 RID: 30289
		private List<GridPosition> m_teamPositions0 = new List<GridPosition>();

		// Token: 0x04007652 RID: 30290
		private List<GridPosition> m_teamPositions1 = new List<GridPosition>();

		// Token: 0x04007653 RID: 30291
		private List<GridPosition> m_teamNpcPositions0 = new List<GridPosition>();

		// Token: 0x04007654 RID: 30292
		private List<BattleHero> m_playerBattleHeros = new List<BattleHero>();

		// Token: 0x04007655 RID: 30293
		private List<int> m_tempIntList = new List<int>();

		// Token: 0x04007656 RID: 30294
		private List<string> m_tempStringList = new List<string>();

		// Token: 0x04007657 RID: 30295
		private HashSet<GridPosition> m_dangerRegion = new HashSet<GridPosition>();

		// Token: 0x04007658 RID: 30296
		private List<TrainingTech> m_trainingTechs = new List<TrainingTech>();

		// Token: 0x04007659 RID: 30297
		private List<int> m_userGuideEnforceHeroIds = new List<int>();

		// Token: 0x0400765A RID: 30298
		private List<int> m_arenaAttackerHeroIds = new List<int>();

		// Token: 0x0400765B RID: 30299
		private List<int> m_myBattleHeroIds = new List<int>();

		// Token: 0x0400765C RID: 30300
		private BattleLoadState m_loadState = BattleLoadState.Prepare;

		// Token: 0x0400765D RID: 30301
		private BattlePerformState m_battlePerformState;

		// Token: 0x0400765E RID: 30302
		private bool m_isStartBattleAutoBattle;

		// Token: 0x0400765F RID: 30303
		private int m_nowSeconds;

		// Token: 0x04007660 RID: 30304
		private DateTime m_myActionTimeout = DateTime.MinValue;

		// Token: 0x04007661 RID: 30305
		private DateTime m_otherActionTimeout = DateTime.MinValue;

		// Token: 0x04007662 RID: 30306
		private bool m_isMyActionTimeoutActive;

		// Token: 0x04007663 RID: 30307
		private bool m_isActionTimeoutAutoBattle;

		// Token: 0x04007664 RID: 30308
		private bool m_isAutoBattleOnce;

		// Token: 0x04007665 RID: 30309
		private List<int> m_pendingHeroSetupNtfs = new List<int>();

		// Token: 0x04007666 RID: 30310
		private GridPosition m_selectProtectHeroPos = GridPosition.Null;

		// Token: 0x04007667 RID: 30311
		private GridPosition m_selectBanHeroPos = GridPosition.Null;

		// Token: 0x04007668 RID: 30312
		private List<object> m_collectAssetObjects = new List<object>();

		// Token: 0x04007669 RID: 30313
		private RandomNumber m_armyRandomNumber = new RandomNumber();

		// Token: 0x0400766A RID: 30314
		private ProBattleReport m_battleReport;

		// Token: 0x0400766B RID: 30315
		private int m_battleStopTurn;

		// Token: 0x0400766C RID: 30316
		private bool m_isSendBattleCheatGMCommand;

		// Token: 0x0400766D RID: 30317
		private bool m_isStartInBattleRoom;

		// Token: 0x04007670 RID: 30320
		private List<BattleUITask.RegretStep> m_regretSteps = new List<BattleUITask.RegretStep>();

		// Token: 0x04007671 RID: 30321
		private List<BattleCommand> m_regretBattleCommands = new List<BattleCommand>();

		// Token: 0x04007672 RID: 30322
		private int m_regretFinalStep = -1;

		// Token: 0x04007673 RID: 30323
		private int m_regretCurrentStep = -1;

		// Token: 0x04007674 RID: 30324
		private int m_regretCameraFocusActorId;

		// Token: 0x04007675 RID: 30325
		[DoNotToLua]
		private BattleUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007676 RID: 30326
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x04007677 RID: 30327
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache1;

		// Token: 0x04007679 RID: 30329
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache2;

		// Token: 0x0400767A RID: 30330
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache3;

		// Token: 0x0400767C RID: 30332
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache4;

		// Token: 0x0400767F RID: 30335
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007680 RID: 30336
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007681 RID: 30337
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007682 RID: 30338
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04007683 RID: 30339
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x04007684 RID: 30340
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007685 RID: 30341
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007686 RID: 30342
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007687 RID: 30343
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04007688 RID: 30344
		private LuaFunction m_HideAllView_hotfix;

		// Token: 0x04007689 RID: 30345
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400768A RID: 30346
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x0400768B RID: 30347
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400768C RID: 30348
		private LuaFunction m_IsLoading_hotfix;

		// Token: 0x0400768D RID: 30349
		private LuaFunction m_CreateClientBattle_hotfix;

		// Token: 0x0400768E RID: 30350
		private LuaFunction m_DestroyClientBattle_hotfix;

		// Token: 0x0400768F RID: 30351
		private LuaFunction m_PrepareClientBattleBoolean_hotfix;

		// Token: 0x04007690 RID: 30352
		private LuaFunction m_StartClientBattle_hotfix;

		// Token: 0x04007691 RID: 30353
		private LuaFunction m_StopBattleBooleanBoolean_hotfix;

		// Token: 0x04007692 RID: 30354
		private LuaFunction m_SendBattleRoomInitLog_hotfix;

		// Token: 0x04007693 RID: 30355
		private LuaFunction m_GetBattleTeamSetupInt32_hotfix;

		// Token: 0x04007694 RID: 30356
		private LuaFunction m_GetTeamPositionsInt32_hotfix;

		// Token: 0x04007695 RID: 30357
		private LuaFunction m_SetCombatHpInt32_hotfix;

		// Token: 0x04007696 RID: 30358
		private LuaFunction m_ExitBattleReturnToWorld_hotfix;

		// Token: 0x04007697 RID: 30359
		private LuaFunction m_ShowErrorMessageAndExitBattleInt32_hotfix;

		// Token: 0x04007698 RID: 30360
		private LuaFunction m_ShowErrorMessageAndExitBattleStringTableId_hotfix;

		// Token: 0x04007699 RID: 30361
		private LuaFunction m_SaveProcessingBattle_hotfix;

		// Token: 0x0400769A RID: 30362
		private LuaFunction m_BattlePrepareBeforeShowResult_hotfix;

		// Token: 0x0400769B RID: 30363
		private LuaFunction m_IsMeArenaBattleTeam1_hotfix;

		// Token: 0x0400769C RID: 30364
		private LuaFunction m_CanUseChat_hotfix;

		// Token: 0x0400769D RID: 30365
		private LuaFunction m_CanUseDanmaku_hotfix;

		// Token: 0x0400769E RID: 30366
		private LuaFunction m_get_ClientBattle_hotfix;

		// Token: 0x0400769F RID: 30367
		private LuaFunction m_BattlePauseUIController_OnClose_hotfix;

		// Token: 0x040076A0 RID: 30368
		private LuaFunction m_BattlePauseUIController_OnShowPlayerSetting_hotfix;

		// Token: 0x040076A1 RID: 30369
		private LuaFunction m_BattlePauseUIController_OnExit_hotfix;

		// Token: 0x040076A2 RID: 30370
		private LuaFunction m_ExitBattleDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x040076A3 RID: 30371
		private LuaFunction m_TestUI_ExitBattle_hotfix;

		// Token: 0x040076A4 RID: 30372
		private LuaFunction m_TestUI_RestartBattle_hotfix;

		// Token: 0x040076A5 RID: 30373
		private LuaFunction m_TestUI_ReplayBattle_hotfix;

		// Token: 0x040076A6 RID: 30374
		private LuaFunction m_TestUI_StopBattleBoolean_hotfix;

		// Token: 0x040076A7 RID: 30375
		private LuaFunction m_PlayerContext_OnChatMessageNtfChatMessage_hotfix;

		// Token: 0x040076A8 RID: 30376
		private LuaFunction m_PlayerContext_OnTeamRoomInviteNtfTeamRoomInviteInfo_hotfix;

		// Token: 0x040076A9 RID: 30377
		private LuaFunction m_PlayerContext_OnBattlePracticeInvitedNtfPVPInviteInfo_hotfix;

		// Token: 0x040076AA RID: 30378
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040076AB RID: 30379
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x040076AC RID: 30380
		private LuaFunction m_CollectBattlePrepareAssets_hotfix;

		// Token: 0x040076AD RID: 30381
		private LuaFunction m_CollectBattleAssets_hotfix;

		// Token: 0x040076AE RID: 30382
		private LuaFunction m_CollectBattlePrepareHerosList`1List;

		// Token: 0x040076AF RID: 30383
		private LuaFunction m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix;

		// Token: 0x040076B0 RID: 30384
		private LuaFunction m_CollectTerrainAssetsConfigDataTerrainInfo_hotfix;

		// Token: 0x040076B1 RID: 30385
		private LuaFunction m_CollectCharImageAssetsConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix;

		// Token: 0x040076B2 RID: 30386
		private LuaFunction m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix;

		// Token: 0x040076B3 RID: 30387
		private LuaFunction m_CollectHeroAssetsConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoInt32_hotfix;

		// Token: 0x040076B4 RID: 30388
		private LuaFunction m_CollectSoldierAssetsConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x040076B5 RID: 30389
		private LuaFunction m_CollectSkinAssetsConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x040076B6 RID: 30390
		private LuaFunction m_CollectSkillAssetsConfigDataSkillInfo_hotfix;

		// Token: 0x040076B7 RID: 30391
		private LuaFunction m_CollectBuffAssetsConfigDataBuffInfo_hotfix;

		// Token: 0x040076B8 RID: 30392
		private LuaFunction m_CollectDefaultHeroAssetsConfigDataHeroInfo_hotfix;

		// Token: 0x040076B9 RID: 30393
		private LuaFunction m_CollectBattleEventAssetsConfigDataBattleEventTriggerInfo_hotfix;

		// Token: 0x040076BA RID: 30394
		private LuaFunction m_CollectBattleEventActionAssetsConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x040076BB RID: 30395
		private LuaFunction m_CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix;

		// Token: 0x040076BC RID: 30396
		private LuaFunction m__CollectBattlePerformAssetsConfigDataBattlePerformInfo_hotfix;

		// Token: 0x040076BD RID: 30397
		private LuaFunction m_CollectTrainingTechAssetsList;

		// Token: 0x040076BE RID: 30398
		private LuaFunction m_IsAlreadyCollectAssetObject_hotfix;

		// Token: 0x040076BF RID: 30399
		private LuaFunction m_ClearAlreadyCollectAssets_hotfix;

		// Token: 0x040076C0 RID: 30400
		private LuaFunction m_StartBattleUI_hotfix;

		// Token: 0x040076C1 RID: 30401
		private LuaFunction m_ClientActorTryMoveToClientBattleActorGridPositionInt32_hotfix;

		// Token: 0x040076C2 RID: 30402
		private LuaFunction m_AddCommandIfMovedClientBattleActor_hotfix;

		// Token: 0x040076C3 RID: 30403
		private LuaFunction m_FindAttackPositionInt32GridPosition_hotfix;

		// Token: 0x040076C4 RID: 30404
		private LuaFunction m_CanAction_hotfix;

		// Token: 0x040076C5 RID: 30405
		private LuaFunction m_GetMapBattleActorGridPosition_hotfix;

		// Token: 0x040076C6 RID: 30406
		private LuaFunction m_ResetActorEffect_hotfix;

		// Token: 0x040076C7 RID: 30407
		private LuaFunction m_CanUseSkillAtPositionClientBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040076C8 RID: 30408
		private LuaFunction m_FindMoveRegion_hotfix;

		// Token: 0x040076C9 RID: 30409
		private LuaFunction m_ShowMoveAndAttackRegionBattleActorGridPosition_hotfix;

		// Token: 0x040076CA RID: 30410
		private LuaFunction m_ShowMoveAndAttackRegion_hotfix;

		// Token: 0x040076CB RID: 30411
		private LuaFunction m_ShowMoveRegionBattleActorGridPosition_hotfix;

		// Token: 0x040076CC RID: 30412
		private LuaFunction m_ShowMoveRegion_hotfix;

		// Token: 0x040076CD RID: 30413
		private LuaFunction m_UpdateDangerRegion_hotfix;

		// Token: 0x040076CE RID: 30414
		private LuaFunction m_ShowDangerTeamRegionInt32_hotfix;

		// Token: 0x040076CF RID: 30415
		private LuaFunction m_ShowDangerRegionList;

		// Token: 0x040076D0 RID: 30416
		private LuaFunction m_ShowMovePathClientBattleActorGridPosition_hotfix;

		// Token: 0x040076D1 RID: 30417
		private LuaFunction m_GetSummonMoveTypeInt32_hotfix;

		// Token: 0x040076D2 RID: 30418
		private LuaFunction m_ShowSkillRegionBattleActorInt32GridPosition_hotfix;

		// Token: 0x040076D3 RID: 30419
		private LuaFunction m_ShowSkillRegion_hotfix;

		// Token: 0x040076D4 RID: 30420
		private LuaFunction m_ShowSkillRangeBattleActorInt32GridPosition_hotfix;

		// Token: 0x040076D5 RID: 30421
		private LuaFunction m_ShowSkillRange_hotfix;

		// Token: 0x040076D6 RID: 30422
		private LuaFunction m_ShowTeleportRegionBattleActorInt32GridPosition_hotfix;

		// Token: 0x040076D7 RID: 30423
		private LuaFunction m_ShowTeleportRegion_hotfix;

		// Token: 0x040076D8 RID: 30424
		private LuaFunction m_ShowAttackTargetsBattleActorGridPosition_hotfix;

		// Token: 0x040076D9 RID: 30425
		private LuaFunction m_ShowSkillTargetsClientBattleActorInt32GridPosition_hotfix;

		// Token: 0x040076DA RID: 30426
		private LuaFunction m_ShowSkillTargets_hotfix;

		// Token: 0x040076DB RID: 30427
		private LuaFunction m_ShowBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x040076DC RID: 30428
		private LuaFunction m_ShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x040076DD RID: 30429
		private LuaFunction m_ShowPreCombatBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x040076DE RID: 30430
		private LuaFunction m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x040076DF RID: 30431
		private LuaFunction m_ShowActorInfoBattleActor_hotfix;

		// Token: 0x040076E0 RID: 30432
		private LuaFunction m_HideActorInfo_hotfix;

		// Token: 0x040076E1 RID: 30433
		private LuaFunction m_ShowSelectionMarkAndTerrainGridPosition_hotfix;

		// Token: 0x040076E2 RID: 30434
		private LuaFunction m_SetUIStateNone_hotfix;

		// Token: 0x040076E3 RID: 30435
		private LuaFunction m_SetUIStateSelectActionActor_hotfix;

		// Token: 0x040076E4 RID: 30436
		private LuaFunction m_SetUIStateMove_hotfix;

		// Token: 0x040076E5 RID: 30437
		private LuaFunction m_ShowSkills_hotfix;

		// Token: 0x040076E6 RID: 30438
		private LuaFunction m_SetUIStateExtraMove_hotfix;

		// Token: 0x040076E7 RID: 30439
		private LuaFunction m_SetUIStateSelectSkillTarget_hotfix;

		// Token: 0x040076E8 RID: 30440
		private LuaFunction m_SetUIStateConfirmSkill_hotfix;

		// Token: 0x040076E9 RID: 30441
		private LuaFunction m_SetUIStateSelectTeleportPosition1_hotfix;

		// Token: 0x040076EA RID: 30442
		private LuaFunction m_SetUIStateSelectTeleportPosition2_hotfix;

		// Token: 0x040076EB RID: 30443
		private LuaFunction m_SetUIStateWaitOtherPlayer_hotfix;

		// Token: 0x040076EC RID: 30444
		private LuaFunction m_ShowCanActionActorsUI_hotfix;

		// Token: 0x040076ED RID: 30445
		private LuaFunction m_HideCanActionActorsUI_hotfix;

		// Token: 0x040076EE RID: 30446
		private LuaFunction m_DoAutoBattle_hotfix;

		// Token: 0x040076EF RID: 30447
		private LuaFunction m_SetAutoBattleBoolean_hotfix;

		// Token: 0x040076F0 RID: 30448
		private LuaFunction m_CameraFocusActorInt32_hotfix;

		// Token: 0x040076F1 RID: 30449
		private LuaFunction m_BattleUIController_OnAutoBattleBoolean_hotfix;

		// Token: 0x040076F2 RID: 30450
		private LuaFunction m_BattleUIController_OnFastBattleBoolean_hotfix;

		// Token: 0x040076F3 RID: 30451
		private LuaFunction m_BattleUIController_OnSkipCombatSkipCombatMode_hotfix;

		// Token: 0x040076F4 RID: 30452
		private LuaFunction m_BattleUIController_OnShowDangerBoolean_hotfix;

		// Token: 0x040076F5 RID: 30453
		private LuaFunction m_BattleUIController_OnEndAllAction_hotfix;

		// Token: 0x040076F6 RID: 30454
		private LuaFunction m_EndAllActionDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x040076F7 RID: 30455
		private LuaFunction m_BattleUIController_OnEndAction_hotfix;

		// Token: 0x040076F8 RID: 30456
		private LuaFunction m_BattleUIController_OnShowActorInfo_hotfix;

		// Token: 0x040076F9 RID: 30457
		private LuaFunction m_BattleUIController_OnSelectSkillInt32_hotfix;

		// Token: 0x040076FA RID: 30458
		private LuaFunction m_BattleUIController_OnUseSkill_hotfix;

		// Token: 0x040076FB RID: 30459
		private LuaFunction m_BattleUIController_OnCancelSkill_hotfix;

		// Token: 0x040076FC RID: 30460
		private LuaFunction m_BattleUIController_OnShowChat_hotfix;

		// Token: 0x040076FD RID: 30461
		private LuaFunction m_BattleUIController_OnShowHelp_hotfix;

		// Token: 0x040076FE RID: 30462
		private LuaFunction m_BattleUIController_OnPauseBattle_hotfix;

		// Token: 0x040076FF RID: 30463
		private LuaFunction m_BattleUIController_OnShowArmyRelation_hotfix;

		// Token: 0x04007700 RID: 30464
		private LuaFunction m_BattleUIController_OnPointerDownInputButtonVector2_hotfix;

		// Token: 0x04007701 RID: 30465
		private LuaFunction m_BattleUIController_OnPointerUpInputButtonVector2_hotfix;

		// Token: 0x04007702 RID: 30466
		private LuaFunction m_BattleUIController_OnShowCurTurnDanmakuInt32_hotfix;

		// Token: 0x04007703 RID: 30467
		private LuaFunction m_BattleUIController_OnCloseCurTurnDanmaku_hotfix;

		// Token: 0x04007704 RID: 30468
		private LuaFunction m_BattleUIController_OnShowOneDanmakuDanmakuEntry_hotfix;

		// Token: 0x04007705 RID: 30469
		private LuaFunction m_BattleUIController_OnPointerClickInputButtonVector2_hotfix;

		// Token: 0x04007706 RID: 30470
		private LuaFunction m_OnBattleMapClickGridPositionBoolean_hotfix;

		// Token: 0x04007707 RID: 30471
		private LuaFunction m_ShouldShowActorInfoBattleActor_hotfix;

		// Token: 0x04007708 RID: 30472
		private LuaFunction m_BattleUIController_On3DTouchVector2_hotfix;

		// Token: 0x04007709 RID: 30473
		private LuaFunction m_PlaySelectHeroSoundBattleActor_hotfix;

		// Token: 0x0400770A RID: 30474
		private LuaFunction m_BattleDialogUITask_OnCloseBoolean_hotfix;

		// Token: 0x0400770B RID: 30475
		private LuaFunction m_BattleTreasureDialogUIController_OnClose_hotfix;

		// Token: 0x0400770C RID: 30476
		private LuaFunction m_GetRewardGoodsUITask_OnStopTask_hotfix;

		// Token: 0x0400770D RID: 30477
		private LuaFunction m_GetRewardGoodsUITask_OnClose_hotfix;

		// Token: 0x0400770E RID: 30478
		private LuaFunction m_CombatUIController_OnAutoBattleBoolean_hotfix;

		// Token: 0x0400770F RID: 30479
		private LuaFunction m_PreCombatUIController_OnOk_hotfix;

		// Token: 0x04007710 RID: 30480
		private LuaFunction m_PreCombatUIController_OnCancel_hotfix;

		// Token: 0x04007711 RID: 30481
		private LuaFunction m_PreCombatUIController_OnStop_hotfix;

		// Token: 0x04007712 RID: 30482
		private LuaFunction m_BattleSceneUIController_OnPointerDownPointerEventData_hotfix;

		// Token: 0x04007713 RID: 30483
		private LuaFunction m_BattleSceneUIController_OnPointerUpPointerEventData_hotfix;

		// Token: 0x04007714 RID: 30484
		private LuaFunction m_BattleSceneUIController_OnPointerClickPointerEventData_hotfix;

		// Token: 0x04007715 RID: 30485
		private LuaFunction m_BattleSceneUIController_OnBeginDragPointerEventData_hotfix;

		// Token: 0x04007716 RID: 30486
		private LuaFunction m_BattleSceneUIController_OnEndDragPointerEventData_hotfix;

		// Token: 0x04007717 RID: 30487
		private LuaFunction m_BattleSceneUIController_OnDragPointerEventData_hotfix;

		// Token: 0x04007718 RID: 30488
		private LuaFunction m_BattleSceneUIController_On3DTouchVector2_hotfix;

		// Token: 0x04007719 RID: 30489
		private LuaFunction m_SendBattleCommands_hotfix;

		// Token: 0x0400771A RID: 30490
		private LuaFunction m_UpdateBattleRoomPlayerHeroStatus_hotfix;

		// Token: 0x0400771B RID: 30491
		private LuaFunction m_StartBattleRoomMyActionCountdown_hotfix;

		// Token: 0x0400771C RID: 30492
		private LuaFunction m_StopBattleRoomMyActionCountdown_hotfix;

		// Token: 0x0400771D RID: 30493
		private LuaFunction m_ActivateBattleRoomMyActionCountdownBoolean_hotfix;

		// Token: 0x0400771E RID: 30494
		private LuaFunction m_UpdateBattleRoomMyActionCountdown_hotfix;

		// Token: 0x0400771F RID: 30495
		private LuaFunction m_StartBattleRoomOtherActionCountdownInt32_hotfix;

		// Token: 0x04007720 RID: 30496
		private LuaFunction m_StopBattleRoomOtherActionCountdown_hotfix;

		// Token: 0x04007721 RID: 30497
		private LuaFunction m_ActivateBattleRoomOtherActionCountdownBoolean_hotfix;

		// Token: 0x04007722 RID: 30498
		private LuaFunction m_UpdateBattleRoomOtherActionCountdown_hotfix;

		// Token: 0x04007723 RID: 30499
		private LuaFunction m_BattleRoomSetAutoBattleBoolean_hotfix;

		// Token: 0x04007724 RID: 30500
		private LuaFunction m_ProcessBattlePendingNtfs_hotfix;

		// Token: 0x04007725 RID: 30501
		private LuaFunction m_PlayerContext_OnBattleRoomPlayerStatusChangedNtfUInt64_hotfix;

		// Token: 0x04007726 RID: 30502
		private LuaFunction m_PlayerContext_OnBattleRoomPlayerQuitNtfUInt64BattleRoomQuitReason_hotfix;

		// Token: 0x04007727 RID: 30503
		private LuaFunction m_PlayerContext_OnBattleRoomBattleCommandExecuteNtfUInt64_hotfix;

		// Token: 0x04007728 RID: 30504
		private LuaFunction m_PlayerContext_OnBattleRoomTeamBattleFinishNtf_hotfix;

		// Token: 0x04007729 RID: 30505
		private LuaFunction m_PlayerContext_OnBattleRoomPVPBattleFinishNtf_hotfix;

		// Token: 0x0400772A RID: 30506
		private LuaFunction m_PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf_hotfix;

		// Token: 0x0400772B RID: 30507
		private LuaFunction m_PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf_hotfix;

		// Token: 0x0400772C RID: 30508
		private LuaFunction m_PlayerContext_OnBattleRoomPVPBattleJoinNtf_hotfix;

		// Token: 0x0400772D RID: 30509
		private LuaFunction m_PlayerContext_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x0400772E RID: 30510
		private LuaFunction m_ReloginUITask_OnReloginSuccess_hotfix;

		// Token: 0x0400772F RID: 30511
		private LuaFunction m_GetBattleRoom_hotfix;

		// Token: 0x04007730 RID: 30512
		private LuaFunction m_UpdateBattleRoomPrepareTimeout_hotfix;

		// Token: 0x04007731 RID: 30513
		private LuaFunction m_UpdateRealtimePVPBattlePrepareTimeout_hotfix;

		// Token: 0x04007732 RID: 30514
		private LuaFunction m_UpdateRealtimePVPBattlePrepareStatus_hotfix;

		// Token: 0x04007733 RID: 30515
		private LuaFunction m_UpdateStageActorTagBattlePrepareStageActor_hotfix;

		// Token: 0x04007734 RID: 30516
		private LuaFunction m_ProcessBattlePreparePendingNtfsBoolean_hotfix;

		// Token: 0x04007735 RID: 30517
		private LuaFunction m_LoadAndUpdateBattleRoomStageActorsList;

		// Token: 0x04007736 RID: 30518
		private LuaFunction m_UpdateBattleRoomStageActorsInt32BattleHeroBoolean_hotfix;

		// Token: 0x04007737 RID: 30519
		private LuaFunction m_BattleRoomBattleStart_hotfix;

		// Token: 0x04007738 RID: 30520
		private LuaFunction m_PVPBattlePrepareUIController_OnPrepareConfirm_hotfix;

		// Token: 0x04007739 RID: 30521
		private LuaFunction m_PlayerContext_OnBattleRoomHeroSetupNtfList;

		// Token: 0x0400773A RID: 30522
		private LuaFunction m_PlayerContext_OnBattleRoomDataChangeNtf_hotfix;

		// Token: 0x0400773B RID: 30523
		private LuaFunction m_PlayerContext_OnBattleRoomTeamBattleStartNtf_hotfix;

		// Token: 0x0400773C RID: 30524
		private LuaFunction m_PlayerContext_OnBattleRoomPVPBattleStartNtf_hotfix;

		// Token: 0x0400773D RID: 30525
		private LuaFunction m_PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf_hotfix;

		// Token: 0x0400773E RID: 30526
		private LuaFunction m_ShowBattleResultBattleTypeInt32BattleRewardBooleanList;

		// Token: 0x0400773F RID: 30527
		private LuaFunction m_ShowBattleLose_hotfix;

		// Token: 0x04007740 RID: 30528
		private LuaFunction m_ShowBattleReportEndArenaBattleReport_hotfix;

		// Token: 0x04007741 RID: 30529
		private LuaFunction m_ShowBattleReportEndRealTimePVPBattleReport_hotfix;

		// Token: 0x04007742 RID: 30530
		private LuaFunction m_BuildBattleReport_hotfix;

		// Token: 0x04007743 RID: 30531
		private LuaFunction m_CheckBattleResult_hotfix;

		// Token: 0x04007744 RID: 30532
		private LuaFunction m_SendBattleCheatGMCommandBoolean_hotfix;

		// Token: 0x04007745 RID: 30533
		private LuaFunction m_BattleResultEnd_hotfix;

		// Token: 0x04007746 RID: 30534
		private LuaFunction m_BattleRoomInviteTeammateDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x04007747 RID: 30535
		private LuaFunction m_BattleUIController_OnWinOrLoseEnd_hotfix;

		// Token: 0x04007748 RID: 30536
		private LuaFunction m_BattleResultUITask_OnStopTask_hotfix;

		// Token: 0x04007749 RID: 30537
		private LuaFunction m_BattleResultUITask_OnClose_hotfix;

		// Token: 0x0400774A RID: 30538
		private LuaFunction m_BattleResultScoreUITask_OnStopTask_hotfix;

		// Token: 0x0400774B RID: 30539
		private LuaFunction m_BattleResultScoreUITask_OnClose_hotfix;

		// Token: 0x0400774C RID: 30540
		private LuaFunction m_BattleLoseUITask_OnStopTask_hotfix;

		// Token: 0x0400774D RID: 30541
		private LuaFunction m_BattleLoseUITask_OnClose_hotfix;

		// Token: 0x0400774E RID: 30542
		private LuaFunction m_BattleReportEndUITask_OnStopTask_hotfix;

		// Token: 0x0400774F RID: 30543
		private LuaFunction m_BattleReportEndUITask_OnClose_hotfix;

		// Token: 0x04007750 RID: 30544
		private LuaFunction m_BattleReportEndUITask_OnPlayAgain_hotfix;

		// Token: 0x04007751 RID: 30545
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x04007752 RID: 30546
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x04007753 RID: 30547
		private LuaFunction m_InitBattleSceneUIController_hotfix;

		// Token: 0x04007754 RID: 30548
		private LuaFunction m_UninitBattleSceneUIController_hotfix;

		// Token: 0x04007755 RID: 30549
		private LuaFunction m_InitBattleUIController_hotfix;

		// Token: 0x04007756 RID: 30550
		private LuaFunction m_UninitBattleUIController_hotfix;

		// Token: 0x04007757 RID: 30551
		private LuaFunction m_InitCombatUIController_hotfix;

		// Token: 0x04007758 RID: 30552
		private LuaFunction m_UninitCombatUIController_hotfix;

		// Token: 0x04007759 RID: 30553
		private LuaFunction m_InitPreCombatUIController_hotfix;

		// Token: 0x0400775A RID: 30554
		private LuaFunction m_UninitPreCombatUIController_hotfix;

		// Token: 0x0400775B RID: 30555
		private LuaFunction m_InitBattleRoomUIController_hotfix;

		// Token: 0x0400775C RID: 30556
		private LuaFunction m_UninitBattleRoomUIController_hotfix;

		// Token: 0x0400775D RID: 30557
		private LuaFunction m_InitBattleCommonUIController_hotfix;

		// Token: 0x0400775E RID: 30558
		private LuaFunction m_UninitBattleCommonUIController_hotfix;

		// Token: 0x0400775F RID: 30559
		private LuaFunction m_InitBattlePrepareUIController_hotfix;

		// Token: 0x04007760 RID: 30560
		private LuaFunction m_UninitBattlePrepareUIController_hotfix;

		// Token: 0x04007761 RID: 30561
		private LuaFunction m_OnStartBattle_hotfix;

		// Token: 0x04007762 RID: 30562
		private LuaFunction m_OnStopBattleBooleanBoolean_hotfix;

		// Token: 0x04007763 RID: 30563
		private LuaFunction m_OnShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix;

		// Token: 0x04007764 RID: 30564
		private LuaFunction m_OnHideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix;

		// Token: 0x04007765 RID: 30565
		private LuaFunction m_OnShowBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix;

		// Token: 0x04007766 RID: 30566
		private LuaFunction m_OnHideBattleLoseConditionConfigDataBattleLoseConditionInfoGridPosition_hotfix;

		// Token: 0x04007767 RID: 30567
		private LuaFunction m_OnNextTurnInt32_hotfix;

		// Token: 0x04007768 RID: 30568
		private LuaFunction m_OnNextTurnAnimationEndInt32_hotfix;

		// Token: 0x04007769 RID: 30569
		private LuaFunction m_OnNextTeamInt32_hotfix;

		// Token: 0x0400776A RID: 30570
		private LuaFunction m_OnNextPlayerInt32_hotfix;

		// Token: 0x0400776B RID: 30571
		private LuaFunction m_OnNextActorBattleActor_hotfix;

		// Token: 0x0400776C RID: 30572
		private LuaFunction m_OnClientActorActiveClientBattleActorBooleanInt32_hotfix;

		// Token: 0x0400776D RID: 30573
		private LuaFunction m_OnClientActorMoveClientBattleActor_hotfix;

		// Token: 0x0400776E RID: 30574
		private LuaFunction m_OnClientActorTryMoveClientBattleActor_hotfix;

		// Token: 0x0400776F RID: 30575
		private LuaFunction m_OnClientActorNoActClientBattleActor_hotfix;

		// Token: 0x04007770 RID: 30576
		private LuaFunction m_OnClientActorTargetClientBattleActorConfigDataSkillInfoGridPositionInt32_hotfix;

		// Token: 0x04007771 RID: 30577
		private LuaFunction m_OnClientActorSkillClientBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04007772 RID: 30578
		private LuaFunction m_OnClientActorSkillEndClientBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04007773 RID: 30579
		private LuaFunction m_OnClientActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007774 RID: 30580
		private LuaFunction m_OnClientActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007775 RID: 30581
		private LuaFunction m_OnClientActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007776 RID: 30582
		private LuaFunction m_OnClientActorImmuneClientBattleActor_hotfix;

		// Token: 0x04007777 RID: 30583
		private LuaFunction m_OnClientActorPassiveSkillClientBattleActorBuffState_hotfix;

		// Token: 0x04007778 RID: 30584
		private LuaFunction m_OnClientActorGuardClientBattleActorClientBattleActor_hotfix;

		// Token: 0x04007779 RID: 30585
		private LuaFunction m_OnClientActorDieClientBattleActor_hotfix;

		// Token: 0x0400777A RID: 30586
		private LuaFunction m_OnClientActorAppearClientBattleActor_hotfix;

		// Token: 0x0400777B RID: 30587
		private LuaFunction m_OnCancelCombat_hotfix;

		// Token: 0x0400777C RID: 30588
		private LuaFunction m_OnPreStartCombatClientBattleActorClientBattleActor_hotfix;

		// Token: 0x0400777D RID: 30589
		private LuaFunction m_OnStartCombatClientBattleActorClientBattleActorBoolean_hotfix;

		// Token: 0x0400777E RID: 30590
		private LuaFunction m_OnPreStopCombat_hotfix;

		// Token: 0x0400777F RID: 30591
		private LuaFunction m_OnStopCombat_hotfix;

		// Token: 0x04007780 RID: 30592
		private LuaFunction m_OnPrepareFastCombatClientBattleActorClientBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04007781 RID: 30593
		private LuaFunction m_OnStartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x04007782 RID: 30594
		private LuaFunction m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007783 RID: 30595
		private LuaFunction m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix;

		// Token: 0x04007784 RID: 30596
		private LuaFunction m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix;

		// Token: 0x04007785 RID: 30597
		private LuaFunction m_OnStopSkillCutscene_hotfix;

		// Token: 0x04007786 RID: 30598
		private LuaFunction m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix;

		// Token: 0x04007787 RID: 30599
		private LuaFunction m_BattleDialogUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04007788 RID: 30600
		private LuaFunction m_OnStartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x04007789 RID: 30601
		private LuaFunction m_OnShowBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x0400778A RID: 30602
		private LuaFunction m_OnStartBattlePerform_hotfix;

		// Token: 0x0400778B RID: 30603
		private LuaFunction m_OnStopBattlePerform_hotfix;

		// Token: 0x0400778C RID: 30604
		private LuaFunction m_OnScreenEffectString_hotfix;

		// Token: 0x0400778D RID: 30605
		private LuaFunction m_StartBattleTeamSetNetTaskBattleTypeInt32List;

		// Token: 0x0400778E RID: 30606
		private LuaFunction m_StartLevelAttackNetTask_hotfix;

		// Token: 0x0400778F RID: 30607
		private LuaFunction m_StartLevelWayPointMoveNetTaskConfigDataWaypointInfo_hotfix;

		// Token: 0x04007790 RID: 30608
		private LuaFunction m_StartLevelScenarioHandleNetTaskConfigDataScenarioInfo_hotfix;

		// Token: 0x04007791 RID: 30609
		private LuaFunction m_StartRiftLevelAttackNetTaskConfigDataRiftLevelInfo_hotfix;

		// Token: 0x04007792 RID: 30610
		private LuaFunction m_StartHeroDungeonLevelAttackNetTaskConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04007793 RID: 30611
		private LuaFunction m_StartAnikiLevelAttackNetTaskConfigDataAnikiLevelInfo_hotfix;

		// Token: 0x04007794 RID: 30612
		private LuaFunction m_StartThearchyLevelAttackNetTaskConfigDataThearchyTrialLevelInfo_hotfix;

		// Token: 0x04007795 RID: 30613
		private LuaFunction m_StartMemoryCorridorLevelAttackNetTaskConfigDataMemoryCorridorLevelInfo_hotfix;

		// Token: 0x04007796 RID: 30614
		private LuaFunction m_StartHeroTrainningLevelAttackNetTaskConfigDataHeroTrainningLevelInfo_hotfix;

		// Token: 0x04007797 RID: 30615
		private LuaFunction m_StartHeroPhantomLevelAttackNetTaskConfigDataHeroPhantomLevelInfo_hotfix;

		// Token: 0x04007798 RID: 30616
		private LuaFunction m_StartTreasureLevelAttackNetTaskConfigDataTreasureLevelInfo_hotfix;

		// Token: 0x04007799 RID: 30617
		private LuaFunction m_StartUnchartedScoreLevelAttackNetTaskConfigDataScoreLevelInfo_hotfix;

		// Token: 0x0400779A RID: 30618
		private LuaFunction m_StartUnchartedChallengeLevelAttackNetTaskConfigDataChallengeLevelInfo_hotfix;

		// Token: 0x0400779B RID: 30619
		private LuaFunction m_StartClimbTowerLevelAttackNetTaskConfigDataTowerFloorInfo_hotfix;

		// Token: 0x0400779C RID: 30620
		private LuaFunction m_StartGuildMassiveCombatAttackNetTaskConfigDataGuildMassiveCombatLevelInfoList;

		// Token: 0x0400779D RID: 30621
		private LuaFunction m_StartArenaOpponentAttackFightingNetTask_hotfix;

		// Token: 0x0400779E RID: 30622
		private LuaFunction m_HandleLevelAttackNetTaskResultInt32_hotfix;

		// Token: 0x0400779F RID: 30623
		private LuaFunction m_StartWayPointBattleFinishedNetTaskConfigDataWaypointInfo_hotfix;

		// Token: 0x040077A0 RID: 30624
		private LuaFunction m_StartRiftLevelBattleFinishedNetTaskConfigDataRiftLevelInfo_hotfix;

		// Token: 0x040077A1 RID: 30625
		private LuaFunction m_StartHeroDungeonLevelBattleFinishedNetTaskConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x040077A2 RID: 30626
		private LuaFunction m_StartAnikiLevelBattleFinishedNetTaskConfigDataAnikiLevelInfo_hotfix;

		// Token: 0x040077A3 RID: 30627
		private LuaFunction m_StartThearchyLevelBattleFinishedNetTaskConfigDataThearchyTrialLevelInfo_hotfix;

		// Token: 0x040077A4 RID: 30628
		private LuaFunction m_StartTreasureLevelBattleFinishedNetTaskConfigDataTreasureLevelInfo_hotfix;

		// Token: 0x040077A5 RID: 30629
		private LuaFunction m_StartMemoryCorridorLevelBattleFinishedNetTaskConfigDataMemoryCorridorLevelInfo_hotfix;

		// Token: 0x040077A6 RID: 30630
		private LuaFunction m_StartHeroTrainningLevelBattleFinishedNetTaskConfigDataHeroTrainningLevelInfo_hotfix;

		// Token: 0x040077A7 RID: 30631
		private LuaFunction m_StartHeroPhantomLevelBattleFinishedNetTaskConfigDataHeroPhantomLevelInfo_hotfix;

		// Token: 0x040077A8 RID: 30632
		private LuaFunction m_StartUnchartedScoreLevelBattleFinishedNetTaskConfigDataScoreLevelInfo_hotfix;

		// Token: 0x040077A9 RID: 30633
		private LuaFunction m_StartUnchartedChallengeLevelBattleFinishedNetTaskConfigDataChallengeLevelInfo_hotfix;

		// Token: 0x040077AA RID: 30634
		private LuaFunction m_StartClimbTowerLevelBattleFinishedNetTaskConfigDataTowerFloorInfo_hotfix;

		// Token: 0x040077AB RID: 30635
		private LuaFunction m_StartGuildMassiveCombatSinglePVEBattleEndNetTaskConfigDataGuildMassiveCombatLevelInfo_hotfix;

		// Token: 0x040077AC RID: 30636
		private LuaFunction m_StartArenaBattleFinishedNetTask_hotfix;

		// Token: 0x040077AD RID: 30637
		private LuaFunction m_HandleBattleFinishedNetTaskResultInt32BooleanBattleRewardInt32BooleanList;

		// Token: 0x040077AE RID: 30638
		private LuaFunction m_StartBattleCancelNetTask_hotfix;

		// Token: 0x040077AF RID: 30639
		private LuaFunction m_StartDanmakuPostNetTaskAction;

		// Token: 0x040077B0 RID: 30640
		private LuaFunction m_StartBattleRoomHeroSetupNetTaskInt32Int32_hotfix;

		// Token: 0x040077B1 RID: 30641
		private LuaFunction m_StartBattleRoomHeroSwapNetTaskInt32Int32_hotfix;

		// Token: 0x040077B2 RID: 30642
		private LuaFunction m_StartBattleRoomHeroSetoffNetTaskInt32_hotfix;

		// Token: 0x040077B3 RID: 30643
		private LuaFunction m_StartBattleRoomPlayerStatusChangeNetTaskPlayerBattleStatusAction_hotfix;

		// Token: 0x040077B4 RID: 30644
		private LuaFunction m_StartBattleRoomQuitNetTask_hotfix;

		// Token: 0x040077B5 RID: 30645
		private LuaFunction m_StartBattleRoomEndCurrentBPTurnNetTaskAction_hotfix;

		// Token: 0x040077B6 RID: 30646
		private LuaFunction m_StartBattleRoomPlayerActionBeginNetTask_hotfix;

		// Token: 0x040077B7 RID: 30647
		private LuaFunction m_PrepareBattleUI_hotfix;

		// Token: 0x040077B8 RID: 30648
		private LuaFunction m_SetupReachRegionBoolean_hotfix;

		// Token: 0x040077B9 RID: 30649
		private LuaFunction m_SetupBattlePauseUIControllerList;

		// Token: 0x040077BA RID: 30650
		private LuaFunction m_SetupBattlePauseUIAchievements_hotfix;

		// Token: 0x040077BB RID: 30651
		private LuaFunction m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix;

		// Token: 0x040077BC RID: 30652
		private LuaFunction m_GetMyStageActorCountMax_hotfix;

		// Token: 0x040077BD RID: 30653
		private LuaFunction m_SetupMyHerosConfigDataBattleInfoInt32Boolean_hotfix;

		// Token: 0x040077BE RID: 30654
		private LuaFunction m_FillMyHerosList`1Int32List;

		// Token: 0x040077BF RID: 30655
		private LuaFunction m_SetupStageActorsBoolean_hotfix;

		// Token: 0x040077C0 RID: 30656
		private LuaFunction m_GetTowerBattleRuleInfo_hotfix;

		// Token: 0x040077C1 RID: 30657
		private LuaFunction m_GetTowerBonusHeroGroupInfo_hotfix;

		// Token: 0x040077C2 RID: 30658
		private LuaFunction m_IsTowerPowerUpHeroBattleHero_hotfix;

		// Token: 0x040077C3 RID: 30659
		private LuaFunction m_GetGuildPlayerMassiveCombatInfo_hotfix;

		// Token: 0x040077C4 RID: 30660
		private LuaFunction m_IsGuildMassiveCombatCampUpHeroBattleHero_hotfix;

		// Token: 0x040077C5 RID: 30661
		private LuaFunction m_GetHeroTagTypeBattleHero_hotfix;

		// Token: 0x040077C6 RID: 30662
		private LuaFunction m_LoadArenaAttackerHeroActionValueBattleHero_hotfix;

		// Token: 0x040077C7 RID: 30663
		private LuaFunction m_ShowStagePositions_hotfix;

		// Token: 0x040077C8 RID: 30664
		private LuaFunction m_SetupBattlePrepareTreasures_hotfix;

		// Token: 0x040077C9 RID: 30665
		private LuaFunction m_BuildBattleTeamSetups_hotfix;

		// Token: 0x040077CA RID: 30666
		private LuaFunction m_BuildBattleTeamSetupInt32Boolean_hotfix;

		// Token: 0x040077CB RID: 30667
		private LuaFunction m_GetSoldierCountInt32_hotfix;

		// Token: 0x040077CC RID: 30668
		private LuaFunction m_SetTeamAndStartBattle_hotfix;

		// Token: 0x040077CD RID: 30669
		private LuaFunction m_StartBattlePrepareLoadState_hotfix;

		// Token: 0x040077CE RID: 30670
		private LuaFunction m_StartBattleLoadState_hotfix;

		// Token: 0x040077CF RID: 30671
		private LuaFunction m_ShowMoveAndAttackRegion_PrepareGridPosition_hotfix;

		// Token: 0x040077D0 RID: 30672
		private LuaFunction m_UpdateArenaAttackerHeroIds_hotfix;

		// Token: 0x040077D1 RID: 30673
		private LuaFunction m_GetPlayerTrainingTechsInt32Int32Boolean_hotfix;

		// Token: 0x040077D2 RID: 30674
		private LuaFunction m_GetPlayerLevelInt32Int32_hotfix;

		// Token: 0x040077D3 RID: 30675
		private LuaFunction m_GetPlayerSessionIdInt32_hotfix;

		// Token: 0x040077D4 RID: 30676
		private LuaFunction m_GetMyPlayerIndex_hotfix;

		// Token: 0x040077D5 RID: 30677
		private LuaFunction m_IsBattlePrepareDisableCameraMove_hotfix;

		// Token: 0x040077D6 RID: 30678
		private LuaFunction m_UpdateBattlePower_hotfix;

		// Token: 0x040077D7 RID: 30679
		private LuaFunction m_BattlePrepareUIController_OnPauseBattle_hotfix;

		// Token: 0x040077D8 RID: 30680
		private LuaFunction m_BattlePrepareUIController_OnShowArmyRelation_hotfix;

		// Token: 0x040077D9 RID: 30681
		private LuaFunction m_BattlePrepareUIController_OnStart_hotfix;

		// Token: 0x040077DA RID: 30682
		private LuaFunction m_BattlePrepareUIController_OnShowActionOrder_hotfix;

		// Token: 0x040077DB RID: 30683
		private LuaFunction m_HeroNotFullDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x040077DC RID: 30684
		private LuaFunction m_BattlePrepareUIController_OnTestOnStage_hotfix;

		// Token: 0x040077DD RID: 30685
		private LuaFunction m_BattlePrepareUIController_OnShowMyActorInfoBattleHero_hotfix;

		// Token: 0x040077DE RID: 30686
		private LuaFunction m_BattlePrepareUIController_OnHideActorInfo_hotfix;

		// Token: 0x040077DF RID: 30687
		private LuaFunction m_BattlePrepareUIController_OnStageActorChange_hotfix;

		// Token: 0x040077E0 RID: 30688
		private LuaFunction m_BattlePrepareUIController_OnHeroOnStageBattleHeroGridPositionInt32_hotfix;

		// Token: 0x040077E1 RID: 30689
		private LuaFunction m_BattlePrepareUIController_OnActorOffStageBattlePrepareStageActor_hotfix;

		// Token: 0x040077E2 RID: 30690
		private LuaFunction m_BattlePrepareUIController_OnStageActorMoveBattlePrepareStageActorGridPosition_hotfix;

		// Token: 0x040077E3 RID: 30691
		private LuaFunction m_BattlePrepareUIController_OnStageActorSwapBattlePrepareStageActorBattlePrepareStageActor_hotfix;

		// Token: 0x040077E4 RID: 30692
		private LuaFunction m_BattlePrepareUIController_OnUpdateBattlePower_hotfix;

		// Token: 0x040077E5 RID: 30693
		private LuaFunction m_BattlePrepareUIController_OnShowChat_hotfix;

		// Token: 0x040077E6 RID: 30694
		private LuaFunction m_BattlePrepareUIController_OnShowHelp_hotfix;

		// Token: 0x040077E7 RID: 30695
		private LuaFunction m_BattlePrepareUIController_OnPointerDownInputButtonVector2_hotfix;

		// Token: 0x040077E8 RID: 30696
		private LuaFunction m_BattlePrepareUIController_OnPointerUpInputButtonVector2_hotfix;

		// Token: 0x040077E9 RID: 30697
		private LuaFunction m_BattlePrepareUIController_OnPointerClickInputButtonVector2_hotfix;

		// Token: 0x040077EA RID: 30698
		private LuaFunction m_BattlePrepareUIController_OnBeginDragHero_hotfix;

		// Token: 0x040077EB RID: 30699
		private LuaFunction m_BattlePrepareUIController_OnEndDragHero_hotfix;

		// Token: 0x040077EC RID: 30700
		private LuaFunction m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix;

		// Token: 0x040077ED RID: 30701
		private LuaFunction m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList;

		// Token: 0x040077EE RID: 30702
		private LuaFunction m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix;

		// Token: 0x040077EF RID: 30703
		private LuaFunction m_ActionOrderUIController_OnConfirm_hotfix;

		// Token: 0x040077F0 RID: 30704
		private LuaFunction m_SetUIStateRegret_hotfix;

		// Token: 0x040077F1 RID: 30705
		private LuaFunction m_IsRegretActive_hotfix;

		// Token: 0x040077F2 RID: 30706
		private LuaFunction m_CanUseRegret_hotfix;

		// Token: 0x040077F3 RID: 30707
		private LuaFunction m_RegretGotoStepInt32_hotfix;

		// Token: 0x040077F4 RID: 30708
		private LuaFunction m_FindRegretStepIndexInt32_hotfix;

		// Token: 0x040077F5 RID: 30709
		private LuaFunction m_BattleUIController_OnRegretActive_hotfix;

		// Token: 0x040077F6 RID: 30710
		private LuaFunction m_BattleUIController_OnRegretConfirm_hotfix;

		// Token: 0x040077F7 RID: 30711
		private LuaFunction m_BattleUIController_OnRegretCancel_hotfix;

		// Token: 0x040077F8 RID: 30712
		private LuaFunction m_BattleUIController_OnRegretBackward_hotfix;

		// Token: 0x040077F9 RID: 30713
		private LuaFunction m_BattleUIController_OnRegretForward_hotfix;

		// Token: 0x040077FA RID: 30714
		private LuaFunction m_UserGuide_GetEnforceHeros_hotfix;

		// Token: 0x040077FB RID: 30715
		private LuaFunction m_SetUserGuideBattleSettings_hotfix;

		// Token: 0x02000AD9 RID: 2777
		public struct RegretStep
		{
			// Token: 0x0600B8D0 RID: 47312 RVA: 0x00345A84 File Offset: 0x00343C84
			public RegretStep(int step, int actorId)
			{
				this.Step = step;
				this.ActorId = actorId;
			}

			// Token: 0x040077FC RID: 30716
			public int Step;

			// Token: 0x040077FD RID: 30717
			public int ActorId;
		}

		// Token: 0x02000ADA RID: 2778
		public new class LuaExportHelper
		{
			// Token: 0x0600B8D1 RID: 47313 RVA: 0x00345A94 File Offset: 0x00343C94
			public LuaExportHelper(BattleUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B8D2 RID: 47314 RVA: 0x00345AA4 File Offset: 0x00343CA4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600B8D3 RID: 47315 RVA: 0x00345AB4 File Offset: 0x00343CB4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600B8D4 RID: 47316 RVA: 0x00345AC4 File Offset: 0x00343CC4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600B8D5 RID: 47317 RVA: 0x00345AD4 File Offset: 0x00343CD4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600B8D6 RID: 47318 RVA: 0x00345AE4 File Offset: 0x00343CE4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600B8D7 RID: 47319 RVA: 0x00345AF4 File Offset: 0x00343CF4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600B8D8 RID: 47320 RVA: 0x00345B04 File Offset: 0x00343D04
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600B8D9 RID: 47321 RVA: 0x00345B14 File Offset: 0x00343D14
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600B8DA RID: 47322 RVA: 0x00345B24 File Offset: 0x00343D24
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600B8DB RID: 47323 RVA: 0x00345B34 File Offset: 0x00343D34
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600B8DC RID: 47324 RVA: 0x00345B44 File Offset: 0x00343D44
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600B8DD RID: 47325 RVA: 0x00345B54 File Offset: 0x00343D54
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600B8DE RID: 47326 RVA: 0x00345B64 File Offset: 0x00343D64
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600B8DF RID: 47327 RVA: 0x00345B74 File Offset: 0x00343D74
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600B8E0 RID: 47328 RVA: 0x00345B84 File Offset: 0x00343D84
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600B8E1 RID: 47329 RVA: 0x00345B94 File Offset: 0x00343D94
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600B8E2 RID: 47330 RVA: 0x00345BA4 File Offset: 0x00343DA4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600B8E3 RID: 47331 RVA: 0x00345BB4 File Offset: 0x00343DB4
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600B8E4 RID: 47332 RVA: 0x00345BC4 File Offset: 0x00343DC4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600B8E5 RID: 47333 RVA: 0x00345BD4 File Offset: 0x00343DD4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600B8E6 RID: 47334 RVA: 0x00345BE4 File Offset: 0x00343DE4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600B8E7 RID: 47335 RVA: 0x00345BF4 File Offset: 0x00343DF4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600B8E8 RID: 47336 RVA: 0x00345C04 File Offset: 0x00343E04
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600B8E9 RID: 47337 RVA: 0x00345C14 File Offset: 0x00343E14
			public static void __callDele_m_onActiveActorEvent(ClientBattleActor obj)
			{
				BattleUITask.__callDele_m_onActiveActorEvent(obj);
			}

			// Token: 0x0600B8EA RID: 47338 RVA: 0x00345C1C File Offset: 0x00343E1C
			public static void __clearDele_m_onActiveActorEvent(ClientBattleActor obj)
			{
				BattleUITask.__clearDele_m_onActiveActorEvent(obj);
			}

			// Token: 0x0600B8EB RID: 47339 RVA: 0x00345C24 File Offset: 0x00343E24
			public static void __callDele_m_onDeactiveActorEvent(ClientBattleActor obj)
			{
				BattleUITask.__callDele_m_onDeactiveActorEvent(obj);
			}

			// Token: 0x0600B8EC RID: 47340 RVA: 0x00345C2C File Offset: 0x00343E2C
			public static void __clearDele_m_onDeactiveActorEvent(ClientBattleActor obj)
			{
				BattleUITask.__clearDele_m_onDeactiveActorEvent(obj);
			}

			// Token: 0x1700250B RID: 9483
			// (get) Token: 0x0600B8ED RID: 47341 RVA: 0x00345C34 File Offset: 0x00343E34
			public static int BattleDanmakuLayerIndex
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x1700250C RID: 9484
			// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x00345C38 File Offset: 0x00343E38
			public static int BattleRoomLayerIndex
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x1700250D RID: 9485
			// (get) Token: 0x0600B8EF RID: 47343 RVA: 0x00345C3C File Offset: 0x00343E3C
			public static int BattleLayerIndex
			{
				get
				{
					return 2;
				}
			}

			// Token: 0x1700250E RID: 9486
			// (get) Token: 0x0600B8F0 RID: 47344 RVA: 0x00345C40 File Offset: 0x00343E40
			public static int BattleActorInfoLayerIndex
			{
				get
				{
					return 3;
				}
			}

			// Token: 0x1700250F RID: 9487
			// (get) Token: 0x0600B8F1 RID: 47345 RVA: 0x00345C44 File Offset: 0x00343E44
			public static int BattlePrepareLayerIndex
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x17002510 RID: 9488
			// (get) Token: 0x0600B8F2 RID: 47346 RVA: 0x00345C48 File Offset: 0x00343E48
			public static int PVPBattlePrepareLayerIndex
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x17002511 RID: 9489
			// (get) Token: 0x0600B8F3 RID: 47347 RVA: 0x00345C4C File Offset: 0x00343E4C
			public static int BattlePrepareActorInfoLayerIndex
			{
				get
				{
					return 6;
				}
			}

			// Token: 0x17002512 RID: 9490
			// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x00345C50 File Offset: 0x00343E50
			public static int ActionOrderLayerIndex
			{
				get
				{
					return 7;
				}
			}

			// Token: 0x17002513 RID: 9491
			// (get) Token: 0x0600B8F5 RID: 47349 RVA: 0x00345C54 File Offset: 0x00343E54
			public static int BattlePauseLayerIndex
			{
				get
				{
					return 8;
				}
			}

			// Token: 0x17002514 RID: 9492
			// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x00345C58 File Offset: 0x00343E58
			public static int BattleTreasureDialogLayerIndex
			{
				get
				{
					return 9;
				}
			}

			// Token: 0x17002515 RID: 9493
			// (get) Token: 0x0600B8F7 RID: 47351 RVA: 0x00345C5C File Offset: 0x00343E5C
			public static int CombatLayerIndex
			{
				get
				{
					return 10;
				}
			}

			// Token: 0x17002516 RID: 9494
			// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x00345C60 File Offset: 0x00343E60
			public static int PreCombatLayerIndex
			{
				get
				{
					return 11;
				}
			}

			// Token: 0x17002517 RID: 9495
			// (get) Token: 0x0600B8F9 RID: 47353 RVA: 0x00345C64 File Offset: 0x00343E64
			public static int BattleCommonLayerIndex
			{
				get
				{
					return 12;
				}
			}

			// Token: 0x17002518 RID: 9496
			// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x00345C68 File Offset: 0x00343E68
			// (set) Token: 0x0600B8FB RID: 47355 RVA: 0x00345C78 File Offset: 0x00343E78
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

			// Token: 0x17002519 RID: 9497
			// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x00345C88 File Offset: 0x00343E88
			// (set) Token: 0x0600B8FD RID: 47357 RVA: 0x00345C98 File Offset: 0x00343E98
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

			// Token: 0x1700251A RID: 9498
			// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x00345CA8 File Offset: 0x00343EA8
			// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x00345CB8 File Offset: 0x00343EB8
			public BattleUIController m_battleUIController
			{
				get
				{
					return this.m_owner.m_battleUIController;
				}
				set
				{
					this.m_owner.m_battleUIController = value;
				}
			}

			// Token: 0x1700251B RID: 9499
			// (get) Token: 0x0600B900 RID: 47360 RVA: 0x00345CC8 File Offset: 0x00343EC8
			// (set) Token: 0x0600B901 RID: 47361 RVA: 0x00345CD8 File Offset: 0x00343ED8
			public BattleDanmakuUIController m_battleDanmakuUIController
			{
				get
				{
					return this.m_owner.m_battleDanmakuUIController;
				}
				set
				{
					this.m_owner.m_battleDanmakuUIController = value;
				}
			}

			// Token: 0x1700251C RID: 9500
			// (get) Token: 0x0600B902 RID: 47362 RVA: 0x00345CE8 File Offset: 0x00343EE8
			// (set) Token: 0x0600B903 RID: 47363 RVA: 0x00345CF8 File Offset: 0x00343EF8
			public BattleActorInfoUIController m_battleActorInfoUIController
			{
				get
				{
					return this.m_owner.m_battleActorInfoUIController;
				}
				set
				{
					this.m_owner.m_battleActorInfoUIController = value;
				}
			}

			// Token: 0x1700251D RID: 9501
			// (get) Token: 0x0600B904 RID: 47364 RVA: 0x00345D08 File Offset: 0x00343F08
			// (set) Token: 0x0600B905 RID: 47365 RVA: 0x00345D18 File Offset: 0x00343F18
			public BattlePrepareUIController m_battlePrepareUIController
			{
				get
				{
					return this.m_owner.m_battlePrepareUIController;
				}
				set
				{
					this.m_owner.m_battlePrepareUIController = value;
				}
			}

			// Token: 0x1700251E RID: 9502
			// (get) Token: 0x0600B906 RID: 47366 RVA: 0x00345D28 File Offset: 0x00343F28
			// (set) Token: 0x0600B907 RID: 47367 RVA: 0x00345D38 File Offset: 0x00343F38
			public PVPBattlePrepareUIController m_pvpBattlePrepareUIController
			{
				get
				{
					return this.m_owner.m_pvpBattlePrepareUIController;
				}
				set
				{
					this.m_owner.m_pvpBattlePrepareUIController = value;
				}
			}

			// Token: 0x1700251F RID: 9503
			// (get) Token: 0x0600B908 RID: 47368 RVA: 0x00345D48 File Offset: 0x00343F48
			// (set) Token: 0x0600B909 RID: 47369 RVA: 0x00345D58 File Offset: 0x00343F58
			public BattlePrepareActorInfoUIController m_battlePrepareActorInfoUIController
			{
				get
				{
					return this.m_owner.m_battlePrepareActorInfoUIController;
				}
				set
				{
					this.m_owner.m_battlePrepareActorInfoUIController = value;
				}
			}

			// Token: 0x17002520 RID: 9504
			// (get) Token: 0x0600B90A RID: 47370 RVA: 0x00345D68 File Offset: 0x00343F68
			// (set) Token: 0x0600B90B RID: 47371 RVA: 0x00345D78 File Offset: 0x00343F78
			public ActionOrderUIController m_actionOrderUIController
			{
				get
				{
					return this.m_owner.m_actionOrderUIController;
				}
				set
				{
					this.m_owner.m_actionOrderUIController = value;
				}
			}

			// Token: 0x17002521 RID: 9505
			// (get) Token: 0x0600B90C RID: 47372 RVA: 0x00345D88 File Offset: 0x00343F88
			// (set) Token: 0x0600B90D RID: 47373 RVA: 0x00345D98 File Offset: 0x00343F98
			public BattlePauseUIController m_battlePauseUIController
			{
				get
				{
					return this.m_owner.m_battlePauseUIController;
				}
				set
				{
					this.m_owner.m_battlePauseUIController = value;
				}
			}

			// Token: 0x17002522 RID: 9506
			// (get) Token: 0x0600B90E RID: 47374 RVA: 0x00345DA8 File Offset: 0x00343FA8
			// (set) Token: 0x0600B90F RID: 47375 RVA: 0x00345DB8 File Offset: 0x00343FB8
			public BattleTreasureDialogUIController m_battleTreasureDialogUIController
			{
				get
				{
					return this.m_owner.m_battleTreasureDialogUIController;
				}
				set
				{
					this.m_owner.m_battleTreasureDialogUIController = value;
				}
			}

			// Token: 0x17002523 RID: 9507
			// (get) Token: 0x0600B910 RID: 47376 RVA: 0x00345DC8 File Offset: 0x00343FC8
			// (set) Token: 0x0600B911 RID: 47377 RVA: 0x00345DD8 File Offset: 0x00343FD8
			public CombatUIController m_combatUIController
			{
				get
				{
					return this.m_owner.m_combatUIController;
				}
				set
				{
					this.m_owner.m_combatUIController = value;
				}
			}

			// Token: 0x17002524 RID: 9508
			// (get) Token: 0x0600B912 RID: 47378 RVA: 0x00345DE8 File Offset: 0x00343FE8
			// (set) Token: 0x0600B913 RID: 47379 RVA: 0x00345DF8 File Offset: 0x00343FF8
			public PreCombatUIController m_preCombatUIController
			{
				get
				{
					return this.m_owner.m_preCombatUIController;
				}
				set
				{
					this.m_owner.m_preCombatUIController = value;
				}
			}

			// Token: 0x17002525 RID: 9509
			// (get) Token: 0x0600B914 RID: 47380 RVA: 0x00345E08 File Offset: 0x00344008
			// (set) Token: 0x0600B915 RID: 47381 RVA: 0x00345E18 File Offset: 0x00344018
			public BattleRoomUIController m_battleRoomUIController
			{
				get
				{
					return this.m_owner.m_battleRoomUIController;
				}
				set
				{
					this.m_owner.m_battleRoomUIController = value;
				}
			}

			// Token: 0x17002526 RID: 9510
			// (get) Token: 0x0600B916 RID: 47382 RVA: 0x00345E28 File Offset: 0x00344028
			// (set) Token: 0x0600B917 RID: 47383 RVA: 0x00345E38 File Offset: 0x00344038
			public BattleCommonUIController m_battleCommonUIController
			{
				get
				{
					return this.m_owner.m_battleCommonUIController;
				}
				set
				{
					this.m_owner.m_battleCommonUIController = value;
				}
			}

			// Token: 0x17002527 RID: 9511
			// (get) Token: 0x0600B918 RID: 47384 RVA: 0x00345E48 File Offset: 0x00344048
			// (set) Token: 0x0600B919 RID: 47385 RVA: 0x00345E58 File Offset: 0x00344058
			public BattleMapUIController m_battleMapUIController
			{
				get
				{
					return this.m_owner.m_battleMapUIController;
				}
				set
				{
					this.m_owner.m_battleMapUIController = value;
				}
			}

			// Token: 0x17002528 RID: 9512
			// (get) Token: 0x0600B91A RID: 47386 RVA: 0x00345E68 File Offset: 0x00344068
			// (set) Token: 0x0600B91B RID: 47387 RVA: 0x00345E78 File Offset: 0x00344078
			public BattleSceneUIController m_battleSceneUIController
			{
				get
				{
					return this.m_owner.m_battleSceneUIController;
				}
				set
				{
					this.m_owner.m_battleSceneUIController = value;
				}
			}

			// Token: 0x17002529 RID: 9513
			// (get) Token: 0x0600B91C RID: 47388 RVA: 0x00345E88 File Offset: 0x00344088
			// (set) Token: 0x0600B91D RID: 47389 RVA: 0x00345E98 File Offset: 0x00344098
			public CombatSceneUIController m_combatSceneUIController
			{
				get
				{
					return this.m_owner.m_combatSceneUIController;
				}
				set
				{
					this.m_owner.m_combatSceneUIController = value;
				}
			}

			// Token: 0x1700252A RID: 9514
			// (get) Token: 0x0600B91E RID: 47390 RVA: 0x00345EA8 File Offset: 0x003440A8
			// (set) Token: 0x0600B91F RID: 47391 RVA: 0x00345EB8 File Offset: 0x003440B8
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

			// Token: 0x1700252B RID: 9515
			// (get) Token: 0x0600B920 RID: 47392 RVA: 0x00345EC8 File Offset: 0x003440C8
			// (set) Token: 0x0600B921 RID: 47393 RVA: 0x00345ED8 File Offset: 0x003440D8
			public BattleDialogUITask m_battleDialogUITask
			{
				get
				{
					return this.m_owner.m_battleDialogUITask;
				}
				set
				{
					this.m_owner.m_battleDialogUITask = value;
				}
			}

			// Token: 0x1700252C RID: 9516
			// (get) Token: 0x0600B922 RID: 47394 RVA: 0x00345EE8 File Offset: 0x003440E8
			// (set) Token: 0x0600B923 RID: 47395 RVA: 0x00345EF8 File Offset: 0x003440F8
			public BattleResultUITask m_battleResultUITask
			{
				get
				{
					return this.m_owner.m_battleResultUITask;
				}
				set
				{
					this.m_owner.m_battleResultUITask = value;
				}
			}

			// Token: 0x1700252D RID: 9517
			// (get) Token: 0x0600B924 RID: 47396 RVA: 0x00345F08 File Offset: 0x00344108
			// (set) Token: 0x0600B925 RID: 47397 RVA: 0x00345F18 File Offset: 0x00344118
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

			// Token: 0x1700252E RID: 9518
			// (get) Token: 0x0600B926 RID: 47398 RVA: 0x00345F28 File Offset: 0x00344128
			// (set) Token: 0x0600B927 RID: 47399 RVA: 0x00345F38 File Offset: 0x00344138
			public BattleLoseUITask m_battleLoseUITask
			{
				get
				{
					return this.m_owner.m_battleLoseUITask;
				}
				set
				{
					this.m_owner.m_battleLoseUITask = value;
				}
			}

			// Token: 0x1700252F RID: 9519
			// (get) Token: 0x0600B928 RID: 47400 RVA: 0x00345F48 File Offset: 0x00344148
			// (set) Token: 0x0600B929 RID: 47401 RVA: 0x00345F58 File Offset: 0x00344158
			public BattleReportEndUITask m_battleReportEndUITask
			{
				get
				{
					return this.m_owner.m_battleReportEndUITask;
				}
				set
				{
					this.m_owner.m_battleReportEndUITask = value;
				}
			}

			// Token: 0x17002530 RID: 9520
			// (get) Token: 0x0600B92A RID: 47402 RVA: 0x00345F68 File Offset: 0x00344168
			// (set) Token: 0x0600B92B RID: 47403 RVA: 0x00345F78 File Offset: 0x00344178
			public ClientBattle m_clientBattle
			{
				get
				{
					return this.m_owner.m_clientBattle;
				}
				set
				{
					this.m_owner.m_clientBattle = value;
				}
			}

			// Token: 0x17002531 RID: 9521
			// (get) Token: 0x0600B92C RID: 47404 RVA: 0x00345F88 File Offset: 0x00344188
			// (set) Token: 0x0600B92D RID: 47405 RVA: 0x00345F98 File Offset: 0x00344198
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

			// Token: 0x17002532 RID: 9522
			// (get) Token: 0x0600B92E RID: 47406 RVA: 0x00345FA8 File Offset: 0x003441A8
			// (set) Token: 0x0600B92F RID: 47407 RVA: 0x00345FB8 File Offset: 0x003441B8
			public BattleUIState m_uiState
			{
				get
				{
					return this.m_owner.m_uiState;
				}
				set
				{
					this.m_owner.m_uiState = value;
				}
			}

			// Token: 0x17002533 RID: 9523
			// (get) Token: 0x0600B930 RID: 47408 RVA: 0x00345FC8 File Offset: 0x003441C8
			// (set) Token: 0x0600B931 RID: 47409 RVA: 0x00345FD8 File Offset: 0x003441D8
			public ClientBattleActor m_activeActor
			{
				get
				{
					return this.m_owner.m_activeActor;
				}
				set
				{
					this.m_owner.m_activeActor = value;
				}
			}

			// Token: 0x17002534 RID: 9524
			// (get) Token: 0x0600B932 RID: 47410 RVA: 0x00345FE8 File Offset: 0x003441E8
			// (set) Token: 0x0600B933 RID: 47411 RVA: 0x00345FF8 File Offset: 0x003441F8
			public GridPosition m_activeActorInitPosition
			{
				get
				{
					return this.m_owner.m_activeActorInitPosition;
				}
				set
				{
					this.m_owner.m_activeActorInitPosition = value;
				}
			}

			// Token: 0x17002535 RID: 9525
			// (get) Token: 0x0600B934 RID: 47412 RVA: 0x00346008 File Offset: 0x00344208
			// (set) Token: 0x0600B935 RID: 47413 RVA: 0x00346018 File Offset: 0x00344218
			public int m_activeActorInitDirection
			{
				get
				{
					return this.m_owner.m_activeActorInitDirection;
				}
				set
				{
					this.m_owner.m_activeActorInitDirection = value;
				}
			}

			// Token: 0x17002536 RID: 9526
			// (get) Token: 0x0600B936 RID: 47414 RVA: 0x00346028 File Offset: 0x00344228
			// (set) Token: 0x0600B937 RID: 47415 RVA: 0x00346038 File Offset: 0x00344238
			public int m_skillIndex
			{
				get
				{
					return this.m_owner.m_skillIndex;
				}
				set
				{
					this.m_owner.m_skillIndex = value;
				}
			}

			// Token: 0x17002537 RID: 9527
			// (get) Token: 0x0600B938 RID: 47416 RVA: 0x00346048 File Offset: 0x00344248
			// (set) Token: 0x0600B939 RID: 47417 RVA: 0x00346058 File Offset: 0x00344258
			public GridPosition m_skillTargetPosition
			{
				get
				{
					return this.m_owner.m_skillTargetPosition;
				}
				set
				{
					this.m_owner.m_skillTargetPosition = value;
				}
			}

			// Token: 0x17002538 RID: 9528
			// (get) Token: 0x0600B93A RID: 47418 RVA: 0x00346068 File Offset: 0x00344268
			// (set) Token: 0x0600B93B RID: 47419 RVA: 0x00346078 File Offset: 0x00344278
			public GridPosition m_skillTargetPosition2
			{
				get
				{
					return this.m_owner.m_skillTargetPosition2;
				}
				set
				{
					this.m_owner.m_skillTargetPosition2 = value;
				}
			}

			// Token: 0x17002539 RID: 9529
			// (get) Token: 0x0600B93C RID: 47420 RVA: 0x00346088 File Offset: 0x00344288
			// (set) Token: 0x0600B93D RID: 47421 RVA: 0x00346098 File Offset: 0x00344298
			public GridPosition m_combatStartPosition
			{
				get
				{
					return this.m_owner.m_combatStartPosition;
				}
				set
				{
					this.m_owner.m_combatStartPosition = value;
				}
			}

			// Token: 0x1700253A RID: 9530
			// (get) Token: 0x0600B93E RID: 47422 RVA: 0x003460A8 File Offset: 0x003442A8
			// (set) Token: 0x0600B93F RID: 47423 RVA: 0x003460B8 File Offset: 0x003442B8
			public GridPosition m_combatTargetPosition
			{
				get
				{
					return this.m_owner.m_combatTargetPosition;
				}
				set
				{
					this.m_owner.m_combatTargetPosition = value;
				}
			}

			// Token: 0x1700253B RID: 9531
			// (get) Token: 0x0600B940 RID: 47424 RVA: 0x003460C8 File Offset: 0x003442C8
			// (set) Token: 0x0600B941 RID: 47425 RVA: 0x003460D8 File Offset: 0x003442D8
			public bool m_isBattleCutsceneFade
			{
				get
				{
					return this.m_owner.m_isBattleCutsceneFade;
				}
				set
				{
					this.m_owner.m_isBattleCutsceneFade = value;
				}
			}

			// Token: 0x1700253C RID: 9532
			// (get) Token: 0x0600B942 RID: 47426 RVA: 0x003460E8 File Offset: 0x003442E8
			// (set) Token: 0x0600B943 RID: 47427 RVA: 0x003460F8 File Offset: 0x003442F8
			public bool m_isCombatCutsceneFade
			{
				get
				{
					return this.m_owner.m_isCombatCutsceneFade;
				}
				set
				{
					this.m_owner.m_isCombatCutsceneFade = value;
				}
			}

			// Token: 0x1700253D RID: 9533
			// (get) Token: 0x0600B944 RID: 47428 RVA: 0x00346108 File Offset: 0x00344308
			// (set) Token: 0x0600B945 RID: 47429 RVA: 0x00346118 File Offset: 0x00344318
			public DateTime m_battleMapClickTime
			{
				get
				{
					return this.m_owner.m_battleMapClickTime;
				}
				set
				{
					this.m_owner.m_battleMapClickTime = value;
				}
			}

			// Token: 0x1700253E RID: 9534
			// (get) Token: 0x0600B946 RID: 47430 RVA: 0x00346128 File Offset: 0x00344328
			// (set) Token: 0x0600B947 RID: 47431 RVA: 0x00346138 File Offset: 0x00344338
			public int m_showDangerRegionTeam
			{
				get
				{
					return this.m_owner.m_showDangerRegionTeam;
				}
				set
				{
					this.m_owner.m_showDangerRegionTeam = value;
				}
			}

			// Token: 0x1700253F RID: 9535
			// (get) Token: 0x0600B948 RID: 47432 RVA: 0x00346148 File Offset: 0x00344348
			// (set) Token: 0x0600B949 RID: 47433 RVA: 0x00346158 File Offset: 0x00344358
			public List<int> m_showDangerRegionActorIds
			{
				get
				{
					return this.m_owner.m_showDangerRegionActorIds;
				}
				set
				{
					this.m_owner.m_showDangerRegionActorIds = value;
				}
			}

			// Token: 0x17002540 RID: 9536
			// (get) Token: 0x0600B94A RID: 47434 RVA: 0x00346168 File Offset: 0x00344368
			// (set) Token: 0x0600B94B RID: 47435 RVA: 0x00346178 File Offset: 0x00344378
			public BattleActor m_preCombatTargetActor
			{
				get
				{
					return this.m_owner.m_preCombatTargetActor;
				}
				set
				{
					this.m_owner.m_preCombatTargetActor = value;
				}
			}

			// Token: 0x17002541 RID: 9537
			// (get) Token: 0x0600B94C RID: 47436 RVA: 0x00346188 File Offset: 0x00344388
			// (set) Token: 0x0600B94D RID: 47437 RVA: 0x00346198 File Offset: 0x00344398
			public bool m_saveShowTopUI
			{
				get
				{
					return this.m_owner.m_saveShowTopUI;
				}
				set
				{
					this.m_owner.m_saveShowTopUI = value;
				}
			}

			// Token: 0x17002542 RID: 9538
			// (get) Token: 0x0600B94E RID: 47438 RVA: 0x003461A8 File Offset: 0x003443A8
			// (set) Token: 0x0600B94F RID: 47439 RVA: 0x003461B8 File Offset: 0x003443B8
			public bool m_saveShowBottomUI
			{
				get
				{
					return this.m_owner.m_saveShowBottomUI;
				}
				set
				{
					this.m_owner.m_saveShowBottomUI = value;
				}
			}

			// Token: 0x17002543 RID: 9539
			// (get) Token: 0x0600B950 RID: 47440 RVA: 0x003461C8 File Offset: 0x003443C8
			// (set) Token: 0x0600B951 RID: 47441 RVA: 0x003461D8 File Offset: 0x003443D8
			public bool m_disableSaveProcessingBattle
			{
				get
				{
					return this.m_owner.m_disableSaveProcessingBattle;
				}
				set
				{
					this.m_owner.m_disableSaveProcessingBattle = value;
				}
			}

			// Token: 0x17002544 RID: 9540
			// (get) Token: 0x0600B952 RID: 47442 RVA: 0x003461E8 File Offset: 0x003443E8
			// (set) Token: 0x0600B953 RID: 47443 RVA: 0x003461F8 File Offset: 0x003443F8
			public BattleTeamSetup m_battleTeamSetup0
			{
				get
				{
					return this.m_owner.m_battleTeamSetup0;
				}
				set
				{
					this.m_owner.m_battleTeamSetup0 = value;
				}
			}

			// Token: 0x17002545 RID: 9541
			// (get) Token: 0x0600B954 RID: 47444 RVA: 0x00346208 File Offset: 0x00344408
			// (set) Token: 0x0600B955 RID: 47445 RVA: 0x00346218 File Offset: 0x00344418
			public BattleTeamSetup m_battleTeamSetup1
			{
				get
				{
					return this.m_owner.m_battleTeamSetup1;
				}
				set
				{
					this.m_owner.m_battleTeamSetup1 = value;
				}
			}

			// Token: 0x17002546 RID: 9542
			// (get) Token: 0x0600B956 RID: 47446 RVA: 0x00346228 File Offset: 0x00344428
			// (set) Token: 0x0600B957 RID: 47447 RVA: 0x00346238 File Offset: 0x00344438
			public List<GridPosition> m_teamPositions0
			{
				get
				{
					return this.m_owner.m_teamPositions0;
				}
				set
				{
					this.m_owner.m_teamPositions0 = value;
				}
			}

			// Token: 0x17002547 RID: 9543
			// (get) Token: 0x0600B958 RID: 47448 RVA: 0x00346248 File Offset: 0x00344448
			// (set) Token: 0x0600B959 RID: 47449 RVA: 0x00346258 File Offset: 0x00344458
			public List<GridPosition> m_teamPositions1
			{
				get
				{
					return this.m_owner.m_teamPositions1;
				}
				set
				{
					this.m_owner.m_teamPositions1 = value;
				}
			}

			// Token: 0x17002548 RID: 9544
			// (get) Token: 0x0600B95A RID: 47450 RVA: 0x00346268 File Offset: 0x00344468
			// (set) Token: 0x0600B95B RID: 47451 RVA: 0x00346278 File Offset: 0x00344478
			public List<GridPosition> m_teamNpcPositions0
			{
				get
				{
					return this.m_owner.m_teamNpcPositions0;
				}
				set
				{
					this.m_owner.m_teamNpcPositions0 = value;
				}
			}

			// Token: 0x17002549 RID: 9545
			// (get) Token: 0x0600B95C RID: 47452 RVA: 0x00346288 File Offset: 0x00344488
			// (set) Token: 0x0600B95D RID: 47453 RVA: 0x00346298 File Offset: 0x00344498
			public List<BattleHero> m_playerBattleHeros
			{
				get
				{
					return this.m_owner.m_playerBattleHeros;
				}
				set
				{
					this.m_owner.m_playerBattleHeros = value;
				}
			}

			// Token: 0x1700254A RID: 9546
			// (get) Token: 0x0600B95E RID: 47454 RVA: 0x003462A8 File Offset: 0x003444A8
			// (set) Token: 0x0600B95F RID: 47455 RVA: 0x003462B8 File Offset: 0x003444B8
			public List<int> m_tempIntList
			{
				get
				{
					return this.m_owner.m_tempIntList;
				}
				set
				{
					this.m_owner.m_tempIntList = value;
				}
			}

			// Token: 0x1700254B RID: 9547
			// (get) Token: 0x0600B960 RID: 47456 RVA: 0x003462C8 File Offset: 0x003444C8
			// (set) Token: 0x0600B961 RID: 47457 RVA: 0x003462D8 File Offset: 0x003444D8
			public List<string> m_tempStringList
			{
				get
				{
					return this.m_owner.m_tempStringList;
				}
				set
				{
					this.m_owner.m_tempStringList = value;
				}
			}

			// Token: 0x1700254C RID: 9548
			// (get) Token: 0x0600B962 RID: 47458 RVA: 0x003462E8 File Offset: 0x003444E8
			// (set) Token: 0x0600B963 RID: 47459 RVA: 0x003462F8 File Offset: 0x003444F8
			public HashSet<GridPosition> m_dangerRegion
			{
				get
				{
					return this.m_owner.m_dangerRegion;
				}
				set
				{
					this.m_owner.m_dangerRegion = value;
				}
			}

			// Token: 0x1700254D RID: 9549
			// (get) Token: 0x0600B964 RID: 47460 RVA: 0x00346308 File Offset: 0x00344508
			// (set) Token: 0x0600B965 RID: 47461 RVA: 0x00346318 File Offset: 0x00344518
			public List<TrainingTech> m_trainingTechs
			{
				get
				{
					return this.m_owner.m_trainingTechs;
				}
				set
				{
					this.m_owner.m_trainingTechs = value;
				}
			}

			// Token: 0x1700254E RID: 9550
			// (get) Token: 0x0600B966 RID: 47462 RVA: 0x00346328 File Offset: 0x00344528
			// (set) Token: 0x0600B967 RID: 47463 RVA: 0x00346338 File Offset: 0x00344538
			public List<int> m_userGuideEnforceHeroIds
			{
				get
				{
					return this.m_owner.m_userGuideEnforceHeroIds;
				}
				set
				{
					this.m_owner.m_userGuideEnforceHeroIds = value;
				}
			}

			// Token: 0x1700254F RID: 9551
			// (get) Token: 0x0600B968 RID: 47464 RVA: 0x00346348 File Offset: 0x00344548
			// (set) Token: 0x0600B969 RID: 47465 RVA: 0x00346358 File Offset: 0x00344558
			public List<int> m_arenaAttackerHeroIds
			{
				get
				{
					return this.m_owner.m_arenaAttackerHeroIds;
				}
				set
				{
					this.m_owner.m_arenaAttackerHeroIds = value;
				}
			}

			// Token: 0x17002550 RID: 9552
			// (get) Token: 0x0600B96A RID: 47466 RVA: 0x00346368 File Offset: 0x00344568
			// (set) Token: 0x0600B96B RID: 47467 RVA: 0x00346378 File Offset: 0x00344578
			public List<int> m_myBattleHeroIds
			{
				get
				{
					return this.m_owner.m_myBattleHeroIds;
				}
				set
				{
					this.m_owner.m_myBattleHeroIds = value;
				}
			}

			// Token: 0x17002551 RID: 9553
			// (get) Token: 0x0600B96C RID: 47468 RVA: 0x00346388 File Offset: 0x00344588
			// (set) Token: 0x0600B96D RID: 47469 RVA: 0x00346398 File Offset: 0x00344598
			public BattleLoadState m_loadState
			{
				get
				{
					return this.m_owner.m_loadState;
				}
				set
				{
					this.m_owner.m_loadState = value;
				}
			}

			// Token: 0x17002552 RID: 9554
			// (get) Token: 0x0600B96E RID: 47470 RVA: 0x003463A8 File Offset: 0x003445A8
			// (set) Token: 0x0600B96F RID: 47471 RVA: 0x003463B8 File Offset: 0x003445B8
			public BattlePerformState m_battlePerformState
			{
				get
				{
					return this.m_owner.m_battlePerformState;
				}
				set
				{
					this.m_owner.m_battlePerformState = value;
				}
			}

			// Token: 0x17002553 RID: 9555
			// (get) Token: 0x0600B970 RID: 47472 RVA: 0x003463C8 File Offset: 0x003445C8
			// (set) Token: 0x0600B971 RID: 47473 RVA: 0x003463D8 File Offset: 0x003445D8
			public bool m_isStartBattleAutoBattle
			{
				get
				{
					return this.m_owner.m_isStartBattleAutoBattle;
				}
				set
				{
					this.m_owner.m_isStartBattleAutoBattle = value;
				}
			}

			// Token: 0x17002554 RID: 9556
			// (get) Token: 0x0600B972 RID: 47474 RVA: 0x003463E8 File Offset: 0x003445E8
			// (set) Token: 0x0600B973 RID: 47475 RVA: 0x003463F8 File Offset: 0x003445F8
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

			// Token: 0x17002555 RID: 9557
			// (get) Token: 0x0600B974 RID: 47476 RVA: 0x00346408 File Offset: 0x00344608
			// (set) Token: 0x0600B975 RID: 47477 RVA: 0x00346418 File Offset: 0x00344618
			public DateTime m_myActionTimeout
			{
				get
				{
					return this.m_owner.m_myActionTimeout;
				}
				set
				{
					this.m_owner.m_myActionTimeout = value;
				}
			}

			// Token: 0x17002556 RID: 9558
			// (get) Token: 0x0600B976 RID: 47478 RVA: 0x00346428 File Offset: 0x00344628
			// (set) Token: 0x0600B977 RID: 47479 RVA: 0x00346438 File Offset: 0x00344638
			public DateTime m_otherActionTimeout
			{
				get
				{
					return this.m_owner.m_otherActionTimeout;
				}
				set
				{
					this.m_owner.m_otherActionTimeout = value;
				}
			}

			// Token: 0x17002557 RID: 9559
			// (get) Token: 0x0600B978 RID: 47480 RVA: 0x00346448 File Offset: 0x00344648
			// (set) Token: 0x0600B979 RID: 47481 RVA: 0x00346458 File Offset: 0x00344658
			public bool m_isMyActionTimeoutActive
			{
				get
				{
					return this.m_owner.m_isMyActionTimeoutActive;
				}
				set
				{
					this.m_owner.m_isMyActionTimeoutActive = value;
				}
			}

			// Token: 0x17002558 RID: 9560
			// (get) Token: 0x0600B97A RID: 47482 RVA: 0x00346468 File Offset: 0x00344668
			// (set) Token: 0x0600B97B RID: 47483 RVA: 0x00346478 File Offset: 0x00344678
			public bool m_isActionTimeoutAutoBattle
			{
				get
				{
					return this.m_owner.m_isActionTimeoutAutoBattle;
				}
				set
				{
					this.m_owner.m_isActionTimeoutAutoBattle = value;
				}
			}

			// Token: 0x17002559 RID: 9561
			// (get) Token: 0x0600B97C RID: 47484 RVA: 0x00346488 File Offset: 0x00344688
			// (set) Token: 0x0600B97D RID: 47485 RVA: 0x00346498 File Offset: 0x00344698
			public bool m_isAutoBattleOnce
			{
				get
				{
					return this.m_owner.m_isAutoBattleOnce;
				}
				set
				{
					this.m_owner.m_isAutoBattleOnce = value;
				}
			}

			// Token: 0x1700255A RID: 9562
			// (get) Token: 0x0600B97E RID: 47486 RVA: 0x003464A8 File Offset: 0x003446A8
			// (set) Token: 0x0600B97F RID: 47487 RVA: 0x003464B8 File Offset: 0x003446B8
			public List<int> m_pendingHeroSetupNtfs
			{
				get
				{
					return this.m_owner.m_pendingHeroSetupNtfs;
				}
				set
				{
					this.m_owner.m_pendingHeroSetupNtfs = value;
				}
			}

			// Token: 0x1700255B RID: 9563
			// (get) Token: 0x0600B980 RID: 47488 RVA: 0x003464C8 File Offset: 0x003446C8
			// (set) Token: 0x0600B981 RID: 47489 RVA: 0x003464D8 File Offset: 0x003446D8
			public GridPosition m_selectProtectHeroPos
			{
				get
				{
					return this.m_owner.m_selectProtectHeroPos;
				}
				set
				{
					this.m_owner.m_selectProtectHeroPos = value;
				}
			}

			// Token: 0x1700255C RID: 9564
			// (get) Token: 0x0600B982 RID: 47490 RVA: 0x003464E8 File Offset: 0x003446E8
			// (set) Token: 0x0600B983 RID: 47491 RVA: 0x003464F8 File Offset: 0x003446F8
			public GridPosition m_selectBanHeroPos
			{
				get
				{
					return this.m_owner.m_selectBanHeroPos;
				}
				set
				{
					this.m_owner.m_selectBanHeroPos = value;
				}
			}

			// Token: 0x1700255D RID: 9565
			// (get) Token: 0x0600B984 RID: 47492 RVA: 0x00346508 File Offset: 0x00344708
			// (set) Token: 0x0600B985 RID: 47493 RVA: 0x00346518 File Offset: 0x00344718
			public List<object> m_collectAssetObjects
			{
				get
				{
					return this.m_owner.m_collectAssetObjects;
				}
				set
				{
					this.m_owner.m_collectAssetObjects = value;
				}
			}

			// Token: 0x1700255E RID: 9566
			// (get) Token: 0x0600B986 RID: 47494 RVA: 0x00346528 File Offset: 0x00344728
			// (set) Token: 0x0600B987 RID: 47495 RVA: 0x00346538 File Offset: 0x00344738
			public RandomNumber m_armyRandomNumber
			{
				get
				{
					return this.m_owner.m_armyRandomNumber;
				}
				set
				{
					this.m_owner.m_armyRandomNumber = value;
				}
			}

			// Token: 0x1700255F RID: 9567
			// (get) Token: 0x0600B988 RID: 47496 RVA: 0x00346548 File Offset: 0x00344748
			// (set) Token: 0x0600B989 RID: 47497 RVA: 0x00346558 File Offset: 0x00344758
			public ProBattleReport m_battleReport
			{
				get
				{
					return this.m_owner.m_battleReport;
				}
				set
				{
					this.m_owner.m_battleReport = value;
				}
			}

			// Token: 0x17002560 RID: 9568
			// (get) Token: 0x0600B98A RID: 47498 RVA: 0x00346568 File Offset: 0x00344768
			// (set) Token: 0x0600B98B RID: 47499 RVA: 0x00346578 File Offset: 0x00344778
			public int m_battleStopTurn
			{
				get
				{
					return this.m_owner.m_battleStopTurn;
				}
				set
				{
					this.m_owner.m_battleStopTurn = value;
				}
			}

			// Token: 0x17002561 RID: 9569
			// (get) Token: 0x0600B98C RID: 47500 RVA: 0x00346588 File Offset: 0x00344788
			// (set) Token: 0x0600B98D RID: 47501 RVA: 0x00346598 File Offset: 0x00344798
			public bool m_isSendBattleCheatGMCommand
			{
				get
				{
					return this.m_owner.m_isSendBattleCheatGMCommand;
				}
				set
				{
					this.m_owner.m_isSendBattleCheatGMCommand = value;
				}
			}

			// Token: 0x17002562 RID: 9570
			// (get) Token: 0x0600B98E RID: 47502 RVA: 0x003465A8 File Offset: 0x003447A8
			// (set) Token: 0x0600B98F RID: 47503 RVA: 0x003465B8 File Offset: 0x003447B8
			public bool m_isStartInBattleRoom
			{
				get
				{
					return this.m_owner.m_isStartInBattleRoom;
				}
				set
				{
					this.m_owner.m_isStartInBattleRoom = value;
				}
			}

			// Token: 0x17002563 RID: 9571
			// (get) Token: 0x0600B990 RID: 47504 RVA: 0x003465C8 File Offset: 0x003447C8
			// (set) Token: 0x0600B991 RID: 47505 RVA: 0x003465D8 File Offset: 0x003447D8
			public List<BattleUITask.RegretStep> m_regretSteps
			{
				get
				{
					return this.m_owner.m_regretSteps;
				}
				set
				{
					this.m_owner.m_regretSteps = value;
				}
			}

			// Token: 0x17002564 RID: 9572
			// (get) Token: 0x0600B992 RID: 47506 RVA: 0x003465E8 File Offset: 0x003447E8
			// (set) Token: 0x0600B993 RID: 47507 RVA: 0x003465F8 File Offset: 0x003447F8
			public List<BattleCommand> m_regretBattleCommands
			{
				get
				{
					return this.m_owner.m_regretBattleCommands;
				}
				set
				{
					this.m_owner.m_regretBattleCommands = value;
				}
			}

			// Token: 0x17002565 RID: 9573
			// (get) Token: 0x0600B994 RID: 47508 RVA: 0x00346608 File Offset: 0x00344808
			// (set) Token: 0x0600B995 RID: 47509 RVA: 0x00346618 File Offset: 0x00344818
			public int m_regretFinalStep
			{
				get
				{
					return this.m_owner.m_regretFinalStep;
				}
				set
				{
					this.m_owner.m_regretFinalStep = value;
				}
			}

			// Token: 0x17002566 RID: 9574
			// (get) Token: 0x0600B996 RID: 47510 RVA: 0x00346628 File Offset: 0x00344828
			// (set) Token: 0x0600B997 RID: 47511 RVA: 0x00346638 File Offset: 0x00344838
			public int m_regretCurrentStep
			{
				get
				{
					return this.m_owner.m_regretCurrentStep;
				}
				set
				{
					this.m_owner.m_regretCurrentStep = value;
				}
			}

			// Token: 0x17002567 RID: 9575
			// (get) Token: 0x0600B998 RID: 47512 RVA: 0x00346648 File Offset: 0x00344848
			// (set) Token: 0x0600B999 RID: 47513 RVA: 0x00346658 File Offset: 0x00344858
			public int m_regretCameraFocusActorId
			{
				get
				{
					return this.m_owner.m_regretCameraFocusActorId;
				}
				set
				{
					this.m_owner.m_regretCameraFocusActorId = value;
				}
			}

			// Token: 0x17002568 RID: 9576
			// (get) Token: 0x0600B99A RID: 47514 RVA: 0x00346668 File Offset: 0x00344868
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002569 RID: 9577
			// (get) Token: 0x0600B99B RID: 47515 RVA: 0x00346678 File Offset: 0x00344878
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600B99C RID: 47516 RVA: 0x00346688 File Offset: 0x00344888
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600B99D RID: 47517 RVA: 0x00346698 File Offset: 0x00344898
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600B99E RID: 47518 RVA: 0x003466A8 File Offset: 0x003448A8
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600B99F RID: 47519 RVA: 0x003466B8 File Offset: 0x003448B8
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600B9A0 RID: 47520 RVA: 0x003466C8 File Offset: 0x003448C8
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600B9A1 RID: 47521 RVA: 0x003466D8 File Offset: 0x003448D8
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600B9A2 RID: 47522 RVA: 0x003466E8 File Offset: 0x003448E8
			public void HideAllView()
			{
				this.m_owner.HideAllView();
			}

			// Token: 0x0600B9A3 RID: 47523 RVA: 0x003466F8 File Offset: 0x003448F8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600B9A4 RID: 47524 RVA: 0x00346708 File Offset: 0x00344908
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x0600B9A5 RID: 47525 RVA: 0x00346718 File Offset: 0x00344918
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600B9A6 RID: 47526 RVA: 0x00346728 File Offset: 0x00344928
			public static void StopSubUITask(Type taskType)
			{
				BattleUITask.StopSubUITask(taskType);
			}

			// Token: 0x0600B9A7 RID: 47527 RVA: 0x00346730 File Offset: 0x00344930
			public bool IsLoading()
			{
				return this.m_owner.IsLoading();
			}

			// Token: 0x0600B9A8 RID: 47528 RVA: 0x00346740 File Offset: 0x00344940
			public void CreateClientBattle()
			{
				this.m_owner.CreateClientBattle();
			}

			// Token: 0x0600B9A9 RID: 47529 RVA: 0x00346750 File Offset: 0x00344950
			public void DestroyClientBattle()
			{
				this.m_owner.DestroyClientBattle();
			}

			// Token: 0x0600B9AA RID: 47530 RVA: 0x00346760 File Offset: 0x00344960
			public void PrepareClientBattle(bool prepareBattleUI)
			{
				this.m_owner.PrepareClientBattle(prepareBattleUI);
			}

			// Token: 0x0600B9AB RID: 47531 RVA: 0x00346770 File Offset: 0x00344970
			public void StartClientBattle()
			{
				this.m_owner.StartClientBattle();
			}

			// Token: 0x0600B9AC RID: 47532 RVA: 0x00346780 File Offset: 0x00344980
			public void StopBattle(bool win, bool skipPerform)
			{
				this.m_owner.StopBattle(win, skipPerform);
			}

			// Token: 0x0600B9AD RID: 47533 RVA: 0x00346790 File Offset: 0x00344990
			public void SendBattleRoomInitLog()
			{
				this.m_owner.SendBattleRoomInitLog();
			}

			// Token: 0x0600B9AE RID: 47534 RVA: 0x003467A0 File Offset: 0x003449A0
			public BattleTeamSetup GetBattleTeamSetup(int team)
			{
				return this.m_owner.GetBattleTeamSetup(team);
			}

			// Token: 0x0600B9AF RID: 47535 RVA: 0x003467B0 File Offset: 0x003449B0
			public List<GridPosition> GetTeamPositions(int team)
			{
				return this.m_owner.GetTeamPositions(team);
			}

			// Token: 0x0600B9B0 RID: 47536 RVA: 0x003467C0 File Offset: 0x003449C0
			public void SetCombatHp(int teamNumber)
			{
				this.m_owner.SetCombatHp(teamNumber);
			}

			// Token: 0x0600B9B1 RID: 47537 RVA: 0x003467D0 File Offset: 0x003449D0
			public void ExitBattleReturnToWorld()
			{
				this.m_owner.ExitBattleReturnToWorld();
			}

			// Token: 0x0600B9B2 RID: 47538 RVA: 0x003467E0 File Offset: 0x003449E0
			public static void UnloadAssetsAndStartWorldUITask()
			{
				BattleUITask.UnloadAssetsAndStartWorldUITask();
			}

			// Token: 0x0600B9B3 RID: 47539 RVA: 0x003467E8 File Offset: 0x003449E8
			public static IEnumerator Co_UnloadAssetsAndStartWorldUITask()
			{
				return BattleUITask.Co_UnloadAssetsAndStartWorldUITask();
			}

			// Token: 0x0600B9B4 RID: 47540 RVA: 0x003467F0 File Offset: 0x003449F0
			public static void WorldUITask_OnLoadAllResCompleted()
			{
				BattleUITask.WorldUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600B9B5 RID: 47541 RVA: 0x003467F8 File Offset: 0x003449F8
			public void ShowErrorMessageAndExitBattle(int errorCode)
			{
				this.m_owner.ShowErrorMessageAndExitBattle(errorCode);
			}

			// Token: 0x0600B9B6 RID: 47542 RVA: 0x00346808 File Offset: 0x00344A08
			public void ShowErrorMessageAndExitBattle(StringTableId strId)
			{
				this.m_owner.ShowErrorMessageAndExitBattle(strId);
			}

			// Token: 0x0600B9B7 RID: 47543 RVA: 0x00346818 File Offset: 0x00344A18
			public void SaveProcessingBattle()
			{
				this.m_owner.SaveProcessingBattle();
			}

			// Token: 0x0600B9B8 RID: 47544 RVA: 0x00346828 File Offset: 0x00344A28
			public void BattlePrepareBeforeShowResult()
			{
				this.m_owner.BattlePrepareBeforeShowResult();
			}

			// Token: 0x0600B9B9 RID: 47545 RVA: 0x00346838 File Offset: 0x00344A38
			public bool IsMeArenaBattleTeam1()
			{
				return this.m_owner.IsMeArenaBattleTeam1();
			}

			// Token: 0x0600B9BA RID: 47546 RVA: 0x00346848 File Offset: 0x00344A48
			public bool CanUseChat()
			{
				return this.m_owner.CanUseChat();
			}

			// Token: 0x0600B9BB RID: 47547 RVA: 0x00346858 File Offset: 0x00344A58
			public bool CanUseDanmaku()
			{
				return this.m_owner.CanUseDanmaku();
			}

			// Token: 0x0600B9BC RID: 47548 RVA: 0x00346868 File Offset: 0x00344A68
			public void BattlePauseUIController_OnClose()
			{
				this.m_owner.BattlePauseUIController_OnClose();
			}

			// Token: 0x0600B9BD RID: 47549 RVA: 0x00346878 File Offset: 0x00344A78
			public void BattlePauseUIController_OnShowPlayerSetting()
			{
				this.m_owner.BattlePauseUIController_OnShowPlayerSetting();
			}

			// Token: 0x0600B9BE RID: 47550 RVA: 0x00346888 File Offset: 0x00344A88
			public void BattlePauseUIController_OnExit()
			{
				this.m_owner.BattlePauseUIController_OnExit();
			}

			// Token: 0x0600B9BF RID: 47551 RVA: 0x00346898 File Offset: 0x00344A98
			public void ExitBattleDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.ExitBattleDialogBoxCallback(r);
			}

			// Token: 0x0600B9C0 RID: 47552 RVA: 0x003468A8 File Offset: 0x00344AA8
			public void TestUI_ExitBattle()
			{
				this.m_owner.TestUI_ExitBattle();
			}

			// Token: 0x0600B9C1 RID: 47553 RVA: 0x003468B8 File Offset: 0x00344AB8
			public void TestUI_RestartBattle()
			{
				this.m_owner.TestUI_RestartBattle();
			}

			// Token: 0x0600B9C2 RID: 47554 RVA: 0x003468C8 File Offset: 0x00344AC8
			public void TestUI_ReplayBattle()
			{
				this.m_owner.TestUI_ReplayBattle();
			}

			// Token: 0x0600B9C3 RID: 47555 RVA: 0x003468D8 File Offset: 0x00344AD8
			public void TestUI_StopBattle(bool win)
			{
				this.m_owner.TestUI_StopBattle(win);
			}

			// Token: 0x0600B9C4 RID: 47556 RVA: 0x003468E8 File Offset: 0x00344AE8
			public void PlayerContext_OnChatMessageNtf(ChatMessage msg)
			{
				this.m_owner.PlayerContext_OnChatMessageNtf(msg);
			}

			// Token: 0x0600B9C5 RID: 47557 RVA: 0x003468F8 File Offset: 0x00344AF8
			public void PlayerContext_OnTeamRoomInviteNtf(TeamRoomInviteInfo inviteInfo)
			{
				this.m_owner.PlayerContext_OnTeamRoomInviteNtf(inviteInfo);
			}

			// Token: 0x0600B9C6 RID: 47558 RVA: 0x00346908 File Offset: 0x00344B08
			public void PlayerContext_OnBattlePracticeInvitedNtf(PVPInviteInfo inviteInfo)
			{
				this.m_owner.PlayerContext_OnBattlePracticeInvitedNtf(inviteInfo);
			}

			// Token: 0x0600B9C7 RID: 47559 RVA: 0x00346918 File Offset: 0x00344B18
			public void CollectBattlePrepareAssets()
			{
				this.m_owner.CollectBattlePrepareAssets();
			}

			// Token: 0x0600B9C8 RID: 47560 RVA: 0x00346928 File Offset: 0x00344B28
			public void CollectBattleAssets()
			{
				this.m_owner.CollectBattleAssets();
			}

			// Token: 0x0600B9C9 RID: 47561 RVA: 0x00346938 File Offset: 0x00344B38
			public void CollectBattlePrepareHeros(List<BattleHero> heros0, List<BattleHero> heros1)
			{
				this.m_owner.CollectBattlePrepareHeros(heros0, heros1);
			}

			// Token: 0x0600B9CA RID: 47562 RVA: 0x00346948 File Offset: 0x00344B48
			public void CollectBattlefieldAssets(ConfigDataBattlefieldInfo battlefieldInfo)
			{
				this.m_owner.CollectBattlefieldAssets(battlefieldInfo);
			}

			// Token: 0x0600B9CB RID: 47563 RVA: 0x00346958 File Offset: 0x00344B58
			public void CollectTerrainAssets(ConfigDataTerrainInfo terrainInfo)
			{
				this.m_owner.CollectTerrainAssets(terrainInfo);
			}

			// Token: 0x0600B9CC RID: 47564 RVA: 0x00346968 File Offset: 0x00344B68
			public void CollectCharImageAssets(ConfigDataCharImageInfo charImageInfo, ConfigDataCharImageSkinResourceInfo skinResInfo)
			{
				this.m_owner.CollectCharImageAssets(charImageInfo, skinResInfo);
			}

			// Token: 0x0600B9CD RID: 47565 RVA: 0x00346978 File Offset: 0x00344B78
			public void CollectHeadImageAssets(ConfigDataCharImageInfo charImageInfo)
			{
				this.m_owner.CollectHeadImageAssets(charImageInfo);
			}

			// Token: 0x0600B9CE RID: 47566 RVA: 0x00346988 File Offset: 0x00344B88
			public void CollectHeroAssets(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo heroSkinResInfo, int heroStar)
			{
				this.m_owner.CollectHeroAssets(jobConnectionInfo, heroSkinResInfo, heroStar);
			}

			// Token: 0x0600B9CF RID: 47567 RVA: 0x00346998 File Offset: 0x00344B98
			public void CollectSoldierAssets(ConfigDataSoldierInfo soldierInfo, ConfigDataModelSkinResourceInfo soldierSkinResInfo)
			{
				this.m_owner.CollectSoldierAssets(soldierInfo, soldierSkinResInfo);
			}

			// Token: 0x0600B9D0 RID: 47568 RVA: 0x003469A8 File Offset: 0x00344BA8
			public void CollectSkinAssets(ConfigDataModelSkinResourceInfo skinResInfo)
			{
				this.m_owner.CollectSkinAssets(skinResInfo);
			}

			// Token: 0x0600B9D1 RID: 47569 RVA: 0x003469B8 File Offset: 0x00344BB8
			public void CollectSkillAssets(ConfigDataSkillInfo skillInfo)
			{
				this.m_owner.CollectSkillAssets(skillInfo);
			}

			// Token: 0x0600B9D2 RID: 47570 RVA: 0x003469C8 File Offset: 0x00344BC8
			public void CollectBuffAssets(ConfigDataBuffInfo buffInfo)
			{
				this.m_owner.CollectBuffAssets(buffInfo);
			}

			// Token: 0x0600B9D3 RID: 47571 RVA: 0x003469D8 File Offset: 0x00344BD8
			public void CollectDefaultHeroAssets(ConfigDataHeroInfo heroInfo)
			{
				this.m_owner.CollectDefaultHeroAssets(heroInfo);
			}

			// Token: 0x0600B9D4 RID: 47572 RVA: 0x003469E8 File Offset: 0x00344BE8
			public void CollectBattleEventAssets(ConfigDataBattleEventTriggerInfo eventTriggerInfo)
			{
				this.m_owner.CollectBattleEventAssets(eventTriggerInfo);
			}

			// Token: 0x0600B9D5 RID: 47573 RVA: 0x003469F8 File Offset: 0x00344BF8
			public void CollectBattleEventActionAssets(ConfigDataBattleEventActionInfo eventActionInfo)
			{
				this.m_owner.CollectBattleEventActionAssets(eventActionInfo);
			}

			// Token: 0x0600B9D6 RID: 47574 RVA: 0x00346A08 File Offset: 0x00344C08
			public void CollectBattlePerformAssets(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.CollectBattlePerformAssets(performInfo);
			}

			// Token: 0x0600B9D7 RID: 47575 RVA: 0x00346A18 File Offset: 0x00344C18
			public void _CollectBattlePerformAssets(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner._CollectBattlePerformAssets(performInfo);
			}

			// Token: 0x0600B9D8 RID: 47576 RVA: 0x00346A28 File Offset: 0x00344C28
			public void CollectTrainingTechAssets(List<TrainingTech> techs)
			{
				this.m_owner.CollectTrainingTechAssets(techs);
			}

			// Token: 0x0600B9D9 RID: 47577 RVA: 0x00346A38 File Offset: 0x00344C38
			public bool IsAlreadyCollectAsset(object obj)
			{
				return this.m_owner.IsAlreadyCollectAsset(obj);
			}

			// Token: 0x0600B9DA RID: 47578 RVA: 0x00346A48 File Offset: 0x00344C48
			public void ClearAlreadyCollectAssets()
			{
				this.m_owner.ClearAlreadyCollectAssets();
			}

			// Token: 0x0600B9DB RID: 47579 RVA: 0x00346A58 File Offset: 0x00344C58
			public void StartBattleUI()
			{
				this.m_owner.StartBattleUI();
			}

			// Token: 0x0600B9DC RID: 47580 RVA: 0x00346A68 File Offset: 0x00344C68
			public void ClientActorTryMoveTo(ClientBattleActor ca, GridPosition p, int finalDir)
			{
				this.m_owner.ClientActorTryMoveTo(ca, p, finalDir);
			}

			// Token: 0x0600B9DD RID: 47581 RVA: 0x00346A78 File Offset: 0x00344C78
			public void AddCommandIfMoved(ClientBattleActor ca)
			{
				this.m_owner.AddCommandIfMoved(ca);
			}

			// Token: 0x0600B9DE RID: 47582 RVA: 0x00346A88 File Offset: 0x00344C88
			public GridPosition FindAttackPosition(int attackDistance, GridPosition targetPos)
			{
				return this.m_owner.FindAttackPosition(attackDistance, targetPos);
			}

			// Token: 0x0600B9DF RID: 47583 RVA: 0x00346A98 File Offset: 0x00344C98
			public bool CanAction()
			{
				return this.m_owner.CanAction();
			}

			// Token: 0x0600B9E0 RID: 47584 RVA: 0x00346AA8 File Offset: 0x00344CA8
			public BattleActor GetMapBattleActor(GridPosition p)
			{
				return this.m_owner.GetMapBattleActor(p);
			}

			// Token: 0x0600B9E1 RID: 47585 RVA: 0x00346AB8 File Offset: 0x00344CB8
			public void ResetActorEffect()
			{
				this.m_owner.ResetActorEffect();
			}

			// Token: 0x0600B9E2 RID: 47586 RVA: 0x00346AC8 File Offset: 0x00344CC8
			public bool CanUseSkillAtPosition(ClientBattleActor ca, ConfigDataSkillInfo skillInfo, GridPosition p)
			{
				return this.m_owner.CanUseSkillAtPosition(ca, skillInfo, p);
			}

			// Token: 0x0600B9E3 RID: 47587 RVA: 0x00346AD8 File Offset: 0x00344CD8
			public void FindMoveRegion()
			{
				this.m_owner.FindMoveRegion();
			}

			// Token: 0x0600B9E4 RID: 47588 RVA: 0x00346AE8 File Offset: 0x00344CE8
			public void ShowMoveAndAttackRegion(BattleActor actor, GridPosition startPos)
			{
				this.m_owner.ShowMoveAndAttackRegion(actor, startPos);
			}

			// Token: 0x0600B9E5 RID: 47589 RVA: 0x00346AF8 File Offset: 0x00344CF8
			public void ShowMoveAndAttackRegion()
			{
				this.m_owner.ShowMoveAndAttackRegion();
			}

			// Token: 0x0600B9E6 RID: 47590 RVA: 0x00346B08 File Offset: 0x00344D08
			public void ShowMoveRegion(BattleActor actor, GridPosition startPos)
			{
				this.m_owner.ShowMoveRegion(actor, startPos);
			}

			// Token: 0x0600B9E7 RID: 47591 RVA: 0x00346B18 File Offset: 0x00344D18
			public void ShowMoveRegion()
			{
				this.m_owner.ShowMoveRegion();
			}

			// Token: 0x0600B9E8 RID: 47592 RVA: 0x00346B28 File Offset: 0x00344D28
			public void UpdateDangerRegion()
			{
				this.m_owner.UpdateDangerRegion();
			}

			// Token: 0x0600B9E9 RID: 47593 RVA: 0x00346B38 File Offset: 0x00344D38
			public void ShowDangerTeamRegion(int team)
			{
				this.m_owner.ShowDangerTeamRegion(team);
			}

			// Token: 0x0600B9EA RID: 47594 RVA: 0x00346B48 File Offset: 0x00344D48
			public void ShowDangerRegion(List<int> actorIds)
			{
				this.m_owner.ShowDangerRegion(actorIds);
			}

			// Token: 0x0600B9EB RID: 47595 RVA: 0x00346B58 File Offset: 0x00344D58
			public void ShowMovePath(ClientBattleActor ca, GridPosition startPos)
			{
				this.m_owner.ShowMovePath(ca, startPos);
			}

			// Token: 0x0600B9EC RID: 47596 RVA: 0x00346B68 File Offset: 0x00344D68
			public MoveType GetSummonMoveType(int heroId)
			{
				return this.m_owner.GetSummonMoveType(heroId);
			}

			// Token: 0x0600B9ED RID: 47597 RVA: 0x00346B78 File Offset: 0x00344D78
			public void ShowSkillRegion(BattleActor actor, int skillIndex, GridPosition startPos)
			{
				this.m_owner.ShowSkillRegion(actor, skillIndex, startPos);
			}

			// Token: 0x0600B9EE RID: 47598 RVA: 0x00346B88 File Offset: 0x00344D88
			public void ShowSkillRegion()
			{
				this.m_owner.ShowSkillRegion();
			}

			// Token: 0x0600B9EF RID: 47599 RVA: 0x00346B98 File Offset: 0x00344D98
			public void ShowSkillRange(BattleActor actor, int skillIndex, GridPosition targetPos)
			{
				this.m_owner.ShowSkillRange(actor, skillIndex, targetPos);
			}

			// Token: 0x0600B9F0 RID: 47600 RVA: 0x00346BA8 File Offset: 0x00344DA8
			public void ShowSkillRange()
			{
				this.m_owner.ShowSkillRange();
			}

			// Token: 0x0600B9F1 RID: 47601 RVA: 0x00346BB8 File Offset: 0x00344DB8
			public void ShowTeleportRegion(BattleActor actor, int skillIndex, GridPosition targetPos)
			{
				this.m_owner.ShowTeleportRegion(actor, skillIndex, targetPos);
			}

			// Token: 0x0600B9F2 RID: 47602 RVA: 0x00346BC8 File Offset: 0x00344DC8
			public void ShowTeleportRegion()
			{
				this.m_owner.ShowTeleportRegion();
			}

			// Token: 0x0600B9F3 RID: 47603 RVA: 0x00346BD8 File Offset: 0x00344DD8
			public void ShowAttackTargets(BattleActor actor, GridPosition goalPos)
			{
				this.m_owner.ShowAttackTargets(actor, goalPos);
			}

			// Token: 0x0600B9F4 RID: 47604 RVA: 0x00346BE8 File Offset: 0x00344DE8
			public void ShowSkillTargets(ClientBattleActor ca, int skillIndex, GridPosition startPos)
			{
				this.m_owner.ShowSkillTargets(ca, skillIndex, startPos);
			}

			// Token: 0x0600B9F5 RID: 47605 RVA: 0x00346BF8 File Offset: 0x00344DF8
			public void ShowSkillTargets()
			{
				this.m_owner.ShowSkillTargets();
			}

			// Token: 0x0600B9F6 RID: 47606 RVA: 0x00346C08 File Offset: 0x00344E08
			public void ShowBattleTreasureDialog(ConfigDataBattleTreasureInfo treasureInfo)
			{
				this.m_owner.ShowBattleTreasureDialog(treasureInfo);
			}

			// Token: 0x0600B9F7 RID: 47607 RVA: 0x00346C18 File Offset: 0x00344E18
			public void ShowBattleTreasureReward(ConfigDataBattleTreasureInfo treasureInfo)
			{
				this.m_owner.ShowBattleTreasureReward(treasureInfo);
			}

			// Token: 0x0600B9F8 RID: 47608 RVA: 0x00346C28 File Offset: 0x00344E28
			public void ShowPreCombat(BattleActor a0, BattleActor a1, ConfigDataSkillInfo attackerSkillInfo)
			{
				this.m_owner.ShowPreCombat(a0, a1, attackerSkillInfo);
			}

			// Token: 0x0600B9F9 RID: 47609 RVA: 0x00346C38 File Offset: 0x00344E38
			public void ShowFastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
			{
				this.m_owner.ShowFastCombat(a0, a1);
			}

			// Token: 0x0600B9FA RID: 47610 RVA: 0x00346C48 File Offset: 0x00344E48
			public void ShowActorInfo(BattleActor a)
			{
				this.m_owner.ShowActorInfo(a);
			}

			// Token: 0x0600B9FB RID: 47611 RVA: 0x00346C58 File Offset: 0x00344E58
			public void HideActorInfo()
			{
				this.m_owner.HideActorInfo();
			}

			// Token: 0x0600B9FC RID: 47612 RVA: 0x00346C68 File Offset: 0x00344E68
			public void ShowSelectionMarkAndTerrain(GridPosition p)
			{
				this.m_owner.ShowSelectionMarkAndTerrain(p);
			}

			// Token: 0x0600B9FD RID: 47613 RVA: 0x00346C78 File Offset: 0x00344E78
			public void SetUIStateNone()
			{
				this.m_owner.SetUIStateNone();
			}

			// Token: 0x0600B9FE RID: 47614 RVA: 0x00346C88 File Offset: 0x00344E88
			public void SetUIStateSelectActionActor()
			{
				this.m_owner.SetUIStateSelectActionActor();
			}

			// Token: 0x0600B9FF RID: 47615 RVA: 0x00346C98 File Offset: 0x00344E98
			public void SetUIStateMove()
			{
				this.m_owner.SetUIStateMove();
			}

			// Token: 0x0600BA00 RID: 47616 RVA: 0x00346CA8 File Offset: 0x00344EA8
			public void ShowSkills()
			{
				this.m_owner.ShowSkills();
			}

			// Token: 0x0600BA01 RID: 47617 RVA: 0x00346CB8 File Offset: 0x00344EB8
			public void SetUIStateExtraMove()
			{
				this.m_owner.SetUIStateExtraMove();
			}

			// Token: 0x0600BA02 RID: 47618 RVA: 0x00346CC8 File Offset: 0x00344EC8
			public void SetUIStateSelectSkillTarget()
			{
				this.m_owner.SetUIStateSelectSkillTarget();
			}

			// Token: 0x0600BA03 RID: 47619 RVA: 0x00346CD8 File Offset: 0x00344ED8
			public void SetUIStateConfirmSkill()
			{
				this.m_owner.SetUIStateConfirmSkill();
			}

			// Token: 0x0600BA04 RID: 47620 RVA: 0x00346CE8 File Offset: 0x00344EE8
			public void SetUIStateSelectTeleportPosition1()
			{
				this.m_owner.SetUIStateSelectTeleportPosition1();
			}

			// Token: 0x0600BA05 RID: 47621 RVA: 0x00346CF8 File Offset: 0x00344EF8
			public void SetUIStateSelectTeleportPosition2()
			{
				this.m_owner.SetUIStateSelectTeleportPosition2();
			}

			// Token: 0x0600BA06 RID: 47622 RVA: 0x00346D08 File Offset: 0x00344F08
			public void SetUIStateWaitOtherPlayer()
			{
				this.m_owner.SetUIStateWaitOtherPlayer();
			}

			// Token: 0x0600BA07 RID: 47623 RVA: 0x00346D18 File Offset: 0x00344F18
			public void ShowCanActionActorsUI()
			{
				this.m_owner.ShowCanActionActorsUI();
			}

			// Token: 0x0600BA08 RID: 47624 RVA: 0x00346D28 File Offset: 0x00344F28
			public void HideCanActionActorsUI()
			{
				this.m_owner.HideCanActionActorsUI();
			}

			// Token: 0x0600BA09 RID: 47625 RVA: 0x00346D38 File Offset: 0x00344F38
			public void DoAutoBattle()
			{
				this.m_owner.DoAutoBattle();
			}

			// Token: 0x0600BA0A RID: 47626 RVA: 0x00346D48 File Offset: 0x00344F48
			public void SetAutoBattle(bool on)
			{
				this.m_owner.SetAutoBattle(on);
			}

			// Token: 0x0600BA0B RID: 47627 RVA: 0x00346D58 File Offset: 0x00344F58
			public void CameraFocusActor(int actorId)
			{
				this.m_owner.CameraFocusActor(actorId);
			}

			// Token: 0x0600BA0C RID: 47628 RVA: 0x00346D68 File Offset: 0x00344F68
			public void BattleUIController_OnAutoBattle(bool on)
			{
				this.m_owner.BattleUIController_OnAutoBattle(on);
			}

			// Token: 0x0600BA0D RID: 47629 RVA: 0x00346D78 File Offset: 0x00344F78
			public void BattleUIController_OnFastBattle(bool on)
			{
				this.m_owner.BattleUIController_OnFastBattle(on);
			}

			// Token: 0x0600BA0E RID: 47630 RVA: 0x00346D88 File Offset: 0x00344F88
			public void BattleUIController_OnSkipCombat(SkipCombatMode mode)
			{
				this.m_owner.BattleUIController_OnSkipCombat(mode);
			}

			// Token: 0x0600BA0F RID: 47631 RVA: 0x00346D98 File Offset: 0x00344F98
			public void BattleUIController_OnShowDanger(bool on)
			{
				this.m_owner.BattleUIController_OnShowDanger(on);
			}

			// Token: 0x0600BA10 RID: 47632 RVA: 0x00346DA8 File Offset: 0x00344FA8
			public void BattleUIController_OnEndAllAction()
			{
				this.m_owner.BattleUIController_OnEndAllAction();
			}

			// Token: 0x0600BA11 RID: 47633 RVA: 0x00346DB8 File Offset: 0x00344FB8
			public void EndAllActionDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.EndAllActionDialogBoxCallback(r);
			}

			// Token: 0x0600BA12 RID: 47634 RVA: 0x00346DC8 File Offset: 0x00344FC8
			public void BattleUIController_OnEndAction()
			{
				this.m_owner.BattleUIController_OnEndAction();
			}

			// Token: 0x0600BA13 RID: 47635 RVA: 0x00346DD8 File Offset: 0x00344FD8
			public void BattleUIController_OnShowActorInfo()
			{
				this.m_owner.BattleUIController_OnShowActorInfo();
			}

			// Token: 0x0600BA14 RID: 47636 RVA: 0x00346DE8 File Offset: 0x00344FE8
			public void BattleUIController_OnSelectSkill(int skillIndex)
			{
				this.m_owner.BattleUIController_OnSelectSkill(skillIndex);
			}

			// Token: 0x0600BA15 RID: 47637 RVA: 0x00346DF8 File Offset: 0x00344FF8
			public void BattleUIController_OnUseSkill()
			{
				this.m_owner.BattleUIController_OnUseSkill();
			}

			// Token: 0x0600BA16 RID: 47638 RVA: 0x00346E08 File Offset: 0x00345008
			public void BattleUIController_OnCancelSkill()
			{
				this.m_owner.BattleUIController_OnCancelSkill();
			}

			// Token: 0x0600BA17 RID: 47639 RVA: 0x00346E18 File Offset: 0x00345018
			public void BattleUIController_OnShowChat()
			{
				this.m_owner.BattleUIController_OnShowChat();
			}

			// Token: 0x0600BA18 RID: 47640 RVA: 0x00346E28 File Offset: 0x00345028
			public void BattleUIController_OnShowHelp()
			{
				this.m_owner.BattleUIController_OnShowHelp();
			}

			// Token: 0x0600BA19 RID: 47641 RVA: 0x00346E38 File Offset: 0x00345038
			public void BattleUIController_OnPauseBattle()
			{
				this.m_owner.BattleUIController_OnPauseBattle();
			}

			// Token: 0x0600BA1A RID: 47642 RVA: 0x00346E48 File Offset: 0x00345048
			public void BattleUIController_OnShowArmyRelation()
			{
				this.m_owner.BattleUIController_OnShowArmyRelation();
			}

			// Token: 0x0600BA1B RID: 47643 RVA: 0x00346E58 File Offset: 0x00345058
			public void BattleUIController_OnPointerDown(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.BattleUIController_OnPointerDown(button, position);
			}

			// Token: 0x0600BA1C RID: 47644 RVA: 0x00346E68 File Offset: 0x00345068
			public void BattleUIController_OnPointerUp(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.BattleUIController_OnPointerUp(button, position);
			}

			// Token: 0x0600BA1D RID: 47645 RVA: 0x00346E78 File Offset: 0x00345078
			public void BattleUIController_OnShowCurTurnDanmaku(int turn)
			{
				this.m_owner.BattleUIController_OnShowCurTurnDanmaku(turn);
			}

			// Token: 0x0600BA1E RID: 47646 RVA: 0x00346E88 File Offset: 0x00345088
			public void BattleUIController_OnCloseCurTurnDanmaku()
			{
				this.m_owner.BattleUIController_OnCloseCurTurnDanmaku();
			}

			// Token: 0x0600BA1F RID: 47647 RVA: 0x00346E98 File Offset: 0x00345098
			public void BattleUIController_OnShowOneDanmaku(DanmakuEntry danmaku)
			{
				this.m_owner.BattleUIController_OnShowOneDanmaku(danmaku);
			}

			// Token: 0x0600BA20 RID: 47648 RVA: 0x00346EA8 File Offset: 0x003450A8
			public void BattleUIController_OnPointerClick(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.BattleUIController_OnPointerClick(button, position);
			}

			// Token: 0x0600BA21 RID: 47649 RVA: 0x00346EB8 File Offset: 0x003450B8
			public bool ShouldShowActorInfo(BattleActor a)
			{
				return this.m_owner.ShouldShowActorInfo(a);
			}

			// Token: 0x0600BA22 RID: 47650 RVA: 0x00346EC8 File Offset: 0x003450C8
			public void BattleUIController_On3DTouch(Vector2 pos)
			{
				this.m_owner.BattleUIController_On3DTouch(pos);
			}

			// Token: 0x0600BA23 RID: 47651 RVA: 0x00346ED8 File Offset: 0x003450D8
			public void PlaySelectHeroSound(BattleActor a)
			{
				this.m_owner.PlaySelectHeroSound(a);
			}

			// Token: 0x0600BA24 RID: 47652 RVA: 0x00346EE8 File Offset: 0x003450E8
			public void BattleDialogUITask_OnClose(bool isSkip)
			{
				this.m_owner.BattleDialogUITask_OnClose(isSkip);
			}

			// Token: 0x0600BA25 RID: 47653 RVA: 0x00346EF8 File Offset: 0x003450F8
			public void BattleTreasureDialogUIController_OnClose()
			{
				this.m_owner.BattleTreasureDialogUIController_OnClose();
			}

			// Token: 0x0600BA26 RID: 47654 RVA: 0x00346F08 File Offset: 0x00345108
			public void GetRewardGoodsUITask_OnStop(Task task)
			{
				this.m_owner.GetRewardGoodsUITask_OnStop(task);
			}

			// Token: 0x0600BA27 RID: 47655 RVA: 0x00346F18 File Offset: 0x00345118
			public void GetRewardGoodsUITask_OnClose()
			{
				this.m_owner.GetRewardGoodsUITask_OnClose();
			}

			// Token: 0x0600BA28 RID: 47656 RVA: 0x00346F28 File Offset: 0x00345128
			public void CombatUIController_OnAutoBattle(bool on)
			{
				this.m_owner.CombatUIController_OnAutoBattle(on);
			}

			// Token: 0x0600BA29 RID: 47657 RVA: 0x00346F38 File Offset: 0x00345138
			public void PreCombatUIController_OnOk()
			{
				this.m_owner.PreCombatUIController_OnOk();
			}

			// Token: 0x0600BA2A RID: 47658 RVA: 0x00346F48 File Offset: 0x00345148
			public void PreCombatUIController_OnCancel()
			{
				this.m_owner.PreCombatUIController_OnCancel();
			}

			// Token: 0x0600BA2B RID: 47659 RVA: 0x00346F58 File Offset: 0x00345158
			public void PreCombatUIController_OnStop()
			{
				this.m_owner.PreCombatUIController_OnStop();
			}

			// Token: 0x0600BA2C RID: 47660 RVA: 0x00346F68 File Offset: 0x00345168
			public void BattleSceneUIController_OnPointerDown(PointerEventData eventData)
			{
				this.m_owner.BattleSceneUIController_OnPointerDown(eventData);
			}

			// Token: 0x0600BA2D RID: 47661 RVA: 0x00346F78 File Offset: 0x00345178
			public void BattleSceneUIController_OnPointerUp(PointerEventData eventData)
			{
				this.m_owner.BattleSceneUIController_OnPointerUp(eventData);
			}

			// Token: 0x0600BA2E RID: 47662 RVA: 0x00346F88 File Offset: 0x00345188
			public void BattleSceneUIController_OnPointerClick(PointerEventData eventData)
			{
				this.m_owner.BattleSceneUIController_OnPointerClick(eventData);
			}

			// Token: 0x0600BA2F RID: 47663 RVA: 0x00346F98 File Offset: 0x00345198
			public void BattleSceneUIController_OnBeginDrag(PointerEventData eventData)
			{
				this.m_owner.BattleSceneUIController_OnBeginDrag(eventData);
			}

			// Token: 0x0600BA30 RID: 47664 RVA: 0x00346FA8 File Offset: 0x003451A8
			public void BattleSceneUIController_OnEndDrag(PointerEventData eventData)
			{
				this.m_owner.BattleSceneUIController_OnEndDrag(eventData);
			}

			// Token: 0x0600BA31 RID: 47665 RVA: 0x00346FB8 File Offset: 0x003451B8
			public void BattleSceneUIController_OnDrag(PointerEventData eventData)
			{
				this.m_owner.BattleSceneUIController_OnDrag(eventData);
			}

			// Token: 0x0600BA32 RID: 47666 RVA: 0x00346FC8 File Offset: 0x003451C8
			public void BattleSceneUIController_On3DTouch(Vector2 p)
			{
				this.m_owner.BattleSceneUIController_On3DTouch(p);
			}

			// Token: 0x0600BA33 RID: 47667 RVA: 0x00346FD8 File Offset: 0x003451D8
			public void SendBattleCommands()
			{
				this.m_owner.SendBattleCommands();
			}

			// Token: 0x0600BA34 RID: 47668 RVA: 0x00346FE8 File Offset: 0x003451E8
			public void UpdateBattleRoomPlayerHeroStatus()
			{
				this.m_owner.UpdateBattleRoomPlayerHeroStatus();
			}

			// Token: 0x0600BA35 RID: 47669 RVA: 0x00346FF8 File Offset: 0x003451F8
			public void StartBattleRoomMyActionCountdown()
			{
				this.m_owner.StartBattleRoomMyActionCountdown();
			}

			// Token: 0x0600BA36 RID: 47670 RVA: 0x00347008 File Offset: 0x00345208
			public void StopBattleRoomMyActionCountdown()
			{
				this.m_owner.StopBattleRoomMyActionCountdown();
			}

			// Token: 0x0600BA37 RID: 47671 RVA: 0x00347018 File Offset: 0x00345218
			public void ActivateBattleRoomMyActionCountdown(bool isActive)
			{
				this.m_owner.ActivateBattleRoomMyActionCountdown(isActive);
			}

			// Token: 0x0600BA38 RID: 47672 RVA: 0x00347028 File Offset: 0x00345228
			public void UpdateBattleRoomMyActionCountdown()
			{
				this.m_owner.UpdateBattleRoomMyActionCountdown();
			}

			// Token: 0x0600BA39 RID: 47673 RVA: 0x00347038 File Offset: 0x00345238
			public void StartBattleRoomOtherActionCountdown(int playerIndex)
			{
				this.m_owner.StartBattleRoomOtherActionCountdown(playerIndex);
			}

			// Token: 0x0600BA3A RID: 47674 RVA: 0x00347048 File Offset: 0x00345248
			public void StopBattleRoomOtherActionCountdown()
			{
				this.m_owner.StopBattleRoomOtherActionCountdown();
			}

			// Token: 0x0600BA3B RID: 47675 RVA: 0x00347058 File Offset: 0x00345258
			public void ActivateBattleRoomOtherActionCountdown(bool isActive)
			{
				this.m_owner.ActivateBattleRoomOtherActionCountdown(isActive);
			}

			// Token: 0x0600BA3C RID: 47676 RVA: 0x00347068 File Offset: 0x00345268
			public void UpdateBattleRoomOtherActionCountdown()
			{
				this.m_owner.UpdateBattleRoomOtherActionCountdown();
			}

			// Token: 0x0600BA3D RID: 47677 RVA: 0x00347078 File Offset: 0x00345278
			public void BattleRoomSetAutoBattle(bool on)
			{
				this.m_owner.BattleRoomSetAutoBattle(on);
			}

			// Token: 0x0600BA3E RID: 47678 RVA: 0x00347088 File Offset: 0x00345288
			public void ProcessBattlePendingNtfs()
			{
				this.m_owner.ProcessBattlePendingNtfs();
			}

			// Token: 0x0600BA3F RID: 47679 RVA: 0x00347098 File Offset: 0x00345298
			public void PlayerContext_OnBattleRoomPlayerStatusChangedNtf(ulong playerSessionId)
			{
				this.m_owner.PlayerContext_OnBattleRoomPlayerStatusChangedNtf(playerSessionId);
			}

			// Token: 0x0600BA40 RID: 47680 RVA: 0x003470A8 File Offset: 0x003452A8
			public void PlayerContext_OnBattleRoomPlayerQuitNtf(ulong playerSessionId, BattleRoomQuitReason reason)
			{
				this.m_owner.PlayerContext_OnBattleRoomPlayerQuitNtf(playerSessionId, reason);
			}

			// Token: 0x0600BA41 RID: 47681 RVA: 0x003470B8 File Offset: 0x003452B8
			public void PlayerContext_OnBattleRoomBattleCommandExecuteNtf(ulong playerSessionId)
			{
				this.m_owner.PlayerContext_OnBattleRoomBattleCommandExecuteNtf(playerSessionId);
			}

			// Token: 0x0600BA42 RID: 47682 RVA: 0x003470C8 File Offset: 0x003452C8
			public void PlayerContext_OnBattleRoomTeamBattleFinishNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomTeamBattleFinishNtf();
			}

			// Token: 0x0600BA43 RID: 47683 RVA: 0x003470D8 File Offset: 0x003452D8
			public void PlayerContext_OnBattleRoomPVPBattleFinishNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomPVPBattleFinishNtf();
			}

			// Token: 0x0600BA44 RID: 47684 RVA: 0x003470E8 File Offset: 0x003452E8
			public void PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf();
			}

			// Token: 0x0600BA45 RID: 47685 RVA: 0x003470F8 File Offset: 0x003452F8
			public void PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf();
			}

			// Token: 0x0600BA46 RID: 47686 RVA: 0x00347108 File Offset: 0x00345308
			public void PlayerContext_OnBattleRoomPVPBattleJoinNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomPVPBattleJoinNtf();
			}

			// Token: 0x0600BA47 RID: 47687 RVA: 0x00347118 File Offset: 0x00345318
			public void PlayerContext_OnPlayerInfoInitEnd()
			{
				this.m_owner.PlayerContext_OnPlayerInfoInitEnd();
			}

			// Token: 0x0600BA48 RID: 47688 RVA: 0x00347128 File Offset: 0x00345328
			public void ReloginUITask_OnReloginSuccess()
			{
				this.m_owner.ReloginUITask_OnReloginSuccess();
			}

			// Token: 0x0600BA49 RID: 47689 RVA: 0x00347138 File Offset: 0x00345338
			public BattleRoom GetBattleRoom()
			{
				return this.m_owner.GetBattleRoom();
			}

			// Token: 0x0600BA4A RID: 47690 RVA: 0x00347148 File Offset: 0x00345348
			public void UpdateBattleRoomPrepareTimeout()
			{
				this.m_owner.UpdateBattleRoomPrepareTimeout();
			}

			// Token: 0x0600BA4B RID: 47691 RVA: 0x00347158 File Offset: 0x00345358
			public void UpdateRealtimePVPBattlePrepareTimeout()
			{
				this.m_owner.UpdateRealtimePVPBattlePrepareTimeout();
			}

			// Token: 0x0600BA4C RID: 47692 RVA: 0x00347168 File Offset: 0x00345368
			public void UpdateRealtimePVPBattlePrepareStatus()
			{
				this.m_owner.UpdateRealtimePVPBattlePrepareStatus();
			}

			// Token: 0x0600BA4D RID: 47693 RVA: 0x00347178 File Offset: 0x00345378
			public void UpdateStageActorTag(BattlePrepareStageActor sa)
			{
				this.m_owner.UpdateStageActorTag(sa);
			}

			// Token: 0x0600BA4E RID: 47694 RVA: 0x00347188 File Offset: 0x00345388
			public void ProcessBattlePreparePendingNtfs(bool playFx)
			{
				this.m_owner.ProcessBattlePreparePendingNtfs(playFx);
			}

			// Token: 0x0600BA4F RID: 47695 RVA: 0x00347198 File Offset: 0x00345398
			public void LoadAndUpdateBattleRoomStageActors(List<int> posList, bool playFx)
			{
				this.m_owner.LoadAndUpdateBattleRoomStageActors(posList, playFx);
			}

			// Token: 0x0600BA50 RID: 47696 RVA: 0x003471A8 File Offset: 0x003453A8
			public void UpdateBattleRoomStageActors(int posIdx, BattleHero hero, bool playFx)
			{
				this.m_owner.UpdateBattleRoomStageActors(posIdx, hero, playFx);
			}

			// Token: 0x0600BA51 RID: 47697 RVA: 0x003471B8 File Offset: 0x003453B8
			public void BattleRoomBattleStart()
			{
				this.m_owner.BattleRoomBattleStart();
			}

			// Token: 0x0600BA52 RID: 47698 RVA: 0x003471C8 File Offset: 0x003453C8
			public void PVPBattlePrepareUIController_OnPrepareConfirm()
			{
				this.m_owner.PVPBattlePrepareUIController_OnPrepareConfirm();
			}

			// Token: 0x0600BA53 RID: 47699 RVA: 0x003471D8 File Offset: 0x003453D8
			public void PlayerContext_OnBattleRoomHeroSetupNtf(List<int> posList)
			{
				this.m_owner.PlayerContext_OnBattleRoomHeroSetupNtf(posList);
			}

			// Token: 0x0600BA54 RID: 47700 RVA: 0x003471E8 File Offset: 0x003453E8
			public void PlayerContext_OnBattleRoomDataChangeNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomDataChangeNtf();
			}

			// Token: 0x0600BA55 RID: 47701 RVA: 0x003471F8 File Offset: 0x003453F8
			public void PlayerContext_OnBattleRoomTeamBattleStartNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomTeamBattleStartNtf();
			}

			// Token: 0x0600BA56 RID: 47702 RVA: 0x00347208 File Offset: 0x00345408
			public void PlayerContext_OnBattleRoomPVPBattleStartNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomPVPBattleStartNtf();
			}

			// Token: 0x0600BA57 RID: 47703 RVA: 0x00347218 File Offset: 0x00345418
			public void PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf()
			{
				this.m_owner.PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf();
			}

			// Token: 0x0600BA58 RID: 47704 RVA: 0x00347228 File Offset: 0x00345428
			public void ShowBattleResult(BattleType battleType, int stars, BattleReward battleReward, bool isFirstWin, List<int> gotAchievements, BattleLevelAchievement[] achievements)
			{
				this.m_owner.ShowBattleResult(battleType, stars, battleReward, isFirstWin, gotAchievements, achievements);
			}

			// Token: 0x0600BA59 RID: 47705 RVA: 0x00347240 File Offset: 0x00345440
			public void ShowBattleLose()
			{
				this.m_owner.ShowBattleLose();
			}

			// Token: 0x0600BA5A RID: 47706 RVA: 0x00347250 File Offset: 0x00345450
			public void ShowBattleReportEnd(ArenaBattleReport battleReport)
			{
				this.m_owner.ShowBattleReportEnd(battleReport);
			}

			// Token: 0x0600BA5B RID: 47707 RVA: 0x00347260 File Offset: 0x00345460
			public void ShowBattleReportEnd(RealTimePVPBattleReport battleReport)
			{
				this.m_owner.ShowBattleReportEnd(battleReport);
			}

			// Token: 0x0600BA5C RID: 47708 RVA: 0x00347270 File Offset: 0x00345470
			public ProBattleReport BuildBattleReport()
			{
				return this.m_owner.BuildBattleReport();
			}

			// Token: 0x0600BA5D RID: 47709 RVA: 0x00347280 File Offset: 0x00345480
			public bool CheckBattleResult()
			{
				return this.m_owner.CheckBattleResult();
			}

			// Token: 0x0600BA5E RID: 47710 RVA: 0x00347290 File Offset: 0x00345490
			public void SendBattleCheatGMCommand(bool isCheat)
			{
				this.m_owner.SendBattleCheatGMCommand(isCheat);
			}

			// Token: 0x0600BA5F RID: 47711 RVA: 0x003472A0 File Offset: 0x003454A0
			public void BattleResultEnd()
			{
				this.m_owner.BattleResultEnd();
			}

			// Token: 0x0600BA60 RID: 47712 RVA: 0x003472B0 File Offset: 0x003454B0
			public void BattleRoomInviteTeammateDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.BattleRoomInviteTeammateDialogBoxCallback(r);
			}

			// Token: 0x0600BA61 RID: 47713 RVA: 0x003472C0 File Offset: 0x003454C0
			public void BattleUIController_OnWinOrLoseEnd()
			{
				this.m_owner.BattleUIController_OnWinOrLoseEnd();
			}

			// Token: 0x0600BA62 RID: 47714 RVA: 0x003472D0 File Offset: 0x003454D0
			public void BattleResultUITask_OnStop(Task task)
			{
				this.m_owner.BattleResultUITask_OnStop(task);
			}

			// Token: 0x0600BA63 RID: 47715 RVA: 0x003472E0 File Offset: 0x003454E0
			public void BattleResultUITask_OnClose()
			{
				this.m_owner.BattleResultUITask_OnClose();
			}

			// Token: 0x0600BA64 RID: 47716 RVA: 0x003472F0 File Offset: 0x003454F0
			public void BattleResultScoreUITask_OnStop(Task task)
			{
				this.m_owner.BattleResultScoreUITask_OnStop(task);
			}

			// Token: 0x0600BA65 RID: 47717 RVA: 0x00347300 File Offset: 0x00345500
			public void BattleResultScoreUITask_OnClose()
			{
				this.m_owner.BattleResultScoreUITask_OnClose();
			}

			// Token: 0x0600BA66 RID: 47718 RVA: 0x00347310 File Offset: 0x00345510
			public void BattleLoseUITask_OnStop(Task task)
			{
				this.m_owner.BattleLoseUITask_OnStop(task);
			}

			// Token: 0x0600BA67 RID: 47719 RVA: 0x00347320 File Offset: 0x00345520
			public void BattleLoseUITask_OnClose()
			{
				this.m_owner.BattleLoseUITask_OnClose();
			}

			// Token: 0x0600BA68 RID: 47720 RVA: 0x00347330 File Offset: 0x00345530
			public void BattleReportEndUITask_OnStop(Task task)
			{
				this.m_owner.BattleReportEndUITask_OnStop(task);
			}

			// Token: 0x0600BA69 RID: 47721 RVA: 0x00347340 File Offset: 0x00345540
			public void BattleReportEndUITask_OnClose()
			{
				this.m_owner.BattleReportEndUITask_OnClose();
			}

			// Token: 0x0600BA6A RID: 47722 RVA: 0x00347350 File Offset: 0x00345550
			public void BattleReportEndUITask_OnPlayAgain()
			{
				this.m_owner.BattleReportEndUITask_OnPlayAgain();
			}

			// Token: 0x0600BA6B RID: 47723 RVA: 0x00347360 File Offset: 0x00345560
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x0600BA6C RID: 47724 RVA: 0x00347370 File Offset: 0x00345570
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x0600BA6D RID: 47725 RVA: 0x00347380 File Offset: 0x00345580
			public void InitBattleSceneUIController()
			{
				this.m_owner.InitBattleSceneUIController();
			}

			// Token: 0x0600BA6E RID: 47726 RVA: 0x00347390 File Offset: 0x00345590
			public void UninitBattleSceneUIController()
			{
				this.m_owner.UninitBattleSceneUIController();
			}

			// Token: 0x0600BA6F RID: 47727 RVA: 0x003473A0 File Offset: 0x003455A0
			public void InitBattleUIController()
			{
				this.m_owner.InitBattleUIController();
			}

			// Token: 0x0600BA70 RID: 47728 RVA: 0x003473B0 File Offset: 0x003455B0
			public void UninitBattleUIController()
			{
				this.m_owner.UninitBattleUIController();
			}

			// Token: 0x0600BA71 RID: 47729 RVA: 0x003473C0 File Offset: 0x003455C0
			public void InitCombatUIController()
			{
				this.m_owner.InitCombatUIController();
			}

			// Token: 0x0600BA72 RID: 47730 RVA: 0x003473D0 File Offset: 0x003455D0
			public void UninitCombatUIController()
			{
				this.m_owner.UninitCombatUIController();
			}

			// Token: 0x0600BA73 RID: 47731 RVA: 0x003473E0 File Offset: 0x003455E0
			public void InitPreCombatUIController()
			{
				this.m_owner.InitPreCombatUIController();
			}

			// Token: 0x0600BA74 RID: 47732 RVA: 0x003473F0 File Offset: 0x003455F0
			public void UninitPreCombatUIController()
			{
				this.m_owner.UninitPreCombatUIController();
			}

			// Token: 0x0600BA75 RID: 47733 RVA: 0x00347400 File Offset: 0x00345600
			public void InitBattleRoomUIController()
			{
				this.m_owner.InitBattleRoomUIController();
			}

			// Token: 0x0600BA76 RID: 47734 RVA: 0x00347410 File Offset: 0x00345610
			public void UninitBattleRoomUIController()
			{
				this.m_owner.UninitBattleRoomUIController();
			}

			// Token: 0x0600BA77 RID: 47735 RVA: 0x00347420 File Offset: 0x00345620
			public void InitBattleCommonUIController()
			{
				this.m_owner.InitBattleCommonUIController();
			}

			// Token: 0x0600BA78 RID: 47736 RVA: 0x00347430 File Offset: 0x00345630
			public void UninitBattleCommonUIController()
			{
				this.m_owner.UninitBattleCommonUIController();
			}

			// Token: 0x0600BA79 RID: 47737 RVA: 0x00347440 File Offset: 0x00345640
			public void InitBattlePrepareUIController()
			{
				this.m_owner.InitBattlePrepareUIController();
			}

			// Token: 0x0600BA7A RID: 47738 RVA: 0x00347450 File Offset: 0x00345650
			public void UninitBattlePrepareUIController()
			{
				this.m_owner.UninitBattlePrepareUIController();
			}

			// Token: 0x0600BA7B RID: 47739 RVA: 0x00347460 File Offset: 0x00345660
			public void BattleDialogUITask_OnLoadAllResCompleted()
			{
				this.m_owner.BattleDialogUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600BA7C RID: 47740 RVA: 0x00347470 File Offset: 0x00345670
			public void StartBattleTeamSetNetTask(BattleType battleType, int battleId, List<int> heros)
			{
				this.m_owner.StartBattleTeamSetNetTask(battleType, battleId, heros);
			}

			// Token: 0x0600BA7D RID: 47741 RVA: 0x00347480 File Offset: 0x00345680
			public void StartLevelAttackNetTask()
			{
				this.m_owner.StartLevelAttackNetTask();
			}

			// Token: 0x0600BA7E RID: 47742 RVA: 0x00347490 File Offset: 0x00345690
			public void StartLevelWayPointMoveNetTask(ConfigDataWaypointInfo waypointInfo)
			{
				this.m_owner.StartLevelWayPointMoveNetTask(waypointInfo);
			}

			// Token: 0x0600BA7F RID: 47743 RVA: 0x003474A0 File Offset: 0x003456A0
			public void StartLevelScenarioHandleNetTask(ConfigDataScenarioInfo scenarioInfo)
			{
				this.m_owner.StartLevelScenarioHandleNetTask(scenarioInfo);
			}

			// Token: 0x0600BA80 RID: 47744 RVA: 0x003474B0 File Offset: 0x003456B0
			public void StartRiftLevelAttackNetTask(ConfigDataRiftLevelInfo levelInfo)
			{
				this.m_owner.StartRiftLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA81 RID: 47745 RVA: 0x003474C0 File Offset: 0x003456C0
			public void StartHeroDungeonLevelAttackNetTask(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				this.m_owner.StartHeroDungeonLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA82 RID: 47746 RVA: 0x003474D0 File Offset: 0x003456D0
			public void StartAnikiLevelAttackNetTask(ConfigDataAnikiLevelInfo levelInfo)
			{
				this.m_owner.StartAnikiLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA83 RID: 47747 RVA: 0x003474E0 File Offset: 0x003456E0
			public void StartThearchyLevelAttackNetTask(ConfigDataThearchyTrialLevelInfo levelInfo)
			{
				this.m_owner.StartThearchyLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA84 RID: 47748 RVA: 0x003474F0 File Offset: 0x003456F0
			public void StartMemoryCorridorLevelAttackNetTask(ConfigDataMemoryCorridorLevelInfo levelInfo)
			{
				this.m_owner.StartMemoryCorridorLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA85 RID: 47749 RVA: 0x00347500 File Offset: 0x00345700
			public void StartHeroTrainningLevelAttackNetTask(ConfigDataHeroTrainningLevelInfo levelInfo)
			{
				this.m_owner.StartHeroTrainningLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA86 RID: 47750 RVA: 0x00347510 File Offset: 0x00345710
			public void StartHeroPhantomLevelAttackNetTask(ConfigDataHeroPhantomLevelInfo levelInfo)
			{
				this.m_owner.StartHeroPhantomLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA87 RID: 47751 RVA: 0x00347520 File Offset: 0x00345720
			public void StartTreasureLevelAttackNetTask(ConfigDataTreasureLevelInfo levelInfo)
			{
				this.m_owner.StartTreasureLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA88 RID: 47752 RVA: 0x00347530 File Offset: 0x00345730
			public void StartUnchartedScoreLevelAttackNetTask(ConfigDataScoreLevelInfo levelInfo)
			{
				this.m_owner.StartUnchartedScoreLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA89 RID: 47753 RVA: 0x00347540 File Offset: 0x00345740
			public void StartUnchartedChallengeLevelAttackNetTask(ConfigDataChallengeLevelInfo levelInfo)
			{
				this.m_owner.StartUnchartedChallengeLevelAttackNetTask(levelInfo);
			}

			// Token: 0x0600BA8A RID: 47754 RVA: 0x00347550 File Offset: 0x00345750
			public void StartClimbTowerLevelAttackNetTask(ConfigDataTowerFloorInfo floorInfo)
			{
				this.m_owner.StartClimbTowerLevelAttackNetTask(floorInfo);
			}

			// Token: 0x0600BA8B RID: 47755 RVA: 0x00347560 File Offset: 0x00345760
			public void StartGuildMassiveCombatAttackNetTask(ConfigDataGuildMassiveCombatLevelInfo levelInfo, List<int> heroIds)
			{
				this.m_owner.StartGuildMassiveCombatAttackNetTask(levelInfo, heroIds);
			}

			// Token: 0x0600BA8C RID: 47756 RVA: 0x00347570 File Offset: 0x00345770
			public void StartArenaOpponentAttackFightingNetTask()
			{
				this.m_owner.StartArenaOpponentAttackFightingNetTask();
			}

			// Token: 0x0600BA8D RID: 47757 RVA: 0x00347580 File Offset: 0x00345780
			public void HandleLevelAttackNetTaskResult(int result)
			{
				this.m_owner.HandleLevelAttackNetTaskResult(result);
			}

			// Token: 0x0600BA8E RID: 47758 RVA: 0x00347590 File Offset: 0x00345790
			public void StartWayPointBattleFinishedNetTask(ConfigDataWaypointInfo wayPointInfo)
			{
				this.m_owner.StartWayPointBattleFinishedNetTask(wayPointInfo);
			}

			// Token: 0x0600BA8F RID: 47759 RVA: 0x003475A0 File Offset: 0x003457A0
			public void StartRiftLevelBattleFinishedNetTask(ConfigDataRiftLevelInfo levelInfo)
			{
				this.m_owner.StartRiftLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA90 RID: 47760 RVA: 0x003475B0 File Offset: 0x003457B0
			public void StartHeroDungeonLevelBattleFinishedNetTask(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				this.m_owner.StartHeroDungeonLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA91 RID: 47761 RVA: 0x003475C0 File Offset: 0x003457C0
			public void StartAnikiLevelBattleFinishedNetTask(ConfigDataAnikiLevelInfo levelInfo)
			{
				this.m_owner.StartAnikiLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA92 RID: 47762 RVA: 0x003475D0 File Offset: 0x003457D0
			public void StartThearchyLevelBattleFinishedNetTask(ConfigDataThearchyTrialLevelInfo levelInfo)
			{
				this.m_owner.StartThearchyLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA93 RID: 47763 RVA: 0x003475E0 File Offset: 0x003457E0
			public void StartTreasureLevelBattleFinishedNetTask(ConfigDataTreasureLevelInfo levelInfo)
			{
				this.m_owner.StartTreasureLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA94 RID: 47764 RVA: 0x003475F0 File Offset: 0x003457F0
			public void StartMemoryCorridorLevelBattleFinishedNetTask(ConfigDataMemoryCorridorLevelInfo levelInfo)
			{
				this.m_owner.StartMemoryCorridorLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA95 RID: 47765 RVA: 0x00347600 File Offset: 0x00345800
			public void StartHeroTrainningLevelBattleFinishedNetTask(ConfigDataHeroTrainningLevelInfo levelInfo)
			{
				this.m_owner.StartHeroTrainningLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA96 RID: 47766 RVA: 0x00347610 File Offset: 0x00345810
			public void StartHeroPhantomLevelBattleFinishedNetTask(ConfigDataHeroPhantomLevelInfo levelInfo)
			{
				this.m_owner.StartHeroPhantomLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA97 RID: 47767 RVA: 0x00347620 File Offset: 0x00345820
			public void StartUnchartedScoreLevelBattleFinishedNetTask(ConfigDataScoreLevelInfo levelInfo)
			{
				this.m_owner.StartUnchartedScoreLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA98 RID: 47768 RVA: 0x00347630 File Offset: 0x00345830
			public void StartUnchartedChallengeLevelBattleFinishedNetTask(ConfigDataChallengeLevelInfo levelInfo)
			{
				this.m_owner.StartUnchartedChallengeLevelBattleFinishedNetTask(levelInfo);
			}

			// Token: 0x0600BA99 RID: 47769 RVA: 0x00347640 File Offset: 0x00345840
			public void StartClimbTowerLevelBattleFinishedNetTask(ConfigDataTowerFloorInfo floorInfo)
			{
				this.m_owner.StartClimbTowerLevelBattleFinishedNetTask(floorInfo);
			}

			// Token: 0x0600BA9A RID: 47770 RVA: 0x00347650 File Offset: 0x00345850
			public void StartGuildMassiveCombatSinglePVEBattleEndNetTask(ConfigDataGuildMassiveCombatLevelInfo levelInfo)
			{
				this.m_owner.StartGuildMassiveCombatSinglePVEBattleEndNetTask(levelInfo);
			}

			// Token: 0x0600BA9B RID: 47771 RVA: 0x00347660 File Offset: 0x00345860
			public void StartArenaBattleFinishedNetTask()
			{
				this.m_owner.StartArenaBattleFinishedNetTask();
			}

			// Token: 0x0600BA9C RID: 47772 RVA: 0x00347670 File Offset: 0x00345870
			public void HandleBattleFinishedNetTaskResult(int result, bool isWin, BattleReward reward, int stars, bool isFirstWin, List<int> gotAchievements, BattleLevelAchievement[] achievements)
			{
				this.m_owner.HandleBattleFinishedNetTaskResult(result, isWin, reward, stars, isFirstWin, gotAchievements, achievements);
			}

			// Token: 0x0600BA9D RID: 47773 RVA: 0x00347688 File Offset: 0x00345888
			public void StartBattleCancelNetTask()
			{
				this.m_owner.StartBattleCancelNetTask();
			}

			// Token: 0x0600BA9E RID: 47774 RVA: 0x00347698 File Offset: 0x00345898
			public void StartDanmakuPostNetTask(Action<int> onEnd)
			{
				this.m_owner.StartDanmakuPostNetTask(onEnd);
			}

			// Token: 0x0600BA9F RID: 47775 RVA: 0x003476A8 File Offset: 0x003458A8
			public void StartBattleRoomHeroSetupNetTask(int heroId, int position)
			{
				this.m_owner.StartBattleRoomHeroSetupNetTask(heroId, position);
			}

			// Token: 0x0600BAA0 RID: 47776 RVA: 0x003476B8 File Offset: 0x003458B8
			public void StartBattleRoomHeroSwapNetTask(int position1, int position2)
			{
				this.m_owner.StartBattleRoomHeroSwapNetTask(position1, position2);
			}

			// Token: 0x0600BAA1 RID: 47777 RVA: 0x003476C8 File Offset: 0x003458C8
			public void StartBattleRoomHeroSetoffNetTask(int position)
			{
				this.m_owner.StartBattleRoomHeroSetoffNetTask(position);
			}

			// Token: 0x0600BAA2 RID: 47778 RVA: 0x003476D8 File Offset: 0x003458D8
			public void StartBattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus status, Action onOk)
			{
				this.m_owner.StartBattleRoomPlayerStatusChangeNetTask(status, onOk);
			}

			// Token: 0x0600BAA3 RID: 47779 RVA: 0x003476E8 File Offset: 0x003458E8
			public void StartBattleRoomQuitNetTask()
			{
				this.m_owner.StartBattleRoomQuitNetTask();
			}

			// Token: 0x0600BAA4 RID: 47780 RVA: 0x003476F8 File Offset: 0x003458F8
			public void StartBattleRoomEndCurrentBPTurnNetTask(Action onOk)
			{
				this.m_owner.StartBattleRoomEndCurrentBPTurnNetTask(onOk);
			}

			// Token: 0x0600BAA5 RID: 47781 RVA: 0x00347708 File Offset: 0x00345908
			public void StartBattleRoomPlayerActionBeginNetTask()
			{
				this.m_owner.StartBattleRoomPlayerActionBeginNetTask();
			}

			// Token: 0x0600BAA6 RID: 47782 RVA: 0x00347718 File Offset: 0x00345918
			public List<GridPosition> SetupReachRegion(bool isSkipBattlePrepare)
			{
				return this.m_owner.SetupReachRegion(isSkipBattlePrepare);
			}

			// Token: 0x0600BAA7 RID: 47783 RVA: 0x00347728 File Offset: 0x00345928
			public void SetupBattlePauseUIController(List<GridPosition> reachRegion)
			{
				this.m_owner.SetupBattlePauseUIController(reachRegion);
			}

			// Token: 0x0600BAA8 RID: 47784 RVA: 0x00347738 File Offset: 0x00345938
			public void SetupBattlePauseUIAchievements()
			{
				this.m_owner.SetupBattlePauseUIAchievements();
			}

			// Token: 0x0600BAA9 RID: 47785 RVA: 0x00347748 File Offset: 0x00345948
			public GridPosition GetWinConditionTargetPosition(ConfigDataBattleWinConditionInfo winConditionInfo)
			{
				return this.m_owner.GetWinConditionTargetPosition(winConditionInfo);
			}

			// Token: 0x0600BAAA RID: 47786 RVA: 0x00347758 File Offset: 0x00345958
			public int GetMyStageActorCountMax()
			{
				return this.m_owner.GetMyStageActorCountMax();
			}

			// Token: 0x0600BAAB RID: 47787 RVA: 0x00347768 File Offset: 0x00345968
			public List<int> SetupMyHeros(ConfigDataBattleInfo battleInfo, int number, bool isSkipBattlePrepare)
			{
				return this.m_owner.SetupMyHeros(battleInfo, number, isSkipBattlePrepare);
			}

			// Token: 0x0600BAAC RID: 47788 RVA: 0x00347778 File Offset: 0x00345978
			public void FillMyHeros(List<int> heroIds, int count, List<int> disableHeroIds)
			{
				this.m_owner.FillMyHeros(heroIds, count, disableHeroIds);
			}

			// Token: 0x0600BAAD RID: 47789 RVA: 0x00347788 File Offset: 0x00345988
			public void SetupStageActors(bool isSkipBattlePrepare)
			{
				this.m_owner.SetupStageActors(isSkipBattlePrepare);
			}

			// Token: 0x0600BAAE RID: 47790 RVA: 0x00347798 File Offset: 0x00345998
			public static ConfigDataUnchartedScoreInfo GetUnchartedScoreInfo()
			{
				return BattleUITask.GetUnchartedScoreInfo();
			}

			// Token: 0x0600BAAF RID: 47791 RVA: 0x003477A0 File Offset: 0x003459A0
			public static int GetHeroUnchartedScoreBonus(BattleHero hero)
			{
				return BattleUITask.GetHeroUnchartedScoreBonus(hero);
			}

			// Token: 0x0600BAB0 RID: 47792 RVA: 0x003477A8 File Offset: 0x003459A8
			public ConfigDataTowerBattleRuleInfo GetTowerBattleRuleInfo()
			{
				return this.m_owner.GetTowerBattleRuleInfo();
			}

			// Token: 0x0600BAB1 RID: 47793 RVA: 0x003477B8 File Offset: 0x003459B8
			public ConfigDataTowerBonusHeroGroupInfo GetTowerBonusHeroGroupInfo()
			{
				return this.m_owner.GetTowerBonusHeroGroupInfo();
			}

			// Token: 0x0600BAB2 RID: 47794 RVA: 0x003477C8 File Offset: 0x003459C8
			public bool IsTowerPowerUpHero(BattleHero hero)
			{
				return this.m_owner.IsTowerPowerUpHero(hero);
			}

			// Token: 0x0600BAB3 RID: 47795 RVA: 0x003477D8 File Offset: 0x003459D8
			public GuildPlayerMassiveCombatInfo GetGuildPlayerMassiveCombatInfo()
			{
				return this.m_owner.GetGuildPlayerMassiveCombatInfo();
			}

			// Token: 0x0600BAB4 RID: 47796 RVA: 0x003477E8 File Offset: 0x003459E8
			public bool IsGuildMassiveCombatCampUpHero(BattleHero hero)
			{
				return this.m_owner.IsGuildMassiveCombatCampUpHero(hero);
			}

			// Token: 0x0600BAB5 RID: 47797 RVA: 0x003477F8 File Offset: 0x003459F8
			public StageActorTagType GetHeroTagType(BattleHero hero)
			{
				return this.m_owner.GetHeroTagType(hero);
			}

			// Token: 0x0600BAB6 RID: 47798 RVA: 0x00347808 File Offset: 0x00345A08
			public void LoadArenaAttackerHeroActionValue(BattleHero hero)
			{
				this.m_owner.LoadArenaAttackerHeroActionValue(hero);
			}

			// Token: 0x0600BAB7 RID: 47799 RVA: 0x00347818 File Offset: 0x00345A18
			public static int CompareHero(BattleHero h1, BattleHero h2)
			{
				return BattleUITask.CompareHero(h1, h2);
			}

			// Token: 0x0600BAB8 RID: 47800 RVA: 0x00347824 File Offset: 0x00345A24
			public static int CompareHeroUnchartdScoreBonus(BattleHero h1, BattleHero h2)
			{
				return BattleUITask.CompareHeroUnchartdScoreBonus(h1, h2);
			}

			// Token: 0x0600BAB9 RID: 47801 RVA: 0x00347830 File Offset: 0x00345A30
			public void ShowStagePositions()
			{
				this.m_owner.ShowStagePositions();
			}

			// Token: 0x0600BABA RID: 47802 RVA: 0x00347840 File Offset: 0x00345A40
			public void SetupBattlePrepareTreasures()
			{
				this.m_owner.SetupBattlePrepareTreasures();
			}

			// Token: 0x0600BABB RID: 47803 RVA: 0x00347850 File Offset: 0x00345A50
			public static bool IsListElementsEqual(List<int> list0, List<int> list1)
			{
				return BattleUITask.IsListElementsEqual(list0, list1);
			}

			// Token: 0x0600BABC RID: 47804 RVA: 0x0034785C File Offset: 0x00345A5C
			public void BuildBattleTeamSetups()
			{
				this.m_owner.BuildBattleTeamSetups();
			}

			// Token: 0x0600BABD RID: 47805 RVA: 0x0034786C File Offset: 0x00345A6C
			public void BuildBattleTeamSetup(int team, bool saveHeroList)
			{
				this.m_owner.BuildBattleTeamSetup(team, saveHeroList);
			}

			// Token: 0x0600BABE RID: 47806 RVA: 0x0034787C File Offset: 0x00345A7C
			public int GetSoldierCount(int team)
			{
				return this.m_owner.GetSoldierCount(team);
			}

			// Token: 0x0600BABF RID: 47807 RVA: 0x0034788C File Offset: 0x00345A8C
			public void SetTeamAndStartBattle()
			{
				this.m_owner.SetTeamAndStartBattle();
			}

			// Token: 0x0600BAC0 RID: 47808 RVA: 0x0034789C File Offset: 0x00345A9C
			public void StartBattlePrepareLoadState()
			{
				this.m_owner.StartBattlePrepareLoadState();
			}

			// Token: 0x0600BAC1 RID: 47809 RVA: 0x003478AC File Offset: 0x00345AAC
			public void StartBattleLoadState()
			{
				this.m_owner.StartBattleLoadState();
			}

			// Token: 0x0600BAC2 RID: 47810 RVA: 0x003478BC File Offset: 0x00345ABC
			public void ShowMoveAndAttackRegion_Prepare(GridPosition pos)
			{
				this.m_owner.ShowMoveAndAttackRegion_Prepare(pos);
			}

			// Token: 0x0600BAC3 RID: 47811 RVA: 0x003478CC File Offset: 0x00345ACC
			public void UpdateArenaAttackerHeroIds()
			{
				this.m_owner.UpdateArenaAttackerHeroIds();
			}

			// Token: 0x0600BAC4 RID: 47812 RVA: 0x003478DC File Offset: 0x00345ADC
			public static int CompareHeroActionValue(BattleHero hero0, BattleHero hero1)
			{
				return BattleUITask.CompareHeroActionValue(hero0, hero1);
			}

			// Token: 0x0600BAC5 RID: 47813 RVA: 0x003478E8 File Offset: 0x00345AE8
			public List<TrainingTech> GetPlayerTrainingTechs(int team, int playerIndex, bool isNpc)
			{
				return this.m_owner.GetPlayerTrainingTechs(team, playerIndex, isNpc);
			}

			// Token: 0x0600BAC6 RID: 47814 RVA: 0x003478F8 File Offset: 0x00345AF8
			public int GetPlayerLevel(int team, int playerIndex)
			{
				return this.m_owner.GetPlayerLevel(team, playerIndex);
			}

			// Token: 0x0600BAC7 RID: 47815 RVA: 0x00347908 File Offset: 0x00345B08
			public ulong GetPlayerSessionId(int playerIndex)
			{
				return this.m_owner.GetPlayerSessionId(playerIndex);
			}

			// Token: 0x0600BAC8 RID: 47816 RVA: 0x00347918 File Offset: 0x00345B18
			public int GetMyPlayerIndex()
			{
				return this.m_owner.GetMyPlayerIndex();
			}

			// Token: 0x0600BAC9 RID: 47817 RVA: 0x00347928 File Offset: 0x00345B28
			public bool IsBattlePrepareDisableCameraMove()
			{
				return this.m_owner.IsBattlePrepareDisableCameraMove();
			}

			// Token: 0x0600BACA RID: 47818 RVA: 0x00347938 File Offset: 0x00345B38
			public void UpdateBattlePower()
			{
				this.m_owner.UpdateBattlePower();
			}

			// Token: 0x0600BACB RID: 47819 RVA: 0x00347948 File Offset: 0x00345B48
			public void BattlePrepareUIController_OnPauseBattle()
			{
				this.m_owner.BattlePrepareUIController_OnPauseBattle();
			}

			// Token: 0x0600BACC RID: 47820 RVA: 0x00347958 File Offset: 0x00345B58
			public void BattlePrepareUIController_OnShowArmyRelation()
			{
				this.m_owner.BattlePrepareUIController_OnShowArmyRelation();
			}

			// Token: 0x0600BACD RID: 47821 RVA: 0x00347968 File Offset: 0x00345B68
			public void BattlePrepareUIController_OnStart()
			{
				this.m_owner.BattlePrepareUIController_OnStart();
			}

			// Token: 0x0600BACE RID: 47822 RVA: 0x00347978 File Offset: 0x00345B78
			public void BattlePrepareUIController_OnShowActionOrder()
			{
				this.m_owner.BattlePrepareUIController_OnShowActionOrder();
			}

			// Token: 0x0600BACF RID: 47823 RVA: 0x00347988 File Offset: 0x00345B88
			public void HeroNotFullDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.HeroNotFullDialogBoxCallback(r);
			}

			// Token: 0x0600BAD0 RID: 47824 RVA: 0x00347998 File Offset: 0x00345B98
			public void BattlePrepareUIController_OnTestOnStage()
			{
				this.m_owner.BattlePrepareUIController_OnTestOnStage();
			}

			// Token: 0x0600BAD1 RID: 47825 RVA: 0x003479A8 File Offset: 0x00345BA8
			public void BattlePrepareUIController_OnShowMyActorInfo(BattleHero hero)
			{
				this.m_owner.BattlePrepareUIController_OnShowMyActorInfo(hero);
			}

			// Token: 0x0600BAD2 RID: 47826 RVA: 0x003479B8 File Offset: 0x00345BB8
			public void BattlePrepareUIController_OnHideActorInfo()
			{
				this.m_owner.BattlePrepareUIController_OnHideActorInfo();
			}

			// Token: 0x0600BAD3 RID: 47827 RVA: 0x003479C8 File Offset: 0x00345BC8
			public void BattlePrepareUIController_OnStageActorChange()
			{
				this.m_owner.BattlePrepareUIController_OnStageActorChange();
			}

			// Token: 0x0600BAD4 RID: 47828 RVA: 0x003479D8 File Offset: 0x00345BD8
			public void BattlePrepareUIController_OnHeroOnStage(BattleHero hero, GridPosition pos, int team)
			{
				this.m_owner.BattlePrepareUIController_OnHeroOnStage(hero, pos, team);
			}

			// Token: 0x0600BAD5 RID: 47829 RVA: 0x003479E8 File Offset: 0x00345BE8
			public void BattlePrepareUIController_OnActorOffStage(BattlePrepareStageActor sa)
			{
				this.m_owner.BattlePrepareUIController_OnActorOffStage(sa);
			}

			// Token: 0x0600BAD6 RID: 47830 RVA: 0x003479F8 File Offset: 0x00345BF8
			public void BattlePrepareUIController_OnStageActorMove(BattlePrepareStageActor sa, GridPosition p)
			{
				this.m_owner.BattlePrepareUIController_OnStageActorMove(sa, p);
			}

			// Token: 0x0600BAD7 RID: 47831 RVA: 0x00347A08 File Offset: 0x00345C08
			public void BattlePrepareUIController_OnStageActorSwap(BattlePrepareStageActor sa1, BattlePrepareStageActor sa2)
			{
				this.m_owner.BattlePrepareUIController_OnStageActorSwap(sa1, sa2);
			}

			// Token: 0x0600BAD8 RID: 47832 RVA: 0x00347A18 File Offset: 0x00345C18
			public void BattlePrepareUIController_OnUpdateBattlePower()
			{
				this.m_owner.BattlePrepareUIController_OnUpdateBattlePower();
			}

			// Token: 0x0600BAD9 RID: 47833 RVA: 0x00347A28 File Offset: 0x00345C28
			public void BattlePrepareUIController_OnShowChat()
			{
				this.m_owner.BattlePrepareUIController_OnShowChat();
			}

			// Token: 0x0600BADA RID: 47834 RVA: 0x00347A38 File Offset: 0x00345C38
			public void BattlePrepareUIController_OnShowHelp()
			{
				this.m_owner.BattlePrepareUIController_OnShowHelp();
			}

			// Token: 0x0600BADB RID: 47835 RVA: 0x00347A48 File Offset: 0x00345C48
			public void BattlePrepareUIController_OnPointerDown(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.BattlePrepareUIController_OnPointerDown(button, position);
			}

			// Token: 0x0600BADC RID: 47836 RVA: 0x00347A58 File Offset: 0x00345C58
			public void BattlePrepareUIController_OnPointerUp(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.BattlePrepareUIController_OnPointerUp(button, position);
			}

			// Token: 0x0600BADD RID: 47837 RVA: 0x00347A68 File Offset: 0x00345C68
			public void BattlePrepareUIController_OnBeginDragHero()
			{
				this.m_owner.BattlePrepareUIController_OnBeginDragHero();
			}

			// Token: 0x0600BADE RID: 47838 RVA: 0x00347A78 File Offset: 0x00345C78
			public void BattlePrepareUIController_OnEndDragHero()
			{
				this.m_owner.BattlePrepareUIController_OnEndDragHero();
			}

			// Token: 0x0600BADF RID: 47839 RVA: 0x00347A88 File Offset: 0x00345C88
			public void BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(BattleHero hero)
			{
				this.m_owner.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(hero);
			}

			// Token: 0x0600BAE0 RID: 47840 RVA: 0x00347A98 File Offset: 0x00345C98
			public void BattlePrepareActorInfoUIController_OnChangeSkill(BattleHero hero, List<int> skillIds)
			{
				this.m_owner.BattlePrepareActorInfoUIController_OnChangeSkill(hero, skillIds);
			}

			// Token: 0x0600BAE1 RID: 47841 RVA: 0x00347AA8 File Offset: 0x00345CA8
			public void BattlePrepareActorInfoUIController_OnChangeSoldier(BattleHero hero, int soldierId)
			{
				this.m_owner.BattlePrepareActorInfoUIController_OnChangeSoldier(hero, soldierId);
			}

			// Token: 0x0600BAE2 RID: 47842 RVA: 0x00347AB8 File Offset: 0x00345CB8
			public void ActionOrderUIController_OnConfirm()
			{
				this.m_owner.ActionOrderUIController_OnConfirm();
			}

			// Token: 0x0600BAE3 RID: 47843 RVA: 0x00347AC8 File Offset: 0x00345CC8
			public void SetUIStateRegret()
			{
				this.m_owner.SetUIStateRegret();
			}

			// Token: 0x0600BAE4 RID: 47844 RVA: 0x00347AD8 File Offset: 0x00345CD8
			public bool IsRegretActive()
			{
				return this.m_owner.IsRegretActive();
			}

			// Token: 0x0600BAE5 RID: 47845 RVA: 0x00347AE8 File Offset: 0x00345CE8
			public bool CanUseRegret()
			{
				return this.m_owner.CanUseRegret();
			}

			// Token: 0x0600BAE6 RID: 47846 RVA: 0x00347AF8 File Offset: 0x00345CF8
			public void RegretGotoStep(int step)
			{
				this.m_owner.RegretGotoStep(step);
			}

			// Token: 0x0600BAE7 RID: 47847 RVA: 0x00347B08 File Offset: 0x00345D08
			public int FindRegretStepIndex(int step)
			{
				return this.m_owner.FindRegretStepIndex(step);
			}

			// Token: 0x0600BAE8 RID: 47848 RVA: 0x00347B18 File Offset: 0x00345D18
			public void BattleUIController_OnRegretActive()
			{
				this.m_owner.BattleUIController_OnRegretActive();
			}

			// Token: 0x0600BAE9 RID: 47849 RVA: 0x00347B28 File Offset: 0x00345D28
			public void BattleUIController_OnRegretConfirm()
			{
				this.m_owner.BattleUIController_OnRegretConfirm();
			}

			// Token: 0x0600BAEA RID: 47850 RVA: 0x00347B38 File Offset: 0x00345D38
			public void BattleUIController_OnRegretCancel()
			{
				this.m_owner.BattleUIController_OnRegretCancel();
			}

			// Token: 0x0600BAEB RID: 47851 RVA: 0x00347B48 File Offset: 0x00345D48
			public void BattleUIController_OnRegretBackward()
			{
				this.m_owner.BattleUIController_OnRegretBackward();
			}

			// Token: 0x0600BAEC RID: 47852 RVA: 0x00347B58 File Offset: 0x00345D58
			public void BattleUIController_OnRegretForward()
			{
				this.m_owner.BattleUIController_OnRegretForward();
			}

			// Token: 0x0600BAED RID: 47853 RVA: 0x00347B68 File Offset: 0x00345D68
			public List<int> UserGuide_GetEnforceHeros()
			{
				return this.m_owner.UserGuide_GetEnforceHeros();
			}

			// Token: 0x0600BAEE RID: 47854 RVA: 0x00347B78 File Offset: 0x00345D78
			public void SetUserGuideBattleSettings()
			{
				this.m_owner.SetUserGuideBattleSettings();
			}

			// Token: 0x040077FE RID: 30718
			private BattleUITask m_owner;
		}
	}
}
