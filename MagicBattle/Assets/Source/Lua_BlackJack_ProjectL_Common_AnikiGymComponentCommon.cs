using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B6 RID: 4534
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon : LuaObject
{
	// Token: 0x060177A9 RID: 96169 RVA: 0x00669FFC File Offset: 0x006681FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon o = new AnikiGymComponentCommon();
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

	// Token: 0x060177AA RID: 96170 RVA: 0x0066A044 File Offset: 0x00668244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			string name = anikiGymComponentCommon.GetName();
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

	// Token: 0x060177AB RID: 96171 RVA: 0x0066A098 File Offset: 0x00668298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			anikiGymComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177AC RID: 96172 RVA: 0x0066A0E4 File Offset: 0x006682E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			anikiGymComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177AD RID: 96173 RVA: 0x0066A130 File Offset: 0x00668330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			anikiGymComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177AE RID: 96174 RVA: 0x0066A17C File Offset: 0x0066837C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			anikiGymComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177AF RID: 96175 RVA: 0x0066A1D4 File Offset: 0x006683D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			anikiGymComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177B0 RID: 96176 RVA: 0x0066A220 File Offset: 0x00668420
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = anikiGymComponentCommon.AttackAnikiGymLevel(levelId);
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

	// Token: 0x060177B1 RID: 96177 RVA: 0x0066A284 File Offset: 0x00668484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = anikiGymComponentCommon.CanAttackAnikiGymLevel(levelId, isTeamBattle);
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

	// Token: 0x060177B2 RID: 96178 RVA: 0x0066A2F4 File Offset: 0x006684F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = anikiGymComponentCommon.IsLevelFinished(levelId);
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

	// Token: 0x060177B3 RID: 96179 RVA: 0x0066A358 File Offset: 0x00668558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = anikiGymComponentCommon.GetAllFinishedLevels();
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

	// Token: 0x060177B4 RID: 96180 RVA: 0x0066A3AC File Offset: 0x006685AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			bool b = anikiGymComponentCommon.IsDailyChallenge();
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

	// Token: 0x060177B5 RID: 96181 RVA: 0x0066A400 File Offset: 0x00668600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int dailyChallengNums = anikiGymComponentCommon.GetDailyChallengNums();
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

	// Token: 0x060177B6 RID: 96182 RVA: 0x0066A454 File Offset: 0x00668654
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			List<int> allUnlockedLevels = anikiGymComponentCommon.GetAllUnlockedLevels();
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

	// Token: 0x060177B7 RID: 96183 RVA: 0x0066A4A8 File Offset: 0x006686A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = anikiGymComponentCommon.IsLevelUnlocked(levelId);
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

	// Token: 0x060177B8 RID: 96184 RVA: 0x0066A50C File Offset: 0x0066870C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			bool b = anikiGymComponentCommon.m_luaExportHelper.IsGameFunctionOpened();
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

	// Token: 0x060177B9 RID: 96185 RVA: 0x0066A568 File Offset: 0x00668768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanOpenLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = anikiGymComponentCommon.m_luaExportHelper.CanOpenLevel(levelId);
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

	// Token: 0x060177BA RID: 96186 RVA: 0x0066A5D0 File Offset: 0x006687D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = anikiGymComponentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
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

	// Token: 0x060177BB RID: 96187 RVA: 0x0066A644 File Offset: 0x00668844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonSuccessAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			anikiGymComponentCommon.m_luaExportHelper.SetCommonSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177BC RID: 96188 RVA: 0x0066A6D4 File Offset: 0x006688D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushChallengNums(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			anikiGymComponentCommon.m_luaExportHelper.FlushChallengNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177BD RID: 96189 RVA: 0x0066A728 File Offset: 0x00668928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			anikiGymComponentCommon.m_luaExportHelper.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177BE RID: 96190 RVA: 0x0066A784 File Offset: 0x00668984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteAnikiGymMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			anikiGymComponentCommon.m_luaExportHelper.__callDele_CompleteAnikiGymMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177BF RID: 96191 RVA: 0x0066A7FC File Offset: 0x006689FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteAnikiGymMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			anikiGymComponentCommon.m_luaExportHelper.__clearDele_CompleteAnikiGymMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C0 RID: 96192 RVA: 0x0066A874 File Offset: 0x00668A74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C1 RID: 96193 RVA: 0x0066A8CC File Offset: 0x00668ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			anikiGymComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C2 RID: 96194 RVA: 0x0066A928 File Offset: 0x00668B28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_anikiGymDS(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_anikiGymDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C3 RID: 96195 RVA: 0x0066A980 File Offset: 0x00668B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGymDS(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			DataSectionAnikiGym anikiGymDS;
			LuaObject.checkType<DataSectionAnikiGym>(l, 2, out anikiGymDS);
			anikiGymComponentCommon.m_luaExportHelper.m_anikiGymDS = anikiGymDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C4 RID: 96196 RVA: 0x0066A9DC File Offset: 0x00668BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C5 RID: 96197 RVA: 0x0066AA34 File Offset: 0x00668C34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			anikiGymComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C6 RID: 96198 RVA: 0x0066AA90 File Offset: 0x00668C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C7 RID: 96199 RVA: 0x0066AAE8 File Offset: 0x00668CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			anikiGymComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C8 RID: 96200 RVA: 0x0066AB44 File Offset: 0x00668D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177C9 RID: 96201 RVA: 0x0066AB9C File Offset: 0x00668D9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			anikiGymComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177CA RID: 96202 RVA: 0x0066ABF8 File Offset: 0x00668DF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177CB RID: 96203 RVA: 0x0066AC50 File Offset: 0x00668E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			anikiGymComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177CC RID: 96204 RVA: 0x0066ACAC File Offset: 0x00668EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177CD RID: 96205 RVA: 0x0066AD04 File Offset: 0x00668F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			anikiGymComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177CE RID: 96206 RVA: 0x0066AD60 File Offset: 0x00668F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompleteAnikiGymMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiGymComponentCommon.CompleteAnikiGymMissionEvent += value;
				}
				else if (num == 2)
				{
					anikiGymComponentCommon.CompleteAnikiGymMissionEvent -= value;
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

	// Token: 0x060177CF RID: 96207 RVA: 0x0066ADE0 File Offset: 0x00668FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177D0 RID: 96208 RVA: 0x0066AE34 File Offset: 0x00669034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			anikiGymComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177D1 RID: 96209 RVA: 0x0066AE8C File Offset: 0x0066908C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymComponentCommon.HasRewardAddRelativeOperationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177D2 RID: 96210 RVA: 0x0066AEE0 File Offset: 0x006690E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponentCommon anikiGymComponentCommon = (AnikiGymComponentCommon)LuaObject.checkSelf(l);
			bool hasRewardAddRelativeOperationalActivity;
			LuaObject.checkType(l, 2, out hasRewardAddRelativeOperationalActivity);
			anikiGymComponentCommon.HasRewardAddRelativeOperationalActivity = hasRewardAddRelativeOperationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177D3 RID: 96211 RVA: 0x0066AF38 File Offset: 0x00669138
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AnikiGymComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.AttackAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.CanAttackAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.CanOpenLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.SetCommonSuccessAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.FlushChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.__callDele_CompleteAnikiGymMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.__clearDele_CompleteAnikiGymMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache15);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache17, true);
		string name2 = "m_anikiGymDS";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_anikiGymDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_anikiGymDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache19, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1B, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1D, true);
		string name5 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_rift);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache1F, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache21, true);
		string name7 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_m_bag);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache23, true);
		string name8 = "CompleteAnikiGymMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_CompleteAnikiGymMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache24, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache26, true);
		string name10 = "HasRewardAddRelativeOperationalActivity";
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.get_HasRewardAddRelativeOperationalActivity);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.set_HasRewardAddRelativeOperationalActivity);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache28, true);
		if (Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.<>f__mg$cache29, typeof(AnikiGymComponentCommon));
	}

	// Token: 0x0400DE1F RID: 56863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE20 RID: 56864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE21 RID: 56865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE22 RID: 56866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE23 RID: 56867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE24 RID: 56868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE25 RID: 56869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE26 RID: 56870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DE27 RID: 56871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DE28 RID: 56872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DE29 RID: 56873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DE2A RID: 56874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DE2B RID: 56875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DE2C RID: 56876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DE2D RID: 56877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DE2E RID: 56878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DE2F RID: 56879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DE30 RID: 56880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DE31 RID: 56881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DE32 RID: 56882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DE33 RID: 56883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DE34 RID: 56884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DE35 RID: 56885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DE36 RID: 56886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DE37 RID: 56887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DE38 RID: 56888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DE39 RID: 56889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DE3A RID: 56890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DE3B RID: 56891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DE3C RID: 56892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DE3D RID: 56893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DE3E RID: 56894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DE3F RID: 56895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DE40 RID: 56896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DE41 RID: 56897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DE42 RID: 56898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DE43 RID: 56899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DE44 RID: 56900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DE45 RID: 56901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DE46 RID: 56902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DE47 RID: 56903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DE48 RID: 56904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
