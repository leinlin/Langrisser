using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000945 RID: 2373
	[CustomLuaClass]
	public class ClientActorActTerrainHit : ClientActorAct
	{
		// Token: 0x040061E8 RID: 25064
		public ConfigDataTerrainInfo m_terrainInfo;

		// Token: 0x040061E9 RID: 25065
		public int m_heroHp;

		// Token: 0x040061EA RID: 25066
		public int m_soldierHp;

		// Token: 0x040061EB RID: 25067
		public int m_heroHpModify;

		// Token: 0x040061EC RID: 25068
		public int m_soldierHpModify;

		// Token: 0x040061ED RID: 25069
		public DamageNumberType m_damageNumberType;
	}
}
