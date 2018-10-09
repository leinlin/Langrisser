using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001820 RID: 6176
[Preserve]
public class Lua_UnityEngine_UI_FontData : LuaObject
{
	// Token: 0x0602402E RID: 147502 RVA: 0x00CA3EE0 File Offset: 0x00CA20E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FontData o = new FontData();
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

	// Token: 0x0602402F RID: 147503 RVA: 0x00CA3F28 File Offset: 0x00CA2128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultFontData(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, FontData.defaultFontData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024030 RID: 147504 RVA: 0x00CA3F70 File Offset: 0x00CA2170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_font(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.font);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024031 RID: 147505 RVA: 0x00CA3FC4 File Offset: 0x00CA21C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_font(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			Font font;
			LuaObject.checkType<Font>(l, 2, out font);
			fontData.font = font;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024032 RID: 147506 RVA: 0x00CA401C File Offset: 0x00CA221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontSize(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.fontSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024033 RID: 147507 RVA: 0x00CA4070 File Offset: 0x00CA2270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontSize(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			fontData.fontSize = fontSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024034 RID: 147508 RVA: 0x00CA40C8 File Offset: 0x00CA22C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)fontData.fontStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024035 RID: 147509 RVA: 0x00CA411C File Offset: 0x00CA231C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			FontStyle fontStyle;
			LuaObject.checkEnum<FontStyle>(l, 2, out fontStyle);
			fontData.fontStyle = fontStyle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024036 RID: 147510 RVA: 0x00CA4174 File Offset: 0x00CA2374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bestFit(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.bestFit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024037 RID: 147511 RVA: 0x00CA41C8 File Offset: 0x00CA23C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bestFit(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			bool bestFit;
			LuaObject.checkType(l, 2, out bestFit);
			fontData.bestFit = bestFit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024038 RID: 147512 RVA: 0x00CA4220 File Offset: 0x00CA2420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minSize(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.minSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024039 RID: 147513 RVA: 0x00CA4274 File Offset: 0x00CA2474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_minSize(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			int minSize;
			LuaObject.checkType(l, 2, out minSize);
			fontData.minSize = minSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602403A RID: 147514 RVA: 0x00CA42CC File Offset: 0x00CA24CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxSize(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.maxSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602403B RID: 147515 RVA: 0x00CA4320 File Offset: 0x00CA2520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_maxSize(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			int maxSize;
			LuaObject.checkType(l, 2, out maxSize);
			fontData.maxSize = maxSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602403C RID: 147516 RVA: 0x00CA4378 File Offset: 0x00CA2578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_alignment(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)fontData.alignment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602403D RID: 147517 RVA: 0x00CA43CC File Offset: 0x00CA25CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignment(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			TextAnchor alignment;
			LuaObject.checkEnum<TextAnchor>(l, 2, out alignment);
			fontData.alignment = alignment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602403E RID: 147518 RVA: 0x00CA4424 File Offset: 0x00CA2624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alignByGeometry(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.alignByGeometry);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602403F RID: 147519 RVA: 0x00CA4478 File Offset: 0x00CA2678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignByGeometry(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			bool alignByGeometry;
			LuaObject.checkType(l, 2, out alignByGeometry);
			fontData.alignByGeometry = alignByGeometry;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024040 RID: 147520 RVA: 0x00CA44D0 File Offset: 0x00CA26D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_richText(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.richText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024041 RID: 147521 RVA: 0x00CA4524 File Offset: 0x00CA2724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_richText(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			bool richText;
			LuaObject.checkType(l, 2, out richText);
			fontData.richText = richText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024042 RID: 147522 RVA: 0x00CA457C File Offset: 0x00CA277C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalOverflow(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)fontData.horizontalOverflow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024043 RID: 147523 RVA: 0x00CA45D0 File Offset: 0x00CA27D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontalOverflow(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			HorizontalWrapMode horizontalOverflow;
			LuaObject.checkEnum<HorizontalWrapMode>(l, 2, out horizontalOverflow);
			fontData.horizontalOverflow = horizontalOverflow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024044 RID: 147524 RVA: 0x00CA4628 File Offset: 0x00CA2828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalOverflow(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)fontData.verticalOverflow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024045 RID: 147525 RVA: 0x00CA467C File Offset: 0x00CA287C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalOverflow(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			VerticalWrapMode verticalOverflow;
			LuaObject.checkEnum<VerticalWrapMode>(l, 2, out verticalOverflow);
			fontData.verticalOverflow = verticalOverflow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024046 RID: 147526 RVA: 0x00CA46D4 File Offset: 0x00CA28D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fontData.lineSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024047 RID: 147527 RVA: 0x00CA4728 File Offset: 0x00CA2928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			FontData fontData = (FontData)LuaObject.checkSelf(l);
			float lineSpacing;
			LuaObject.checkType(l, 2, out lineSpacing);
			fontData.lineSpacing = lineSpacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024048 RID: 147528 RVA: 0x00CA4780 File Offset: 0x00CA2980
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.FontData");
		string name = "defaultFontData";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_defaultFontData);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_FontData.<>f__mg$cache0, null, false);
		string name2 = "font";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_font);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_FontData.<>f__mg$cache1;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_font);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_UI_FontData.<>f__mg$cache2, true);
		string name3 = "fontSize";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_fontSize);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_FontData.<>f__mg$cache3;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_fontSize);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_UI_FontData.<>f__mg$cache4, true);
		string name4 = "fontStyle";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_fontStyle);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_FontData.<>f__mg$cache5;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_fontStyle);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_UI_FontData.<>f__mg$cache6, true);
		string name5 = "bestFit";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_bestFit);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_FontData.<>f__mg$cache7;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_bestFit);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_UI_FontData.<>f__mg$cache8, true);
		string name6 = "minSize";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_minSize);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_FontData.<>f__mg$cache9;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_minSize);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_UI_FontData.<>f__mg$cacheA, true);
		string name7 = "maxSize";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_maxSize);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_FontData.<>f__mg$cacheB;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_maxSize);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_UI_FontData.<>f__mg$cacheC, true);
		string name8 = "alignment";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_alignment);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_FontData.<>f__mg$cacheD;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_alignment);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_UI_FontData.<>f__mg$cacheE, true);
		string name9 = "alignByGeometry";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_alignByGeometry);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_FontData.<>f__mg$cacheF;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_alignByGeometry);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_UI_FontData.<>f__mg$cache10, true);
		string name10 = "richText";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_richText);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_FontData.<>f__mg$cache11;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_richText);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_UI_FontData.<>f__mg$cache12, true);
		string name11 = "horizontalOverflow";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_horizontalOverflow);
		}
		LuaCSFunction get10 = Lua_UnityEngine_UI_FontData.<>f__mg$cache13;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_horizontalOverflow);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_UI_FontData.<>f__mg$cache14, true);
		string name12 = "verticalOverflow";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_verticalOverflow);
		}
		LuaCSFunction get11 = Lua_UnityEngine_UI_FontData.<>f__mg$cache15;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_verticalOverflow);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_UI_FontData.<>f__mg$cache16, true);
		string name13 = "lineSpacing";
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.get_lineSpacing);
		}
		LuaCSFunction get12 = Lua_UnityEngine_UI_FontData.<>f__mg$cache17;
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.set_lineSpacing);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_UI_FontData.<>f__mg$cache18, true);
		if (Lua_UnityEngine_UI_FontData.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_FontData.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_FontData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_FontData.<>f__mg$cache19, typeof(FontData));
	}

	// Token: 0x04019C4C RID: 105548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C4D RID: 105549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C4E RID: 105550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C4F RID: 105551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C50 RID: 105552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C51 RID: 105553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C52 RID: 105554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C53 RID: 105555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C54 RID: 105556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C55 RID: 105557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019C56 RID: 105558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019C57 RID: 105559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019C58 RID: 105560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019C59 RID: 105561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019C5A RID: 105562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019C5B RID: 105563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019C5C RID: 105564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019C5D RID: 105565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019C5E RID: 105566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019C5F RID: 105567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019C60 RID: 105568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019C61 RID: 105569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019C62 RID: 105570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019C63 RID: 105571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019C64 RID: 105572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019C65 RID: 105573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
