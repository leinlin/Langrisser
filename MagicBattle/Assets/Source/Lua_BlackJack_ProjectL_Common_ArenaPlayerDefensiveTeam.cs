using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011BF RID: 4543
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam : LuaObject
{
	// Token: 0x0601788A RID: 96394 RVA: 0x006706B8 File Offset: 0x0066E8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam o = new ArenaPlayerDefensiveTeam();
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

	// Token: 0x0601788B RID: 96395 RVA: 0x00670700 File Offset: 0x0066E900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBArenaDefensiveTeamToArenaDefensiveTeam_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaPlayerDefensiveTeam pbDefensiveTeam;
			LuaObject.checkType<ProArenaPlayerDefensiveTeam>(l, 1, out pbDefensiveTeam);
			ArenaPlayerDefensiveTeam o = ArenaPlayerDefensiveTeam.PBArenaDefensiveTeamToArenaDefensiveTeam(pbDefensiveTeam);
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

	// Token: 0x0601788C RID: 96396 RVA: 0x00670754 File Offset: 0x0066E954
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ArenaDefensiveTeamToPBArenaDefensiveTeam_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam defensiveTeam;
			LuaObject.checkType<ArenaPlayerDefensiveTeam>(l, 1, out defensiveTeam);
			ProArenaPlayerDefensiveTeam o = ArenaPlayerDefensiveTeam.ArenaDefensiveTeamToPBArenaDefensiveTeam(defensiveTeam);
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

	// Token: 0x0601788D RID: 96397 RVA: 0x006707A8 File Offset: 0x0066E9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = (ArenaPlayerDefensiveTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeam.Heroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601788E RID: 96398 RVA: 0x006707FC File Offset: 0x0066E9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Heroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = (ArenaPlayerDefensiveTeam)LuaObject.checkSelf(l);
			List<ArenaPlayerDefensiveHero> heroes;
			LuaObject.checkType<List<ArenaPlayerDefensiveHero>>(l, 2, out heroes);
			arenaPlayerDefensiveTeam.Heroes = heroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601788F RID: 96399 RVA: 0x00670854 File Offset: 0x0066EA54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = (ArenaPlayerDefensiveTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeam.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017890 RID: 96400 RVA: 0x006708A8 File Offset: 0x0066EAA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = (ArenaPlayerDefensiveTeam)LuaObject.checkSelf(l);
			byte battleId;
			LuaObject.checkType(l, 2, out battleId);
			arenaPlayerDefensiveTeam.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017891 RID: 96401 RVA: 0x00670900 File Offset: 0x0066EB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaDefenderRuleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = (ArenaPlayerDefensiveTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeam.ArenaDefenderRuleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017892 RID: 96402 RVA: 0x00670954 File Offset: 0x0066EB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaDefenderRuleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = (ArenaPlayerDefensiveTeam)LuaObject.checkSelf(l);
			byte arenaDefenderRuleId;
			LuaObject.checkType(l, 2, out arenaDefenderRuleId);
			arenaPlayerDefensiveTeam.ArenaDefenderRuleId = arenaDefenderRuleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017893 RID: 96403 RVA: 0x006709AC File Offset: 0x0066EBAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaPlayerDefensiveTeam");
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.PBArenaDefensiveTeamToArenaDefensiveTeam_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.ArenaDefensiveTeamToPBArenaDefensiveTeam_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache1);
		string name = "Heroes";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.get_Heroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.set_Heroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache3, true);
		string name2 = "BattleId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.get_BattleId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.set_BattleId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache5, true);
		string name3 = "ArenaDefenderRuleId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.get_ArenaDefenderRuleId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.set_ArenaDefenderRuleId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.<>f__mg$cache8, typeof(ArenaPlayerDefensiveTeam));
	}

	// Token: 0x0400DEEE RID: 57070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DEEF RID: 57071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DEF0 RID: 57072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DEF1 RID: 57073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DEF2 RID: 57074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DEF3 RID: 57075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DEF4 RID: 57076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DEF5 RID: 57077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DEF6 RID: 57078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
