using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200047F RID: 1151
	[HotFix]
	public class LevelComponentCommon : IComponentBase
	{
		// Token: 0x060043AA RID: 17322 RVA: 0x00144F20 File Offset: 0x00143120
		public LevelComponentCommon()
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

		// Token: 0x060043AB RID: 17323 RVA: 0x00144F94 File Offset: 0x00143194
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Level";
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00145008 File Offset: 0x00143208
		public virtual void Init()
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
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00145068 File Offset: 0x00143268
		public virtual void PostInit()
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00145150 File Offset: 0x00143350
		public virtual void DeInit()
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
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x001451B0 File Offset: 0x001433B0
		public virtual void Tick(uint deltaMillisecond)
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
			if (this.m_levelDS.RandomEvents.Count == 0 || this.m_battle.IsWaypointBattling())
			{
				return;
			}
			List<RandomEvent> list = null;
			foreach (RandomEvent randomEvent in this.m_levelDS.RandomEvents)
			{
				if (!this.IsRandomEventTimeOut(randomEvent))
				{
					break;
				}
				if (list == null)
				{
					list = new List<RandomEvent>();
				}
				list.Add(randomEvent);
			}
			if (list != null)
			{
				foreach (RandomEvent randomEvent2 in list)
				{
					this.RemoveRandomEvent(randomEvent2);
					this.OutPutRandomEventOperateLog(randomEvent2.EventId, RandomEventStatus.OutTime, null);
				}
			}
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00145314 File Offset: 0x00143514
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00145394 File Offset: 0x00143594
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00145404 File Offset: 0x00143604
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x00145464 File Offset: 0x00143664
		// (set) Token: 0x060043B4 RID: 17332 RVA: 0x001454D8 File Offset: 0x001436D8
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00145550 File Offset: 0x00143750
		public bool IsWayPointArrived(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWayPointArrivedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWayPointArrivedInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.IsWayPointArrived(wayPointId);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x001455D8 File Offset: 0x001437D8
		protected virtual void OutPutRandomEventOperateLog(int eventId, RandomEventStatus status, List<Goods> rewards = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutRandomEventOperateLogInt32RandomEventStatusList`1_hotfix != null)
			{
				this.m_OutPutRandomEventOperateLogInt32RandomEventStatusList`1_hotfix.call(new object[]
				{
					this,
					eventId,
					status,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00145668 File Offset: 0x00143868
		protected void InitLevelInfo(List<int> arrivedWayPoints)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLevelInfoList`1_hotfix != null)
			{
				this.m_InitLevelInfoList`1_hotfix.call(new object[]
				{
					this,
					arrivedWayPoints
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int wayPointId in arrivedWayPoints)
			{
				this.m_levelDS.AddArrivedWayPoint(wayPointId);
			}
			this.m_levelDS.AddCanMoveWayPointId(this.m_configDataLoader.ConfigableConstId_FirstWayPointId, WayPointStatus.None);
			foreach (int newId in arrivedWayPoints)
			{
				this.AddCanMovePublicWayPoint(newId);
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00145784 File Offset: 0x00143984
		protected void SetArrivedWayPoint(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArrivedWayPointInt32_hotfix != null)
			{
				this.m_SetArrivedWayPointInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelDS.SetArrivedWayPointId(wayPointId);
			this.AddCanMovePublicWayPoint(wayPointId);
			this.m_levelDS.SetCurrentWayPoint(wayPointId);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00145814 File Offset: 0x00143A14
		public void ArriveWayPoint(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArriveWayPointInt32_hotfix != null)
			{
				this.m_ArriveWayPointInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelDS.SetCurrentWayPoint(wayPointId);
			this.AddCanMovePublicWayPoint(wayPointId);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00145898 File Offset: 0x00143A98
		protected bool HasFirstWayPointWithScenario()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasFirstWayPointWithScenario_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasFirstWayPointWithScenario_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(this.GetScenarioId());
			return configDataScenarioInfo != null && configDataScenarioInfo.Waypoint_ID == this.m_configDataLoader.ConfigableConstId_FirstWayPointId;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00145934 File Offset: 0x00143B34
		public void AddCanMovePublicWayPoint(int newId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddCanMovePublicWayPointInt32_hotfix != null)
			{
				this.m_AddCanMovePublicWayPointInt32_hotfix.call(new object[]
				{
					this,
					newId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(newId);
			foreach (ConfigDataWaypointInfo configDataWaypointInfo2 in configDataWaypointInfo.m_waypointInfos)
			{
				if (this.IsRegionOpen(configDataWaypointInfo2.m_regionInfo))
				{
					WaypointFuncType funcType = configDataWaypointInfo2.FuncType;
					WayPointStatus eventStatus;
					if (funcType != WaypointFuncType.WaypointFuncType_Event)
					{
						eventStatus = WayPointStatus.None;
					}
					else
					{
						eventStatus = WayPointStatus.NormalEvent;
					}
					this.m_levelDS.AddCanMoveWayPointId(configDataWaypointInfo2.ID, eventStatus);
				}
			}
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00145A24 File Offset: 0x00143C24
		public virtual void SetFinishedScenario(ConfigDataScenarioInfo scenarioInfo)
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
			if (!this.IsScenarioFinished(scenarioInfo))
			{
				this.m_levelDS.SetScenario(scenarioInfo.ID);
				if (this.CompleteNewScenarioMissionEvent != null)
				{
					this.CompleteNewScenarioMissionEvent(scenarioInfo.ID);
				}
			}
			if (this.CompleteScenarioMissionEvent != null)
			{
				this.CompleteScenarioMissionEvent(scenarioInfo.ID);
			}
			this.SetArrivedWayPoint(scenarioInfo.Waypoint_ID);
			if (scenarioInfo.m_regionInfo != null)
			{
				this.OnOpenRegion(scenarioInfo.m_regionInfo);
			}
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00145B0C File Offset: 0x00143D0C
		public int GetLastFinishedScenarioId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastFinishedScenarioId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLastFinishedScenarioId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.LastFinishedScenarioId;
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00145B84 File Offset: 0x00143D84
		public bool IsScenarioCompleted(int scenarioId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScenarioCompletedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScenarioCompletedInt32_hotfix.call(new object[]
				{
					this,
					scenarioId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(scenarioId);
			if (configDataScenarioInfo == null)
			{
				return false;
			}
			ConfigDataScenarioInfo configDataScenarioInfo2 = this.m_configDataLoader.GetConfigDataScenarioInfo(this.m_levelDS.LastFinishedScenarioId);
			return configDataScenarioInfo2 != null && configDataScenarioInfo2.m_scenarioDepth >= configDataScenarioInfo.m_scenarioDepth;
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00145C48 File Offset: 0x00143E48
		public int GetScenarioId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetScenarioId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetScenarioId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_levelDS.LastFinishedScenarioId != 0)
			{
				ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(this.m_levelDS.LastFinishedScenarioId);
				return (configDataScenarioInfo.NextScenario_ID == 0) ? int.MaxValue : configDataScenarioInfo.NextScenario_ID;
			}
			return this.m_configDataLoader.ConfigableConstId_FirstScenarioId;
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00145D04 File Offset: 0x00143F04
		public virtual void SetBattleWayPointSuccessful(ConfigDataWaypointInfo wayPointInfo, List<int> battleTreasures)
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
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00145D84 File Offset: 0x00143F84
		private bool IsExistRandomEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExistRandomEvent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExistRandomEvent_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.IsExistRandomEvent();
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00145DFC File Offset: 0x00143FFC
		public bool IsSetRandomEvent(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSetRandomEventInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSetRandomEventInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.IsSetRandomEvent(wayPointId);
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00145E84 File Offset: 0x00144084
		public int MoveToWayPoint(int waypointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveToWayPointInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_MoveToWayPointInt32_hotfix.call(new object[]
				{
					this,
					waypointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(waypointId);
			if (configDataWaypointInfo == null)
			{
				return -705;
			}
			int num = this.CanMoveToWayPoint(waypointId);
			if (num != 0)
			{
				return num;
			}
			return this.HandleWayPoint(configDataWaypointInfo);
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00145F30 File Offset: 0x00144130
		public int HandleWayPoint(ConfigDataWaypointInfo wayPointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleWayPointConfigDataWaypointInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleWayPointConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					wayPointInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (wayPointInfo.FuncType)
			{
			case WaypointFuncType.WaypointFuncType_None:
			case WaypointFuncType.WaypointFuncType_Portal:
				this.SetArrivedWayPoint(wayPointInfo.ID);
				break;
			case WaypointFuncType.WaypointFuncType_Scenario:
				if (this.IsScenarioInWaypoint(wayPointInfo.ID))
				{
					return -707;
				}
				this.SetArrivedWayPoint(wayPointInfo.ID);
				break;
			case WaypointFuncType.WaypointFuncType_Event:
				return this.HandleEventWayPoint(wayPointInfo);
			default:
				throw new Exception("WaypointFuncType not found");
			}
			return 0;
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x0014601C File Offset: 0x0014421C
		protected void InitRandomEvents(List<RandomEvent> randomEvents)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRandomEventsList`1_hotfix != null)
			{
				this.m_InitRandomEventsList`1_hotfix.call(new object[]
				{
					this,
					randomEvents
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (RandomEvent randomEvent in randomEvents)
			{
				this.PreInitRandomEvent(randomEvent);
				this.m_levelDS.SetRandomEvent(randomEvent.WayPointId);
			}
			this.m_levelDS.InitRandomEvents(randomEvents);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x001460F4 File Offset: 0x001442F4
		private void PreInitRandomEvent(RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreInitRandomEventRandomEvent_hotfix != null)
			{
				this.m_PreInitRandomEventRandomEvent_hotfix.call(new object[]
				{
					this,
					randomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int eventLives = this.GetEventLives(randomEvent.EventId);
			randomEvent.Lives = eventLives;
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00146178 File Offset: 0x00144378
		protected long GetEventExpiredTime(int eventId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventExpiredTimeInt32_hotfix != null)
			{
				return Convert.ToInt64(this.m_GetEventExpiredTimeInt32_hotfix.call(new object[]
				{
					this,
					eventId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			ConfigDataEventInfo configDataEventInfo = this.m_configDataLoader.GetConfigDataEventInfo(eventId);
			EventInfoDisappearCondition eventInfoDisappearCondition = configDataEventInfo.DisappearCondition.Find((EventInfoDisappearCondition t) => t.ConditionType == EventDisappearConditionType.EventDisappearConditionType_LifeTime);
			if (eventInfoDisappearCondition != null)
			{
				num = eventInfoDisappearCondition.Param;
			}
			return (num != 0) ? this.m_basicInfo.GetCurrentTime().AddSeconds((double)num).Ticks : DateTime.MaxValue.Ticks;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00146270 File Offset: 0x00144470
		protected int GetEventLives(int eventId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventLivesInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEventLivesInt32_hotfix.call(new object[]
				{
					this,
					eventId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = int.MaxValue;
			ConfigDataEventInfo configDataEventInfo = this.m_configDataLoader.GetConfigDataEventInfo(eventId);
			EventInfoDisappearCondition eventInfoDisappearCondition = configDataEventInfo.DisappearCondition.Find((EventInfoDisappearCondition t) => t.ConditionType == EventDisappearConditionType.EventDisappearConditionType_Complete);
			if (eventInfoDisappearCondition != null)
			{
				result = eventInfoDisappearCondition.Param;
			}
			return result;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00146338 File Offset: 0x00144538
		public bool IsRandomEventTimeOut(RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRandomEventTimeOutRandomEvent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRandomEventTimeOutRandomEvent_hotfix.call(new object[]
				{
					this,
					randomEvent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return randomEvent.ExpiredTime != 0L && this.m_basicInfo.GetCurrentTime().Ticks >= randomEvent.ExpiredTime;
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x001463E4 File Offset: 0x001445E4
		public bool IsRandomEventDead(RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRandomEventDeadRandomEvent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRandomEventDeadRandomEvent_hotfix.call(new object[]
				{
					this,
					randomEvent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return randomEvent.DeadLives >= randomEvent.Lives;
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00146474 File Offset: 0x00144674
		public virtual void RemoveRandomEvent(RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveRandomEventRandomEvent_hotfix != null)
			{
				this.m_RemoveRandomEventRandomEvent_hotfix.call(new object[]
				{
					this,
					randomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelDS.RemoveRandomEvent(randomEvent);
			this.m_levelDS.CleanWayPointEvent(randomEvent.WayPointId);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00146504 File Offset: 0x00144704
		public virtual void AddRandomEvent(RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRandomEventRandomEvent_hotfix != null)
			{
				this.m_AddRandomEventRandomEvent_hotfix.call(new object[]
				{
					this,
					randomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PreInitRandomEvent(randomEvent);
			this.m_levelDS.SetRandomEvent(randomEvent.WayPointId);
			this.m_levelDS.AddRandomEvent(randomEvent);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00146598 File Offset: 0x00144798
		public int CanUnLockScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnLockScenarioConfigDataScenarioInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnLockScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ScenarioInfoUnlockCondition> unlockCondition = scenarioInfo.UnlockCondition;
			if (unlockCondition == null || unlockCondition.Count == 0)
			{
				return 0;
			}
			int[] array = new int[3];
			foreach (ScenarioInfoUnlockCondition scenarioInfoUnlockCondition in unlockCondition)
			{
				array[(int)scenarioInfoUnlockCondition.ConditionType] = scenarioInfoUnlockCondition.Param;
			}
			int num = array[1];
			if (num != 0 && this.m_basicInfo.GetLevel() < num)
			{
				return -701;
			}
			int num2 = array[2];
			if (num2 != 0 && !this.m_rift.m_unLockInfo.FinishedRiftLevelIds.Contains(num2))
			{
				return -713;
			}
			if (!scenarioInfo.IsOpened)
			{
				return -719;
			}
			return 0;
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x001466EC File Offset: 0x001448EC
		public int HandleScenario(int scenarioId, bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleScenarioInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleScenarioInt32Boolean_hotfix.call(new object[]
				{
					this,
					scenarioId,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CheckGameFunctionOpenByGM(GameFunctionType.GameFunctionType_Scenario);
			if (num != 0)
			{
				return num;
			}
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(scenarioId);
			if (configDataScenarioInfo == null)
			{
				return -700;
			}
			num = this.CanUnLockScenario(configDataScenarioInfo);
			if (num != 0)
			{
				return num;
			}
			int waypoint_ID = configDataScenarioInfo.Waypoint_ID;
			num = this.CanMoveToWayPoint(waypoint_ID);
			if (num != 0)
			{
				return num;
			}
			ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(waypoint_ID);
			bool flag = this.IsScenarioFinished(configDataScenarioInfo);
			if (configDataScenarioInfo.m_battleInfo == null)
			{
				int energyCost = 0;
				List<Goods> itemRewards;
				if (flag)
				{
					energyCost = configDataScenarioInfo.EnergySuccess;
					itemRewards = new List<Goods>();
				}
				else
				{
					itemRewards = GoodsFactory.CloneGoods(configDataScenarioInfo.FirstReward);
				}
				num = this.HandleDialogEvent(configDataWaypointInfo, itemRewards, configDataScenarioInfo.PlayerExpReward, configDataScenarioInfo.GoldReward, energyCost, scenarioId);
				if (num == 0)
				{
					this.SetFinishedScenario(configDataScenarioInfo);
				}
				return num;
			}
			return this.AttackScenario(configDataScenarioInfo, flag, checkBag);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x0014684C File Offset: 0x00144A4C
		protected bool IsScenarioFinished(ConfigDataScenarioInfo secenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScenarioFinishedConfigDataScenarioInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScenarioFinishedConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					secenarioInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int scenarioId = this.GetScenarioId();
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(scenarioId);
			return configDataScenarioInfo == null || secenarioInfo.m_scenarioDepth < configDataScenarioInfo.m_scenarioDepth;
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x001468F4 File Offset: 0x00144AF4
		public bool IsScenarioFinished(int scenarioId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScenarioFinishedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScenarioFinishedInt32_hotfix.call(new object[]
				{
					this,
					scenarioId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(scenarioId);
			return configDataScenarioInfo != null && this.IsScenarioFinished(configDataScenarioInfo);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x0014698C File Offset: 0x00144B8C
		public bool IsScenarioInWaypoint(int waypointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScenarioInWaypointInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScenarioInWaypointInt32_hotfix.call(new object[]
				{
					this,
					waypointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int scenarioId = this.GetScenarioId();
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(scenarioId);
			return configDataScenarioInfo != null && configDataScenarioInfo.Waypoint_ID == waypointId;
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00146A30 File Offset: 0x00144C30
		public RandomEvent GetRandomEvent(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRandomEventInt32_hotfix != null)
			{
				return (RandomEvent)this.m_GetRandomEventInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDS.GetRandomEvent(wayPointId);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00146AB8 File Offset: 0x00144CB8
		public int GetEventId(ConfigDataWaypointInfo wayPointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventIdConfigDataWaypointInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEventIdConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					wayPointInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result;
			if (this.IsSetRandomEvent(wayPointInfo.ID))
			{
				result = this.GetRandomEvent(wayPointInfo.ID).EventId;
			}
			else
			{
				result = wayPointInfo.FuncTypeParam1;
			}
			return result;
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00146B68 File Offset: 0x00144D68
		protected virtual int CheckGameFunctionOpenByGM(GameFunctionType gameFunctionTypeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGameFunctionOpenByGMGameFunctionType_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGameFunctionOpenByGMGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return 0;
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00146BE8 File Offset: 0x00144DE8
		private int HandleEventWayPoint(ConfigDataWaypointInfo wayPointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleEventWayPointConfigDataWaypointInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleEventWayPointConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					wayPointInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RandomEvent randomEvent = null;
			int key;
			int num;
			if (this.IsSetRandomEvent(wayPointInfo.ID))
			{
				randomEvent = this.GetRandomEvent(wayPointInfo.ID);
				if (this.IsRandomEventTimeOut(randomEvent))
				{
					this.RemoveRandomEvent(randomEvent);
					this.OutPutRandomEventOperateLog(randomEvent.EventId, RandomEventStatus.OutTime, null);
					this.SetArrivedWayPoint(wayPointInfo.ID);
					return -1204;
				}
				key = randomEvent.EventId;
				num = this.CheckGameFunctionOpenByGM(GameFunctionType.GameFunctionType_RandomEvent);
				if (num != 0)
				{
					return num;
				}
			}
			else
			{
				if (this.m_levelDS.IsWayPointArrived(wayPointInfo.ID))
				{
					this.ArriveWayPoint(wayPointInfo.ID);
					return 0;
				}
				key = wayPointInfo.FuncTypeParam1;
				num = this.CheckGameFunctionOpenByGM(GameFunctionType.GameFunctionType_Event);
				if (num != 0)
				{
					return num;
				}
			}
			ConfigDataEventInfo configDataEventInfo = this.m_configDataLoader.GetConfigDataEventInfo(key);
			if (!this.m_basicInfo.IsEnergyEnough(configDataEventInfo.EnergySuccess))
			{
				return -402;
			}
			switch (configDataEventInfo.FuncType)
			{
			case EventFuncType.EventFuncType_Monster:
			case EventFuncType.EventFuncType_Mission:
				return this.HandleAttackWayPointEvent(wayPointInfo.ID, configDataEventInfo);
			case EventFuncType.EventFuncType_Dialog:
				num = this.HandleDialogEvent(wayPointInfo, this.GetEventRewards(configDataEventInfo), configDataEventInfo.PlayerExpReward, configDataEventInfo.GoldReward, configDataEventInfo.EnergySuccess, 0);
				break;
			case EventFuncType.EventFuncType_Treasure:
				num = this.HandleTresureEvent(wayPointInfo.ID, configDataEventInfo);
				break;
			default:
				return -712;
			}
			if (num != 0)
			{
				return num;
			}
			this.OnEventComplete(wayPointInfo.ID, randomEvent);
			return 0;
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00146DC8 File Offset: 0x00144FC8
		public void OnEventComplete(int wayPointId, RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEventCompleteInt32RandomEvent_hotfix != null)
			{
				this.m_OnEventCompleteInt32RandomEvent_hotfix.call(new object[]
				{
					this,
					wayPointId,
					randomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (randomEvent != null)
			{
				this.m_levelDS.AddDeadLives(randomEvent, 1);
				if (this.IsRandomEventDead(randomEvent))
				{
					this.RemoveRandomEvent(randomEvent);
					this.m_levelDS.SetArrivedWayPointId(randomEvent.WayPointId);
				}
				this.ArriveWayPoint(wayPointId);
			}
			else
			{
				this.SetArrivedWayPoint(wayPointId);
				this.OnCompleteWayPointEvent();
			}
			if (this.CompleteEventMissionEvent != null)
			{
				this.CompleteEventMissionEvent(randomEvent != null);
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00146EB8 File Offset: 0x001450B8
		protected virtual int HandleDialogEvent(ConfigDataWaypointInfo wayPointInfo, List<Goods> itemRewards, int expReward, int goldReward, int energyCost, int scenarioId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleDialogEventConfigDataWaypointInfoList`1Int32Int32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleDialogEventConfigDataWaypointInfoList`1Int32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					wayPointInfo,
					itemRewards,
					expReward,
					goldReward,
					energyCost,
					scenarioId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return 0;
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00146F88 File Offset: 0x00145188
		protected virtual int HandleTresureEvent(int wayPointId, ConfigDataEventInfo eventInfo)
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
			return 0;
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00147018 File Offset: 0x00145218
		protected virtual List<Goods> GetEventRewards(ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventRewardsConfigDataEventInfo_hotfix != null)
			{
				return (List<Goods>)this.m_GetEventRewardsConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					eventInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return eventInfo.Reward;
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0014709C File Offset: 0x0014529C
		private int AttackScenario(ConfigDataScenarioInfo secenarioInfo, bool scenarioFinished, bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix.call(new object[]
				{
					this,
					secenarioInfo,
					scenarioFinished,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackScenario(secenarioInfo, scenarioFinished, checkBag);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			this.m_battle.SetProcessingBattleInfo(BattleType.Scenario, secenarioInfo.ID);
			if (scenarioFinished)
			{
				this.m_basicInfo.DecreaseEnergy(secenarioInfo.EnergyFail, GameFunctionType.GameFunctionType_Scenario, secenarioInfo.ID.ToString());
			}
			return 0;
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x001471A4 File Offset: 0x001453A4
		public virtual int CanAttackScenario(ConfigDataScenarioInfo scenarioInfo, bool scenarioFinished, bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix.call(new object[]
				{
					this,
					scenarioInfo,
					scenarioFinished,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (scenarioFinished)
			{
				int energySuccess = scenarioInfo.EnergySuccess;
				if (!this.m_basicInfo.IsEnergyEnough(energySuccess))
				{
					return -402;
				}
			}
			if (checkBag && this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return (!this.m_battle.IsFighting()) ? 0 : -900;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x0014729C File Offset: 0x0014549C
		private int HandleAttackWayPointEvent(int wayPointId, ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleAttackWayPointEventInt32ConfigDataEventInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_HandleAttackWayPointEventInt32ConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					wayPointId,
					eventInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventInfo.m_battleInfo == null)
			{
				return -711;
			}
			int num = this.AttackEventWayPoint(wayPointId, eventInfo);
			if (num != 0)
			{
				return num;
			}
			this.m_basicInfo.DecreaseEnergy(eventInfo.EnergyFail, GameFunctionType.GameFunctionType_Event, eventInfo.ID.ToString());
			return 0;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00147374 File Offset: 0x00145574
		private int AttackEventWayPoint(int wayPointId, ConfigDataEventInfo eventyInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackEventWayPointInt32ConfigDataEventInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackEventWayPointInt32ConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					wayPointId,
					eventyInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackEventWayPoint(wayPointId, eventyInfo);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			this.m_battle.SetProcessingBattleInfo(BattleType.WayPoint, wayPointId);
			return 0;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00147438 File Offset: 0x00145638
		public int CanAttackEventWayPoint(int wayPointdId, ConfigDataEventInfo eventyInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackEventWayPointInt32ConfigDataEventInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackEventWayPointInt32ConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					wayPointdId,
					eventyInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_configDataLoader.GetConfigDataWaypointInfo(wayPointdId) == null)
			{
				return -705;
			}
			if (!this.m_basicInfo.IsEnergyEnough(eventyInfo.EnergySuccess))
			{
				return -402;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return (!this.m_battle.IsFighting()) ? 0 : -900;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x0014752C File Offset: 0x0014572C
		protected int CanMoveToWayPoint(int destWayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanMoveToWayPointInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanMoveToWayPointInt32_hotfix.call(new object[]
				{
					this,
					destWayPointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_levelDS.CanMoveWayPoint(destWayPointId))
			{
				return -707;
			}
			return 0;
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x001475C0 File Offset: 0x001457C0
		protected int CanMoveToWayPointExistRandomEvent(int destWayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanMoveToWayPointExistRandomEventInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanMoveToWayPointExistRandomEventInt32_hotfix.call(new object[]
				{
					this,
					destWayPointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int currentWayPointId = this.m_levelDS.CurrentWayPointId;
			if (this.m_levelDS.IsSetRandomEvent(currentWayPointId))
			{
				return -1203;
			}
			Queue<int> queue = new Queue<int>();
			HashSet<int> hashSet = new HashSet<int>();
			queue.Enqueue(destWayPointId);
			while (queue.Count != 0)
			{
				int num = queue.Dequeue();
				hashSet.Add(num);
				if (num == currentWayPointId)
				{
					return 0;
				}
				ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(num);
				foreach (int num2 in configDataWaypointInfo.Waypoints_ID)
				{
					if (this.m_levelDS.CanExpandWayPoint(num2) && !hashSet.Contains(num2))
					{
						queue.Enqueue(num2);
					}
				}
			}
			return -707;
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00147724 File Offset: 0x00145924
		public virtual void OnCompleteWayPointEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompleteWayPointEvent_hotfix != null)
			{
				this.m_OnCompleteWayPointEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x00147784 File Offset: 0x00145984
		public bool IsRegionOpen(ConfigDataRegionInfo regionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRegionOpenConfigDataRegionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRegionOpenConfigDataRegionInfo_hotfix.call(new object[]
				{
					this,
					regionInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (regionInfo == null)
			{
				return false;
			}
			if (regionInfo.m_openByScenarioInfo == null)
			{
				return true;
			}
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(this.m_levelDS.LastFinishedScenarioId);
			return configDataScenarioInfo != null && configDataScenarioInfo.m_scenarioDepth >= regionInfo.m_openByScenarioInfo.m_scenarioDepth;
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x0014784C File Offset: 0x00145A4C
		protected virtual void OnOpenRegion(ConfigDataRegionInfo regionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOpenRegionConfigDataRegionInfo_hotfix != null)
			{
				this.m_OnOpenRegionConfigDataRegionInfo_hotfix.call(new object[]
				{
					this,
					regionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ConfigDataWaypointInfo configDataWaypointInfo in regionInfo.m_waypointInfos)
			{
				bool flag = false;
				foreach (ConfigDataWaypointInfo configDataWaypointInfo2 in configDataWaypointInfo.m_waypointInfos)
				{
					if (this.m_levelDS.IsWayPointArrived(configDataWaypointInfo2.ID))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					WaypointFuncType funcType = configDataWaypointInfo.FuncType;
					WayPointStatus eventStatus;
					if (funcType != WaypointFuncType.WaypointFuncType_Event)
					{
						eventStatus = WayPointStatus.None;
					}
					else
					{
						eventStatus = WayPointStatus.NormalEvent;
					}
					this.m_levelDS.AddCanMoveWayPointId(configDataWaypointInfo.ID, eventStatus);
				}
			}
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x00147968 File Offset: 0x00145B68
		public WayPointStatus GetWayPointStatus(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWayPointStatusInt32_hotfix != null)
			{
				return (WayPointStatus)this.m_GetWayPointStatusInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			WayPointStatus result = WayPointStatus.Close;
			this.m_levelDS.CanMoveWayPointIds.TryGetValue(wayPointId, out result);
			return result;
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060043E5 RID: 17381 RVA: 0x001479FC File Offset: 0x00145BFC
		// (remove) Token: 0x060043E6 RID: 17382 RVA: 0x00147A98 File Offset: 0x00145C98
		public event Action<bool> CompleteEventMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteEventMissionEventAction`1_hotfix != null)
				{
					this.m_add_CompleteEventMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.CompleteEventMissionEvent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.CompleteEventMissionEvent, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteEventMissionEventAction`1_hotfix != null)
				{
					this.m_remove_CompleteEventMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.CompleteEventMissionEvent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.CompleteEventMissionEvent, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060043E7 RID: 17383 RVA: 0x00147B34 File Offset: 0x00145D34
		// (remove) Token: 0x060043E8 RID: 17384 RVA: 0x00147BD0 File Offset: 0x00145DD0
		public event Action<int> CompleteScenarioMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteScenarioMissionEventAction`1_hotfix != null)
				{
					this.m_add_CompleteScenarioMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.CompleteScenarioMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.CompleteScenarioMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteScenarioMissionEventAction`1_hotfix != null)
				{
					this.m_remove_CompleteScenarioMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.CompleteScenarioMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.CompleteScenarioMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060043E9 RID: 17385 RVA: 0x00147C6C File Offset: 0x00145E6C
		// (remove) Token: 0x060043EA RID: 17386 RVA: 0x00147D08 File Offset: 0x00145F08
		public event Action<int> CompleteNewScenarioMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteNewScenarioMissionEventAction`1_hotfix != null)
				{
					this.m_add_CompleteNewScenarioMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.CompleteNewScenarioMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.CompleteNewScenarioMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteNewScenarioMissionEventAction`1_hotfix != null)
				{
					this.m_remove_CompleteNewScenarioMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.CompleteNewScenarioMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.CompleteNewScenarioMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00147DA4 File Offset: 0x00145FA4
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x00147DC4 File Offset: 0x00145FC4
		[DoNotToLua]
		public LevelComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LevelComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00147DD0 File Offset: 0x00145FD0
		private void __callDele_CompleteEventMissionEvent(bool obj)
		{
			Action<bool> completeEventMissionEvent = this.CompleteEventMissionEvent;
			if (completeEventMissionEvent != null)
			{
				completeEventMissionEvent(obj);
			}
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00147DF4 File Offset: 0x00145FF4
		private void __clearDele_CompleteEventMissionEvent(bool obj)
		{
			this.CompleteEventMissionEvent = null;
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00147E00 File Offset: 0x00146000
		private void __callDele_CompleteScenarioMissionEvent(int obj)
		{
			Action<int> completeScenarioMissionEvent = this.CompleteScenarioMissionEvent;
			if (completeScenarioMissionEvent != null)
			{
				completeScenarioMissionEvent(obj);
			}
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00147E24 File Offset: 0x00146024
		private void __clearDele_CompleteScenarioMissionEvent(int obj)
		{
			this.CompleteScenarioMissionEvent = null;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00147E30 File Offset: 0x00146030
		private void __callDele_CompleteNewScenarioMissionEvent(int obj)
		{
			Action<int> completeNewScenarioMissionEvent = this.CompleteNewScenarioMissionEvent;
			if (completeNewScenarioMissionEvent != null)
			{
				completeNewScenarioMissionEvent(obj);
			}
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00147E54 File Offset: 0x00146054
		private void __clearDele_CompleteNewScenarioMissionEvent(int obj)
		{
			this.CompleteNewScenarioMissionEvent = null;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00147E78 File Offset: 0x00146078
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_IsWayPointArrivedInt32_hotfix = (luaObj.RawGet("IsWayPointArrived") as LuaFunction);
					this.m_OutPutRandomEventOperateLogInt32RandomEventStatusList`1_hotfix = (luaObj.RawGet("OutPutRandomEventOperateLog") as LuaFunction);
					this.m_InitLevelInfoList`1_hotfix = (luaObj.RawGet("InitLevelInfo") as LuaFunction);
					this.m_SetArrivedWayPointInt32_hotfix = (luaObj.RawGet("SetArrivedWayPoint") as LuaFunction);
					this.m_ArriveWayPointInt32_hotfix = (luaObj.RawGet("ArriveWayPoint") as LuaFunction);
					this.m_HasFirstWayPointWithScenario_hotfix = (luaObj.RawGet("HasFirstWayPointWithScenario") as LuaFunction);
					this.m_AddCanMovePublicWayPointInt32_hotfix = (luaObj.RawGet("AddCanMovePublicWayPoint") as LuaFunction);
					this.m_SetFinishedScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("SetFinishedScenario") as LuaFunction);
					this.m_GetLastFinishedScenarioId_hotfix = (luaObj.RawGet("GetLastFinishedScenarioId") as LuaFunction);
					this.m_IsScenarioCompletedInt32_hotfix = (luaObj.RawGet("IsScenarioCompleted") as LuaFunction);
					this.m_GetScenarioId_hotfix = (luaObj.RawGet("GetScenarioId") as LuaFunction);
					this.m_SetBattleWayPointSuccessfulConfigDataWaypointInfoList`1_hotfix = (luaObj.RawGet("SetBattleWayPointSuccessful") as LuaFunction);
					this.m_IsExistRandomEvent_hotfix = (luaObj.RawGet("IsExistRandomEvent") as LuaFunction);
					this.m_IsSetRandomEventInt32_hotfix = (luaObj.RawGet("IsSetRandomEvent") as LuaFunction);
					this.m_MoveToWayPointInt32_hotfix = (luaObj.RawGet("MoveToWayPoint") as LuaFunction);
					this.m_HandleWayPointConfigDataWaypointInfo_hotfix = (luaObj.RawGet("HandleWayPoint") as LuaFunction);
					this.m_InitRandomEventsList`1_hotfix = (luaObj.RawGet("InitRandomEvents") as LuaFunction);
					this.m_PreInitRandomEventRandomEvent_hotfix = (luaObj.RawGet("PreInitRandomEvent") as LuaFunction);
					this.m_GetEventExpiredTimeInt32_hotfix = (luaObj.RawGet("GetEventExpiredTime") as LuaFunction);
					this.m_GetEventLivesInt32_hotfix = (luaObj.RawGet("GetEventLives") as LuaFunction);
					this.m_IsRandomEventTimeOutRandomEvent_hotfix = (luaObj.RawGet("IsRandomEventTimeOut") as LuaFunction);
					this.m_IsRandomEventDeadRandomEvent_hotfix = (luaObj.RawGet("IsRandomEventDead") as LuaFunction);
					this.m_RemoveRandomEventRandomEvent_hotfix = (luaObj.RawGet("RemoveRandomEvent") as LuaFunction);
					this.m_AddRandomEventRandomEvent_hotfix = (luaObj.RawGet("AddRandomEvent") as LuaFunction);
					this.m_CanUnLockScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("CanUnLockScenario") as LuaFunction);
					this.m_HandleScenarioInt32Boolean_hotfix = (luaObj.RawGet("HandleScenario") as LuaFunction);
					this.m_IsScenarioFinishedConfigDataScenarioInfo_hotfix = (luaObj.RawGet("IsScenarioFinished") as LuaFunction);
					this.m_IsScenarioFinishedInt32_hotfix = (luaObj.RawGet("IsScenarioFinished") as LuaFunction);
					this.m_IsScenarioInWaypointInt32_hotfix = (luaObj.RawGet("IsScenarioInWaypoint") as LuaFunction);
					this.m_GetRandomEventInt32_hotfix = (luaObj.RawGet("GetRandomEvent") as LuaFunction);
					this.m_GetEventIdConfigDataWaypointInfo_hotfix = (luaObj.RawGet("GetEventId") as LuaFunction);
					this.m_CheckGameFunctionOpenByGMGameFunctionType_hotfix = (luaObj.RawGet("CheckGameFunctionOpenByGM") as LuaFunction);
					this.m_HandleEventWayPointConfigDataWaypointInfo_hotfix = (luaObj.RawGet("HandleEventWayPoint") as LuaFunction);
					this.m_OnEventCompleteInt32RandomEvent_hotfix = (luaObj.RawGet("OnEventComplete") as LuaFunction);
					this.m_HandleDialogEventConfigDataWaypointInfoList`1Int32Int32Int32Int32_hotfix = (luaObj.RawGet("HandleDialogEvent") as LuaFunction);
					this.m_HandleTresureEventInt32ConfigDataEventInfo_hotfix = (luaObj.RawGet("HandleTresureEvent") as LuaFunction);
					this.m_GetEventRewardsConfigDataEventInfo_hotfix = (luaObj.RawGet("GetEventRewards") as LuaFunction);
					this.m_AttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix = (luaObj.RawGet("AttackScenario") as LuaFunction);
					this.m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix = (luaObj.RawGet("CanAttackScenario") as LuaFunction);
					this.m_HandleAttackWayPointEventInt32ConfigDataEventInfo_hotfix = (luaObj.RawGet("HandleAttackWayPointEvent") as LuaFunction);
					this.m_AttackEventWayPointInt32ConfigDataEventInfo_hotfix = (luaObj.RawGet("AttackEventWayPoint") as LuaFunction);
					this.m_CanAttackEventWayPointInt32ConfigDataEventInfo_hotfix = (luaObj.RawGet("CanAttackEventWayPoint") as LuaFunction);
					this.m_CanMoveToWayPointInt32_hotfix = (luaObj.RawGet("CanMoveToWayPoint") as LuaFunction);
					this.m_CanMoveToWayPointExistRandomEventInt32_hotfix = (luaObj.RawGet("CanMoveToWayPointExistRandomEvent") as LuaFunction);
					this.m_OnCompleteWayPointEvent_hotfix = (luaObj.RawGet("OnCompleteWayPointEvent") as LuaFunction);
					this.m_IsRegionOpenConfigDataRegionInfo_hotfix = (luaObj.RawGet("IsRegionOpen") as LuaFunction);
					this.m_OnOpenRegionConfigDataRegionInfo_hotfix = (luaObj.RawGet("OnOpenRegion") as LuaFunction);
					this.m_GetWayPointStatusInt32_hotfix = (luaObj.RawGet("GetWayPointStatus") as LuaFunction);
					this.m_add_CompleteEventMissionEventAction`1_hotfix = (luaObj.RawGet("add_CompleteEventMissionEvent") as LuaFunction);
					this.m_remove_CompleteEventMissionEventAction`1_hotfix = (luaObj.RawGet("remove_CompleteEventMissionEvent") as LuaFunction);
					this.m_add_CompleteScenarioMissionEventAction`1_hotfix = (luaObj.RawGet("add_CompleteScenarioMissionEvent") as LuaFunction);
					this.m_remove_CompleteScenarioMissionEventAction`1_hotfix = (luaObj.RawGet("remove_CompleteScenarioMissionEvent") as LuaFunction);
					this.m_add_CompleteNewScenarioMissionEventAction`1_hotfix = (luaObj.RawGet("add_CompleteNewScenarioMissionEvent") as LuaFunction);
					this.m_remove_CompleteNewScenarioMissionEventAction`1_hotfix = (luaObj.RawGet("remove_CompleteNewScenarioMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00148584 File Offset: 0x00146784
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400337F RID: 13183
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003380 RID: 13184
		protected BagComponentCommon m_bag;

		// Token: 0x04003381 RID: 13185
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003382 RID: 13186
		protected RiftComponentCommon m_rift;

		// Token: 0x04003383 RID: 13187
		protected BattleComponentCommon m_battle;

		// Token: 0x04003384 RID: 13188
		protected HeroComponentCommon m_hero;

		// Token: 0x04003385 RID: 13189
		protected DataSectionLevel m_levelDS = new DataSectionLevel();

		// Token: 0x04003389 RID: 13193
		[DoNotToLua]
		private LevelComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400338C RID: 13196
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400338D RID: 13197
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400338E RID: 13198
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400338F RID: 13199
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003390 RID: 13200
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003391 RID: 13201
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003392 RID: 13202
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003393 RID: 13203
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003394 RID: 13204
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003395 RID: 13205
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003396 RID: 13206
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003397 RID: 13207
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003398 RID: 13208
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003399 RID: 13209
		private LuaFunction m_IsWayPointArrivedInt32_hotfix;

		// Token: 0x0400339A RID: 13210
		private LuaFunction m_OutPutRandomEventOperateLogInt32RandomEventStatusList;

		// Token: 0x0400339B RID: 13211
		private LuaFunction m_InitLevelInfoList;

		// Token: 0x0400339C RID: 13212
		private LuaFunction m_SetArrivedWayPointInt32_hotfix;

		// Token: 0x0400339D RID: 13213
		private LuaFunction m_ArriveWayPointInt32_hotfix;

		// Token: 0x0400339E RID: 13214
		private LuaFunction m_HasFirstWayPointWithScenario_hotfix;

		// Token: 0x0400339F RID: 13215
		private LuaFunction m_AddCanMovePublicWayPointInt32_hotfix;

		// Token: 0x040033A0 RID: 13216
		private LuaFunction m_SetFinishedScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x040033A1 RID: 13217
		private LuaFunction m_GetLastFinishedScenarioId_hotfix;

		// Token: 0x040033A2 RID: 13218
		private LuaFunction m_IsScenarioCompletedInt32_hotfix;

		// Token: 0x040033A3 RID: 13219
		private LuaFunction m_GetScenarioId_hotfix;

		// Token: 0x040033A4 RID: 13220
		private LuaFunction m_SetBattleWayPointSuccessfulConfigDataWaypointInfoList;

		// Token: 0x040033A5 RID: 13221
		private LuaFunction m_IsExistRandomEvent_hotfix;

		// Token: 0x040033A6 RID: 13222
		private LuaFunction m_IsSetRandomEventInt32_hotfix;

		// Token: 0x040033A7 RID: 13223
		private LuaFunction m_MoveToWayPointInt32_hotfix;

		// Token: 0x040033A8 RID: 13224
		private LuaFunction m_HandleWayPointConfigDataWaypointInfo_hotfix;

		// Token: 0x040033A9 RID: 13225
		private LuaFunction m_InitRandomEventsList;

		// Token: 0x040033AA RID: 13226
		private LuaFunction m_PreInitRandomEventRandomEvent_hotfix;

		// Token: 0x040033AB RID: 13227
		private LuaFunction m_GetEventExpiredTimeInt32_hotfix;

		// Token: 0x040033AC RID: 13228
		private LuaFunction m_GetEventLivesInt32_hotfix;

		// Token: 0x040033AD RID: 13229
		private LuaFunction m_IsRandomEventTimeOutRandomEvent_hotfix;

		// Token: 0x040033AE RID: 13230
		private LuaFunction m_IsRandomEventDeadRandomEvent_hotfix;

		// Token: 0x040033AF RID: 13231
		private LuaFunction m_RemoveRandomEventRandomEvent_hotfix;

		// Token: 0x040033B0 RID: 13232
		private LuaFunction m_AddRandomEventRandomEvent_hotfix;

		// Token: 0x040033B1 RID: 13233
		private LuaFunction m_CanUnLockScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x040033B2 RID: 13234
		private LuaFunction m_HandleScenarioInt32Boolean_hotfix;

		// Token: 0x040033B3 RID: 13235
		private LuaFunction m_IsScenarioFinishedConfigDataScenarioInfo_hotfix;

		// Token: 0x040033B4 RID: 13236
		private LuaFunction m_IsScenarioFinishedInt32_hotfix;

		// Token: 0x040033B5 RID: 13237
		private LuaFunction m_IsScenarioInWaypointInt32_hotfix;

		// Token: 0x040033B6 RID: 13238
		private LuaFunction m_GetRandomEventInt32_hotfix;

		// Token: 0x040033B7 RID: 13239
		private LuaFunction m_GetEventIdConfigDataWaypointInfo_hotfix;

		// Token: 0x040033B8 RID: 13240
		private LuaFunction m_CheckGameFunctionOpenByGMGameFunctionType_hotfix;

		// Token: 0x040033B9 RID: 13241
		private LuaFunction m_HandleEventWayPointConfigDataWaypointInfo_hotfix;

		// Token: 0x040033BA RID: 13242
		private LuaFunction m_OnEventCompleteInt32RandomEvent_hotfix;

		// Token: 0x040033BB RID: 13243
		private LuaFunction m_HandleDialogEventConfigDataWaypointInfoList;

		// Token: 0x040033BC RID: 13244
		private LuaFunction m_HandleTresureEventInt32ConfigDataEventInfo_hotfix;

		// Token: 0x040033BD RID: 13245
		private LuaFunction m_GetEventRewardsConfigDataEventInfo_hotfix;

		// Token: 0x040033BE RID: 13246
		private LuaFunction m_AttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix;

		// Token: 0x040033BF RID: 13247
		private LuaFunction m_CanAttackScenarioConfigDataScenarioInfoBooleanBoolean_hotfix;

		// Token: 0x040033C0 RID: 13248
		private LuaFunction m_HandleAttackWayPointEventInt32ConfigDataEventInfo_hotfix;

		// Token: 0x040033C1 RID: 13249
		private LuaFunction m_AttackEventWayPointInt32ConfigDataEventInfo_hotfix;

		// Token: 0x040033C2 RID: 13250
		private LuaFunction m_CanAttackEventWayPointInt32ConfigDataEventInfo_hotfix;

		// Token: 0x040033C3 RID: 13251
		private LuaFunction m_CanMoveToWayPointInt32_hotfix;

		// Token: 0x040033C4 RID: 13252
		private LuaFunction m_CanMoveToWayPointExistRandomEventInt32_hotfix;

		// Token: 0x040033C5 RID: 13253
		private LuaFunction m_OnCompleteWayPointEvent_hotfix;

		// Token: 0x040033C6 RID: 13254
		private LuaFunction m_IsRegionOpenConfigDataRegionInfo_hotfix;

		// Token: 0x040033C7 RID: 13255
		private LuaFunction m_OnOpenRegionConfigDataRegionInfo_hotfix;

		// Token: 0x040033C8 RID: 13256
		private LuaFunction m_GetWayPointStatusInt32_hotfix;

		// Token: 0x040033C9 RID: 13257
		private LuaFunction m_add_CompleteEventMissionEventAction;

		// Token: 0x040033CA RID: 13258
		private LuaFunction m_remove_CompleteEventMissionEventAction;

		// Token: 0x040033CB RID: 13259
		private LuaFunction m_add_CompleteScenarioMissionEventAction;

		// Token: 0x040033CC RID: 13260
		private LuaFunction m_remove_CompleteScenarioMissionEventAction;

		// Token: 0x040033CD RID: 13261
		private LuaFunction m_add_CompleteNewScenarioMissionEventAction;

		// Token: 0x040033CE RID: 13262
		private LuaFunction m_remove_CompleteNewScenarioMissionEventAction;

		// Token: 0x02000480 RID: 1152
		public class LuaExportHelper
		{
			// Token: 0x060043F7 RID: 17399 RVA: 0x001485EC File Offset: 0x001467EC
			public LuaExportHelper(LevelComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060043F8 RID: 17400 RVA: 0x001485FC File Offset: 0x001467FC
			public void __callDele_CompleteEventMissionEvent(bool obj)
			{
				this.m_owner.__callDele_CompleteEventMissionEvent(obj);
			}

			// Token: 0x060043F9 RID: 17401 RVA: 0x0014860C File Offset: 0x0014680C
			public void __clearDele_CompleteEventMissionEvent(bool obj)
			{
				this.m_owner.__clearDele_CompleteEventMissionEvent(obj);
			}

			// Token: 0x060043FA RID: 17402 RVA: 0x0014861C File Offset: 0x0014681C
			public void __callDele_CompleteScenarioMissionEvent(int obj)
			{
				this.m_owner.__callDele_CompleteScenarioMissionEvent(obj);
			}

			// Token: 0x060043FB RID: 17403 RVA: 0x0014862C File Offset: 0x0014682C
			public void __clearDele_CompleteScenarioMissionEvent(int obj)
			{
				this.m_owner.__clearDele_CompleteScenarioMissionEvent(obj);
			}

			// Token: 0x060043FC RID: 17404 RVA: 0x0014863C File Offset: 0x0014683C
			public void __callDele_CompleteNewScenarioMissionEvent(int obj)
			{
				this.m_owner.__callDele_CompleteNewScenarioMissionEvent(obj);
			}

			// Token: 0x060043FD RID: 17405 RVA: 0x0014864C File Offset: 0x0014684C
			public void __clearDele_CompleteNewScenarioMissionEvent(int obj)
			{
				this.m_owner.__clearDele_CompleteNewScenarioMissionEvent(obj);
			}

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x060043FE RID: 17406 RVA: 0x0014865C File Offset: 0x0014685C
			// (set) Token: 0x060043FF RID: 17407 RVA: 0x0014866C File Offset: 0x0014686C
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

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x06004400 RID: 17408 RVA: 0x0014867C File Offset: 0x0014687C
			// (set) Token: 0x06004401 RID: 17409 RVA: 0x0014868C File Offset: 0x0014688C
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x06004402 RID: 17410 RVA: 0x0014869C File Offset: 0x0014689C
			// (set) Token: 0x06004403 RID: 17411 RVA: 0x001486AC File Offset: 0x001468AC
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x06004404 RID: 17412 RVA: 0x001486BC File Offset: 0x001468BC
			// (set) Token: 0x06004405 RID: 17413 RVA: 0x001486CC File Offset: 0x001468CC
			public RiftComponentCommon m_rift
			{
				get
				{
					return this.m_owner.m_rift;
				}
				set
				{
					this.m_owner.m_rift = value;
				}
			}

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x06004406 RID: 17414 RVA: 0x001486DC File Offset: 0x001468DC
			// (set) Token: 0x06004407 RID: 17415 RVA: 0x001486EC File Offset: 0x001468EC
			public BattleComponentCommon m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x06004408 RID: 17416 RVA: 0x001486FC File Offset: 0x001468FC
			// (set) Token: 0x06004409 RID: 17417 RVA: 0x0014870C File Offset: 0x0014690C
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001192 RID: 4498
			// (get) Token: 0x0600440A RID: 17418 RVA: 0x0014871C File Offset: 0x0014691C
			// (set) Token: 0x0600440B RID: 17419 RVA: 0x0014872C File Offset: 0x0014692C
			public DataSectionLevel m_levelDS
			{
				get
				{
					return this.m_owner.m_levelDS;
				}
				set
				{
					this.m_owner.m_levelDS = value;
				}
			}

			// Token: 0x0600440C RID: 17420 RVA: 0x0014873C File Offset: 0x0014693C
			public void OutPutRandomEventOperateLog(int eventId, RandomEventStatus status, List<Goods> rewards)
			{
				this.m_owner.OutPutRandomEventOperateLog(eventId, status, rewards);
			}

			// Token: 0x0600440D RID: 17421 RVA: 0x0014874C File Offset: 0x0014694C
			public void InitLevelInfo(List<int> arrivedWayPoints)
			{
				this.m_owner.InitLevelInfo(arrivedWayPoints);
			}

			// Token: 0x0600440E RID: 17422 RVA: 0x0014875C File Offset: 0x0014695C
			public void SetArrivedWayPoint(int wayPointId)
			{
				this.m_owner.SetArrivedWayPoint(wayPointId);
			}

			// Token: 0x0600440F RID: 17423 RVA: 0x0014876C File Offset: 0x0014696C
			public bool HasFirstWayPointWithScenario()
			{
				return this.m_owner.HasFirstWayPointWithScenario();
			}

			// Token: 0x06004410 RID: 17424 RVA: 0x0014877C File Offset: 0x0014697C
			public bool IsExistRandomEvent()
			{
				return this.m_owner.IsExistRandomEvent();
			}

			// Token: 0x06004411 RID: 17425 RVA: 0x0014878C File Offset: 0x0014698C
			public void InitRandomEvents(List<RandomEvent> randomEvents)
			{
				this.m_owner.InitRandomEvents(randomEvents);
			}

			// Token: 0x06004412 RID: 17426 RVA: 0x0014879C File Offset: 0x0014699C
			public void PreInitRandomEvent(RandomEvent randomEvent)
			{
				this.m_owner.PreInitRandomEvent(randomEvent);
			}

			// Token: 0x06004413 RID: 17427 RVA: 0x001487AC File Offset: 0x001469AC
			public long GetEventExpiredTime(int eventId)
			{
				return this.m_owner.GetEventExpiredTime(eventId);
			}

			// Token: 0x06004414 RID: 17428 RVA: 0x001487BC File Offset: 0x001469BC
			public int GetEventLives(int eventId)
			{
				return this.m_owner.GetEventLives(eventId);
			}

			// Token: 0x06004415 RID: 17429 RVA: 0x001487CC File Offset: 0x001469CC
			public bool IsScenarioFinished(ConfigDataScenarioInfo secenarioInfo)
			{
				return this.m_owner.IsScenarioFinished(secenarioInfo);
			}

			// Token: 0x06004416 RID: 17430 RVA: 0x001487DC File Offset: 0x001469DC
			public int CheckGameFunctionOpenByGM(GameFunctionType gameFunctionTypeId)
			{
				return this.m_owner.CheckGameFunctionOpenByGM(gameFunctionTypeId);
			}

			// Token: 0x06004417 RID: 17431 RVA: 0x001487EC File Offset: 0x001469EC
			public int HandleEventWayPoint(ConfigDataWaypointInfo wayPointInfo)
			{
				return this.m_owner.HandleEventWayPoint(wayPointInfo);
			}

			// Token: 0x06004418 RID: 17432 RVA: 0x001487FC File Offset: 0x001469FC
			public int HandleDialogEvent(ConfigDataWaypointInfo wayPointInfo, List<Goods> itemRewards, int expReward, int goldReward, int energyCost, int scenarioId)
			{
				return this.m_owner.HandleDialogEvent(wayPointInfo, itemRewards, expReward, goldReward, energyCost, scenarioId);
			}

			// Token: 0x06004419 RID: 17433 RVA: 0x00148814 File Offset: 0x00146A14
			public int HandleTresureEvent(int wayPointId, ConfigDataEventInfo eventInfo)
			{
				return this.m_owner.HandleTresureEvent(wayPointId, eventInfo);
			}

			// Token: 0x0600441A RID: 17434 RVA: 0x00148824 File Offset: 0x00146A24
			public List<Goods> GetEventRewards(ConfigDataEventInfo eventInfo)
			{
				return this.m_owner.GetEventRewards(eventInfo);
			}

			// Token: 0x0600441B RID: 17435 RVA: 0x00148834 File Offset: 0x00146A34
			public int AttackScenario(ConfigDataScenarioInfo secenarioInfo, bool scenarioFinished, bool checkBag)
			{
				return this.m_owner.AttackScenario(secenarioInfo, scenarioFinished, checkBag);
			}

			// Token: 0x0600441C RID: 17436 RVA: 0x00148844 File Offset: 0x00146A44
			public int HandleAttackWayPointEvent(int wayPointId, ConfigDataEventInfo eventInfo)
			{
				return this.m_owner.HandleAttackWayPointEvent(wayPointId, eventInfo);
			}

			// Token: 0x0600441D RID: 17437 RVA: 0x00148854 File Offset: 0x00146A54
			public int AttackEventWayPoint(int wayPointId, ConfigDataEventInfo eventyInfo)
			{
				return this.m_owner.AttackEventWayPoint(wayPointId, eventyInfo);
			}

			// Token: 0x0600441E RID: 17438 RVA: 0x00148864 File Offset: 0x00146A64
			public int CanMoveToWayPoint(int destWayPointId)
			{
				return this.m_owner.CanMoveToWayPoint(destWayPointId);
			}

			// Token: 0x0600441F RID: 17439 RVA: 0x00148874 File Offset: 0x00146A74
			public int CanMoveToWayPointExistRandomEvent(int destWayPointId)
			{
				return this.m_owner.CanMoveToWayPointExistRandomEvent(destWayPointId);
			}

			// Token: 0x06004420 RID: 17440 RVA: 0x00148884 File Offset: 0x00146A84
			public void OnOpenRegion(ConfigDataRegionInfo regionInfo)
			{
				this.m_owner.OnOpenRegion(regionInfo);
			}

			// Token: 0x040033CF RID: 13263
			private LevelComponentCommon m_owner;
		}
	}
}
