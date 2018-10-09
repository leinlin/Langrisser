using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003F6 RID: 1014
	[CustomLuaClass]
	public class GuildMemberCacheObject
	{
		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x00110038 File Offset: 0x0010E238
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x00110040 File Offset: 0x0010E240
		public bool Dirty { get; set; }

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0011004C File Offset: 0x0010E24C
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x00110054 File Offset: 0x0010E254
		public GuildMember Member { get; set; }
	}
}
