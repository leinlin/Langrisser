using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F7 RID: 5879
[Preserve]
public class Lua_UnityEngine_JointAngleLimits2D : LuaObject
{
	// Token: 0x060233FF RID: 144383 RVA: 0x00C3C108 File Offset: 0x00C3A308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointAngleLimits2D jointAngleLimits2D = default(JointAngleLimits2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointAngleLimits2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023400 RID: 144384 RVA: 0x00C3C158 File Offset: 0x00C3A358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			JointAngleLimits2D jointAngleLimits2D;
			LuaObject.checkValueType<JointAngleLimits2D>(l, 1, out jointAngleLimits2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointAngleLimits2D.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023401 RID: 144385 RVA: 0x00C3C1AC File Offset: 0x00C3A3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			JointAngleLimits2D jointAngleLimits2D;
			LuaObject.checkValueType<JointAngleLimits2D>(l, 1, out jointAngleLimits2D);
			float min;
			LuaObject.checkType(l, 2, out min);
			jointAngleLimits2D.min = min;
			LuaObject.setBack(l, jointAngleLimits2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023402 RID: 144386 RVA: 0x00C3C210 File Offset: 0x00C3A410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			JointAngleLimits2D jointAngleLimits2D;
			LuaObject.checkValueType<JointAngleLimits2D>(l, 1, out jointAngleLimits2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointAngleLimits2D.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023403 RID: 144387 RVA: 0x00C3C264 File Offset: 0x00C3A464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			JointAngleLimits2D jointAngleLimits2D;
			LuaObject.checkValueType<JointAngleLimits2D>(l, 1, out jointAngleLimits2D);
			float max;
			LuaObject.checkType(l, 2, out max);
			jointAngleLimits2D.max = max;
			LuaObject.setBack(l, jointAngleLimits2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023404 RID: 144388 RVA: 0x00C3C2C8 File Offset: 0x00C3A4C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointAngleLimits2D");
		string name = "min";
		if (Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointAngleLimits2D.get_min);
		}
		LuaCSFunction get = Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache0;
		if (Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointAngleLimits2D.set_min);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache1, true);
		string name2 = "max";
		if (Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointAngleLimits2D.get_max);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache2;
		if (Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointAngleLimits2D.set_max);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache3, true);
		if (Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointAngleLimits2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointAngleLimits2D.<>f__mg$cache4, typeof(JointAngleLimits2D), typeof(ValueType));
	}

	// Token: 0x0401926F RID: 103023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019270 RID: 103024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019271 RID: 103025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019272 RID: 103026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019273 RID: 103027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
