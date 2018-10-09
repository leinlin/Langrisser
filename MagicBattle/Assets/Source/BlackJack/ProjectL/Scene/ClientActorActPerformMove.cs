using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000934 RID: 2356
	[CustomLuaClass]
	public class ClientActorActPerformMove : ClientActorAct
	{
		// Token: 0x040061B6 RID: 25014
		public GridPosition m_position;

		// Token: 0x040061B7 RID: 25015
		public int m_direction;

		// Token: 0x040061B8 RID: 25016
		public bool m_sound;

		// Token: 0x040061B9 RID: 25017
		public bool m_cameraFollow;
	}
}
