using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000405 RID: 1029
	[CustomLuaClass]
	public class RandomEventLevelZone
	{
		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x00111CA4 File Offset: 0x0010FEA4
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x00111CAC File Offset: 0x0010FEAC
		public int LevelZoneId { get; set; }

		// Token: 0x04002DE2 RID: 11746
		public Dictionary<int, RandomEventGroup> Groups = new Dictionary<int, RandomEventGroup>();
	}
}
