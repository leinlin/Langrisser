using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200176E RID: 5998
[Preserve]
public class Lua_UnityEngine_RectInt : LuaObject
{
	// Token: 0x0602399C RID: 145820 RVA: 0x00C705F8 File Offset: 0x00C6E7F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				int xMin;
				LuaObject.checkType(l, 2, out xMin);
				int yMin;
				LuaObject.checkType(l, 3, out yMin);
				int width;
				LuaObject.checkType(l, 4, out width);
				int height;
				LuaObject.checkType(l, 5, out height);
				RectInt rectInt = new RectInt(xMin, yMin, width, height);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rectInt);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2Int position;
				LuaObject.checkValueType<Vector2Int>(l, 2, out position);
				Vector2Int size;
				LuaObject.checkValueType<Vector2Int>(l, 3, out size);
				RectInt rectInt = new RectInt(position, size);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rectInt);
				result = 2;
			}
			else if (num == 0)
			{
				RectInt rectInt = default(RectInt);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, rectInt);
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

	// Token: 0x0602399D RID: 145821 RVA: 0x00C70704 File Offset: 0x00C6E904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMinMax(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			Vector2Int minPosition;
			LuaObject.checkValueType<Vector2Int>(l, 2, out minPosition);
			Vector2Int maxPosition;
			LuaObject.checkValueType<Vector2Int>(l, 3, out maxPosition);
			rectInt.SetMinMax(minPosition, maxPosition);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, rectInt);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602399E RID: 145822 RVA: 0x00C70774 File Offset: 0x00C6E974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClampToBounds(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			RectInt bounds;
			LuaObject.checkValueType<RectInt>(l, 2, out bounds);
			rectInt.ClampToBounds(bounds);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, rectInt);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602399F RID: 145823 RVA: 0x00C707D8 File Offset: 0x00C6E9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			Vector2Int position;
			LuaObject.checkValueType<Vector2Int>(l, 2, out position);
			bool b = rectInt.Contains(position);
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

	// Token: 0x060239A0 RID: 145824 RVA: 0x00C70838 File Offset: 0x00C6EA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A1 RID: 145825 RVA: 0x00C7088C File Offset: 0x00C6EA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int x;
			LuaObject.checkType(l, 2, out x);
			rectInt.x = x;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A2 RID: 145826 RVA: 0x00C708F0 File Offset: 0x00C6EAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A3 RID: 145827 RVA: 0x00C70944 File Offset: 0x00C6EB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int y;
			LuaObject.checkType(l, 2, out y);
			rectInt.y = y;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A4 RID: 145828 RVA: 0x00C709A8 File Offset: 0x00C6EBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A5 RID: 145829 RVA: 0x00C709FC File Offset: 0x00C6EBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A6 RID: 145830 RVA: 0x00C70A54 File Offset: 0x00C6EC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			Vector2Int min;
			LuaObject.checkValueType<Vector2Int>(l, 2, out min);
			rectInt.min = min;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A7 RID: 145831 RVA: 0x00C70AB8 File Offset: 0x00C6ECB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A8 RID: 145832 RVA: 0x00C70B10 File Offset: 0x00C6ED10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			Vector2Int max;
			LuaObject.checkValueType<Vector2Int>(l, 2, out max);
			rectInt.max = max;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239A9 RID: 145833 RVA: 0x00C70B74 File Offset: 0x00C6ED74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239AA RID: 145834 RVA: 0x00C70BC8 File Offset: 0x00C6EDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int width;
			LuaObject.checkType(l, 2, out width);
			rectInt.width = width;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239AB RID: 145835 RVA: 0x00C70C2C File Offset: 0x00C6EE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239AC RID: 145836 RVA: 0x00C70C80 File Offset: 0x00C6EE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int height;
			LuaObject.checkType(l, 2, out height);
			rectInt.height = height;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239AD RID: 145837 RVA: 0x00C70CE4 File Offset: 0x00C6EEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xMin(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.xMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239AE RID: 145838 RVA: 0x00C70D38 File Offset: 0x00C6EF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMin(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int xMin;
			LuaObject.checkType(l, 2, out xMin);
			rectInt.xMin = xMin;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239AF RID: 145839 RVA: 0x00C70D9C File Offset: 0x00C6EF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMin(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.yMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B0 RID: 145840 RVA: 0x00C70DF0 File Offset: 0x00C6EFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMin(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int yMin;
			LuaObject.checkType(l, 2, out yMin);
			rectInt.yMin = yMin;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B1 RID: 145841 RVA: 0x00C70E54 File Offset: 0x00C6F054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_xMax(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.xMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B2 RID: 145842 RVA: 0x00C70EA8 File Offset: 0x00C6F0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMax(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int xMax;
			LuaObject.checkType(l, 2, out xMax);
			rectInt.xMax = xMax;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B3 RID: 145843 RVA: 0x00C70F0C File Offset: 0x00C6F10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMax(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.yMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B4 RID: 145844 RVA: 0x00C70F60 File Offset: 0x00C6F160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMax(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			int yMax;
			LuaObject.checkType(l, 2, out yMax);
			rectInt.yMax = yMax;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B5 RID: 145845 RVA: 0x00C70FC4 File Offset: 0x00C6F1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B6 RID: 145846 RVA: 0x00C7101C File Offset: 0x00C6F21C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			Vector2Int position;
			LuaObject.checkValueType<Vector2Int>(l, 2, out position);
			rectInt.position = position;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B7 RID: 145847 RVA: 0x00C71080 File Offset: 0x00C6F280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B8 RID: 145848 RVA: 0x00C710D8 File Offset: 0x00C6F2D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			Vector2Int size;
			LuaObject.checkValueType<Vector2Int>(l, 2, out size);
			rectInt.size = size;
			LuaObject.setBack(l, rectInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239B9 RID: 145849 RVA: 0x00C7113C File Offset: 0x00C6F33C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_allPositionsWithin(IntPtr l)
	{
		int result;
		try
		{
			RectInt rectInt;
			LuaObject.checkValueType<RectInt>(l, 1, out rectInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectInt.allPositionsWithin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239BA RID: 145850 RVA: 0x00C71194 File Offset: 0x00C6F394
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RectInt");
		if (Lua_UnityEngine_RectInt.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RectInt.SetMinMax);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectInt.<>f__mg$cache0);
		if (Lua_UnityEngine_RectInt.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RectInt.ClampToBounds);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectInt.<>f__mg$cache1);
		if (Lua_UnityEngine_RectInt.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RectInt.Contains);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectInt.<>f__mg$cache2);
		string name = "x";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_RectInt.<>f__mg$cache3;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_x);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RectInt.<>f__mg$cache4, true);
		string name2 = "y";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RectInt.<>f__mg$cache5;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_y);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RectInt.<>f__mg$cache6, true);
		string name3 = "center";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_center);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_RectInt.<>f__mg$cache7, null, true);
		string name4 = "min";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_min);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RectInt.<>f__mg$cache8;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_min);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_RectInt.<>f__mg$cache9, true);
		string name5 = "max";
		if (Lua_UnityEngine_RectInt.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RectInt.get_max);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RectInt.<>f__mg$cacheA;
		if (Lua_UnityEngine_RectInt.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RectInt.set_max);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_RectInt.<>f__mg$cacheB, true);
		string name6 = "width";
		if (Lua_UnityEngine_RectInt.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RectInt.get_width);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RectInt.<>f__mg$cacheC;
		if (Lua_UnityEngine_RectInt.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RectInt.set_width);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_RectInt.<>f__mg$cacheD, true);
		string name7 = "height";
		if (Lua_UnityEngine_RectInt.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RectInt.get_height);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RectInt.<>f__mg$cacheE;
		if (Lua_UnityEngine_RectInt.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RectInt.set_height);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_RectInt.<>f__mg$cacheF, true);
		string name8 = "xMin";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_xMin);
		}
		LuaCSFunction get7 = Lua_UnityEngine_RectInt.<>f__mg$cache10;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_xMin);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_RectInt.<>f__mg$cache11, true);
		string name9 = "yMin";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_yMin);
		}
		LuaCSFunction get8 = Lua_UnityEngine_RectInt.<>f__mg$cache12;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_yMin);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_RectInt.<>f__mg$cache13, true);
		string name10 = "xMax";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_xMax);
		}
		LuaCSFunction get9 = Lua_UnityEngine_RectInt.<>f__mg$cache14;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_xMax);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_RectInt.<>f__mg$cache15, true);
		string name11 = "yMax";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_yMax);
		}
		LuaCSFunction get10 = Lua_UnityEngine_RectInt.<>f__mg$cache16;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_yMax);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_RectInt.<>f__mg$cache17, true);
		string name12 = "position";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_RectInt.get_position);
		}
		LuaCSFunction get11 = Lua_UnityEngine_RectInt.<>f__mg$cache18;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_RectInt.set_position);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_RectInt.<>f__mg$cache19, true);
		string name13 = "size";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_RectInt.get_size);
		}
		LuaCSFunction get12 = Lua_UnityEngine_RectInt.<>f__mg$cache1A;
		if (Lua_UnityEngine_RectInt.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_RectInt.set_size);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_RectInt.<>f__mg$cache1B, true);
		string name14 = "allPositionsWithin";
		if (Lua_UnityEngine_RectInt.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_RectInt.get_allPositionsWithin);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_RectInt.<>f__mg$cache1C, null, true);
		if (Lua_UnityEngine_RectInt.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_RectInt.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_RectInt.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RectInt.<>f__mg$cache1D, typeof(RectInt), typeof(ValueType));
	}

	// Token: 0x0401971E RID: 104222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401971F RID: 104223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019720 RID: 104224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019721 RID: 104225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019722 RID: 104226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019723 RID: 104227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019724 RID: 104228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019725 RID: 104229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019726 RID: 104230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019727 RID: 104231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019728 RID: 104232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019729 RID: 104233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401972A RID: 104234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401972B RID: 104235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401972C RID: 104236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401972D RID: 104237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401972E RID: 104238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401972F RID: 104239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019730 RID: 104240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019731 RID: 104241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019732 RID: 104242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019733 RID: 104243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019734 RID: 104244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019735 RID: 104245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019736 RID: 104246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019737 RID: 104247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019738 RID: 104248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019739 RID: 104249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401973A RID: 104250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401973B RID: 104251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
