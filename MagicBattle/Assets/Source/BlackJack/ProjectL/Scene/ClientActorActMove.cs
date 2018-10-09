using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000932 RID: 2354
	[CustomLuaClass]
	public class ClientActorActMove : ClientActorAct
	{
		// Token: 0x040061B0 RID: 25008
		public GridPosition m_position;

		// Token: 0x040061B1 RID: 25009
		public int m_direction;

		// Token: 0x040061B2 RID: 25010
		public bool m_sound;
	}
}
