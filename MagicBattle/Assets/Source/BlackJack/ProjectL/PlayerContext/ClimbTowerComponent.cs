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
	// Token: 0x0200089F RID: 2207
	[HotFix]
	public class ClimbTowerComponent : ClimbTowerComponentCommon
	{
		// Token: 0x06006E8B RID: 28299 RVA: 0x001EF470 File Offset: 0x001ED670
		public ClimbTowerComponent()
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

		// Token: 0x06006E8C RID: 28300 RVA: 0x001EF4D8 File Offset: 0x001ED6D8
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

		// Token: 0x06006E8D RID: 28301 RVA: 0x001EF554 File Offset: 0x001ED754
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

		// Token: 0x06006E8E RID: 28302 RVA: 0x001EF5BC File Offset: 0x001ED7BC
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
			return this.m_climbTowerDS.ClientVersion;
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x001EF634 File Offset: 0x001ED834
		public void DeSerialize(DSClimbTowerNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSClimbTowerNtf_hotfix != null)
			{
				this.m_DeSerializeDSClimbTowerNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_climbTowerDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_climbTowerDS.ClearInitedData();
			this.m_climbTowerDS.GlobalClimbTowerInfo = ClimbTower.FromPb(msg.ClimbTower);
			this.m_climbTowerDS.ClimbTower.Floor = msg.Floor;
			this.m_climbTowerDS.ClimbTower.HistoryFloorMax = msg.HistoryFloorMax;
			this.m_climbTowerDS.ClimbTower.NextFlushTime = this.m_climbTowerDS.GlobalClimbTowerInfo.ClimbNextWeekFlushTime;
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x001EF72C File Offset: 0x001ED92C
		public void SetClimbTower(ClimbTowerGetAck msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetClimbTowerClimbTowerGetAck_hotfix != null)
			{
				this.m_SetClimbTowerClimbTowerGetAck_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_climbTowerDS.ClearInitedData();
			this.m_climbTowerDS.GlobalClimbTowerInfo = ClimbTower.FromPb(msg.ClimbTower);
			this.m_climbTowerDS.ClimbTower.Floor = msg.Floor;
			this.m_climbTowerDS.ClimbTower.HistoryFloorMax = msg.HistoryFloorMax;
			this.m_climbTowerDS.ClimbTower.NextFlushTime = this.m_climbTowerDS.GlobalClimbTowerInfo.ClimbNextWeekFlushTime;
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x001EF80C File Offset: 0x001EDA0C
		public int FinishedClimbTowerLevel(int floorId, int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedClimbTowerLevelInt32Int32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedClimbTowerLevelInt32Int32BooleanList`1_hotfix.call(new object[]
				{
					this,
					floorId,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(floorId);
			if (configDataTowerFloorInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -5405;
			}
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = this.m_configDataLoader.GetConfigDataTowerLevelInfo(levelId);
			if (configDataTowerLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -5402;
			}
			if (isWin)
			{
				this.SetSuccessClimbTowerLevel(configDataTowerFloorInfo, configDataTowerLevelInfo, battleTreasures, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x001EF928 File Offset: 0x001EDB28
		public void SetSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, List<int> battleTreasures, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList`1Boolean_hotfix != null)
			{
				this.m_SetSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList`1Boolean_hotfix.call(new object[]
				{
					this,
					floorInfo,
					levelInfo,
					battleTreasures,
					isTeamBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int energyCost = 0;
			if (!isTeamBattle)
			{
				energyCost = floorInfo.EnergySuccess - floorInfo.EnergyFail;
			}
			base.SetCommonSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, energyCost);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = floorInfo.PlayerExp;
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x001EFA08 File Offset: 0x001EDC08
		public int RaidClimbTowerLevel(int reachFloorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidClimbTowerLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_RaidClimbTowerLevelInt32_hotfix.call(new object[]
				{
					this,
					reachFloorId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			int num = this.GetFinishedFloorId() + 1;
			for (int i = num; i <= reachFloorId; i++)
			{
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(i);
				base.SetRaidSuccessClimbTowerLevel(configDataTowerFloorInfo);
				battleReward.PlayerExp += configDataTowerFloorInfo.PlayerExp;
			}
			base.SetCompleteSuccessFloor(reachFloorId);
			return 0;
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x001EFAE0 File Offset: 0x001EDCE0
		public int GetFinishedFloorId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFinishedFloorId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFinishedFloorId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_climbTowerDS.ClimbTower.Floor;
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x001EFB5C File Offset: 0x001EDD5C
		public int GetHistoryMaxFloorId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHistoryMaxFloorId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHistoryMaxFloorId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_climbTowerDS.ClimbTower.HistoryFloorMax;
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x001EFBD8 File Offset: 0x001EDDD8
		public int GetClimbTowerFloorMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClimbTowerFloorMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetClimbTowerFloorMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.ClimbTowerFloorMax;
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x001EFC4C File Offset: 0x001EDE4C
		public int TryRaid(out int reachFloorId, out int costEnergy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryRaidInt32_Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent_TryRaid_Int32_Int32(this, this.m_TryRaidInt32_Int32__hotfix, out reachFloorId, out costEnergy);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			reachFloorId = 0;
			costEnergy = 0;
			if (base.IsNeedFlush())
			{
				return -5403;
			}
			if (base.IsReachTopTower())
			{
				return -5410;
			}
			int autoRaidClimbTowerMax = base.GetAutoRaidClimbTowerMax();
			int num = this.m_climbTowerDS.ClimbTower.Floor + 1;
			if (num > autoRaidClimbTowerMax)
			{
				return -5409;
			}
			ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(num);
			int num2 = base.CanAttackLevelByEnergyAndSoOn(configDataTowerFloorInfo, true);
			if (num2 != 0)
			{
				return num2;
			}
			int num3 = this.m_basicInfo.GetEnergy();
			for (int i = num; i <= autoRaidClimbTowerMax; i++)
			{
				ConfigDataTowerFloorInfo configDataTowerFloorInfo2 = this.m_configDataLoader.GetConfigDataTowerFloorInfo(i);
				if (num3 < configDataTowerFloorInfo2.EnergySuccess)
				{
					break;
				}
				num3 -= configDataTowerFloorInfo2.EnergySuccess;
				costEnergy += configDataTowerFloorInfo2.EnergySuccess;
				reachFloorId = i;
			}
			return 0;
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x001EFD78 File Offset: 0x001EDF78
		public DateTime GetNextFlushTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextFlushTime_hotfix != null)
			{
				return (DateTime)this.m_GetNextFlushTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_climbTowerDS.GlobalClimbTowerInfo.ClimbNextWeekFlushTime;
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06006E99 RID: 28313 RVA: 0x001EFDF4 File Offset: 0x001EDFF4
		// (set) Token: 0x06006E9A RID: 28314 RVA: 0x001EFE14 File Offset: 0x001EE014
		[DoNotToLua]
		public new ClimbTowerComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x001EFE20 File Offset: 0x001EE020
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x001EFE28 File Offset: 0x001EE028
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x001EFE30 File Offset: 0x001EE030
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x001EFE38 File Offset: 0x001EE038
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x001EFE40 File Offset: 0x001EE040
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x001EFE4C File Offset: 0x001EE04C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x001EFE54 File Offset: 0x001EE054
		private bool __callBase_IsNeedFlush()
		{
			return base.IsNeedFlush();
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x001EFE5C File Offset: 0x001EE05C
		private int __callBase_GetAutoRaidClimbTowerMax()
		{
			return base.GetAutoRaidClimbTowerMax();
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x001EFE64 File Offset: 0x001EE064
		private bool __callBase_IsReachTopTower()
		{
			return base.IsReachTopTower();
		}

		// Token: 0x06006EA4 RID: 28324 RVA: 0x001EFE6C File Offset: 0x001EE06C
		private ClimbTower __callBase_GetClimbTower()
		{
			return base.GetClimbTower();
		}

		// Token: 0x06006EA5 RID: 28325 RVA: 0x001EFE74 File Offset: 0x001EE074
		private void __callBase_SetCompleteSuccessFloor(int floorId)
		{
			base.SetCompleteSuccessFloor(floorId);
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x001EFE80 File Offset: 0x001EE080
		private GlobalClimbTowerInfo __callBase_GetGlobalClimbTowerInfo()
		{
			return base.GetGlobalClimbTowerInfo();
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x001EFE88 File Offset: 0x001EE088
		private int __callBase_AttackClimbTowerLevel(int floorId)
		{
			return base.AttackClimbTowerLevel(floorId);
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x001EFE94 File Offset: 0x001EE094
		private int __callBase_CanAttackClimbTowerLevel(int floorId)
		{
			return base.CanAttackClimbTowerLevel(floorId);
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x001EFEA0 File Offset: 0x001EE0A0
		private GlobalClimbTowerFloor __callBase_GetFloor(int floorId)
		{
			return base.GetFloor(floorId);
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x001EFEAC File Offset: 0x001EE0AC
		private GlobalClimbTowerInfo __callBase_NewClimbTower(int seed)
		{
			return base.NewClimbTower(seed);
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x001EFEB8 File Offset: 0x001EE0B8
		private void __callBase_SetCommonSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, List<int> battleTreasures, int energyCost)
		{
			base.SetCommonSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, energyCost);
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x001EFEC8 File Offset: 0x001EE0C8
		private int __callBase_CanRaidLevel(ConfigDataTowerFloorInfo floorInfo)
		{
			return base.CanRaidLevel(floorInfo);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x001EFED4 File Offset: 0x001EE0D4
		private void __callBase_SetRaidSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo)
		{
			base.SetRaidSuccessClimbTowerLevel(floorInfo);
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x001EFEE0 File Offset: 0x001EE0E0
		private int __callBase_CanAttackLevelByEnergyAndSoOn(ConfigDataTowerFloorInfo floorInfo, bool checkBagFull)
		{
			return base.CanAttackLevelByEnergyAndSoOn(floorInfo, checkBagFull);
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x001EFEEC File Offset: 0x001EE0EC
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
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_DeSerializeDSClimbTowerNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_SetClimbTowerClimbTowerGetAck_hotfix = (luaObj.RawGet("SetClimbTower") as LuaFunction);
					this.m_FinishedClimbTowerLevelInt32Int32BooleanList`1_hotfix = (luaObj.RawGet("FinishedClimbTowerLevel") as LuaFunction);
					this.m_SetSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList`1Boolean_hotfix = (luaObj.RawGet("SetSuccessClimbTowerLevel") as LuaFunction);
					this.m_RaidClimbTowerLevelInt32_hotfix = (luaObj.RawGet("RaidClimbTowerLevel") as LuaFunction);
					this.m_GetFinishedFloorId_hotfix = (luaObj.RawGet("GetFinishedFloorId") as LuaFunction);
					this.m_GetHistoryMaxFloorId_hotfix = (luaObj.RawGet("GetHistoryMaxFloorId") as LuaFunction);
					this.m_GetClimbTowerFloorMax_hotfix = (luaObj.RawGet("GetClimbTowerFloorMax") as LuaFunction);
					this.m_TryRaidInt32_Int32__hotfix = (luaObj.RawGet("TryRaid") as LuaFunction);
					this.m_GetNextFlushTime_hotfix = (luaObj.RawGet("GetNextFlushTime") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x001F00FC File Offset: 0x001EE2FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005439 RID: 21561
		[DoNotToLua]
		private ClimbTowerComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400543A RID: 21562
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400543B RID: 21563
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400543C RID: 21564
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400543D RID: 21565
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400543E RID: 21566
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400543F RID: 21567
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005440 RID: 21568
		private LuaFunction m_DeSerializeDSClimbTowerNtf_hotfix;

		// Token: 0x04005441 RID: 21569
		private LuaFunction m_SetClimbTowerClimbTowerGetAck_hotfix;

		// Token: 0x04005442 RID: 21570
		private LuaFunction m_FinishedClimbTowerLevelInt32Int32BooleanList;

		// Token: 0x04005443 RID: 21571
		private LuaFunction m_SetSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList;

		// Token: 0x04005444 RID: 21572
		private LuaFunction m_RaidClimbTowerLevelInt32_hotfix;

		// Token: 0x04005445 RID: 21573
		private LuaFunction m_GetFinishedFloorId_hotfix;

		// Token: 0x04005446 RID: 21574
		private LuaFunction m_GetHistoryMaxFloorId_hotfix;

		// Token: 0x04005447 RID: 21575
		private LuaFunction m_GetClimbTowerFloorMax_hotfix;

		// Token: 0x04005448 RID: 21576
		private LuaFunction m_TryRaidInt32_Int32__hotfix;

		// Token: 0x04005449 RID: 21577
		private LuaFunction m_GetNextFlushTime_hotfix;

		// Token: 0x020008A0 RID: 2208
		public new class LuaExportHelper
		{
			// Token: 0x06006EB1 RID: 28337 RVA: 0x001F0164 File Offset: 0x001EE364
			public LuaExportHelper(ClimbTowerComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006EB2 RID: 28338 RVA: 0x001F0174 File Offset: 0x001EE374
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006EB3 RID: 28339 RVA: 0x001F0184 File Offset: 0x001EE384
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006EB4 RID: 28340 RVA: 0x001F0194 File Offset: 0x001EE394
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006EB5 RID: 28341 RVA: 0x001F01A4 File Offset: 0x001EE3A4
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006EB6 RID: 28342 RVA: 0x001F01B4 File Offset: 0x001EE3B4
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006EB7 RID: 28343 RVA: 0x001F01C4 File Offset: 0x001EE3C4
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006EB8 RID: 28344 RVA: 0x001F01D4 File Offset: 0x001EE3D4
			public bool __callBase_IsNeedFlush()
			{
				return this.m_owner.__callBase_IsNeedFlush();
			}

			// Token: 0x06006EB9 RID: 28345 RVA: 0x001F01E4 File Offset: 0x001EE3E4
			public int __callBase_GetAutoRaidClimbTowerMax()
			{
				return this.m_owner.__callBase_GetAutoRaidClimbTowerMax();
			}

			// Token: 0x06006EBA RID: 28346 RVA: 0x001F01F4 File Offset: 0x001EE3F4
			public bool __callBase_IsReachTopTower()
			{
				return this.m_owner.__callBase_IsReachTopTower();
			}

			// Token: 0x06006EBB RID: 28347 RVA: 0x001F0204 File Offset: 0x001EE404
			public ClimbTower __callBase_GetClimbTower()
			{
				return this.m_owner.__callBase_GetClimbTower();
			}

			// Token: 0x06006EBC RID: 28348 RVA: 0x001F0214 File Offset: 0x001EE414
			public void __callBase_SetCompleteSuccessFloor(int floorId)
			{
				this.m_owner.__callBase_SetCompleteSuccessFloor(floorId);
			}

			// Token: 0x06006EBD RID: 28349 RVA: 0x001F0224 File Offset: 0x001EE424
			public GlobalClimbTowerInfo __callBase_GetGlobalClimbTowerInfo()
			{
				return this.m_owner.__callBase_GetGlobalClimbTowerInfo();
			}

			// Token: 0x06006EBE RID: 28350 RVA: 0x001F0234 File Offset: 0x001EE434
			public int __callBase_AttackClimbTowerLevel(int floorId)
			{
				return this.m_owner.__callBase_AttackClimbTowerLevel(floorId);
			}

			// Token: 0x06006EBF RID: 28351 RVA: 0x001F0244 File Offset: 0x001EE444
			public int __callBase_CanAttackClimbTowerLevel(int floorId)
			{
				return this.m_owner.__callBase_CanAttackClimbTowerLevel(floorId);
			}

			// Token: 0x06006EC0 RID: 28352 RVA: 0x001F0254 File Offset: 0x001EE454
			public GlobalClimbTowerFloor __callBase_GetFloor(int floorId)
			{
				return this.m_owner.__callBase_GetFloor(floorId);
			}

			// Token: 0x06006EC1 RID: 28353 RVA: 0x001F0264 File Offset: 0x001EE464
			public GlobalClimbTowerInfo __callBase_NewClimbTower(int seed)
			{
				return this.m_owner.__callBase_NewClimbTower(seed);
			}

			// Token: 0x06006EC2 RID: 28354 RVA: 0x001F0274 File Offset: 0x001EE474
			public void __callBase_SetCommonSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, List<int> battleTreasures, int energyCost)
			{
				this.m_owner.__callBase_SetCommonSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, energyCost);
			}

			// Token: 0x06006EC3 RID: 28355 RVA: 0x001F0288 File Offset: 0x001EE488
			public int __callBase_CanRaidLevel(ConfigDataTowerFloorInfo floorInfo)
			{
				return this.m_owner.__callBase_CanRaidLevel(floorInfo);
			}

			// Token: 0x06006EC4 RID: 28356 RVA: 0x001F0298 File Offset: 0x001EE498
			public void __callBase_SetRaidSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo)
			{
				this.m_owner.__callBase_SetRaidSuccessClimbTowerLevel(floorInfo);
			}

			// Token: 0x06006EC5 RID: 28357 RVA: 0x001F02A8 File Offset: 0x001EE4A8
			public int __callBase_CanAttackLevelByEnergyAndSoOn(ConfigDataTowerFloorInfo floorInfo, bool checkBagFull)
			{
				return this.m_owner.__callBase_CanAttackLevelByEnergyAndSoOn(floorInfo, checkBagFull);
			}

			// Token: 0x0400544A RID: 21578
			private ClimbTowerComponent m_owner;
		}
	}
}
