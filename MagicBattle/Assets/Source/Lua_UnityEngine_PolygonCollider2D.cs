using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001758 RID: 5976
[Preserve]
public class Lua_UnityEngine_PolygonCollider2D : LuaObject
{
	// Token: 0x06023863 RID: 145507 RVA: 0x00C677A4 File Offset: 0x00C659A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPath(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector2[] path = polygonCollider2D.GetPath(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, path);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023864 RID: 145508 RVA: 0x00C67808 File Offset: 0x00C65A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPath(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector2[] points;
			LuaObject.checkArray<Vector2>(l, 3, out points);
			polygonCollider2D.SetPath(index, points);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023865 RID: 145509 RVA: 0x00C6786C File Offset: 0x00C65A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePrimitive(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
				int sides;
				LuaObject.checkType(l, 2, out sides);
				polygonCollider2D.CreatePrimitive(sides);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				PolygonCollider2D polygonCollider2D2 = (PolygonCollider2D)LuaObject.checkSelf(l);
				int sides2;
				LuaObject.checkType(l, 2, out sides2);
				Vector2 scale;
				LuaObject.checkType(l, 3, out scale);
				polygonCollider2D2.CreatePrimitive(sides2, scale);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				PolygonCollider2D polygonCollider2D3 = (PolygonCollider2D)LuaObject.checkSelf(l);
				int sides3;
				LuaObject.checkType(l, 2, out sides3);
				Vector2 scale2;
				LuaObject.checkType(l, 3, out scale2);
				Vector2 offset;
				LuaObject.checkType(l, 4, out offset);
				polygonCollider2D3.CreatePrimitive(sides3, scale2, offset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreatePrimitive to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023866 RID: 145510 RVA: 0x00C6797C File Offset: 0x00C65B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalPointCount(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			int totalPointCount = polygonCollider2D.GetTotalPointCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalPointCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023867 RID: 145511 RVA: 0x00C679D0 File Offset: 0x00C65BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_points(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, polygonCollider2D.points);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023868 RID: 145512 RVA: 0x00C67A24 File Offset: 0x00C65C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_points(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			Vector2[] points;
			LuaObject.checkArray<Vector2>(l, 2, out points);
			polygonCollider2D.points = points;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023869 RID: 145513 RVA: 0x00C67A7C File Offset: 0x00C65C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pathCount(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, polygonCollider2D.pathCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602386A RID: 145514 RVA: 0x00C67AD0 File Offset: 0x00C65CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pathCount(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			int pathCount;
			LuaObject.checkType(l, 2, out pathCount);
			polygonCollider2D.pathCount = pathCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602386B RID: 145515 RVA: 0x00C67B28 File Offset: 0x00C65D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoTiling(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, polygonCollider2D.autoTiling);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602386C RID: 145516 RVA: 0x00C67B7C File Offset: 0x00C65D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoTiling(IntPtr l)
	{
		int result;
		try
		{
			PolygonCollider2D polygonCollider2D = (PolygonCollider2D)LuaObject.checkSelf(l);
			bool autoTiling;
			LuaObject.checkType(l, 2, out autoTiling);
			polygonCollider2D.autoTiling = autoTiling;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602386D RID: 145517 RVA: 0x00C67BD4 File Offset: 0x00C65DD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PolygonCollider2D");
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.GetPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache0);
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.SetPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache1);
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.CreatePrimitive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache2);
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.GetTotalPointCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache3);
		string name = "points";
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.get_points);
		}
		LuaCSFunction get = Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache4;
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.set_points);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache5, true);
		string name2 = "pathCount";
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.get_pathCount);
		}
		LuaCSFunction get2 = Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache6;
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.set_pathCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache7, true);
		string name3 = "autoTiling";
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.get_autoTiling);
		}
		LuaCSFunction get3 = Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache8;
		if (Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_PolygonCollider2D.set_autoTiling);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_PolygonCollider2D.<>f__mg$cache9, true);
		LuaObject.createTypeMetatable(l, null, typeof(PolygonCollider2D), typeof(Collider2D));
	}

	// Token: 0x04019611 RID: 103953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019612 RID: 103954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019613 RID: 103955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019614 RID: 103956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019615 RID: 103957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019616 RID: 103958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019617 RID: 103959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019618 RID: 103960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019619 RID: 103961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401961A RID: 103962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
