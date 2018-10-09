using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000351 RID: 849
	[CustomLuaClass]
	public class BattleLevelAchievement
	{
		// Token: 0x04002583 RID: 9603
		public ConfigDataBattleAchievementRelatedInfo m_achievementRelatedInfo;

		// Token: 0x04002584 RID: 9604
		public List<Goods> m_rewards;
	}
}
