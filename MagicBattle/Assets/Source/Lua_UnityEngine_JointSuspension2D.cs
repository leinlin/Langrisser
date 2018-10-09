using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016FF RID: 5887
[Preserve]
public class Lua_UnityEngine_JointSuspension2D : LuaObject
{
	// Token: 0x06023439 RID: 144441 RVA: 0x00C3D774 File Offset: 0x00C3B974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D = default(JointSuspension2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSuspension2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602343A RID: 144442 RVA: 0x00C3D7C4 File Offset: 0x00C3B9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D;
			LuaObject.checkValueType<JointSuspension2D>(l, 1, out jointSuspension2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSuspension2D.dampingRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602343B RID: 144443 RVA: 0x00C3D818 File Offset: 0x00C3BA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D;
			LuaObject.checkValueType<JointSuspension2D>(l, 1, out jointSuspension2D);
			float dampingRatio;
			LuaObject.checkType(l, 2, out dampingRatio);
			jointSuspension2D.dampingRatio = dampingRatio;
			LuaObject.setBack(l, jointSuspension2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602343C RID: 144444 RVA: 0x00C3D87C File Offset: 0x00C3BA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frequency(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D;
			LuaObject.checkValueType<JointSuspension2D>(l, 1, out jointSuspension2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSuspension2D.frequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602343D RID: 144445 RVA: 0x00C3D8D0 File Offset: 0x00C3BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_frequency(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D;
			LuaObject.checkValueType<JointSuspension2D>(l, 1, out jointSuspension2D);
			float frequency;
			LuaObject.checkType(l, 2, out frequency);
			jointSuspension2D.frequency = frequency;
			LuaObject.setBack(l, jointSuspension2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602343E RID: 144446 RVA: 0x00C3D934 File Offset: 0x00C3BB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angle(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D;
			LuaObject.checkValueType<JointSuspension2D>(l, 1, out jointSuspension2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointSuspension2D.angle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602343F RID: 144447 RVA: 0x00C3D988 File Offset: 0x00C3BB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angle(IntPtr l)
	{
		int result;
		try
		{
			JointSuspension2D jointSuspension2D;
			LuaObject.checkValueType<JointSuspension2D>(l, 1, out jointSuspension2D);
			float angle;
			LuaObject.checkType(l, 2, out angle);
			jointSuspension2D.angle = angle;
			LuaObject.setBack(l, jointSuspension2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023440 RID: 144448 RVA: 0x00C3D9EC File Offset: 0x00C3BBEC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointSuspension2D");
		string name = "dampingRatio";
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.get_dampingRatio);
		}
		LuaCSFunction get = Lua_UnityEngine_JointSuspension2D.<>f__mg$cache0;
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.set_dampingRatio);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointSuspension2D.<>f__mg$cache1, true);
		string name2 = "frequency";
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.get_frequency);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointSuspension2D.<>f__mg$cache2;
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.set_frequency);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointSuspension2D.<>f__mg$cache3, true);
		string name3 = "angle";
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.get_angle);
		}
		LuaCSFunction get3 = Lua_UnityEngine_JointSuspension2D.<>f__mg$cache4;
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.set_angle);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_JointSuspension2D.<>f__mg$cache5, true);
		if (Lua_UnityEngine_JointSuspension2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_JointSuspension2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_JointSuspension2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointSuspension2D.<>f__mg$cache6, typeof(JointSuspension2D), typeof(ValueType));
	}

	// Token: 0x04019299 RID: 103065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401929A RID: 103066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401929B RID: 103067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401929C RID: 103068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401929D RID: 103069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401929E RID: 103070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401929F RID: 103071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
