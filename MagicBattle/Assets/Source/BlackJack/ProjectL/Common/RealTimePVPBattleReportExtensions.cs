using System;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000571 RID: 1393
	public static class RealTimePVPBattleReportExtensions
	{
		// Token: 0x0600510B RID: 20747 RVA: 0x00182480 File Offset: 0x00180680
		public static RealTimePVPBattleReportPlayerData ToMemory(this ProRealTimePVPBattleReportPlayerData Data)
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = new RealTimePVPBattleReportPlayerData
			{
				HeadIcon = Data.HeadIcon,
				Level = Data.Level,
				Name = Data.Name,
				UserId = Data.UserId,
				ScoreDiff = Data.ScoreDiff
			};
			foreach (ProBattleHero pbBattleHero in Data.Heroes)
			{
				realTimePVPBattleReportPlayerData.Heroes.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero));
			}
			foreach (ProTrainingTech tech in Data.Techs)
			{
				realTimePVPBattleReportPlayerData.Techs.Add(TrainingTech.FromDataSection(tech));
			}
			return realTimePVPBattleReportPlayerData;
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00182584 File Offset: 0x00180784
		public static ProRealTimePVPBattleReportPlayerData ToPro(this RealTimePVPBattleReportPlayerData Data)
		{
			ProRealTimePVPBattleReportPlayerData proRealTimePVPBattleReportPlayerData = new ProRealTimePVPBattleReportPlayerData
			{
				HeadIcon = Data.HeadIcon,
				Level = Data.Level,
				Name = Data.Name,
				UserId = Data.UserId,
				ScoreDiff = Data.ScoreDiff
			};
			foreach (BattleHero battleHero in Data.Heroes)
			{
				proRealTimePVPBattleReportPlayerData.Heroes.Add(BattleHero.BattleHeroToPBBattleHero(battleHero));
			}
			foreach (TrainingTech trainingTech in Data.Techs)
			{
				proRealTimePVPBattleReportPlayerData.Techs.Add(trainingTech.ToPro());
			}
			return proRealTimePVPBattleReportPlayerData;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00182688 File Offset: 0x00180888
		public static RealTimePVPBattleReport ToMemory(this ProRealTimePVPBattleReport Report)
		{
			RealTimePVPBattleReport realTimePVPBattleReport = new RealTimePVPBattleReport
			{
				BattleId = Report.BattleId,
				BattleType = (BattleType)Report.BattleType,
				BPRule = (BattleRoomBPRule)Report.BPRule,
				CreateTime = new DateTime(Report.CreateTime),
				InstanceId = Report.InstanceId,
				RandomSeed = Report.RandomSeed,
				ReportType = (RealTimePVPBattleReportType)Report.ReportType,
				Win = Report.Win,
				IsCancel = Report.IsCancel,
				Version = Report.Version
			};
			for (int i = 0; i < Report.Datas.Count; i++)
			{
				realTimePVPBattleReport.PlayerDatas[i] = Report.Datas[i].ToMemory();
			}
			foreach (ProBattleCommand pbBattleCommand in Report.Commands)
			{
				realTimePVPBattleReport.Commands.Add(BattleCommand.PBBattleCommandToBattleCommand(pbBattleCommand));
			}
			return realTimePVPBattleReport;
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x001827AC File Offset: 0x001809AC
		public static ProRealTimePVPBattleReport ToPro(this RealTimePVPBattleReport Report)
		{
			ProRealTimePVPBattleReport proRealTimePVPBattleReport = new ProRealTimePVPBattleReport
			{
				BattleId = Report.BattleId,
				BattleType = (int)Report.BattleType,
				BPRule = (int)Report.BPRule,
				CreateTime = Report.CreateTime.Ticks,
				InstanceId = Report.InstanceId,
				RandomSeed = Report.RandomSeed,
				ReportType = (int)Report.ReportType,
				Win = Report.Win,
				IsCancel = Report.IsCancel,
				Version = Report.Version
			};
			for (int i = 0; i < Report.PlayerDatas.Length; i++)
			{
				proRealTimePVPBattleReport.Datas.Add(Report.PlayerDatas[i].ToPro());
			}
			foreach (BattleCommand battleCommand in Report.Commands)
			{
				proRealTimePVPBattleReport.Commands.Add(BattleCommand.BattleCommandToPBBattleCommand(battleCommand));
			}
			return proRealTimePVPBattleReport;
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x001828D0 File Offset: 0x00180AD0
		public static RealTimePVPMatchStats ToMemory(this ProRealTimePVPMatchStats ProStats)
		{
			return new RealTimePVPMatchStats
			{
				ConsecutiveLosses = ProStats.ConsecutiveLosses,
				ConsecutiveWins = ProStats.ConsecutiveWins,
				Matches = ProStats.Matches,
				Wins = ProStats.Wins
			};
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x00182914 File Offset: 0x00180B14
		public static ProRealTimePVPMatchStats ToPro(this RealTimePVPMatchStats Stats)
		{
			return new ProRealTimePVPMatchStats
			{
				ConsecutiveLosses = Stats.ConsecutiveLosses,
				ConsecutiveWins = Stats.ConsecutiveWins,
				Matches = Stats.Matches,
				Wins = Stats.Wins
			};
		}
	}
}
