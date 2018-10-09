using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000347 RID: 839
	[CustomLuaClass]
	public class MonthSignRewardInfo
	{
		// Token: 0x04002575 RID: 9589
		public int Month;

		// Token: 0x04002576 RID: 9590
		public Dictionary<int, List<Goods>> SignRewards = new Dictionary<int, List<Goods>>();
	}
}
