using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200128F RID: 4751
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon : LuaObject
{
	// Token: 0x06018C1E RID: 101406 RVA: 0x00700FB8 File Offset: 0x006FF1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon o = new TreasureMapComponentCommon();
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

	// Token: 0x06018C1F RID: 101407 RVA: 0x00701000 File Offset: 0x006FF200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			string name = treasureMapComponentCommon.GetName();
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

	// Token: 0x06018C20 RID: 101408 RVA: 0x00701054 File Offset: 0x006FF254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			treasureMapComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C21 RID: 101409 RVA: 0x007010A0 File Offset: 0x006FF2A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			treasureMapComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C22 RID: 101410 RVA: 0x007010EC File Offset: 0x006FF2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			treasureMapComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C23 RID: 101411 RVA: 0x00701138 File Offset: 0x006FF338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			treasureMapComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C24 RID: 101412 RVA: 0x00701190 File Offset: 0x006FF390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			treasureMapComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C25 RID: 101413 RVA: 0x007011DC File Offset: 0x006FF3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = treasureMapComponentCommon.IsLevelFinished(levelId);
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

	// Token: 0x06018C26 RID: 101414 RVA: 0x00701240 File Offset: 0x006FF440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = treasureMapComponentCommon.AttackTreasureLevel(levelId);
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

	// Token: 0x06018C27 RID: 101415 RVA: 0x007012A4 File Offset: 0x006FF4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			int leveId;
			LuaObject.checkType(l, 2, out leveId);
			int i = treasureMapComponentCommon.CanAttackTreasureLevel(leveId);
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

	// Token: 0x06018C28 RID: 101416 RVA: 0x00701308 File Offset: 0x006FF508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			bool b = treasureMapComponentCommon.m_luaExportHelper.IsGameFunctionOpened();
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

	// Token: 0x06018C29 RID: 101417 RVA: 0x00701364 File Offset: 0x006FF564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			int i = treasureMapComponentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo);
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

	// Token: 0x06018C2A RID: 101418 RVA: 0x007013CC File Offset: 0x006FF5CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSuccessTreasureMapLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			treasureMapComponentCommon.m_luaExportHelper.SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C2B RID: 101419 RVA: 0x00701438 File Offset: 0x006FF638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			treasureMapComponentCommon.m_luaExportHelper.OnFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C2C RID: 101420 RVA: 0x00701494 File Offset: 0x006FF694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_CompleteTreasureMapMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			treasureMapComponentCommon.m_luaExportHelper.__callDele_CompleteTreasureMapMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C2D RID: 101421 RVA: 0x0070150C File Offset: 0x006FF70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteTreasureMapMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			treasureMapComponentCommon.m_luaExportHelper.__clearDele_CompleteTreasureMapMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C2E RID: 101422 RVA: 0x00701584 File Offset: 0x006FF784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C2F RID: 101423 RVA: 0x007015DC File Offset: 0x006FF7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			treasureMapComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C30 RID: 101424 RVA: 0x00701638 File Offset: 0x006FF838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureMapDS(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.m_luaExportHelper.m_treasureMapDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C31 RID: 101425 RVA: 0x00701690 File Offset: 0x006FF890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_treasureMapDS(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			DataSectionTreasureMap treasureMapDS;
			LuaObject.checkType<DataSectionTreasureMap>(l, 2, out treasureMapDS);
			treasureMapComponentCommon.m_luaExportHelper.m_treasureMapDS = treasureMapDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C32 RID: 101426 RVA: 0x007016EC File Offset: 0x006FF8EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C33 RID: 101427 RVA: 0x00701744 File Offset: 0x006FF944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			treasureMapComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C34 RID: 101428 RVA: 0x007017A0 File Offset: 0x006FF9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C35 RID: 101429 RVA: 0x007017F8 File Offset: 0x006FF9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			treasureMapComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C36 RID: 101430 RVA: 0x00701854 File Offset: 0x006FFA54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C37 RID: 101431 RVA: 0x007018AC File Offset: 0x006FFAAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			treasureMapComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C38 RID: 101432 RVA: 0x00701908 File Offset: 0x006FFB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C39 RID: 101433 RVA: 0x00701960 File Offset: 0x006FFB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			treasureMapComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C3A RID: 101434 RVA: 0x007019BC File Offset: 0x006FFBBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompleteTreasureMapMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					treasureMapComponentCommon.CompleteTreasureMapMissionEvent += value;
				}
				else if (num == 2)
				{
					treasureMapComponentCommon.CompleteTreasureMapMissionEvent -= value;
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

	// Token: 0x06018C3B RID: 101435 RVA: 0x00701A3C File Offset: 0x006FFC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C3C RID: 101436 RVA: 0x00701A90 File Offset: 0x006FFC90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponentCommon treasureMapComponentCommon = (TreasureMapComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			treasureMapComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C3D RID: 101437 RVA: 0x00701AE8 File Offset: 0x006FFCE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TreasureMapComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.AttackTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.CanAttackTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.SetSuccessTreasureMapLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.OnFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.__callDele_CompleteTreasureMapMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.__clearDele_CompleteTreasureMapMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheE);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache10, true);
		string name2 = "m_treasureMapDS";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_m_treasureMapDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_m_treasureMapDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache12, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache14, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache16, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache18, true);
		string name6 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_m_bag);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1A, true);
		string name7 = "CompleteTreasureMapMissionEvent";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_CompleteTreasureMapMissionEvent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1B, true);
		string name8 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.get_Owner);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1D, true);
		if (Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.<>f__mg$cache1E, typeof(TreasureMapComponentCommon));
	}

	// Token: 0x0400F0E2 RID: 61666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F0E3 RID: 61667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F0E4 RID: 61668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F0E5 RID: 61669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F0E6 RID: 61670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F0E7 RID: 61671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F0E8 RID: 61672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F0E9 RID: 61673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F0EA RID: 61674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F0EB RID: 61675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F0EC RID: 61676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F0ED RID: 61677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F0EE RID: 61678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F0EF RID: 61679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F0F0 RID: 61680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F0F1 RID: 61681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F0F2 RID: 61682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F0F3 RID: 61683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F0F4 RID: 61684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F0F5 RID: 61685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F0F6 RID: 61686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F0F7 RID: 61687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F0F8 RID: 61688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F0F9 RID: 61689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F0FA RID: 61690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F0FB RID: 61691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F0FC RID: 61692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F0FD RID: 61693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F0FE RID: 61694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F0FF RID: 61695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F100 RID: 61696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
