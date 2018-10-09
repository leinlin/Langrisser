using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200154C RID: 5452
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController : LuaObject
{
	// Token: 0x060209A6 RID: 133542 RVA: 0x00AE3BEC File Offset: 0x00AE1DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			rankingSubMenuUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209A7 RID: 133543 RVA: 0x00AE3C44 File Offset: 0x00AE1E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			rankingSubMenuUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209A8 RID: 133544 RVA: 0x00AE3C9C File Offset: 0x00AE1E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			rankingSubMenuUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209A9 RID: 133545 RVA: 0x00AE3CF4 File Offset: 0x00AE1EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			rankingSubMenuUIController.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209AA RID: 133546 RVA: 0x00AE3D4C File Offset: 0x00AE1F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			rankingSubMenuUIController.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209AB RID: 133547 RVA: 0x00AE3DA4 File Offset: 0x00AE1FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			rankingSubMenuUIController.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209AC RID: 133548 RVA: 0x00AE3DFC File Offset: 0x00AE1FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PassEvent(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			PointerEventData data;
			LuaObject.checkType<PointerEventData>(l, 2, out data);
			ExecuteEvents.EventFunction<IEventSystemHandler> function;
			LuaObject.checkDelegate<ExecuteEvents.EventFunction<IEventSystemHandler>>(l, 3, out function);
			rankingSubMenuUIController.PassEvent<IEventSystemHandler>(data, function);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209AD RID: 133549 RVA: 0x00AE3E60 File Offset: 0x00AE2060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209AE RID: 133550 RVA: 0x00AE3ECC File Offset: 0x00AE20CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209AF RID: 133551 RVA: 0x00AE3F20 File Offset: 0x00AE2120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B0 RID: 133552 RVA: 0x00AE3F74 File Offset: 0x00AE2174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = rankingSubMenuUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060209B1 RID: 133553 RVA: 0x00AE401C File Offset: 0x00AE221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B2 RID: 133554 RVA: 0x00AE4070 File Offset: 0x00AE2270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B3 RID: 133555 RVA: 0x00AE40DC File Offset: 0x00AE22DC
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
				RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rankingSubMenuUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RankingSubMenuUIController rankingSubMenuUIController2 = (RankingSubMenuUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rankingSubMenuUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060209B4 RID: 133556 RVA: 0x00AE41EC File Offset: 0x00AE23EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B5 RID: 133557 RVA: 0x00AE4258 File Offset: 0x00AE2458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B6 RID: 133558 RVA: 0x00AE42C4 File Offset: 0x00AE24C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B7 RID: 133559 RVA: 0x00AE4330 File Offset: 0x00AE2530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingSubMenuUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209B8 RID: 133560 RVA: 0x00AE439C File Offset: 0x00AE259C
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
				RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rankingSubMenuUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RankingSubMenuUIController rankingSubMenuUIController2 = (RankingSubMenuUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rankingSubMenuUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060209B9 RID: 133561 RVA: 0x00AE44AC File Offset: 0x00AE26AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			string s = rankingSubMenuUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060209BA RID: 133562 RVA: 0x00AE4508 File Offset: 0x00AE2708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNoneSubMenuAreaClick(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			rankingSubMenuUIController.m_luaExportHelper.__callDele_EventOnNoneSubMenuAreaClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209BB RID: 133563 RVA: 0x00AE455C File Offset: 0x00AE275C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNoneSubMenuAreaClick(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			rankingSubMenuUIController.m_luaExportHelper.__clearDele_EventOnNoneSubMenuAreaClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209BC RID: 133564 RVA: 0x00AE45B0 File Offset: 0x00AE27B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNoneSubMenuAreaClick(IntPtr l)
	{
		int result;
		try
		{
			RankingSubMenuUIController rankingSubMenuUIController = (RankingSubMenuUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rankingSubMenuUIController.EventOnNoneSubMenuAreaClick += value;
				}
				else if (num == 2)
				{
					rankingSubMenuUIController.EventOnNoneSubMenuAreaClick -= value;
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

	// Token: 0x060209BD RID: 133565 RVA: 0x00AE4630 File Offset: 0x00AE2830
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RankingSubMenuUIController");
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.PassEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__callDele_EventOnNoneSubMenuAreaClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.__clearDele_EventOnNoneSubMenuAreaClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache15);
		string name = "EventOnNoneSubMenuAreaClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.set_EventOnNoneSubMenuAreaClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.<>f__mg$cache16, true);
		LuaObject.createTypeMetatable(l, null, typeof(RankingSubMenuUIController), typeof(UIControllerBase));
	}

	// Token: 0x040168F0 RID: 92400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040168F1 RID: 92401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040168F2 RID: 92402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040168F3 RID: 92403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040168F4 RID: 92404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040168F5 RID: 92405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040168F6 RID: 92406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040168F7 RID: 92407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040168F8 RID: 92408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040168F9 RID: 92409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040168FA RID: 92410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040168FB RID: 92411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040168FC RID: 92412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040168FD RID: 92413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040168FE RID: 92414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040168FF RID: 92415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016900 RID: 92416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016901 RID: 92417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016902 RID: 92418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016903 RID: 92419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016904 RID: 92420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016905 RID: 92421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016906 RID: 92422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
