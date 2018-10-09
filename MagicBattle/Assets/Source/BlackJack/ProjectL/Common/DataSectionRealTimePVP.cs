using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004F2 RID: 1266
	[CustomLuaClass]
	public class DataSectionRealTimePVP : DataSection
	{
		// Token: 0x06004CCF RID: 19663 RVA: 0x001794A4 File Offset: 0x001776A4
		public override void ClearInitedData()
		{
			base.ClearInitedData();
			this.PromotionReports.Clear();
			this.Reports.Clear();
			this.FriendlyMatchStats = new RealTimePVPMatchStats();
			this.LadderMatchStats = new RealTimePVPMatchStats();
			this.FriendlyCareerMatchStats = new RealTimePVPMatchStats();
			this.LadderCareerMatchStats = new RealTimePVPMatchStats();
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x001794FC File Offset: 0x001776FC
		public override object SerializeToClient()
		{
			DSRealTimePVPNtf dsrealTimePVPNtf = new DSRealTimePVPNtf
			{
				Version = (uint)base.Version,
				RealTimePVP = new ProRealTimePVP
				{
					IsPromotion = this.IsPromotion
				}
			};
			foreach (RealTimePVPBattleReport report in this.PromotionReports)
			{
				dsrealTimePVPNtf.RealTimePVP.PromotionReports.Add(report.ToPro());
			}
			foreach (RealTimePVPBattleReport report2 in this.Reports)
			{
				dsrealTimePVPNtf.RealTimePVP.Reports.Add(report2.ToPro());
			}
			dsrealTimePVPNtf.RealTimePVP.FriendlyMatchStats = this.FriendlyMatchStats.ToPro();
			dsrealTimePVPNtf.RealTimePVP.FriendlyCareerMatchStats = this.FriendlyCareerMatchStats.ToPro();
			dsrealTimePVPNtf.RealTimePVP.LadderMatchStats = this.LadderMatchStats.ToPro();
			dsrealTimePVPNtf.RealTimePVP.LadderCareerMatchStats = this.LadderCareerMatchStats.ToPro();
			dsrealTimePVPNtf.RealTimePVP.WinsBonusIdAcquired.AddRange(this.WinsBonusIdAcquired);
			return dsrealTimePVPNtf;
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00179664 File Offset: 0x00177864
		public void StartPromotion()
		{
			this.IsPromotion = true;
			base.SetDirty(true);
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00179674 File Offset: 0x00177874
		public void EndPromotion()
		{
			this.IsPromotion = false;
			this.PromotionReports.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x00179690 File Offset: 0x00177890
		public void SavePromotionReport(RealTimePVPBattleReport Report)
		{
			this.PromotionReports.AddFirst(Report);
			base.SetDirty(true);
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x001796A8 File Offset: 0x001778A8
		public void SaveReport(RealTimePVPBattleReport Report)
		{
			this.Reports.AddFirst(Report);
			RealTimePVPMatchStats realTimePVPMatchStats = null;
			RealTimePVPMatchStats realTimePVPMatchStats2 = null;
			RealTimePVPBattleReportType reportType = Report.ReportType;
			if (reportType != RealTimePVPBattleReportType.Default && reportType != RealTimePVPBattleReportType.Promotion)
			{
				if (reportType == RealTimePVPBattleReportType.Friendly)
				{
					realTimePVPMatchStats = this.FriendlyMatchStats;
					realTimePVPMatchStats2 = this.FriendlyCareerMatchStats;
				}
			}
			else
			{
				realTimePVPMatchStats = this.LadderMatchStats;
				realTimePVPMatchStats2 = this.LadderCareerMatchStats;
			}
			if (Report.Win)
			{
				realTimePVPMatchStats.AddWins();
				realTimePVPMatchStats2.AddWins();
			}
			else
			{
				realTimePVPMatchStats.AddLosses();
				realTimePVPMatchStats2.AddLosses();
			}
			base.SetDirty(true);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x0017973C File Offset: 0x0017793C
		public void StartNewSeason()
		{
			this.IsPromotion = false;
			this.PromotionReports.Clear();
			this.FriendlyMatchStats = new RealTimePVPMatchStats();
			this.LadderMatchStats = new RealTimePVPMatchStats();
			this.WinsBonusIdAcquired.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x00179778 File Offset: 0x00177978
		public void AcquireWinsBonus(int BonusId)
		{
			this.WinsBonusIdAcquired.Add(BonusId);
			base.SetDirty(true);
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00179790 File Offset: 0x00177990
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00179798 File Offset: 0x00177998
		public bool IsPromotion { get; set; }

		// Token: 0x040038C5 RID: 14533
		public LinkedList<RealTimePVPBattleReport> PromotionReports = new LinkedList<RealTimePVPBattleReport>();

		// Token: 0x040038C6 RID: 14534
		public LinkedList<RealTimePVPBattleReport> Reports = new LinkedList<RealTimePVPBattleReport>();

		// Token: 0x040038C7 RID: 14535
		public RealTimePVPMatchStats FriendlyMatchStats = new RealTimePVPMatchStats();

		// Token: 0x040038C8 RID: 14536
		public RealTimePVPMatchStats LadderMatchStats = new RealTimePVPMatchStats();

		// Token: 0x040038C9 RID: 14537
		public RealTimePVPMatchStats FriendlyCareerMatchStats = new RealTimePVPMatchStats();

		// Token: 0x040038CA RID: 14538
		public RealTimePVPMatchStats LadderCareerMatchStats = new RealTimePVPMatchStats();

		// Token: 0x040038CB RID: 14539
		public List<int> WinsBonusIdAcquired = new List<int>();
	}
}
