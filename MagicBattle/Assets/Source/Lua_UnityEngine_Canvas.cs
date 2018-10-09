using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001651 RID: 5713
[Preserve]
public class Lua_UnityEngine_Canvas : LuaObject
{
	// Token: 0x06022D8F RID: 142735 RVA: 0x00C0AAEC File Offset: 0x00C08CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDefaultCanvasMaterial_s(IntPtr l)
	{
		int result;
		try
		{
			Material defaultCanvasMaterial = Canvas.GetDefaultCanvasMaterial();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, defaultCanvasMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D90 RID: 142736 RVA: 0x00C0AB34 File Offset: 0x00C08D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetETC1SupportedCanvasMaterial_s(IntPtr l)
	{
		int result;
		try
		{
			Material etc1SupportedCanvasMaterial = Canvas.GetETC1SupportedCanvasMaterial();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, etc1SupportedCanvasMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D91 RID: 142737 RVA: 0x00C0AB7C File Offset: 0x00C08D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceUpdateCanvases_s(IntPtr l)
	{
		int result;
		try
		{
			Canvas.ForceUpdateCanvases();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D92 RID: 142738 RVA: 0x00C0ABBC File Offset: 0x00C08DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderMode(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)canvas.renderMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D93 RID: 142739 RVA: 0x00C0AC10 File Offset: 0x00C08E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_renderMode(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			RenderMode renderMode;
			LuaObject.checkEnum<RenderMode>(l, 2, out renderMode);
			canvas.renderMode = renderMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D94 RID: 142740 RVA: 0x00C0AC68 File Offset: 0x00C08E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isRootCanvas(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.isRootCanvas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D95 RID: 142741 RVA: 0x00C0ACBC File Offset: 0x00C08EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldCamera(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.worldCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D96 RID: 142742 RVA: 0x00C0AD10 File Offset: 0x00C08F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_worldCamera(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			Camera worldCamera;
			LuaObject.checkType<Camera>(l, 2, out worldCamera);
			canvas.worldCamera = worldCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D97 RID: 142743 RVA: 0x00C0AD68 File Offset: 0x00C08F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelRect(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.pixelRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D98 RID: 142744 RVA: 0x00C0ADC0 File Offset: 0x00C08FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scaleFactor(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.scaleFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D99 RID: 142745 RVA: 0x00C0AE14 File Offset: 0x00C09014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scaleFactor(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			float scaleFactor;
			LuaObject.checkType(l, 2, out scaleFactor);
			canvas.scaleFactor = scaleFactor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D9A RID: 142746 RVA: 0x00C0AE6C File Offset: 0x00C0906C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_referencePixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.referencePixelsPerUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D9B RID: 142747 RVA: 0x00C0AEC0 File Offset: 0x00C090C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_referencePixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			float referencePixelsPerUnit;
			LuaObject.checkType(l, 2, out referencePixelsPerUnit);
			canvas.referencePixelsPerUnit = referencePixelsPerUnit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D9C RID: 142748 RVA: 0x00C0AF18 File Offset: 0x00C09118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_overridePixelPerfect(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.overridePixelPerfect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D9D RID: 142749 RVA: 0x00C0AF6C File Offset: 0x00C0916C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_overridePixelPerfect(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			bool overridePixelPerfect;
			LuaObject.checkType(l, 2, out overridePixelPerfect);
			canvas.overridePixelPerfect = overridePixelPerfect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D9E RID: 142750 RVA: 0x00C0AFC4 File Offset: 0x00C091C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelPerfect(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.pixelPerfect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D9F RID: 142751 RVA: 0x00C0B018 File Offset: 0x00C09218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pixelPerfect(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			bool pixelPerfect;
			LuaObject.checkType(l, 2, out pixelPerfect);
			canvas.pixelPerfect = pixelPerfect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA0 RID: 142752 RVA: 0x00C0B070 File Offset: 0x00C09270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_planeDistance(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.planeDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA1 RID: 142753 RVA: 0x00C0B0C4 File Offset: 0x00C092C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_planeDistance(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			float planeDistance;
			LuaObject.checkType(l, 2, out planeDistance);
			canvas.planeDistance = planeDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA2 RID: 142754 RVA: 0x00C0B11C File Offset: 0x00C0931C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderOrder(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.renderOrder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA3 RID: 142755 RVA: 0x00C0B170 File Offset: 0x00C09370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_overrideSorting(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.overrideSorting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA4 RID: 142756 RVA: 0x00C0B1C4 File Offset: 0x00C093C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_overrideSorting(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			bool overrideSorting;
			LuaObject.checkType(l, 2, out overrideSorting);
			canvas.overrideSorting = overrideSorting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA5 RID: 142757 RVA: 0x00C0B21C File Offset: 0x00C0941C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.sortingOrder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA6 RID: 142758 RVA: 0x00C0B270 File Offset: 0x00C09470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			int sortingOrder;
			LuaObject.checkType(l, 2, out sortingOrder);
			canvas.sortingOrder = sortingOrder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA7 RID: 142759 RVA: 0x00C0B2C8 File Offset: 0x00C094C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetDisplay(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.targetDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA8 RID: 142760 RVA: 0x00C0B31C File Offset: 0x00C0951C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetDisplay(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			int targetDisplay;
			LuaObject.checkType(l, 2, out targetDisplay);
			canvas.targetDisplay = targetDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DA9 RID: 142761 RVA: 0x00C0B374 File Offset: 0x00C09574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedSortingGridSize(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.normalizedSortingGridSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DAA RID: 142762 RVA: 0x00C0B3C8 File Offset: 0x00C095C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normalizedSortingGridSize(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			float normalizedSortingGridSize;
			LuaObject.checkType(l, 2, out normalizedSortingGridSize);
			canvas.normalizedSortingGridSize = normalizedSortingGridSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DAB RID: 142763 RVA: 0x00C0B420 File Offset: 0x00C09620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayerID(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.sortingLayerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DAC RID: 142764 RVA: 0x00C0B474 File Offset: 0x00C09674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayerID(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			int sortingLayerID;
			LuaObject.checkType(l, 2, out sortingLayerID);
			canvas.sortingLayerID = sortingLayerID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DAD RID: 142765 RVA: 0x00C0B4CC File Offset: 0x00C096CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cachedSortingLayerValue(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.cachedSortingLayerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DAE RID: 142766 RVA: 0x00C0B520 File Offset: 0x00C09720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_additionalShaderChannels(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)canvas.additionalShaderChannels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DAF RID: 142767 RVA: 0x00C0B574 File Offset: 0x00C09774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_additionalShaderChannels(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			AdditionalCanvasShaderChannels additionalShaderChannels;
			LuaObject.checkEnum<AdditionalCanvasShaderChannels>(l, 2, out additionalShaderChannels);
			canvas.additionalShaderChannels = additionalShaderChannels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB0 RID: 142768 RVA: 0x00C0B5CC File Offset: 0x00C097CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayerName(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.sortingLayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB1 RID: 142769 RVA: 0x00C0B620 File Offset: 0x00C09820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayerName(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			string sortingLayerName;
			LuaObject.checkType(l, 2, out sortingLayerName);
			canvas.sortingLayerName = sortingLayerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB2 RID: 142770 RVA: 0x00C0B678 File Offset: 0x00C09878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rootCanvas(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas = (Canvas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvas.rootCanvas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB3 RID: 142771 RVA: 0x00C0B6CC File Offset: 0x00C098CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Canvas");
		if (Lua_UnityEngine_Canvas.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Canvas.GetDefaultCanvasMaterial_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Canvas.<>f__mg$cache0);
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Canvas.GetETC1SupportedCanvasMaterial_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Canvas.<>f__mg$cache1);
		if (Lua_UnityEngine_Canvas.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Canvas.ForceUpdateCanvases_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Canvas.<>f__mg$cache2);
		string name = "renderMode";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_renderMode);
		}
		LuaCSFunction get = Lua_UnityEngine_Canvas.<>f__mg$cache3;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_renderMode);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Canvas.<>f__mg$cache4, true);
		string name2 = "isRootCanvas";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_isRootCanvas);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Canvas.<>f__mg$cache5, null, true);
		string name3 = "worldCamera";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_worldCamera);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Canvas.<>f__mg$cache6;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_worldCamera);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Canvas.<>f__mg$cache7, true);
		string name4 = "pixelRect";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_pixelRect);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Canvas.<>f__mg$cache8, null, true);
		string name5 = "scaleFactor";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_scaleFactor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Canvas.<>f__mg$cache9;
		if (Lua_UnityEngine_Canvas.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Canvas.set_scaleFactor);
		}
		LuaObject.addMember(l, name5, get3, Lua_UnityEngine_Canvas.<>f__mg$cacheA, true);
		string name6 = "referencePixelsPerUnit";
		if (Lua_UnityEngine_Canvas.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Canvas.get_referencePixelsPerUnit);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Canvas.<>f__mg$cacheB;
		if (Lua_UnityEngine_Canvas.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Canvas.set_referencePixelsPerUnit);
		}
		LuaObject.addMember(l, name6, get4, Lua_UnityEngine_Canvas.<>f__mg$cacheC, true);
		string name7 = "overridePixelPerfect";
		if (Lua_UnityEngine_Canvas.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Canvas.get_overridePixelPerfect);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Canvas.<>f__mg$cacheD;
		if (Lua_UnityEngine_Canvas.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Canvas.set_overridePixelPerfect);
		}
		LuaObject.addMember(l, name7, get5, Lua_UnityEngine_Canvas.<>f__mg$cacheE, true);
		string name8 = "pixelPerfect";
		if (Lua_UnityEngine_Canvas.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Canvas.get_pixelPerfect);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Canvas.<>f__mg$cacheF;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_pixelPerfect);
		}
		LuaObject.addMember(l, name8, get6, Lua_UnityEngine_Canvas.<>f__mg$cache10, true);
		string name9 = "planeDistance";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_planeDistance);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Canvas.<>f__mg$cache11;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_planeDistance);
		}
		LuaObject.addMember(l, name9, get7, Lua_UnityEngine_Canvas.<>f__mg$cache12, true);
		string name10 = "renderOrder";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_renderOrder);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Canvas.<>f__mg$cache13, null, true);
		string name11 = "overrideSorting";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_overrideSorting);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Canvas.<>f__mg$cache14;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_overrideSorting);
		}
		LuaObject.addMember(l, name11, get8, Lua_UnityEngine_Canvas.<>f__mg$cache15, true);
		string name12 = "sortingOrder";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_sortingOrder);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Canvas.<>f__mg$cache16;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_sortingOrder);
		}
		LuaObject.addMember(l, name12, get9, Lua_UnityEngine_Canvas.<>f__mg$cache17, true);
		string name13 = "targetDisplay";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_targetDisplay);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Canvas.<>f__mg$cache18;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_targetDisplay);
		}
		LuaObject.addMember(l, name13, get10, Lua_UnityEngine_Canvas.<>f__mg$cache19, true);
		string name14 = "normalizedSortingGridSize";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Canvas.get_normalizedSortingGridSize);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Canvas.<>f__mg$cache1A;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Canvas.set_normalizedSortingGridSize);
		}
		LuaObject.addMember(l, name14, get11, Lua_UnityEngine_Canvas.<>f__mg$cache1B, true);
		string name15 = "sortingLayerID";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Canvas.get_sortingLayerID);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Canvas.<>f__mg$cache1C;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Canvas.set_sortingLayerID);
		}
		LuaObject.addMember(l, name15, get12, Lua_UnityEngine_Canvas.<>f__mg$cache1D, true);
		string name16 = "cachedSortingLayerValue";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Canvas.get_cachedSortingLayerValue);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Canvas.<>f__mg$cache1E, null, true);
		string name17 = "additionalShaderChannels";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Canvas.get_additionalShaderChannels);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Canvas.<>f__mg$cache1F;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_additionalShaderChannels);
		}
		LuaObject.addMember(l, name17, get13, Lua_UnityEngine_Canvas.<>f__mg$cache20, true);
		string name18 = "sortingLayerName";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_sortingLayerName);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Canvas.<>f__mg$cache21;
		if (Lua_UnityEngine_Canvas.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Canvas.set_sortingLayerName);
		}
		LuaObject.addMember(l, name18, get14, Lua_UnityEngine_Canvas.<>f__mg$cache22, true);
		string name19 = "rootCanvas";
		if (Lua_UnityEngine_Canvas.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Canvas.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Canvas.get_rootCanvas);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Canvas.<>f__mg$cache23, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Canvas), typeof(Behaviour));
	}

	// Token: 0x04018D4B RID: 101707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018D4C RID: 101708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018D4D RID: 101709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018D4E RID: 101710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018D4F RID: 101711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018D50 RID: 101712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018D51 RID: 101713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018D52 RID: 101714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018D53 RID: 101715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018D54 RID: 101716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018D55 RID: 101717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018D56 RID: 101718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018D57 RID: 101719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018D58 RID: 101720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018D59 RID: 101721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018D5A RID: 101722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018D5B RID: 101723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018D5C RID: 101724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018D5D RID: 101725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018D5E RID: 101726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018D5F RID: 101727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018D60 RID: 101728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018D61 RID: 101729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018D62 RID: 101730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018D63 RID: 101731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018D64 RID: 101732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018D65 RID: 101733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018D66 RID: 101734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018D67 RID: 101735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018D68 RID: 101736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018D69 RID: 101737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018D6A RID: 101738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018D6B RID: 101739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018D6C RID: 101740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018D6D RID: 101741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018D6E RID: 101742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
