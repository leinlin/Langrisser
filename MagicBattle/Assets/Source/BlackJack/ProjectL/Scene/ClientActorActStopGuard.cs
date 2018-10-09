using System;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000952 RID: 2386
	[CustomLuaClass]
	public class ClientActorActStopGuard : ClientActorAct
	{
		// Token: 0x04006201 RID: 25089
		public BattleActor m_targetActor;

		// Token: 0x04006202 RID: 25090
		public GridPosition m_position;

		// Token: 0x04006203 RID: 25091
		public int m_direction;
	}
}
