using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001763 RID: 5987
[Preserve]
public class Lua_UnityEngine_Quaternion : LuaObject
{
	// Token: 0x06023901 RID: 145665 RVA: 0x00C6BAC4 File Offset: 0x00C69CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float x;
			LuaObject.checkType(l, 2, out x);
			float y;
			LuaObject.checkType(l, 3, out y);
			float z;
			LuaObject.checkType(l, 4, out z);
			float w;
			LuaObject.checkType(l, 5, out w);
			Quaternion o = new Quaternion(x, y, z, w);
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

	// Token: 0x06023902 RID: 145666 RVA: 0x00C6BB40 File Offset: 0x00C69D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToAngleAxis(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
			LuaObject.checkType(l, 1, out v);
			float o;
			Vector3 o2;
			v.ToAngleAxis(out o, out o2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			LuaObject.setBack(l, v);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023903 RID: 145667 RVA: 0x00C6BBA8 File Offset: 0x00C69DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFromToRotation(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
			LuaObject.checkType(l, 1, out v);
			Vector3 fromDirection;
			LuaObject.checkType(l, 2, out fromDirection);
			Vector3 toDirection;
			LuaObject.checkType(l, 3, out toDirection);
			v.SetFromToRotation(fromDirection, toDirection);
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

	// Token: 0x06023904 RID: 145668 RVA: 0x00C6BC14 File Offset: 0x00C69E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
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

	// Token: 0x06023905 RID: 145669 RVA: 0x00C6BC98 File Offset: 0x00C69E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLookRotation(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Quaternion v;
				LuaObject.checkType(l, 1, out v);
				Vector3 lookRotation;
				LuaObject.checkType(l, 2, out lookRotation);
				v.SetLookRotation(lookRotation);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, v);
				result = 1;
			}
			else if (num == 3)
			{
				Quaternion v2;
				LuaObject.checkType(l, 1, out v2);
				Vector3 view;
				LuaObject.checkType(l, 2, out view);
				Vector3 up;
				LuaObject.checkType(l, 3, out up);
				v2.SetLookRotation(view, up);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, v2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetLookRotation to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023906 RID: 145670 RVA: 0x00C6BD64 File Offset: 0x00C69F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AlmostEquals(IntPtr l)
	{
		int result;
		try
		{
			Quaternion target;
			LuaObject.checkType(l, 1, out target);
			Quaternion second;
			LuaObject.checkType(l, 2, out second);
			float maxAngle;
			LuaObject.checkType(l, 3, out maxAngle);
			bool b = target.AlmostEquals(second, maxAngle);
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

	// Token: 0x06023907 RID: 145671 RVA: 0x00C6BDD4 File Offset: 0x00C69FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AngleAxis_s(IntPtr l)
	{
		int result;
		try
		{
			float angle;
			LuaObject.checkType(l, 1, out angle);
			Vector3 axis;
			LuaObject.checkType(l, 2, out axis);
			Quaternion o = Quaternion.AngleAxis(angle, axis);
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

	// Token: 0x06023908 RID: 145672 RVA: 0x00C6BE34 File Offset: 0x00C6A034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromToRotation_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 fromDirection;
			LuaObject.checkType(l, 1, out fromDirection);
			Vector3 toDirection;
			LuaObject.checkType(l, 2, out toDirection);
			Quaternion o = Quaternion.FromToRotation(fromDirection, toDirection);
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

	// Token: 0x06023909 RID: 145673 RVA: 0x00C6BE94 File Offset: 0x00C6A094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LookRotation_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Vector3 forward;
				LuaObject.checkType(l, 1, out forward);
				Quaternion o = Quaternion.LookRotation(forward);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				Vector3 forward2;
				LuaObject.checkType(l, 1, out forward2);
				Vector3 upwards;
				LuaObject.checkType(l, 2, out upwards);
				Quaternion o2 = Quaternion.LookRotation(forward2, upwards);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LookRotation to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602390A RID: 145674 RVA: 0x00C6BF4C File Offset: 0x00C6A14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Slerp_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion a;
			LuaObject.checkType(l, 1, out a);
			Quaternion b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Quaternion o = Quaternion.Slerp(a, b, t);
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

	// Token: 0x0602390B RID: 145675 RVA: 0x00C6BFBC File Offset: 0x00C6A1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SlerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion a;
			LuaObject.checkType(l, 1, out a);
			Quaternion b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Quaternion o = Quaternion.SlerpUnclamped(a, b, t);
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

	// Token: 0x0602390C RID: 145676 RVA: 0x00C6C02C File Offset: 0x00C6A22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion a;
			LuaObject.checkType(l, 1, out a);
			Quaternion b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Quaternion o = Quaternion.Lerp(a, b, t);
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

	// Token: 0x0602390D RID: 145677 RVA: 0x00C6C09C File Offset: 0x00C6A29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion a;
			LuaObject.checkType(l, 1, out a);
			Quaternion b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Quaternion o = Quaternion.LerpUnclamped(a, b, t);
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

	// Token: 0x0602390E RID: 145678 RVA: 0x00C6C10C File Offset: 0x00C6A30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RotateTowards_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion from;
			LuaObject.checkType(l, 1, out from);
			Quaternion to;
			LuaObject.checkType(l, 2, out to);
			float maxDegreesDelta;
			LuaObject.checkType(l, 3, out maxDegreesDelta);
			Quaternion o = Quaternion.RotateTowards(from, to, maxDegreesDelta);
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

	// Token: 0x0602390F RID: 145679 RVA: 0x00C6C17C File Offset: 0x00C6A37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Inverse_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion rotation;
			LuaObject.checkType(l, 1, out rotation);
			Quaternion o = Quaternion.Inverse(rotation);
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

	// Token: 0x06023910 RID: 145680 RVA: 0x00C6C1D0 File Offset: 0x00C6A3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Euler_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Vector3 euler;
				LuaObject.checkType(l, 1, out euler);
				Quaternion o = Quaternion.Euler(euler);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				float x;
				LuaObject.checkType(l, 1, out x);
				float y;
				LuaObject.checkType(l, 2, out y);
				float z;
				LuaObject.checkType(l, 3, out z);
				Quaternion o2 = Quaternion.Euler(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Euler to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023911 RID: 145681 RVA: 0x00C6C294 File Offset: 0x00C6A494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Quaternion), typeof(Vector3)))
			{
				Quaternion rotation;
				LuaObject.checkType(l, 1, out rotation);
				Vector3 point;
				LuaObject.checkType(l, 2, out point);
				Vector3 o = rotation * point;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Quaternion), typeof(Quaternion)))
			{
				Quaternion lhs;
				LuaObject.checkType(l, 1, out lhs);
				Quaternion rhs;
				LuaObject.checkType(l, 2, out rhs);
				Quaternion o2 = lhs * rhs;
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

	// Token: 0x06023912 RID: 145682 RVA: 0x00C6C390 File Offset: 0x00C6A590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Quaternion lhs;
			LuaObject.checkType(l, 1, out lhs);
			Quaternion rhs;
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

	// Token: 0x06023913 RID: 145683 RVA: 0x00C6C3F0 File Offset: 0x00C6A5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Quaternion lhs;
			LuaObject.checkType(l, 1, out lhs);
			Quaternion rhs;
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

	// Token: 0x06023914 RID: 145684 RVA: 0x00C6C450 File Offset: 0x00C6A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dot_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion a;
			LuaObject.checkType(l, 1, out a);
			Quaternion b;
			LuaObject.checkType(l, 2, out b);
			float o = Quaternion.Dot(a, b);
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

	// Token: 0x06023915 RID: 145685 RVA: 0x00C6C4B0 File Offset: 0x00C6A6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Angle_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion a;
			LuaObject.checkType(l, 1, out a);
			Quaternion b;
			LuaObject.checkType(l, 2, out b);
			float o = Quaternion.Angle(a, b);
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

	// Token: 0x06023916 RID: 145686 RVA: 0x00C6C510 File Offset: 0x00C6A710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, quaternion.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023917 RID: 145687 RVA: 0x00C6C564 File Offset: 0x00C6A764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
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

	// Token: 0x06023918 RID: 145688 RVA: 0x00C6C5C4 File Offset: 0x00C6A7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, quaternion.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023919 RID: 145689 RVA: 0x00C6C618 File Offset: 0x00C6A818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
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

	// Token: 0x0602391A RID: 145690 RVA: 0x00C6C678 File Offset: 0x00C6A878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_z(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, quaternion.z);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602391B RID: 145691 RVA: 0x00C6C6CC File Offset: 0x00C6A8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_z(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
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

	// Token: 0x0602391C RID: 145692 RVA: 0x00C6C72C File Offset: 0x00C6A92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_w(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, quaternion.w);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602391D RID: 145693 RVA: 0x00C6C780 File Offset: 0x00C6A980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_w(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
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

	// Token: 0x0602391E RID: 145694 RVA: 0x00C6C7E0 File Offset: 0x00C6A9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kEpsilon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1E-06f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602391F RID: 145695 RVA: 0x00C6C828 File Offset: 0x00C6AA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eulerAngles(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, quaternion.eulerAngles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023920 RID: 145696 RVA: 0x00C6C87C File Offset: 0x00C6AA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_eulerAngles(IntPtr l)
	{
		int result;
		try
		{
			Quaternion v;
			LuaObject.checkType(l, 1, out v);
			Vector3 eulerAngles;
			LuaObject.checkType(l, 2, out eulerAngles);
			v.eulerAngles = eulerAngles;
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

	// Token: 0x06023921 RID: 145697 RVA: 0x00C6C8DC File Offset: 0x00C6AADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_identity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Quaternion.identity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023922 RID: 145698 RVA: 0x00C6C924 File Offset: 0x00C6AB24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			int index;
			LuaObject.checkType(l, 2, out index);
			float o = quaternion[index];
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

	// Token: 0x06023923 RID: 145699 RVA: 0x00C6C984 File Offset: 0x00C6AB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Quaternion quaternion;
			LuaObject.checkType(l, 1, out quaternion);
			int index;
			LuaObject.checkType(l, 2, out index);
			float value;
			LuaObject.checkType(l, 3, out value);
			quaternion[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023924 RID: 145700 RVA: 0x00C6C9E8 File Offset: 0x00C6ABE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Quaternion");
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Quaternion.ToAngleAxis);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache0);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Quaternion.SetFromToRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache1);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Quaternion.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache2);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Quaternion.SetLookRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache3);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Quaternion.AlmostEquals);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache4);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Quaternion.AngleAxis_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache5);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Quaternion.FromToRotation_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache6);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Quaternion.LookRotation_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache7);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Quaternion.Slerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache8);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Quaternion.SlerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache9);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Quaternion.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cacheA);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Quaternion.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cacheB);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Quaternion.RotateTowards_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cacheC);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Quaternion.Inverse_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cacheD);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Quaternion.Euler_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cacheE);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Quaternion.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cacheF);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Quaternion.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache10);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Quaternion.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache11);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Quaternion.Dot_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache12);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Quaternion.Angle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache13);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Quaternion.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache14);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Quaternion.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Quaternion.<>f__mg$cache15);
		string name = "x";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Quaternion.<>f__mg$cache16;
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Quaternion.set_x);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Quaternion.<>f__mg$cache17, true);
		string name2 = "y";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Quaternion.<>f__mg$cache18;
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Quaternion.set_y);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Quaternion.<>f__mg$cache19, true);
		string name3 = "z";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_z);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Quaternion.<>f__mg$cache1A;
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Quaternion.set_z);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Quaternion.<>f__mg$cache1B, true);
		string name4 = "w";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_w);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Quaternion.<>f__mg$cache1C;
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Quaternion.set_w);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Quaternion.<>f__mg$cache1D, true);
		string name5 = "kEpsilon";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_kEpsilon);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Quaternion.<>f__mg$cache1E, null, false);
		string name6 = "eulerAngles";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_eulerAngles);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Quaternion.<>f__mg$cache1F;
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Quaternion.set_eulerAngles);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_Quaternion.<>f__mg$cache20, true);
		string name7 = "identity";
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Quaternion.get_identity);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Quaternion.<>f__mg$cache21, null, false);
		if (Lua_UnityEngine_Quaternion.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Quaternion.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Quaternion.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Quaternion.<>f__mg$cache22, typeof(Quaternion), typeof(ValueType));
	}

	// Token: 0x04019699 RID: 104089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401969A RID: 104090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401969B RID: 104091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401969C RID: 104092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401969D RID: 104093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401969E RID: 104094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401969F RID: 104095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040196A0 RID: 104096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040196A1 RID: 104097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040196A2 RID: 104098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040196A3 RID: 104099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040196A4 RID: 104100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040196A5 RID: 104101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040196A6 RID: 104102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040196A7 RID: 104103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040196A8 RID: 104104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040196A9 RID: 104105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040196AA RID: 104106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040196AB RID: 104107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040196AC RID: 104108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040196AD RID: 104109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040196AE RID: 104110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040196AF RID: 104111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040196B0 RID: 104112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040196B1 RID: 104113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040196B2 RID: 104114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040196B3 RID: 104115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040196B4 RID: 104116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040196B5 RID: 104117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040196B6 RID: 104118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040196B7 RID: 104119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040196B8 RID: 104120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040196B9 RID: 104121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040196BA RID: 104122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040196BB RID: 104123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
