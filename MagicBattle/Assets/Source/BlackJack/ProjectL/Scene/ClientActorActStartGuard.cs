using System;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000951 RID: 2385
	[CustomLuaClass]
	public class ClientActorActStartGuard : ClientActorAct
	{
		// Token: 0x040061FE RID: 25086
		public BattleActor m_targetActor;

		// Token: 0x040061FF RID: 25087
		public GridPosition m_position;

		// Token: 0x04006200 RID: 25088
		public int m_direction;
	}
}
