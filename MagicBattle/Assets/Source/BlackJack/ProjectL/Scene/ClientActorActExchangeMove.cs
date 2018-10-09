using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000936 RID: 2358
	[CustomLuaClass]
	public class ClientActorActExchangeMove : ClientActorAct
	{
		// Token: 0x040061BE RID: 25022
		public GridPosition m_position;

		// Token: 0x040061BF RID: 25023
		public int m_direction;

		// Token: 0x040061C0 RID: 25024
		public string m_fxName;

		// Token: 0x040061C1 RID: 25025
		public int m_moveType;
	}
}
