using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A0 RID: 4512
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleTreasureState : LuaObject
{
	// Token: 0x060174AC RID: 95404 RVA: 0x00653644 File Offset: 0x00651844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState o = new BattleTreasureState();
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

	// Token: 0x060174AD RID: 95405 RVA: 0x0065368C File Offset: 0x0065188C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState battleTreasureState = (BattleTreasureState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureState.m_battleTreasureInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174AE RID: 95406 RVA: 0x006536E0 File Offset: 0x006518E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState battleTreasureState = (BattleTreasureState)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo battleTreasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out battleTreasureInfo);
			battleTreasureState.m_battleTreasureInfo = battleTreasureInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174AF RID: 95407 RVA: 0x00653738 File Offset: 0x00651938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState battleTreasureState = (BattleTreasureState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureState.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B0 RID: 95408 RVA: 0x0065378C File Offset: 0x0065198C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState battleTreasureState = (BattleTreasureState)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			battleTreasureState.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B1 RID: 95409 RVA: 0x006537E4 File Offset: 0x006519E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGain(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState battleTreasureState = (BattleTreasureState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureState.m_isGain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B2 RID: 95410 RVA: 0x00653838 File Offset: 0x00651A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGain(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureState battleTreasureState = (BattleTreasureState)LuaObject.checkSelf(l);
			bool isGain;
			LuaObject.checkType(l, 2, out isGain);
			battleTreasureState.m_isGain = isGain;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174B3 RID: 95411 RVA: 0x00653890 File Offset: 0x00651A90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleTreasureState");
		string name = "m_battleTreasureInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.get_m_battleTreasureInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.set_m_battleTreasureInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache1, true);
		string name2 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.get_m_isOpened);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.set_m_isOpened);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache3, true);
		string name3 = "m_isGain";
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.get_m_isGain);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.set_m_isGain);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleTreasureState.<>f__mg$cache6, typeof(BattleTreasureState));
	}

	// Token: 0x0400DB4E RID: 56142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB4F RID: 56143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB50 RID: 56144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB51 RID: 56145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB52 RID: 56146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB53 RID: 56147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB54 RID: 56148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
