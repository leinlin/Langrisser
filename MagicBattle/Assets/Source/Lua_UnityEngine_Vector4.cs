using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001877 RID: 6263
[Preserve]
public class Lua_UnityEngine_Vector4 : LuaObject
{
	// Token: 0x06024403 RID: 148483 RVA: 0x00CBE038 File Offset: 0x00CBC238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				float w;
				LuaObject.checkType(l, 5, out w);
				Vector4 vector = new Vector4(x, y, z, w);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (num == 4)
			{
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				float z2;
				LuaObject.checkType(l, 4, out z2);
				Vector4 vector = new Vector4(x2, y2, z2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (num == 3)
			{
				float x3;
				LuaObject.checkType(l, 2, out x3);
				float y3;
				LuaObject.checkType(l, 3, out y3);
				Vector4 vector = new Vector4(x3, y3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (num == 0)
			{
				Vector4 vector = default(Vector4);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, vector);
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

	// Token: 0x06024404 RID: 148484 RVA: 0x00CBE18C File Offset: 0x00CBC38C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			float newX;
			LuaObject.checkType(l, 2, out newX);
			float newY;
			LuaObject.checkType(l, 3, out newY);
			float newZ;
			LuaObject.checkType(l, 4, out newZ);
			float newW;
			LuaObject.checkType(l, 5, out newW);
			v.Set(newX, newY, newZ, newW);
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

	// Token: 0x06024405 RID: 148485 RVA: 0x00CBE210 File Offset: 0x00CBC410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			Vector4 scale;
			LuaObject.checkType(l, 2, out scale);
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

	// Token: 0x06024406 RID: 148486 RVA: 0x00CBE270 File Offset: 0x00CBC470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Normalize(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			v.Normalize();
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

	// Token: 0x06024407 RID: 148487 RVA: 0x00CBE2C4 File Offset: 0x00CBC4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			float o = vector.SqrMagnitude();
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

	// Token: 0x06024408 RID: 148488 RVA: 0x00CBE318 File Offset: 0x00CBC518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector4 o = Vector4.Lerp(a, b, t);
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

	// Token: 0x06024409 RID: 148489 RVA: 0x00CBE388 File Offset: 0x00CBC588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector4 o = Vector4.LerpUnclamped(a, b, t);
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

	// Token: 0x0602440A RID: 148490 RVA: 0x00CBE3F8 File Offset: 0x00CBC5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTowards_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 current;
			LuaObject.checkType(l, 1, out current);
			Vector4 target;
			LuaObject.checkType(l, 2, out target);
			float maxDistanceDelta;
			LuaObject.checkType(l, 3, out maxDistanceDelta);
			Vector4 o = Vector4.MoveTowards(current, target, maxDistanceDelta);
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

	// Token: 0x0602440B RID: 148491 RVA: 0x00CBE468 File Offset: 0x00CBC668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			Vector4 o = Vector4.Scale(a, b);
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

	// Token: 0x0602440C RID: 148492 RVA: 0x00CBE4C8 File Offset: 0x00CBC6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Normalize_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 o = Vector4.Normalize(a);
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

	// Token: 0x0602440D RID: 148493 RVA: 0x00CBE51C File Offset: 0x00CBC71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dot_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			float o = Vector4.Dot(a, b);
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

	// Token: 0x0602440E RID: 148494 RVA: 0x00CBE57C File Offset: 0x00CBC77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Project_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			Vector4 o = Vector4.Project(a, b);
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

	// Token: 0x0602440F RID: 148495 RVA: 0x00CBE5DC File Offset: 0x00CBC7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			float o = Vector4.Distance(a, b);
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

	// Token: 0x06024410 RID: 148496 RVA: 0x00CBE63C File Offset: 0x00CBC83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Magnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			float o = Vector4.Magnitude(a);
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

	// Token: 0x06024411 RID: 148497 RVA: 0x00CBE690 File Offset: 0x00CBC890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Min_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector4 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector4 o = Vector4.Min(lhs, rhs);
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

	// Token: 0x06024412 RID: 148498 RVA: 0x00CBE6F0 File Offset: 0x00CBC8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Max_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector4 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector4 o = Vector4.Max(lhs, rhs);
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

	// Token: 0x06024413 RID: 148499 RVA: 0x00CBE750 File Offset: 0x00CBC950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			Vector4 o = a + b;
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

	// Token: 0x06024414 RID: 148500 RVA: 0x00CBE7B0 File Offset: 0x00CBC9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 b;
			LuaObject.checkType(l, 2, out b);
			Vector4 o = a - b;
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

	// Token: 0x06024415 RID: 148501 RVA: 0x00CBE810 File Offset: 0x00CBCA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_UnaryNegation(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			Vector4 o = -a;
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

	// Token: 0x06024416 RID: 148502 RVA: 0x00CBE864 File Offset: 0x00CBCA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(Vector4)))
			{
				float d;
				LuaObject.checkType(l, 1, out d);
				Vector4 a;
				LuaObject.checkType(l, 2, out a);
				Vector4 o = d * a;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Vector4), typeof(float)))
			{
				Vector4 a2;
				LuaObject.checkType(l, 1, out a2);
				float d2;
				LuaObject.checkType(l, 2, out d2);
				Vector4 o2 = a2 * d2;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
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

	// Token: 0x06024417 RID: 148503 RVA: 0x00CBE960 File Offset: 0x00CBCB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Division(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			float d;
			LuaObject.checkType(l, 2, out d);
			Vector4 o = a / d;
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

	// Token: 0x06024418 RID: 148504 RVA: 0x00CBE9C0 File Offset: 0x00CBCBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Vector4 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector4 rhs;
			LuaObject.checkType(l, 2, out rhs);
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

	// Token: 0x06024419 RID: 148505 RVA: 0x00CBEA20 File Offset: 0x00CBCC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Vector4 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector4 rhs;
			LuaObject.checkType(l, 2, out rhs);
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

	// Token: 0x0602441A RID: 148506 RVA: 0x00CBEA80 File Offset: 0x00CBCC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SqrMagnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector4 a;
			LuaObject.checkType(l, 1, out a);
			float o = Vector4.SqrMagnitude(a);
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

	// Token: 0x0602441B RID: 148507 RVA: 0x00CBEAD4 File Offset: 0x00CBCCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kEpsilon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1E-05f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602441C RID: 148508 RVA: 0x00CBEB1C File Offset: 0x00CBCD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602441D RID: 148509 RVA: 0x00CBEB70 File Offset: 0x00CBCD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			float x;
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

	// Token: 0x0602441E RID: 148510 RVA: 0x00CBEBD0 File Offset: 0x00CBCDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602441F RID: 148511 RVA: 0x00CBEC24 File Offset: 0x00CBCE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			float y;
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

	// Token: 0x06024420 RID: 148512 RVA: 0x00CBEC84 File Offset: 0x00CBCE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_z(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.z);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024421 RID: 148513 RVA: 0x00CBECD8 File Offset: 0x00CBCED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_z(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			float z;
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

	// Token: 0x06024422 RID: 148514 RVA: 0x00CBED38 File Offset: 0x00CBCF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_w(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.w);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024423 RID: 148515 RVA: 0x00CBED8C File Offset: 0x00CBCF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_w(IntPtr l)
	{
		int result;
		try
		{
			Vector4 v;
			LuaObject.checkType(l, 1, out v);
			float w;
			LuaObject.checkType(l, 2, out w);
			v.w = w;
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

	// Token: 0x06024424 RID: 148516 RVA: 0x00CBEDEC File Offset: 0x00CBCFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalized(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.normalized);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024425 RID: 148517 RVA: 0x00CBEE40 File Offset: 0x00CBD040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_magnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.magnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024426 RID: 148518 RVA: 0x00CBEE94 File Offset: 0x00CBD094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector.sqrMagnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024427 RID: 148519 RVA: 0x00CBEEE8 File Offset: 0x00CBD0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector4.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024428 RID: 148520 RVA: 0x00CBEF30 File Offset: 0x00CBD130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_one(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector4.one);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024429 RID: 148521 RVA: 0x00CBEF78 File Offset: 0x00CBD178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positiveInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector4.positiveInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602442A RID: 148522 RVA: 0x00CBEFC0 File Offset: 0x00CBD1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_negativeInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector4.negativeInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602442B RID: 148523 RVA: 0x00CBF008 File Offset: 0x00CBD208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			int index;
			LuaObject.checkType(l, 2, out index);
			float o = vector[index];
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

	// Token: 0x0602442C RID: 148524 RVA: 0x00CBF068 File Offset: 0x00CBD268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Vector4 vector;
			LuaObject.checkType(l, 1, out vector);
			int index;
			LuaObject.checkType(l, 2, out index);
			float value;
			LuaObject.checkType(l, 3, out value);
			vector[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602442D RID: 148525 RVA: 0x00CBF0CC File Offset: 0x00CBD2CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Vector4");
		if (Lua_UnityEngine_Vector4.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Vector4.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache0);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Vector4.Scale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache1);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Vector4.Normalize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache2);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Vector4.SqrMagnitude);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache3);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Vector4.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache4);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Vector4.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache5);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Vector4.MoveTowards_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache6);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Vector4.Scale_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache7);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Vector4.Normalize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache8);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Vector4.Dot_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache9);
		if (Lua_UnityEngine_Vector4.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Vector4.Project_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cacheA);
		if (Lua_UnityEngine_Vector4.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Vector4.Distance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cacheB);
		if (Lua_UnityEngine_Vector4.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Vector4.Magnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cacheC);
		if (Lua_UnityEngine_Vector4.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Vector4.Min_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cacheD);
		if (Lua_UnityEngine_Vector4.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Vector4.Max_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cacheE);
		if (Lua_UnityEngine_Vector4.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Vector4.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cacheF);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Vector4.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache10);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Vector4.op_UnaryNegation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache11);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Vector4.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache12);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Vector4.op_Division);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache13);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Vector4.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache14);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Vector4.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache15);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Vector4.SqrMagnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache16);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Vector4.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache17);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Vector4.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector4.<>f__mg$cache18);
		string name = "kEpsilon";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_kEpsilon);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Vector4.<>f__mg$cache19, null, false);
		string name2 = "x";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Vector4.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Vector4.<>f__mg$cache1A;
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Vector4.set_x);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Vector4.<>f__mg$cache1B, true);
		string name3 = "y";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Vector4.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Vector4.<>f__mg$cache1C;
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Vector4.set_y);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Vector4.<>f__mg$cache1D, true);
		string name4 = "z";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Vector4.get_z);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Vector4.<>f__mg$cache1E;
		if (Lua_UnityEngine_Vector4.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Vector4.set_z);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Vector4.<>f__mg$cache1F, true);
		string name5 = "w";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_w);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Vector4.<>f__mg$cache20;
		if (Lua_UnityEngine_Vector4.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Vector4.set_w);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_Vector4.<>f__mg$cache21, true);
		string name6 = "normalized";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_normalized);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Vector4.<>f__mg$cache22, null, true);
		string name7 = "magnitude";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_magnitude);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Vector4.<>f__mg$cache23, null, true);
		string name8 = "sqrMagnitude";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_sqrMagnitude);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Vector4.<>f__mg$cache24, null, true);
		string name9 = "zero";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_zero);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Vector4.<>f__mg$cache25, null, false);
		string name10 = "one";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_one);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Vector4.<>f__mg$cache26, null, false);
		string name11 = "positiveInfinity";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_positiveInfinity);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Vector4.<>f__mg$cache27, null, false);
		string name12 = "negativeInfinity";
		if (Lua_UnityEngine_Vector4.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Vector4.get_negativeInfinity);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Vector4.<>f__mg$cache28, null, false);
		if (Lua_UnityEngine_Vector4.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Vector4.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Vector4.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Vector4.<>f__mg$cache29, typeof(Vector4), typeof(ValueType));
	}

	// Token: 0x04019F73 RID: 106355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019F74 RID: 106356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019F75 RID: 106357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019F76 RID: 106358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019F77 RID: 106359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019F78 RID: 106360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019F79 RID: 106361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019F7A RID: 106362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019F7B RID: 106363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019F7C RID: 106364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019F7D RID: 106365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019F7E RID: 106366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019F7F RID: 106367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019F80 RID: 106368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019F81 RID: 106369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019F82 RID: 106370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019F83 RID: 106371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019F84 RID: 106372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019F85 RID: 106373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019F86 RID: 106374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019F87 RID: 106375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019F88 RID: 106376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019F89 RID: 106377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019F8A RID: 106378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019F8B RID: 106379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019F8C RID: 106380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019F8D RID: 106381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019F8E RID: 106382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019F8F RID: 106383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019F90 RID: 106384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019F91 RID: 106385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019F92 RID: 106386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019F93 RID: 106387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019F94 RID: 106388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019F95 RID: 106389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019F96 RID: 106390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019F97 RID: 106391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019F98 RID: 106392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019F99 RID: 106393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019F9A RID: 106394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019F9B RID: 106395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019F9C RID: 106396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
