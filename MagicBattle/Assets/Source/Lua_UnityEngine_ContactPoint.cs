using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001677 RID: 5751
[Preserve]
public class Lua_UnityEngine_ContactPoint : LuaObject
{
	// Token: 0x06022FB2 RID: 143282 RVA: 0x00C1B980 File Offset: 0x00C19B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint contactPoint = default(ContactPoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB3 RID: 143283 RVA: 0x00C1B9D0 File Offset: 0x00C19BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_point(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint contactPoint;
			LuaObject.checkValueType<ContactPoint>(l, 1, out contactPoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint.point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB4 RID: 143284 RVA: 0x00C1BA24 File Offset: 0x00C19C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint contactPoint;
			LuaObject.checkValueType<ContactPoint>(l, 1, out contactPoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB5 RID: 143285 RVA: 0x00C1BA78 File Offset: 0x00C19C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_thisCollider(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint contactPoint;
			LuaObject.checkValueType<ContactPoint>(l, 1, out contactPoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint.thisCollider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB6 RID: 143286 RVA: 0x00C1BACC File Offset: 0x00C19CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_otherCollider(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint contactPoint;
			LuaObject.checkValueType<ContactPoint>(l, 1, out contactPoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint.otherCollider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB7 RID: 143287 RVA: 0x00C1BB20 File Offset: 0x00C19D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_separation(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint contactPoint;
			LuaObject.checkValueType<ContactPoint>(l, 1, out contactPoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint.separation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB8 RID: 143288 RVA: 0x00C1BB74 File Offset: 0x00C19D74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ContactPoint");
		string name = "point";
		if (Lua_UnityEngine_ContactPoint.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ContactPoint.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ContactPoint.get_point);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_ContactPoint.<>f__mg$cache0, null, true);
		string name2 = "normal";
		if (Lua_UnityEngine_ContactPoint.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ContactPoint.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ContactPoint.get_normal);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_ContactPoint.<>f__mg$cache1, null, true);
		string name3 = "thisCollider";
		if (Lua_UnityEngine_ContactPoint.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ContactPoint.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ContactPoint.get_thisCollider);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_ContactPoint.<>f__mg$cache2, null, true);
		string name4 = "otherCollider";
		if (Lua_UnityEngine_ContactPoint.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ContactPoint.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ContactPoint.get_otherCollider);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_ContactPoint.<>f__mg$cache3, null, true);
		string name5 = "separation";
		if (Lua_UnityEngine_ContactPoint.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ContactPoint.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ContactPoint.get_separation);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_ContactPoint.<>f__mg$cache4, null, true);
		if (Lua_UnityEngine_ContactPoint.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ContactPoint.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ContactPoint.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ContactPoint.<>f__mg$cache5, typeof(ContactPoint), typeof(ValueType));
	}

	// Token: 0x04018F22 RID: 102178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F23 RID: 102179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F24 RID: 102180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F25 RID: 102181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F26 RID: 102182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F27 RID: 102183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
