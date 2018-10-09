using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000345 RID: 837
	[CustomLuaClass]
	public class FixedStoreInfo
	{
		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x000C07B4 File Offset: 0x000BE9B4
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x000C07BC File Offset: 0x000BE9BC
		public int StoreId { get; set; }

		// Token: 0x04002573 RID: 9587
		public Dictionary<int, ConfigDataFixedStoreItemInfo> StoreItems = new Dictionary<int, ConfigDataFixedStoreItemInfo>();
	}
}
