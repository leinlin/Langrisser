using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200093E RID: 2366
	[CustomLuaClass]
	public class ClientActorActSkillHit : ClientActorAct
	{
		// Token: 0x040061D4 RID: 25044
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040061D5 RID: 25045
		public int m_direction;

		// Token: 0x040061D6 RID: 25046
		public List<ClientActorHitInfo> m_hits;
	}
}
