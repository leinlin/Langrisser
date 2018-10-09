using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200123E RID: 4670
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon : LuaObject
{
	// Token: 0x06018447 RID: 99399 RVA: 0x006C6A70 File Offset: 0x006C4C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon o = new HeroDungeonComponentCommon();
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

	// Token: 0x06018448 RID: 99400 RVA: 0x006C6AB8 File Offset: 0x006C4CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			string name = heroDungeonComponentCommon.GetName();
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

	// Token: 0x06018449 RID: 99401 RVA: 0x006C6B0C File Offset: 0x006C4D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			heroDungeonComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601844A RID: 99402 RVA: 0x006C6B58 File Offset: 0x006C4D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			heroDungeonComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601844B RID: 99403 RVA: 0x006C6BA4 File Offset: 0x006C4DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			heroDungeonComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601844C RID: 99404 RVA: 0x006C6BF0 File Offset: 0x006C4DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroDungeonComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601844D RID: 99405 RVA: 0x006C6C48 File Offset: 0x006C4E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			heroDungeonComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601844E RID: 99406 RVA: 0x006C6C94 File Offset: 0x006C4E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGotAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int achievementRelationId;
			LuaObject.checkType(l, 2, out achievementRelationId);
			bool b = heroDungeonComponentCommon.HasGotAchievementRelationId(achievementRelationId);
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

	// Token: 0x0601844F RID: 99407 RVA: 0x006C6CF8 File Offset: 0x006C4EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFirstPass(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroDungeonComponentCommon.IsLevelFirstPass(levelId);
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

	// Token: 0x06018450 RID: 99408 RVA: 0x006C6D5C File Offset: 0x006C4F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroDungeonComponentCommon.IsFinishedLevel(levelId);
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

	// Token: 0x06018451 RID: 99409 RVA: 0x006C6DC0 File Offset: 0x006C4FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLevelCanChallengeMaxNums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			int levelCanChallengeMaxNums = heroDungeonComponentCommon.GetLevelCanChallengeMaxNums(levelInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelCanChallengeMaxNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018452 RID: 99410 RVA: 0x006C6E24 File Offset: 0x006C5024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDailyChallengeMaxNums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int dailyChallengeMaxNums = heroDungeonComponentCommon.GetDailyChallengeMaxNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyChallengeMaxNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018453 RID: 99411 RVA: 0x006C6E78 File Offset: 0x006C5078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			HeroDungeonLevel o = heroDungeonComponentCommon.FindLevel(chapterId, levelId);
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

	// Token: 0x06018454 RID: 99412 RVA: 0x006C6EE8 File Offset: 0x006C50E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponentCommon.AttackHeroDungeonLevel(levelId);
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

	// Token: 0x06018455 RID: 99413 RVA: 0x006C6F4C File Offset: 0x006C514C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponentCommon.CanAttackHeroDungeonLevel(levelId);
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

	// Token: 0x06018456 RID: 99414 RVA: 0x006C6FB0 File Offset: 0x006C51B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanRaidHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponentCommon.CanRaidHeroDungeonLevel(levelId);
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

	// Token: 0x06018457 RID: 99415 RVA: 0x006C7014 File Offset: 0x006C5214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUnlockHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponentCommon.CanUnlockHeroDungeonLevel(levelId);
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

	// Token: 0x06018458 RID: 99416 RVA: 0x006C7078 File Offset: 0x006C5278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroDungeonChapterStar(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int heroDungeonChapterStar = heroDungeonComponentCommon.GetHeroDungeonChapterStar(chapterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonChapterStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018459 RID: 99417 RVA: 0x006C70DC File Offset: 0x006C52DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGotChapterStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			bool b = heroDungeonComponentCommon.HasGotChapterStarReward(chapterId, index);
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

	// Token: 0x0601845A RID: 99418 RVA: 0x006C714C File Offset: 0x006C534C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int i = heroDungeonComponentCommon.CanGainHeroDungeonChapterStarRewards(chapterId, index);
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

	// Token: 0x0601845B RID: 99419 RVA: 0x006C71BC File Offset: 0x006C53BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GainHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			bool check;
			LuaObject.checkType(l, 4, out check);
			int i = heroDungeonComponentCommon.GainHeroDungeonChapterStarRewards(chapterId, index, check);
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

	// Token: 0x0601845C RID: 99420 RVA: 0x006C7238 File Offset: 0x006C5438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushLevelChallengeNumsEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			heroDungeonComponentCommon.m_luaExportHelper.OnFlushLevelChallengeNumsEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601845D RID: 99421 RVA: 0x006C728C File Offset: 0x006C548C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEnoughAttackNums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			bool b = heroDungeonComponentCommon.m_luaExportHelper.IsEnoughAttackNums(levelInfo, nums);
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

	// Token: 0x0601845E RID: 99422 RVA: 0x006C7300 File Offset: 0x006C5500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			heroDungeonComponentCommon.m_luaExportHelper.InitLevel(chapterId, levelId, stars, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601845F RID: 99423 RVA: 0x006C7384 File Offset: 0x006C5584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			heroDungeonComponentCommon.m_luaExportHelper.SetLevel(chapterId, levelId, stars, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018460 RID: 99424 RVA: 0x006C7408 File Offset: 0x006C5608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSuccessHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			List<int> newGotAchievementRelationInds;
			LuaObject.checkType<List<int>>(l, 3, out newGotAchievementRelationInds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			heroDungeonComponentCommon.m_luaExportHelper.SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018461 RID: 99425 RVA: 0x006C748C File Offset: 0x006C568C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRaidSuccessHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo raidSuccessHeroDungeonLevel;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out raidSuccessHeroDungeonLevel);
			heroDungeonComponentCommon.m_luaExportHelper.SetRaidSuccessHeroDungeonLevel(raidSuccessHeroDungeonLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018462 RID: 99426 RVA: 0x006C74E8 File Offset: 0x006C56E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			bool isRaid;
			LuaObject.checkType(l, 3, out isRaid);
			int i = heroDungeonComponentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo, isRaid);
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

	// Token: 0x06018463 RID: 99427 RVA: 0x006C755C File Offset: 0x006C575C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackLevelByRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			bool isRaid;
			LuaObject.checkType(l, 3, out isRaid);
			int i = heroDungeonComponentCommon.m_luaExportHelper.CanAttackLevelByRewards(levelInfo, isRaid);
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

	// Token: 0x06018464 RID: 99428 RVA: 0x006C75D0 File Offset: 0x006C57D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo chapterInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out chapterInfo);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> heroDungeonChapterStarRewards = heroDungeonComponentCommon.m_luaExportHelper.GetHeroDungeonChapterStarRewards(chapterInfo, index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonChapterStarRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018465 RID: 99429 RVA: 0x006C7644 File Offset: 0x006C5844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			heroDungeonComponentCommon.m_luaExportHelper.GenerateHeroDungeonChapterStarRewards(chapterId, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018466 RID: 99430 RVA: 0x006C76B0 File Offset: 0x006C58B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_CompleteHeroDungeonLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			heroDungeonComponentCommon.m_luaExportHelper.__callDele_CompleteHeroDungeonLevelMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018467 RID: 99431 RVA: 0x006C7728 File Offset: 0x006C5928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteHeroDungeonLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			heroDungeonComponentCommon.m_luaExportHelper.__clearDele_CompleteHeroDungeonLevelMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018468 RID: 99432 RVA: 0x006C77A0 File Offset: 0x006C59A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018469 RID: 99433 RVA: 0x006C77F8 File Offset: 0x006C59F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			heroDungeonComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601846A RID: 99434 RVA: 0x006C7854 File Offset: 0x006C5A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601846B RID: 99435 RVA: 0x006C78AC File Offset: 0x006C5AAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			heroDungeonComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601846C RID: 99436 RVA: 0x006C7908 File Offset: 0x006C5B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601846D RID: 99437 RVA: 0x006C7960 File Offset: 0x006C5B60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			heroDungeonComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601846E RID: 99438 RVA: 0x006C79BC File Offset: 0x006C5BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601846F RID: 99439 RVA: 0x006C7A14 File Offset: 0x006C5C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			heroDungeonComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018470 RID: 99440 RVA: 0x006C7A70 File Offset: 0x006C5C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018471 RID: 99441 RVA: 0x006C7AC8 File Offset: 0x006C5CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			heroDungeonComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018472 RID: 99442 RVA: 0x006C7B24 File Offset: 0x006C5D24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroDungeonDS(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_heroDungeonDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018473 RID: 99443 RVA: 0x006C7B7C File Offset: 0x006C5D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDungeonDS(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			DataSectionHeroDungeon heroDungeonDS;
			LuaObject.checkType<DataSectionHeroDungeon>(l, 2, out heroDungeonDS);
			heroDungeonComponentCommon.m_luaExportHelper.m_heroDungeonDS = heroDungeonDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018474 RID: 99444 RVA: 0x006C7BD8 File Offset: 0x006C5DD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018475 RID: 99445 RVA: 0x006C7C30 File Offset: 0x006C5E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDungeonComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018476 RID: 99446 RVA: 0x006C7C8C File Offset: 0x006C5E8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompleteHeroDungeonLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDungeonComponentCommon.CompleteHeroDungeonLevelMissionEvent += value;
				}
				else if (num == 2)
				{
					heroDungeonComponentCommon.CompleteHeroDungeonLevelMissionEvent -= value;
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

	// Token: 0x06018477 RID: 99447 RVA: 0x006C7D0C File Offset: 0x006C5F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018478 RID: 99448 RVA: 0x006C7D60 File Offset: 0x006C5F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			heroDungeonComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018479 RID: 99449 RVA: 0x006C7DB8 File Offset: 0x006C5FB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.HasRewardAddRelativeOperationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601847A RID: 99450 RVA: 0x006C7E0C File Offset: 0x006C600C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			bool hasRewardAddRelativeOperationalActivity;
			LuaObject.checkType(l, 2, out hasRewardAddRelativeOperationalActivity);
			heroDungeonComponentCommon.HasRewardAddRelativeOperationalActivity = hasRewardAddRelativeOperationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601847B RID: 99451 RVA: 0x006C7E64 File Offset: 0x006C6064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OperationalActivityChanllengenumsAdd(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonComponentCommon.OperationalActivityChanllengenumsAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601847C RID: 99452 RVA: 0x006C7EB8 File Offset: 0x006C60B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OperationalActivityChanllengenumsAdd(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponentCommon heroDungeonComponentCommon = (HeroDungeonComponentCommon)LuaObject.checkSelf(l);
			int operationalActivityChanllengenumsAdd;
			LuaObject.checkType(l, 2, out operationalActivityChanllengenumsAdd);
			heroDungeonComponentCommon.OperationalActivityChanllengenumsAdd = operationalActivityChanllengenumsAdd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601847D RID: 99453 RVA: 0x006C7F10 File Offset: 0x006C6110
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroDungeonComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.HasGotAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.IsLevelFirstPass);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.IsFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GetLevelCanChallengeMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GetDailyChallengeMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.FindLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.AttackHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.CanAttackHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.CanRaidHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.CanUnlockHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GetHeroDungeonChapterStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.HasGotChapterStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.CanGainHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GainHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.OnFlushLevelChallengeNumsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.IsEnoughAttackNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.InitLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.SetSuccessHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.SetRaidSuccessHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.CanAttackLevelByRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GetHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.GenerateHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.__callDele_CompleteHeroDungeonLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.__clearDele_CompleteHeroDungeonLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache1F);
		string name = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache21, true);
		string name2 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_rift);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache23, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache25, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache27, true);
		string name5 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_bag);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache29, true);
		string name6 = "m_heroDungeonDS";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_heroDungeonDS);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_heroDungeonDS);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2B, true);
		string name7 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2D, true);
		string name8 = "CompleteHeroDungeonLevelMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_CompleteHeroDungeonLevelMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2E, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache30, true);
		string name10 = "HasRewardAddRelativeOperationalActivity";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_HasRewardAddRelativeOperationalActivity);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_HasRewardAddRelativeOperationalActivity);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache32, true);
		string name11 = "OperationalActivityChanllengenumsAdd";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.get_OperationalActivityChanllengenumsAdd);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.set_OperationalActivityChanllengenumsAdd);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache34, true);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.<>f__mg$cache35, typeof(HeroDungeonComponentCommon));
	}

	// Token: 0x0400E9AD RID: 59821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E9AE RID: 59822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E9AF RID: 59823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E9B0 RID: 59824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E9B1 RID: 59825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E9B2 RID: 59826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E9B3 RID: 59827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E9B4 RID: 59828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E9B5 RID: 59829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E9B6 RID: 59830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E9B7 RID: 59831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E9B8 RID: 59832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E9B9 RID: 59833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E9BA RID: 59834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E9BB RID: 59835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E9BC RID: 59836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E9BD RID: 59837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E9BE RID: 59838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E9BF RID: 59839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E9C0 RID: 59840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E9C1 RID: 59841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E9C2 RID: 59842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E9C3 RID: 59843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E9C4 RID: 59844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E9C5 RID: 59845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E9C6 RID: 59846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E9C7 RID: 59847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E9C8 RID: 59848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E9C9 RID: 59849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E9CA RID: 59850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E9CB RID: 59851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E9CC RID: 59852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E9CD RID: 59853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E9CE RID: 59854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E9CF RID: 59855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E9D0 RID: 59856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E9D1 RID: 59857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E9D2 RID: 59858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E9D3 RID: 59859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E9D4 RID: 59860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E9D5 RID: 59861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E9D6 RID: 59862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E9D7 RID: 59863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E9D8 RID: 59864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E9D9 RID: 59865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E9DA RID: 59866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E9DB RID: 59867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E9DC RID: 59868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E9DD RID: 59869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E9DE RID: 59870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E9DF RID: 59871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E9E0 RID: 59872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E9E1 RID: 59873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E9E2 RID: 59874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
