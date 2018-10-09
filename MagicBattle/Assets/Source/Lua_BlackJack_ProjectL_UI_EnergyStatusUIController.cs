using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200141F RID: 5151
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EnergyStatusUIController : LuaObject
{
	// Token: 0x0601D52E RID: 120110 RVA: 0x00942B10 File Offset: 0x00940D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D52F RID: 120111 RVA: 0x00942B5C File Offset: 0x00940D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNow(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			DateTime now;
			LuaObject.checkValueType<DateTime>(l, 2, out now);
			energyStatusUIController.SetNow(now);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D530 RID: 120112 RVA: 0x00942BB4 File Offset: 0x00940DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecoverTime(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			TimeSpan recoverTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out recoverTime);
			energyStatusUIController.SetRecoverTime(recoverTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D531 RID: 120113 RVA: 0x00942C0C File Offset: 0x00940E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecoverAllTime(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			TimeSpan recoverAllTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out recoverAllTime);
			energyStatusUIController.SetRecoverAllTime(recoverAllTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D532 RID: 120114 RVA: 0x00942C64 File Offset: 0x00940E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnergyStatusPosition(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Vector3 energyStatusPosition;
			LuaObject.checkType(l, 2, out energyStatusPosition);
			energyStatusUIController.SetEnergyStatusPosition(energyStatusPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D533 RID: 120115 RVA: 0x00942CBC File Offset: 0x00940EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D534 RID: 120116 RVA: 0x00942D10 File Offset: 0x00940F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D535 RID: 120117 RVA: 0x00942D64 File Offset: 0x00940F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			energyStatusUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D536 RID: 120118 RVA: 0x00942DD0 File Offset: 0x00940FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D537 RID: 120119 RVA: 0x00942E24 File Offset: 0x00941024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D538 RID: 120120 RVA: 0x00942E78 File Offset: 0x00941078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = energyStatusUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D539 RID: 120121 RVA: 0x00942F20 File Offset: 0x00941120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D53A RID: 120122 RVA: 0x00942F74 File Offset: 0x00941174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			energyStatusUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D53B RID: 120123 RVA: 0x00942FE0 File Offset: 0x009411E0
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
				EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				energyStatusUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EnergyStatusUIController energyStatusUIController2 = (EnergyStatusUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				energyStatusUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D53C RID: 120124 RVA: 0x009430F0 File Offset: 0x009412F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			energyStatusUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D53D RID: 120125 RVA: 0x0094315C File Offset: 0x0094135C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			energyStatusUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D53E RID: 120126 RVA: 0x009431C8 File Offset: 0x009413C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			energyStatusUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D53F RID: 120127 RVA: 0x00943234 File Offset: 0x00941434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			energyStatusUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D540 RID: 120128 RVA: 0x009432A0 File Offset: 0x009414A0
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
				EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				energyStatusUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EnergyStatusUIController energyStatusUIController2 = (EnergyStatusUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				energyStatusUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D541 RID: 120129 RVA: 0x009433B0 File Offset: 0x009415B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			string s = energyStatusUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D542 RID: 120130 RVA: 0x0094340C File Offset: 0x0094160C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D543 RID: 120131 RVA: 0x00943460 File Offset: 0x00941660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			energyStatusUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D544 RID: 120132 RVA: 0x009434B4 File Offset: 0x009416B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					energyStatusUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					energyStatusUIController.EventOnClose -= value;
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

	// Token: 0x0601D545 RID: 120133 RVA: 0x00943534 File Offset: 0x00941734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D546 RID: 120134 RVA: 0x0094358C File Offset: 0x0094178C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			energyStatusUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D547 RID: 120135 RVA: 0x009435E8 File Offset: 0x009417E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowText(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUIController.m_luaExportHelper.m_nowText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D548 RID: 120136 RVA: 0x00943640 File Offset: 0x00941840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowText(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Text nowText;
			LuaObject.checkType<Text>(l, 2, out nowText);
			energyStatusUIController.m_luaExportHelper.m_nowText = nowText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D549 RID: 120137 RVA: 0x0094369C File Offset: 0x0094189C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recoverTimeText(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUIController.m_luaExportHelper.m_recoverTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D54A RID: 120138 RVA: 0x009436F4 File Offset: 0x009418F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recoverTimeText(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Text recoverTimeText;
			LuaObject.checkType<Text>(l, 2, out recoverTimeText);
			energyStatusUIController.m_luaExportHelper.m_recoverTimeText = recoverTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D54B RID: 120139 RVA: 0x00943750 File Offset: 0x00941950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recoverAllTimeText(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUIController.m_luaExportHelper.m_recoverAllTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D54C RID: 120140 RVA: 0x009437A8 File Offset: 0x009419A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recoverAllTimeText(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Text recoverAllTimeText;
			LuaObject.checkType<Text>(l, 2, out recoverAllTimeText);
			energyStatusUIController.m_luaExportHelper.m_recoverAllTimeText = recoverAllTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D54D RID: 120141 RVA: 0x00943804 File Offset: 0x00941A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D54E RID: 120142 RVA: 0x0094385C File Offset: 0x00941A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			energyStatusUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D54F RID: 120143 RVA: 0x009438B8 File Offset: 0x00941AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyStatusPanel(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUIController.m_luaExportHelper.m_energyStatusPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D550 RID: 120144 RVA: 0x00943910 File Offset: 0x00941B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyStatusPanel(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUIController energyStatusUIController = (EnergyStatusUIController)LuaObject.checkSelf(l);
			GameObject energyStatusPanel;
			LuaObject.checkType<GameObject>(l, 2, out energyStatusPanel);
			energyStatusUIController.m_luaExportHelper.m_energyStatusPanel = energyStatusPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D551 RID: 120145 RVA: 0x0094396C File Offset: 0x00941B6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EnergyStatusUIController");
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.SetNow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.SetRecoverTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.SetRecoverAllTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.SetEnergyStatusPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache15);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache16, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache18, true);
		string name3 = "m_nowText";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.get_m_nowText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_m_nowText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1A, true);
		string name4 = "m_recoverTimeText";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.get_m_recoverTimeText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_m_recoverTimeText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1C, true);
		string name5 = "m_recoverAllTimeText";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.get_m_recoverAllTimeText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_m_recoverAllTimeText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1E, true);
		string name6 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.get_m_backgroundButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache20, true);
		string name7 = "m_energyStatusPanel";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.get_m_energyStatusPanel);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.set_m_energyStatusPanel);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.<>f__mg$cache22, true);
		LuaObject.createTypeMetatable(l, null, typeof(EnergyStatusUIController), typeof(UIControllerBase));
	}

	// Token: 0x040136D2 RID: 79570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040136D3 RID: 79571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040136D4 RID: 79572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040136D5 RID: 79573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040136D6 RID: 79574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040136D7 RID: 79575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040136D8 RID: 79576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040136D9 RID: 79577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040136DA RID: 79578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040136DB RID: 79579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040136DC RID: 79580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040136DD RID: 79581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040136DE RID: 79582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040136DF RID: 79583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040136E0 RID: 79584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040136E1 RID: 79585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040136E2 RID: 79586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040136E3 RID: 79587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040136E4 RID: 79588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040136E5 RID: 79589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040136E6 RID: 79590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040136E7 RID: 79591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040136E8 RID: 79592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040136E9 RID: 79593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040136EA RID: 79594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040136EB RID: 79595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040136EC RID: 79596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040136ED RID: 79597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040136EE RID: 79598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040136EF RID: 79599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040136F0 RID: 79600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040136F1 RID: 79601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040136F2 RID: 79602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040136F3 RID: 79603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040136F4 RID: 79604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
