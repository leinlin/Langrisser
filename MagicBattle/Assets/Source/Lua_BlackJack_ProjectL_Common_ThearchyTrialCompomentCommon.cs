using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001289 RID: 4745
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon : LuaObject
{
	// Token: 0x06018B81 RID: 101249 RVA: 0x006FC644 File Offset: 0x006FA844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon o = new ThearchyTrialCompomentCommon();
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

	// Token: 0x06018B82 RID: 101250 RVA: 0x006FC68C File Offset: 0x006FA88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			string name = thearchyTrialCompomentCommon.GetName();
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

	// Token: 0x06018B83 RID: 101251 RVA: 0x006FC6E0 File Offset: 0x006FA8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			thearchyTrialCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B84 RID: 101252 RVA: 0x006FC72C File Offset: 0x006FA92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			thearchyTrialCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B85 RID: 101253 RVA: 0x006FC778 File Offset: 0x006FA978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			thearchyTrialCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B86 RID: 101254 RVA: 0x006FC7C4 File Offset: 0x006FA9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			thearchyTrialCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B87 RID: 101255 RVA: 0x006FC81C File Offset: 0x006FAA1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			thearchyTrialCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B88 RID: 101256 RVA: 0x006FC868 File Offset: 0x006FAA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = thearchyTrialCompomentCommon.AttackThearchyTrialLevel(levelId);
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

	// Token: 0x06018B89 RID: 101257 RVA: 0x006FC8CC File Offset: 0x006FAACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = thearchyTrialCompomentCommon.IsLevelFinished(levelId);
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

	// Token: 0x06018B8A RID: 101258 RVA: 0x006FC930 File Offset: 0x006FAB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = thearchyTrialCompomentCommon.CanAttackThearchyTrialLevel(levelId, isTeamBattle);
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

	// Token: 0x06018B8B RID: 101259 RVA: 0x006FC9A0 File Offset: 0x006FABA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = thearchyTrialCompomentCommon.GetAllFinishedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B8C RID: 101260 RVA: 0x006FC9F4 File Offset: 0x006FABF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			bool b = thearchyTrialCompomentCommon.IsDailyChallenge();
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

	// Token: 0x06018B8D RID: 101261 RVA: 0x006FCA48 File Offset: 0x006FAC48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int dailyChallengNums = thearchyTrialCompomentCommon.GetDailyChallengNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyChallengNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B8E RID: 101262 RVA: 0x006FCA9C File Offset: 0x006FAC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			List<int> allUnlockedLevels = thearchyTrialCompomentCommon.GetAllUnlockedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allUnlockedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B8F RID: 101263 RVA: 0x006FCAF0 File Offset: 0x006FACF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = thearchyTrialCompomentCommon.IsLevelUnlocked(levelId);
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

	// Token: 0x06018B90 RID: 101264 RVA: 0x006FCB54 File Offset: 0x006FAD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			bool b = thearchyTrialCompomentCommon.m_luaExportHelper.IsGameFunctionOpened();
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

	// Token: 0x06018B91 RID: 101265 RVA: 0x006FCBB0 File Offset: 0x006FADB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanOpenLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = thearchyTrialCompomentCommon.m_luaExportHelper.CanOpenLevel(levelId);
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

	// Token: 0x06018B92 RID: 101266 RVA: 0x006FCC18 File Offset: 0x006FAE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = thearchyTrialCompomentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
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

	// Token: 0x06018B93 RID: 101267 RVA: 0x006FCC8C File Offset: 0x006FAE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonSuccessThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			thearchyTrialCompomentCommon.m_luaExportHelper.SetCommonSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B94 RID: 101268 RVA: 0x006FCD1C File Offset: 0x006FAF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushChallengNums(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			thearchyTrialCompomentCommon.m_luaExportHelper.FlushChallengNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B95 RID: 101269 RVA: 0x006FCD70 File Offset: 0x006FAF70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			thearchyTrialCompomentCommon.m_luaExportHelper.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B96 RID: 101270 RVA: 0x006FCDCC File Offset: 0x006FAFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteThearchyTrialMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			thearchyTrialCompomentCommon.m_luaExportHelper.__callDele_CompleteThearchyTrialMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B97 RID: 101271 RVA: 0x006FCE44 File Offset: 0x006FB044
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_CompleteThearchyTrialMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			thearchyTrialCompomentCommon.m_luaExportHelper.__clearDele_CompleteThearchyTrialMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B98 RID: 101272 RVA: 0x006FCEBC File Offset: 0x006FB0BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B99 RID: 101273 RVA: 0x006FCF14 File Offset: 0x006FB114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B9A RID: 101274 RVA: 0x006FCF70 File Offset: 0x006FB170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_thearchyTrial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B9B RID: 101275 RVA: 0x006FCFC8 File Offset: 0x006FB1C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			DataSectionThearchyTrail thearchyTrial;
			LuaObject.checkType<DataSectionThearchyTrail>(l, 2, out thearchyTrial);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_thearchyTrial = thearchyTrial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B9C RID: 101276 RVA: 0x006FD024 File Offset: 0x006FB224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B9D RID: 101277 RVA: 0x006FD07C File Offset: 0x006FB27C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B9E RID: 101278 RVA: 0x006FD0D8 File Offset: 0x006FB2D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B9F RID: 101279 RVA: 0x006FD130 File Offset: 0x006FB330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA0 RID: 101280 RVA: 0x006FD18C File Offset: 0x006FB38C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA1 RID: 101281 RVA: 0x006FD1E4 File Offset: 0x006FB3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA2 RID: 101282 RVA: 0x006FD240 File Offset: 0x006FB440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA3 RID: 101283 RVA: 0x006FD298 File Offset: 0x006FB498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA4 RID: 101284 RVA: 0x006FD2F4 File Offset: 0x006FB4F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA5 RID: 101285 RVA: 0x006FD34C File Offset: 0x006FB54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			thearchyTrialCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA6 RID: 101286 RVA: 0x006FD3A8 File Offset: 0x006FB5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompleteThearchyTrialMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyTrialCompomentCommon.CompleteThearchyTrialMissionEvent += value;
				}
				else if (num == 2)
				{
					thearchyTrialCompomentCommon.CompleteThearchyTrialMissionEvent -= value;
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

	// Token: 0x06018BA7 RID: 101287 RVA: 0x006FD428 File Offset: 0x006FB628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA8 RID: 101288 RVA: 0x006FD47C File Offset: 0x006FB67C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			thearchyTrialCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BA9 RID: 101289 RVA: 0x006FD4D4 File Offset: 0x006FB6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialCompomentCommon.HasRewardAddRelativeOperationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BAA RID: 101290 RVA: 0x006FD528 File Offset: 0x006FB728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialCompomentCommon thearchyTrialCompomentCommon = (ThearchyTrialCompomentCommon)LuaObject.checkSelf(l);
			bool hasRewardAddRelativeOperationalActivity;
			LuaObject.checkType(l, 2, out hasRewardAddRelativeOperationalActivity);
			thearchyTrialCompomentCommon.HasRewardAddRelativeOperationalActivity = hasRewardAddRelativeOperationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BAB RID: 101291 RVA: 0x006FD580 File Offset: 0x006FB780
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ThearchyTrialCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.AttackThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.CanAttackThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.CanOpenLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.SetCommonSuccessThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.FlushChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.__callDele_CompleteThearchyTrialMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.__clearDele_CompleteThearchyTrialMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache15);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache17, true);
		string name2 = "m_thearchyTrial";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_thearchyTrial);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_thearchyTrial);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache19, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1B, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1D, true);
		string name5 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_rift);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache1F, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache21, true);
		string name7 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_m_bag);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache23, true);
		string name8 = "CompleteThearchyTrialMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_CompleteThearchyTrialMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache24, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache26, true);
		string name10 = "HasRewardAddRelativeOperationalActivity";
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.get_HasRewardAddRelativeOperationalActivity);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.set_HasRewardAddRelativeOperationalActivity);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache28, true);
		if (Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.<>f__mg$cache29, typeof(ThearchyTrialCompomentCommon));
	}

	// Token: 0x0400F051 RID: 61521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F052 RID: 61522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F053 RID: 61523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F054 RID: 61524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F055 RID: 61525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F056 RID: 61526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F057 RID: 61527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F058 RID: 61528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F059 RID: 61529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F05A RID: 61530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F05B RID: 61531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F05C RID: 61532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F05D RID: 61533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F05E RID: 61534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F05F RID: 61535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F060 RID: 61536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F061 RID: 61537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F062 RID: 61538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F063 RID: 61539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F064 RID: 61540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F065 RID: 61541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F066 RID: 61542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F067 RID: 61543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F068 RID: 61544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F069 RID: 61545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F06A RID: 61546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F06B RID: 61547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F06C RID: 61548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F06D RID: 61549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F06E RID: 61550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F06F RID: 61551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F070 RID: 61552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F071 RID: 61553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F072 RID: 61554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F073 RID: 61555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F074 RID: 61556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F075 RID: 61557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F076 RID: 61558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F077 RID: 61559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F078 RID: 61560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F079 RID: 61561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F07A RID: 61562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
