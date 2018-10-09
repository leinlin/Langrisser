using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200093B RID: 2363
	[CustomLuaClass]
	public class ClientActorActTarget : ClientActorAct
	{
		// Token: 0x040061C8 RID: 25032
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040061C9 RID: 25033
		public GridPosition m_targetPosition;

		// Token: 0x040061CA RID: 25034
		public int m_armyRelationValue;
	}
}
