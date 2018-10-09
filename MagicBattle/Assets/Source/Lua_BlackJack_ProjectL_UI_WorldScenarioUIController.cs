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

// Token: 0x020015E8 RID: 5608
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldScenarioUIController : LuaObject
{
	// Token: 0x06022493 RID: 140435 RVA: 0x00BB9EF4 File Offset: 0x00BB80F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldScenarioUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022494 RID: 140436 RVA: 0x00BB9F4C File Offset: 0x00BB814C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldScenarioUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022495 RID: 140437 RVA: 0x00BB9FA4 File Offset: 0x00BB81A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldScenarioUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022496 RID: 140438 RVA: 0x00BB9FFC File Offset: 0x00BB81FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022497 RID: 140439 RVA: 0x00BBA050 File Offset: 0x00BB8250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldScenarioUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022498 RID: 140440 RVA: 0x00BBA0BC File Offset: 0x00BB82BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022499 RID: 140441 RVA: 0x00BBA110 File Offset: 0x00BB8310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602249A RID: 140442 RVA: 0x00BBA164 File Offset: 0x00BB8364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldScenarioUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602249B RID: 140443 RVA: 0x00BBA20C File Offset: 0x00BB840C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602249C RID: 140444 RVA: 0x00BBA260 File Offset: 0x00BB8460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldScenarioUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602249D RID: 140445 RVA: 0x00BBA2CC File Offset: 0x00BB84CC
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
				WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldScenarioUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldScenarioUIController worldScenarioUIController2 = (WorldScenarioUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldScenarioUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602249E RID: 140446 RVA: 0x00BBA3DC File Offset: 0x00BB85DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldScenarioUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602249F RID: 140447 RVA: 0x00BBA448 File Offset: 0x00BB8648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldScenarioUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A0 RID: 140448 RVA: 0x00BBA4B4 File Offset: 0x00BB86B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldScenarioUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A1 RID: 140449 RVA: 0x00BBA520 File Offset: 0x00BB8720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldScenarioUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A2 RID: 140450 RVA: 0x00BBA58C File Offset: 0x00BB878C
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
				WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldScenarioUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldScenarioUIController worldScenarioUIController2 = (WorldScenarioUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldScenarioUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060224A3 RID: 140451 RVA: 0x00BBA69C File Offset: 0x00BB889C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			string s = worldScenarioUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060224A4 RID: 140452 RVA: 0x00BBA6F8 File Offset: 0x00BB88F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__callDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A5 RID: 140453 RVA: 0x00BBA74C File Offset: 0x00BB894C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__clearDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A6 RID: 140454 RVA: 0x00BBA7A0 File Offset: 0x00BB89A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__callDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A7 RID: 140455 RVA: 0x00BBA7F4 File Offset: 0x00BB89F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__clearDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A8 RID: 140456 RVA: 0x00BBA848 File Offset: 0x00BB8A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224A9 RID: 140457 RVA: 0x00BBA89C File Offset: 0x00BB8A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			worldScenarioUIController.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224AA RID: 140458 RVA: 0x00BBA8F0 File Offset: 0x00BB8AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldScenarioUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					worldScenarioUIController.EventOnPointerDown -= value;
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

	// Token: 0x060224AB RID: 140459 RVA: 0x00BBA970 File Offset: 0x00BB8B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldScenarioUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					worldScenarioUIController.EventOnPointerUp -= value;
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

	// Token: 0x060224AC RID: 140460 RVA: 0x00BBA9F0 File Offset: 0x00BB8BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldScenarioUIController worldScenarioUIController = (WorldScenarioUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldScenarioUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					worldScenarioUIController.EventOnClick -= value;
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

	// Token: 0x060224AD RID: 140461 RVA: 0x00BBAA70 File Offset: 0x00BB8C70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldScenarioUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache16);
		string name = "EventOnPointerDown";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache17, true);
		string name2 = "EventOnPointerUp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache18, true);
		string name3 = "EventOnClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.<>f__mg$cache19, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldScenarioUIController), typeof(UIControllerBase));
	}

	// Token: 0x040182A5 RID: 98981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040182A6 RID: 98982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040182A7 RID: 98983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040182A8 RID: 98984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040182A9 RID: 98985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040182AA RID: 98986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040182AB RID: 98987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040182AC RID: 98988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040182AD RID: 98989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040182AE RID: 98990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040182AF RID: 98991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040182B0 RID: 98992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040182B1 RID: 98993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040182B2 RID: 98994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040182B3 RID: 98995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040182B4 RID: 98996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040182B5 RID: 98997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040182B6 RID: 98998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040182B7 RID: 98999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040182B8 RID: 99000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040182B9 RID: 99001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040182BA RID: 99002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040182BB RID: 99003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040182BC RID: 99004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040182BD RID: 99005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040182BE RID: 99006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
