using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000935 RID: 2357
	[CustomLuaClass]
	public class ClientActorActPunchMove : ClientActorAct
	{
		// Token: 0x040061BA RID: 25018
		public GridPosition m_position;

		// Token: 0x040061BB RID: 25019
		public int m_direction;

		// Token: 0x040061BC RID: 25020
		public string m_fxName;

		// Token: 0x040061BD RID: 25021
		public bool m_isDragExchange;
	}
}
