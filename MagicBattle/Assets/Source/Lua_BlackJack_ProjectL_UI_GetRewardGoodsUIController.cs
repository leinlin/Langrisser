using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001460 RID: 5216
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController : LuaObject
{
	// Token: 0x0601E1FE RID: 123390 RVA: 0x009A88A4 File Offset: 0x009A6AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowReward(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			List<Goods> itemList;
			LuaObject.checkType<List<Goods>>(l, 2, out itemList);
			getRewardGoodsUIController.ShowReward(itemList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1FF RID: 123391 RVA: 0x009A88FC File Offset: 0x009A6AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E200 RID: 123392 RVA: 0x009A8950 File Offset: 0x009A6B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowReward(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodsList);
			IEnumerator o = getRewardGoodsUIController.m_luaExportHelper.Co_ShowReward(goodsList);
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

	// Token: 0x0601E201 RID: 123393 RVA: 0x009A89B8 File Offset: 0x009A6BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = getRewardGoodsUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x0601E202 RID: 123394 RVA: 0x009A8A2C File Offset: 0x009A6C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			IEnumerator o = getRewardGoodsUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x0601E203 RID: 123395 RVA: 0x009A8A88 File Offset: 0x009A6C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E204 RID: 123396 RVA: 0x009A8ADC File Offset: 0x009A6CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E205 RID: 123397 RVA: 0x009A8B48 File Offset: 0x009A6D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E206 RID: 123398 RVA: 0x009A8B9C File Offset: 0x009A6D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E207 RID: 123399 RVA: 0x009A8BF0 File Offset: 0x009A6DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = getRewardGoodsUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E208 RID: 123400 RVA: 0x009A8C98 File Offset: 0x009A6E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E209 RID: 123401 RVA: 0x009A8CEC File Offset: 0x009A6EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E20A RID: 123402 RVA: 0x009A8D58 File Offset: 0x009A6F58
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
				GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				getRewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GetRewardGoodsUIController getRewardGoodsUIController2 = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				getRewardGoodsUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E20B RID: 123403 RVA: 0x009A8E68 File Offset: 0x009A7068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E20C RID: 123404 RVA: 0x009A8ED4 File Offset: 0x009A70D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E20D RID: 123405 RVA: 0x009A8F40 File Offset: 0x009A7140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E20E RID: 123406 RVA: 0x009A8FAC File Offset: 0x009A71AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getRewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E20F RID: 123407 RVA: 0x009A9018 File Offset: 0x009A7218
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
				GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				getRewardGoodsUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GetRewardGoodsUIController getRewardGoodsUIController2 = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				getRewardGoodsUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E210 RID: 123408 RVA: 0x009A9128 File Offset: 0x009A7328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			string s = getRewardGoodsUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E211 RID: 123409 RVA: 0x009A9184 File Offset: 0x009A7384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E212 RID: 123410 RVA: 0x009A91D8 File Offset: 0x009A73D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			getRewardGoodsUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E213 RID: 123411 RVA: 0x009A922C File Offset: 0x009A742C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					getRewardGoodsUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					getRewardGoodsUIController.EventOnClose -= value;
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

	// Token: 0x0601E214 RID: 123412 RVA: 0x009A92AC File Offset: 0x009A74AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E215 RID: 123413 RVA: 0x009A9304 File Offset: 0x009A7504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			getRewardGoodsUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E216 RID: 123414 RVA: 0x009A9360 File Offset: 0x009A7560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E217 RID: 123415 RVA: 0x009A93B8 File Offset: 0x009A75B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			getRewardGoodsUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E218 RID: 123416 RVA: 0x009A9414 File Offset: 0x009A7614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelGameObject(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUIController.m_luaExportHelper.m_panelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E219 RID: 123417 RVA: 0x009A946C File Offset: 0x009A766C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelGameObject(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			GameObject panelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out panelGameObject);
			getRewardGoodsUIController.m_luaExportHelper.m_panelGameObject = panelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E21A RID: 123418 RVA: 0x009A94C8 File Offset: 0x009A76C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUIController.m_luaExportHelper.m_scrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E21B RID: 123419 RVA: 0x009A9520 File Offset: 0x009A7720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			getRewardGoodsUIController.m_luaExportHelper.m_scrollRect = scrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E21C RID: 123420 RVA: 0x009A957C File Offset: 0x009A777C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gridLayoutGroup(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUIController.m_luaExportHelper.m_gridLayoutGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E21D RID: 123421 RVA: 0x009A95D4 File Offset: 0x009A77D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gridLayoutGroup(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			GridLayoutGroup gridLayoutGroup;
			LuaObject.checkType<GridLayoutGroup>(l, 2, out gridLayoutGroup);
			getRewardGoodsUIController.m_luaExportHelper.m_gridLayoutGroup = gridLayoutGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E21E RID: 123422 RVA: 0x009A9630 File Offset: 0x009A7830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E21F RID: 123423 RVA: 0x009A9688 File Offset: 0x009A7888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUIController getRewardGoodsUIController = (GetRewardGoodsUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			getRewardGoodsUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E220 RID: 123424 RVA: 0x009A96E4 File Offset: 0x009A78E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetRewardGoodsUIController");
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.Co_ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache14);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache15, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache17, true);
		string name3 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.get_m_backgroundButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache19, true);
		string name4 = "m_panelGameObject";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.get_m_panelGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_m_panelGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1B, true);
		string name5 = "m_scrollRect";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.get_m_scrollRect);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_m_scrollRect);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1D, true);
		string name6 = "m_gridLayoutGroup";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.get_m_gridLayoutGroup);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_m_gridLayoutGroup);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache1F, true);
		string name7 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.get_m_isClick);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.<>f__mg$cache21, true);
		LuaObject.createTypeMetatable(l, null, typeof(GetRewardGoodsUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014320 RID: 82720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014321 RID: 82721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014322 RID: 82722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014323 RID: 82723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014324 RID: 82724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014325 RID: 82725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014326 RID: 82726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014327 RID: 82727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014328 RID: 82728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014329 RID: 82729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401432A RID: 82730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401432B RID: 82731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401432C RID: 82732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401432D RID: 82733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401432E RID: 82734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401432F RID: 82735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014330 RID: 82736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014331 RID: 82737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014332 RID: 82738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014333 RID: 82739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014334 RID: 82740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014335 RID: 82741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014336 RID: 82742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014337 RID: 82743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014338 RID: 82744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014339 RID: 82745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401433A RID: 82746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401433B RID: 82747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401433C RID: 82748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401433D RID: 82749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401433E RID: 82750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401433F RID: 82751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014340 RID: 82752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014341 RID: 82753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
