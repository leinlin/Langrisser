using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D5 RID: 5845
[Preserve]
public class Lua_UnityEngine_GeometryUtility : LuaObject
{
	// Token: 0x0602328F RID: 144015 RVA: 0x00C2F0B0 File Offset: 0x00C2D2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GeometryUtility o = new GeometryUtility();
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

	// Token: 0x06023290 RID: 144016 RVA: 0x00C2F0F8 File Offset: 0x00C2D2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateFrustumPlanes_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Camera)))
			{
				Camera camera;
				LuaObject.checkType<Camera>(l, 1, out camera);
				Plane[] a = GeometryUtility.CalculateFrustumPlanes(camera);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Matrix4x4)))
			{
				Matrix4x4 worldToProjectionMatrix;
				LuaObject.checkValueType<Matrix4x4>(l, 1, out worldToProjectionMatrix);
				Plane[] a2 = GeometryUtility.CalculateFrustumPlanes(worldToProjectionMatrix);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Matrix4x4), typeof(Plane[])))
			{
				Matrix4x4 worldToProjectionMatrix2;
				LuaObject.checkValueType<Matrix4x4>(l, 1, out worldToProjectionMatrix2);
				Plane[] planes;
				LuaObject.checkArray<Plane>(l, 2, out planes);
				GeometryUtility.CalculateFrustumPlanes(worldToProjectionMatrix2, planes);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Camera), typeof(Plane[])))
			{
				Camera camera2;
				LuaObject.checkType<Camera>(l, 1, out camera2);
				Plane[] planes2;
				LuaObject.checkArray<Plane>(l, 2, out planes2);
				GeometryUtility.CalculateFrustumPlanes(camera2, planes2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CalculateFrustumPlanes to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023291 RID: 144017 RVA: 0x00C2F268 File Offset: 0x00C2D468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateBounds_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3[] positions;
			LuaObject.checkArray<Vector3>(l, 1, out positions);
			Matrix4x4 transform;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out transform);
			Bounds bounds = GeometryUtility.CalculateBounds(positions, transform);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023292 RID: 144018 RVA: 0x00C2F2CC File Offset: 0x00C2D4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryCreatePlaneFromPolygon_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3[] vertices;
			LuaObject.checkArray<Vector3>(l, 1, out vertices);
			Plane plane;
			bool b = GeometryUtility.TryCreatePlaneFromPolygon(vertices, out plane);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, plane);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023293 RID: 144019 RVA: 0x00C2F330 File Offset: 0x00C2D530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestPlanesAABB_s(IntPtr l)
	{
		int result;
		try
		{
			Plane[] planes;
			LuaObject.checkArray<Plane>(l, 1, out planes);
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 2, out bounds);
			bool b = GeometryUtility.TestPlanesAABB(planes, bounds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023294 RID: 144020 RVA: 0x00C2F390 File Offset: 0x00C2D590
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.GeometryUtility");
		if (Lua_UnityEngine_GeometryUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_GeometryUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_GeometryUtility.CalculateFrustumPlanes_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GeometryUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_GeometryUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_GeometryUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_GeometryUtility.CalculateBounds_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GeometryUtility.<>f__mg$cache1);
		if (Lua_UnityEngine_GeometryUtility.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_GeometryUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_GeometryUtility.TryCreatePlaneFromPolygon_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GeometryUtility.<>f__mg$cache2);
		if (Lua_UnityEngine_GeometryUtility.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_GeometryUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_GeometryUtility.TestPlanesAABB_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GeometryUtility.<>f__mg$cache3);
		if (Lua_UnityEngine_GeometryUtility.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_GeometryUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_GeometryUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_GeometryUtility.<>f__mg$cache4, typeof(GeometryUtility));
	}

	// Token: 0x04019143 RID: 102723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019144 RID: 102724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019145 RID: 102725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019146 RID: 102726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019147 RID: 102727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
