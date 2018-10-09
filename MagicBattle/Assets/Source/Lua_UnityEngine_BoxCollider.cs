using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001646 RID: 5702
[Preserve]
public class Lua_UnityEngine_BoxCollider : LuaObject
{
	// Token: 0x06022CB1 RID: 142513 RVA: 0x00C043DC File Offset: 0x00C025DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider boxCollider = (BoxCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxCollider.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CB2 RID: 142514 RVA: 0x00C04430 File Offset: 0x00C02630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider boxCollider = (BoxCollider)LuaObject.checkSelf(l);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			boxCollider.center = center;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CB3 RID: 142515 RVA: 0x00C04488 File Offset: 0x00C02688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider boxCollider = (BoxCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxCollider.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CB4 RID: 142516 RVA: 0x00C044DC File Offset: 0x00C026DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider boxCollider = (BoxCollider)LuaObject.checkSelf(l);
			Vector3 size;
			LuaObject.checkType(l, 2, out size);
			boxCollider.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CB5 RID: 142517 RVA: 0x00C04534 File Offset: 0x00C02734
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BoxCollider");
		string name = "center";
		if (Lua_UnityEngine_BoxCollider.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BoxCollider.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BoxCollider.get_center);
		}
		LuaCSFunction get = Lua_UnityEngine_BoxCollider.<>f__mg$cache0;
		if (Lua_UnityEngine_BoxCollider.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BoxCollider.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BoxCollider.set_center);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BoxCollider.<>f__mg$cache1, true);
		string name2 = "size";
		if (Lua_UnityEngine_BoxCollider.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BoxCollider.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BoxCollider.get_size);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BoxCollider.<>f__mg$cache2;
		if (Lua_UnityEngine_BoxCollider.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BoxCollider.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BoxCollider.set_size);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BoxCollider.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(BoxCollider), typeof(Collider));
	}

	// Token: 0x04018C83 RID: 101507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C84 RID: 101508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C85 RID: 101509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C86 RID: 101510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
