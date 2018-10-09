using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001250 RID: 4688
[Preserve]
public class Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon : LuaObject
{
	// Token: 0x06018600 RID: 99840 RVA: 0x006D3A70 File Offset: 0x006D1C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon o = new MemoryCorridorCompomentCommon();
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

	// Token: 0x06018601 RID: 99841 RVA: 0x006D3AB8 File Offset: 0x006D1CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			string name = memoryCorridorCompomentCommon.GetName();
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

	// Token: 0x06018602 RID: 99842 RVA: 0x006D3B0C File Offset: 0x006D1D0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			memoryCorridorCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018603 RID: 99843 RVA: 0x006D3B58 File Offset: 0x006D1D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			memoryCorridorCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018604 RID: 99844 RVA: 0x006D3BA4 File Offset: 0x006D1DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			memoryCorridorCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018605 RID: 99845 RVA: 0x006D3BF0 File Offset: 0x006D1DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			memoryCorridorCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018606 RID: 99846 RVA: 0x006D3C48 File Offset: 0x006D1E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			memoryCorridorCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018607 RID: 99847 RVA: 0x006D3C94 File Offset: 0x006D1E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = memoryCorridorCompomentCommon.IsLevelFinished(levelId);
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

	// Token: 0x06018608 RID: 99848 RVA: 0x006D3CF8 File Offset: 0x006D1EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = memoryCorridorCompomentCommon.AttackMemoryCorridorLevel(levelId);
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

	// Token: 0x06018609 RID: 99849 RVA: 0x006D3D5C File Offset: 0x006D1F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = memoryCorridorCompomentCommon.CanAttackMemoryCorridorLevel(levelId, isTeamBattle);
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

	// Token: 0x0601860A RID: 99850 RVA: 0x006D3DCC File Offset: 0x006D1FCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = memoryCorridorCompomentCommon.GetAllFinishedLevels();
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

	// Token: 0x0601860B RID: 99851 RVA: 0x006D3E20 File Offset: 0x006D2020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			bool b = memoryCorridorCompomentCommon.IsDailyChallenge();
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

	// Token: 0x0601860C RID: 99852 RVA: 0x006D3E74 File Offset: 0x006D2074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int dailyChallengNums = memoryCorridorCompomentCommon.GetDailyChallengNums();
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

	// Token: 0x0601860D RID: 99853 RVA: 0x006D3EC8 File Offset: 0x006D20C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			List<int> allUnlockedLevels = memoryCorridorCompomentCommon.GetAllUnlockedLevels();
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

	// Token: 0x0601860E RID: 99854 RVA: 0x006D3F1C File Offset: 0x006D211C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = memoryCorridorCompomentCommon.IsLevelUnlocked(levelId);
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

	// Token: 0x0601860F RID: 99855 RVA: 0x006D3F80 File Offset: 0x006D2180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			bool b = memoryCorridorCompomentCommon.m_luaExportHelper.IsGameFunctionOpened();
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

	// Token: 0x06018610 RID: 99856 RVA: 0x006D3FDC File Offset: 0x006D21DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanOpenLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = memoryCorridorCompomentCommon.m_luaExportHelper.CanOpenLevel(levelId);
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

	// Token: 0x06018611 RID: 99857 RVA: 0x006D4044 File Offset: 0x006D2244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = memoryCorridorCompomentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
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

