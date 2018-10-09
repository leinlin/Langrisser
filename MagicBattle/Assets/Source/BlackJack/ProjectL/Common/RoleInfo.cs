using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000428 RID: 1064
	[CustomLuaClass]
	public class RoleInfo
	{
		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00114EF4 File Offset: 0x001130F4
		// (set) Token: 0x06003D5C RID: 15708 RVA: 0x00114EFC File Offset: 0x001130FC
		public string UserId { get; set; }

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x00114F08 File Offset: 0x00113108
		// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00114F10 File Offset: 0x00113110
		public int ServerId { get; set; }

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00114F1C File Offset: 0x0011311C
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00114F24 File Offset: 0x00113124
		public int PlayerLevel { get; set; }

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x00114F30 File Offset: 0x00113130
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00114F38 File Offset: 0x00113138
		public int HeadIcon { get; set; }

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00114F44 File Offset: 0x00113144
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00114F4C File Offset: 0x0011314C
		public string Name { get; set; }

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00114F58 File Offset: 0x00113158
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00114F60 File Offset: 0x00113160
		public int LastLoginHours { get; set; }
	}
}
