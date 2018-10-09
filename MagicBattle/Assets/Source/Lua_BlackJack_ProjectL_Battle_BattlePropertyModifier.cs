using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200119C RID: 4508
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier : LuaObject
{
	// Token: 0x0601745B RID: 95323 RVA: 0x0065126C File Offset: 0x0064F46C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier o = new BattlePropertyModifier();
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

	// Token: 0x0601745C RID: 95324 RVA: 0x006512B4 File Offset: 0x0064F4B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Get(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			PropertyModifyType t;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out t);
			int i = battlePropertyModifier.Get(t);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601745D RID: 95325 RVA: 0x00651318 File Offset: 0x0064F518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Collect(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			PropertyModifyType t;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out t);
			int value;
			LuaObject.checkType(l, 3, out value);
			battlePropertyModifier.Collect(t, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601745E RID: 95326 RVA: 0x0065137C File Offset: 0x0064F57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			battlePropertyModifier.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601745F RID: 95327 RVA: 0x006513C8 File Offset: 0x0064F5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_values(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.m_luaExportHelper.m_values);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017460 RID: 95328 RVA: 0x00651420 File Offset: 0x0064F620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_values(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int[] values;
			LuaObject.checkArray<int>(l, 2, out values);
			battlePropertyModifier.m_luaExportHelper.m_values = values;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017461 RID: 95329 RVA: 0x0065147C File Offset: 0x0064F67C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExchangeAttack(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.ExchangeAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017462 RID: 95330 RVA: 0x006514D0 File Offset: 0x0064F6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExchangeAttack(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int exchangeAttack;
			LuaObject.checkType(l, 2, out exchangeAttack);
			battlePropertyModifier.ExchangeAttack = exchangeAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017463 RID: 95331 RVA: 0x00651528 File Offset: 0x0064F728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExchangeDefense(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.ExchangeDefense);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017464 RID: 95332 RVA: 0x0065157C File Offset: 0x0064F77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExchangeDefense(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int exchangeDefense;
			LuaObject.checkType(l, 2, out exchangeDefense);
			battlePropertyModifier.ExchangeDefense = exchangeDefense;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017465 RID: 95333 RVA: 0x006515D4 File Offset: 0x0064F7D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExchangeMagic(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.ExchangeMagic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017466 RID: 95334 RVA: 0x00651628 File Offset: 0x0064F828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExchangeMagic(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int exchangeMagic;
			LuaObject.checkType(l, 2, out exchangeMagic);
			battlePropertyModifier.ExchangeMagic = exchangeMagic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017467 RID: 95335 RVA: 0x00651680 File Offset: 0x0064F880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExchangeMagicDefense(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.ExchangeMagicDefense);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017468 RID: 95336 RVA: 0x006516D4 File Offset: 0x0064F8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExchangeMagicDefense(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int exchangeMagicDefense;
			LuaObject.checkType(l, 2, out exchangeMagicDefense);
			battlePropertyModifier.ExchangeMagicDefense = exchangeMagicDefense;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017469 RID: 95337 RVA: 0x0065172C File Offset: 0x0064F92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExchangeDexterity(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.ExchangeDexterity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601746A RID: 95338 RVA: 0x00651780 File Offset: 0x0064F980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ExchangeDexterity(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int exchangeDexterity;
			LuaObject.checkType(l, 2, out exchangeDexterity);
			battlePropertyModifier.ExchangeDexterity = exchangeDexterity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601746B RID: 95339 RVA: 0x006517D8 File Offset: 0x0064F9D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExchangeHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePropertyModifier.ExchangeHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601746C RID: 95340 RVA: 0x0065182C File Offset: 0x0064FA2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ExchangeHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePropertyModifier battlePropertyModifier = (BattlePropertyModifier)LuaObject.checkSelf(l);
			int exchangeHealthPointMax;
			LuaObject.checkType(l, 2, out exchangeHealthPointMax);
			battlePropertyModifier.ExchangeHealthPointMax = exchangeHealthPointMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601746D RID: 95341 RVA: 0x00651884 File Offset: 0x0064FA84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattlePropertyModifier");
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.Get);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.Collect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache2);
		string name = "m_values";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_m_values);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_m_values);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache4, true);
		string name2 = "ExchangeAttack";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_ExchangeAttack);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_ExchangeAttack);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache6, true);
		string name3 = "ExchangeDefense";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_ExchangeDefense);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_ExchangeDefense);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache8, true);
		string name4 = "ExchangeMagic";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_ExchangeMagic);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_ExchangeMagic);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheA, true);
		string name5 = "ExchangeMagicDefense";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_ExchangeMagicDefense);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_ExchangeMagicDefense);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheC, true);
		string name6 = "ExchangeDexterity";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_ExchangeDexterity);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_ExchangeDexterity);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheE, true);
		string name7 = "ExchangeHealthPointMax";
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.get_ExchangeHealthPointMax);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.set_ExchangeHealthPointMax);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.<>f__mg$cache11, typeof(BattlePropertyModifier));
	}

	// Token: 0x0400DB05 RID: 56069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB06 RID: 56070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB07 RID: 56071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB08 RID: 56072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB09 RID: 56073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB0A RID: 56074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB0B RID: 56075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DB0C RID: 56076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DB0D RID: 56077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DB0E RID: 56078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DB0F RID: 56079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DB10 RID: 56080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DB11 RID: 56081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DB12 RID: 56082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DB13 RID: 56083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DB14 RID: 56084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DB15 RID: 56085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DB16 RID: 56086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
