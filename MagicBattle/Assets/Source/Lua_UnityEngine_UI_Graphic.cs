using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001822 RID: 6178
[Preserve]
public class Lua_UnityEngine_UI_Graphic : LuaObject
{
	// Token: 0x0602404E RID: 147534 RVA: 0x00CA4C50 File Offset: 0x00CA2E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAllDirty(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.SetAllDirty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602404F RID: 147535 RVA: 0x00CA4C9C File Offset: 0x00CA2E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutDirty(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.SetLayoutDirty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024050 RID: 147536 RVA: 0x00CA4CE8 File Offset: 0x00CA2EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVerticesDirty(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.SetVerticesDirty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024051 RID: 147537 RVA: 0x00CA4D34 File Offset: 0x00CA2F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMaterialDirty(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.SetMaterialDirty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024052 RID: 147538 RVA: 0x00CA4D80 File Offset: 0x00CA2F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCullingChanged(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.OnCullingChanged();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024053 RID: 147539 RVA: 0x00CA4DCC File Offset: 0x00CA2FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			CanvasUpdate update;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out update);
			graphic.Rebuild(update);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024054 RID: 147540 RVA: 0x00CA4E24 File Offset: 0x00CA3024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024055 RID: 147541 RVA: 0x00CA4E70 File Offset: 0x00CA3070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024056 RID: 147542 RVA: 0x00CA4EBC File Offset: 0x00CA30BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNativeSize(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			graphic.SetNativeSize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024057 RID: 147543 RVA: 0x00CA4F08 File Offset: 0x00CA3108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			Camera eventCamera;
			LuaObject.checkType<Camera>(l, 3, out eventCamera);
			bool b = graphic.Raycast(sp, eventCamera);
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

	// Token: 0x06024058 RID: 147544 RVA: 0x00CA4F78 File Offset: 0x00CA3178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PixelAdjustPoint(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			Vector2 o = graphic.PixelAdjustPoint(point);
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

	// Token: 0x06024059 RID: 147545 RVA: 0x00CA4FDC File Offset: 0x00CA31DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixelAdjustedRect(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			Rect pixelAdjustedRect = graphic.GetPixelAdjustedRect();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pixelAdjustedRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602405A RID: 147546 RVA: 0x00CA5038 File Offset: 0x00CA3238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFadeColor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Graphic graphic = (Graphic)LuaObject.checkSelf(l);
				Color targetColor;
				LuaObject.checkType(l, 2, out targetColor);
				float duration;
				LuaObject.checkType(l, 3, out duration);
				bool ignoreTimeScale;
				LuaObject.checkType(l, 4, out ignoreTimeScale);
				bool useAlpha;
				LuaObject.checkType(l, 5, out useAlpha);
				graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Graphic graphic2 = (Graphic)LuaObject.checkSelf(l);
				Color targetColor2;
				LuaObject.checkType(l, 2, out targetColor2);
				float duration2;
				LuaObject.checkType(l, 3, out duration2);
				bool ignoreTimeScale2;
				LuaObject.checkType(l, 4, out ignoreTimeScale2);
				bool useAlpha2;
				LuaObject.checkType(l, 5, out useAlpha2);
				bool useRGB;
				LuaObject.checkType(l, 6, out useRGB);
				graphic2.CrossFadeColor(targetColor2, duration2, ignoreTimeScale2, useAlpha2, useRGB);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CrossFadeColor to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602405B RID: 147547 RVA: 0x00CA5148 File Offset: 0x00CA3348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFadeAlpha(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			float alpha;
			LuaObject.checkType(l, 2, out alpha);
			float duration;
			LuaObject.checkType(l, 3, out duration);
			bool ignoreTimeScale;
			LuaObject.checkType(l, 4, out ignoreTimeScale);
			graphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602405C RID: 147548 RVA: 0x00CA51BC File Offset: 0x00CA33BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterDirtyLayoutCallback(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			graphic.RegisterDirtyLayoutCallback(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602405D RID: 147549 RVA: 0x00CA5214 File Offset: 0x00CA3414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterDirtyLayoutCallback(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			graphic.UnregisterDirtyLayoutCallback(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602405E RID: 147550 RVA: 0x00CA526C File Offset: 0x00CA346C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterDirtyVerticesCallback(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			graphic.RegisterDirtyVerticesCallback(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602405F RID: 147551 RVA: 0x00CA52C4 File Offset: 0x00CA34C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterDirtyVerticesCallback(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			graphic.UnregisterDirtyVerticesCallback(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024060 RID: 147552 RVA: 0x00CA531C File Offset: 0x00CA351C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterDirtyMaterialCallback(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			graphic.RegisterDirtyMaterialCallback(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024061 RID: 147553 RVA: 0x00CA5374 File Offset: 0x00CA3574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterDirtyMaterialCallback(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			graphic.UnregisterDirtyMaterialCallback(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024062 RID: 147554 RVA: 0x00CA53CC File Offset: 0x00CA35CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultGraphicMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Graphic.defaultGraphicMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024063 RID: 147555 RVA: 0x00CA5414 File Offset: 0x00CA3614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024064 RID: 147556 RVA: 0x00CA5468 File Offset: 0x00CA3668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			graphic.color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024065 RID: 147557 RVA: 0x00CA54C0 File Offset: 0x00CA36C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_raycastTarget(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.raycastTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024066 RID: 147558 RVA: 0x00CA5514 File Offset: 0x00CA3714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_raycastTarget(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			bool raycastTarget;
			LuaObject.checkType(l, 2, out raycastTarget);
			graphic.raycastTarget = raycastTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024067 RID: 147559 RVA: 0x00CA556C File Offset: 0x00CA376C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024068 RID: 147560 RVA: 0x00CA55C0 File Offset: 0x00CA37C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rectTransform(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.rectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024069 RID: 147561 RVA: 0x00CA5614 File Offset: 0x00CA3814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_canvas(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.canvas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602406A RID: 147562 RVA: 0x00CA5668 File Offset: 0x00CA3868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_canvasRenderer(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.canvasRenderer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602406B RID: 147563 RVA: 0x00CA56BC File Offset: 0x00CA38BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultMaterial(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.defaultMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602406C RID: 147564 RVA: 0x00CA5710 File Offset: 0x00CA3910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602406D RID: 147565 RVA: 0x00CA5764 File Offset: 0x00CA3964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			graphic.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602406E RID: 147566 RVA: 0x00CA57BC File Offset: 0x00CA39BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_materialForRendering(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.materialForRendering);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602406F RID: 147567 RVA: 0x00CA5810 File Offset: 0x00CA3A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTexture(IntPtr l)
	{
		int result;
		try
		{
			Graphic graphic = (Graphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic.mainTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024070 RID: 147568 RVA: 0x00CA5864 File Offset: 0x00CA3A64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Graphic");
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.SetAllDirty);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.SetLayoutDirty);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.SetVerticesDirty);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.SetMaterialDirty);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.OnCullingChanged);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.SetNativeSize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.PixelAdjustPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cacheA);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.GetPixelAdjustedRect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cacheB);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.CrossFadeColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cacheC);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.CrossFadeAlpha);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cacheD);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.RegisterDirtyLayoutCallback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cacheE);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.UnregisterDirtyLayoutCallback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cacheF);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.RegisterDirtyVerticesCallback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache10);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.UnregisterDirtyVerticesCallback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache11);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.RegisterDirtyMaterialCallback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache12);
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.UnregisterDirtyMaterialCallback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Graphic.<>f__mg$cache13);
		string name = "defaultGraphicMaterial";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_defaultGraphicMaterial);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_Graphic.<>f__mg$cache14, null, false);
		string name2 = "color";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_color);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Graphic.<>f__mg$cache15;
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.set_color);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_UI_Graphic.<>f__mg$cache16, true);
		string name3 = "raycastTarget";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_raycastTarget);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Graphic.<>f__mg$cache17;
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.set_raycastTarget);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_UI_Graphic.<>f__mg$cache18, true);
		string name4 = "depth";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_depth);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_UI_Graphic.<>f__mg$cache19, null, true);
		string name5 = "rectTransform";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_rectTransform);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_UI_Graphic.<>f__mg$cache1A, null, true);
		string name6 = "canvas";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_canvas);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_UI_Graphic.<>f__mg$cache1B, null, true);
		string name7 = "canvasRenderer";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_canvasRenderer);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_UI_Graphic.<>f__mg$cache1C, null, true);
		string name8 = "defaultMaterial";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_defaultMaterial);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_UI_Graphic.<>f__mg$cache1D, null, true);
		string name9 = "material";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_material);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Graphic.<>f__mg$cache1E;
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.set_material);
		}
		LuaObject.addMember(l, name9, get3, Lua_UnityEngine_UI_Graphic.<>f__mg$cache1F, true);
		string name10 = "materialForRendering";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_materialForRendering);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_UI_Graphic.<>f__mg$cache20, null, true);
		string name11 = "mainTexture";
		if (Lua_UnityEngine_UI_Graphic.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_UI_Graphic.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_UI_Graphic.get_mainTexture);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_UI_Graphic.<>f__mg$cache21, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Graphic), typeof(UIBehaviour));
	}

	// Token: 0x04019C68 RID: 105576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C69 RID: 105577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C6A RID: 105578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C6B RID: 105579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C6C RID: 105580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C6D RID: 105581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C6E RID: 105582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C6F RID: 105583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C70 RID: 105584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C71 RID: 105585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019C72 RID: 105586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019C73 RID: 105587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019C74 RID: 105588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019C75 RID: 105589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019C76 RID: 105590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019C77 RID: 105591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019C78 RID: 105592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019C79 RID: 105593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019C7A RID: 105594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019C7B RID: 105595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019C7C RID: 105596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019C7D RID: 105597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019C7E RID: 105598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019C7F RID: 105599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019C80 RID: 105600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019C81 RID: 105601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019C82 RID: 105602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019C83 RID: 105603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019C84 RID: 105604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019C85 RID: 105605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019C86 RID: 105606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019C87 RID: 105607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019C88 RID: 105608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019C89 RID: 105609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
