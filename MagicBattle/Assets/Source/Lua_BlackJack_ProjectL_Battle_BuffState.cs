using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A4 RID: 4516
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BuffState : LuaObject
{
	// Token: 0x060174E1 RID: 95457 RVA: 0x00654CFC File Offset: 0x00652EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 2, out id);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 3, out buffInfo);
			BattleActor applyer;
			LuaObject.checkType<BattleActor>(l, 4, out applyer);
			BuffSourceType sourceType;
			LuaObject.checkEnum<BuffSourceType>(l, 5, out sourceType);
			ConfigDataSkillInfo sourceSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 6, out sourceSkillInfo);
			BuffState o = new BuffState(id, buffInfo, applyer, sourceType, sourceSkillInfo);
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

	// Token: 0x060174E2 RID: 95458 RVA: 0x00654D84 File Offset: 0x00652F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChild(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			bool b = buffState.IsChild();
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

	// Token: 0x060174E3 RID: 95459 RVA: 0x00654DD8 File Offset: 0x00652FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanNotDispel(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			bool b = buffState.CanNotDispel();
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

	// Token: 0x060174E4 RID: 95460 RVA: 0x00654E2C File Offset: 0x0065302C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_id(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174E5 RID: 95461 RVA: 0x00654E80 File Offset: 0x00653080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_id(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			buffState.m_id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174E6 RID: 95462 RVA: 0x00654ED8 File Offset: 0x006530D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_displayOrder(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_displayOrder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174E7 RID: 95463 RVA: 0x00654F2C File Offset: 0x0065312C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_displayOrder(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			int displayOrder;
			LuaObject.checkType(l, 2, out displayOrder);
			buffState.m_displayOrder = displayOrder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174E8 RID: 95464 RVA: 0x00654F84 File Offset: 0x00653184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffInfo(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_buffInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174E9 RID: 95465 RVA: 0x00654FD8 File Offset: 0x006531D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buffInfo(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buffInfo);
			buffState.m_buffInfo = buffInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174EA RID: 95466 RVA: 0x00655030 File Offset: 0x00653230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sourceType(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)buffState.m_sourceType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174EB RID: 95467 RVA: 0x00655084 File Offset: 0x00653284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_sourceType(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			BuffSourceType sourceType;
			LuaObject.checkEnum<BuffSourceType>(l, 2, out sourceType);
			buffState.m_sourceType = sourceType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174EC RID: 95468 RVA: 0x006550DC File Offset: 0x006532DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sourceSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_sourceSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174ED RID: 95469 RVA: 0x00655130 File Offset: 0x00653330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sourceSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			ConfigDataSkillInfo sourceSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out sourceSkillInfo);
			buffState.m_sourceSkillInfo = sourceSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174EE RID: 95470 RVA: 0x00655188 File Offset: 0x00653388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174EF RID: 95471 RVA: 0x006551DC File Offset: 0x006533DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			int time;
			LuaObject.checkType(l, 2, out time);
			buffState.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F0 RID: 95472 RVA: 0x00655234 File Offset: 0x00653434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectTimes(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_effectTimes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F1 RID: 95473 RVA: 0x00655288 File Offset: 0x00653488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_effectTimes(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			int effectTimes;
			LuaObject.checkType(l, 2, out effectTimes);
			buffState.m_effectTimes = effectTimes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F2 RID: 95474 RVA: 0x006552E0 File Offset: 0x006534E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasExtraTime(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_hasExtraTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F3 RID: 95475 RVA: 0x00655334 File Offset: 0x00653534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hasExtraTime(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			bool hasExtraTime;
			LuaObject.checkType(l, 2, out hasExtraTime);
			buffState.m_hasExtraTime = hasExtraTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F4 RID: 95476 RVA: 0x0065538C File Offset: 0x0065358C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_applyer(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_applyer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F5 RID: 95477 RVA: 0x006553E0 File Offset: 0x006535E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_applyer(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			BattleActor applyer;
			LuaObject.checkType<BattleActor>(l, 2, out applyer);
			buffState.m_applyer = applyer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F6 RID: 95478 RVA: 0x00655438 File Offset: 0x00653638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_parent(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffState.m_parent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F7 RID: 95479 RVA: 0x0065548C File Offset: 0x0065368C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_parent(IntPtr l)
	{
		int result;
		try
		{
			BuffState buffState = (BuffState)LuaObject.checkSelf(l);
			BuffState parent;
			LuaObject.checkType<BuffState>(l, 2, out parent);
			buffState.m_parent = parent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174F8 RID: 95480 RVA: 0x006554E4 File Offset: 0x006536E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BuffState");
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.IsChild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.CanNotDispel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache1);
		string name = "m_id";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache3, true);
		string name2 = "m_displayOrder";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_displayOrder);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_displayOrder);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache5, true);
		string name3 = "m_buffInfo";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_buffInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_buffInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache7, true);
		string name4 = "m_sourceType";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_sourceType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_sourceType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache9, true);
		string name5 = "m_sourceSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_sourceSkillInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_sourceSkillInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheB, true);
		string name6 = "m_time";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_time);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_time);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheD, true);
		string name7 = "m_effectTimes";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_effectTimes);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_effectTimes);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cacheF, true);
		string name8 = "m_hasExtraTime";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_hasExtraTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_hasExtraTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache11, true);
		string name9 = "m_applyer";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_applyer);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_applyer);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache13, true);
		string name10 = "m_parent";
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.get_m_parent);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.set_m_parent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache15, true);
		if (Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BuffState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BuffState.<>f__mg$cache16, typeof(BuffState));
	}

	// Token: 0x0400DB7B RID: 56187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB7C RID: 56188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB7D RID: 56189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB7E RID: 56190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB7F RID: 56191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB80 RID: 56192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB81 RID: 56193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DB82 RID: 56194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DB83 RID: 56195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DB84 RID: 56196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DB85 RID: 56197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DB86 RID: 56198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DB87 RID: 56199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DB88 RID: 56200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DB89 RID: 56201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DB8A RID: 56202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DB8B RID: 56203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DB8C RID: 56204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DB8D RID: 56205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DB8E RID: 56206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DB8F RID: 56207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DB90 RID: 56208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DB91 RID: 56209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
