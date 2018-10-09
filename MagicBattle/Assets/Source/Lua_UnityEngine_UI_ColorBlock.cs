using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001817 RID: 6167
[Preserve]
public class Lua_UnityEngine_UI_ColorBlock : LuaObject
{
	// Token: 0x06023FCB RID: 147403 RVA: 0x00CA14E0 File Offset: 0x00C9F6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock = default(ColorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FCC RID: 147404 RVA: 0x00CA1530 File Offset: 0x00C9F730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock point;
			LuaObject.checkValueType<ColorBlock>(l, 1, out point);
			ColorBlock point2;
			LuaObject.checkValueType<ColorBlock>(l, 2, out point2);
			bool b = point == point2;
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

	// Token: 0x06023FCD RID: 147405 RVA: 0x00CA1590 File Offset: 0x00C9F790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock point;
			LuaObject.checkValueType<ColorBlock>(l, 1, out point);
			ColorBlock point2;
			LuaObject.checkValueType<ColorBlock>(l, 2, out point2);
			bool b = point != point2;
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

	// Token: 0x06023FCE RID: 147406 RVA: 0x00CA15F0 File Offset: 0x00C9F7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock.normalColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FCF RID: 147407 RVA: 0x00CA1644 File Offset: 0x00C9F844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normalColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			Color normalColor;
			LuaObject.checkType(l, 2, out normalColor);
			colorBlock.normalColor = normalColor;
			LuaObject.setBack(l, colorBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD0 RID: 147408 RVA: 0x00CA16A8 File Offset: 0x00C9F8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_highlightedColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock.highlightedColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD1 RID: 147409 RVA: 0x00CA16FC File Offset: 0x00C9F8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_highlightedColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			Color highlightedColor;
			LuaObject.checkType(l, 2, out highlightedColor);
			colorBlock.highlightedColor = highlightedColor;
			LuaObject.setBack(l, colorBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD2 RID: 147410 RVA: 0x00CA1760 File Offset: 0x00C9F960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pressedColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock.pressedColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD3 RID: 147411 RVA: 0x00CA17B4 File Offset: 0x00C9F9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pressedColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			Color pressedColor;
			LuaObject.checkType(l, 2, out pressedColor);
			colorBlock.pressedColor = pressedColor;
			LuaObject.setBack(l, colorBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD4 RID: 147412 RVA: 0x00CA1818 File Offset: 0x00C9FA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_disabledColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock.disabledColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD5 RID: 147413 RVA: 0x00CA186C File Offset: 0x00C9FA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_disabledColor(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			Color disabledColor;
			LuaObject.checkType(l, 2, out disabledColor);
			colorBlock.disabledColor = disabledColor;
			LuaObject.setBack(l, colorBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD6 RID: 147414 RVA: 0x00CA18D0 File Offset: 0x00C9FAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorMultiplier(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock.colorMultiplier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD7 RID: 147415 RVA: 0x00CA1924 File Offset: 0x00C9FB24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_colorMultiplier(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			float colorMultiplier;
			LuaObject.checkType(l, 2, out colorMultiplier);
			colorBlock.colorMultiplier = colorMultiplier;
			LuaObject.setBack(l, colorBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD8 RID: 147416 RVA: 0x00CA1988 File Offset: 0x00C9FB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fadeDuration(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colorBlock.fadeDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FD9 RID: 147417 RVA: 0x00CA19DC File Offset: 0x00C9FBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fadeDuration(IntPtr l)
	{
		int result;
		try
		{
			ColorBlock colorBlock;
			LuaObject.checkValueType<ColorBlock>(l, 1, out colorBlock);
			float fadeDuration;
			LuaObject.checkType(l, 2, out fadeDuration);
			colorBlock.fadeDuration = fadeDuration;
			LuaObject.setBack(l, colorBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FDA RID: 147418 RVA: 0x00CA1A40 File Offset: 0x00C9FC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultColorBlock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ColorBlock.defaultColorBlock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FDB RID: 147419 RVA: 0x00CA1A8C File Offset: 0x00C9FC8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ColorBlock");
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache1);
		string name = "normalColor";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_normalColor);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.set_normalColor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache3, true);
		string name2 = "highlightedColor";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_highlightedColor);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.set_highlightedColor);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache5, true);
		string name3 = "pressedColor";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_pressedColor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.set_pressedColor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache7, true);
		string name4 = "disabledColor";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_disabledColor);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.set_disabledColor);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cache9, true);
		string name5 = "colorMultiplier";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_colorMultiplier);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.set_colorMultiplier);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheB, true);
		string name6 = "fadeDuration";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_fadeDuration);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.set_fadeDuration);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheD, true);
		string name7 = "defaultColorBlock";
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.get_defaultColorBlock);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheE, null, false);
		if (Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_ColorBlock.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_ColorBlock.<>f__mg$cacheF, typeof(ColorBlock), typeof(ValueType));
	}

	// Token: 0x04019BFB RID: 105467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BFC RID: 105468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BFD RID: 105469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BFE RID: 105470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019BFF RID: 105471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C00 RID: 105472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C01 RID: 105473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C02 RID: 105474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C03 RID: 105475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C04 RID: 105476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019C05 RID: 105477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019C06 RID: 105478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019C07 RID: 105479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019C08 RID: 105480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019C09 RID: 105481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019C0A RID: 105482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
