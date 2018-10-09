using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200119F RID: 4511
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleTeamSetup : LuaObject
{
	// Token: 0x060174A6 RID: 95398 RVA: 0x0065344C File Offset: 0x0065164C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamSetup o = new BattleTeamSetup();
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

	// Token: 0x060174A7 RID: 95399 RVA: 0x00653494 File Offset: 0x00651694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamSetup battleTeamSetup = (BattleTeamSetup)LuaObject.checkSelf(l);
			battleTeamSetup.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A8 RID: 95400 RVA: 0x006534E0 File Offset: 0x006516E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actors(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamSetup battleTeamSetup = (BattleTeamSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamSetup.m_actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A9 RID: 95401 RVA: 0x00653534 File Offset: 0x00651734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actors(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamSetup battleTeamSetup = (BattleTeamSetup)LuaObject.checkSelf(l);
			List<BattleActorSetup> actors;
			LuaObject.checkType<List<BattleActorSetup>>(l, 2, out actors);
			battleTeamSetup.m_actors = actors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174AA RID: 95402 RVA: 0x0065358C File Offset: 0x0065178C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleTeamSetup");
		if (Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache0);
		string name = "m_actors";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.get_m_actors);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.set_m_actors);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.<>f__mg$cache3, typeof(BattleTeamSetup));
	}

	// Token: 0x0400DB4A RID: 56138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB4B RID: 56139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB4C RID: 56140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB4D RID: 56141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
