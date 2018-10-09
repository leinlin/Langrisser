using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200185E RID: 6238
[Preserve]
public class Lua_UnityEngine_UI_Slider : LuaObject
{
	// Token: 0x06024286 RID: 148102 RVA: 0x00CB3100 File Offset: 0x00CB1300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			CanvasUpdate executing;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out executing);
			slider.Rebuild(executing);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024287 RID: 148103 RVA: 0x00CB3158 File Offset: 0x00CB1358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			slider.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024288 RID: 148104 RVA: 0x00CB31A4 File Offset: 0x00CB13A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			slider.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024289 RID: 148105 RVA: 0x00CB31F0 File Offset: 0x00CB13F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			slider.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602428A RID: 148106 RVA: 0x00CB3248 File Offset: 0x00CB1448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			slider.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602428B RID: 148107 RVA: 0x00CB32A0 File Offset: 0x00CB14A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMove(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			AxisEventData eventData;
			LuaObject.checkType<AxisEventData>(l, 2, out eventData);
			slider.OnMove(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602428C RID: 148108 RVA: 0x00CB32F8 File Offset: 0x00CB14F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnLeft(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Selectable o = slider.FindSelectableOnLeft();
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

	// Token: 0x0602428D RID: 148109 RVA: 0x00CB334C File Offset: 0x00CB154C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnRight(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Selectable o = slider.FindSelectableOnRight();
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

	// Token: 0x0602428E RID: 148110 RVA: 0x00CB33A0 File Offset: 0x00CB15A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnUp(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Selectable o = slider.FindSelectableOnUp();
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

	// Token: 0x0602428F RID: 148111 RVA: 0x00CB33F4 File Offset: 0x00CB15F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnDown(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Selectable o = slider.FindSelectableOnDown();
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

	// Token: 0x06024290 RID: 148112 RVA: 0x00CB3448 File Offset: 0x00CB1648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInitializePotentialDrag(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			slider.OnInitializePotentialDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024291 RID: 148113 RVA: 0x00CB34A0 File Offset: 0x00CB16A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Slider.Direction direction;
			LuaObject.checkEnum<Slider.Direction>(l, 2, out direction);
			bool includeRectLayouts;
			LuaObject.checkType(l, 3, out includeRectLayouts);
			slider.SetDirection(direction, includeRectLayouts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024292 RID: 148114 RVA: 0x00CB3504 File Offset: 0x00CB1704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fillRect(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.fillRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024293 RID: 148115 RVA: 0x00CB3558 File Offset: 0x00CB1758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fillRect(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			RectTransform fillRect;
			LuaObject.checkType<RectTransform>(l, 2, out fillRect);
			slider.fillRect = fillRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024294 RID: 148116 RVA: 0x00CB35B0 File Offset: 0x00CB17B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_handleRect(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.handleRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024295 RID: 148117 RVA: 0x00CB3604 File Offset: 0x00CB1804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_handleRect(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			RectTransform handleRect;
			LuaObject.checkType<RectTransform>(l, 2, out handleRect);
			slider.handleRect = handleRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024296 RID: 148118 RVA: 0x00CB365C File Offset: 0x00CB185C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_direction(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)slider.direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024297 RID: 148119 RVA: 0x00CB36B0 File Offset: 0x00CB18B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_direction(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Slider.Direction direction;
			LuaObject.checkEnum<Slider.Direction>(l, 2, out direction);
			slider.direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024298 RID: 148120 RVA: 0x00CB3708 File Offset: 0x00CB1908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minValue(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.minValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024299 RID: 148121 RVA: 0x00CB375C File Offset: 0x00CB195C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_minValue(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			float minValue;
			LuaObject.checkType(l, 2, out minValue);
			slider.minValue = minValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602429A RID: 148122 RVA: 0x00CB37B4 File Offset: 0x00CB19B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxValue(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.maxValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602429B RID: 148123 RVA: 0x00CB3808 File Offset: 0x00CB1A08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_maxValue(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			float maxValue;
			LuaObject.checkType(l, 2, out maxValue);
			slider.maxValue = maxValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602429C RID: 148124 RVA: 0x00CB3860 File Offset: 0x00CB1A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wholeNumbers(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.wholeNumbers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602429D RID: 148125 RVA: 0x00CB38B4 File Offset: 0x00CB1AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wholeNumbers(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			bool wholeNumbers;
			LuaObject.checkType(l, 2, out wholeNumbers);
			slider.wholeNumbers = wholeNumbers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602429E RID: 148126 RVA: 0x00CB390C File Offset: 0x00CB1B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602429F RID: 148127 RVA: 0x00CB3960 File Offset: 0x00CB1B60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_value(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			float value;
			LuaObject.checkType(l, 2, out value);
			slider.value = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242A0 RID: 148128 RVA: 0x00CB39B8 File Offset: 0x00CB1BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedValue(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.normalizedValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242A1 RID: 148129 RVA: 0x00CB3A0C File Offset: 0x00CB1C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_normalizedValue(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			float normalizedValue;
			LuaObject.checkType(l, 2, out normalizedValue);
			slider.normalizedValue = normalizedValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242A2 RID: 148130 RVA: 0x00CB3A64 File Offset: 0x00CB1C64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, slider.onValueChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242A3 RID: 148131 RVA: 0x00CB3AB8 File Offset: 0x00CB1CB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Slider slider = (Slider)LuaObject.checkSelf(l);
			Slider.SliderEvent onValueChanged;
			LuaObject.checkType<Slider.SliderEvent>(l, 2, out onValueChanged);
			slider.onValueChanged = onValueChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242A4 RID: 148132 RVA: 0x00CB3B10 File Offset: 0x00CB1D10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Slider");
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.OnDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.OnMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.FindSelectableOnLeft);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.FindSelectableOnRight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.FindSelectableOnUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.FindSelectableOnDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Slider.OnInitializePotentialDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cacheA);
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Slider.SetDirection);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Slider.<>f__mg$cacheB);
		string name = "fillRect";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_fillRect);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Slider.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_fillRect);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Slider.<>f__mg$cacheD, true);
		string name2 = "handleRect";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_handleRect);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Slider.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_handleRect);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Slider.<>f__mg$cacheF, true);
		string name3 = "direction";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_direction);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Slider.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_direction);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Slider.<>f__mg$cache11, true);
		string name4 = "minValue";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_minValue);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Slider.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_minValue);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_Slider.<>f__mg$cache13, true);
		string name5 = "maxValue";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_maxValue);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Slider.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_maxValue);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_Slider.<>f__mg$cache15, true);
		string name6 = "wholeNumbers";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_wholeNumbers);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_Slider.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_wholeNumbers);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_Slider.<>f__mg$cache17, true);
		string name7 = "value";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_value);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_Slider.<>f__mg$cache18;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_value);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_Slider.<>f__mg$cache19, true);
		string name8 = "normalizedValue";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_normalizedValue);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_Slider.<>f__mg$cache1A;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_normalizedValue);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UI_Slider.<>f__mg$cache1B, true);
		string name9 = "onValueChanged";
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_Slider.get_onValueChanged);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_Slider.<>f__mg$cache1C;
		if (Lua_UnityEngine_UI_Slider.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_Slider.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_Slider.set_onValueChanged);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_UI_Slider.<>f__mg$cache1D, true);
		LuaObject.createTypeMetatable(l, null, typeof(Slider), typeof(Selectable));
	}

	// Token: 0x04019E28 RID: 106024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E29 RID: 106025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E2A RID: 106026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E2B RID: 106027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E2C RID: 106028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E2D RID: 106029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E2E RID: 106030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019E2F RID: 106031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019E30 RID: 106032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019E31 RID: 106033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019E32 RID: 106034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019E33 RID: 106035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019E34 RID: 106036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019E35 RID: 106037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019E36 RID: 106038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019E37 RID: 106039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019E38 RID: 106040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019E39 RID: 106041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019E3A RID: 106042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019E3B RID: 106043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019E3C RID: 106044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019E3D RID: 106045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019E3E RID: 106046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019E3F RID: 106047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019E40 RID: 106048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019E41 RID: 106049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019E42 RID: 106050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019E43 RID: 106051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019E44 RID: 106052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019E45 RID: 106053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
