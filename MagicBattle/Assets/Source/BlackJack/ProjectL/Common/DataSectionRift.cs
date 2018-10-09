using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004F7 RID: 1271
	[CustomLuaClass]
	public class DataSectionRift : DataSection
	{
		// Token: 0x06004CFC RID: 19708 RVA: 0x00179CCC File Offset: 0x00177ECC
		public DataSectionRift()
		{
			this.FinishedRiftLevelIds = new HashSet<int>();
			this.AchievementRelationIds = new HashSet<int>();
			this.Chapters = new Dictionary<int, RiftChapter>();
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00179CF8 File Offset: 0x00177EF8
		public override void ClearInitedData()
		{
			this.FinishedRiftLevelIds.Clear();
			this.AchievementRelationIds.Clear();
			this.Chapters.Clear();
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x00179D1C File Offset: 0x00177F1C
		public override object SerializeToClient()
		{
			DSRiftNtf dsriftNtf = new DSRiftNtf();
			dsriftNtf.Version = (uint)base.Version;
			foreach (int item in this.AchievementRelationIds)
			{
				dsriftNtf.AchievementRelationIds.Add(item);
			}
			foreach (KeyValuePair<int, RiftChapter> keyValuePair in this.Chapters)
			{
				dsriftNtf.RiftChapters.Add(RiftChapter.RiftChapterToPBRiftChapter(keyValuePair.Value));
			}
			return dsriftNtf;
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00179DEC File Offset: 0x00177FEC
		public void InitLevel(int chapterId, int levelId, int nums, int stars)
		{
			RiftChapter chapter;
			if (this.Chapters.TryGetValue(chapterId, out chapter))
			{
				this.InitLevel(chapter, levelId, nums, stars);
			}
			else
			{
				chapter = this.AddChapter(chapterId);
				this.InitLevel(chapter, levelId, nums, stars);
			}
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00179E30 File Offset: 0x00178030
		public RiftChapter FindChapter(int chapterId)
		{
			RiftChapter result;
			this.Chapters.TryGetValue(chapterId, out result);
			return result;
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00179E50 File Offset: 0x00178050
		public RiftChapter AddChapter(int chapterId)
		{
			RiftChapter riftChapter = new RiftChapter();
			this.Chapters.Add(chapterId, riftChapter);
			return riftChapter;
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x00179E74 File Offset: 0x00178074
		public RiftLevel FindLevel(int chapterId, int levelId)
		{
			RiftChapter chapter;
			if (!this.Chapters.TryGetValue(chapterId, out chapter))
			{
				return null;
			}
			return this.FindLevel(chapter, levelId);
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00179EA0 File Offset: 0x001780A0
		public RiftLevel FindLevel(RiftChapter chapter, int levelId)
		{
			return chapter.ChapterLevels.Find((RiftLevel m) => m.LevelId == levelId);
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00179ED4 File Offset: 0x001780D4
		public void AddLevel(RiftChapter chapter, int levelId, int nums, int stars)
		{
			chapter.ChapterLevels.Add(new RiftLevel(levelId, nums, stars));
			if (stars > 0)
			{
				this.FinishedRiftLevelIds.Add(levelId);
			}
			base.SetDirty(true);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x00179F08 File Offset: 0x00178108
		private void InitLevel(RiftChapter chapter, int levelId, int nums, int stars)
		{
			chapter.ChapterLevels.Add(new RiftLevel(levelId, nums, stars));
			if (stars > 0)
			{
				this.FinishedRiftLevelIds.Add(levelId);
			}
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00179F34 File Offset: 0x00178134
		public void AddLevelChallengeNums(RiftLevel riftLevel, int nums)
		{
			riftLevel.Nums += nums;
			base.SetDirty(true);
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00179F4C File Offset: 0x0017814C
		public int GetLevelChallengeNums(RiftLevel riftLevel)
		{
			return riftLevel.Nums;
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00179F54 File Offset: 0x00178154
		public void ResetLevelChallengeNums()
		{
			foreach (KeyValuePair<int, RiftChapter> keyValuePair in this.Chapters)
			{
				foreach (RiftLevel riftLevel in keyValuePair.Value.ChapterLevels)
				{
					riftLevel.Nums = 0;
				}
			}
			base.SetDirty(true);
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x0017A004 File Offset: 0x00178204
		public bool HasGotAchievementRelationId(int achievementId)
		{
			return this.AchievementRelationIds.Contains(achievementId);
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x0017A014 File Offset: 0x00178214
		public void AddAchievementRelationId(int achievementId, DateTime currTime)
		{
			if (this.AchievementRelationIds.Add(achievementId))
			{
				this.AchievementUpdateTime = currTime;
				base.SetDirty(true);
			}
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x0017A038 File Offset: 0x00178238
		public void InitAchievementRelationIds(List<int> achievementRelationIds, DateTime updateTime, int lastRiftAchievment)
		{
			foreach (int item in achievementRelationIds)
			{
				this.AchievementRelationIds.Add(item);
			}
			this.AchievementUpdateTime = updateTime;
			this.LastRiftAchievementRank = lastRiftAchievment;
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x0017A0A4 File Offset: 0x001782A4
		public void InitAllChapterStar(DateTime updateTime, int lastRiftStars, DateTime lastRiftRankUpdateTime)
		{
			this.RiftChaptersStarUpdateTime = updateTime;
			this.LastRiftStarsRank = lastRiftStars;
			this.LastRiftRankUpdateTime = lastRiftRankUpdateTime;
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x0017A0BC File Offset: 0x001782BC
		public void SetChapterStarReward(int chapterId, int index)
		{
			this.Chapters[chapterId].StarRewardIndexes.Add(index);
			base.SetDirty(true);
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x0017A0DC File Offset: 0x001782DC
		public bool IsGainChapterStarReward(int chapterId, int index)
		{
			return this.Chapters[chapterId].StarRewardIndexes.Contains(index);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x0017A0F8 File Offset: 0x001782F8
		public void AddChapterStarReward(int chapterId, int index)
		{
			RiftChapter riftChapter;
			if (!this.Chapters.TryGetValue(chapterId, out riftChapter))
			{
				riftChapter = new RiftChapter();
				this.Chapters.Add(chapterId, riftChapter);
			}
			riftChapter.StarRewardIndexes.Add(index);
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x0017A138 File Offset: 0x00178338
		public int GetChapterTotalStars(int chapterId)
		{
			RiftChapter riftChapter;
			if (!this.Chapters.TryGetValue(chapterId, out riftChapter))
			{
				return 0;
			}
			return riftChapter.TotalStars;
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x0017A160 File Offset: 0x00178360
		public int GetAllRiftLevelStars()
		{
			int num = 0;
			foreach (KeyValuePair<int, RiftChapter> keyValuePair in this.Chapters)
			{
				num += this.GetChapterTotalStars(keyValuePair.Key);
			}
			return num;
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x0017A1C8 File Offset: 0x001783C8
		// (set) Token: 0x06004D13 RID: 19731 RVA: 0x0017A1D0 File Offset: 0x001783D0
		public HashSet<int> FinishedRiftLevelIds { get; set; }

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x0017A1DC File Offset: 0x001783DC
		// (set) Token: 0x06004D15 RID: 19733 RVA: 0x0017A1E4 File Offset: 0x001783E4
		public HashSet<int> AchievementRelationIds { get; set; }

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x0017A1F0 File Offset: 0x001783F0
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x0017A1F8 File Offset: 0x001783F8
		public DateTime AchievementUpdateTime { get; set; }

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x0017A204 File Offset: 0x00178404
		// (set) Token: 0x06004D19 RID: 19737 RVA: 0x0017A20C File Offset: 0x0017840C
		public int LastRiftAchievementRank { get; set; }

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x0017A218 File Offset: 0x00178418
		// (set) Token: 0x06004D1B RID: 19739 RVA: 0x0017A220 File Offset: 0x00178420
		public Dictionary<int, RiftChapter> Chapters { get; set; }

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x0017A22C File Offset: 0x0017842C
		public int RiftStars
		{
			get
			{
				return this.GetAllRiftLevelStars();
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x0017A234 File Offset: 0x00178434
		// (set) Token: 0x06004D1E RID: 19742 RVA: 0x0017A23C File Offset: 0x0017843C
		public DateTime RiftChaptersStarUpdateTime { get; set; }

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06004D1F RID: 19743 RVA: 0x0017A248 File Offset: 0x00178448
		// (set) Token: 0x06004D20 RID: 19744 RVA: 0x0017A250 File Offset: 0x00178450
		public int LastRiftStarsRank { get; set; }

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x0017A25C File Offset: 0x0017845C
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x0017A264 File Offset: 0x00178464
		public DateTime LastRiftRankUpdateTime { get; set; }
	}
}
