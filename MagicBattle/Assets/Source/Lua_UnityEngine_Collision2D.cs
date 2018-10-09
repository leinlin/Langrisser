using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001661 RID: 5729
[Preserve]
public class Lua_UnityEngine_Collision2D : LuaObject
{
	// Token: 0x06022E8D RID: 142989 RVA: 0x00C126DC File Offset: 0x00C108DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Collision2D o = new Collision2D();
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

	// Token: 0x06022E8E RID: 142990 RVA: 0x00C12724 File Offset: 0x00C10924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetContacts(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			ContactPoint2D[] contacts;
			LuaObject.checkArray<ContactPoint2D>(l, 2, out contacts);
			int contacts2 = collision2D.GetContacts(contacts);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contacts2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E8F RID: 142991 RVA: 0x00C12788 File Offset: 0x00C10988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collider(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.collider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E90 RID: 142992 RVA: 0x00C127DC File Offset: 0x00C109DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_otherCollider(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.otherCollider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E91 RID: 142993 RVA: 0x00C12830 File Offset: 0x00C10A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rigidbody(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.rigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E92 RID: 142994 RVA: 0x00C12884 File Offset: 0x00C10A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_otherRigidbody(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.otherRigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E93 RID: 142995 RVA: 0x00C128D8 File Offset: 0x00C10AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E94 RID: 142996 RVA: 0x00C1292C File Offset: 0x00C10B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E95 RID: 142997 RVA: 0x00C12980 File Offset: 0x00C10B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_contacts(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.contacts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E96 RID: 142998 RVA: 0x00C129D4 File Offset: 0x00C10BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeVelocity(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.relativeVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E97 RID: 142999 RVA: 0x00C12A28 File Offset: 0x00C10C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Collision2D collision2D = (Collision2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision2D.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E98 RID: 143000 RVA: 0x00C12A7C File Offset: 0x00C10C7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Collision2D");
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Collision2D.GetContacts);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collision2D.<>f__mg$cache0);
		string name = "collider";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_collider);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Collision2D.<>f__mg$cache1, null, true);
		string name2 = "otherCollider";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_otherCollider);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Collision2D.<>f__mg$cache2, null, true);
		string name3 = "rigidbody";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_rigidbody);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Collision2D.<>f__mg$cache3, null, true);
		string name4 = "otherRigidbody";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_otherRigidbody);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Collision2D.<>f__mg$cache4, null, true);
		string name5 = "transform";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_transform);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Collision2D.<>f__mg$cache5, null, true);
		string name6 = "gameObject";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_gameObject);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Collision2D.<>f__mg$cache6, null, true);
		string name7 = "contacts";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_contacts);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Collision2D.<>f__mg$cache7, null, true);
		string name8 = "relativeVelocity";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_relativeVelocity);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Collision2D.<>f__mg$cache8, null, true);
		string name9 = "enabled";
		if (Lua_UnityEngine_Collision2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Collision2D.get_enabled);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Collision2D.<>f__mg$cache9, null, true);
		if (Lua_UnityEngine_Collision2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Collision2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Collision2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Collision2D.<>f__mg$cacheA, typeof(Collision2D));
	}

	// Token: 0x04018E29 RID: 101929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E2A RID: 101930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E2B RID: 101931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E2C RID: 101932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E2D RID: 101933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E2E RID: 101934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E2F RID: 101935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E30 RID: 101936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E31 RID: 101937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E32 RID: 101938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E33 RID: 101939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
