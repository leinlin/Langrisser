using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001276 RID: 4726
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RiftComponentCommon : LuaObject
{
	// Token: 0x06018A06 RID: 100870 RVA: 0x006F1A20 File Offset: 0x006EFC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon o = new RiftComponentCommon();
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

	// Token: 0x06018A07 RID: 100871 RVA: 0x006F1A68 File Offset: 0x006EFC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			string name = riftComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A08 RID: 100872 RVA: 0x006F1ABC File Offset: 0x006EFCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			riftComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A09 RID: 100873 RVA: 0x006F1B08 File Offset: 0x006EFD08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			riftComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A0A RID: 100874 RVA: 0x006F1B54 File Offset: 0x006EFD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			riftComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A0B RID: 100875 RVA: 0x006F1BA0 File Offset: 0x006EFDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			riftComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A0C RID: 100876 RVA: 0x006F1BF8 File Offset: 0x006EFDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			riftComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A0D RID: 100877 RVA: 0x006F1C44 File Offset: 0x006EFE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int num;
			LuaObject.checkType(l, 3, out num);
			riftComponentCommon.AddChallengeNums(levelInfo, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A0E RID: 100878 RVA: 0x006F1CA8 File Offset: 0x006EFEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			riftComponentCommon.ResetLevelChallengeNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A0F RID: 100879 RVA: 0x006F1CF4 File Offset: 0x006EFEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllRiftLevelAchievements(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> allRiftLevelAchievements = riftComponentCommon.GetAllRiftLevelAchievements();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allRiftLevelAchievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A10 RID: 100880 RVA: 0x006F1D48 File Offset: 0x006EFF48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = riftComponentCommon.AttackLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A11 RID: 100881 RVA: 0x006F1DAC File Offset: 0x006EFFAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = riftComponentCommon.CanAttackLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A12 RID: 100882 RVA: 0x006F1E10 File Offset: 0x006F0010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFirstPassLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = riftComponentCommon.IsFirstPassLevel(levelId);
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

	// Token: 0x06018A13 RID: 100883 RVA: 0x006F1E74 File Offset: 0x006F0074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = riftComponentCommon.IsLevelFinished(levelId);
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

	// Token: 0x06018A14 RID: 100884 RVA: 0x006F1ED8 File Offset: 0x006F00D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAddRandomDropRewardExpectedSize(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int randomDropId;
			LuaObject.checkType(l, 2, out randomDropId);
			int addRandomDropRewardExpectedSize = riftComponentCommon.GetAddRandomDropRewardExpectedSize(randomDropId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, addRandomDropRewardExpectedSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A15 RID: 100885 RVA: 0x006F1F3C File Offset: 0x006F013C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUnLockLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			int i = riftComponentCommon.CanUnLockLevel(riftLevelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A16 RID: 100886 RVA: 0x006F1FA0 File Offset: 0x006F01A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRiftLevelCanChallengeMaxNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int riftLevelCanChallengeMaxNums = riftComponentCommon.GetRiftLevelCanChallengeMaxNums(levelInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelCanChallengeMaxNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A17 RID: 100887 RVA: 0x006F2004 File Offset: 0x006F0204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanRaidLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int i = riftComponentCommon.CanRaidLevel(levelInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A18 RID: 100888 RVA: 0x006F2068 File Offset: 0x006F0268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompleteAchievement(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int achievementRelationId;
			LuaObject.checkType(l, 2, out achievementRelationId);
			riftComponentCommon.CompleteAchievement(achievementRelationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A19 RID: 100889 RVA: 0x006F20C0 File Offset: 0x006F02C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			List<int> newAchievementIds;
			LuaObject.checkType<List<int>>(l, 3, out newAchievementIds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			riftComponentCommon.SetSuccessRiftLevel(riftLevelInfo, newAchievementIds, stars, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A1A RID: 100890 RVA: 0x006F2140 File Offset: 0x006F0340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGotAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int achievementId;
			LuaObject.checkType(l, 2, out achievementId);
			bool b = riftComponentCommon.HasGotAchievementRelationId(achievementId);
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

	// Token: 0x06018A1B RID: 100891 RVA: 0x006F21A4 File Offset: 0x006F03A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetChapterTotalStars(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int chapterTotalStars = riftComponentCommon.GetChapterTotalStars(chapterId);
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

	// Token: 0x06018A1C RID: 100892 RVA: 0x006F2208 File Offset: 0x006F0408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllRiftLevelStars(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int allRiftLevelStars = riftComponentCommon.GetAllRiftLevelStars();
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

	// Token: 0x06018A1D RID: 100893 RVA: 0x006F225C File Offset: 0x006F045C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFlushChallengeCountEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			riftComponentCommon.m_luaExportHelper.OnFlushChallengeCountEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A1E RID: 100894 RVA: 0x006F22B0 File Offset: 0x006F04B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			int stars;
			LuaObject.checkType(l, 5, out stars);
			bool needAddStar;
			LuaObject.checkType(l, 6, out needAddStar);
			riftComponentCommon.m_luaExportHelper.SetLevel(chapterId, levelId, nums, stars, needAddStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A1F RID: 100895 RVA: 0x006F2340 File Offset: 0x006F0540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChapterTotalStar(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			RiftChapter chapter;
			LuaObject.checkType<RiftChapter>(l, 2, out chapter);
			int addStar;
			LuaObject.checkType(l, 3, out addStar);
			riftComponentCommon.m_luaExportHelper.AddChapterTotalStar(chapter, addStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A20 RID: 100896 RVA: 0x006F23AC File Offset: 0x006F05AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			bool b = riftComponentCommon.m_luaExportHelper.IsGameFunctionOpened();
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

	// Token: 0x06018A21 RID: 100897 RVA: 0x006F2408 File Offset: 0x006F0608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			bool isRaid;
			LuaObject.checkType(l, 3, out isRaid);
			int i = riftComponentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo, isRaid);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A22 RID: 100898 RVA: 0x006F247C File Offset: 0x006F067C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnoughAttackNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			bool b = riftComponentCommon.m_luaExportHelper.IsEnoughAttackNums(levelInfo, nums);
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

	// Token: 0x06018A23 RID: 100899 RVA: 0x006F24F0 File Offset: 0x006F06F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRiftLevelBasicRewards(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			bool isRaid;
			LuaObject.checkType(l, 3, out isRaid);
			riftComponentCommon.m_luaExportHelper.AddRiftLevelBasicRewards(riftLevelInfo, isRaid);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A24 RID: 100900 RVA: 0x006F255C File Offset: 0x006F075C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRaidSuccessRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo raidSuccessRiftLevel;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out raidSuccessRiftLevel);
			riftComponentCommon.m_luaExportHelper.SetRaidSuccessRiftLevel(raidSuccessRiftLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A25 RID: 100901 RVA: 0x006F25B8 File Offset: 0x006F07B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetChapterRewards(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> chapterRewards = riftComponentCommon.m_luaExportHelper.GetChapterRewards(chapterInfo, index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chapterRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A26 RID: 100902 RVA: 0x006F262C File Offset: 0x006F082C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainChapterReward(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 4, out rewards);
			int i = riftComponentCommon.m_luaExportHelper.CanGainChapterReward(chapterInfo, index, rewards);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A27 RID: 100903 RVA: 0x006F26B0 File Offset: 0x006F08B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComplteRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			riftComponentCommon.m_luaExportHelper.ComplteRiftLevel(riftLevelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A28 RID: 100904 RVA: 0x006F270C File Offset: 0x006F090C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAllRiftLevelStarAdd(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int addStar;
			LuaObject.checkType(l, 2, out addStar);
			riftComponentCommon.m_luaExportHelper.OnAllRiftLevelStarAdd(addStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A29 RID: 100905 RVA: 0x006F2768 File Offset: 0x006F0968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRiftAchivementAdd(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int addAchivement;
			LuaObject.checkType(l, 2, out addAchivement);
			riftComponentCommon.m_luaExportHelper.OnRiftAchivementAdd(addAchivement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A2A RID: 100906 RVA: 0x006F27C4 File Offset: 0x006F09C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_CompleteRiftLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			riftComponentCommon.m_luaExportHelper.__callDele_CompleteRiftLevelMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A2B RID: 100907 RVA: 0x006F283C File Offset: 0x006F0A3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_CompleteRiftLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			riftComponentCommon.m_luaExportHelper.__clearDele_CompleteRiftLevelMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A2C RID: 100908 RVA: 0x006F28B4 File Offset: 0x006F0AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_GetRiftLevelAchievementMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftComponentCommon.m_luaExportHelper.__callDele_GetRiftLevelAchievementMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A2D RID: 100909 RVA: 0x006F2910 File Offset: 0x006F0B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_GetRiftLevelAchievementMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftComponentCommon.m_luaExportHelper.__clearDele_GetRiftLevelAchievementMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A2E RID: 100910 RVA: 0x006F296C File Offset: 0x006F0B6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_GetRiftLevelFightStarMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftComponentCommon.m_luaExportHelper.__callDele_GetRiftLevelFightStarMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A2F RID: 100911 RVA: 0x006F29C8 File Offset: 0x006F0BC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_GetRiftLevelFightStarMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftComponentCommon.m_luaExportHelper.__clearDele_GetRiftLevelFightStarMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A30 RID: 100912 RVA: 0x006F2A24 File Offset: 0x006F0C24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RiftLevelCompleteEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			Action<int> action;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out action);
			if (num == 0)
			{
				riftComponentCommon.RiftLevelCompleteEvent = action;
			}
			else if (num == 1)
			{
				RiftComponentCommon riftComponentCommon2 = riftComponentCommon;
				riftComponentCommon2.RiftLevelCompleteEvent = (Action<int>)Delegate.Combine(riftComponentCommon2.RiftLevelCompleteEvent, action);
			}
			else if (num == 2)
			{
				RiftComponentCommon riftComponentCommon3 = riftComponentCommon;
				riftComponentCommon3.RiftLevelCompleteEvent = (Action<int>)Delegate.Remove(riftComponentCommon3.RiftLevelCompleteEvent, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A31 RID: 100913 RVA: 0x006F2ACC File Offset: 0x006F0CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A32 RID: 100914 RVA: 0x006F2B24 File Offset: 0x006F0D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			riftComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A33 RID: 100915 RVA: 0x006F2B80 File Offset: 0x006F0D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompleteRiftLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftComponentCommon.CompleteRiftLevelMissionEvent += value;
				}
				else if (num == 2)
				{
					riftComponentCommon.CompleteRiftLevelMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A34 RID: 100916 RVA: 0x006F2C00 File Offset: 0x006F0E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetRiftLevelAchievementMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftComponentCommon.GetRiftLevelAchievementMissionEvent += value;
				}
				else if (num == 2)
				{
					riftComponentCommon.GetRiftLevelAchievementMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A35 RID: 100917 RVA: 0x006F2C80 File Offset: 0x006F0E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GetRiftLevelFightStarMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftComponentCommon.GetRiftLevelFightStarMissionEvent += value;
				}
				else if (num == 2)
				{
					riftComponentCommon.GetRiftLevelFightStarMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A36 RID: 100918 RVA: 0x006F2D00 File Offset: 0x006F0F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A37 RID: 100919 RVA: 0x006F2D58 File Offset: 0x006F0F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			riftComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A38 RID: 100920 RVA: 0x006F2DB4 File Offset: 0x006F0FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_level(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A39 RID: 100921 RVA: 0x006F2E0C File Offset: 0x006F100C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_level(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LevelComponentCommon level;
			LuaObject.checkType<LevelComponentCommon>(l, 2, out level);
			riftComponentCommon.m_luaExportHelper.m_level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A3A RID: 100922 RVA: 0x006F2E68 File Offset: 0x006F1068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A3B RID: 100923 RVA: 0x006F2EC0 File Offset: 0x006F10C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			riftComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A3C RID: 100924 RVA: 0x006F2F1C File Offset: 0x006F111C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A3D RID: 100925 RVA: 0x006F2F74 File Offset: 0x006F1174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			riftComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A3E RID: 100926 RVA: 0x006F2FD0 File Offset: 0x006F11D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A3F RID: 100927 RVA: 0x006F3028 File Offset: 0x006F1228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			riftComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A40 RID: 100928 RVA: 0x006F3084 File Offset: 0x006F1284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftDS(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_luaExportHelper.m_riftDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A41 RID: 100929 RVA: 0x006F30DC File Offset: 0x006F12DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_riftDS(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			DataSectionRift riftDS;
			LuaObject.checkType<DataSectionRift>(l, 2, out riftDS);
			riftComponentCommon.m_luaExportHelper.m_riftDS = riftDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A42 RID: 100930 RVA: 0x006F3138 File Offset: 0x006F1338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.m_unLockInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A43 RID: 100931 RVA: 0x006F318C File Offset: 0x006F138C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			RiftLevelUnLockInfo unLockInfo;
			LuaObject.checkType<RiftLevelUnLockInfo>(l, 2, out unLockInfo);
			riftComponentCommon.m_unLockInfo = unLockInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A44 RID: 100932 RVA: 0x006F31E4 File Offset: 0x006F13E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A45 RID: 100933 RVA: 0x006F3238 File Offset: 0x006F1438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			riftComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A46 RID: 100934 RVA: 0x006F3290 File Offset: 0x006F1490
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.HasRewardAddRelativeOperationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A47 RID: 100935 RVA: 0x006F32E4 File Offset: 0x006F14E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			bool hasRewardAddRelativeOperationalActivity;
			LuaObject.checkType(l, 2, out hasRewardAddRelativeOperationalActivity);
			riftComponentCommon.HasRewardAddRelativeOperationalActivity = hasRewardAddRelativeOperationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A48 RID: 100936 RVA: 0x006F333C File Offset: 0x006F153C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityChanllengenumsAdd(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftComponentCommon.OperationalActivityChanllengenumsAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A49 RID: 100937 RVA: 0x006F3390 File Offset: 0x006F1590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationalActivityChanllengenumsAdd(IntPtr l)
	{
		int result;
		try
		{
			RiftComponentCommon riftComponentCommon = (RiftComponentCommon)LuaObject.checkSelf(l);
			int operationalActivityChanllengenumsAdd;
			LuaObject.checkType(l, 2, out operationalActivityChanllengenumsAdd);
			riftComponentCommon.OperationalActivityChanllengenumsAdd = operationalActivityChanllengenumsAdd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A4A RID: 100938 RVA: 0x006F33E8 File Offset: 0x006F15E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RiftComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.AddChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.ResetLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetAllRiftLevelAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.AttackLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.CanAttackLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.IsFirstPassLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetAddRandomDropRewardExpectedSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.CanUnLockLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetRiftLevelCanChallengeMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.CanRaidLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.CompleteAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.SetSuccessRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.HasGotAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetChapterTotalStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetAllRiftLevelStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.OnFlushChallengeCountEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.AddChapterTotalStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.IsEnoughAttackNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.AddRiftLevelBasicRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.SetRaidSuccessRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.GetChapterRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.CanGainChapterReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.ComplteRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.OnAllRiftLevelStarAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.OnRiftAchivementAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.__callDele_CompleteRiftLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.__clearDele_CompleteRiftLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.__callDele_GetRiftLevelAchievementMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.__clearDele_GetRiftLevelAchievementMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.__callDele_GetRiftLevelFightStarMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.__clearDele_GetRiftLevelFightStarMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache28);
		string name = "RiftLevelCompleteEvent";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_RiftLevelCompleteEvent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache29, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2B, true);
		string name3 = "CompleteRiftLevelMissionEvent";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_CompleteRiftLevelMissionEvent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2C, true);
		string name4 = "GetRiftLevelAchievementMissionEvent";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_GetRiftLevelAchievementMissionEvent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2D, true);
		string name5 = "GetRiftLevelFightStarMissionEvent";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_GetRiftLevelFightStarMissionEvent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2E, true);
		string name6 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache30, true);
		string name7 = "m_level";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_level);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_level);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache32, true);
		string name8 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_hero);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache34, true);
		string name9 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_bag);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache36, true);
		string name10 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_battle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache38, true);
		string name11 = "m_riftDS";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_riftDS);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_riftDS);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3A, true);
		string name12 = "m_unLockInfo";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_m_unLockInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_m_unLockInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3C, true);
		string name13 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_Owner);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3E, true);
		string name14 = "HasRewardAddRelativeOperationalActivity";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_HasRewardAddRelativeOperationalActivity);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_HasRewardAddRelativeOperationalActivity);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache40, true);
		string name15 = "OperationalActivityChanllengenumsAdd";
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.get_OperationalActivityChanllengenumsAdd);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.set_OperationalActivityChanllengenumsAdd);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache42, true);
		if (Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RiftComponentCommon.<>f__mg$cache43, typeof(RiftComponentCommon));
	}

	// Token: 0x0400EEFC RID: 61180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EEFD RID: 61181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EEFE RID: 61182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EEFF RID: 61183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF00 RID: 61184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF01 RID: 61185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF02 RID: 61186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EF03 RID: 61187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EF04 RID: 61188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EF05 RID: 61189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EF06 RID: 61190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EF07 RID: 61191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EF08 RID: 61192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EF09 RID: 61193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EF0A RID: 61194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EF0B RID: 61195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EF0C RID: 61196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EF0D RID: 61197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EF0E RID: 61198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EF0F RID: 61199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EF10 RID: 61200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EF11 RID: 61201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EF12 RID: 61202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EF13 RID: 61203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EF14 RID: 61204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EF15 RID: 61205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EF16 RID: 61206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EF17 RID: 61207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EF18 RID: 61208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EF19 RID: 61209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EF1A RID: 61210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EF1B RID: 61211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EF1C RID: 61212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EF1D RID: 61213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EF1E RID: 61214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EF1F RID: 61215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EF20 RID: 61216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EF21 RID: 61217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EF22 RID: 61218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EF23 RID: 61219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EF24 RID: 61220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EF25 RID: 61221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EF26 RID: 61222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EF27 RID: 61223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400EF28 RID: 61224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400EF29 RID: 61225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400EF2A RID: 61226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400EF2B RID: 61227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400EF2C RID: 61228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400EF2D RID: 61229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400EF2E RID: 61230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400EF2F RID: 61231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400EF30 RID: 61232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400EF31 RID: 61233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400EF32 RID: 61234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400EF33 RID: 61235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400EF34 RID: 61236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400EF35 RID: 61237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400EF36 RID: 61238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400EF37 RID: 61239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400EF38 RID: 61240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400EF39 RID: 61241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400EF3A RID: 61242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400EF3B RID: 61243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400EF3C RID: 61244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400EF3D RID: 61245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400EF3E RID: 61246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400EF3F RID: 61247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;
}
