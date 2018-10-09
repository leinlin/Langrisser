using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200093F RID: 2367
	[CustomLuaClass]
	public class ClientActorActAttachBuff : ClientActorAct
	{
		// Token: 0x040061D7 RID: 25047
		public BuffState m_buffState;

		// Token: 0x040061D8 RID: 25048
		public uint m_fightTags;

		// Token: 0x040061D9 RID: 25049
		public int m_heroHpMax;

		// Token: 0x040061DA RID: 25050
		public int m_soldierHpMax;
	}
}
