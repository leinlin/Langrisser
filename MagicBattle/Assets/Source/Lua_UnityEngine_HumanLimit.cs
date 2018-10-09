using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E5 RID: 5861
[Preserve]
public class Lua_UnityEngine_HumanLimit : LuaObject
{
	// Token: 0x0602334C RID: 144204 RVA: 0x00C37514 File Offset: 0x00C35714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit = default(HumanLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602334D RID: 144205 RVA: 0x00C37564 File Offset: 0x00C35764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useDefaultValues(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanLimit.useDefaultValues);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602334E RID: 144206 RVA: 0x00C375B8 File Offset: 0x00C357B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useDefaultValues(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			bool useDefaultValues;
			LuaObject.checkType(l, 2, out useDefaultValues);
			humanLimit.useDefaultValues = useDefaultValues;
			LuaObject.setBack(l, humanLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602334F RID: 144207 RVA: 0x00C3761C File Offset: 0x00C3581C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanLimit.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023350 RID: 144208 RVA: 0x00C37670 File Offset: 0x00C35870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			Vector3 min;
			LuaObject.checkType(l, 2, out min);
			humanLimit.min = min;
			LuaObject.setBack(l, humanLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023351 RID: 144209 RVA: 0x00C376D4 File Offset: 0x00C358D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanLimit.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023352 RID: 144210 RVA: 0x00C37728 File Offset: 0x00C35928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			Vector3 max;
			LuaObject.checkType(l, 2, out max);
			humanLimit.max = max;
			LuaObject.setBack(l, humanLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023353 RID: 144211 RVA: 0x00C3778C File Offset: 0x00C3598C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanLimit.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023354 RID: 144212 RVA: 0x00C377E0 File Offset: 0x00C359E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			humanLimit.center = center;
			LuaObject.setBack(l, humanLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023355 RID: 144213 RVA: 0x00C37844 File Offset: 0x00C35A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_axisLength(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanLimit.axisLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023356 RID: 144214 RVA: 0x00C37898 File Offset: 0x00C35A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_axisLength(IntPtr l)
	{
		int result;
		try
		{
			HumanLimit humanLimit;
			LuaObject.checkValueType<HumanLimit>(l, 1, out humanLimit);
			float axisLength;
			LuaObject.checkType(l, 2, out axisLength);
			humanLimit.axisLength = axisLength;
			LuaObject.setBack(l, humanLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023357 RID: 144215 RVA: 0x00C378FC File Offset: 0x00C35AFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HumanLimit");
		string name = "useDefaultValues";
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.get_useDefaultValues);
		}
		LuaCSFunction get = Lua_UnityEngine_HumanLimit.<>f__mg$cache0;
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.set_useDefaultValues);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_HumanLimit.<>f__mg$cache1, true);
		string name2 = "min";
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.get_min);
		}
		LuaCSFunction get2 = Lua_UnityEngine_HumanLimit.<>f__mg$cache2;
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.set_min);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_HumanLimit.<>f__mg$cache3, true);
		string name3 = "max";
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.get_max);
		}
		LuaCSFunction get3 = Lua_UnityEngine_HumanLimit.<>f__mg$cache4;
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.set_max);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_HumanLimit.<>f__mg$cache5, true);
		string name4 = "center";
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.get_center);
		}
		LuaCSFunction get4 = Lua_UnityEngine_HumanLimit.<>f__mg$cache6;
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.set_center);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_HumanLimit.<>f__mg$cache7, true);
		string name5 = "axisLength";
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.get_axisLength);
		}
		LuaCSFunction get5 = Lua_UnityEngine_HumanLimit.<>f__mg$cache8;
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_HumanLimit.set_axisLength);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_HumanLimit.<>f__mg$cache9, true);
		if (Lua_UnityEngine_HumanLimit.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_HumanLimit.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_HumanLimit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_HumanLimit.<>f__mg$cacheA, typeof(HumanLimit), typeof(ValueType));
	}

	// Token: 0x040191E0 RID: 102880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191E1 RID: 102881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191E2 RID: 102882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191E3 RID: 102883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191E4 RID: 102884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191E5 RID: 102885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191E6 RID: 102886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040191E7 RID: 102887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040191E8 RID: 102888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040191E9 RID: 102889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040191EA RID: 102890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
