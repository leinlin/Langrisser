using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000572 RID: 1394
	[CustomLuaClass]
	public class RiftChapter
	{
		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x00182978 File Offset: 0x00180B78
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x00182980 File Offset: 0x00180B80
		public int TotalStars { get; set; }

		// Token: 0x06005114 RID: 20756 RVA: 0x0018298C File Offset: 0x00180B8C
		public static RiftChapter PBRiftChapterToRiftCHapter(ProRiftChapter pbRiftChapter)
		{
			RiftChapter riftChapter = new RiftChapter();
			foreach (ProRiftLevel pbRiftLevel in pbRiftChapter.ChapterLevels)
			{
				riftChapter.ChapterLevels.Add(RiftLevel.PBRiftLevelToRiftLevel(pbRiftLevel));
			}
			foreach (int item in pbRiftChapter.StarRewardIndexes)
			{
				riftChapter.StarRewardIndexes.Add(item);
			}
			return riftChapter;
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00182A4C File Offset: 0x00180C4C
		public static ProRiftChapter RiftChapterToPBRiftChapter(RiftChapter riftChapter)
		{
			ProRiftChapter proRiftChapter = new ProRiftChapter();
			foreach (RiftLevel riftLevel in riftChapter.ChapterLevels)
			{
				proRiftChapter.ChapterLevels.Add(RiftLevel.RiftLevelToPBRiftLevel(riftLevel));
			}
			foreach (int item in riftChapter.StarRewardIndexes)
			{
				proRiftChapter.StarRewardIndexes.Add(item);
			}
			return proRiftChapter;
		}

		// Token: 0x04003A5B RID: 14939
		public List<RiftLevel> ChapterLevels = new List<RiftLevel>();

		// Token: 0x04003A5C RID: 14940
		public List<int> StarRewardIndexes = new List<int>();
	}
}
