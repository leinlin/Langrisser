using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001876 RID: 6262
[Preserve]
public class Lua_UnityEngine_Vector3Int : LuaObject
{
	// Token: 0x060243E1 RID: 148449 RVA: 0x00CBCF24 File Offset: 0x00CBB124
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
			int z;
			LuaObject.checkType(l, 4, out z);
			Vector3Int v = new Vector3Int(x, y, z);
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

	// Token: 0x060243E2 RID: 148450 RVA: 0x00CBCF98 File Offset: 0x00CBB198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int v;
			LuaObject.checkValueType<Vector3Int>(l, 1, out v);
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			int z;
			LuaObject.checkType(l, 4, out z);
			v.Set(x, y, z);
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

	// Token: 0x060243E3 RID: 148451 RVA: 0x00CBD018 File Offset: 0x00CBB218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int v;
			LuaObject.checkValueType<Vector3Int>(l, 1, out v);
			Vector3Int scale;
			LuaObject.checkValueType<Vector3Int>(l, 2, out scale);
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

	// Token: 0x060243E4 RID: 148452 RVA: 0x00CBD07C File Offset: 0x00CBB27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clamp(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int v;
			LuaObject.checkValueType<Vector3Int>(l, 1, out v);
			Vector3Int min;
			LuaObject.checkValueType<Vector3Int>(l, 2, out min);
			Vector3Int max;
			LuaObject.checkValueType<Vector3Int>(l, 3, out max);
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

	// Token: 0x060243E5 RID: 148453 RVA: 0x00CBD0EC File Offset: 0x00CBB2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int a;
			LuaObject.checkValueType<Vector3Int>(l, 1, out a);
			Vector3Int b;
			LuaObject.checkValueType<Vector3Int>(l, 2, out b);
			float o = Vector3Int.Distance(a, b);
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

	// Token: 0x060243E6 RID: 148454 RVA: 0x00CBD14C File Offset: 0x00CBB34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Min_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int lhs;
			LuaObject.checkValueType<Vector3Int>(l, 1, out lhs);
			Vector3Int rhs;
			LuaObject.checkValueType<Vector3Int>(l, 2, out rhs);
			Vector3Int v = Vector3Int.Min(lhs, rhs);
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

	// Token: 0x060243E7 RID: 148455 RVA: 0x00CBD1B0 File Offset: 0x00CBB3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Max_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int lhs;
			LuaObject.checkValueType<Vector3Int>(l, 1, out lhs);
			Vector3Int rhs;
			LuaObject.checkValueType<Vector3Int>(l, 2, out rhs);
			Vector3Int v = Vector3Int.Max(lhs, rhs);
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

	// Token: 0x060243E8 RID: 148456 RVA: 0x00CBD214 File Offset: 0x00CBB414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int a;
			LuaObject.checkValueType<Vector3Int>(l, 1, out a);
			Vector3Int b;
			LuaObject.checkValueType<Vector3Int>(l, 2, out b);
			Vector3Int v = Vector3Int.Scale(a, b);
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

	// Token: 0x060243E9 RID: 148457 RVA: 0x00CBD278 File Offset: 0x00CBB478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FloorToInt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			Vector3Int v2 = Vector3Int.FloorToInt(v);
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

	// Token: 0x060243EA RID: 148458 RVA: 0x00CBD2D0 File Offset: 0x00CBB4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CeilToInt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			Vector3Int v2 = Vector3Int.CeilToInt(v);
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

	// Token: 0x060243EB RID: 148459 RVA: 0x00CBD328 File Offset: 0x00CBB528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RoundToInt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			Vector3Int v2 = Vector3Int.RoundToInt(v);
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

	// Token: 0x060243EC RID: 148460 RVA: 0x00CBD380 File Offset: 0x00CBB580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int a;
			LuaObject.checkValueType<Vector3Int>(l, 1, out a);
			Vector3Int b;
			LuaObject.checkValueType<Vector3Int>(l, 2, out b);
			Vector3Int v = a + b;
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

	// Token: 0x060243ED RID: 148461 RVA: 0x00CBD3E4 File Offset: 0x00CBB5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int a;
			LuaObject.checkValueType<Vector3Int>(l, 1, out a);
			Vector3Int b;
			LuaObject.checkValueType<Vector3Int>(l, 2, out b);
			Vector3Int v = a - b;
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

