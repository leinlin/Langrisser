using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014C2 RID: 5314
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroExpItemUIController : LuaObject
{
	// Token: 0x0601F153 RID: 127315 RVA: 0x00A21DC8 File Offset: 0x00A1FFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitExpItem(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			float delay;
			LuaObject.checkType(l, 3, out delay);
			float interval;
			LuaObject.checkType(l, 4, out interval);
			Action eventOnLongPress;
			LuaObject.checkDelegate<Action>(l, 5, out eventOnLongPress);
			heroExpItemUIController.InitExpItem(bagItem, delay, interval, eventOnLongPress);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F154 RID: 127316 RVA: 0x00A21E48 File Offset: 0x00A20048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroExpItemUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F155 RID: 127317 RVA: 0x00A21EA0 File Offset: 0x00A200A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroExpItemUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F156 RID: 127318 RVA: 0x00A21EF8 File Offset: 0x00A200F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroExpItemUIController.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F157 RID: 127319 RVA: 0x00A21F50 File Offset: 0x00A20150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroExpItemUIController.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F158 RID: 127320 RVA: 0x00A21FA8 File Offset: 0x00A201A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroExpItemUIController.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F159 RID: 127321 RVA: 0x00A22000 File Offset: 0x00A20200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PassEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			PointerEventData data;
			LuaObject.checkType<PointerEventData>(l, 2, out data);
			ExecuteEvents.EventFunction<IEventSystemHandler> function;
			LuaObject.checkDelegate<ExecuteEvents.EventFunction<IEventSystemHandler>>(l, 3, out function);
			heroExpItemUIController.PassEvent<IEventSystemHandler>(data, function);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F15A RID: 127322 RVA: 0x00A22064 File Offset: 0x00A20264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F15B RID: 127323 RVA: 0x00A220B8 File Offset: 0x00A202B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F15C RID: 127324 RVA: 0x00A2210C File Offset: 0x00A2030C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroExpItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F15D RID: 127325 RVA: 0x00A22178 File Offset: 0x00A20378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F15E RID: 127326 RVA: 0x00A221CC File Offset: 0x00A203CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F15F RID: 127327 RVA: 0x00A22220 File Offset: 0x00A20420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = heroExpItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F160 RID: 127328 RVA: 0x00A222C8 File Offset: 0x00A204C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F161 RID: 127329 RVA: 0x00A2231C File Offset: 0x00A2051C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroExpItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F162 RID: 127330 RVA: 0x00A22388 File Offset: 0x00A20588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroExpItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroExpItemUIController heroExpItemUIController2 = (HeroExpItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroExpItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F163 RID: 127331 RVA: 0x00A22498 File Offset: 0x00A20698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroExpItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F164 RID: 127332 RVA: 0x00A22504 File Offset: 0x00A20704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroExpItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F165 RID: 127333 RVA: 0x00A22570 File Offset: 0x00A20770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroExpItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F166 RID: 127334 RVA: 0x00A225DC File Offset: 0x00A207DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroExpItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F167 RID: 127335 RVA: 0x00A22648 File Offset: 0x00A20848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroExpItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroExpItemUIController heroExpItemUIController2 = (HeroExpItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroExpItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F168 RID: 127336 RVA: 0x00A22758 File Offset: 0x00A20958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			string s = heroExpItemUIController.m_luaExportHelper.__callBase_ToString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F169 RID: 127337 RVA: 0x00A227B4 File Offset: 0x00A209B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_OnItemPointUp(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroExpItemUIController.m_luaExportHelper.__callDele_OnItemPointUp(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F16A RID: 127338 RVA: 0x00A22810 File Offset: 0x00A20A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_OnItemPointUp(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroExpItemUIController.m_luaExportHelper.__clearDele_OnItemPointUp(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F16B RID: 127339 RVA: 0x00A2286C File Offset: 0x00A20A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_OnItemPointDown(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			HeroExpItemUIController obj;
			LuaObject.checkType<HeroExpItemUIController>(l, 2, out obj);
			heroExpItemUIController.m_luaExportHelper.__callDele_OnItemPointDown(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F16C RID: 127340 RVA: 0x00A228C8 File Offset: 0x00A20AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_OnItemPointDown(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			HeroExpItemUIController obj;
			LuaObject.checkType<HeroExpItemUIController>(l, 2, out obj);
			heroExpItemUIController.m_luaExportHelper.__clearDele_OnItemPointDown(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F16D RID: 127341 RVA: 0x00A22924 File Offset: 0x00A20B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLongPress(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.__callDele_EventOnLongPress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F16E RID: 127342 RVA: 0x00A22978 File Offset: 0x00A20B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLongPress(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			heroExpItemUIController.m_luaExportHelper.__clearDele_EventOnLongPress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F16F RID: 127343 RVA: 0x00A229CC File Offset: 0x00A20BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OnItemPointUp(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroExpItemUIController.OnItemPointUp += value;
				}
				else if (num == 2)
				{
					heroExpItemUIController.OnItemPointUp -= value;
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

	// Token: 0x0601F170 RID: 127344 RVA: 0x00A22A4C File Offset: 0x00A20C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OnItemPointDown(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Action<HeroExpItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroExpItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroExpItemUIController.OnItemPointDown += value;
				}
				else if (num == 2)
				{
					heroExpItemUIController.OnItemPointDown -= value;
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

	// Token: 0x0601F171 RID: 127345 RVA: 0x00A22ACC File Offset: 0x00A20CCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F172 RID: 127346 RVA: 0x00A22B24 File Offset: 0x00A20D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			heroExpItemUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F173 RID: 127347 RVA: 0x00A22B80 File Offset: 0x00A20D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F174 RID: 127348 RVA: 0x00A22BD8 File Offset: 0x00A20DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			heroExpItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F175 RID: 127349 RVA: 0x00A22C34 File Offset: 0x00A20E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_frameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F176 RID: 127350 RVA: 0x00A22C8C File Offset: 0x00A20E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Image frameImage;
			LuaObject.checkType<Image>(l, 2, out frameImage);
			heroExpItemUIController.m_luaExportHelper.m_frameImage = frameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F177 RID: 127351 RVA: 0x00A22CE8 File Offset: 0x00A20EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLongPress(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroExpItemUIController.EventOnLongPress += value;
				}
				else if (num == 2)
				{
					heroExpItemUIController.EventOnLongPress -= value;
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

	// Token: 0x0601F178 RID: 127352 RVA: 0x00A22D68 File Offset: 0x00A20F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsPointDown(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.IsPointDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F179 RID: 127353 RVA: 0x00A22DBC File Offset: 0x00A20FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsPointDown(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			bool isPointDown;
			LuaObject.checkType(l, 2, out isPointDown);
			heroExpItemUIController.IsPointDown = isPointDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F17A RID: 127354 RVA: 0x00A22E14 File Offset: 0x00A21014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_usedCount(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.usedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F17B RID: 127355 RVA: 0x00A22E6C File Offset: 0x00A2106C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_usedCount(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			int usedCount;
			LuaObject.checkType(l, 2, out usedCount);
			heroExpItemUIController.m_luaExportHelper.usedCount = usedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F17C RID: 127356 RVA: 0x00A22EC8 File Offset: 0x00A210C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delay(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_delay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F17D RID: 127357 RVA: 0x00A22F20 File Offset: 0x00A21120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delay(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			heroExpItemUIController.m_luaExportHelper.m_delay = delay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F17E RID: 127358 RVA: 0x00A22F7C File Offset: 0x00A2117C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastInvokeTime(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_lastInvokeTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F17F RID: 127359 RVA: 0x00A22FD4 File Offset: 0x00A211D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lastInvokeTime(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			float lastInvokeTime;
			LuaObject.checkType(l, 2, out lastInvokeTime);
			heroExpItemUIController.m_luaExportHelper.m_lastInvokeTime = lastInvokeTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F180 RID: 127360 RVA: 0x00A23030 File Offset: 0x00A21230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isDragging(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_isDragging);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F181 RID: 127361 RVA: 0x00A23088 File Offset: 0x00A21288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDragging(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			bool isDragging;
			LuaObject.checkType(l, 2, out isDragging);
			heroExpItemUIController.m_luaExportHelper.m_isDragging = isDragging;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F182 RID: 127362 RVA: 0x00A230E4 File Offset: 0x00A212E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingGo(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_draggingGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F183 RID: 127363 RVA: 0x00A2313C File Offset: 0x00A2133C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingGo(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			GameObject draggingGo;
			LuaObject.checkType<GameObject>(l, 2, out draggingGo);
			heroExpItemUIController.m_luaExportHelper.m_draggingGo = draggingGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F184 RID: 127364 RVA: 0x00A23198 File Offset: 0x00A21398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startPressTime(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.m_startPressTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F185 RID: 127365 RVA: 0x00A231F0 File Offset: 0x00A213F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startPressTime(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			float startPressTime;
			LuaObject.checkType(l, 2, out startPressTime);
			heroExpItemUIController.m_luaExportHelper.m_startPressTime = startPressTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F186 RID: 127366 RVA: 0x00A2324C File Offset: 0x00A2144C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BagItem(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.BagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F187 RID: 127367 RVA: 0x00A232A0 File Offset: 0x00A214A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BagItem(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			heroExpItemUIController.m_luaExportHelper.BagItem = bagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F188 RID: 127368 RVA: 0x00A232FC File Offset: 0x00A214FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AddExpValue(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.AddExpValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F189 RID: 127369 RVA: 0x00A23350 File Offset: 0x00A21550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AddExpValue(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			int addExpValue;
			LuaObject.checkType(l, 2, out addExpValue);
			heroExpItemUIController.m_luaExportHelper.AddExpValue = addExpValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F18A RID: 127370 RVA: 0x00A233AC File Offset: 0x00A215AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Interval(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.Interval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F18B RID: 127371 RVA: 0x00A23404 File Offset: 0x00A21604
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Interval(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			float interval;
			LuaObject.checkType(l, 2, out interval);
			heroExpItemUIController.Interval = interval;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F18C RID: 127372 RVA: 0x00A2345C File Offset: 0x00A2165C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Delay(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpItemUIController.m_luaExportHelper.Delay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F18D RID: 127373 RVA: 0x00A234B4 File Offset: 0x00A216B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Delay(IntPtr l)
	{
		int result;
		try
		{
			HeroExpItemUIController heroExpItemUIController = (HeroExpItemUIController)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			heroExpItemUIController.Delay = delay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F18E RID: 127374 RVA: 0x00A2350C File Offset: 0x00A2170C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroExpItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.InitExpItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.PassEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callDele_OnItemPointUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__clearDele_OnItemPointUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callDele_OnItemPointDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__clearDele_OnItemPointDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__callDele_EventOnLongPress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.__clearDele_EventOnLongPress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1B);
		string name = "OnItemPointUp";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_OnItemPointUp);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1C, true);
		string name2 = "OnItemPointDown";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_OnItemPointDown);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1D, true);
		string name3 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_countText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_countText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache1F, true);
		string name4 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_iconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache21, true);
		string name5 = "m_frameImage";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_frameImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_frameImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache23, true);
		string name6 = "EventOnLongPress";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_EventOnLongPress);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache24, true);
		string name7 = "IsPointDown";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_IsPointDown);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_IsPointDown);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache26, true);
		string name8 = "usedCount";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_usedCount);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_usedCount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache28, true);
		string name9 = "m_delay";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_delay);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_delay);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2A, true);
		string name10 = "m_lastInvokeTime";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_lastInvokeTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_lastInvokeTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2C, true);
		string name11 = "m_isDragging";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_isDragging);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_isDragging);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2E, true);
		string name12 = "m_draggingGo";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_draggingGo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_draggingGo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache30, true);
		string name13 = "m_startPressTime";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_m_startPressTime);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_m_startPressTime);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache32, true);
		string name14 = "BagItem";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_BagItem);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_BagItem);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache34, true);
		string name15 = "AddExpValue";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_AddExpValue);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_AddExpValue);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache36, true);
		string name16 = "Interval";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_Interval);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_Interval);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache38, true);
		string name17 = "Delay";
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.get_Delay);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.set_Delay);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.<>f__mg$cache3A, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroExpItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040151B1 RID: 86449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040151B2 RID: 86450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040151B3 RID: 86451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040151B4 RID: 86452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040151B5 RID: 86453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040151B6 RID: 86454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040151B7 RID: 86455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040151B8 RID: 86456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040151B9 RID: 86457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040151BA RID: 86458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040151BB RID: 86459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040151BC RID: 86460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040151BD RID: 86461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040151BE RID: 86462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040151BF RID: 86463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040151C0 RID: 86464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040151C1 RID: 86465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040151C2 RID: 86466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040151C3 RID: 86467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040151C4 RID: 86468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040151C5 RID: 86469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040151C6 RID: 86470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040151C7 RID: 86471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040151C8 RID: 86472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040151C9 RID: 86473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040151CA RID: 86474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040151CB RID: 86475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040151CC RID: 86476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040151CD RID: 86477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040151CE RID: 86478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040151CF RID: 86479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040151D0 RID: 86480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040151D1 RID: 86481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040151D2 RID: 86482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040151D3 RID: 86483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040151D4 RID: 86484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040151D5 RID: 86485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040151D6 RID: 86486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040151D7 RID: 86487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040151D8 RID: 86488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040151D9 RID: 86489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040151DA RID: 86490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040151DB RID: 86491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040151DC RID: 86492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040151DD RID: 86493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040151DE RID: 86494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040151DF RID: 86495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040151E0 RID: 86496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040151E1 RID: 86497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040151E2 RID: 86498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040151E3 RID: 86499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040151E4 RID: 86500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040151E5 RID: 86501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040151E6 RID: 86502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040151E7 RID: 86503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040151E8 RID: 86504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040151E9 RID: 86505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040151EA RID: 86506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040151EB RID: 86507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
