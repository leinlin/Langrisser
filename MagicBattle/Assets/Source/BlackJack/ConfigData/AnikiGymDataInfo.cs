using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200034A RID: 842
	[CustomLuaClass]
	public class AnikiGymDataInfo
	{
		// Token: 0x0400257A RID: 9594
		public Dictionary<int, List<ConfigDataAnikiGymInfo>> AnikiGymOfWeekDict = new Dictionary<int, List<ConfigDataAnikiGymInfo>>();
	}
}
