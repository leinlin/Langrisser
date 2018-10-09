using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017B3 RID: 6067
[Preserve]
public class Lua_UnityEngine_Resolution : LuaObject
{
	// Token: 0x06023BE0 RID: 146400 RVA: 0x00C83590 File Offset: 0x00C81790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution = default(Resolution);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE1 RID: 146401 RVA: 0x00C835E0 File Offset: 0x00C817E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution;
			LuaObject.checkValueType<Resolution>(l, 1, out resolution);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resolution.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE2 RID: 146402 RVA: 0x00C83634 File Offset: 0x00C81834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution;
			LuaObject.checkValueType<Resolution>(l, 1, out resolution);
			int width;
			LuaObject.checkType(l, 2, out width);
			resolution.width = width;
			LuaObject.setBack(l, resolution);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE3 RID: 146403 RVA: 0x00C83698 File Offset: 0x00C81898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution;
			LuaObject.checkValueType<Resolution>(l, 1, out resolution);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resolution.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE4 RID: 146404 RVA: 0x00C836EC File Offset: 0x00C818EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution;
			LuaObject.checkValueType<Resolution>(l, 1, out resolution);
			int height;
			LuaObject.checkType(l, 2, out height);
			resolution.height = height;
			LuaObject.setBack(l, resolution);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE5 RID: 146405 RVA: 0x00C83750 File Offset: 0x00C81950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_refreshRate(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution;
			LuaObject.checkValueType<Resolution>(l, 1, out resolution);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resolution.refreshRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE6 RID: 146406 RVA: 0x00C837A4 File Offset: 0x00C819A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_refreshRate(IntPtr l)
	{
		int result;
		try
		{
			Resolution resolution;
			LuaObject.checkValueType<Resolution>(l, 1, out resolution);
			int refreshRate;
			LuaObject.checkType(l, 2, out refreshRate);
			resolution.refreshRate = refreshRate;
			LuaObject.setBack(l, resolution);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BE7 RID: 146407 RVA: 0x00C83808 File Offset: 0x00C81A08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Resolution");
		string name = "width";
		if (Lua_UnityEngine_Resolution.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Resolution.get_width);
		}
		LuaCSFunction get = Lua_UnityEngine_Resolution.<>f__mg$cache0;
		if (Lua_UnityEngine_Resolution.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Resolution.set_width);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Resolution.<>f__mg$cache1, true);
		string name2 = "height";
		if (Lua_UnityEngine_Resolution.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Resolution.get_height);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Resolution.<>f__mg$cache2;
		if (Lua_UnityEngine_Resolution.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Resolution.set_height);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Resolution.<>f__mg$cache3, true);
		string name3 = "refreshRate";
		if (Lua_UnityEngine_Resolution.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Resolution.get_refreshRate);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Resolution.<>f__mg$cache4;
		if (Lua_UnityEngine_Resolution.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Resolution.set_refreshRate);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Resolution.<>f__mg$cache5, true);
		if (Lua_UnityEngine_Resolution.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Resolution.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Resolution.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Resolution.<>f__mg$cache6, typeof(Resolution), typeof(ValueType));
	}

	// Token: 0x040198D8 RID: 104664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040198D9 RID: 104665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040198DA RID: 104666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040198DB RID: 104667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040198DC RID: 104668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040198DD RID: 104669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040198DE RID: 104670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
