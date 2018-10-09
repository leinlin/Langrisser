using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001702 RID: 5890
[Preserve]
public class Lua_UnityEngine_Keyframe : LuaObject
{
	// Token: 0x0602344B RID: 144459 RVA: 0x00C3F11C File Offset: 0x00C3D31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				float time;
				LuaObject.checkType(l, 2, out time);
				float value;
				LuaObject.checkType(l, 3, out value);
				Keyframe keyframe = new Keyframe(time, value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, keyframe);
				result = 2;
			}
			else if (num == 5)
			{
				float time2;
				LuaObject.checkType(l, 2, out time2);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				float inTangent;
				LuaObject.checkType(l, 4, out inTangent);
				float outTangent;
				LuaObject.checkType(l, 5, out outTangent);
				Keyframe keyframe = new Keyframe(time2, value2, inTangent, outTangent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, keyframe);
				result = 2;
			}
			else if (num == 0)
			{
				Keyframe keyframe = default(Keyframe);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, keyframe);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602344C RID: 144460 RVA: 0x00C3F228 File Offset: 0x00C3D428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, keyframe.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602344D RID: 144461 RVA: 0x00C3F27C File Offset: 0x00C3D47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_time(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			float time;
			LuaObject.checkType(l, 2, out time);
			keyframe.time = time;
			LuaObject.setBack(l, keyframe);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602344E RID: 144462 RVA: 0x00C3F2E0 File Offset: 0x00C3D4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, keyframe.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602344F RID: 144463 RVA: 0x00C3F334 File Offset: 0x00C3D534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_value(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			float value;
			LuaObject.checkType(l, 2, out value);
			keyframe.value = value;
			LuaObject.setBack(l, keyframe);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023450 RID: 144464 RVA: 0x00C3F398 File Offset: 0x00C3D598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inTangent(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, keyframe.inTangent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023451 RID: 144465 RVA: 0x00C3F3EC File Offset: 0x00C3D5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inTangent(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			float inTangent;
			LuaObject.checkType(l, 2, out inTangent);
			keyframe.inTangent = inTangent;
			LuaObject.setBack(l, keyframe);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023452 RID: 144466 RVA: 0x00C3F450 File Offset: 0x00C3D650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_outTangent(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, keyframe.outTangent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023453 RID: 144467 RVA: 0x00C3F4A4 File Offset: 0x00C3D6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_outTangent(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			float outTangent;
			LuaObject.checkType(l, 2, out outTangent);
			keyframe.outTangent = outTangent;
			LuaObject.setBack(l, keyframe);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023454 RID: 144468 RVA: 0x00C3F508 File Offset: 0x00C3D708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tangentMode(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, keyframe.tangentMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023455 RID: 144469 RVA: 0x00C3F55C File Offset: 0x00C3D75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tangentMode(IntPtr l)
	{
		int result;
		try
		{
			Keyframe keyframe;
			LuaObject.checkValueType<Keyframe>(l, 1, out keyframe);
			int tangentMode;
			LuaObject.checkType(l, 2, out tangentMode);
			keyframe.tangentMode = tangentMode;
			LuaObject.setBack(l, keyframe);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023456 RID: 144470 RVA: 0x00C3F5C0 File Offset: 0x00C3D7C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Keyframe");
		string name = "time";
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Keyframe.get_time);
		}
		LuaCSFunction get = Lua_UnityEngine_Keyframe.<>f__mg$cache0;
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Keyframe.set_time);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Keyframe.<>f__mg$cache1, true);
		string name2 = "value";
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Keyframe.get_value);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Keyframe.<>f__mg$cache2;
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Keyframe.set_value);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Keyframe.<>f__mg$cache3, true);
		string name3 = "inTangent";
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Keyframe.get_inTangent);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Keyframe.<>f__mg$cache4;
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Keyframe.set_inTangent);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Keyframe.<>f__mg$cache5, true);
		string name4 = "outTangent";
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Keyframe.get_outTangent);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Keyframe.<>f__mg$cache6;
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Keyframe.set_outTangent);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Keyframe.<>f__mg$cache7, true);
		string name5 = "tangentMode";
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Keyframe.get_tangentMode);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Keyframe.<>f__mg$cache8;
		if (Lua_UnityEngine_Keyframe.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Keyframe.set_tangentMode);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Keyframe.<>f__mg$cache9, true);
		if (Lua_UnityEngine_Keyframe.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Keyframe.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Keyframe.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Keyframe.<>f__mg$cacheA, typeof(Keyframe), typeof(ValueType));
	}

	// Token: 0x040192A5 RID: 103077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192A6 RID: 103078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192A7 RID: 103079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192A8 RID: 103080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192A9 RID: 103081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040192AA RID: 103082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040192AB RID: 103083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040192AC RID: 103084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040192AD RID: 103085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040192AE RID: 103086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040192AF RID: 103087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
