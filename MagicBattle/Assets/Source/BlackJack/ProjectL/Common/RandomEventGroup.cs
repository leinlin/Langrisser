using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000406 RID: 1030
	[CustomLuaClass]
	public class RandomEventGroup
	{
		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x00111CC0 File Offset: 0x0010FEC0
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x00111CC8 File Offset: 0x0010FEC8
		public int Index { get; set; }

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x00111CD4 File Offset: 0x0010FED4
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x00111CDC File Offset: 0x0010FEDC
		public int Nums { get; set; }

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x00111CE8 File Offset: 0x0010FEE8
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x00111CF0 File Offset: 0x0010FEF0
		public int MaxNums { get; set; }

		// Token: 0x06003C4F RID: 15439 RVA: 0x00111CFC File Offset: 0x0010FEFC
		public bool CanGenerateRandomEvent()
		{
			return this.MaxNums > this.Nums;
		}
	}
}
