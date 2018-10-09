using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000344 RID: 836
	[CustomLuaClass]
	public class FixedStoreDataInfo
	{
		// Token: 0x04002571 RID: 9585
		public Dictionary<int, FixedStoreInfo> Stores = new Dictionary<int, FixedStoreInfo>();
	}
}
