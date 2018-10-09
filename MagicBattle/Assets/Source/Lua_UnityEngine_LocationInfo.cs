using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200171A RID: 5914
[Preserve]
public class Lua_UnityEngine_LocationInfo : LuaObject
{
	// Token: 0x06023521 RID: 144673 RVA: 0x00C44894 File Offset: 0x00C42A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo = default(LocationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023522 RID: 144674 RVA: 0x00C448E4 File Offset: 0x00C42AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_latitude(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo;
			LuaObject.checkValueType<LocationInfo>(l, 1, out locationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo.latitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023523 RID: 144675 RVA: 0x00C44938 File Offset: 0x00C42B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_longitude(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo;
			LuaObject.checkValueType<LocationInfo>(l, 1, out locationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo.longitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023524 RID: 144676 RVA: 0x00C4498C File Offset: 0x00C42B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_altitude(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo;
			LuaObject.checkValueType<LocationInfo>(l, 1, out locationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo.altitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023525 RID: 144677 RVA: 0x00C449E0 File Offset: 0x00C42BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_horizontalAccuracy(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo;
			LuaObject.checkValueType<LocationInfo>(l, 1, out locationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo.horizontalAccuracy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023526 RID: 144678 RVA: 0x00C44A34 File Offset: 0x00C42C34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_verticalAccuracy(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo;
			LuaObject.checkValueType<LocationInfo>(l, 1, out locationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo.verticalAccuracy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023527 RID: 144679 RVA: 0x00C44A88 File Offset: 0x00C42C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timestamp(IntPtr l)
	{
		int result;
		try
		{
			LocationInfo locationInfo;
			LuaObject.checkValueType<LocationInfo>(l, 1, out locationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationInfo.timestamp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023528 RID: 144680 RVA: 0x00C44ADC File Offset: 0x00C42CDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LocationInfo");
		string name = "latitude";
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.get_latitude);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_LocationInfo.<>f__mg$cache0, null, true);
		string name2 = "longitude";
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.get_longitude);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_LocationInfo.<>f__mg$cache1, null, true);
		string name3 = "altitude";
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.get_altitude);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_LocationInfo.<>f__mg$cache2, null, true);
		string name4 = "horizontalAccuracy";
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.get_horizontalAccuracy);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_LocationInfo.<>f__mg$cache3, null, true);
		string name5 = "verticalAccuracy";
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.get_verticalAccuracy);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_LocationInfo.<>f__mg$cache4, null, true);
		string name6 = "timestamp";
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.get_timestamp);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_LocationInfo.<>f__mg$cache5, null, true);
		if (Lua_UnityEngine_LocationInfo.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LocationInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LocationInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LocationInfo.<>f__mg$cache6, typeof(LocationInfo), typeof(ValueType));
	}

	// Token: 0x0401934B RID: 103243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401934C RID: 103244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401934D RID: 103245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401934E RID: 103246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401934F RID: 103247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019350 RID: 103248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019351 RID: 103249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
