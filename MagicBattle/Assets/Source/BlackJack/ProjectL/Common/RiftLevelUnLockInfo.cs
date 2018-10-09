using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000574 RID: 1396
	[CustomLuaClass]
	public class RiftLevelUnLockInfo
	{
		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x00182BD0 File Offset: 0x00180DD0
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x00182BD8 File Offset: 0x00180DD8
		public HashSet<int> FinishedRiftLevelIds { get; set; }

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x00182BE4 File Offset: 0x00180DE4
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x00182BEC File Offset: 0x00180DEC
		public HashSet<int> GainRiftAchievementRelationIds { get; set; }

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x00182BF8 File Offset: 0x00180DF8
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x00182C00 File Offset: 0x00180E00
		public HashSet<int> GainHeroIds { get; set; }
	}
}
