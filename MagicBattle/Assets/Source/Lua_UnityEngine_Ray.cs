using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001769 RID: 5993
[Preserve]
public class Lua_UnityEngine_Ray : LuaObject
{
	// Token: 0x06023943 RID: 145731 RVA: 0x00C6DB18 File Offset: 0x00C6BD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Vector3 origin;
			LuaObject.checkType(l, 2, out origin);
			Vector3 direction;
			LuaObject.checkType(l, 3, out direction);
			Ray ray = new Ray(origin, direction);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023944 RID: 145732 RVA: 0x00C6DB80 File Offset: 0x00C6BD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPoint(IntPtr l)
	{
		int result;
		try
		{
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 1, out ray);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			Vector3 point = ray.GetPoint(distance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023945 RID: 145733 RVA: 0x00C6DBE0 File Offset: 0x00C6BDE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_origin(IntPtr l)
	{
		int result;
		try
		{
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 1, out ray);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray.origin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023946 RID: 145734 RVA: 0x00C6DC34 File Offset: 0x00C6BE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_origin(IntPtr l)
	{
		int result;
		try
		{
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 1, out ray);
			Vector3 origin;
			LuaObject.checkType(l, 2, out origin);
			ray.origin = origin;
			LuaObject.setBack(l, ray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023947 RID: 145735 RVA: 0x00C6DC98 File Offset: 0x00C6BE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_direction(IntPtr l)
	{
		int result;
		try
		{
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 1, out ray);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray.direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023948 RID: 145736 RVA: 0x00C6DCEC File Offset: 0x00C6BEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_direction(IntPtr l)
	{
		int result;
		try
		{
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 1, out ray);
			Vector3 direction;
			LuaObject.checkType(l, 2, out direction);
			ray.direction = direction;
			LuaObject.setBack(l, ray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023949 RID: 145737 RVA: 0x00C6DD50 File Offset: 0x00C6BF50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Ray");
		if (Lua_UnityEngine_Ray.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Ray.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Ray.GetPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Ray.<>f__mg$cache0);
		string name = "origin";
		if (Lua_UnityEngine_Ray.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Ray.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Ray.get_origin);
		}
		LuaCSFunction get = Lua_UnityEngine_Ray.<>f__mg$cache1;
		if (Lua_UnityEngine_Ray.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Ray.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Ray.set_origin);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Ray.<>f__mg$cache2, true);
		string name2 = "direction";
		if (Lua_UnityEngine_Ray.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Ray.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Ray.get_direction);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Ray.<>f__mg$cache3;
		if (Lua_UnityEngine_Ray.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Ray.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Ray.set_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Ray.<>f__mg$cache4, true);
		if (Lua_UnityEngine_Ray.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Ray.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Ray.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Ray.<>f__mg$cache5, typeof(Ray), typeof(ValueType));
	}

	// Token: 0x040196CF RID: 104143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196D0 RID: 104144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196D1 RID: 104145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196D2 RID: 104146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196D3 RID: 104147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196D4 RID: 104148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
