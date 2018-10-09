using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001210 RID: 4624
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionRift : LuaObject
{
	// Token: 0x0601800B RID: 98315 RVA: 0x006A7148 File Offset: 0x006A5348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift o = new DataSectionRift();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601800C RID: 98316 RVA: 0x006A7190 File Offset: 0x006A5390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			dataSectionRift.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601800D RID: 98317 RVA: 0x006A71DC File Offset: 0x006A53DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			object o = dataSectionRift.SerializeToClient();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601800E RID: 98318 RVA: 0x006A7230 File Offset: 0x006A5430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			int stars;
			LuaObject.checkType(l, 5, out stars);
			dataSectionRift.InitLevel(chapterId, levelId, nums, stars);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601800F RID: 98319 RVA: 0x006A72B0 File Offset: 0x006A54B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindChapter(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			RiftChapter o = dataSectionRift.FindChapter(chapterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018010 RID: 98320 RVA: 0x006A7314 File Offset: 0x006A5514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChapter(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			RiftChapter o = dataSectionRift.AddChapter(chapterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018011 RID: 98321 RVA: 0x006A7378 File Offset: 0x006A5578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindLevel(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(RiftChapter), typeof(int)))
			{
				DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
				RiftChapter chapter;
				LuaObject.checkType<RiftChapter>(l, 2, out chapter);
				int levelId;
				LuaObject.checkType(l, 3, out levelId);
				RiftLevel o = dataSectionRift.FindLevel(chapter, levelId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				DataSectionRift dataSectionRift2 = (DataSectionRift)LuaObject.checkSelf(l);
				int chapterId;
				LuaObject.checkType(l, 2, out chapterId);
				int levelId2;
				LuaObject.checkType(l, 3, out levelId2);
				RiftLevel o2 = dataSectionRift2.FindLevel(chapterId, levelId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018012 RID: 98322 RVA: 0x006A7494 File Offset: 0x006A5694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			RiftChapter chapter;
			LuaObject.checkType<RiftChapter>(l, 2, out chapter);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			int stars;
			LuaObject.checkType(l, 5, out stars);
			dataSectionRift.AddLevel(chapter, levelId, nums, stars);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018013 RID: 98323 RVA: 0x006A7514 File Offset: 0x006A5714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			RiftLevel riftLevel;
			LuaObject.checkType<RiftLevel>(l, 2, out riftLevel);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionRift.AddLevelChallengeNums(riftLevel, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018014 RID: 98324 RVA: 0x006A7578 File Offset: 0x006A5778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			RiftLevel riftLevel;
			LuaObject.checkType<RiftLevel>(l, 2, out riftLevel);
			int levelChallengeNums = dataSectionRift.GetLevelChallengeNums(riftLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelChallengeNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018015 RID: 98325 RVA: 0x006A75DC File Offset: 0x006A57DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			dataSectionRift.ResetLevelChallengeNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018016 RID: 98326 RVA: 0x006A7628 File Offset: 0x006A5828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGotAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int achievementId;
			LuaObject.checkType(l, 2, out achievementId);
			bool b = dataSectionRift.HasGotAchievementRelationId(achievementId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018017 RID: 98327 RVA: 0x006A768C File Offset: 0x006A588C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int achievementId;
			LuaObject.checkType(l, 2, out achievementId);
			DateTime currTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currTime);
			dataSectionRift.AddAchievementRelationId(achievementId, currTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018018 RID: 98328 RVA: 0x006A76F0 File Offset: 0x006A58F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			List<int> achievementRelationIds;
			LuaObject.checkType<List<int>>(l, 2, out achievementRelationIds);
			DateTime updateTime;
			LuaObject.checkValueType<DateTime>(l, 3, out updateTime);
			int lastRiftAchievment;
			LuaObject.checkType(l, 4, out lastRiftAchievment);
			dataSectionRift.InitAchievementRelationIds(achievementRelationIds, updateTime, lastRiftAchievment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018019 RID: 98329 RVA: 0x006A7764 File Offset: 0x006A5964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllChapterStar(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			DateTime updateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out updateTime);
			int lastRiftStars;
			LuaObject.checkType(l, 3, out lastRiftStars);
			DateTime lastRiftRankUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out lastRiftRankUpdateTime);
			dataSectionRift.InitAllChapterStar(updateTime, lastRiftStars, lastRiftRankUpdateTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601801A RID: 98330 RVA: 0x006A77D8 File Offset: 0x006A59D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetChapterStarReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			dataSectionRift.SetChapterStarReward(chapterId, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601801B RID: 98331 RVA: 0x006A783C File Offset: 0x006A5A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGainChapterStarReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			bool b = dataSectionRift.IsGainChapterStarReward(chapterId, index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601801C RID: 98332 RVA: 0x006A78AC File Offset: 0x006A5AAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChapterStarReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			dataSectionRift.AddChapterStarReward(chapterId, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601801D RID: 98333 RVA: 0x006A7910 File Offset: 0x006A5B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChapterTotalStars(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int chapterTotalStars = dataSectionRift.GetChapterTotalStars(chapterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chapterTotalStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601801E RID: 98334 RVA: 0x006A7974 File Offset: 0x006A5B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllRiftLevelStars(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int allRiftLevelStars = dataSectionRift.GetAllRiftLevelStars();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allRiftLevelStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601801F RID: 98335 RVA: 0x006A79C8 File Offset: 0x006A5BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FinishedRiftLevelIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.FinishedRiftLevelIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018020 RID: 98336 RVA: 0x006A7A1C File Offset: 0x006A5C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FinishedRiftLevelIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			HashSet<int> finishedRiftLevelIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out finishedRiftLevelIds);
			dataSectionRift.FinishedRiftLevelIds = finishedRiftLevelIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018021 RID: 98337 RVA: 0x006A7A74 File Offset: 0x006A5C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.AchievementRelationIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018022 RID: 98338 RVA: 0x006A7AC8 File Offset: 0x006A5CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			HashSet<int> achievementRelationIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out achievementRelationIds);
			dataSectionRift.AchievementRelationIds = achievementRelationIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018023 RID: 98339 RVA: 0x006A7B20 File Offset: 0x006A5D20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.AchievementUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018024 RID: 98340 RVA: 0x006A7B78 File Offset: 0x006A5D78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AchievementUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			DateTime achievementUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out achievementUpdateTime);
			dataSectionRift.AchievementUpdateTime = achievementUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018025 RID: 98341 RVA: 0x006A7BD0 File Offset: 0x006A5DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRiftAchievementRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.LastRiftAchievementRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018026 RID: 98342 RVA: 0x006A7C24 File Offset: 0x006A5E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastRiftAchievementRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int lastRiftAchievementRank;
			LuaObject.checkType(l, 2, out lastRiftAchievementRank);
			dataSectionRift.LastRiftAchievementRank = lastRiftAchievementRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018027 RID: 98343 RVA: 0x006A7C7C File Offset: 0x006A5E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Chapters(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.Chapters);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018028 RID: 98344 RVA: 0x006A7CD0 File Offset: 0x006A5ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Chapters(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			Dictionary<int, RiftChapter> chapters;
			LuaObject.checkType<Dictionary<int, RiftChapter>>(l, 2, out chapters);
			dataSectionRift.Chapters = chapters;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018029 RID: 98345 RVA: 0x006A7D28 File Offset: 0x006A5F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftStars(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.RiftStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601802A RID: 98346 RVA: 0x006A7D7C File Offset: 0x006A5F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftChaptersStarUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.RiftChaptersStarUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601802B RID: 98347 RVA: 0x006A7DD4 File Offset: 0x006A5FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RiftChaptersStarUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			DateTime riftChaptersStarUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out riftChaptersStarUpdateTime);
			dataSectionRift.RiftChaptersStarUpdateTime = riftChaptersStarUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601802C RID: 98348 RVA: 0x006A7E2C File Offset: 0x006A602C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRiftStarsRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.LastRiftStarsRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601802D RID: 98349 RVA: 0x006A7E80 File Offset: 0x006A6080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastRiftStarsRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			int lastRiftStarsRank;
			LuaObject.checkType(l, 2, out lastRiftStarsRank);
			dataSectionRift.LastRiftStarsRank = lastRiftStarsRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601802E RID: 98350 RVA: 0x006A7ED8 File Offset: 0x006A60D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRiftRankUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRift.LastRiftRankUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601802F RID: 98351 RVA: 0x006A7F30 File Offset: 0x006A6130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastRiftRankUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRift dataSectionRift = (DataSectionRift)LuaObject.checkSelf(l);
			DateTime lastRiftRankUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastRiftRankUpdateTime);
			dataSectionRift.LastRiftRankUpdateTime = lastRiftRankUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018030 RID: 98352 RVA: 0x006A7F88 File Offset: 0x006A6188
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionRift");
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.InitLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.FindChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.AddChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.FindLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.AddLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.AddLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.GetLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.ResetLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.HasGotAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.AddAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.InitAchievementRelationIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.InitAllChapterStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.SetChapterStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.IsGainChapterStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.AddChapterStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.GetChapterTotalStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.GetAllRiftLevelStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache12);
		string name = "FinishedRiftLevelIds";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_FinishedRiftLevelIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_FinishedRiftLevelIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache14, true);
		string name2 = "AchievementRelationIds";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_AchievementRelationIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_AchievementRelationIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache16, true);
		string name3 = "AchievementUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_AchievementUpdateTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_AchievementUpdateTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache18, true);
		string name4 = "LastRiftAchievementRank";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_LastRiftAchievementRank);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_LastRiftAchievementRank);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1A, true);
		string name5 = "Chapters";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_Chapters);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_Chapters);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1C, true);
		string name6 = "RiftStars";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_RiftStars);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1D, null, true);
		string name7 = "RiftChaptersStarUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_RiftChaptersStarUpdateTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_RiftChaptersStarUpdateTime);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache1F, true);
		string name8 = "LastRiftStarsRank";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_LastRiftStarsRank);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_LastRiftStarsRank);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache21, true);
		string name9 = "LastRiftRankUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.get_LastRiftRankUpdateTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.set_LastRiftRankUpdateTime);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache23, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRift.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionRift.<>f__mg$cache24, typeof(DataSectionRift), typeof(DataSection));
	}

	// Token: 0x0400E5CD RID: 58829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E5CE RID: 58830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E5CF RID: 58831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E5D0 RID: 58832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E5D1 RID: 58833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E5D2 RID: 58834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E5D3 RID: 58835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E5D4 RID: 58836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E5D5 RID: 58837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E5D6 RID: 58838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E5D7 RID: 58839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E5D8 RID: 58840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E5D9 RID: 58841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E5DA RID: 58842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E5DB RID: 58843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E5DC RID: 58844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E5DD RID: 58845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E5DE RID: 58846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E5DF RID: 58847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E5E0 RID: 58848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E5E1 RID: 58849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E5E2 RID: 58850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E5E3 RID: 58851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E5E4 RID: 58852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E5E5 RID: 58853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E5E6 RID: 58854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E5E7 RID: 58855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E5E8 RID: 58856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E5E9 RID: 58857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E5EA RID: 58858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E5EB RID: 58859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E5EC RID: 58860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E5ED RID: 58861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E5EE RID: 58862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E5EF RID: 58863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E5F0 RID: 58864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E5F1 RID: 58865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
