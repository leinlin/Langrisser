using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001727 RID: 5927
[Preserve]
public class Lua_UnityEngine_Matrix4x4 : LuaObject
{
	// Token: 0x060235F8 RID: 144888 RVA: 0x00C4D954 File Offset: 0x00C4BB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Vector4 column;
			LuaObject.checkType(l, 2, out column);
			Vector4 column2;
			LuaObject.checkType(l, 3, out column2);
			Vector4 column3;
			LuaObject.checkType(l, 4, out column3);
			Vector4 column4;
			LuaObject.checkType(l, 5, out column4);
			Matrix4x4 matrix4x = new Matrix4x4(column, column2, column3, column4);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F9 RID: 144889 RVA: 0x00C4D9D4 File Offset: 0x00C4BBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ValidTRS(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			bool b = matrix4x.ValidTRS();
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

	// Token: 0x060235FA RID: 144890 RVA: 0x00C4DA28 File Offset: 0x00C4BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTRS(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			Vector3 pos;
			LuaObject.checkType(l, 2, out pos);
			Quaternion q;
			LuaObject.checkType(l, 3, out q);
			Vector3 s;
			LuaObject.checkType(l, 4, out s);
			matrix4x.SetTRS(pos, q, s);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, matrix4x);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235FB RID: 144891 RVA: 0x00C4DAA8 File Offset: 0x00C4BCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetColumn(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector4 column = matrix4x.GetColumn(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, column);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235FC RID: 144892 RVA: 0x00C4DB08 File Offset: 0x00C4BD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRow(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector4 row = matrix4x.GetRow(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, row);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235FD RID: 144893 RVA: 0x00C4DB68 File Offset: 0x00C4BD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColumn(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector4 column;
			LuaObject.checkType(l, 3, out column);
			matrix4x.SetColumn(index, column);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, matrix4x);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235FE RID: 144894 RVA: 0x00C4DBD8 File Offset: 0x00C4BDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRow(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector4 row;
			LuaObject.checkType(l, 3, out row);
			matrix4x.SetRow(index, row);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, matrix4x);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235FF RID: 144895 RVA: 0x00C4DC48 File Offset: 0x00C4BE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MultiplyPoint(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			Vector3 o = matrix4x.MultiplyPoint(point);
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

	// Token: 0x06023600 RID: 144896 RVA: 0x00C4DCA8 File Offset: 0x00C4BEA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MultiplyPoint3x4(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			Vector3 o = matrix4x.MultiplyPoint3x4(point);
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

	// Token: 0x06023601 RID: 144897 RVA: 0x00C4DD08 File Offset: 0x00C4BF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MultiplyVector(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			Vector3 vector;
			LuaObject.checkType(l, 2, out vector);
			Vector3 o = matrix4x.MultiplyVector(vector);
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

	// Token: 0x06023602 RID: 144898 RVA: 0x00C4DD68 File Offset: 0x00C4BF68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TransformPlane(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			Plane plane;
			LuaObject.checkValueType<Plane>(l, 2, out plane);
			Plane plane2 = matrix4x.TransformPlane(plane);
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

	// Token: 0x06023603 RID: 144899 RVA: 0x00C4DDD0 File Offset: 0x00C4BFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Inverse_s(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 m;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out m);
			Matrix4x4 matrix4x = Matrix4x4.Inverse(m);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023604 RID: 144900 RVA: 0x00C4DE28 File Offset: 0x00C4C028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Transpose_s(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 m;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out m);
			Matrix4x4 matrix4x = Matrix4x4.Transpose(m);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023605 RID: 144901 RVA: 0x00C4DE80 File Offset: 0x00C4C080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Determinant_s(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 m;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out m);
			float o = Matrix4x4.Determinant(m);
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

	// Token: 0x06023606 RID: 144902 RVA: 0x00C4DED4 File Offset: 0x00C4C0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TRS_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 pos;
			LuaObject.checkType(l, 1, out pos);
			Quaternion q;
			LuaObject.checkType(l, 2, out q);
			Vector3 s;
			LuaObject.checkType(l, 3, out s);
			Matrix4x4 matrix4x = Matrix4x4.TRS(pos, q, s);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023607 RID: 144903 RVA: 0x00C4DF48 File Offset: 0x00C4C148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Ortho_s(IntPtr l)
	{
		int result;
		try
		{
			float left;
			LuaObject.checkType(l, 1, out left);
			float right;
			LuaObject.checkType(l, 2, out right);
			float bottom;
			LuaObject.checkType(l, 3, out bottom);
			float top;
			LuaObject.checkType(l, 4, out top);
			float zNear;
			LuaObject.checkType(l, 5, out zNear);
			float zFar;
			LuaObject.checkType(l, 6, out zFar);
			Matrix4x4 matrix4x = Matrix4x4.Ortho(left, right, bottom, top, zNear, zFar);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023608 RID: 144904 RVA: 0x00C4DFE0 File Offset: 0x00C4C1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Perspective_s(IntPtr l)
	{
		int result;
		try
		{
			float fov;
			LuaObject.checkType(l, 1, out fov);
			float aspect;
			LuaObject.checkType(l, 2, out aspect);
			float zNear;
			LuaObject.checkType(l, 3, out zNear);
			float zFar;
			LuaObject.checkType(l, 4, out zFar);
			Matrix4x4 matrix4x = Matrix4x4.Perspective(fov, aspect, zNear, zFar);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023609 RID: 144905 RVA: 0x00C4E060 File Offset: 0x00C4C260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LookAt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 from;
			LuaObject.checkType(l, 1, out from);
			Vector3 to;
			LuaObject.checkType(l, 2, out to);
			Vector3 up;
			LuaObject.checkType(l, 3, out up);
			Matrix4x4 matrix4x = Matrix4x4.LookAt(from, to, up);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602360A RID: 144906 RVA: 0x00C4E0D4 File Offset: 0x00C4C2D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Frustum_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				FrustumPlanes frustumPlanes;
				LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
				Matrix4x4 matrix4x = Matrix4x4.Frustum(frustumPlanes);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrix4x);
				result = 2;
			}
			else if (num == 6)
			{
				float left;
				LuaObject.checkType(l, 1, out left);
				float right;
				LuaObject.checkType(l, 2, out right);
				float bottom;
				LuaObject.checkType(l, 3, out bottom);
				float top;
				LuaObject.checkType(l, 4, out top);
				float zNear;
				LuaObject.checkType(l, 5, out zNear);
				float zFar;
				LuaObject.checkType(l, 6, out zFar);
				Matrix4x4 matrix4x2 = Matrix4x4.Frustum(left, right, bottom, top, zNear, zFar);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrix4x2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Frustum to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602360B RID: 144907 RVA: 0x00C4E1C8 File Offset: 0x00C4C3C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Matrix4x4), typeof(Vector4)))
			{
				Matrix4x4 lhs;
				LuaObject.checkValueType<Matrix4x4>(l, 1, out lhs);
				Vector4 vector;
				LuaObject.checkType(l, 2, out vector);
				Vector4 o = lhs * vector;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Matrix4x4), typeof(Matrix4x4)))
			{
				Matrix4x4 lhs2;
				LuaObject.checkValueType<Matrix4x4>(l, 1, out lhs2);
				Matrix4x4 rhs;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out rhs);
				Matrix4x4 matrix4x = lhs2 * rhs;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrix4x);
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

