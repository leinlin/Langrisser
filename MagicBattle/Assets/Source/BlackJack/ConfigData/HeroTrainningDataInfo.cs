using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200034C RID: 844
	[CustomLuaClass]
	public class HeroTrainningDataInfo
	{
		// Token: 0x0400257C RID: 9596
		public Dictionary<int, List<ConfigDataHeroTrainningInfo>> HeroTrainningOfWeekDict = new Dictionary<int, List<ConfigDataHeroTrainningInfo>>();
	}
}
