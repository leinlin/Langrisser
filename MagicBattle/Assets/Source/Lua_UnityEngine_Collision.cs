using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001660 RID: 5728
[Preserve]
public class Lua_UnityEngine_Collision : LuaObject
{
	// Token: 0x06022E83 RID: 142979 RVA: 0x00C122D4 File Offset: 0x00C104D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Collision o = new Collision();
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

	// Token: 0x06022E84 RID: 142980 RVA: 0x00C1231C File Offset: 0x00C1051C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeVelocity(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.relativeVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E85 RID: 142981 RVA: 0x00C12370 File Offset: 0x00C10570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rigidbody(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.rigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E86 RID: 142982 RVA: 0x00C123C4 File Offset: 0x00C105C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collider(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.collider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E87 RID: 142983 RVA: 0x00C12418 File Offset: 0x00C10618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E88 RID: 142984 RVA: 0x00C1246C File Offset: 0x00C1066C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E89 RID: 142985 RVA: 0x00C124C0 File Offset: 0x00C106C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_contacts(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.contacts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E8A RID: 142986 RVA: 0x00C12514 File Offset: 0x00C10714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_impulse(IntPtr l)
	{
		int result;
		try
		{
			Collision collision = (Collision)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collision.impulse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E8B RID: 142987 RVA: 0x00C12568 File Offset: 0x00C10768
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Collision");
		string name = "relativeVelocity";
		if (Lua_UnityEngine_Collision.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Collision.get_relativeVelocity);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Collision.<>f__mg$cache0, null, true);
		string name2 = "rigidbody";
		if (Lua_UnityEngine_Collision.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Collision.get_rigidbody);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Collision.<>f__mg$cache1, null, true);
		string name3 = "collider";
		if (Lua_UnityEngine_Collision.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Collision.get_collider);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Collision.<>f__mg$cache2, null, true);
		string name4 = "transform";
		if (Lua_UnityEngine_Collision.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Collision.get_transform);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Collision.<>f__mg$cache3, null, true);
		string name5 = "gameObject";
		if (Lua_UnityEngine_Collision.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Collision.get_gameObject);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Collision.<>f__mg$cache4, null, true);
		string name6 = "contacts";
		if (Lua_UnityEngine_Collision.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Collision.get_contacts);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Collision.<>f__mg$cache5, null, true);
		string name7 = "impulse";
		if (Lua_UnityEngine_Collision.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Collision.get_impulse);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Collision.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_Collision.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Collision.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Collision.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Collision.<>f__mg$cache7, typeof(Collision));
	}

	// Token: 0x04018E21 RID: 101921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E22 RID: 101922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E23 RID: 101923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E24 RID: 101924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E25 RID: 101925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E26 RID: 101926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E27 RID: 101927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E28 RID: 101928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
