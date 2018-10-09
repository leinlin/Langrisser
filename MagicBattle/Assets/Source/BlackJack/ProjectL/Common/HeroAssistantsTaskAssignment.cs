using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000548 RID: 1352
	[CustomLuaClass]
	public class HeroAssistantsTaskAssignment
	{
		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x0017F894 File Offset: 0x0017DA94
		public int AssignPoints
		{
			get
			{
				int num = 0;
				foreach (int heroId in this.AssignedHeroIds)
				{
					num += this.Task.GetHeroAssignPoints(heroId);
				}
				return num;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x0017F8FC File Offset: 0x0017DAFC
		public int CompleteRate
		{
			get
			{
				return Math.Min(100, this.AssignPoints * 100 / this.Task.CompletePoints);
			}
		}

		// Token: 0x040039D4 RID: 14804
		public int TaskId;

		// Token: 0x040039D5 RID: 14805
		public HeroAssistantsTask Task;

		// Token: 0x040039D6 RID: 14806
		public List<int> AssignedHeroIds = new List<int>();

		// Token: 0x040039D7 RID: 14807
		public DateTime StartTime;

		// Token: 0x040039D8 RID: 14808
		public DateTime EndTime;

		// Token: 0x040039D9 RID: 14809
		public int Slot;
	}
}
