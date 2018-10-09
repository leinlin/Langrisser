using System;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200094C RID: 2380
	[CustomLuaClass]
	public class ClientActorActChangeTeam : ClientActorAct
	{
		// Token: 0x040061F8 RID: 25080
		public int m_team;

		// Token: 0x040061F9 RID: 25081
		public bool m_isAINpc;
	}
}
