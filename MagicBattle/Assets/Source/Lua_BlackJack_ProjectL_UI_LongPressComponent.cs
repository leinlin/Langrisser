using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020014FF RID: 5375
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LongPressComponent : LuaObject
{
	// Token: 0x0601FD2C RID: 130348 RVA: 0x00A80208 File Offset: 0x00A7E408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBasicParam(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			float interval;
			LuaObject.checkType(l, 3, out interval);
			Action eventOnLongPress;
			LuaObject.checkDelegate<Action>(l, 4, out eventOnLongPress);
			Action eventOnPointDown;
			LuaObject.checkDelegate<Action>(l, 5, out eventOnPointDown);
			Action eventOnPointUp;
			LuaObject.checkDelegate<Action>(l, 6, out eventOnPointUp);
			bool isNeedEventOnLongPressLoop;
			LuaObject.checkType(l, 7, out isNeedEventOnLongPressLoop);
			longPressComponent.SetBasicParam(delay, interval, eventOnLongPress, eventOnPointDown, eventOnPointUp, isNeedEventOnLongPressLoop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD2D RID: 130349 RVA: 0x00A802A0 File Offset: 0x00A7E4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			longPressComponent.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD2E RID: 130350 RVA: 0x00A802F8 File Offset: 0x00A7E4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			longPressComponent.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD2F RID: 130351 RVA: 0x00A80350 File Offset: 0x00A7E550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerExit(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			longPressComponent.OnPointerExit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD30 RID: 130352 RVA: 0x00A803A8 File Offset: 0x00A7E5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD31 RID: 130353 RVA: 0x00A803FC File Offset: 0x00A7E5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLongPress(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.__callDele_EventOnLongPress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD32 RID: 130354 RVA: 0x00A80450 File Offset: 0x00A7E650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLongPress(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.__clearDele_EventOnLongPress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD33 RID: 130355 RVA: 0x00A804A4 File Offset: 0x00A7E6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointDown(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.__callDele_EventOnPointDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD34 RID: 130356 RVA: 0x00A804F8 File Offset: 0x00A7E6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointDown(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.__clearDele_EventOnPointDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD35 RID: 130357 RVA: 0x00A8054C File Offset: 0x00A7E74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointUp(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.__callDele_EventOnPointUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD36 RID: 130358 RVA: 0x00A805A0 File Offset: 0x00A7E7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointUp(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			longPressComponent.m_luaExportHelper.__clearDele_EventOnPointUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD37 RID: 130359 RVA: 0x00A805F4 File Offset: 0x00A7E7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLongPress(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					longPressComponent.m_luaExportHelper.EventOnLongPress += value;
				}
				else if (num == 2)
				{
					longPressComponent.m_luaExportHelper.EventOnLongPress -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD38 RID: 130360 RVA: 0x00A8067C File Offset: 0x00A7E87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointDown(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					longPressComponent.m_luaExportHelper.EventOnPointDown += value;
				}
				else if (num == 2)
				{
					longPressComponent.m_luaExportHelper.EventOnPointDown -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD39 RID: 130361 RVA: 0x00A80704 File Offset: 0x00A7E904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointUp(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					longPressComponent.m_luaExportHelper.EventOnPointUp += value;
				}
				else if (num == 2)
				{
					longPressComponent.m_luaExportHelper.EventOnPointUp -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD3A RID: 130362 RVA: 0x00A8078C File Offset: 0x00A7E98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasInvokeLongPressEvent(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.hasInvokeLongPressEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD3B RID: 130363 RVA: 0x00A807E4 File Offset: 0x00A7E9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hasInvokeLongPressEvent(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			bool hasInvokeLongPressEvent;
			LuaObject.checkType(l, 2, out hasInvokeLongPressEvent);
			longPressComponent.m_luaExportHelper.hasInvokeLongPressEvent = hasInvokeLongPressEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD3C RID: 130364 RVA: 0x00A80840 File Offset: 0x00A7EA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNeedEventOnLongPressLoop(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.IsNeedEventOnLongPressLoop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD3D RID: 130365 RVA: 0x00A80898 File Offset: 0x00A7EA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNeedEventOnLongPressLoop(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			bool isNeedEventOnLongPressLoop;
			LuaObject.checkType(l, 2, out isNeedEventOnLongPressLoop);
			longPressComponent.m_luaExportHelper.IsNeedEventOnLongPressLoop = isNeedEventOnLongPressLoop;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD3E RID: 130366 RVA: 0x00A808F4 File Offset: 0x00A7EAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPointDown(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.m_isPointDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD3F RID: 130367 RVA: 0x00A8094C File Offset: 0x00A7EB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPointDown(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			bool isPointDown;
			LuaObject.checkType(l, 2, out isPointDown);
			longPressComponent.m_luaExportHelper.m_isPointDown = isPointDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD40 RID: 130368 RVA: 0x00A809A8 File Offset: 0x00A7EBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastInvokeTime(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.m_lastInvokeTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD41 RID: 130369 RVA: 0x00A80A00 File Offset: 0x00A7EC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastInvokeTime(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			float lastInvokeTime;
			LuaObject.checkType(l, 2, out lastInvokeTime);
			longPressComponent.m_luaExportHelper.m_lastInvokeTime = lastInvokeTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD42 RID: 130370 RVA: 0x00A80A5C File Offset: 0x00A7EC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delay(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.m_delay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD43 RID: 130371 RVA: 0x00A80AB4 File Offset: 0x00A7ECB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delay(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			longPressComponent.m_luaExportHelper.m_delay = delay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD44 RID: 130372 RVA: 0x00A80B10 File Offset: 0x00A7ED10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Interval(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.Interval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD45 RID: 130373 RVA: 0x00A80B68 File Offset: 0x00A7ED68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Interval(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			float interval;
			LuaObject.checkType(l, 2, out interval);
			longPressComponent.Interval = interval;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD46 RID: 130374 RVA: 0x00A80BC0 File Offset: 0x00A7EDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Delay(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, longPressComponent.m_luaExportHelper.Delay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD47 RID: 130375 RVA: 0x00A80C18 File Offset: 0x00A7EE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Delay(IntPtr l)
	{
		int result;
		try
		{
			LongPressComponent longPressComponent = (LongPressComponent)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			longPressComponent.Delay = delay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD48 RID: 130376 RVA: 0x00A80C70 File Offset: 0x00A7EE70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LongPressComponent");
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.SetBasicParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.OnPointerExit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.__callDele_EventOnLongPress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.__clearDele_EventOnLongPress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.__callDele_EventOnPointDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.__clearDele_EventOnPointDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.__callDele_EventOnPointUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.__clearDele_EventOnPointUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheA);
		string name = "EventOnLongPress";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_EventOnLongPress);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheB, true);
		string name2 = "EventOnPointDown";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_EventOnPointDown);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheC, true);
		string name3 = "EventOnPointUp";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_EventOnPointUp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheD, true);
		string name4 = "hasInvokeLongPressEvent";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_hasInvokeLongPressEvent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_hasInvokeLongPressEvent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cacheF, true);
		string name5 = "IsNeedEventOnLongPressLoop";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_IsNeedEventOnLongPressLoop);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_IsNeedEventOnLongPressLoop);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache11, true);
		string name6 = "m_isPointDown";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_m_isPointDown);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_m_isPointDown);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache13, true);
		string name7 = "m_lastInvokeTime";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_m_lastInvokeTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_m_lastInvokeTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache15, true);
		string name8 = "m_delay";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_m_delay);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_m_delay);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache17, true);
		string name9 = "Interval";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_Interval);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_Interval);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache19, true);
		string name10 = "Delay";
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.get_Delay);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LongPressComponent.set_Delay);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_LongPressComponent.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(LongPressComponent), typeof(MonoBehaviour));
	}

	// Token: 0x04015D10 RID: 89360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015D11 RID: 89361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015D12 RID: 89362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015D13 RID: 89363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015D14 RID: 89364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015D15 RID: 89365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015D16 RID: 89366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015D17 RID: 89367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015D18 RID: 89368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015D19 RID: 89369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015D1A RID: 89370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015D1B RID: 89371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015D1C RID: 89372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015D1D RID: 89373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015D1E RID: 89374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015D1F RID: 89375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015D20 RID: 89376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015D21 RID: 89377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015D22 RID: 89378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015D23 RID: 89379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015D24 RID: 89380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015D25 RID: 89381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015D26 RID: 89382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015D27 RID: 89383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015D28 RID: 89384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015D29 RID: 89385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015D2A RID: 89386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015D2B RID: 89387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
