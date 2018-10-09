using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016FB RID: 5883
[Preserve]
public class Lua_UnityEngine_JointMotor : LuaObject
{
	// Token: 0x0602341E RID: 144414 RVA: 0x00C3CD48 File Offset: 0x00C3AF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor = default(JointMotor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602341F RID: 144415 RVA: 0x00C3CD98 File Offset: 0x00C3AF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetVelocity(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor;
			LuaObject.checkValueType<JointMotor>(l, 1, out jointMotor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor.targetVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023420 RID: 144416 RVA: 0x00C3CDEC File Offset: 0x00C3AFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetVelocity(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor;
			LuaObject.checkValueType<JointMotor>(l, 1, out jointMotor);
			float targetVelocity;
			LuaObject.checkType(l, 2, out targetVelocity);
			jointMotor.targetVelocity = targetVelocity;
			LuaObject.setBack(l, jointMotor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023421 RID: 144417 RVA: 0x00C3CE50 File Offset: 0x00C3B050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_force(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor;
			LuaObject.checkValueType<JointMotor>(l, 1, out jointMotor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor.force);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023422 RID: 144418 RVA: 0x00C3CEA4 File Offset: 0x00C3B0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_force(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor;
			LuaObject.checkValueType<JointMotor>(l, 1, out jointMotor);
			float force;
			LuaObject.checkType(l, 2, out force);
			jointMotor.force = force;
			LuaObject.setBack(l, jointMotor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023423 RID: 144419 RVA: 0x00C3CF08 File Offset: 0x00C3B108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_freeSpin(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor;
			LuaObject.checkValueType<JointMotor>(l, 1, out jointMotor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointMotor.freeSpin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023424 RID: 144420 RVA: 0x00C3CF5C File Offset: 0x00C3B15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_freeSpin(IntPtr l)
	{
		int result;
		try
		{
			JointMotor jointMotor;
			LuaObject.checkValueType<JointMotor>(l, 1, out jointMotor);
			bool freeSpin;
			LuaObject.checkType(l, 2, out freeSpin);
			jointMotor.freeSpin = freeSpin;
			LuaObject.setBack(l, jointMotor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023425 RID: 144421 RVA: 0x00C3CFC0 File Offset: 0x00C3B1C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointMotor");
		string name = "targetVelocity";
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointMotor.get_targetVelocity);
		}
		LuaCSFunction get = Lua_UnityEngine_JointMotor.<>f__mg$cache0;
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointMotor.set_targetVelocity);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointMotor.<>f__mg$cache1, true);
		string name2 = "force";
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointMotor.get_force);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointMotor.<>f__mg$cache2;
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointMotor.set_force);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointMotor.<>f__mg$cache3, true);
		string name3 = "freeSpin";
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointMotor.get_freeSpin);
		}
		LuaCSFunction get3 = Lua_UnityEngine_JointMotor.<>f__mg$cache4;
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_JointMotor.set_freeSpin);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_JointMotor.<>f__mg$cache5, true);
		if (Lua_UnityEngine_JointMotor.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_JointMotor.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_JointMotor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointMotor.<>f__mg$cache6, typeof(JointMotor), typeof(ValueType));
	}

	// Token: 0x04019286 RID: 103046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019287 RID: 103047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019288 RID: 103048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019289 RID: 103049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401928A RID: 103050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401928B RID: 103051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401928C RID: 103052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
