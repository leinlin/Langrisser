using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015BA RID: 5562
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController : LuaObject
{
	// Token: 0x06021CD5 RID: 138453 RVA: 0x00B7D140 File Offset: 0x00B7B340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTreasureLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo treasureLevelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out treasureLevelInfo);
			treasureLevelListItemUIController.SetTreasureLevelInfo(treasureLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CD6 RID: 138454 RVA: 0x00B7D198 File Offset: 0x00B7B398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTreasureLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo treasureLevelInfo = treasureLevelListItemUIController.GetTreasureLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CD7 RID: 138455 RVA: 0x00B7D1EC File Offset: 0x00B7B3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			ConfigDataTreasureLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 3, out levelnfo);
			treasureLevelListItemUIController.SetLocked(locked, levelnfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CD8 RID: 138456 RVA: 0x00B7D250 File Offset: 0x00B7B450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			treasureLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CD9 RID: 138457 RVA: 0x00B7D2A4 File Offset: 0x00B7B4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			treasureLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CDA RID: 138458 RVA: 0x00B7D2F8 File Offset: 0x00B7B4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			treasureLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CDB RID: 138459 RVA: 0x00B7D34C File Offset: 0x00B7B54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CDC RID: 138460 RVA: 0x00B7D3B8 File Offset: 0x00B7B5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CDD RID: 138461 RVA: 0x00B7D40C File Offset: 0x00B7B60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CDE RID: 138462 RVA: 0x00B7D460 File Offset: 0x00B7B660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = treasureLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021CDF RID: 138463 RVA: 0x00B7D508 File Offset: 0x00B7B708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE0 RID: 138464 RVA: 0x00B7D55C File Offset: 0x00B7B75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE1 RID: 138465 RVA: 0x00B7D5C8 File Offset: 0x00B7B7C8
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
				TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				treasureLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TreasureLevelListItemUIController treasureLevelListItemUIController2 = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				treasureLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021CE2 RID: 138466 RVA: 0x00B7D6D8 File Offset: 0x00B7B8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE3 RID: 138467 RVA: 0x00B7D744 File Offset: 0x00B7B944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE4 RID: 138468 RVA: 0x00B7D7B0 File Offset: 0x00B7B9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE5 RID: 138469 RVA: 0x00B7D81C File Offset: 0x00B7BA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE6 RID: 138470 RVA: 0x00B7D888 File Offset: 0x00B7BA88
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
				TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				treasureLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TreasureLevelListItemUIController treasureLevelListItemUIController2 = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				treasureLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021CE7 RID: 138471 RVA: 0x00B7D998 File Offset: 0x00B7BB98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			string s = treasureLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021CE8 RID: 138472 RVA: 0x00B7D9F4 File Offset: 0x00B7BBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			TreasureLevelListItemUIController obj;
			LuaObject.checkType<TreasureLevelListItemUIController>(l, 2, out obj);
			treasureLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CE9 RID: 138473 RVA: 0x00B7DA50 File Offset: 0x00B7BC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			TreasureLevelListItemUIController obj;
			LuaObject.checkType<TreasureLevelListItemUIController>(l, 2, out obj);
			treasureLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CEA RID: 138474 RVA: 0x00B7DAAC File Offset: 0x00B7BCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Action<TreasureLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<TreasureLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					treasureLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					treasureLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x06021CEB RID: 138475 RVA: 0x00B7DB2C File Offset: 0x00B7BD2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CEC RID: 138476 RVA: 0x00B7DB84 File Offset: 0x00B7BD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			treasureLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CED RID: 138477 RVA: 0x00B7DBE0 File Offset: 0x00B7BDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CEE RID: 138478 RVA: 0x00B7DC38 File Offset: 0x00B7BE38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			treasureLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CEF RID: 138479 RVA: 0x00B7DC94 File Offset: 0x00B7BE94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ticketText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_ticketText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF0 RID: 138480 RVA: 0x00B7DCEC File Offset: 0x00B7BEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_ticketText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Text ticketText;
			LuaObject.checkType<Text>(l, 2, out ticketText);
			treasureLevelListItemUIController.m_luaExportHelper.m_ticketText = ticketText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF1 RID: 138481 RVA: 0x00B7DD48 File Offset: 0x00B7BF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF2 RID: 138482 RVA: 0x00B7DDA0 File Offset: 0x00B7BFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			treasureLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF3 RID: 138483 RVA: 0x00B7DDFC File Offset: 0x00B7BFFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_lockedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF4 RID: 138484 RVA: 0x00B7DE54 File Offset: 0x00B7C054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Text lockedText;
			LuaObject.checkType<Text>(l, 2, out lockedText);
			treasureLevelListItemUIController.m_luaExportHelper.m_lockedText = lockedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF5 RID: 138485 RVA: 0x00B7DEB0 File Offset: 0x00B7C0B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF6 RID: 138486 RVA: 0x00B7DF08 File Offset: 0x00B7C108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			treasureLevelListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF7 RID: 138487 RVA: 0x00B7DF64 File Offset: 0x00B7C164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF8 RID: 138488 RVA: 0x00B7DFBC File Offset: 0x00B7C1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			treasureLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CF9 RID: 138489 RVA: 0x00B7E018 File Offset: 0x00B7C218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureLevelListItemUIController.m_luaExportHelper.m_treasureLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CFA RID: 138490 RVA: 0x00B7E070 File Offset: 0x00B7C270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			TreasureLevelListItemUIController treasureLevelListItemUIController = (TreasureLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo treasureLevelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out treasureLevelInfo);
			treasureLevelListItemUIController.m_luaExportHelper.m_treasureLevelInfo = treasureLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CFB RID: 138491 RVA: 0x00B7E0CC File Offset: 0x00B7C2CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TreasureLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.SetTreasureLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.GetTreasureLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache14);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache15, true);
		string name2 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache17, true);
		string name3 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache19, true);
		string name4 = "m_ticketText";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_ticketText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_ticketText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_lockedText";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_lockedText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_lockedText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_startButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache21, true);
		string name8 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache23, true);
		string name9 = "m_treasureLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.get_m_treasureLevelInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.set_m_treasureLevelInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.<>f__mg$cache25, true);
		LuaObject.createTypeMetatable(l, null, typeof(TreasureLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017B43 RID: 97091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017B44 RID: 97092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017B45 RID: 97093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017B46 RID: 97094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017B47 RID: 97095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017B48 RID: 97096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017B49 RID: 97097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017B4A RID: 97098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017B4B RID: 97099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017B4C RID: 97100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017B4D RID: 97101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017B4E RID: 97102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017B4F RID: 97103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017B50 RID: 97104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017B51 RID: 97105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017B52 RID: 97106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017B53 RID: 97107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017B54 RID: 97108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017B55 RID: 97109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017B56 RID: 97110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017B57 RID: 97111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017B58 RID: 97112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017B59 RID: 97113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017B5A RID: 97114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017B5B RID: 97115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017B5C RID: 97116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017B5D RID: 97117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017B5E RID: 97118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017B5F RID: 97119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017B60 RID: 97120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017B61 RID: 97121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017B62 RID: 97122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017B63 RID: 97123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017B64 RID: 97124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017B65 RID: 97125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017B66 RID: 97126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017B67 RID: 97127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017B68 RID: 97128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
