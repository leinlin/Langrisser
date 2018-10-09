using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001692 RID: 5778
[Preserve]
public class Lua_UnityEngine_EdgeCollider2D : LuaObject
{
	// Token: 0x06023099 RID: 143513 RVA: 0x00C22628 File Offset: 0x00C20828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reset(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			edgeCollider2D.Reset();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602309A RID: 143514 RVA: 0x00C22674 File Offset: 0x00C20874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_points(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, edgeCollider2D.points);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602309B RID: 143515 RVA: 0x00C226C8 File Offset: 0x00C208C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_points(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			Vector2[] points;
			LuaObject.checkArray<Vector2>(l, 2, out points);
			edgeCollider2D.points = points;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602309C RID: 143516 RVA: 0x00C22720 File Offset: 0x00C20920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_edgeRadius(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, edgeCollider2D.edgeRadius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602309D RID: 143517 RVA: 0x00C22774 File Offset: 0x00C20974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_edgeRadius(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			float edgeRadius;
			LuaObject.checkType(l, 2, out edgeRadius);
			edgeCollider2D.edgeRadius = edgeRadius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602309E RID: 143518 RVA: 0x00C227CC File Offset: 0x00C209CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_edgeCount(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, edgeCollider2D.edgeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602309F RID: 143519 RVA: 0x00C22820 File Offset: 0x00C20A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointCount(IntPtr l)
	{
		int result;
		try
		{
			EdgeCollider2D edgeCollider2D = (EdgeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, edgeCollider2D.pointCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230A0 RID: 143520 RVA: 0x00C22874 File Offset: 0x00C20A74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EdgeCollider2D");
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.Reset);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache0);
		string name = "points";
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.get_points);
		}
		LuaCSFunction get = Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache1;
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.set_points);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache2, true);
		string name2 = "edgeRadius";
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.get_edgeRadius);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache3;
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.set_edgeRadius);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache4, true);
		string name3 = "edgeCount";
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.get_edgeCount);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache5, null, true);
		string name4 = "pointCount";
		if (Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EdgeCollider2D.get_pointCount);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_EdgeCollider2D.<>f__mg$cache6, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(EdgeCollider2D), typeof(Collider2D));
	}

	// Token: 0x04018FD3 RID: 102355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FD4 RID: 102356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FD5 RID: 102357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018FD6 RID: 102358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018FD7 RID: 102359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018FD8 RID: 102360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018FD9 RID: 102361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
