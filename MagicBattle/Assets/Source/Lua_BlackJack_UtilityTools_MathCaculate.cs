using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F4 RID: 5620
[Preserve]
public class Lua_BlackJack_UtilityTools_MathCaculate : LuaObject
{
	// Token: 0x060227DA RID: 141274 RVA: 0x00BD3A98 File Offset: 0x00BD1C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MathCaculate o = new MathCaculate();
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

	// Token: 0x060227DB RID: 141275 RVA: 0x00BD3AE0 File Offset: 0x00BD1CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDownIntegerByPeriod_s(IntPtr l)
	{
		int result;
		try
		{
			long inputIntger;
			LuaObject.checkType(l, 1, out inputIntger);
			int period;
			LuaObject.checkType(l, 2, out period);
			long downIntegerByPeriod = MathCaculate.GetDownIntegerByPeriod(inputIntger, period);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, downIntegerByPeriod);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227DC RID: 141276 RVA: 0x00BD3B40 File Offset: 0x00BD1D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUpInterByPeriod_s(IntPtr l)
	{
		int result;
		try
		{
			long inputIntger;
			LuaObject.checkType(l, 1, out inputIntger);
			int period;
			LuaObject.checkType(l, 2, out period);
			long upInterByPeriod = MathCaculate.GetUpInterByPeriod(inputIntger, period);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, upInterByPeriod);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227DD RID: 141277 RVA: 0x00BD3BA0 File Offset: 0x00BD1DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDownIntegerByDiscount_s(IntPtr l)
	{
		int result;
		try
		{
			long inputInterger;
			LuaObject.checkType(l, 1, out inputInterger);
			int discount;
			LuaObject.checkType(l, 2, out discount);
			long downIntegerByDiscount = MathCaculate.GetDownIntegerByDiscount(inputInterger, discount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, downIntegerByDiscount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227DE RID: 141278 RVA: 0x00BD3C00 File Offset: 0x00BD1E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUpIntegerByDiscount_s(IntPtr l)
	{
		int result;
		try
		{
			long inputInterger;
			LuaObject.checkType(l, 1, out inputInterger);
			int discount;
			LuaObject.checkType(l, 2, out discount);
			long upIntegerByDiscount = MathCaculate.GetUpIntegerByDiscount(inputInterger, discount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, upIntegerByDiscount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227DF RID: 141279 RVA: 0x00BD3C60 File Offset: 0x00BD1E60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.MathCaculate");
		if (Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MathCaculate.GetDownIntegerByPeriod_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MathCaculate.GetUpInterByPeriod_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MathCaculate.GetDownIntegerByDiscount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache2);
		if (Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MathCaculate.GetUpIntegerByDiscount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache3);
		if (Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MathCaculate.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_MathCaculate.<>f__mg$cache4, typeof(MathCaculate));
	}

	// Token: 0x040185D4 RID: 99796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185D5 RID: 99797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185D6 RID: 99798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185D7 RID: 99799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185D8 RID: 99800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
