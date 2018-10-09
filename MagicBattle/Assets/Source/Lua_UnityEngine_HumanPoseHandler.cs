using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E7 RID: 5863
[Preserve]
public class Lua_UnityEngine_HumanPoseHandler : LuaObject
{
	// Token: 0x06023362 RID: 144226 RVA: 0x00C37E58 File Offset: 0x00C36058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Avatar avatar;
			LuaObject.checkType<Avatar>(l, 2, out avatar);
			Transform root;
			LuaObject.checkType<Transform>(l, 3, out root);
			HumanPoseHandler o = new HumanPoseHandler(avatar, root);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023363 RID: 144227 RVA: 0x00C37EB8 File Offset: 0x00C360B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			HumanPoseHandler humanPoseHandler = (HumanPoseHandler)LuaObject.checkSelf(l);
			humanPoseHandler.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023364 RID: 144228 RVA: 0x00C37F04 File Offset: 0x00C36104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHumanPose(IntPtr l)
	{
		int result;
		try
		{
			HumanPoseHandler humanPoseHandler = (HumanPoseHandler)LuaObject.checkSelf(l);
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 2, out humanPose);
			humanPoseHandler.GetHumanPose(ref humanPose);
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

	// Token: 0x06023365 RID: 144229 RVA: 0x00C37F68 File Offset: 0x00C36168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHumanPose(IntPtr l)
	{
		int result;
		try
		{
			HumanPoseHandler humanPoseHandler = (HumanPoseHandler)LuaObject.checkSelf(l);
			HumanPose humanPose;
			LuaObject.checkValueType<HumanPose>(l, 2, out humanPose);
			humanPoseHandler.SetHumanPose(ref humanPose);
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

	// Token: 0x06023366 RID: 144230 RVA: 0x00C37FCC File Offset: 0x00C361CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HumanPoseHandler");
		if (Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HumanPoseHandler.Dispose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache0);
		if (Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HumanPoseHandler.GetHumanPose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache1);
		if (Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HumanPoseHandler.SetHumanPose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache2);
		if (Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HumanPoseHandler.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_HumanPoseHandler.<>f__mg$cache3, typeof(HumanPoseHandler));
	}

	// Token: 0x040191F2 RID: 102898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191F3 RID: 102899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191F4 RID: 102900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191F5 RID: 102901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
