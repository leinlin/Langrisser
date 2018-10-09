using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000959 RID: 2393
	[CustomLuaClass]
	public class ClientNullActorActBattleLoseCondition : ClientActorAct
	{
		// Token: 0x0400620F RID: 25103
		public ConfigDataBattleLoseConditionInfo m_loseConditionInfo;

		// Token: 0x04006210 RID: 25104
		public GridPosition m_targetPosition;
	}
}
