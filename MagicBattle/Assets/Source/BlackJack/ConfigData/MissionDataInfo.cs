using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000348 RID: 840
	[CustomLuaClass]
	public class MissionDataInfo
	{
		// Token: 0x04002577 RID: 9591
		public List<ConfigDataMissionInfo> EverydayMissions = new List<ConfigDataMissionInfo>();

		// Token: 0x04002578 RID: 9592
		public List<ConfigDataMissionInfo> OneOffMissions = new List<ConfigDataMissionInfo>();
	}
}
