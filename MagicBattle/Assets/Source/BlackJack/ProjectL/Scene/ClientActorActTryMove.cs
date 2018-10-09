using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000933 RID: 2355
	[CustomLuaClass]
	public class ClientActorActTryMove : ClientActorAct
	{
		// Token: 0x040061B3 RID: 25011
		public GridPosition m_position;

		// Token: 0x040061B4 RID: 25012
		public int m_direction;

		// Token: 0x040061B5 RID: 25013
		public bool m_sound;
	}
}
