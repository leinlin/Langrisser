using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000342 RID: 834
	[CustomLuaClass]
	public class RandomDropRewardArea
	{
		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x000C0750 File Offset: 0x000BE950
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x000C0758 File Offset: 0x000BE958
		public int AreaId { get; set; }

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x000C0764 File Offset: 0x000BE964
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x000C076C File Offset: 0x000BE96C
		public int CanDropMaxCount { get; set; }

		// Token: 0x0400256C RID: 9580
		public List<RandomDropRewardGroup> groups = new List<RandomDropRewardGroup>();
	}
}
