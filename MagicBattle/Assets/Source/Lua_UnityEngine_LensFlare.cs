using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001704 RID: 5892
[Preserve]
public class Lua_UnityEngine_LensFlare : LuaObject
{
	// Token: 0x06023460 RID: 144480 RVA: 0x00C3FA84 File Offset: 0x00C3DC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_brightness(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lensFlare.brightness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023461 RID: 144481 RVA: 0x00C3FAD8 File Offset: 0x00C3DCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_brightness(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			float brightness;
			LuaObject.checkType(l, 2, out brightness);
			lensFlare.brightness = brightness;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023462 RID: 144482 RVA: 0x00C3FB30 File Offset: 0x00C3DD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fadeSpeed(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lensFlare.fadeSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023463 RID: 144483 RVA: 0x00C3FB84 File Offset: 0x00C3DD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fadeSpeed(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			float fadeSpeed;
			LuaObject.checkType(l, 2, out fadeSpeed);
			lensFlare.fadeSpeed = fadeSpeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023464 RID: 144484 RVA: 0x00C3FBDC File Offset: 0x00C3DDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lensFlare.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023465 RID: 144485 RVA: 0x00C3FC30 File Offset: 0x00C3DE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			lensFlare.color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023466 RID: 144486 RVA: 0x00C3FC88 File Offset: 0x00C3DE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flare(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lensFlare.flare);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023467 RID: 144487 RVA: 0x00C3FCDC File Offset: 0x00C3DEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flare(IntPtr l)
	{
		int result;
		try
		{
			LensFlare lensFlare = (LensFlare)LuaObject.checkSelf(l);
			Flare flare;
			LuaObject.checkType<Flare>(l, 2, out flare);
			lensFlare.flare = flare;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023468 RID: 144488 RVA: 0x00C3FD34 File Offset: 0x00C3DF34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LensFlare");
		string name = "brightness";
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LensFlare.get_brightness);
		}
		LuaCSFunction get = Lua_UnityEngine_LensFlare.<>f__mg$cache0;
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LensFlare.set_brightness);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LensFlare.<>f__mg$cache1, true);
		string name2 = "fadeSpeed";
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LensFlare.get_fadeSpeed);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LensFlare.<>f__mg$cache2;
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LensFlare.set_fadeSpeed);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LensFlare.<>f__mg$cache3, true);
		string name3 = "color";
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LensFlare.get_color);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LensFlare.<>f__mg$cache4;
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LensFlare.set_color);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_LensFlare.<>f__mg$cache5, true);
		string name4 = "flare";
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LensFlare.get_flare);
		}
		LuaCSFunction get4 = Lua_UnityEngine_LensFlare.<>f__mg$cache6;
		if (Lua_UnityEngine_LensFlare.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_LensFlare.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_LensFlare.set_flare);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_LensFlare.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(LensFlare), typeof(Behaviour));
	}

	// Token: 0x040192B6 RID: 103094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192B7 RID: 103095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192B8 RID: 103096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192B9 RID: 103097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192BA RID: 103098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040192BB RID: 103099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040192BC RID: 103100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040192BD RID: 103101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
