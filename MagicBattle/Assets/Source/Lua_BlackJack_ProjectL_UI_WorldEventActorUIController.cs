using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015E1 RID: 5601
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldEventActorUIController : LuaObject
{
	// Token: 0x06022375 RID: 140149 RVA: 0x00BB0A84 File Offset: 0x00BAEC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			ConfigDataEventInfo @event;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out @event);
			worldEventActorUIController.SetEvent(@event);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022376 RID: 140150 RVA: 0x00BB0ADC File Offset: 0x00BAECDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo = worldEventActorUIController.GetEventInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022377 RID: 140151 RVA: 0x00BB0B30 File Offset: 0x00BAED30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCanClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			bool canClick;
			LuaObject.checkType(l, 2, out canClick);
			worldEventActorUIController.SetCanClick(canClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022378 RID: 140152 RVA: 0x00BB0B88 File Offset: 0x00BAED88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.IgnoreClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022379 RID: 140153 RVA: 0x00BB0BD4 File Offset: 0x00BAEDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldEventActorUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602237A RID: 140154 RVA: 0x00BB0C2C File Offset: 0x00BAEE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldEventActorUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602237B RID: 140155 RVA: 0x00BB0C84 File Offset: 0x00BAEE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldEventActorUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602237C RID: 140156 RVA: 0x00BB0CDC File Offset: 0x00BAEEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602237D RID: 140157 RVA: 0x00BB0D30 File Offset: 0x00BAEF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnergy(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			int energy;
			LuaObject.checkType(l, 2, out energy);
			worldEventActorUIController.m_luaExportHelper.SetEnergy(energy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602237E RID: 140158 RVA: 0x00BB0D8C File Offset: 0x00BAEF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldEventActorUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602237F RID: 140159 RVA: 0x00BB0DF8 File Offset: 0x00BAEFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022380 RID: 140160 RVA: 0x00BB0E4C File Offset: 0x00BAF04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022381 RID: 140161 RVA: 0x00BB0EA0 File Offset: 0x00BAF0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldEventActorUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022382 RID: 140162 RVA: 0x00BB0F48 File Offset: 0x00BAF148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022383 RID: 140163 RVA: 0x00BB0F9C File Offset: 0x00BAF19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldEventActorUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022384 RID: 140164 RVA: 0x00BB1008 File Offset: 0x00BAF208
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
				WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldEventActorUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldEventActorUIController worldEventActorUIController2 = (WorldEventActorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldEventActorUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06022385 RID: 140165 RVA: 0x00BB1118 File Offset: 0x00BAF318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventActorUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022386 RID: 140166 RVA: 0x00BB1184 File Offset: 0x00BAF384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventActorUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022387 RID: 140167 RVA: 0x00BB11F0 File Offset: 0x00BAF3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventActorUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022388 RID: 140168 RVA: 0x00BB125C File Offset: 0x00BAF45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventActorUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022389 RID: 140169 RVA: 0x00BB12C8 File Offset: 0x00BAF4C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldEventActorUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldEventActorUIController worldEventActorUIController2 = (WorldEventActorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldEventActorUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602238A RID: 140170 RVA: 0x00BB13D8 File Offset: 0x00BAF5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			string s = worldEventActorUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602238B RID: 140171 RVA: 0x00BB1434 File Offset: 0x00BAF634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__callDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602238C RID: 140172 RVA: 0x00BB1488 File Offset: 0x00BAF688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__clearDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602238D RID: 140173 RVA: 0x00BB14DC File Offset: 0x00BAF6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__callDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602238E RID: 140174 RVA: 0x00BB1530 File Offset: 0x00BAF730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__clearDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602238F RID: 140175 RVA: 0x00BB1584 File Offset: 0x00BAF784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022390 RID: 140176 RVA: 0x00BB15D8 File Offset: 0x00BAF7D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			worldEventActorUIController.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022391 RID: 140177 RVA: 0x00BB162C File Offset: 0x00BAF82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventActorUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					worldEventActorUIController.EventOnPointerDown -= value;
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

	// Token: 0x06022392 RID: 140178 RVA: 0x00BB16AC File Offset: 0x00BAF8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventActorUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					worldEventActorUIController.EventOnPointerUp -= value;
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

	// Token: 0x06022393 RID: 140179 RVA: 0x00BB172C File Offset: 0x00BAF92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventActorUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					worldEventActorUIController.EventOnClick -= value;
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

	// Token: 0x06022394 RID: 140180 RVA: 0x00BB17AC File Offset: 0x00BAF9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventActorUIController.m_luaExportHelper.m_testText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022395 RID: 140181 RVA: 0x00BB1804 File Offset: 0x00BAFA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			Text testText;
			LuaObject.checkType<Text>(l, 2, out testText);
			worldEventActorUIController.m_luaExportHelper.m_testText = testText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022396 RID: 140182 RVA: 0x00BB1860 File Offset: 0x00BAFA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventActorUIController.m_luaExportHelper.m_iconGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022397 RID: 140183 RVA: 0x00BB18B8 File Offset: 0x00BAFAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			GameObject iconGameObject;
			LuaObject.checkType<GameObject>(l, 2, out iconGameObject);
			worldEventActorUIController.m_luaExportHelper.m_iconGameObject = iconGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022398 RID: 140184 RVA: 0x00BB1914 File Offset: 0x00BAFB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventActorUIController.m_luaExportHelper.m_hitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022399 RID: 140185 RVA: 0x00BB196C File Offset: 0x00BAFB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			GameObject hitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out hitGameObject);
			worldEventActorUIController.m_luaExportHelper.m_hitGameObject = hitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602239A RID: 140186 RVA: 0x00BB19C8 File Offset: 0x00BAFBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventActorUIController.m_luaExportHelper.m_eventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602239B RID: 140187 RVA: 0x00BB1A20 File Offset: 0x00BAFC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			worldEventActorUIController.m_luaExportHelper.m_eventInfo = eventInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602239C RID: 140188 RVA: 0x00BB1A7C File Offset: 0x00BAFC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventActorUIController.m_luaExportHelper.m_isPointerDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602239D RID: 140189 RVA: 0x00BB1AD4 File Offset: 0x00BAFCD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			bool isPointerDown;
			LuaObject.checkType(l, 2, out isPointerDown);
			worldEventActorUIController.m_luaExportHelper.m_isPointerDown = isPointerDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602239E RID: 140190 RVA: 0x00BB1B30 File Offset: 0x00BAFD30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventActorUIController.m_luaExportHelper.m_ignoreClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602239F RID: 140191 RVA: 0x00BB1B88 File Offset: 0x00BAFD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventActorUIController worldEventActorUIController = (WorldEventActorUIController)LuaObject.checkSelf(l);
			bool ignoreClick;
			LuaObject.checkType(l, 2, out ignoreClick);
			worldEventActorUIController.m_luaExportHelper.m_ignoreClick = ignoreClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A0 RID: 140192 RVA: 0x00BB1BE4 File Offset: 0x00BAFDE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldEventActorUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.SetEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.GetEventInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.SetCanClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.IgnoreClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.SetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1B);
		string name = "EventOnPointerDown";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1C, true);
		string name2 = "EventOnPointerUp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1D, true);
		string name3 = "EventOnClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1E, true);
		string name4 = "m_testText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.get_m_testText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_m_testText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache20, true);
		string name5 = "m_iconGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.get_m_iconGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_m_iconGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache22, true);
		string name6 = "m_hitGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.get_m_hitGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_m_hitGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache24, true);
		string name7 = "m_eventInfo";
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.get_m_eventInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_m_eventInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache26, true);
		string name8 = "m_isPointerDown";
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.get_m_isPointerDown);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_m_isPointerDown);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache28, true);
		string name9 = "m_ignoreClick";
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.get_m_ignoreClick);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.set_m_ignoreClick);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.<>f__mg$cache2A, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldEventActorUIController), typeof(UIControllerBase));
	}

	// Token: 0x04018195 RID: 98709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018196 RID: 98710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018197 RID: 98711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018198 RID: 98712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018199 RID: 98713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401819A RID: 98714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401819B RID: 98715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401819C RID: 98716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401819D RID: 98717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401819E RID: 98718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401819F RID: 98719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040181A0 RID: 98720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040181A1 RID: 98721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040181A2 RID: 98722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040181A3 RID: 98723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040181A4 RID: 98724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040181A5 RID: 98725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040181A6 RID: 98726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040181A7 RID: 98727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040181A8 RID: 98728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040181A9 RID: 98729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040181AA RID: 98730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040181AB RID: 98731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040181AC RID: 98732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040181AD RID: 98733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040181AE RID: 98734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040181AF RID: 98735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040181B0 RID: 98736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040181B1 RID: 98737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040181B2 RID: 98738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040181B3 RID: 98739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040181B4 RID: 98740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040181B5 RID: 98741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040181B6 RID: 98742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040181B7 RID: 98743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040181B8 RID: 98744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040181B9 RID: 98745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040181BA RID: 98746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040181BB RID: 98747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040181BC RID: 98748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040181BD RID: 98749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040181BE RID: 98750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040181BF RID: 98751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
