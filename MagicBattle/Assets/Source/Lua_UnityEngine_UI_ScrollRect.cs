using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001857 RID: 6231
[Preserve]
public class Lua_UnityEngine_UI_ScrollRect : LuaObject
{
	// Token: 0x06024213 RID: 147987 RVA: 0x00CAFF8C File Offset: 0x00CAE18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			CanvasUpdate executing;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out executing);
			scrollRect.Rebuild(executing);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024214 RID: 147988 RVA: 0x00CAFFE4 File Offset: 0x00CAE1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024215 RID: 147989 RVA: 0x00CB0030 File Offset: 0x00CAE230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024216 RID: 147990 RVA: 0x00CB007C File Offset: 0x00CAE27C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsActive(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			bool b = scrollRect.IsActive();
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

	// Token: 0x06024217 RID: 147991 RVA: 0x00CB00D0 File Offset: 0x00CAE2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopMovement(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.StopMovement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024218 RID: 147992 RVA: 0x00CB011C File Offset: 0x00CAE31C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnScroll(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			PointerEventData data;
			LuaObject.checkType<PointerEventData>(l, 2, out data);
			scrollRect.OnScroll(data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024219 RID: 147993 RVA: 0x00CB0174 File Offset: 0x00CAE374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInitializePotentialDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollRect.OnInitializePotentialDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602421A RID: 147994 RVA: 0x00CB01CC File Offset: 0x00CAE3CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollRect.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602421B RID: 147995 RVA: 0x00CB0224 File Offset: 0x00CAE424
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollRect.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602421C RID: 147996 RVA: 0x00CB027C File Offset: 0x00CAE47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollRect.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602421D RID: 147997 RVA: 0x00CB02D4 File Offset: 0x00CAE4D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602421E RID: 147998 RVA: 0x00CB0320 File Offset: 0x00CAE520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602421F RID: 147999 RVA: 0x00CB036C File Offset: 0x00CAE56C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024220 RID: 148000 RVA: 0x00CB03B8 File Offset: 0x00CAE5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			scrollRect.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024221 RID: 148001 RVA: 0x00CB0404 File Offset: 0x00CAE604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_content(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024222 RID: 148002 RVA: 0x00CB0458 File Offset: 0x00CAE658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_content(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			RectTransform content;
			LuaObject.checkType<RectTransform>(l, 2, out content);
			scrollRect.content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024223 RID: 148003 RVA: 0x00CB04B0 File Offset: 0x00CAE6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontal(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.horizontal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024224 RID: 148004 RVA: 0x00CB0504 File Offset: 0x00CAE704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontal(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			bool horizontal;
			LuaObject.checkType(l, 2, out horizontal);
			scrollRect.horizontal = horizontal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024225 RID: 148005 RVA: 0x00CB055C File Offset: 0x00CAE75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vertical(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.vertical);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024226 RID: 148006 RVA: 0x00CB05B0 File Offset: 0x00CAE7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_vertical(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			bool vertical;
			LuaObject.checkType(l, 2, out vertical);
			scrollRect.vertical = vertical;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024227 RID: 148007 RVA: 0x00CB0608 File Offset: 0x00CAE808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_movementType(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)scrollRect.movementType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024228 RID: 148008 RVA: 0x00CB065C File Offset: 0x00CAE85C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_movementType(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			ScrollRect.MovementType movementType;
			LuaObject.checkEnum<ScrollRect.MovementType>(l, 2, out movementType);
			scrollRect.movementType = movementType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024229 RID: 148009 RVA: 0x00CB06B4 File Offset: 0x00CAE8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_elasticity(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.elasticity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602422A RID: 148010 RVA: 0x00CB0708 File Offset: 0x00CAE908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_elasticity(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float elasticity;
			LuaObject.checkType(l, 2, out elasticity);
			scrollRect.elasticity = elasticity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602422B RID: 148011 RVA: 0x00CB0760 File Offset: 0x00CAE960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inertia(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.inertia);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602422C RID: 148012 RVA: 0x00CB07B4 File Offset: 0x00CAE9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inertia(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			bool inertia;
			LuaObject.checkType(l, 2, out inertia);
			scrollRect.inertia = inertia;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602422D RID: 148013 RVA: 0x00CB080C File Offset: 0x00CAEA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_decelerationRate(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.decelerationRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602422E RID: 148014 RVA: 0x00CB0860 File Offset: 0x00CAEA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_decelerationRate(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float decelerationRate;
			LuaObject.checkType(l, 2, out decelerationRate);
			scrollRect.decelerationRate = decelerationRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602422F RID: 148015 RVA: 0x00CB08B8 File Offset: 0x00CAEAB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_scrollSensitivity(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.scrollSensitivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024230 RID: 148016 RVA: 0x00CB090C File Offset: 0x00CAEB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scrollSensitivity(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float scrollSensitivity;
			LuaObject.checkType(l, 2, out scrollSensitivity);
			scrollRect.scrollSensitivity = scrollSensitivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024231 RID: 148017 RVA: 0x00CB0964 File Offset: 0x00CAEB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_viewport(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.viewport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024232 RID: 148018 RVA: 0x00CB09B8 File Offset: 0x00CAEBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_viewport(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			RectTransform viewport;
			LuaObject.checkType<RectTransform>(l, 2, out viewport);
			scrollRect.viewport = viewport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024233 RID: 148019 RVA: 0x00CB0A10 File Offset: 0x00CAEC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.horizontalScrollbar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024234 RID: 148020 RVA: 0x00CB0A64 File Offset: 0x00CAEC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontalScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			Scrollbar horizontalScrollbar;
			LuaObject.checkType<Scrollbar>(l, 2, out horizontalScrollbar);
			scrollRect.horizontalScrollbar = horizontalScrollbar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024235 RID: 148021 RVA: 0x00CB0ABC File Offset: 0x00CAECBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_verticalScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.verticalScrollbar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024236 RID: 148022 RVA: 0x00CB0B10 File Offset: 0x00CAED10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			Scrollbar verticalScrollbar;
			LuaObject.checkType<Scrollbar>(l, 2, out verticalScrollbar);
			scrollRect.verticalScrollbar = verticalScrollbar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024237 RID: 148023 RVA: 0x00CB0B68 File Offset: 0x00CAED68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalScrollbarVisibility(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)scrollRect.horizontalScrollbarVisibility);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024238 RID: 148024 RVA: 0x00CB0BBC File Offset: 0x00CAEDBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_horizontalScrollbarVisibility(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility;
			LuaObject.checkEnum<ScrollRect.ScrollbarVisibility>(l, 2, out horizontalScrollbarVisibility);
			scrollRect.horizontalScrollbarVisibility = horizontalScrollbarVisibility;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024239 RID: 148025 RVA: 0x00CB0C14 File Offset: 0x00CAEE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalScrollbarVisibility(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)scrollRect.verticalScrollbarVisibility);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602423A RID: 148026 RVA: 0x00CB0C68 File Offset: 0x00CAEE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalScrollbarVisibility(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			ScrollRect.ScrollbarVisibility verticalScrollbarVisibility;
			LuaObject.checkEnum<ScrollRect.ScrollbarVisibility>(l, 2, out verticalScrollbarVisibility);
			scrollRect.verticalScrollbarVisibility = verticalScrollbarVisibility;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602423B RID: 148027 RVA: 0x00CB0CC0 File Offset: 0x00CAEEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalScrollbarSpacing(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.horizontalScrollbarSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602423C RID: 148028 RVA: 0x00CB0D14 File Offset: 0x00CAEF14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_horizontalScrollbarSpacing(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float horizontalScrollbarSpacing;
			LuaObject.checkType(l, 2, out horizontalScrollbarSpacing);
			scrollRect.horizontalScrollbarSpacing = horizontalScrollbarSpacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602423D RID: 148029 RVA: 0x00CB0D6C File Offset: 0x00CAEF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalScrollbarSpacing(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.verticalScrollbarSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602423E RID: 148030 RVA: 0x00CB0DC0 File Offset: 0x00CAEFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalScrollbarSpacing(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float verticalScrollbarSpacing;
			LuaObject.checkType(l, 2, out verticalScrollbarSpacing);
			scrollRect.verticalScrollbarSpacing = verticalScrollbarSpacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602423F RID: 148031 RVA: 0x00CB0E18 File Offset: 0x00CAF018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.onValueChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024240 RID: 148032 RVA: 0x00CB0E6C File Offset: 0x00CAF06C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			ScrollRect.ScrollRectEvent onValueChanged;
			LuaObject.checkType<ScrollRect.ScrollRectEvent>(l, 2, out onValueChanged);
			scrollRect.onValueChanged = onValueChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024241 RID: 148033 RVA: 0x00CB0EC4 File Offset: 0x00CAF0C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024242 RID: 148034 RVA: 0x00CB0F18 File Offset: 0x00CAF118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_velocity(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			Vector2 velocity;
			LuaObject.checkType(l, 2, out velocity);
			scrollRect.velocity = velocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024243 RID: 148035 RVA: 0x00CB0F70 File Offset: 0x00CAF170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.normalizedPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024244 RID: 148036 RVA: 0x00CB0FC4 File Offset: 0x00CAF1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normalizedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			Vector2 normalizedPosition;
			LuaObject.checkType(l, 2, out normalizedPosition);
			scrollRect.normalizedPosition = normalizedPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024245 RID: 148037 RVA: 0x00CB101C File Offset: 0x00CAF21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalNormalizedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.horizontalNormalizedPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024246 RID: 148038 RVA: 0x00CB1070 File Offset: 0x00CAF270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_horizontalNormalizedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float horizontalNormalizedPosition;
			LuaObject.checkType(l, 2, out horizontalNormalizedPosition);
			scrollRect.horizontalNormalizedPosition = horizontalNormalizedPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024247 RID: 148039 RVA: 0x00CB10C8 File Offset: 0x00CAF2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalNormalizedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.verticalNormalizedPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024248 RID: 148040 RVA: 0x00CB111C File Offset: 0x00CAF31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalNormalizedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			float verticalNormalizedPosition;
			LuaObject.checkType(l, 2, out verticalNormalizedPosition);
			scrollRect.verticalNormalizedPosition = verticalNormalizedPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024249 RID: 148041 RVA: 0x00CB1174 File Offset: 0x00CAF374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602424A RID: 148042 RVA: 0x00CB11C8 File Offset: 0x00CAF3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602424B RID: 148043 RVA: 0x00CB121C File Offset: 0x00CAF41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602424C RID: 148044 RVA: 0x00CB1270 File Offset: 0x00CAF470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602424D RID: 148045 RVA: 0x00CB12C4 File Offset: 0x00CAF4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602424E RID: 148046 RVA: 0x00CB1318 File Offset: 0x00CAF518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602424F RID: 148047 RVA: 0x00CB136C File Offset: 0x00CAF56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect = (ScrollRect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollRect.layoutPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024250 RID: 148048 RVA: 0x00CB13C0 File Offset: 0x00CAF5C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ScrollRect");
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.IsActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.StopMovement);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.OnScroll);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.OnInitializePotentialDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.OnDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheA);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheB);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheC);
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheD);
		string name = "content";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_content);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_content);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cacheF, true);
		string name2 = "horizontal";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_horizontal);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_horizontal);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache11, true);
		string name3 = "vertical";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_vertical);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_vertical);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache13, true);
		string name4 = "movementType";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_movementType);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_movementType);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache15, true);
		string name5 = "elasticity";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_elasticity);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_elasticity);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache17, true);
		string name6 = "inertia";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_inertia);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache18;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_inertia);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache19, true);
		string name7 = "decelerationRate";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_decelerationRate);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1A;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_decelerationRate);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1B, true);
		string name8 = "scrollSensitivity";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_scrollSensitivity);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1C;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_scrollSensitivity);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1D, true);
		string name9 = "viewport";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_viewport);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1E;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_viewport);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache1F, true);
		string name10 = "horizontalScrollbar";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_horizontalScrollbar);
		}
		LuaCSFunction get10 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache20;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_horizontalScrollbar);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache21, true);
		string name11 = "verticalScrollbar";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_verticalScrollbar);
		}
		LuaCSFunction get11 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache22;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_verticalScrollbar);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache23, true);
		string name12 = "horizontalScrollbarVisibility";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_horizontalScrollbarVisibility);
		}
		LuaCSFunction get12 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache24;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_horizontalScrollbarVisibility);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache25, true);
		string name13 = "verticalScrollbarVisibility";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_verticalScrollbarVisibility);
		}
		LuaCSFunction get13 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache26;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_verticalScrollbarVisibility);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache27, true);
		string name14 = "horizontalScrollbarSpacing";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_horizontalScrollbarSpacing);
		}
		LuaCSFunction get14 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache28;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_horizontalScrollbarSpacing);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache29, true);
		string name15 = "verticalScrollbarSpacing";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_verticalScrollbarSpacing);
		}
		LuaCSFunction get15 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2A;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_verticalScrollbarSpacing);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2B, true);
		string name16 = "onValueChanged";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_onValueChanged);
		}
		LuaCSFunction get16 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2C;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_onValueChanged);
		}
		LuaObject.addMember(l, name16, get16, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2D, true);
		string name17 = "velocity";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_velocity);
		}
		LuaCSFunction get17 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2E;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_velocity);
		}
		LuaObject.addMember(l, name17, get17, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache2F, true);
		string name18 = "normalizedPosition";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_normalizedPosition);
		}
		LuaCSFunction get18 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache30;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_normalizedPosition);
		}
		LuaObject.addMember(l, name18, get18, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache31, true);
		string name19 = "horizontalNormalizedPosition";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_horizontalNormalizedPosition);
		}
		LuaCSFunction get19 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache32;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_horizontalNormalizedPosition);
		}
		LuaObject.addMember(l, name19, get19, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache33, true);
		string name20 = "verticalNormalizedPosition";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_verticalNormalizedPosition);
		}
		LuaCSFunction get20 = Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache34;
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.set_verticalNormalizedPosition);
		}
		LuaObject.addMember(l, name20, get20, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache35, true);
		string name21 = "minWidth";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_minWidth);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache36, null, true);
		string name22 = "preferredWidth";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_preferredWidth);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache37, null, true);
		string name23 = "flexibleWidth";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_flexibleWidth);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache38, null, true);
		string name24 = "minHeight";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_minHeight);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache39, null, true);
		string name25 = "preferredHeight";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_preferredHeight);
		}
		LuaObject.addMember(l, name25, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3A, null, true);
		string name26 = "flexibleHeight";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_flexibleHeight);
		}
		LuaObject.addMember(l, name26, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3B, null, true);
		string name27 = "layoutPriority";
		if (Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect.get_layoutPriority);
		}
		LuaObject.addMember(l, name27, Lua_UnityEngine_UI_ScrollRect.<>f__mg$cache3C, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(ScrollRect), typeof(UIBehaviour));
	}

	// Token: 0x04019DC3 RID: 105923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019DC4 RID: 105924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019DC5 RID: 105925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019DC6 RID: 105926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019DC7 RID: 105927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019DC8 RID: 105928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019DC9 RID: 105929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019DCA RID: 105930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019DCB RID: 105931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019DCC RID: 105932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019DCD RID: 105933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019DCE RID: 105934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019DCF RID: 105935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019DD0 RID: 105936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019DD1 RID: 105937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019DD2 RID: 105938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019DD3 RID: 105939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019DD4 RID: 105940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019DD5 RID: 105941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019DD6 RID: 105942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019DD7 RID: 105943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019DD8 RID: 105944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019DD9 RID: 105945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019DDA RID: 105946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019DDB RID: 105947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019DDC RID: 105948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019DDD RID: 105949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019DDE RID: 105950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019DDF RID: 105951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019DE0 RID: 105952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019DE1 RID: 105953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019DE2 RID: 105954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019DE3 RID: 105955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019DE4 RID: 105956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019DE5 RID: 105957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019DE6 RID: 105958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019DE7 RID: 105959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019DE8 RID: 105960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019DE9 RID: 105961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019DEA RID: 105962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019DEB RID: 105963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019DEC RID: 105964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019DED RID: 105965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019DEE RID: 105966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019DEF RID: 105967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019DF0 RID: 105968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019DF1 RID: 105969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019DF2 RID: 105970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019DF3 RID: 105971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019DF4 RID: 105972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04019DF5 RID: 105973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019DF6 RID: 105974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019DF7 RID: 105975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019DF8 RID: 105976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04019DF9 RID: 105977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019DFA RID: 105978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019DFB RID: 105979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019DFC RID: 105980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019DFD RID: 105981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019DFE RID: 105982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019DFF RID: 105983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;
}
