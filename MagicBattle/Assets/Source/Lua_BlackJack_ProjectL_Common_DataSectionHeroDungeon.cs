using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001201 RID: 4609
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon : LuaObject
{
	// Token: 0x06017E8D RID: 97933 RVA: 0x0069C44C File Offset: 0x0069A64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon o = new DataSectionHeroDungeon();
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

	// Token: 0x06017E8E RID: 97934 RVA: 0x0069C494 File Offset: 0x0069A694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			dataSectionHeroDungeon.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E8F RID: 97935 RVA: 0x0069C4E0 File Offset: 0x0069A6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			object o = dataSectionHeroDungeon.SerializeToClient();
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

	// Token: 0x06017E90 RID: 97936 RVA: 0x0069C534 File Offset: 0x0069A734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindChapter(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			HeroDungeonChapter o = dataSectionHeroDungeon.FindChapter(chapterId);
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

	// Token: 0x06017E91 RID: 97937 RVA: 0x0069C598 File Offset: 0x0069A798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			HeroDungeonLevel o = dataSectionHeroDungeon.FindLevel(chapterId, levelId);
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

	// Token: 0x06017E92 RID: 97938 RVA: 0x0069C608 File Offset: 0x0069A808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			dataSectionHeroDungeon.ResetLevelChallengeNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E93 RID: 97939 RVA: 0x0069C654 File Offset: 0x0069A854
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			HeroDungeonChapter chapter;
			LuaObject.checkType<HeroDungeonChapter>(l, 2, out chapter);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			dataSectionHeroDungeon.InitLevel(chapter, levelId, stars, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E94 RID: 97940 RVA: 0x0069C6D4 File Offset: 0x0069A8D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			dataSectionHeroDungeon.FinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E95 RID: 97941 RVA: 0x0069C72C File Offset: 0x0069A92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			HeroDungeonChapter chapter;
			LuaObject.checkType<HeroDungeonChapter>(l, 2, out chapter);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			dataSectionHeroDungeon.AddLevel(chapter, levelId, stars, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E96 RID: 97942 RVA: 0x0069C7AC File Offset: 0x0069A9AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChapter(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			HeroDungeonChapter o = dataSectionHeroDungeon.AddChapter(chapterId);
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

	// Token: 0x06017E97 RID: 97943 RVA: 0x0069C810 File Offset: 0x0069AA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChapteStarRewardIndexes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			List<int> starRewardIndexes;
			LuaObject.checkType<List<int>>(l, 3, out starRewardIndexes);
			dataSectionHeroDungeon.InitChapteStarRewardIndexes(chapterId, starRewardIndexes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E98 RID: 97944 RVA: 0x0069C874 File Offset: 0x0069AA74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChapterStarRewardIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			HeroDungeonChapter chapter;
			LuaObject.checkType<HeroDungeonChapter>(l, 2, out chapter);
			int index;
			LuaObject.checkType(l, 3, out index);
			dataSectionHeroDungeon.AddChapterStarRewardIndex(chapter, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E99 RID: 97945 RVA: 0x0069C8D8 File Offset: 0x0069AAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = dataSectionHeroDungeon.IsFinishedLevel(levelId);
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

	// Token: 0x06017E9A RID: 97946 RVA: 0x0069C93C File Offset: 0x0069AB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGotAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int achievementId;
			LuaObject.checkType(l, 2, out achievementId);
			bool b = dataSectionHeroDungeon.HasGotAchievementRelationId(achievementId);
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

	// Token: 0x06017E9B RID: 97947 RVA: 0x0069C9A0 File Offset: 0x0069ABA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int achievementRelationId;
			LuaObject.checkType(l, 2, out achievementRelationId);
			dataSectionHeroDungeon.AddAchievementRelationId(achievementRelationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E9C RID: 97948 RVA: 0x0069C9F8 File Offset: 0x0069ABF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			List<int> achievementIds;
			LuaObject.checkType<List<int>>(l, 2, out achievementIds);
			dataSectionHeroDungeon.InitAchievementRelationIds(achievementIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E9D RID: 97949 RVA: 0x0069CA50 File Offset: 0x0069AC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroDungeonLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			HeroDungeonLevel level;
			LuaObject.checkType<HeroDungeonLevel>(l, 2, out level);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionHeroDungeon.AddHeroDungeonLevelChallengeNums(level, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E9E RID: 97950 RVA: 0x0069CAB4 File Offset: 0x0069ACB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDailyChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionHeroDungeon.InitDailyChallengeNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E9F RID: 97951 RVA: 0x0069CB0C File Offset: 0x0069AD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int dailyChallengeNums;
			LuaObject.checkType(l, 2, out dailyChallengeNums);
			dataSectionHeroDungeon.SetDailyChallengeNums(dailyChallengeNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA0 RID: 97952 RVA: 0x0069CB64 File Offset: 0x0069AD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDailyChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionHeroDungeon.AddDailyChallengeNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA1 RID: 97953 RVA: 0x0069CBBC File Offset: 0x0069ADBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DailyChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroDungeon.DailyChallengeNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA2 RID: 97954 RVA: 0x0069CC10 File Offset: 0x0069AE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroDungeon.FinishedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA3 RID: 97955 RVA: 0x0069CC64 File Offset: 0x0069AE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			HashSet<int> finishedLevels;
			LuaObject.checkType<HashSet<int>>(l, 2, out finishedLevels);
			dataSectionHeroDungeon.FinishedLevels = finishedLevels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA4 RID: 97956 RVA: 0x0069CCBC File Offset: 0x0069AEBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroDungeon.AchievementRelationIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA5 RID: 97957 RVA: 0x0069CD10 File Offset: 0x0069AF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			HashSet<int> achievementRelationIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out achievementRelationIds);
			dataSectionHeroDungeon.AchievementRelationIds = achievementRelationIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA6 RID: 97958 RVA: 0x0069CD68 File Offset: 0x0069AF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Chapters(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroDungeon.Chapters);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA7 RID: 97959 RVA: 0x0069CDBC File Offset: 0x0069AFBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Chapters(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroDungeon dataSectionHeroDungeon = (DataSectionHeroDungeon)LuaObject.checkSelf(l);
			Dictionary<int, HeroDungeonChapter> chapters;
			LuaObject.checkType<Dictionary<int, HeroDungeonChapter>>(l, 2, out chapters);
			dataSectionHeroDungeon.Chapters = chapters;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EA8 RID: 97960 RVA: 0x0069CE14 File Offset: 0x0069B014
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionHeroDungeon");
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.FindChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.FindLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.ResetLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.InitLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.FinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.AddLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.AddChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.InitChapteStarRewardIndexes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.AddChapterStarRewardIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.IsFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.HasGotAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.AddAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.InitAchievementRelationIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.AddHeroDungeonLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.InitDailyChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.SetDailyChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.AddDailyChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache12);
		string name = "DailyChallengeNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.get_DailyChallengeNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache13, null, true);
		string name2 = "FinishedLevels";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.get_FinishedLevels);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.set_FinishedLevels);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache15, true);
		string name3 = "AchievementRelationIds";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.get_AchievementRelationIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.set_AchievementRelationIds);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache17, true);
		string name4 = "Chapters";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.get_Chapters);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.set_Chapters);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache19, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.<>f__mg$cache1A, typeof(DataSectionHeroDungeon), typeof(DataSection));
	}

	// Token: 0x0400E46D RID: 58477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E46E RID: 58478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E46F RID: 58479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E470 RID: 58480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E471 RID: 58481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E472 RID: 58482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E473 RID: 58483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E474 RID: 58484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E475 RID: 58485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E476 RID: 58486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E477 RID: 58487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E478 RID: 58488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E479 RID: 58489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E47A RID: 58490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E47B RID: 58491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E47C RID: 58492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E47D RID: 58493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E47E RID: 58494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E47F RID: 58495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E480 RID: 58496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E481 RID: 58497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E482 RID: 58498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E483 RID: 58499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E484 RID: 58500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E485 RID: 58501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E486 RID: 58502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E487 RID: 58503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
