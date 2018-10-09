using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001708 RID: 5896
[Preserve]
public class Lua_UnityEngine_LightmapData : LuaObject
{
	// Token: 0x060234AA RID: 144554 RVA: 0x00C41B8C File Offset: 0x00C3FD8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LightmapData o = new LightmapData();
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

	// Token: 0x060234AB RID: 144555 RVA: 0x00C41BD4 File Offset: 0x00C3FDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightmapColor(IntPtr l)
	{
		int result;
		try
		{
			LightmapData lightmapData = (LightmapData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightmapData.lightmapColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234AC RID: 144556 RVA: 0x00C41C28 File Offset: 0x00C3FE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmapColor(IntPtr l)
	{
		int result;
		try
		{
			LightmapData lightmapData = (LightmapData)LuaObject.checkSelf(l);
			Texture2D lightmapColor;
			LuaObject.checkType<Texture2D>(l, 2, out lightmapColor);
			lightmapData.lightmapColor = lightmapColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234AD RID: 144557 RVA: 0x00C41C80 File Offset: 0x00C3FE80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_lightmapDir(IntPtr l)
	{
		int result;
		try
		{
			LightmapData lightmapData = (LightmapData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightmapData.lightmapDir);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234AE RID: 144558 RVA: 0x00C41CD4 File Offset: 0x00C3FED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmapDir(IntPtr l)
	{
		int result;
		try
		{
			LightmapData lightmapData = (LightmapData)LuaObject.checkSelf(l);
			Texture2D lightmapDir;
			LuaObject.checkType<Texture2D>(l, 2, out lightmapDir);
			lightmapData.lightmapDir = lightmapDir;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234AF RID: 144559 RVA: 0x00C41D2C File Offset: 0x00C3FF2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_shadowMask(IntPtr l)
	{
		int result;
		try
		{
			LightmapData lightmapData = (LightmapData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightmapData.shadowMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B0 RID: 144560 RVA: 0x00C41D80 File Offset: 0x00C3FF80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_shadowMask(IntPtr l)
	{
		int result;
		try
		{
			LightmapData lightmapData = (LightmapData)LuaObject.checkSelf(l);
			Texture2D shadowMask;
			LuaObject.checkType<Texture2D>(l, 2, out shadowMask);
			lightmapData.shadowMask = shadowMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234B1 RID: 144561 RVA: 0x00C41DD8 File Offset: 0x00C3FFD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LightmapData");
		string name = "lightmapColor";
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LightmapData.get_lightmapColor);
		}
		LuaCSFunction get = Lua_UnityEngine_LightmapData.<>f__mg$cache0;
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LightmapData.set_lightmapColor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LightmapData.<>f__mg$cache1, true);
		string name2 = "lightmapDir";
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LightmapData.get_lightmapDir);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LightmapData.<>f__mg$cache2;
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LightmapData.set_lightmapDir);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LightmapData.<>f__mg$cache3, true);
		string name3 = "shadowMask";
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LightmapData.get_shadowMask);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LightmapData.<>f__mg$cache4;
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LightmapData.set_shadowMask);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_LightmapData.<>f__mg$cache5, true);
		if (Lua_UnityEngine_LightmapData.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LightmapData.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LightmapData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LightmapData.<>f__mg$cache6, typeof(LightmapData));
	}

	// Token: 0x040192F8 RID: 103160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192F9 RID: 103161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192FA RID: 103162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192FB RID: 103163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192FC RID: 103164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040192FD RID: 103165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040192FE RID: 103166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