	// Token: 0x0602360C RID: 144908 RVA: 0x00C4E2C8 File Offset: 0x00C4C4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 lhs;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out lhs);
			Matrix4x4 rhs;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out rhs);
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

	// Token: 0x0602360D RID: 144909 RVA: 0x00C4E328 File Offset: 0x00C4C528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 lhs;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out lhs);
			Matrix4x4 rhs;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out rhs);
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

	// Token: 0x0602360E RID: 144910 RVA: 0x00C4E388 File Offset: 0x00C4C588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Scale_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			Matrix4x4 matrix4x = Matrix4x4.Scale(vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602360F RID: 144911 RVA: 0x00C4E3E0 File Offset: 0x00C4C5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Translate_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			Matrix4x4 matrix4x = Matrix4x4.Translate(vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023610 RID: 144912 RVA: 0x00C4E438 File Offset: 0x00C4C638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rotate_s(IntPtr l)
	{
		int result;
		try
		{
			Quaternion q;
			LuaObject.checkType(l, 1, out q);
			Matrix4x4 matrix4x = Matrix4x4.Rotate(q);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023611 RID: 144913 RVA: 0x00C4E490 File Offset: 0x00C4C690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m00(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m00);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023612 RID: 144914 RVA: 0x00C4E4E4 File Offset: 0x00C4C6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m00(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m00 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023613 RID: 144915 RVA: 0x00C4E548 File Offset: 0x00C4C748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m10(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m10);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023614 RID: 144916 RVA: 0x00C4E59C File Offset: 0x00C4C79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m10(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m10 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023615 RID: 144917 RVA: 0x00C4E600 File Offset: 0x00C4C800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m20(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m20);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023616 RID: 144918 RVA: 0x00C4E654 File Offset: 0x00C4C854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m20(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m20 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023617 RID: 144919 RVA: 0x00C4E6B8 File Offset: 0x00C4C8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m30(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m30);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023618 RID: 144920 RVA: 0x00C4E70C File Offset: 0x00C4C90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m30(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m30 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023619 RID: 144921 RVA: 0x00C4E770 File Offset: 0x00C4C970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m01(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m01);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602361A RID: 144922 RVA: 0x00C4E7C4 File Offset: 0x00C4C9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m01(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m01 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602361B RID: 144923 RVA: 0x00C4E828 File Offset: 0x00C4CA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m11(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m11);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602361C RID: 144924 RVA: 0x00C4E87C File Offset: 0x00C4CA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m11(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m11 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602361D RID: 144925 RVA: 0x00C4E8E0 File Offset: 0x00C4CAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m21(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m21);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602361E RID: 144926 RVA: 0x00C4E934 File Offset: 0x00C4CB34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m21(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m21 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602361F RID: 144927 RVA: 0x00C4E998 File Offset: 0x00C4CB98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m31(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m31);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023620 RID: 144928 RVA: 0x00C4E9EC File Offset: 0x00C4CBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m31(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m31 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023621 RID: 144929 RVA: 0x00C4EA50 File Offset: 0x00C4CC50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m02(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m02);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023622 RID: 144930 RVA: 0x00C4EAA4 File Offset: 0x00C4CCA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m02(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m02 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023623 RID: 144931 RVA: 0x00C4EB08 File Offset: 0x00C4CD08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m12(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m12);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023624 RID: 144932 RVA: 0x00C4EB5C File Offset: 0x00C4CD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m12(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m12 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023625 RID: 144933 RVA: 0x00C4EBC0 File Offset: 0x00C4CDC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m22(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m22);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023626 RID: 144934 RVA: 0x00C4EC14 File Offset: 0x00C4CE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m22(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m22 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023627 RID: 144935 RVA: 0x00C4EC78 File Offset: 0x00C4CE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m32(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m32);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023628 RID: 144936 RVA: 0x00C4ECCC File Offset: 0x00C4CECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m32(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m32 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023629 RID: 144937 RVA: 0x00C4ED30 File Offset: 0x00C4CF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m03(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m03);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602362A RID: 144938 RVA: 0x00C4ED84 File Offset: 0x00C4CF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m03(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m03 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602362B RID: 144939 RVA: 0x00C4EDE8 File Offset: 0x00C4CFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m13(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m13);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602362C RID: 144940 RVA: 0x00C4EE3C File Offset: 0x00C4D03C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m13(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m13 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602362D RID: 144941 RVA: 0x00C4EEA0 File Offset: 0x00C4D0A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m23(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m23);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602362E RID: 144942 RVA: 0x00C4EEF4 File Offset: 0x00C4D0F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m23(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m23 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602362F RID: 144943 RVA: 0x00C4EF58 File Offset: 0x00C4D158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m33(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.m33);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023630 RID: 144944 RVA: 0x00C4EFAC File Offset: 0x00C4D1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m33(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			float m;
			LuaObject.checkType(l, 2, out m);
			matrix4x.m33 = m;
			LuaObject.setBack(l, matrix4x);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023631 RID: 144945 RVA: 0x00C4F010 File Offset: 0x00C4D210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inverse(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.inverse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023632 RID: 144946 RVA: 0x00C4F068 File Offset: 0x00C4D268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transpose(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.transpose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023633 RID: 144947 RVA: 0x00C4F0C0 File Offset: 0x00C4D2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023634 RID: 144948 RVA: 0x00C4F114 File Offset: 0x00C4D314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lossyScale(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.lossyScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023635 RID: 144949 RVA: 0x00C4F168 File Offset: 0x00C4D368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isIdentity(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.isIdentity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023636 RID: 144950 RVA: 0x00C4F1BC File Offset: 0x00C4D3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_determinant(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.determinant);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023637 RID: 144951 RVA: 0x00C4F210 File Offset: 0x00C4D410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_decomposeProjection(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x.decomposeProjection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023638 RID: 144952 RVA: 0x00C4F268 File Offset: 0x00C4D468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Matrix4x4.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023639 RID: 144953 RVA: 0x00C4F2B4 File Offset: 0x00C4D4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_identity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Matrix4x4.identity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602363A RID: 144954 RVA: 0x00C4F300 File Offset: 0x00C4D500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			int index;
			LuaObject.checkType(l, 2, out index);
			float o = matrix4x[index];
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

	// Token: 0x0602363B RID: 144955 RVA: 0x00C4F360 File Offset: 0x00C4D560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 matrix4x;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out matrix4x);
			int index;
			LuaObject.checkType(l, 2, out index);
			float value;
			LuaObject.checkType(l, 3, out value);
			matrix4x[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602363C RID: 144956 RVA: 0x00C4F3C4 File Offset: 0x00C4D5C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Matrix4x4");
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.ValidTRS);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache0);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.SetTRS);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache1);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.GetColumn);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache2);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.GetRow);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.SetColumn);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache4);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.SetRow);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache5);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.MultiplyPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache6);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.MultiplyPoint3x4);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache7);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.MultiplyVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache8);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.TransformPlane);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache9);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Inverse_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cacheA);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Transpose_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cacheB);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Determinant_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cacheC);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.TRS_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cacheD);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Ortho_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cacheE);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Perspective_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cacheF);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.LookAt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache10);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Frustum_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache11);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache12);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache13);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache14);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Scale_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache15);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Translate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache16);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.Rotate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache17);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache18);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache19);
		string name = "m00";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m00);
		}
		LuaCSFunction get = Lua_UnityEngine_Matrix4x4.<>f__mg$cache1A;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m00);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Matrix4x4.<>f__mg$cache1B, true);
		string name2 = "m10";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m10);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache1C;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m10);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Matrix4x4.<>f__mg$cache1D, true);
		string name3 = "m20";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m20);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache1E;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m20);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Matrix4x4.<>f__mg$cache1F, true);
		string name4 = "m30";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m30);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache20;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m30);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Matrix4x4.<>f__mg$cache21, true);
		string name5 = "m01";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m01);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache22;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m01);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Matrix4x4.<>f__mg$cache23, true);
		string name6 = "m11";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m11);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache24;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m11);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Matrix4x4.<>f__mg$cache25, true);
		string name7 = "m21";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m21);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache26;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m21);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Matrix4x4.<>f__mg$cache27, true);
		string name8 = "m31";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m31);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache28;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m31);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Matrix4x4.<>f__mg$cache29, true);
		string name9 = "m02";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m02);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache2A;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m02);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_Matrix4x4.<>f__mg$cache2B, true);
		string name10 = "m12";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m12);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache2C;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m12);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_Matrix4x4.<>f__mg$cache2D, true);
		string name11 = "m22";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m22);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache2E;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m22);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_Matrix4x4.<>f__mg$cache2F, true);
		string name12 = "m32";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m32);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache30;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m32);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_Matrix4x4.<>f__mg$cache31, true);
		string name13 = "m03";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m03);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache32;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m03);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_Matrix4x4.<>f__mg$cache33, true);
		string name14 = "m13";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m13);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache34;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m13);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_Matrix4x4.<>f__mg$cache35, true);
		string name15 = "m23";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m23);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache36;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m23);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_Matrix4x4.<>f__mg$cache37, true);
		string name16 = "m33";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_m33);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Matrix4x4.<>f__mg$cache38;
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.set_m33);
		}
		LuaObject.addMember(l, name16, get16, Lua_UnityEngine_Matrix4x4.<>f__mg$cache39, true);
		string name17 = "inverse";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_inverse);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3A, null, true);
		string name18 = "transpose";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_transpose);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3B, null, true);
		string name19 = "rotation";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_rotation);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3C, null, true);
		string name20 = "lossyScale";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_lossyScale);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3D, null, true);
		string name21 = "isIdentity";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_isIdentity);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3E, null, true);
		string name22 = "determinant";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_determinant);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_Matrix4x4.<>f__mg$cache3F, null, true);
		string name23 = "decomposeProjection";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_decomposeProjection);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_Matrix4x4.<>f__mg$cache40, null, true);
		string name24 = "zero";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_zero);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_Matrix4x4.<>f__mg$cache41, null, false);
		string name25 = "identity";
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.get_identity);
		}
		LuaObject.addMember(l, name25, Lua_UnityEngine_Matrix4x4.<>f__mg$cache42, null, false);
		if (Lua_UnityEngine_Matrix4x4.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_Matrix4x4.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_Matrix4x4.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Matrix4x4.<>f__mg$cache43, typeof(Matrix4x4), typeof(ValueType));
	}

	// Token: 0x04019408 RID: 103432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019409 RID: 103433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401940A RID: 103434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401940B RID: 103435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401940C RID: 103436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401940D RID: 103437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401940E RID: 103438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401940F RID: 103439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019410 RID: 103440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019411 RID: 103441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019412 RID: 103442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019413 RID: 103443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019414 RID: 103444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019415 RID: 103445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019416 RID: 103446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019417 RID: 103447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019418 RID: 103448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019419 RID: 103449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401941A RID: 103450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401941B RID: 103451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401941C RID: 103452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401941D RID: 103453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401941E RID: 103454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401941F RID: 103455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019420 RID: 103456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019421 RID: 103457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019422 RID: 103458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019423 RID: 103459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019424 RID: 103460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019425 RID: 103461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019426 RID: 103462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019427 RID: 103463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019428 RID: 103464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019429 RID: 103465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401942A RID: 103466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401942B RID: 103467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401942C RID: 103468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401942D RID: 103469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401942E RID: 103470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401942F RID: 103471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019430 RID: 103472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019431 RID: 103473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019432 RID: 103474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019433 RID: 103475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019434 RID: 103476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019435 RID: 103477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019436 RID: 103478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019437 RID: 103479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019438 RID: 103480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019439 RID: 103481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401943A RID: 103482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401943B RID: 103483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401943C RID: 103484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401943D RID: 103485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401943E RID: 103486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401943F RID: 103487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019440 RID: 103488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019441 RID: 103489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019442 RID: 103490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019443 RID: 103491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019444 RID: 103492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04019445 RID: 103493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04019446 RID: 103494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04019447 RID: 103495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04019448 RID: 103496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04019449 RID: 103497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401944A RID: 103498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401944B RID: 103499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;
}
