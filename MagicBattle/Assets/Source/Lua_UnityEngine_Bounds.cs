using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001644 RID: 5700
[Preserve]
public class Lua_UnityEngine_Bounds : LuaObject
{
	// Token: 0x06022C76 RID: 142454 RVA: 0x00C02558 File Offset: 0x00C00758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			Vector3 size;
			LuaObject.checkType(l, 3, out size);
			Bounds bounds = new Bounds(center, size);
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

	// Token: 0x06022C77 RID: 142455 RVA: 0x00C025C0 File Offset: 0x00C007C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			bool b = bounds.Contains(point);
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

	// Token: 0x06022C78 RID: 142456 RVA: 0x00C02620 File Offset: 0x00C00820
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SqrDistance(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			float o = bounds.SqrDistance(point);
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

	// Token: 0x06022C79 RID: 142457 RVA: 0x00C02680 File Offset: 0x00C00880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IntersectRay(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Bounds bounds;
				LuaObject.checkValueType<Bounds>(l, 1, out bounds);
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 2, out ray);
				bool b = bounds.IntersectRay(ray);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				Bounds bounds2;
				LuaObject.checkValueType<Bounds>(l, 1, out bounds2);
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 2, out ray2);
				float o;
				bool b2 = bounds2.IntersectRay(ray2, out o);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, o);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IntersectRay to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C7A RID: 142458 RVA: 0x00C02754 File Offset: 0x00C00954
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClosestPoint(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			Vector3 o = bounds.ClosestPoint(point);
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

	// Token: 0x06022C7B RID: 142459 RVA: 0x00C027B4 File Offset: 0x00C009B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMinMax(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 min;
			LuaObject.checkType(l, 2, out min);
			Vector3 max;
			LuaObject.checkType(l, 3, out max);
			bounds.SetMinMax(min, max);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, bounds);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C7C RID: 142460 RVA: 0x00C02824 File Offset: 0x00C00A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Encapsulate(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Vector3)))
			{
				Bounds bounds;
				LuaObject.checkValueType<Bounds>(l, 1, out bounds);
				Vector3 point;
				LuaObject.checkType(l, 2, out point);
				bounds.Encapsulate(point);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, bounds);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Bounds)))
			{
				Bounds bounds2;
				LuaObject.checkValueType<Bounds>(l, 1, out bounds2);
				Bounds bounds3;
				LuaObject.checkValueType<Bounds>(l, 2, out bounds3);
				bounds2.Encapsulate(bounds3);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, bounds2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Encapsulate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C7D RID: 142461 RVA: 0x00C02910 File Offset: 0x00C00B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Expand(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(float)))
			{
				Bounds bounds;
				LuaObject.checkValueType<Bounds>(l, 1, out bounds);
				float amount;
				LuaObject.checkType(l, 2, out amount);
				bounds.Expand(amount);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, bounds);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector3)))
			{
				Bounds bounds2;
				LuaObject.checkValueType<Bounds>(l, 1, out bounds2);
				Vector3 amount2;
				LuaObject.checkType(l, 2, out amount2);
				bounds2.Expand(amount2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, bounds2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Expand to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C7E RID: 142462 RVA: 0x00C029FC File Offset: 0x00C00BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Intersects(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Bounds bounds2;
			LuaObject.checkValueType<Bounds>(l, 2, out bounds2);
			bool b = bounds.Intersects(bounds2);
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

	// Token: 0x06022C7F RID: 142463 RVA: 0x00C02A5C File Offset: 0x00C00C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Bounds lhs;
			LuaObject.checkValueType<Bounds>(l, 1, out lhs);
			Bounds rhs;
			LuaObject.checkValueType<Bounds>(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06022C80 RID: 142464 RVA: 0x00C02ABC File Offset: 0x00C00CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Bounds lhs;
			LuaObject.checkValueType<Bounds>(l, 1, out lhs);
			Bounds rhs;
			LuaObject.checkValueType<Bounds>(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06022C81 RID: 142465 RVA: 0x00C02B1C File Offset: 0x00C00D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bounds.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C82 RID: 142466 RVA: 0x00C02B70 File Offset: 0x00C00D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			bounds.center = center;
			LuaObject.setBack(l, bounds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C83 RID: 142467 RVA: 0x00C02BD4 File Offset: 0x00C00DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bounds.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C84 RID: 142468 RVA: 0x00C02C28 File Offset: 0x00C00E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 size;
			LuaObject.checkType(l, 2, out size);
			bounds.size = size;
			LuaObject.setBack(l, bounds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C85 RID: 142469 RVA: 0x00C02C8C File Offset: 0x00C00E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_extents(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bounds.extents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C86 RID: 142470 RVA: 0x00C02CE0 File Offset: 0x00C00EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_extents(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 extents;
			LuaObject.checkType(l, 2, out extents);
			bounds.extents = extents;
			LuaObject.setBack(l, bounds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C87 RID: 142471 RVA: 0x00C02D44 File Offset: 0x00C00F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bounds.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C88 RID: 142472 RVA: 0x00C02D98 File Offset: 0x00C00F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 min;
			LuaObject.checkType(l, 2, out min);
			bounds.min = min;
			LuaObject.setBack(l, bounds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C89 RID: 142473 RVA: 0x00C02DFC File Offset: 0x00C00FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bounds.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C8A RID: 142474 RVA: 0x00C02E50 File Offset: 0x00C01050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 1, out bounds);
			Vector3 max;
			LuaObject.checkType(l, 2, out max);
			bounds.max = max;
			LuaObject.setBack(l, bounds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C8B RID: 142475 RVA: 0x00C02EB4 File Offset: 0x00C010B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Bounds");
		if (Lua_UnityEngine_Bounds.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Bounds.Contains);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache0);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Bounds.SqrDistance);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache1);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Bounds.IntersectRay);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache2);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Bounds.ClosestPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache3);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Bounds.SetMinMax);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache4);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Bounds.Encapsulate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache5);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Bounds.Expand);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache6);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Bounds.Intersects);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache7);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Bounds.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache8);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Bounds.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Bounds.<>f__mg$cache9);
		string name = "center";
		if (Lua_UnityEngine_Bounds.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Bounds.get_center);
		}
		LuaCSFunction get = Lua_UnityEngine_Bounds.<>f__mg$cacheA;
		if (Lua_UnityEngine_Bounds.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Bounds.set_center);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Bounds.<>f__mg$cacheB, true);
		string name2 = "size";
		if (Lua_UnityEngine_Bounds.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Bounds.get_size);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Bounds.<>f__mg$cacheC;
		if (Lua_UnityEngine_Bounds.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Bounds.set_size);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Bounds.<>f__mg$cacheD, true);
		string name3 = "extents";
		if (Lua_UnityEngine_Bounds.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Bounds.get_extents);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Bounds.<>f__mg$cacheE;
		if (Lua_UnityEngine_Bounds.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Bounds.set_extents);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Bounds.<>f__mg$cacheF, true);
		string name4 = "min";
		if (Lua_UnityEngine_Bounds.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Bounds.get_min);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Bounds.<>f__mg$cache10;
		if (Lua_UnityEngine_Bounds.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Bounds.set_min);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Bounds.<>f__mg$cache11, true);
		string name5 = "max";
		if (Lua_UnityEngine_Bounds.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Bounds.get_max);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Bounds.<>f__mg$cache12;
		if (Lua_UnityEngine_Bounds.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Bounds.set_max);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Bounds.<>f__mg$cache13, true);
		if (Lua_UnityEngine_Bounds.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Bounds.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Bounds.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Bounds.<>f__mg$cache14, typeof(Bounds), typeof(ValueType));
	}

	// Token: 0x04018C4C RID: 101452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C4D RID: 101453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C4E RID: 101454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C4F RID: 101455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C50 RID: 101456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C51 RID: 101457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C52 RID: 101458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018C53 RID: 101459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018C54 RID: 101460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018C55 RID: 101461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018C56 RID: 101462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018C57 RID: 101463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018C58 RID: 101464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018C59 RID: 101465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018C5A RID: 101466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018C5B RID: 101467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018C5C RID: 101468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018C5D RID: 101469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018C5E RID: 101470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018C5F RID: 101471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018C60 RID: 101472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
