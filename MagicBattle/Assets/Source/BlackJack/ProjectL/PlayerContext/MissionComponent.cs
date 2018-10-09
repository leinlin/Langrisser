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
	// Token: 0x020008CD RID: 2253
	[HotFix]
	public class MissionComponent : MissionComponentCommon
	{
		// Token: 0x06007396 RID: 29590 RVA: 0x001FE6F8 File Offset: 0x001FC8F8
		public MissionComponent()
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

		// Token: 0x06007397 RID: 29591 RVA: 0x001FE760 File Offset: 0x001FC960
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

		// Token: 0x06007398 RID: 29592 RVA: 0x001FE7DC File Offset: 0x001FC9DC
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

		// Token: 0x06007399 RID: 29593 RVA: 0x001FE844 File Offset: 0x001FCA44
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

		// Token: 0x0600739A RID: 29594 RVA: 0x001FE8AC File Offset: 0x001FCAAC
		public void DeSerialize(DSMissionNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSMissionNtf_hotfix != null)
			{
				this.m_DeSerializeDSMissionNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_missionDS.ClearInitedData();
			this.m_lockedMissionConfigsInLogic.Clear();
			base.InitProcessingMission(Mission.PBMissionListToMissionList(msg.ProcessingMissionList));
			this.m_missionDS.InitFinishedEverydayMissions(msg.FinishedEverydayMissionList);
			this.m_missionDS.InitFinishedOneOffMissions(msg.FinishedOneOffMissionList);
			this.m_missionDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			base.InitExistMissions();
			base.InitMissionListByMissionPeriodType(MissionPeriodType.MissionPeriodType_Everyday);
			base.InitMissionListByMissionPeriodType(MissionPeriodType.MissionPeriodType_OneOff);
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x001FE994 File Offset: 0x001FCB94
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
			return this.m_missionDS.ClientVersion;
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x001FEA0C File Offset: 0x001FCC0C
		public void AddMissionById(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMissionByIdInt32_hotfix != null)
			{
				this.m_AddMissionByIdInt32_hotfix.call(new object[]
				{
					this,
					missionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMissionInfo configDataMissionInfo = this.m_configDataLoader.GetConfigDataMissionInfo(missionId);
			if (configDataMissionInfo == null)
			{
				return;
			}
			base.AddMission(configDataMissionInfo);
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x001FEA98 File Offset: 0x001FCC98
		protected override bool CanUnlockMissionInLogicFromInit(ConfigDataMissionInfo missionInfo)
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
			return missionInfo.MissionType != MissionType.MissionType_DirectActivation && base.CanUnlockMissionInLogicFromInit(missionInfo);
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x001FEB2C File Offset: 0x001FCD2C
		protected bool CanUnlockMissionInUIInterface(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockMissionInUIInterfaceMission_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUnlockMissionInUIInterfaceMission_hotfix.call(new object[]
				{
					this,
					mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMissionInfo config = mission.Config;
			if (config.MissionColumn == MissionColumnType.MissionColumnType_HeroFetter || config.MissionColumn == MissionColumnType.MissionColumnType_BeginningOfTheLegend)
			{
				return false;
			}
			MissionPeriodType missionPeriod = config.MissionPeriod;
			return (missionPeriod == MissionPeriodType.MissionPeriodType_OneOff || missionPeriod == MissionPeriodType.MissionPeriodType_Everyday) && (config.IsMonthCardMission || base.CanUnlockMission(config));
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x001FEBFC File Offset: 0x001FCDFC
		public int GetMissionReward(int missionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissionRewardInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMissionRewardInt32_hotfix.call(new object[]
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
			Mission processingMissionByMissionPeriod = base.GetProcessingMissionByMissionPeriod(configDataMissionInfo.MissionPeriod, configDataMissionInfo.ID);
			if (processingMissionByMissionPeriod == null)
			{
				return -1603;
			}
			base.FinishMission(processingMissionByMissionPeriod);
			if (base.IsNoviceMission(processingMissionByMissionPeriod) && base.IsNoviceMissionActivated(processingMissionByMissionPeriod))
			{
				this.m_novice.AddMissionPoints(processingMissionByMissionPeriod.Config.m_Novice.NovicePoints);
			}
			return 0;
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x001FECEC File Offset: 0x001FCEEC
		public List<Mission> GetAllProcessingMissionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllProcessingMissionList_hotfix != null)
			{
				return (List<Mission>)this.m_GetAllProcessingMissionList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> list = new List<Mission>();
			foreach (Mission mission in this.m_missionDS.GetAllProcessingMissions())
			{
				if (this.CanUnlockMissionInUIInterface(mission))
				{
					if (!base.CanGetRewarding(mission))
					{
						DirectlyActivatedMissionSatatus directlyActivatedMissionSatatus = base.CaculateDirectlyActivationMissionStatus(mission.Config);
						if (directlyActivatedMissionSatatus != DirectlyActivatedMissionSatatus.Expired && directlyActivatedMissionSatatus != DirectlyActivatedMissionSatatus.NotOnToday && directlyActivatedMissionSatatus != DirectlyActivatedMissionSatatus.Locked)
						{
							list.Add(mission);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x001FEDFC File Offset: 0x001FCFFC
		public List<Mission> GetAllCompletedMissionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllCompletedMissionList_hotfix != null)
			{
				return (List<Mission>)this.m_GetAllCompletedMissionList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> list = new List<Mission>();
			foreach (Mission mission in this.m_missionDS.GetAllProcessingMissions())
			{
				if (this.CanUnlockMissionInUIInterface(mission))
				{
					if (base.CanGetRewarding(mission))
					{
						list.Add(mission);
					}
				}
			}
			return list;
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x001FEEE0 File Offset: 0x001FD0E0
		public List<Mission> GetAllFinishedMissionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllFinishedMissionList_hotfix != null)
			{
				return (List<Mission>)this.m_GetAllFinishedMissionList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mission> list = new List<Mission>();
			foreach (int missionId in this.m_missionDS.FinishedOneOffMissions)
			{
				Mission item = new Mission(missionId);
				list.Add(item);
			}
			foreach (int missionId2 in this.m_missionDS.FinishedEverydayMissions)
			{
				Mission item2 = new Mission(missionId2);
				list.Add(item2);
			}
			base.InitMissionsFromConfig(list);
			return list;
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x060073A3 RID: 29603 RVA: 0x001FF014 File Offset: 0x001FD214
		// (set) Token: 0x060073A4 RID: 29604 RVA: 0x001FF034 File Offset: 0x001FD234
		[DoNotToLua]
		public new MissionComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MissionComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x001FF040 File Offset: 0x001FD240
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x001FF048 File Offset: 0x001FD248
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x001FF050 File Offset: 0x001FD250
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x001FF058 File Offset: 0x001FD258
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x001FF060 File Offset: 0x001FD260
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x001FF06C File Offset: 0x001FD26C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x001FF074 File Offset: 0x001FD274
		private void __callBase_RemoveProcessingMissionById(int missionId)
		{
			base.RemoveProcessingMissionById(missionId);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x001FF080 File Offset: 0x001FD280
		private void __callBase_InitProcessingMission(List<Mission> processingMissionList)
		{
			base.InitProcessingMission(processingMissionList);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x001FF08C File Offset: 0x001FD28C
		private List<Mission> __callBase_GetProcessingMissionByMissionType(MissionType missionType)
		{
			return base.GetProcessingMissionByMissionType(missionType);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x001FF098 File Offset: 0x001FD298
		private void __callBase_InitExistMissions()
		{
			base.InitExistMissions();
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x001FF0A0 File Offset: 0x001FD2A0
		private void __callBase_ResetEverydayMissions()
		{
			base.ResetEverydayMissions();
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x001FF0A8 File Offset: 0x001FD2A8
		private void __callBase_InitMissionListByMissionPeriodType(MissionPeriodType missionPeriod)
		{
			base.InitMissionListByMissionPeriodType(missionPeriod);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x001FF0B4 File Offset: 0x001FD2B4
		private bool __callBase_CanUnlockMissionInLogicFromInit(ConfigDataMissionInfo missionInfo)
		{
			return base.CanUnlockMissionInLogicFromInit(missionInfo);
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x001FF0C0 File Offset: 0x001FD2C0
		private void __callBase_OnDirectActivatedMissionLocked(ConfigDataMissionInfo missionConfig)
		{
			base.OnDirectActivatedMissionLocked(missionConfig);
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x001FF0CC File Offset: 0x001FD2CC
		private bool __callBase_IsNoviceMission(Mission mission)
		{
			return base.IsNoviceMission(mission);
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x001FF0D8 File Offset: 0x001FD2D8
		private bool __callBase_IsNoviceMission(ConfigDataMissionInfo mission)
		{
			return base.IsNoviceMission(mission);
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x001FF0E4 File Offset: 0x001FD2E4
		private bool __callBase_IsNoviceMissionActivated(ConfigDataMissionInfo mission)
		{
			return base.IsNoviceMissionActivated(mission);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x001FF0F0 File Offset: 0x001FD2F0
		private bool __callBase_IsNoviceMissionActivatedForRewarding(ConfigDataMissionInfo mission)
		{
			return base.IsNoviceMissionActivatedForRewarding(mission);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x001FF0FC File Offset: 0x001FD2FC
		private bool __callBase_IsNoviceMissionActivated(Mission mission)
		{
			return base.IsNoviceMissionActivated(mission);
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x001FF108 File Offset: 0x001FD308
		private bool __callBase_CanGetRewarding(Mission mission)
		{
			return base.CanGetRewarding(mission);
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x001FF114 File Offset: 0x001FD314
		private bool __callBase_CanUnlockMissionInLogic(ConfigDataMissionInfo missionConfigInfo)
		{
			return base.CanUnlockMissionInLogic(missionConfigInfo);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x001FF120 File Offset: 0x001FD320
		private bool __callBase_CanUnlockMission(ConfigDataMissionInfo missionConfigInfo)
		{
			return base.CanUnlockMission(missionConfigInfo);
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x001FF12C File Offset: 0x001FD32C
		private DirectlyActivatedMissionSatatus __callBase_CaculateDirectlyActivationMissionStatus(ConfigDataMissionInfo missionConfigInfo)
		{
			return base.CaculateDirectlyActivationMissionStatus(missionConfigInfo);
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x001FF138 File Offset: 0x001FD338
		private bool __callBase_AddMission(ConfigDataMissionInfo missionInfo)
		{
			return base.AddMission(missionInfo);
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x001FF144 File Offset: 0x001FD344
		private void __callBase_OnAddProcessingDirectelyActivitedMission(Mission mission)
		{
			base.OnAddProcessingDirectelyActivitedMission(mission);
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x001FF150 File Offset: 0x001FD350
		private Mission __callBase_GetProcessingMissionByMissionPeriod(MissionPeriodType missionPeriodType, int missionId)
		{
			return base.GetProcessingMissionByMissionPeriod(missionPeriodType, missionId);
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x001FF15C File Offset: 0x001FD35C
		private void __callBase_OnGetProcessingDirectActivationMissionFail(Mission mission)
		{
			base.OnGetProcessingDirectActivationMissionFail(mission);
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x001FF168 File Offset: 0x001FD368
		private void __callBase_AddOneOffMission(Mission mission)
		{
			base.AddOneOffMission(mission);
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x001FF174 File Offset: 0x001FD374
		private bool __callBase_IsMissionFinished(int missionId)
		{
			return base.IsMissionFinished(missionId);
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x001FF180 File Offset: 0x001FD380
		private void __callBase_InitMissionsFromConfig(List<Mission> missions)
		{
			base.InitMissionsFromConfig(missions);
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x001FF18C File Offset: 0x001FD38C
		private void __callBase_FinishMission(Mission mission)
		{
			base.FinishMission(mission);
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x001FF198 File Offset: 0x001FD398
		private List<Mission> __callBase_GetAllProcessingNoviceMissionList()
		{
			return base.GetAllProcessingNoviceMissionList();
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x001FF1A0 File Offset: 0x001FD3A0
		private List<Mission> __callBase_GetAllFinishedNoviceMissionList()
		{
			return base.GetAllFinishedNoviceMissionList();
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x001FF1A8 File Offset: 0x001FD3A8
		private void __callBase_AddMissionProcess(Mission mission, long process)
		{
			base.AddMissionProcess(mission, process);
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x001FF1B4 File Offset: 0x001FD3B4
		private int __callBase_GetMissionMaxProcess(Mission mission)
		{
			return base.GetMissionMaxProcess(mission);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x001FF1C0 File Offset: 0x001FD3C0
		private bool __callBase_IsMissionProcessFinished(int missionId)
		{
			return base.IsMissionProcessFinished(missionId);
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x001FF1CC File Offset: 0x001FD3CC
		private int __callBase_CanGainMissionReward(int missionId)
		{
			return base.CanGainMissionReward(missionId);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x001FF1D8 File Offset: 0x001FD3D8
		private bool __callBase_IsCompleted(int missionId)
		{
			return base.IsCompleted(missionId);
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x001FF1E4 File Offset: 0x001FD3E4
		private void __callBase_SetStatisticalData(StatisticalDataType typeId, long nums)
		{
			base.SetStatisticalData(typeId, nums);
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x001FF1F0 File Offset: 0x001FD3F0
		private void __callBase_AddStatisticalData(StatisticalDataType typeId, int nums)
		{
			base.AddStatisticalData(typeId, nums);
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x001FF1FC File Offset: 0x001FD3FC
		private long __callBase_GetMissionCompletedProcess(Mission mission)
		{
			return base.GetMissionCompletedProcess(mission);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x001FF208 File Offset: 0x001FD408
		private void __callBase_OnLoginGameCallBack()
		{
			base.OnLoginGameCallBack();
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x001FF210 File Offset: 0x001FD410
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
					this.m_DeSerializeDSMissionNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_AddMissionByIdInt32_hotfix = (luaObj.RawGet("AddMissionById") as LuaFunction);
					this.m_CanUnlockMissionInLogicFromInitConfigDataMissionInfo_hotfix = (luaObj.RawGet("CanUnlockMissionInLogicFromInit") as LuaFunction);
					this.m_CanUnlockMissionInUIInterfaceMission_hotfix = (luaObj.RawGet("CanUnlockMissionInUIInterface") as LuaFunction);
					this.m_GetMissionRewardInt32_hotfix = (luaObj.RawGet("GetMissionReward") as LuaFunction);
					this.m_GetAllProcessingMissionList_hotfix = (luaObj.RawGet("GetAllProcessingMissionList") as LuaFunction);
					this.m_GetAllCompletedMissionList_hotfix = (luaObj.RawGet("GetAllCompletedMissionList") as LuaFunction);
					this.m_GetAllFinishedMissionList_hotfix = (luaObj.RawGet("GetAllFinishedMissionList") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x001FF408 File Offset: 0x001FD608
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MissionComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005581 RID: 21889
		[DoNotToLua]
		private MissionComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005582 RID: 21890
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005583 RID: 21891
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005584 RID: 21892
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005585 RID: 21893
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005586 RID: 21894
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005587 RID: 21895
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005588 RID: 21896
		private LuaFunction m_DeSerializeDSMissionNtf_hotfix;

		// Token: 0x04005589 RID: 21897
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400558A RID: 21898
		private LuaFunction m_AddMissionByIdInt32_hotfix;

		// Token: 0x0400558B RID: 21899
		private LuaFunction m_CanUnlockMissionInLogicFromInitConfigDataMissionInfo_hotfix;

		// Token: 0x0400558C RID: 21900
		private LuaFunction m_CanUnlockMissionInUIInterfaceMission_hotfix;

		// Token: 0x0400558D RID: 21901
		private LuaFunction m_GetMissionRewardInt32_hotfix;

		// Token: 0x0400558E RID: 21902
		private LuaFunction m_GetAllProcessingMissionList_hotfix;

		// Token: 0x0400558F RID: 21903
		private LuaFunction m_GetAllCompletedMissionList_hotfix;

		// Token: 0x04005590 RID: 21904
		private LuaFunction m_GetAllFinishedMissionList_hotfix;

		// Token: 0x020008CE RID: 2254
		public new class LuaExportHelper
		{
			// Token: 0x060073D1 RID: 29649 RVA: 0x001FF470 File Offset: 0x001FD670
			public LuaExportHelper(MissionComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060073D2 RID: 29650 RVA: 0x001FF480 File Offset: 0x001FD680
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060073D3 RID: 29651 RVA: 0x001FF490 File Offset: 0x001FD690
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060073D4 RID: 29652 RVA: 0x001FF4A0 File Offset: 0x001FD6A0
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060073D5 RID: 29653 RVA: 0x001FF4B0 File Offset: 0x001FD6B0
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060073D6 RID: 29654 RVA: 0x001FF4C0 File Offset: 0x001FD6C0
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060073D7 RID: 29655 RVA: 0x001FF4D0 File Offset: 0x001FD6D0
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060073D8 RID: 29656 RVA: 0x001FF4E0 File Offset: 0x001FD6E0
			public void __callBase_RemoveProcessingMissionById(int missionId)
			{
				this.m_owner.__callBase_RemoveProcessingMissionById(missionId);
			}

			// Token: 0x060073D9 RID: 29657 RVA: 0x001FF4F0 File Offset: 0x001FD6F0
			public void __callBase_InitProcessingMission(List<Mission> processingMissionList)
			{
				this.m_owner.__callBase_InitProcessingMission(processingMissionList);
			}

			// Token: 0x060073DA RID: 29658 RVA: 0x001FF500 File Offset: 0x001FD700
			public List<Mission> __callBase_GetProcessingMissionByMissionType(MissionType missionType)
			{
				return this.m_owner.__callBase_GetProcessingMissionByMissionType(missionType);
			}

			// Token: 0x060073DB RID: 29659 RVA: 0x001FF510 File Offset: 0x001FD710
			public void __callBase_InitExistMissions()
			{
				this.m_owner.__callBase_InitExistMissions();
			}

			// Token: 0x060073DC RID: 29660 RVA: 0x001FF520 File Offset: 0x001FD720
			public void __callBase_ResetEverydayMissions()
			{
				this.m_owner.__callBase_ResetEverydayMissions();
			}

			// Token: 0x060073DD RID: 29661 RVA: 0x001FF530 File Offset: 0x001FD730
			public void __callBase_InitMissionListByMissionPeriodType(MissionPeriodType missionPeriod)
			{
				this.m_owner.__callBase_InitMissionListByMissionPeriodType(missionPeriod);
			}

			// Token: 0x060073DE RID: 29662 RVA: 0x001FF540 File Offset: 0x001FD740
			public bool __callBase_CanUnlockMissionInLogicFromInit(ConfigDataMissionInfo missionInfo)
			{
				return this.m_owner.__callBase_CanUnlockMissionInLogicFromInit(missionInfo);
			}

			// Token: 0x060073DF RID: 29663 RVA: 0x001FF550 File Offset: 0x001FD750
			public void __callBase_OnDirectActivatedMissionLocked(ConfigDataMissionInfo missionConfig)
			{
				this.m_owner.__callBase_OnDirectActivatedMissionLocked(missionConfig);
			}

			// Token: 0x060073E0 RID: 29664 RVA: 0x001FF560 File Offset: 0x001FD760
			public bool __callBase_IsNoviceMission(Mission mission)
			{
				return this.m_owner.__callBase_IsNoviceMission(mission);
			}

			// Token: 0x060073E1 RID: 29665 RVA: 0x001FF570 File Offset: 0x001FD770
			public bool __callBase_IsNoviceMission(ConfigDataMissionInfo mission)
			{
				return this.m_owner.__callBase_IsNoviceMission(mission);
			}

			// Token: 0x060073E2 RID: 29666 RVA: 0x001FF580 File Offset: 0x001FD780
			public bool __callBase_IsNoviceMissionActivated(ConfigDataMissionInfo mission)
			{
				return this.m_owner.__callBase_IsNoviceMissionActivated(mission);
			}

			// Token: 0x060073E3 RID: 29667 RVA: 0x001FF590 File Offset: 0x001FD790
			public bool __callBase_IsNoviceMissionActivatedForRewarding(ConfigDataMissionInfo mission)
			{
				return this.m_owner.__callBase_IsNoviceMissionActivatedForRewarding(mission);
			}

			// Token: 0x060073E4 RID: 29668 RVA: 0x001FF5A0 File Offset: 0x001FD7A0
			public bool __callBase_IsNoviceMissionActivated(Mission mission)
			{
				return this.m_owner.__callBase_IsNoviceMissionActivated(mission);
			}

			// Token: 0x060073E5 RID: 29669 RVA: 0x001FF5B0 File Offset: 0x001FD7B0
			public bool __callBase_CanGetRewarding(Mission mission)
			{
				return this.m_owner.__callBase_CanGetRewarding(mission);
			}

			// Token: 0x060073E6 RID: 29670 RVA: 0x001FF5C0 File Offset: 0x001FD7C0
			public bool __callBase_CanUnlockMissionInLogic(ConfigDataMissionInfo missionConfigInfo)
			{
				return this.m_owner.__callBase_CanUnlockMissionInLogic(missionConfigInfo);
			}

			// Token: 0x060073E7 RID: 29671 RVA: 0x001FF5D0 File Offset: 0x001FD7D0
			public bool __callBase_CanUnlockMission(ConfigDataMissionInfo missionConfigInfo)
			{
				return this.m_owner.__callBase_CanUnlockMission(missionConfigInfo);
			}

			// Token: 0x060073E8 RID: 29672 RVA: 0x001FF5E0 File Offset: 0x001FD7E0
			public DirectlyActivatedMissionSatatus __callBase_CaculateDirectlyActivationMissionStatus(ConfigDataMissionInfo missionConfigInfo)
			{
				return this.m_owner.__callBase_CaculateDirectlyActivationMissionStatus(missionConfigInfo);
			}

			// Token: 0x060073E9 RID: 29673 RVA: 0x001FF5F0 File Offset: 0x001FD7F0
			public bool __callBase_AddMission(ConfigDataMissionInfo missionInfo)
			{
				return this.m_owner.__callBase_AddMission(missionInfo);
			}

			// Token: 0x060073EA RID: 29674 RVA: 0x001FF600 File Offset: 0x001FD800
			public void __callBase_OnAddProcessingDirectelyActivitedMission(Mission mission)
			{
				this.m_owner.__callBase_OnAddProcessingDirectelyActivitedMission(mission);
			}

			// Token: 0x060073EB RID: 29675 RVA: 0x001FF610 File Offset: 0x001FD810
			public Mission __callBase_GetProcessingMissionByMissionPeriod(MissionPeriodType missionPeriodType, int missionId)
			{
				return this.m_owner.__callBase_GetProcessingMissionByMissionPeriod(missionPeriodType, missionId);
			}

			// Token: 0x060073EC RID: 29676 RVA: 0x001FF620 File Offset: 0x001FD820
			public void __callBase_OnGetProcessingDirectActivationMissionFail(Mission mission)
			{
				this.m_owner.__callBase_OnGetProcessingDirectActivationMissionFail(mission);
			}

			// Token: 0x060073ED RID: 29677 RVA: 0x001FF630 File Offset: 0x001FD830
			public void __callBase_AddOneOffMission(Mission mission)
			{
				this.m_owner.__callBase_AddOneOffMission(mission);
			}

			// Token: 0x060073EE RID: 29678 RVA: 0x001FF640 File Offset: 0x001FD840
			public bool __callBase_IsMissionFinished(int missionId)
			{
				return this.m_owner.__callBase_IsMissionFinished(missionId);
			}

			// Token: 0x060073EF RID: 29679 RVA: 0x001FF650 File Offset: 0x001FD850
			public void __callBase_InitMissionsFromConfig(List<Mission> missions)
			{
				this.m_owner.__callBase_InitMissionsFromConfig(missions);
			}

			// Token: 0x060073F0 RID: 29680 RVA: 0x001FF660 File Offset: 0x001FD860
			public void __callBase_FinishMission(Mission mission)
			{
				this.m_owner.__callBase_FinishMission(mission);
			}

			// Token: 0x060073F1 RID: 29681 RVA: 0x001FF670 File Offset: 0x001FD870
			public List<Mission> __callBase_GetAllProcessingNoviceMissionList()
			{
				return this.m_owner.__callBase_GetAllProcessingNoviceMissionList();
			}

			// Token: 0x060073F2 RID: 29682 RVA: 0x001FF680 File Offset: 0x001FD880
			public List<Mission> __callBase_GetAllFinishedNoviceMissionList()
			{
				return this.m_owner.__callBase_GetAllFinishedNoviceMissionList();
			}

			// Token: 0x060073F3 RID: 29683 RVA: 0x001FF690 File Offset: 0x001FD890
			public void __callBase_AddMissionProcess(Mission mission, long process)
			{
				this.m_owner.__callBase_AddMissionProcess(mission, process);
			}

			// Token: 0x060073F4 RID: 29684 RVA: 0x001FF6A0 File Offset: 0x001FD8A0
			public int __callBase_GetMissionMaxProcess(Mission mission)
			{
				return this.m_owner.__callBase_GetMissionMaxProcess(mission);
			}

			// Token: 0x060073F5 RID: 29685 RVA: 0x001FF6B0 File Offset: 0x001FD8B0
			public bool __callBase_IsMissionProcessFinished(int missionId)
			{
				return this.m_owner.__callBase_IsMissionProcessFinished(missionId);
			}

			// Token: 0x060073F6 RID: 29686 RVA: 0x001FF6C0 File Offset: 0x001FD8C0
			public int __callBase_CanGainMissionReward(int missionId)
			{
				return this.m_owner.__callBase_CanGainMissionReward(missionId);
			}

			// Token: 0x060073F7 RID: 29687 RVA: 0x001FF6D0 File Offset: 0x001FD8D0
			public bool __callBase_IsCompleted(int missionId)
			{
				return this.m_owner.__callBase_IsCompleted(missionId);
			}

			// Token: 0x060073F8 RID: 29688 RVA: 0x001FF6E0 File Offset: 0x001FD8E0
			public void __callBase_SetStatisticalData(StatisticalDataType typeId, long nums)
			{
				this.m_owner.__callBase_SetStatisticalData(typeId, nums);
			}

			// Token: 0x060073F9 RID: 29689 RVA: 0x001FF6F0 File Offset: 0x001FD8F0
			public void __callBase_AddStatisticalData(StatisticalDataType typeId, int nums)
			{
				this.m_owner.__callBase_AddStatisticalData(typeId, nums);
			}

			// Token: 0x060073FA RID: 29690 RVA: 0x001FF700 File Offset: 0x001FD900
			public long __callBase_GetMissionCompletedProcess(Mission mission)
			{
				return this.m_owner.__callBase_GetMissionCompletedProcess(mission);
			}

			// Token: 0x060073FB RID: 29691 RVA: 0x001FF710 File Offset: 0x001FD910
			public void __callBase_OnLoginGameCallBack()
			{
				this.m_owner.__callBase_OnLoginGameCallBack();
			}

			// Token: 0x060073FC RID: 29692 RVA: 0x001FF720 File Offset: 0x001FD920
			public bool CanUnlockMissionInLogicFromInit(ConfigDataMissionInfo missionInfo)
			{
				return this.m_owner.CanUnlockMissionInLogicFromInit(missionInfo);
			}

			// Token: 0x060073FD RID: 29693 RVA: 0x001FF730 File Offset: 0x001FD930
			public bool CanUnlockMissionInUIInterface(Mission mission)
			{
				return this.m_owner.CanUnlockMissionInUIInterface(mission);
			}

			// Token: 0x04005591 RID: 21905
			private MissionComponent m_owner;
		}
	}
}
