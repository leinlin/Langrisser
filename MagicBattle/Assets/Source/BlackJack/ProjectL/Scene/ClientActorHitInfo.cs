using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200093C RID: 2364
	[CustomLuaClass]
	public class ClientActorHitInfo
	{
		// Token: 0x040061CB RID: 25035
		public int m_heroHp;

		// Token: 0x040061CC RID: 25036
		public int m_soldierHp;

		// Token: 0x040061CD RID: 25037
		public int m_heroHpModify;

		// Token: 0x040061CE RID: 25038
		public int m_soldierHpModify;

		// Token: 0x040061CF RID: 25039
		public int m_frame;

		// Token: 0x040061D0 RID: 25040
		public DamageNumberType m_damageNumberType;
	}
}
