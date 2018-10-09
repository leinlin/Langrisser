using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001678 RID: 5752
[Preserve]
public class Lua_UnityEngine_ContactPoint2D : LuaObject
{
	// Token: 0x06022FBA RID: 143290 RVA: 0x00C1BCA0 File Offset: 0x00C19EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D = default(ContactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FBB RID: 143291 RVA: 0x00C1BCF0 File Offset: 0x00C19EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_point(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FBC RID: 143292 RVA: 0x00C1BD44 File Offset: 0x00C19F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FBD RID: 143293 RVA: 0x00C1BD98 File Offset: 0x00C19F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_separation(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.separation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FBE RID: 143294 RVA: 0x00C1BDEC File Offset: 0x00C19FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalImpulse(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.normalImpulse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FBF RID: 143295 RVA: 0x00C1BE40 File Offset: 0x00C1A040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tangentImpulse(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.tangentImpulse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC0 RID: 143296 RVA: 0x00C1BE94 File Offset: 0x00C1A094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeVelocity(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.relativeVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC1 RID: 143297 RVA: 0x00C1BEE8 File Offset: 0x00C1A0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collider(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.collider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC2 RID: 143298 RVA: 0x00C1BF3C File Offset: 0x00C1A13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_otherCollider(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.otherCollider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC3 RID: 143299 RVA: 0x00C1BF90 File Offset: 0x00C1A190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rigidbody(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.rigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC4 RID: 143300 RVA: 0x00C1BFE4 File Offset: 0x00C1A1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_otherRigidbody(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.otherRigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC5 RID: 143301 RVA: 0x00C1C038 File Offset: 0x00C1A238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			ContactPoint2D contactPoint2D;
			LuaObject.checkValueType<ContactPoint2D>(l, 1, out contactPoint2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactPoint2D.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FC6 RID: 143302 RVA: 0x00C1C08C File Offset: 0x00C1A28C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ContactPoint2D");
		string name = "point";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_point);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache0, null, true);
		string name2 = "normal";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_normal);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache1, null, true);
		string name3 = "separation";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_separation);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache2, null, true);
		string name4 = "normalImpulse";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_normalImpulse);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache3, null, true);
		string name5 = "tangentImpulse";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_tangentImpulse);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache4, null, true);
		string name6 = "relativeVelocity";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_relativeVelocity);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache5, null, true);
		string name7 = "collider";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_collider);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache6, null, true);
		string name8 = "otherCollider";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_otherCollider);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache7, null, true);
		string name9 = "rigidbody";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_rigidbody);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache8, null, true);
		string name10 = "otherRigidbody";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_otherRigidbody);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_ContactPoint2D.<>f__mg$cache9, null, true);
		string name11 = "enabled";
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.get_enabled);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_ContactPoint2D.<>f__mg$cacheA, null, true);
		if (Lua_UnityEngine_ContactPoint2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_ContactPoint2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_ContactPoint2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ContactPoint2D.<>f__mg$cacheB, typeof(ContactPoint2D), typeof(ValueType));
	}

	// Token: 0x04018F28 RID: 102184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F29 RID: 102185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F2A RID: 102186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F2B RID: 102187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F2C RID: 102188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F2D RID: 102189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F2E RID: 102190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F2F RID: 102191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F30 RID: 102192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F31 RID: 102193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018F32 RID: 102194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018F33 RID: 102195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
