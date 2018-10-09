using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003F1 RID: 1009
	[CustomLuaClass]
	public class RealTimePVPConstDefine
	{
		// Token: 0x04002D57 RID: 11607
		public const int NoRank = -1;

		// Token: 0x04002D58 RID: 11608
		public const DayOfWeek StartDayOfWeek = DayOfWeek.Monday;

		// Token: 0x04002D59 RID: 11609
		public const int RankingRewardSingleOperationTimeThreshold = 2000;
	}
}
