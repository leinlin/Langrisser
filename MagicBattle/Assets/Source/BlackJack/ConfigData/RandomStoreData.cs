using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200033F RID: 831
	[CustomLuaClass]
	public class RandomStoreData
	{
		// Token: 0x04002567 RID: 9575
		public Dictionary<RandomStoreItemDataKey, List<RandomStoreItemData>> Stores = new Dictionary<RandomStoreItemDataKey, List<RandomStoreItemData>>();
	}
}
