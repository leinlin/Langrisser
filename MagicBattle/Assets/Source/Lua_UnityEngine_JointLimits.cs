using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F9 RID: 5881
[Preserve]
public class Lua_UnityEngine_JointLimits : LuaObject
{
	// Token: 0x0602340F RID: 144399 RVA: 0x00C3C750 File Offset: 0x00C3A950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits = default(JointLimits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointLimits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023410 RID: 144400 RVA: 0x00C3C7A0 File Offset: 0x00C3A9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointLimits.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023411 RID: 144401 RVA: 0x00C3C7F4 File Offset: 0x00C3A9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			float min;
			LuaObject.checkType(l, 2, out min);
			jointLimits.min = min;
			LuaObject.setBack(l, jointLimits);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023412 RID: 144402 RVA: 0x00C3C858 File Offset: 0x00C3AA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointLimits.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023413 RID: 144403 RVA: 0x00C3C8AC File Offset: 0x00C3AAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			float max;
			LuaObject.checkType(l, 2, out max);
			jointLimits.max = max;
			LuaObject.setBack(l, jointLimits);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023414 RID: 144404 RVA: 0x00C3C910 File Offset: 0x00C3AB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounciness(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointLimits.bounciness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023415 RID: 144405 RVA: 0x00C3C964 File Offset: 0x00C3AB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounciness(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			float bounciness;
			LuaObject.checkType(l, 2, out bounciness);
			jointLimits.bounciness = bounciness;
			LuaObject.setBack(l, jointLimits);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023416 RID: 144406 RVA: 0x00C3C9C8 File Offset: 0x00C3ABC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounceMinVelocity(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointLimits.bounceMinVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023417 RID: 144407 RVA: 0x00C3CA1C File Offset: 0x00C3AC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounceMinVelocity(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			float bounceMinVelocity;
			LuaObject.checkType(l, 2, out bounceMinVelocity);
			jointLimits.bounceMinVelocity = bounceMinVelocity;
			LuaObject.setBack(l, jointLimits);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023418 RID: 144408 RVA: 0x00C3CA80 File Offset: 0x00C3AC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_contactDistance(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointLimits.contactDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023419 RID: 144409 RVA: 0x00C3CAD4 File Offset: 0x00C3ACD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_contactDistance(IntPtr l)
	{
		int result;
		try
		{
			JointLimits jointLimits;
			LuaObject.checkValueType<JointLimits>(l, 1, out jointLimits);
			float contactDistance;
			LuaObject.checkType(l, 2, out contactDistance);
			jointLimits.contactDistance = contactDistance;
			LuaObject.setBack(l, jointLimits);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602341A RID: 144410 RVA: 0x00C3CB38 File Offset: 0x00C3AD38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointLimits");
		string name = "min";
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointLimits.get_min);
		}
		LuaCSFunction get = Lua_UnityEngine_JointLimits.<>f__mg$cache0;
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointLimits.set_min);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointLimits.<>f__mg$cache1, true);
		string name2 = "max";
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointLimits.get_max);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointLimits.<>f__mg$cache2;
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointLimits.set_max);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointLimits.<>f__mg$cache3, true);
		string name3 = "bounciness";
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointLimits.get_bounciness);
		}
		LuaCSFunction get3 = Lua_UnityEngine_JointLimits.<>f__mg$cache4;
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_JointLimits.set_bounciness);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_JointLimits.<>f__mg$cache5, true);
		string name4 = "bounceMinVelocity";
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_JointLimits.get_bounceMinVelocity);
		}
		LuaCSFunction get4 = Lua_UnityEngine_JointLimits.<>f__mg$cache6;
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_JointLimits.set_bounceMinVelocity);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_JointLimits.<>f__mg$cache7, true);
		string name5 = "contactDistance";
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_JointLimits.get_contactDistance);
		}
		LuaCSFunction get5 = Lua_UnityEngine_JointLimits.<>f__mg$cache8;
		if (Lua_UnityEngine_JointLimits.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_JointLimits.set_contactDistance);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_JointLimits.<>f__mg$cache9, true);
		if (Lua_UnityEngine_JointLimits.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_JointLimits.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_JointLimits.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointLimits.<>f__mg$cacheA, typeof(JointLimits), typeof(ValueType));
	}

	// Token: 0x0401927B RID: 103035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401927C RID: 103036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401927D RID: 103037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401927E RID: 103038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401927F RID: 103039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019280 RID: 103040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019281 RID: 103041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019282 RID: 103042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019283 RID: 103043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019284 RID: 103044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019285 RID: 103045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
