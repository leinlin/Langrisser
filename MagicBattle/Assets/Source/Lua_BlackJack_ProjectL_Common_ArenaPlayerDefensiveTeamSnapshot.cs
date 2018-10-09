using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C0 RID: 4544
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot : LuaObject
{
	// Token: 0x06017895 RID: 96405 RVA: 0x00670B14 File Offset: 0x0066ED14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot o = new ArenaPlayerDefensiveTeamSnapshot();
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

	// Token: 0x06017896 RID: 96406 RVA: 0x00670B5C File Offset: 0x0066ED5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefenderHeroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeamSnapshot.DefenderHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017897 RID: 96407 RVA: 0x00670BB0 File Offset: 0x0066EDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefenderHeroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			List<BattleHero> defenderHeroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out defenderHeroes);
			arenaPlayerDefensiveTeamSnapshot.DefenderHeroes = defenderHeroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017898 RID: 96408 RVA: 0x00670C08 File Offset: 0x0066EE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Techs(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeamSnapshot.Techs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017899 RID: 96409 RVA: 0x00670C5C File Offset: 0x0066EE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Techs(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			arenaPlayerDefensiveTeamSnapshot.Techs = techs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601789A RID: 96410 RVA: 0x00670CB4 File Offset: 0x0066EEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeamSnapshot.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601789B RID: 96411 RVA: 0x00670D08 File Offset: 0x0066EF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			arenaPlayerDefensiveTeamSnapshot.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601789C RID: 96412 RVA: 0x00670D60 File Offset: 0x0066EF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaDefenderRuleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeamSnapshot.ArenaDefenderRuleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601789D RID: 96413 RVA: 0x00670DB4 File Offset: 0x0066EFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaDefenderRuleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			int arenaDefenderRuleId;
			LuaObject.checkType(l, 2, out arenaDefenderRuleId);
			arenaPlayerDefensiveTeamSnapshot.ArenaDefenderRuleId = arenaDefenderRuleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601789E RID: 96414 RVA: 0x00670E0C File Offset: 0x0066F00C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveTeamSnapshot.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601789F RID: 96415 RVA: 0x00670E60 File Offset: 0x0066F060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveTeamSnapshot arenaPlayerDefensiveTeamSnapshot = (ArenaPlayerDefensiveTeamSnapshot)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			arenaPlayerDefensiveTeamSnapshot.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178A0 RID: 96416 RVA: 0x00670EB8 File Offset: 0x0066F0B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaPlayerDefensiveTeamSnapshot");
		string name = "DefenderHeroes";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.get_DefenderHeroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.set_DefenderHeroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache1, true);
		string name2 = "Techs";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.get_Techs);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.set_Techs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache3, true);
		string name3 = "BattleId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.get_BattleId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.set_BattleId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache5, true);
		string name4 = "ArenaDefenderRuleId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.get_ArenaDefenderRuleId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.set_ArenaDefenderRuleId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache7, true);
		string name5 = "PlayerLevel";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.get_PlayerLevel);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.set_PlayerLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.<>f__mg$cacheA, typeof(ArenaPlayerDefensiveTeamSnapshot));
	}

	// Token: 0x0400DEF7 RID: 57079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DEF8 RID: 57080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DEF9 RID: 57081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DEFA RID: 57082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DEFB RID: 57083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DEFC RID: 57084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DEFD RID: 57085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DEFE RID: 57086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DEFF RID: 57087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DF00 RID: 57088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DF01 RID: 57089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
