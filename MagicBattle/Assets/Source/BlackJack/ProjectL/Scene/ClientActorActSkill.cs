using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200093D RID: 2365
	[CustomLuaClass]
	public class ClientActorActSkill : ClientActorAct
	{
		// Token: 0x040061D1 RID: 25041
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040061D2 RID: 25042
		public GridPosition m_targetPosition;

		// Token: 0x040061D3 RID: 25043
		public List<ClientActorHitInfo> m_hits;
	}
}
