using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013D8 RID: 5080
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController : LuaObject
{
	// Token: 0x0601C69A RID: 116378 RVA: 0x008CEA4C File Offset: 0x008CCC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroListItemInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			BusinessCard businessCard;
			LuaObject.checkType<BusinessCard>(l, 3, out businessCard);
			businessCardHeroListItemUIController.SetHeroListItemInfo(hero, businessCard);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C69B RID: 116379 RVA: 0x008CEAB0 File Offset: 0x008CCCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroID(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			int heroID = businessCardHeroListItemUIController.GetHeroID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C69C RID: 116380 RVA: 0x008CEB04 File Offset: 0x008CCD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			int positionIndex = businessCardHeroListItemUIController.GetPositionIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, positionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C69D RID: 116381 RVA: 0x008CEB58 File Offset: 0x008CCD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSelect(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			bool b = businessCardHeroListItemUIController.IsSelect();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C69E RID: 116382 RVA: 0x008CEBAC File Offset: 0x008CCDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNormalState(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			businessCardHeroListItemUIController.SetNormalState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C69F RID: 116383 RVA: 0x008CEBF8 File Offset: 0x008CCDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectState(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			int selectState;
			LuaObject.checkType(l, 2, out selectState);
			businessCardHeroListItemUIController.SetSelectState(selectState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A0 RID: 116384 RVA: 0x008CEC50 File Offset: 0x008CCE50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			businessCardHeroListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A1 RID: 116385 RVA: 0x008CECA4 File Offset: 0x008CCEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			businessCardHeroListItemUIController.m_luaExportHelper.OnHeroItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A2 RID: 116386 RVA: 0x008CECF8 File Offset: 0x008CCEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A3 RID: 116387 RVA: 0x008CED64 File Offset: 0x008CCF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A4 RID: 116388 RVA: 0x008CEDB8 File Offset: 0x008CCFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A5 RID: 116389 RVA: 0x008CEE0C File Offset: 0x008CD00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = businessCardHeroListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C6A6 RID: 116390 RVA: 0x008CEEB4 File Offset: 0x008CD0B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A7 RID: 116391 RVA: 0x008CEF08 File Offset: 0x008CD108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6A8 RID: 116392 RVA: 0x008CEF74 File Offset: 0x008CD174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				businessCardHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BusinessCardHeroListItemUIController businessCardHeroListItemUIController2 = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				businessCardHeroListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C6A9 RID: 116393 RVA: 0x008CF084 File Offset: 0x008CD284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6AA RID: 116394 RVA: 0x008CF0F0 File Offset: 0x008CD2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6AB RID: 116395 RVA: 0x008CF15C File Offset: 0x008CD35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6AC RID: 116396 RVA: 0x008CF1C8 File Offset: 0x008CD3C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6AD RID: 116397 RVA: 0x008CF234 File Offset: 0x008CD434
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
				BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				businessCardHeroListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BusinessCardHeroListItemUIController businessCardHeroListItemUIController2 = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				businessCardHeroListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C6AE RID: 116398 RVA: 0x008CF344 File Offset: 0x008CD544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			string s = businessCardHeroListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C6AF RID: 116399 RVA: 0x008CF3A0 File Offset: 0x008CD5A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnSelectHeroItem(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			BusinessCardHeroListItemUIController obj;
			LuaObject.checkType<BusinessCardHeroListItemUIController>(l, 2, out obj);
			businessCardHeroListItemUIController.m_luaExportHelper.__callDele_EventOnSelectHeroItem(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B0 RID: 116400 RVA: 0x008CF3FC File Offset: 0x008CD5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectHeroItem(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			BusinessCardHeroListItemUIController obj;
			LuaObject.checkType<BusinessCardHeroListItemUIController>(l, 2, out obj);
			businessCardHeroListItemUIController.m_luaExportHelper.__clearDele_EventOnSelectHeroItem(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B1 RID: 116401 RVA: 0x008CF458 File Offset: 0x008CD658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectHeroItem(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Action<BusinessCardHeroListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<BusinessCardHeroListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardHeroListItemUIController.EventOnSelectHeroItem += value;
				}
				else if (num == 2)
				{
					businessCardHeroListItemUIController.EventOnSelectHeroItem -= value;
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

	// Token: 0x0601C6B2 RID: 116402 RVA: 0x008CF4D8 File Offset: 0x008CD6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroItemButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B3 RID: 116403 RVA: 0x008CF530 File Offset: 0x008CD730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroItemButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Button heroItemButton;
			LuaObject.checkType<Button>(l, 2, out heroItemButton);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroItemButton = heroItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B4 RID: 116404 RVA: 0x008CF58C File Offset: 0x008CD78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroItemUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroItemUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B5 RID: 116405 RVA: 0x008CF5E4 File Offset: 0x008CD7E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroItemUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroItemUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroItemUIStateController);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroItemUIStateController = heroItemUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B6 RID: 116406 RVA: 0x008CF640 File Offset: 0x008CD840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B7 RID: 116407 RVA: 0x008CF698 File Offset: 0x008CD898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			GameObject heroStar;
			LuaObject.checkType<GameObject>(l, 2, out heroStar);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B8 RID: 116408 RVA: 0x008CF6F4 File Offset: 0x008CD8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroTypeImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6B9 RID: 116409 RVA: 0x008CF74C File Offset: 0x008CD94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Image heroTypeImg;
			LuaObject.checkType<Image>(l, 2, out heroTypeImg);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroTypeImg = heroTypeImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6BA RID: 116410 RVA: 0x008CF7A8 File Offset: 0x008CD9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6BB RID: 116411 RVA: 0x008CF800 File Offset: 0x008CDA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Text heroLvText;
			LuaObject.checkType<Text>(l, 2, out heroLvText);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroLvText = heroLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6BC RID: 116412 RVA: 0x008CF85C File Offset: 0x008CDA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSSRFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroSSRFrameEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6BD RID: 116413 RVA: 0x008CF8B4 File Offset: 0x008CDAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSSRFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			GameObject heroSSRFrameEffect;
			LuaObject.checkType<GameObject>(l, 2, out heroSSRFrameEffect);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroSSRFrameEffect = heroSSRFrameEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6BE RID: 116414 RVA: 0x008CF910 File Offset: 0x008CDB10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroFrameImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroFrameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6BF RID: 116415 RVA: 0x008CF968 File Offset: 0x008CDB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroFrameImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Image heroFrameImg;
			LuaObject.checkType<Image>(l, 2, out heroFrameImg);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroFrameImg = heroFrameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C0 RID: 116416 RVA: 0x008CF9C4 File Offset: 0x008CDBC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C1 RID: 116417 RVA: 0x008CFA1C File Offset: 0x008CDC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Image heroIconImg;
			LuaObject.checkType<Image>(l, 2, out heroIconImg);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroIconImg = heroIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C2 RID: 116418 RVA: 0x008CFA78 File Offset: 0x008CDC78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroIndexText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroIndexText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C3 RID: 116419 RVA: 0x008CFAD0 File Offset: 0x008CDCD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroIndexText(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Text heroIndexText;
			LuaObject.checkType<Text>(l, 2, out heroIndexText);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroIndexText = heroIndexText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C4 RID: 116420 RVA: 0x008CFB2C File Offset: 0x008CDD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_heroPositionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C5 RID: 116421 RVA: 0x008CFB84 File Offset: 0x008CDD84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			int heroPositionIndex;
			LuaObject.checkType(l, 2, out heroPositionIndex);
			businessCardHeroListItemUIController.m_luaExportHelper.m_heroPositionIndex = heroPositionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C6 RID: 116422 RVA: 0x008CFBE0 File Offset: 0x008CDDE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C7 RID: 116423 RVA: 0x008CFC38 File Offset: 0x008CDE38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			businessCardHeroListItemUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C8 RID: 116424 RVA: 0x008CFC94 File Offset: 0x008CDE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroListItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6C9 RID: 116425 RVA: 0x008CFCEC File Offset: 0x008CDEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroListItemUIController businessCardHeroListItemUIController = (BusinessCardHeroListItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			businessCardHeroListItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6CA RID: 116426 RVA: 0x008CFD48 File Offset: 0x008CDF48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardHeroListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.SetHeroListItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.GetHeroID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.GetPositionIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.IsSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.SetNormalState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.SetSelectState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__callDele_EventOnSelectHeroItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.__clearDele_EventOnSelectHeroItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache16);
		string name = "EventOnSelectHeroItem";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_EventOnSelectHeroItem);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache17, true);
		string name2 = "m_heroItemButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroItemButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroItemButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache19, true);
		string name3 = "m_heroItemUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroItemUIStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroItemUIStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1B, true);
		string name4 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroStar);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroStar);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1D, true);
		string name5 = "m_heroTypeImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroTypeImg);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroTypeImg);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache1F, true);
		string name6 = "m_heroLvText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroLvText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroLvText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache21, true);
		string name7 = "m_heroSSRFrameEffect";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroSSRFrameEffect);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroSSRFrameEffect);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache23, true);
		string name8 = "m_heroFrameImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroFrameImg);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroFrameImg);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache25, true);
		string name9 = "m_heroIconImg";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroIconImg);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroIconImg);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache27, true);
		string name10 = "m_heroIndexText";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroIndexText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroIndexText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache29, true);
		string name11 = "m_heroPositionIndex";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_heroPositionIndex);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_heroPositionIndex);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2B, true);
		string name12 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_hero);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_hero);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2D, true);
		string name13 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(BusinessCardHeroListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040128CC RID: 75980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040128CD RID: 75981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040128CE RID: 75982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040128CF RID: 75983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040128D0 RID: 75984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040128D1 RID: 75985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040128D2 RID: 75986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040128D3 RID: 75987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040128D4 RID: 75988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040128D5 RID: 75989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040128D6 RID: 75990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040128D7 RID: 75991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040128D8 RID: 75992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040128D9 RID: 75993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040128DA RID: 75994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040128DB RID: 75995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040128DC RID: 75996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040128DD RID: 75997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040128DE RID: 75998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040128DF RID: 75999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040128E0 RID: 76000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040128E1 RID: 76001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040128E2 RID: 76002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040128E3 RID: 76003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040128E4 RID: 76004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040128E5 RID: 76005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040128E6 RID: 76006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040128E7 RID: 76007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040128E8 RID: 76008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040128E9 RID: 76009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040128EA RID: 76010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040128EB RID: 76011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040128EC RID: 76012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040128ED RID: 76013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040128EE RID: 76014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040128EF RID: 76015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040128F0 RID: 76016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040128F1 RID: 76017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040128F2 RID: 76018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040128F3 RID: 76019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040128F4 RID: 76020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040128F5 RID: 76021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040128F6 RID: 76022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040128F7 RID: 76023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040128F8 RID: 76024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040128F9 RID: 76025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040128FA RID: 76026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040128FB RID: 76027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
