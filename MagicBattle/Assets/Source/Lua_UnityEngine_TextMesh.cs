using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017F7 RID: 6135
[Preserve]
public class Lua_UnityEngine_TextMesh : LuaObject
{
	// Token: 0x06023E6A RID: 147050 RVA: 0x00C967C8 File Offset: 0x00C949C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E6B RID: 147051 RVA: 0x00C9681C File Offset: 0x00C94A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_text(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			textMesh.text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E6C RID: 147052 RVA: 0x00C96874 File Offset: 0x00C94A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_font(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.font);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E6D RID: 147053 RVA: 0x00C968C8 File Offset: 0x00C94AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_font(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			Font font;
			LuaObject.checkType<Font>(l, 2, out font);
			textMesh.font = font;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E6E RID: 147054 RVA: 0x00C96920 File Offset: 0x00C94B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontSize(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.fontSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E6F RID: 147055 RVA: 0x00C96974 File Offset: 0x00C94B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontSize(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			textMesh.fontSize = fontSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E70 RID: 147056 RVA: 0x00C969CC File Offset: 0x00C94BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textMesh.fontStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E71 RID: 147057 RVA: 0x00C96A20 File Offset: 0x00C94C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			FontStyle fontStyle;
			LuaObject.checkEnum<FontStyle>(l, 2, out fontStyle);
			textMesh.fontStyle = fontStyle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E72 RID: 147058 RVA: 0x00C96A78 File Offset: 0x00C94C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_offsetZ(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.offsetZ);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E73 RID: 147059 RVA: 0x00C96ACC File Offset: 0x00C94CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_offsetZ(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			float offsetZ;
			LuaObject.checkType(l, 2, out offsetZ);
			textMesh.offsetZ = offsetZ;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E74 RID: 147060 RVA: 0x00C96B24 File Offset: 0x00C94D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alignment(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textMesh.alignment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E75 RID: 147061 RVA: 0x00C96B78 File Offset: 0x00C94D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignment(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			TextAlignment alignment;
			LuaObject.checkEnum<TextAlignment>(l, 2, out alignment);
			textMesh.alignment = alignment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E76 RID: 147062 RVA: 0x00C96BD0 File Offset: 0x00C94DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anchor(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textMesh.anchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E77 RID: 147063 RVA: 0x00C96C24 File Offset: 0x00C94E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anchor(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			TextAnchor anchor;
			LuaObject.checkEnum<TextAnchor>(l, 2, out anchor);
			textMesh.anchor = anchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E78 RID: 147064 RVA: 0x00C96C7C File Offset: 0x00C94E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_characterSize(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.characterSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E79 RID: 147065 RVA: 0x00C96CD0 File Offset: 0x00C94ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_characterSize(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			float characterSize;
			LuaObject.checkType(l, 2, out characterSize);
			textMesh.characterSize = characterSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E7A RID: 147066 RVA: 0x00C96D28 File Offset: 0x00C94F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.lineSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E7B RID: 147067 RVA: 0x00C96D7C File Offset: 0x00C94F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			float lineSpacing;
			LuaObject.checkType(l, 2, out lineSpacing);
			textMesh.lineSpacing = lineSpacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E7C RID: 147068 RVA: 0x00C96DD4 File Offset: 0x00C94FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tabSize(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.tabSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E7D RID: 147069 RVA: 0x00C96E28 File Offset: 0x00C95028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tabSize(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			float tabSize;
			LuaObject.checkType(l, 2, out tabSize);
			textMesh.tabSize = tabSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E7E RID: 147070 RVA: 0x00C96E80 File Offset: 0x00C95080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_richText(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.richText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E7F RID: 147071 RVA: 0x00C96ED4 File Offset: 0x00C950D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_richText(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			bool richText;
			LuaObject.checkType(l, 2, out richText);
			textMesh.richText = richText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E80 RID: 147072 RVA: 0x00C96F2C File Offset: 0x00C9512C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textMesh.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E81 RID: 147073 RVA: 0x00C96F80 File Offset: 0x00C95180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			TextMesh textMesh = (TextMesh)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			textMesh.color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E82 RID: 147074 RVA: 0x00C96FD8 File Offset: 0x00C951D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.TextMesh");
		string name = "text";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_text);
		}
		LuaCSFunction get = Lua_UnityEngine_TextMesh.<>f__mg$cache0;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_text);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_TextMesh.<>f__mg$cache1, true);
		string name2 = "font";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_font);
		}
		LuaCSFunction get2 = Lua_UnityEngine_TextMesh.<>f__mg$cache2;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_font);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_TextMesh.<>f__mg$cache3, true);
		string name3 = "fontSize";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_fontSize);
		}
		LuaCSFunction get3 = Lua_UnityEngine_TextMesh.<>f__mg$cache4;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_fontSize);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_TextMesh.<>f__mg$cache5, true);
		string name4 = "fontStyle";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_fontStyle);
		}
		LuaCSFunction get4 = Lua_UnityEngine_TextMesh.<>f__mg$cache6;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_fontStyle);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_TextMesh.<>f__mg$cache7, true);
		string name5 = "offsetZ";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_offsetZ);
		}
		LuaCSFunction get5 = Lua_UnityEngine_TextMesh.<>f__mg$cache8;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_offsetZ);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_TextMesh.<>f__mg$cache9, true);
		string name6 = "alignment";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_alignment);
		}
		LuaCSFunction get6 = Lua_UnityEngine_TextMesh.<>f__mg$cacheA;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_alignment);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_TextMesh.<>f__mg$cacheB, true);
		string name7 = "anchor";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_anchor);
		}
		LuaCSFunction get7 = Lua_UnityEngine_TextMesh.<>f__mg$cacheC;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_anchor);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_TextMesh.<>f__mg$cacheD, true);
		string name8 = "characterSize";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_characterSize);
		}
		LuaCSFunction get8 = Lua_UnityEngine_TextMesh.<>f__mg$cacheE;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_characterSize);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_TextMesh.<>f__mg$cacheF, true);
		string name9 = "lineSpacing";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_lineSpacing);
		}
		LuaCSFunction get9 = Lua_UnityEngine_TextMesh.<>f__mg$cache10;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_lineSpacing);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_TextMesh.<>f__mg$cache11, true);
		string name10 = "tabSize";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_tabSize);
		}
		LuaCSFunction get10 = Lua_UnityEngine_TextMesh.<>f__mg$cache12;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_tabSize);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_TextMesh.<>f__mg$cache13, true);
		string name11 = "richText";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_richText);
		}
		LuaCSFunction get11 = Lua_UnityEngine_TextMesh.<>f__mg$cache14;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_richText);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_TextMesh.<>f__mg$cache15, true);
		string name12 = "color";
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_TextMesh.get_color);
		}
		LuaCSFunction get12 = Lua_UnityEngine_TextMesh.<>f__mg$cache16;
		if (Lua_UnityEngine_TextMesh.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_TextMesh.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_TextMesh.set_color);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_TextMesh.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(TextMesh), typeof(Component));
	}

	// Token: 0x04019ADA RID: 105178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019ADB RID: 105179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019ADC RID: 105180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019ADD RID: 105181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019ADE RID: 105182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019ADF RID: 105183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019AE0 RID: 105184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019AE1 RID: 105185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019AE2 RID: 105186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019AE3 RID: 105187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019AE4 RID: 105188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019AE5 RID: 105189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019AE6 RID: 105190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019AE7 RID: 105191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019AE8 RID: 105192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019AE9 RID: 105193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019AEA RID: 105194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019AEB RID: 105195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019AEC RID: 105196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019AED RID: 105197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019AEE RID: 105198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019AEF RID: 105199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019AF0 RID: 105200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019AF1 RID: 105201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