	// Token: 0x060243EE RID: 148462 RVA: 0x00CBD448 File Offset: 0x00CBB648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Vector3Int), typeof(int)))
			{
				Vector3Int a;
				LuaObject.checkValueType<Vector3Int>(l, 1, out a);
				int b;
				LuaObject.checkType(l, 2, out b);
				Vector3Int v = a * b;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, v);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Vector3Int), typeof(Vector3Int)))
			{
				Vector3Int a2;
				LuaObject.checkValueType<Vector3Int>(l, 1, out a2);
				Vector3Int b2;
				LuaObject.checkValueType<Vector3Int>(l, 2, out b2);
				Vector3Int v2 = a2 * b2;
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

	// Token: 0x060243EF RID: 148463 RVA: 0x00CBD550 File Offset: 0x00CBB750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int lhs;
			LuaObject.checkValueType<Vector3Int>(l, 1, out lhs);
			Vector3Int rhs;
			LuaObject.checkValueType<Vector3Int>(l, 2, out rhs);
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

	// Token: 0x060243F0 RID: 148464 RVA: 0x00CBD5B0 File Offset: 0x00CBB7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int lhs;
			LuaObject.checkValueType<Vector3Int>(l, 1, out lhs);
			Vector3Int rhs;
			LuaObject.checkValueType<Vector3Int>(l, 2, out rhs);
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

	// Token: 0x060243F1 RID: 148465 RVA: 0x00CBD610 File Offset: 0x00CBB810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector3Int.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243F2 RID: 148466 RVA: 0x00CBD664 File Offset: 0x00CBB864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int v;
			LuaObject.checkValueType<Vector3Int>(l, 1, out v);
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

	// Token: 0x060243F3 RID: 148467 RVA: 0x00CBD6C8 File Offset: 0x00CBB8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector3Int.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243F4 RID: 148468 RVA: 0x00CBD71C File Offset: 0x00CBB91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int v;
			LuaObject.checkValueType<Vector3Int>(l, 1, out v);
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

	// Token: 0x060243F5 RID: 148469 RVA: 0x00CBD780 File Offset: 0x00CBB980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_z(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector3Int.z);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243F6 RID: 148470 RVA: 0x00CBD7D4 File Offset: 0x00CBB9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_z(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int v;
			LuaObject.checkValueType<Vector3Int>(l, 1, out v);
			int z;
			LuaObject.checkType(l, 2, out z);
			v.z = z;
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

	// Token: 0x060243F7 RID: 148471 RVA: 0x00CBD838 File Offset: 0x00CBBA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_magnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector3Int.magnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243F8 RID: 148472 RVA: 0x00CBD88C File Offset: 0x00CBBA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector3Int.sqrMagnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243F9 RID: 148473 RVA: 0x00CBD8E0 File Offset: 0x00CBBAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3Int.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243FA RID: 148474 RVA: 0x00CBD92C File Offset: 0x00CBBB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_one(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3Int.one);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243FB RID: 148475 RVA: 0x00CBD978 File Offset: 0x00CBBB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_up(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3Int.up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243FC RID: 148476 RVA: 0x00CBD9C4 File Offset: 0x00CBBBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_down(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3Int.down);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243FD RID: 148477 RVA: 0x00CBDA10 File Offset: 0x00CBBC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_left(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3Int.left);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243FE RID: 148478 RVA: 0x00CBDA5C File Offset: 0x00CBBC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3Int.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243FF RID: 148479 RVA: 0x00CBDAA8 File Offset: 0x00CBBCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			int index;
			LuaObject.checkType(l, 2, out index);
			int i = vector3Int[index];
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

	// Token: 0x06024400 RID: 148480 RVA: 0x00CBDB08 File Offset: 0x00CBBD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Vector3Int vector3Int;
			LuaObject.checkValueType<Vector3Int>(l, 1, out vector3Int);
			int index;
			LuaObject.checkType(l, 2, out index);
			int value;
			LuaObject.checkType(l, 3, out value);
			vector3Int[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024401 RID: 148481 RVA: 0x00CBDB6C File Offset: 0x00CBBD6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Vector3Int");
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache0);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Scale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache1);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Clamp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache2);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Distance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache3);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Min_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache4);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Max_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache5);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.Scale_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache6);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.FloorToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache7);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.CeilToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache8);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.RoundToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache9);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Vector3Int.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cacheA);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Vector3Int.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cacheB);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Vector3Int.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cacheC);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Vector3Int.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cacheD);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Vector3Int.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cacheE);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Vector3Int.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cacheF);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache10);
		string name = "x";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Vector3Int.<>f__mg$cache11;
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.set_x);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Vector3Int.<>f__mg$cache12, true);
		string name2 = "y";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Vector3Int.<>f__mg$cache13;
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.set_y);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Vector3Int.<>f__mg$cache14, true);
		string name3 = "z";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_z);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Vector3Int.<>f__mg$cache15;
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.set_z);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Vector3Int.<>f__mg$cache16, true);
		string name4 = "magnitude";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_magnitude);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Vector3Int.<>f__mg$cache17, null, true);
		string name5 = "sqrMagnitude";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_sqrMagnitude);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Vector3Int.<>f__mg$cache18, null, true);
		string name6 = "zero";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_zero);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Vector3Int.<>f__mg$cache19, null, false);
		string name7 = "one";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_one);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Vector3Int.<>f__mg$cache1A, null, false);
		string name8 = "up";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_up);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Vector3Int.<>f__mg$cache1B, null, false);
		string name9 = "down";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_down);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Vector3Int.<>f__mg$cache1C, null, false);
		string name10 = "left";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_left);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Vector3Int.<>f__mg$cache1D, null, false);
		string name11 = "right";
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Vector3Int.get_right);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Vector3Int.<>f__mg$cache1E, null, false);
		if (Lua_UnityEngine_Vector3Int.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Vector3Int.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Vector3Int.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Vector3Int.<>f__mg$cache1F, typeof(Vector3Int), typeof(ValueType));
	}

	// Token: 0x04019F53 RID: 106323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019F54 RID: 106324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019F55 RID: 106325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019F56 RID: 106326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019F57 RID: 106327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019F58 RID: 106328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019F59 RID: 106329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019F5A RID: 106330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019F5B RID: 106331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019F5C RID: 106332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019F5D RID: 106333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019F5E RID: 106334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019F5F RID: 106335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019F60 RID: 106336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019F61 RID: 106337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019F62 RID: 106338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019F63 RID: 106339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019F64 RID: 106340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019F65 RID: 106341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019F66 RID: 106342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019F67 RID: 106343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019F68 RID: 106344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019F69 RID: 106345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019F6A RID: 106346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019F6B RID: 106347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019F6C RID: 106348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019F6D RID: 106349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019F6E RID: 106350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019F6F RID: 106351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019F70 RID: 106352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019F71 RID: 106353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019F72 RID: 106354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
