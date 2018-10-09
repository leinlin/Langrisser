using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200168D RID: 5773
[Preserve]
public class Lua_UnityEngine_DistanceJoint2D : LuaObject
{
	// Token: 0x0602307B RID: 143483 RVA: 0x00C21AA0 File Offset: 0x00C1FCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoConfigureDistance(IntPtr l)
	{
		int result;
		try
		{
			DistanceJoint2D distanceJoint2D = (DistanceJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, distanceJoint2D.autoConfigureDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602307C RID: 143484 RVA: 0x00C21AF4 File Offset: 0x00C1FCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoConfigureDistance(IntPtr l)
	{
		int result;
		try
		{
			DistanceJoint2D distanceJoint2D = (DistanceJoint2D)LuaObject.checkSelf(l);
			bool autoConfigureDistance;
			LuaObject.checkType(l, 2, out autoConfigureDistance);
			distanceJoint2D.autoConfigureDistance = autoConfigureDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602307D RID: 143485 RVA: 0x00C21B4C File Offset: 0x00C1FD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			DistanceJoint2D distanceJoint2D = (DistanceJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, distanceJoint2D.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602307E RID: 143486 RVA: 0x00C21BA0 File Offset: 0x00C1FDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			DistanceJoint2D distanceJoint2D = (DistanceJoint2D)LuaObject.checkSelf(l);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			distanceJoint2D.distance = distance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602307F RID: 143487 RVA: 0x00C21BF8 File Offset: 0x00C1FDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxDistanceOnly(IntPtr l)
	{
		int result;
		try
		{
			DistanceJoint2D distanceJoint2D = (DistanceJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, distanceJoint2D.maxDistanceOnly);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023080 RID: 143488 RVA: 0x00C21C4C File Offset: 0x00C1FE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxDistanceOnly(IntPtr l)
	{
		int result;
		try
		{
			DistanceJoint2D distanceJoint2D = (DistanceJoint2D)LuaObject.checkSelf(l);
			bool maxDistanceOnly;
			LuaObject.checkType(l, 2, out maxDistanceOnly);
			distanceJoint2D.maxDistanceOnly = maxDistanceOnly;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023081 RID: 143489 RVA: 0x00C21CA4 File Offset: 0x00C1FEA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.DistanceJoint2D");
		string name = "autoConfigureDistance";
		if (Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_DistanceJoint2D.get_autoConfigureDistance);
		}
		LuaCSFunction get = Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_DistanceJoint2D.set_autoConfigureDistance);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache1, true);
		string name2 = "distance";
		if (Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_DistanceJoint2D.get_distance);
		}
		LuaCSFunction get2 = Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_DistanceJoint2D.set_distance);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache3, true);
		string name3 = "maxDistanceOnly";
		if (Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_DistanceJoint2D.get_maxDistanceOnly);
		}
		LuaCSFunction get3 = Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache4;
		if (Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_DistanceJoint2D.set_maxDistanceOnly);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_DistanceJoint2D.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(DistanceJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x04018FBF RID: 102335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FC0 RID: 102336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FC1 RID: 102337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018FC2 RID: 102338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018FC3 RID: 102339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018FC4 RID: 102340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
