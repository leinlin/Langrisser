using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200056E RID: 1390
	[CustomLuaClass]
	public class RealTimePVPBattleReport : BattleReport
	{
		// Token: 0x060050F8 RID: 20728 RVA: 0x00182210 File Offset: 0x00180410
		public RealTimePVPBattleReport()
		{
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00182224 File Offset: 0x00180424
		public RealTimePVPBattleReport(BattleReport battleReport)
		{
			base.Version = battleReport.Version;
			base.InstanceId = battleReport.InstanceId;
			base.BattleType = battleReport.BattleType;
			base.BattleId = battleReport.BattleId;
			base.RandomSeed = battleReport.RandomSeed;
			this.Commands.AddRange(battleReport.Commands);
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00182290 File Offset: 0x00180490
		public RealTimePVPBattleReport DeepCopy()
		{
			RealTimePVPBattleReport realTimePVPBattleReport = new RealTimePVPBattleReport
			{
				Version = base.Version,
				InstanceId = base.InstanceId,
				BattleType = base.BattleType,
				BattleId = base.BattleId,
				RandomSeed = base.RandomSeed,
				ReportType = this.ReportType,
				BPRule = this.BPRule,
				Win = this.Win,
				IsCancel = this.IsCancel,
				CreateTime = this.CreateTime
			};
			realTimePVPBattleReport.Commands.AddRange(this.Commands);
			for (int i = 0; i < this.PlayerDatas.Length; i++)
			{
				realTimePVPBattleReport.PlayerDatas[i] = this.PlayerDatas[i].DeepCopy();
			}
			return realTimePVPBattleReport;
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x00182360 File Offset: 0x00180560
		// (set) Token: 0x060050FC RID: 20732 RVA: 0x00182368 File Offset: 0x00180568
		public RealTimePVPBattleReportType ReportType { get; set; }

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x00182374 File Offset: 0x00180574
		// (set) Token: 0x060050FE RID: 20734 RVA: 0x0018237C File Offset: 0x0018057C
		public BattleRoomBPRule BPRule { get; set; }

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x00182388 File Offset: 0x00180588
		// (set) Token: 0x06005100 RID: 20736 RVA: 0x00182390 File Offset: 0x00180590
		public DateTime CreateTime { get; set; }

		// Token: 0x04003A4B RID: 14923
		public RealTimePVPBattleReportPlayerData[] PlayerDatas = new RealTimePVPBattleReportPlayerData[2];

		// Token: 0x04003A4C RID: 14924
		public bool Win;

		// Token: 0x04003A4D RID: 14925
		public bool IsCancel;
	}
}
