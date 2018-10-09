using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004DA RID: 1242
	[CustomLuaClass]
	public class DataSectionHeroDungeon : DataSection
	{
		// Token: 0x06004B9B RID: 19355 RVA: 0x00176AFC File Offset: 0x00174CFC
		public DataSectionHeroDungeon()
		{
			this.FinishedLevels = new HashSet<int>();
			this.AchievementRelationIds = new HashSet<int>();
			this.Chapters = new Dictionary<int, HeroDungeonChapter>();
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00176B28 File Offset: 0x00174D28
		public override void ClearInitedData()
		{
			this.FinishedLevels.Clear();
			this.AchievementRelationIds.Clear();
			this.Chapters.Clear();
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x00176B4C File Offset: 0x00174D4C
		public override object SerializeToClient()
		{
			DSHeroDungeonNtf dsheroDungeonNtf = new DSHeroDungeonNtf();
			dsheroDungeonNtf.AchievementRelationIds.AddRange(this.AchievementRelationIds);
			foreach (HeroDungeonChapter chapter in this.Chapters.Values)
			{
				dsheroDungeonNtf.Chapters.Add(HeroDungeonChapter.ToPBChapter(chapter));
			}
			dsheroDungeonNtf.Version = (uint)base.Version;
			dsheroDungeonNtf.DailyChallengeNums = this.m_dailyChallengeNums;
			return dsheroDungeonNtf;
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00176BE8 File Offset: 0x00174DE8
		public HeroDungeonChapter FindChapter(int chapterId)
		{
			HeroDungeonChapter result = null;
			this.Chapters.TryGetValue(chapterId, out result);
			return result;
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00176C08 File Offset: 0x00174E08
		public HeroDungeonLevel FindLevel(int chapterId, int levelId)
		{
			HeroDungeonChapter heroDungeonChapter = this.FindChapter(chapterId);
			if (heroDungeonChapter == null)
			{
				return null;
			}
			return heroDungeonChapter.ChapterLevels.Find((HeroDungeonLevel t) => t.LevelId == levelId);
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x00176C4C File Offset: 0x00174E4C
		public void ResetLevelChallengeNums()
		{
			foreach (HeroDungeonChapter heroDungeonChapter in this.Chapters.Values)
			{
				foreach (HeroDungeonLevel heroDungeonLevel in heroDungeonChapter.ChapterLevels)
				{
					heroDungeonLevel.Nums = 0;
				}
			}
			base.SetDirty(true);
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x00176CF8 File Offset: 0x00174EF8
		public void InitLevel(HeroDungeonChapter chapter, int levelId, int stars, int nums)
		{
			chapter.ChapterLevels.Add(new HeroDungeonLevel
			{
				LevelId = levelId,
				Stars = stars,
				Nums = nums
			});
			if (stars > 0)
			{
				chapter.TotalStars += stars;
				this.FinishedLevel(levelId);
			}
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x00176D4C File Offset: 0x00174F4C
		public void FinishedLevel(int levelId)
		{
			this.FinishedLevels.Add(levelId);
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x00176D5C File Offset: 0x00174F5C
		public void AddLevel(HeroDungeonChapter chapter, int levelId, int stars, int nums)
		{
			this.InitLevel(chapter, levelId, stars, nums);
			base.SetDirty(true);
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x00176D70 File Offset: 0x00174F70
		public HeroDungeonChapter AddChapter(int chapterId)
		{
			HeroDungeonChapter heroDungeonChapter = new HeroDungeonChapter
			{
				ChapterId = chapterId
			};
			this.Chapters.Add(chapterId, heroDungeonChapter);
			return heroDungeonChapter;
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x00176D9C File Offset: 0x00174F9C
		public void InitChapteStarRewardIndexes(int chapterId, List<int> starRewardIndexes)
		{
			HeroDungeonChapter heroDungeonChapter = this.FindChapter(chapterId);
			if (heroDungeonChapter == null)
			{
				heroDungeonChapter = this.AddChapter(chapterId);
			}
			heroDungeonChapter.StarRewardIndexes.AddRange(starRewardIndexes);
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x00176DCC File Offset: 0x00174FCC
		public void AddChapterStarRewardIndex(HeroDungeonChapter chapter, int index)
		{
			chapter.StarRewardIndexes.Add(index);
			base.SetDirty(true);
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x00176DE4 File Offset: 0x00174FE4
		public bool IsFinishedLevel(int levelId)
		{
			return this.FinishedLevels.Contains(levelId);
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x00176DF4 File Offset: 0x00174FF4
		public bool HasGotAchievementRelationId(int achievementId)
		{
			return this.AchievementRelationIds.Contains(achievementId);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x00176E04 File Offset: 0x00175004
		public void AddAchievementRelationId(int achievementRelationId)
		{
			if (this.AchievementRelationIds.Add(achievementRelationId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x00176E20 File Offset: 0x00175020
		public void InitAchievementRelationIds(List<int> achievementIds)
		{
			foreach (int item in achievementIds)
			{
				this.AchievementRelationIds.Add(item);
			}
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x00176E80 File Offset: 0x00175080
		public void AddHeroDungeonLevelChallengeNums(HeroDungeonLevel level, int nums)
		{
			level.Nums += nums;
			base.SetDirty(true);
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x00176E98 File Offset: 0x00175098
		public void InitDailyChallengeNums(int nums)
		{
			this.m_dailyChallengeNums = nums;
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x00176EA4 File Offset: 0x001750A4
		public void SetDailyChallengeNums(int nums)
		{
			this.m_dailyChallengeNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00176EB4 File Offset: 0x001750B4
		public void AddDailyChallengeNums(int nums)
		{
			this.m_dailyChallengeNums += nums;
			base.SetDirty(true);
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06004BAF RID: 19375 RVA: 0x00176ECC File Offset: 0x001750CC
		public int DailyChallengeNums
		{
			get
			{
				return this.m_dailyChallengeNums;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004BB0 RID: 19376 RVA: 0x00176ED4 File Offset: 0x001750D4
		// (set) Token: 0x06004BB1 RID: 19377 RVA: 0x00176EDC File Offset: 0x001750DC
		public HashSet<int> FinishedLevels { get; set; }

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06004BB2 RID: 19378 RVA: 0x00176EE8 File Offset: 0x001750E8
		// (set) Token: 0x06004BB3 RID: 19379 RVA: 0x00176EF0 File Offset: 0x001750F0
		public HashSet<int> AchievementRelationIds { get; set; }

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x00176EFC File Offset: 0x001750FC
		// (set) Token: 0x06004BB5 RID: 19381 RVA: 0x00176F04 File Offset: 0x00175104
		public Dictionary<int, HeroDungeonChapter> Chapters { get; set; }

		// Token: 0x04003874 RID: 14452
		private int m_dailyChallengeNums;
	}
}
