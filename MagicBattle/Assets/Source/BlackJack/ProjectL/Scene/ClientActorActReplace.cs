using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200094E RID: 2382
	[CustomLuaClass]
	public class ClientActorActReplace : ClientActorAct
	{
		// Token: 0x040061FB RID: 25083
		public BattleActor m_newActor;

		// Token: 0x040061FC RID: 25084
		public string m_fxName;
	}
}
