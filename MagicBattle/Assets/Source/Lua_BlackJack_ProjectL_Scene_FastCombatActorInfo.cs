using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001341 RID: 4929
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo : LuaObject
{
	// Token: 0x0601A794 RID: 108436 RVA: 0x007D841C File Offset: 0x007D661C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo o = new FastCombatActorInfo();
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

	// Token: 0x0601A795 RID: 108437 RVA: 0x007D8464 File Offset: 0x007D6664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleActor(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_battleActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A796 RID: 108438 RVA: 0x007D84B8 File Offset: 0x007D66B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleActor(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			BattleActor battleActor;
			LuaObject.checkType<BattleActor>(l, 2, out battleActor);
			fastCombatActorInfo.m_battleActor = battleActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A797 RID: 108439 RVA: 0x007D8510 File Offset: 0x007D6710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHpMax(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_heroHpMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A798 RID: 108440 RVA: 0x007D8564 File Offset: 0x007D6764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHpMax(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int heroHpMax;
			LuaObject.checkType(l, 2, out heroHpMax);
			fastCombatActorInfo.m_heroHpMax = heroHpMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A799 RID: 108441 RVA: 0x007D85BC File Offset: 0x007D67BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHpMax(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_soldierHpMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A79A RID: 108442 RVA: 0x007D8610 File Offset: 0x007D6810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHpMax(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int soldierHpMax;
			LuaObject.checkType(l, 2, out soldierHpMax);
			fastCombatActorInfo.m_soldierHpMax = soldierHpMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A79B RID: 108443 RVA: 0x007D8668 File Offset: 0x007D6868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beforeHeroHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_beforeHeroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A79C RID: 108444 RVA: 0x007D86BC File Offset: 0x007D68BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beforeHeroHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int beforeHeroHp;
			LuaObject.checkType(l, 2, out beforeHeroHp);
			fastCombatActorInfo.m_beforeHeroHp = beforeHeroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A79D RID: 108445 RVA: 0x007D8714 File Offset: 0x007D6914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beforeSoldierHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_beforeSoldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A79E RID: 108446 RVA: 0x007D8768 File Offset: 0x007D6968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beforeSoldierHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int beforeSoldierHp;
			LuaObject.checkType(l, 2, out beforeSoldierHp);
			fastCombatActorInfo.m_beforeSoldierHp = beforeSoldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A79F RID: 108447 RVA: 0x007D87C0 File Offset: 0x007D69C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterHeroHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_afterHeroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A0 RID: 108448 RVA: 0x007D8814 File Offset: 0x007D6A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterHeroHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int afterHeroHp;
			LuaObject.checkType(l, 2, out afterHeroHp);
			fastCombatActorInfo.m_afterHeroHp = afterHeroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A1 RID: 108449 RVA: 0x007D886C File Offset: 0x007D6A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterSoldierHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_afterSoldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A2 RID: 108450 RVA: 0x007D88C0 File Offset: 0x007D6AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterSoldierHp(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int afterSoldierHp;
			LuaObject.checkType(l, 2, out afterSoldierHp);
			fastCombatActorInfo.m_afterSoldierHp = afterSoldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A3 RID: 108451 RVA: 0x007D8918 File Offset: 0x007D6B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDamage(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_heroDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A4 RID: 108452 RVA: 0x007D896C File Offset: 0x007D6B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDamage(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int heroDamage;
			LuaObject.checkType(l, 2, out heroDamage);
			fastCombatActorInfo.m_heroDamage = heroDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A5 RID: 108453 RVA: 0x007D89C4 File Offset: 0x007D6BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDamage(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_soldierDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A6 RID: 108454 RVA: 0x007D8A18 File Offset: 0x007D6C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDamage(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			int soldierDamage;
			LuaObject.checkType(l, 2, out soldierDamage);
			fastCombatActorInfo.m_soldierDamage = soldierDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A7 RID: 108455 RVA: 0x007D8A70 File Offset: 0x007D6C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isReceiveCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fastCombatActorInfo.m_isReceiveCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A8 RID: 108456 RVA: 0x007D8AC4 File Offset: 0x007D6CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isReceiveCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			FastCombatActorInfo fastCombatActorInfo = (FastCombatActorInfo)LuaObject.checkSelf(l);
			bool isReceiveCriticalAttack;
			LuaObject.checkType(l, 2, out isReceiveCriticalAttack);
			fastCombatActorInfo.m_isReceiveCriticalAttack = isReceiveCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7A9 RID: 108457 RVA: 0x007D8B1C File Offset: 0x007D6D1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.FastCombatActorInfo");
		string name = "m_battleActor";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_battleActor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_battleActor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache1, true);
		string name2 = "m_heroHpMax";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_heroHpMax);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_heroHpMax);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache3, true);
		string name3 = "m_soldierHpMax";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_soldierHpMax);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_soldierHpMax);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache5, true);
		string name4 = "m_beforeHeroHp";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_beforeHeroHp);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_beforeHeroHp);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache7, true);
		string name5 = "m_beforeSoldierHp";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_beforeSoldierHp);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_beforeSoldierHp);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache9, true);
		string name6 = "m_afterHeroHp";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_afterHeroHp);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_afterHeroHp);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheB, true);
		string name7 = "m_afterSoldierHp";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_afterSoldierHp);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_afterSoldierHp);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheD, true);
		string name8 = "m_heroDamage";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_heroDamage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_heroDamage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cacheF, true);
		string name9 = "m_soldierDamage";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_soldierDamage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_soldierDamage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache11, true);
		string name10 = "m_isReceiveCriticalAttack";
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.get_m_isReceiveCriticalAttack);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.set_m_isReceiveCriticalAttack);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache13, true);
		if (Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.<>f__mg$cache14, typeof(FastCombatActorInfo));
	}

	// Token: 0x04010AF4 RID: 68340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010AF5 RID: 68341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010AF6 RID: 68342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010AF7 RID: 68343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010AF8 RID: 68344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010AF9 RID: 68345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010AFA RID: 68346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010AFB RID: 68347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010AFC RID: 68348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010AFD RID: 68349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010AFE RID: 68350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010AFF RID: 68351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010B00 RID: 68352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010B01 RID: 68353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010B02 RID: 68354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010B03 RID: 68355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010B04 RID: 68356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010B05 RID: 68357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010B06 RID: 68358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010B07 RID: 68359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010B08 RID: 68360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
