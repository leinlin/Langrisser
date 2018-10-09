using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000886 RID: 2182
	[HotFix]
	public class ArenaComponent : ArenaComponentCommon
	{
		// Token: 0x06006C1D RID: 27677 RVA: 0x001E4514 File Offset: 0x001E2714
		public ArenaComponent()
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

		// Token: 0x06006C1E RID: 27678 RVA: 0x001E457C File Offset: 0x001E277C
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

		// Token: 0x06006C1F RID: 27679 RVA: 0x001E45F8 File Offset: 0x001E27F8
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

		// Token: 0x06006C20 RID: 27680 RVA: 0x001E4660 File Offset: 0x001E2860
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

		// Token: 0x06006C21 RID: 27681 RVA: 0x001E46C8 File Offset: 0x001E28C8
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

		// Token: 0x06006C22 RID: 27682 RVA: 0x001E4740 File Offset: 0x001E2940
		public DateTime GetArenaTicketNextGivenTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaTicketNextGivenTime_hotfix != null)
			{
				return (DateTime)this.m_GetArenaTicketNextGivenTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!base.IsArenaOpen() || this.m_basicInfo.IsArenaTicketsFull())
			{
				return DateTime.MinValue;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return TimeCaculate.GetInitialTimeNexPeriodDay(currentTime, 1);
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x001E47E0 File Offset: 0x001E29E0
		public void DeSerialize(DSArenaNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSArenaNtf_hotfix != null)
			{
				this.m_DeSerializeDSArenaNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitArenaPlayInfo(ntf.ArenaPlayerData);
			this.m_arenaDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x001E4878 File Offset: 0x001E2A78
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
			return this.m_arenaDS.ClientVersion;
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x001E48F0 File Offset: 0x001E2AF0
		public int AddArenaBattleReportPlayBackData(ProArenaBattleReport pbArenaBattleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddArenaBattleReportPlayBackDataProArenaBattleReport_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddArenaBattleReportPlayBackDataProArenaBattleReport_hotfix.call(new object[]
				{
					this,
					pbArenaBattleReport
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaBattleReport arenaBattleReport = base.m_arenaBattleReportDS.FindArenaBattleReportByInstanceId(pbArenaBattleReport.InstanceId);
			if (arenaBattleReport == null)
			{
				return -2007;
			}
			arenaBattleReport.BattleType = (BattleType)pbArenaBattleReport.BattleType;
			arenaBattleReport.BattleId = pbArenaBattleReport.BattleId;
			arenaBattleReport.RandomSeed = pbArenaBattleReport.RandomSeed;
			arenaBattleReport.ArenaDefenderRuleId = pbArenaBattleReport.ArenaDefenderRuleId;
			foreach (ProBattleCommand pbBattleCommand in pbArenaBattleReport.Commands)
			{
				arenaBattleReport.Commands.Add(BattleCommand.PBBattleCommandToBattleCommand(pbBattleCommand));
			}
			foreach (ProBattleHero pbBattleHero in pbArenaBattleReport.AttackerHeroes)
			{
				arenaBattleReport.AttackerHeroes.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero));
			}
			foreach (ProBattleHero pbBattleHero2 in pbArenaBattleReport.DefenderHeroes)
			{
				arenaBattleReport.DefenderHeroes.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero2));
			}
			foreach (ProTrainingTech tech in pbArenaBattleReport.AttackerTechs)
			{
				TrainingTech trainingTech = TrainingTech.FromDataSection(tech);
				trainingTech.ConfigDataLoader = this.m_configDataLoader;
				arenaBattleReport.AttackerTechs.Add(trainingTech);
			}
			foreach (ProTrainingTech tech2 in pbArenaBattleReport.DefenderTechs)
			{
				TrainingTech trainingTech2 = TrainingTech.FromDataSection(tech2);
				trainingTech2.ConfigDataLoader = this.m_configDataLoader;
				arenaBattleReport.DefenderTechs.Add(trainingTech2);
			}
			return 0;
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x001E4B94 File Offset: 0x001E2D94
		public void StartArenaBattle(ProArenaDefensiveBattleInfo pbBattleInfo, bool autoBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleProArenaDefensiveBattleInfoBoolean_hotfix != null)
			{
				this.m_StartArenaBattleProArenaDefensiveBattleInfoBoolean_hotfix.call(new object[]
				{
					this,
					pbBattleInfo,
					autoBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = ArenaOpponentDefensiveBattleInfo.PBDefensiveBattleInfoToDefensiveBattleInfo(pbBattleInfo);
			foreach (TrainingTech trainingTech in arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.Techs)
			{
				trainingTech.ConfigDataLoader = this.m_configDataLoader;
			}
			arenaOpponentDefensiveBattleInfo.Status = ArenaBattleReportStatus.Attack;
			this.m_arenaDS.SetAttackedOpponent(autoBattle);
			this.OnStartArenaBattle(arenaOpponentDefensiveBattleInfo);
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x001E4C90 File Offset: 0x001E2E90
		public void ReconnectArenaBattle(ProArenaDefensiveBattleInfo pbBattleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReconnectArenaBattleProArenaDefensiveBattleInfo_hotfix != null)
			{
				this.m_ReconnectArenaBattleProArenaDefensiveBattleInfo_hotfix.call(new object[]
				{
					this,
					pbBattleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = ArenaOpponentDefensiveBattleInfo.PBDefensiveBattleInfoToDefensiveBattleInfo(pbBattleInfo);
			foreach (TrainingTech trainingTech in arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.Techs)
			{
				trainingTech.ConfigDataLoader = this.m_configDataLoader;
			}
			this.m_arenaDS.SetArenaDefensiveBattleInfo(arenaOpponentDefensiveBattleInfo);
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x001E4D6C File Offset: 0x001E2F6C
		public void RevengeOpponent(ulong battleReportInstanceId, bool autoBattle, ProArenaDefensiveBattleInfo pbBattleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RevengeOpponentUInt64BooleanProArenaDefensiveBattleInfo_hotfix != null)
			{
				this.m_RevengeOpponentUInt64BooleanProArenaDefensiveBattleInfo_hotfix.call(new object[]
				{
					this,
					battleReportInstanceId,
					autoBattle,
					pbBattleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = ArenaOpponentDefensiveBattleInfo.PBDefensiveBattleInfoToDefensiveBattleInfo(pbBattleInfo);
			foreach (TrainingTech trainingTech in arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.Techs)
			{
				trainingTech.ConfigDataLoader = this.m_configDataLoader;
			}
			ArenaBattleReport battleReportRevenged = base.m_arenaBattleReportDS.FindArenaBattleReportByInstanceId(battleReportInstanceId);
			base.SetBattleReportRevenged(battleReportRevenged);
			base.ArenaPlayerInfo.IsAutoBattle = autoBattle;
			this.OnStartArenaBattle(arenaOpponentDefensiveBattleInfo);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x001E4E84 File Offset: 0x001E3084
		private void OnStartArenaBattle(ArenaOpponentDefensiveBattleInfo battleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartArenaBattleArenaOpponentDefensiveBattleInfo_hotfix != null)
			{
				this.m_OnStartArenaBattleArenaOpponentDefensiveBattleInfo_hotfix.call(new object[]
				{
					this,
					battleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDS.SetArenaDefensiveBattleInfo(battleInfo);
			this.m_basicInfo.AddArenaTickets(-this.m_configDataLoader.ConfigableConstId_ArenaOneTimeAttackUseTicketsNums, false, GameFunctionType.GameFunctionType_None, null);
			this.m_battle.SetArenaBattleInfo(battleInfo.BattleTeamSnapshot.BattleId);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x001E4F34 File Offset: 0x001E3134
		public void SetDefensiveTeam(ProArenaPlayerDefensiveTeam pbDefensiveTeamInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDefensiveTeamProArenaPlayerDefensiveTeam_hotfix != null)
			{
				this.m_SetDefensiveTeamProArenaPlayerDefensiveTeam_hotfix.call(new object[]
				{
					this,
					pbDefensiveTeamInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaPlayerDefensiveTeam defensiveTeam = ArenaPlayerDefensiveTeam.PBArenaDefensiveTeamToArenaDefensiveTeam(pbDefensiveTeamInfo);
			this.m_arenaDS.SetDefensiveTeam(defensiveTeam);
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x001E4FB8 File Offset: 0x001E31B8
		public void FinsihArenaBattle(bool isWin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinsihArenaBattleBoolean_hotfix != null)
			{
				this.m_FinsihArenaBattleBoolean_hotfix.call(new object[]
				{
					this,
					isWin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaOpponentDefensiveBattleInfo arenaDefensiveBattleInfo = base.GetArenaDefensiveBattleInfo();
			if (arenaDefensiveBattleInfo == null)
			{
				Debug.LogError("FinsihArenaBattle, defensivBattleInfo is null");
				return;
			}
			if (isWin)
			{
				base.SetSuccessArenaBattle(arenaDefensiveBattleInfo.ArenaOpponentPointZoneId);
				BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
				battleReward.PlayerExp = this.m_configDataLoader.ConfigableConstId_ArenaAddPlayerExp;
				battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(this.m_configDataLoader.ConfigableConstId_ArenaAddHeroExp);
			}
			base.OnFinishedArenaBattle(arenaDefensiveBattleInfo, isWin);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x001E5098 File Offset: 0x001E3298
		public void FlushOpponents(List<ProArenaOpponent> pbOpponents, long nextFlushTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushOpponentsList`1Int64_hotfix != null)
			{
				this.m_FlushOpponentsList`1Int64_hotfix.call(new object[]
				{
					this,
					pbOpponents,
					nextFlushTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ArenaOpponent> list = new List<ArenaOpponent>();
			foreach (ProArenaOpponent pbArenaOpponent in pbOpponents)
			{
				list.Add(ArenaOpponent.PBArenaOpponentToArenaOpponent(pbArenaOpponent));
			}
			this.m_arenaDS.SetOpponents(list);
			this.m_arenaDS.ArenaPlayerInfo.NextFlushOpponentTime = nextFlushTime;
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x001E518C File Offset: 0x001E338C
		public void InitArenaPlayInfo(ProArenaPlayerInfo pbArenaPlayerInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaPlayInfoProArenaPlayerInfo_hotfix != null)
			{
				this.m_InitArenaPlayInfoProArenaPlayerInfo_hotfix.call(new object[]
				{
					this,
					pbArenaPlayerInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDS.ClearInitedData();
			ArenaPlayerInfo info = ArenaPlayerInfo.PBArenaPlayerInfoToArenaPlayerInfo(pbArenaPlayerInfo);
			base.InitArenaPlayerInfo(info);
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x001E5218 File Offset: 0x001E3418
		public void InitBattleReportBasicInfo(List<ProArenaBattleReport> pbArenaBattleReports, int nextBattleReportIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleReportBasicInfoList`1Int32_hotfix != null)
			{
				this.m_InitBattleReportBasicInfoList`1Int32_hotfix.call(new object[]
				{
					this,
					pbArenaBattleReports,
					nextBattleReportIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.m_arenaBattleReportDS.ClearInitedData();
			foreach (ProArenaBattleReport pbArenaBattleReport in pbArenaBattleReports)
			{
				base.m_arenaBattleReportDS.InitArenaBattleReport(ArenaBattleReport.PBArenaBattleReportToArenaBattleReport(pbArenaBattleReport, false));
			}
			base.m_arenaBattleReportDS.NextBattleReportIndex = (byte)nextBattleReportIndex;
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x001E5308 File Offset: 0x001E3508
		public void GainVictoryPointsReward(int victoryPointsRewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainVictoryPointsRewardInt32_hotfix != null)
			{
				this.m_GainVictoryPointsRewardInt32_hotfix.call(new object[]
				{
					this,
					victoryPointsRewardIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.AddReceivedVictoryPointsRewardIndex(victoryPointsRewardIndex);
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x001E5380 File Offset: 0x001E3580
		public ArenaPlayerInfo GetArenaPlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaPlayerInfo_hotfix != null)
			{
				return (ArenaPlayerInfo)this.m_GetArenaPlayerInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_arenaDS.ArenaPlayerInfo;
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x001E53F8 File Offset: 0x001E35F8
		public ArenaBattleReport GetArenaBattleReport(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaBattleReportUInt64_hotfix != null)
			{
				return (ArenaBattleReport)this.m_GetArenaBattleReportUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.m_arenaBattleReportDS.FindArenaBattleReportByInstanceId(instanceId);
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06006C32 RID: 27698 RVA: 0x001E5480 File Offset: 0x001E3680
		// (set) Token: 0x06006C33 RID: 27699 RVA: 0x001E54A0 File Offset: 0x001E36A0
		[DoNotToLua]
		public new ArenaComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x001E54AC File Offset: 0x001E36AC
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x001E54B4 File Offset: 0x001E36B4
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x001E54BC File Offset: 0x001E36BC
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x001E54C4 File Offset: 0x001E36C4
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x001E54CC File Offset: 0x001E36CC
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x001E54D8 File Offset: 0x001E36D8
		private void __callBase_OnBattleTimeOut()
		{
			base.OnBattleTimeOut();
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x001E54E0 File Offset: 0x001E36E0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x001E54E8 File Offset: 0x001E36E8
		private void __callBase_OnFinishedArenaBattle(ArenaOpponentDefensiveBattleInfo defensivBattleInfo, bool isWin)
		{
			base.OnFinishedArenaBattle(defensivBattleInfo, isWin);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x001E54F4 File Offset: 0x001E36F4
		private void __callBase_ResetThisWeekBattleInfo()
		{
			base.ResetThisWeekBattleInfo();
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x001E54FC File Offset: 0x001E36FC
		private void __callBase_InitArenaPlayerInfo(ArenaPlayerInfo info)
		{
			base.InitArenaPlayerInfo(info);
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x001E5508 File Offset: 0x001E3708
		private void __callBase_AddReceivedVictoryPointsRewardIndex(int victoryPointsIndex)
		{
			base.AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x001E5514 File Offset: 0x001E3714
		private void __callBase_OnFlushVictoryPointsEvent()
		{
			base.OnFlushVictoryPointsEvent();
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x001E551C File Offset: 0x001E371C
		private void __callBase_OnArenaGiveTicketsEvent()
		{
			base.OnArenaGiveTicketsEvent();
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x001E5524 File Offset: 0x001E3724
		private ArenaOpponentDefensiveBattleInfo __callBase_GetArenaDefensiveBattleInfo()
		{
			return base.GetArenaDefensiveBattleInfo();
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x001E552C File Offset: 0x001E372C
		private void __callBase_SetSuccessArenaBattle(int arenaOpponentPointZoneId)
		{
			base.SetSuccessArenaBattle(arenaOpponentPointZoneId);
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x001E5538 File Offset: 0x001E3738
		private void __callBase_AddArenaBattleReport(ArenaBattleReport arenaBattleReport)
		{
			base.AddArenaBattleReport(arenaBattleReport);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x001E5544 File Offset: 0x001E3744
		private void __callBase_SetArenaLevelIdAndPoints(int arenaLevelId, ushort arenaPoints)
		{
			base.SetArenaLevelIdAndPoints(arenaLevelId, arenaPoints);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x001E5550 File Offset: 0x001E3750
		private int __callBase_CanGetVictoryPointsReward(int victoryPointsRewardIndex)
		{
			return base.CanGetVictoryPointsReward(victoryPointsRewardIndex);
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x001E555C File Offset: 0x001E375C
		private int __callBase_CanViewOpponent(int index)
		{
			return base.CanViewOpponent(index);
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x001E5568 File Offset: 0x001E3768
		private int __callBase_CanAttackOpponent()
		{
			return base.CanAttackOpponent();
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x001E5570 File Offset: 0x001E3770
		private int __callBase_CanAttackOpponentByClient()
		{
			return base.CanAttackOpponentByClient();
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x001E5578 File Offset: 0x001E3778
		private int __callBase_CanRevengeOpponent(ulong battleReportInstanceId)
		{
			return base.CanRevengeOpponent(battleReportInstanceId);
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x001E5584 File Offset: 0x001E3784
		private void __callBase_SetBattleReportRevenged(ArenaBattleReport battleReport)
		{
			base.SetBattleReportRevenged(battleReport);
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x001E5590 File Offset: 0x001E3790
		private int __callBase_CanFlushOpponents()
		{
			return base.CanFlushOpponents();
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x001E5598 File Offset: 0x001E3798
		private bool __callBase_IsInSettleCacheTime()
		{
			return base.IsInSettleCacheTime();
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x001E55A0 File Offset: 0x001E37A0
		private bool __callBase_IsInRealWeekSettleTime()
		{
			return base.IsInRealWeekSettleTime();
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x001E55A8 File Offset: 0x001E37A8
		private bool __callBase_IsArenaOpen()
		{
			return base.IsArenaOpen();
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x001E55B0 File Offset: 0x001E37B0
		private bool __callBase_IsEmptyArenaPlayerInfo()
		{
			return base.IsEmptyArenaPlayerInfo();
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x001E55B8 File Offset: 0x001E37B8
		private bool __callBase_IsArenaInited()
		{
			return base.IsArenaInited();
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x001E55C0 File Offset: 0x001E37C0
		private bool __callBase_IsVictoryPointsRewardGot(int victoryPointsRewardIndex)
		{
			return base.IsVictoryPointsRewardGot(victoryPointsRewardIndex);
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x001E55CC File Offset: 0x001E37CC
		private int __callBase_AttackOpponentFighting()
		{
			return base.AttackOpponentFighting();
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x001E55D4 File Offset: 0x001E37D4
		private void __callBase_ArenaBattleFinish(GameFunctionStatus status)
		{
			base.ArenaBattleFinish(status);
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x001E55E0 File Offset: 0x001E37E0
		private void __callBase_SetUpFirstDefensiveTeam()
		{
			base.SetUpFirstDefensiveTeam();
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x001E55E8 File Offset: 0x001E37E8
		private void __callBase_SetMineRank(int rank)
		{
			base.SetMineRank(rank);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x001E55F4 File Offset: 0x001E37F4
		private int __callBase_GetMineRank()
		{
			return base.GetMineRank();
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x001E55FC File Offset: 0x001E37FC
		private List<ArenaBattleReport> __callBase_GetAllArenaBattleReports()
		{
			return base.GetAllArenaBattleReports();
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x001E5604 File Offset: 0x001E3804
		private void __callBase_ArenaConsecutiveSuccess(int consecutiveVictoryNums)
		{
			base.ArenaConsecutiveSuccess(consecutiveVictoryNums);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x001E5610 File Offset: 0x001E3810
		private int __callBase_CanGetArenaTopRankPlayers()
		{
			return base.CanGetArenaTopRankPlayers();
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x001E5618 File Offset: 0x001E3818
		private int __callBase_CanGetArenaPlayerInfo()
		{
			return base.CanGetArenaPlayerInfo();
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x001E5620 File Offset: 0x001E3820
		private int __callBase_CanReconnectArenaBattle()
		{
			return base.CanReconnectArenaBattle();
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x001E5628 File Offset: 0x001E3828
		private int __callBase_ReconnectArenaBattle()
		{
			return base.ReconnectArenaBattle();
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x001E5630 File Offset: 0x001E3830
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
					this.m_GetArenaTicketNextGivenTime_hotfix = (luaObj.RawGet("GetArenaTicketNextGivenTime") as LuaFunction);
					this.m_DeSerializeDSArenaNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_AddArenaBattleReportPlayBackDataProArenaBattleReport_hotfix = (luaObj.RawGet("AddArenaBattleReportPlayBackData") as LuaFunction);
					this.m_StartArenaBattleProArenaDefensiveBattleInfoBoolean_hotfix = (luaObj.RawGet("StartArenaBattle") as LuaFunction);
					this.m_ReconnectArenaBattleProArenaDefensiveBattleInfo_hotfix = (luaObj.RawGet("ReconnectArenaBattle") as LuaFunction);
					this.m_RevengeOpponentUInt64BooleanProArenaDefensiveBattleInfo_hotfix = (luaObj.RawGet("RevengeOpponent") as LuaFunction);
					this.m_OnStartArenaBattleArenaOpponentDefensiveBattleInfo_hotfix = (luaObj.RawGet("OnStartArenaBattle") as LuaFunction);
					this.m_SetDefensiveTeamProArenaPlayerDefensiveTeam_hotfix = (luaObj.RawGet("SetDefensiveTeam") as LuaFunction);
					this.m_FinsihArenaBattleBoolean_hotfix = (luaObj.RawGet("FinsihArenaBattle") as LuaFunction);
					this.m_FlushOpponentsList`1Int64_hotfix = (luaObj.RawGet("FlushOpponents") as LuaFunction);
					this.m_InitArenaPlayInfoProArenaPlayerInfo_hotfix = (luaObj.RawGet("InitArenaPlayInfo") as LuaFunction);
					this.m_InitBattleReportBasicInfoList`1Int32_hotfix = (luaObj.RawGet("InitBattleReportBasicInfo") as LuaFunction);
					this.m_GainVictoryPointsRewardInt32_hotfix = (luaObj.RawGet("GainVictoryPointsReward") as LuaFunction);
					this.m_GetArenaPlayerInfo_hotfix = (luaObj.RawGet("GetArenaPlayerInfo") as LuaFunction);
					this.m_GetArenaBattleReportUInt64_hotfix = (luaObj.RawGet("GetArenaBattleReport") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x001E58F0 File Offset: 0x001E3AF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400530F RID: 21263
		[DoNotToLua]
		private ArenaComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005310 RID: 21264
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005311 RID: 21265
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005312 RID: 21266
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005313 RID: 21267
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005314 RID: 21268
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005315 RID: 21269
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005316 RID: 21270
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04005317 RID: 21271
		private LuaFunction m_GetArenaTicketNextGivenTime_hotfix;

		// Token: 0x04005318 RID: 21272
		private LuaFunction m_DeSerializeDSArenaNtf_hotfix;

		// Token: 0x04005319 RID: 21273
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400531A RID: 21274
		private LuaFunction m_AddArenaBattleReportPlayBackDataProArenaBattleReport_hotfix;

		// Token: 0x0400531B RID: 21275
		private LuaFunction m_StartArenaBattleProArenaDefensiveBattleInfoBoolean_hotfix;

		// Token: 0x0400531C RID: 21276
		private LuaFunction m_ReconnectArenaBattleProArenaDefensiveBattleInfo_hotfix;

		// Token: 0x0400531D RID: 21277
		private LuaFunction m_RevengeOpponentUInt64BooleanProArenaDefensiveBattleInfo_hotfix;

		// Token: 0x0400531E RID: 21278
		private LuaFunction m_OnStartArenaBattleArenaOpponentDefensiveBattleInfo_hotfix;

		// Token: 0x0400531F RID: 21279
		private LuaFunction m_SetDefensiveTeamProArenaPlayerDefensiveTeam_hotfix;

		// Token: 0x04005320 RID: 21280
		private LuaFunction m_FinsihArenaBattleBoolean_hotfix;

		// Token: 0x04005321 RID: 21281
		private LuaFunction m_FlushOpponentsList;

		// Token: 0x04005322 RID: 21282
		private LuaFunction m_InitArenaPlayInfoProArenaPlayerInfo_hotfix;

		// Token: 0x04005323 RID: 21283
		private LuaFunction m_InitBattleReportBasicInfoList;

		// Token: 0x04005324 RID: 21284
		private LuaFunction m_GainVictoryPointsRewardInt32_hotfix;

		// Token: 0x04005325 RID: 21285
		private LuaFunction m_GetArenaPlayerInfo_hotfix;

		// Token: 0x04005326 RID: 21286
		private LuaFunction m_GetArenaBattleReportUInt64_hotfix;

		// Token: 0x02000887 RID: 2183
		public new class LuaExportHelper
		{
			// Token: 0x06006C5F RID: 27743 RVA: 0x001E5958 File Offset: 0x001E3B58
			public LuaExportHelper(ArenaComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006C60 RID: 27744 RVA: 0x001E5968 File Offset: 0x001E3B68
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006C61 RID: 27745 RVA: 0x001E5978 File Offset: 0x001E3B78
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006C62 RID: 27746 RVA: 0x001E5988 File Offset: 0x001E3B88
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006C63 RID: 27747 RVA: 0x001E5998 File Offset: 0x001E3B98
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006C64 RID: 27748 RVA: 0x001E59A8 File Offset: 0x001E3BA8
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006C65 RID: 27749 RVA: 0x001E59B8 File Offset: 0x001E3BB8
			public void __callBase_OnBattleTimeOut()
			{
				this.m_owner.__callBase_OnBattleTimeOut();
			}

			// Token: 0x06006C66 RID: 27750 RVA: 0x001E59C8 File Offset: 0x001E3BC8
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006C67 RID: 27751 RVA: 0x001E59D8 File Offset: 0x001E3BD8
			public void __callBase_OnFinishedArenaBattle(ArenaOpponentDefensiveBattleInfo defensivBattleInfo, bool isWin)
			{
				this.m_owner.__callBase_OnFinishedArenaBattle(defensivBattleInfo, isWin);
			}

			// Token: 0x06006C68 RID: 27752 RVA: 0x001E59E8 File Offset: 0x001E3BE8
			public void __callBase_ResetThisWeekBattleInfo()
			{
				this.m_owner.__callBase_ResetThisWeekBattleInfo();
			}

			// Token: 0x06006C69 RID: 27753 RVA: 0x001E59F8 File Offset: 0x001E3BF8
			public void __callBase_InitArenaPlayerInfo(ArenaPlayerInfo info)
			{
				this.m_owner.__callBase_InitArenaPlayerInfo(info);
			}

			// Token: 0x06006C6A RID: 27754 RVA: 0x001E5A08 File Offset: 0x001E3C08
			public void __callBase_AddReceivedVictoryPointsRewardIndex(int victoryPointsIndex)
			{
				this.m_owner.__callBase_AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
			}

			// Token: 0x06006C6B RID: 27755 RVA: 0x001E5A18 File Offset: 0x001E3C18
			public void __callBase_OnFlushVictoryPointsEvent()
			{
				this.m_owner.__callBase_OnFlushVictoryPointsEvent();
			}

			// Token: 0x06006C6C RID: 27756 RVA: 0x001E5A28 File Offset: 0x001E3C28
			public void __callBase_OnArenaGiveTicketsEvent()
			{
				this.m_owner.__callBase_OnArenaGiveTicketsEvent();
			}

			// Token: 0x06006C6D RID: 27757 RVA: 0x001E5A38 File Offset: 0x001E3C38
			public ArenaOpponentDefensiveBattleInfo __callBase_GetArenaDefensiveBattleInfo()
			{
				return this.m_owner.__callBase_GetArenaDefensiveBattleInfo();
			}

			// Token: 0x06006C6E RID: 27758 RVA: 0x001E5A48 File Offset: 0x001E3C48
			public void __callBase_SetSuccessArenaBattle(int arenaOpponentPointZoneId)
			{
				this.m_owner.__callBase_SetSuccessArenaBattle(arenaOpponentPointZoneId);
			}

			// Token: 0x06006C6F RID: 27759 RVA: 0x001E5A58 File Offset: 0x001E3C58
			public void __callBase_AddArenaBattleReport(ArenaBattleReport arenaBattleReport)
			{
				this.m_owner.__callBase_AddArenaBattleReport(arenaBattleReport);
			}

			// Token: 0x06006C70 RID: 27760 RVA: 0x001E5A68 File Offset: 0x001E3C68
			public void __callBase_SetArenaLevelIdAndPoints(int arenaLevelId, ushort arenaPoints)
			{
				this.m_owner.__callBase_SetArenaLevelIdAndPoints(arenaLevelId, arenaPoints);
			}

			// Token: 0x06006C71 RID: 27761 RVA: 0x001E5A78 File Offset: 0x001E3C78
			public int __callBase_CanGetVictoryPointsReward(int victoryPointsRewardIndex)
			{
				return this.m_owner.__callBase_CanGetVictoryPointsReward(victoryPointsRewardIndex);
			}

			// Token: 0x06006C72 RID: 27762 RVA: 0x001E5A88 File Offset: 0x001E3C88
			public int __callBase_CanViewOpponent(int index)
			{
				return this.m_owner.__callBase_CanViewOpponent(index);
			}

			// Token: 0x06006C73 RID: 27763 RVA: 0x001E5A98 File Offset: 0x001E3C98
			public int __callBase_CanAttackOpponent()
			{
				return this.m_owner.__callBase_CanAttackOpponent();
			}

			// Token: 0x06006C74 RID: 27764 RVA: 0x001E5AA8 File Offset: 0x001E3CA8
			public int __callBase_CanAttackOpponentByClient()
			{
				return this.m_owner.__callBase_CanAttackOpponentByClient();
			}

			// Token: 0x06006C75 RID: 27765 RVA: 0x001E5AB8 File Offset: 0x001E3CB8
			public int __callBase_CanRevengeOpponent(ulong battleReportInstanceId)
			{
				return this.m_owner.__callBase_CanRevengeOpponent(battleReportInstanceId);
			}

			// Token: 0x06006C76 RID: 27766 RVA: 0x001E5AC8 File Offset: 0x001E3CC8
			public void __callBase_SetBattleReportRevenged(ArenaBattleReport battleReport)
			{
				this.m_owner.__callBase_SetBattleReportRevenged(battleReport);
			}

			// Token: 0x06006C77 RID: 27767 RVA: 0x001E5AD8 File Offset: 0x001E3CD8
			public int __callBase_CanFlushOpponents()
			{
				return this.m_owner.__callBase_CanFlushOpponents();
			}

			// Token: 0x06006C78 RID: 27768 RVA: 0x001E5AE8 File Offset: 0x001E3CE8
			public bool __callBase_IsInSettleCacheTime()
			{
				return this.m_owner.__callBase_IsInSettleCacheTime();
			}

			// Token: 0x06006C79 RID: 27769 RVA: 0x001E5AF8 File Offset: 0x001E3CF8
			public bool __callBase_IsInRealWeekSettleTime()
			{
				return this.m_owner.__callBase_IsInRealWeekSettleTime();
			}

			// Token: 0x06006C7A RID: 27770 RVA: 0x001E5B08 File Offset: 0x001E3D08
			public bool __callBase_IsArenaOpen()
			{
				return this.m_owner.__callBase_IsArenaOpen();
			}

			// Token: 0x06006C7B RID: 27771 RVA: 0x001E5B18 File Offset: 0x001E3D18
			public bool __callBase_IsEmptyArenaPlayerInfo()
			{
				return this.m_owner.__callBase_IsEmptyArenaPlayerInfo();
			}

			// Token: 0x06006C7C RID: 27772 RVA: 0x001E5B28 File Offset: 0x001E3D28
			public bool __callBase_IsArenaInited()
			{
				return this.m_owner.__callBase_IsArenaInited();
			}

			// Token: 0x06006C7D RID: 27773 RVA: 0x001E5B38 File Offset: 0x001E3D38
			public bool __callBase_IsVictoryPointsRewardGot(int victoryPointsRewardIndex)
			{
				return this.m_owner.__callBase_IsVictoryPointsRewardGot(victoryPointsRewardIndex);
			}

			// Token: 0x06006C7E RID: 27774 RVA: 0x001E5B48 File Offset: 0x001E3D48
			public int __callBase_AttackOpponentFighting()
			{
				return this.m_owner.__callBase_AttackOpponentFighting();
			}

			// Token: 0x06006C7F RID: 27775 RVA: 0x001E5B58 File Offset: 0x001E3D58
			public void __callBase_ArenaBattleFinish(GameFunctionStatus status)
			{
				this.m_owner.__callBase_ArenaBattleFinish(status);
			}

			// Token: 0x06006C80 RID: 27776 RVA: 0x001E5B68 File Offset: 0x001E3D68
			public void __callBase_SetUpFirstDefensiveTeam()
			{
				this.m_owner.__callBase_SetUpFirstDefensiveTeam();
			}

			// Token: 0x06006C81 RID: 27777 RVA: 0x001E5B78 File Offset: 0x001E3D78
			public void __callBase_SetMineRank(int rank)
			{
				this.m_owner.__callBase_SetMineRank(rank);
			}

			// Token: 0x06006C82 RID: 27778 RVA: 0x001E5B88 File Offset: 0x001E3D88
			public int __callBase_GetMineRank()
			{
				return this.m_owner.__callBase_GetMineRank();
			}

			// Token: 0x06006C83 RID: 27779 RVA: 0x001E5B98 File Offset: 0x001E3D98
			public List<ArenaBattleReport> __callBase_GetAllArenaBattleReports()
			{
				return this.m_owner.__callBase_GetAllArenaBattleReports();
			}

			// Token: 0x06006C84 RID: 27780 RVA: 0x001E5BA8 File Offset: 0x001E3DA8
			public void __callBase_ArenaConsecutiveSuccess(int consecutiveVictoryNums)
			{
				this.m_owner.__callBase_ArenaConsecutiveSuccess(consecutiveVictoryNums);
			}

			// Token: 0x06006C85 RID: 27781 RVA: 0x001E5BB8 File Offset: 0x001E3DB8
			public int __callBase_CanGetArenaTopRankPlayers()
			{
				return this.m_owner.__callBase_CanGetArenaTopRankPlayers();
			}

			// Token: 0x06006C86 RID: 27782 RVA: 0x001E5BC8 File Offset: 0x001E3DC8
			public int __callBase_CanGetArenaPlayerInfo()
			{
				return this.m_owner.__callBase_CanGetArenaPlayerInfo();
			}

			// Token: 0x06006C87 RID: 27783 RVA: 0x001E5BD8 File Offset: 0x001E3DD8
			public int __callBase_CanReconnectArenaBattle()
			{
				return this.m_owner.__callBase_CanReconnectArenaBattle();
			}

			// Token: 0x06006C88 RID: 27784 RVA: 0x001E5BE8 File Offset: 0x001E3DE8
			public int __callBase_ReconnectArenaBattle()
			{
				return this.m_owner.__callBase_ReconnectArenaBattle();
			}

			// Token: 0x06006C89 RID: 27785 RVA: 0x001E5BF8 File Offset: 0x001E3DF8
			public void OnStartArenaBattle(ArenaOpponentDefensiveBattleInfo battleInfo)
			{
				this.m_owner.OnStartArenaBattle(battleInfo);
			}

			// Token: 0x04005327 RID: 21287
			private ArenaComponent m_owner;
		}
	}
}
