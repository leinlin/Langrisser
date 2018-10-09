using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001669 RID: 5737
[Preserve]
public class Lua_UnityEngine_ColorUtility : LuaObject
{
	// Token: 0x06022ED7 RID: 143063 RVA: 0x00C14814 File Offset: 0x00C12A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ColorUtility o = new ColorUtility();
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

	// Token: 0x06022ED8 RID: 143064 RVA: 0x00C1485C File Offset: 0x00C12A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryParseHtmlString_s(IntPtr l)
	{
		int result;
		try
		{
			string htmlString;
			LuaObject.checkType(l, 1, out htmlString);
			Color o;
			bool b = ColorUtility.TryParseHtmlString(htmlString, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ED9 RID: 143065 RVA: 0x00C148BC File Offset: 0x00C12ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToHtmlStringRGB_s(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			string s = ColorUtility.ToHtmlStringRGB(color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EDA RID: 143066 RVA: 0x00C14910 File Offset: 0x00C12B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToHtmlStringRGBA_s(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			string s = ColorUtility.ToHtmlStringRGBA(color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EDB RID: 143067 RVA: 0x00C14964 File Offset: 0x00C12B64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ColorUtility");
		if (Lua_UnityEngine_ColorUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ColorUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ColorUtility.TryParseHtmlString_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ColorUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_ColorUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ColorUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ColorUtility.ToHtmlStringRGB_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ColorUtility.<>f__mg$cache1);
		if (Lua_UnityEngine_ColorUtility.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ColorUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ColorUtility.ToHtmlStringRGBA_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ColorUtility.<>f__mg$cache2);
		if (Lua_UnityEngine_ColorUtility.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ColorUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ColorUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ColorUtility.<>f__mg$cache3, typeof(ColorUtility));
	}

	// Token: 0x04018E63 RID: 101987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E64 RID: 101988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E65 RID: 101989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E66 RID: 101990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
