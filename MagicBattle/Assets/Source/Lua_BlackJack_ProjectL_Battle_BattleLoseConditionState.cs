using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001196 RID: 4502
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState : LuaObject
{
	// Token: 0x060173D6 RID: 95190 RVA: 0x0064D708 File Offset: 0x0064B908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState o = new BattleLoseConditionState();
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

	// Token: 0x060173D7 RID: 95191 RVA: 0x0064D750 File Offset: 0x0064B950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState battleLoseConditionState = (BattleLoseConditionState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseConditionState.m_conditionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D8 RID: 95192 RVA: 0x0064D7A4 File Offset: 0x0064B9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState battleLoseConditionState = (BattleLoseConditionState)LuaObject.checkSelf(l);
			int conditionId;
			LuaObject.checkType(l, 2, out conditionId);
			battleLoseConditionState.m_conditionId = conditionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D9 RID: 95193 RVA: 0x0064D7FC File Offset: 0x0064B9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState battleLoseConditionState = (BattleLoseConditionState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleLoseConditionState.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173DA RID: 95194 RVA: 0x0064D850 File Offset: 0x0064BA50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState battleLoseConditionState = (BattleLoseConditionState)LuaObject.checkSelf(l);
			BattleConditionStatus status;
			LuaObject.checkEnum<BattleConditionStatus>(l, 2, out status);
			battleLoseConditionState.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173DB RID: 95195 RVA: 0x0064D8A8 File Offset: 0x0064BAA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loseConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState battleLoseConditionState = (BattleLoseConditionState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseConditionState.m_loseConditionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173DC RID: 95196 RVA: 0x0064D8FC File Offset: 0x0064BAFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loseConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseConditionState battleLoseConditionState = (BattleLoseConditionState)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo loseConditionInfo;
			LuaObject.checkType<ConfigDataBattleLoseConditionInfo>(l, 2, out loseConditionInfo);
			battleLoseConditionState.m_loseConditionInfo = loseConditionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173DD RID: 95197 RVA: 0x0064D954 File Offset: 0x0064BB54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleLoseConditionState");
		string name = "m_conditionId";
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.get_m_conditionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.set_m_conditionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache1, true);
		string name2 = "m_status";
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.get_m_status);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.set_m_status);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache3, true);
		string name3 = "m_loseConditionInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.get_m_loseConditionInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.set_m_loseConditionInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.<>f__mg$cache6, typeof(BattleLoseConditionState));
	}

	// Token: 0x0400DA8C RID: 55948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DA8D RID: 55949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DA8E RID: 55950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DA8F RID: 55951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DA90 RID: 55952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DA91 RID: 55953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DA92 RID: 55954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
