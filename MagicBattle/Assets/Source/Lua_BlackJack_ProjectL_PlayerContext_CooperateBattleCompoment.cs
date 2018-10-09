using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012BE RID: 4798
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment : LuaObject
{
	// Token: 0x060193B7 RID: 103351 RVA: 0x0073946C File Offset: 0x0073766C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment o = new CooperateBattleCompoment();
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

	// Token: 0x060193B8 RID: 103352 RVA: 0x007394B4 File Offset: 0x007376B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193B9 RID: 103353 RVA: 0x00739500 File Offset: 0x00737700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193BA RID: 103354 RVA: 0x0073954C File Offset: 0x0073774C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193BB RID: 103355 RVA: 0x00739598 File Offset: 0x00737798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			DSCooperateBattleNtf ntf;
			LuaObject.checkType<DSCooperateBattleNtf>(l, 2, out ntf);
			cooperateBattleCompoment.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193BC RID: 103356 RVA: 0x007395F0 File Offset: 0x007377F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			ushort dsversion = cooperateBattleCompoment.GetDSVersion();
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

	// Token: 0x060193BD RID: 103357 RVA: 0x00739644 File Offset: 0x00737844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			cooperateBattleCompoment.SetSuccessCooperateBattleLevel(levelInfo, battleTreasures, heroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193BE RID: 103358 RVA: 0x007396B8 File Offset: 0x007378B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			string s = cooperateBattleCompoment.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060193BF RID: 103359 RVA: 0x00739714 File Offset: 0x00737914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193C0 RID: 103360 RVA: 0x00739768 File Offset: 0x00737968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193C1 RID: 103361 RVA: 0x007397BC File Offset: 0x007379BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193C2 RID: 103362 RVA: 0x00739810 File Offset: 0x00737A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193C3 RID: 103363 RVA: 0x0073986C File Offset: 0x00737A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193C4 RID: 103364 RVA: 0x007398C0 File Offset: 0x00737AC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckCooperateBattleAvailable(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int cooperateBattleID;
			LuaObject.checkType(l, 2, out cooperateBattleID);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_CheckCooperateBattleAvailable(cooperateBattleID, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193C5 RID: 103365 RVA: 0x0073993C File Offset: 0x00737B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckCooperateBattleDisplayable(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int cooperateBattleID;
			LuaObject.checkType(l, 2, out cooperateBattleID);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_CheckCooperateBattleDisplayable(cooperateBattleID);
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

	// Token: 0x060193C6 RID: 103366 RVA: 0x007399A4 File Offset: 0x00737BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_IsLevelUnlocked(levelId);
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

	// Token: 0x060193C7 RID: 103367 RVA: 0x00739A0C File Offset: 0x00737C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x060193C8 RID: 103368 RVA: 0x00739A74 File Offset: 0x00737C74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			List<int> o = cooperateBattleCompoment.m_luaExportHelper.__callBase_GetAllUnlockedLevels();
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

	// Token: 0x060193C9 RID: 103369 RVA: 0x00739AD0 File Offset: 0x00737CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			List<int> o = cooperateBattleCompoment.m_luaExportHelper.__callBase_GetAllFinishedLevels();
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

	// Token: 0x060193CA RID: 103370 RVA: 0x00739B2C File Offset: 0x00737D2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetDailyChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int i = cooperateBattleCompoment.m_luaExportHelper.__callBase_GetDailyChallengeNums(battleId);
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

	// Token: 0x060193CB RID: 103371 RVA: 0x00739B94 File Offset: 0x00737D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckCooperateBattleLevelAvailable(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i;
			LuaObject.checkType(l, 4, out i);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_CheckCooperateBattleLevelAvailable(battleId, levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193CC RID: 103372 RVA: 0x00739C20 File Offset: 0x00737E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckPlayerOutOfBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_CheckPlayerOutOfBattle(ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193CD RID: 103373 RVA: 0x00739C90 File Offset: 0x00737E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckEnergy(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i;
			LuaObject.checkType(l, 4, out i);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_CheckEnergy(battleId, levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193CE RID: 103374 RVA: 0x00739D1C File Offset: 0x00737F1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckBag(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			int cooperateBattleId;
			LuaObject.checkType(l, 2, out cooperateBattleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i;
			LuaObject.checkType(l, 4, out i);
			bool b = cooperateBattleCompoment.m_luaExportHelper.__callBase_CheckBag(cooperateBattleId, levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193CF RID: 103375 RVA: 0x00739DA8 File Offset: 0x00737FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
				int levelId;
				LuaObject.checkType(l, 2, out levelId);
				int i = cooperateBattleCompoment.m_luaExportHelper.__callBase_CanAttackCooperateBattleLevel(levelId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				CooperateBattleCompoment cooperateBattleCompoment2 = (CooperateBattleCompoment)LuaObject.checkSelf(l);
				int battleId;
				LuaObject.checkType(l, 2, out battleId);
				int levelId2;
				LuaObject.checkType(l, 3, out levelId2);
				int i2 = cooperateBattleCompoment2.m_luaExportHelper.__callBase_CanAttackCooperateBattleLevel(battleId, levelId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_CanAttackCooperateBattleLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D0 RID: 103376 RVA: 0x00739E8C File Offset: 0x0073808C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo level;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_SetCommonSuccessCooperateBattleLevel(level, heroes, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D1 RID: 103377 RVA: 0x00739F04 File Offset: 0x00738104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FinishedCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompoment cooperateBattleCompoment = (CooperateBattleCompoment)LuaObject.checkSelf(l);
			CooperateBattleLevel level;
			LuaObject.checkType<CooperateBattleLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			cooperateBattleCompoment.m_luaExportHelper.__callBase_FinishedCooperateBattleLevel(level, heroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D2 RID: 103378 RVA: 0x00739F70 File Offset: 0x00738170
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.CooperateBattleCompoment");
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.SetSuccessCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CheckCooperateBattleAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CheckCooperateBattleDisplayable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_GetDailyChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CheckCooperateBattleLevelAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CheckPlayerOutOfBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CheckEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CheckBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_CanAttackCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_SetCommonSuccessCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.__callBase_FinishedCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.<>f__mg$cache1A, typeof(CooperateBattleCompoment), typeof(CooperateBattleCompomentCommon));
	}

	// Token: 0x0400F81D RID: 63517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F81E RID: 63518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F81F RID: 63519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F820 RID: 63520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F821 RID: 63521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F822 RID: 63522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F823 RID: 63523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F824 RID: 63524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F825 RID: 63525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F826 RID: 63526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F827 RID: 63527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F828 RID: 63528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F829 RID: 63529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F82A RID: 63530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F82B RID: 63531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F82C RID: 63532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F82D RID: 63533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F82E RID: 63534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F82F RID: 63535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F830 RID: 63536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F831 RID: 63537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F832 RID: 63538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F833 RID: 63539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F834 RID: 63540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F835 RID: 63541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F836 RID: 63542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F837 RID: 63543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
