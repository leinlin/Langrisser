using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A1 RID: 4513
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleWinConditionState : LuaObject
{
	// Token: 0x060174B5 RID: 95413 RVA: 0x006539B0 File Offset: 0x00651BB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState o = new BattleWinConditionState();
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

	// Token: 0x060174B6 RID: 95414 RVA: 0x006539F8 File Offset: 0x00651BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState battleWinConditionState = (BattleWinConditionState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleWinConditionState.m_conditionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B7 RID: 95415 RVA: 0x00653A4C File Offset: 0x00651C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState battleWinConditionState = (BattleWinConditionState)LuaObject.checkSelf(l);
			int conditionId;
			LuaObject.checkType(l, 2, out conditionId);
			battleWinConditionState.m_conditionId = conditionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B8 RID: 95416 RVA: 0x00653AA4 File Offset: 0x00651CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState battleWinConditionState = (BattleWinConditionState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleWinConditionState.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B9 RID: 95417 RVA: 0x00653AF8 File Offset: 0x00651CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState battleWinConditionState = (BattleWinConditionState)LuaObject.checkSelf(l);
			BattleConditionStatus status;
			LuaObject.checkEnum<BattleConditionStatus>(l, 2, out status);
			battleWinConditionState.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174BA RID: 95418 RVA: 0x00653B50 File Offset: 0x00651D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState battleWinConditionState = (BattleWinConditionState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleWinConditionState.m_winConditionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174BB RID: 95419 RVA: 0x00653BA4 File Offset: 0x00651DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleWinConditionState battleWinConditionState = (BattleWinConditionState)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			battleWinConditionState.m_winConditionInfo = winConditionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174BC RID: 95420 RVA: 0x00653BFC File Offset: 0x00651DFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleWinConditionState");
		string name = "m_conditionId";
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.get_m_conditionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.set_m_conditionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache1, true);
		string name2 = "m_status";
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.get_m_status);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.set_m_status);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache3, true);
		string name3 = "m_winConditionInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.get_m_winConditionInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.set_m_winConditionInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.<>f__mg$cache6, typeof(BattleWinConditionState));
	}

	// Token: 0x0400DB55 RID: 56149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB56 RID: 56150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB57 RID: 56151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB58 RID: 56152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB59 RID: 56153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB5A RID: 56154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB5B RID: 56155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
