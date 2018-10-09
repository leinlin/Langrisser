using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200165F RID: 5727
[Preserve]
public class Lua_UnityEngine_ColliderDistance2D : LuaObject
{
	// Token: 0x06022E76 RID: 142966 RVA: 0x00C11D38 File Offset: 0x00C0FF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D = default(ColliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E77 RID: 142967 RVA: 0x00C11D88 File Offset: 0x00C0FF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointA(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D.pointA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E78 RID: 142968 RVA: 0x00C11DDC File Offset: 0x00C0FFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointA(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			Vector2 pointA;
			LuaObject.checkType(l, 2, out pointA);
			colliderDistance2D.pointA = pointA;
			LuaObject.setBack(l, colliderDistance2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E79 RID: 142969 RVA: 0x00C11E40 File Offset: 0x00C10040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointB(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D.pointB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E7A RID: 142970 RVA: 0x00C11E94 File Offset: 0x00C10094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointB(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			Vector2 pointB;
			LuaObject.checkType(l, 2, out pointB);
			colliderDistance2D.pointB = pointB;
			LuaObject.setBack(l, colliderDistance2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E7B RID: 142971 RVA: 0x00C11EF8 File Offset: 0x00C100F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E7C RID: 142972 RVA: 0x00C11F4C File Offset: 0x00C1014C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E7D RID: 142973 RVA: 0x00C11FA0 File Offset: 0x00C101A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			colliderDistance2D.distance = distance;
			LuaObject.setBack(l, colliderDistance2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E7E RID: 142974 RVA: 0x00C12004 File Offset: 0x00C10204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isOverlapped(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D.isOverlapped);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E7F RID: 142975 RVA: 0x00C12058 File Offset: 0x00C10258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isValid(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D.isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E80 RID: 142976 RVA: 0x00C120AC File Offset: 0x00C102AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isValid(IntPtr l)
	{
		int result;
		try
		{
			ColliderDistance2D colliderDistance2D;
			LuaObject.checkValueType<ColliderDistance2D>(l, 1, out colliderDistance2D);
			bool isValid;
			LuaObject.checkType(l, 2, out isValid);
			colliderDistance2D.isValid = isValid;
			LuaObject.setBack(l, colliderDistance2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E81 RID: 142977 RVA: 0x00C12110 File Offset: 0x00C10310
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ColliderDistance2D");
		string name = "pointA";
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.get_pointA);
		}
		LuaCSFunction get = Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache0;
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.set_pointA);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache1, true);
		string name2 = "pointB";
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.get_pointB);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache2;
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.set_pointB);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache3, true);
		string name3 = "normal";
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.get_normal);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache4, null, true);
		string name4 = "distance";
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.get_distance);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache5;
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.set_distance);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache6, true);
		string name5 = "isOverlapped";
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.get_isOverlapped);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache7, null, true);
		string name6 = "isValid";
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.get_isValid);
		}
		LuaCSFunction get4 = Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache8;
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.set_isValid);
		}
		LuaObject.addMember(l, name6, get4, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cache9, true);
		if (Lua_UnityEngine_ColliderDistance2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ColliderDistance2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ColliderDistance2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ColliderDistance2D.<>f__mg$cacheA, typeof(ColliderDistance2D), typeof(ValueType));
	}

	// Token: 0x04018E16 RID: 101910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E17 RID: 101911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E18 RID: 101912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E19 RID: 101913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E1A RID: 101914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E1B RID: 101915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E1C RID: 101916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E1D RID: 101917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E1E RID: 101918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E1F RID: 101919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E20 RID: 101920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
