using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011BE RID: 4542
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero : LuaObject
{
	// Token: 0x0601787E RID: 96382 RVA: 0x006701E8 File Offset: 0x0066E3E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero o = new ArenaPlayerDefensiveHero();
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

	// Token: 0x0601787F RID: 96383 RVA: 0x00670230 File Offset: 0x0066E430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBArenaDefensiveHeroToArenaDefensiveHero_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaPlayerDefensiveHero pbDefensiveHero;
			LuaObject.checkType<ProArenaPlayerDefensiveHero>(l, 1, out pbDefensiveHero);
			ArenaPlayerDefensiveHero o = ArenaPlayerDefensiveHero.PBArenaDefensiveHeroToArenaDefensiveHero(pbDefensiveHero);
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

	// Token: 0x06017880 RID: 96384 RVA: 0x00670284 File Offset: 0x0066E484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefensiveHeroToPBDfensiveHero_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero defensiveHero;
			LuaObject.checkType<ArenaPlayerDefensiveHero>(l, 1, out defensiveHero);
			ProArenaPlayerDefensiveHero o = ArenaPlayerDefensiveHero.ArenaDefensiveHeroToPBDfensiveHero(defensiveHero);
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

	// Token: 0x06017881 RID: 96385 RVA: 0x006702D8 File Offset: 0x0066E4D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroToArenaDefensiveHero_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			ArenaPlayerDefensiveHero o = ArenaPlayerDefensiveHero.HeroToArenaDefensiveHero(hero);
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

	// Token: 0x06017882 RID: 96386 RVA: 0x0067032C File Offset: 0x0066E52C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = (ArenaPlayerDefensiveHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveHero.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017883 RID: 96387 RVA: 0x00670380 File Offset: 0x0066E580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = (ArenaPlayerDefensiveHero)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			arenaPlayerDefensiveHero.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017884 RID: 96388 RVA: 0x006703D8 File Offset: 0x0066E5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = (ArenaPlayerDefensiveHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveHero.ActionPositionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017885 RID: 96389 RVA: 0x0067042C File Offset: 0x0066E62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActionPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = (ArenaPlayerDefensiveHero)LuaObject.checkSelf(l);
			int actionPositionIndex;
			LuaObject.checkType(l, 2, out actionPositionIndex);
			arenaPlayerDefensiveHero.ActionPositionIndex = actionPositionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017886 RID: 96390 RVA: 0x00670484 File Offset: 0x0066E684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = (ArenaPlayerDefensiveHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerDefensiveHero.ActionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017887 RID: 96391 RVA: 0x006704D8 File Offset: 0x0066E6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = (ArenaPlayerDefensiveHero)LuaObject.checkSelf(l);
			int actionValue;
			LuaObject.checkType(l, 2, out actionValue);
			arenaPlayerDefensiveHero.ActionValue = actionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017888 RID: 96392 RVA: 0x00670530 File Offset: 0x0066E730
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaPlayerDefensiveHero");
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.PBArenaDefensiveHeroToArenaDefensiveHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.ArenaDefensiveHeroToPBDfensiveHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.HeroToArenaDefensiveHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache2);
		string name = "HeroId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.get_HeroId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.set_HeroId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache4, true);
		string name2 = "ActionPositionIndex";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.get_ActionPositionIndex);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.set_ActionPositionIndex);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache6, true);
		string name3 = "ActionValue";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.get_ActionValue);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.set_ActionValue);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache8, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.<>f__mg$cache9, typeof(ArenaPlayerDefensiveHero));
	}

	// Token: 0x0400DEE4 RID: 57060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DEE5 RID: 57061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DEE6 RID: 57062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DEE7 RID: 57063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DEE8 RID: 57064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DEE9 RID: 57065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DEEA RID: 57066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DEEB RID: 57067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DEEC RID: 57068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DEED RID: 57069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
