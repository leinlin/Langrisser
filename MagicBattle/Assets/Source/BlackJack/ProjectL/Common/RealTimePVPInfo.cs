using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003E0 RID: 992
	[CustomLuaClass]
	public class RealTimePVPInfo
	{
		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x0010D730 File Offset: 0x0010B930
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x0010D738 File Offset: 0x0010B938
		public string UserId { get; set; }

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x0010D744 File Offset: 0x0010B944
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x0010D74C File Offset: 0x0010B94C
		public int Score { get; set; }

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0010D758 File Offset: 0x0010B958
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x0010D760 File Offset: 0x0010B960
		public int LocalRank { get; set; }

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x0010D76C File Offset: 0x0010B96C
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x0010D774 File Offset: 0x0010B974
		public int GlobalRank { get; set; }

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x0010D780 File Offset: 0x0010B980
		// (set) Token: 0x06003B11 RID: 15121 RVA: 0x0010D788 File Offset: 0x0010B988
		public int Dan { get; set; }

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x0010D794 File Offset: 0x0010B994
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x0010D79C File Offset: 0x0010B99C
		public bool IsBot { get; set; }
	}
}
