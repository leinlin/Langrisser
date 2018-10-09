using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200053A RID: 1338
	[CustomLuaClass]
	public class DanmakuEntry
	{
		// Token: 0x06004F6A RID: 20330 RVA: 0x0017EFA8 File Offset: 0x0017D1A8
		public DanmakuEntry()
		{
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x0017EFB0 File Offset: 0x0017D1B0
		public DanmakuEntry(DanmakuEntry other)
		{
			this.UserId = other.UserId;
			this.Content = other.Content;
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06004F6C RID: 20332 RVA: 0x0017EFD0 File Offset: 0x0017D1D0
		// (set) Token: 0x06004F6D RID: 20333 RVA: 0x0017EFD8 File Offset: 0x0017D1D8
		public string UserId { get; set; }

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06004F6E RID: 20334 RVA: 0x0017EFE4 File Offset: 0x0017D1E4
		// (set) Token: 0x06004F6F RID: 20335 RVA: 0x0017EFEC File Offset: 0x0017D1EC
		public string Content { get; set; }

		// Token: 0x06004F70 RID: 20336 RVA: 0x0017EFF8 File Offset: 0x0017D1F8
		public static DanmakuEntry PBLevelDanmakuToLevelDanmaku(ProDanmakuEntry pbEntry)
		{
			return new DanmakuEntry
			{
				UserId = pbEntry.UserId,
				Content = pbEntry.Content
			};
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x0017F028 File Offset: 0x0017D228
		public static ProDanmakuEntry LevelDanmakuToPBLevelDanmaku(DanmakuEntry entry)
		{
			return new ProDanmakuEntry
			{
				UserId = entry.UserId,
				Content = entry.Content
			};
		}
	}
}
