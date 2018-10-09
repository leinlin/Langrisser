using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001425 RID: 5157
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController : LuaObject
{
	// Token: 0x0601D655 RID: 120405 RVA: 0x0094BE94 File Offset: 0x0094A094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateEquipmentDepotView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			ulong equipmentId;
			LuaObject.checkType(l, 4, out equipmentId);
			equipmentDepotUIController.UpdateEquipmentDepotView(hero, slot, equipmentId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D656 RID: 120406 RVA: 0x0094BF08 File Offset: 0x0094A108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFirstEquipmentGoInListForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject firstEquipmentGoInListForUserGuide = equipmentDepotUIController.GetFirstEquipmentGoInListForUserGuide();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, firstEquipmentGoInListForUserGuide);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D657 RID: 120407 RVA: 0x0094BF5C File Offset: 0x0094A15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClickEquipmentListItemForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			equipmentDepotUIController.ClickEquipmentListItemForUserGuide(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D658 RID: 120408 RVA: 0x0094BFB4 File Offset: 0x0094A1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D659 RID: 120409 RVA: 0x0094C008 File Offset: 0x0094A208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSortTypePanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.InitSortTypePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D65A RID: 120410 RVA: 0x0094C05C File Offset: 0x0094A25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLoopScrollRect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.InitLoopScrollRect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D65B RID: 120411 RVA: 0x0094C0B0 File Offset: 0x0094A2B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateEquipmentList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.CreateEquipmentList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D65C RID: 120412 RVA: 0x0094C104 File Offset: 0x0094A304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SortEquipmentListByType(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			List<EquipmentBagItem> list;
			LuaObject.checkType<List<EquipmentBagItem>>(l, 2, out list);
			equipmentDepotUIController.m_luaExportHelper.SortEquipmentListByType(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D65D RID: 120413 RVA: 0x0094C160 File Offset: 0x0094A360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DefaultEquipmentItemComparer(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			EquipmentBagItem e;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out e);
			EquipmentBagItem e2;
			LuaObject.checkType<EquipmentBagItem>(l, 3, out e2);
			int i = equipmentDepotUIController.m_luaExportHelper.DefaultEquipmentItemComparer(e, e2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e3)
		{
			result = LuaObject.error(l, e3);
		}
		return result;
	}

	// Token: 0x0601D65E RID: 120414 RVA: 0x0094C1D4 File Offset: 0x0094A3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectEquipmentPropValueAndSort(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			List<EquipmentBagItem> list;
			LuaObject.checkType<List<EquipmentBagItem>>(l, 2, out list);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 3, out type);
			equipmentDepotUIController.m_luaExportHelper.CollectEquipmentPropValueAndSort(list, type);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D65F RID: 120415 RVA: 0x0094C240 File Offset: 0x0094A440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentListItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			equipmentDepotUIController.m_luaExportHelper.OnEquipmentListItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D660 RID: 120416 RVA: 0x0094C29C File Offset: 0x0094A49C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentListItemNeedFill(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			equipmentDepotUIController.m_luaExportHelper.OnEquipmentListItemNeedFill(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D661 RID: 120417 RVA: 0x0094C2F8 File Offset: 0x0094A4F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFilterSortButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnFilterSortButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D662 RID: 120418 RVA: 0x0094C34C File Offset: 0x0094A54C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCloseFilterSortTypeGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnCloseFilterSortTypeGo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D663 RID: 120419 RVA: 0x0094C3A0 File Offset: 0x0094A5A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFilterSortOrderButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnFilterSortOrderButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D664 RID: 120420 RVA: 0x0094C3F4 File Offset: 0x0094A5F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFilterTypeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			EquipmentSortItemUIController ctrl;
			LuaObject.checkType<EquipmentSortItemUIController>(l, 2, out ctrl);
			bool isOn;
			LuaObject.checkType(l, 3, out isOn);
			equipmentDepotUIController.m_luaExportHelper.OnFilterTypeButtonClick(ctrl, isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D665 RID: 120421 RVA: 0x0094C460 File Offset: 0x0094A660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEquipmentItemDesc(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentItemDesc;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentItemDesc);
			equipmentDepotUIController.m_luaExportHelper.SetEquipmentItemDesc(equipmentItemDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D666 RID: 120422 RVA: 0x0094C4BC File Offset: 0x0094A6BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEquipmentComparison(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentComparison;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentComparison);
			equipmentDepotUIController.m_luaExportHelper.SetEquipmentComparison(equipmentComparison);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D667 RID: 120423 RVA: 0x0094C518 File Offset: 0x0094A718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetEquipmentComparisonPropValue(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.ResetEquipmentComparisonPropValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D668 RID: 120424 RVA: 0x0094C56C File Offset: 0x0094A76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEquipmentComparisonProp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			bool isDressed;
			LuaObject.checkType(l, 4, out isDressed);
			equipmentDepotUIController.m_luaExportHelper.SetEquipmentComparisonProp(type, value, isDressed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D669 RID: 120425 RVA: 0x0094C5E4 File Offset: 0x0094A7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropItemColor(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text oldText;
			LuaObject.checkType<Text>(l, 2, out oldText);
			Text newText;
			LuaObject.checkType<Text>(l, 3, out newText);
			equipmentDepotUIController.m_luaExportHelper.SetPropItemColor(oldText, newText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D66A RID: 120426 RVA: 0x0094C650 File Offset: 0x0094A850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPropItems(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			int addValue;
			LuaObject.checkType(l, 4, out addValue);
			int level;
			LuaObject.checkType(l, 5, out level);
			equipmentDepotUIController.m_luaExportHelper.SetPropItems(type, value, addValue, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D66B RID: 120427 RVA: 0x0094C6D4 File Offset: 0x0094A8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDescEquipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnDescEquipButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D66C RID: 120428 RVA: 0x0094C728 File Offset: 0x0094A928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfirmPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnConfirmPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D66D RID: 120429 RVA: 0x0094C77C File Offset: 0x0094A97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfirmPanelCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnConfirmPanelCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D66E RID: 120430 RVA: 0x0094C7D0 File Offset: 0x0094A9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDescUnloadButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnDescUnloadButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D66F RID: 120431 RVA: 0x0094C824 File Offset: 0x0094AA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDescLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnDescLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D670 RID: 120432 RVA: 0x0094C878 File Offset: 0x0094AA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D671 RID: 120433 RVA: 0x0094C8CC File Offset: 0x0094AACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.OnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D672 RID: 120434 RVA: 0x0094C920 File Offset: 0x0094AB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D673 RID: 120435 RVA: 0x0094C974 File Offset: 0x0094AB74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			equipmentDepotUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D674 RID: 120436 RVA: 0x0094C9E0 File Offset: 0x0094ABE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D675 RID: 120437 RVA: 0x0094CA34 File Offset: 0x0094AC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D676 RID: 120438 RVA: 0x0094CA88 File Offset: 0x0094AC88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = equipmentDepotUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D677 RID: 120439 RVA: 0x0094CB30 File Offset: 0x0094AD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D678 RID: 120440 RVA: 0x0094CB84 File Offset: 0x0094AD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			equipmentDepotUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D679 RID: 120441 RVA: 0x0094CBF0 File Offset: 0x0094ADF0
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
				EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				equipmentDepotUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EquipmentDepotUIController equipmentDepotUIController2 = (EquipmentDepotUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				equipmentDepotUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D67A RID: 120442 RVA: 0x0094CD00 File Offset: 0x0094AF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D67B RID: 120443 RVA: 0x0094CD6C File Offset: 0x0094AF6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D67C RID: 120444 RVA: 0x0094CDD8 File Offset: 0x0094AFD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D67D RID: 120445 RVA: 0x0094CE44 File Offset: 0x0094B044
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentDepotUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D67E RID: 120446 RVA: 0x0094CEB0 File Offset: 0x0094B0B0
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
				EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				equipmentDepotUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EquipmentDepotUIController equipmentDepotUIController2 = (EquipmentDepotUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				equipmentDepotUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D67F RID: 120447 RVA: 0x0094CFC0 File Offset: 0x0094B1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			string s = equipmentDepotUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D680 RID: 120448 RVA: 0x0094D01C File Offset: 0x0094B21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D681 RID: 120449 RVA: 0x0094D070 File Offset: 0x0094B270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D682 RID: 120450 RVA: 0x0094D0C4 File Offset: 0x0094B2C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__callDele_EventOnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D683 RID: 120451 RVA: 0x0094D118 File Offset: 0x0094B318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			equipmentDepotUIController.m_luaExportHelper.__clearDele_EventOnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D684 RID: 120452 RVA: 0x0094D16C File Offset: 0x0094B36C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnTakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			equipmentDepotUIController.m_luaExportHelper.__callDele_EventOnTakeOffEquipment(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D685 RID: 120453 RVA: 0x0094D1E4 File Offset: 0x0094B3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			equipmentDepotUIController.m_luaExportHelper.__clearDele_EventOnTakeOffEquipment(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D686 RID: 120454 RVA: 0x0094D25C File Offset: 0x0094B45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			equipmentDepotUIController.m_luaExportHelper.__callDele_EventOnLockButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D687 RID: 120455 RVA: 0x0094D2C8 File Offset: 0x0094B4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			equipmentDepotUIController.m_luaExportHelper.__clearDele_EventOnLockButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D688 RID: 120456 RVA: 0x0094D334 File Offset: 0x0094B534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEquipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			equipmentDepotUIController.m_luaExportHelper.__callDele_EventOnEquipButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D689 RID: 120457 RVA: 0x0094D3AC File Offset: 0x0094B5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEquipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			equipmentDepotUIController.m_luaExportHelper.__clearDele_EventOnEquipButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D68A RID: 120458 RVA: 0x0094D424 File Offset: 0x0094B624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentDepotUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					equipmentDepotUIController.EventOnReturn -= value;
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

	// Token: 0x0601D68B RID: 120459 RVA: 0x0094D4A4 File Offset: 0x0094B6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentDepotUIController.EventOnGoldAddButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentDepotUIController.EventOnGoldAddButtonClick -= value;
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

	// Token: 0x0601D68C RID: 120460 RVA: 0x0094D524 File Offset: 0x0094B724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentDepotUIController.EventOnTakeOffEquipment += value;
				}
				else if (num == 2)
				{
					equipmentDepotUIController.EventOnTakeOffEquipment -= value;
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

	// Token: 0x0601D68D RID: 120461 RVA: 0x0094D5A4 File Offset: 0x0094B7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Action<ulong, int> value;
			int num = LuaObject.checkDelegate<Action<ulong, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentDepotUIController.EventOnLockButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentDepotUIController.EventOnLockButtonClick -= value;
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

	// Token: 0x0601D68E RID: 120462 RVA: 0x0094D624 File Offset: 0x0094B824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEquipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Action<int, ulong, int> value;
			int num = LuaObject.checkDelegate<Action<int, ulong, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentDepotUIController.EventOnEquipButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentDepotUIController.EventOnEquipButtonClick -= value;
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

	// Token: 0x0601D68F RID: 120463 RVA: 0x0094D6A4 File Offset: 0x0094B8A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D690 RID: 120464 RVA: 0x0094D6FC File Offset: 0x0094B8FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			equipmentDepotUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D691 RID: 120465 RVA: 0x0094D758 File Offset: 0x0094B958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D692 RID: 120466 RVA: 0x0094D7B0 File Offset: 0x0094B9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			equipmentDepotUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D693 RID: 120467 RVA: 0x0094D80C File Offset: 0x0094BA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldAddButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_goldAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D694 RID: 120468 RVA: 0x0094D864 File Offset: 0x0094BA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldAddButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button goldAddButton;
			LuaObject.checkType<Button>(l, 2, out goldAddButton);
			equipmentDepotUIController.m_luaExportHelper.m_goldAddButton = goldAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D695 RID: 120469 RVA: 0x0094D8C0 File Offset: 0x0094BAC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_loopScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D696 RID: 120470 RVA: 0x0094D918 File Offset: 0x0094BB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LoopVerticalScrollRect loopScrollView;
			LuaObject.checkType<LoopVerticalScrollRect>(l, 2, out loopScrollView);
			equipmentDepotUIController.m_luaExportHelper.m_loopScrollView = loopScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D697 RID: 120471 RVA: 0x0094D974 File Offset: 0x0094BB74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_listItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D698 RID: 120472 RVA: 0x0094D9CC File Offset: 0x0094BBCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			EasyObjectPool listItemPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out listItemPool);
			equipmentDepotUIController.m_luaExportHelper.m_listItemPool = listItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D699 RID: 120473 RVA: 0x0094DA28 File Offset: 0x0094BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listScrollViewItemRoot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_listScrollViewItemRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D69A RID: 120474 RVA: 0x0094DA80 File Offset: 0x0094BC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listScrollViewItemRoot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject listScrollViewItemRoot;
			LuaObject.checkType<GameObject>(l, 2, out listScrollViewItemRoot);
			equipmentDepotUIController.m_luaExportHelper.m_listScrollViewItemRoot = listScrollViewItemRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D69B RID: 120475 RVA: 0x0094DADC File Offset: 0x0094BCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_filterSortButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D69C RID: 120476 RVA: 0x0094DB34 File Offset: 0x0094BD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button filterSortButton;
			LuaObject.checkType<Button>(l, 2, out filterSortButton);
			equipmentDepotUIController.m_luaExportHelper.m_filterSortButton = filterSortButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D69D RID: 120477 RVA: 0x0094DB90 File Offset: 0x0094BD90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_filterSortTypeText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_filterSortTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D69E RID: 120478 RVA: 0x0094DBE8 File Offset: 0x0094BDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortTypeText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text filterSortTypeText;
			LuaObject.checkType<Text>(l, 2, out filterSortTypeText);
			equipmentDepotUIController.m_luaExportHelper.m_filterSortTypeText = filterSortTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D69F RID: 120479 RVA: 0x0094DC44 File Offset: 0x0094BE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortOrderButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_filterSortOrderButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A0 RID: 120480 RVA: 0x0094DC9C File Offset: 0x0094BE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortOrderButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button filterSortOrderButton;
			LuaObject.checkType<Button>(l, 2, out filterSortOrderButton);
			equipmentDepotUIController.m_luaExportHelper.m_filterSortOrderButton = filterSortOrderButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A1 RID: 120481 RVA: 0x0094DCF8 File Offset: 0x0094BEF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_filterSortTypesGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_filterSortTypesGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A2 RID: 120482 RVA: 0x0094DD50 File Offset: 0x0094BF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortTypesGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject filterSortTypesGo;
			LuaObject.checkType<GameObject>(l, 2, out filterSortTypesGo);
			equipmentDepotUIController.m_luaExportHelper.m_filterSortTypesGo = filterSortTypesGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A3 RID: 120483 RVA: 0x0094DDAC File Offset: 0x0094BFAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_filterSortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_filterSortTypesGridLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A4 RID: 120484 RVA: 0x0094DE04 File Offset: 0x0094C004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject filterSortTypesGridLayout;
			LuaObject.checkType<GameObject>(l, 2, out filterSortTypesGridLayout);
			equipmentDepotUIController.m_luaExportHelper.m_filterSortTypesGridLayout = filterSortTypesGridLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A5 RID: 120485 RVA: 0x0094DE60 File Offset: 0x0094C060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listNotItemGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_listNotItemGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A6 RID: 120486 RVA: 0x0094DEB8 File Offset: 0x0094C0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listNotItemGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject listNotItemGo;
			LuaObject.checkType<GameObject>(l, 2, out listNotItemGo);
			equipmentDepotUIController.m_luaExportHelper.m_listNotItemGo = listNotItemGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A7 RID: 120487 RVA: 0x0094DF14 File Offset: 0x0094C114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A8 RID: 120488 RVA: 0x0094DF6C File Offset: 0x0094C16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descTitleText;
			LuaObject.checkType<Text>(l, 2, out descTitleText);
			equipmentDepotUIController.m_luaExportHelper.m_descTitleText = descTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6A9 RID: 120489 RVA: 0x0094DFC8 File Offset: 0x0094C1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6AA RID: 120490 RVA: 0x0094E020 File Offset: 0x0094C220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Image descIcon;
			LuaObject.checkType<Image>(l, 2, out descIcon);
			equipmentDepotUIController.m_luaExportHelper.m_descIcon = descIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6AB RID: 120491 RVA: 0x0094E07C File Offset: 0x0094C27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6AC RID: 120492 RVA: 0x0094E0D4 File Offset: 0x0094C2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Image descIconBg;
			LuaObject.checkType<Image>(l, 2, out descIconBg);
			equipmentDepotUIController.m_luaExportHelper.m_descIconBg = descIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6AD RID: 120493 RVA: 0x0094E130 File Offset: 0x0094C330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6AE RID: 120494 RVA: 0x0094E188 File Offset: 0x0094C388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out descSSREffect);
			equipmentDepotUIController.m_luaExportHelper.m_descSSREffect = descSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6AF RID: 120495 RVA: 0x0094E1E4 File Offset: 0x0094C3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B0 RID: 120496 RVA: 0x0094E23C File Offset: 0x0094C43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out descStarGroup);
			equipmentDepotUIController.m_luaExportHelper.m_descStarGroup = descStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B1 RID: 120497 RVA: 0x0094E298 File Offset: 0x0094C498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B2 RID: 120498 RVA: 0x0094E2F0 File Offset: 0x0094C4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descLvText;
			LuaObject.checkType<Text>(l, 2, out descLvText);
			equipmentDepotUIController.m_luaExportHelper.m_descLvText = descLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B3 RID: 120499 RVA: 0x0094E34C File Offset: 0x0094C54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descExpText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B4 RID: 120500 RVA: 0x0094E3A4 File Offset: 0x0094C5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descExpText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descExpText;
			LuaObject.checkType<Text>(l, 2, out descExpText);
			equipmentDepotUIController.m_luaExportHelper.m_descExpText = descExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B5 RID: 120501 RVA: 0x0094E400 File Offset: 0x0094C600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descProgressImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descProgressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B6 RID: 120502 RVA: 0x0094E458 File Offset: 0x0094C658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descProgressImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Image descProgressImage;
			LuaObject.checkType<Image>(l, 2, out descProgressImage);
			equipmentDepotUIController.m_luaExportHelper.m_descProgressImage = descProgressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B7 RID: 120503 RVA: 0x0094E4B4 File Offset: 0x0094C6B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descEquipLimitContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B8 RID: 120504 RVA: 0x0094E50C File Offset: 0x0094C70C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descEquipLimitContent;
			LuaObject.checkType<GameObject>(l, 2, out descEquipLimitContent);
			equipmentDepotUIController.m_luaExportHelper.m_descEquipLimitContent = descEquipLimitContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6B9 RID: 120505 RVA: 0x0094E568 File Offset: 0x0094C768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descEquipUnlimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6BA RID: 120506 RVA: 0x0094E5C0 File Offset: 0x0094C7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descEquipUnlimitText;
			LuaObject.checkType<Text>(l, 2, out descEquipUnlimitText);
			equipmentDepotUIController.m_luaExportHelper.m_descEquipUnlimitText = descEquipUnlimitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6BB RID: 120507 RVA: 0x0094E61C File Offset: 0x0094C81C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descSkillContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6BC RID: 120508 RVA: 0x0094E674 File Offset: 0x0094C874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descSkillContent;
			LuaObject.checkType<GameObject>(l, 2, out descSkillContent);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillContent = descSkillContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6BD RID: 120509 RVA: 0x0094E6D0 File Offset: 0x0094C8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillContentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6BE RID: 120510 RVA: 0x0094E728 File Offset: 0x0094C928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			CommonUIStateController descSkillContentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descSkillContentStateCtrl);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillContentStateCtrl = descSkillContentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6BF RID: 120511 RVA: 0x0094E784 File Offset: 0x0094C984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C0 RID: 120512 RVA: 0x0094E7DC File Offset: 0x0094C9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descSkillNameText;
			LuaObject.checkType<Text>(l, 2, out descSkillNameText);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillNameText = descSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C1 RID: 120513 RVA: 0x0094E838 File Offset: 0x0094CA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C2 RID: 120514 RVA: 0x0094E890 File Offset: 0x0094CA90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descSkillLvText;
			LuaObject.checkType<Text>(l, 2, out descSkillLvText);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillLvText = descSkillLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C3 RID: 120515 RVA: 0x0094E8EC File Offset: 0x0094CAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descUnlockCoditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C4 RID: 120516 RVA: 0x0094E944 File Offset: 0x0094CB44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descUnlockCoditionText;
			LuaObject.checkType<Text>(l, 2, out descUnlockCoditionText);
			equipmentDepotUIController.m_luaExportHelper.m_descUnlockCoditionText = descUnlockCoditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C5 RID: 120517 RVA: 0x0094E9A0 File Offset: 0x0094CBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillOwnerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C6 RID: 120518 RVA: 0x0094E9F8 File Offset: 0x0094CBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descSkillOwnerText;
			LuaObject.checkType<Text>(l, 2, out descSkillOwnerText);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillOwnerText = descSkillOwnerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C7 RID: 120519 RVA: 0x0094EA54 File Offset: 0x0094CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillOwnerBGImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillOwnerBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C8 RID: 120520 RVA: 0x0094EAAC File Offset: 0x0094CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillOwnerBGImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descSkillOwnerBGImage;
			LuaObject.checkType<GameObject>(l, 2, out descSkillOwnerBGImage);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillOwnerBGImage = descSkillOwnerBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6C9 RID: 120521 RVA: 0x0094EB08 File Offset: 0x0094CD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6CA RID: 120522 RVA: 0x0094EB60 File Offset: 0x0094CD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descSkillDescText;
			LuaObject.checkType<Text>(l, 2, out descSkillDescText);
			equipmentDepotUIController.m_luaExportHelper.m_descSkillDescText = descSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6CB RID: 120523 RVA: 0x0094EBBC File Offset: 0x0094CDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descNotEquipSkillTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6CC RID: 120524 RVA: 0x0094EC14 File Offset: 0x0094CE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descNotEquipSkillTip;
			LuaObject.checkType<GameObject>(l, 2, out descNotEquipSkillTip);
			equipmentDepotUIController.m_luaExportHelper.m_descNotEquipSkillTip = descNotEquipSkillTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6CD RID: 120525 RVA: 0x0094EC70 File Offset: 0x0094CE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descLockButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descLockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6CE RID: 120526 RVA: 0x0094ECC8 File Offset: 0x0094CEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descLockButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button descLockButton;
			LuaObject.checkType<Button>(l, 2, out descLockButton);
			equipmentDepotUIController.m_luaExportHelper.m_descLockButton = descLockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6CF RID: 120527 RVA: 0x0094ED24 File Offset: 0x0094CF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descEquipButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descEquipButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D0 RID: 120528 RVA: 0x0094ED7C File Offset: 0x0094CF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descEquipButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button descEquipButton;
			LuaObject.checkType<Button>(l, 2, out descEquipButton);
			equipmentDepotUIController.m_luaExportHelper.m_descEquipButton = descEquipButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D1 RID: 120529 RVA: 0x0094EDD8 File Offset: 0x0094CFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descUnloadButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descUnloadButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D2 RID: 120530 RVA: 0x0094EE30 File Offset: 0x0094D030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descUnloadButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button descUnloadButton;
			LuaObject.checkType<Button>(l, 2, out descUnloadButton);
			equipmentDepotUIController.m_luaExportHelper.m_descUnloadButton = descUnloadButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D3 RID: 120531 RVA: 0x0094EE8C File Offset: 0x0094D08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D4 RID: 120532 RVA: 0x0094EEE4 File Offset: 0x0094D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropContent;
			LuaObject.checkType<GameObject>(l, 2, out descPropContent);
			equipmentDepotUIController.m_luaExportHelper.m_descPropContent = descPropContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D5 RID: 120533 RVA: 0x0094EF40 File Offset: 0x0094D140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D6 RID: 120534 RVA: 0x0094EF98 File Offset: 0x0094D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropATGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropATGo);
			equipmentDepotUIController.m_luaExportHelper.m_descPropATGo = descPropATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D7 RID: 120535 RVA: 0x0094EFF4 File Offset: 0x0094D1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D8 RID: 120536 RVA: 0x0094F04C File Offset: 0x0094D24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropATValueText;
			LuaObject.checkType<Text>(l, 2, out descPropATValueText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropATValueText = descPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6D9 RID: 120537 RVA: 0x0094F0A8 File Offset: 0x0094D2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6DA RID: 120538 RVA: 0x0094F100 File Offset: 0x0094D300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropDFGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropDFGo);
			equipmentDepotUIController.m_luaExportHelper.m_descPropDFGo = descPropDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6DB RID: 120539 RVA: 0x0094F15C File Offset: 0x0094D35C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6DC RID: 120540 RVA: 0x0094F1B4 File Offset: 0x0094D3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out descPropDFValueText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropDFValueText = descPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6DD RID: 120541 RVA: 0x0094F210 File Offset: 0x0094D410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropHPGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6DE RID: 120542 RVA: 0x0094F268 File Offset: 0x0094D468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropHPGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropHPGo);
			equipmentDepotUIController.m_luaExportHelper.m_descPropHPGo = descPropHPGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6DF RID: 120543 RVA: 0x0094F2C4 File Offset: 0x0094D4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E0 RID: 120544 RVA: 0x0094F31C File Offset: 0x0094D51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out descPropHPValueText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropHPValueText = descPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E1 RID: 120545 RVA: 0x0094F378 File Offset: 0x0094D578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropMagiccGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E2 RID: 120546 RVA: 0x0094F3D0 File Offset: 0x0094D5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropMagiccGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropMagiccGo);
			equipmentDepotUIController.m_luaExportHelper.m_descPropMagiccGo = descPropMagiccGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E3 RID: 120547 RVA: 0x0094F42C File Offset: 0x0094D62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E4 RID: 120548 RVA: 0x0094F484 File Offset: 0x0094D684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out descPropMagicValueText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropMagicValueText = descPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E5 RID: 120549 RVA: 0x0094F4E0 File Offset: 0x0094D6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E6 RID: 120550 RVA: 0x0094F538 File Offset: 0x0094D738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropMagicDFGo);
			equipmentDepotUIController.m_luaExportHelper.m_descPropMagicDFGo = descPropMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E7 RID: 120551 RVA: 0x0094F594 File Offset: 0x0094D794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E8 RID: 120552 RVA: 0x0094F5EC File Offset: 0x0094D7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out descPropMagicDFValueText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropMagicDFValueText = descPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6E9 RID: 120553 RVA: 0x0094F648 File Offset: 0x0094D848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropDexGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6EA RID: 120554 RVA: 0x0094F6A0 File Offset: 0x0094D8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropDexGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropDexGo);
			equipmentDepotUIController.m_luaExportHelper.m_descPropDexGo = descPropDexGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6EB RID: 120555 RVA: 0x0094F6FC File Offset: 0x0094D8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropDexValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6EC RID: 120556 RVA: 0x0094F754 File Offset: 0x0094D954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropDexValueText;
			LuaObject.checkType<Text>(l, 2, out descPropDexValueText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropDexValueText = descPropDexValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6ED RID: 120557 RVA: 0x0094F7B0 File Offset: 0x0094D9B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6EE RID: 120558 RVA: 0x0094F808 File Offset: 0x0094DA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			CommonUIStateController descPropGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descPropGroupStateCtrl);
			equipmentDepotUIController.m_luaExportHelper.m_descPropGroupStateCtrl = descPropGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6EF RID: 120559 RVA: 0x0094F864 File Offset: 0x0094DA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F0 RID: 120560 RVA: 0x0094F8BC File Offset: 0x0094DABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject descPropEnchantmentGroup;
			LuaObject.checkType<GameObject>(l, 2, out descPropEnchantmentGroup);
			equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroup = descPropEnchantmentGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F1 RID: 120561 RVA: 0x0094F918 File Offset: 0x0094DB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F2 RID: 120562 RVA: 0x0094F970 File Offset: 0x0094DB70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Image descPropEnchantmentGroupRuneIconImage;
			LuaObject.checkType<Image>(l, 2, out descPropEnchantmentGroupRuneIconImage);
			equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneIconImage = descPropEnchantmentGroupRuneIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F3 RID: 120563 RVA: 0x0094F9CC File Offset: 0x0094DBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F4 RID: 120564 RVA: 0x0094FA24 File Offset: 0x0094DC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text descPropEnchantmentGroupRuneNameText;
			LuaObject.checkType<Text>(l, 2, out descPropEnchantmentGroupRuneNameText);
			equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneNameText = descPropEnchantmentGroupRuneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F5 RID: 120565 RVA: 0x0094FA80 File Offset: 0x0094DC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F6 RID: 120566 RVA: 0x0094FAD8 File Offset: 0x0094DCD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			CommonUIStateController descPropEnchantmentGroupRuneStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descPropEnchantmentGroupRuneStateCtrl);
			equipmentDepotUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneStateCtrl = descPropEnchantmentGroupRuneStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F7 RID: 120567 RVA: 0x0094FB34 File Offset: 0x0094DD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_PropertyComparisonGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_PropertyComparisonGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F8 RID: 120568 RVA: 0x0094FB8C File Offset: 0x0094DD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_PropertyComparisonGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject propertyComparisonGo;
			LuaObject.checkType<GameObject>(l, 2, out propertyComparisonGo);
			equipmentDepotUIController.m_luaExportHelper.m_PropertyComparisonGo = propertyComparisonGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6F9 RID: 120569 RVA: 0x0094FBE8 File Offset: 0x0094DDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescPropGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescPropGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6FA RID: 120570 RVA: 0x0094FC40 File Offset: 0x0094DE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescPropGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescPropGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescPropGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescPropGo = allDescPropGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6FB RID: 120571 RVA: 0x0094FC9C File Offset: 0x0094DE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescHpGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescHpGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6FC RID: 120572 RVA: 0x0094FCF4 File Offset: 0x0094DEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescHpGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescHpGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescHpGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescHpGo = allDescHpGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6FD RID: 120573 RVA: 0x0094FD50 File Offset: 0x0094DF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescHpOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescHpOldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6FE RID: 120574 RVA: 0x0094FDA8 File Offset: 0x0094DFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescHpOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescHpOldText;
			LuaObject.checkType<Text>(l, 2, out allDescHpOldText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescHpOldText = allDescHpOldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D6FF RID: 120575 RVA: 0x0094FE04 File Offset: 0x0094E004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescHpNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescHpNewText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D700 RID: 120576 RVA: 0x0094FE5C File Offset: 0x0094E05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescHpNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescHpNewText;
			LuaObject.checkType<Text>(l, 2, out allDescHpNewText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescHpNewText = allDescHpNewText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D701 RID: 120577 RVA: 0x0094FEB8 File Offset: 0x0094E0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D702 RID: 120578 RVA: 0x0094FF10 File Offset: 0x0094E110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescATGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescATGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescATGo = allDescATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D703 RID: 120579 RVA: 0x0094FF6C File Offset: 0x0094E16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescATOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescATOldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D704 RID: 120580 RVA: 0x0094FFC4 File Offset: 0x0094E1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescATOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescATOldText;
			LuaObject.checkType<Text>(l, 2, out allDescATOldText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescATOldText = allDescATOldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D705 RID: 120581 RVA: 0x00950020 File Offset: 0x0094E220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescATNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescATNewText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D706 RID: 120582 RVA: 0x00950078 File Offset: 0x0094E278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescATNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescATNewText;
			LuaObject.checkType<Text>(l, 2, out allDescATNewText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescATNewText = allDescATNewText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D707 RID: 120583 RVA: 0x009500D4 File Offset: 0x0094E2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D708 RID: 120584 RVA: 0x0095012C File Offset: 0x0094E32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescDFGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescDFGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescDFGo = allDescDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D709 RID: 120585 RVA: 0x00950188 File Offset: 0x0094E388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescDFOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescDFOldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D70A RID: 120586 RVA: 0x009501E0 File Offset: 0x0094E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescDFOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescDFOldText;
			LuaObject.checkType<Text>(l, 2, out allDescDFOldText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescDFOldText = allDescDFOldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D70B RID: 120587 RVA: 0x0095023C File Offset: 0x0094E43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescDFNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescDFNewText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D70C RID: 120588 RVA: 0x00950294 File Offset: 0x0094E494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescDFNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescDFNewText;
			LuaObject.checkType<Text>(l, 2, out allDescDFNewText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescDFNewText = allDescDFNewText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D70D RID: 120589 RVA: 0x009502F0 File Offset: 0x0094E4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D70E RID: 120590 RVA: 0x00950348 File Offset: 0x0094E548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescMagicDFGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescMagicDFGo = allDescMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D70F RID: 120591 RVA: 0x009503A4 File Offset: 0x0094E5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescMagicDFOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescMagicDFOldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D710 RID: 120592 RVA: 0x009503FC File Offset: 0x0094E5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescMagicDFOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescMagicDFOldText;
			LuaObject.checkType<Text>(l, 2, out allDescMagicDFOldText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescMagicDFOldText = allDescMagicDFOldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D711 RID: 120593 RVA: 0x00950458 File Offset: 0x0094E658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescMagicDFNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescMagicDFNewText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D712 RID: 120594 RVA: 0x009504B0 File Offset: 0x0094E6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescMagicDFNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescMagicDFNewText;
			LuaObject.checkType<Text>(l, 2, out allDescMagicDFNewText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescMagicDFNewText = allDescMagicDFNewText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D713 RID: 120595 RVA: 0x0095050C File Offset: 0x0094E70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescMagicGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescMagicGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D714 RID: 120596 RVA: 0x00950564 File Offset: 0x0094E764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescMagicGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescMagicGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescMagicGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescMagicGo = allDescMagicGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D715 RID: 120597 RVA: 0x009505C0 File Offset: 0x0094E7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescMagicOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescMagicOldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D716 RID: 120598 RVA: 0x00950618 File Offset: 0x0094E818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescMagicOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescMagicOldText;
			LuaObject.checkType<Text>(l, 2, out allDescMagicOldText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescMagicOldText = allDescMagicOldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D717 RID: 120599 RVA: 0x00950674 File Offset: 0x0094E874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescMagicNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescMagicNewText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D718 RID: 120600 RVA: 0x009506CC File Offset: 0x0094E8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescMagicNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescMagicNewText;
			LuaObject.checkType<Text>(l, 2, out allDescMagicNewText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescMagicNewText = allDescMagicNewText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D719 RID: 120601 RVA: 0x00950728 File Offset: 0x0094E928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescDexGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescDexGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D71A RID: 120602 RVA: 0x00950780 File Offset: 0x0094E980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescDexGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			GameObject allDescDexGo;
			LuaObject.checkType<GameObject>(l, 2, out allDescDexGo);
			equipmentDepotUIController.m_luaExportHelper.m_allDescDexGo = allDescDexGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D71B RID: 120603 RVA: 0x009507DC File Offset: 0x0094E9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescDexOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescDexOldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D71C RID: 120604 RVA: 0x00950834 File Offset: 0x0094EA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescDexOldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescDexOldText;
			LuaObject.checkType<Text>(l, 2, out allDescDexOldText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescDexOldText = allDescDexOldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D71D RID: 120605 RVA: 0x00950890 File Offset: 0x0094EA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allDescDexNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_allDescDexNewText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D71E RID: 120606 RVA: 0x009508E8 File Offset: 0x0094EAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allDescDexNewText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Text allDescDexNewText;
			LuaObject.checkType<Text>(l, 2, out allDescDexNewText);
			equipmentDepotUIController.m_luaExportHelper.m_allDescDexNewText = allDescDexNewText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D71F RID: 120607 RVA: 0x00950944 File Offset: 0x0094EB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_confirmPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D720 RID: 120608 RVA: 0x0095099C File Offset: 0x0094EB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			CommonUIStateController confirmPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out confirmPanelStateCtrl);
			equipmentDepotUIController.m_luaExportHelper.m_confirmPanelStateCtrl = confirmPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D721 RID: 120609 RVA: 0x009509F8 File Offset: 0x0094EBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_confirmPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D722 RID: 120610 RVA: 0x00950A50 File Offset: 0x0094EC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button confirmPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out confirmPanelCancelButton);
			equipmentDepotUIController.m_luaExportHelper.m_confirmPanelCancelButton = confirmPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D723 RID: 120611 RVA: 0x00950AAC File Offset: 0x0094ECAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_confirmPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D724 RID: 120612 RVA: 0x00950B04 File Offset: 0x0094ED04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_confirmPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Button confirmPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out confirmPanelConfirmButton);
			equipmentDepotUIController.m_luaExportHelper.m_confirmPanelConfirmButton = confirmPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D725 RID: 120613 RVA: 0x00950B60 File Offset: 0x0094ED60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAscend(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_isAscend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D726 RID: 120614 RVA: 0x00950BB8 File Offset: 0x0094EDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAscend(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int isAscend;
			LuaObject.checkType(l, 2, out isAscend);
			equipmentDepotUIController.m_luaExportHelper.m_isAscend = isAscend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D727 RID: 120615 RVA: 0x00950C14 File Offset: 0x0094EE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curEquipmentSortType(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)equipmentDepotUIController.m_luaExportHelper.m_curEquipmentSortType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D728 RID: 120616 RVA: 0x00950C6C File Offset: 0x0094EE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curEquipmentSortType(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			EquipmentDepotUIController.EquipmentSortTypeState curEquipmentSortType;
			LuaObject.checkEnum<EquipmentDepotUIController.EquipmentSortTypeState>(l, 2, out curEquipmentSortType);
			equipmentDepotUIController.m_luaExportHelper.m_curEquipmentSortType = curEquipmentSortType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D729 RID: 120617 RVA: 0x00950CC8 File Offset: 0x0094EEC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D72A RID: 120618 RVA: 0x00950D20 File Offset: 0x0094EF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			equipmentDepotUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D72B RID: 120619 RVA: 0x00950D7C File Offset: 0x0094EF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D72C RID: 120620 RVA: 0x00950DD4 File Offset: 0x0094EFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			equipmentDepotUIController.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D72D RID: 120621 RVA: 0x00950E30 File Offset: 0x0094F030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canUseEquipmentCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_canUseEquipmentCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D72E RID: 120622 RVA: 0x00950E88 File Offset: 0x0094F088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canUseEquipmentCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			int canUseEquipmentCount;
			LuaObject.checkType(l, 2, out canUseEquipmentCount);
			equipmentDepotUIController.m_luaExportHelper.m_canUseEquipmentCount = canUseEquipmentCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D72F RID: 120623 RVA: 0x00950EE4 File Offset: 0x0094F0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curEquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_curEquipmentInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D730 RID: 120624 RVA: 0x00950F3C File Offset: 0x0094F13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curEquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			ulong curEquipmentInstanceId;
			LuaObject.checkType(l, 2, out curEquipmentInstanceId);
			equipmentDepotUIController.m_luaExportHelper.m_curEquipmentInstanceId = curEquipmentInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D731 RID: 120625 RVA: 0x00950F98 File Offset: 0x0094F198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D732 RID: 120626 RVA: 0x00950FF0 File Offset: 0x0094F1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			equipmentDepotUIController.m_luaExportHelper.m_isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D733 RID: 120627 RVA: 0x0095104C File Offset: 0x0094F24C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipItemCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_equipItemCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D734 RID: 120628 RVA: 0x009510A4 File Offset: 0x0094F2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			List<EquipmentBagItem> equipItemCache;
			LuaObject.checkType<List<EquipmentBagItem>>(l, 2, out equipItemCache);
			equipmentDepotUIController.m_luaExportHelper.m_equipItemCache = equipItemCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D735 RID: 120629 RVA: 0x00951100 File Offset: 0x0094F300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipmentDepotCtrlList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_equipmentDepotCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D736 RID: 120630 RVA: 0x00951158 File Offset: 0x0094F358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentDepotCtrlList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			List<EquipmentDepotListItemUIController> equipmentDepotCtrlList;
			LuaObject.checkType<List<EquipmentDepotListItemUIController>>(l, 2, out equipmentDepotCtrlList);
			equipmentDepotUIController.m_luaExportHelper.m_equipmentDepotCtrlList = equipmentDepotCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D737 RID: 120631 RVA: 0x009511B4 File Offset: 0x0094F3B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D738 RID: 120632 RVA: 0x0095120C File Offset: 0x0094F40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			equipmentDepotUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D739 RID: 120633 RVA: 0x00951268 File Offset: 0x0094F468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D73A RID: 120634 RVA: 0x009512C0 File Offset: 0x0094F4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUIController equipmentDepotUIController = (EquipmentDepotUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			equipmentDepotUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D73B RID: 120635 RVA: 0x0095131C File Offset: 0x0094F51C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentDepotUIController");
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.UpdateEquipmentDepotView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.GetFirstEquipmentGoInListForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.ClickEquipmentListItemForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.InitSortTypePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.InitLoopScrollRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.CreateEquipmentList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.SortEquipmentListByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.DefaultEquipmentItemComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.CollectEquipmentPropValueAndSort);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnEquipmentListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnEquipmentListItemNeedFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnFilterSortButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnCloseFilterSortTypeGo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnFilterSortOrderButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnFilterTypeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.SetEquipmentItemDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.SetEquipmentComparison);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.ResetEquipmentComparisonPropValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.SetEquipmentComparisonProp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.SetPropItemColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.SetPropItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnDescEquipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnConfirmPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnConfirmPanelCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnDescUnloadButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnDescLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callDele_EventOnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__clearDele_EventOnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callDele_EventOnTakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__clearDele_EventOnTakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callDele_EventOnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__clearDele_EventOnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__callDele_EventOnEquipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.__clearDele_EventOnEquipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache34);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache35, true);
		string name2 = "EventOnGoldAddButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_EventOnGoldAddButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache36, true);
		string name3 = "EventOnTakeOffEquipment";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_EventOnTakeOffEquipment);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache37, true);
		string name4 = "EventOnLockButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_EventOnLockButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache38, true);
		string name5 = "EventOnEquipButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_EventOnEquipButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache39, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3B, true);
		string name7 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_goldText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3D, true);
		string name8 = "m_goldAddButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_goldAddButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_goldAddButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache3F, true);
		string name9 = "m_loopScrollView";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_loopScrollView);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_loopScrollView);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache41, true);
		string name10 = "m_listItemPool";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_listItemPool);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_listItemPool);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache43, true);
		string name11 = "m_listScrollViewItemRoot";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_listScrollViewItemRoot);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_listScrollViewItemRoot);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache45, true);
		string name12 = "m_filterSortButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_filterSortButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_filterSortButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache47, true);
		string name13 = "m_filterSortTypeText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_filterSortTypeText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_filterSortTypeText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache49, true);
		string name14 = "m_filterSortOrderButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_filterSortOrderButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_filterSortOrderButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4B, true);
		string name15 = "m_filterSortTypesGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_filterSortTypesGo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_filterSortTypesGo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4D, true);
		string name16 = "m_filterSortTypesGridLayout";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_filterSortTypesGridLayout);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_filterSortTypesGridLayout);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache4F, true);
		string name17 = "m_listNotItemGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_listNotItemGo);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_listNotItemGo);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache51, true);
		string name18 = "m_descTitleText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descTitleText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descTitleText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache53, true);
		string name19 = "m_descIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descIcon);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descIcon);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache55, true);
		string name20 = "m_descIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descIconBg);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descIconBg);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache57, true);
		string name21 = "m_descSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSSREffect);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSSREffect);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache59, true);
		string name22 = "m_descStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descStarGroup);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descStarGroup);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5B, true);
		string name23 = "m_descLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descLvText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descLvText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5D, true);
		string name24 = "m_descExpText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descExpText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descExpText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache5F, true);
		string name25 = "m_descProgressImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descProgressImage);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descProgressImage);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache61, true);
		string name26 = "m_descEquipLimitContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descEquipLimitContent);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descEquipLimitContent);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache63, true);
		string name27 = "m_descEquipUnlimitText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descEquipUnlimitText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descEquipUnlimitText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache65, true);
		string name28 = "m_descSkillContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillContent);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillContent);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache67, true);
		string name29 = "m_descSkillContentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillContentStateCtrl);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillContentStateCtrl);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache69, true);
		string name30 = "m_descSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillNameText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillNameText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6B, true);
		string name31 = "m_descSkillLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillLvText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillLvText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6D, true);
		string name32 = "m_descUnlockCoditionText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descUnlockCoditionText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descUnlockCoditionText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache6F, true);
		string name33 = "m_descSkillOwnerText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillOwnerText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillOwnerText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache71, true);
		string name34 = "m_descSkillOwnerBGImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillOwnerBGImage);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillOwnerBGImage);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache73, true);
		string name35 = "m_descSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descSkillDescText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descSkillDescText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache75, true);
		string name36 = "m_descNotEquipSkillTip";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descNotEquipSkillTip);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descNotEquipSkillTip);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache77, true);
		string name37 = "m_descLockButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descLockButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descLockButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache79, true);
		string name38 = "m_descEquipButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descEquipButton);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descEquipButton);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7B, true);
		string name39 = "m_descUnloadButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descUnloadButton);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descUnloadButton);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7D, true);
		string name40 = "m_descPropContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropContent);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropContent);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache7F, true);
		string name41 = "m_descPropATGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropATGo);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropATGo);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache81, true);
		string name42 = "m_descPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropATValueText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropATValueText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache83, true);
		string name43 = "m_descPropDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropDFGo);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropDFGo);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache85, true);
		string name44 = "m_descPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropDFValueText);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropDFValueText);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache87, true);
		string name45 = "m_descPropHPGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropHPGo);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropHPGo);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache89, true);
		string name46 = "m_descPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropHPValueText);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropHPValueText);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8B, true);
		string name47 = "m_descPropMagiccGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropMagiccGo);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropMagiccGo);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8D, true);
		string name48 = "m_descPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropMagicValueText);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropMagicValueText);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache8F, true);
		string name49 = "m_descPropMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropMagicDFGo);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropMagicDFGo);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache91, true);
		string name50 = "m_descPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropMagicDFValueText);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropMagicDFValueText);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache93, true);
		string name51 = "m_descPropDexGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropDexGo);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropDexGo);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache95, true);
		string name52 = "m_descPropDexValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropDexValueText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropDexValueText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache97, true);
		string name53 = "m_descPropGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropGroupStateCtrl);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropGroupStateCtrl);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache99, true);
		string name54 = "m_descPropEnchantmentGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropEnchantmentGroup);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropEnchantmentGroup);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9B, true);
		string name55 = "m_descPropEnchantmentGroupRuneIconImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropEnchantmentGroupRuneIconImage);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropEnchantmentGroupRuneIconImage);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9D, true);
		string name56 = "m_descPropEnchantmentGroupRuneNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropEnchantmentGroupRuneNameText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropEnchantmentGroupRuneNameText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cache9F, true);
		string name57 = "m_descPropEnchantmentGroupRuneStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_descPropEnchantmentGroupRuneStateCtrl);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_descPropEnchantmentGroupRuneStateCtrl);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA1, true);
		string name58 = "m_PropertyComparisonGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_PropertyComparisonGo);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_PropertyComparisonGo);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA3, true);
		string name59 = "m_allDescPropGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescPropGo);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescPropGo);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA5, true);
		string name60 = "m_allDescHpGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescHpGo);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescHpGo);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA7, true);
		string name61 = "m_allDescHpOldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescHpOldText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescHpOldText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheA9, true);
		string name62 = "m_allDescHpNewText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescHpNewText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescHpNewText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAB, true);
		string name63 = "m_allDescATGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescATGo);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescATGo);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAD, true);
		string name64 = "m_allDescATOldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescATOldText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescATOldText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheAF, true);
		string name65 = "m_allDescATNewText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescATNewText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescATNewText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB1, true);
		string name66 = "m_allDescDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescDFGo);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescDFGo);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB3, true);
		string name67 = "m_allDescDFOldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescDFOldText);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescDFOldText);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB5, true);
		string name68 = "m_allDescDFNewText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescDFNewText);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescDFNewText);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB7, true);
		string name69 = "m_allDescMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescMagicDFGo);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescMagicDFGo);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheB9, true);
		string name70 = "m_allDescMagicDFOldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescMagicDFOldText);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescMagicDFOldText);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBB, true);
		string name71 = "m_allDescMagicDFNewText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescMagicDFNewText);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescMagicDFNewText);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBD, true);
		string name72 = "m_allDescMagicGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescMagicGo);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescMagicGo);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheBF, true);
		string name73 = "m_allDescMagicOldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescMagicOldText);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescMagicOldText);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC1, true);
		string name74 = "m_allDescMagicNewText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescMagicNewText);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescMagicNewText);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC3, true);
		string name75 = "m_allDescDexGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescDexGo);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescDexGo);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC5, true);
		string name76 = "m_allDescDexOldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescDexOldText);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescDexOldText);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC7, true);
		string name77 = "m_allDescDexNewText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_allDescDexNewText);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_allDescDexNewText);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheC9, true);
		string name78 = "m_confirmPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_confirmPanelStateCtrl);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_confirmPanelStateCtrl);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCB, true);
		string name79 = "m_confirmPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_confirmPanelCancelButton);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_confirmPanelCancelButton);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCD, true);
		string name80 = "m_confirmPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_confirmPanelConfirmButton);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_confirmPanelConfirmButton);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheCF, true);
		string name81 = "m_isAscend";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_isAscend);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_isAscend);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD1, true);
		string name82 = "m_curEquipmentSortType";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_curEquipmentSortType);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_curEquipmentSortType);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD3, true);
		string name83 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_hero);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_hero);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD5, true);
		string name84 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_slot);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_slot);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD7, true);
		string name85 = "m_canUseEquipmentCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_canUseEquipmentCount);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_canUseEquipmentCount);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheD9, true);
		string name86 = "m_curEquipmentInstanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_curEquipmentInstanceId);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_curEquipmentInstanceId);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDB, true);
		string name87 = "m_isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_isFirstIn);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_isFirstIn);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDD, true);
		string name88 = "m_equipItemCache";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_equipItemCache);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_equipItemCache);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheDF, true);
		string name89 = "m_equipmentDepotCtrlList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_equipmentDepotCtrlList);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_equipmentDepotCtrlList);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE1, true);
		string name90 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_playerContext);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE3, true);
		string name91 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.get_m_configDataLoader);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.<>f__mg$cacheE5, true);
		LuaObject.createTypeMetatable(l, null, typeof(EquipmentDepotUIController), typeof(UIControllerBase));
	}

	// Token: 0x040137ED RID: 79853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040137EE RID: 79854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040137EF RID: 79855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040137F0 RID: 79856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040137F1 RID: 79857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040137F2 RID: 79858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040137F3 RID: 79859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040137F4 RID: 79860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040137F5 RID: 79861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040137F6 RID: 79862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040137F7 RID: 79863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040137F8 RID: 79864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040137F9 RID: 79865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040137FA RID: 79866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040137FB RID: 79867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040137FC RID: 79868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040137FD RID: 79869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040137FE RID: 79870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040137FF RID: 79871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013800 RID: 79872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013801 RID: 79873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013802 RID: 79874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013803 RID: 79875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013804 RID: 79876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013805 RID: 79877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013806 RID: 79878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013807 RID: 79879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013808 RID: 79880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013809 RID: 79881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401380A RID: 79882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401380B RID: 79883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401380C RID: 79884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401380D RID: 79885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401380E RID: 79886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401380F RID: 79887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013810 RID: 79888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013811 RID: 79889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013812 RID: 79890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013813 RID: 79891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013814 RID: 79892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013815 RID: 79893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013816 RID: 79894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013817 RID: 79895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013818 RID: 79896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013819 RID: 79897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401381A RID: 79898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401381B RID: 79899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401381C RID: 79900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401381D RID: 79901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401381E RID: 79902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401381F RID: 79903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013820 RID: 79904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013821 RID: 79905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013822 RID: 79906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013823 RID: 79907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013824 RID: 79908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013825 RID: 79909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013826 RID: 79910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013827 RID: 79911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013828 RID: 79912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013829 RID: 79913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401382A RID: 79914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401382B RID: 79915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401382C RID: 79916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401382D RID: 79917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401382E RID: 79918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401382F RID: 79919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013830 RID: 79920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013831 RID: 79921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013832 RID: 79922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013833 RID: 79923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013834 RID: 79924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013835 RID: 79925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013836 RID: 79926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013837 RID: 79927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013838 RID: 79928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013839 RID: 79929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401383A RID: 79930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401383B RID: 79931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401383C RID: 79932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401383D RID: 79933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401383E RID: 79934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401383F RID: 79935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013840 RID: 79936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013841 RID: 79937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013842 RID: 79938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013843 RID: 79939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013844 RID: 79940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013845 RID: 79941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013846 RID: 79942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013847 RID: 79943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013848 RID: 79944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04013849 RID: 79945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401384A RID: 79946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401384B RID: 79947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401384C RID: 79948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401384D RID: 79949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401384E RID: 79950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401384F RID: 79951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013850 RID: 79952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013851 RID: 79953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013852 RID: 79954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013853 RID: 79955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013854 RID: 79956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013855 RID: 79957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04013856 RID: 79958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04013857 RID: 79959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04013858 RID: 79960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04013859 RID: 79961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401385A RID: 79962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401385B RID: 79963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401385C RID: 79964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401385D RID: 79965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401385E RID: 79966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0401385F RID: 79967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013860 RID: 79968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013861 RID: 79969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013862 RID: 79970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013863 RID: 79971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013864 RID: 79972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04013865 RID: 79973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04013866 RID: 79974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04013867 RID: 79975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04013868 RID: 79976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04013869 RID: 79977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401386A RID: 79978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401386B RID: 79979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401386C RID: 79980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0401386D RID: 79981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0401386E RID: 79982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0401386F RID: 79983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013870 RID: 79984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013871 RID: 79985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013872 RID: 79986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013873 RID: 79987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04013874 RID: 79988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04013875 RID: 79989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04013876 RID: 79990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04013877 RID: 79991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04013878 RID: 79992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04013879 RID: 79993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401387A RID: 79994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401387B RID: 79995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401387C RID: 79996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401387D RID: 79997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0401387E RID: 79998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0401387F RID: 79999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04013880 RID: 80000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04013881 RID: 80001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04013882 RID: 80002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04013883 RID: 80003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04013884 RID: 80004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04013885 RID: 80005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04013886 RID: 80006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04013887 RID: 80007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04013888 RID: 80008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04013889 RID: 80009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401388A RID: 80010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401388B RID: 80011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0401388C RID: 80012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0401388D RID: 80013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0401388E RID: 80014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0401388F RID: 80015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04013890 RID: 80016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04013891 RID: 80017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04013892 RID: 80018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04013893 RID: 80019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04013894 RID: 80020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04013895 RID: 80021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04013896 RID: 80022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04013897 RID: 80023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04013898 RID: 80024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04013899 RID: 80025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401389A RID: 80026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401389B RID: 80027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0401389C RID: 80028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0401389D RID: 80029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0401389E RID: 80030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0401389F RID: 80031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040138A0 RID: 80032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040138A1 RID: 80033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040138A2 RID: 80034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040138A3 RID: 80035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040138A4 RID: 80036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040138A5 RID: 80037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040138A6 RID: 80038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040138A7 RID: 80039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040138A8 RID: 80040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040138A9 RID: 80041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040138AA RID: 80042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040138AB RID: 80043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040138AC RID: 80044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040138AD RID: 80045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040138AE RID: 80046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040138AF RID: 80047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040138B0 RID: 80048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040138B1 RID: 80049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040138B2 RID: 80050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040138B3 RID: 80051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040138B4 RID: 80052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040138B5 RID: 80053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040138B6 RID: 80054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040138B7 RID: 80055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040138B8 RID: 80056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040138B9 RID: 80057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040138BA RID: 80058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040138BB RID: 80059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040138BC RID: 80060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040138BD RID: 80061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040138BE RID: 80062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040138BF RID: 80063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040138C0 RID: 80064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040138C1 RID: 80065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040138C2 RID: 80066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040138C3 RID: 80067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040138C4 RID: 80068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040138C5 RID: 80069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040138C6 RID: 80070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040138C7 RID: 80071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040138C8 RID: 80072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040138C9 RID: 80073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040138CA RID: 80074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040138CB RID: 80075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040138CC RID: 80076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040138CD RID: 80077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040138CE RID: 80078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040138CF RID: 80079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040138D0 RID: 80080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040138D1 RID: 80081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040138D2 RID: 80082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;
}
