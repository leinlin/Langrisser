using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003EF RID: 1007
	public enum WayPointStatus
	{
		// Token: 0x04002D4D RID: 11597
		None,
		// Token: 0x04002D4E RID: 11598
		Close,
		// Token: 0x04002D4F RID: 11599
		Open,
		// Token: 0x04002D50 RID: 11600
		Public = 4,
		// Token: 0x04002D51 RID: 11601
		Arrived = 8,
		// Token: 0x04002D52 RID: 11602
		NormalEvent = 16,
		// Token: 0x04002D53 RID: 11603
		RandomEvent = 32
	}
}
