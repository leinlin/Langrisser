using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001759 RID: 5977
[Preserve]
public class Lua_UnityEngine_Pose : LuaObject
{
	// Token: 0x0602386F RID: 145519 RVA: 0x00C67D70 File Offset: 0x00C65F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Quaternion rotation;
			LuaObject.checkType(l, 3, out rotation);
			Pose pose = new Pose(position, rotation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023870 RID: 145520 RVA: 0x00C67DD8 File Offset: 0x00C65FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTransformedBy(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Pose)))
			{
				Pose pose;
				LuaObject.checkValueType<Pose>(l, 1, out pose);
				Pose lhs;
				LuaObject.checkValueType<Pose>(l, 2, out lhs);
				Pose transformedBy = pose.GetTransformedBy(lhs);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, transformedBy);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Transform)))
			{
				Pose pose2;
				LuaObject.checkValueType<Pose>(l, 1, out pose2);
				Transform lhs2;
				LuaObject.checkType<Transform>(l, 2, out lhs2);
				Pose transformedBy2 = pose2.GetTransformedBy(lhs2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, transformedBy2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTransformedBy to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023871 RID: 145521 RVA: 0x00C67ECC File Offset: 0x00C660CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pose.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023872 RID: 145522 RVA: 0x00C67F20 File Offset: 0x00C66120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			pose.position = position;
			LuaObject.setBack(l, pose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023873 RID: 145523 RVA: 0x00C67F84 File Offset: 0x00C66184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pose.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023874 RID: 145524 RVA: 0x00C67FD8 File Offset: 0x00C661D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotation(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			Quaternion rotation;
			LuaObject.checkType(l, 2, out rotation);
			pose.rotation = rotation;
			LuaObject.setBack(l, pose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023875 RID: 145525 RVA: 0x00C6803C File Offset: 0x00C6623C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_forward(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pose.forward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023876 RID: 145526 RVA: 0x00C68090 File Offset: 0x00C66290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pose.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023877 RID: 145527 RVA: 0x00C680E4 File Offset: 0x00C662E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_up(IntPtr l)
	{
		int result;
		try
		{
			Pose pose;
			LuaObject.checkValueType<Pose>(l, 1, out pose);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pose.up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023878 RID: 145528 RVA: 0x00C68138 File Offset: 0x00C66338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_identity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Pose.identity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023879 RID: 145529 RVA: 0x00C68184 File Offset: 0x00C66384
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Pose");
		if (Lua_UnityEngine_Pose.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Pose.GetTransformedBy);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Pose.<>f__mg$cache0);
		string name = "position";
		if (Lua_UnityEngine_Pose.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Pose.get_position);
		}
		LuaCSFunction get = Lua_UnityEngine_Pose.<>f__mg$cache1;
		if (Lua_UnityEngine_Pose.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Pose.set_position);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Pose.<>f__mg$cache2, true);
		string name2 = "rotation";
		if (Lua_UnityEngine_Pose.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Pose.get_rotation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Pose.<>f__mg$cache3;
		if (Lua_UnityEngine_Pose.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Pose.set_rotation);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Pose.<>f__mg$cache4, true);
		string name3 = "forward";
		if (Lua_UnityEngine_Pose.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Pose.get_forward);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Pose.<>f__mg$cache5, null, true);
		string name4 = "right";
		if (Lua_UnityEngine_Pose.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Pose.get_right);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Pose.<>f__mg$cache6, null, true);
		string name5 = "up";
		if (Lua_UnityEngine_Pose.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Pose.get_up);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Pose.<>f__mg$cache7, null, true);
		string name6 = "identity";
		if (Lua_UnityEngine_Pose.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Pose.get_identity);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Pose.<>f__mg$cache8, null, false);
		if (Lua_UnityEngine_Pose.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Pose.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Pose.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Pose.<>f__mg$cache9, typeof(Pose), typeof(ValueType));
	}

	// Token: 0x0401961B RID: 103963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401961C RID: 103964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401961D RID: 103965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401961E RID: 103966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401961F RID: 103967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019620 RID: 103968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019621 RID: 103969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019622 RID: 103970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019623 RID: 103971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019624 RID: 103972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
