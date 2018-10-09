using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200165A RID: 5722
[Preserve]
public class Lua_UnityEngine_CircleCollider2D : LuaObject
{
	// Token: 0x06022E41 RID: 142913 RVA: 0x00C0FDFC File Offset: 0x00C0DFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_radius(IntPtr l)
	{
		int result;
		try
		{
			CircleCollider2D circleCollider2D = (CircleCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, circleCollider2D.radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E42 RID: 142914 RVA: 0x00C0FE50 File Offset: 0x00C0E050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_radius(IntPtr l)
	{
		int result;
		try
		{
			CircleCollider2D circleCollider2D = (CircleCollider2D)LuaObject.checkSelf(l);
			float radius;
			LuaObject.checkType(l, 2, out radius);
			circleCollider2D.radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E43 RID: 142915 RVA: 0x00C0FEA8 File Offset: 0x00C0E0A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CircleCollider2D");
		string name = "radius";
		if (Lua_UnityEngine_CircleCollider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CircleCollider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CircleCollider2D.get_radius);
		}
		LuaCSFunction get = Lua_UnityEngine_CircleCollider2D.<>f__mg$cache0;
		if (Lua_UnityEngine_CircleCollider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CircleCollider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CircleCollider2D.set_radius);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CircleCollider2D.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(CircleCollider2D), typeof(Collider2D));
	}

	// Token: 0x04018DEB RID: 101867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018DEC RID: 101868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
