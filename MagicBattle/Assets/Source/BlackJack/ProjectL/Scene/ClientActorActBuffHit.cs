using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000944 RID: 2372
	[CustomLuaClass]
	public class ClientActorActBuffHit : ClientActorAct
	{
		// Token: 0x040061E2 RID: 25058
		public BuffState m_buffState;

		// Token: 0x040061E3 RID: 25059
		public int m_heroHp;

		// Token: 0x040061E4 RID: 25060
		public int m_soldierHp;

		// Token: 0x040061E5 RID: 25061
		public int m_heroHpModify;

		// Token: 0x040061E6 RID: 25062
		public int m_soldierHpModify;

		// Token: 0x040061E7 RID: 25063
		public DamageNumberType m_damageNumberType;
	}
}
