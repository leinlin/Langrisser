using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200034B RID: 843
	[CustomLuaClass]
	public class MemoryCorridorDataInfo
	{
		// Token: 0x0400257B RID: 9595
		public Dictionary<int, List<ConfigDataMemoryCorridorInfo>> MemoryCorridorOfWeekDict = new Dictionary<int, List<ConfigDataMemoryCorridorInfo>>();
	}
}
