using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001863 RID: 6243
[Preserve]
public class Lua_UnityEngine_UI_Text : LuaObject
{
	// Token: 0x060242B9 RID: 148153 RVA: 0x00CB465C File Offset: 0x00CB285C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FontTextureChanged(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			text.FontTextureChanged();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242BA RID: 148154 RVA: 0x00CB46A8 File Offset: 0x00CB28A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGenerationSettings(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			Vector2 extents;
			LuaObject.checkType(l, 2, out extents);
			TextGenerationSettings generationSettings = text.GetGenerationSettings(extents);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, generationSettings);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242BB RID: 148155 RVA: 0x00CB4710 File Offset: 0x00CB2910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			text.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242BC RID: 148156 RVA: 0x00CB475C File Offset: 0x00CB295C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			text.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242BD RID: 148157 RVA: 0x00CB47A8 File Offset: 0x00CB29A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTextAnchorPivot_s(IntPtr l)
	{
		int result;
		try
		{
			TextAnchor anchor;
			LuaObject.checkEnum<TextAnchor>(l, 1, out anchor);
			Vector2 textAnchorPivot = Text.GetTextAnchorPivot(anchor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textAnchorPivot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242BE RID: 148158 RVA: 0x00CB47FC File Offset: 0x00CB29FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cachedTextGenerator(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.cachedTextGenerator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242BF RID: 148159 RVA: 0x00CB4850 File Offset: 0x00CB2A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cachedTextGeneratorForLayout(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.cachedTextGeneratorForLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C0 RID: 148160 RVA: 0x00CB48A4 File Offset: 0x00CB2AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTexture(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.mainTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C1 RID: 148161 RVA: 0x00CB48F8 File Offset: 0x00CB2AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_font(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.font);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C2 RID: 148162 RVA: 0x00CB494C File Offset: 0x00CB2B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_font(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			Font font;
			LuaObject.checkType<Font>(l, 2, out font);
			text.font = font;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C3 RID: 148163 RVA: 0x00CB49A4 File Offset: 0x00CB2BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C4 RID: 148164 RVA: 0x00CB49F8 File Offset: 0x00CB2BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_text(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			string text2;
			LuaObject.checkType(l, 2, out text2);
			text.text = text2;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C5 RID: 148165 RVA: 0x00CB4A50 File Offset: 0x00CB2C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportRichText(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.supportRichText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C6 RID: 148166 RVA: 0x00CB4AA4 File Offset: 0x00CB2CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_supportRichText(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			bool supportRichText;
			LuaObject.checkType(l, 2, out supportRichText);
			text.supportRichText = supportRichText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C7 RID: 148167 RVA: 0x00CB4AFC File Offset: 0x00CB2CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resizeTextForBestFit(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.resizeTextForBestFit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C8 RID: 148168 RVA: 0x00CB4B50 File Offset: 0x00CB2D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resizeTextForBestFit(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			bool resizeTextForBestFit;
			LuaObject.checkType(l, 2, out resizeTextForBestFit);
			text.resizeTextForBestFit = resizeTextForBestFit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242C9 RID: 148169 RVA: 0x00CB4BA8 File Offset: 0x00CB2DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resizeTextMinSize(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.resizeTextMinSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242CA RID: 148170 RVA: 0x00CB4BFC File Offset: 0x00CB2DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resizeTextMinSize(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			int resizeTextMinSize;
			LuaObject.checkType(l, 2, out resizeTextMinSize);
			text.resizeTextMinSize = resizeTextMinSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242CB RID: 148171 RVA: 0x00CB4C54 File Offset: 0x00CB2E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resizeTextMaxSize(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.resizeTextMaxSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242CC RID: 148172 RVA: 0x00CB4CA8 File Offset: 0x00CB2EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resizeTextMaxSize(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			int resizeTextMaxSize;
			LuaObject.checkType(l, 2, out resizeTextMaxSize);
			text.resizeTextMaxSize = resizeTextMaxSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242CD RID: 148173 RVA: 0x00CB4D00 File Offset: 0x00CB2F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alignment(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)text.alignment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242CE RID: 148174 RVA: 0x00CB4D54 File Offset: 0x00CB2F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignment(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			TextAnchor alignment;
			LuaObject.checkEnum<TextAnchor>(l, 2, out alignment);
			text.alignment = alignment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242CF RID: 148175 RVA: 0x00CB4DAC File Offset: 0x00CB2FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alignByGeometry(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.alignByGeometry);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D0 RID: 148176 RVA: 0x00CB4E00 File Offset: 0x00CB3000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignByGeometry(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			bool alignByGeometry;
			LuaObject.checkType(l, 2, out alignByGeometry);
			text.alignByGeometry = alignByGeometry;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D1 RID: 148177 RVA: 0x00CB4E58 File Offset: 0x00CB3058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontSize(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.fontSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D2 RID: 148178 RVA: 0x00CB4EAC File Offset: 0x00CB30AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontSize(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			text.fontSize = fontSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D3 RID: 148179 RVA: 0x00CB4F04 File Offset: 0x00CB3104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalOverflow(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)text.horizontalOverflow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D4 RID: 148180 RVA: 0x00CB4F58 File Offset: 0x00CB3158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontalOverflow(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			HorizontalWrapMode horizontalOverflow;
			LuaObject.checkEnum<HorizontalWrapMode>(l, 2, out horizontalOverflow);
			text.horizontalOverflow = horizontalOverflow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D5 RID: 148181 RVA: 0x00CB4FB0 File Offset: 0x00CB31B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalOverflow(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)text.verticalOverflow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D6 RID: 148182 RVA: 0x00CB5004 File Offset: 0x00CB3204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalOverflow(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			VerticalWrapMode verticalOverflow;
			LuaObject.checkEnum<VerticalWrapMode>(l, 2, out verticalOverflow);
			text.verticalOverflow = verticalOverflow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D7 RID: 148183 RVA: 0x00CB505C File Offset: 0x00CB325C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.lineSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D8 RID: 148184 RVA: 0x00CB50B0 File Offset: 0x00CB32B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			float lineSpacing;
			LuaObject.checkType(l, 2, out lineSpacing);
			text.lineSpacing = lineSpacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242D9 RID: 148185 RVA: 0x00CB5108 File Offset: 0x00CB3308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)text.fontStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242DA RID: 148186 RVA: 0x00CB515C File Offset: 0x00CB335C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			FontStyle fontStyle;
			LuaObject.checkEnum<FontStyle>(l, 2, out fontStyle);
			text.fontStyle = fontStyle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242DB RID: 148187 RVA: 0x00CB51B4 File Offset: 0x00CB33B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.pixelsPerUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242DC RID: 148188 RVA: 0x00CB5208 File Offset: 0x00CB3408
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242DD RID: 148189 RVA: 0x00CB525C File Offset: 0x00CB345C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242DE RID: 148190 RVA: 0x00CB52B0 File Offset: 0x00CB34B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242DF RID: 148191 RVA: 0x00CB5304 File Offset: 0x00CB3504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E0 RID: 148192 RVA: 0x00CB5358 File Offset: 0x00CB3558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E1 RID: 148193 RVA: 0x00CB53AC File Offset: 0x00CB35AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E2 RID: 148194 RVA: 0x00CB5400 File Offset: 0x00CB3600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			Text text = (Text)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, text.layoutPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E3 RID: 148195 RVA: 0x00CB5454 File Offset: 0x00CB3654
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Text");
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Text.FontTextureChanged);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Text.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Text.GetGenerationSettings);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Text.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Text.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Text.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Text.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Text.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Text.GetTextAnchorPivot_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Text.<>f__mg$cache4);
		string name = "cachedTextGenerator";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_cachedTextGenerator);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_Text.<>f__mg$cache5, null, true);
		string name2 = "cachedTextGeneratorForLayout";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_cachedTextGeneratorForLayout);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_UI_Text.<>f__mg$cache6, null, true);
		string name3 = "mainTexture";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_mainTexture);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_UI_Text.<>f__mg$cache7, null, true);
		string name4 = "font";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_font);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Text.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_font);
		}
		LuaObject.addMember(l, name4, get, Lua_UnityEngine_UI_Text.<>f__mg$cache9, true);
		string name5 = "text";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_text);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Text.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_text);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_UI_Text.<>f__mg$cacheB, true);
		string name6 = "supportRichText";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_supportRichText);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Text.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_supportRichText);
		}
		LuaObject.addMember(l, name6, get3, Lua_UnityEngine_UI_Text.<>f__mg$cacheD, true);
		string name7 = "resizeTextForBestFit";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_resizeTextForBestFit);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Text.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_resizeTextForBestFit);
		}
		LuaObject.addMember(l, name7, get4, Lua_UnityEngine_UI_Text.<>f__mg$cacheF, true);
		string name8 = "resizeTextMinSize";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_resizeTextMinSize);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Text.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_resizeTextMinSize);
		}
		LuaObject.addMember(l, name8, get5, Lua_UnityEngine_UI_Text.<>f__mg$cache11, true);
		string name9 = "resizeTextMaxSize";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_resizeTextMaxSize);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_Text.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_resizeTextMaxSize);
		}
		LuaObject.addMember(l, name9, get6, Lua_UnityEngine_UI_Text.<>f__mg$cache13, true);
		string name10 = "alignment";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_alignment);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_Text.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_alignment);
		}
		LuaObject.addMember(l, name10, get7, Lua_UnityEngine_UI_Text.<>f__mg$cache15, true);
		string name11 = "alignByGeometry";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_alignByGeometry);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_Text.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_alignByGeometry);
		}
		LuaObject.addMember(l, name11, get8, Lua_UnityEngine_UI_Text.<>f__mg$cache17, true);
		string name12 = "fontSize";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_fontSize);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_Text.<>f__mg$cache18;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_fontSize);
		}
		LuaObject.addMember(l, name12, get9, Lua_UnityEngine_UI_Text.<>f__mg$cache19, true);
		string name13 = "horizontalOverflow";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_horizontalOverflow);
		}
		LuaCSFunction get10 = Lua_UnityEngine_UI_Text.<>f__mg$cache1A;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_horizontalOverflow);
		}
		LuaObject.addMember(l, name13, get10, Lua_UnityEngine_UI_Text.<>f__mg$cache1B, true);
		string name14 = "verticalOverflow";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_verticalOverflow);
		}
		LuaCSFunction get11 = Lua_UnityEngine_UI_Text.<>f__mg$cache1C;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_verticalOverflow);
		}
		LuaObject.addMember(l, name14, get11, Lua_UnityEngine_UI_Text.<>f__mg$cache1D, true);
		string name15 = "lineSpacing";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_lineSpacing);
		}
		LuaCSFunction get12 = Lua_UnityEngine_UI_Text.<>f__mg$cache1E;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_lineSpacing);
		}
		LuaObject.addMember(l, name15, get12, Lua_UnityEngine_UI_Text.<>f__mg$cache1F, true);
		string name16 = "fontStyle";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_fontStyle);
		}
		LuaCSFunction get13 = Lua_UnityEngine_UI_Text.<>f__mg$cache20;
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_UI_Text.set_fontStyle);
		}
		LuaObject.addMember(l, name16, get13, Lua_UnityEngine_UI_Text.<>f__mg$cache21, true);
		string name17 = "pixelsPerUnit";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_pixelsPerUnit);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_UI_Text.<>f__mg$cache22, null, true);
		string name18 = "minWidth";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_minWidth);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_UI_Text.<>f__mg$cache23, null, true);
		string name19 = "preferredWidth";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_preferredWidth);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_UI_Text.<>f__mg$cache24, null, true);
		string name20 = "flexibleWidth";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_flexibleWidth);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_UI_Text.<>f__mg$cache25, null, true);
		string name21 = "minHeight";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_minHeight);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_UI_Text.<>f__mg$cache26, null, true);
		string name22 = "preferredHeight";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_preferredHeight);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_UI_Text.<>f__mg$cache27, null, true);
		string name23 = "flexibleHeight";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_flexibleHeight);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_UI_Text.<>f__mg$cache28, null, true);
		string name24 = "layoutPriority";
		if (Lua_UnityEngine_UI_Text.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_UI_Text.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_UI_Text.get_layoutPriority);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_UI_Text.<>f__mg$cache29, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Text), typeof(MaskableGraphic));
	}

	// Token: 0x04019E51 RID: 106065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E52 RID: 106066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E53 RID: 106067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E54 RID: 106068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E55 RID: 106069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E56 RID: 106070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E57 RID: 106071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019E58 RID: 106072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019E59 RID: 106073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019E5A RID: 106074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019E5B RID: 106075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019E5C RID: 106076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019E5D RID: 106077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019E5E RID: 106078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019E5F RID: 106079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019E60 RID: 106080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019E61 RID: 106081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019E62 RID: 106082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019E63 RID: 106083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019E64 RID: 106084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019E65 RID: 106085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019E66 RID: 106086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019E67 RID: 106087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019E68 RID: 106088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019E69 RID: 106089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019E6A RID: 106090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019E6B RID: 106091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019E6C RID: 106092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019E6D RID: 106093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019E6E RID: 106094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019E6F RID: 106095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019E70 RID: 106096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019E71 RID: 106097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019E72 RID: 106098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019E73 RID: 106099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019E74 RID: 106100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019E75 RID: 106101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019E76 RID: 106102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019E77 RID: 106103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019E78 RID: 106104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019E79 RID: 106105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019E7A RID: 106106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
