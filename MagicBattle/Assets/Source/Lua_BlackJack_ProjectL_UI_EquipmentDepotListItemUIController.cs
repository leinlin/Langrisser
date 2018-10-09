using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001424 RID: 5156
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController : LuaObject
{
	// Token: 0x0601D61C RID: 120348 RVA: 0x0094A204 File Offset: 0x00948404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEquipmentDepotListItemInfo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			bool canWear;
			LuaObject.checkType(l, 3, out canWear);
			equipmentDepotListItemUIController.InitEquipmentDepotListItemInfo(bagItem, canWear);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D61D RID: 120349 RVA: 0x0094A268 File Offset: 0x00948468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCheckImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			equipmentDepotListItemUIController.ShowCheckImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D61E RID: 120350 RVA: 0x0094A2C0 File Offset: 0x009484C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectFrame(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			equipmentDepotListItemUIController.ShowSelectFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D61F RID: 120351 RVA: 0x0094A318 File Offset: 0x00948518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			equipmentDepotListItemUIController.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D620 RID: 120352 RVA: 0x0094A364 File Offset: 0x00948564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			equipmentDepotListItemUIController.RegisterItemClickEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D621 RID: 120353 RVA: 0x0094A3BC File Offset: 0x009485BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItemNeedFillEvent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			equipmentDepotListItemUIController.RegisterItemNeedFillEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D622 RID: 120354 RVA: 0x0094A414 File Offset: 0x00948614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItem3DTouchEvent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			equipmentDepotListItemUIController.RegisterItem3DTouchEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D623 RID: 120355 RVA: 0x0094A46C File Offset: 0x0094866C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			equipmentDepotListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D624 RID: 120356 RVA: 0x0094A4C0 File Offset: 0x009486C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D625 RID: 120357 RVA: 0x0094A52C File Offset: 0x0094872C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D626 RID: 120358 RVA: 0x0094A580 File Offset: 0x00948780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D627 RID: 120359 RVA: 0x0094A5D4 File Offset: 0x009487D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = equipmentDepotListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D628 RID: 120360 RVA: 0x0094A67C File Offset: 0x0094887C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D629 RID: 120361 RVA: 0x0094A6D0 File Offset: 0x009488D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D62A RID: 120362 RVA: 0x0094A73C File Offset: 0x0094893C
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
				EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				equipmentDepotListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EquipmentDepotListItemUIController equipmentDepotListItemUIController2 = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				equipmentDepotListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D62B RID: 120363 RVA: 0x0094A84C File Offset: 0x00948A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D62C RID: 120364 RVA: 0x0094A8B8 File Offset: 0x00948AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D62D RID: 120365 RVA: 0x0094A924 File Offset: 0x00948B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D62E RID: 120366 RVA: 0x0094A990 File Offset: 0x00948B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D62F RID: 120367 RVA: 0x0094A9FC File Offset: 0x00948BFC
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
				EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				equipmentDepotListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EquipmentDepotListItemUIController equipmentDepotListItemUIController2 = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				equipmentDepotListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D630 RID: 120368 RVA: 0x0094AB0C File Offset: 0x00948D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			string s = equipmentDepotListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D631 RID: 120369 RVA: 0x0094AB68 File Offset: 0x00948D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D632 RID: 120370 RVA: 0x0094ABBC File Offset: 0x00948DBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			equipmentDepotListItemUIController.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D633 RID: 120371 RVA: 0x0094AC14 File Offset: 0x00948E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D634 RID: 120372 RVA: 0x0094AC68 File Offset: 0x00948E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			equipmentDepotListItemUIController.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D635 RID: 120373 RVA: 0x0094ACC0 File Offset: 0x00948EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgFrame(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_bgFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D636 RID: 120374 RVA: 0x0094AD14 File Offset: 0x00948F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgFrame(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Image bgFrame;
			LuaObject.checkType<Image>(l, 2, out bgFrame);
			equipmentDepotListItemUIController.m_bgFrame = bgFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D637 RID: 120375 RVA: 0x0094AD6C File Offset: 0x00948F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_SSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_SSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D638 RID: 120376 RVA: 0x0094ADC0 File Offset: 0x00948FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_SSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			GameObject ssreffect;
			LuaObject.checkType<GameObject>(l, 2, out ssreffect);
			equipmentDepotListItemUIController.m_SSREffect = ssreffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D639 RID: 120377 RVA: 0x0094AE18 File Offset: 0x00949018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_checkImageMask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_checkImageMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D63A RID: 120378 RVA: 0x0094AE6C File Offset: 0x0094906C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_checkImageMask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			GameObject checkImageMask;
			LuaObject.checkType<GameObject>(l, 2, out checkImageMask);
			equipmentDepotListItemUIController.m_checkImageMask = checkImageMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D63B RID: 120379 RVA: 0x0094AEC4 File Offset: 0x009490C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_starGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D63C RID: 120380 RVA: 0x0094AF18 File Offset: 0x00949118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			GameObject starGroup;
			LuaObject.checkType<GameObject>(l, 2, out starGroup);
			equipmentDepotListItemUIController.m_starGroup = starGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D63D RID: 120381 RVA: 0x0094AF70 File Offset: 0x00949170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_lvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D63E RID: 120382 RVA: 0x0094AFC4 File Offset: 0x009491C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Text lvValueText;
			LuaObject.checkType<Text>(l, 2, out lvValueText);
			equipmentDepotListItemUIController.m_lvValueText = lvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D63F RID: 120383 RVA: 0x0094B01C File Offset: 0x0094921C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipingTagHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_equipingTagHeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D640 RID: 120384 RVA: 0x0094B070 File Offset: 0x00949270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipingTagHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Image equipingTagHeadIcon;
			LuaObject.checkType<Image>(l, 2, out equipingTagHeadIcon);
			equipmentDepotListItemUIController.m_equipingTagHeadIcon = equipingTagHeadIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D641 RID: 120385 RVA: 0x0094B0C8 File Offset: 0x009492C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_lockImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D642 RID: 120386 RVA: 0x0094B11C File Offset: 0x0094931C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lockImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			GameObject lockImage;
			LuaObject.checkType<GameObject>(l, 2, out lockImage);
			equipmentDepotListItemUIController.m_lockImage = lockImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D643 RID: 120387 RVA: 0x0094B174 File Offset: 0x00949374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_selectFrame(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_selectFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D644 RID: 120388 RVA: 0x0094B1C8 File Offset: 0x009493C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectFrame(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			GameObject selectFrame;
			LuaObject.checkType<GameObject>(l, 2, out selectFrame);
			equipmentDepotListItemUIController.m_selectFrame = selectFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D645 RID: 120389 RVA: 0x0094B220 File Offset: 0x00949420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_mask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D646 RID: 120390 RVA: 0x0094B274 File Offset: 0x00949474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			GameObject mask;
			LuaObject.checkType<GameObject>(l, 2, out mask);
			equipmentDepotListItemUIController.m_mask = mask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D647 RID: 120391 RVA: 0x0094B2CC File Offset: 0x009494CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_enchantmentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D648 RID: 120392 RVA: 0x0094B320 File Offset: 0x00949520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Image enchantmentIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentIcon);
			equipmentDepotListItemUIController.m_enchantmentIcon = enchantmentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D649 RID: 120393 RVA: 0x0094B378 File Offset: 0x00949578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D64A RID: 120394 RVA: 0x0094B3CC File Offset: 0x009495CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			equipmentDepotListItemUIController.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D64B RID: 120395 RVA: 0x0094B424 File Offset: 0x00949624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsEquiped(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.IsEquiped);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D64C RID: 120396 RVA: 0x0094B478 File Offset: 0x00949678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsEquiped(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			bool isEquiped;
			LuaObject.checkType(l, 2, out isEquiped);
			equipmentDepotListItemUIController.IsEquiped = isEquiped;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D64D RID: 120397 RVA: 0x0094B4D0 File Offset: 0x009496D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.EquipmentInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D64E RID: 120398 RVA: 0x0094B524 File Offset: 0x00949724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			equipmentDepotListItemUIController.EquipmentInstanceId = equipmentInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D64F RID: 120399 RVA: 0x0094B57C File Offset: 0x0094977C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BagItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.BagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D650 RID: 120400 RVA: 0x0094B5D0 File Offset: 0x009497D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BagItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			equipmentDepotListItemUIController.BagItem = bagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D651 RID: 120401 RVA: 0x0094B628 File Offset: 0x00949828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotListItemUIController.ScrollItemBaseUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D652 RID: 120402 RVA: 0x0094B67C File Offset: 0x0094987C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = (EquipmentDepotListItemUIController)LuaObject.checkSelf(l);
			ScrollItemBaseUIController scrollItemBaseUICtrl;
			LuaObject.checkType<ScrollItemBaseUIController>(l, 2, out scrollItemBaseUICtrl);
			equipmentDepotListItemUIController.ScrollItemBaseUICtrl = scrollItemBaseUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D653 RID: 120403 RVA: 0x0094B6D4 File Offset: 0x009498D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentDepotListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.InitEquipmentDepotListItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.ShowCheckImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.ShowSelectFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.RegisterItemClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.RegisterItemNeedFillEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.RegisterItem3DTouchEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache14);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache16, true);
		string name2 = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_icon);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_icon);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache18, true);
		string name3 = "m_bgFrame";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_bgFrame);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_bgFrame);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_SSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_SSREffect);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_SSREffect);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_checkImageMask";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_checkImageMask);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_checkImageMask);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_starGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_starGroup);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_starGroup);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache20, true);
		string name7 = "m_lvValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_lvValueText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_lvValueText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache22, true);
		string name8 = "m_equipingTagHeadIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_equipingTagHeadIcon);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_equipingTagHeadIcon);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache24, true);
		string name9 = "m_lockImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_lockImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_lockImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache26, true);
		string name10 = "m_selectFrame";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_selectFrame);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_selectFrame);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache28, true);
		string name11 = "m_mask";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_mask);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_mask);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2A, true);
		string name12 = "m_enchantmentIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_enchantmentIcon);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_enchantmentIcon);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2C, true);
		string name13 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_m_countText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_m_countText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2E, true);
		string name14 = "IsEquiped";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_IsEquiped);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_IsEquiped);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache30, true);
		string name15 = "EquipmentInstanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_EquipmentInstanceId);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_EquipmentInstanceId);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache32, true);
		string name16 = "BagItem";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_BagItem);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_BagItem);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache34, true);
		string name17 = "ScrollItemBaseUICtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.get_ScrollItemBaseUICtrl);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.set_ScrollItemBaseUICtrl);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.<>f__mg$cache36, true);
		LuaObject.createTypeMetatable(l, null, typeof(EquipmentDepotListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040137B6 RID: 79798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040137B7 RID: 79799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040137B8 RID: 79800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040137B9 RID: 79801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040137BA RID: 79802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040137BB RID: 79803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040137BC RID: 79804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040137BD RID: 79805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040137BE RID: 79806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040137BF RID: 79807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040137C0 RID: 79808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040137C1 RID: 79809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040137C2 RID: 79810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040137C3 RID: 79811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040137C4 RID: 79812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040137C5 RID: 79813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040137C6 RID: 79814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040137C7 RID: 79815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040137C8 RID: 79816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040137C9 RID: 79817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040137CA RID: 79818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040137CB RID: 79819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040137CC RID: 79820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040137CD RID: 79821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040137CE RID: 79822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040137CF RID: 79823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040137D0 RID: 79824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040137D1 RID: 79825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040137D2 RID: 79826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040137D3 RID: 79827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040137D4 RID: 79828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040137D5 RID: 79829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040137D6 RID: 79830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040137D7 RID: 79831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040137D8 RID: 79832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040137D9 RID: 79833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040137DA RID: 79834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040137DB RID: 79835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040137DC RID: 79836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040137DD RID: 79837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040137DE RID: 79838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040137DF RID: 79839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040137E0 RID: 79840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040137E1 RID: 79841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040137E2 RID: 79842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040137E3 RID: 79843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040137E4 RID: 79844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040137E5 RID: 79845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040137E6 RID: 79846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040137E7 RID: 79847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040137E8 RID: 79848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040137E9 RID: 79849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040137EA RID: 79850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040137EB RID: 79851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040137EC RID: 79852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
