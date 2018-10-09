using System;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200095B RID: 2395
	[CustomLuaClass]
	public class ClientNullActorActNextTeam : ClientActorAct
	{
		// Token: 0x04006212 RID: 25106
		public int m_team;

		// Token: 0x04006213 RID: 25107
		public ClientBattleActor m_focusActor;
	}
}
