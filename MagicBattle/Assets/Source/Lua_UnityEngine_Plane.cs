using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200173D RID: 5949
[Preserve]
public class Lua_UnityEngine_Plane : LuaObject
{
	// Token: 0x06023796 RID: 145302 RVA: 0x00C624F8 File Offset: 0x00C606F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(Vector3)))
			{
				Vector3 inNormal;
				LuaObject.checkType(l, 2, out inNormal);
				Vector3 inPoint;
				LuaObject.checkType(l, 3, out inPoint);
				Plane plane = new Plane(inNormal, inPoint);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, plane);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(float)))
			{
				Vector3 inNormal2;
				LuaObject.checkType(l, 2, out inNormal2);
				float d;
				LuaObject.checkType(l, 3, out d);
				Plane plane = new Plane(inNormal2, d);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, plane);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 a;
				LuaObject.checkType(l, 2, out a);
				Vector3 b;
				LuaObject.checkType(l, 3, out b);
				Vector3 c;
				LuaObject.checkType(l, 4, out c);
				Plane plane = new Plane(a, b, c);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, plane);
				result = 2;
			}
			else if (num == 0)
			{
				Plane plane = default(Plane);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, plane);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023797 RID: 145303 RVA: 0x00C62678 File Offset: 0x00C60878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNormalAndPosition(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 inNormal;
			LuaObject.checkType(l, 2, out inNormal);
			Vector3 inPoint;
			LuaObject.checkType(l, 3, out inPoint);
			plane.SetNormalAndPosition(inNormal, inPoint);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, plane);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023798 RID: 145304 RVA: 0x00C626E8 File Offset: 0x00C608E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Set3Points(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 a;
			LuaObject.checkType(l, 2, out a);
			Vector3 b;
			LuaObject.checkType(l, 3, out b);
			Vector3 c;
			LuaObject.checkType(l, 4, out c);
			plane.Set3Points(a, b, c);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, plane);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023799 RID: 145305 RVA: 0x00C62768 File Offset: 0x00C60968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Flip(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			plane.Flip();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, plane);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602379A RID: 145306 RVA: 0x00C627C0 File Offset: 0x00C609C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Translate(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 translation;
			LuaObject.checkType(l, 2, out translation);
			plane.Translate(translation);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, plane);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602379B RID: 145307 RVA: 0x00C62824 File Offset: 0x00C60A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosestPointOnPlane(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			Vector3 o = plane.ClosestPointOnPlane(point);
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

	// Token: 0x0602379C RID: 145308 RVA: 0x00C62884 File Offset: 0x00C60A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDistanceToPoint(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			float distanceToPoint = plane.GetDistanceToPoint(point);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, distanceToPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602379D RID: 145309 RVA: 0x00C628E4 File Offset: 0x00C60AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSide(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			bool side = plane.GetSide(point);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, side);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602379E RID: 145310 RVA: 0x00C62944 File Offset: 0x00C60B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SameSide(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 inPt;
			LuaObject.checkType(l, 2, out inPt);
			Vector3 inPt2;
			LuaObject.checkType(l, 3, out inPt2);
			bool b = plane.SameSide(inPt, inPt2);
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

	// Token: 0x0602379F RID: 145311 RVA: 0x00C629B4 File Offset: 0x00C60BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 2, out ray);
			float o;
			bool b = plane.Raycast(ray, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A0 RID: 145312 RVA: 0x00C62A20 File Offset: 0x00C60C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Translate_s(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 translation;
			LuaObject.checkType(l, 2, out translation);
			Plane plane2 = Plane.Translate(plane, translation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, plane2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A1 RID: 145313 RVA: 0x00C62A84 File Offset: 0x00C60C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, plane.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A2 RID: 145314 RVA: 0x00C62AD8 File Offset: 0x00C60CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normal(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			Vector3 normal;
			LuaObject.checkType(l, 2, out normal);
			plane.normal = normal;
			LuaObject.setBack(l, plane);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A3 RID: 145315 RVA: 0x00C62B3C File Offset: 0x00C60D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, plane.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A4 RID: 145316 RVA: 0x00C62B90 File Offset: 0x00C60D90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			plane.distance = distance;
			LuaObject.setBack(l, plane);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A5 RID: 145317 RVA: 0x00C62BF4 File Offset: 0x00C60DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_flipped(IntPtr l)
	{
		int result;
		try
		{
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 1, out plane);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, plane.flipped);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A6 RID: 145318 RVA: 0x00C62C4C File Offset: 0x00C60E4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Plane");
		if (Lua_UnityEngine_Plane.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Plane.SetNormalAndPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache0);
		if (Lua_UnityEngine_Plane.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Plane.Set3Points);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache1);
		if (Lua_UnityEngine_Plane.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Plane.Flip);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache2);
		if (Lua_UnityEngine_Plane.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Plane.Translate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache3);
		if (Lua_UnityEngine_Plane.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Plane.ClosestPointOnPlane);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache4);
		if (Lua_UnityEngine_Plane.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Plane.GetDistanceToPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache5);
		if (Lua_UnityEngine_Plane.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Plane.GetSide);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache6);
		if (Lua_UnityEngine_Plane.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Plane.SameSide);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache7);
		if (Lua_UnityEngine_Plane.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Plane.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache8);
		if (Lua_UnityEngine_Plane.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Plane.Translate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Plane.<>f__mg$cache9);
		string name = "normal";
		if (Lua_UnityEngine_Plane.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Plane.get_normal);
		}
		LuaCSFunction get = Lua_UnityEngine_Plane.<>f__mg$cacheA;
		if (Lua_UnityEngine_Plane.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Plane.set_normal);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Plane.<>f__mg$cacheB, true);
		string name2 = "distance";
		if (Lua_UnityEngine_Plane.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Plane.get_distance);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Plane.<>f__mg$cacheC;
		if (Lua_UnityEngine_Plane.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Plane.set_distance);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Plane.<>f__mg$cacheD, true);
		string name3 = "flipped";
		if (Lua_UnityEngine_Plane.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Plane.get_flipped);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Plane.<>f__mg$cacheE, null, true);
		if (Lua_UnityEngine_Plane.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Plane.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Plane.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Plane.<>f__mg$cacheF, typeof(Plane), typeof(ValueType));
	}

	// Token: 0x0401957A RID: 103802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401957B RID: 103803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401957C RID: 103804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401957D RID: 103805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401957E RID: 103806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401957F RID: 103807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019580 RID: 103808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019581 RID: 103809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019582 RID: 103810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019583 RID: 103811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019584 RID: 103812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019585 RID: 103813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019586 RID: 103814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019587 RID: 103815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019588 RID: 103816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019589 RID: 103817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
