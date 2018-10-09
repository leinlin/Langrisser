using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E6 RID: 5862
[Preserve]
public class Lua_UnityEngine_HumanPose : LuaObject
{
	// Token: 0x06023359 RID: 144217 RVA: 0x00C37AB4 File Offset: 0x00C35CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose = default(HumanPose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanPose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602335A RID: 144218 RVA: 0x00C37B04 File Offset: 0x00C35D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bodyPosition(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 1, out humanPose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanPose.bodyPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602335B RID: 144219 RVA: 0x00C37B58 File Offset: 0x00C35D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bodyPosition(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 1, out humanPose);
			Vector3 bodyPosition;
			LuaObject.checkType(l, 2, out bodyPosition);
			humanPose.bodyPosition = bodyPosition;
			LuaObject.setBack(l, humanPose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602335C RID: 144220 RVA: 0x00C37BBC File Offset: 0x00C35DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bodyRotation(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 1, out humanPose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanPose.bodyRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602335D RID: 144221 RVA: 0x00C37C10 File Offset: 0x00C35E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bodyRotation(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 1, out humanPose);
			Quaternion bodyRotation;
			LuaObject.checkType(l, 2, out bodyRotation);
			humanPose.bodyRotation = bodyRotation;
			LuaObject.setBack(l, humanPose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602335E RID: 144222 RVA: 0x00C37C74 File Offset: 0x00C35E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_muscles(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 1, out humanPose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanPose.muscles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602335F RID: 144223 RVA: 0x00C37CC8 File Offset: 0x00C35EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_muscles(IntPtr l)
	{
		int result;
		try
		{
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 1, out humanPose);
			float[] muscles;
			LuaObject.checkArray<float>(l, 2, out muscles);
			humanPose.muscles = muscles;
			LuaObject.setBack(l, humanPose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023360 RID: 144224 RVA: 0x00C37D2C File Offset: 0x00C35F2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HumanPose");
		string name = "bodyPosition";
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HumanPose.get_bodyPosition);
		}
		LuaCSFunction get = Lua_UnityEngine_HumanPose.<>f__mg$cache0;
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HumanPose.set_bodyPosition);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_HumanPose.<>f__mg$cache1, true);
		string name2 = "bodyRotation";
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HumanPose.get_bodyRotation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_HumanPose.<>f__mg$cache2;
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HumanPose.set_bodyRotation);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_HumanPose.<>f__mg$cache3, true);
		string name3 = "muscles";
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HumanPose.get_muscles);
		}
		LuaCSFunction get3 = Lua_UnityEngine_HumanPose.<>f__mg$cache4;
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HumanPose.set_muscles);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_HumanPose.<>f__mg$cache5, true);
		if (Lua_UnityEngine_HumanPose.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HumanPose.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HumanPose.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_HumanPose.<>f__mg$cache6, typeof(HumanPose), typeof(ValueType));
	}

	// Token: 0x040191EB RID: 102891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191EC RID: 102892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191ED RID: 102893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191EE RID: 102894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191EF RID: 102895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191F0 RID: 102896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191F1 RID: 102897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
