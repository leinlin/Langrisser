using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000947 RID: 2375
	[CustomLuaClass]
	public class ClientActorActTeleportAppear : ClientActorAct
	{
		// Token: 0x040061F0 RID: 25072
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040061F1 RID: 25073
		public GridPosition m_position;
	}
}
