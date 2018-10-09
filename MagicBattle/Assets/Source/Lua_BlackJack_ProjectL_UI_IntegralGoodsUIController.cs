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

// Token: 0x020014F1 RID: 5361
[Preserve]
public class Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController : LuaObject
{
	// Token: 0x0601FA62 RID: 129634 RVA: 0x00A6A710 File Offset: 0x00A68910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitIntegralGoodsInfo(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			ConfigDataNoviceRewardInfo reward;
			LuaObject.checkType<ConfigDataNoviceRewardInfo>(l, 2, out reward);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			integralGoodsUIController.InitIntegralGoodsInfo(reward, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA63 RID: 129635 RVA: 0x00A6A774 File Offset: 0x00A68974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayGotChangeEffect(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Action onStateFinish;
			LuaObject.checkDelegate<Action>(l, 2, out onStateFinish);
			integralGoodsUIController.PlayGotChangeEffect(onStateFinish);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA64 RID: 129636 RVA: 0x00A6A7CC File Offset: 0x00A689CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA65 RID: 129637 RVA: 0x00A6A820 File Offset: 0x00A68A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIntegralGoodsState(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.SetIntegralGoodsState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA66 RID: 129638 RVA: 0x00A6A874 File Offset: 0x00A68A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIntegralGoodsInfo(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.SetIntegralGoodsInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA67 RID: 129639 RVA: 0x00A6A8C8 File Offset: 0x00A68AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemClick(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.OnItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA68 RID: 129640 RVA: 0x00A6A91C File Offset: 0x00A68B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			integralGoodsUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA69 RID: 129641 RVA: 0x00A6A988 File Offset: 0x00A68B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA6A RID: 129642 RVA: 0x00A6A9DC File Offset: 0x00A68BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA6B RID: 129643 RVA: 0x00A6AA30 File Offset: 0x00A68C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = integralGoodsUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FA6C RID: 129644 RVA: 0x00A6AAD8 File Offset: 0x00A68CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			integralGoodsUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA6D RID: 129645 RVA: 0x00A6AB2C File Offset: 0x00A68D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			integralGoodsUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA6E RID: 129646 RVA: 0x00A6AB98 File Offset: 0x00A68D98
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
				IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				integralGoodsUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				IntegralGoodsUIController integralGoodsUIController2 = (IntegralGoodsUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				integralGoodsUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FA6F RID: 129647 RVA: 0x00A6ACA8 File Offset: 0x00A68EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			integralGoodsUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA70 RID: 129648 RVA: 0x00A6AD14 File Offset: 0x00A68F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			integralGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA71 RID: 129649 RVA: 0x00A6AD80 File Offset: 0x00A68F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			integralGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA72 RID: 129650 RVA: 0x00A6ADEC File Offset: 0x00A68FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			integralGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA73 RID: 129651 RVA: 0x00A6AE58 File Offset: 0x00A69058
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
				IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				integralGoodsUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				IntegralGoodsUIController integralGoodsUIController2 = (IntegralGoodsUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				integralGoodsUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FA74 RID: 129652 RVA: 0x00A6AF68 File Offset: 0x00A69168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			string s = integralGoodsUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FA75 RID: 129653 RVA: 0x00A6AFC4 File Offset: 0x00A691C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			IntegralGoodsUIController obj;
			LuaObject.checkType<IntegralGoodsUIController>(l, 2, out obj);
			integralGoodsUIController.m_luaExportHelper.__callDele_EventOnIntegralGoodsClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA76 RID: 129654 RVA: 0x00A6B020 File Offset: 0x00A69220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			IntegralGoodsUIController obj;
			LuaObject.checkType<IntegralGoodsUIController>(l, 2, out obj);
			integralGoodsUIController.m_luaExportHelper.__clearDele_EventOnIntegralGoodsClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA77 RID: 129655 RVA: 0x00A6B07C File Offset: 0x00A6927C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Action<IntegralGoodsUIController> value;
			int num = LuaObject.checkDelegate<Action<IntegralGoodsUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					integralGoodsUIController.EventOnIntegralGoodsClick += value;
				}
				else if (num == 2)
				{
					integralGoodsUIController.EventOnIntegralGoodsClick -= value;
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

	// Token: 0x0601FA78 RID: 129656 RVA: 0x00A6B0FC File Offset: 0x00A692FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA79 RID: 129657 RVA: 0x00A6B154 File Offset: 0x00A69354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			integralGoodsUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA7A RID: 129658 RVA: 0x00A6B1B0 File Offset: 0x00A693B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA7B RID: 129659 RVA: 0x00A6B208 File Offset: 0x00A69408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			integralGoodsUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA7C RID: 129660 RVA: 0x00A6B264 File Offset: 0x00A69464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_bgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA7D RID: 129661 RVA: 0x00A6B2BC File Offset: 0x00A694BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Image bgImage;
			LuaObject.checkType<Image>(l, 2, out bgImage);
			integralGoodsUIController.m_luaExportHelper.m_bgImage = bgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA7E RID: 129662 RVA: 0x00A6B318 File Offset: 0x00A69518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA7F RID: 129663 RVA: 0x00A6B370 File Offset: 0x00A69570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			integralGoodsUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA80 RID: 129664 RVA: 0x00A6B3CC File Offset: 0x00A695CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalEffect(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_crystalEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA81 RID: 129665 RVA: 0x00A6B424 File Offset: 0x00A69624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalEffect(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			GameObject crystalEffect;
			LuaObject.checkType<GameObject>(l, 2, out crystalEffect);
			integralGoodsUIController.m_luaExportHelper.m_crystalEffect = crystalEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA82 RID: 129666 RVA: 0x00A6B480 File Offset: 0x00A69680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_ssrEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA83 RID: 129667 RVA: 0x00A6B4D8 File Offset: 0x00A696D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			GameObject ssrEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrEffect);
			integralGoodsUIController.m_luaExportHelper.m_ssrEffect = ssrEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA84 RID: 129668 RVA: 0x00A6B534 File Offset: 0x00A69734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countValueText(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_countValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA85 RID: 129669 RVA: 0x00A6B58C File Offset: 0x00A6978C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countValueText(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Text countValueText;
			LuaObject.checkType<Text>(l, 2, out countValueText);
			integralGoodsUIController.m_luaExportHelper.m_countValueText = countValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA86 RID: 129670 RVA: 0x00A6B5E8 File Offset: 0x00A697E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_integralText(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.m_luaExportHelper.m_integralText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA87 RID: 129671 RVA: 0x00A6B640 File Offset: 0x00A69840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_integralText(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			Text integralText;
			LuaObject.checkType<Text>(l, 2, out integralText);
			integralGoodsUIController.m_luaExportHelper.m_integralText = integralText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA88 RID: 129672 RVA: 0x00A6B69C File Offset: 0x00A6989C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_integralGoodsState(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)integralGoodsUIController.m_luaExportHelper.m_integralGoodsState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA89 RID: 129673 RVA: 0x00A6B6F4 File Offset: 0x00A698F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_integralGoodsState(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			IntegralGoodsUIController.IntegralGoodsState integralGoodsState;
			LuaObject.checkEnum<IntegralGoodsUIController.IntegralGoodsState>(l, 2, out integralGoodsState);
			integralGoodsUIController.m_luaExportHelper.m_integralGoodsState = integralGoodsState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA8A RID: 129674 RVA: 0x00A6B750 File Offset: 0x00A69950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Slot(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.Slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA8B RID: 129675 RVA: 0x00A6B7A4 File Offset: 0x00A699A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Slot(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			integralGoodsUIController.m_luaExportHelper.Slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA8C RID: 129676 RVA: 0x00A6B800 File Offset: 0x00A69A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NoviceReward(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, integralGoodsUIController.NoviceReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA8D RID: 129677 RVA: 0x00A6B854 File Offset: 0x00A69A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NoviceReward(IntPtr l)
	{
		int result;
		try
		{
			IntegralGoodsUIController integralGoodsUIController = (IntegralGoodsUIController)LuaObject.checkSelf(l);
			ConfigDataNoviceRewardInfo noviceReward;
			LuaObject.checkType<ConfigDataNoviceRewardInfo>(l, 2, out noviceReward);
			integralGoodsUIController.m_luaExportHelper.NoviceReward = noviceReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA8E RID: 129678 RVA: 0x00A6B8B0 File Offset: 0x00A69AB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.IntegralGoodsUIController");
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.InitIntegralGoodsInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.PlayGotChangeEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.SetIntegralGoodsState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.SetIntegralGoodsInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.OnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__callDele_EventOnIntegralGoodsClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.__clearDele_EventOnIntegralGoodsClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache14);
		string name = "EventOnIntegralGoodsClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_EventOnIntegralGoodsClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache15, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache17, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache19, true);
		string name4 = "m_bgImage";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_bgImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_bgImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1B, true);
		string name5 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_iconImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1D, true);
		string name6 = "m_crystalEffect";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_crystalEffect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_crystalEffect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache1F, true);
		string name7 = "m_ssrEffect";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_ssrEffect);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_ssrEffect);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache21, true);
		string name8 = "m_countValueText";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_countValueText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_countValueText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache23, true);
		string name9 = "m_integralText";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_integralText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_integralText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache25, true);
		string name10 = "m_integralGoodsState";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_m_integralGoodsState);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_m_integralGoodsState);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache27, true);
		string name11 = "Slot";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_Slot);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_Slot);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache29, true);
		string name12 = "NoviceReward";
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.get_NoviceReward);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.set_NoviceReward);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(IntegralGoodsUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015A62 RID: 88674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015A63 RID: 88675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015A64 RID: 88676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015A65 RID: 88677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015A66 RID: 88678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015A67 RID: 88679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015A68 RID: 88680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015A69 RID: 88681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015A6A RID: 88682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015A6B RID: 88683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015A6C RID: 88684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015A6D RID: 88685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015A6E RID: 88686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015A6F RID: 88687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015A70 RID: 88688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015A71 RID: 88689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015A72 RID: 88690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015A73 RID: 88691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015A74 RID: 88692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015A75 RID: 88693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015A76 RID: 88694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015A77 RID: 88695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015A78 RID: 88696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015A79 RID: 88697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015A7A RID: 88698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015A7B RID: 88699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015A7C RID: 88700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015A7D RID: 88701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015A7E RID: 88702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015A7F RID: 88703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015A80 RID: 88704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015A81 RID: 88705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015A82 RID: 88706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015A83 RID: 88707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015A84 RID: 88708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015A85 RID: 88709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015A86 RID: 88710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015A87 RID: 88711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015A88 RID: 88712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015A89 RID: 88713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015A8A RID: 88714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015A8B RID: 88715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015A8C RID: 88716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015A8D RID: 88717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
