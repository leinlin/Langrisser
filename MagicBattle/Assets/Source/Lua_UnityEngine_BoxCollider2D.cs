using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001647 RID: 5703
[Preserve]
public class Lua_UnityEngine_BoxCollider2D : LuaObject
{
	// Token: 0x06022CB7 RID: 142519 RVA: 0x00C045FC File Offset: 0x00C027FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider2D boxCollider2D = (BoxCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxCollider2D.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CB8 RID: 142520 RVA: 0x00C04650 File Offset: 0x00C02850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider2D boxCollider2D = (BoxCollider2D)LuaObject.checkSelf(l);
			Vector2 size;
			LuaObject.checkType(l, 2, out size);
			boxCollider2D.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CB9 RID: 142521 RVA: 0x00C046A8 File Offset: 0x00C028A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_edgeRadius(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider2D boxCollider2D = (BoxCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxCollider2D.edgeRadius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CBA RID: 142522 RVA: 0x00C046FC File Offset: 0x00C028FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_edgeRadius(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider2D boxCollider2D = (BoxCollider2D)LuaObject.checkSelf(l);
			float edgeRadius;
			LuaObject.checkType(l, 2, out edgeRadius);
			boxCollider2D.edgeRadius = edgeRadius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CBB RID: 142523 RVA: 0x00C04754 File Offset: 0x00C02954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoTiling(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider2D boxCollider2D = (BoxCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxCollider2D.autoTiling);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CBC RID: 142524 RVA: 0x00C047A8 File Offset: 0x00C029A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoTiling(IntPtr l)
	{
		int result;
		try
		{
			BoxCollider2D boxCollider2D = (BoxCollider2D)LuaObject.checkSelf(l);
			bool autoTiling;
			LuaObject.checkType(l, 2, out autoTiling);
			boxCollider2D.autoTiling = autoTiling;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CBD RID: 142525 RVA: 0x00C04800 File Offset: 0x00C02A00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BoxCollider2D");
		string name = "size";
		if (Lua_UnityEngine_BoxCollider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BoxCollider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BoxCollider2D.get_size);
		}
		LuaCSFunction get = Lua_UnityEngine_BoxCollider2D.<>f__mg$cache0;
		if (Lua_UnityEngine_BoxCollider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BoxCollider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BoxCollider2D.set_size);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BoxCollider2D.<>f__mg$cache1, true);
		string name2 = "edgeRadius";
		if (Lua_UnityEngine_BoxCollider2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BoxCollider2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BoxCollider2D.get_edgeRadius);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BoxCollider2D.<>f__mg$cache2;
		if (Lua_UnityEngine_BoxCollider2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BoxCollider2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BoxCollider2D.set_edgeRadius);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BoxCollider2D.<>f__mg$cache3, true);
		string name3 = "autoTiling";
		if (Lua_UnityEngine_BoxCollider2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_BoxCollider2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_BoxCollider2D.get_autoTiling);
		}
		LuaCSFunction get3 = Lua_UnityEngine_BoxCollider2D.<>f__mg$cache4;
		if (Lua_UnityEngine_BoxCollider2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_BoxCollider2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_BoxCollider2D.set_autoTiling);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_BoxCollider2D.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(BoxCollider2D), typeof(Collider2D));
	}

	// Token: 0x04018C87 RID: 101511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C88 RID: 101512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C89 RID: 101513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C8A RID: 101514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C8B RID: 101515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C8C RID: 101516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
