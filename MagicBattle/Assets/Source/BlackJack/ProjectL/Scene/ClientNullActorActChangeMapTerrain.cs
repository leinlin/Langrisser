using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000963 RID: 2403
	[CustomLuaClass]
	public class ClientNullActorActChangeMapTerrain : ClientActorAct
	{
		// Token: 0x04006226 RID: 25126
		public GridPosition m_position;

		// Token: 0x04006227 RID: 25127
		public ConfigDataTerrainInfo m_terrainInfo;
	}
}
