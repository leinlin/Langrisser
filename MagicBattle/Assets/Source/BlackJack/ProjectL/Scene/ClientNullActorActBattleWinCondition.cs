using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000958 RID: 2392
	[CustomLuaClass]
	public class ClientNullActorActBattleWinCondition : ClientActorAct
	{
		// Token: 0x0400620D RID: 25101
		public ConfigDataBattleWinConditionInfo m_winConditionInfo;

		// Token: 0x0400620E RID: 25102
		public GridPosition m_targetPosition;
	}
}
