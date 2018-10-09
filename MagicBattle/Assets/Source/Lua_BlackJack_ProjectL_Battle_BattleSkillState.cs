using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200119D RID: 4509
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleSkillState : LuaObject
{
	// Token: 0x0601746F RID: 95343 RVA: 0x00651B24 File Offset: 0x0064FD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState o = new BattleSkillState();
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

	// Token: 0x06017470 RID: 95344 RVA: 0x00651B6C File Offset: 0x0064FD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState battleSkillState = (BattleSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillState.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017471 RID: 95345 RVA: 0x00651BC0 File Offset: 0x0064FDC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState battleSkillState = (BattleSkillState)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			battleSkillState.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017472 RID: 95346 RVA: 0x00651C18 File Offset: 0x0064FE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooldown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState battleSkillState = (BattleSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillState.m_cooldown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017473 RID: 95347 RVA: 0x00651C6C File Offset: 0x0064FE6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cooldown(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState battleSkillState = (BattleSkillState)LuaObject.checkSelf(l);
			int cooldown;
			LuaObject.checkType(l, 2, out cooldown);
			battleSkillState.m_cooldown = cooldown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017474 RID: 95348 RVA: 0x00651CC4 File Offset: 0x0064FEC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isSkillUseable(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState battleSkillState = (BattleSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSkillState.m_isSkillUseable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017475 RID: 95349 RVA: 0x00651D18 File Offset: 0x0064FF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSkillUseable(IntPtr l)
	{
		int result;
		try
		{
			BattleSkillState battleSkillState = (BattleSkillState)LuaObject.checkSelf(l);
			bool isSkillUseable;
			LuaObject.checkType(l, 2, out isSkillUseable);
			battleSkillState.m_isSkillUseable = isSkillUseable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017476 RID: 95350 RVA: 0x00651D70 File Offset: 0x0064FF70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleSkillState");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache1, true);
		string name2 = "m_cooldown";
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.get_m_cooldown);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.set_m_cooldown);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache3, true);
		string name3 = "m_isSkillUseable";
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.get_m_isSkillUseable);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.set_m_isSkillUseable);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleSkillState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleSkillState.<>f__mg$cache6, typeof(BattleSkillState));
	}

	// Token: 0x0400DB17 RID: 56087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB18 RID: 56088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB19 RID: 56089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB1A RID: 56090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB1B RID: 56091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB1C RID: 56092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB1D RID: 56093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