	// Token: 0x06018612 RID: 99858 RVA: 0x006D40B8 File Offset: 0x006D22B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonSuccessMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			memoryCorridorCompomentCommon.m_luaExportHelper.SetCommonSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018613 RID: 99859 RVA: 0x006D4148 File Offset: 0x006D2348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushChallengNums(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			memoryCorridorCompomentCommon.m_luaExportHelper.FlushChallengNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018614 RID: 99860 RVA: 0x006D419C File Offset: 0x006D239C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			memoryCorridorCompomentCommon.m_luaExportHelper.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018615 RID: 99861 RVA: 0x006D41F8 File Offset: 0x006D23F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteMemoryCorridorMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			memoryCorridorCompomentCommon.m_luaExportHelper.__callDele_CompleteMemoryCorridorMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018616 RID: 99862 RVA: 0x006D4270 File Offset: 0x006D2470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_CompleteMemoryCorridorMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			memoryCorridorCompomentCommon.m_luaExportHelper.__clearDele_CompleteMemoryCorridorMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018617 RID: 99863 RVA: 0x006D42E8 File Offset: 0x006D24E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018618 RID: 99864 RVA: 0x006D4340 File Offset: 0x006D2540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018619 RID: 99865 RVA: 0x006D439C File Offset: 0x006D259C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_memoryCorridorDS(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_memoryCorridorDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601861A RID: 99866 RVA: 0x006D43F4 File Offset: 0x006D25F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorDS(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			DataSectionMemoryCorridor memoryCorridorDS;
			LuaObject.checkType<DataSectionMemoryCorridor>(l, 2, out memoryCorridorDS);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_memoryCorridorDS = memoryCorridorDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601861B RID: 99867 RVA: 0x006D4450 File Offset: 0x006D2650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601861C RID: 99868 RVA: 0x006D44A8 File Offset: 0x006D26A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601861D RID: 99869 RVA: 0x006D4504 File Offset: 0x006D2704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601861E RID: 99870 RVA: 0x006D455C File Offset: 0x006D275C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601861F RID: 99871 RVA: 0x006D45B8 File Offset: 0x006D27B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018620 RID: 99872 RVA: 0x006D4610 File Offset: 0x006D2810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018621 RID: 99873 RVA: 0x006D466C File Offset: 0x006D286C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018622 RID: 99874 RVA: 0x006D46C4 File Offset: 0x006D28C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018623 RID: 99875 RVA: 0x006D4720 File Offset: 0x006D2920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018624 RID: 99876 RVA: 0x006D4778 File Offset: 0x006D2978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			memoryCorridorCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018625 RID: 99877 RVA: 0x006D47D4 File Offset: 0x006D29D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompleteMemoryCorridorMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorCompomentCommon.CompleteMemoryCorridorMissionEvent += value;
				}
				else if (num == 2)
				{
					memoryCorridorCompomentCommon.CompleteMemoryCorridorMissionEvent -= value;
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

	// Token: 0x06018626 RID: 99878 RVA: 0x006D4854 File Offset: 0x006D2A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018627 RID: 99879 RVA: 0x006D48A8 File Offset: 0x006D2AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			memoryCorridorCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018628 RID: 99880 RVA: 0x006D4900 File Offset: 0x006D2B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorCompomentCommon.HasRewardAddRelativeOperationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018629 RID: 99881 RVA: 0x006D4954 File Offset: 0x006D2B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompomentCommon memoryCorridorCompomentCommon = (MemoryCorridorCompomentCommon)LuaObject.checkSelf(l);
			bool hasRewardAddRelativeOperationalActivity;
			LuaObject.checkType(l, 2, out hasRewardAddRelativeOperationalActivity);
			memoryCorridorCompomentCommon.HasRewardAddRelativeOperationalActivity = hasRewardAddRelativeOperationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601862A RID: 99882 RVA: 0x006D49AC File Offset: 0x006D2BAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.MemoryCorridorCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.AttackMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.CanAttackMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.CanOpenLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.SetCommonSuccessMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.FlushChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.__callDele_CompleteMemoryCorridorMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.__clearDele_CompleteMemoryCorridorMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache15);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache17, true);
		string name2 = "m_memoryCorridorDS";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_memoryCorridorDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_memoryCorridorDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache19, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1B, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1D, true);
		string name5 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_rift);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache1F, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache21, true);
		string name7 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_m_bag);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache23, true);
		string name8 = "CompleteMemoryCorridorMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_CompleteMemoryCorridorMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache24, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache26, true);
		string name10 = "HasRewardAddRelativeOperationalActivity";
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.get_HasRewardAddRelativeOperationalActivity);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.set_HasRewardAddRelativeOperationalActivity);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache28, true);
		if (Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.<>f__mg$cache29, typeof(MemoryCorridorCompomentCommon));
	}

	// Token: 0x0400EB42 RID: 60226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EB43 RID: 60227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EB44 RID: 60228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EB45 RID: 60229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EB46 RID: 60230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EB47 RID: 60231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EB48 RID: 60232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EB49 RID: 60233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EB4A RID: 60234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EB4B RID: 60235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EB4C RID: 60236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EB4D RID: 60237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EB4E RID: 60238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EB4F RID: 60239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EB50 RID: 60240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EB51 RID: 60241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EB52 RID: 60242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EB53 RID: 60243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EB54 RID: 60244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EB55 RID: 60245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EB56 RID: 60246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EB57 RID: 60247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EB58 RID: 60248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EB59 RID: 60249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EB5A RID: 60250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EB5B RID: 60251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EB5C RID: 60252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EB5D RID: 60253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EB5E RID: 60254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EB5F RID: 60255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EB60 RID: 60256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EB61 RID: 60257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EB62 RID: 60258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EB63 RID: 60259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EB64 RID: 60260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EB65 RID: 60261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EB66 RID: 60262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EB67 RID: 60263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EB68 RID: 60264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EB69 RID: 60265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EB6A RID: 60266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EB6B RID: 60267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
