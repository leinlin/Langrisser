using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200176A RID: 5994
[Preserve]
public class Lua_UnityEngine_Ray2D : LuaObject
{
	// Token: 0x0602394B RID: 145739 RVA: 0x00C6DE58 File Offset: 0x00C6C058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Vector2 origin;
			LuaObject.checkType(l, 2, out origin);
			Vector2 direction;
			LuaObject.checkType(l, 3, out direction);
			Ray2D ray2D = new Ray2D(origin, direction);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602394C RID: 145740 RVA: 0x00C6DEC0 File Offset: 0x00C6C0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPoint(IntPtr l)
	{
		int result;
		try
		{
			Ray2D ray2D;
			LuaObject.checkValueType<Ray2D>(l, 1, out ray2D);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			Vector2 point = ray2D.GetPoint(distance);
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

	// Token: 0x0602394D RID: 145741 RVA: 0x00C6DF20 File Offset: 0x00C6C120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_origin(IntPtr l)
	{
		int result;
		try
		{
			Ray2D ray2D;
			LuaObject.checkValueType<Ray2D>(l, 1, out ray2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray2D.origin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602394E RID: 145742 RVA: 0x00C6DF74 File Offset: 0x00C6C174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_origin(IntPtr l)
	{
		int result;
		try
		{
			Ray2D ray2D;
			LuaObject.checkValueType<Ray2D>(l, 1, out ray2D);
			Vector2 origin;
			LuaObject.checkType(l, 2, out origin);
			ray2D.origin = origin;
			LuaObject.setBack(l, ray2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602394F RID: 145743 RVA: 0x00C6DFD8 File Offset: 0x00C6C1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_direction(IntPtr l)
	{
		int result;
		try
		{
			Ray2D ray2D;
			LuaObject.checkValueType<Ray2D>(l, 1, out ray2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray2D.direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023950 RID: 145744 RVA: 0x00C6E02C File Offset: 0x00C6C22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_direction(IntPtr l)
	{
		int result;
		try
		{
			Ray2D ray2D;
			LuaObject.checkValueType<Ray2D>(l, 1, out ray2D);
			Vector2 direction;
			LuaObject.checkType(l, 2, out direction);
			ray2D.direction = direction;
			LuaObject.setBack(l, ray2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023951 RID: 145745 RVA: 0x00C6E090 File Offset: 0x00C6C290
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Ray2D");
		if (Lua_UnityEngine_Ray2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Ray2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Ray2D.GetPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Ray2D.<>f__mg$cache0);
		string name = "origin";
		if (Lua_UnityEngine_Ray2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Ray2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Ray2D.get_origin);
		}
		LuaCSFunction get = Lua_UnityEngine_Ray2D.<>f__mg$cache1;
		if (Lua_UnityEngine_Ray2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Ray2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Ray2D.set_origin);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Ray2D.<>f__mg$cache2, true);
		string name2 = "direction";
		if (Lua_UnityEngine_Ray2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Ray2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Ray2D.get_direction);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Ray2D.<>f__mg$cache3;
		if (Lua_UnityEngine_Ray2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Ray2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Ray2D.set_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Ray2D.<>f__mg$cache4, true);
		if (Lua_UnityEngine_Ray2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Ray2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Ray2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Ray2D.<>f__mg$cache5, typeof(Ray2D), typeof(ValueType));
	}

	// Token: 0x040196D5 RID: 104149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196D6 RID: 104150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196D7 RID: 104151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196D8 RID: 104152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196D9 RID: 104153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196DA RID: 104154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
