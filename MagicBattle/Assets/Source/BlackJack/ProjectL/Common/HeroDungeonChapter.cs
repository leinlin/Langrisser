using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000549 RID: 1353
	[CustomLuaClass]
	public class HeroDungeonChapter
	{
		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x0017F93C File Offset: 0x0017DB3C
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x0017F944 File Offset: 0x0017DB44
		public int ChapterId { get; set; }

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x0017F950 File Offset: 0x0017DB50
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x0017F958 File Offset: 0x0017DB58
		public int TotalStars { get; set; }

		// Token: 0x06004FCF RID: 20431 RVA: 0x0017F964 File Offset: 0x0017DB64
		public static ProHeroDungeonChapter ToPBChapter(HeroDungeonChapter chapter)
		{
			ProHeroDungeonChapter proHeroDungeonChapter = new ProHeroDungeonChapter();
			proHeroDungeonChapter.ChapterId = chapter.ChapterId;
			proHeroDungeonChapter.StarRewardIndexes.AddRange(chapter.StarRewardIndexes);
			foreach (HeroDungeonLevel level in chapter.ChapterLevels)
			{
				proHeroDungeonChapter.ChapterLevels.Add(HeroDungeonLevel.ToPBLevel(level));
			}
			return proHeroDungeonChapter;
		}

		// Token: 0x040039DB RID: 14811
		public List<HeroDungeonLevel> ChapterLevels = new List<HeroDungeonLevel>();

		// Token: 0x040039DC RID: 14812
		public List<int> StarRewardIndexes = new List<int>();
	}
}
