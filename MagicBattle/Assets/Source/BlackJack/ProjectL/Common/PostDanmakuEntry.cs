using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200053B RID: 1339
	[CustomLuaClass]
	public class PostDanmakuEntry
	{
		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x0017F060 File Offset: 0x0017D260
		// (set) Token: 0x06004F74 RID: 20340 RVA: 0x0017F068 File Offset: 0x0017D268
		public int Turn { get; set; }

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x0017F074 File Offset: 0x0017D274
		// (set) Token: 0x06004F76 RID: 20342 RVA: 0x0017F07C File Offset: 0x0017D27C
		public string Content { get; set; }

		// Token: 0x06004F77 RID: 20343 RVA: 0x0017F088 File Offset: 0x0017D288
		public static PostDanmakuEntry PBPostDanmakuEntryToPostDanmakuEntry(ProPostDanmakuEntry pbEntry)
		{
			return new PostDanmakuEntry
			{
				Turn = pbEntry.Turn,
				Content = pbEntry.Content
			};
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0017F0B8 File Offset: 0x0017D2B8
		public static ProPostDanmakuEntry PostDanmakuEntryToPBPostDanmakuEntry(PostDanmakuEntry entry)
		{
			return new ProPostDanmakuEntry
			{
				Turn = entry.Turn,
				Content = entry.Content
			};
		}
	}
}
