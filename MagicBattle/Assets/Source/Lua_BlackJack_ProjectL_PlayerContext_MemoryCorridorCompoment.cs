using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D1 RID: 4817
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment : LuaObject
{
	// Token: 0x060196A6 RID: 104102 RVA: 0x00750AD4 File Offset: 0x0074ECD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment o = new MemoryCorridorCompoment();
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

	// Token: 0x060196A7 RID: 104103 RVA: 0x00750B1C File Offset: 0x0074ED1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196A8 RID: 104104 RVA: 0x00750B68 File Offset: 0x0074ED68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196A9 RID: 104105 RVA: 0x00750BB4 File Offset: 0x0074EDB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196AA RID: 104106 RVA: 0x00750C00 File Offset: 0x0074EE00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			DSMemoryCorridorNtf msg;
			LuaObject.checkType<DSMemoryCorridorNtf>(l, 2, out msg);
			memoryCorridorCompoment.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196AB RID: 104107 RVA: 0x00750C58 File Offset: 0x0074EE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			ushort dsversion = memoryCorridorCompoment.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196AC RID: 104108 RVA: 0x00750CAC File Offset: 0x0074EEAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentTicketNums(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int currentTicketNums = memoryCorridorCompoment.GetCurrentTicketNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentTicketNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196AD RID: 104109 RVA: 0x00750D00 File Offset: 0x0074EF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			int i = memoryCorridorCompoment.FinishedMemoryCorridorLevel(levelId, isWin, battleTreasures);
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

	// Token: 0x060196AE RID: 104110 RVA: 0x00750D7C File Offset: 0x0074EF7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSuccessMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			bool isTeamBattle;
			LuaObject.checkType(l, 5, out isTeamBattle);
			memoryCorridorCompoment.SetSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196AF RID: 104111 RVA: 0x00750DFC File Offset: 0x0074EFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMemoryCorridorOpened(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int memoryCorridorId;
			LuaObject.checkType(l, 2, out memoryCorridorId);
			bool b = memoryCorridorCompoment.IsMemoryCorridorOpened(memoryCorridorId);
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

	// Token: 0x060196B0 RID: 104112 RVA: 0x00750E60 File Offset: 0x0074F060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMemoryCorridorLevelOpened(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = memoryCorridorCompoment.IsMemoryCorridorLevelOpened(levelId);
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

	// Token: 0x060196B1 RID: 104113 RVA: 0x00750EC4 File Offset: 0x0074F0C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			string s = memoryCorridorCompoment.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196B2 RID: 104114 RVA: 0x00750F20 File Offset: 0x0074F120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196B3 RID: 104115 RVA: 0x00750F74 File Offset: 0x0074F174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196B4 RID: 104116 RVA: 0x00750FC8 File Offset: 0x0074F1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196B5 RID: 104117 RVA: 0x0075101C File Offset: 0x0074F21C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			memoryCorridorCompoment.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196B6 RID: 104118 RVA: 0x00751078 File Offset: 0x0074F278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			memoryCorridorCompoment.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196B7 RID: 104119 RVA: 0x007510CC File Offset: 0x0074F2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = memoryCorridorCompoment.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x060196B8 RID: 104120 RVA: 0x00751134 File Offset: 0x0074F334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AttackMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = memoryCorridorCompoment.m_luaExportHelper.__callBase_AttackMemoryCorridorLevel(levelId);
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

	// Token: 0x060196B9 RID: 104121 RVA: 0x0075119C File Offset: 0x0074F39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanAttackMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = memoryCorridorCompoment.m_luaExportHelper.__callBase_CanAttackMemoryCorridorLevel(levelId, isTeamBattle);
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

	// Token: 0x060196BA RID: 104122 RVA: 0x00751210 File Offset: 0x0074F410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
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
			memoryCorridorCompoment.m_luaExportHelper.__callBase_SetCommonSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196BB RID: 104123 RVA: 0x007512A0 File Offset: 0x0074F4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			HashSet<int> o = memoryCorridorCompoment.m_luaExportHelper.__callBase_GetAllFinishedLevels();
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

	// Token: 0x060196BC RID: 104124 RVA: 0x007512FC File Offset: 0x0074F4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			bool b = memoryCorridorCompoment.m_luaExportHelper.__callBase_IsDailyChallenge();
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

	// Token: 0x060196BD RID: 104125 RVA: 0x00751358 File Offset: 0x0074F558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int i = memoryCorridorCompoment.m_luaExportHelper.__callBase_GetDailyChallengNums();
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

	// Token: 0x060196BE RID: 104126 RVA: 0x007513B4 File Offset: 0x0074F5B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			memoryCorridorCompoment.m_luaExportHelper.__callBase_AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196BF RID: 104127 RVA: 0x00751410 File Offset: 0x0074F610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			List<int> o = memoryCorridorCompoment.m_luaExportHelper.__callBase_GetAllUnlockedLevels();
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

	// Token: 0x060196C0 RID: 104128 RVA: 0x0075146C File Offset: 0x0074F66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorCompoment memoryCorridorCompoment = (MemoryCorridorCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = memoryCorridorCompoment.m_luaExportHelper.__callBase_IsLevelUnlocked(levelId);
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

	// Token: 0x060196C1 RID: 104129 RVA: 0x007514D4 File Offset: 0x0074F6D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.MemoryCorridorCompoment");
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.GetCurrentTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.FinishedMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.SetSuccessMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.IsMemoryCorridorOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.IsMemoryCorridorLevelOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_AttackMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_CanAttackMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_SetCommonSuccessMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.__callBase_IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.<>f__mg$cache1A, typeof(MemoryCorridorCompoment), typeof(MemoryCorridorCompomentCommon));
	}

	// Token: 0x0400FAE6 RID: 64230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FAE7 RID: 64231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FAE8 RID: 64232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FAE9 RID: 64233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FAEA RID: 64234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FAEB RID: 64235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FAEC RID: 64236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FAED RID: 64237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FAEE RID: 64238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FAEF RID: 64239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FAF0 RID: 64240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FAF1 RID: 64241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FAF2 RID: 64242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FAF3 RID: 64243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FAF4 RID: 64244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FAF5 RID: 64245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FAF6 RID: 64246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FAF7 RID: 64247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FAF8 RID: 64248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FAF9 RID: 64249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FAFA RID: 64250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FAFB RID: 64251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FAFC RID: 64252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FAFD RID: 64253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FAFE RID: 64254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FAFF RID: 64255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FB00 RID: 64256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
