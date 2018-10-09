using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000343 RID: 835
	[CustomLuaClass]
	public class RandomDropRewardGroup
	{
		// Token: 0x0400256E RID: 9582
		public int GroupIndex;

		// Token: 0x0400256F RID: 9583
		public int DropCount;

		// Token: 0x04002570 RID: 9584
		public Dictionary<int, WeightGoods> DropRewards = new Dictionary<int, WeightGoods>();
	}
}
