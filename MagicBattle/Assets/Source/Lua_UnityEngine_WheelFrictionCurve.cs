using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001880 RID: 6272
[Preserve]
public class Lua_UnityEngine_WheelFrictionCurve : LuaObject
{
	// Token: 0x06024448 RID: 148552 RVA: 0x00CBFCDC File Offset: 0x00CBDEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve = default(WheelFrictionCurve);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelFrictionCurve);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024449 RID: 148553 RVA: 0x00CBFD2C File Offset: 0x00CBDF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_extremumSlip(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelFrictionCurve.extremumSlip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602444A RID: 148554 RVA: 0x00CBFD80 File Offset: 0x00CBDF80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_extremumSlip(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			float extremumSlip;
			LuaObject.checkType(l, 2, out extremumSlip);
			wheelFrictionCurve.extremumSlip = extremumSlip;
			LuaObject.setBack(l, wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602444B RID: 148555 RVA: 0x00CBFDE4 File Offset: 0x00CBDFE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_extremumValue(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelFrictionCurve.extremumValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602444C RID: 148556 RVA: 0x00CBFE38 File Offset: 0x00CBE038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_extremumValue(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			float extremumValue;
			LuaObject.checkType(l, 2, out extremumValue);
			wheelFrictionCurve.extremumValue = extremumValue;
			LuaObject.setBack(l, wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602444D RID: 148557 RVA: 0x00CBFE9C File Offset: 0x00CBE09C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_asymptoteSlip(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelFrictionCurve.asymptoteSlip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602444E RID: 148558 RVA: 0x00CBFEF0 File Offset: 0x00CBE0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_asymptoteSlip(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			float asymptoteSlip;
			LuaObject.checkType(l, 2, out asymptoteSlip);
			wheelFrictionCurve.asymptoteSlip = asymptoteSlip;
			LuaObject.setBack(l, wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602444F RID: 148559 RVA: 0x00CBFF54 File Offset: 0x00CBE154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_asymptoteValue(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelFrictionCurve.asymptoteValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024450 RID: 148560 RVA: 0x00CBFFA8 File Offset: 0x00CBE1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_asymptoteValue(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			float asymptoteValue;
			LuaObject.checkType(l, 2, out asymptoteValue);
			wheelFrictionCurve.asymptoteValue = asymptoteValue;
			LuaObject.setBack(l, wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024451 RID: 148561 RVA: 0x00CC000C File Offset: 0x00CBE20C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_stiffness(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelFrictionCurve.stiffness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024452 RID: 148562 RVA: 0x00CC0060 File Offset: 0x00CBE260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_stiffness(IntPtr l)
	{
		int result;
		try
		{
			WheelFrictionCurve wheelFrictionCurve;
			LuaObject.checkValueType<WheelFrictionCurve>(l, 1, out wheelFrictionCurve);
			float stiffness;
			LuaObject.checkType(l, 2, out stiffness);
			wheelFrictionCurve.stiffness = stiffness;
			LuaObject.setBack(l, wheelFrictionCurve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024453 RID: 148563 RVA: 0x00CC00C4 File Offset: 0x00CBE2C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WheelFrictionCurve");
		string name = "extremumSlip";
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.get_extremumSlip);
		}
		LuaCSFunction get = Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache0;
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.set_extremumSlip);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache1, true);
		string name2 = "extremumValue";
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.get_extremumValue);
		}
		LuaCSFunction get2 = Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache2;
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.set_extremumValue);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache3, true);
		string name3 = "asymptoteSlip";
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.get_asymptoteSlip);
		}
		LuaCSFunction get3 = Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache4;
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.set_asymptoteSlip);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache5, true);
		string name4 = "asymptoteValue";
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.get_asymptoteValue);
		}
		LuaCSFunction get4 = Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache6;
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.set_asymptoteValue);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache7, true);
		string name5 = "stiffness";
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.get_stiffness);
		}
		LuaCSFunction get5 = Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache8;
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.set_stiffness);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cache9, true);
		if (Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_WheelFrictionCurve.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WheelFrictionCurve.<>f__mg$cacheA, typeof(WheelFrictionCurve), typeof(ValueType));
	}

	// Token: 0x04019FA6 RID: 106406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FA7 RID: 106407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019FA8 RID: 106408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019FA9 RID: 106409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019FAA RID: 106410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019FAB RID: 106411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019FAC RID: 106412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019FAD RID: 106413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019FAE RID: 106414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019FAF RID: 106415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019FB0 RID: 106416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
