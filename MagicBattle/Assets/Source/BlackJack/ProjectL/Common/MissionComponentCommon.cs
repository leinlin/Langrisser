using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000486 RID: 1158
	[HotFix]
	public class MissionComponentCommon : IComponentBase
	{
		// Token: 0x0600449A RID: 17562 RVA: 0x0014BDDC File Offset: 0x00149FDC
		public MissionComponentCommon()
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

		// Token: 0x0600449B RID: 17563 RVA: 0x0014BE64 File Offset: 0x0014A064
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
			return "Mission";
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x0014BED8 File Offset: 0x0014A0D8
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

		// Token: 0x0600449D RID: 17565 RVA: 0x0014BF38 File Offset: 0x0014A138
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
			this.m_selectCard = (this.Owner.GetOwnerComponent("SelectCard") as SelectCardComponentCommon);
			this.m_level = (this.Owner.GetOwnerComponent("Level") as LevelComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_thearchyTrial = (this.Owner.GetOwnerComponent("ThearchyTrail") as ThearchyTrialCompomentCommon);
			this.m_anikiGym = (this.Owner.GetOwnerComponent("AnikiGym") as AnikiGymComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_arena = (this.Owner.GetOwnerComponent("Arena") as ArenaComponentCommon);
			this.m_heroDungeon = (this.Owner.GetOwnerComponent("HeroDungeon") as HeroDungeonComponentCommon);
			this.m_heroTrainning = (this.Owner.GetOwnerComponent("HeroTrainning") as HeroTrainningComponentCommon);
			this.m_memoryCorridor = (this.Owner.GetOwnerComponent("MemoryCorridor") as MemoryCorridorCompomentCommon);
			this.m_treasureMap = (this.Owner.GetOwnerComponent("TreasureMap") as TreasureMapComponentCommon);
			this.m_heroPhantom = (this.Owner.GetOwnerComponent("HeroPhantom") as HeroPhantomCompomentCommon);
			this.m_cooperateBattle = (this.Owner.GetOwnerComponent("CooperateBattle") as CooperateBattleCompomentCommon);
			this.m_trainingGround = (this.Owner.GetOwnerComponent("TrainingGround") as TrainingGroundCompomentCommon);
			this.m_team = (this.Owner.GetOwnerComponent("Team") as TeamComponentCommon);
			this.m_heroAssistants = (this.Owner.GetOwnerComponent("HeroAssistants") as HeroAssistantsCompomentCommon);
			this.m_novice = (this.Owner.GetOwnerComponent("Novice") as NoviceComponentCommon);
			this.m_friend = (this.Owner.GetOwnerComponent("Friend") as FriendComponentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
			this.m_realTimePvp = (this.Owner.GetOwnerComponent("RealTimePVP") as RealTimePVPComponentCommon);
			this.m_giftStore = (this.Owner.GetOwnerComponent("GiftStore") as GiftStoreComponentCommon);
			this.m_rechargeStore = (this.Owner.GetOwnerComponent("RechargeStore") as RechargeStoreComponentCommon);
			this.m_basicInfo.LevelUpPlayerLevelEvent += this.UpdateMissionListByLevelUp;
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushEverydayMissionEvent;
			this.m_level.CompleteNewScenarioMissionEvent += this.UpdateMissionListByScenario;
			this.m_resource.MonthCardValidEvent += this.OnMonthCardVaildCallBack;
			this.RegisterMissionCallBack();
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x0014C2A0 File Offset: 0x0014A4A0
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

		// Token: 0x0600449F RID: 17567 RVA: 0x0014C300 File Offset: 0x0014A500
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
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x0014C370 File Offset: 0x0014A570
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

		// Token: 0x060044A1 RID: 17569 RVA: 0x0014C3F0 File Offset: 0x0014A5F0
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

		// Token: 0x060044A2 RID: 17570 RVA: 0x0014C460 File Offset: 0x0014A660
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x0014C4C0 File Offset: 0x0014A6C0
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x0014C534 File Offset: 0x0014A734
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

		// Token: 0x060044A5 RID: 17573 RVA: 0x0014C5AC File Offset: 0x0014A7AC
		public void RemoveProcessingMissionById(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveProcessingMissionByIdInt32_hotfix != null)
			{
				this.m_RemoveProcessingMissionByIdInt32_hotfix.call(new object[]
				{
					this,
					missionId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int missionId = missionId2;
			Mission mission = this.m_missionDS.ProcessingEverydayMissions.Find((Mission t) => t.MissionId == missionId);
			if (mission != null)
			{
				this.m_missionDS.ProcessingEverydayMissions.Remove(mission);
				this.m_missionDS.SetDirty(true);
			}
			mission = this.m_missionDS.ProcessingOneOffMissions.Find((Mission t) => t.MissionId == missionId);
			if (mission != null)
			{
				this.m_missionDS.ProcessingOneOffMissions.Remove(mission);
				this.m_missionDS.SetDirty(true);
			}
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x0014C6AC File Offset: 0x0014A8AC
		private void OnMonthCardVaildEveryDayFlush()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardVaildEveryDayFlush_hotfix != null)
			{
				this.m_OnMonthCardVaildEveryDayFlush_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (MonthCard monthCard in this.m_resource.GetAllValidMonthCards())
			{
				this.OnMonthCardVaildCallBack(monthCard.CardId);
			}
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0014C768 File Offset: 0x0014A968
		private void OnMonthCardVaildCallBack(int monthCardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardVaildCallBackInt32_hotfix != null)
			{
				this.m_OnMonthCardVaildCallBackInt32_hotfix.call(new object[]
				{
					this,
					monthCardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCardId);
			if (configDataMonthCardInfo == null || configDataMonthCardInfo.OpenEverydayTaskId == 0)
			{
				return;
			}
			ConfigDataMissionInfo configDataMissionInfo = this.m_configDataLoader.GetConfigDataMissionInfo(configDataMonthCardInfo.OpenEverydayTaskId);
			if (configDataMissionInfo != null)
			{
				this.AddMission(configDataMissionInfo);
			}
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x0014C818 File Offset: 0x0014AA18
		protected void InitProcessingMission(List<Mission> processingMissionList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitProcessingMissionList`1_hotfix != null)
			{
				this.m_InitProcessingMissionList`1_hotfix.call(new object[]
				{
					this,
					processingMissionList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (processingMissionList.Count == 0)
			{
				return;
			}
			this.InitMissionsFromConfig(processingMissionList);
			List<Mission> list = new List<Mission>();
			List<Mission> list2 = new List<Mission>();
			foreach (Mission mission in processingMissionList)
			{
				if (mission.Config != null)
				{
					if (!mission.Config.Obsoleted)
					{
						if (mission.Config.MissionType == MissionType.MissionType_DirectActivation)
						{
							int relativeSecondsInOneDay = TimeCaculate.GetRelativeSecondsInOneDay(this.m_basicInfo.GetCurrentTime());
							if (relativeSecondsInOneDay >= mission.Config.Param3)
							{
								continue;
							}
							this.OnAddProcessingDirectelyActivitedMission(mission);
						}
						if (!this.IsNoviceMission(mission) || this.IsNoviceMissionActivated(mission))
						{
							if (mission.Config.MissionPeriod == MissionPeriodType.MissionPeriodType_Everyday)
							{
								list.Add(mission);
							}
							else if (mission.Config.MissionPeriod == MissionPeriodType.MissionPeriodType_OneOff)
							{
								list2.Add(mission);
							}
						}
					}
				}
			}
			this.m_missionDS.InitEverydayMissions(list);
			this.m_missionDS.InitOneOffMissions(list2);
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x0014C9BC File Offset: 0x0014ABBC
		public List<Mission> GetProcessingMissionByMissionType(MissionType missionType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetProcessingMissionByMissionTypeMissionType_hotfix != null)
			{
				return (List<Mission>)this.m_GetProcessingMissionByMissionTypeMissionType_hotfix.call(new object[]
				{
					this,
					missionType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> list = new List<Mission>();
			foreach (Mission mission in this.m_missionDS.ProcessingEverydayMissions)
			{
				if (mission.Config.MissionType == missionType)
				{
					list.Add(mission);
				}
			}
			foreach (Mission mission2 in this.m_missionDS.ProcessingOneOffMissions)
			{
				if (mission2.Config.MissionType == missionType)
				{
					list.Add(mission2);
				}
			}
			return list;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x0014CB08 File Offset: 0x0014AD08
		protected void InitExistMissions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitExistMissions_hotfix != null)
			{
				this.m_InitExistMissions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_existMissions.Clear();
			foreach (int item in this.m_missionDS.GetExistMissionIds())
			{
				this.m_existMissions.Add(item);
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x0014CBD0 File Offset: 0x0014ADD0
		private void OnFlushEverydayMissionEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushEverydayMissionEvent_hotfix != null)
			{
				this.m_OnFlushEverydayMissionEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnLoginGameCallBack();
			this.ResetEverydayMissions();
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0014CC3C File Offset: 0x0014AE3C
		protected virtual void ResetEverydayMissions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetEverydayMissions_hotfix != null)
			{
				this.m_ResetEverydayMissions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_missionDS.ResetEverydayMissions();
			this.m_lockedMissionConfigsInLogic.RemoveWhere((ConfigDataMissionInfo t) => t.MissionPeriod == MissionPeriodType.MissionPeriodType_Everyday);
			this.InitExistMissions();
			this.InitMissionListByMissionPeriodType(MissionPeriodType.MissionPeriodType_Everyday);
			this.OnMonthCardVaildEveryDayFlush();
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x0014CCE4 File Offset: 0x0014AEE4
		protected void InitMissionListByMissionPeriodType(MissionPeriodType missionPeriod)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMissionListByMissionPeriodTypeMissionPeriodType_hotfix != null)
			{
				this.m_InitMissionListByMissionPeriodTypeMissionPeriodType_hotfix.call(new object[]
				{
					this,
					missionPeriod
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> list = null;
			if (missionPeriod != MissionPeriodType.MissionPeriodType_Everyday)
			{
				if (missionPeriod == MissionPeriodType.MissionPeriodType_OneOff)
				{
					list = this.m_configDataLoader.MissionData.OneOffMissions;
				}
			}
			else
			{
				list = this.m_configDataLoader.MissionData.EverydayMissions;
			}
			foreach (ConfigDataMissionInfo configDataMissionInfo in list)
			{
				if (!this.IsMissionExist(configDataMissionInfo.ID))
				{
					if (!configDataMissionInfo.Obsoleted)
					{
						if (!configDataMissionInfo.IsMonthCardMission)
						{
							if (this.CanUnlockMissionInLogicFromInit(configDataMissionInfo))
							{
								this.AddMission(configDataMissionInfo);
							}
							else if (!this.IsNoviceMission(configDataMissionInfo))
							{
								if (configDataMissionInfo.MissionType == MissionType.MissionType_DirectActivation)
								{
									DirectlyActivatedMissionSatatus directlyActivatedMissionSatatus = this.CaculateDirectlyActivationMissionStatus(configDataMissionInfo);
									if (directlyActivatedMissionSatatus != DirectlyActivatedMissionSatatus.Expired && directlyActivatedMissionSatatus != DirectlyActivatedMissionSatatus.NotOnToday)
									{
										this.OnDirectActivatedMissionLocked(configDataMissionInfo);
									}
								}
								else
								{
									this.m_lockedMissionConfigsInLogic.Add(configDataMissionInfo);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x0014CE78 File Offset: 0x0014B078
		protected virtual bool CanUnlockMissionInLogicFromInit(ConfigDataMissionInfo missionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockMissionInLogicFromInitConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUnlockMissionInLogicFromInitConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					missionInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.CanUnlockMissionInLogic(missionInfo);
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x0014CEFC File Offset: 0x0014B0FC
		protected virtual void OnDirectActivatedMissionLocked(ConfigDataMissionInfo missionConfig)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDirectActivatedMissionLockedConfigDataMissionInfo_hotfix != null)
			{
				this.m_OnDirectActivatedMissionLockedConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					missionConfig
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x0014CF6C File Offset: 0x0014B16C
		protected bool IsNoviceMission(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNoviceMissionMission_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNoviceMissionMission_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsNoviceMission(mission.Config);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x0014CFF4 File Offset: 0x0014B1F4
		protected bool IsNoviceMission(ConfigDataMissionInfo mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNoviceMissionConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNoviceMissionConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mission.m_Novice != null;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x0014D07C File Offset: 0x0014B27C
		protected bool IsNoviceMissionActivated(ConfigDataMissionInfo mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNoviceMissionActivatedConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNoviceMissionActivatedConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime date = this.m_basicInfo.GetCreateTime().Date;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return currentTime < date + new TimeSpan(10000000L * (long)mission.m_Novice.DeactivateTime);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x0014D13C File Offset: 0x0014B33C
		protected bool IsNoviceMissionActivatedForRewarding(ConfigDataMissionInfo mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNoviceMissionActivatedForRewardingConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNoviceMissionActivatedForRewardingConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime date = this.m_basicInfo.GetCreateTime().Date;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return date + new TimeSpan(10000000L * (long)mission.m_Novice.ActivateTime) < currentTime && currentTime < date + new TimeSpan(10000000L * (long)mission.m_Novice.DeactivateTime);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x0014D228 File Offset: 0x0014B428
		protected bool IsNoviceMissionActivated(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNoviceMissionActivatedMission_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNoviceMissionActivatedMission_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsNoviceMissionActivated(mission.Config);
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x0014D2B0 File Offset: 0x0014B4B0
		public bool CanGetRewarding(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetRewardingMission_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanGetRewardingMission_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsMissionFinished(mission.MissionId))
			{
				return false;
			}
			if (this.IsNoviceMission(mission) && (!this.IsNoviceMissionActivated(mission) || !this.IsNoviceMissionActivatedForRewarding(mission.Config)))
			{
				return false;
			}
			switch (mission.Config.MissionType)
			{
			case MissionType.MissionType_CardPoolSelectCard:
			case MissionType.MissionType_SummonHero:
			case MissionType.MissionType_HeroMasterJobNums:
			case MissionType.MissionType_HaveStarHeroNums:
			case MissionType.MissionType_RankJobHeroNums:
			case MissionType.MissionType_SpecificHeroFightNums:
			case MissionType.MissionType_HasAboveLevelHeroNums:
			case MissionType.MissionType_HaveRankHeroNums:
			case MissionType.MissionType_SpecificHeroReachSpecificLevel:
			case MissionType.MissionType_RealTimeArena:
			case MissionType.MissionType_BuyGiftStoreGoods:
			case MissionType.MissionType_BuyRechargeStoreGoods:
			case MissionType.MissionType_MissionSelectCard:
				return mission.CompletedProcess >= (long)mission.Config.Param2;
			case MissionType.MissionType_ConsumeEnergy:
			case MissionType.MissionType_CompleteEvent:
			case MissionType.MissionType_ComleteSimpleRiftLevel:
			case MissionType.MissionType_ComleteDiffcultRiftLevel:
			case MissionType.MissionType_GetRiftLevelFightAchievement:
			case MissionType.MissionType_GetRiftLevelFightStar:
			case MissionType.MissionType_ConsumeCrystal:
			case MissionType.MissionType_ConsumeGold:
			case MissionType.MissionType_UseAnyHeroExpItem:
			case MissionType.MissionType_AllHeroAllJobLevelUpNums:
			case MissionType.MissionType_AllHerohaveJobNums:
			case MissionType.MissionType_AllHeroHaveSkillNums:
			case MissionType.MissionType_AllHeroHaveSoliderNums:
			case MissionType.MissionType_AllJobMasterHeroNums:
			case MissionType.MissionType_PlayerLevelUp:
			case MissionType.MissionType_UseCrystalBuyEnergyNums:
			case MissionType.MissionType_LoginGameDays:
			case MissionType.MissionType_ArenaConsecutiveVictoryNums:
			case MissionType.MissionType_TransferNewJobNums:
			case MissionType.MissionType_TrainingTechToLevel:
			case MissionType.MissionType_EquipmentToLevel:
			case MissionType.MissionType_FinishTeamBattle:
			case MissionType.MissionType_FavorabilityToLevel:
			case MissionType.MissionType_FetterToLevel:
			case MissionType.MissionType_EnchatEquipments:
			case MissionType.MissionType_TotalHeroJobLevelUp:
			case MissionType.MissionType_AddFriend:
			case MissionType.MissionType_AssignHeroToTask:
			case MissionType.MissionType_BattlePractice:
			case MissionType.MissionType_ReachedSpecificRealTimeArenaDan:
			case MissionType.MissionType_DailyEquipmentEnchant:
			case MissionType.MissionType_Share:
				return mission.CompletedProcess >= (long)mission.Config.Param1;
			case MissionType.MissionType_CompleteLevel:
				return mission.CompletedProcess >= (long)mission.Config.Param4;
			case MissionType.MissionType_DirectActivation:
				return this.CaculateDirectlyActivationMissionStatus(mission.Config) == DirectlyActivatedMissionSatatus.Activated;
			case MissionType.MissionType_CompleteAllEverydayMission:
				foreach (Mission mission2 in this.m_missionDS.ProcessingEverydayMissions)
				{
					if (mission2.Config.MissionType != MissionType.MissionType_CompleteAllEverydayMission)
					{
						if (mission2.Config.MissionType != MissionType.MissionType_DirectActivation || this.CaculateDirectlyActivationMissionStatus(mission2.Config) != DirectlyActivatedMissionSatatus.Expired)
						{
							if (!this.CanGetRewarding(mission2))
							{
								return false;
							}
						}
					}
				}
				return true;
			case MissionType.MissionType_CompleteScenario:
			case MissionType.MissionType_CompleteBattleAchievement:
			case MissionType.MissionType_SpecificHeroMasterSpecificJobRelationId:
				return mission.CompletedProcess > 0L;
			default:
				return false;
			}
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x0014D558 File Offset: 0x0014B758
		protected bool CanUnlockMissionInLogic(ConfigDataMissionInfo missionConfigInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockMissionInLogicConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUnlockMissionInLogicConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					missionConfigInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsNoviceMission(missionConfigInfo))
			{
				return this.IsNoviceMissionActivated(missionConfigInfo) && this.CanUnlockMission(missionConfigInfo);
			}
			MissionPeriodType missionPeriod = missionConfigInfo.MissionPeriod;
			if (missionPeriod != MissionPeriodType.MissionPeriodType_Everyday)
			{
				return missionPeriod == MissionPeriodType.MissionPeriodType_OneOff;
			}
			return this.CanUnlockMission(missionConfigInfo);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x0014D61C File Offset: 0x0014B81C
		protected bool CanUnlockMission(ConfigDataMissionInfo missionConfigInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockMissionConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUnlockMissionConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					missionConfigInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (missionConfigInfo.Obsoleted || missionConfigInfo.IsMonthCardMission)
			{
				return false;
			}
			if (this.m_basicInfo.GetLevel() >= missionConfigInfo.MissionUnlockPlayerLvl && (missionConfigInfo.MissionUnlockScenarioID == 0 || this.m_level.IsScenarioCompleted(missionConfigInfo.MissionUnlockScenarioID)) && (missionConfigInfo.MissionUnlockPreTaskID == 0 || this.IsCompleted(missionConfigInfo.MissionUnlockPreTaskID)))
			{
				DirectlyActivatedMissionSatatus directlyActivatedMissionSatatus = this.CaculateDirectlyActivationMissionStatus(missionConfigInfo);
				return directlyActivatedMissionSatatus == DirectlyActivatedMissionSatatus.None || directlyActivatedMissionSatatus == DirectlyActivatedMissionSatatus.Activated;
			}
			return false;
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x0014D71C File Offset: 0x0014B91C
		protected DirectlyActivatedMissionSatatus CaculateDirectlyActivationMissionStatus(ConfigDataMissionInfo missionConfigInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaculateDirectlyActivationMissionStatusConfigDataMissionInfo_hotfix != null)
			{
				return (DirectlyActivatedMissionSatatus)this.m_CaculateDirectlyActivationMissionStatusConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					missionConfigInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (missionConfigInfo.MissionType != MissionType.MissionType_DirectActivation)
			{
				return DirectlyActivatedMissionSatatus.None;
			}
			DayOfWeek dayOfWeek = this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int num = (int)((dayOfWeek != DayOfWeek.Sunday) ? dayOfWeek : ((DayOfWeek)7));
			int relativeSecondsInOneDay = TimeCaculate.GetRelativeSecondsInOneDay(this.m_basicInfo.GetCurrentTime());
			if (missionConfigInfo.Param1 != 0 && num != missionConfigInfo.Param1)
			{
				return DirectlyActivatedMissionSatatus.NotOnToday;
			}
			if (missionConfigInfo.Param2 > relativeSecondsInOneDay)
			{
				return DirectlyActivatedMissionSatatus.Locked;
			}
			if (missionConfigInfo.Param3 <= relativeSecondsInOneDay)
			{
				return DirectlyActivatedMissionSatatus.Expired;
			}
			return DirectlyActivatedMissionSatatus.Activated;
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x0014D810 File Offset: 0x0014BA10
		protected bool AddMission(ConfigDataMissionInfo missionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMissionConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AddMissionConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					missionInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (missionInfo.Obsoleted || this.IsMissionExist(missionInfo.ID))
			{
				return false;
			}
			Mission mission = new Mission(missionInfo.ID);
			mission.Config = missionInfo;
			if (missionInfo.MissionPeriod == MissionPeriodType.MissionPeriodType_Everyday)
			{
				this.AddEverydayMission(mission);
			}
			else if (missionInfo.MissionPeriod == MissionPeriodType.MissionPeriodType_OneOff)
			{
				this.AddOneOffMission(mission);
			}
			this.m_missionDS.SetDirty(true);
			if (mission.Config.MissionType == MissionType.MissionType_DirectActivation)
			{
				this.OnAddProcessingDirectelyActivitedMission(mission);
			}
			if (this.m_lockedMissionConfigsInLogic.Contains(missionInfo))
			{
				this.m_lockedMissionConfigsInLogic.Remove(missionInfo);
			}
			this.m_existMissions.Add(missionInfo.ID);
			return true;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x0014D940 File Offset: 0x0014BB40
		protected virtual void OnAddProcessingDirectelyActivitedMission(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddProcessingDirectelyActivitedMissionMission_hotfix != null)
			{
				this.m_OnAddProcessingDirectelyActivitedMissionMission_hotfix.call(new object[]
				{
					this,
					mission
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x0014D9B0 File Offset: 0x0014BBB0
		protected Mission GetProcessingMissionByMissionPeriod(MissionPeriodType missionPeriodType, int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetProcessingMissionByMissionPeriodMissionPeriodTypeInt32_hotfix != null)
			{
				return (Mission)this.m_GetProcessingMissionByMissionPeriodMissionPeriodTypeInt32_hotfix.call(new object[]
				{
					this,
					missionPeriodType,
					missionId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int missionId = missionId2;
			Mission mission = null;
			if (missionPeriodType != MissionPeriodType.MissionPeriodType_Everyday)
			{
				if (missionPeriodType == MissionPeriodType.MissionPeriodType_OneOff)
				{
					mission = this.m_missionDS.ProcessingOneOffMissions.Find((Mission t) => t.MissionId == missionId);
				}
			}
			else
			{
				mission = this.m_missionDS.ProcessingEverydayMissions.Find((Mission t) => t.MissionId == missionId);
			}
			if (mission == null)
			{
				return null;
			}
			if (mission.Config.MissionType == MissionType.MissionType_DirectActivation && this.CaculateDirectlyActivationMissionStatus(mission.Config) == DirectlyActivatedMissionSatatus.Expired)
			{
				this.OnGetProcessingDirectActivationMissionFail(mission);
				return null;
			}
			return mission;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x0014DAD8 File Offset: 0x0014BCD8
		protected virtual void OnGetProcessingDirectActivationMissionFail(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetProcessingDirectActivationMissionFailMission_hotfix != null)
			{
				this.m_OnGetProcessingDirectActivationMissionFailMission_hotfix.call(new object[]
				{
					this,
					mission
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x0014DB48 File Offset: 0x0014BD48
		private void AddEverydayMission(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddEverydayMissionMission_hotfix != null)
			{
				this.m_AddEverydayMissionMission_hotfix.call(new object[]
				{
					this,
					mission
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (mission.Config.MissionType == MissionType.MissionType_DirectActivation)
			{
				mission.CompletedProcess = 1L;
			}
			this.m_missionDS.AddEverydayMission(mission);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x0014DBE0 File Offset: 0x0014BDE0
		protected virtual void AddOneOffMission(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddOneOffMissionMission_hotfix != null)
			{
				this.m_AddOneOffMissionMission_hotfix.call(new object[]
				{
					this,
					mission
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_missionDS.AddOneOffMission(mission);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x0014DC5C File Offset: 0x0014BE5C
		private bool IsMissionExist(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMissionExistInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMissionExistInt32_hotfix.call(new object[]
				{
					this,
					missionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_existMissions.Contains(missionId);
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x0014DCE4 File Offset: 0x0014BEE4
		public bool IsMissionFinished(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMissionFinishedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMissionFinishedInt32_hotfix.call(new object[]
				{
					this,
					missionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_missionDS.FinishedEverydayMissions.Contains(missionId) || this.m_missionDS.FinishedOneOffMissions.Contains(missionId);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x0014DD8C File Offset: 0x0014BF8C
		protected void InitMissionsFromConfig(List<Mission> missions)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMissionsFromConfigList`1_hotfix != null)
			{
				this.m_InitMissionsFromConfigList`1_hotfix.call(new object[]
				{
					this,
					missions
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (Mission mission in missions)
			{
				mission.Config = this.m_configDataLoader.GetConfigDataMissionInfo(mission.MissionId);
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x0014DE58 File Offset: 0x0014C058
		protected void FinishMission(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishMissionMission_hotfix != null)
			{
				this.m_FinishMissionMission_hotfix.call(new object[]
				{
					this,
					mission
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (mission.Config.MissionPeriod == MissionPeriodType.MissionPeriodType_Everyday)
			{
				this.m_missionDS.FinishEverydayMission(mission);
			}
			if (mission.Config.MissionPeriod == MissionPeriodType.MissionPeriodType_OneOff)
			{
				this.m_missionDS.FinishOneOffMission(mission);
			}
			this.UpdateMissionListByMissionComplete(mission.MissionId);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x0014DF10 File Offset: 0x0014C110
		private List<ConfigDataMissionInfo> GetAllEverydayMissionConfigByPreMissionId(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllEverydayMissionConfigByPreMissionIdInt32_hotfix != null)
			{
				return (List<ConfigDataMissionInfo>)this.m_GetAllEverydayMissionConfigByPreMissionIdInt32_hotfix.call(new object[]
				{
					this,
					missionId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> list = new List<ConfigDataMissionInfo>();
			foreach (ConfigDataMissionInfo configDataMissionInfo in this.m_lockedMissionConfigsInLogic)
			{
				if (configDataMissionInfo.MissionUnlockPreTaskID == missionId)
				{
					list.Add(configDataMissionInfo);
				}
			}
			return list;
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x0014DFF0 File Offset: 0x0014C1F0
		private List<ConfigDataMissionInfo> GetAllEverydayMissionListByPlayerLevel(int playerLvl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllEverydayMissionListByPlayerLevelInt32_hotfix != null)
			{
				return (List<ConfigDataMissionInfo>)this.m_GetAllEverydayMissionListByPlayerLevelInt32_hotfix.call(new object[]
				{
					this,
					playerLvl
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> list = new List<ConfigDataMissionInfo>();
			foreach (ConfigDataMissionInfo configDataMissionInfo in this.m_lockedMissionConfigsInLogic)
			{
				if (configDataMissionInfo.MissionUnlockPlayerLvl <= playerLvl)
				{
					list.Add(configDataMissionInfo);
				}
			}
			return list;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x0014E0D0 File Offset: 0x0014C2D0
		private List<ConfigDataMissionInfo> GetAllEverydayMissionListByScenario(int scenario)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllEverydayMissionListByScenarioInt32_hotfix != null)
			{
				return (List<ConfigDataMissionInfo>)this.m_GetAllEverydayMissionListByScenarioInt32_hotfix.call(new object[]
				{
					this,
					scenario
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> list = new List<ConfigDataMissionInfo>();
			foreach (ConfigDataMissionInfo configDataMissionInfo in this.m_lockedMissionConfigsInLogic)
			{
				if (configDataMissionInfo.MissionUnlockScenarioID == scenario)
				{
					list.Add(configDataMissionInfo);
				}
			}
			return list;
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x0014E1B0 File Offset: 0x0014C3B0
		public List<Mission> GetAllProcessingNoviceMissionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllProcessingNoviceMissionList_hotfix != null)
			{
				return (List<Mission>)this.m_GetAllProcessingNoviceMissionList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> list = new List<Mission>();
			foreach (Mission mission in this.m_missionDS.ProcessingEverydayMissions)
			{
				if (this.IsNoviceMission(mission))
				{
					list.InsertInOrder(mission, delegate(Mission x, Mission y)
					{
						int num = x.Config.m_Novice.ActivateTime - y.Config.m_Novice.ActivateTime;
						if (num != 0)
						{
							return num;
						}
						return x.MissionId - y.MissionId;
					}, true);
				}
			}
			foreach (Mission mission2 in this.m_missionDS.ProcessingOneOffMissions)
			{
				if (this.IsNoviceMission(mission2))
				{
					list.InsertInOrder(mission2, delegate(Mission x, Mission y)
					{
						int num = x.Config.m_Novice.ActivateTime - y.Config.m_Novice.ActivateTime;
						if (num != 0)
						{
							return num;
						}
						return x.MissionId - y.MissionId;
					}, true);
				}
			}
			return list;
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x0014E320 File Offset: 0x0014C520
		public List<Mission> GetAllFinishedNoviceMissionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllFinishedNoviceMissionList_hotfix != null)
			{
				return (List<Mission>)this.m_GetAllFinishedNoviceMissionList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> list = new List<Mission>();
			foreach (int num in this.m_missionDS.FinishedEverydayMissions)
			{
				ConfigDataMissionInfo configDataMissionInfo = this.m_configDataLoader.GetConfigDataMissionInfo(num);
				if (this.IsNoviceMission(configDataMissionInfo) && !configDataMissionInfo.Obsoleted)
				{
					list.Add(new Mission(num));
				}
			}
			foreach (int num2 in this.m_missionDS.FinishedOneOffMissions)
			{
				ConfigDataMissionInfo configDataMissionInfo2 = this.m_configDataLoader.GetConfigDataMissionInfo(num2);
				if (this.IsNoviceMission(configDataMissionInfo2) && !configDataMissionInfo2.Obsoleted)
				{
					list.Add(new Mission(num2));
				}
			}
			this.InitMissionsFromConfig(list);
			return list;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x0014E498 File Offset: 0x0014C698
		private void UpdateMissionListByMissionComplete(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMissionListByMissionCompleteInt32_hotfix != null)
			{
				this.m_UpdateMissionListByMissionCompleteInt32_hotfix.call(new object[]
				{
					this,
					missionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> allEverydayMissionConfigByPreMissionId = this.GetAllEverydayMissionConfigByPreMissionId(missionId);
			this.UpdateMissionListByNewMissionConfigList(allEverydayMissionConfigByPreMissionId);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x0014E518 File Offset: 0x0014C718
		private void UpdateMissionListByLevelUp(int playerLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMissionListByLevelUpInt32_hotfix != null)
			{
				this.m_UpdateMissionListByLevelUpInt32_hotfix.call(new object[]
				{
					this,
					playerLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> allEverydayMissionListByPlayerLevel = this.GetAllEverydayMissionListByPlayerLevel(playerLevel);
			this.UpdateMissionListByNewMissionConfigList(allEverydayMissionListByPlayerLevel);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x0014E598 File Offset: 0x0014C798
		private void UpdateMissionListByScenario(int scenarioId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMissionListByScenarioInt32_hotfix != null)
			{
				this.m_UpdateMissionListByScenarioInt32_hotfix.call(new object[]
				{
					this,
					scenarioId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataMissionInfo> allEverydayMissionListByScenario = this.GetAllEverydayMissionListByScenario(scenarioId);
			this.UpdateMissionListByNewMissionConfigList(allEverydayMissionListByScenario);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x0014E618 File Offset: 0x0014C818
		private void UpdateMissionListByNewMissionConfigList(List<ConfigDataMissionInfo> newMissionConfigList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMissionListByNewMissionConfigListList`1_hotfix != null)
			{
				this.m_UpdateMissionListByNewMissionConfigListList`1_hotfix.call(new object[]
				{
					this,
					newMissionConfigList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ConfigDataMissionInfo configDataMissionInfo in newMissionConfigList)
			{
				if (!this.IsMissionExist(configDataMissionInfo.ID))
				{
					if (this.CanUnlockMissionInLogic(configDataMissionInfo))
					{
						this.AddMission(configDataMissionInfo);
					}
				}
			}
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x0014E6F8 File Offset: 0x0014C8F8
		protected void AddMissionProcess(Mission mission, long process)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMissionProcessMissionInt64_hotfix != null)
			{
				this.m_AddMissionProcessMissionInt64_hotfix.call(new object[]
				{
					this,
					mission,
					process
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int missionMaxProcess = this.GetMissionMaxProcess(mission);
			if (mission.CompletedProcess >= (long)missionMaxProcess)
			{
				if (!this.IsCompleted(mission.MissionId) && mission.Config.Reward.Count == 0 && !this.IsNoviceMission(mission))
				{
					this.FinishMission(mission);
				}
				return;
			}
			long count = process;
			long num = mission.CompletedProcess + process;
			if (num >= (long)missionMaxProcess)
			{
				if (mission.Config.Reward.Count == 0 && !this.IsNoviceMission(mission))
				{
					this.FinishMission(mission);
					return;
				}
				count = (long)missionMaxProcess - mission.CompletedProcess;
			}
			this.m_missionDS.AddMissionProcess(mission, count);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x0014E81C File Offset: 0x0014CA1C
		public int GetMissionMaxProcess(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissionMaxProcessMission_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMissionMaxProcessMission_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (mission.Config.MissionType)
			{
			case MissionType.MissionType_CardPoolSelectCard:
			case MissionType.MissionType_SummonHero:
			case MissionType.MissionType_HeroMasterJobNums:
			case MissionType.MissionType_HaveStarHeroNums:
			case MissionType.MissionType_RankJobHeroNums:
			case MissionType.MissionType_SpecificHeroFightNums:
			case MissionType.MissionType_HasAboveLevelHeroNums:
			case MissionType.MissionType_HaveRankHeroNums:
			case MissionType.MissionType_SpecificHeroReachSpecificLevel:
			case MissionType.MissionType_RealTimeArena:
			case MissionType.MissionType_BuyGiftStoreGoods:
			case MissionType.MissionType_BuyRechargeStoreGoods:
			case MissionType.MissionType_MissionSelectCard:
				return mission.Config.Param2;
			case MissionType.MissionType_ConsumeEnergy:
			case MissionType.MissionType_CompleteEvent:
			case MissionType.MissionType_ComleteSimpleRiftLevel:
			case MissionType.MissionType_ComleteDiffcultRiftLevel:
			case MissionType.MissionType_GetRiftLevelFightAchievement:
			case MissionType.MissionType_GetRiftLevelFightStar:
			case MissionType.MissionType_ConsumeCrystal:
			case MissionType.MissionType_ConsumeGold:
			case MissionType.MissionType_UseAnyHeroExpItem:
			case MissionType.MissionType_AllHeroAllJobLevelUpNums:
			case MissionType.MissionType_AllHerohaveJobNums:
			case MissionType.MissionType_AllHeroHaveSkillNums:
			case MissionType.MissionType_AllHeroHaveSoliderNums:
			case MissionType.MissionType_AllJobMasterHeroNums:
			case MissionType.MissionType_PlayerLevelUp:
			case MissionType.MissionType_UseCrystalBuyEnergyNums:
			case MissionType.MissionType_LoginGameDays:
			case MissionType.MissionType_ArenaConsecutiveVictoryNums:
			case MissionType.MissionType_TransferNewJobNums:
			case MissionType.MissionType_TrainingTechToLevel:
			case MissionType.MissionType_EquipmentToLevel:
			case MissionType.MissionType_FinishTeamBattle:
			case MissionType.MissionType_FavorabilityToLevel:
			case MissionType.MissionType_FetterToLevel:
			case MissionType.MissionType_EnchatEquipments:
			case MissionType.MissionType_TotalHeroJobLevelUp:
			case MissionType.MissionType_AddFriend:
			case MissionType.MissionType_AssignHeroToTask:
			case MissionType.MissionType_BattlePractice:
			case MissionType.MissionType_ReachedSpecificRealTimeArenaDan:
			case MissionType.MissionType_DailyEquipmentEnchant:
			case MissionType.MissionType_Share:
				return mission.Config.Param1;
			case MissionType.MissionType_CompleteLevel:
				return mission.Config.Param4;
			case MissionType.MissionType_DirectActivation:
			case MissionType.MissionType_CompleteAllEverydayMission:
			case MissionType.MissionType_CompleteScenario:
			case MissionType.MissionType_CompleteBattleAchievement:
			case MissionType.MissionType_SpecificHeroMasterSpecificJobRelationId:
				return 1;
			default:
				return int.MaxValue;
			}
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x0014E9A8 File Offset: 0x0014CBA8
		public bool IsMissionProcessFinished(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMissionProcessFinishedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMissionProcessFinishedInt32_hotfix.call(new object[]
				{
					this,
					missionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMissionInfo configDataMissionInfo = this.m_configDataLoader.GetConfigDataMissionInfo(missionId);
			if (configDataMissionInfo == null)
			{
				return false;
			}
			if (this.IsMissionFinished(missionId))
			{
				return true;
			}
			Mission processingMissionByMissionPeriod = this.GetProcessingMissionByMissionPeriod(configDataMissionInfo.MissionPeriod, configDataMissionInfo.ID);
			return processingMissionByMissionPeriod != null && this.CanGetRewarding(processingMissionByMissionPeriod);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x0014EA6C File Offset: 0x0014CC6C
		public virtual int CanGainMissionReward(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGainMissionRewardInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGainMissionRewardInt32_hotfix.call(new object[]
				{
					this,
					missionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMissionInfo configDataMissionInfo = this.m_configDataLoader.GetConfigDataMissionInfo(missionId);
			if (configDataMissionInfo == null)
			{
				return -1600;
			}
			Mission processingMissionByMissionPeriod = this.GetProcessingMissionByMissionPeriod(configDataMissionInfo.MissionPeriod, configDataMissionInfo.ID);
			if (processingMissionByMissionPeriod == null)
			{
				return -1603;
			}
			if (this.IsMissionFinished(missionId))
			{
				return -1605;
			}
			if (!this.CanGetRewarding(processingMissionByMissionPeriod))
			{
				return -1601;
			}
			foreach (Goods goods in processingMissionByMissionPeriod.Config.Reward)
			{
				if (BagItemBase.IsBagItem(goods.GoodsType))
				{
					if (this.m_bag.IsBagFullByCurrentSize())
					{
						return -500;
					}
					break;
				}
			}
			return 0;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x0014EBC8 File Offset: 0x0014CDC8
		private void RegisterMissionCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterMissionCallBack_hotfix != null)
			{
				this.m_RegisterMissionCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectCard.SelectCardMissionEvent += this.OnSelectCardMissionCallBack;
			this.m_selectCard.SelectCardMissionEvent += this.OnMissionSelectCardCallBack;
			this.m_selectCard.SummonHeroMissionEvent += this.OnSummonHeroCallBack;
			this.m_level.CompleteEventMissionEvent += this.OnCompleteEventCallBack;
			this.m_level.CompleteScenarioMissionEvent += this.OnCompleteScenaioCallBack;
			this.m_rift.CompleteRiftLevelMissionEvent += this.OnCompleteLevelCallBack;
			this.m_rift.GetRiftLevelAchievementMissionEvent += this.OnGetRiftLevelFightAchievementCallBack;
			this.m_rift.GetRiftLevelFightStarMissionEvent += this.OnGetRiftLevelStarCallBack;
			this.m_basicInfo.ConsumeEnergyMissionEvent += this.OnConsumeEnergyCallBack;
			this.m_basicInfo.LevelUpPlayerLevelMissionEvent += this.OnLevelUpPlayerLevelCallBack;
			this.m_basicInfo.ConsumeCrystalMissionEvent += this.OnConsumeCrystalCallBack;
			this.m_basicInfo.ConsumeGoldMissionEvent += this.OnComsumeGoldCallBack;
			this.m_basicInfo.AddBuyEnergyMissionEvent += this.OnUseCrystalBuyEnergyCallBack;
			this.m_basicInfo.DoShareEvent += this.OnDoShareCallBack;
			this.m_bag.UseHeroExpItemMissionEvent += this.OnUseHeroExpItemCallBack;
			this.m_bag.EquipmentLevelupMissionEvent += this.OnEquipmentToLevelCallBack;
			this.m_bag.EnchantEquipmentsMissionEvent += this.OnEnchantEquipmentCallBack;
			this.m_bag.EnchantEquipmentPropertiesSaveMissionEvent += this.OnEnchantPropertiesSaveCallBack;
			this.m_hero.SpecificHeroFightMissionEvent += this.OnSpecificHeroFight;
			this.m_hero.HeroNewJobTransferMissionEvent += this.OnNewHeroJobTransferCallBack;
			this.m_hero.HeroJobLevelUpMissionEvent += this.OnAllHeroAllJobLevelUpCallBack;
			this.m_hero.AddHeroJobMissionEvent += this.OnAllHeroAddJobNums;
			this.m_hero.AddHeroJobMissionEvent += this.OnRankJobHaveCallBack;
			this.m_hero.HeroJobMasterMissionEvent += this.OnHeroMasterJobCallBack;
			this.m_hero.AddHeroJobSkillMissionEvent += this.OnAllHeroAddSkillNumsCallBack;
			this.m_hero.AddHeroJobSoliderMissionEvent += this.OnAllHeroAddSoliderNumsCallBack;
			this.m_hero.AddHeroMissionEvent += this.OnAddHeroNumsCallBack;
			this.m_hero.HeroLevelUpMissionEvent += this.OnSpecificHeroLevelUp;
			this.m_hero.LevelUpHeroStarLevelMissionEvent += this.OnLevelUpHeroStarLevelCallBack;
			HeroComponentCommon hero = this.m_hero;
			hero.HeroFavorabilityLevelupMissionEvent = (Action<Hero>)Delegate.Combine(hero.HeroFavorabilityLevelupMissionEvent, new Action<Hero>(this.OnFavorabilityToLevelCallBack));
			this.m_hero.HeroJobLevelUpMissionEvent += this.OnTotalHeroJobLevelUpCallBack;
			HeroComponentCommon hero2 = this.m_hero;
			hero2.HeroFetterLevelupMissionEvent = (Action<Hero, int>)Delegate.Combine(hero2.HeroFetterLevelupMissionEvent, new Action<Hero, int>(this.OnFetterToLevelCallBack));
			this.m_thearchyTrial.CompleteThearchyTrialMissionEvent += this.OnCompleteLevelCallBack;
			this.m_anikiGym.CompleteAnikiGymMissionEvent += this.OnCompleteLevelCallBack;
			ArenaComponentCommon arena = this.m_arena;
			arena.ArenaAttackMissionEvent = (Action<BattleType, int, List<int>>)Delegate.Combine(arena.ArenaAttackMissionEvent, new Action<BattleType, int, List<int>>(this.OnCompleteLevelCallBack));
			ArenaComponentCommon arena2 = this.m_arena;
			arena2.ArenaConsecutiveVictoryEvent = (Action<int>)Delegate.Combine(arena2.ArenaConsecutiveVictoryEvent, new Action<int>(this.OnArenaConsecutiveVictoryCallBack));
			ArenaComponentCommon arena3 = this.m_arena;
			arena3.ArenaFightEvent = (Action)Delegate.Combine(arena3.ArenaFightEvent, new Action(this.OnArenaFightCallBack));
			this.m_heroDungeon.CompleteHeroDungeonLevelMissionEvent += this.OnCompleteLevelCallBack;
			this.m_heroTrainning.CompleteHeroTrainningMissionEvent += this.OnCompleteLevelCallBack;
			this.m_memoryCorridor.CompleteMemoryCorridorMissionEvent += this.OnCompleteLevelCallBack;
			this.m_treasureMap.CompleteTreasureMapMissionEvent += this.OnCompleteLevelCallBack;
			this.m_heroPhantom.CompleteHeroPhantomMissionEvent += this.OnCompleteLevelCallBack;
			this.m_heroPhantom.GetBattleAchievementMissionEvent += this.OnFinishFightAchievementCallBack;
			this.m_cooperateBattle.CompleteCooperateBattleMissionEvent += this.OnCompleteLevelCallBack;
			this.m_trainingGround.TrainingTechLevelupMissionEvent += this.OnTrainingTechToLevelCallBack;
			TeamComponentCommon team = this.m_team;
			team.FinishTeamBattleMissionEvent = (Action)Delegate.Combine(team.FinishTeamBattleMissionEvent, new Action(this.OnFinishTeamBattleCallBack));
			this.m_heroAssistants.AssignHeroToTaskMissionEvent += this.OnAssignHeroToTaskCallBack;
			this.m_battle.BattlePracticeMissionEvent += this.OnBattlePracticeCallBack;
			this.m_friend.InviteFriendMissionEvent += this.OnInviteFriendCallBack;
			this.m_realTimePvp.RealTimeArenaBattleStartMissionEvent += this.OnRealTimeArenaBattleStartCallBack;
			this.m_realTimePvp.RealTimeArenaBattleFinishMissionEvent += this.OnRealTimeArenaBattleFinishCallBack;
			this.m_realTimePvp.RealTimeArenaDanUpdateMissionEvent += this.OnRealTimeArenaDanUpdateCallBack;
			this.m_giftStore.BuyGiftStoreGoodsEvent += this.OnBuyGiftStoreGoodsCallBack;
			this.m_rechargeStore.BuyRechargeStoreGoodsEvent += this.OnBuyRechargeStoreGoodsCallBack;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x0014F164 File Offset: 0x0014D364
		protected bool IsCompleted(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCompletedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCompletedInt32_hotfix.call(new object[]
				{
					this,
					missionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_missionDS.FinishedEverydayMissions.Contains(missionId) || this.m_missionDS.FinishedOneOffMissions.Contains(missionId);
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x0014F210 File Offset: 0x0014D410
		private void OnSelectCardMissionCallBack(int cardPoolId, int selectCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectCardMissionCallBackInt32Int32_hotfix != null)
			{
				this.m_OnSelectCardMissionCallBackInt32Int32_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					selectCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (selectCount <= 0)
			{
				return;
			}
			if (cardPoolId != 1)
			{
				if (cardPoolId != 2)
				{
					if (cardPoolId == 3)
					{
						this.AddStatisticalData(StatisticalDataType.CardPool3SelectCard, selectCount);
					}
				}
				else
				{
					this.AddStatisticalData(StatisticalDataType.CardPool2SelectCard, selectCount);
				}
			}
			else
			{
				this.AddStatisticalData(StatisticalDataType.CardPool1SelectCard, selectCount);
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_CardPoolSelectCard);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == cardPoolId)
				{
					this.AddMissionProcess(mission, (long)selectCount);
				}
			}
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0014F340 File Offset: 0x0014D540
		private void OnMissionSelectCardCallBack(int cardPoolId, int selectCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMissionSelectCardCallBackInt32Int32_hotfix != null)
			{
				this.m_OnMissionSelectCardCallBackInt32Int32_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					selectCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataCardPoolInfo configDataCardPoolInfo = this.m_configDataLoader.GetConfigDataCardPoolInfo(cardPoolId);
			if (configDataCardPoolInfo == null || selectCount <= 0)
			{
				return;
			}
			switch (configDataCardPoolInfo.MissionCardPoolType)
			{
			case MissionCardPoolType.MissionCardPoolType_None:
				this.AddStatisticalData(StatisticalDataType.DoShare, selectCount);
				break;
			case MissionCardPoolType.MissionCardPoolType_Free:
				this.AddStatisticalData(StatisticalDataType.FreeCardPoolSelectCard, selectCount);
				break;
			case MissionCardPoolType.MissionCardPoolType_Hero:
				this.AddStatisticalData(StatisticalDataType.HeroCardPoolSelectCard, selectCount);
				break;
			case MissionCardPoolType.MissionCardPoolType_Equipment:
				this.AddStatisticalData(StatisticalDataType.EquipmentCardPoolSelectCard, selectCount);
				break;
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_MissionSelectCard);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == 0 || mission.Config.Param1 == (int)configDataCardPoolInfo.MissionCardPoolType)
				{
					this.AddMissionProcess(mission, (long)selectCount);
				}
			}
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x0014F4B8 File Offset: 0x0014D6B8
		protected virtual void SetStatisticalData(StatisticalDataType typeId, long nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatisticalDataStatisticalDataTypeInt64_hotfix != null)
			{
				this.m_SetStatisticalDataStatisticalDataTypeInt64_hotfix.call(new object[]
				{
					this,
					typeId,
					nums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x0014F538 File Offset: 0x0014D738
		protected virtual void AddStatisticalData(StatisticalDataType typeId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddStatisticalDataStatisticalDataTypeInt32_hotfix != null)
			{
				this.m_AddStatisticalDataStatisticalDataTypeInt32_hotfix.call(new object[]
				{
					this,
					typeId,
					nums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x0014F5B8 File Offset: 0x0014D7B8
		public long GetMissionCompletedProcess(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissionCompletedProcessMission_hotfix != null)
			{
				return Convert.ToInt64(this.m_GetMissionCompletedProcessMission_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CanGetRewarding(mission))
			{
				return (long)this.GetMissionMaxProcess(mission);
			}
			return mission.CompletedProcess;
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x0014F650 File Offset: 0x0014D850
		private void OnSummonHeroCallBack(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSummonHeroCallBackInt32_hotfix != null)
			{
				this.m_OnSummonHeroCallBackInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo == null)
			{
				return;
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_SummonHero);
			foreach (Mission mission in processingMissionByMissionType)
			{
				int param = mission.Config.Param1;
				if (param == 0 || param == configDataHeroInfo.Rank)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x0014F748 File Offset: 0x0014D948
		private void OnConsumeEnergyCallBack(int energyCost)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConsumeEnergyCallBackInt32_hotfix != null)
			{
				this.m_OnConsumeEnergyCallBackInt32_hotfix.call(new object[]
				{
					this,
					energyCost
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (energyCost <= 0)
			{
				return;
			}
			this.AddStatisticalData(StatisticalDataType.EnergyConsume, energyCost);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ConsumeEnergy);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)energyCost);
			}
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0014F820 File Offset: 0x0014DA20
		private void OnCompleteEventCallBack(bool isRandomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompleteEventCallBackBoolean_hotfix != null)
			{
				this.m_OnCompleteEventCallBackBoolean_hotfix.call(new object[]
				{
					this,
					isRandomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isRandomEvent)
			{
				this.AddStatisticalData(StatisticalDataType.EventCompleteRandom, 1);
			}
			else
			{
				this.AddStatisticalData(StatisticalDataType.EventCompleteFixed, 1);
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_CompleteEvent);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param2 == 0 || (mission.Config.Param2 == 2 && isRandomEvent) || (mission.Config.Param2 == 1 && !isRandomEvent))
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x0014F940 File Offset: 0x0014DB40
		private void OnCompleteLevelCallBack(BattleType levelType, int levelId, List<int> fightHeroes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompleteLevelCallBackBattleTypeInt32List`1_hotfix != null)
			{
				this.m_OnCompleteLevelCallBackBattleTypeInt32List`1_hotfix.call(new object[]
				{
					this,
					levelType,
					levelId,
					fightHeroes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddBattleTypeLevelStatisticalData(levelType);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_CompleteLevel);
			foreach (Mission mission in processingMissionByMissionType)
			{
				int param = mission.Config.Param1;
				BattleType param2 = (BattleType)mission.Config.Param2;
				int param3 = mission.Config.Param3;
				if ((param2 == BattleType.None || param2 == levelType) && (param3 == 0 || param3 == levelId))
				{
					if (param == 0)
					{
						this.AddMissionProcess(mission, 1L);
					}
					else if (fightHeroes != null && fightHeroes.Contains(param))
					{
						this.AddMissionProcess(mission, 1L);
					}
				}
			}
			if (levelType == BattleType.Rift)
			{
				this.RiftLevelAttackDiffculityCallBack(levelId);
			}
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x0014FAAC File Offset: 0x0014DCAC
		private void RiftLevelAttackDiffculityCallBack(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelAttackDiffculityCallBackInt32_hotfix != null)
			{
				this.m_RiftLevelAttackDiffculityCallBackInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
			StatisticalDataType typeId;
			if (configDataRiftLevelInfo.m_chapterInfo.Hard == 1)
			{
				typeId = StatisticalDataType.RiftLevelSimpleLevel;
			}
			else
			{
				typeId = StatisticalDataType.RiftLevelDiffcultLevel;
			}
			this.OnCompleteRiftLevelCallBack(configDataRiftLevelInfo.m_chapterInfo.Hard);
			this.AddStatisticalData(typeId, 1);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x0014FB60 File Offset: 0x0014DD60
		private void AddBattleTypeLevelStatisticalData(BattleType levelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBattleTypeLevelStatisticalDataBattleType_hotfix != null)
			{
				this.m_AddBattleTypeLevelStatisticalDataBattleType_hotfix.call(new object[]
				{
					this,
					levelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (levelType)
			{
			case BattleType.ThearchyTrial:
				this.AddStatisticalData(StatisticalDataType.ThearchyTrial, 1);
				break;
			case BattleType.AnikiGym:
				this.AddStatisticalData(StatisticalDataType.AnikiGymLevel, 1);
				break;
			case BattleType.ArenaAttack:
				this.AddStatisticalData(StatisticalDataType.ArenaAttack, 1);
				break;
			case BattleType.HeroDungeon:
				this.AddStatisticalData(StatisticalDataType.HeroDungeonLevel, 1);
				break;
			case BattleType.TreasureMap:
				this.AddStatisticalData(StatisticalDataType.TreasureMapLevel, 1);
				break;
			case BattleType.MemoryCorridor:
				this.AddStatisticalData(StatisticalDataType.MemoryCorridor, 1);
				break;
			case BattleType.HeroTrainning:
				this.AddStatisticalData(StatisticalDataType.HeroDungeonLevel, 1);
				break;
			case BattleType.HeroPhantom:
				this.AddStatisticalData(StatisticalDataType.HeroPhantom, 1);
				break;
			case BattleType.CooperateBattle:
				this.AddStatisticalData(StatisticalDataType.CooperateBattle, 1);
				break;
			}
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x0014FC8C File Offset: 0x0014DE8C
		private void OnArenaConsecutiveVictoryCallBack(int consecutiveVictoryNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaConsecutiveVictoryCallBackInt32_hotfix != null)
			{
				this.m_OnArenaConsecutiveVictoryCallBackInt32_hotfix.call(new object[]
				{
					this,
					consecutiveVictoryNums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetStatisticalData(StatisticalDataType.ArenaConsecutiveVictory, (long)consecutiveVictoryNums);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ArenaConsecutiveVictoryNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				long process = (long)consecutiveVictoryNums - mission.CompletedProcess;
				this.AddMissionProcess(mission, process);
			}
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x0014FD68 File Offset: 0x0014DF68
		private void OnArenaFightCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaFightCallBack_hotfix != null)
			{
				this.m_OnArenaFightCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.ArenaFight, 1);
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x0014FDD4 File Offset: 0x0014DFD4
		private void OnCompleteScenaioCallBack(int scenarioId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompleteScenaioCallBackInt32_hotfix != null)
			{
				this.m_OnCompleteScenaioCallBackInt32_hotfix.call(new object[]
				{
					this,
					scenarioId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_CompleteScenario);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == scenarioId)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x0014FEAC File Offset: 0x0014E0AC
		private void OnCompleteRiftLevelCallBack(int diffculty)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompleteRiftLevelCallBackInt32_hotfix != null)
			{
				this.m_OnCompleteRiftLevelCallBackInt32_hotfix.call(new object[]
				{
					this,
					diffculty
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType;
			if (diffculty == 1)
			{
				this.AddStatisticalData(StatisticalDataType.RiftLevelSimpleLevel, 1);
				processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ComleteSimpleRiftLevel);
			}
			else
			{
				this.AddStatisticalData(StatisticalDataType.RiftLevelDiffcultLevel, 1);
				processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ComleteDiffcultRiftLevel);
			}
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == diffculty)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x0014FFA8 File Offset: 0x0014E1A8
		private void OnGetRiftLevelFightAchievementCallBack(int achievementRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetRiftLevelFightAchievementCallBackInt32_hotfix != null)
			{
				this.m_OnGetRiftLevelFightAchievementCallBackInt32_hotfix.call(new object[]
				{
					this,
					achievementRelatedId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_GetRiftLevelFightAchievement);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
			this.OnFinishFightAchievementCallBack(achievementRelatedId);
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00150074 File Offset: 0x0014E274
		private void OnFinishFightAchievementCallBack(int achievementRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFinishFightAchievementCallBackInt32_hotfix != null)
			{
				this.m_OnFinishFightAchievementCallBackInt32_hotfix.call(new object[]
				{
					this,
					achievementRelatedId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_CompleteBattleAchievement);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == achievementRelatedId)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x0015014C File Offset: 0x0014E34C
		private void OnGetRiftLevelStarCallBack(int starCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetRiftLevelStarCallBackInt32_hotfix != null)
			{
				this.m_OnGetRiftLevelStarCallBackInt32_hotfix.call(new object[]
				{
					this,
					starCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (starCount <= 0)
			{
				return;
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_GetRiftLevelFightStar);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)starCount);
			}
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x0015021C File Offset: 0x0014E41C
		private void OnConsumeCrystalCallBack(int crystalCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConsumeCrystalCallBackInt32_hotfix != null)
			{
				this.m_OnConsumeCrystalCallBackInt32_hotfix.call(new object[]
				{
					this,
					crystalCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (crystalCount <= 0)
			{
				return;
			}
			this.AddStatisticalData(StatisticalDataType.CrystalComsume, crystalCount);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ConsumeCrystal);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)crystalCount);
			}
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x001502F4 File Offset: 0x0014E4F4
		private void OnComsumeGoldCallBack(int goldCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnComsumeGoldCallBackInt32_hotfix != null)
			{
				this.m_OnComsumeGoldCallBackInt32_hotfix.call(new object[]
				{
					this,
					goldCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goldCount <= 0)
			{
				return;
			}
			this.AddStatisticalData(StatisticalDataType.GoldConsume, goldCount);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ConsumeGold);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)goldCount);
			}
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001503CC File Offset: 0x0014E5CC
		private void OnUseHeroExpItemCallBack(int itemCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUseHeroExpItemCallBackInt32_hotfix != null)
			{
				this.m_OnUseHeroExpItemCallBackInt32_hotfix.call(new object[]
				{
					this,
					itemCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (itemCount <= 0)
			{
				return;
			}
			this.AddStatisticalData(StatisticalDataType.HeroExpItemUse, itemCount);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_UseAnyHeroExpItem);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)itemCount);
			}
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x001504A4 File Offset: 0x0014E6A4
		private void OnAllHeroAllJobLevelUpCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllHeroAllJobLevelUpCallBack_hotfix != null)
			{
				this.m_OnAllHeroAllJobLevelUpCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AllHeroAllJobLevelUpNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x0015055C File Offset: 0x0014E75C
		private void OnAllHeroAddJobNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllHeroAddJobNums_hotfix != null)
			{
				this.m_OnAllHeroAddJobNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AllHerohaveJobNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00150614 File Offset: 0x0014E814
		private void OnRankJobHaveCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankJobHaveCallBack_hotfix != null)
			{
				this.m_OnRankJobHaveCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Hero> allHeros = this.m_hero.GetAllHeros();
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_RankJobHeroNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				long num = 0L;
				long completedProcess = mission.CompletedProcess;
				foreach (Hero hero in allHeros)
				{
					foreach (HeroJob heroJob in hero.Jobs)
					{
						ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(heroJob.JobRelatedId);
						if (configDataJobConnectionInfo.m_jobInfo.Rank >= mission.Config.Param1)
						{
							num += 1L;
							break;
						}
					}
				}
				if (num > completedProcess)
				{
					this.AddMissionProcess(mission, num - completedProcess);
				}
			}
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001507B0 File Offset: 0x0014E9B0
		private void OnAllHeroAddSkillNumsCallBack(int skillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllHeroAddSkillNumsCallBackInt32_hotfix != null)
			{
				this.m_OnAllHeroAddSkillNumsCallBackInt32_hotfix.call(new object[]
				{
					this,
					skillId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillId == 0 || this.m_hero.IsExistSkillId(skillId))
			{
				return;
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AllHeroHaveSkillNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x00150890 File Offset: 0x0014EA90
		private void OnAllHeroAddSoliderNumsCallBack(int soliderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllHeroAddSoliderNumsCallBackInt32_hotfix != null)
			{
				this.m_OnAllHeroAddSoliderNumsCallBackInt32_hotfix.call(new object[]
				{
					this,
					soliderId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soliderId == 0 || this.m_hero.IsExistSoliderId(soliderId))
			{
				return;
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AllHeroHaveSoliderNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00150970 File Offset: 0x0014EB70
		private void OnAllJobMasterHeroCallBack(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllJobMasterHeroCallBackInt32_hotfix != null)
			{
				this.m_OnAllJobMasterHeroCallBackInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_hero.FindHero(heroId);
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			foreach (int jobRelatedId in configDataHeroInfo.UseableJobConnections_ID)
			{
				HeroJob heroJob = this.m_hero.FindHeroJob(hero, jobRelatedId);
				if (heroJob == null)
				{
					return;
				}
				if (!this.m_hero.IsJobLevelMax(heroJob))
				{
					return;
				}
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AllJobMasterHeroNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00150AC8 File Offset: 0x0014ECC8
		private void OnHeroMasterJobCallBack(int heroId, int jobRelateId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroMasterJobCallBackInt32Int32_hotfix != null)
			{
				this.m_OnHeroMasterJobCallBackInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelateId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_HeroMasterJobNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == 0 || mission.Config.Param1 == heroId)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
			processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_SpecificHeroMasterSpecificJobRelationId);
			foreach (Mission mission2 in processingMissionByMissionType)
			{
				if (mission2.Config.Param2 == jobRelateId && mission2.Config.Param1 == heroId)
				{
					this.AddMissionProcess(mission2, 1L);
				}
			}
			this.OnAllJobMasterHeroCallBack(heroId);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00150C3C File Offset: 0x0014EE3C
		private void OnLevelUpHeroStarLevelCallBack(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelUpHeroStarLevelCallBackInt32_hotfix != null)
			{
				this.m_OnLevelUpHeroStarLevelCallBackInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_hero.FindHero(heroId);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_HaveStarHeroNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == hero.StarLevel)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			int rank = configDataHeroInfo.GetRank(hero.StarLevel - 1);
			int rank2 = configDataHeroInfo.GetRank(hero.StarLevel);
			if (rank2 > rank)
			{
				this.UpdateHeroRankLevelCallBack(rank2);
			}
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00150D68 File Offset: 0x0014EF68
		private void UpdateHeroRankLevelCallBack(int heroRank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroRankLevelCallBackInt32_hotfix != null)
			{
				this.m_UpdateHeroRankLevelCallBackInt32_hotfix.call(new object[]
				{
					this,
					heroRank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_HaveRankHeroNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == heroRank)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00150E40 File Offset: 0x0014F040
		private void OnAddHeroNumsCallBack(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddHeroNumsCallBackInt32_hotfix != null)
			{
				this.m_OnAddHeroNumsCallBackInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_HaveStarHeroNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				int param = mission.Config.Param1;
				if (param == 0 || param == configDataHeroInfo.Star)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
			this.UpdateHeroRankLevelCallBack(configDataHeroInfo.Rank);
			this.OnSpecificHeroLevelUp(heroId);
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00150F48 File Offset: 0x0014F148
		private void OnHasAboveLevelHeroNumsCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHasAboveLevelHeroNumsCallBack_hotfix != null)
			{
				this.m_OnHasAboveLevelHeroNumsCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Hero> allHeros = this.m_hero.GetAllHeros();
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_HasAboveLevelHeroNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				long num = 0L;
				long completedProcess = mission.CompletedProcess;
				foreach (Hero hero in allHeros)
				{
					if (hero.Level >= mission.Config.Param1)
					{
						num += 1L;
					}
				}
				if (num > completedProcess)
				{
					this.AddMissionProcess(mission, num - completedProcess);
				}
			}
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00151080 File Offset: 0x0014F280
		private void OnLevelUpPlayerLevelCallBack(int upLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelUpPlayerLevelCallBackInt32_hotfix != null)
			{
				this.m_OnLevelUpPlayerLevelCallBackInt32_hotfix.call(new object[]
				{
					this,
					upLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_PlayerLevelUp);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)upLevel);
			}
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00151148 File Offset: 0x0014F348
		private void OnUseCrystalBuyEnergyCallBack(int buyCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUseCrystalBuyEnergyCallBackInt32_hotfix != null)
			{
				this.m_OnUseCrystalBuyEnergyCallBackInt32_hotfix.call(new object[]
				{
					this,
					buyCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.EnergyBuy, buyCount);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_UseCrystalBuyEnergyNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, (long)buyCount);
			}
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00151218 File Offset: 0x0014F418
		protected void OnLoginGameCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginGameCallBack_hotfix != null)
			{
				this.m_OnLoginGameCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.AccumulateLogin, 1);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_LoginGameDays);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x001512D8 File Offset: 0x0014F4D8
		private void OnNewHeroJobTransferCallBack(int heroId, int jobConnnectionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewHeroJobTransferCallBackInt32Int32_hotfix != null)
			{
				this.m_OnNewHeroJobTransferCallBackInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobConnnectionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_TransferNewJobNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
			processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_SpecificHeroMasterSpecificJobRelationId);
			foreach (Mission mission2 in processingMissionByMissionType)
			{
				if (mission2.Config.Param1 == heroId && mission2.Config.Param2 == jobConnnectionId)
				{
					this.AddMissionProcess(mission2, 1L);
				}
			}
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00151424 File Offset: 0x0014F624
		private void OnSpecificHeroFight(int heroId, int fightNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSpecificHeroFightInt32Int32_hotfix != null)
			{
				this.m_OnSpecificHeroFightInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					fightNums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_SpecificHeroFightNums);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == heroId)
				{
					this.AddMissionProcess(mission, (long)fightNums);
				}
			}
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x0015150C File Offset: 0x0014F70C
		private void OnSpecificHeroLevelUp(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSpecificHeroLevelUpInt32_hotfix != null)
			{
				this.m_OnSpecificHeroLevelUpInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_SpecificHeroReachSpecificLevel);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == heroId)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
			this.OnHasAboveLevelHeroNumsCallBack();
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x001515E8 File Offset: 0x0014F7E8
		private void OnTrainingTechToLevelCallBack(TrainingTech Tech)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingTechToLevelCallBackTrainingTech_hotfix != null)
			{
				this.m_OnTrainingTechToLevelCallBackTrainingTech_hotfix.call(new object[]
				{
					this,
					Tech
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_TrainingTechToLevel);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (Tech.Level == mission.Config.Param2)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x001516C4 File Offset: 0x0014F8C4
		private void OnEquipmentToLevelCallBack(EquipmentBagItem Equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentToLevelCallBackEquipmentBagItem_hotfix != null)
			{
				this.m_OnEquipmentToLevelCallBackEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					Equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_EquipmentToLevel);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (Equipment.Level == mission.Config.Param2)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x001517A0 File Offset: 0x0014F9A0
		private void OnFinishTeamBattleCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFinishTeamBattleCallBack_hotfix != null)
			{
				this.m_OnFinishTeamBattleCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.TeamBattle, 1);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_FinishTeamBattle);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00151860 File Offset: 0x0014FA60
		private void OnFavorabilityToLevelCallBack(Hero Hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFavorabilityToLevelCallBackHero_hotfix != null)
			{
				this.m_OnFavorabilityToLevelCallBackHero_hotfix.call(new object[]
				{
					this,
					Hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_FavorabilityToLevel);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (Hero.FavorabilityLevel == mission.Config.Param2)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x0015193C File Offset: 0x0014FB3C
		private void OnFetterToLevelCallBack(Hero Hero, int FetterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFetterToLevelCallBackHeroInt32_hotfix != null)
			{
				this.m_OnFetterToLevelCallBackHeroInt32_hotfix.call(new object[]
				{
					this,
					Hero,
					FetterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_FetterToLevel);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (Hero.Fetters[FetterId] == mission.Config.Param2)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00151A30 File Offset: 0x0014FC30
		private void OnEnchantPropertiesSaveCallBack(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantPropertiesSaveCallBackEquipmentBagItem_hotfix != null)
			{
				this.m_OnEnchantPropertiesSaveCallBackEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_EnchatEquipments);
			foreach (Mission mission in processingMissionByMissionType)
			{
				int num = 0;
				foreach (BagItemBase bagItemBase in this.m_bag.GetAllBagItems())
				{
					EquipmentBagItem equipmentBagItem = bagItemBase as EquipmentBagItem;
					if (equipmentBagItem != null && equipmentBagItem.EnchantProperties.Count > 0)
					{
						num++;
					}
				}
				long process = Math.Max((long)num, mission.CompletedProcess) - mission.CompletedProcess;
				this.AddMissionProcess(mission, process);
			}
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00151B80 File Offset: 0x0014FD80
		private void OnEnchantEquipmentCallBack(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantEquipmentCallBackEquipmentBagItem_hotfix != null)
			{
				this.m_OnEnchantEquipmentCallBackEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_DailyEquipmentEnchant);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00151C48 File Offset: 0x0014FE48
		private void OnTotalHeroJobLevelUpCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTotalHeroJobLevelUpCallBack_hotfix != null)
			{
				this.m_OnTotalHeroJobLevelUpCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (Hero hero in this.m_hero.GetAllHeros())
			{
				if (hero.Jobs.Exists((HeroJob j) => j.JobLevel > 0))
				{
					num++;
				}
			}
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_TotalHeroJobLevelUp);
			foreach (Mission mission in processingMissionByMissionType)
			{
				long process = Math.Max((long)num, mission.CompletedProcess) - mission.CompletedProcess;
				this.AddMissionProcess(mission, process);
			}
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00151D94 File Offset: 0x0014FF94
		private void OnInviteFriendCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendCallBack_hotfix != null)
			{
				this.m_OnInviteFriendCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.InviteFriend, 1);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AddFriend);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00151E54 File Offset: 0x00150054
		private void OnAssignHeroToTaskCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAssignHeroToTaskCallBack_hotfix != null)
			{
				this.m_OnAssignHeroToTaskCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.AssignHeroToTask, 1);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_AssignHeroToTask);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00151F14 File Offset: 0x00150114
		private void OnBattlePracticeCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattlePracticeCallBack_hotfix != null)
			{
				this.m_OnBattlePracticeCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddStatisticalData(StatisticalDataType.BattlePractice, 1);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_BattlePractice);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00151FD4 File Offset: 0x001501D4
		private void OnRealTimeArenaBattleStartCallBack(BattleMode battleMode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRealTimeArenaBattleStartCallBackBattleMode_hotfix != null)
			{
				this.m_OnRealTimeArenaBattleStartCallBackBattleMode_hotfix.call(new object[]
				{
					this,
					battleMode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_RealTimeArena);
			foreach (Mission mission in processingMissionByMissionType)
			{
				int param = mission.Config.Param1;
				if (param != 0)
				{
					if (param != 1)
					{
						if (param == 2)
						{
							if (battleMode == BattleMode.Friendly && mission.Config.Param3 == 0)
							{
								this.AddMissionProcess(mission, 1L);
							}
						}
					}
					else if (battleMode == BattleMode.Default && mission.Config.Param3 == 0)
					{
						this.AddMissionProcess(mission, 1L);
					}
				}
				else if (mission.Config.Param3 == 0)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
			if (battleMode != BattleMode.Default)
			{
				if (battleMode == BattleMode.Friendly)
				{
					this.AddStatisticalData(StatisticalDataType.RealTimeArenaRelaxModeFight, 1);
				}
			}
			else
			{
				this.AddStatisticalData(StatisticalDataType.RealTimeArenaLadderModeFight, 1);
			}
			this.AddStatisticalData(StatisticalDataType.RealTimeArenaAnyModeFight, 1);
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00152154 File Offset: 0x00150354
		private void OnRealTimeArenaBattleFinishCallBack(BattleMode battleMode, bool win)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRealTimeArenaBattleFinishCallBackBattleModeBoolean_hotfix != null)
			{
				this.m_OnRealTimeArenaBattleFinishCallBackBattleModeBoolean_hotfix.call(new object[]
				{
					this,
					battleMode,
					win
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_RealTimeArena);
			foreach (Mission mission in processingMissionByMissionType)
			{
				int param = mission.Config.Param1;
				if (param != 0)
				{
					if (param != 1)
					{
						if (param == 2)
						{
							if (battleMode == BattleMode.Friendly && mission.Config.Param3 != 0 && win)
							{
								this.AddMissionProcess(mission, 1L);
							}
						}
					}
					else if (battleMode == BattleMode.Default && mission.Config.Param3 != 0 && win)
					{
						this.AddMissionProcess(mission, 1L);
					}
				}
				else if (mission.Config.Param3 != 0 && win)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
			if (battleMode != BattleMode.Default)
			{
				if (battleMode == BattleMode.Friendly)
				{
					if (win)
					{
						this.AddStatisticalData(StatisticalDataType.RealTimeArenaRelaxModeSuccess, 1);
					}
				}
			}
			else if (win)
			{
				this.AddStatisticalData(StatisticalDataType.RealTimeArenaLadderModeSuccess, 1);
			}
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x001522F8 File Offset: 0x001504F8
		private void OnRealTimeArenaDanUpdateCallBack(int dan)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRealTimeArenaDanUpdateCallBackInt32_hotfix != null)
			{
				this.m_OnRealTimeArenaDanUpdateCallBackInt32_hotfix.call(new object[]
				{
					this,
					dan
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetStatisticalData(StatisticalDataType.RealTimeReachedMaxDan, (long)dan);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_ReachedSpecificRealTimeArenaDan);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.CompletedProcess < (long)dan)
				{
					this.AddMissionProcess(mission, (long)dan - mission.CompletedProcess);
				}
			}
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x001523DC File Offset: 0x001505DC
		private void OnBuyGiftStoreGoodsCallBack(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyGiftStoreGoodsCallBackInt32_hotfix != null)
			{
				this.m_OnBuyGiftStoreGoodsCallBackInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetStatisticalData(StatisticalDataType.BuyGiftStoreGoods, 1L);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_BuyGiftStoreGoods);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == 0 || mission.Config.Param1 == goodsId)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x001524CC File Offset: 0x001506CC
		private void OnBuyRechargeStoreGoodsCallBack(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyRechargeStoreGoodsCallBackInt32_hotfix != null)
			{
				this.m_OnBuyRechargeStoreGoodsCallBackInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetStatisticalData(StatisticalDataType.BuyRechargeStoreGoods, 1L);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_BuyRechargeStoreGoods);
			foreach (Mission mission in processingMissionByMissionType)
			{
				if (mission.Config.Param1 == 0 || mission.Config.Param1 == goodsId)
				{
					this.AddMissionProcess(mission, 1L);
				}
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x001525BC File Offset: 0x001507BC
		private void OnDoShareCallBack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDoShareCallBack_hotfix != null)
			{
				this.m_OnDoShareCallBack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetStatisticalData(StatisticalDataType.DoShare, 1L);
			List<Mission> processingMissionByMissionType = this.GetProcessingMissionByMissionType(MissionType.MissionType_Share);
			foreach (Mission mission in processingMissionByMissionType)
			{
				this.AddMissionProcess(mission, 1L);
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x0015267C File Offset: 0x0015087C
		// (set) Token: 0x0600450A RID: 17674 RVA: 0x0015269C File Offset: 0x0015089C
		[DoNotToLua]
		public MissionComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MissionComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00152748 File Offset: 0x00150948
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
					this.m_RemoveProcessingMissionByIdInt32_hotfix = (luaObj.RawGet("RemoveProcessingMissionById") as LuaFunction);
					this.m_OnMonthCardVaildEveryDayFlush_hotfix = (luaObj.RawGet("OnMonthCardVaildEveryDayFlush") as LuaFunction);
					this.m_OnMonthCardVaildCallBackInt32_hotfix = (luaObj.RawGet("OnMonthCardVaildCallBack") as LuaFunction);
					this.m_InitProcessingMissionList`1_hotfix = (luaObj.RawGet("InitProcessingMission") as LuaFunction);
					this.m_GetProcessingMissionByMissionTypeMissionType_hotfix = (luaObj.RawGet("GetProcessingMissionByMissionType") as LuaFunction);
					this.m_InitExistMissions_hotfix = (luaObj.RawGet("InitExistMissions") as LuaFunction);
					this.m_OnFlushEverydayMissionEvent_hotfix = (luaObj.RawGet("OnFlushEverydayMissionEvent") as LuaFunction);
					this.m_ResetEverydayMissions_hotfix = (luaObj.RawGet("ResetEverydayMissions") as LuaFunction);
					this.m_InitMissionListByMissionPeriodTypeMissionPeriodType_hotfix = (luaObj.RawGet("InitMissionListByMissionPeriodType") as LuaFunction);
					this.m_CanUnlockMissionInLogicFromInitConfigDataMissionInfo_hotfix = (luaObj.RawGet("CanUnlockMissionInLogicFromInit") as LuaFunction);
					this.m_OnDirectActivatedMissionLockedConfigDataMissionInfo_hotfix = (luaObj.RawGet("OnDirectActivatedMissionLocked") as LuaFunction);
					this.m_IsNoviceMissionMission_hotfix = (luaObj.RawGet("IsNoviceMission") as LuaFunction);
					this.m_IsNoviceMissionConfigDataMissionInfo_hotfix = (luaObj.RawGet("IsNoviceMission") as LuaFunction);
					this.m_IsNoviceMissionActivatedConfigDataMissionInfo_hotfix = (luaObj.RawGet("IsNoviceMissionActivated") as LuaFunction);
					this.m_IsNoviceMissionActivatedForRewardingConfigDataMissionInfo_hotfix = (luaObj.RawGet("IsNoviceMissionActivatedForRewarding") as LuaFunction);
					this.m_IsNoviceMissionActivatedMission_hotfix = (luaObj.RawGet("IsNoviceMissionActivated") as LuaFunction);
					this.m_CanGetRewardingMission_hotfix = (luaObj.RawGet("CanGetRewarding") as LuaFunction);
					this.m_CanUnlockMissionInLogicConfigDataMissionInfo_hotfix = (luaObj.RawGet("CanUnlockMissionInLogic") as LuaFunction);
					this.m_CanUnlockMissionConfigDataMissionInfo_hotfix = (luaObj.RawGet("CanUnlockMission") as LuaFunction);
					this.m_CaculateDirectlyActivationMissionStatusConfigDataMissionInfo_hotfix = (luaObj.RawGet("CaculateDirectlyActivationMissionStatus") as LuaFunction);
					this.m_AddMissionConfigDataMissionInfo_hotfix = (luaObj.RawGet("AddMission") as LuaFunction);
					this.m_OnAddProcessingDirectelyActivitedMissionMission_hotfix = (luaObj.RawGet("OnAddProcessingDirectelyActivitedMission") as LuaFunction);
					this.m_GetProcessingMissionByMissionPeriodMissionPeriodTypeInt32_hotfix = (luaObj.RawGet("GetProcessingMissionByMissionPeriod") as LuaFunction);
					this.m_OnGetProcessingDirectActivationMissionFailMission_hotfix = (luaObj.RawGet("OnGetProcessingDirectActivationMissionFail") as LuaFunction);
					this.m_AddEverydayMissionMission_hotfix = (luaObj.RawGet("AddEverydayMission") as LuaFunction);
					this.m_AddOneOffMissionMission_hotfix = (luaObj.RawGet("AddOneOffMission") as LuaFunction);
					this.m_IsMissionExistInt32_hotfix = (luaObj.RawGet("IsMissionExist") as LuaFunction);
					this.m_IsMissionFinishedInt32_hotfix = (luaObj.RawGet("IsMissionFinished") as LuaFunction);
					this.m_InitMissionsFromConfigList`1_hotfix = (luaObj.RawGet("InitMissionsFromConfig") as LuaFunction);
					this.m_FinishMissionMission_hotfix = (luaObj.RawGet("FinishMission") as LuaFunction);
					this.m_GetAllEverydayMissionConfigByPreMissionIdInt32_hotfix = (luaObj.RawGet("GetAllEverydayMissionConfigByPreMissionId") as LuaFunction);
					this.m_GetAllEverydayMissionListByPlayerLevelInt32_hotfix = (luaObj.RawGet("GetAllEverydayMissionListByPlayerLevel") as LuaFunction);
					this.m_GetAllEverydayMissionListByScenarioInt32_hotfix = (luaObj.RawGet("GetAllEverydayMissionListByScenario") as LuaFunction);
					this.m_GetAllProcessingNoviceMissionList_hotfix = (luaObj.RawGet("GetAllProcessingNoviceMissionList") as LuaFunction);
					this.m_GetAllFinishedNoviceMissionList_hotfix = (luaObj.RawGet("GetAllFinishedNoviceMissionList") as LuaFunction);
					this.m_UpdateMissionListByMissionCompleteInt32_hotfix = (luaObj.RawGet("UpdateMissionListByMissionComplete") as LuaFunction);
					this.m_UpdateMissionListByLevelUpInt32_hotfix = (luaObj.RawGet("UpdateMissionListByLevelUp") as LuaFunction);
					this.m_UpdateMissionListByScenarioInt32_hotfix = (luaObj.RawGet("UpdateMissionListByScenario") as LuaFunction);
					this.m_UpdateMissionListByNewMissionConfigListList`1_hotfix = (luaObj.RawGet("UpdateMissionListByNewMissionConfigList") as LuaFunction);
					this.m_AddMissionProcessMissionInt64_hotfix = (luaObj.RawGet("AddMissionProcess") as LuaFunction);
					this.m_GetMissionMaxProcessMission_hotfix = (luaObj.RawGet("GetMissionMaxProcess") as LuaFunction);
					this.m_IsMissionProcessFinishedInt32_hotfix = (luaObj.RawGet("IsMissionProcessFinished") as LuaFunction);
					this.m_CanGainMissionRewardInt32_hotfix = (luaObj.RawGet("CanGainMissionReward") as LuaFunction);
					this.m_RegisterMissionCallBack_hotfix = (luaObj.RawGet("RegisterMissionCallBack") as LuaFunction);
					this.m_IsCompletedInt32_hotfix = (luaObj.RawGet("IsCompleted") as LuaFunction);
					this.m_OnSelectCardMissionCallBackInt32Int32_hotfix = (luaObj.RawGet("OnSelectCardMissionCallBack") as LuaFunction);
					this.m_OnMissionSelectCardCallBackInt32Int32_hotfix = (luaObj.RawGet("OnMissionSelectCardCallBack") as LuaFunction);
					this.m_SetStatisticalDataStatisticalDataTypeInt64_hotfix = (luaObj.RawGet("SetStatisticalData") as LuaFunction);
					this.m_AddStatisticalDataStatisticalDataTypeInt32_hotfix = (luaObj.RawGet("AddStatisticalData") as LuaFunction);
					this.m_GetMissionCompletedProcessMission_hotfix = (luaObj.RawGet("GetMissionCompletedProcess") as LuaFunction);
					this.m_OnSummonHeroCallBackInt32_hotfix = (luaObj.RawGet("OnSummonHeroCallBack") as LuaFunction);
					this.m_OnConsumeEnergyCallBackInt32_hotfix = (luaObj.RawGet("OnConsumeEnergyCallBack") as LuaFunction);
					this.m_OnCompleteEventCallBackBoolean_hotfix = (luaObj.RawGet("OnCompleteEventCallBack") as LuaFunction);
					this.m_OnCompleteLevelCallBackBattleTypeInt32List`1_hotfix = (luaObj.RawGet("OnCompleteLevelCallBack") as LuaFunction);
					this.m_RiftLevelAttackDiffculityCallBackInt32_hotfix = (luaObj.RawGet("RiftLevelAttackDiffculityCallBack") as LuaFunction);
					this.m_AddBattleTypeLevelStatisticalDataBattleType_hotfix = (luaObj.RawGet("AddBattleTypeLevelStatisticalData") as LuaFunction);
					this.m_OnArenaConsecutiveVictoryCallBackInt32_hotfix = (luaObj.RawGet("OnArenaConsecutiveVictoryCallBack") as LuaFunction);
					this.m_OnArenaFightCallBack_hotfix = (luaObj.RawGet("OnArenaFightCallBack") as LuaFunction);
					this.m_OnCompleteScenaioCallBackInt32_hotfix = (luaObj.RawGet("OnCompleteScenaioCallBack") as LuaFunction);
					this.m_OnCompleteRiftLevelCallBackInt32_hotfix = (luaObj.RawGet("OnCompleteRiftLevelCallBack") as LuaFunction);
					this.m_OnGetRiftLevelFightAchievementCallBackInt32_hotfix = (luaObj.RawGet("OnGetRiftLevelFightAchievementCallBack") as LuaFunction);
					this.m_OnFinishFightAchievementCallBackInt32_hotfix = (luaObj.RawGet("OnFinishFightAchievementCallBack") as LuaFunction);
					this.m_OnGetRiftLevelStarCallBackInt32_hotfix = (luaObj.RawGet("OnGetRiftLevelStarCallBack") as LuaFunction);
					this.m_OnConsumeCrystalCallBackInt32_hotfix = (luaObj.RawGet("OnConsumeCrystalCallBack") as LuaFunction);
					this.m_OnComsumeGoldCallBackInt32_hotfix = (luaObj.RawGet("OnComsumeGoldCallBack") as LuaFunction);
					this.m_OnUseHeroExpItemCallBackInt32_hotfix = (luaObj.RawGet("OnUseHeroExpItemCallBack") as LuaFunction);
					this.m_OnAllHeroAllJobLevelUpCallBack_hotfix = (luaObj.RawGet("OnAllHeroAllJobLevelUpCallBack") as LuaFunction);
					this.m_OnAllHeroAddJobNums_hotfix = (luaObj.RawGet("OnAllHeroAddJobNums") as LuaFunction);
					this.m_OnRankJobHaveCallBack_hotfix = (luaObj.RawGet("OnRankJobHaveCallBack") as LuaFunction);
					this.m_OnAllHeroAddSkillNumsCallBackInt32_hotfix = (luaObj.RawGet("OnAllHeroAddSkillNumsCallBack") as LuaFunction);
					this.m_OnAllHeroAddSoliderNumsCallBackInt32_hotfix = (luaObj.RawGet("OnAllHeroAddSoliderNumsCallBack") as LuaFunction);
					this.m_OnAllJobMasterHeroCallBackInt32_hotfix = (luaObj.RawGet("OnAllJobMasterHeroCallBack") as LuaFunction);
					this.m_OnHeroMasterJobCallBackInt32Int32_hotfix = (luaObj.RawGet("OnHeroMasterJobCallBack") as LuaFunction);
					this.m_OnLevelUpHeroStarLevelCallBackInt32_hotfix = (luaObj.RawGet("OnLevelUpHeroStarLevelCallBack") as LuaFunction);
					this.m_UpdateHeroRankLevelCallBackInt32_hotfix = (luaObj.RawGet("UpdateHeroRankLevelCallBack") as LuaFunction);
					this.m_OnAddHeroNumsCallBackInt32_hotfix = (luaObj.RawGet("OnAddHeroNumsCallBack") as LuaFunction);
					this.m_OnHasAboveLevelHeroNumsCallBack_hotfix = (luaObj.RawGet("OnHasAboveLevelHeroNumsCallBack") as LuaFunction);
					this.m_OnLevelUpPlayerLevelCallBackInt32_hotfix = (luaObj.RawGet("OnLevelUpPlayerLevelCallBack") as LuaFunction);
					this.m_OnUseCrystalBuyEnergyCallBackInt32_hotfix = (luaObj.RawGet("OnUseCrystalBuyEnergyCallBack") as LuaFunction);
					this.m_OnLoginGameCallBack_hotfix = (luaObj.RawGet("OnLoginGameCallBack") as LuaFunction);
					this.m_OnNewHeroJobTransferCallBackInt32Int32_hotfix = (luaObj.RawGet("OnNewHeroJobTransferCallBack") as LuaFunction);
					this.m_OnSpecificHeroFightInt32Int32_hotfix = (luaObj.RawGet("OnSpecificHeroFight") as LuaFunction);
					this.m_OnSpecificHeroLevelUpInt32_hotfix = (luaObj.RawGet("OnSpecificHeroLevelUp") as LuaFunction);
					this.m_OnTrainingTechToLevelCallBackTrainingTech_hotfix = (luaObj.RawGet("OnTrainingTechToLevelCallBack") as LuaFunction);
					this.m_OnEquipmentToLevelCallBackEquipmentBagItem_hotfix = (luaObj.RawGet("OnEquipmentToLevelCallBack") as LuaFunction);
					this.m_OnFinishTeamBattleCallBack_hotfix = (luaObj.RawGet("OnFinishTeamBattleCallBack") as LuaFunction);
					this.m_OnFavorabilityToLevelCallBackHero_hotfix = (luaObj.RawGet("OnFavorabilityToLevelCallBack") as LuaFunction);
					this.m_OnFetterToLevelCallBackHeroInt32_hotfix = (luaObj.RawGet("OnFetterToLevelCallBack") as LuaFunction);
					this.m_OnEnchantPropertiesSaveCallBackEquipmentBagItem_hotfix = (luaObj.RawGet("OnEnchantPropertiesSaveCallBack") as LuaFunction);
					this.m_OnEnchantEquipmentCallBackEquipmentBagItem_hotfix = (luaObj.RawGet("OnEnchantEquipmentCallBack") as LuaFunction);
					this.m_OnTotalHeroJobLevelUpCallBack_hotfix = (luaObj.RawGet("OnTotalHeroJobLevelUpCallBack") as LuaFunction);
					this.m_OnInviteFriendCallBack_hotfix = (luaObj.RawGet("OnInviteFriendCallBack") as LuaFunction);
					this.m_OnAssignHeroToTaskCallBack_hotfix = (luaObj.RawGet("OnAssignHeroToTaskCallBack") as LuaFunction);
					this.m_OnBattlePracticeCallBack_hotfix = (luaObj.RawGet("OnBattlePracticeCallBack") as LuaFunction);
					this.m_OnRealTimeArenaBattleStartCallBackBattleMode_hotfix = (luaObj.RawGet("OnRealTimeArenaBattleStartCallBack") as LuaFunction);
					this.m_OnRealTimeArenaBattleFinishCallBackBattleModeBoolean_hotfix = (luaObj.RawGet("OnRealTimeArenaBattleFinishCallBack") as LuaFunction);
					this.m_OnRealTimeArenaDanUpdateCallBackInt32_hotfix = (luaObj.RawGet("OnRealTimeArenaDanUpdateCallBack") as LuaFunction);
					this.m_OnBuyGiftStoreGoodsCallBackInt32_hotfix = (luaObj.RawGet("OnBuyGiftStoreGoodsCallBack") as LuaFunction);
					this.m_OnBuyRechargeStoreGoodsCallBackInt32_hotfix = (luaObj.RawGet("OnBuyRechargeStoreGoodsCallBack") as LuaFunction);
					this.m_OnDoShareCallBack_hotfix = (luaObj.RawGet("OnDoShareCallBack") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x001532D4 File Offset: 0x001514D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MissionComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400342B RID: 13355
		protected HashSet<ConfigDataMissionInfo> m_lockedMissionConfigsInLogic = new HashSet<ConfigDataMissionInfo>();

		// Token: 0x0400342C RID: 13356
		protected HashSet<int> m_existMissions = new HashSet<int>();

		// Token: 0x0400342D RID: 13357
		protected DataSectionMission m_missionDS = new DataSectionMission();

		// Token: 0x0400342E RID: 13358
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x0400342F RID: 13359
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003430 RID: 13360
		protected SelectCardComponentCommon m_selectCard;

		// Token: 0x04003431 RID: 13361
		protected BagComponentCommon m_bag;

		// Token: 0x04003432 RID: 13362
		protected LevelComponentCommon m_level;

		// Token: 0x04003433 RID: 13363
		protected RiftComponentCommon m_rift;

		// Token: 0x04003434 RID: 13364
		protected HeroComponentCommon m_hero;

		// Token: 0x04003435 RID: 13365
		protected ThearchyTrialCompomentCommon m_thearchyTrial;

		// Token: 0x04003436 RID: 13366
		protected AnikiGymComponentCommon m_anikiGym;

		// Token: 0x04003437 RID: 13367
		protected BattleComponentCommon m_battle;

		// Token: 0x04003438 RID: 13368
		protected ArenaComponentCommon m_arena;

		// Token: 0x04003439 RID: 13369
		protected HeroDungeonComponentCommon m_heroDungeon;

		// Token: 0x0400343A RID: 13370
		protected HeroTrainningComponentCommon m_heroTrainning;

		// Token: 0x0400343B RID: 13371
		protected MemoryCorridorCompomentCommon m_memoryCorridor;

		// Token: 0x0400343C RID: 13372
		protected TreasureMapComponentCommon m_treasureMap;

		// Token: 0x0400343D RID: 13373
		protected HeroPhantomCompomentCommon m_heroPhantom;

		// Token: 0x0400343E RID: 13374
		protected CooperateBattleCompomentCommon m_cooperateBattle;

		// Token: 0x0400343F RID: 13375
		protected TrainingGroundCompomentCommon m_trainingGround;

		// Token: 0x04003440 RID: 13376
		protected TeamComponentCommon m_team;

		// Token: 0x04003441 RID: 13377
		protected NoviceComponentCommon m_novice;

		// Token: 0x04003442 RID: 13378
		protected FriendComponentCommon m_friend;

		// Token: 0x04003443 RID: 13379
		protected HeroAssistantsCompomentCommon m_heroAssistants;

		// Token: 0x04003444 RID: 13380
		protected ResourceComponentCommon m_resource;

		// Token: 0x04003445 RID: 13381
		protected RealTimePVPComponentCommon m_realTimePvp;

		// Token: 0x04003446 RID: 13382
		protected GiftStoreComponentCommon m_giftStore;

		// Token: 0x04003447 RID: 13383
		protected RechargeStoreComponentCommon m_rechargeStore;

		// Token: 0x04003448 RID: 13384
		[DoNotToLua]
		private MissionComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400344D RID: 13389
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400344E RID: 13390
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400344F RID: 13391
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003450 RID: 13392
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003451 RID: 13393
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003452 RID: 13394
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003453 RID: 13395
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003454 RID: 13396
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003455 RID: 13397
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003456 RID: 13398
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003457 RID: 13399
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003458 RID: 13400
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003459 RID: 13401
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400345A RID: 13402
		private LuaFunction m_RemoveProcessingMissionByIdInt32_hotfix;

		// Token: 0x0400345B RID: 13403
		private LuaFunction m_OnMonthCardVaildEveryDayFlush_hotfix;

		// Token: 0x0400345C RID: 13404
		private LuaFunction m_OnMonthCardVaildCallBackInt32_hotfix;

		// Token: 0x0400345D RID: 13405
		private LuaFunction m_InitProcessingMissionList;

		// Token: 0x0400345E RID: 13406
		private LuaFunction m_GetProcessingMissionByMissionTypeMissionType_hotfix;

		// Token: 0x0400345F RID: 13407
		private LuaFunction m_InitExistMissions_hotfix;

		// Token: 0x04003460 RID: 13408
		private LuaFunction m_OnFlushEverydayMissionEvent_hotfix;

		// Token: 0x04003461 RID: 13409
		private LuaFunction m_ResetEverydayMissions_hotfix;

		// Token: 0x04003462 RID: 13410
		private LuaFunction m_InitMissionListByMissionPeriodTypeMissionPeriodType_hotfix;

		// Token: 0x04003463 RID: 13411
		private LuaFunction m_CanUnlockMissionInLogicFromInitConfigDataMissionInfo_hotfix;

		// Token: 0x04003464 RID: 13412
		private LuaFunction m_OnDirectActivatedMissionLockedConfigDataMissionInfo_hotfix;

		// Token: 0x04003465 RID: 13413
		private LuaFunction m_IsNoviceMissionMission_hotfix;

		// Token: 0x04003466 RID: 13414
		private LuaFunction m_IsNoviceMissionConfigDataMissionInfo_hotfix;

		// Token: 0x04003467 RID: 13415
		private LuaFunction m_IsNoviceMissionActivatedConfigDataMissionInfo_hotfix;

		// Token: 0x04003468 RID: 13416
		private LuaFunction m_IsNoviceMissionActivatedForRewardingConfigDataMissionInfo_hotfix;

		// Token: 0x04003469 RID: 13417
		private LuaFunction m_IsNoviceMissionActivatedMission_hotfix;

		// Token: 0x0400346A RID: 13418
		private LuaFunction m_CanGetRewardingMission_hotfix;

		// Token: 0x0400346B RID: 13419
		private LuaFunction m_CanUnlockMissionInLogicConfigDataMissionInfo_hotfix;

		// Token: 0x0400346C RID: 13420
		private LuaFunction m_CanUnlockMissionConfigDataMissionInfo_hotfix;

		// Token: 0x0400346D RID: 13421
		private LuaFunction m_CaculateDirectlyActivationMissionStatusConfigDataMissionInfo_hotfix;

		// Token: 0x0400346E RID: 13422
		private LuaFunction m_AddMissionConfigDataMissionInfo_hotfix;

		// Token: 0x0400346F RID: 13423
		private LuaFunction m_OnAddProcessingDirectelyActivitedMissionMission_hotfix;

		// Token: 0x04003470 RID: 13424
		private LuaFunction m_GetProcessingMissionByMissionPeriodMissionPeriodTypeInt32_hotfix;

		// Token: 0x04003471 RID: 13425
		private LuaFunction m_OnGetProcessingDirectActivationMissionFailMission_hotfix;

		// Token: 0x04003472 RID: 13426
		private LuaFunction m_AddEverydayMissionMission_hotfix;

		// Token: 0x04003473 RID: 13427
		private LuaFunction m_AddOneOffMissionMission_hotfix;

		// Token: 0x04003474 RID: 13428
		private LuaFunction m_IsMissionExistInt32_hotfix;

		// Token: 0x04003475 RID: 13429
		private LuaFunction m_IsMissionFinishedInt32_hotfix;

		// Token: 0x04003476 RID: 13430
		private LuaFunction m_InitMissionsFromConfigList;

		// Token: 0x04003477 RID: 13431
		private LuaFunction m_FinishMissionMission_hotfix;

		// Token: 0x04003478 RID: 13432
		private LuaFunction m_GetAllEverydayMissionConfigByPreMissionIdInt32_hotfix;

		// Token: 0x04003479 RID: 13433
		private LuaFunction m_GetAllEverydayMissionListByPlayerLevelInt32_hotfix;

		// Token: 0x0400347A RID: 13434
		private LuaFunction m_GetAllEverydayMissionListByScenarioInt32_hotfix;

		// Token: 0x0400347B RID: 13435
		private LuaFunction m_GetAllProcessingNoviceMissionList_hotfix;

		// Token: 0x0400347C RID: 13436
		private LuaFunction m_GetAllFinishedNoviceMissionList_hotfix;

		// Token: 0x0400347D RID: 13437
		private LuaFunction m_UpdateMissionListByMissionCompleteInt32_hotfix;

		// Token: 0x0400347E RID: 13438
		private LuaFunction m_UpdateMissionListByLevelUpInt32_hotfix;

		// Token: 0x0400347F RID: 13439
		private LuaFunction m_UpdateMissionListByScenarioInt32_hotfix;

		// Token: 0x04003480 RID: 13440
		private LuaFunction m_UpdateMissionListByNewMissionConfigListList;

		// Token: 0x04003481 RID: 13441
		private LuaFunction m_AddMissionProcessMissionInt64_hotfix;

		// Token: 0x04003482 RID: 13442
		private LuaFunction m_GetMissionMaxProcessMission_hotfix;

		// Token: 0x04003483 RID: 13443
		private LuaFunction m_IsMissionProcessFinishedInt32_hotfix;

		// Token: 0x04003484 RID: 13444
		private LuaFunction m_CanGainMissionRewardInt32_hotfix;

		// Token: 0x04003485 RID: 13445
		private LuaFunction m_RegisterMissionCallBack_hotfix;

		// Token: 0x04003486 RID: 13446
		private LuaFunction m_IsCompletedInt32_hotfix;

		// Token: 0x04003487 RID: 13447
		private LuaFunction m_OnSelectCardMissionCallBackInt32Int32_hotfix;

		// Token: 0x04003488 RID: 13448
		private LuaFunction m_OnMissionSelectCardCallBackInt32Int32_hotfix;

		// Token: 0x04003489 RID: 13449
		private LuaFunction m_SetStatisticalDataStatisticalDataTypeInt64_hotfix;

		// Token: 0x0400348A RID: 13450
		private LuaFunction m_AddStatisticalDataStatisticalDataTypeInt32_hotfix;

		// Token: 0x0400348B RID: 13451
		private LuaFunction m_GetMissionCompletedProcessMission_hotfix;

		// Token: 0x0400348C RID: 13452
		private LuaFunction m_OnSummonHeroCallBackInt32_hotfix;

		// Token: 0x0400348D RID: 13453
		private LuaFunction m_OnConsumeEnergyCallBackInt32_hotfix;

		// Token: 0x0400348E RID: 13454
		private LuaFunction m_OnCompleteEventCallBackBoolean_hotfix;

		// Token: 0x0400348F RID: 13455
		private LuaFunction m_OnCompleteLevelCallBackBattleTypeInt32List;

		// Token: 0x04003490 RID: 13456
		private LuaFunction m_RiftLevelAttackDiffculityCallBackInt32_hotfix;

		// Token: 0x04003491 RID: 13457
		private LuaFunction m_AddBattleTypeLevelStatisticalDataBattleType_hotfix;

		// Token: 0x04003492 RID: 13458
		private LuaFunction m_OnArenaConsecutiveVictoryCallBackInt32_hotfix;

		// Token: 0x04003493 RID: 13459
		private LuaFunction m_OnArenaFightCallBack_hotfix;

		// Token: 0x04003494 RID: 13460
		private LuaFunction m_OnCompleteScenaioCallBackInt32_hotfix;

		// Token: 0x04003495 RID: 13461
		private LuaFunction m_OnCompleteRiftLevelCallBackInt32_hotfix;

		// Token: 0x04003496 RID: 13462
		private LuaFunction m_OnGetRiftLevelFightAchievementCallBackInt32_hotfix;

		// Token: 0x04003497 RID: 13463
		private LuaFunction m_OnFinishFightAchievementCallBackInt32_hotfix;

		// Token: 0x04003498 RID: 13464
		private LuaFunction m_OnGetRiftLevelStarCallBackInt32_hotfix;

		// Token: 0x04003499 RID: 13465
		private LuaFunction m_OnConsumeCrystalCallBackInt32_hotfix;

		// Token: 0x0400349A RID: 13466
		private LuaFunction m_OnComsumeGoldCallBackInt32_hotfix;

		// Token: 0x0400349B RID: 13467
		private LuaFunction m_OnUseHeroExpItemCallBackInt32_hotfix;

		// Token: 0x0400349C RID: 13468
		private LuaFunction m_OnAllHeroAllJobLevelUpCallBack_hotfix;

		// Token: 0x0400349D RID: 13469
		private LuaFunction m_OnAllHeroAddJobNums_hotfix;

		// Token: 0x0400349E RID: 13470
		private LuaFunction m_OnRankJobHaveCallBack_hotfix;

		// Token: 0x0400349F RID: 13471
		private LuaFunction m_OnAllHeroAddSkillNumsCallBackInt32_hotfix;

		// Token: 0x040034A0 RID: 13472
		private LuaFunction m_OnAllHeroAddSoliderNumsCallBackInt32_hotfix;

		// Token: 0x040034A1 RID: 13473
		private LuaFunction m_OnAllJobMasterHeroCallBackInt32_hotfix;

		// Token: 0x040034A2 RID: 13474
		private LuaFunction m_OnHeroMasterJobCallBackInt32Int32_hotfix;

		// Token: 0x040034A3 RID: 13475
		private LuaFunction m_OnLevelUpHeroStarLevelCallBackInt32_hotfix;

		// Token: 0x040034A4 RID: 13476
		private LuaFunction m_UpdateHeroRankLevelCallBackInt32_hotfix;

		// Token: 0x040034A5 RID: 13477
		private LuaFunction m_OnAddHeroNumsCallBackInt32_hotfix;

		// Token: 0x040034A6 RID: 13478
		private LuaFunction m_OnHasAboveLevelHeroNumsCallBack_hotfix;

		// Token: 0x040034A7 RID: 13479
		private LuaFunction m_OnLevelUpPlayerLevelCallBackInt32_hotfix;

		// Token: 0x040034A8 RID: 13480
		private LuaFunction m_OnUseCrystalBuyEnergyCallBackInt32_hotfix;

		// Token: 0x040034A9 RID: 13481
		private LuaFunction m_OnLoginGameCallBack_hotfix;

		// Token: 0x040034AA RID: 13482
		private LuaFunction m_OnNewHeroJobTransferCallBackInt32Int32_hotfix;

		// Token: 0x040034AB RID: 13483
		private LuaFunction m_OnSpecificHeroFightInt32Int32_hotfix;

		// Token: 0x040034AC RID: 13484
		private LuaFunction m_OnSpecificHeroLevelUpInt32_hotfix;

		// Token: 0x040034AD RID: 13485
		private LuaFunction m_OnTrainingTechToLevelCallBackTrainingTech_hotfix;

		// Token: 0x040034AE RID: 13486
		private LuaFunction m_OnEquipmentToLevelCallBackEquipmentBagItem_hotfix;

		// Token: 0x040034AF RID: 13487
		private LuaFunction m_OnFinishTeamBattleCallBack_hotfix;

		// Token: 0x040034B0 RID: 13488
		private LuaFunction m_OnFavorabilityToLevelCallBackHero_hotfix;

		// Token: 0x040034B1 RID: 13489
		private LuaFunction m_OnFetterToLevelCallBackHeroInt32_hotfix;

		// Token: 0x040034B2 RID: 13490
		private LuaFunction m_OnEnchantPropertiesSaveCallBackEquipmentBagItem_hotfix;

		// Token: 0x040034B3 RID: 13491
		private LuaFunction m_OnEnchantEquipmentCallBackEquipmentBagItem_hotfix;

		// Token: 0x040034B4 RID: 13492
		private LuaFunction m_OnTotalHeroJobLevelUpCallBack_hotfix;

		// Token: 0x040034B5 RID: 13493
		private LuaFunction m_OnInviteFriendCallBack_hotfix;

		// Token: 0x040034B6 RID: 13494
		private LuaFunction m_OnAssignHeroToTaskCallBack_hotfix;

		// Token: 0x040034B7 RID: 13495
		private LuaFunction m_OnBattlePracticeCallBack_hotfix;

		// Token: 0x040034B8 RID: 13496
		private LuaFunction m_OnRealTimeArenaBattleStartCallBackBattleMode_hotfix;

		// Token: 0x040034B9 RID: 13497
		private LuaFunction m_OnRealTimeArenaBattleFinishCallBackBattleModeBoolean_hotfix;

		// Token: 0x040034BA RID: 13498
		private LuaFunction m_OnRealTimeArenaDanUpdateCallBackInt32_hotfix;

		// Token: 0x040034BB RID: 13499
		private LuaFunction m_OnBuyGiftStoreGoodsCallBackInt32_hotfix;

		// Token: 0x040034BC RID: 13500
		private LuaFunction m_OnBuyRechargeStoreGoodsCallBackInt32_hotfix;

		// Token: 0x040034BD RID: 13501
		private LuaFunction m_OnDoShareCallBack_hotfix;

		// Token: 0x02000487 RID: 1159
		public class LuaExportHelper
		{
			// Token: 0x06004511 RID: 17681 RVA: 0x0015333C File Offset: 0x0015153C
			public LuaExportHelper(MissionComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170011A6 RID: 4518
			// (get) Token: 0x06004512 RID: 17682 RVA: 0x0015334C File Offset: 0x0015154C
			// (set) Token: 0x06004513 RID: 17683 RVA: 0x0015335C File Offset: 0x0015155C
			public HashSet<ConfigDataMissionInfo> m_lockedMissionConfigsInLogic
			{
				get
				{
					return this.m_owner.m_lockedMissionConfigsInLogic;
				}
				set
				{
					this.m_owner.m_lockedMissionConfigsInLogic = value;
				}
			}

			// Token: 0x170011A7 RID: 4519
			// (get) Token: 0x06004514 RID: 17684 RVA: 0x0015336C File Offset: 0x0015156C
			// (set) Token: 0x06004515 RID: 17685 RVA: 0x0015337C File Offset: 0x0015157C
			public HashSet<int> m_existMissions
			{
				get
				{
					return this.m_owner.m_existMissions;
				}
				set
				{
					this.m_owner.m_existMissions = value;
				}
			}

			// Token: 0x170011A8 RID: 4520
			// (get) Token: 0x06004516 RID: 17686 RVA: 0x0015338C File Offset: 0x0015158C
			// (set) Token: 0x06004517 RID: 17687 RVA: 0x0015339C File Offset: 0x0015159C
			public DataSectionMission m_missionDS
			{
				get
				{
					return this.m_owner.m_missionDS;
				}
				set
				{
					this.m_owner.m_missionDS = value;
				}
			}

			// Token: 0x170011A9 RID: 4521
			// (get) Token: 0x06004518 RID: 17688 RVA: 0x001533AC File Offset: 0x001515AC
			// (set) Token: 0x06004519 RID: 17689 RVA: 0x001533BC File Offset: 0x001515BC
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

			// Token: 0x170011AA RID: 4522
			// (get) Token: 0x0600451A RID: 17690 RVA: 0x001533CC File Offset: 0x001515CC
			// (set) Token: 0x0600451B RID: 17691 RVA: 0x001533DC File Offset: 0x001515DC
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

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x0600451C RID: 17692 RVA: 0x001533EC File Offset: 0x001515EC
			// (set) Token: 0x0600451D RID: 17693 RVA: 0x001533FC File Offset: 0x001515FC
			public SelectCardComponentCommon m_selectCard
			{
				get
				{
					return this.m_owner.m_selectCard;
				}
				set
				{
					this.m_owner.m_selectCard = value;
				}
			}

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x0600451E RID: 17694 RVA: 0x0015340C File Offset: 0x0015160C
			// (set) Token: 0x0600451F RID: 17695 RVA: 0x0015341C File Offset: 0x0015161C
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

			// Token: 0x170011AD RID: 4525
			// (get) Token: 0x06004520 RID: 17696 RVA: 0x0015342C File Offset: 0x0015162C
			// (set) Token: 0x06004521 RID: 17697 RVA: 0x0015343C File Offset: 0x0015163C
			public LevelComponentCommon m_level
			{
				get
				{
					return this.m_owner.m_level;
				}
				set
				{
					this.m_owner.m_level = value;
				}
			}

			// Token: 0x170011AE RID: 4526
			// (get) Token: 0x06004522 RID: 17698 RVA: 0x0015344C File Offset: 0x0015164C
			// (set) Token: 0x06004523 RID: 17699 RVA: 0x0015345C File Offset: 0x0015165C
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

			// Token: 0x170011AF RID: 4527
			// (get) Token: 0x06004524 RID: 17700 RVA: 0x0015346C File Offset: 0x0015166C
			// (set) Token: 0x06004525 RID: 17701 RVA: 0x0015347C File Offset: 0x0015167C
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

			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x06004526 RID: 17702 RVA: 0x0015348C File Offset: 0x0015168C
			// (set) Token: 0x06004527 RID: 17703 RVA: 0x0015349C File Offset: 0x0015169C
			public ThearchyTrialCompomentCommon m_thearchyTrial
			{
				get
				{
					return this.m_owner.m_thearchyTrial;
				}
				set
				{
					this.m_owner.m_thearchyTrial = value;
				}
			}

			// Token: 0x170011B1 RID: 4529
			// (get) Token: 0x06004528 RID: 17704 RVA: 0x001534AC File Offset: 0x001516AC
			// (set) Token: 0x06004529 RID: 17705 RVA: 0x001534BC File Offset: 0x001516BC
			public AnikiGymComponentCommon m_anikiGym
			{
				get
				{
					return this.m_owner.m_anikiGym;
				}
				set
				{
					this.m_owner.m_anikiGym = value;
				}
			}

			// Token: 0x170011B2 RID: 4530
			// (get) Token: 0x0600452A RID: 17706 RVA: 0x001534CC File Offset: 0x001516CC
			// (set) Token: 0x0600452B RID: 17707 RVA: 0x001534DC File Offset: 0x001516DC
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

			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x0600452C RID: 17708 RVA: 0x001534EC File Offset: 0x001516EC
			// (set) Token: 0x0600452D RID: 17709 RVA: 0x001534FC File Offset: 0x001516FC
			public ArenaComponentCommon m_arena
			{
				get
				{
					return this.m_owner.m_arena;
				}
				set
				{
					this.m_owner.m_arena = value;
				}
			}

			// Token: 0x170011B4 RID: 4532
			// (get) Token: 0x0600452E RID: 17710 RVA: 0x0015350C File Offset: 0x0015170C
			// (set) Token: 0x0600452F RID: 17711 RVA: 0x0015351C File Offset: 0x0015171C
			public HeroDungeonComponentCommon m_heroDungeon
			{
				get
				{
					return this.m_owner.m_heroDungeon;
				}
				set
				{
					this.m_owner.m_heroDungeon = value;
				}
			}

			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x06004530 RID: 17712 RVA: 0x0015352C File Offset: 0x0015172C
			// (set) Token: 0x06004531 RID: 17713 RVA: 0x0015353C File Offset: 0x0015173C
			public HeroTrainningComponentCommon m_heroTrainning
			{
				get
				{
					return this.m_owner.m_heroTrainning;
				}
				set
				{
					this.m_owner.m_heroTrainning = value;
				}
			}

			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x06004532 RID: 17714 RVA: 0x0015354C File Offset: 0x0015174C
			// (set) Token: 0x06004533 RID: 17715 RVA: 0x0015355C File Offset: 0x0015175C
			public MemoryCorridorCompomentCommon m_memoryCorridor
			{
				get
				{
					return this.m_owner.m_memoryCorridor;
				}
				set
				{
					this.m_owner.m_memoryCorridor = value;
				}
			}

			// Token: 0x170011B7 RID: 4535
			// (get) Token: 0x06004534 RID: 17716 RVA: 0x0015356C File Offset: 0x0015176C
			// (set) Token: 0x06004535 RID: 17717 RVA: 0x0015357C File Offset: 0x0015177C
			public TreasureMapComponentCommon m_treasureMap
			{
				get
				{
					return this.m_owner.m_treasureMap;
				}
				set
				{
					this.m_owner.m_treasureMap = value;
				}
			}

			// Token: 0x170011B8 RID: 4536
			// (get) Token: 0x06004536 RID: 17718 RVA: 0x0015358C File Offset: 0x0015178C
			// (set) Token: 0x06004537 RID: 17719 RVA: 0x0015359C File Offset: 0x0015179C
			public HeroPhantomCompomentCommon m_heroPhantom
			{
				get
				{
					return this.m_owner.m_heroPhantom;
				}
				set
				{
					this.m_owner.m_heroPhantom = value;
				}
			}

			// Token: 0x170011B9 RID: 4537
			// (get) Token: 0x06004538 RID: 17720 RVA: 0x001535AC File Offset: 0x001517AC
			// (set) Token: 0x06004539 RID: 17721 RVA: 0x001535BC File Offset: 0x001517BC
			public CooperateBattleCompomentCommon m_cooperateBattle
			{
				get
				{
					return this.m_owner.m_cooperateBattle;
				}
				set
				{
					this.m_owner.m_cooperateBattle = value;
				}
			}

			// Token: 0x170011BA RID: 4538
			// (get) Token: 0x0600453A RID: 17722 RVA: 0x001535CC File Offset: 0x001517CC
			// (set) Token: 0x0600453B RID: 17723 RVA: 0x001535DC File Offset: 0x001517DC
			public TrainingGroundCompomentCommon m_trainingGround
			{
				get
				{
					return this.m_owner.m_trainingGround;
				}
				set
				{
					this.m_owner.m_trainingGround = value;
				}
			}

			// Token: 0x170011BB RID: 4539
			// (get) Token: 0x0600453C RID: 17724 RVA: 0x001535EC File Offset: 0x001517EC
			// (set) Token: 0x0600453D RID: 17725 RVA: 0x001535FC File Offset: 0x001517FC
			public TeamComponentCommon m_team
			{
				get
				{
					return this.m_owner.m_team;
				}
				set
				{
					this.m_owner.m_team = value;
				}
			}

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x0600453E RID: 17726 RVA: 0x0015360C File Offset: 0x0015180C
			// (set) Token: 0x0600453F RID: 17727 RVA: 0x0015361C File Offset: 0x0015181C
			public NoviceComponentCommon m_novice
			{
				get
				{
					return this.m_owner.m_novice;
				}
				set
				{
					this.m_owner.m_novice = value;
				}
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x06004540 RID: 17728 RVA: 0x0015362C File Offset: 0x0015182C
			// (set) Token: 0x06004541 RID: 17729 RVA: 0x0015363C File Offset: 0x0015183C
			public FriendComponentCommon m_friend
			{
				get
				{
					return this.m_owner.m_friend;
				}
				set
				{
					this.m_owner.m_friend = value;
				}
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x06004542 RID: 17730 RVA: 0x0015364C File Offset: 0x0015184C
			// (set) Token: 0x06004543 RID: 17731 RVA: 0x0015365C File Offset: 0x0015185C
			public HeroAssistantsCompomentCommon m_heroAssistants
			{
				get
				{
					return this.m_owner.m_heroAssistants;
				}
				set
				{
					this.m_owner.m_heroAssistants = value;
				}
			}

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x06004544 RID: 17732 RVA: 0x0015366C File Offset: 0x0015186C
			// (set) Token: 0x06004545 RID: 17733 RVA: 0x0015367C File Offset: 0x0015187C
			public ResourceComponentCommon m_resource
			{
				get
				{
					return this.m_owner.m_resource;
				}
				set
				{
					this.m_owner.m_resource = value;
				}
			}

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x06004546 RID: 17734 RVA: 0x0015368C File Offset: 0x0015188C
			// (set) Token: 0x06004547 RID: 17735 RVA: 0x0015369C File Offset: 0x0015189C
			public RealTimePVPComponentCommon m_realTimePvp
			{
				get
				{
					return this.m_owner.m_realTimePvp;
				}
				set
				{
					this.m_owner.m_realTimePvp = value;
				}
			}

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x06004548 RID: 17736 RVA: 0x001536AC File Offset: 0x001518AC
			// (set) Token: 0x06004549 RID: 17737 RVA: 0x001536BC File Offset: 0x001518BC
			public GiftStoreComponentCommon m_giftStore
			{
				get
				{
					return this.m_owner.m_giftStore;
				}
				set
				{
					this.m_owner.m_giftStore = value;
				}
			}

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x0600454A RID: 17738 RVA: 0x001536CC File Offset: 0x001518CC
			// (set) Token: 0x0600454B RID: 17739 RVA: 0x001536DC File Offset: 0x001518DC
			public RechargeStoreComponentCommon m_rechargeStore
			{
				get
				{
					return this.m_owner.m_rechargeStore;
				}
				set
				{
					this.m_owner.m_rechargeStore = value;
				}
			}

			// Token: 0x0600454C RID: 17740 RVA: 0x001536EC File Offset: 0x001518EC
			public void OnMonthCardVaildEveryDayFlush()
			{
				this.m_owner.OnMonthCardVaildEveryDayFlush();
			}

			// Token: 0x0600454D RID: 17741 RVA: 0x001536FC File Offset: 0x001518FC
			public void OnMonthCardVaildCallBack(int monthCardId)
			{
				this.m_owner.OnMonthCardVaildCallBack(monthCardId);
			}

			// Token: 0x0600454E RID: 17742 RVA: 0x0015370C File Offset: 0x0015190C
			public void InitProcessingMission(List<Mission> processingMissionList)
			{
				this.m_owner.InitProcessingMission(processingMissionList);
			}

			// Token: 0x0600454F RID: 17743 RVA: 0x0015371C File Offset: 0x0015191C
			public void InitExistMissions()
			{
				this.m_owner.InitExistMissions();
			}

			// Token: 0x06004550 RID: 17744 RVA: 0x0015372C File Offset: 0x0015192C
			public void OnFlushEverydayMissionEvent()
			{
				this.m_owner.OnFlushEverydayMissionEvent();
			}

			// Token: 0x06004551 RID: 17745 RVA: 0x0015373C File Offset: 0x0015193C
			public void ResetEverydayMissions()
			{
				this.m_owner.ResetEverydayMissions();
			}

			// Token: 0x06004552 RID: 17746 RVA: 0x0015374C File Offset: 0x0015194C
			public void InitMissionListByMissionPeriodType(MissionPeriodType missionPeriod)
			{
				this.m_owner.InitMissionListByMissionPeriodType(missionPeriod);
			}

			// Token: 0x06004553 RID: 17747 RVA: 0x0015375C File Offset: 0x0015195C
			public bool CanUnlockMissionInLogicFromInit(ConfigDataMissionInfo missionInfo)
			{
				return this.m_owner.CanUnlockMissionInLogicFromInit(missionInfo);
			}

			// Token: 0x06004554 RID: 17748 RVA: 0x0015376C File Offset: 0x0015196C
			public void OnDirectActivatedMissionLocked(ConfigDataMissionInfo missionConfig)
			{
				this.m_owner.OnDirectActivatedMissionLocked(missionConfig);
			}

			// Token: 0x06004555 RID: 17749 RVA: 0x0015377C File Offset: 0x0015197C
			public bool IsNoviceMission(Mission mission)
			{
				return this.m_owner.IsNoviceMission(mission);
			}

			// Token: 0x06004556 RID: 17750 RVA: 0x0015378C File Offset: 0x0015198C
			public bool IsNoviceMission(ConfigDataMissionInfo mission)
			{
				return this.m_owner.IsNoviceMission(mission);
			}

			// Token: 0x06004557 RID: 17751 RVA: 0x0015379C File Offset: 0x0015199C
			public bool IsNoviceMissionActivated(ConfigDataMissionInfo mission)
			{
				return this.m_owner.IsNoviceMissionActivated(mission);
			}

			// Token: 0x06004558 RID: 17752 RVA: 0x001537AC File Offset: 0x001519AC
			public bool IsNoviceMissionActivatedForRewarding(ConfigDataMissionInfo mission)
			{
				return this.m_owner.IsNoviceMissionActivatedForRewarding(mission);
			}

			// Token: 0x06004559 RID: 17753 RVA: 0x001537BC File Offset: 0x001519BC
			public bool IsNoviceMissionActivated(Mission mission)
			{
				return this.m_owner.IsNoviceMissionActivated(mission);
			}

			// Token: 0x0600455A RID: 17754 RVA: 0x001537CC File Offset: 0x001519CC
			public bool CanUnlockMissionInLogic(ConfigDataMissionInfo missionConfigInfo)
			{
				return this.m_owner.CanUnlockMissionInLogic(missionConfigInfo);
			}

			// Token: 0x0600455B RID: 17755 RVA: 0x001537DC File Offset: 0x001519DC
			public bool CanUnlockMission(ConfigDataMissionInfo missionConfigInfo)
			{
				return this.m_owner.CanUnlockMission(missionConfigInfo);
			}

			// Token: 0x0600455C RID: 17756 RVA: 0x001537EC File Offset: 0x001519EC
			public DirectlyActivatedMissionSatatus CaculateDirectlyActivationMissionStatus(ConfigDataMissionInfo missionConfigInfo)
			{
				return this.m_owner.CaculateDirectlyActivationMissionStatus(missionConfigInfo);
			}

			// Token: 0x0600455D RID: 17757 RVA: 0x001537FC File Offset: 0x001519FC
			public bool AddMission(ConfigDataMissionInfo missionInfo)
			{
				return this.m_owner.AddMission(missionInfo);
			}

			// Token: 0x0600455E RID: 17758 RVA: 0x0015380C File Offset: 0x00151A0C
			public void OnAddProcessingDirectelyActivitedMission(Mission mission)
			{
				this.m_owner.OnAddProcessingDirectelyActivitedMission(mission);
			}

			// Token: 0x0600455F RID: 17759 RVA: 0x0015381C File Offset: 0x00151A1C
			public Mission GetProcessingMissionByMissionPeriod(MissionPeriodType missionPeriodType, int missionId)
			{
				return this.m_owner.GetProcessingMissionByMissionPeriod(missionPeriodType, missionId);
			}

			// Token: 0x06004560 RID: 17760 RVA: 0x0015382C File Offset: 0x00151A2C
			public void OnGetProcessingDirectActivationMissionFail(Mission mission)
			{
				this.m_owner.OnGetProcessingDirectActivationMissionFail(mission);
			}

			// Token: 0x06004561 RID: 17761 RVA: 0x0015383C File Offset: 0x00151A3C
			public void AddEverydayMission(Mission mission)
			{
				this.m_owner.AddEverydayMission(mission);
			}

			// Token: 0x06004562 RID: 17762 RVA: 0x0015384C File Offset: 0x00151A4C
			public void AddOneOffMission(Mission mission)
			{
				this.m_owner.AddOneOffMission(mission);
			}

			// Token: 0x06004563 RID: 17763 RVA: 0x0015385C File Offset: 0x00151A5C
			public bool IsMissionExist(int missionId)
			{
				return this.m_owner.IsMissionExist(missionId);
			}

			// Token: 0x06004564 RID: 17764 RVA: 0x0015386C File Offset: 0x00151A6C
			public void InitMissionsFromConfig(List<Mission> missions)
			{
				this.m_owner.InitMissionsFromConfig(missions);
			}

			// Token: 0x06004565 RID: 17765 RVA: 0x0015387C File Offset: 0x00151A7C
			public void FinishMission(Mission mission)
			{
				this.m_owner.FinishMission(mission);
			}

			// Token: 0x06004566 RID: 17766 RVA: 0x0015388C File Offset: 0x00151A8C
			public List<ConfigDataMissionInfo> GetAllEverydayMissionConfigByPreMissionId(int missionId)
			{
				return this.m_owner.GetAllEverydayMissionConfigByPreMissionId(missionId);
			}

			// Token: 0x06004567 RID: 17767 RVA: 0x0015389C File Offset: 0x00151A9C
			public List<ConfigDataMissionInfo> GetAllEverydayMissionListByPlayerLevel(int playerLvl)
			{
				return this.m_owner.GetAllEverydayMissionListByPlayerLevel(playerLvl);
			}

			// Token: 0x06004568 RID: 17768 RVA: 0x001538AC File Offset: 0x00151AAC
			public List<ConfigDataMissionInfo> GetAllEverydayMissionListByScenario(int scenario)
			{
				return this.m_owner.GetAllEverydayMissionListByScenario(scenario);
			}

			// Token: 0x06004569 RID: 17769 RVA: 0x001538BC File Offset: 0x00151ABC
			public void UpdateMissionListByMissionComplete(int missionId)
			{
				this.m_owner.UpdateMissionListByMissionComplete(missionId);
			}

			// Token: 0x0600456A RID: 17770 RVA: 0x001538CC File Offset: 0x00151ACC
			public void UpdateMissionListByLevelUp(int playerLevel)
			{
				this.m_owner.UpdateMissionListByLevelUp(playerLevel);
			}

			// Token: 0x0600456B RID: 17771 RVA: 0x001538DC File Offset: 0x00151ADC
			public void UpdateMissionListByScenario(int scenarioId)
			{
				this.m_owner.UpdateMissionListByScenario(scenarioId);
			}

			// Token: 0x0600456C RID: 17772 RVA: 0x001538EC File Offset: 0x00151AEC
			public void UpdateMissionListByNewMissionConfigList(List<ConfigDataMissionInfo> newMissionConfigList)
			{
				this.m_owner.UpdateMissionListByNewMissionConfigList(newMissionConfigList);
			}

			// Token: 0x0600456D RID: 17773 RVA: 0x001538FC File Offset: 0x00151AFC
			public void AddMissionProcess(Mission mission, long process)
			{
				this.m_owner.AddMissionProcess(mission, process);
			}

			// Token: 0x0600456E RID: 17774 RVA: 0x0015390C File Offset: 0x00151B0C
			public void RegisterMissionCallBack()
			{
				this.m_owner.RegisterMissionCallBack();
			}

			// Token: 0x0600456F RID: 17775 RVA: 0x0015391C File Offset: 0x00151B1C
			public bool IsCompleted(int missionId)
			{
				return this.m_owner.IsCompleted(missionId);
			}

			// Token: 0x06004570 RID: 17776 RVA: 0x0015392C File Offset: 0x00151B2C
			public void OnSelectCardMissionCallBack(int cardPoolId, int selectCount)
			{
				this.m_owner.OnSelectCardMissionCallBack(cardPoolId, selectCount);
			}

			// Token: 0x06004571 RID: 17777 RVA: 0x0015393C File Offset: 0x00151B3C
			public void OnMissionSelectCardCallBack(int cardPoolId, int selectCount)
			{
				this.m_owner.OnMissionSelectCardCallBack(cardPoolId, selectCount);
			}

			// Token: 0x06004572 RID: 17778 RVA: 0x0015394C File Offset: 0x00151B4C
			public void SetStatisticalData(StatisticalDataType typeId, long nums)
			{
				this.m_owner.SetStatisticalData(typeId, nums);
			}

			// Token: 0x06004573 RID: 17779 RVA: 0x0015395C File Offset: 0x00151B5C
			public void AddStatisticalData(StatisticalDataType typeId, int nums)
			{
				this.m_owner.AddStatisticalData(typeId, nums);
			}

			// Token: 0x06004574 RID: 17780 RVA: 0x0015396C File Offset: 0x00151B6C
			public void OnSummonHeroCallBack(int heroId)
			{
				this.m_owner.OnSummonHeroCallBack(heroId);
			}

			// Token: 0x06004575 RID: 17781 RVA: 0x0015397C File Offset: 0x00151B7C
			public void OnConsumeEnergyCallBack(int energyCost)
			{
				this.m_owner.OnConsumeEnergyCallBack(energyCost);
			}

			// Token: 0x06004576 RID: 17782 RVA: 0x0015398C File Offset: 0x00151B8C
			public void OnCompleteEventCallBack(bool isRandomEvent)
			{
				this.m_owner.OnCompleteEventCallBack(isRandomEvent);
			}

			// Token: 0x06004577 RID: 17783 RVA: 0x0015399C File Offset: 0x00151B9C
			public void OnCompleteLevelCallBack(BattleType levelType, int levelId, List<int> fightHeroes)
			{
				this.m_owner.OnCompleteLevelCallBack(levelType, levelId, fightHeroes);
			}

			// Token: 0x06004578 RID: 17784 RVA: 0x001539AC File Offset: 0x00151BAC
			public void RiftLevelAttackDiffculityCallBack(int levelId)
			{
				this.m_owner.RiftLevelAttackDiffculityCallBack(levelId);
			}

			// Token: 0x06004579 RID: 17785 RVA: 0x001539BC File Offset: 0x00151BBC
			public void AddBattleTypeLevelStatisticalData(BattleType levelType)
			{
				this.m_owner.AddBattleTypeLevelStatisticalData(levelType);
			}

			// Token: 0x0600457A RID: 17786 RVA: 0x001539CC File Offset: 0x00151BCC
			public void OnArenaConsecutiveVictoryCallBack(int consecutiveVictoryNums)
			{
				this.m_owner.OnArenaConsecutiveVictoryCallBack(consecutiveVictoryNums);
			}

			// Token: 0x0600457B RID: 17787 RVA: 0x001539DC File Offset: 0x00151BDC
			public void OnArenaFightCallBack()
			{
				this.m_owner.OnArenaFightCallBack();
			}

			// Token: 0x0600457C RID: 17788 RVA: 0x001539EC File Offset: 0x00151BEC
			public void OnCompleteScenaioCallBack(int scenarioId)
			{
				this.m_owner.OnCompleteScenaioCallBack(scenarioId);
			}

			// Token: 0x0600457D RID: 17789 RVA: 0x001539FC File Offset: 0x00151BFC
			public void OnCompleteRiftLevelCallBack(int diffculty)
			{
				this.m_owner.OnCompleteRiftLevelCallBack(diffculty);
			}

			// Token: 0x0600457E RID: 17790 RVA: 0x00153A0C File Offset: 0x00151C0C
			public void OnGetRiftLevelFightAchievementCallBack(int achievementRelatedId)
			{
				this.m_owner.OnGetRiftLevelFightAchievementCallBack(achievementRelatedId);
			}

			// Token: 0x0600457F RID: 17791 RVA: 0x00153A1C File Offset: 0x00151C1C
			public void OnFinishFightAchievementCallBack(int achievementRelatedId)
			{
				this.m_owner.OnFinishFightAchievementCallBack(achievementRelatedId);
			}

			// Token: 0x06004580 RID: 17792 RVA: 0x00153A2C File Offset: 0x00151C2C
			public void OnGetRiftLevelStarCallBack(int starCount)
			{
				this.m_owner.OnGetRiftLevelStarCallBack(starCount);
			}

			// Token: 0x06004581 RID: 17793 RVA: 0x00153A3C File Offset: 0x00151C3C
			public void OnConsumeCrystalCallBack(int crystalCount)
			{
				this.m_owner.OnConsumeCrystalCallBack(crystalCount);
			}

			// Token: 0x06004582 RID: 17794 RVA: 0x00153A4C File Offset: 0x00151C4C
			public void OnComsumeGoldCallBack(int goldCount)
			{
				this.m_owner.OnComsumeGoldCallBack(goldCount);
			}

			// Token: 0x06004583 RID: 17795 RVA: 0x00153A5C File Offset: 0x00151C5C
			public void OnUseHeroExpItemCallBack(int itemCount)
			{
				this.m_owner.OnUseHeroExpItemCallBack(itemCount);
			}

			// Token: 0x06004584 RID: 17796 RVA: 0x00153A6C File Offset: 0x00151C6C
			public void OnAllHeroAllJobLevelUpCallBack()
			{
				this.m_owner.OnAllHeroAllJobLevelUpCallBack();
			}

			// Token: 0x06004585 RID: 17797 RVA: 0x00153A7C File Offset: 0x00151C7C
			public void OnAllHeroAddJobNums()
			{
				this.m_owner.OnAllHeroAddJobNums();
			}

			// Token: 0x06004586 RID: 17798 RVA: 0x00153A8C File Offset: 0x00151C8C
			public void OnRankJobHaveCallBack()
			{
				this.m_owner.OnRankJobHaveCallBack();
			}

			// Token: 0x06004587 RID: 17799 RVA: 0x00153A9C File Offset: 0x00151C9C
			public void OnAllHeroAddSkillNumsCallBack(int skillId)
			{
				this.m_owner.OnAllHeroAddSkillNumsCallBack(skillId);
			}

			// Token: 0x06004588 RID: 17800 RVA: 0x00153AAC File Offset: 0x00151CAC
			public void OnAllHeroAddSoliderNumsCallBack(int soliderId)
			{
				this.m_owner.OnAllHeroAddSoliderNumsCallBack(soliderId);
			}

			// Token: 0x06004589 RID: 17801 RVA: 0x00153ABC File Offset: 0x00151CBC
			public void OnAllJobMasterHeroCallBack(int heroId)
			{
				this.m_owner.OnAllJobMasterHeroCallBack(heroId);
			}

			// Token: 0x0600458A RID: 17802 RVA: 0x00153ACC File Offset: 0x00151CCC
			public void OnHeroMasterJobCallBack(int heroId, int jobRelateId)
			{
				this.m_owner.OnHeroMasterJobCallBack(heroId, jobRelateId);
			}

			// Token: 0x0600458B RID: 17803 RVA: 0x00153ADC File Offset: 0x00151CDC
			public void OnLevelUpHeroStarLevelCallBack(int heroId)
			{
				this.m_owner.OnLevelUpHeroStarLevelCallBack(heroId);
			}

			// Token: 0x0600458C RID: 17804 RVA: 0x00153AEC File Offset: 0x00151CEC
			public void UpdateHeroRankLevelCallBack(int heroRank)
			{
				this.m_owner.UpdateHeroRankLevelCallBack(heroRank);
			}

			// Token: 0x0600458D RID: 17805 RVA: 0x00153AFC File Offset: 0x00151CFC
			public void OnAddHeroNumsCallBack(int heroId)
			{
				this.m_owner.OnAddHeroNumsCallBack(heroId);
			}

			// Token: 0x0600458E RID: 17806 RVA: 0x00153B0C File Offset: 0x00151D0C
			public void OnHasAboveLevelHeroNumsCallBack()
			{
				this.m_owner.OnHasAboveLevelHeroNumsCallBack();
			}

			// Token: 0x0600458F RID: 17807 RVA: 0x00153B1C File Offset: 0x00151D1C
			public void OnLevelUpPlayerLevelCallBack(int upLevel)
			{
				this.m_owner.OnLevelUpPlayerLevelCallBack(upLevel);
			}

			// Token: 0x06004590 RID: 17808 RVA: 0x00153B2C File Offset: 0x00151D2C
			public void OnUseCrystalBuyEnergyCallBack(int buyCount)
			{
				this.m_owner.OnUseCrystalBuyEnergyCallBack(buyCount);
			}

			// Token: 0x06004591 RID: 17809 RVA: 0x00153B3C File Offset: 0x00151D3C
			public void OnLoginGameCallBack()
			{
				this.m_owner.OnLoginGameCallBack();
			}

			// Token: 0x06004592 RID: 17810 RVA: 0x00153B4C File Offset: 0x00151D4C
			public void OnNewHeroJobTransferCallBack(int heroId, int jobConnnectionId)
			{
				this.m_owner.OnNewHeroJobTransferCallBack(heroId, jobConnnectionId);
			}

			// Token: 0x06004593 RID: 17811 RVA: 0x00153B5C File Offset: 0x00151D5C
			public void OnSpecificHeroFight(int heroId, int fightNums)
			{
				this.m_owner.OnSpecificHeroFight(heroId, fightNums);
			}

			// Token: 0x06004594 RID: 17812 RVA: 0x00153B6C File Offset: 0x00151D6C
			public void OnSpecificHeroLevelUp(int heroId)
			{
				this.m_owner.OnSpecificHeroLevelUp(heroId);
			}

			// Token: 0x06004595 RID: 17813 RVA: 0x00153B7C File Offset: 0x00151D7C
			public void OnTrainingTechToLevelCallBack(TrainingTech Tech)
			{
				this.m_owner.OnTrainingTechToLevelCallBack(Tech);
			}

			// Token: 0x06004596 RID: 17814 RVA: 0x00153B8C File Offset: 0x00151D8C
			public void OnEquipmentToLevelCallBack(EquipmentBagItem Equipment)
			{
				this.m_owner.OnEquipmentToLevelCallBack(Equipment);
			}

			// Token: 0x06004597 RID: 17815 RVA: 0x00153B9C File Offset: 0x00151D9C
			public void OnFinishTeamBattleCallBack()
			{
				this.m_owner.OnFinishTeamBattleCallBack();
			}

			// Token: 0x06004598 RID: 17816 RVA: 0x00153BAC File Offset: 0x00151DAC
			public void OnFavorabilityToLevelCallBack(Hero Hero)
			{
				this.m_owner.OnFavorabilityToLevelCallBack(Hero);
			}

			// Token: 0x06004599 RID: 17817 RVA: 0x00153BBC File Offset: 0x00151DBC
			public void OnFetterToLevelCallBack(Hero Hero, int FetterId)
			{
				this.m_owner.OnFetterToLevelCallBack(Hero, FetterId);
			}

			// Token: 0x0600459A RID: 17818 RVA: 0x00153BCC File Offset: 0x00151DCC
			public void OnEnchantPropertiesSaveCallBack(EquipmentBagItem equipment)
			{
				this.m_owner.OnEnchantPropertiesSaveCallBack(equipment);
			}

			// Token: 0x0600459B RID: 17819 RVA: 0x00153BDC File Offset: 0x00151DDC
			public void OnEnchantEquipmentCallBack(EquipmentBagItem equipment)
			{
				this.m_owner.OnEnchantEquipmentCallBack(equipment);
			}

			// Token: 0x0600459C RID: 17820 RVA: 0x00153BEC File Offset: 0x00151DEC
			public void OnTotalHeroJobLevelUpCallBack()
			{
				this.m_owner.OnTotalHeroJobLevelUpCallBack();
			}

			// Token: 0x0600459D RID: 17821 RVA: 0x00153BFC File Offset: 0x00151DFC
			public void OnInviteFriendCallBack()
			{
				this.m_owner.OnInviteFriendCallBack();
			}

			// Token: 0x0600459E RID: 17822 RVA: 0x00153C0C File Offset: 0x00151E0C
			public void OnAssignHeroToTaskCallBack()
			{
				this.m_owner.OnAssignHeroToTaskCallBack();
			}

			// Token: 0x0600459F RID: 17823 RVA: 0x00153C1C File Offset: 0x00151E1C
			public void OnBattlePracticeCallBack()
			{
				this.m_owner.OnBattlePracticeCallBack();
			}

			// Token: 0x060045A0 RID: 17824 RVA: 0x00153C2C File Offset: 0x00151E2C
			public void OnRealTimeArenaBattleStartCallBack(BattleMode battleMode)
			{
				this.m_owner.OnRealTimeArenaBattleStartCallBack(battleMode);
			}

			// Token: 0x060045A1 RID: 17825 RVA: 0x00153C3C File Offset: 0x00151E3C
			public void OnRealTimeArenaBattleFinishCallBack(BattleMode battleMode, bool win)
			{
				this.m_owner.OnRealTimeArenaBattleFinishCallBack(battleMode, win);
			}

			// Token: 0x060045A2 RID: 17826 RVA: 0x00153C4C File Offset: 0x00151E4C
			public void OnRealTimeArenaDanUpdateCallBack(int dan)
			{
				this.m_owner.OnRealTimeArenaDanUpdateCallBack(dan);
			}

			// Token: 0x060045A3 RID: 17827 RVA: 0x00153C5C File Offset: 0x00151E5C
			public void OnBuyGiftStoreGoodsCallBack(int goodsId)
			{
				this.m_owner.OnBuyGiftStoreGoodsCallBack(goodsId);
			}

			// Token: 0x060045A4 RID: 17828 RVA: 0x00153C6C File Offset: 0x00151E6C
			public void OnBuyRechargeStoreGoodsCallBack(int goodsId)
			{
				this.m_owner.OnBuyRechargeStoreGoodsCallBack(goodsId);
			}

			// Token: 0x060045A5 RID: 17829 RVA: 0x00153C7C File Offset: 0x00151E7C
			public void OnDoShareCallBack()
			{
				this.m_owner.OnDoShareCallBack();
			}

			// Token: 0x040034BE RID: 13502
			private MissionComponentCommon m_owner;
		}
	}
}
