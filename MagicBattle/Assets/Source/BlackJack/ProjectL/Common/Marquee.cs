using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000559 RID: 1369
	[CustomLuaClass]
	public class Marquee
	{
		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06005039 RID: 20537 RVA: 0x001807CC File Offset: 0x0017E9CC
		// (set) Token: 0x0600503A RID: 20538 RVA: 0x001807D4 File Offset: 0x0017E9D4
		public DateTime SendTime { get; set; }

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600503B RID: 20539 RVA: 0x001807E0 File Offset: 0x0017E9E0
		// (set) Token: 0x0600503C RID: 20540 RVA: 0x001807E8 File Offset: 0x0017E9E8
		public string Title { get; set; }

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600503D RID: 20541 RVA: 0x001807F4 File Offset: 0x0017E9F4
		// (set) Token: 0x0600503E RID: 20542 RVA: 0x001807FC File Offset: 0x0017E9FC
		public string Content { get; set; }

		// Token: 0x0600503F RID: 20543 RVA: 0x00180808 File Offset: 0x0017EA08
		public static Marquee PBToMarquee(ProMarquee pbMarquee)
		{
			return new Marquee
			{
				SendTime = new DateTime(pbMarquee.SendTime),
				Title = pbMarquee.Title,
				Content = pbMarquee.Content
			};
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00180848 File Offset: 0x0017EA48
		public static ProMarquee ToPBMarquee(Marquee marquee)
		{
			return new ProMarquee
			{
				SendTime = marquee.SendTime.Ticks,
				Title = marquee.Title,
				Content = marquee.Content
			};
		}
	}
}
