using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000942 RID: 2370
	[CustomLuaClass]
	public class ClientActorActPassiveSkill : ClientActorAct
	{
		// Token: 0x040061DF RID: 25055
		public BuffState m_sourceBuffState;

		// Token: 0x040061E0 RID: 25056
		public bool m_hitSelf;
	}
}
