using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200050A RID: 1290
	[CustomLuaClass]
	public class ArenaBattleReport : BattleReport
	{
		// Token: 0x06004E02 RID: 19970 RVA: 0x0017BB78 File Offset: 0x00179D78
		public ArenaBattleReport()
		{
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x0017BBAC File Offset: 0x00179DAC
		public ArenaBattleReport(BattleReport battleReport)
		{
			base.Version = battleReport.Version;
			base.InstanceId = battleReport.InstanceId;
			base.BattleType = battleReport.BattleType;
			base.BattleId = battleReport.BattleId;
			base.RandomSeed = battleReport.RandomSeed;
			this.Commands.AddRange(battleReport.Commands);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x0017BC38 File Offset: 0x00179E38
		public ArenaBattleReport(ArenaBattleReport other)
		{
			this.Status = other.Status;
			base.Version = other.Version;
			base.BattleType = other.BattleType;
			base.BattleId = other.BattleId;
			base.RandomSeed = other.RandomSeed;
			this.Commands.AddRange(other.Commands);
			this.ArenaDefenderRuleId = other.ArenaDefenderRuleId;
			this.DefenderUserId = other.DefenderUserId;
			this.DefenderName = other.DefenderName;
			this.DefenderLevel = other.DefenderLevel;
			this.AttackerUserId = other.AttackerUserId;
			this.AttackerName = other.AttackerName;
			this.AttackerLevel = other.AttackerLevel;
			this.CreateTime = other.CreateTime;
			this.OpponentHeadIcon = other.OpponentHeadIcon;
			this.AttackerHeroes.AddRange(other.AttackerHeroes);
			this.DefenderHeroes.AddRange(other.DefenderHeroes);
			this.AttackerTechs.AddRange(other.AttackerTechs);
			this.DefenderTechs.AddRange(other.DefenderTechs);
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06004E05 RID: 19973 RVA: 0x0017BD74 File Offset: 0x00179F74
		// (set) Token: 0x06004E06 RID: 19974 RVA: 0x0017BD7C File Offset: 0x00179F7C
		public ArenaBattleReportStatus Status { get; set; }

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x0017BD88 File Offset: 0x00179F88
		// (set) Token: 0x06004E08 RID: 19976 RVA: 0x0017BD90 File Offset: 0x00179F90
		public int ArenaDefenderRuleId { get; set; }

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06004E09 RID: 19977 RVA: 0x0017BD9C File Offset: 0x00179F9C
		// (set) Token: 0x06004E0A RID: 19978 RVA: 0x0017BDA4 File Offset: 0x00179FA4
		public string DefenderUserId { get; set; }

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06004E0B RID: 19979 RVA: 0x0017BDB0 File Offset: 0x00179FB0
		// (set) Token: 0x06004E0C RID: 19980 RVA: 0x0017BDB8 File Offset: 0x00179FB8
		public string DefenderName { get; set; }

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06004E0D RID: 19981 RVA: 0x0017BDC4 File Offset: 0x00179FC4
		// (set) Token: 0x06004E0E RID: 19982 RVA: 0x0017BDCC File Offset: 0x00179FCC
		public int DefenderLevel { get; set; }

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06004E0F RID: 19983 RVA: 0x0017BDD8 File Offset: 0x00179FD8
		// (set) Token: 0x06004E10 RID: 19984 RVA: 0x0017BDE0 File Offset: 0x00179FE0
		public string AttackerUserId { get; set; }

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06004E11 RID: 19985 RVA: 0x0017BDEC File Offset: 0x00179FEC
		// (set) Token: 0x06004E12 RID: 19986 RVA: 0x0017BDF4 File Offset: 0x00179FF4
		public string AttackerName { get; set; }

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06004E13 RID: 19987 RVA: 0x0017BE00 File Offset: 0x0017A000
		// (set) Token: 0x06004E14 RID: 19988 RVA: 0x0017BE08 File Offset: 0x0017A008
		public int AttackerLevel { get; set; }

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06004E15 RID: 19989 RVA: 0x0017BE14 File Offset: 0x0017A014
		// (set) Token: 0x06004E16 RID: 19990 RVA: 0x0017BE1C File Offset: 0x0017A01C
		public int AttackerGotArenaPoints { get; set; }

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06004E17 RID: 19991 RVA: 0x0017BE28 File Offset: 0x0017A028
		// (set) Token: 0x06004E18 RID: 19992 RVA: 0x0017BE30 File Offset: 0x0017A030
		public int DefenderGotArenaPoints { get; set; }

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06004E19 RID: 19993 RVA: 0x0017BE3C File Offset: 0x0017A03C
		// (set) Token: 0x06004E1A RID: 19994 RVA: 0x0017BE44 File Offset: 0x0017A044
		public long CreateTime { get; set; }

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06004E1B RID: 19995 RVA: 0x0017BE50 File Offset: 0x0017A050
		// (set) Token: 0x06004E1C RID: 19996 RVA: 0x0017BE58 File Offset: 0x0017A058
		public int OpponentHeadIcon { get; set; }

		// Token: 0x06004E1D RID: 19997 RVA: 0x0017BE64 File Offset: 0x0017A064
		public static ArenaBattleReport PBArenaBattleReportToArenaBattleReport(ProArenaBattleReport pbArenaBattleReport, bool isBattleData)
		{
			ArenaBattleReport arenaBattleReport = new ArenaBattleReport();
			arenaBattleReport.InstanceId = pbArenaBattleReport.InstanceId;
			arenaBattleReport.Version = pbArenaBattleReport.Version;
			if (isBattleData)
			{
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
					arenaBattleReport.AttackerTechs.Add(TrainingTech.FromDataSection(tech));
				}
				foreach (ProTrainingTech tech2 in pbArenaBattleReport.DefenderTechs)
				{
					arenaBattleReport.DefenderTechs.Add(TrainingTech.FromDataSection(tech2));
				}
			}
			else
			{
				arenaBattleReport.Status = (ArenaBattleReportStatus)pbArenaBattleReport.Status;
				arenaBattleReport.AttackerUserId = pbArenaBattleReport.AttackerUserId;
				arenaBattleReport.AttackerLevel = pbArenaBattleReport.AttackerLevel;
				arenaBattleReport.AttackerName = pbArenaBattleReport.AttackerName;
				arenaBattleReport.DefenderUserId = pbArenaBattleReport.DefenderUserId;
				arenaBattleReport.DefenderLevel = pbArenaBattleReport.DefenderLevel;
				arenaBattleReport.DefenderName = pbArenaBattleReport.DefenderName;
				arenaBattleReport.CreateTime = pbArenaBattleReport.CreateTime;
				arenaBattleReport.AttackerGotArenaPoints = pbArenaBattleReport.AttackerGotArenaPoints;
				arenaBattleReport.DefenderGotArenaPoints = pbArenaBattleReport.DefenderGotArenaPoints;
				arenaBattleReport.OpponentHeadIcon = pbArenaBattleReport.OpponentHeadIcon;
			}
			return arenaBattleReport;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x0017C108 File Offset: 0x0017A308
		public static ProArenaBattleReport ArenaBattleReportToPBArenaBattleReport(ArenaBattleReport arenaBattleReport, bool isBattleData)
		{
			ProArenaBattleReport proArenaBattleReport = new ProArenaBattleReport();
			proArenaBattleReport.Version = arenaBattleReport.Version;
			proArenaBattleReport.InstanceId = arenaBattleReport.InstanceId;
			if (isBattleData)
			{
				proArenaBattleReport.BattleType = (int)arenaBattleReport.BattleType;
				proArenaBattleReport.BattleId = arenaBattleReport.BattleId;
				proArenaBattleReport.RandomSeed = arenaBattleReport.RandomSeed;
				proArenaBattleReport.ArenaDefenderRuleId = arenaBattleReport.ArenaDefenderRuleId;
				foreach (BattleCommand battleCommand in arenaBattleReport.Commands)
				{
					proArenaBattleReport.Commands.Add(BattleCommand.BattleCommandToPBBattleCommand(battleCommand));
				}
				foreach (BattleHero battleHero in arenaBattleReport.AttackerHeroes)
				{
					proArenaBattleReport.AttackerHeroes.Add(BattleHero.BattleHeroToPBBattleHero(battleHero));
				}
				foreach (BattleHero battleHero2 in arenaBattleReport.DefenderHeroes)
				{
					proArenaBattleReport.DefenderHeroes.Add(BattleHero.BattleHeroToPBBattleHero(battleHero2));
				}
				foreach (TrainingTech trainingTech in arenaBattleReport.AttackerTechs)
				{
					proArenaBattleReport.AttackerTechs.Add(trainingTech.ToPro());
				}
				foreach (TrainingTech trainingTech2 in arenaBattleReport.DefenderTechs)
				{
					proArenaBattleReport.DefenderTechs.Add(trainingTech2.ToPro());
				}
			}
			else
			{
				proArenaBattleReport.Status = (int)arenaBattleReport.Status;
				proArenaBattleReport.AttackerUserId = arenaBattleReport.AttackerUserId;
				proArenaBattleReport.AttackerLevel = arenaBattleReport.AttackerLevel;
				proArenaBattleReport.AttackerName = arenaBattleReport.AttackerName;
				proArenaBattleReport.DefenderUserId = arenaBattleReport.DefenderUserId;
				proArenaBattleReport.DefenderLevel = arenaBattleReport.DefenderLevel;
				proArenaBattleReport.DefenderName = arenaBattleReport.DefenderName;
				proArenaBattleReport.CreateTime = arenaBattleReport.CreateTime;
				proArenaBattleReport.AttackerGotArenaPoints = arenaBattleReport.AttackerGotArenaPoints;
				proArenaBattleReport.DefenderGotArenaPoints = arenaBattleReport.DefenderGotArenaPoints;
				proArenaBattleReport.OpponentHeadIcon = arenaBattleReport.OpponentHeadIcon;
			}
			return proArenaBattleReport;
		}

		// Token: 0x04003929 RID: 14633
		public List<BattleHero> DefenderHeroes = new List<BattleHero>();

		// Token: 0x0400392A RID: 14634
		public List<TrainingTech> DefenderTechs = new List<TrainingTech>();

		// Token: 0x0400392E RID: 14638
		public List<BattleHero> AttackerHeroes = new List<BattleHero>();

		// Token: 0x0400392F RID: 14639
		public List<TrainingTech> AttackerTechs = new List<TrainingTech>();
	}
}
