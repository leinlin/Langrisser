using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001881 RID: 6273
[Preserve]
public class Lua_UnityEngine_WheelJoint2D : LuaObject
{
	// Token: 0x06024455 RID: 148565 RVA: 0x00CC027C File Offset: 0x00CBE47C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMotorTorque(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			float timeStep;
			LuaObject.checkType(l, 2, out timeStep);
			float motorTorque = wheelJoint2D.GetMotorTorque(timeStep);
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

	// Token: 0x06024456 RID: 148566 RVA: 0x00CC02E0 File Offset: 0x00CBE4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_suspension(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.suspension);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024457 RID: 148567 RVA: 0x00CC0338 File Offset: 0x00CBE538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_suspension(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			JointSuspension2D suspension;
			LuaObject.checkValueType<JointSuspension2D>(l, 2, out suspension);
			wheelJoint2D.suspension = suspension;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024458 RID: 148568 RVA: 0x00CC0390 File Offset: 0x00CBE590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useMotor(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.useMotor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024459 RID: 148569 RVA: 0x00CC03E4 File Offset: 0x00CBE5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useMotor(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			bool useMotor;
			LuaObject.checkType(l, 2, out useMotor);
			wheelJoint2D.useMotor = useMotor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602445A RID: 148570 RVA: 0x00CC043C File Offset: 0x00CBE63C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_motor(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.motor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602445B RID: 148571 RVA: 0x00CC0494 File Offset: 0x00CBE694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_motor(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			JointMotor2D motor;
			LuaObject.checkValueType<JointMotor2D>(l, 2, out motor);
			wheelJoint2D.motor = motor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602445C RID: 148572 RVA: 0x00CC04EC File Offset: 0x00CBE6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_jointTranslation(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.jointTranslation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602445D RID: 148573 RVA: 0x00CC0540 File Offset: 0x00CBE740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_jointLinearSpeed(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.jointLinearSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602445E RID: 148574 RVA: 0x00CC0594 File Offset: 0x00CBE794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_jointSpeed(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.jointSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602445F RID: 148575 RVA: 0x00CC05E8 File Offset: 0x00CBE7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_jointAngle(IntPtr l)
	{
		int result;
		try
		{
			WheelJoint2D wheelJoint2D = (WheelJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wheelJoint2D.jointAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024460 RID: 148576 RVA: 0x00CC063C File Offset: 0x00CBE83C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WheelJoint2D");
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.GetMotorTorque);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache0);
		string name = "suspension";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_suspension);
		}
		LuaCSFunction get = Lua_UnityEngine_WheelJoint2D.<>f__mg$cache1;
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.set_suspension);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache2, true);
		string name2 = "useMotor";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_useMotor);
		}
		LuaCSFunction get2 = Lua_UnityEngine_WheelJoint2D.<>f__mg$cache3;
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.set_useMotor);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache4, true);
		string name3 = "motor";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_motor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_WheelJoint2D.<>f__mg$cache5;
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.set_motor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache6, true);
		string name4 = "jointTranslation";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_jointTranslation);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache7, null, true);
		string name5 = "jointLinearSpeed";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_jointLinearSpeed);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache8, null, true);
		string name6 = "jointSpeed";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_jointSpeed);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_WheelJoint2D.<>f__mg$cache9, null, true);
		string name7 = "jointAngle";
		if (Lua_UnityEngine_WheelJoint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_WheelJoint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_WheelJoint2D.get_jointAngle);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_WheelJoint2D.<>f__mg$cacheA, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(WheelJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x04019FB1 RID: 106417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FB2 RID: 106418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019FB3 RID: 106419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019FB4 RID: 106420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019FB5 RID: 106421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019FB6 RID: 106422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019FB7 RID: 106423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019FB8 RID: 106424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019FB9 RID: 106425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019FBA RID: 106426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019FBB RID: 106427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
