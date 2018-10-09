using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001402 RID: 5122
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CombatUIController_HPState : LuaObject
{
	// Token: 0x0601CDD8 RID: 118232 RVA: 0x00907C08 File Offset: 0x00905E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState o = new CombatUIController.HPState();
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

	// Token: 0x0601CDD9 RID: 118233 RVA: 0x00907C50 File Offset: 0x00905E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_combatCharUIController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hpstate.m_combatCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDDA RID: 118234 RVA: 0x00907CA4 File Offset: 0x00905EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatCharUIController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			CombatCharUIController combatCharUIController;
			LuaObject.checkType<CombatCharUIController>(l, 2, out combatCharUIController);
			hpstate.m_combatCharUIController = combatCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDDB RID: 118235 RVA: 0x00907CFC File Offset: 0x00905EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalHpPercent(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hpstate.m_totalHpPercent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDDC RID: 118236 RVA: 0x00907D50 File Offset: 0x00905F50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_totalHpPercent(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			float totalHpPercent;
			LuaObject.checkType(l, 2, out totalHpPercent);
			hpstate.m_totalHpPercent = totalHpPercent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDDD RID: 118237 RVA: 0x00907DA8 File Offset: 0x00905FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDamages(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hpstate.m_heroDamages);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDDE RID: 118238 RVA: 0x00907DFC File Offset: 0x00905FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDamages(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			List<CombatUIController.Damage> heroDamages;
			LuaObject.checkType<List<CombatUIController.Damage>>(l, 2, out heroDamages);
			hpstate.m_heroDamages = heroDamages;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDDF RID: 118239 RVA: 0x00907E54 File Offset: 0x00906054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDamages(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hpstate.m_soldierDamages);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE0 RID: 118240 RVA: 0x00907EA8 File Offset: 0x009060A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDamages(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			List<CombatUIController.Damage> soldierDamages;
			LuaObject.checkType<List<CombatUIController.Damage>>(l, 2, out soldierDamages);
			hpstate.m_soldierDamages = soldierDamages;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE1 RID: 118241 RVA: 0x00907F00 File Offset: 0x00906100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hpstate.m_isCritical);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE2 RID: 118242 RVA: 0x00907F54 File Offset: 0x00906154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController.HPState hpstate = (CombatUIController.HPState)LuaObject.checkSelf(l);
			bool isCritical;
			LuaObject.checkType(l, 2, out isCritical);
			hpstate.m_isCritical = isCritical;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE3 RID: 118243 RVA: 0x00907FAC File Offset: 0x009061AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CombatUIController.HPState");
		string name = "m_combatCharUIController";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.get_m_combatCharUIController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.set_m_combatCharUIController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache1, true);
		string name2 = "m_totalHpPercent";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.get_m_totalHpPercent);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.set_m_totalHpPercent);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache3, true);
		string name3 = "m_heroDamages";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.get_m_heroDamages);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.set_m_heroDamages);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache5, true);
		string name4 = "m_soldierDamages";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.get_m_soldierDamages);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.set_m_soldierDamages);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache7, true);
		string name5 = "m_isCritical";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.get_m_isCritical);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.set_m_isCritical);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.<>f__mg$cacheA, typeof(CombatUIController.HPState));
	}

	// Token: 0x04012FB6 RID: 77750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012FB7 RID: 77751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012FB8 RID: 77752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012FB9 RID: 77753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012FBA RID: 77754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012FBB RID: 77755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012FBC RID: 77756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012FBD RID: 77757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012FBE RID: 77758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012FBF RID: 77759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012FC0 RID: 77760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
