using System;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000340 RID: 832
	[CustomLuaClass]
	public class RandomStoreItemData
	{
		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x000C0700 File Offset: 0x000BE900
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x000C0708 File Offset: 0x000BE908
		public int Id { get; set; }

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x000C0714 File Offset: 0x000BE914
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x000C071C File Offset: 0x000BE91C
		public int Weight { get; set; }
	}
}
