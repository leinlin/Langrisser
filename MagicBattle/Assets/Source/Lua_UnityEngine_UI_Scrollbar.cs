using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001854 RID: 6228
[Preserve]
public class Lua_UnityEngine_UI_Scrollbar : LuaObject
{
	// Token: 0x060241F2 RID: 147954 RVA: 0x00CAF204 File Offset: 0x00CAD404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			CanvasUpdate executing;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out executing);
			scrollbar.Rebuild(executing);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F3 RID: 147955 RVA: 0x00CAF25C File Offset: 0x00CAD45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			scrollbar.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F4 RID: 147956 RVA: 0x00CAF2A8 File Offset: 0x00CAD4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			scrollbar.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F5 RID: 147957 RVA: 0x00CAF2F4 File Offset: 0x00CAD4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollbar.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F6 RID: 147958 RVA: 0x00CAF34C File Offset: 0x00CAD54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollbar.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F7 RID: 147959 RVA: 0x00CAF3A4 File Offset: 0x00CAD5A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollbar.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F8 RID: 147960 RVA: 0x00CAF3FC File Offset: 0x00CAD5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollbar.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F9 RID: 147961 RVA: 0x00CAF454 File Offset: 0x00CAD654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMove(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			AxisEventData eventData;
			LuaObject.checkType<AxisEventData>(l, 2, out eventData);
			scrollbar.OnMove(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241FA RID: 147962 RVA: 0x00CAF4AC File Offset: 0x00CAD6AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindSelectableOnLeft(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Selectable o = scrollbar.FindSelectableOnLeft();
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

	// Token: 0x060241FB RID: 147963 RVA: 0x00CAF500 File Offset: 0x00CAD700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnRight(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Selectable o = scrollbar.FindSelectableOnRight();
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

	// Token: 0x060241FC RID: 147964 RVA: 0x00CAF554 File Offset: 0x00CAD754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnUp(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Selectable o = scrollbar.FindSelectableOnUp();
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

	// Token: 0x060241FD RID: 147965 RVA: 0x00CAF5A8 File Offset: 0x00CAD7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnDown(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Selectable o = scrollbar.FindSelectableOnDown();
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

	// Token: 0x060241FE RID: 147966 RVA: 0x00CAF5FC File Offset: 0x00CAD7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInitializePotentialDrag(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollbar.OnInitializePotentialDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241FF RID: 147967 RVA: 0x00CAF654 File Offset: 0x00CAD854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Scrollbar.Direction direction;
			LuaObject.checkEnum<Scrollbar.Direction>(l, 2, out direction);
			bool includeRectLayouts;
			LuaObject.checkType(l, 3, out includeRectLayouts);
			scrollbar.SetDirection(direction, includeRectLayouts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024200 RID: 147968 RVA: 0x00CAF6B8 File Offset: 0x00CAD8B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_handleRect(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollbar.handleRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024201 RID: 147969 RVA: 0x00CAF70C File Offset: 0x00CAD90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_handleRect(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			RectTransform handleRect;
			LuaObject.checkType<RectTransform>(l, 2, out handleRect);
			scrollbar.handleRect = handleRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024202 RID: 147970 RVA: 0x00CAF764 File Offset: 0x00CAD964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_direction(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)scrollbar.direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024203 RID: 147971 RVA: 0x00CAF7B8 File Offset: 0x00CAD9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_direction(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Scrollbar.Direction direction;
			LuaObject.checkEnum<Scrollbar.Direction>(l, 2, out direction);
			scrollbar.direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024204 RID: 147972 RVA: 0x00CAF810 File Offset: 0x00CADA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollbar.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024205 RID: 147973 RVA: 0x00CAF864 File Offset: 0x00CADA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_value(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			float value;
			LuaObject.checkType(l, 2, out value);
			scrollbar.value = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024206 RID: 147974 RVA: 0x00CAF8BC File Offset: 0x00CADABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollbar.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024207 RID: 147975 RVA: 0x00CAF910 File Offset: 0x00CADB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			float size;
			LuaObject.checkType(l, 2, out size);
			scrollbar.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024208 RID: 147976 RVA: 0x00CAF968 File Offset: 0x00CADB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_numberOfSteps(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollbar.numberOfSteps);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024209 RID: 147977 RVA: 0x00CAF9BC File Offset: 0x00CADBBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_numberOfSteps(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			int numberOfSteps;
			LuaObject.checkType(l, 2, out numberOfSteps);
			scrollbar.numberOfSteps = numberOfSteps;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602420A RID: 147978 RVA: 0x00CAFA14 File Offset: 0x00CADC14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollbar.onValueChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602420B RID: 147979 RVA: 0x00CAFA68 File Offset: 0x00CADC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar scrollbar = (Scrollbar)LuaObject.checkSelf(l);
			Scrollbar.ScrollEvent onValueChanged;
			LuaObject.checkType<Scrollbar.ScrollEvent>(l, 2, out onValueChanged);
			scrollbar.onValueChanged = onValueChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602420C RID: 147980 RVA: 0x00CAFAC0 File Offset: 0x00CADCC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Scrollbar");
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.OnDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.OnMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.FindSelectableOnLeft);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.FindSelectableOnRight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.FindSelectableOnUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheA);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.FindSelectableOnDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheB);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.OnInitializePotentialDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheC);
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.SetDirection);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheD);
		string name = "handleRect";
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.get_handleRect);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.set_handleRect);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cacheF, true);
		string name2 = "direction";
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.get_direction);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.set_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache11, true);
		string name3 = "value";
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.get_value);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.set_value);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache13, true);
		string name4 = "size";
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.get_size);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.set_size);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache15, true);
		string name5 = "numberOfSteps";
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.get_numberOfSteps);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.set_numberOfSteps);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache17, true);
		string name6 = "onValueChanged";
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.get_onValueChanged);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache18;
		if (Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar.set_onValueChanged);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_Scrollbar.<>f__mg$cache19, true);
		LuaObject.createTypeMetatable(l, null, typeof(Scrollbar), typeof(Selectable));
	}

	// Token: 0x04019DA8 RID: 105896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019DA9 RID: 105897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019DAA RID: 105898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019DAB RID: 105899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019DAC RID: 105900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019DAD RID: 105901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019DAE RID: 105902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019DAF RID: 105903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019DB0 RID: 105904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019DB1 RID: 105905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019DB2 RID: 105906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019DB3 RID: 105907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019DB4 RID: 105908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019DB5 RID: 105909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019DB6 RID: 105910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019DB7 RID: 105911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019DB8 RID: 105912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019DB9 RID: 105913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019DBA RID: 105914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019DBB RID: 105915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019DBC RID: 105916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019DBD RID: 105917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019DBE RID: 105918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019DBF RID: 105919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019DC0 RID: 105920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019DC1 RID: 105921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
