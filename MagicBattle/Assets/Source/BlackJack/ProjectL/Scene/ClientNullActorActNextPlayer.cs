using System;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200095C RID: 2396
	[CustomLuaClass]
	public class ClientNullActorActNextPlayer : ClientActorAct
	{
		// Token: 0x04006214 RID: 25108
		public int m_playerIndex;

		// Token: 0x04006215 RID: 25109
		public ClientBattleActor m_focusActor;
	}
}
