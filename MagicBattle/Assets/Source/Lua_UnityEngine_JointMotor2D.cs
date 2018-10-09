using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016FC RID: 5884
[Preserve]
public class Lua_UnityEngine_JointMotor2D : LuaObject
{
	// Token: 0x06023427 RID: 144423 RVA: 0x00C3D0EC File Offset: 0x00C3B2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointMotor2D jointMotor2D = default(JointMotor2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023428 RID: 144424 RVA: 0x00C3D13C File Offset: 0x00C3B33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_motorSpeed(IntPtr l)
	{
		int result;
		try
		{
			JointMotor2D jointMotor2D;
			LuaObject.checkValueType<JointMotor2D>(l, 1, out jointMotor2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor2D.motorSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023429 RID: 144425 RVA: 0x00C3D190 File Offset: 0x00C3B390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_motorSpeed(IntPtr l)
	{
		int result;
		try
		{
			JointMotor2D jointMotor2D;
			LuaObject.checkValueType<JointMotor2D>(l, 1, out jointMotor2D);
			float motorSpeed;
			LuaObject.checkType(l, 2, out motorSpeed);
			jointMotor2D.motorSpeed = motorSpeed;
			LuaObject.setBack(l, jointMotor2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602342A RID: 144426 RVA: 0x00C3D1F4 File Offset: 0x00C3B3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxMotorTorque(IntPtr l)
	{
		int result;
		try
		{
			JointMotor2D jointMotor2D;
			LuaObject.checkValueType<JointMotor2D>(l, 1, out jointMotor2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor2D.maxMotorTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602342B RID: 144427 RVA: 0x00C3D248 File Offset: 0x00C3B448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxMotorTorque(IntPtr l)
	{
		int result;
		try
		{
			JointMotor2D jointMotor2D;
			LuaObject.checkValueType<JointMotor2D>(l, 1, out jointMotor2D);
			float maxMotorTorque;
			LuaObject.checkType(l, 2, out maxMotorTorque);
			jointMotor2D.maxMotorTorque = maxMotorTorque;
			LuaObject.setBack(l, jointMotor2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602342C RID: 144428 RVA: 0x00C3D2AC File Offset: 0x00C3B4AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointMotor2D");
		string name = "motorSpeed";
		if (Lua_UnityEngine_JointMotor2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointMotor2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointMotor2D.get_motorSpeed);
		}
		LuaCSFunction get = Lua_UnityEngine_JointMotor2D.<>f__mg$cache0;
		if (Lua_UnityEngine_JointMotor2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointMotor2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointMotor2D.set_motorSpeed);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointMotor2D.<>f__mg$cache1, true);
		string name2 = "maxMotorTorque";
		if (Lua_UnityEngine_JointMotor2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointMotor2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointMotor2D.get_maxMotorTorque);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointMotor2D.<>f__mg$cache2;
		if (Lua_UnityEngine_JointMotor2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointMotor2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointMotor2D.set_maxMotorTorque);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointMotor2D.<>f__mg$cache3, true);
		if (Lua_UnityEngine_JointMotor2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointMotor2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointMotor2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointMotor2D.<>f__mg$cache4, typeof(JointMotor2D), typeof(ValueType));
	}

	// Token: 0x0401928D RID: 103053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401928E RID: 103054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401928F RID: 103055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019290 RID: 103056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019291 RID: 103057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
