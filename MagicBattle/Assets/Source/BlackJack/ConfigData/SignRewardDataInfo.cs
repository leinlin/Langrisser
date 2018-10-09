using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000346 RID: 838
	[CustomLuaClass]
	public class SignRewardDataInfo
	{
		// Token: 0x04002574 RID: 9588
		public Dictionary<int, MonthSignRewardInfo> MonthRewards = new Dictionary<int, MonthSignRewardInfo>();
	}
}
