using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008C6 RID: 2246
	[HotFix]
	public class LevelComponent : LevelComponentCommon
	{
		// Token: 0x0600729E RID: 29342 RVA: 0x001FB998 File Offset: 0x001F9B98
		public LevelComponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x001FBA00 File Offset: 0x001F9C00
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x001FBA7C File Offset: 0x001F9C7C
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x001FBAE4 File Offset: 0x001F9CE4
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x001FBB4C File Offset: 0x001F9D4C
		public override void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x001FBBC4 File Offset: 0x001F9DC4
		public void DeSerialize(DSLevelNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSLevelNtf_hotfix != null)
			{
				this.m_DeSerializeDSLevelNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelDS.ClearInitedData();
			this.m_levelDS.SetCurrentWayPoint(msg.CurrentWayPointId);
			this.m_levelDS.SetScenario(msg.ScenarioId);
			base.InitLevelInfo(msg.ArrivedWayPointIds);
			base.InitRandomEvents(RandomEvent.PBRandomEventsToRandomEvents(msg.RandomEvents));
			this.m_levelDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x001FBC98 File Offset: 0x001F9E98
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.ClientVersion;
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x001FBD10 File Offset: 0x001F9F10
		protected override int HandleDialogEvent(ConfigDataWaypointInfo wayPointInfo, List<Goods> itemRewards, int playerExpReward, int goldReward, int energyCost, int scenarioId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleDialogEventConfigDataWaypointInfoList`1Int32Int32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleDialogEventConfigDataWaypointInfoList`1Int32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					wayPointInfo,
					itemRewards,
					playerExpReward,
					goldReward,
					energyCost,
					scenarioId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.AddPlayerExp(playerExpReward);
			this.m_basicInfo.AddGold(goldReward, GameFunctionType.GameFunctionType_None, null);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = playerExpReward;
			battleReward.HeroExp = 0;
			battleReward.Gold = goldReward;
			return 0;
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x001FBE24 File Offset: 0x001FA024
		public override int CanAttackScenario(ConfigDataScenarioInfo secenarioInfo, bool scenarioFinished, bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix.call(new object[]
				{
					this,
					secenarioInfo,
					scenarioFinished,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanUnLockScenario(secenarioInfo);
			if (num != 0)
			{
				return num;
			}
			int waypoint_ID = secenarioInfo.Waypoint_ID;
			num = base.CanMoveToWayPoint(waypoint_ID);
			if (num != 0)
			{
				return num;
			}
			scenarioFinished = base.IsScenarioFinished(secenarioInfo);
			return base.CanAttackScenario(secenarioInfo, scenarioFinished, checkBag);
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x001FBEFC File Offset: 0x001FA0FC
		public int CanAttackScenario(ConfigDataScenarioInfo secenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackScenarioConfigDataScenarioInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					secenarioInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool scenarioFinished = base.IsScenarioFinished(secenarioInfo);
			return this.CanAttackScenario(secenarioInfo, scenarioFinished, true);
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x001FBF8C File Offset: 0x001FA18C
		public int CanAttackEventWayPoint(ConfigDataWaypointInfo wayPointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackEventWayPointConfigDataWaypointInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackEventWayPointConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					wayPointInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int eventId = base.GetEventId(wayPointInfo);
			ConfigDataEventInfo configDataEventInfo = this.m_configDataLoader.GetConfigDataEventInfo(eventId);
			return base.CanAttackEventWayPoint(wayPointInfo.ID, configDataEventInfo);
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x001FC02C File Offset: 0x001FA22C
		protected override int HandleTresureEvent(int wayPointId, ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleTresureEventInt32ConfigDataEventInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleTresureEventInt32ConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					wayPointId,
					eventInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.AddPlayerExp(eventInfo.PlayerExpReward);
			this.m_basicInfo.AddGold(eventInfo.GoldReward, GameFunctionType.GameFunctionType_None, null);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = eventInfo.PlayerExpReward;
			battleReward.HeroExp = 0;
			battleReward.Gold = eventInfo.GoldReward;
			return 0;
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x001FC110 File Offset: 0x001FA310
		public override void SetBattleWayPointSuccessful(ConfigDataWaypointInfo wayPointInfo, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleWayPointSuccessfulConfigDataWaypointInfoList`1_hotfix != null)
			{
				this.m_SetBattleWayPointSuccessfulConfigDataWaypointInfoList`1_hotfix.call(new object[]
				{
					this,
					wayPointInfo,
					battleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(battleTreasures);
			int playerExpReward;
			int heroExpReward;
			int goldReward;
			int battle_ID;
			if (wayPointInfo.FuncType == WaypointFuncType.WaypointFuncType_Scenario)
			{
				int processingScenarioId = this.m_battle.ProcessingScenarioId;
				ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(processingScenarioId);
				if (base.IsScenarioFinished(configDataScenarioInfo))
				{
					this.m_basicInfo.DecreaseEnergy(configDataScenarioInfo.EnergySuccess - configDataScenarioInfo.EnergyFail, GameFunctionType.GameFunctionType_Scenario, processingScenarioId.ToString());
				}
				playerExpReward = configDataScenarioInfo.PlayerExpReward;
				heroExpReward = configDataScenarioInfo.HeroExpReward;
				goldReward = configDataScenarioInfo.GoldReward;
				battle_ID = configDataScenarioInfo.Battle_ID;
				this.SetFinishedScenario(configDataScenarioInfo);
			}
			else
			{
				RandomEvent randomEvent = null;
				int key;
				if (base.IsSetRandomEvent(wayPointInfo.ID))
				{
					randomEvent = base.GetRandomEvent(wayPointInfo.ID);
					key = randomEvent.EventId;
				}
				else
				{
					key = wayPointInfo.FuncTypeParam1;
				}
				base.OnEventComplete(wayPointInfo.ID, randomEvent);
				ConfigDataEventInfo configDataEventInfo = this.m_configDataLoader.GetConfigDataEventInfo(key);
				this.m_basicInfo.DecreaseEnergy(configDataEventInfo.EnergySuccess - configDataEventInfo.EnergyFail, GameFunctionType.GameFunctionType_Event, key.ToString());
				playerExpReward = configDataEventInfo.PlayerExpReward;
				heroExpReward = configDataEventInfo.HeroExpReward;
				goldReward = configDataEventInfo.GoldReward;
				battle_ID = configDataEventInfo.Battle_ID;
			}
			this.m_basicInfo.AddPlayerExp(playerExpReward);
			this.m_basicInfo.AddGold(goldReward, GameFunctionType.GameFunctionType_None, null);
			List<int> pveTeam = this.m_battle.GetPveTeam();
			this.m_battle.AddFightHeroFightNumsAndExp(pveTeam, heroExpReward);
			this.m_battle.WinPveBattle(battle_ID);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = playerExpReward;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(heroExpReward);
			battleReward.Gold = goldReward;
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x001FC348 File Offset: 0x001FA548
		public bool IsRegionOpen(int regionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRegionOpenInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRegionOpenInt32_hotfix.call(new object[]
				{
					this,
					regionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.IsRegionOpen(this.m_configDataLoader.GetConfigDataRegionInfo(regionId));
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x001FC3D8 File Offset: 0x001FA5D8
		public WayPointStatus GetWaypointStatus(int waypointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWaypointStatusInt32_hotfix != null)
			{
				return (WayPointStatus)this.m_GetWaypointStatusInt32_hotfix.call(new object[]
				{
					this,
					waypointId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(waypointId);
			if (configDataWaypointInfo == null || configDataWaypointInfo.m_regionInfo == null)
			{
				return WayPointStatus.Close;
			}
			WayPointStatus wayPointStatus;
			if (this.m_levelDS.CanMoveWayPointIds.TryGetValue(waypointId, out wayPointStatus))
			{
				if ((wayPointStatus & WayPointStatus.Arrived) != WayPointStatus.None)
				{
					return WayPointStatus.Arrived;
				}
				if (configDataWaypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Scenario)
				{
					ConfigDataScenarioInfo lastFinishedScenarioInfo = this.GetLastFinishedScenarioInfo();
					if (lastFinishedScenarioInfo != null)
					{
						ConfigDataScenarioInfo nextScenarioInfo = lastFinishedScenarioInfo.m_nextScenarioInfo;
						if (nextScenarioInfo != null && !nextScenarioInfo.IsOpened && nextScenarioInfo.Waypoint_ID == waypointId)
						{
							return WayPointStatus.Open;
						}
					}
				}
				return WayPointStatus.Public;
			}
			else
			{
				if (!base.IsRegionOpen(configDataWaypointInfo.m_regionInfo))
				{
					return WayPointStatus.Close;
				}
				return WayPointStatus.Open;
			}
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x001FC4EC File Offset: 0x001FA6EC
		public ConfigDataWaypointInfo GetPlayerCurrentWaypointInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerCurrentWaypointInfo_hotfix != null)
			{
				return (ConfigDataWaypointInfo)this.m_GetPlayerCurrentWaypointInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.CurrentWaypointInfo;
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x001FC564 File Offset: 0x001FA764
		public ConfigDataScenarioInfo GetLastFinishedScenarioInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastFinishedScenarioInfo_hotfix != null)
			{
				return (ConfigDataScenarioInfo)this.m_GetLastFinishedScenarioInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.LastFinishedScenarioInfo;
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x001FC5DC File Offset: 0x001FA7DC
		public override void SetFinishedScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFinishedScenarioConfigDataScenarioInfo_hotfix != null)
			{
				this.m_SetFinishedScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.SetFinishedScenario(scenarioInfo);
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x001FC654 File Offset: 0x001FA854
		public int FinishBattleWayPoint(int wayPointId, bool isWin, int result, List<int> battleTreasureIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishBattleWayPointInt32BooleanInt32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishBattleWayPointInt32BooleanInt32List`1_hotfix.call(new object[]
				{
					this,
					wayPointId,
					isWin,
					result,
					battleTreasureIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(wayPointId);
			if (result == 0 && isWin)
			{
				this.SetBattleWayPointSuccessful(configDataWaypointInfo, battleTreasureIds);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return result;
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x060072B1 RID: 29361 RVA: 0x001FC734 File Offset: 0x001FA934
		// (set) Token: 0x060072B2 RID: 29362 RVA: 0x001FC754 File Offset: 0x001FA954
		[DoNotToLua]
		public new LevelComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LevelComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x001FC760 File Offset: 0x001FA960
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x001FC768 File Offset: 0x001FA968
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x001FC770 File Offset: 0x001FA970
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x001FC778 File Offset: 0x001FA978
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x001FC780 File Offset: 0x001FA980
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x001FC78C File Offset: 0x001FA98C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x001FC794 File Offset: 0x001FA994
		private bool __callBase_IsWayPointArrived(int wayPointId)
		{
			return base.IsWayPointArrived(wayPointId);
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x001FC7A0 File Offset: 0x001FA9A0
		private void __callBase_OutPutRandomEventOperateLog(int eventId, RandomEventStatus status, List<Goods> rewards)
		{
			base.OutPutRandomEventOperateLog(eventId, status, rewards);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x001FC7AC File Offset: 0x001FA9AC
		private void __callBase_InitLevelInfo(List<int> arrivedWayPoints)
		{
			base.InitLevelInfo(arrivedWayPoints);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x001FC7B8 File Offset: 0x001FA9B8
		private void __callBase_SetArrivedWayPoint(int wayPointId)
		{
			base.SetArrivedWayPoint(wayPointId);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x001FC7C4 File Offset: 0x001FA9C4
		private void __callBase_ArriveWayPoint(int wayPointId)
		{
			base.ArriveWayPoint(wayPointId);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x001FC7D0 File Offset: 0x001FA9D0
		private bool __callBase_HasFirstWayPointWithScenario()
		{
			return base.HasFirstWayPointWithScenario();
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x001FC7D8 File Offset: 0x001FA9D8
		private void __callBase_AddCanMovePublicWayPoint(int newId)
		{
			base.AddCanMovePublicWayPoint(newId);
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x001FC7E4 File Offset: 0x001FA9E4
		private void __callBase_SetFinishedScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			base.SetFinishedScenario(scenarioInfo);
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x001FC7F0 File Offset: 0x001FA9F0
		private int __callBase_GetLastFinishedScenarioId()
		{
			return base.GetLastFinishedScenarioId();
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x001FC7F8 File Offset: 0x001FA9F8
		private bool __callBase_IsScenarioCompleted(int scenarioId)
		{
			return base.IsScenarioCompleted(scenarioId);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x001FC804 File Offset: 0x001FAA04
		private int __callBase_GetScenarioId()
		{
			return base.GetScenarioId();
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x001FC80C File Offset: 0x001FAA0C
		private void __callBase_SetBattleWayPointSuccessful(ConfigDataWaypointInfo wayPointInfo, List<int> battleTreasures)
		{
			base.SetBattleWayPointSuccessful(wayPointInfo, battleTreasures);
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x001FC818 File Offset: 0x001FAA18
		private bool __callBase_IsSetRandomEvent(int wayPointId)
		{
			return base.IsSetRandomEvent(wayPointId);
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x001FC824 File Offset: 0x001FAA24
		private int __callBase_MoveToWayPoint(int waypointId)
		{
			return base.MoveToWayPoint(waypointId);
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x001FC830 File Offset: 0x001FAA30
		private int __callBase_HandleWayPoint(ConfigDataWaypointInfo wayPointInfo)
		{
			return base.HandleWayPoint(wayPointInfo);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x001FC83C File Offset: 0x001FAA3C
		private void __callBase_InitRandomEvents(List<RandomEvent> randomEvents)
		{
			base.InitRandomEvents(randomEvents);
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x001FC848 File Offset: 0x001FAA48
		private long __callBase_GetEventExpiredTime(int eventId)
		{
			return base.GetEventExpiredTime(eventId);
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x001FC854 File Offset: 0x001FAA54
		private int __callBase_GetEventLives(int eventId)
		{
			return base.GetEventLives(eventId);
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x001FC860 File Offset: 0x001FAA60
		private bool __callBase_IsRandomEventTimeOut(RandomEvent randomEvent)
		{
			return base.IsRandomEventTimeOut(randomEvent);
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x001FC86C File Offset: 0x001FAA6C
		private bool __callBase_IsRandomEventDead(RandomEvent randomEvent)
		{
			return base.IsRandomEventDead(randomEvent);
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x001FC878 File Offset: 0x001FAA78
		private void __callBase_RemoveRandomEvent(RandomEvent randomEvent)
		{
			base.RemoveRandomEvent(randomEvent);
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x001FC884 File Offset: 0x001FAA84
		private void __callBase_AddRandomEvent(RandomEvent randomEvent)
		{
			base.AddRandomEvent(randomEvent);
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x001FC890 File Offset: 0x001FAA90
		private int __callBase_CanUnLockScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			return base.CanUnLockScenario(scenarioInfo);
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x001FC89C File Offset: 0x001FAA9C
		private int __callBase_HandleScenario(int scenarioId, bool checkBag)
		{
			return base.HandleScenario(scenarioId, checkBag);
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x001FC8A8 File Offset: 0x001FAAA8
		private bool __callBase_IsScenarioFinished(ConfigDataScenarioInfo secenarioInfo)
		{
			return base.IsScenarioFinished(secenarioInfo);
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x001FC8B4 File Offset: 0x001FAAB4
		private bool __callBase_IsScenarioFinished(int scenarioId)
		{
			return base.IsScenarioFinished(scenarioId);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x001FC8C0 File Offset: 0x001FAAC0
		private bool __callBase_IsScenarioInWaypoint(int waypointId)
		{
			return base.IsScenarioInWaypoint(waypointId);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x001FC8CC File Offset: 0x001FAACC
		private RandomEvent __callBase_GetRandomEvent(int wayPointId)
		{
			return base.GetRandomEvent(wayPointId);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x001FC8D8 File Offset: 0x001FAAD8
		private int __callBase_GetEventId(ConfigDataWaypointInfo wayPointInfo)
		{
			return base.GetEventId(wayPointInfo);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x001FC8E4 File Offset: 0x001FAAE4
		private int __callBase_CheckGameFunctionOpenByGM(GameFunctionType gameFunctionTypeId)
		{
			return base.CheckGameFunctionOpenByGM(gameFunctionTypeId);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x001FC8F0 File Offset: 0x001FAAF0
		private void __callBase_OnEventComplete(int wayPointId, RandomEvent randomEvent)
		{
			base.OnEventComplete(wayPointId, randomEvent);
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x001FC8FC File Offset: 0x001FAAFC
		private int __callBase_HandleDialogEvent(ConfigDataWaypointInfo wayPointInfo, List<Goods> itemRewards, int expReward, int goldReward, int energyCost, int scenarioId)
		{
			return base.HandleDialogEvent(wayPointInfo, itemRewards, expReward, goldReward, energyCost, scenarioId);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x001FC910 File Offset: 0x001FAB10
		private int __callBase_HandleTresureEvent(int wayPointId, ConfigDataEventInfo eventInfo)
		{
			return base.HandleTresureEvent(wayPointId, eventInfo);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x001FC91C File Offset: 0x001FAB1C
		private List<Goods> __callBase_GetEventRewards(ConfigDataEventInfo eventInfo)
		{
			return base.GetEventRewards(eventInfo);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x001FC928 File Offset: 0x001FAB28
		private int __callBase_CanAttackScenario(ConfigDataScenarioInfo scenarioInfo, bool scenarioFinished, bool checkBag)
		{
			return base.CanAttackScenario(scenarioInfo, scenarioFinished, checkBag);
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x001FC934 File Offset: 0x001FAB34
		private int __callBase_CanAttackEventWayPoint(int wayPointdId, ConfigDataEventInfo eventyInfo)
		{
			return base.CanAttackEventWayPoint(wayPointdId, eventyInfo);
		}

		// Token: 0x060072DD RID: 29405 RVA: 0x001FC940 File Offset: 0x001FAB40
		private int __callBase_CanMoveToWayPoint(int destWayPointId)
		{
			return base.CanMoveToWayPoint(destWayPointId);
		}

		// Token: 0x060072DE RID: 29406 RVA: 0x001FC94C File Offset: 0x001FAB4C
		private int __callBase_CanMoveToWayPointExistRandomEvent(int destWayPointId)
		{
			return base.CanMoveToWayPointExistRandomEvent(destWayPointId);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x001FC958 File Offset: 0x001FAB58
		private void __callBase_OnCompleteWayPointEvent()
		{
			base.OnCompleteWayPointEvent();
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x001FC960 File Offset: 0x001FAB60
		private bool __callBase_IsRegionOpen(ConfigDataRegionInfo regionInfo)
		{
			return base.IsRegionOpen(regionInfo);
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x001FC96C File Offset: 0x001FAB6C
		private void __callBase_OnOpenRegion(ConfigDataRegionInfo regionInfo)
		{
			base.OnOpenRegion(regionInfo);
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x001FC978 File Offset: 0x001FAB78
		private WayPointStatus __callBase_GetWayPointStatus(int wayPointId)
		{
			return base.GetWayPointStatus(wayPointId);
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x001FC984 File Offset: 0x001FAB84
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_DeSerializeDSLevelNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_HandleDialogEventConfigDataWaypointInfoList`1Int32Int32Int32Int32_hotfix = (luaObj.RawGet("HandleDialogEvent") as LuaFunction);
					this.m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix = (luaObj.RawGet("CanAttackScenario") as LuaFunction);
					this.m_CanAttackScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("CanAttackScenario") as LuaFunction);
					this.m_CanAttackEventWayPointConfigDataWaypointInfo_hotfix = (luaObj.RawGet("CanAttackEventWayPoint") as LuaFunction);
					this.m_HandleTresureEventInt32ConfigDataEventInfo_hotfix = (luaObj.RawGet("HandleTresureEvent") as LuaFunction);
					this.m_SetBattleWayPointSuccessfulConfigDataWaypointInfoList`1_hotfix = (luaObj.RawGet("SetBattleWayPointSuccessful") as LuaFunction);
					this.m_IsRegionOpenInt32_hotfix = (luaObj.RawGet("IsRegionOpen") as LuaFunction);
					this.m_GetWaypointStatusInt32_hotfix = (luaObj.RawGet("GetWaypointStatus") as LuaFunction);
					this.m_GetPlayerCurrentWaypointInfo_hotfix = (luaObj.RawGet("GetPlayerCurrentWaypointInfo") as LuaFunction);
					this.m_GetLastFinishedScenarioInfo_hotfix = (luaObj.RawGet("GetLastFinishedScenarioInfo") as LuaFunction);
					this.m_SetFinishedScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("SetFinishedScenario") as LuaFunction);
					this.m_FinishBattleWayPointInt32BooleanInt32List`1_hotfix = (luaObj.RawGet("FinishBattleWayPoint") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x001FCC14 File Offset: 0x001FAE14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400554A RID: 21834
		[DoNotToLua]
		private LevelComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400554B RID: 21835
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400554C RID: 21836
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400554D RID: 21837
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400554E RID: 21838
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400554F RID: 21839
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005550 RID: 21840
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005551 RID: 21841
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04005552 RID: 21842
		private LuaFunction m_DeSerializeDSLevelNtf_hotfix;

		// Token: 0x04005553 RID: 21843
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005554 RID: 21844
		private LuaFunction m_HandleDialogEventConfigDataWaypointInfoList;

		// Token: 0x04005555 RID: 21845
		private LuaFunction m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix;

		// Token: 0x04005556 RID: 21846
		private LuaFunction m_CanAttackScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x04005557 RID: 21847
		private LuaFunction m_CanAttackEventWayPointConfigDataWaypointInfo_hotfix;

		// Token: 0x04005558 RID: 21848
		private LuaFunction m_HandleTresureEventInt32ConfigDataEventInfo_hotfix;

		// Token: 0x04005559 RID: 21849
		private LuaFunction m_SetBattleWayPointSuccessfulConfigDataWaypointInfoList;

		// Token: 0x0400555A RID: 21850
		private LuaFunction m_IsRegionOpenInt32_hotfix;

		// Token: 0x0400555B RID: 21851
		private LuaFunction m_GetWaypointStatusInt32_hotfix;

		// Token: 0x0400555C RID: 21852
		private LuaFunction m_GetPlayerCurrentWaypointInfo_hotfix;

		// Token: 0x0400555D RID: 21853
		private LuaFunction m_GetLastFinishedScenarioInfo_hotfix;

		// Token: 0x0400555E RID: 21854
		private LuaFunction m_SetFinishedScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x0400555F RID: 21855
		private LuaFunction m_FinishBattleWayPointInt32BooleanInt32List;

		// Token: 0x020008C7 RID: 2247
		public new class LuaExportHelper
		{
			// Token: 0x060072E5 RID: 29413 RVA: 0x001FCC7C File Offset: 0x001FAE7C
			public LuaExportHelper(LevelComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060072E6 RID: 29414 RVA: 0x001FCC8C File Offset: 0x001FAE8C
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060072E7 RID: 29415 RVA: 0x001FCC9C File Offset: 0x001FAE9C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060072E8 RID: 29416 RVA: 0x001FCCAC File Offset: 0x001FAEAC
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060072E9 RID: 29417 RVA: 0x001FCCBC File Offset: 0x001FAEBC
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060072EA RID: 29418 RVA: 0x001FCCCC File Offset: 0x001FAECC
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060072EB RID: 29419 RVA: 0x001FCCDC File Offset: 0x001FAEDC
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060072EC RID: 29420 RVA: 0x001FCCEC File Offset: 0x001FAEEC
			public bool __callBase_IsWayPointArrived(int wayPointId)
			{
				return this.m_owner.__callBase_IsWayPointArrived(wayPointId);
			}

			// Token: 0x060072ED RID: 29421 RVA: 0x001FCCFC File Offset: 0x001FAEFC
			public void __callBase_OutPutRandomEventOperateLog(int eventId, RandomEventStatus status, List<Goods> rewards)
			{
				this.m_owner.__callBase_OutPutRandomEventOperateLog(eventId, status, rewards);
			}

			// Token: 0x060072EE RID: 29422 RVA: 0x001FCD0C File Offset: 0x001FAF0C
			public void __callBase_InitLevelInfo(List<int> arrivedWayPoints)
			{
				this.m_owner.__callBase_InitLevelInfo(arrivedWayPoints);
			}

			// Token: 0x060072EF RID: 29423 RVA: 0x001FCD1C File Offset: 0x001FAF1C
			public void __callBase_SetArrivedWayPoint(int wayPointId)
			{
				this.m_owner.__callBase_SetArrivedWayPoint(wayPointId);
			}

			// Token: 0x060072F0 RID: 29424 RVA: 0x001FCD2C File Offset: 0x001FAF2C
			public void __callBase_ArriveWayPoint(int wayPointId)
			{
				this.m_owner.__callBase_ArriveWayPoint(wayPointId);
			}

			// Token: 0x060072F1 RID: 29425 RVA: 0x001FCD3C File Offset: 0x001FAF3C
			public bool __callBase_HasFirstWayPointWithScenario()
			{
				return this.m_owner.__callBase_HasFirstWayPointWithScenario();
			}

			// Token: 0x060072F2 RID: 29426 RVA: 0x001FCD4C File Offset: 0x001FAF4C
			public void __callBase_AddCanMovePublicWayPoint(int newId)
			{
				this.m_owner.__callBase_AddCanMovePublicWayPoint(newId);
			}

			// Token: 0x060072F3 RID: 29427 RVA: 0x001FCD5C File Offset: 0x001FAF5C
			public void __callBase_SetFinishedScenario(ConfigDataScenarioInfo scenarioInfo)
			{
				this.m_owner.__callBase_SetFinishedScenario(scenarioInfo);
			}

			// Token: 0x060072F4 RID: 29428 RVA: 0x001FCD6C File Offset: 0x001FAF6C
			public int __callBase_GetLastFinishedScenarioId()
			{
				return this.m_owner.__callBase_GetLastFinishedScenarioId();
			}

			// Token: 0x060072F5 RID: 29429 RVA: 0x001FCD7C File Offset: 0x001FAF7C
			public bool __callBase_IsScenarioCompleted(int scenarioId)
			{
				return this.m_owner.__callBase_IsScenarioCompleted(scenarioId);
			}

			// Token: 0x060072F6 RID: 29430 RVA: 0x001FCD8C File Offset: 0x001FAF8C
			public int __callBase_GetScenarioId()
			{
				return this.m_owner.__callBase_GetScenarioId();
			}

			// Token: 0x060072F7 RID: 29431 RVA: 0x001FCD9C File Offset: 0x001FAF9C
			public void __callBase_SetBattleWayPointSuccessful(ConfigDataWaypointInfo wayPointInfo, List<int> battleTreasures)
			{
				this.m_owner.__callBase_SetBattleWayPointSuccessful(wayPointInfo, battleTreasures);
			}

			// Token: 0x060072F8 RID: 29432 RVA: 0x001FCDAC File Offset: 0x001FAFAC
			public bool __callBase_IsSetRandomEvent(int wayPointId)
			{
				return this.m_owner.__callBase_IsSetRandomEvent(wayPointId);
			}

			// Token: 0x060072F9 RID: 29433 RVA: 0x001FCDBC File Offset: 0x001FAFBC
			public int __callBase_MoveToWayPoint(int waypointId)
			{
				return this.m_owner.__callBase_MoveToWayPoint(waypointId);
			}

			// Token: 0x060072FA RID: 29434 RVA: 0x001FCDCC File Offset: 0x001FAFCC
			public int __callBase_HandleWayPoint(ConfigDataWaypointInfo wayPointInfo)
			{
				return this.m_owner.__callBase_HandleWayPoint(wayPointInfo);
			}

			// Token: 0x060072FB RID: 29435 RVA: 0x001FCDDC File Offset: 0x001FAFDC
			public void __callBase_InitRandomEvents(List<RandomEvent> randomEvents)
			{
				this.m_owner.__callBase_InitRandomEvents(randomEvents);
			}

			// Token: 0x060072FC RID: 29436 RVA: 0x001FCDEC File Offset: 0x001FAFEC
			public long __callBase_GetEventExpiredTime(int eventId)
			{
				return this.m_owner.__callBase_GetEventExpiredTime(eventId);
			}

			// Token: 0x060072FD RID: 29437 RVA: 0x001FCDFC File Offset: 0x001FAFFC
			public int __callBase_GetEventLives(int eventId)
			{
				return this.m_owner.__callBase_GetEventLives(eventId);
			}

			// Token: 0x060072FE RID: 29438 RVA: 0x001FCE0C File Offset: 0x001FB00C
			public bool __callBase_IsRandomEventTimeOut(RandomEvent randomEvent)
			{
				return this.m_owner.__callBase_IsRandomEventTimeOut(randomEvent);
			}

			// Token: 0x060072FF RID: 29439 RVA: 0x001FCE1C File Offset: 0x001FB01C
			public bool __callBase_IsRandomEventDead(RandomEvent randomEvent)
			{
				return this.m_owner.__callBase_IsRandomEventDead(randomEvent);
			}

			// Token: 0x06007300 RID: 29440 RVA: 0x001FCE2C File Offset: 0x001FB02C
			public void __callBase_RemoveRandomEvent(RandomEvent randomEvent)
			{
				this.m_owner.__callBase_RemoveRandomEvent(randomEvent);
			}

			// Token: 0x06007301 RID: 29441 RVA: 0x001FCE3C File Offset: 0x001FB03C
			public void __callBase_AddRandomEvent(RandomEvent randomEvent)
			{
				this.m_owner.__callBase_AddRandomEvent(randomEvent);
			}

			// Token: 0x06007302 RID: 29442 RVA: 0x001FCE4C File Offset: 0x001FB04C
			public int __callBase_CanUnLockScenario(ConfigDataScenarioInfo scenarioInfo)
			{
				return this.m_owner.__callBase_CanUnLockScenario(scenarioInfo);
			}

			// Token: 0x06007303 RID: 29443 RVA: 0x001FCE5C File Offset: 0x001FB05C
			public int __callBase_HandleScenario(int scenarioId, bool checkBag)
			{
				return this.m_owner.__callBase_HandleScenario(scenarioId, checkBag);
			}

			// Token: 0x06007304 RID: 29444 RVA: 0x001FCE6C File Offset: 0x001FB06C
			public bool __callBase_IsScenarioFinished(ConfigDataScenarioInfo secenarioInfo)
			{
				return this.m_owner.__callBase_IsScenarioFinished(secenarioInfo);
			}

			// Token: 0x06007305 RID: 29445 RVA: 0x001FCE7C File Offset: 0x001FB07C
			public bool __callBase_IsScenarioFinished(int scenarioId)
			{
				return this.m_owner.__callBase_IsScenarioFinished(scenarioId);
			}

			// Token: 0x06007306 RID: 29446 RVA: 0x001FCE8C File Offset: 0x001FB08C
			public bool __callBase_IsScenarioInWaypoint(int waypointId)
			{
				return this.m_owner.__callBase_IsScenarioInWaypoint(waypointId);
			}

			// Token: 0x06007307 RID: 29447 RVA: 0x001FCE9C File Offset: 0x001FB09C
			public RandomEvent __callBase_GetRandomEvent(int wayPointId)
			{
				return this.m_owner.__callBase_GetRandomEvent(wayPointId);
			}

			// Token: 0x06007308 RID: 29448 RVA: 0x001FCEAC File Offset: 0x001FB0AC
			public int __callBase_GetEventId(ConfigDataWaypointInfo wayPointInfo)
			{
				return this.m_owner.__callBase_GetEventId(wayPointInfo);
			}

			// Token: 0x06007309 RID: 29449 RVA: 0x001FCEBC File Offset: 0x001FB0BC
			public int __callBase_CheckGameFunctionOpenByGM(GameFunctionType gameFunctionTypeId)
			{
				return this.m_owner.__callBase_CheckGameFunctionOpenByGM(gameFunctionTypeId);
			}

			// Token: 0x0600730A RID: 29450 RVA: 0x001FCECC File Offset: 0x001FB0CC
			public void __callBase_OnEventComplete(int wayPointId, RandomEvent randomEvent)
			{
				this.m_owner.__callBase_OnEventComplete(wayPointId, randomEvent);
			}

			// Token: 0x0600730B RID: 29451 RVA: 0x001FCEDC File Offset: 0x001FB0DC
			public int __callBase_HandleDialogEvent(ConfigDataWaypointInfo wayPointInfo, List<Goods> itemRewards, int expReward, int goldReward, int energyCost, int scenarioId)
			{
				return this.m_owner.__callBase_HandleDialogEvent(wayPointInfo, itemRewards, expReward, goldReward, energyCost, scenarioId);
			}

			// Token: 0x0600730C RID: 29452 RVA: 0x001FCEF4 File Offset: 0x001FB0F4
			public int __callBase_HandleTresureEvent(int wayPointId, ConfigDataEventInfo eventInfo)
			{
				return this.m_owner.__callBase_HandleTresureEvent(wayPointId, eventInfo);
			}

			// Token: 0x0600730D RID: 29453 RVA: 0x001FCF04 File Offset: 0x001FB104
			public List<Goods> __callBase_GetEventRewards(ConfigDataEventInfo eventInfo)
			{
				return this.m_owner.__callBase_GetEventRewards(eventInfo);
			}

			// Token: 0x0600730E RID: 29454 RVA: 0x001FCF14 File Offset: 0x001FB114
			public int __callBase_CanAttackScenario(ConfigDataScenarioInfo scenarioInfo, bool scenarioFinished, bool checkBag)
			{
				return this.m_owner.__callBase_CanAttackScenario(scenarioInfo, scenarioFinished, checkBag);
			}

			// Token: 0x0600730F RID: 29455 RVA: 0x001FCF24 File Offset: 0x001FB124
			public int __callBase_CanAttackEventWayPoint(int wayPointdId, ConfigDataEventInfo eventyInfo)
			{
				return this.m_owner.__callBase_CanAttackEventWayPoint(wayPointdId, eventyInfo);
			}

			// Token: 0x06007310 RID: 29456 RVA: 0x001FCF34 File Offset: 0x001FB134
			public int __callBase_CanMoveToWayPoint(int destWayPointId)
			{
				return this.m_owner.__callBase_CanMoveToWayPoint(destWayPointId);
			}

			// Token: 0x06007311 RID: 29457 RVA: 0x001FCF44 File Offset: 0x001FB144
			public int __callBase_CanMoveToWayPointExistRandomEvent(int destWayPointId)
			{
				return this.m_owner.__callBase_CanMoveToWayPointExistRandomEvent(destWayPointId);
			}

			// Token: 0x06007312 RID: 29458 RVA: 0x001FCF54 File Offset: 0x001FB154
			public void __callBase_OnCompleteWayPointEvent()
			{
				this.m_owner.__callBase_OnCompleteWayPointEvent();
			}

			// Token: 0x06007313 RID: 29459 RVA: 0x001FCF64 File Offset: 0x001FB164
			public bool __callBase_IsRegionOpen(ConfigDataRegionInfo regionInfo)
			{
				return this.m_owner.__callBase_IsRegionOpen(regionInfo);
			}

			// Token: 0x06007314 RID: 29460 RVA: 0x001FCF74 File Offset: 0x001FB174
			public void __callBase_OnOpenRegion(ConfigDataRegionInfo regionInfo)
			{
				this.m_owner.__callBase_OnOpenRegion(regionInfo);
			}

			// Token: 0x06007315 RID: 29461 RVA: 0x001FCF84 File Offset: 0x001FB184
			public WayPointStatus __callBase_GetWayPointStatus(int wayPointId)
			{
				return this.m_owner.__callBase_GetWayPointStatus(wayPointId);
			}

			// Token: 0x06007316 RID: 29462 RVA: 0x001FCF94 File Offset: 0x001FB194
			public int HandleDialogEvent(ConfigDataWaypointInfo wayPointInfo, List<Goods> itemRewards, int playerExpReward, int goldReward, int energyCost, int scenarioId)
			{
				return this.m_owner.HandleDialogEvent(wayPointInfo, itemRewards, playerExpReward, goldReward, energyCost, scenarioId);
			}

			// Token: 0x06007317 RID: 29463 RVA: 0x001FCFAC File Offset: 0x001FB1AC
			public int HandleTresureEvent(int wayPointId, ConfigDataEventInfo eventInfo)
			{
				return this.m_owner.HandleTresureEvent(wayPointId, eventInfo);
			}

			// Token: 0x04005560 RID: 21856
			private LevelComponent m_owner;
		}
	}
}
