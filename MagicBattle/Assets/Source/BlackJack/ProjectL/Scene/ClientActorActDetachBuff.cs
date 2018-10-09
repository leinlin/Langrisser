using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000940 RID: 2368
	[CustomLuaClass]
	public class ClientActorActDetachBuff : ClientActorAct
	{
		// Token: 0x040061DB RID: 25051
		public BuffState m_buffState;

		// Token: 0x040061DC RID: 25052
		public uint m_fightTags;

		// Token: 0x040061DD RID: 25053
		public int m_heroHpMax;

		// Token: 0x040061DE RID: 25054
		public int m_soldierHpMax;
	}
}
