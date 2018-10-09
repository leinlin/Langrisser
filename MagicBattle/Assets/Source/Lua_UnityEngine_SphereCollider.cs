using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017DD RID: 6109
[Preserve]
public class Lua_UnityEngine_SphereCollider : LuaObject
{
	// Token: 0x06023D72 RID: 146802 RVA: 0x00C8FB9C File Offset: 0x00C8DD9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			SphereCollider sphereCollider = (SphereCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sphereCollider.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D73 RID: 146803 RVA: 0x00C8FBF0 File Offset: 0x00C8DDF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			SphereCollider sphereCollider = (SphereCollider)LuaObject.checkSelf(l);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			sphereCollider.center = center;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D74 RID: 146804 RVA: 0x00C8FC48 File Offset: 0x00C8DE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_radius(IntPtr l)
	{
		int result;
		try
		{
			SphereCollider sphereCollider = (SphereCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sphereCollider.radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D75 RID: 146805 RVA: 0x00C8FC9C File Offset: 0x00C8DE9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_radius(IntPtr l)
	{
		int result;
		try
		{
			SphereCollider sphereCollider = (SphereCollider)LuaObject.checkSelf(l);
			float radius;
			LuaObject.checkType(l, 2, out radius);
			sphereCollider.radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D76 RID: 146806 RVA: 0x00C8FCF4 File Offset: 0x00C8DEF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SphereCollider");
		string name = "center";
		if (Lua_UnityEngine_SphereCollider.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SphereCollider.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SphereCollider.get_center);
		}
		LuaCSFunction get = Lua_UnityEngine_SphereCollider.<>f__mg$cache0;
		if (Lua_UnityEngine_SphereCollider.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SphereCollider.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SphereCollider.set_center);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SphereCollider.<>f__mg$cache1, true);
		string name2 = "radius";
		if (Lua_UnityEngine_SphereCollider.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SphereCollider.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SphereCollider.get_radius);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SphereCollider.<>f__mg$cache2;
		if (Lua_UnityEngine_SphereCollider.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SphereCollider.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SphereCollider.set_radius);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SphereCollider.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(SphereCollider), typeof(Collider));
	}

	// Token: 0x04019A16 RID: 104982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A17 RID: 104983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A18 RID: 104984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A19 RID: 104985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
