using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000349 RID: 841
	[CustomLuaClass]
	public class ThearchyTrialDataInfo
	{
		// Token: 0x04002579 RID: 9593
		public Dictionary<int, List<ConfigDataThearchyTrialInfo>> ThearchyTrailOfWeekDict = new Dictionary<int, List<ConfigDataThearchyTrialInfo>>();
	}
}
