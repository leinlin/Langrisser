using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016DF RID: 5855
[Preserve]
public class Lua_UnityEngine_HingeJoint : LuaObject
{
	// Token: 0x06023309 RID: 144137 RVA: 0x00C35630 File Offset: 0x00C33830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_motor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.motor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602330A RID: 144138 RVA: 0x00C35688 File Offset: 0x00C33888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_motor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			JointMotor motor;
			LuaObject.checkValueType<JointMotor>(l, 2, out motor);
			hingeJoint.motor = motor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602330B RID: 144139 RVA: 0x00C356E0 File Offset: 0x00C338E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_limits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.limits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602330C RID: 144140 RVA: 0x00C35738 File Offset: 0x00C33938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_limits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			JointLimits limits;
			LuaObject.checkValueType<JointLimits>(l, 2, out limits);
			hingeJoint.limits = limits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602330D RID: 144141 RVA: 0x00C35790 File Offset: 0x00C33990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spring(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.spring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602330E RID: 144142 RVA: 0x00C357E8 File Offset: 0x00C339E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spring(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			JointSpring spring;
			LuaObject.checkValueType<JointSpring>(l, 2, out spring);
			hingeJoint.spring = spring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602330F RID: 144143 RVA: 0x00C35840 File Offset: 0x00C33A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useMotor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.useMotor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023310 RID: 144144 RVA: 0x00C35894 File Offset: 0x00C33A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useMotor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			bool useMotor;
			LuaObject.checkType(l, 2, out useMotor);
			hingeJoint.useMotor = useMotor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023311 RID: 144145 RVA: 0x00C358EC File Offset: 0x00C33AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useLimits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.useLimits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023312 RID: 144146 RVA: 0x00C35940 File Offset: 0x00C33B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useLimits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			bool useLimits;
			LuaObject.checkType(l, 2, out useLimits);
			hingeJoint.useLimits = useLimits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023313 RID: 144147 RVA: 0x00C35998 File Offset: 0x00C33B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useSpring(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.useSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023314 RID: 144148 RVA: 0x00C359EC File Offset: 0x00C33BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useSpring(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			bool useSpring;
			LuaObject.checkType(l, 2, out useSpring);
			hingeJoint.useSpring = useSpring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023315 RID: 144149 RVA: 0x00C35A44 File Offset: 0x00C33C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023316 RID: 144150 RVA: 0x00C35A98 File Offset: 0x00C33C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angle(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint hingeJoint = (HingeJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint.angle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023317 RID: 144151 RVA: 0x00C35AEC File Offset: 0x00C33CEC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HingeJoint");
		string name = "motor";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_motor);
		}
		LuaCSFunction get = Lua_UnityEngine_HingeJoint.<>f__mg$cache0;
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.set_motor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_HingeJoint.<>f__mg$cache1, true);
		string name2 = "limits";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_limits);
		}
		LuaCSFunction get2 = Lua_UnityEngine_HingeJoint.<>f__mg$cache2;
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.set_limits);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_HingeJoint.<>f__mg$cache3, true);
		string name3 = "spring";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_spring);
		}
		LuaCSFunction get3 = Lua_UnityEngine_HingeJoint.<>f__mg$cache4;
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.set_spring);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_HingeJoint.<>f__mg$cache5, true);
		string name4 = "useMotor";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_useMotor);
		}
		LuaCSFunction get4 = Lua_UnityEngine_HingeJoint.<>f__mg$cache6;
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.set_useMotor);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_HingeJoint.<>f__mg$cache7, true);
		string name5 = "useLimits";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_useLimits);
		}
		LuaCSFunction get5 = Lua_UnityEngine_HingeJoint.<>f__mg$cache8;
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_HingeJoint.set_useLimits);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_HingeJoint.<>f__mg$cache9, true);
		string name6 = "useSpring";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_useSpring);
		}
		LuaCSFunction get6 = Lua_UnityEngine_HingeJoint.<>f__mg$cacheA;
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_HingeJoint.set_useSpring);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_HingeJoint.<>f__mg$cacheB, true);
		string name7 = "velocity";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_velocity);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_HingeJoint.<>f__mg$cacheC, null, true);
		string name8 = "angle";
		if (Lua_UnityEngine_HingeJoint.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_HingeJoint.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_HingeJoint.get_angle);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_HingeJoint.<>f__mg$cacheD, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(HingeJoint), typeof(Joint));
	}

	// Token: 0x040191A9 RID: 102825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191AA RID: 102826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191AB RID: 102827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191AC RID: 102828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191AD RID: 102829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191AE RID: 102830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191AF RID: 102831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040191B0 RID: 102832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040191B1 RID: 102833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040191B2 RID: 102834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040191B3 RID: 102835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040191B4 RID: 102836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040191B5 RID: 102837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040191B6 RID: 102838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
