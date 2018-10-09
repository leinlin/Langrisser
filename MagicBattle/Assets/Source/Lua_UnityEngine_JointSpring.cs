using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016FE RID: 5886
[Preserve]
public class Lua_UnityEngine_JointSpring : LuaObject
{
	// Token: 0x06023430 RID: 144432 RVA: 0x00C3D3D0 File Offset: 0x00C3B5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring = default(JointSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023431 RID: 144433 RVA: 0x00C3D420 File Offset: 0x00C3B620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spring(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring;
			LuaObject.checkValueType<JointSpring>(l, 1, out jointSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSpring.spring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023432 RID: 144434 RVA: 0x00C3D474 File Offset: 0x00C3B674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spring(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring;
			LuaObject.checkValueType<JointSpring>(l, 1, out jointSpring);
			float spring;
			LuaObject.checkType(l, 2, out spring);
			jointSpring.spring = spring;
			LuaObject.setBack(l, jointSpring);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023433 RID: 144435 RVA: 0x00C3D4D8 File Offset: 0x00C3B6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_damper(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring;
			LuaObject.checkValueType<JointSpring>(l, 1, out jointSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSpring.damper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023434 RID: 144436 RVA: 0x00C3D52C File Offset: 0x00C3B72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_damper(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring;
			LuaObject.checkValueType<JointSpring>(l, 1, out jointSpring);
			float damper;
			LuaObject.checkType(l, 2, out damper);
			jointSpring.damper = damper;
			LuaObject.setBack(l, jointSpring);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023435 RID: 144437 RVA: 0x00C3D590 File Offset: 0x00C3B790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring;
			LuaObject.checkValueType<JointSpring>(l, 1, out jointSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSpring.targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023436 RID: 144438 RVA: 0x00C3D5E4 File Offset: 0x00C3B7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			JointSpring jointSpring;
			LuaObject.checkValueType<JointSpring>(l, 1, out jointSpring);
			float targetPosition;
			LuaObject.checkType(l, 2, out targetPosition);
			jointSpring.targetPosition = targetPosition;
			LuaObject.setBack(l, jointSpring);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023437 RID: 144439 RVA: 0x00C3D648 File Offset: 0x00C3B848
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointSpring");
		string name = "spring";
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointSpring.get_spring);
		}
		LuaCSFunction get = Lua_UnityEngine_JointSpring.<>f__mg$cache0;
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointSpring.set_spring);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointSpring.<>f__mg$cache1, true);
		string name2 = "damper";
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointSpring.get_damper);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointSpring.<>f__mg$cache2;
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointSpring.set_damper);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointSpring.<>f__mg$cache3, true);
		string name3 = "targetPosition";
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointSpring.get_targetPosition);
		}
		LuaCSFunction get3 = Lua_UnityEngine_JointSpring.<>f__mg$cache4;
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_JointSpring.set_targetPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_JointSpring.<>f__mg$cache5, true);
		if (Lua_UnityEngine_JointSpring.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_JointSpring.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_JointSpring.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointSpring.<>f__mg$cache6, typeof(JointSpring), typeof(ValueType));
	}

	// Token: 0x04019292 RID: 103058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019293 RID: 103059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019294 RID: 103060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019295 RID: 103061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019296 RID: 103062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019297 RID: 103063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019298 RID: 103064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
