using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001805 RID: 6149
[Preserve]
public class Lua_UnityEngine_Transform : LuaObject
{
	// Token: 0x06023F37 RID: 147255 RVA: 0x00C9D0FC File Offset: 0x00C9B2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetParent(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Transform parent;
				LuaObject.checkType<Transform>(l, 2, out parent);
				transform.SetParent(parent);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				Transform parent2;
				LuaObject.checkType<Transform>(l, 2, out parent2);
				bool worldPositionStays;
				LuaObject.checkType(l, 3, out worldPositionStays);
				transform2.SetParent(parent2, worldPositionStays);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetParent to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F38 RID: 147256 RVA: 0x00C9D1C0 File Offset: 0x00C9B3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPositionAndRotation(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Quaternion rotation;
			LuaObject.checkType(l, 3, out rotation);
			transform.SetPositionAndRotation(position, rotation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F39 RID: 147257 RVA: 0x00C9D224 File Offset: 0x00C9B424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Translate(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 translation;
				LuaObject.checkType(l, 2, out translation);
				transform.Translate(translation);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(Transform)))
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				Vector3 translation2;
				LuaObject.checkType(l, 2, out translation2);
				Transform relativeTo;
				LuaObject.checkType<Transform>(l, 3, out relativeTo);
				transform2.Translate(translation2, relativeTo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(Space)))
			{
				Transform transform3 = (Transform)LuaObject.checkSelf(l);
				Vector3 translation3;
				LuaObject.checkType(l, 2, out translation3);
				Space relativeTo2;
				LuaObject.checkEnum<Space>(l, 3, out relativeTo2);
				transform3.Translate(translation3, relativeTo2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Transform transform4 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				transform4.Translate(x, y, z);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(float), typeof(float), typeof(float), typeof(Transform)))
			{
				Transform transform5 = (Transform)LuaObject.checkSelf(l);
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				float z2;
				LuaObject.checkType(l, 4, out z2);
				Transform relativeTo3;
				LuaObject.checkType<Transform>(l, 5, out relativeTo3);
				transform5.Translate(x2, y2, z2, relativeTo3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(float), typeof(float), typeof(float), typeof(Space)))
			{
				Transform transform6 = (Transform)LuaObject.checkSelf(l);
				float x3;
				LuaObject.checkType(l, 2, out x3);
				float y3;
				LuaObject.checkType(l, 3, out y3);
				float z3;
				LuaObject.checkType(l, 4, out z3);
				Space relativeTo4;
				LuaObject.checkEnum<Space>(l, 5, out relativeTo4);
				transform6.Translate(x3, y3, z3, relativeTo4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Translate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F3A RID: 147258 RVA: 0x00C9D4C4 File Offset: 0x00C9B6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rotate(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 eulerAngles;
				LuaObject.checkType(l, 2, out eulerAngles);
				transform.Rotate(eulerAngles);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(float)))
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				Vector3 axis;
				LuaObject.checkType(l, 2, out axis);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				transform2.Rotate(axis, angle);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(Space)))
			{
				Transform transform3 = (Transform)LuaObject.checkSelf(l);
				Vector3 eulerAngles2;
				LuaObject.checkType(l, 2, out eulerAngles2);
				Space relativeTo;
				LuaObject.checkEnum<Space>(l, 3, out relativeTo);
				transform3.Rotate(eulerAngles2, relativeTo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(float), typeof(Space)))
			{
				Transform transform4 = (Transform)LuaObject.checkSelf(l);
				Vector3 axis2;
				LuaObject.checkType(l, 2, out axis2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				Space relativeTo2;
				LuaObject.checkEnum<Space>(l, 4, out relativeTo2);
				transform4.Rotate(axis2, angle2, relativeTo2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(float), typeof(float), typeof(float)))
			{
				Transform transform5 = (Transform)LuaObject.checkSelf(l);
				float xAngle;
				LuaObject.checkType(l, 2, out xAngle);
				float yAngle;
				LuaObject.checkType(l, 3, out yAngle);
				float zAngle;
				LuaObject.checkType(l, 4, out zAngle);
				transform5.Rotate(xAngle, yAngle, zAngle);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Transform transform6 = (Transform)LuaObject.checkSelf(l);
				float xAngle2;
				LuaObject.checkType(l, 2, out xAngle2);
				float yAngle2;
				LuaObject.checkType(l, 3, out yAngle2);
				float zAngle2;
				LuaObject.checkType(l, 4, out zAngle2);
				Space relativeTo3;
				LuaObject.checkEnum<Space>(l, 5, out relativeTo3);
				transform6.Rotate(xAngle2, yAngle2, zAngle2, relativeTo3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Rotate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F3B RID: 147259 RVA: 0x00C9D744 File Offset: 0x00C9B944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RotateAround(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			Vector3 axis;
			LuaObject.checkType(l, 3, out axis);
			float angle;
			LuaObject.checkType(l, 4, out angle);
			transform.RotateAround(point, axis, angle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F3C RID: 147260 RVA: 0x00C9D7B8 File Offset: 0x00C9B9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LookAt(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Transform)))
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Transform target;
				LuaObject.checkType<Transform>(l, 2, out target);
				transform.LookAt(target);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector3)))
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				Vector3 worldPosition;
				LuaObject.checkType(l, 2, out worldPosition);
				transform2.LookAt(worldPosition);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector3), typeof(Vector3)))
			{
				Transform transform3 = (Transform)LuaObject.checkSelf(l);
				Vector3 worldPosition2;
				LuaObject.checkType(l, 2, out worldPosition2);
				Vector3 worldUp;
				LuaObject.checkType(l, 3, out worldUp);
				transform3.LookAt(worldPosition2, worldUp);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Transform), typeof(Vector3)))
			{
				Transform transform4 = (Transform)LuaObject.checkSelf(l);
				Transform target2;
				LuaObject.checkType<Transform>(l, 2, out target2);
				Vector3 worldUp2;
				LuaObject.checkType(l, 3, out worldUp2);
				transform4.LookAt(target2, worldUp2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LookAt to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F3D RID: 147261 RVA: 0x00C9D950 File Offset: 0x00C9BB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TransformDirection(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				Vector3 o = transform.TransformDirection(direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 o2 = transform2.TransformDirection(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function TransformDirection to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F3E RID: 147262 RVA: 0x00C9DA34 File Offset: 0x00C9BC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InverseTransformDirection(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				Vector3 o = transform.InverseTransformDirection(direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 o2 = transform2.InverseTransformDirection(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function InverseTransformDirection to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F3F RID: 147263 RVA: 0x00C9DB18 File Offset: 0x00C9BD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TransformVector(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 vector;
				LuaObject.checkType(l, 2, out vector);
				Vector3 o = transform.TransformVector(vector);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 o2 = transform2.TransformVector(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function TransformVector to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F40 RID: 147264 RVA: 0x00C9DBFC File Offset: 0x00C9BDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InverseTransformVector(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 vector;
				LuaObject.checkType(l, 2, out vector);
				Vector3 o = transform.InverseTransformVector(vector);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 o2 = transform2.InverseTransformVector(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function InverseTransformVector to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F41 RID: 147265 RVA: 0x00C9DCE0 File Offset: 0x00C9BEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TransformPoint(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 position;
				LuaObject.checkType(l, 2, out position);
				Vector3 o = transform.TransformPoint(position);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 o2 = transform2.TransformPoint(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function TransformPoint to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F42 RID: 147266 RVA: 0x00C9DDC4 File Offset: 0x00C9BFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InverseTransformPoint(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Transform transform = (Transform)LuaObject.checkSelf(l);
				Vector3 position;
				LuaObject.checkType(l, 2, out position);
				Vector3 o = transform.InverseTransformPoint(position);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Transform transform2 = (Transform)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				Vector3 o2 = transform2.InverseTransformPoint(x, y, z);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function InverseTransformPoint to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F43 RID: 147267 RVA: 0x00C9DEA8 File Offset: 0x00C9C0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DetachChildren(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			transform.DetachChildren();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F44 RID: 147268 RVA: 0x00C9DEF4 File Offset: 0x00C9C0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAsFirstSibling(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			transform.SetAsFirstSibling();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F45 RID: 147269 RVA: 0x00C9DF40 File Offset: 0x00C9C140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAsLastSibling(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			transform.SetAsLastSibling();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F46 RID: 147270 RVA: 0x00C9DF8C File Offset: 0x00C9C18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSiblingIndex(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			int siblingIndex;
			LuaObject.checkType(l, 2, out siblingIndex);
			transform.SetSiblingIndex(siblingIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F47 RID: 147271 RVA: 0x00C9DFE4 File Offset: 0x00C9C1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSiblingIndex(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			int siblingIndex = transform.GetSiblingIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, siblingIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F48 RID: 147272 RVA: 0x00C9E038 File Offset: 0x00C9C238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Find(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			Transform o = transform.Find(name);
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

	// Token: 0x06023F49 RID: 147273 RVA: 0x00C9E09C File Offset: 0x00C9C29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChildOf(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			bool b = transform.IsChildOf(parent);
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

	// Token: 0x06023F4A RID: 147274 RVA: 0x00C9E100 File Offset: 0x00C9C300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChild(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Transform child = transform.GetChild(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, child);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F4B RID: 147275 RVA: 0x00C9E164 File Offset: 0x00C9C364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F4C RID: 147276 RVA: 0x00C9E1B8 File Offset: 0x00C9C3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			transform.position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F4D RID: 147277 RVA: 0x00C9E210 File Offset: 0x00C9C410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_localPosition(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.localPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F4E RID: 147278 RVA: 0x00C9E264 File Offset: 0x00C9C464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_localPosition(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 localPosition;
			LuaObject.checkType(l, 2, out localPosition);
			transform.localPosition = localPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F4F RID: 147279 RVA: 0x00C9E2BC File Offset: 0x00C9C4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eulerAngles(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.eulerAngles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F50 RID: 147280 RVA: 0x00C9E310 File Offset: 0x00C9C510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_eulerAngles(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 eulerAngles;
			LuaObject.checkType(l, 2, out eulerAngles);
			transform.eulerAngles = eulerAngles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F51 RID: 147281 RVA: 0x00C9E368 File Offset: 0x00C9C568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localEulerAngles(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.localEulerAngles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F52 RID: 147282 RVA: 0x00C9E3BC File Offset: 0x00C9C5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_localEulerAngles(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 localEulerAngles;
			LuaObject.checkType(l, 2, out localEulerAngles);
			transform.localEulerAngles = localEulerAngles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F53 RID: 147283 RVA: 0x00C9E414 File Offset: 0x00C9C614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F54 RID: 147284 RVA: 0x00C9E468 File Offset: 0x00C9C668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_right(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 right;
			LuaObject.checkType(l, 2, out right);
			transform.right = right;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F55 RID: 147285 RVA: 0x00C9E4C0 File Offset: 0x00C9C6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_up(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.up);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F56 RID: 147286 RVA: 0x00C9E514 File Offset: 0x00C9C714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_up(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 up;
			LuaObject.checkType(l, 2, out up);
			transform.up = up;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F57 RID: 147287 RVA: 0x00C9E56C File Offset: 0x00C9C76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_forward(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.forward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F58 RID: 147288 RVA: 0x00C9E5C0 File Offset: 0x00C9C7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forward(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 forward;
			LuaObject.checkType(l, 2, out forward);
			transform.forward = forward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F59 RID: 147289 RVA: 0x00C9E618 File Offset: 0x00C9C818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F5A RID: 147290 RVA: 0x00C9E66C File Offset: 0x00C9C86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotation(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Quaternion rotation;
			LuaObject.checkType(l, 2, out rotation);
			transform.rotation = rotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F5B RID: 147291 RVA: 0x00C9E6C4 File Offset: 0x00C9C8C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_localRotation(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.localRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F5C RID: 147292 RVA: 0x00C9E718 File Offset: 0x00C9C918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_localRotation(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Quaternion localRotation;
			LuaObject.checkType(l, 2, out localRotation);
			transform.localRotation = localRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F5D RID: 147293 RVA: 0x00C9E770 File Offset: 0x00C9C970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localScale(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.localScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F5E RID: 147294 RVA: 0x00C9E7C4 File Offset: 0x00C9C9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_localScale(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Vector3 localScale;
			LuaObject.checkType(l, 2, out localScale);
			transform.localScale = localScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F5F RID: 147295 RVA: 0x00C9E81C File Offset: 0x00C9CA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_parent(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.parent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F60 RID: 147296 RVA: 0x00C9E870 File Offset: 0x00C9CA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_parent(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			transform.parent = parent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F61 RID: 147297 RVA: 0x00C9E8C8 File Offset: 0x00C9CAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldToLocalMatrix(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.worldToLocalMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F62 RID: 147298 RVA: 0x00C9E920 File Offset: 0x00C9CB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localToWorldMatrix(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.localToWorldMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F63 RID: 147299 RVA: 0x00C9E978 File Offset: 0x00C9CB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_root(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.root);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F64 RID: 147300 RVA: 0x00C9E9CC File Offset: 0x00C9CBCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_childCount(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.childCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F65 RID: 147301 RVA: 0x00C9EA20 File Offset: 0x00C9CC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lossyScale(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.lossyScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F66 RID: 147302 RVA: 0x00C9EA74 File Offset: 0x00C9CC74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_hasChanged(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.hasChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F67 RID: 147303 RVA: 0x00C9EAC8 File Offset: 0x00C9CCC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hasChanged(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			bool hasChanged;
			LuaObject.checkType(l, 2, out hasChanged);
			transform.hasChanged = hasChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F68 RID: 147304 RVA: 0x00C9EB20 File Offset: 0x00C9CD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hierarchyCapacity(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.hierarchyCapacity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F69 RID: 147305 RVA: 0x00C9EB74 File Offset: 0x00C9CD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hierarchyCapacity(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			int hierarchyCapacity;
			LuaObject.checkType(l, 2, out hierarchyCapacity);
			transform.hierarchyCapacity = hierarchyCapacity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F6A RID: 147306 RVA: 0x00C9EBCC File Offset: 0x00C9CDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hierarchyCount(IntPtr l)
	{
		int result;
		try
		{
			Transform transform = (Transform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transform.hierarchyCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F6B RID: 147307 RVA: 0x00C9EC20 File Offset: 0x00C9CE20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Transform");
		if (Lua_UnityEngine_Transform.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Transform.SetParent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache0);
		if (Lua_UnityEngine_Transform.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Transform.SetPositionAndRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache1);
		if (Lua_UnityEngine_Transform.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Transform.Translate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache2);
		if (Lua_UnityEngine_Transform.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Transform.Rotate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache3);
		if (Lua_UnityEngine_Transform.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Transform.RotateAround);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache4);
		if (Lua_UnityEngine_Transform.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Transform.LookAt);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache5);
		if (Lua_UnityEngine_Transform.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Transform.TransformDirection);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache6);
		if (Lua_UnityEngine_Transform.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Transform.InverseTransformDirection);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache7);
		if (Lua_UnityEngine_Transform.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Transform.TransformVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache8);
		if (Lua_UnityEngine_Transform.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Transform.InverseTransformVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache9);
		if (Lua_UnityEngine_Transform.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Transform.TransformPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cacheA);
		if (Lua_UnityEngine_Transform.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Transform.InverseTransformPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cacheB);
		if (Lua_UnityEngine_Transform.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Transform.DetachChildren);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cacheC);
		if (Lua_UnityEngine_Transform.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Transform.SetAsFirstSibling);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cacheD);
		if (Lua_UnityEngine_Transform.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Transform.SetAsLastSibling);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cacheE);
		if (Lua_UnityEngine_Transform.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Transform.SetSiblingIndex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cacheF);
		if (Lua_UnityEngine_Transform.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Transform.GetSiblingIndex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache10);
		if (Lua_UnityEngine_Transform.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Transform.Find);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache11);
		if (Lua_UnityEngine_Transform.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Transform.IsChildOf);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache12);
		if (Lua_UnityEngine_Transform.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Transform.GetChild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Transform.<>f__mg$cache13);
		string name = "position";
		if (Lua_UnityEngine_Transform.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Transform.get_position);
		}
		LuaCSFunction get = Lua_UnityEngine_Transform.<>f__mg$cache14;
		if (Lua_UnityEngine_Transform.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Transform.set_position);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Transform.<>f__mg$cache15, true);
		string name2 = "localPosition";
		if (Lua_UnityEngine_Transform.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Transform.get_localPosition);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Transform.<>f__mg$cache16;
		if (Lua_UnityEngine_Transform.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Transform.set_localPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Transform.<>f__mg$cache17, true);
		string name3 = "eulerAngles";
		if (Lua_UnityEngine_Transform.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Transform.get_eulerAngles);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Transform.<>f__mg$cache18;
		if (Lua_UnityEngine_Transform.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Transform.set_eulerAngles);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Transform.<>f__mg$cache19, true);
		string name4 = "localEulerAngles";
		if (Lua_UnityEngine_Transform.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Transform.get_localEulerAngles);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Transform.<>f__mg$cache1A;
		if (Lua_UnityEngine_Transform.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Transform.set_localEulerAngles);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Transform.<>f__mg$cache1B, true);
		string name5 = "right";
		if (Lua_UnityEngine_Transform.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Transform.get_right);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Transform.<>f__mg$cache1C;
		if (Lua_UnityEngine_Transform.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Transform.set_right);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Transform.<>f__mg$cache1D, true);
		string name6 = "up";
		if (Lua_UnityEngine_Transform.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Transform.get_up);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Transform.<>f__mg$cache1E;
		if (Lua_UnityEngine_Transform.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Transform.set_up);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Transform.<>f__mg$cache1F, true);
		string name7 = "forward";
		if (Lua_UnityEngine_Transform.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Transform.get_forward);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Transform.<>f__mg$cache20;
		if (Lua_UnityEngine_Transform.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Transform.set_forward);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Transform.<>f__mg$cache21, true);
		string name8 = "rotation";
		if (Lua_UnityEngine_Transform.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Transform.get_rotation);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Transform.<>f__mg$cache22;
		if (Lua_UnityEngine_Transform.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Transform.set_rotation);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Transform.<>f__mg$cache23, true);
		string name9 = "localRotation";
		if (Lua_UnityEngine_Transform.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Transform.get_localRotation);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Transform.<>f__mg$cache24;
		if (Lua_UnityEngine_Transform.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Transform.set_localRotation);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_Transform.<>f__mg$cache25, true);
		string name10 = "localScale";
		if (Lua_UnityEngine_Transform.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Transform.get_localScale);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Transform.<>f__mg$cache26;
		if (Lua_UnityEngine_Transform.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Transform.set_localScale);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_Transform.<>f__mg$cache27, true);
		string name11 = "parent";
		if (Lua_UnityEngine_Transform.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Transform.get_parent);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Transform.<>f__mg$cache28;
		if (Lua_UnityEngine_Transform.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Transform.set_parent);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_Transform.<>f__mg$cache29, true);
		string name12 = "worldToLocalMatrix";
		if (Lua_UnityEngine_Transform.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Transform.get_worldToLocalMatrix);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Transform.<>f__mg$cache2A, null, true);
		string name13 = "localToWorldMatrix";
		if (Lua_UnityEngine_Transform.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Transform.get_localToWorldMatrix);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Transform.<>f__mg$cache2B, null, true);
		string name14 = "root";
		if (Lua_UnityEngine_Transform.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Transform.get_root);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Transform.<>f__mg$cache2C, null, true);
		string name15 = "childCount";
		if (Lua_UnityEngine_Transform.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Transform.get_childCount);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Transform.<>f__mg$cache2D, null, true);
		string name16 = "lossyScale";
		if (Lua_UnityEngine_Transform.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Transform.get_lossyScale);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Transform.<>f__mg$cache2E, null, true);
		string name17 = "hasChanged";
		if (Lua_UnityEngine_Transform.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Transform.get_hasChanged);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Transform.<>f__mg$cache2F;
		if (Lua_UnityEngine_Transform.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Transform.set_hasChanged);
		}
		LuaObject.addMember(l, name17, get12, Lua_UnityEngine_Transform.<>f__mg$cache30, true);
		string name18 = "hierarchyCapacity";
		if (Lua_UnityEngine_Transform.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Transform.get_hierarchyCapacity);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Transform.<>f__mg$cache31;
		if (Lua_UnityEngine_Transform.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Transform.set_hierarchyCapacity);
		}
		LuaObject.addMember(l, name18, get13, Lua_UnityEngine_Transform.<>f__mg$cache32, true);
		string name19 = "hierarchyCount";
		if (Lua_UnityEngine_Transform.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Transform.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Transform.get_hierarchyCount);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Transform.<>f__mg$cache33, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Transform), typeof(Component));
	}

	// Token: 0x04019B8B RID: 105355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B8C RID: 105356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B8D RID: 105357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B8E RID: 105358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B8F RID: 105359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B90 RID: 105360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B91 RID: 105361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B92 RID: 105362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019B93 RID: 105363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019B94 RID: 105364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019B95 RID: 105365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019B96 RID: 105366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019B97 RID: 105367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019B98 RID: 105368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019B99 RID: 105369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019B9A RID: 105370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019B9B RID: 105371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019B9C RID: 105372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019B9D RID: 105373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019B9E RID: 105374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019B9F RID: 105375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019BA0 RID: 105376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019BA1 RID: 105377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019BA2 RID: 105378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019BA3 RID: 105379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019BA4 RID: 105380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019BA5 RID: 105381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019BA6 RID: 105382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019BA7 RID: 105383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019BA8 RID: 105384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019BA9 RID: 105385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019BAA RID: 105386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019BAB RID: 105387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019BAC RID: 105388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019BAD RID: 105389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019BAE RID: 105390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019BAF RID: 105391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019BB0 RID: 105392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019BB1 RID: 105393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019BB2 RID: 105394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019BB3 RID: 105395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019BB4 RID: 105396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019BB5 RID: 105397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019BB6 RID: 105398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019BB7 RID: 105399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019BB8 RID: 105400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019BB9 RID: 105401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019BBA RID: 105402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019BBB RID: 105403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019BBC RID: 105404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04019BBD RID: 105405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019BBE RID: 105406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
