using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E0 RID: 5856
[Preserve]
public class Lua_UnityEngine_HingeJoint2D : LuaObject
{
	// Token: 0x06023319 RID: 144153 RVA: 0x00C35D20 File Offset: 0x00C33F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMotorTorque(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			float timeStep;
			LuaObject.checkType(l, 2, out timeStep);
			float motorTorque = hingeJoint2D.GetMotorTorque(timeStep);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, motorTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602331A RID: 144154 RVA: 0x00C35D84 File Offset: 0x00C33F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useMotor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.useMotor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602331B RID: 144155 RVA: 0x00C35DD8 File Offset: 0x00C33FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useMotor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			bool useMotor;
			LuaObject.checkType(l, 2, out useMotor);
			hingeJoint2D.useMotor = useMotor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602331C RID: 144156 RVA: 0x00C35E30 File Offset: 0x00C34030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useLimits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.useLimits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602331D RID: 144157 RVA: 0x00C35E84 File Offset: 0x00C34084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useLimits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			bool useLimits;
			LuaObject.checkType(l, 2, out useLimits);
			hingeJoint2D.useLimits = useLimits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602331E RID: 144158 RVA: 0x00C35EDC File Offset: 0x00C340DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_motor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.motor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602331F RID: 144159 RVA: 0x00C35F34 File Offset: 0x00C34134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_motor(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			JointMotor2D motor;
			LuaObject.checkValueType<JointMotor2D>(l, 2, out motor);
			hingeJoint2D.motor = motor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023320 RID: 144160 RVA: 0x00C35F8C File Offset: 0x00C3418C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_limits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.limits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023321 RID: 144161 RVA: 0x00C35FE4 File Offset: 0x00C341E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_limits(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			JointAngleLimits2D limits;
			LuaObject.checkValueType<JointAngleLimits2D>(l, 2, out limits);
			hingeJoint2D.limits = limits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023322 RID: 144162 RVA: 0x00C3603C File Offset: 0x00C3423C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_limitState(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)hingeJoint2D.limitState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023323 RID: 144163 RVA: 0x00C36090 File Offset: 0x00C34290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_referenceAngle(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.referenceAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023324 RID: 144164 RVA: 0x00C360E4 File Offset: 0x00C342E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_jointAngle(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.jointAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023325 RID: 144165 RVA: 0x00C36138 File Offset: 0x00C34338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_jointSpeed(IntPtr l)
	{
		int result;
		try
		{
			HingeJoint2D hingeJoint2D = (HingeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hingeJoint2D.jointSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023326 RID: 144166 RVA: 0x00C3618C File Offset: 0x00C3438C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HingeJoint2D");
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.GetMotorTorque);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HingeJoint2D.<>f__mg$cache0);
		string name = "useMotor";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_useMotor);
		}
		LuaCSFunction get = Lua_UnityEngine_HingeJoint2D.<>f__mg$cache1;
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.set_useMotor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_HingeJoint2D.<>f__mg$cache2, true);
		string name2 = "useLimits";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_useLimits);
		}
		LuaCSFunction get2 = Lua_UnityEngine_HingeJoint2D.<>f__mg$cache3;
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.set_useLimits);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_HingeJoint2D.<>f__mg$cache4, true);
		string name3 = "motor";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_motor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_HingeJoint2D.<>f__mg$cache5;
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.set_motor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_HingeJoint2D.<>f__mg$cache6, true);
		string name4 = "limits";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_limits);
		}
		LuaCSFunction get4 = Lua_UnityEngine_HingeJoint2D.<>f__mg$cache7;
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.set_limits);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_HingeJoint2D.<>f__mg$cache8, true);
		string name5 = "limitState";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_limitState);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_HingeJoint2D.<>f__mg$cache9, null, true);
		string name6 = "referenceAngle";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_referenceAngle);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheA, null, true);
		string name7 = "jointAngle";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_jointAngle);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheB, null, true);
		string name8 = "jointSpeed";
		if (Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_HingeJoint2D.get_jointSpeed);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_HingeJoint2D.<>f__mg$cacheC, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(HingeJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x040191B7 RID: 102839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191B8 RID: 102840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191B9 RID: 102841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191BA RID: 102842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191BB RID: 102843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191BC RID: 102844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191BD RID: 102845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040191BE RID: 102846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040191BF RID: 102847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040191C0 RID: 102848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040191C1 RID: 102849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040191C2 RID: 102850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040191C3 RID: 102851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
