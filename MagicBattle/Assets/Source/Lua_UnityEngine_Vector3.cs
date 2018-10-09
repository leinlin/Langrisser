using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001875 RID: 6261
[Preserve]
public class Lua_UnityEngine_Vector3 : LuaObject
{
	// Token: 0x060243A6 RID: 148390 RVA: 0x00CBAF58 File Offset: 0x00CB9158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 vector = new Vector3(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (num == 3)
			{
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				Vector3 vector = new Vector3(x2, y2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (num == 0)
			{
				Vector3 vector = default(Vector3);
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

	// Token: 0x060243A7 RID: 148391 RVA: 0x00CBB04C File Offset: 0x00CB924C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			float newX;
			LuaObject.checkType(l, 2, out newX);
			float newY;
			LuaObject.checkType(l, 3, out newY);
			float newZ;
			LuaObject.checkType(l, 4, out newZ);
			v.Set(newX, newY, newZ);
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

	// Token: 0x060243A8 RID: 148392 RVA: 0x00CBB0C4 File Offset: 0x00CB92C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			Vector3 scale;
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

	// Token: 0x060243A9 RID: 148393 RVA: 0x00CBB124 File Offset: 0x00CB9324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Normalize(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
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

	// Token: 0x060243AA RID: 148394 RVA: 0x00CBB178 File Offset: 0x00CB9378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AlmostEquals(IntPtr l)
	{
		int result;
		try
		{
			Vector3 target;
			LuaObject.checkType(l, 1, out target);
			Vector3 second;
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

	// Token: 0x060243AB RID: 148395 RVA: 0x00CBB1E8 File Offset: 0x00CB93E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Slerp_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector3 o = Vector3.Slerp(a, b, t);
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

	// Token: 0x060243AC RID: 148396 RVA: 0x00CBB258 File Offset: 0x00CB9458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SlerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector3 o = Vector3.SlerpUnclamped(a, b, t);
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

	// Token: 0x060243AD RID: 148397 RVA: 0x00CBB2C8 File Offset: 0x00CB94C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OrthoNormalize_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 o;
				LuaObject.checkType(l, 1, out o);
				Vector3 o2;
				LuaObject.checkType(l, 2, out o2);
				Vector3.OrthoNormalize(ref o, ref o2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				LuaObject.pushValue(l, o2);
				result = 3;
			}
			else if (num == 3)
			{
				Vector3 o3;
				LuaObject.checkType(l, 1, out o3);
				Vector3 o4;
				LuaObject.checkType(l, 2, out o4);
				Vector3 o5;
				LuaObject.checkType(l, 3, out o5);
				Vector3.OrthoNormalize(ref o3, ref o4, ref o5);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				LuaObject.pushValue(l, o4);
				LuaObject.pushValue(l, o5);
				result = 4;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OrthoNormalize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243AE RID: 148398 RVA: 0x00CBB3AC File Offset: 0x00CB95AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RotateTowards_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 current;
			LuaObject.checkType(l, 1, out current);
			Vector3 target;
			LuaObject.checkType(l, 2, out target);
			float maxRadiansDelta;
			LuaObject.checkType(l, 3, out maxRadiansDelta);
			float maxMagnitudeDelta;
			LuaObject.checkType(l, 4, out maxMagnitudeDelta);
			Vector3 o = Vector3.RotateTowards(current, target, maxRadiansDelta, maxMagnitudeDelta);
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

	// Token: 0x060243AF RID: 148399 RVA: 0x00CBB428 File Offset: 0x00CB9628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector3 o = Vector3.Lerp(a, b, t);
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

	// Token: 0x060243B0 RID: 148400 RVA: 0x00CBB498 File Offset: 0x00CB9698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Vector3 o = Vector3.LerpUnclamped(a, b, t);
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

	// Token: 0x060243B1 RID: 148401 RVA: 0x00CBB508 File Offset: 0x00CB9708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MoveTowards_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 current;
			LuaObject.checkType(l, 1, out current);
			Vector3 target;
			LuaObject.checkType(l, 2, out target);
			float maxDistanceDelta;
			LuaObject.checkType(l, 3, out maxDistanceDelta);
			Vector3 o = Vector3.MoveTowards(current, target, maxDistanceDelta);
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

	// Token: 0x060243B2 RID: 148402 RVA: 0x00CBB578 File Offset: 0x00CB9778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothDamp_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector3 current;
				LuaObject.checkType(l, 1, out current);
				Vector3 target;
				LuaObject.checkType(l, 2, out target);
				Vector3 o;
				LuaObject.checkType(l, 3, out o);
				float smoothTime;
				LuaObject.checkType(l, 4, out smoothTime);
				Vector3 o2 = Vector3.SmoothDamp(current, target, ref o, smoothTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				LuaObject.pushValue(l, o);
				result = 3;
			}
			else if (num == 5)
			{
				Vector3 current2;
				LuaObject.checkType(l, 1, out current2);
				Vector3 target2;
				LuaObject.checkType(l, 2, out target2);
				Vector3 o3;
				LuaObject.checkType(l, 3, out o3);
				float smoothTime2;
				LuaObject.checkType(l, 4, out smoothTime2);
				float maxSpeed;
				LuaObject.checkType(l, 5, out maxSpeed);
				Vector3 o4 = Vector3.SmoothDamp(current2, target2, ref o3, smoothTime2, maxSpeed);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				LuaObject.pushValue(l, o3);
				result = 3;
			}
			else if (num == 6)
			{
				Vector3 current3;
				LuaObject.checkType(l, 1, out current3);
				Vector3 target3;
				LuaObject.checkType(l, 2, out target3);
				Vector3 o5;
				LuaObject.checkType(l, 3, out o5);
				float smoothTime3;
				LuaObject.checkType(l, 4, out smoothTime3);
				float maxSpeed2;
				LuaObject.checkType(l, 5, out maxSpeed2);
				float deltaTime;
				LuaObject.checkType(l, 6, out deltaTime);
				Vector3 o6 = Vector3.SmoothDamp(current3, target3, ref o5, smoothTime3, maxSpeed2, deltaTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o6);
				LuaObject.pushValue(l, o5);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SmoothDamp to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243B3 RID: 148403 RVA: 0x00CBB710 File Offset: 0x00CB9910
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Scale_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			Vector3 o = Vector3.Scale(a, b);
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

	// Token: 0x060243B4 RID: 148404 RVA: 0x00CBB770 File Offset: 0x00CB9970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cross_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector3 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector3 o = Vector3.Cross(lhs, rhs);
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

	// Token: 0x060243B5 RID: 148405 RVA: 0x00CBB7D0 File Offset: 0x00CB99D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reflect_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 inDirection;
			LuaObject.checkType(l, 1, out inDirection);
			Vector3 inNormal;
			LuaObject.checkType(l, 2, out inNormal);
			Vector3 o = Vector3.Reflect(inDirection, inNormal);
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

	// Token: 0x060243B6 RID: 148406 RVA: 0x00CBB830 File Offset: 0x00CB9A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Normalize_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 value;
			LuaObject.checkType(l, 1, out value);
			Vector3 o = Vector3.Normalize(value);
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

	// Token: 0x060243B7 RID: 148407 RVA: 0x00CBB884 File Offset: 0x00CB9A84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Dot_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector3 rhs;
			LuaObject.checkType(l, 2, out rhs);
			float o = Vector3.Dot(lhs, rhs);
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

	// Token: 0x060243B8 RID: 148408 RVA: 0x00CBB8E4 File Offset: 0x00CB9AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Project_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			Vector3 onNormal;
			LuaObject.checkType(l, 2, out onNormal);
			Vector3 o = Vector3.Project(vector, onNormal);
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

	// Token: 0x060243B9 RID: 148409 RVA: 0x00CBB944 File Offset: 0x00CB9B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProjectOnPlane_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			Vector3 planeNormal;
			LuaObject.checkType(l, 2, out planeNormal);
			Vector3 o = Vector3.ProjectOnPlane(vector, planeNormal);
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

	// Token: 0x060243BA RID: 148410 RVA: 0x00CBB9A4 File Offset: 0x00CB9BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Angle_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 from;
			LuaObject.checkType(l, 1, out from);
			Vector3 to;
			LuaObject.checkType(l, 2, out to);
			float o = Vector3.Angle(from, to);
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

	// Token: 0x060243BB RID: 148411 RVA: 0x00CBBA04 File Offset: 0x00CB9C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SignedAngle_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 from;
			LuaObject.checkType(l, 1, out from);
			Vector3 to;
			LuaObject.checkType(l, 2, out to);
			Vector3 axis;
			LuaObject.checkType(l, 3, out axis);
			float o = Vector3.SignedAngle(from, to, axis);
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

	// Token: 0x060243BC RID: 148412 RVA: 0x00CBBA74 File Offset: 0x00CB9C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			float o = Vector3.Distance(a, b);
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

	// Token: 0x060243BD RID: 148413 RVA: 0x00CBBAD4 File Offset: 0x00CB9CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClampMagnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			float maxLength;
			LuaObject.checkType(l, 2, out maxLength);
			Vector3 o = Vector3.ClampMagnitude(vector, maxLength);
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

	// Token: 0x060243BE RID: 148414 RVA: 0x00CBBB34 File Offset: 0x00CB9D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Magnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			float o = Vector3.Magnitude(vector);
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

	// Token: 0x060243BF RID: 148415 RVA: 0x00CBBB88 File Offset: 0x00CB9D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SqrMagnitude_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			float o = Vector3.SqrMagnitude(vector);
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

	// Token: 0x060243C0 RID: 148416 RVA: 0x00CBBBDC File Offset: 0x00CB9DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Min_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector3 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector3 o = Vector3.Min(lhs, rhs);
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

	// Token: 0x060243C1 RID: 148417 RVA: 0x00CBBC3C File Offset: 0x00CB9E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Max_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector3 rhs;
			LuaObject.checkType(l, 2, out rhs);
			Vector3 o = Vector3.Max(lhs, rhs);
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

	// Token: 0x060243C2 RID: 148418 RVA: 0x00CBBC9C File Offset: 0x00CB9E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			Vector3 o = a + b;
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

	// Token: 0x060243C3 RID: 148419 RVA: 0x00CBBCFC File Offset: 0x00CB9EFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 b;
			LuaObject.checkType(l, 2, out b);
			Vector3 o = a - b;
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

	// Token: 0x060243C4 RID: 148420 RVA: 0x00CBBD5C File Offset: 0x00CB9F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_UnaryNegation(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			Vector3 o = -a;
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

	// Token: 0x060243C5 RID: 148421 RVA: 0x00CBBDB0 File Offset: 0x00CB9FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(Vector3)))
			{
				float d;
				LuaObject.checkType(l, 1, out d);
				Vector3 a;
				LuaObject.checkType(l, 2, out a);
				Vector3 o = d * a;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Vector3), typeof(float)))
			{
				Vector3 a2;
				LuaObject.checkType(l, 1, out a2);
				float d2;
				LuaObject.checkType(l, 2, out d2);
				Vector3 o2 = a2 * d2;
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

	// Token: 0x060243C6 RID: 148422 RVA: 0x00CBBEAC File Offset: 0x00CBA0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Division(IntPtr l)
	{
		int result;
		try
		{
			Vector3 a;
			LuaObject.checkType(l, 1, out a);
			float d;
			LuaObject.checkType(l, 2, out d);
			Vector3 o = a / d;
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

	// Token: 0x060243C7 RID: 148423 RVA: 0x00CBBF0C File Offset: 0x00CBA10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Vector3 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector3 rhs;
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

	// Token: 0x060243C8 RID: 148424 RVA: 0x00CBBF6C File Offset: 0x00CBA16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Vector3 lhs;
			LuaObject.checkType(l, 1, out lhs);
			Vector3 rhs;
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

	// Token: 0x060243C9 RID: 148425 RVA: 0x00CBBFCC File Offset: 0x00CBA1CC
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

	// Token: 0x060243CA RID: 148426 RVA: 0x00CBC014 File Offset: 0x00CBA214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243CB RID: 148427 RVA: 0x00CBC068 File Offset: 0x00CBA268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
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

	// Token: 0x060243CC RID: 148428 RVA: 0x00CBC0C8 File Offset: 0x00CBA2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243CD RID: 148429 RVA: 0x00CBC11C File Offset: 0x00CBA31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
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

	// Token: 0x060243CE RID: 148430 RVA: 0x00CBC17C File Offset: 0x00CBA37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_z(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243CF RID: 148431 RVA: 0x00CBC1D0 File Offset: 0x00CBA3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_z(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
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

	// Token: 0x060243D0 RID: 148432 RVA: 0x00CBC230 File Offset: 0x00CBA430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_normalized(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243D1 RID: 148433 RVA: 0x00CBC284 File Offset: 0x00CBA484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_magnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243D2 RID: 148434 RVA: 0x00CBC2D8 File Offset: 0x00CBA4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sqrMagnitude(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243D3 RID: 148435 RVA: 0x00CBC32C File Offset: 0x00CBA52C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243D4 RID: 148436 RVA: 0x00CBC374 File Offset: 0x00CBA574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_one(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.one);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243D5 RID: 148437 RVA: 0x00CBC3BC File Offset: 0x00CBA5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forward(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.forward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243D6 RID: 148438 RVA: 0x00CBC404 File Offset: 0x00CBA604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_back(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.back);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243D7 RID: 148439 RVA: 0x00CBC44C File Offset: 0x00CBA64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_up(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243D8 RID: 148440 RVA: 0x00CBC494 File Offset: 0x00CBA694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_down(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.down);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243D9 RID: 148441 RVA: 0x00CBC4DC File Offset: 0x00CBA6DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_left(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.left);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243DA RID: 148442 RVA: 0x00CBC524 File Offset: 0x00CBA724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243DB RID: 148443 RVA: 0x00CBC56C File Offset: 0x00CBA76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positiveInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.positiveInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243DC RID: 148444 RVA: 0x00CBC5B4 File Offset: 0x00CBA7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_negativeInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Vector3.negativeInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060243DD RID: 148445 RVA: 0x00CBC5FC File Offset: 0x00CBA7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243DE RID: 148446 RVA: 0x00CBC65C File Offset: 0x00CBA85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
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

	// Token: 0x060243DF RID: 148447 RVA: 0x00CBC6C0 File Offset: 0x00CBA8C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Vector3");
		if (Lua_UnityEngine_Vector3.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Vector3.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache0);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Vector3.Scale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Vector3.Normalize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache2);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Vector3.AlmostEquals);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache3);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Vector3.Slerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache4);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Vector3.SlerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache5);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Vector3.OrthoNormalize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache6);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Vector3.RotateTowards_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache7);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Vector3.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache8);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Vector3.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache9);
		if (Lua_UnityEngine_Vector3.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Vector3.MoveTowards_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cacheA);
		if (Lua_UnityEngine_Vector3.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Vector3.SmoothDamp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cacheB);
		if (Lua_UnityEngine_Vector3.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Vector3.Scale_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cacheC);
		if (Lua_UnityEngine_Vector3.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Vector3.Cross_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cacheD);
		if (Lua_UnityEngine_Vector3.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Vector3.Reflect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cacheE);
		if (Lua_UnityEngine_Vector3.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Vector3.Normalize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cacheF);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Vector3.Dot_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache10);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Vector3.Project_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache11);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Vector3.ProjectOnPlane_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache12);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Vector3.Angle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache13);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Vector3.SignedAngle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache14);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Vector3.Distance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache15);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Vector3.ClampMagnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache16);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Vector3.Magnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache17);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Vector3.SqrMagnitude_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache18);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Vector3.Min_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache19);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Vector3.Max_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1A);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Vector3.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1B);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Vector3.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1C);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Vector3.op_UnaryNegation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1D);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Vector3.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1E);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Vector3.op_Division);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache1F);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Vector3.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache20);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Vector3.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache21);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Vector3.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache22);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Vector3.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Vector3.<>f__mg$cache23);
		string name = "kEpsilon";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_kEpsilon);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Vector3.<>f__mg$cache24, null, false);
		string name2 = "x";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Vector3.<>f__mg$cache25;
		if (Lua_UnityEngine_Vector3.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Vector3.set_x);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Vector3.<>f__mg$cache26, true);
		string name3 = "y";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Vector3.<>f__mg$cache27;
		if (Lua_UnityEngine_Vector3.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Vector3.set_y);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Vector3.<>f__mg$cache28, true);
		string name4 = "z";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_z);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Vector3.<>f__mg$cache29;
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Vector3.set_z);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Vector3.<>f__mg$cache2A, true);
		string name5 = "normalized";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Vector3.get_normalized);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Vector3.<>f__mg$cache2B, null, true);
		string name6 = "magnitude";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Vector3.get_magnitude);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Vector3.<>f__mg$cache2C, null, true);
		string name7 = "sqrMagnitude";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Vector3.get_sqrMagnitude);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Vector3.<>f__mg$cache2D, null, true);
		string name8 = "zero";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Vector3.get_zero);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Vector3.<>f__mg$cache2E, null, false);
		string name9 = "one";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Vector3.get_one);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Vector3.<>f__mg$cache2F, null, false);
		string name10 = "forward";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_forward);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Vector3.<>f__mg$cache30, null, false);
		string name11 = "back";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_back);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Vector3.<>f__mg$cache31, null, false);
		string name12 = "up";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_up);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Vector3.<>f__mg$cache32, null, false);
		string name13 = "down";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_down);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Vector3.<>f__mg$cache33, null, false);
		string name14 = "left";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_left);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Vector3.<>f__mg$cache34, null, false);
		string name15 = "right";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_right);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Vector3.<>f__mg$cache35, null, false);
		string name16 = "positiveInfinity";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_positiveInfinity);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Vector3.<>f__mg$cache36, null, false);
		string name17 = "negativeInfinity";
		if (Lua_UnityEngine_Vector3.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Vector3.get_negativeInfinity);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_Vector3.<>f__mg$cache37, null, false);
		if (Lua_UnityEngine_Vector3.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Vector3.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Vector3.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Vector3.<>f__mg$cache38, typeof(Vector3), typeof(ValueType));
	}

	// Token: 0x04019F1A RID: 106266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019F1B RID: 106267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019F1C RID: 106268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019F1D RID: 106269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019F1E RID: 106270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019F1F RID: 106271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019F20 RID: 106272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019F21 RID: 106273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019F22 RID: 106274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019F23 RID: 106275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019F24 RID: 106276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019F25 RID: 106277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019F26 RID: 106278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019F27 RID: 106279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019F28 RID: 106280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019F29 RID: 106281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019F2A RID: 106282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019F2B RID: 106283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019F2C RID: 106284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019F2D RID: 106285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019F2E RID: 106286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019F2F RID: 106287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019F30 RID: 106288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019F31 RID: 106289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019F32 RID: 106290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019F33 RID: 106291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019F34 RID: 106292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019F35 RID: 106293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019F36 RID: 106294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019F37 RID: 106295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019F38 RID: 106296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019F39 RID: 106297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019F3A RID: 106298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019F3B RID: 106299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019F3C RID: 106300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019F3D RID: 106301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019F3E RID: 106302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019F3F RID: 106303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019F40 RID: 106304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019F41 RID: 106305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019F42 RID: 106306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019F43 RID: 106307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019F44 RID: 106308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019F45 RID: 106309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019F46 RID: 106310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019F47 RID: 106311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019F48 RID: 106312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019F49 RID: 106313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019F4A RID: 106314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019F4B RID: 106315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04019F4C RID: 106316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019F4D RID: 106317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019F4E RID: 106318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019F4F RID: 106319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04019F50 RID: 106320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019F51 RID: 106321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019F52 RID: 106322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;
}
