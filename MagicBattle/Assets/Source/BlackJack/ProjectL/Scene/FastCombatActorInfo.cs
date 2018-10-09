using System;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200095E RID: 2398
	[CustomLuaClass]
	public class FastCombatActorInfo
	{
		// Token: 0x04006217 RID: 25111
		public BattleActor m_battleActor;

		// Token: 0x04006218 RID: 25112
		public int m_heroHpMax;

		// Token: 0x04006219 RID: 25113
		public int m_soldierHpMax;

		// Token: 0x0400621A RID: 25114
		public int m_beforeHeroHp;

		// Token: 0x0400621B RID: 25115
		public int m_beforeSoldierHp;

		// Token: 0x0400621C RID: 25116
		public int m_afterHeroHp;

		// Token: 0x0400621D RID: 25117
		public int m_afterSoldierHp;

		// Token: 0x0400621E RID: 25118
		public int m_heroDamage;

		// Token: 0x0400621F RID: 25119
		public int m_soldierDamage;

		// Token: 0x04006220 RID: 25120
		public bool m_isReceiveCriticalAttack;
	}
}
