using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200095F RID: 2399
	[CustomLuaClass]
	public class ClientNullActorActFastCombat : ClientActorAct
	{
		// Token: 0x04006221 RID: 25121
		public FastCombatActorInfo m_fastCombatActorInfoA;

		// Token: 0x04006222 RID: 25122
		public FastCombatActorInfo m_fastCombatActorInfoB;

		// Token: 0x04006223 RID: 25123
		public ConfigDataSkillInfo m_attackerSkillInfo;
	}
}
