using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200052E RID: 1326
	[CustomLuaClass]
	public class GlobalClimbTowerInfo
	{
		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x0017E080 File Offset: 0x0017C280
		// (set) Token: 0x06004F05 RID: 20229 RVA: 0x0017E088 File Offset: 0x0017C288
		public DateTime ClimbNextWeekFlushTime { get; set; }

		// Token: 0x04003992 RID: 14738
		public List<GlobalClimbTowerFloor> Floors = new List<GlobalClimbTowerFloor>();
	}
}
