using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017F6 RID: 6134
[Preserve]
public class Lua_UnityEngine_TextGenerationSettings : LuaObject
{
	// Token: 0x06023E43 RID: 147011 RVA: 0x00C95544 File Offset: 0x00C93744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings = default(TextGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E44 RID: 147012 RVA: 0x00C95594 File Offset: 0x00C93794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_font(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.font);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E45 RID: 147013 RVA: 0x00C955E8 File Offset: 0x00C937E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_font(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			Font font;
			LuaObject.checkType<Font>(l, 2, out font);
			textGenerationSettings.font = font;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E46 RID: 147014 RVA: 0x00C9564C File Offset: 0x00C9384C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E47 RID: 147015 RVA: 0x00C956A0 File Offset: 0x00C938A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			Color color;
			LuaObject.checkType(l, 2, out color);
			textGenerationSettings.color = color;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E48 RID: 147016 RVA: 0x00C95704 File Offset: 0x00C93904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontSize(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.fontSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E49 RID: 147017 RVA: 0x00C95758 File Offset: 0x00C93958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontSize(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			textGenerationSettings.fontSize = fontSize;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E4A RID: 147018 RVA: 0x00C957BC File Offset: 0x00C939BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.lineSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E4B RID: 147019 RVA: 0x00C95810 File Offset: 0x00C93A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lineSpacing(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			float lineSpacing;
			LuaObject.checkType(l, 2, out lineSpacing);
			textGenerationSettings.lineSpacing = lineSpacing;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E4C RID: 147020 RVA: 0x00C95874 File Offset: 0x00C93A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_richText(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.richText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E4D RID: 147021 RVA: 0x00C958C8 File Offset: 0x00C93AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_richText(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			bool richText;
			LuaObject.checkType(l, 2, out richText);
			textGenerationSettings.richText = richText;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E4E RID: 147022 RVA: 0x00C9592C File Offset: 0x00C93B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scaleFactor(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.scaleFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E4F RID: 147023 RVA: 0x00C95980 File Offset: 0x00C93B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scaleFactor(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			float scaleFactor;
			LuaObject.checkType(l, 2, out scaleFactor);
			textGenerationSettings.scaleFactor = scaleFactor;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E50 RID: 147024 RVA: 0x00C959E4 File Offset: 0x00C93BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textGenerationSettings.fontStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E51 RID: 147025 RVA: 0x00C95A38 File Offset: 0x00C93C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontStyle(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			FontStyle fontStyle;
			LuaObject.checkEnum<FontStyle>(l, 2, out fontStyle);
			textGenerationSettings.fontStyle = fontStyle;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E52 RID: 147026 RVA: 0x00C95A9C File Offset: 0x00C93C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textAnchor(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textGenerationSettings.textAnchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E53 RID: 147027 RVA: 0x00C95AF0 File Offset: 0x00C93CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_textAnchor(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			TextAnchor textAnchor;
			LuaObject.checkEnum<TextAnchor>(l, 2, out textAnchor);
			textGenerationSettings.textAnchor = textAnchor;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E54 RID: 147028 RVA: 0x00C95B54 File Offset: 0x00C93D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alignByGeometry(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.alignByGeometry);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E55 RID: 147029 RVA: 0x00C95BA8 File Offset: 0x00C93DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignByGeometry(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			bool alignByGeometry;
			LuaObject.checkType(l, 2, out alignByGeometry);
			textGenerationSettings.alignByGeometry = alignByGeometry;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E56 RID: 147030 RVA: 0x00C95C0C File Offset: 0x00C93E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resizeTextForBestFit(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.resizeTextForBestFit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E57 RID: 147031 RVA: 0x00C95C60 File Offset: 0x00C93E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resizeTextForBestFit(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			bool resizeTextForBestFit;
			LuaObject.checkType(l, 2, out resizeTextForBestFit);
			textGenerationSettings.resizeTextForBestFit = resizeTextForBestFit;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E58 RID: 147032 RVA: 0x00C95CC4 File Offset: 0x00C93EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resizeTextMinSize(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.resizeTextMinSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E59 RID: 147033 RVA: 0x00C95D18 File Offset: 0x00C93F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resizeTextMinSize(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			int resizeTextMinSize;
			LuaObject.checkType(l, 2, out resizeTextMinSize);
			textGenerationSettings.resizeTextMinSize = resizeTextMinSize;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E5A RID: 147034 RVA: 0x00C95D7C File Offset: 0x00C93F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resizeTextMaxSize(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.resizeTextMaxSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E5B RID: 147035 RVA: 0x00C95DD0 File Offset: 0x00C93FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resizeTextMaxSize(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			int resizeTextMaxSize;
			LuaObject.checkType(l, 2, out resizeTextMaxSize);
			textGenerationSettings.resizeTextMaxSize = resizeTextMaxSize;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E5C RID: 147036 RVA: 0x00C95E34 File Offset: 0x00C94034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateBounds(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.updateBounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E5D RID: 147037 RVA: 0x00C95E88 File Offset: 0x00C94088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateBounds(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			bool updateBounds;
			LuaObject.checkType(l, 2, out updateBounds);
			textGenerationSettings.updateBounds = updateBounds;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E5E RID: 147038 RVA: 0x00C95EEC File Offset: 0x00C940EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalOverflow(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textGenerationSettings.verticalOverflow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E5F RID: 147039 RVA: 0x00C95F40 File Offset: 0x00C94140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalOverflow(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			VerticalWrapMode verticalOverflow;
			LuaObject.checkEnum<VerticalWrapMode>(l, 2, out verticalOverflow);
			textGenerationSettings.verticalOverflow = verticalOverflow;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E60 RID: 147040 RVA: 0x00C95FA4 File Offset: 0x00C941A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalOverflow(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)textGenerationSettings.horizontalOverflow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E61 RID: 147041 RVA: 0x00C95FF8 File Offset: 0x00C941F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontalOverflow(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			HorizontalWrapMode horizontalOverflow;
			LuaObject.checkEnum<HorizontalWrapMode>(l, 2, out horizontalOverflow);
			textGenerationSettings.horizontalOverflow = horizontalOverflow;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E62 RID: 147042 RVA: 0x00C9605C File Offset: 0x00C9425C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_generationExtents(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.generationExtents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E63 RID: 147043 RVA: 0x00C960B0 File Offset: 0x00C942B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_generationExtents(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			Vector2 generationExtents;
			LuaObject.checkType(l, 2, out generationExtents);
			textGenerationSettings.generationExtents = generationExtents;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E64 RID: 147044 RVA: 0x00C96114 File Offset: 0x00C94314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pivot(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.pivot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E65 RID: 147045 RVA: 0x00C96168 File Offset: 0x00C94368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pivot(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			Vector2 pivot;
			LuaObject.checkType(l, 2, out pivot);
			textGenerationSettings.pivot = pivot;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E66 RID: 147046 RVA: 0x00C961CC File Offset: 0x00C943CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_generateOutOfBounds(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textGenerationSettings.generateOutOfBounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E67 RID: 147047 RVA: 0x00C96220 File Offset: 0x00C94420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_generateOutOfBounds(IntPtr l)
	{
		int result;
		try
		{
			TextGenerationSettings textGenerationSettings;
			LuaObject.checkValueType<TextGenerationSettings>(l, 1, out textGenerationSettings);
			bool generateOutOfBounds;
			LuaObject.checkType(l, 2, out generateOutOfBounds);
			textGenerationSettings.generateOutOfBounds = generateOutOfBounds;
			LuaObject.setBack(l, textGenerationSettings);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E68 RID: 147048 RVA: 0x00C96284 File Offset: 0x00C94484
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.TextGenerationSettings");
		string name = "font";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_font);
		}
		LuaCSFunction get = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache0;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_font);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1, true);
		string name2 = "color";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_color);
		}
		LuaCSFunction get2 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache2;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_color);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache3, true);
		string name3 = "fontSize";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_fontSize);
		}
		LuaCSFunction get3 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache4;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_fontSize);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache5, true);
		string name4 = "lineSpacing";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_lineSpacing);
		}
		LuaCSFunction get4 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache6;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_lineSpacing);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache7, true);
		string name5 = "richText";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_richText);
		}
		LuaCSFunction get5 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache8;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_richText);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache9, true);
		string name6 = "scaleFactor";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_scaleFactor);
		}
		LuaCSFunction get6 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheA;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_scaleFactor);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheB, true);
		string name7 = "fontStyle";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_fontStyle);
		}
		LuaCSFunction get7 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheC;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_fontStyle);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheD, true);
		string name8 = "textAnchor";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_textAnchor);
		}
		LuaCSFunction get8 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheE;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_textAnchor);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cacheF, true);
		string name9 = "alignByGeometry";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_alignByGeometry);
		}
		LuaCSFunction get9 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache10;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_alignByGeometry);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache11, true);
		string name10 = "resizeTextForBestFit";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_resizeTextForBestFit);
		}
		LuaCSFunction get10 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache12;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_resizeTextForBestFit);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache13, true);
		string name11 = "resizeTextMinSize";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_resizeTextMinSize);
		}
		LuaCSFunction get11 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache14;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_resizeTextMinSize);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache15, true);
		string name12 = "resizeTextMaxSize";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_resizeTextMaxSize);
		}
		LuaCSFunction get12 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache16;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_resizeTextMaxSize);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache17, true);
		string name13 = "updateBounds";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_updateBounds);
		}
		LuaCSFunction get13 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache18;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_updateBounds);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache19, true);
		string name14 = "verticalOverflow";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_verticalOverflow);
		}
		LuaCSFunction get14 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1A;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_verticalOverflow);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1B, true);
		string name15 = "horizontalOverflow";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_horizontalOverflow);
		}
		LuaCSFunction get15 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1C;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_horizontalOverflow);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1D, true);
		string name16 = "generationExtents";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_generationExtents);
		}
		LuaCSFunction get16 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1E;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_generationExtents);
		}
		LuaObject.addMember(l, name16, get16, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache1F, true);
		string name17 = "pivot";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_pivot);
		}
		LuaCSFunction get17 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache20;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_pivot);
		}
		LuaObject.addMember(l, name17, get17, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache21, true);
		string name18 = "generateOutOfBounds";
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.get_generateOutOfBounds);
		}
		LuaCSFunction get18 = Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache22;
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.set_generateOutOfBounds);
		}
		LuaObject.addMember(l, name18, get18, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache23, true);
		if (Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_TextGenerationSettings.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_TextGenerationSettings.<>f__mg$cache24, typeof(TextGenerationSettings), typeof(ValueType));
	}

	// Token: 0x04019AB5 RID: 105141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019AB6 RID: 105142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019AB7 RID: 105143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019AB8 RID: 105144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019AB9 RID: 105145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019ABA RID: 105146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019ABB RID: 105147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019ABC RID: 105148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019ABD RID: 105149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019ABE RID: 105150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019ABF RID: 105151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019AC0 RID: 105152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019AC1 RID: 105153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019AC2 RID: 105154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019AC3 RID: 105155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019AC4 RID: 105156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019AC5 RID: 105157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019AC6 RID: 105158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019AC7 RID: 105159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019AC8 RID: 105160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019AC9 RID: 105161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019ACA RID: 105162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019ACB RID: 105163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019ACC RID: 105164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019ACD RID: 105165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019ACE RID: 105166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019ACF RID: 105167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019AD0 RID: 105168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019AD1 RID: 105169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019AD2 RID: 105170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019AD3 RID: 105171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019AD4 RID: 105172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019AD5 RID: 105173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019AD6 RID: 105174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019AD7 RID: 105175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019AD8 RID: 105176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019AD9 RID: 105177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
