using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200166D RID: 5741
[Preserve]
public class Lua_UnityEngine_CompositeCollider2D : LuaObject
{
	// Token: 0x06022F05 RID: 143109 RVA: 0x00C16168 File Offset: 0x00C14368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPath(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector2[] points;
			LuaObject.checkArray<Vector2>(l, 3, out points);
			int path = compositeCollider2D.GetPath(index, points);
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

	// Token: 0x06022F06 RID: 143110 RVA: 0x00C161D8 File Offset: 0x00C143D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateGeometry(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			compositeCollider2D.GenerateGeometry();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F07 RID: 143111 RVA: 0x00C16224 File Offset: 0x00C14424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPathPointCount(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int pathPointCount = compositeCollider2D.GetPathPointCount(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathPointCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F08 RID: 143112 RVA: 0x00C16288 File Offset: 0x00C14488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_geometryType(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)compositeCollider2D.geometryType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F09 RID: 143113 RVA: 0x00C162DC File Offset: 0x00C144DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_geometryType(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			CompositeCollider2D.GeometryType geometryType;
			LuaObject.checkEnum<CompositeCollider2D.GeometryType>(l, 2, out geometryType);
			compositeCollider2D.geometryType = geometryType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F0A RID: 143114 RVA: 0x00C16334 File Offset: 0x00C14534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_generationType(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)compositeCollider2D.generationType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F0B RID: 143115 RVA: 0x00C16388 File Offset: 0x00C14588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_generationType(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			CompositeCollider2D.GenerationType generationType;
			LuaObject.checkEnum<CompositeCollider2D.GenerationType>(l, 2, out generationType);
			compositeCollider2D.generationType = generationType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F0C RID: 143116 RVA: 0x00C163E0 File Offset: 0x00C145E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vertexDistance(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compositeCollider2D.vertexDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F0D RID: 143117 RVA: 0x00C16434 File Offset: 0x00C14634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_vertexDistance(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			float vertexDistance;
			LuaObject.checkType(l, 2, out vertexDistance);
			compositeCollider2D.vertexDistance = vertexDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F0E RID: 143118 RVA: 0x00C1648C File Offset: 0x00C1468C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_edgeRadius(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compositeCollider2D.edgeRadius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F0F RID: 143119 RVA: 0x00C164E0 File Offset: 0x00C146E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_edgeRadius(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			float edgeRadius;
			LuaObject.checkType(l, 2, out edgeRadius);
			compositeCollider2D.edgeRadius = edgeRadius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F10 RID: 143120 RVA: 0x00C16538 File Offset: 0x00C14738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pathCount(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compositeCollider2D.pathCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F11 RID: 143121 RVA: 0x00C1658C File Offset: 0x00C1478C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointCount(IntPtr l)
	{
		int result;
		try
		{
			CompositeCollider2D compositeCollider2D = (CompositeCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compositeCollider2D.pointCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F12 RID: 143122 RVA: 0x00C165E0 File Offset: 0x00C147E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CompositeCollider2D");
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.GetPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache0);
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.GenerateGeometry);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache1);
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.GetPathPointCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache2);
		string name = "geometryType";
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.get_geometryType);
		}
		LuaCSFunction get = Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache3;
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.set_geometryType);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache4, true);
		string name2 = "generationType";
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.get_generationType);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache5;
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.set_generationType);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache6, true);
		string name3 = "vertexDistance";
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.get_vertexDistance);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache7;
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.set_vertexDistance);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache8, true);
		string name4 = "edgeRadius";
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.get_edgeRadius);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CompositeCollider2D.<>f__mg$cache9;
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.set_edgeRadius);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheA, true);
		string name5 = "pathCount";
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.get_pathCount);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheB, null, true);
		string name6 = "pointCount";
		if (Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CompositeCollider2D.get_pointCount);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_CompositeCollider2D.<>f__mg$cacheC, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(CompositeCollider2D), typeof(Collider2D));
	}

	// Token: 0x04018E89 RID: 102025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E8A RID: 102026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E8B RID: 102027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E8C RID: 102028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E8D RID: 102029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E8E RID: 102030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E8F RID: 102031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E90 RID: 102032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E91 RID: 102033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E92 RID: 102034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E93 RID: 102035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018E94 RID: 102036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018E95 RID: 102037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
