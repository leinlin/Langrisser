using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200034D RID: 845
	[CustomLuaClass]
	public class EnchantPropertyProbabilityInfo
	{
		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000C0868 File Offset: 0x000BEA68
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x000C0870 File Offset: 0x000BEA70
		public PropertyModifyType Id { get; set; }

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x000C087C File Offset: 0x000BEA7C
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x000C0884 File Offset: 0x000BEA84
		public List<EnchantPropertyValueInfo> PropertyValues { get; set; }

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x000C0890 File Offset: 0x000BEA90
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x000C0898 File Offset: 0x000BEA98
		public int Weight { get; set; }
	}
}
