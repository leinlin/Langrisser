using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000567 RID: 1383
	[CustomLuaClass]
	public class MonthCard
	{
		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060050B9 RID: 20665 RVA: 0x00181BF0 File Offset: 0x0017FDF0
		// (set) Token: 0x060050BA RID: 20666 RVA: 0x00181BF8 File Offset: 0x0017FDF8
		public int CardId { get; set; }

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060050BB RID: 20667 RVA: 0x00181C04 File Offset: 0x0017FE04
		// (set) Token: 0x060050BC RID: 20668 RVA: 0x00181C0C File Offset: 0x0017FE0C
		public DateTime ExpiredTime { get; set; }

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060050BD RID: 20669 RVA: 0x00181C18 File Offset: 0x0017FE18
		// (set) Token: 0x060050BE RID: 20670 RVA: 0x00181C20 File Offset: 0x0017FE20
		public string GoodsId { get; set; }

		// Token: 0x060050BF RID: 20671 RVA: 0x00181C2C File Offset: 0x0017FE2C
		public static ProMonthCard ToPB(MonthCard monthCard)
		{
			return new ProMonthCard
			{
				MonthCardId = monthCard.CardId,
				ExpiredTime = monthCard.ExpiredTime.Ticks
			};
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00181C60 File Offset: 0x0017FE60
		public static MonthCard FromPB(ProMonthCard pbMonthCard)
		{
			return new MonthCard
			{
				CardId = pbMonthCard.MonthCardId,
				ExpiredTime = new DateTime(pbMonthCard.ExpiredTime)
			};
		}
	}
}
