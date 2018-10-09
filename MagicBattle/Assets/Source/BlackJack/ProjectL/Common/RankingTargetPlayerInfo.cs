using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200056C RID: 1388
	[CustomLuaClass]
	public class RankingTargetPlayerInfo
	{
		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060050E3 RID: 20707 RVA: 0x00181FA8 File Offset: 0x001801A8
		// (set) Token: 0x060050E4 RID: 20708 RVA: 0x00181FB0 File Offset: 0x001801B0
		public RankingPlayerInfo PlayerInfo { get; set; }

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x00181FBC File Offset: 0x001801BC
		// (set) Token: 0x060050E6 RID: 20710 RVA: 0x00181FC4 File Offset: 0x001801C4
		public long UpdateTime { get; set; }

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x00181FD0 File Offset: 0x001801D0
		// (set) Token: 0x060050E8 RID: 20712 RVA: 0x00181FD8 File Offset: 0x001801D8
		public int Score { get; set; }
	}
}
