using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200176D RID: 5997
[Preserve]
public class Lua_UnityEngine_Rect : LuaObject
{
	// Token: 0x06023976 RID: 145782 RVA: 0x00C6F140 File Offset: 0x00C6D340
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
				float width;
				LuaObject.checkType(l, 4, out width);
				float height;
				LuaObject.checkType(l, 5, out height);
				Rect rect = new Rect(x, y, width, height);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rect);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 position;
				LuaObject.checkType(l, 2, out position);
				Vector2 size;
				LuaObject.checkType(l, 3, out size);
				Rect rect = new Rect(position, size);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rect);
				result = 2;
			}
			else if (num == 2)
			{
				Rect source;
				LuaObject.checkValueType<Rect>(l, 2, out source);
				Rect rect = new Rect(source);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rect);
				result = 2;
			}
			else if (num == 0)
			{
				Rect rect = default(Rect);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, rect);
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

	// Token: 0x06023977 RID: 145783 RVA: 0x00C6F28C File Offset: 0x00C6D48C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Set(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float x;
			LuaObject.checkType(l, 2, out x);
			float y;
			LuaObject.checkType(l, 3, out y);
			float width;
			LuaObject.checkType(l, 4, out width);
			float height;
			LuaObject.checkType(l, 5, out height);
			rect.Set(x, y, width, height);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, rect);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023978 RID: 145784 RVA: 0x00C6F318 File Offset: 0x00C6D518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(Vector2)))
			{
				Rect rect;
				LuaObject.checkValueType<Rect>(l, 1, out rect);
				Vector2 point;
				LuaObject.checkType(l, 2, out point);
				bool b = rect.Contains(point);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3)))
			{
				Rect rect2;
				LuaObject.checkValueType<Rect>(l, 1, out rect2);
				Vector3 point2;
				LuaObject.checkType(l, 2, out point2);
				bool b2 = rect2.Contains(point2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 3)
			{
				Rect rect3;
				LuaObject.checkValueType<Rect>(l, 1, out rect3);
				Vector3 point3;
				LuaObject.checkType(l, 2, out point3);
				bool allowInverse;
				LuaObject.checkType(l, 3, out allowInverse);
				bool b3 = rect3.Contains(point3, allowInverse);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Contains to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023979 RID: 145785 RVA: 0x00C6F458 File Offset: 0x00C6D658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Overlaps(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Rect rect;
				LuaObject.checkValueType<Rect>(l, 1, out rect);
				Rect other;
				LuaObject.checkValueType<Rect>(l, 2, out other);
				bool b = rect.Overlaps(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				Rect rect2;
				LuaObject.checkValueType<Rect>(l, 1, out rect2);
				Rect other2;
				LuaObject.checkValueType<Rect>(l, 2, out other2);
				bool allowInverse;
				LuaObject.checkType(l, 3, out allowInverse);
				bool b2 = rect2.Overlaps(other2, allowInverse);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Overlaps to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602397A RID: 145786 RVA: 0x00C6F52C File Offset: 0x00C6D72C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MinMaxRect_s(IntPtr l)
	{
		int result;
		try
		{
			float xmin;
			LuaObject.checkType(l, 1, out xmin);
			float ymin;
			LuaObject.checkType(l, 2, out ymin);
			float xmax;
			LuaObject.checkType(l, 3, out xmax);
			float ymax;
			LuaObject.checkType(l, 4, out ymax);
			Rect rect = Rect.MinMaxRect(xmin, ymin, xmax, ymax);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602397B RID: 145787 RVA: 0x00C6F5AC File Offset: 0x00C6D7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NormalizedToPoint_s(IntPtr l)
	{
		int result;
		try
		{
			Rect rectangle;
			LuaObject.checkValueType<Rect>(l, 1, out rectangle);
			Vector2 normalizedRectCoordinates;
			LuaObject.checkType(l, 2, out normalizedRectCoordinates);
			Vector2 o = Rect.NormalizedToPoint(rectangle, normalizedRectCoordinates);
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

	// Token: 0x0602397C RID: 145788 RVA: 0x00C6F60C File Offset: 0x00C6D80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PointToNormalized_s(IntPtr l)
	{
		int result;
		try
		{
			Rect rectangle;
			LuaObject.checkValueType<Rect>(l, 1, out rectangle);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			Vector2 o = Rect.PointToNormalized(rectangle, point);
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

	// Token: 0x0602397D RID: 145789 RVA: 0x00C6F66C File Offset: 0x00C6D86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Rect lhs;
			LuaObject.checkValueType<Rect>(l, 1, out lhs);
			Rect rhs;
			LuaObject.checkValueType<Rect>(l, 2, out rhs);
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

	// Token: 0x0602397E RID: 145790 RVA: 0x00C6F6CC File Offset: 0x00C6D8CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Rect lhs;
			LuaObject.checkValueType<Rect>(l, 1, out lhs);
			Rect rhs;
			LuaObject.checkValueType<Rect>(l, 2, out rhs);
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

	// Token: 0x0602397F RID: 145791 RVA: 0x00C6F72C File Offset: 0x00C6D92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Rect.zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023980 RID: 145792 RVA: 0x00C6F778 File Offset: 0x00C6D978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023981 RID: 145793 RVA: 0x00C6F7CC File Offset: 0x00C6D9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float x;
			LuaObject.checkType(l, 2, out x);
			rect.x = x;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023982 RID: 145794 RVA: 0x00C6F830 File Offset: 0x00C6DA30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023983 RID: 145795 RVA: 0x00C6F884 File Offset: 0x00C6DA84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float y;
			LuaObject.checkType(l, 2, out y);
			rect.y = y;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023984 RID: 145796 RVA: 0x00C6F8E8 File Offset: 0x00C6DAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023985 RID: 145797 RVA: 0x00C6F93C File Offset: 0x00C6DB3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			rect.position = position;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023986 RID: 145798 RVA: 0x00C6F9A0 File Offset: 0x00C6DBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023987 RID: 145799 RVA: 0x00C6F9F4 File Offset: 0x00C6DBF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			Vector2 center;
			LuaObject.checkType(l, 2, out center);
			rect.center = center;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023988 RID: 145800 RVA: 0x00C6FA58 File Offset: 0x00C6DC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023989 RID: 145801 RVA: 0x00C6FAAC File Offset: 0x00C6DCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			Vector2 min;
			LuaObject.checkType(l, 2, out min);
			rect.min = min;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602398A RID: 145802 RVA: 0x00C6FB10 File Offset: 0x00C6DD10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602398B RID: 145803 RVA: 0x00C6FB64 File Offset: 0x00C6DD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			Vector2 max;
			LuaObject.checkType(l, 2, out max);
			rect.max = max;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602398C RID: 145804 RVA: 0x00C6FBC8 File Offset: 0x00C6DDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602398D RID: 145805 RVA: 0x00C6FC1C File Offset: 0x00C6DE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float width;
			LuaObject.checkType(l, 2, out width);
			rect.width = width;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602398E RID: 145806 RVA: 0x00C6FC80 File Offset: 0x00C6DE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602398F RID: 145807 RVA: 0x00C6FCD4 File Offset: 0x00C6DED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float height;
			LuaObject.checkType(l, 2, out height);
			rect.height = height;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023990 RID: 145808 RVA: 0x00C6FD38 File Offset: 0x00C6DF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023991 RID: 145809 RVA: 0x00C6FD8C File Offset: 0x00C6DF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			Vector2 size;
			LuaObject.checkType(l, 2, out size);
			rect.size = size;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023992 RID: 145810 RVA: 0x00C6FDF0 File Offset: 0x00C6DFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xMin(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.xMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023993 RID: 145811 RVA: 0x00C6FE44 File Offset: 0x00C6E044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMin(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float xMin;
			LuaObject.checkType(l, 2, out xMin);
			rect.xMin = xMin;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023994 RID: 145812 RVA: 0x00C6FEA8 File Offset: 0x00C6E0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMin(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.yMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023995 RID: 145813 RVA: 0x00C6FEFC File Offset: 0x00C6E0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMin(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float yMin;
			LuaObject.checkType(l, 2, out yMin);
			rect.yMin = yMin;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023996 RID: 145814 RVA: 0x00C6FF60 File Offset: 0x00C6E160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xMax(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.xMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023997 RID: 145815 RVA: 0x00C6FFB4 File Offset: 0x00C6E1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMax(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float xMax;
			LuaObject.checkType(l, 2, out xMax);
			rect.xMax = xMax;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023998 RID: 145816 RVA: 0x00C70018 File Offset: 0x00C6E218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMax(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect.yMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023999 RID: 145817 RVA: 0x00C7006C File Offset: 0x00C6E26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMax(IntPtr l)
	{
		int result;
		try
		{
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 1, out rect);
			float yMax;
			LuaObject.checkType(l, 2, out yMax);
			rect.yMax = yMax;
			LuaObject.setBack(l, rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602399A RID: 145818 RVA: 0x00C700D0 File Offset: 0x00C6E2D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rect");
		if (Lua_UnityEngine_Rect.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rect.Set);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache0);
		if (Lua_UnityEngine_Rect.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rect.Contains);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache1);
		if (Lua_UnityEngine_Rect.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rect.Overlaps);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache2);
		if (Lua_UnityEngine_Rect.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rect.MinMaxRect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache3);
		if (Lua_UnityEngine_Rect.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rect.NormalizedToPoint_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache4);
		if (Lua_UnityEngine_Rect.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rect.PointToNormalized_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache5);
		if (Lua_UnityEngine_Rect.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Rect.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache6);
		if (Lua_UnityEngine_Rect.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Rect.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rect.<>f__mg$cache7);
		string name = "zero";
		if (Lua_UnityEngine_Rect.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Rect.get_zero);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Rect.<>f__mg$cache8, null, false);
		string name2 = "x";
		if (Lua_UnityEngine_Rect.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Rect.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_Rect.<>f__mg$cache9;
		if (Lua_UnityEngine_Rect.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Rect.set_x);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Rect.<>f__mg$cacheA, true);
		string name3 = "y";
		if (Lua_UnityEngine_Rect.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Rect.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Rect.<>f__mg$cacheB;
		if (Lua_UnityEngine_Rect.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Rect.set_y);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Rect.<>f__mg$cacheC, true);
		string name4 = "position";
		if (Lua_UnityEngine_Rect.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Rect.get_position);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Rect.<>f__mg$cacheD;
		if (Lua_UnityEngine_Rect.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Rect.set_position);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Rect.<>f__mg$cacheE, true);
		string name5 = "center";
		if (Lua_UnityEngine_Rect.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Rect.get_center);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Rect.<>f__mg$cacheF;
		if (Lua_UnityEngine_Rect.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Rect.set_center);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_Rect.<>f__mg$cache10, true);
		string name6 = "min";
		if (Lua_UnityEngine_Rect.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Rect.get_min);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Rect.<>f__mg$cache11;
		if (Lua_UnityEngine_Rect.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Rect.set_min);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_Rect.<>f__mg$cache12, true);
		string name7 = "max";
		if (Lua_UnityEngine_Rect.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Rect.get_max);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Rect.<>f__mg$cache13;
		if (Lua_UnityEngine_Rect.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Rect.set_max);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_Rect.<>f__mg$cache14, true);
		string name8 = "width";
		if (Lua_UnityEngine_Rect.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Rect.get_width);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Rect.<>f__mg$cache15;
		if (Lua_UnityEngine_Rect.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Rect.set_width);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_Rect.<>f__mg$cache16, true);
		string name9 = "height";
		if (Lua_UnityEngine_Rect.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Rect.get_height);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Rect.<>f__mg$cache17;
		if (Lua_UnityEngine_Rect.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Rect.set_height);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_Rect.<>f__mg$cache18, true);
		string name10 = "size";
		if (Lua_UnityEngine_Rect.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Rect.get_size);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Rect.<>f__mg$cache19;
		if (Lua_UnityEngine_Rect.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Rect.set_size);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_Rect.<>f__mg$cache1A, true);
		string name11 = "xMin";
		if (Lua_UnityEngine_Rect.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Rect.get_xMin);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Rect.<>f__mg$cache1B;
		if (Lua_UnityEngine_Rect.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Rect.set_xMin);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_Rect.<>f__mg$cache1C, true);
		string name12 = "yMin";
		if (Lua_UnityEngine_Rect.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Rect.get_yMin);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Rect.<>f__mg$cache1D;
		if (Lua_UnityEngine_Rect.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Rect.set_yMin);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_Rect.<>f__mg$cache1E, true);
		string name13 = "xMax";
		if (Lua_UnityEngine_Rect.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Rect.get_xMax);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Rect.<>f__mg$cache1F;
		if (Lua_UnityEngine_Rect.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Rect.set_xMax);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_Rect.<>f__mg$cache20, true);
		string name14 = "yMax";
		if (Lua_UnityEngine_Rect.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Rect.get_yMax);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Rect.<>f__mg$cache21;
		if (Lua_UnityEngine_Rect.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Rect.set_yMax);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_Rect.<>f__mg$cache22, true);
		if (Lua_UnityEngine_Rect.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Rect.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Rect.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rect.<>f__mg$cache23, typeof(Rect), typeof(ValueType));
	}

	// Token: 0x040196FA RID: 104186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196FB RID: 104187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196FC RID: 104188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196FD RID: 104189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196FE RID: 104190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196FF RID: 104191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019700 RID: 104192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019701 RID: 104193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019702 RID: 104194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019703 RID: 104195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019704 RID: 104196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019705 RID: 104197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019706 RID: 104198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019707 RID: 104199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019708 RID: 104200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019709 RID: 104201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401970A RID: 104202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401970B RID: 104203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401970C RID: 104204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401970D RID: 104205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401970E RID: 104206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401970F RID: 104207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019710 RID: 104208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019711 RID: 104209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019712 RID: 104210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019713 RID: 104211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019714 RID: 104212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019715 RID: 104213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019716 RID: 104214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019717 RID: 104215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019718 RID: 104216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019719 RID: 104217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401971A RID: 104218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401971B RID: 104219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401971C RID: 104220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401971D RID: 104221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
