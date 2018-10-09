using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000946 RID: 2374
	[CustomLuaClass]
	public class ClientActorActTeleportDisappear : ClientActorAct
	{
		// Token: 0x040061EE RID: 25070
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040061EF RID: 25071
		public GridPosition m_position;
	}
}
