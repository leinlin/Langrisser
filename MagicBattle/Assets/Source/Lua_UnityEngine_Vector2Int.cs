using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001874 RID: 6260
[Preserve]
public class Lua_UnityEngine_Vector2Int : LuaObject
{
	// Token: 0x06024386 RID: 148358 RVA: 0x00CB9F5C File Offset: 0x00CB815C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			Vector2Int v = new Vector2Int(x, y);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024387 RID: 148359 RVA: 0x00CB9FC4 File Offset: 0x00CB81C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int v;
			LuaObject.checkValueType<Vector2Int>(l, 1, out v);
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			v.Set(x, y);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, v);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024388 RID: 148360 RVA: 0x00CBA034 File Offset: 0x00CB8234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int v;
			LuaObject.checkValueType<Vector2Int>(l, 1, out v);
			Vector2Int scale;
			LuaObject.checkValueType<Vector2Int>(l, 2, out scale);
			v.Scale(scale);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, v);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024389 RID: 148361 RVA: 0x00CBA098 File Offset: 0x00CB8298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clamp(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int v;
			LuaObject.checkValueType<Vector2Int>(l, 1, out v);
			Vector2Int min;
			LuaObject.checkValueType<Vector2Int>(l, 2, out min);
			Vector2Int max;
			LuaObject.checkValueType<Vector2Int>(l, 3, out max);
			v.Clamp(min, max);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, v);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602438A RID: 148362 RVA: 0x00CBA108 File Offset: 0x00CB8308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int a;
			LuaObject.checkValueType<Vector2Int>(l, 1, out a);
			Vector2Int b;
			LuaObject.checkValueType<Vector2Int>(l, 2, out b);
			float o = Vector2Int.Distance(a, b);
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

	// Token: 0x0602438B RID: 148363 RVA: 0x00CBA168 File Offset: 0x00CB8368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Min_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int lhs;
			LuaObject.checkValueType<Vector2Int>(l, 1, out lhs);
			Vector2Int rhs;
			LuaObject.checkValueType<Vector2Int>(l, 2, out rhs);
			Vector2Int v = Vector2Int.Min(lhs, rhs);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602438C RID: 148364 RVA: 0x00CBA1CC File Offset: 0x00CB83CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Max_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int lhs;
			LuaObject.checkValueType<Vector2Int>(l, 1, out lhs);
			Vector2Int rhs;
			LuaObject.checkValueType<Vector2Int>(l, 2, out rhs);
			Vector2Int v = Vector2Int.Max(lhs, rhs);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602438D RID: 148365 RVA: 0x00CBA230 File Offset: 0x00CB8430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int a;
			LuaObject.checkValueType<Vector2Int>(l, 1, out a);
			Vector2Int b;
			LuaObject.checkValueType<Vector2Int>(l, 2, out b);
			Vector2Int v = Vector2Int.Scale(a, b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602438E RID: 148366 RVA: 0x00CBA294 File Offset: 0x00CB8494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FloorToInt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
			LuaObject.checkType(l, 1, out v);
			Vector2Int v2 = Vector2Int.FloorToInt(v);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602438F RID: 148367 RVA: 0x00CBA2EC File Offset: 0x00CB84EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CeilToInt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
			LuaObject.checkType(l, 1, out v);
			Vector2Int v2 = Vector2Int.CeilToInt(v);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024390 RID: 148368 RVA: 0x00CBA344 File Offset: 0x00CB8544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RoundToInt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
			LuaObject.checkType(l, 1, out v);
			Vector2Int v2 = Vector2Int.RoundToInt(v);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024391 RID: 148369 RVA: 0x00CBA39C File Offset: 0x00CB859C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int a;
			LuaObject.checkValueType<Vector2Int>(l, 1, out a);
			Vector2Int b;
			LuaObject.checkValueType<Vector2Int>(l, 2, out b);
			Vector2Int v = a + b;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024392 RID: 148370 RVA: 0x00CBA400 File Offset: 0x00CB8600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int a;
			LuaObject.checkValueType<Vector2Int>(l, 1, out a);
			Vector2Int b;
			LuaObject.checkValueType<Vector2Int>(l, 2, out b);
			Vector2Int v = a - b;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024393 RID: 148371 RVA: 0x00CBA464 File Offset: 0x00CB8664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Vector2Int), typeof(int)))
			{
				Vector2Int a;
				LuaObject.checkValueType<Vector2Int>(l, 1, out a);
				int b;
				LuaObject.checkType(l, 2, out b);
				Vector2Int v = a * b;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, v);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Vector2Int), typeof(Vector2Int)))
			{
				Vector2Int a2;
				LuaObject.checkValueType<Vector2Int>(l, 1, out a2);
				Vector2Int b2;
				LuaObject.checkValueType<Vector2Int>(l, 2, out b2);
				Vector2Int v2 = a2 * b2;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, v2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function op_Multiply to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024394 RID: 148372 RVA: 0x00CBA56C File Offset: 0x00CB876C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int lhs;
			LuaObject.checkValueType<Vector2Int>(l, 1, out lhs);
			Vector2Int rhs;
			LuaObject.checkValueType<Vector2Int>(l, 2, out rhs);
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

	// Token: 0x06024395 RID: 148373 RVA: 0x00CBA5CC File Offset: 0x00CB87CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int lhs;
			LuaObject.checkValueType<Vector2Int>(l, 1, out lhs);
			Vector2Int rhs;
			LuaObject.checkValueType<Vector2Int>(l, 2, out rhs);
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

	// Token: 0x06024396 RID: 148374 RVA: 0x00CBA62C File Offset: 0x00CB882C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int vector2Int;
			LuaObject.checkValueType<Vector2Int>(l, 1, out vector2Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector2Int.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024397 RID: 148375 RVA: 0x00CBA680 File Offset: 0x00CB8880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int v;
			LuaObject.checkValueType<Vector2Int>(l, 1, out v);
			int x;
			LuaObject.checkType(l, 2, out x);
			v.x = x;
			LuaObject.setBack(l, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024398 RID: 148376 RVA: 0x00CBA6E4 File Offset: 0x00CB88E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int vector2Int;
			LuaObject.checkValueType<Vector2Int>(l, 1, out vector2Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector2Int.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024399 RID: 148377 RVA: 0x00CBA738 File Offset: 0x00CB8938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int v;
			LuaObject.checkValueType<Vector2Int>(l, 1, out v);
			int y;
			LuaObject.checkType(l, 2, out y);
			v.y = y;
			LuaObject.setBack(l, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602439A RID: 148378 RVA: 0x00CBA79C File Offset: 0x00CB899C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_magnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int vector2Int;
			LuaObject.checkValueType<Vector2Int>(l, 1, out vector2Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector2Int.magnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602439B RID: 148379 RVA: 0x00CBA7F0 File Offset: 0x00CB89F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int vector2Int;
			LuaObject.checkValueType<Vector2Int>(l, 1, out vector2Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector2Int.sqrMagnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602439C RID: 148380 RVA: 0x00CBA844 File Offset: 0x00CB8A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2Int.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602439D RID: 148381 RVA: 0x00CBA890 File Offset: 0x00CB8A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_one(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2Int.one);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602439E RID: 148382 RVA: 0x00CBA8DC File Offset: 0x00CB8ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_up(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2Int.up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602439F RID: 148383 RVA: 0x00CBA928 File Offset: 0x00CB8B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_down(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2Int.down);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243A0 RID: 148384 RVA: 0x00CBA974 File Offset: 0x00CB8B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_left(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2Int.left);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243A1 RID: 148385 RVA: 0x00CBA9C0 File Offset: 0x00CB8BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2Int.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243A2 RID: 148386 RVA: 0x00CBAA0C File Offset: 0x00CB8C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int vector2Int;
			LuaObject.checkValueType<Vector2Int>(l, 1, out vector2Int);
			int index;
			LuaObject.checkType(l, 2, out index);
			int i = vector2Int[index];
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243A3 RID: 148387 RVA: 0x00CBAA6C File Offset: 0x00CB8C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Vector2Int vector2Int;
			LuaObject.checkValueType<Vector2Int>(l, 1, out vector2Int);
			int index;
			LuaObject.checkType(l, 2, out index);
			int value;
			LuaObject.checkType(l, 3, out value);
			vector2Int[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243A4 RID: 148388 RVA: 0x00CBAAD0 File Offset: 0x00CB8CD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Vector2Int");
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache0);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Scale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache1);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Clamp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache2);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Distance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache3);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Min_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache4);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Max_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache5);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.Scale_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache6);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.FloorToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache7);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.CeilToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache8);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.RoundToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache9);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Vector2Int.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cacheA);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Vector2Int.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cacheB);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Vector2Int.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cacheC);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Vector2Int.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cacheD);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Vector2Int.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cacheE);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Vector2Int.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cacheF);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache10);
		string name = "x";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Vector2Int.<>f__mg$cache11;
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.set_x);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Vector2Int.<>f__mg$cache12, true);
		string name2 = "y";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Vector2Int.<>f__mg$cache13;
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.set_y);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Vector2Int.<>f__mg$cache14, true);
		string name3 = "magnitude";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_magnitude);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Vector2Int.<>f__mg$cache15, null, true);
		string name4 = "sqrMagnitude";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_sqrMagnitude);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Vector2Int.<>f__mg$cache16, null, true);
		string name5 = "zero";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_zero);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Vector2Int.<>f__mg$cache17, null, false);
		string name6 = "one";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_one);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Vector2Int.<>f__mg$cache18, null, false);
		string name7 = "up";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_up);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Vector2Int.<>f__mg$cache19, null, false);
		string name8 = "down";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_down);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Vector2Int.<>f__mg$cache1A, null, false);
		string name9 = "left";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_left);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Vector2Int.<>f__mg$cache1B, null, false);
		string name10 = "right";
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Vector2Int.get_right);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Vector2Int.<>f__mg$cache1C, null, false);
		if (Lua_UnityEngine_Vector2Int.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Vector2Int.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Vector2Int.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Vector2Int.<>f__mg$cache1D, typeof(Vector2Int), typeof(ValueType));
	}

	// Token: 0x04019EFC RID: 106236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019EFD RID: 106237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019EFE RID: 106238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019EFF RID: 106239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019F00 RID: 106240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019F01 RID: 106241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019F02 RID: 106242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019F03 RID: 106243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019F04 RID: 106244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019F05 RID: 106245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019F06 RID: 106246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019F07 RID: 106247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019F08 RID: 106248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019F09 RID: 106249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019F0A RID: 106250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019F0B RID: 106251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019F0C RID: 106252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019F0D RID: 106253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019F0E RID: 106254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019F0F RID: 106255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019F10 RID: 106256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019F11 RID: 106257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019F12 RID: 106258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019F13 RID: 106259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019F14 RID: 106260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019F15 RID: 106261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019F16 RID: 106262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019F17 RID: 106263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019F18 RID: 106264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019F19 RID: 106265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
