using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015E6 RID: 5606
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController : LuaObject
{
	// Token: 0x0602245D RID: 140381 RVA: 0x00BB8188 File Offset: 0x00BB6388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			string iconName;
			LuaObject.checkType(l, 3, out iconName);
			string titleName;
			LuaObject.checkType(l, 4, out titleName);
			worldMonthCardItemUIController.UpdateItemInfo(cardId, iconName, titleName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602245E RID: 140382 RVA: 0x00BB81FC File Offset: 0x00BB63FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateRemainTime(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string time;
			LuaObject.checkType(l, 2, out time);
			worldMonthCardItemUIController.UpdateRemainTime(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602245F RID: 140383 RVA: 0x00BB8254 File Offset: 0x00BB6454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			worldMonthCardItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022460 RID: 140384 RVA: 0x00BB82A8 File Offset: 0x00BB64A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			worldMonthCardItemUIController.m_luaExportHelper.OnItemButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022461 RID: 140385 RVA: 0x00BB82FC File Offset: 0x00BB64FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			worldMonthCardItemUIController.m_luaExportHelper.OnBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022462 RID: 140386 RVA: 0x00BB8350 File Offset: 0x00BB6550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022463 RID: 140387 RVA: 0x00BB83BC File Offset: 0x00BB65BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022464 RID: 140388 RVA: 0x00BB8410 File Offset: 0x00BB6610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022465 RID: 140389 RVA: 0x00BB8464 File Offset: 0x00BB6664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldMonthCardItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022466 RID: 140390 RVA: 0x00BB850C File Offset: 0x00BB670C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022467 RID: 140391 RVA: 0x00BB8560 File Offset: 0x00BB6760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022468 RID: 140392 RVA: 0x00BB85CC File Offset: 0x00BB67CC
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
				WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldMonthCardItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldMonthCardItemUIController worldMonthCardItemUIController2 = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldMonthCardItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06022469 RID: 140393 RVA: 0x00BB86DC File Offset: 0x00BB68DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602246A RID: 140394 RVA: 0x00BB8748 File Offset: 0x00BB6948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602246B RID: 140395 RVA: 0x00BB87B4 File Offset: 0x00BB69B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602246C RID: 140396 RVA: 0x00BB8820 File Offset: 0x00BB6A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMonthCardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602246D RID: 140397 RVA: 0x00BB888C File Offset: 0x00BB6A8C
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
				WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldMonthCardItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldMonthCardItemUIController worldMonthCardItemUIController2 = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldMonthCardItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602246E RID: 140398 RVA: 0x00BB899C File Offset: 0x00BB6B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			string s = worldMonthCardItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602246F RID: 140399 RVA: 0x00BB89F8 File Offset: 0x00BB6BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldMonthCardItemUIController.m_luaExportHelper.__callDele_EventOnItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022470 RID: 140400 RVA: 0x00BB8A54 File Offset: 0x00BB6C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldMonthCardItemUIController.m_luaExportHelper.__clearDele_EventOnItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022471 RID: 140401 RVA: 0x00BB8AB0 File Offset: 0x00BB6CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnItemBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldMonthCardItemUIController.m_luaExportHelper.__callDele_EventOnItemBuyButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022472 RID: 140402 RVA: 0x00BB8B0C File Offset: 0x00BB6D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnItemBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldMonthCardItemUIController.m_luaExportHelper.__clearDele_EventOnItemBuyButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022473 RID: 140403 RVA: 0x00BB8B68 File Offset: 0x00BB6D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldMonthCardItemUIController.EventOnItemButtonClick += value;
				}
				else if (num == 2)
				{
					worldMonthCardItemUIController.EventOnItemButtonClick -= value;
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

	// Token: 0x06022474 RID: 140404 RVA: 0x00BB8BE8 File Offset: 0x00BB6DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnItemBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldMonthCardItemUIController.EventOnItemBuyButtonClick += value;
				}
				else if (num == 2)
				{
					worldMonthCardItemUIController.EventOnItemBuyButtonClick -= value;
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

	// Token: 0x06022475 RID: 140405 RVA: 0x00BB8C68 File Offset: 0x00BB6E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldMonthCardItemUIController.m_luaExportHelper.m_itemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022476 RID: 140406 RVA: 0x00BB8CC0 File Offset: 0x00BB6EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Button itemButton;
			LuaObject.checkType<Button>(l, 2, out itemButton);
			worldMonthCardItemUIController.m_luaExportHelper.m_itemButton = itemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022477 RID: 140407 RVA: 0x00BB8D1C File Offset: 0x00BB6F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldMonthCardItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022478 RID: 140408 RVA: 0x00BB8D74 File Offset: 0x00BB6F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			worldMonthCardItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022479 RID: 140409 RVA: 0x00BB8DD0 File Offset: 0x00BB6FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyButton(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldMonthCardItemUIController.m_luaExportHelper.m_buyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602247A RID: 140410 RVA: 0x00BB8E28 File Offset: 0x00BB7028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyButton(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Button buyButton;
			LuaObject.checkType<Button>(l, 2, out buyButton);
			worldMonthCardItemUIController.m_luaExportHelper.m_buyButton = buyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602247B RID: 140411 RVA: 0x00BB8E84 File Offset: 0x00BB7084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_remainTimeText(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldMonthCardItemUIController.m_luaExportHelper.m_remainTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602247C RID: 140412 RVA: 0x00BB8EDC File Offset: 0x00BB70DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_remainTimeText(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Text remainTimeText;
			LuaObject.checkType<Text>(l, 2, out remainTimeText);
			worldMonthCardItemUIController.m_luaExportHelper.m_remainTimeText = remainTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602247D RID: 140413 RVA: 0x00BB8F38 File Offset: 0x00BB7138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldMonthCardItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602247E RID: 140414 RVA: 0x00BB8F90 File Offset: 0x00BB7190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			worldMonthCardItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602247F RID: 140415 RVA: 0x00BB8FEC File Offset: 0x00BB71EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardId(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldMonthCardItemUIController.CardId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022480 RID: 140416 RVA: 0x00BB9040 File Offset: 0x00BB7240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardId(IntPtr l)
	{
		int result;
		try
		{
			WorldMonthCardItemUIController worldMonthCardItemUIController = (WorldMonthCardItemUIController)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			worldMonthCardItemUIController.CardId = cardId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022481 RID: 140417 RVA: 0x00BB9098 File Offset: 0x00BB7298
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldMonthCardItemUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.UpdateRemainTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.OnItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.OnBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callDele_EventOnItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__clearDele_EventOnItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__callDele_EventOnItemBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.__clearDele_EventOnItemBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache15);
		string name = "EventOnItemButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_EventOnItemButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache16, true);
		string name2 = "EventOnItemBuyButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_EventOnItemBuyButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache17, true);
		string name3 = "m_itemButton";
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.get_m_itemButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_m_itemButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache19, true);
		string name4 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.get_m_iconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_buyButton";
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.get_m_buyButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_m_buyButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_remainTimeText";
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.get_m_remainTimeText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_m_remainTimeText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.get_m_nameText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache21, true);
		string name8 = "CardId";
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.get_CardId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.set_CardId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldMonthCardItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04018273 RID: 98931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018274 RID: 98932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018275 RID: 98933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018276 RID: 98934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018277 RID: 98935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018278 RID: 98936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018279 RID: 98937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401827A RID: 98938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401827B RID: 98939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401827C RID: 98940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401827D RID: 98941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401827E RID: 98942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401827F RID: 98943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018280 RID: 98944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018281 RID: 98945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018282 RID: 98946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018283 RID: 98947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018284 RID: 98948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018285 RID: 98949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018286 RID: 98950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018287 RID: 98951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018288 RID: 98952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018289 RID: 98953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401828A RID: 98954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401828B RID: 98955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401828C RID: 98956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401828D RID: 98957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401828E RID: 98958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401828F RID: 98959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018290 RID: 98960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018291 RID: 98961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018292 RID: 98962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018293 RID: 98963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018294 RID: 98964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018295 RID: 98965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018296 RID: 98966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
