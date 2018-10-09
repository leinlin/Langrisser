using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001709 RID: 5897
[Preserve]
public class Lua_UnityEngine_LightmapSettings : LuaObject
{
	// Token: 0x060234B3 RID: 144563 RVA: 0x00C41EF8 File Offset: 0x00C400F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LightmapSettings o = new LightmapSettings();
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

	// Token: 0x060234B4 RID: 144564 RVA: 0x00C41F40 File Offset: 0x00C40140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_lightmaps(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LightmapSettings.lightmaps);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B5 RID: 144565 RVA: 0x00C41F88 File Offset: 0x00C40188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmaps(IntPtr l)
	{
		int result;
		try
		{
			LightmapData[] lightmaps;
			LuaObject.checkArray<LightmapData>(l, 2, out lightmaps);
			LightmapSettings.lightmaps = lightmaps;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B6 RID: 144566 RVA: 0x00C41FD4 File Offset: 0x00C401D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_lightmapsMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)LightmapSettings.lightmapsMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B7 RID: 144567 RVA: 0x00C4201C File Offset: 0x00C4021C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_lightmapsMode(IntPtr l)
	{
		int result;
		try
		{
			LightmapsMode lightmapsMode;
			LuaObject.checkEnum<LightmapsMode>(l, 2, out lightmapsMode);
			LightmapSettings.lightmapsMode = lightmapsMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B8 RID: 144568 RVA: 0x00C42068 File Offset: 0x00C40268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightProbes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LightmapSettings.lightProbes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B9 RID: 144569 RVA: 0x00C420B0 File Offset: 0x00C402B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_lightProbes(IntPtr l)
	{
		int result;
		try
		{
			LightProbes lightProbes;
			LuaObject.checkType<LightProbes>(l, 2, out lightProbes);
			LightmapSettings.lightProbes = lightProbes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234BA RID: 144570 RVA: 0x00C420FC File Offset: 0x00C402FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LightmapSettings");
		string name = "lightmaps";
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.get_lightmaps);
		}
		LuaCSFunction get = Lua_UnityEngine_LightmapSettings.<>f__mg$cache0;
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.set_lightmaps);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LightmapSettings.<>f__mg$cache1, false);
		string name2 = "lightmapsMode";
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.get_lightmapsMode);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LightmapSettings.<>f__mg$cache2;
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.set_lightmapsMode);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LightmapSettings.<>f__mg$cache3, false);
		string name3 = "lightProbes";
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.get_lightProbes);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LightmapSettings.<>f__mg$cache4;
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.set_lightProbes);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_LightmapSettings.<>f__mg$cache5, false);
		if (Lua_UnityEngine_LightmapSettings.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LightmapSettings.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LightmapSettings.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LightmapSettings.<>f__mg$cache6, typeof(LightmapSettings), typeof(UnityEngine.Object));
	}

	// Token: 0x040192FF RID: 103167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019300 RID: 103168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019301 RID: 103169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019302 RID: 103170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019303 RID: 103171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019304 RID: 103172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019305 RID: 103173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
