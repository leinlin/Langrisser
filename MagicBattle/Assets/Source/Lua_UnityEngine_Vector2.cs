using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001873 RID: 6259
[Preserve]
public class Lua_UnityEngine_Vector2 : LuaObject
{
	// Token: 0x06024357 RID: 148311 RVA: 0x00CB87E8 File Offset: 0x00CB69E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float x;
			LuaObject.checkType(l, 2, out x);
			float y;
			LuaObject.checkType(l, 3, out y);
			Vector2 o = new Vector2(x, y);
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

	// Token: 0x06024358 RID: 148312 RVA: 0x00CB8848 File Offset: 0x00CB6A48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
			LuaObject.checkType(l, 1, out v);
			float newX;
			LuaObject.checkType(l, 2, out newX);
			float newY;
			LuaObject.checkType(l, 3, out newY);
			v.Set(newX, newY);
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

	// Token: 0x06024359 RID: 148313 RVA: 0x00CB88B4 File Offset: 0x00CB6AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
			LuaObject.checkType(l, 1, out v);
			Vector2 scale;
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

	// Token: 0x0602435A RID: 148314 RVA: 0x00CB8914 File Offset: 0x00CB6B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Normalize(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
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

	// Token: 0x0602435B RID: 148315 RVA: 0x00CB8968 File Offset: 0x00CB6B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x0602435C RID: 148316 RVA: 0x00CB89BC File Offset: 0x00CB6BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AlmostEquals(IntPtr l)
	{
		int result;
		try
		{
			Vector2 target;
			LuaObject.checkType(l, 1, out target);
			Vector2 second;
			LuaObject.checkType(l, 2, out second);
			float sqrMagnitudePrecision;
			LuaObject.checkType(l, 3, out sqrMagnitudePrecision);
			bool b = target.AlmostEquals(second, sqrMagnitudePrecision);
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

	// Token: 0x0602435D RID: 148317 RVA: 0x00CB8A2C File Offset: 0x00CB6C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector2 o = Vector2.Lerp(a, b, t);
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

	// Token: 0x0602435E RID: 148318 RVA: 0x00CB8A9C File Offset: 0x00CB6C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector2 o = Vector2.LerpUnclamped(a, b, t);
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

	// Token: 0x0602435F RID: 148319 RVA: 0x00CB8B0C File Offset: 0x00CB6D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTowards_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 current;
			LuaObject.checkType(l, 1, out current);
			Vector2 target;
			LuaObject.checkType(l, 2, out target);
			float maxDistanceDelta;
			LuaObject.checkType(l, 3, out maxDistanceDelta);
			Vector2 o = Vector2.MoveTowards(current, target, maxDistanceDelta);
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

	// Token: 0x06024360 RID: 148320 RVA: 0x00CB8B7C File Offset: 0x00CB6D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 b;
			LuaObject.checkType(l, 2, out b);
			Vector2 o = Vector2.Scale(a, b);
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

	// Token: 0x06024361 RID: 148321 RVA: 0x00CB8BDC File Offset: 0x00CB6DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reflect_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 inDirection;
			LuaObject.checkType(l, 1, out inDirection);
			Vector2 inNormal;
			LuaObject.checkType(l, 2, out inNormal);
			Vector2 o = Vector2.Reflect(inDirection, inNormal);
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

	// Token: 0x06024362 RID: 148322 RVA: 0x00CB8C3C File Offset: 0x00CB6E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dot_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector2 rhs;
			LuaObject.checkType(l, 2, out rhs);
			float o = Vector2.Dot(lhs, rhs);
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

	// Token: 0x06024363 RID: 148323 RVA: 0x00CB8C9C File Offset: 0x00CB6E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Angle_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 from;
			LuaObject.checkType(l, 1, out from);
			Vector2 to;
			LuaObject.checkType(l, 2, out to);
			float o = Vector2.Angle(from, to);
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

	// Token: 0x06024364 RID: 148324 RVA: 0x00CB8CFC File Offset: 0x00CB6EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SignedAngle_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 from;
			LuaObject.checkType(l, 1, out from);
			Vector2 to;
			LuaObject.checkType(l, 2, out to);
			float o = Vector2.SignedAngle(from, to);
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

	// Token: 0x06024365 RID: 148325 RVA: 0x00CB8D5C File Offset: 0x00CB6F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 b;
			LuaObject.checkType(l, 2, out b);
			float o = Vector2.Distance(a, b);
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

	// Token: 0x06024366 RID: 148326 RVA: 0x00CB8DBC File Offset: 0x00CB6FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClampMagnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
			LuaObject.checkType(l, 1, out vector);
			float maxLength;
			LuaObject.checkType(l, 2, out maxLength);
			Vector2 o = Vector2.ClampMagnitude(vector, maxLength);
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

	// Token: 0x06024367 RID: 148327 RVA: 0x00CB8E1C File Offset: 0x00CB701C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SqrMagnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			float o = Vector2.SqrMagnitude(a);
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

	// Token: 0x06024368 RID: 148328 RVA: 0x00CB8E70 File Offset: 0x00CB7070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Min_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector2 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector2 o = Vector2.Min(lhs, rhs);
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

	// Token: 0x06024369 RID: 148329 RVA: 0x00CB8ED0 File Offset: 0x00CB70D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Max_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector2 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector2 o = Vector2.Max(lhs, rhs);
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

	// Token: 0x0602436A RID: 148330 RVA: 0x00CB8F30 File Offset: 0x00CB7130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothDamp_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 current;
			LuaObject.checkType(l, 1, out current);
			Vector2 target;
			LuaObject.checkType(l, 2, out target);
			Vector2 o;
			LuaObject.checkType(l, 3, out o);
			float smoothTime;
			LuaObject.checkType(l, 4, out smoothTime);
			float maxSpeed;
			LuaObject.checkType(l, 5, out maxSpeed);
			float deltaTime;
			LuaObject.checkType(l, 6, out deltaTime);
			Vector2 o2 = Vector2.SmoothDamp(current, target, ref o, smoothTime, maxSpeed, deltaTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o2);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602436B RID: 148331 RVA: 0x00CB8FCC File Offset: 0x00CB71CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 b;
			LuaObject.checkType(l, 2, out b);
			Vector2 o = a + b;
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

	// Token: 0x0602436C RID: 148332 RVA: 0x00CB902C File Offset: 0x00CB722C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 b;
			LuaObject.checkType(l, 2, out b);
			Vector2 o = a - b;
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

	// Token: 0x0602436D RID: 148333 RVA: 0x00CB908C File Offset: 0x00CB728C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_UnaryNegation(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			Vector2 o = -a;
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

	// Token: 0x0602436E RID: 148334 RVA: 0x00CB90E0 File Offset: 0x00CB72E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(Vector2)))
			{
				float d;
				LuaObject.checkType(l, 1, out d);
				Vector2 a;
				LuaObject.checkType(l, 2, out a);
				Vector2 o = d * a;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Vector2), typeof(float)))
			{
				Vector2 a2;
				LuaObject.checkType(l, 1, out a2);
				float d2;
				LuaObject.checkType(l, 2, out d2);
				Vector2 o2 = a2 * d2;
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

	// Token: 0x0602436F RID: 148335 RVA: 0x00CB91DC File Offset: 0x00CB73DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Division(IntPtr l)
	{
		int result;
		try
		{
			Vector2 a;
			LuaObject.checkType(l, 1, out a);
			float d;
			LuaObject.checkType(l, 2, out d);
			Vector2 o = a / d;
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

	// Token: 0x06024370 RID: 148336 RVA: 0x00CB923C File Offset: 0x00CB743C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Vector2 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector2 rhs;
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

	// Token: 0x06024371 RID: 148337 RVA: 0x00CB929C File Offset: 0x00CB749C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Vector2 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector2 rhs;
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

	// Token: 0x06024372 RID: 148338 RVA: 0x00CB92FC File Offset: 0x00CB74FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x06024373 RID: 148339 RVA: 0x00CB9350 File Offset: 0x00CB7550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
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

	// Token: 0x06024374 RID: 148340 RVA: 0x00CB93B0 File Offset: 0x00CB75B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x06024375 RID: 148341 RVA: 0x00CB9404 File Offset: 0x00CB7604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Vector2 v;
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

	// Token: 0x06024376 RID: 148342 RVA: 0x00CB9464 File Offset: 0x00CB7664
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

	// Token: 0x06024377 RID: 148343 RVA: 0x00CB94AC File Offset: 0x00CB76AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalized(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x06024378 RID: 148344 RVA: 0x00CB9500 File Offset: 0x00CB7700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_magnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x06024379 RID: 148345 RVA: 0x00CB9554 File Offset: 0x00CB7754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x0602437A RID: 148346 RVA: 0x00CB95A8 File Offset: 0x00CB77A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602437B RID: 148347 RVA: 0x00CB95F0 File Offset: 0x00CB77F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_one(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.one);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602437C RID: 148348 RVA: 0x00CB9638 File Offset: 0x00CB7838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_up(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602437D RID: 148349 RVA: 0x00CB9680 File Offset: 0x00CB7880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_down(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.down);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602437E RID: 148350 RVA: 0x00CB96C8 File Offset: 0x00CB78C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_left(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.left);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602437F RID: 148351 RVA: 0x00CB9710 File Offset: 0x00CB7910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024380 RID: 148352 RVA: 0x00CB9758 File Offset: 0x00CB7958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positiveInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.positiveInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024381 RID: 148353 RVA: 0x00CB97A0 File Offset: 0x00CB79A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_negativeInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector2.negativeInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024382 RID: 148354 RVA: 0x00CB97E8 File Offset: 0x00CB79E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x06024383 RID: 148355 RVA: 0x00CB9848 File Offset: 0x00CB7A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Vector2 vector;
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

	// Token: 0x06024384 RID: 148356 RVA: 0x00CB98AC File Offset: 0x00CB7AAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Vector2");
		if (Lua_UnityEngine_Vector2.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Vector2.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache0);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Vector2.Scale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache1);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Vector2.Normalize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache2);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Vector2.SqrMagnitude);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache3);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Vector2.AlmostEquals);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache4);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Vector2.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache5);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Vector2.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache6);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Vector2.MoveTowards_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache7);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Vector2.Scale_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache8);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Vector2.Reflect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache9);
		if (Lua_UnityEngine_Vector2.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Vector2.Dot_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cacheA);
		if (Lua_UnityEngine_Vector2.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Vector2.Angle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cacheB);
		if (Lua_UnityEngine_Vector2.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Vector2.SignedAngle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cacheC);
		if (Lua_UnityEngine_Vector2.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Vector2.Distance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cacheD);
		if (Lua_UnityEngine_Vector2.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Vector2.ClampMagnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cacheE);
		if (Lua_UnityEngine_Vector2.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Vector2.SqrMagnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cacheF);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Vector2.Min_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache10);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Vector2.Max_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache11);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Vector2.SmoothDamp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache12);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache13);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache14);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_UnaryNegation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache15);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache16);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_Division);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache17);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache18);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Vector2.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache19);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Vector2.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache1A);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Vector2.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector2.<>f__mg$cache1B);
		string name = "x";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Vector2.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Vector2.<>f__mg$cache1C;
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Vector2.set_x);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Vector2.<>f__mg$cache1D, true);
		string name2 = "y";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Vector2.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Vector2.<>f__mg$cache1E;
		if (Lua_UnityEngine_Vector2.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Vector2.set_y);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Vector2.<>f__mg$cache1F, true);
		string name3 = "kEpsilon";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_kEpsilon);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Vector2.<>f__mg$cache20, null, false);
		string name4 = "normalized";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_normalized);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Vector2.<>f__mg$cache21, null, true);
		string name5 = "magnitude";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_magnitude);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Vector2.<>f__mg$cache22, null, true);
		string name6 = "sqrMagnitude";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_sqrMagnitude);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Vector2.<>f__mg$cache23, null, true);
		string name7 = "zero";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_zero);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Vector2.<>f__mg$cache24, null, false);
		string name8 = "one";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_one);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Vector2.<>f__mg$cache25, null, false);
		string name9 = "up";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_up);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Vector2.<>f__mg$cache26, null, false);
		string name10 = "down";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_down);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Vector2.<>f__mg$cache27, null, false);
		string name11 = "left";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_left);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Vector2.<>f__mg$cache28, null, false);
		string name12 = "right";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Vector2.get_right);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Vector2.<>f__mg$cache29, null, false);
		string name13 = "positiveInfinity";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Vector2.get_positiveInfinity);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Vector2.<>f__mg$cache2A, null, false);
		string name14 = "negativeInfinity";
		if (Lua_UnityEngine_Vector2.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Vector2.get_negativeInfinity);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Vector2.<>f__mg$cache2B, null, false);
		if (Lua_UnityEngine_Vector2.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Vector2.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Vector2.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Vector2.<>f__mg$cache2C, typeof(Vector2), typeof(ValueType));
	}

	// Token: 0x04019ECF RID: 106191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019ED0 RID: 106192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019ED1 RID: 106193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019ED2 RID: 106194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019ED3 RID: 106195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019ED4 RID: 106196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019ED5 RID: 106197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019ED6 RID: 106198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019ED7 RID: 106199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019ED8 RID: 106200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019ED9 RID: 106201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019EDA RID: 106202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019EDB RID: 106203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019EDC RID: 106204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019EDD RID: 106205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019EDE RID: 106206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019EDF RID: 106207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019EE0 RID: 106208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019EE1 RID: 106209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019EE2 RID: 106210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019EE3 RID: 106211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019EE4 RID: 106212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019EE5 RID: 106213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019EE6 RID: 106214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019EE7 RID: 106215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019EE8 RID: 106216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019EE9 RID: 106217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019EEA RID: 106218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019EEB RID: 106219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019EEC RID: 106220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019EED RID: 106221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019EEE RID: 106222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019EEF RID: 106223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019EF0 RID: 106224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019EF1 RID: 106225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019EF2 RID: 106226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019EF3 RID: 106227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019EF4 RID: 106228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019EF5 RID: 106229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019EF6 RID: 106230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019EF7 RID: 106231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019EF8 RID: 106232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019EF9 RID: 106233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019EFA RID: 106234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019EFB RID: 106235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
