using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001645 RID: 5701
[Preserve]
public class Lua_UnityEngine_BoundsInt : LuaObject
{
	// Token: 0x06022C8D RID: 142477 RVA: 0x00C031C8 File Offset: 0x00C013C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 7)
			{
				int xMin;
				LuaObject.checkType(l, 2, out xMin);
				int yMin;
				LuaObject.checkType(l, 3, out yMin);
				int zMin;
				LuaObject.checkType(l, 4, out zMin);
				int sizeX;
				LuaObject.checkType(l, 5, out sizeX);
				int sizeY;
				LuaObject.checkType(l, 6, out sizeY);
				int sizeZ;
				LuaObject.checkType(l, 7, out sizeZ);
				BoundsInt boundsInt = new BoundsInt(xMin, yMin, zMin, sizeX, sizeY, sizeZ);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, boundsInt);
				result = 2;
			}
			else if (num == 3)
			{
				Vector3Int position;
				LuaObject.checkValueType<Vector3Int>(l, 2, out position);
				Vector3Int size;
				LuaObject.checkValueType<Vector3Int>(l, 3, out size);
				BoundsInt boundsInt = new BoundsInt(position, size);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, boundsInt);
				result = 2;
			}
			else if (num == 0)
			{
				BoundsInt boundsInt = default(BoundsInt);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, boundsInt);
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

	// Token: 0x06022C8E RID: 142478 RVA: 0x00C032EC File Offset: 0x00C014EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMinMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			Vector3Int minPosition;
			LuaObject.checkValueType<Vector3Int>(l, 2, out minPosition);
			Vector3Int maxPosition;
			LuaObject.checkValueType<Vector3Int>(l, 3, out maxPosition);
			boundsInt.SetMinMax(minPosition, maxPosition);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, boundsInt);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C8F RID: 142479 RVA: 0x00C0335C File Offset: 0x00C0155C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClampToBounds(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			BoundsInt bounds;
			LuaObject.checkValueType<BoundsInt>(l, 2, out bounds);
			boundsInt.ClampToBounds(bounds);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, boundsInt);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C90 RID: 142480 RVA: 0x00C033C0 File Offset: 0x00C015C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			Vector3Int position;
			LuaObject.checkValueType<Vector3Int>(l, 2, out position);
			bool b = boundsInt.Contains(position);
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

	// Token: 0x06022C91 RID: 142481 RVA: 0x00C03420 File Offset: 0x00C01620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt lhs;
			LuaObject.checkValueType<BoundsInt>(l, 1, out lhs);
			BoundsInt rhs;
			LuaObject.checkValueType<BoundsInt>(l, 2, out rhs);
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

	// Token: 0x06022C92 RID: 142482 RVA: 0x00C03480 File Offset: 0x00C01680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt lhs;
			LuaObject.checkValueType<BoundsInt>(l, 1, out lhs);
			BoundsInt rhs;
			LuaObject.checkValueType<BoundsInt>(l, 2, out rhs);
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

	// Token: 0x06022C93 RID: 142483 RVA: 0x00C034E0 File Offset: 0x00C016E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_x(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C94 RID: 142484 RVA: 0x00C03534 File Offset: 0x00C01734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_x(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int x;
			LuaObject.checkType(l, 2, out x);
			boundsInt.x = x;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C95 RID: 142485 RVA: 0x00C03598 File Offset: 0x00C01798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_y(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C96 RID: 142486 RVA: 0x00C035EC File Offset: 0x00C017EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_y(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int y;
			LuaObject.checkType(l, 2, out y);
			boundsInt.y = y;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C97 RID: 142487 RVA: 0x00C03650 File Offset: 0x00C01850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_z(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.z);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C98 RID: 142488 RVA: 0x00C036A4 File Offset: 0x00C018A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_z(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int z;
			LuaObject.checkType(l, 2, out z);
			boundsInt.z = z;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C99 RID: 142489 RVA: 0x00C03708 File Offset: 0x00C01908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C9A RID: 142490 RVA: 0x00C0375C File Offset: 0x00C0195C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C9B RID: 142491 RVA: 0x00C037B4 File Offset: 0x00C019B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			Vector3Int min;
			LuaObject.checkValueType<Vector3Int>(l, 2, out min);
			boundsInt.min = min;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C9C RID: 142492 RVA: 0x00C03818 File Offset: 0x00C01A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C9D RID: 142493 RVA: 0x00C03870 File Offset: 0x00C01A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			Vector3Int max;
			LuaObject.checkValueType<Vector3Int>(l, 2, out max);
			boundsInt.max = max;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C9E RID: 142494 RVA: 0x00C038D4 File Offset: 0x00C01AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xMin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.xMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C9F RID: 142495 RVA: 0x00C03928 File Offset: 0x00C01B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int xMin;
			LuaObject.checkType(l, 2, out xMin);
			boundsInt.xMin = xMin;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA0 RID: 142496 RVA: 0x00C0398C File Offset: 0x00C01B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.yMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA1 RID: 142497 RVA: 0x00C039E0 File Offset: 0x00C01BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int yMin;
			LuaObject.checkType(l, 2, out yMin);
			boundsInt.yMin = yMin;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA2 RID: 142498 RVA: 0x00C03A44 File Offset: 0x00C01C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zMin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.zMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA3 RID: 142499 RVA: 0x00C03A98 File Offset: 0x00C01C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_zMin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int zMin;
			LuaObject.checkType(l, 2, out zMin);
			boundsInt.zMin = zMin;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA4 RID: 142500 RVA: 0x00C03AFC File Offset: 0x00C01CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.xMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA5 RID: 142501 RVA: 0x00C03B50 File Offset: 0x00C01D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int xMax;
			LuaObject.checkType(l, 2, out xMax);
			boundsInt.xMax = xMax;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA6 RID: 142502 RVA: 0x00C03BB4 File Offset: 0x00C01DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.yMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA7 RID: 142503 RVA: 0x00C03C08 File Offset: 0x00C01E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int yMax;
			LuaObject.checkType(l, 2, out yMax);
			boundsInt.yMax = yMax;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA8 RID: 142504 RVA: 0x00C03C6C File Offset: 0x00C01E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.zMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CA9 RID: 142505 RVA: 0x00C03CC0 File Offset: 0x00C01EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_zMax(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			int zMax;
			LuaObject.checkType(l, 2, out zMax);
			boundsInt.zMax = zMax;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CAA RID: 142506 RVA: 0x00C03D24 File Offset: 0x00C01F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CAB RID: 142507 RVA: 0x00C03D7C File Offset: 0x00C01F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			Vector3Int position;
			LuaObject.checkValueType<Vector3Int>(l, 2, out position);
			boundsInt.position = position;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CAC RID: 142508 RVA: 0x00C03DE0 File Offset: 0x00C01FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CAD RID: 142509 RVA: 0x00C03E38 File Offset: 0x00C02038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			Vector3Int size;
			LuaObject.checkValueType<Vector3Int>(l, 2, out size);
			boundsInt.size = size;
			LuaObject.setBack(l, boundsInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CAE RID: 142510 RVA: 0x00C03E9C File Offset: 0x00C0209C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allPositionsWithin(IntPtr l)
	{
		int result;
		try
		{
			BoundsInt boundsInt;
			LuaObject.checkValueType<BoundsInt>(l, 1, out boundsInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundsInt.allPositionsWithin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CAF RID: 142511 RVA: 0x00C03EF4 File Offset: 0x00C020F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BoundsInt");
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.SetMinMax);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoundsInt.<>f__mg$cache0);
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.ClampToBounds);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoundsInt.<>f__mg$cache1);
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.Contains);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoundsInt.<>f__mg$cache2);
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoundsInt.<>f__mg$cache3);
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoundsInt.<>f__mg$cache4);
		string name = "x";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_x);
		}
		LuaCSFunction get = Lua_UnityEngine_BoundsInt.<>f__mg$cache5;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_x);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BoundsInt.<>f__mg$cache6, true);
		string name2 = "y";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_y);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BoundsInt.<>f__mg$cache7;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_y);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BoundsInt.<>f__mg$cache8, true);
		string name3 = "z";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_z);
		}
		LuaCSFunction get3 = Lua_UnityEngine_BoundsInt.<>f__mg$cache9;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_z);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_BoundsInt.<>f__mg$cacheA, true);
		string name4 = "center";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_center);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_BoundsInt.<>f__mg$cacheB, null, true);
		string name5 = "min";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_min);
		}
		LuaCSFunction get4 = Lua_UnityEngine_BoundsInt.<>f__mg$cacheC;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_min);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_BoundsInt.<>f__mg$cacheD, true);
		string name6 = "max";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_max);
		}
		LuaCSFunction get5 = Lua_UnityEngine_BoundsInt.<>f__mg$cacheE;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_max);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_BoundsInt.<>f__mg$cacheF, true);
		string name7 = "xMin";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_xMin);
		}
		LuaCSFunction get6 = Lua_UnityEngine_BoundsInt.<>f__mg$cache10;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_xMin);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_BoundsInt.<>f__mg$cache11, true);
		string name8 = "yMin";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_yMin);
		}
		LuaCSFunction get7 = Lua_UnityEngine_BoundsInt.<>f__mg$cache12;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_yMin);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_BoundsInt.<>f__mg$cache13, true);
		string name9 = "zMin";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_zMin);
		}
		LuaCSFunction get8 = Lua_UnityEngine_BoundsInt.<>f__mg$cache14;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_zMin);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_BoundsInt.<>f__mg$cache15, true);
		string name10 = "xMax";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_xMax);
		}
		LuaCSFunction get9 = Lua_UnityEngine_BoundsInt.<>f__mg$cache16;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_xMax);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_BoundsInt.<>f__mg$cache17, true);
		string name11 = "yMax";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_yMax);
		}
		LuaCSFunction get10 = Lua_UnityEngine_BoundsInt.<>f__mg$cache18;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_yMax);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_BoundsInt.<>f__mg$cache19, true);
		string name12 = "zMax";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_zMax);
		}
		LuaCSFunction get11 = Lua_UnityEngine_BoundsInt.<>f__mg$cache1A;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_zMax);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_BoundsInt.<>f__mg$cache1B, true);
		string name13 = "position";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_position);
		}
		LuaCSFunction get12 = Lua_UnityEngine_BoundsInt.<>f__mg$cache1C;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_position);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_BoundsInt.<>f__mg$cache1D, true);
		string name14 = "size";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_size);
		}
		LuaCSFunction get13 = Lua_UnityEngine_BoundsInt.<>f__mg$cache1E;
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_BoundsInt.set_size);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_BoundsInt.<>f__mg$cache1F, true);
		string name15 = "allPositionsWithin";
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.get_allPositionsWithin);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_BoundsInt.<>f__mg$cache20, null, true);
		if (Lua_UnityEngine_BoundsInt.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_BoundsInt.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_BoundsInt.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_BoundsInt.<>f__mg$cache21, typeof(BoundsInt), typeof(ValueType));
	}

	// Token: 0x04018C61 RID: 101473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C62 RID: 101474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C63 RID: 101475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C64 RID: 101476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C65 RID: 101477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C66 RID: 101478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C67 RID: 101479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018C68 RID: 101480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018C69 RID: 101481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018C6A RID: 101482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018C6B RID: 101483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018C6C RID: 101484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018C6D RID: 101485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018C6E RID: 101486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018C6F RID: 101487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018C70 RID: 101488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018C71 RID: 101489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018C72 RID: 101490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018C73 RID: 101491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018C74 RID: 101492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018C75 RID: 101493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018C76 RID: 101494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018C77 RID: 101495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018C78 RID: 101496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018C79 RID: 101497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018C7A RID: 101498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018C7B RID: 101499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018C7C RID: 101500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018C7D RID: 101501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018C7E RID: 101502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018C7F RID: 101503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018C80 RID: 101504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018C81 RID: 101505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018C82 RID: 101506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
