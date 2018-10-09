using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000955 RID: 2389
	[CustomLuaClass]
	public class ClientActorActStartCombat : ClientActorAct
	{
		// Token: 0x04006205 RID: 25093
		public BattleActor m_targetActor;

		// Token: 0x04006206 RID: 25094
		public ConfigDataSkillInfo m_attackerSkillInfo;

		// Token: 0x04006207 RID: 25095
		public int m_direction;

		// Token: 0x04006208 RID: 25096
		public bool m_isAttacker;
	}
}
