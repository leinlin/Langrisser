using System;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000878 RID: 2168
	[CustomLuaClass]
	public class LocalAccountConfigData
	{
		// Token: 0x040052B0 RID: 21168
		public string[] HaveReadAnnounceActivities;

		// Token: 0x040052B1 RID: 21169
		public int[] HaveReadHeroBiographyIds;

		// Token: 0x040052B2 RID: 21170
		public int[] HaveReadHeroPerformanceIds;

		// Token: 0x040052B3 RID: 21171
		public int[] UnlockHeroBiographyIds;

		// Token: 0x040052B4 RID: 21172
		public int[] UnlockHeroPerformanceIds;

		// Token: 0x040052B5 RID: 21173
		public int[] UnlockHeroDungeonLevelIds;

		// Token: 0x040052B6 RID: 21174
		public int[] UnlockHeroFetterIds;

		// Token: 0x040052B7 RID: 21175
		public int[] ArenaAttackerHeroIds;

		// Token: 0x040052B8 RID: 21176
		public int TeamPlayerLevelMin;

		// Token: 0x040052B9 RID: 21177
		public int TeamPlayerLevelMax;

		// Token: 0x040052BA RID: 21178
		public bool IsRealtimePVPShowNotice = true;

		// Token: 0x040052BB RID: 21179
		public bool HaveDoneMemoryExtraction;
	}
}
