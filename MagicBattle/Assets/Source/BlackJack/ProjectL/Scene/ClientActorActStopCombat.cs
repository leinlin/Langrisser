using System;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000956 RID: 2390
	[CustomLuaClass]
	public class ClientActorActStopCombat : ClientActorAct
	{
		// Token: 0x04006209 RID: 25097
		public int m_heroHp;

		// Token: 0x0400620A RID: 25098
		public int m_soldierHp;

		// Token: 0x0400620B RID: 25099
		public int m_heroDamage;

		// Token: 0x0400620C RID: 25100
		public int m_soldierDamage;
	}
}
