using System;
using System.Collections;
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

// Token: 0x0200142A RID: 5162
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController : LuaObject
{
	// Token: 0x0601D783 RID: 120707 RVA: 0x00955258 File Offset: 0x00953458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateEquipmentForgeView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentForgeUIController.ForgeState forgeState;
			LuaObject.checkEnum<EquipmentForgeUIController.ForgeState>(l, 2, out forgeState);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			ulong equipmentId;
			LuaObject.checkType(l, 4, out equipmentId);
			equipmentForgeUIController.UpdateEquipmentForgeView(forgeState, slot, equipmentId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D784 RID: 120708 RVA: 0x009552CC File Offset: 0x009534CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnhanceFastAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.OnEnhanceFastAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D785 RID: 120709 RVA: 0x00955318 File Offset: 0x00953518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPlayerResourceGold(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.SetPlayerResourceGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D786 RID: 120710 RVA: 0x00955364 File Offset: 0x00953564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFirstEquipmentGoInListForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject firstEquipmentGoInListForUserGuide = equipmentForgeUIController.GetFirstEquipmentGoInListForUserGuide();
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

	// Token: 0x0601D787 RID: 120711 RVA: 0x009553B8 File Offset: 0x009535B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D788 RID: 120712 RVA: 0x0095540C File Offset: 0x0095360C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSortTypePanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.InitSortTypePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D789 RID: 120713 RVA: 0x00955460 File Offset: 0x00953660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitLoopScrollRect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.InitLoopScrollRect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D78A RID: 120714 RVA: 0x009554B4 File Offset: 0x009536B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateEquipmentList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.CreateEquipmentList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D78B RID: 120715 RVA: 0x00955508 File Offset: 0x00953708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortEquipmentListByType(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<EquipmentBagItem> list;
			LuaObject.checkType<List<EquipmentBagItem>>(l, 2, out list);
			equipmentForgeUIController.m_luaExportHelper.SortEquipmentListByType(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D78C RID: 120716 RVA: 0x00955564 File Offset: 0x00953764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DefaultEquipmentItemComparer(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentBagItem e;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out e);
			EquipmentBagItem e2;
			LuaObject.checkType<EquipmentBagItem>(l, 3, out e2);
			int i = equipmentForgeUIController.m_luaExportHelper.DefaultEquipmentItemComparer(e, e2);
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

	// Token: 0x0601D78D RID: 120717 RVA: 0x009555D8 File Offset: 0x009537D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectEquipmentPropValueAndSort(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<EquipmentBagItem> list;
			LuaObject.checkType<List<EquipmentBagItem>>(l, 2, out list);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 3, out type);
			equipmentForgeUIController.m_luaExportHelper.CollectEquipmentPropValueAndSort(list, type);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D78E RID: 120718 RVA: 0x00955644 File Offset: 0x00953844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentListItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentListItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D78F RID: 120719 RVA: 0x009556A0 File Offset: 0x009538A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentItemClickInEnhance(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentDepotListItemUIController ctrl;
			LuaObject.checkType<EquipmentDepotListItemUIController>(l, 2, out ctrl);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentItemClickInEnhance(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D790 RID: 120720 RVA: 0x009556FC File Offset: 0x009538FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentItemClickInBreak(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentDepotListItemUIController ctrl;
			LuaObject.checkType<EquipmentDepotListItemUIController>(l, 2, out ctrl);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentItemClickInBreak(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D791 RID: 120721 RVA: 0x00955758 File Offset: 0x00953958
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentItemClickInEnchantment(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentDepotListItemUIController ctrl;
			LuaObject.checkType<EquipmentDepotListItemUIController>(l, 2, out ctrl);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentItemClickInEnchantment(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D792 RID: 120722 RVA: 0x009557B4 File Offset: 0x009539B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentListItemNeedFill(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentListItemNeedFill(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D793 RID: 120723 RVA: 0x00955810 File Offset: 0x00953A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentListItem3DTouch(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentListItem3DTouch(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D794 RID: 120724 RVA: 0x0095586C File Offset: 0x00953A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFilterSortButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnFilterSortButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D795 RID: 120725 RVA: 0x009558C0 File Offset: 0x00953AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantmentFilterSortButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentFilterSortButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D796 RID: 120726 RVA: 0x00955914 File Offset: 0x00953B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseFilterSortTypeGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnCloseFilterSortTypeGo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D797 RID: 120727 RVA: 0x00955968 File Offset: 0x00953B68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCloseEnchantmentFilterSortTypeGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnCloseEnchantmentFilterSortTypeGo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D798 RID: 120728 RVA: 0x009559BC File Offset: 0x00953BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFilterSortOrderButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnFilterSortOrderButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D799 RID: 120729 RVA: 0x00955A10 File Offset: 0x00953C10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFilterTypeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentSortItemUIController ctrl;
			LuaObject.checkType<EquipmentSortItemUIController>(l, 2, out ctrl);
			bool isOn;
			LuaObject.checkType(l, 3, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnFilterTypeButtonClick(ctrl, isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D79A RID: 120730 RVA: 0x00955A7C File Offset: 0x00953C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantmentFilterTypeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentSortItemUIController ctrl;
			LuaObject.checkType<EquipmentSortItemUIController>(l, 2, out ctrl);
			bool isOn;
			LuaObject.checkType(l, 3, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentFilterTypeButtonClick(ctrl, isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D79B RID: 120731 RVA: 0x00955AE8 File Offset: 0x00953CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEquipmentItemDesc(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentItemDesc;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentItemDesc);
			equipmentForgeUIController.m_luaExportHelper.SetEquipmentItemDesc(equipmentItemDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D79C RID: 120732 RVA: 0x00955B44 File Offset: 0x00953D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPropItemColor(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text oldText;
			LuaObject.checkType<Text>(l, 2, out oldText);
			Text newText;
			LuaObject.checkType<Text>(l, 3, out newText);
			equipmentForgeUIController.m_luaExportHelper.SetPropItemColor(oldText, newText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D79D RID: 120733 RVA: 0x00955BB0 File Offset: 0x00953DB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPropItems(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			int addValue;
			LuaObject.checkType(l, 4, out addValue);
			int level;
			LuaObject.checkType(l, 5, out level);
			equipmentForgeUIController.m_luaExportHelper.SetPropItems(type, value, addValue, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D79E RID: 120734 RVA: 0x00955C34 File Offset: 0x00953E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateViewInEnhanceState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.UpdateViewInEnhanceState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D79F RID: 120735 RVA: 0x00955C88 File Offset: 0x00953E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnhancePropItems(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int originValue;
			LuaObject.checkType(l, 3, out originValue);
			int perAddValue;
			LuaObject.checkType(l, 4, out perAddValue);
			int curLv;
			LuaObject.checkType(l, 5, out curLv);
			int addLv;
			LuaObject.checkType(l, 6, out addLv);
			equipmentForgeUIController.m_luaExportHelper.SetEnhancePropItems(type, originValue, perAddValue, curLv, addLv);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A0 RID: 120736 RVA: 0x00955D18 File Offset: 0x00953F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetEnhancePropItemActive(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.ResetEnhancePropItemActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A1 RID: 120737 RVA: 0x00955D6C File Offset: 0x00953F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateEquipmentEnhanceAddLvByExp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int enhanceExp;
			LuaObject.checkType(l, 3, out enhanceExp);
			int curLv;
			LuaObject.checkType(l, 4, out curLv);
			int i = equipmentForgeUIController.m_luaExportHelper.CalculateEquipmentEnhanceAddLvByExp(equipment, enhanceExp, curLv);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A2 RID: 120738 RVA: 0x00955DF0 File Offset: 0x00953FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnhanceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A3 RID: 120739 RVA: 0x00955E44 File Offset: 0x00954044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendEnhanceEquipmentMsg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.SendEnhanceEquipmentMsg();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A4 RID: 120740 RVA: 0x00955E98 File Offset: 0x00954098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnhanceSucceed(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string oldSkillLevelStr;
			LuaObject.checkType(l, 2, out oldSkillLevelStr);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceSucceed(oldSkillLevelStr);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A5 RID: 120741 RVA: 0x00955EF4 File Offset: 0x009540F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopEnhanceSucceedEffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.StopEnhanceSucceedEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A6 RID: 120742 RVA: 0x00955F48 File Offset: 0x00954148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillLevelUpEffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			string oldLv;
			LuaObject.checkType(l, 3, out oldLv);
			string newLv;
			LuaObject.checkType(l, 4, out newLv);
			int newSkillId;
			LuaObject.checkType(l, 5, out newSkillId);
			equipmentForgeUIController.m_luaExportHelper.SetSkillLevelUpEffect(equipment, oldLv, newLv, newSkillId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A7 RID: 120743 RVA: 0x00955FCC File Offset: 0x009541CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayActiveIntensifyContinueButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			IEnumerator o = equipmentForgeUIController.m_luaExportHelper.DelayActiveIntensifyContinueButton();
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

	// Token: 0x0601D7A8 RID: 120744 RVA: 0x00956028 File Offset: 0x00954228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnIntensifySuccessPanelBlackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnIntensifySuccessPanelBlackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7A9 RID: 120745 RVA: 0x0095607C File Offset: 0x0095427C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowEnhanceItemSRConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.ShowEnhanceItemSRConfirmPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7AA RID: 120746 RVA: 0x009560D0 File Offset: 0x009542D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnhanceItemsConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.ShowEnhanceItemsConfirmPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7AB RID: 120747 RVA: 0x00956124 File Offset: 0x00954324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnhanceItemSRConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceItemSRConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7AC RID: 120748 RVA: 0x00956178 File Offset: 0x00954378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnhanceItemSRCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceItemSRCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7AD RID: 120749 RVA: 0x009561CC File Offset: 0x009543CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnhanceConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7AE RID: 120750 RVA: 0x00956220 File Offset: 0x00954420
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnhanceCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7AF RID: 120751 RVA: 0x00956274 File Offset: 0x00954474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEquipmentAddExpAtMaxLevelMaxExp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int addLv;
			LuaObject.checkType(l, 3, out addLv);
			int addExp;
			LuaObject.checkType(l, 4, out addExp);
			bool b = equipmentForgeUIController.m_luaExportHelper.IsEquipmentAddExpAtMaxLevelMaxExp(equipment, addLv, addExp);
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

	// Token: 0x0601D7B0 RID: 120752 RVA: 0x009562F8 File Offset: 0x009544F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInBreakState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.UpdateViewInBreakState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B1 RID: 120753 RVA: 0x0095634C File Offset: 0x0095454C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBreakButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnBreakButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B2 RID: 120754 RVA: 0x009563A0 File Offset: 0x009545A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBreakSucceed(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnBreakSucceed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B3 RID: 120755 RVA: 0x009563F4 File Offset: 0x009545F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayActiveBreakContinueButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			IEnumerator o = equipmentForgeUIController.m_luaExportHelper.DelayActiveBreakContinueButton();
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

	// Token: 0x0601D7B4 RID: 120756 RVA: 0x00956450 File Offset: 0x00954650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBreakSuccessPanelContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnBreakSuccessPanelContinueButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B5 RID: 120757 RVA: 0x009564A4 File Offset: 0x009546A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentBreakNeedItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			equipmentForgeUIController.m_luaExportHelper.OnEquipmentBreakNeedItemClick(type, id, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B6 RID: 120758 RVA: 0x0095651C File Offset: 0x0095471C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInEnchantmentState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.UpdateViewInEnchantmentState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B7 RID: 120759 RVA: 0x00956570 File Offset: 0x00954770
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnchantmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B8 RID: 120760 RVA: 0x009565C4 File Offset: 0x009547C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowEnchantmentResultPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			int newResonanceId;
			LuaObject.checkType(l, 2, out newResonanceId);
			List<CommonBattleProperty> properties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 3, out properties);
			bool isFirstShow;
			LuaObject.checkType(l, 4, out isFirstShow);
			equipmentForgeUIController.m_luaExportHelper.ShowEnchantmentResultPanel(newResonanceId, properties, isFirstShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7B9 RID: 120761 RVA: 0x0095663C File Offset: 0x0095483C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEnchantmentResultPanelInfo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			int newResonanceId;
			LuaObject.checkType(l, 2, out newResonanceId);
			List<CommonBattleProperty> properties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 3, out properties);
			equipmentForgeUIController.m_luaExportHelper.SetEnchantmentResultPanelInfo(newResonanceId, properties);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7BA RID: 120762 RVA: 0x009566A8 File Offset: 0x009548A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_PlayNewPropertyEffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<CommonBattleProperty> properties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 2, out properties);
			IEnumerator o = equipmentForgeUIController.m_luaExportHelper.Co_PlayNewPropertyEffect(properties);
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

	// Token: 0x0601D7BB RID: 120763 RVA: 0x00956710 File Offset: 0x00954910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_DynamicSetPropertyValue(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text valueText;
			LuaObject.checkType<Text>(l, 2, out valueText);
			Image progressBar;
			LuaObject.checkType<Image>(l, 3, out progressBar);
			int value;
			LuaObject.checkType(l, 4, out value);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 5, out type);
			IEnumerator o = equipmentForgeUIController.m_luaExportHelper.Co_DynamicSetPropertyValue(valueText, progressBar, value, type);
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

	// Token: 0x0601D7BC RID: 120764 RVA: 0x009567A0 File Offset: 0x009549A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcPropertyPercent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			PropertyModifyType propertyTypeId;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out propertyTypeId);
			int value;
			LuaObject.checkType(l, 3, out value);
			float o = equipmentForgeUIController.m_luaExportHelper.CalcPropertyPercent(propertyTypeId, value);
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

	// Token: 0x0601D7BD RID: 120765 RVA: 0x00956814 File Offset: 0x00954A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantmentResultPanelContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentResultPanelContinueButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7BE RID: 120766 RVA: 0x00956868 File Offset: 0x00954A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseEnchantmentResultPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action succeedEffectEvent;
			LuaObject.checkDelegate<Action>(l, 2, out succeedEffectEvent);
			equipmentForgeUIController.m_luaExportHelper.CloseEnchantmentResultPanel(succeedEffectEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7BF RID: 120767 RVA: 0x009568C4 File Offset: 0x00954AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantmentResultSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentResultSaveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C0 RID: 120768 RVA: 0x00956918 File Offset: 0x00954B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantmentAgainButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentAgainButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C1 RID: 120769 RVA: 0x0095696C File Offset: 0x00954B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSavePanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.ShowSavePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C2 RID: 120770 RVA: 0x009569C0 File Offset: 0x00954BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSavePanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.CloseSavePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C3 RID: 120771 RVA: 0x00956A14 File Offset: 0x00954C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSavePanlConfirmClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnSavePanlConfirmClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C4 RID: 120772 RVA: 0x00956A68 File Offset: 0x00954C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySucceedEffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.PlaySucceedEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C5 RID: 120773 RVA: 0x00956ABC File Offset: 0x00954CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseEnchantResultPanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnCloseEnchantResultPanelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C6 RID: 120774 RVA: 0x00956B10 File Offset: 0x00954D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowCancelPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.ShowCancelPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C7 RID: 120775 RVA: 0x00956B64 File Offset: 0x00954D64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloseCancelPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.CloseCancelPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C8 RID: 120776 RVA: 0x00956BB8 File Offset: 0x00954DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelPanlConfirmClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnCancelPanlConfirmClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7C9 RID: 120777 RVA: 0x00956C0C File Offset: 0x00954E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSavePropertyToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnSavePropertyToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7CA RID: 120778 RVA: 0x00956C68 File Offset: 0x00954E68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCancelPanelToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnCancelPanelToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7CB RID: 120779 RVA: 0x00956CC4 File Offset: 0x00954EC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnhanceToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnEnhanceToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7CC RID: 120780 RVA: 0x00956D20 File Offset: 0x00954F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBreakToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnBreakToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7CD RID: 120781 RVA: 0x00956D7C File Offset: 0x00954F7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnchantmentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantmentToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7CE RID: 120782 RVA: 0x00956DD8 File Offset: 0x00954FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnchantLockMaskButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnEnchantLockMaskButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7CF RID: 120783 RVA: 0x00956E2C File Offset: 0x0095502C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D0 RID: 120784 RVA: 0x00956E80 File Offset: 0x00955080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D1 RID: 120785 RVA: 0x00956ED4 File Offset: 0x009550D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D2 RID: 120786 RVA: 0x00956F28 File Offset: 0x00955128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			equipmentForgeUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D3 RID: 120787 RVA: 0x00956F94 File Offset: 0x00955194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D4 RID: 120788 RVA: 0x00956FE8 File Offset: 0x009551E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D5 RID: 120789 RVA: 0x0095703C File Offset: 0x0095523C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = equipmentForgeUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D7D6 RID: 120790 RVA: 0x009570E4 File Offset: 0x009552E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D7 RID: 120791 RVA: 0x00957138 File Offset: 0x00955338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			equipmentForgeUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7D8 RID: 120792 RVA: 0x009571A4 File Offset: 0x009553A4
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
				EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				equipmentForgeUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EquipmentForgeUIController equipmentForgeUIController2 = (EquipmentForgeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				equipmentForgeUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D7D9 RID: 120793 RVA: 0x009572B4 File Offset: 0x009554B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentForgeUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7DA RID: 120794 RVA: 0x00957320 File Offset: 0x00955520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentForgeUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7DB RID: 120795 RVA: 0x0095738C File Offset: 0x0095558C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentForgeUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7DC RID: 120796 RVA: 0x009573F8 File Offset: 0x009555F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentForgeUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7DD RID: 120797 RVA: 0x00957464 File Offset: 0x00955664
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
				EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				equipmentForgeUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EquipmentForgeUIController equipmentForgeUIController2 = (EquipmentForgeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				equipmentForgeUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D7DE RID: 120798 RVA: 0x00957574 File Offset: 0x00955774
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string s = equipmentForgeUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D7DF RID: 120799 RVA: 0x009575D0 File Offset: 0x009557D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E0 RID: 120800 RVA: 0x00957624 File Offset: 0x00955824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E1 RID: 120801 RVA: 0x00957678 File Offset: 0x00955878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E2 RID: 120802 RVA: 0x009576CC File Offset: 0x009558CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E3 RID: 120803 RVA: 0x00957720 File Offset: 0x00955920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			EquipmentForgeUIController.ForgeState arg3;
			LuaObject.checkEnum<EquipmentForgeUIController.ForgeState>(l, 4, out arg3);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnGoldAddButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E4 RID: 120804 RVA: 0x00957798 File Offset: 0x00955998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			EquipmentForgeUIController.ForgeState arg3;
			LuaObject.checkEnum<EquipmentForgeUIController.ForgeState>(l, 4, out arg3);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnGoldAddButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E5 RID: 120805 RVA: 0x00957810 File Offset: 0x00955A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnEnhanceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			List<ulong> arg2;
			LuaObject.checkType<List<ulong>>(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnEnhanceButtonClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E6 RID: 120806 RVA: 0x00957894 File Offset: 0x00955A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnEnhanceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			List<ulong> arg2;
			LuaObject.checkType<List<ulong>>(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnEnhanceButtonClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E7 RID: 120807 RVA: 0x00957918 File Offset: 0x00955B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnBreakButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnBreakButtonClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E8 RID: 120808 RVA: 0x0095799C File Offset: 0x00955B9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnBreakButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnBreakButtonClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7E9 RID: 120809 RVA: 0x00957A20 File Offset: 0x00955C20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnEnchantButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action<int, List<CommonBattleProperty>> arg3;
			LuaObject.checkDelegate<Action<int, List<CommonBattleProperty>>>(l, 4, out arg3);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnEnchantButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7EA RID: 120810 RVA: 0x00957A98 File Offset: 0x00955C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnEnchantButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action<int, List<CommonBattleProperty>> arg3;
			LuaObject.checkDelegate<Action<int, List<CommonBattleProperty>>>(l, 4, out arg3);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnEnchantButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7EB RID: 120811 RVA: 0x00957B10 File Offset: 0x00955D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnBreakNeedItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnBreakNeedItemClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7EC RID: 120812 RVA: 0x00957B88 File Offset: 0x00955D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnBreakNeedItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnBreakNeedItemClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7ED RID: 120813 RVA: 0x00957C00 File Offset: 0x00955E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEnchantSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnEnchantSaveButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7EE RID: 120814 RVA: 0x00957C5C File Offset: 0x00955E5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnEnchantSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnEnchantSaveButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7EF RID: 120815 RVA: 0x00957CB8 File Offset: 0x00955EB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__callDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7F0 RID: 120816 RVA: 0x00957D0C File Offset: 0x00955F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			equipmentForgeUIController.m_luaExportHelper.__clearDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7F1 RID: 120817 RVA: 0x00957D60 File Offset: 0x00955F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnReturn -= value;
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

	// Token: 0x0601D7F2 RID: 120818 RVA: 0x00957DE0 File Offset: 0x00955FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601D7F3 RID: 120819 RVA: 0x00957E60 File Offset: 0x00956060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action<ulong, int, EquipmentForgeUIController.ForgeState> value;
			int num = LuaObject.checkDelegate<Action<ulong, int, EquipmentForgeUIController.ForgeState>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnGoldAddButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnGoldAddButtonClick -= value;
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

	// Token: 0x0601D7F4 RID: 120820 RVA: 0x00957EE0 File Offset: 0x009560E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEnhanceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action<ulong, List<ulong>, Action, int> value;
			int num = LuaObject.checkDelegate<Action<ulong, List<ulong>, Action, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnEnhanceButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnEnhanceButtonClick -= value;
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

	// Token: 0x0601D7F5 RID: 120821 RVA: 0x00957F60 File Offset: 0x00956160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBreakButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action<ulong, ulong, Action, int> value;
			int num = LuaObject.checkDelegate<Action<ulong, ulong, Action, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnBreakButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnBreakButtonClick -= value;
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

	// Token: 0x0601D7F6 RID: 120822 RVA: 0x00957FE0 File Offset: 0x009561E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEnchantButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> value;
			int num = LuaObject.checkDelegate<Action<ulong, ulong, Action<int, List<CommonBattleProperty>>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnEnchantButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnEnchantButtonClick -= value;
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

	// Token: 0x0601D7F7 RID: 120823 RVA: 0x00958060 File Offset: 0x00956260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBreakNeedItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnBreakNeedItemClick += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnBreakNeedItemClick -= value;
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

	// Token: 0x0601D7F8 RID: 120824 RVA: 0x009580E0 File Offset: 0x009562E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEnchantSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action<Action> value;
			int num = LuaObject.checkDelegate<Action<Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnEnchantSaveButtonClick += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnEnchantSaveButtonClick -= value;
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

	// Token: 0x0601D7F9 RID: 120825 RVA: 0x00958160 File Offset: 0x00956360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentForgeUIController.EventOnCrystalNotEnough += value;
				}
				else if (num == 2)
				{
					equipmentForgeUIController.EventOnCrystalNotEnough -= value;
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

	// Token: 0x0601D7FA RID: 120826 RVA: 0x009581E0 File Offset: 0x009563E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7FB RID: 120827 RVA: 0x00958238 File Offset: 0x00956438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			equipmentForgeUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7FC RID: 120828 RVA: 0x00958294 File Offset: 0x00956494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7FD RID: 120829 RVA: 0x009582EC File Offset: 0x009564EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			equipmentForgeUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7FE RID: 120830 RVA: 0x00958348 File Offset: 0x00956548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D7FF RID: 120831 RVA: 0x009583A0 File Offset: 0x009565A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			equipmentForgeUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D800 RID: 120832 RVA: 0x009583FC File Offset: 0x009565FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D801 RID: 120833 RVA: 0x00958454 File Offset: 0x00956654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Toggle enhanceToggle;
			LuaObject.checkType<Toggle>(l, 2, out enhanceToggle);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceToggle = enhanceToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D802 RID: 120834 RVA: 0x009584B0 File Offset: 0x009566B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D803 RID: 120835 RVA: 0x00958508 File Offset: 0x00956708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Toggle breakToggle;
			LuaObject.checkType<Toggle>(l, 2, out breakToggle);
			equipmentForgeUIController.m_luaExportHelper.m_breakToggle = breakToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D804 RID: 120836 RVA: 0x00958564 File Offset: 0x00956764
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D805 RID: 120837 RVA: 0x009585BC File Offset: 0x009567BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Toggle enchantmentToggle;
			LuaObject.checkType<Toggle>(l, 2, out enchantmentToggle);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentToggle = enchantmentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D806 RID: 120838 RVA: 0x00958618 File Offset: 0x00956818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantLockMaskButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantLockMaskButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D807 RID: 120839 RVA: 0x00958670 File Offset: 0x00956870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantLockMaskButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantLockMaskButton;
			LuaObject.checkType<Button>(l, 2, out enchantLockMaskButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantLockMaskButton = enchantLockMaskButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D808 RID: 120840 RVA: 0x009586CC File Offset: 0x009568CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D809 RID: 120841 RVA: 0x00958724 File Offset: 0x00956924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			equipmentForgeUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D80A RID: 120842 RVA: 0x00958780 File Offset: 0x00956980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldAddButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_goldAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D80B RID: 120843 RVA: 0x009587D8 File Offset: 0x009569D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldAddButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button goldAddButton;
			LuaObject.checkType<Button>(l, 2, out goldAddButton);
			equipmentForgeUIController.m_luaExportHelper.m_goldAddButton = goldAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D80C RID: 120844 RVA: 0x00958834 File Offset: 0x00956A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_loopScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D80D RID: 120845 RVA: 0x0095888C File Offset: 0x00956A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LoopVerticalScrollRect loopScrollView;
			LuaObject.checkType<LoopVerticalScrollRect>(l, 2, out loopScrollView);
			equipmentForgeUIController.m_luaExportHelper.m_loopScrollView = loopScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D80E RID: 120846 RVA: 0x009588E8 File Offset: 0x00956AE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_listItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D80F RID: 120847 RVA: 0x00958940 File Offset: 0x00956B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EasyObjectPool listItemPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out listItemPool);
			equipmentForgeUIController.m_luaExportHelper.m_listItemPool = listItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D810 RID: 120848 RVA: 0x0095899C File Offset: 0x00956B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listScrollViewItemRoot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_listScrollViewItemRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D811 RID: 120849 RVA: 0x009589F4 File Offset: 0x00956BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listScrollViewItemRoot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject listScrollViewItemRoot;
			LuaObject.checkType<GameObject>(l, 2, out listScrollViewItemRoot);
			equipmentForgeUIController.m_luaExportHelper.m_listScrollViewItemRoot = listScrollViewItemRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D812 RID: 120850 RVA: 0x00958A50 File Offset: 0x00956C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentFilter(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentFilter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D813 RID: 120851 RVA: 0x00958AA8 File Offset: 0x00956CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentFilter(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentFilter;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentFilter);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentFilter = enchantmentFilter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D814 RID: 120852 RVA: 0x00958B04 File Offset: 0x00956D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentfilterSortButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D815 RID: 120853 RVA: 0x00958B5C File Offset: 0x00956D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentfilterSortButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantmentfilterSortButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentfilterSortButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortButton = enchantmentfilterSortButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D816 RID: 120854 RVA: 0x00958BB8 File Offset: 0x00956DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentfilterSortTypeText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D817 RID: 120855 RVA: 0x00958C10 File Offset: 0x00956E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentfilterSortTypeText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentfilterSortTypeText;
			LuaObject.checkType<Text>(l, 2, out enchantmentfilterSortTypeText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypeText = enchantmentfilterSortTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D818 RID: 120856 RVA: 0x00958C6C File Offset: 0x00956E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentfilterSortTypesGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypesGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D819 RID: 120857 RVA: 0x00958CC4 File Offset: 0x00956EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentfilterSortTypesGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentfilterSortTypesGo;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentfilterSortTypesGo);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypesGo = enchantmentfilterSortTypesGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D81A RID: 120858 RVA: 0x00958D20 File Offset: 0x00956F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentfilterSortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypesGridLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D81B RID: 120859 RVA: 0x00958D78 File Offset: 0x00956F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentfilterSortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentfilterSortTypesGridLayout;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentfilterSortTypesGridLayout);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypesGridLayout = enchantmentfilterSortTypesGridLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D81C RID: 120860 RVA: 0x00958DD4 File Offset: 0x00956FD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentfilterSortTypesAllToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypesAllToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D81D RID: 120861 RVA: 0x00958E2C File Offset: 0x0095702C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentfilterSortTypesAllToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentfilterSortTypesAllToggle;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentfilterSortTypesAllToggle);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentfilterSortTypesAllToggle = enchantmentfilterSortTypesAllToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D81E RID: 120862 RVA: 0x00958E88 File Offset: 0x00957088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceAndBreakFilter(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceAndBreakFilter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D81F RID: 120863 RVA: 0x00958EE0 File Offset: 0x009570E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceAndBreakFilter(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceAndBreakFilter;
			LuaObject.checkType<GameObject>(l, 2, out enhanceAndBreakFilter);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceAndBreakFilter = enhanceAndBreakFilter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D820 RID: 120864 RVA: 0x00958F3C File Offset: 0x0095713C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_filterSortButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D821 RID: 120865 RVA: 0x00958F94 File Offset: 0x00957194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button filterSortButton;
			LuaObject.checkType<Button>(l, 2, out filterSortButton);
			equipmentForgeUIController.m_luaExportHelper.m_filterSortButton = filterSortButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D822 RID: 120866 RVA: 0x00958FF0 File Offset: 0x009571F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortTypeText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_filterSortTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D823 RID: 120867 RVA: 0x00959048 File Offset: 0x00957248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortTypeText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text filterSortTypeText;
			LuaObject.checkType<Text>(l, 2, out filterSortTypeText);
			equipmentForgeUIController.m_luaExportHelper.m_filterSortTypeText = filterSortTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D824 RID: 120868 RVA: 0x009590A4 File Offset: 0x009572A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortOrderButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_filterSortOrderButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D825 RID: 120869 RVA: 0x009590FC File Offset: 0x009572FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortOrderButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button filterSortOrderButton;
			LuaObject.checkType<Button>(l, 2, out filterSortOrderButton);
			equipmentForgeUIController.m_luaExportHelper.m_filterSortOrderButton = filterSortOrderButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D826 RID: 120870 RVA: 0x00959158 File Offset: 0x00957358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortTypesGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_filterSortTypesGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D827 RID: 120871 RVA: 0x009591B0 File Offset: 0x009573B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortTypesGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject filterSortTypesGo;
			LuaObject.checkType<GameObject>(l, 2, out filterSortTypesGo);
			equipmentForgeUIController.m_luaExportHelper.m_filterSortTypesGo = filterSortTypesGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D828 RID: 120872 RVA: 0x0095920C File Offset: 0x0095740C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterSortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_filterSortTypesGridLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D829 RID: 120873 RVA: 0x00959264 File Offset: 0x00957464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterSortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject filterSortTypesGridLayout;
			LuaObject.checkType<GameObject>(l, 2, out filterSortTypesGridLayout);
			equipmentForgeUIController.m_luaExportHelper.m_filterSortTypesGridLayout = filterSortTypesGridLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D82A RID: 120874 RVA: 0x009592C0 File Offset: 0x009574C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listNoBreakItemGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_listNoBreakItemGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D82B RID: 120875 RVA: 0x00959318 File Offset: 0x00957518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listNoBreakItemGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject listNoBreakItemGo;
			LuaObject.checkType<GameObject>(l, 2, out listNoBreakItemGo);
			equipmentForgeUIController.m_luaExportHelper.m_listNoBreakItemGo = listNoBreakItemGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D82C RID: 120876 RVA: 0x00959374 File Offset: 0x00957574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listNoEnchantmentItemGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_listNoEnchantmentItemGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D82D RID: 120877 RVA: 0x009593CC File Offset: 0x009575CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listNoEnchantmentItemGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject listNoEnchantmentItemGo;
			LuaObject.checkType<GameObject>(l, 2, out listNoEnchantmentItemGo);
			equipmentForgeUIController.m_luaExportHelper.m_listNoEnchantmentItemGo = listNoEnchantmentItemGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D82E RID: 120878 RVA: 0x00959428 File Offset: 0x00957628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listTitleStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_listTitleStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D82F RID: 120879 RVA: 0x00959480 File Offset: 0x00957680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_listTitleStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController listTitleStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out listTitleStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_listTitleStateCtrl = listTitleStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D830 RID: 120880 RVA: 0x009594DC File Offset: 0x009576DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_listLongPressTipGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_listLongPressTipGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D831 RID: 120881 RVA: 0x00959534 File Offset: 0x00957734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listLongPressTipGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject listLongPressTipGo;
			LuaObject.checkType<GameObject>(l, 2, out listLongPressTipGo);
			equipmentForgeUIController.m_luaExportHelper.m_listLongPressTipGo = listLongPressTipGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D832 RID: 120882 RVA: 0x00959590 File Offset: 0x00957790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D833 RID: 120883 RVA: 0x009595E8 File Offset: 0x009577E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descGo;
			LuaObject.checkType<GameObject>(l, 2, out descGo);
			equipmentForgeUIController.m_luaExportHelper.m_descGo = descGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D834 RID: 120884 RVA: 0x00959644 File Offset: 0x00957844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D835 RID: 120885 RVA: 0x0095969C File Offset: 0x0095789C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descTitleText;
			LuaObject.checkType<Text>(l, 2, out descTitleText);
			equipmentForgeUIController.m_luaExportHelper.m_descTitleText = descTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D836 RID: 120886 RVA: 0x009596F8 File Offset: 0x009578F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D837 RID: 120887 RVA: 0x00959750 File Offset: 0x00957950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image descIcon;
			LuaObject.checkType<Image>(l, 2, out descIcon);
			equipmentForgeUIController.m_luaExportHelper.m_descIcon = descIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D838 RID: 120888 RVA: 0x009597AC File Offset: 0x009579AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D839 RID: 120889 RVA: 0x00959804 File Offset: 0x00957A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image descIconBg;
			LuaObject.checkType<Image>(l, 2, out descIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_descIconBg = descIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D83A RID: 120890 RVA: 0x00959860 File Offset: 0x00957A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D83B RID: 120891 RVA: 0x009598B8 File Offset: 0x00957AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out descSSREffect);
			equipmentForgeUIController.m_luaExportHelper.m_descSSREffect = descSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D83C RID: 120892 RVA: 0x00959914 File Offset: 0x00957B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D83D RID: 120893 RVA: 0x0095996C File Offset: 0x00957B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out descStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_descStarGroup = descStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D83E RID: 120894 RVA: 0x009599C8 File Offset: 0x00957BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D83F RID: 120895 RVA: 0x00959A20 File Offset: 0x00957C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descLvText;
			LuaObject.checkType<Text>(l, 2, out descLvText);
			equipmentForgeUIController.m_luaExportHelper.m_descLvText = descLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D840 RID: 120896 RVA: 0x00959A7C File Offset: 0x00957C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descExpText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D841 RID: 120897 RVA: 0x00959AD4 File Offset: 0x00957CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descExpText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descExpText;
			LuaObject.checkType<Text>(l, 2, out descExpText);
			equipmentForgeUIController.m_luaExportHelper.m_descExpText = descExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D842 RID: 120898 RVA: 0x00959B30 File Offset: 0x00957D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descProgressImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descProgressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D843 RID: 120899 RVA: 0x00959B88 File Offset: 0x00957D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descProgressImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image descProgressImage;
			LuaObject.checkType<Image>(l, 2, out descProgressImage);
			equipmentForgeUIController.m_luaExportHelper.m_descProgressImage = descProgressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D844 RID: 120900 RVA: 0x00959BE4 File Offset: 0x00957DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descEquipLimitContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D845 RID: 120901 RVA: 0x00959C3C File Offset: 0x00957E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descEquipLimitContent;
			LuaObject.checkType<GameObject>(l, 2, out descEquipLimitContent);
			equipmentForgeUIController.m_luaExportHelper.m_descEquipLimitContent = descEquipLimitContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D846 RID: 120902 RVA: 0x00959C98 File Offset: 0x00957E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descEquipUnlimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D847 RID: 120903 RVA: 0x00959CF0 File Offset: 0x00957EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descEquipUnlimitText;
			LuaObject.checkType<Text>(l, 2, out descEquipUnlimitText);
			equipmentForgeUIController.m_luaExportHelper.m_descEquipUnlimitText = descEquipUnlimitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D848 RID: 120904 RVA: 0x00959D4C File Offset: 0x00957F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D849 RID: 120905 RVA: 0x00959DA4 File Offset: 0x00957FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descSkillContent;
			LuaObject.checkType<GameObject>(l, 2, out descSkillContent);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillContent = descSkillContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D84A RID: 120906 RVA: 0x00959E00 File Offset: 0x00958000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillContentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D84B RID: 120907 RVA: 0x00959E58 File Offset: 0x00958058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController descSkillContentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descSkillContentStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillContentStateCtrl = descSkillContentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D84C RID: 120908 RVA: 0x00959EB4 File Offset: 0x009580B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descUnlockCoditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D84D RID: 120909 RVA: 0x00959F0C File Offset: 0x0095810C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descUnlockCoditionText;
			LuaObject.checkType<Text>(l, 2, out descUnlockCoditionText);
			equipmentForgeUIController.m_luaExportHelper.m_descUnlockCoditionText = descUnlockCoditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D84E RID: 120910 RVA: 0x00959F68 File Offset: 0x00958168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D84F RID: 120911 RVA: 0x00959FC0 File Offset: 0x009581C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descSkillNameText;
			LuaObject.checkType<Text>(l, 2, out descSkillNameText);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillNameText = descSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D850 RID: 120912 RVA: 0x0095A01C File Offset: 0x0095821C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D851 RID: 120913 RVA: 0x0095A074 File Offset: 0x00958274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descSkillLvText;
			LuaObject.checkType<Text>(l, 2, out descSkillLvText);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillLvText = descSkillLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D852 RID: 120914 RVA: 0x0095A0D0 File Offset: 0x009582D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillOwnerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D853 RID: 120915 RVA: 0x0095A128 File Offset: 0x00958328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descSkillOwnerText;
			LuaObject.checkType<Text>(l, 2, out descSkillOwnerText);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillOwnerText = descSkillOwnerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D854 RID: 120916 RVA: 0x0095A184 File Offset: 0x00958384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillOwnerBGImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillOwnerBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D855 RID: 120917 RVA: 0x0095A1DC File Offset: 0x009583DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillOwnerBGImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descSkillOwnerBGImage;
			LuaObject.checkType<GameObject>(l, 2, out descSkillOwnerBGImage);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillOwnerBGImage = descSkillOwnerBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D856 RID: 120918 RVA: 0x0095A238 File Offset: 0x00958438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D857 RID: 120919 RVA: 0x0095A290 File Offset: 0x00958490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descSkillDescText;
			LuaObject.checkType<Text>(l, 2, out descSkillDescText);
			equipmentForgeUIController.m_luaExportHelper.m_descSkillDescText = descSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D858 RID: 120920 RVA: 0x0095A2EC File Offset: 0x009584EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descNotEquipSkillTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D859 RID: 120921 RVA: 0x0095A344 File Offset: 0x00958544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descNotEquipSkillTip;
			LuaObject.checkType<GameObject>(l, 2, out descNotEquipSkillTip);
			equipmentForgeUIController.m_luaExportHelper.m_descNotEquipSkillTip = descNotEquipSkillTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D85A RID: 120922 RVA: 0x0095A3A0 File Offset: 0x009585A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descPropContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D85B RID: 120923 RVA: 0x0095A3F8 File Offset: 0x009585F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descPropContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropContent;
			LuaObject.checkType<GameObject>(l, 2, out descPropContent);
			equipmentForgeUIController.m_luaExportHelper.m_descPropContent = descPropContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D85C RID: 120924 RVA: 0x0095A454 File Offset: 0x00958654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D85D RID: 120925 RVA: 0x0095A4AC File Offset: 0x009586AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropATGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropATGo);
			equipmentForgeUIController.m_luaExportHelper.m_descPropATGo = descPropATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D85E RID: 120926 RVA: 0x0095A508 File Offset: 0x00958708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D85F RID: 120927 RVA: 0x0095A560 File Offset: 0x00958760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropATValueText;
			LuaObject.checkType<Text>(l, 2, out descPropATValueText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropATValueText = descPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D860 RID: 120928 RVA: 0x0095A5BC File Offset: 0x009587BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D861 RID: 120929 RVA: 0x0095A614 File Offset: 0x00958814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropDFGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropDFGo);
			equipmentForgeUIController.m_luaExportHelper.m_descPropDFGo = descPropDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D862 RID: 120930 RVA: 0x0095A670 File Offset: 0x00958870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D863 RID: 120931 RVA: 0x0095A6C8 File Offset: 0x009588C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out descPropDFValueText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropDFValueText = descPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D864 RID: 120932 RVA: 0x0095A724 File Offset: 0x00958924
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropHPGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D865 RID: 120933 RVA: 0x0095A77C File Offset: 0x0095897C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropHPGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropHPGo);
			equipmentForgeUIController.m_luaExportHelper.m_descPropHPGo = descPropHPGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D866 RID: 120934 RVA: 0x0095A7D8 File Offset: 0x009589D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D867 RID: 120935 RVA: 0x0095A830 File Offset: 0x00958A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out descPropHPValueText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropHPValueText = descPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D868 RID: 120936 RVA: 0x0095A88C File Offset: 0x00958A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_descPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropMagiccGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D869 RID: 120937 RVA: 0x0095A8E4 File Offset: 0x00958AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropMagiccGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropMagiccGo);
			equipmentForgeUIController.m_luaExportHelper.m_descPropMagiccGo = descPropMagiccGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D86A RID: 120938 RVA: 0x0095A940 File Offset: 0x00958B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D86B RID: 120939 RVA: 0x0095A998 File Offset: 0x00958B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out descPropMagicValueText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropMagicValueText = descPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D86C RID: 120940 RVA: 0x0095A9F4 File Offset: 0x00958BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D86D RID: 120941 RVA: 0x0095AA4C File Offset: 0x00958C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropMagicDFGo);
			equipmentForgeUIController.m_luaExportHelper.m_descPropMagicDFGo = descPropMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D86E RID: 120942 RVA: 0x0095AAA8 File Offset: 0x00958CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D86F RID: 120943 RVA: 0x0095AB00 File Offset: 0x00958D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out descPropMagicDFValueText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropMagicDFValueText = descPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D870 RID: 120944 RVA: 0x0095AB5C File Offset: 0x00958D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropDexGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D871 RID: 120945 RVA: 0x0095ABB4 File Offset: 0x00958DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropDexGo;
			LuaObject.checkType<GameObject>(l, 2, out descPropDexGo);
			equipmentForgeUIController.m_luaExportHelper.m_descPropDexGo = descPropDexGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D872 RID: 120946 RVA: 0x0095AC10 File Offset: 0x00958E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropDexValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D873 RID: 120947 RVA: 0x0095AC68 File Offset: 0x00958E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropDexValueText;
			LuaObject.checkType<Text>(l, 2, out descPropDexValueText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropDexValueText = descPropDexValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D874 RID: 120948 RVA: 0x0095ACC4 File Offset: 0x00958EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D875 RID: 120949 RVA: 0x0095AD1C File Offset: 0x00958F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController descPropGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descPropGroupStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_descPropGroupStateCtrl = descPropGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D876 RID: 120950 RVA: 0x0095AD78 File Offset: 0x00958F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D877 RID: 120951 RVA: 0x0095ADD0 File Offset: 0x00958FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject descPropEnchantmentGroup;
			LuaObject.checkType<GameObject>(l, 2, out descPropEnchantmentGroup);
			equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroup = descPropEnchantmentGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D878 RID: 120952 RVA: 0x0095AE2C File Offset: 0x0095902C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D879 RID: 120953 RVA: 0x0095AE84 File Offset: 0x00959084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_descPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController descPropEnchantmentGroupRuneStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descPropEnchantmentGroupRuneStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneStateCtrl = descPropEnchantmentGroupRuneStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D87A RID: 120954 RVA: 0x0095AEE0 File Offset: 0x009590E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D87B RID: 120955 RVA: 0x0095AF38 File Offset: 0x00959138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image descPropEnchantmentGroupRuneIconImage;
			LuaObject.checkType<Image>(l, 2, out descPropEnchantmentGroupRuneIconImage);
			equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneIconImage = descPropEnchantmentGroupRuneIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D87C RID: 120956 RVA: 0x0095AF94 File Offset: 0x00959194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D87D RID: 120957 RVA: 0x0095AFEC File Offset: 0x009591EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text descPropEnchantmentGroupRuneNameText;
			LuaObject.checkType<Text>(l, 2, out descPropEnchantmentGroupRuneNameText);
			equipmentForgeUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneNameText = descPropEnchantmentGroupRuneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D87E RID: 120958 RVA: 0x0095B048 File Offset: 0x00959248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D87F RID: 120959 RVA: 0x0095B0A0 File Offset: 0x009592A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceTitleText;
			LuaObject.checkType<Text>(l, 2, out enhanceTitleText);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceTitleText = enhanceTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D880 RID: 120960 RVA: 0x0095B0FC File Offset: 0x009592FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D881 RID: 120961 RVA: 0x0095B154 File Offset: 0x00959354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enhanceIcon;
			LuaObject.checkType<Image>(l, 2, out enhanceIcon);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceIcon = enhanceIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D882 RID: 120962 RVA: 0x0095B1B0 File Offset: 0x009593B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D883 RID: 120963 RVA: 0x0095B208 File Offset: 0x00959408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enhanceIconBg;
			LuaObject.checkType<Image>(l, 2, out enhanceIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceIconBg = enhanceIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D884 RID: 120964 RVA: 0x0095B264 File Offset: 0x00959464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceIconSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D885 RID: 120965 RVA: 0x0095B2BC File Offset: 0x009594BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceIconSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out enhanceIconSSREffect);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceIconSSREffect = enhanceIconSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D886 RID: 120966 RVA: 0x0095B318 File Offset: 0x00959518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D887 RID: 120967 RVA: 0x0095B370 File Offset: 0x00959570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out enhanceStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceStarGroup = enhanceStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D888 RID: 120968 RVA: 0x0095B3CC File Offset: 0x009595CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceCurLv(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceCurLv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D889 RID: 120969 RVA: 0x0095B424 File Offset: 0x00959624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceCurLv(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceCurLv;
			LuaObject.checkType<Text>(l, 2, out enhanceCurLv);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceCurLv = enhanceCurLv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D88A RID: 120970 RVA: 0x0095B480 File Offset: 0x00959680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceCurLv1(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceCurLv1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D88B RID: 120971 RVA: 0x0095B4D8 File Offset: 0x009596D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceCurLv1(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceCurLv;
			LuaObject.checkType<Text>(l, 2, out enhanceCurLv);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceCurLv1 = enhanceCurLv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D88C RID: 120972 RVA: 0x0095B534 File Offset: 0x00959734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceMaxLV(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceMaxLV);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D88D RID: 120973 RVA: 0x0095B58C File Offset: 0x0095978C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhanceMaxLV(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceMaxLV;
			LuaObject.checkType<Text>(l, 2, out enhanceMaxLV);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceMaxLV = enhanceMaxLV;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D88E RID: 120974 RVA: 0x0095B5E8 File Offset: 0x009597E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhanceProgressImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceProgressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D88F RID: 120975 RVA: 0x0095B640 File Offset: 0x00959840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhanceProgressImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enhanceProgressImage;
			LuaObject.checkType<Image>(l, 2, out enhanceProgressImage);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceProgressImage = enhanceProgressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D890 RID: 120976 RVA: 0x0095B69C File Offset: 0x0095989C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceWillGetExpImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceWillGetExpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D891 RID: 120977 RVA: 0x0095B6F4 File Offset: 0x009598F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhanceWillGetExpImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enhanceWillGetExpImage;
			LuaObject.checkType<Image>(l, 2, out enhanceWillGetExpImage);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceWillGetExpImage = enhanceWillGetExpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D892 RID: 120978 RVA: 0x0095B750 File Offset: 0x00959950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhanceExpCurValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceExpCurValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D893 RID: 120979 RVA: 0x0095B7A8 File Offset: 0x009599A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceExpCurValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceExpCurValueText;
			LuaObject.checkType<Text>(l, 2, out enhanceExpCurValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceExpCurValueText = enhanceExpCurValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D894 RID: 120980 RVA: 0x0095B804 File Offset: 0x00959A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceExpAddValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceExpAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D895 RID: 120981 RVA: 0x0095B85C File Offset: 0x00959A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceExpAddValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceExpAddValueText;
			LuaObject.checkType<Text>(l, 2, out enhanceExpAddValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceExpAddValueText = enhanceExpAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D896 RID: 120982 RVA: 0x0095B8B8 File Offset: 0x00959AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceExpNextLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceExpNextLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D897 RID: 120983 RVA: 0x0095B910 File Offset: 0x00959B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhanceExpNextLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceExpNextLvText;
			LuaObject.checkType<Text>(l, 2, out enhanceExpNextLvText);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceExpNextLvText = enhanceExpNextLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D898 RID: 120984 RVA: 0x0095B96C File Offset: 0x00959B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceMaterialsContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceMaterialsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D899 RID: 120985 RVA: 0x0095B9C4 File Offset: 0x00959BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceMaterialsContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceMaterialsContent;
			LuaObject.checkType<GameObject>(l, 2, out enhanceMaterialsContent);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceMaterialsContent = enhanceMaterialsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D89A RID: 120986 RVA: 0x0095BA20 File Offset: 0x00959C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceGoldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceGoldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D89B RID: 120987 RVA: 0x0095BA78 File Offset: 0x00959C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceGoldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceGoldText;
			LuaObject.checkType<Text>(l, 2, out enhanceGoldText);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceGoldText = enhanceGoldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D89C RID: 120988 RVA: 0x0095BAD4 File Offset: 0x00959CD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhanceButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D89D RID: 120989 RVA: 0x0095BB2C File Offset: 0x00959D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceButton;
			LuaObject.checkType<Button>(l, 2, out enhanceButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceButton = enhanceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D89E RID: 120990 RVA: 0x0095BB88 File Offset: 0x00959D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceSuccessEffectPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceSuccessEffectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D89F RID: 120991 RVA: 0x0095BBE0 File Offset: 0x00959DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceSuccessEffectPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceSuccessEffectPanel;
			LuaObject.checkType<GameObject>(l, 2, out enhanceSuccessEffectPanel);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceSuccessEffectPanel = enhanceSuccessEffectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A0 RID: 120992 RVA: 0x0095BC3C File Offset: 0x00959E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceSuccessEffectPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceSuccessEffectPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A1 RID: 120993 RVA: 0x0095BC94 File Offset: 0x00959E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceSuccessEffectPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceSuccessEffectPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out enhanceSuccessEffectPanelCloseButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceSuccessEffectPanelCloseButton = enhanceSuccessEffectPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A2 RID: 120994 RVA: 0x0095BCF0 File Offset: 0x00959EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A3 RID: 120995 RVA: 0x0095BD48 File Offset: 0x00959F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceConfirmPanel;
			LuaObject.checkType<GameObject>(l, 2, out enhanceConfirmPanel);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmPanel = enhanceConfirmPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A4 RID: 120996 RVA: 0x0095BDA4 File Offset: 0x00959FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A5 RID: 120997 RVA: 0x0095BDFC File Offset: 0x00959FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceConfirmButton;
			LuaObject.checkType<Button>(l, 2, out enhanceConfirmButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmButton = enhanceConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A6 RID: 120998 RVA: 0x0095BE58 File Offset: 0x0095A058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A7 RID: 120999 RVA: 0x0095BEB0 File Offset: 0x0095A0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceCancelButton;
			LuaObject.checkType<Button>(l, 2, out enhanceCancelButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceCancelButton = enhanceCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A8 RID: 121000 RVA: 0x0095BF0C File Offset: 0x0095A10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceConfirmPanelTip1(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmPanelTip1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8A9 RID: 121001 RVA: 0x0095BF64 File Offset: 0x0095A164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceConfirmPanelTip1(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceConfirmPanelTip;
			LuaObject.checkType<Text>(l, 2, out enhanceConfirmPanelTip);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmPanelTip1 = enhanceConfirmPanelTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8AA RID: 121002 RVA: 0x0095BFC0 File Offset: 0x0095A1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceConfirmPanelTip2(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmPanelTip2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8AB RID: 121003 RVA: 0x0095C018 File Offset: 0x0095A218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceConfirmPanelTip2(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceConfirmPanelTip;
			LuaObject.checkType<Text>(l, 2, out enhanceConfirmPanelTip);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceConfirmPanelTip2 = enhanceConfirmPanelTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8AC RID: 121004 RVA: 0x0095C074 File Offset: 0x0095A274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceItemSRConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRConfirmPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8AD RID: 121005 RVA: 0x0095C0CC File Offset: 0x0095A2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceItemSRConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhanceItemSRConfirmPanel;
			LuaObject.checkType<GameObject>(l, 2, out enhanceItemSRConfirmPanel);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRConfirmPanel = enhanceItemSRConfirmPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8AE RID: 121006 RVA: 0x0095C128 File Offset: 0x0095A328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhanceItemSRConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8AF RID: 121007 RVA: 0x0095C180 File Offset: 0x0095A380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceItemSRConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceItemSRConfirmButton;
			LuaObject.checkType<Button>(l, 2, out enhanceItemSRConfirmButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRConfirmButton = enhanceItemSRConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B0 RID: 121008 RVA: 0x0095C1DC File Offset: 0x0095A3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceItemSRCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B1 RID: 121009 RVA: 0x0095C234 File Offset: 0x0095A434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceItemSRCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceItemSRCancelButton;
			LuaObject.checkType<Button>(l, 2, out enhanceItemSRCancelButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRCancelButton = enhanceItemSRCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B2 RID: 121010 RVA: 0x0095C290 File Offset: 0x0095A490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceItemSRTip(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B3 RID: 121011 RVA: 0x0095C2E8 File Offset: 0x0095A4E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhanceItemSRTip(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhanceItemSRTip;
			LuaObject.checkType<Text>(l, 2, out enhanceItemSRTip);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceItemSRTip = enhanceItemSRTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B4 RID: 121012 RVA: 0x0095C344 File Offset: 0x0095A544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_intensifySuccessPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B5 RID: 121013 RVA: 0x0095C39C File Offset: 0x0095A59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController intensifySuccessPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out intensifySuccessPanelStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelStateCtrl = intensifySuccessPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B6 RID: 121014 RVA: 0x0095C3F8 File Offset: 0x0095A5F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_intensifySuccessPanelInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B7 RID: 121015 RVA: 0x0095C450 File Offset: 0x0095A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController intensifySuccessPanelInfoStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out intensifySuccessPanelInfoStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoStateCtrl = intensifySuccessPanelInfoStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B8 RID: 121016 RVA: 0x0095C4AC File Offset: 0x0095A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensifySuccessPanelInfoIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8B9 RID: 121017 RVA: 0x0095C504 File Offset: 0x0095A704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelInfoIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image intensifySuccessPanelInfoIconBg;
			LuaObject.checkType<Image>(l, 2, out intensifySuccessPanelInfoIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoIconBg = intensifySuccessPanelInfoIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8BA RID: 121018 RVA: 0x0095C560 File Offset: 0x0095A760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_intensifySuccessPanelInfoIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8BB RID: 121019 RVA: 0x0095C5B8 File Offset: 0x0095A7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelInfoIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image intensifySuccessPanelInfoIcon;
			LuaObject.checkType<Image>(l, 2, out intensifySuccessPanelInfoIcon);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoIcon = intensifySuccessPanelInfoIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8BC RID: 121020 RVA: 0x0095C614 File Offset: 0x0095A814
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_intensifySuccessPanelInfoStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8BD RID: 121021 RVA: 0x0095C66C File Offset: 0x0095A86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_intensifySuccessPanelInfoStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject intensifySuccessPanelInfoStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out intensifySuccessPanelInfoStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelInfoStarGroup = intensifySuccessPanelInfoStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8BE RID: 121022 RVA: 0x0095C6C8 File Offset: 0x0095A8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensifySuccessPanelCurLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelCurLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8BF RID: 121023 RVA: 0x0095C720 File Offset: 0x0095A920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelCurLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text intensifySuccessPanelCurLvText;
			LuaObject.checkType<Text>(l, 2, out intensifySuccessPanelCurLvText);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelCurLvText = intensifySuccessPanelCurLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C0 RID: 121024 RVA: 0x0095C77C File Offset: 0x0095A97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensifySuccessPanelNextLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelNextLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C1 RID: 121025 RVA: 0x0095C7D4 File Offset: 0x0095A9D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_intensifySuccessPanelNextLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text intensifySuccessPanelNextLvText;
			LuaObject.checkType<Text>(l, 2, out intensifySuccessPanelNextLvText);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelNextLvText = intensifySuccessPanelNextLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C2 RID: 121026 RVA: 0x0095C830 File Offset: 0x0095AA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensifySuccessPanelSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C3 RID: 121027 RVA: 0x0095C888 File Offset: 0x0095AA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text intensifySuccessPanelSkillNameText;
			LuaObject.checkType<Text>(l, 2, out intensifySuccessPanelSkillNameText);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelSkillNameText = intensifySuccessPanelSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C4 RID: 121028 RVA: 0x0095C8E4 File Offset: 0x0095AAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensifySuccessPanelSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C5 RID: 121029 RVA: 0x0095C93C File Offset: 0x0095AB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensifySuccessPanelSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text intensifySuccessPanelSkillDescText;
			LuaObject.checkType<Text>(l, 2, out intensifySuccessPanelSkillDescText);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelSkillDescText = intensifySuccessPanelSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C6 RID: 121030 RVA: 0x0095C998 File Offset: 0x0095AB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensifySuccessPanelBlackButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelBlackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C7 RID: 121031 RVA: 0x0095C9F0 File Offset: 0x0095ABF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_intensifySuccessPanelBlackButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button intensifySuccessPanelBlackButton;
			LuaObject.checkType<Button>(l, 2, out intensifySuccessPanelBlackButton);
			equipmentForgeUIController.m_luaExportHelper.m_intensifySuccessPanelBlackButton = intensifySuccessPanelBlackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C8 RID: 121032 RVA: 0x0095CA4C File Offset: 0x0095AC4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropGroupGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropGroupGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8C9 RID: 121033 RVA: 0x0095CAA4 File Offset: 0x0095ACA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropGroupGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropGroupGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropGroupGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropGroupGo = enhancePropGroupGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8CA RID: 121034 RVA: 0x0095CB00 File Offset: 0x0095AD00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropHpGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropHpGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8CB RID: 121035 RVA: 0x0095CB58 File Offset: 0x0095AD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropHpGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropHpGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropHpGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropHpGo = enhancePropHpGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8CC RID: 121036 RVA: 0x0095CBB4 File Offset: 0x0095ADB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropHpOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropHpOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8CD RID: 121037 RVA: 0x0095CC0C File Offset: 0x0095AE0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropHpOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropHpOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropHpOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropHpOldValueText = enhancePropHpOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8CE RID: 121038 RVA: 0x0095CC68 File Offset: 0x0095AE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropHpNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropHpNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8CF RID: 121039 RVA: 0x0095CCC0 File Offset: 0x0095AEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropHpNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropHpNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropHpNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropHpNewValueText = enhancePropHpNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D0 RID: 121040 RVA: 0x0095CD1C File Offset: 0x0095AF1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D1 RID: 121041 RVA: 0x0095CD74 File Offset: 0x0095AF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropATGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropATGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropATGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropATGo = enhancePropATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D2 RID: 121042 RVA: 0x0095CDD0 File Offset: 0x0095AFD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropATOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropATOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D3 RID: 121043 RVA: 0x0095CE28 File Offset: 0x0095B028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropATOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropATOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropATOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropATOldValueText = enhancePropATOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D4 RID: 121044 RVA: 0x0095CE84 File Offset: 0x0095B084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropATNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropATNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D5 RID: 121045 RVA: 0x0095CEDC File Offset: 0x0095B0DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropATNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropATNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropATNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropATNewValueText = enhancePropATNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D6 RID: 121046 RVA: 0x0095CF38 File Offset: 0x0095B138
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D7 RID: 121047 RVA: 0x0095CF90 File Offset: 0x0095B190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropDFGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropDFGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropDFGo = enhancePropDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D8 RID: 121048 RVA: 0x0095CFEC File Offset: 0x0095B1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropDFOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropDFOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8D9 RID: 121049 RVA: 0x0095D044 File Offset: 0x0095B244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropDFOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropDFOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropDFOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropDFOldValueText = enhancePropDFOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8DA RID: 121050 RVA: 0x0095D0A0 File Offset: 0x0095B2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropDFNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropDFNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8DB RID: 121051 RVA: 0x0095D0F8 File Offset: 0x0095B2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropDFNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropDFNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropDFNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropDFNewValueText = enhancePropDFNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8DC RID: 121052 RVA: 0x0095D154 File Offset: 0x0095B354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropMagicGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8DD RID: 121053 RVA: 0x0095D1AC File Offset: 0x0095B3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropMagicGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropMagicGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropMagicGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicGo = enhancePropMagicGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8DE RID: 121054 RVA: 0x0095D208 File Offset: 0x0095B408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropMagicOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8DF RID: 121055 RVA: 0x0095D260 File Offset: 0x0095B460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropMagicOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropMagicOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropMagicOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicOldValueText = enhancePropMagicOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E0 RID: 121056 RVA: 0x0095D2BC File Offset: 0x0095B4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropMagicNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E1 RID: 121057 RVA: 0x0095D314 File Offset: 0x0095B514
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropMagicNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropMagicNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropMagicNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicNewValueText = enhancePropMagicNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E2 RID: 121058 RVA: 0x0095D370 File Offset: 0x0095B570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E3 RID: 121059 RVA: 0x0095D3C8 File Offset: 0x0095B5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropMagicDFGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicDFGo = enhancePropMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E4 RID: 121060 RVA: 0x0095D424 File Offset: 0x0095B624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropMagicDFOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicDFOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E5 RID: 121061 RVA: 0x0095D47C File Offset: 0x0095B67C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropMagicDFOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropMagicDFOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropMagicDFOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicDFOldValueText = enhancePropMagicDFOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E6 RID: 121062 RVA: 0x0095D4D8 File Offset: 0x0095B6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropMagicDFNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicDFNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E7 RID: 121063 RVA: 0x0095D530 File Offset: 0x0095B730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropMagicDFNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropMagicDFNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropMagicDFNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropMagicDFNewValueText = enhancePropMagicDFNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E8 RID: 121064 RVA: 0x0095D58C File Offset: 0x0095B78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropDEXGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropDEXGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8E9 RID: 121065 RVA: 0x0095D5E4 File Offset: 0x0095B7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropDEXGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enhancePropDEXGo;
			LuaObject.checkType<GameObject>(l, 2, out enhancePropDEXGo);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropDEXGo = enhancePropDEXGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8EA RID: 121066 RVA: 0x0095D640 File Offset: 0x0095B840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropDEXOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropDEXOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8EB RID: 121067 RVA: 0x0095D698 File Offset: 0x0095B898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropDEXOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropDEXOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropDEXOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropDEXOldValueText = enhancePropDEXOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8EC RID: 121068 RVA: 0x0095D6F4 File Offset: 0x0095B8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropDEXNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropDEXNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8ED RID: 121069 RVA: 0x0095D74C File Offset: 0x0095B94C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropDEXNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropDEXNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropDEXNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropDEXNewValueText = enhancePropDEXNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8EE RID: 121070 RVA: 0x0095D7A8 File Offset: 0x0095B9A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropSkillStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8EF RID: 121071 RVA: 0x0095D800 File Offset: 0x0095BA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropSkillStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enhancePropSkillStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enhancePropSkillStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillStateCtrl = enhancePropSkillStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F0 RID: 121072 RVA: 0x0095D85C File Offset: 0x0095BA5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhancePropSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F1 RID: 121073 RVA: 0x0095D8B4 File Offset: 0x0095BAB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhancePropSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropSkillNameText;
			LuaObject.checkType<Text>(l, 2, out enhancePropSkillNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillNameText = enhancePropSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F2 RID: 121074 RVA: 0x0095D910 File Offset: 0x0095BB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropSkillOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillOldValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F3 RID: 121075 RVA: 0x0095D968 File Offset: 0x0095BB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropSkillOldValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropSkillOldValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropSkillOldValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillOldValueText = enhancePropSkillOldValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F4 RID: 121076 RVA: 0x0095D9C4 File Offset: 0x0095BBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropSkillNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillNewValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F5 RID: 121077 RVA: 0x0095DA1C File Offset: 0x0095BC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropSkillNewValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropSkillNewValueText;
			LuaObject.checkType<Text>(l, 2, out enhancePropSkillNewValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillNewValueText = enhancePropSkillNewValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F6 RID: 121078 RVA: 0x0095DA78 File Offset: 0x0095BC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhancePropSkillConditionText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillConditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F7 RID: 121079 RVA: 0x0095DAD0 File Offset: 0x0095BCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhancePropSkillConditionText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enhancePropSkillConditionText;
			LuaObject.checkType<Text>(l, 2, out enhancePropSkillConditionText);
			equipmentForgeUIController.m_luaExportHelper.m_enhancePropSkillConditionText = enhancePropSkillConditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F8 RID: 121080 RVA: 0x0095DB2C File Offset: 0x0095BD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceFastAddButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceFastAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8F9 RID: 121081 RVA: 0x0095DB84 File Offset: 0x0095BD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceFastAddButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enhanceFastAddButton;
			LuaObject.checkType<Button>(l, 2, out enhanceFastAddButton);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceFastAddButton = enhanceFastAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8FA RID: 121082 RVA: 0x0095DBE0 File Offset: 0x0095BDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8FB RID: 121083 RVA: 0x0095DC38 File Offset: 0x0095BE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakGo;
			LuaObject.checkType<GameObject>(l, 2, out breakGo);
			equipmentForgeUIController.m_luaExportHelper.m_breakGo = breakGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8FC RID: 121084 RVA: 0x0095DC94 File Offset: 0x0095BE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8FD RID: 121085 RVA: 0x0095DCEC File Offset: 0x0095BEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakTitleText;
			LuaObject.checkType<Text>(l, 2, out breakTitleText);
			equipmentForgeUIController.m_luaExportHelper.m_breakTitleText = breakTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8FE RID: 121086 RVA: 0x0095DD48 File Offset: 0x0095BF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCurLvEquipmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D8FF RID: 121087 RVA: 0x0095DDA0 File Offset: 0x0095BFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCurLvEquipmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakCurLvEquipmentIcon;
			LuaObject.checkType<Image>(l, 2, out breakCurLvEquipmentIcon);
			equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentIcon = breakCurLvEquipmentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D900 RID: 121088 RVA: 0x0095DDFC File Offset: 0x0095BFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCurLvEquipmentIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D901 RID: 121089 RVA: 0x0095DE54 File Offset: 0x0095C054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCurLvEquipmentIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakCurLvEquipmentIconBg;
			LuaObject.checkType<Image>(l, 2, out breakCurLvEquipmentIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentIconBg = breakCurLvEquipmentIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D902 RID: 121090 RVA: 0x0095DEB0 File Offset: 0x0095C0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCurLvEquipmentIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentIconSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D903 RID: 121091 RVA: 0x0095DF08 File Offset: 0x0095C108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCurLvEquipmentIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakCurLvEquipmentIconSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out breakCurLvEquipmentIconSSREffect);
			equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentIconSSREffect = breakCurLvEquipmentIconSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D904 RID: 121092 RVA: 0x0095DF64 File Offset: 0x0095C164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCurLvEquipmentStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D905 RID: 121093 RVA: 0x0095DFBC File Offset: 0x0095C1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCurLvEquipmentStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakCurLvEquipmentStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out breakCurLvEquipmentStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentStarGroup = breakCurLvEquipmentStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D906 RID: 121094 RVA: 0x0095E018 File Offset: 0x0095C218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCurLvEquipmentOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentOldLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D907 RID: 121095 RVA: 0x0095E070 File Offset: 0x0095C270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCurLvEquipmentOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakCurLvEquipmentOldLvText;
			LuaObject.checkType<Text>(l, 2, out breakCurLvEquipmentOldLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentOldLvText = breakCurLvEquipmentOldLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D908 RID: 121096 RVA: 0x0095E0CC File Offset: 0x0095C2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCurLvEquipmentMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentMaxLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D909 RID: 121097 RVA: 0x0095E124 File Offset: 0x0095C324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakCurLvEquipmentMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakCurLvEquipmentMaxLvText;
			LuaObject.checkType<Text>(l, 2, out breakCurLvEquipmentMaxLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakCurLvEquipmentMaxLvText = breakCurLvEquipmentMaxLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D90A RID: 121098 RVA: 0x0095E180 File Offset: 0x0095C380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakNextLvEquipmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D90B RID: 121099 RVA: 0x0095E1D8 File Offset: 0x0095C3D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakNextLvEquipmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakNextLvEquipmentIcon;
			LuaObject.checkType<Image>(l, 2, out breakNextLvEquipmentIcon);
			equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentIcon = breakNextLvEquipmentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D90C RID: 121100 RVA: 0x0095E234 File Offset: 0x0095C434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_breakNextLvEquipmentIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D90D RID: 121101 RVA: 0x0095E28C File Offset: 0x0095C48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakNextLvEquipmentIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakNextLvEquipmentIconBg;
			LuaObject.checkType<Image>(l, 2, out breakNextLvEquipmentIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentIconBg = breakNextLvEquipmentIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D90E RID: 121102 RVA: 0x0095E2E8 File Offset: 0x0095C4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakNextLvEquipmentIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentIconSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D90F RID: 121103 RVA: 0x0095E340 File Offset: 0x0095C540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakNextLvEquipmentIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakNextLvEquipmentIconSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out breakNextLvEquipmentIconSSREffect);
			equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentIconSSREffect = breakNextLvEquipmentIconSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D910 RID: 121104 RVA: 0x0095E39C File Offset: 0x0095C59C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_breakNextLvEquipmentStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D911 RID: 121105 RVA: 0x0095E3F4 File Offset: 0x0095C5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakNextLvEquipmentStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakNextLvEquipmentStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out breakNextLvEquipmentStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentStarGroup = breakNextLvEquipmentStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D912 RID: 121106 RVA: 0x0095E450 File Offset: 0x0095C650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakNextLvEquipmentOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentOldLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D913 RID: 121107 RVA: 0x0095E4A8 File Offset: 0x0095C6A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakNextLvEquipmentOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakNextLvEquipmentOldLvText;
			LuaObject.checkType<Text>(l, 2, out breakNextLvEquipmentOldLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentOldLvText = breakNextLvEquipmentOldLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D914 RID: 121108 RVA: 0x0095E504 File Offset: 0x0095C704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_breakNextLvEquipmentMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentMaxLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D915 RID: 121109 RVA: 0x0095E55C File Offset: 0x0095C75C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakNextLvEquipmentMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakNextLvEquipmentMaxLvText;
			LuaObject.checkType<Text>(l, 2, out breakNextLvEquipmentMaxLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakNextLvEquipmentMaxLvText = breakNextLvEquipmentMaxLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D916 RID: 121110 RVA: 0x0095E5B8 File Offset: 0x0095C7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakMaterialIconGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakMaterialIconGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D917 RID: 121111 RVA: 0x0095E610 File Offset: 0x0095C810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakMaterialIconGo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakMaterialIconGo;
			LuaObject.checkType<GameObject>(l, 2, out breakMaterialIconGo);
			equipmentForgeUIController.m_luaExportHelper.m_breakMaterialIconGo = breakMaterialIconGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D918 RID: 121112 RVA: 0x0095E66C File Offset: 0x0095C86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_breakMaterialIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakMaterialIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D919 RID: 121113 RVA: 0x0095E6C4 File Offset: 0x0095C8C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakMaterialIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakMaterialIcon;
			LuaObject.checkType<Image>(l, 2, out breakMaterialIcon);
			equipmentForgeUIController.m_luaExportHelper.m_breakMaterialIcon = breakMaterialIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D91A RID: 121114 RVA: 0x0095E720 File Offset: 0x0095C920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakMaterialIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakMaterialIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D91B RID: 121115 RVA: 0x0095E778 File Offset: 0x0095C978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakMaterialIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakMaterialIconBg;
			LuaObject.checkType<Image>(l, 2, out breakMaterialIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_breakMaterialIconBg = breakMaterialIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D91C RID: 121116 RVA: 0x0095E7D4 File Offset: 0x0095C9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakMaterialSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakMaterialSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D91D RID: 121117 RVA: 0x0095E82C File Offset: 0x0095CA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakMaterialSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakMaterialSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out breakMaterialSSREffect);
			equipmentForgeUIController.m_luaExportHelper.m_breakMaterialSSREffect = breakMaterialSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D91E RID: 121118 RVA: 0x0095E888 File Offset: 0x0095CA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakItemsContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakItemsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D91F RID: 121119 RVA: 0x0095E8E0 File Offset: 0x0095CAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakItemsContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakItemsContent;
			LuaObject.checkType<GameObject>(l, 2, out breakItemsContent);
			equipmentForgeUIController.m_luaExportHelper.m_breakItemsContent = breakItemsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D920 RID: 121120 RVA: 0x0095E93C File Offset: 0x0095CB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakGoldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakGoldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D921 RID: 121121 RVA: 0x0095E994 File Offset: 0x0095CB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakGoldText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakGoldText;
			LuaObject.checkType<Text>(l, 2, out breakGoldText);
			equipmentForgeUIController.m_luaExportHelper.m_breakGoldText = breakGoldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D922 RID: 121122 RVA: 0x0095E9F0 File Offset: 0x0095CBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D923 RID: 121123 RVA: 0x0095EA48 File Offset: 0x0095CC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button breakButton;
			LuaObject.checkType<Button>(l, 2, out breakButton);
			equipmentForgeUIController.m_luaExportHelper.m_breakButton = breakButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D924 RID: 121124 RVA: 0x0095EAA4 File Offset: 0x0095CCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCantIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCantIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D925 RID: 121125 RVA: 0x0095EAFC File Offset: 0x0095CCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCantIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakCantIcon;
			LuaObject.checkType<Image>(l, 2, out breakCantIcon);
			equipmentForgeUIController.m_luaExportHelper.m_breakCantIcon = breakCantIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D926 RID: 121126 RVA: 0x0095EB58 File Offset: 0x0095CD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCantIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCantIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D927 RID: 121127 RVA: 0x0095EBB0 File Offset: 0x0095CDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakCantIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakCantIconBg;
			LuaObject.checkType<Image>(l, 2, out breakCantIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_breakCantIconBg = breakCantIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D928 RID: 121128 RVA: 0x0095EC0C File Offset: 0x0095CE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCantStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCantStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D929 RID: 121129 RVA: 0x0095EC64 File Offset: 0x0095CE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCantStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakCantStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out breakCantStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_breakCantStarGroup = breakCantStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D92A RID: 121130 RVA: 0x0095ECC0 File Offset: 0x0095CEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakCantTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakCantTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D92B RID: 121131 RVA: 0x0095ED18 File Offset: 0x0095CF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakCantTitleText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakCantTitleText;
			LuaObject.checkType<Text>(l, 2, out breakCantTitleText);
			equipmentForgeUIController.m_luaExportHelper.m_breakCantTitleText = breakCantTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D92C RID: 121132 RVA: 0x0095ED74 File Offset: 0x0095CF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D92D RID: 121133 RVA: 0x0095EDCC File Offset: 0x0095CFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakSuccessPanel;
			LuaObject.checkType<GameObject>(l, 2, out breakSuccessPanel);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessPanel = breakSuccessPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D92E RID: 121134 RVA: 0x0095EE28 File Offset: 0x0095D028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessPanelBlackButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessPanelBlackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D92F RID: 121135 RVA: 0x0095EE80 File Offset: 0x0095D080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessPanelBlackButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button breakSuccessPanelBlackButton;
			LuaObject.checkType<Button>(l, 2, out breakSuccessPanelBlackButton);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessPanelBlackButton = breakSuccessPanelBlackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D930 RID: 121136 RVA: 0x0095EEDC File Offset: 0x0095D0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D931 RID: 121137 RVA: 0x0095EF34 File Offset: 0x0095D134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessInfoIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakSuccessInfoIconBg;
			LuaObject.checkType<Image>(l, 2, out breakSuccessInfoIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoIconBg = breakSuccessInfoIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D932 RID: 121138 RVA: 0x0095EF90 File Offset: 0x0095D190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D933 RID: 121139 RVA: 0x0095EFE8 File Offset: 0x0095D1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessInfoIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image breakSuccessInfoIcon;
			LuaObject.checkType<Image>(l, 2, out breakSuccessInfoIcon);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoIcon = breakSuccessInfoIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D934 RID: 121140 RVA: 0x0095F044 File Offset: 0x0095D244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D935 RID: 121141 RVA: 0x0095F09C File Offset: 0x0095D29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessInfoStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject breakSuccessInfoStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out breakSuccessInfoStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoStarGroup = breakSuccessInfoStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D936 RID: 121142 RVA: 0x0095F0F8 File Offset: 0x0095D2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoCurOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoCurOldLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D937 RID: 121143 RVA: 0x0095F150 File Offset: 0x0095D350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessInfoCurOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakSuccessInfoCurOldLvText;
			LuaObject.checkType<Text>(l, 2, out breakSuccessInfoCurOldLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoCurOldLvText = breakSuccessInfoCurOldLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D938 RID: 121144 RVA: 0x0095F1AC File Offset: 0x0095D3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoCurMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoCurMaxLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D939 RID: 121145 RVA: 0x0095F204 File Offset: 0x0095D404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessInfoCurMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakSuccessInfoCurMaxLvText;
			LuaObject.checkType<Text>(l, 2, out breakSuccessInfoCurMaxLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoCurMaxLvText = breakSuccessInfoCurMaxLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D93A RID: 121146 RVA: 0x0095F260 File Offset: 0x0095D460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoNextOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoNextOldLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D93B RID: 121147 RVA: 0x0095F2B8 File Offset: 0x0095D4B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_breakSuccessInfoNextOldLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakSuccessInfoNextOldLvText;
			LuaObject.checkType<Text>(l, 2, out breakSuccessInfoNextOldLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoNextOldLvText = breakSuccessInfoNextOldLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D93C RID: 121148 RVA: 0x0095F314 File Offset: 0x0095D514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakSuccessInfoNextMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoNextMaxLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D93D RID: 121149 RVA: 0x0095F36C File Offset: 0x0095D56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakSuccessInfoNextMaxLvText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text breakSuccessInfoNextMaxLvText;
			LuaObject.checkType<Text>(l, 2, out breakSuccessInfoNextMaxLvText);
			equipmentForgeUIController.m_luaExportHelper.m_breakSuccessInfoNextMaxLvText = breakSuccessInfoNextMaxLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D93E RID: 121150 RVA: 0x0095F3C8 File Offset: 0x0095D5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentItemNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentItemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D93F RID: 121151 RVA: 0x0095F420 File Offset: 0x0095D620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentItemNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentItemNameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentItemNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentItemNameText = enchantmentItemNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D940 RID: 121152 RVA: 0x0095F47C File Offset: 0x0095D67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentItemLevelValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentItemLevelValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D941 RID: 121153 RVA: 0x0095F4D4 File Offset: 0x0095D6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentItemLevelValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentItemLevelValueText;
			LuaObject.checkType<Text>(l, 2, out enchantmentItemLevelValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentItemLevelValueText = enchantmentItemLevelValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D942 RID: 121154 RVA: 0x0095F530 File Offset: 0x0095D730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D943 RID: 121155 RVA: 0x0095F588 File Offset: 0x0095D788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentIcon);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentIcon = enchantmentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D944 RID: 121156 RVA: 0x0095F5E4 File Offset: 0x0095D7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D945 RID: 121157 RVA: 0x0095F63C File Offset: 0x0095D83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentIconBg;
			LuaObject.checkType<Image>(l, 2, out enchantmentIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentIconBg = enchantmentIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D946 RID: 121158 RVA: 0x0095F698 File Offset: 0x0095D898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentIconSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D947 RID: 121159 RVA: 0x0095F6F0 File Offset: 0x0095D8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentIconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentIconSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentIconSSREffect);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentIconSSREffect = enchantmentIconSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D948 RID: 121160 RVA: 0x0095F74C File Offset: 0x0095D94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D949 RID: 121161 RVA: 0x0095F7A4 File Offset: 0x0095D9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentStarGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentStarGroup);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStarGroup = enchantmentStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D94A RID: 121162 RVA: 0x0095F800 File Offset: 0x0095DA00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentEnchantPropertyGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentEnchantPropertyGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D94B RID: 121163 RVA: 0x0095F858 File Offset: 0x0095DA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentEnchantPropertyGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentEnchantPropertyGroup;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentEnchantPropertyGroup);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentEnchantPropertyGroup = enchantmentEnchantPropertyGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D94C RID: 121164 RVA: 0x0095F8B4 File Offset: 0x0095DAB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentEnchantPropertyGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentEnchantPropertyGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D94D RID: 121165 RVA: 0x0095F90C File Offset: 0x0095DB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentEnchantPropertyGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentEnchantPropertyGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentEnchantPropertyGroupStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentEnchantPropertyGroupStateCtrl = enchantmentEnchantPropertyGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D94E RID: 121166 RVA: 0x0095F968 File Offset: 0x0095DB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D94F RID: 121167 RVA: 0x0095F9C0 File Offset: 0x0095DBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentSuitInfoStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentSuitInfoStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoStateCtrl = enchantmentSuitInfoStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D950 RID: 121168 RVA: 0x0095FA1C File Offset: 0x0095DC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D951 RID: 121169 RVA: 0x0095FA74 File Offset: 0x0095DC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentSuitInfoGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentSuitInfoGroupStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoGroupStateCtrl = enchantmentSuitInfoGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D952 RID: 121170 RVA: 0x0095FAD0 File Offset: 0x0095DCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoNowEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D953 RID: 121171 RVA: 0x0095FB28 File Offset: 0x0095DD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoNowEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentSuitInfoNowEffectStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentSuitInfoNowEffectStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectStateCtrl = enchantmentSuitInfoNowEffectStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D954 RID: 121172 RVA: 0x0095FB84 File Offset: 0x0095DD84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentSuitInfoNowEffectRuneIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneIconStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D955 RID: 121173 RVA: 0x0095FBDC File Offset: 0x0095DDDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentSuitInfoNowEffectRuneIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentSuitInfoNowEffectRuneIconStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentSuitInfoNowEffectRuneIconStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneIconStateCtrl = enchantmentSuitInfoNowEffectRuneIconStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D956 RID: 121174 RVA: 0x0095FC38 File Offset: 0x0095DE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoNowEffectRuneActiveIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneActiveIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D957 RID: 121175 RVA: 0x0095FC90 File Offset: 0x0095DE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoNowEffectRuneActiveIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentSuitInfoNowEffectRuneActiveIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentSuitInfoNowEffectRuneActiveIcon);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneActiveIcon = enchantmentSuitInfoNowEffectRuneActiveIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D958 RID: 121176 RVA: 0x0095FCEC File Offset: 0x0095DEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoNowEffectRuneUnactiveIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneUnactiveIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D959 RID: 121177 RVA: 0x0095FD44 File Offset: 0x0095DF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoNowEffectRuneUnactiveIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentSuitInfoNowEffectRuneUnactiveIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentSuitInfoNowEffectRuneUnactiveIcon);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneUnactiveIcon = enchantmentSuitInfoNowEffectRuneUnactiveIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D95A RID: 121178 RVA: 0x0095FDA0 File Offset: 0x0095DFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoNowEffectRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D95B RID: 121179 RVA: 0x0095FDF8 File Offset: 0x0095DFF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentSuitInfoNowEffectRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentSuitInfoNowEffectRuneNameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentSuitInfoNowEffectRuneNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRuneNameText = enchantmentSuitInfoNowEffectRuneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D95C RID: 121180 RVA: 0x0095FE54 File Offset: 0x0095E054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentSuitInfoNowEffectRune2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRune2SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D95D RID: 121181 RVA: 0x0095FEAC File Offset: 0x0095E0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoNowEffectRune2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentSuitInfoNowEffectRune2SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentSuitInfoNowEffectRune2SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRune2SuitInfoText = enchantmentSuitInfoNowEffectRune2SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D95E RID: 121182 RVA: 0x0095FF08 File Offset: 0x0095E108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentSuitInfoNowEffectRune4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRune4SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D95F RID: 121183 RVA: 0x0095FF60 File Offset: 0x0095E160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoNowEffectRune4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentSuitInfoNowEffectRune4SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentSuitInfoNowEffectRune4SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoNowEffectRune4SuitInfoText = enchantmentSuitInfoNowEffectRune4SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D960 RID: 121184 RVA: 0x0095FFBC File Offset: 0x0095E1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoAfterEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D961 RID: 121185 RVA: 0x00960014 File Offset: 0x0095E214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoAfterEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentSuitInfoAfterEffectStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentSuitInfoAfterEffectStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectStateCtrl = enchantmentSuitInfoAfterEffectStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D962 RID: 121186 RVA: 0x00960070 File Offset: 0x0095E270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D963 RID: 121187 RVA: 0x009600C8 File Offset: 0x0095E2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentSuitInfoAfterEffectRuneUnactiveIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentSuitInfoAfterEffectRuneUnactiveIcon);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon = enchantmentSuitInfoAfterEffectRuneUnactiveIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D964 RID: 121188 RVA: 0x00960124 File Offset: 0x0095E324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoAfterEffectRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRuneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D965 RID: 121189 RVA: 0x0096017C File Offset: 0x0095E37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoAfterEffectRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentSuitInfoAfterEffectRuneNameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentSuitInfoAfterEffectRuneNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRuneNameText = enchantmentSuitInfoAfterEffectRuneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D966 RID: 121190 RVA: 0x009601D8 File Offset: 0x0095E3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoAfterEffectRune2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRune2SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D967 RID: 121191 RVA: 0x00960230 File Offset: 0x0095E430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentSuitInfoAfterEffectRune2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentSuitInfoAfterEffectRune2SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentSuitInfoAfterEffectRune2SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRune2SuitInfoText = enchantmentSuitInfoAfterEffectRune2SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D968 RID: 121192 RVA: 0x0096028C File Offset: 0x0095E48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentSuitInfoAfterEffectRune4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRune4SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D969 RID: 121193 RVA: 0x009602E4 File Offset: 0x0095E4E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentSuitInfoAfterEffectRune4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentSuitInfoAfterEffectRune4SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentSuitInfoAfterEffectRune4SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentSuitInfoAfterEffectRune4SuitInfoText = enchantmentSuitInfoAfterEffectRune4SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D96A RID: 121194 RVA: 0x00960340 File Offset: 0x0095E540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentMaterialGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentMaterialGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D96B RID: 121195 RVA: 0x00960398 File Offset: 0x0095E598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentMaterialGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentMaterialGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentMaterialGroupStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentMaterialGroupStateCtrl = enchantmentMaterialGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D96C RID: 121196 RVA: 0x009603F4 File Offset: 0x0095E5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentStoneIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D96D RID: 121197 RVA: 0x0096044C File Offset: 0x0095E64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentStoneIconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentStoneIconBg;
			LuaObject.checkType<Image>(l, 2, out enchantmentStoneIconBg);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneIconBg = enchantmentStoneIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D96E RID: 121198 RVA: 0x009604A8 File Offset: 0x0095E6A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentStoneIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D96F RID: 121199 RVA: 0x00960500 File Offset: 0x0095E700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentStoneIcon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentStoneIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentStoneIcon);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneIcon = enchantmentStoneIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D970 RID: 121200 RVA: 0x0096055C File Offset: 0x0095E75C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentStoneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D971 RID: 121201 RVA: 0x009605B4 File Offset: 0x0095E7B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentStoneNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentStoneNameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentStoneNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneNameText = enchantmentStoneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D972 RID: 121202 RVA: 0x00960610 File Offset: 0x0095E810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentStoneDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D973 RID: 121203 RVA: 0x00960668 File Offset: 0x0095E868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentStoneDescText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentStoneDescText;
			LuaObject.checkType<Text>(l, 2, out enchantmentStoneDescText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneDescText = enchantmentStoneDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D974 RID: 121204 RVA: 0x009606C4 File Offset: 0x0095E8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentStoneValueGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneValueGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D975 RID: 121205 RVA: 0x0096071C File Offset: 0x0095E91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentStoneValueGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentStoneValueGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentStoneValueGroupStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneValueGroupStateCtrl = enchantmentStoneValueGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D976 RID: 121206 RVA: 0x00960778 File Offset: 0x0095E978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentStoneHaveCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneHaveCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D977 RID: 121207 RVA: 0x009607D0 File Offset: 0x0095E9D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentStoneHaveCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentStoneHaveCount;
			LuaObject.checkType<Text>(l, 2, out enchantmentStoneHaveCount);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentStoneHaveCount = enchantmentStoneHaveCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D978 RID: 121208 RVA: 0x0096082C File Offset: 0x0095EA2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentGoldenValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentGoldenValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D979 RID: 121209 RVA: 0x00960884 File Offset: 0x0095EA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentGoldenValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentGoldenValueText;
			LuaObject.checkType<Text>(l, 2, out enchantmentGoldenValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentGoldenValueText = enchantmentGoldenValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D97A RID: 121210 RVA: 0x009608E0 File Offset: 0x0095EAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentGoldenValueTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentGoldenValueTextStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D97B RID: 121211 RVA: 0x00960938 File Offset: 0x0095EB38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentGoldenValueTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentGoldenValueTextStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentGoldenValueTextStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentGoldenValueTextStateCtrl = enchantmentGoldenValueTextStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D97C RID: 121212 RVA: 0x00960994 File Offset: 0x0095EB94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D97D RID: 121213 RVA: 0x009609EC File Offset: 0x0095EBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantmentButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentButton = enchantmentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D97E RID: 121214 RVA: 0x00960A48 File Offset: 0x0095EC48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantKeepPropertyGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantKeepPropertyGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D97F RID: 121215 RVA: 0x00960AA0 File Offset: 0x0095ECA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantKeepPropertyGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantKeepPropertyGroup;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantKeepPropertyGroup);
			equipmentForgeUIController.m_luaExportHelper.m_enchantKeepPropertyGroup = enchantKeepPropertyGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D980 RID: 121216 RVA: 0x00960AFC File Offset: 0x0095ECFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantSuccessEffectPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantSuccessEffectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D981 RID: 121217 RVA: 0x00960B54 File Offset: 0x0095ED54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantSuccessEffectPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantSuccessEffectPanel;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantSuccessEffectPanel);
			equipmentForgeUIController.m_luaExportHelper.m_enchantSuccessEffectPanel = enchantSuccessEffectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D982 RID: 121218 RVA: 0x00960BB0 File Offset: 0x0095EDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D983 RID: 121219 RVA: 0x00960C08 File Offset: 0x0095EE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelStateCtrl = enchantmentResultPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D984 RID: 121220 RVA: 0x00960C64 File Offset: 0x0095EE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D985 RID: 121221 RVA: 0x00960CBC File Offset: 0x0095EEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantmentResultPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentResultPanelCloseButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelCloseButton = enchantmentResultPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D986 RID: 121222 RVA: 0x00960D18 File Offset: 0x0095EF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelOldPropretyGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOldPropretyGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D987 RID: 121223 RVA: 0x00960D70 File Offset: 0x0095EF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelOldPropretyGroup(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			GameObject enchantmentResultPanelOldPropretyGroup;
			LuaObject.checkType<GameObject>(l, 2, out enchantmentResultPanelOldPropretyGroup);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOldPropretyGroup = enchantmentResultPanelOldPropretyGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D988 RID: 121224 RVA: 0x00960DCC File Offset: 0x0095EFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelOldSuitInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOldSuitInfoStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D989 RID: 121225 RVA: 0x00960E24 File Offset: 0x0095F024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentResultPanelOldSuitInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelOldSuitInfoStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelOldSuitInfoStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOldSuitInfoStateCtrl = enchantmentResultPanelOldSuitInfoStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D98A RID: 121226 RVA: 0x00960E80 File Offset: 0x0095F080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelOldSuitInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOldSuitInfoNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D98B RID: 121227 RVA: 0x00960ED8 File Offset: 0x0095F0D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentResultPanelOldSuitInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelOldSuitInfoNameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelOldSuitInfoNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOldSuitInfoNameText = enchantmentResultPanelOldSuitInfoNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D98C RID: 121228 RVA: 0x00960F34 File Offset: 0x0095F134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelOld2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOld2SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D98D RID: 121229 RVA: 0x00960F8C File Offset: 0x0095F18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelOld2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelOld2SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelOld2SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOld2SuitInfoText = enchantmentResultPanelOld2SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D98E RID: 121230 RVA: 0x00960FE8 File Offset: 0x0095F1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelOld4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOld4SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D98F RID: 121231 RVA: 0x00961040 File Offset: 0x0095F240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelOld4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelOld4SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelOld4SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelOld4SuitInfoText = enchantmentResultPanelOld4SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D990 RID: 121232 RVA: 0x0096109C File Offset: 0x0095F29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety1StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1StateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D991 RID: 121233 RVA: 0x009610F4 File Offset: 0x0095F2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety1StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelNewProprety1StateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelNewProprety1StateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1StateCtrl = enchantmentResultPanelNewProprety1StateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D992 RID: 121234 RVA: 0x00961150 File Offset: 0x0095F350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety1ProgressBar(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1ProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D993 RID: 121235 RVA: 0x009611A8 File Offset: 0x0095F3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentResultPanelNewProprety1ProgressBar(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentResultPanelNewProprety1ProgressBar;
			LuaObject.checkType<Image>(l, 2, out enchantmentResultPanelNewProprety1ProgressBar);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1ProgressBar = enchantmentResultPanelNewProprety1ProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D994 RID: 121236 RVA: 0x00961204 File Offset: 0x0095F404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety1NameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D995 RID: 121237 RVA: 0x0096125C File Offset: 0x0095F45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety1NameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewProprety1NameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewProprety1NameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1NameText = enchantmentResultPanelNewProprety1NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D996 RID: 121238 RVA: 0x009612B8 File Offset: 0x0095F4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety1ValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D997 RID: 121239 RVA: 0x00961310 File Offset: 0x0095F510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety1ValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewProprety1ValueText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewProprety1ValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety1ValueText = enchantmentResultPanelNewProprety1ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D998 RID: 121240 RVA: 0x0096136C File Offset: 0x0095F56C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelNewProprety2StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2StateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D999 RID: 121241 RVA: 0x009613C4 File Offset: 0x0095F5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety2StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelNewProprety2StateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelNewProprety2StateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2StateCtrl = enchantmentResultPanelNewProprety2StateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D99A RID: 121242 RVA: 0x00961420 File Offset: 0x0095F620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelNewProprety2ProgressBar(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2ProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D99B RID: 121243 RVA: 0x00961478 File Offset: 0x0095F678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety2ProgressBar(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentResultPanelNewProprety2ProgressBar;
			LuaObject.checkType<Image>(l, 2, out enchantmentResultPanelNewProprety2ProgressBar);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2ProgressBar = enchantmentResultPanelNewProprety2ProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D99C RID: 121244 RVA: 0x009614D4 File Offset: 0x0095F6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety2NameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D99D RID: 121245 RVA: 0x0096152C File Offset: 0x0095F72C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enchantmentResultPanelNewProprety2NameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewProprety2NameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewProprety2NameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2NameText = enchantmentResultPanelNewProprety2NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D99E RID: 121246 RVA: 0x00961588 File Offset: 0x0095F788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety2ValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D99F RID: 121247 RVA: 0x009615E0 File Offset: 0x0095F7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety2ValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewProprety2ValueText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewProprety2ValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety2ValueText = enchantmentResultPanelNewProprety2ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A0 RID: 121248 RVA: 0x0096163C File Offset: 0x0095F83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety3StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3StateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A1 RID: 121249 RVA: 0x00961694 File Offset: 0x0095F894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety3StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelNewProprety3StateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelNewProprety3StateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3StateCtrl = enchantmentResultPanelNewProprety3StateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A2 RID: 121250 RVA: 0x009616F0 File Offset: 0x0095F8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety3ProgressBar(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3ProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A3 RID: 121251 RVA: 0x00961748 File Offset: 0x0095F948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety3ProgressBar(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentResultPanelNewProprety3ProgressBar;
			LuaObject.checkType<Image>(l, 2, out enchantmentResultPanelNewProprety3ProgressBar);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3ProgressBar = enchantmentResultPanelNewProprety3ProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A4 RID: 121252 RVA: 0x009617A4 File Offset: 0x0095F9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNewProprety3NameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A5 RID: 121253 RVA: 0x009617FC File Offset: 0x0095F9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety3NameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewProprety3NameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewProprety3NameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3NameText = enchantmentResultPanelNewProprety3NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A6 RID: 121254 RVA: 0x00961858 File Offset: 0x0095FA58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelNewProprety3ValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A7 RID: 121255 RVA: 0x009618B0 File Offset: 0x0095FAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewProprety3ValueText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewProprety3ValueText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewProprety3ValueText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewProprety3ValueText = enchantmentResultPanelNewProprety3ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A8 RID: 121256 RVA: 0x0096190C File Offset: 0x0095FB0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelNewSuitInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewSuitInfoNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9A9 RID: 121257 RVA: 0x00961964 File Offset: 0x0095FB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNewSuitInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNewSuitInfoNameText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNewSuitInfoNameText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNewSuitInfoNameText = enchantmentResultPanelNewSuitInfoNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9AA RID: 121258 RVA: 0x009619C0 File Offset: 0x0095FBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNew2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNew2SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9AB RID: 121259 RVA: 0x00961A18 File Offset: 0x0095FC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNew2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNew2SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNew2SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNew2SuitInfoText = enchantmentResultPanelNew2SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9AC RID: 121260 RVA: 0x00961A74 File Offset: 0x0095FC74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelNew4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNew4SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9AD RID: 121261 RVA: 0x00961ACC File Offset: 0x0095FCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNew4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNew4SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNew4SuitInfoText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNew4SuitInfoText = enchantmentResultPanelNew4SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9AE RID: 121262 RVA: 0x00961B28 File Offset: 0x0095FD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelEnchantmentAgainButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelEnchantmentAgainButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9AF RID: 121263 RVA: 0x00961B80 File Offset: 0x0095FD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelEnchantmentAgainButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantmentResultPanelEnchantmentAgainButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentResultPanelEnchantmentAgainButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelEnchantmentAgainButton = enchantmentResultPanelEnchantmentAgainButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B0 RID: 121264 RVA: 0x00961BDC File Offset: 0x0095FDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B1 RID: 121265 RVA: 0x00961C34 File Offset: 0x0095FE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelEnchantmentAgainButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelEnchantmentAgainButtonStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl = enchantmentResultPanelEnchantmentAgainButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B2 RID: 121266 RVA: 0x00961C90 File Offset: 0x0095FE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelNumberText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B3 RID: 121267 RVA: 0x00961CE8 File Offset: 0x0095FEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelNumberText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelNumberText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelNumberText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelNumberText = enchantmentResultPanelNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B4 RID: 121268 RVA: 0x00961D44 File Offset: 0x0095FF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelGoldenNumberText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelGoldenNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B5 RID: 121269 RVA: 0x00961D9C File Offset: 0x0095FF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelGoldenNumberText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Text enchantmentResultPanelGoldenNumberText;
			LuaObject.checkType<Text>(l, 2, out enchantmentResultPanelGoldenNumberText);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelGoldenNumberText = enchantmentResultPanelGoldenNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B6 RID: 121270 RVA: 0x00961DF8 File Offset: 0x0095FFF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enchantmentResultPanelGoldenNumberStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelGoldenNumberStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B7 RID: 121271 RVA: 0x00961E50 File Offset: 0x00960050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelGoldenNumberStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController enchantmentResultPanelGoldenNumberStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enchantmentResultPanelGoldenNumberStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelGoldenNumberStateCtrl = enchantmentResultPanelGoldenNumberStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B8 RID: 121272 RVA: 0x00961EAC File Offset: 0x009600AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelItemImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelItemImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9B9 RID: 121273 RVA: 0x00961F04 File Offset: 0x00960104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelItemImage(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Image enchantmentResultPanelItemImage;
			LuaObject.checkType<Image>(l, 2, out enchantmentResultPanelItemImage);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelItemImage = enchantmentResultPanelItemImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9BA RID: 121274 RVA: 0x00961F60 File Offset: 0x00960160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelSavePropretyButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelSavePropretyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9BB RID: 121275 RVA: 0x00961FB8 File Offset: 0x009601B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelSavePropretyButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantmentResultPanelSavePropretyButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentResultPanelSavePropretyButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelSavePropretyButton = enchantmentResultPanelSavePropretyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9BC RID: 121276 RVA: 0x00962014 File Offset: 0x00960214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentResultPanelContinueButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelContinueButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9BD RID: 121277 RVA: 0x0096206C File Offset: 0x0096026C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentResultPanelContinueButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button enchantmentResultPanelContinueButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentResultPanelContinueButton);
			equipmentForgeUIController.m_luaExportHelper.m_enchantmentResultPanelContinueButton = enchantmentResultPanelContinueButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9BE RID: 121278 RVA: 0x009620C8 File Offset: 0x009602C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_savePropretyPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9BF RID: 121279 RVA: 0x00962120 File Offset: 0x00960320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_savePropretyPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController savePropretyPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out savePropretyPanelStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelStateCtrl = savePropretyPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C0 RID: 121280 RVA: 0x0096217C File Offset: 0x0096037C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_savePropretyPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C1 RID: 121281 RVA: 0x009621D4 File Offset: 0x009603D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_savePropretyPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button savePropretyPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out savePropretyPanelCancelButton);
			equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelCancelButton = savePropretyPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C2 RID: 121282 RVA: 0x00962230 File Offset: 0x00960430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_savePropretyPanelComfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelComfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C3 RID: 121283 RVA: 0x00962288 File Offset: 0x00960488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_savePropretyPanelComfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button savePropretyPanelComfirmButton;
			LuaObject.checkType<Button>(l, 2, out savePropretyPanelComfirmButton);
			equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelComfirmButton = savePropretyPanelComfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C4 RID: 121284 RVA: 0x009622E4 File Offset: 0x009604E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_savePropretyPanelToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C5 RID: 121285 RVA: 0x0096233C File Offset: 0x0096053C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_savePropretyPanelToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Toggle savePropretyPanelToggle;
			LuaObject.checkType<Toggle>(l, 2, out savePropretyPanelToggle);
			equipmentForgeUIController.m_luaExportHelper.m_savePropretyPanelToggle = savePropretyPanelToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C6 RID: 121286 RVA: 0x00962398 File Offset: 0x00960598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cancelPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_cancelPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C7 RID: 121287 RVA: 0x009623F0 File Offset: 0x009605F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cancelPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			CommonUIStateController cancelPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out cancelPanelStateCtrl);
			equipmentForgeUIController.m_luaExportHelper.m_cancelPanelStateCtrl = cancelPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C8 RID: 121288 RVA: 0x0096244C File Offset: 0x0096064C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_cancelPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9C9 RID: 121289 RVA: 0x009624A4 File Offset: 0x009606A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cancelPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button cancelPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out cancelPanelCancelButton);
			equipmentForgeUIController.m_luaExportHelper.m_cancelPanelCancelButton = cancelPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9CA RID: 121290 RVA: 0x00962500 File Offset: 0x00960700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cancelPanelComfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_cancelPanelComfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9CB RID: 121291 RVA: 0x00962558 File Offset: 0x00960758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cancelPanelComfirmButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Button cancelPanelComfirmButton;
			LuaObject.checkType<Button>(l, 2, out cancelPanelComfirmButton);
			equipmentForgeUIController.m_luaExportHelper.m_cancelPanelComfirmButton = cancelPanelComfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9CC RID: 121292 RVA: 0x009625B4 File Offset: 0x009607B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelPanelToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_cancelPanelToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9CD RID: 121293 RVA: 0x0096260C File Offset: 0x0096080C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelPanelToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			Toggle cancelPanelToggle;
			LuaObject.checkType<Toggle>(l, 2, out cancelPanelToggle);
			equipmentForgeUIController.m_luaExportHelper.m_cancelPanelToggle = cancelPanelToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9CE RID: 121294 RVA: 0x00962668 File Offset: 0x00960868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9CF RID: 121295 RVA: 0x009626C0 File Offset: 0x009608C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			equipmentForgeUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D0 RID: 121296 RVA: 0x0096271C File Offset: 0x0096091C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D1 RID: 121297 RVA: 0x00962774 File Offset: 0x00960974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			equipmentForgeUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D2 RID: 121298 RVA: 0x009627D0 File Offset: 0x009609D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D3 RID: 121299 RVA: 0x00962828 File Offset: 0x00960A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			equipmentForgeUIController.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D4 RID: 121300 RVA: 0x00962884 File Offset: 0x00960A84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isAscend(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_isAscend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D5 RID: 121301 RVA: 0x009628DC File Offset: 0x00960ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAscend(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			int isAscend;
			LuaObject.checkType(l, 2, out isAscend);
			equipmentForgeUIController.m_luaExportHelper.m_isAscend = isAscend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D6 RID: 121302 RVA: 0x00962938 File Offset: 0x00960B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D7 RID: 121303 RVA: 0x00962990 File Offset: 0x00960B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			equipmentForgeUIController.m_luaExportHelper.m_isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D8 RID: 121304 RVA: 0x009629EC File Offset: 0x00960BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_isToggleChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9D9 RID: 121305 RVA: 0x00962A44 File Offset: 0x00960C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isToggleChanged;
			LuaObject.checkType(l, 2, out isToggleChanged);
			equipmentForgeUIController.m_luaExportHelper.m_isToggleChanged = isToggleChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9DA RID: 121306 RVA: 0x00962AA0 File Offset: 0x00960CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curForgeState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)equipmentForgeUIController.m_luaExportHelper.m_curForgeState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9DB RID: 121307 RVA: 0x00962AF8 File Offset: 0x00960CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curForgeState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentForgeUIController.ForgeState curForgeState;
			LuaObject.checkEnum<EquipmentForgeUIController.ForgeState>(l, 2, out curForgeState);
			equipmentForgeUIController.m_luaExportHelper.m_curForgeState = curForgeState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9DC RID: 121308 RVA: 0x00962B54 File Offset: 0x00960D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curEquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_curEquipmentInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9DD RID: 121309 RVA: 0x00962BAC File Offset: 0x00960DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curEquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong curEquipmentInstanceId;
			LuaObject.checkType(l, 2, out curEquipmentInstanceId);
			equipmentForgeUIController.m_luaExportHelper.m_curEquipmentInstanceId = curEquipmentInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9DE RID: 121310 RVA: 0x00962C08 File Offset: 0x00960E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBreakMaterialEquipmentId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_curBreakMaterialEquipmentId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9DF RID: 121311 RVA: 0x00962C60 File Offset: 0x00960E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBreakMaterialEquipmentId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong curBreakMaterialEquipmentId;
			LuaObject.checkType(l, 2, out curBreakMaterialEquipmentId);
			equipmentForgeUIController.m_luaExportHelper.m_curBreakMaterialEquipmentId = curBreakMaterialEquipmentId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E0 RID: 121312 RVA: 0x00962CBC File Offset: 0x00960EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curAddEnhanceEquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_curAddEnhanceEquipmentInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E1 RID: 121313 RVA: 0x00962D14 File Offset: 0x00960F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curAddEnhanceEquipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ulong curAddEnhanceEquipmentInstanceId;
			LuaObject.checkType(l, 2, out curAddEnhanceEquipmentInstanceId);
			equipmentForgeUIController.m_luaExportHelper.m_curAddEnhanceEquipmentInstanceId = curAddEnhanceEquipmentInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E2 RID: 121314 RVA: 0x00962D70 File Offset: 0x00960F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectEnchantStoneItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_curSelectEnchantStoneItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E3 RID: 121315 RVA: 0x00962DC8 File Offset: 0x00960FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectEnchantStoneItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			BagItemBase curSelectEnchantStoneItem;
			LuaObject.checkType<BagItemBase>(l, 2, out curSelectEnchantStoneItem);
			equipmentForgeUIController.m_luaExportHelper.m_curSelectEnchantStoneItem = curSelectEnchantStoneItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E4 RID: 121316 RVA: 0x00962E24 File Offset: 0x00961024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastSelectEnchantStoneInfo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_lastSelectEnchantStoneInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E5 RID: 121317 RVA: 0x00962E7C File Offset: 0x0096107C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lastSelectEnchantStoneInfo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			ConfigDataEnchantStoneInfo lastSelectEnchantStoneInfo;
			LuaObject.checkType<ConfigDataEnchantStoneInfo>(l, 2, out lastSelectEnchantStoneInfo);
			equipmentForgeUIController.m_luaExportHelper.m_lastSelectEnchantStoneInfo = lastSelectEnchantStoneInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E6 RID: 121318 RVA: 0x00962ED8 File Offset: 0x009610D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhanceEquipmentInstanceIds(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enhanceEquipmentInstanceIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E7 RID: 121319 RVA: 0x00962F30 File Offset: 0x00961130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceEquipmentInstanceIds(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<ulong> enhanceEquipmentInstanceIds;
			LuaObject.checkType<List<ulong>>(l, 2, out enhanceEquipmentInstanceIds);
			equipmentForgeUIController.m_luaExportHelper.m_enhanceEquipmentInstanceIds = enhanceEquipmentInstanceIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E8 RID: 121320 RVA: 0x00962F8C File Offset: 0x0096118C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentItemCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_equipmentItemCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9E9 RID: 121321 RVA: 0x00962FE4 File Offset: 0x009611E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentItemCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<EquipmentBagItem> equipmentItemCache;
			LuaObject.checkType<List<EquipmentBagItem>>(l, 2, out equipmentItemCache);
			equipmentForgeUIController.m_luaExportHelper.m_equipmentItemCache = equipmentItemCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9EA RID: 121322 RVA: 0x00963040 File Offset: 0x00961240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantStoneItemCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_enchantStoneItemCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9EB RID: 121323 RVA: 0x00963098 File Offset: 0x00961298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantStoneItemCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<EnchantStoneBagItem> enchantStoneItemCache;
			LuaObject.checkType<List<EnchantStoneBagItem>>(l, 2, out enchantStoneItemCache);
			equipmentForgeUIController.m_luaExportHelper.m_enchantStoneItemCache = enchantStoneItemCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9EC RID: 121324 RVA: 0x009630F4 File Offset: 0x009612F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentForgeCtrlList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_equipmentForgeCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9ED RID: 121325 RVA: 0x0096314C File Offset: 0x0096134C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipmentForgeCtrlList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<EquipmentDepotListItemUIController> equipmentForgeCtrlList;
			LuaObject.checkType<List<EquipmentDepotListItemUIController>>(l, 2, out equipmentForgeCtrlList);
			equipmentForgeUIController.m_luaExportHelper.m_equipmentForgeCtrlList = equipmentForgeCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9EE RID: 121326 RVA: 0x009631A8 File Offset: 0x009613A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curEquipmentSortType(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)equipmentForgeUIController.m_luaExportHelper.m_curEquipmentSortType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9EF RID: 121327 RVA: 0x00963200 File Offset: 0x00961400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curEquipmentSortType(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			EquipmentDepotUIController.EquipmentSortTypeState curEquipmentSortType;
			LuaObject.checkEnum<EquipmentDepotUIController.EquipmentSortTypeState>(l, 2, out curEquipmentSortType);
			equipmentForgeUIController.m_luaExportHelper.m_curEquipmentSortType = curEquipmentSortType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F0 RID: 121328 RVA: 0x0096325C File Offset: 0x0096145C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curEnchantmentSortTypeId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_curEnchantmentSortTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F1 RID: 121329 RVA: 0x009632B4 File Offset: 0x009614B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curEnchantmentSortTypeId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			int curEnchantmentSortTypeId;
			LuaObject.checkType(l, 2, out curEnchantmentSortTypeId);
			equipmentForgeUIController.m_luaExportHelper.m_curEnchantmentSortTypeId = curEnchantmentSortTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F2 RID: 121330 RVA: 0x00963310 File Offset: 0x00961510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_properties(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_properties);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F3 RID: 121331 RVA: 0x00963368 File Offset: 0x00961568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_properties(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			List<CommonBattleProperty> properties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 2, out properties);
			equipmentForgeUIController.m_luaExportHelper.m_properties = properties;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F4 RID: 121332 RVA: 0x009633C4 File Offset: 0x009615C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isAfter3DTouch(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_isAfter3DTouch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F5 RID: 121333 RVA: 0x0096341C File Offset: 0x0096161C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isAfter3DTouch(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			bool isAfter3DTouch;
			LuaObject.checkType(l, 2, out isAfter3DTouch);
			equipmentForgeUIController.m_luaExportHelper.m_isAfter3DTouch = isAfter3DTouch;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F6 RID: 121334 RVA: 0x00963478 File Offset: 0x00961678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldSkillLevelStr(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUIController.m_luaExportHelper.m_oldSkillLevelStr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F7 RID: 121335 RVA: 0x009634D0 File Offset: 0x009616D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_oldSkillLevelStr(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUIController equipmentForgeUIController = (EquipmentForgeUIController)LuaObject.checkSelf(l);
			string oldSkillLevelStr;
			LuaObject.checkType(l, 2, out oldSkillLevelStr);
			equipmentForgeUIController.m_luaExportHelper.m_oldSkillLevelStr = oldSkillLevelStr;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9F8 RID: 121336 RVA: 0x0096352C File Offset: 0x0096172C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentForgeUIController");
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.UpdateEquipmentForgeView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceFastAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetPlayerResourceGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.GetFirstEquipmentGoInListForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.InitSortTypePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.InitLoopScrollRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CreateEquipmentList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SortEquipmentListByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.DefaultEquipmentItemComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CollectEquipmentPropValueAndSort);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentItemClickInEnhance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentItemClickInBreak);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentItemClickInEnchantment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentListItemNeedFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentListItem3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnFilterSortButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentFilterSortButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnCloseFilterSortTypeGo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnCloseEnchantmentFilterSortTypeGo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnFilterSortOrderButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnFilterTypeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentFilterTypeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetEquipmentItemDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetPropItemColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetPropItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.UpdateViewInEnhanceState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetEnhancePropItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.ResetEnhancePropItemActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CalculateEquipmentEnhanceAddLvByExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SendEnhanceEquipmentMsg);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.StopEnhanceSucceedEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetSkillLevelUpEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.DelayActiveIntensifyContinueButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnIntensifySuccessPanelBlackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.ShowEnhanceItemSRConfirmPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.ShowEnhanceItemsConfirmPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceItemSRConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceItemSRCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.IsEquipmentAddExpAtMaxLevelMaxExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.UpdateViewInBreakState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnBreakButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnBreakSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.DelayActiveBreakContinueButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnBreakSuccessPanelContinueButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEquipmentBreakNeedItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.UpdateViewInEnchantmentState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.ShowEnchantmentResultPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.SetEnchantmentResultPanelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.Co_PlayNewPropertyEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.Co_DynamicSetPropertyValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CalcPropertyPercent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentResultPanelContinueButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CloseEnchantmentResultPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentResultSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentAgainButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.ShowSavePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CloseSavePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnSavePanlConfirmClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.PlaySucceedEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnCloseEnchantResultPanelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.ShowCancelPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.CloseCancelPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnCancelPanlConfirmClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnSavePropertyToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnCancelPanelToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnhanceToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnBreakToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantmentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnEnchantLockMaskButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnEnhanceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnEnhanceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnBreakButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnBreakButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnEnchantButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnEnchantButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnBreakNeedItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnBreakNeedItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnEnchantSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnEnchantSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__callDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.__clearDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6D);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6E, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache6F, true);
		string name3 = "EventOnGoldAddButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnGoldAddButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache70, true);
		string name4 = "EventOnEnhanceButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnEnhanceButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache71, true);
		string name5 = "EventOnBreakButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnBreakButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache72, true);
		string name6 = "EventOnEnchantButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnEnchantButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache73, true);
		string name7 = "EventOnBreakNeedItemClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnBreakNeedItemClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache74, true);
		string name8 = "EventOnEnchantSaveButtonClick";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnEnchantSaveButtonClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache75, true);
		string name9 = "EventOnCrystalNotEnough";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache76, true);
		string name10 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_marginTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache78, true);
		string name11 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_returnButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7A, true);
		string name12 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_helpButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7C, true);
		string name13 = "m_enhanceToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceToggle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceToggle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7E, true);
		string name14 = "m_breakToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakToggle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakToggle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache80, true);
		string name15 = "m_enchantmentToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentToggle);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentToggle);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache82, true);
		string name16 = "m_enchantLockMaskButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantLockMaskButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantLockMaskButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache84, true);
		string name17 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_goldText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache86, true);
		string name18 = "m_goldAddButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_goldAddButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_goldAddButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache88, true);
		string name19 = "m_loopScrollView";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_loopScrollView);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_loopScrollView);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8A, true);
		string name20 = "m_listItemPool";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_listItemPool);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_listItemPool);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8C, true);
		string name21 = "m_listScrollViewItemRoot";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_listScrollViewItemRoot);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_listScrollViewItemRoot);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8E, true);
		string name22 = "m_enchantmentFilter";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentFilter);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentFilter);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache90, true);
		string name23 = "m_enchantmentfilterSortButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentfilterSortButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentfilterSortButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache92, true);
		string name24 = "m_enchantmentfilterSortTypeText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentfilterSortTypeText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentfilterSortTypeText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache94, true);
		string name25 = "m_enchantmentfilterSortTypesGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentfilterSortTypesGo);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentfilterSortTypesGo);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache96, true);
		string name26 = "m_enchantmentfilterSortTypesGridLayout";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentfilterSortTypesGridLayout);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentfilterSortTypesGridLayout);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache98, true);
		string name27 = "m_enchantmentfilterSortTypesAllToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentfilterSortTypesAllToggle);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentfilterSortTypesAllToggle);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9A, true);
		string name28 = "m_enhanceAndBreakFilter";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceAndBreakFilter);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceAndBreakFilter);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9C, true);
		string name29 = "m_filterSortButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_filterSortButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_filterSortButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9E, true);
		string name30 = "m_filterSortTypeText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_filterSortTypeText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_filterSortTypeText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA0, true);
		string name31 = "m_filterSortOrderButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_filterSortOrderButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_filterSortOrderButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA2, true);
		string name32 = "m_filterSortTypesGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_filterSortTypesGo);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_filterSortTypesGo);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA4, true);
		string name33 = "m_filterSortTypesGridLayout";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_filterSortTypesGridLayout);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_filterSortTypesGridLayout);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA6, true);
		string name34 = "m_listNoBreakItemGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_listNoBreakItemGo);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_listNoBreakItemGo);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA8, true);
		string name35 = "m_listNoEnchantmentItemGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_listNoEnchantmentItemGo);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_listNoEnchantmentItemGo);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAA, true);
		string name36 = "m_listTitleStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_listTitleStateCtrl);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_listTitleStateCtrl);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAC, true);
		string name37 = "m_listLongPressTipGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_listLongPressTipGo);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_listLongPressTipGo);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAE, true);
		string name38 = "m_descGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descGo);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descGo);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB0, true);
		string name39 = "m_descTitleText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descTitleText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descTitleText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB2, true);
		string name40 = "m_descIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descIcon);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descIcon);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB4, true);
		string name41 = "m_descIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descIconBg);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descIconBg);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB6, true);
		string name42 = "m_descSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSSREffect);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSSREffect);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB8, true);
		string name43 = "m_descStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descStarGroup);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descStarGroup);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBA, true);
		string name44 = "m_descLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descLvText);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descLvText);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBC, true);
		string name45 = "m_descExpText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descExpText);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descExpText);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBE, true);
		string name46 = "m_descProgressImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descProgressImage);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descProgressImage);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC0, true);
		string name47 = "m_descEquipLimitContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descEquipLimitContent);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descEquipLimitContent);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC2, true);
		string name48 = "m_descEquipUnlimitText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descEquipUnlimitText);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descEquipUnlimitText);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC4, true);
		string name49 = "m_descSkillContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillContent);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillContent);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC6, true);
		string name50 = "m_descSkillContentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillContentStateCtrl);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillContentStateCtrl);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC8, true);
		string name51 = "m_descUnlockCoditionText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descUnlockCoditionText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descUnlockCoditionText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCA, true);
		string name52 = "m_descSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillNameText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillNameText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCC, true);
		string name53 = "m_descSkillLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillLvText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillLvText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCE, true);
		string name54 = "m_descSkillOwnerText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillOwnerText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillOwnerText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD0, true);
		string name55 = "m_descSkillOwnerBGImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillOwnerBGImage);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillOwnerBGImage);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD2, true);
		string name56 = "m_descSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descSkillDescText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descSkillDescText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD4, true);
		string name57 = "m_descNotEquipSkillTip";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descNotEquipSkillTip);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descNotEquipSkillTip);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD6, true);
		string name58 = "m_descPropContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropContent);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropContent);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD8, true);
		string name59 = "m_descPropATGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropATGo);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropATGo);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDA, true);
		string name60 = "m_descPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropATValueText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropATValueText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDC, true);
		string name61 = "m_descPropDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropDFGo);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropDFGo);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDE, true);
		string name62 = "m_descPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropDFValueText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropDFValueText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE0, true);
		string name63 = "m_descPropHPGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropHPGo);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropHPGo);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE2, true);
		string name64 = "m_descPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropHPValueText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropHPValueText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE4, true);
		string name65 = "m_descPropMagiccGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropMagiccGo);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropMagiccGo);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE6, true);
		string name66 = "m_descPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropMagicValueText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropMagicValueText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE8, true);
		string name67 = "m_descPropMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropMagicDFGo);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropMagicDFGo);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEA, true);
		string name68 = "m_descPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropMagicDFValueText);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropMagicDFValueText);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEC, true);
		string name69 = "m_descPropDexGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropDexGo);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropDexGo);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEE, true);
		string name70 = "m_descPropDexValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropDexValueText);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropDexValueText);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF0, true);
		string name71 = "m_descPropGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropGroupStateCtrl);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropGroupStateCtrl);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF2, true);
		string name72 = "m_descPropEnchantmentGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropEnchantmentGroup);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropEnchantmentGroup);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF4, true);
		string name73 = "m_descPropEnchantmentGroupRuneStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropEnchantmentGroupRuneStateCtrl);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropEnchantmentGroupRuneStateCtrl);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF6, true);
		string name74 = "m_descPropEnchantmentGroupRuneIconImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropEnchantmentGroupRuneIconImage);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropEnchantmentGroupRuneIconImage);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF8, true);
		string name75 = "m_descPropEnchantmentGroupRuneNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_descPropEnchantmentGroupRuneNameText);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_descPropEnchantmentGroupRuneNameText);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFA, true);
		string name76 = "m_enhanceTitleText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceTitleText);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceTitleText);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFC, true);
		string name77 = "m_enhanceIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceIcon);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceIcon);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFE, true);
		string name78 = "m_enhanceIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceIconBg);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceIconBg);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache100, true);
		string name79 = "m_enhanceIconSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceIconSSREffect);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceIconSSREffect);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache102, true);
		string name80 = "m_enhanceStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceStarGroup);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceStarGroup);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache104, true);
		string name81 = "m_enhanceCurLv";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceCurLv);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache105;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceCurLv);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache106, true);
		string name82 = "m_enhanceCurLv1";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceCurLv1);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache107;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceCurLv1);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache108, true);
		string name83 = "m_enhanceMaxLV";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceMaxLV);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache109;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceMaxLV);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10A, true);
		string name84 = "m_enhanceProgressImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceProgressImage);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceProgressImage);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10C, true);
		string name85 = "m_enhanceWillGetExpImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceWillGetExpImage);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceWillGetExpImage);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10E, true);
		string name86 = "m_enhanceExpCurValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceExpCurValueText);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceExpCurValueText);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache110, true);
		string name87 = "m_enhanceExpAddValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceExpAddValueText);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceExpAddValueText);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache112, true);
		string name88 = "m_enhanceExpNextLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceExpNextLvText);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceExpNextLvText);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache114, true);
		string name89 = "m_enhanceMaterialsContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceMaterialsContent);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceMaterialsContent);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache116, true);
		string name90 = "m_enhanceGoldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceGoldText);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceGoldText);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache118, true);
		string name91 = "m_enhanceButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceButton);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceButton);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11A, true);
		string name92 = "m_enhanceSuccessEffectPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceSuccessEffectPanel);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceSuccessEffectPanel);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11C, true);
		string name93 = "m_enhanceSuccessEffectPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceSuccessEffectPanelCloseButton);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceSuccessEffectPanelCloseButton);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11E, true);
		string name94 = "m_enhanceConfirmPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceConfirmPanel);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceConfirmPanel);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache120, true);
		string name95 = "m_enhanceConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceConfirmButton);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceConfirmButton);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache122, true);
		string name96 = "m_enhanceCancelButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceCancelButton);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceCancelButton);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache124, true);
		string name97 = "m_enhanceConfirmPanelTip1";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceConfirmPanelTip1);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceConfirmPanelTip1);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache126, true);
		string name98 = "m_enhanceConfirmPanelTip2";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceConfirmPanelTip2);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceConfirmPanelTip2);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache128, true);
		string name99 = "m_enhanceItemSRConfirmPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceItemSRConfirmPanel);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceItemSRConfirmPanel);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12A, true);
		string name100 = "m_enhanceItemSRConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceItemSRConfirmButton);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceItemSRConfirmButton);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12C, true);
		string name101 = "m_enhanceItemSRCancelButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceItemSRCancelButton);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceItemSRCancelButton);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12E, true);
		string name102 = "m_enhanceItemSRTip";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceItemSRTip);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceItemSRTip);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache130, true);
		string name103 = "m_intensifySuccessPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelStateCtrl);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelStateCtrl);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache132, true);
		string name104 = "m_intensifySuccessPanelInfoStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelInfoStateCtrl);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache133;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelInfoStateCtrl);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache134, true);
		string name105 = "m_intensifySuccessPanelInfoIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelInfoIconBg);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache135;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelInfoIconBg);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache136, true);
		string name106 = "m_intensifySuccessPanelInfoIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelInfoIcon);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache137;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelInfoIcon);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache138, true);
		string name107 = "m_intensifySuccessPanelInfoStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelInfoStarGroup);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache139;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelInfoStarGroup);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13A, true);
		string name108 = "m_intensifySuccessPanelCurLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelCurLvText);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelCurLvText);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13C, true);
		string name109 = "m_intensifySuccessPanelNextLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelNextLvText);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelNextLvText);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13E, true);
		string name110 = "m_intensifySuccessPanelSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelSkillNameText);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache13F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelSkillNameText);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache140, true);
		string name111 = "m_intensifySuccessPanelSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelSkillDescText);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache141;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelSkillDescText);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache142, true);
		string name112 = "m_intensifySuccessPanelBlackButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_intensifySuccessPanelBlackButton);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache143;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_intensifySuccessPanelBlackButton);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache144, true);
		string name113 = "m_enhancePropGroupGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropGroupGo);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache145;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropGroupGo);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache146, true);
		string name114 = "m_enhancePropHpGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropHpGo);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache147;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropHpGo);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache148, true);
		string name115 = "m_enhancePropHpOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropHpOldValueText);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache149;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropHpOldValueText);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14A, true);
		string name116 = "m_enhancePropHpNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropHpNewValueText);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropHpNewValueText);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14C, true);
		string name117 = "m_enhancePropATGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropATGo);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropATGo);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14E, true);
		string name118 = "m_enhancePropATOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropATOldValueText);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache14F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropATOldValueText);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache150, true);
		string name119 = "m_enhancePropATNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropATNewValueText);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache151;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropATNewValueText);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache152, true);
		string name120 = "m_enhancePropDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropDFGo);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache153;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropDFGo);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache154, true);
		string name121 = "m_enhancePropDFOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropDFOldValueText);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache155;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropDFOldValueText);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache156, true);
		string name122 = "m_enhancePropDFNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropDFNewValueText);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache157;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropDFNewValueText);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache158, true);
		string name123 = "m_enhancePropMagicGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropMagicGo);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache159;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropMagicGo);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15A, true);
		string name124 = "m_enhancePropMagicOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropMagicOldValueText);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropMagicOldValueText);
		}
		LuaObject.addMember(l, name124, get124, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15C, true);
		string name125 = "m_enhancePropMagicNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropMagicNewValueText);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropMagicNewValueText);
		}
		LuaObject.addMember(l, name125, get125, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15E, true);
		string name126 = "m_enhancePropMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropMagicDFGo);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache15F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropMagicDFGo);
		}
		LuaObject.addMember(l, name126, get126, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache160, true);
		string name127 = "m_enhancePropMagicDFOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropMagicDFOldValueText);
		}
		LuaCSFunction get127 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache161;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropMagicDFOldValueText);
		}
		LuaObject.addMember(l, name127, get127, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache162, true);
		string name128 = "m_enhancePropMagicDFNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropMagicDFNewValueText);
		}
		LuaCSFunction get128 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache163;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropMagicDFNewValueText);
		}
		LuaObject.addMember(l, name128, get128, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache164, true);
		string name129 = "m_enhancePropDEXGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropDEXGo);
		}
		LuaCSFunction get129 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache165;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropDEXGo);
		}
		LuaObject.addMember(l, name129, get129, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache166, true);
		string name130 = "m_enhancePropDEXOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropDEXOldValueText);
		}
		LuaCSFunction get130 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache167;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropDEXOldValueText);
		}
		LuaObject.addMember(l, name130, get130, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache168, true);
		string name131 = "m_enhancePropDEXNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropDEXNewValueText);
		}
		LuaCSFunction get131 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache169;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropDEXNewValueText);
		}
		LuaObject.addMember(l, name131, get131, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16A, true);
		string name132 = "m_enhancePropSkillStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropSkillStateCtrl);
		}
		LuaCSFunction get132 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropSkillStateCtrl);
		}
		LuaObject.addMember(l, name132, get132, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16C, true);
		string name133 = "m_enhancePropSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropSkillNameText);
		}
		LuaCSFunction get133 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropSkillNameText);
		}
		LuaObject.addMember(l, name133, get133, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16E, true);
		string name134 = "m_enhancePropSkillOldValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropSkillOldValueText);
		}
		LuaCSFunction get134 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache16F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropSkillOldValueText);
		}
		LuaObject.addMember(l, name134, get134, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache170, true);
		string name135 = "m_enhancePropSkillNewValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropSkillNewValueText);
		}
		LuaCSFunction get135 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache171;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropSkillNewValueText);
		}
		LuaObject.addMember(l, name135, get135, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache172, true);
		string name136 = "m_enhancePropSkillConditionText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhancePropSkillConditionText);
		}
		LuaCSFunction get136 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache173;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhancePropSkillConditionText);
		}
		LuaObject.addMember(l, name136, get136, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache174, true);
		string name137 = "m_enhanceFastAddButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceFastAddButton);
		}
		LuaCSFunction get137 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache175;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceFastAddButton);
		}
		LuaObject.addMember(l, name137, get137, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache176, true);
		string name138 = "m_breakGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakGo);
		}
		LuaCSFunction get138 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache177;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakGo);
		}
		LuaObject.addMember(l, name138, get138, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache178, true);
		string name139 = "m_breakTitleText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakTitleText);
		}
		LuaCSFunction get139 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache179;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakTitleText);
		}
		LuaObject.addMember(l, name139, get139, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17A, true);
		string name140 = "m_breakCurLvEquipmentIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCurLvEquipmentIcon);
		}
		LuaCSFunction get140 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCurLvEquipmentIcon);
		}
		LuaObject.addMember(l, name140, get140, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17C, true);
		string name141 = "m_breakCurLvEquipmentIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCurLvEquipmentIconBg);
		}
		LuaCSFunction get141 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCurLvEquipmentIconBg);
		}
		LuaObject.addMember(l, name141, get141, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17E, true);
		string name142 = "m_breakCurLvEquipmentIconSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCurLvEquipmentIconSSREffect);
		}
		LuaCSFunction get142 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache17F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCurLvEquipmentIconSSREffect);
		}
		LuaObject.addMember(l, name142, get142, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache180, true);
		string name143 = "m_breakCurLvEquipmentStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCurLvEquipmentStarGroup);
		}
		LuaCSFunction get143 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache181;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCurLvEquipmentStarGroup);
		}
		LuaObject.addMember(l, name143, get143, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache182, true);
		string name144 = "m_breakCurLvEquipmentOldLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCurLvEquipmentOldLvText);
		}
		LuaCSFunction get144 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache183;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCurLvEquipmentOldLvText);
		}
		LuaObject.addMember(l, name144, get144, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache184, true);
		string name145 = "m_breakCurLvEquipmentMaxLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCurLvEquipmentMaxLvText);
		}
		LuaCSFunction get145 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache185;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCurLvEquipmentMaxLvText);
		}
		LuaObject.addMember(l, name145, get145, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache186, true);
		string name146 = "m_breakNextLvEquipmentIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakNextLvEquipmentIcon);
		}
		LuaCSFunction get146 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache187;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakNextLvEquipmentIcon);
		}
		LuaObject.addMember(l, name146, get146, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache188, true);
		string name147 = "m_breakNextLvEquipmentIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakNextLvEquipmentIconBg);
		}
		LuaCSFunction get147 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache189;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakNextLvEquipmentIconBg);
		}
		LuaObject.addMember(l, name147, get147, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18A, true);
		string name148 = "m_breakNextLvEquipmentIconSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakNextLvEquipmentIconSSREffect);
		}
		LuaCSFunction get148 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakNextLvEquipmentIconSSREffect);
		}
		LuaObject.addMember(l, name148, get148, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18C, true);
		string name149 = "m_breakNextLvEquipmentStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakNextLvEquipmentStarGroup);
		}
		LuaCSFunction get149 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakNextLvEquipmentStarGroup);
		}
		LuaObject.addMember(l, name149, get149, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18E, true);
		string name150 = "m_breakNextLvEquipmentOldLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakNextLvEquipmentOldLvText);
		}
		LuaCSFunction get150 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache18F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakNextLvEquipmentOldLvText);
		}
		LuaObject.addMember(l, name150, get150, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache190, true);
		string name151 = "m_breakNextLvEquipmentMaxLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakNextLvEquipmentMaxLvText);
		}
		LuaCSFunction get151 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache191;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakNextLvEquipmentMaxLvText);
		}
		LuaObject.addMember(l, name151, get151, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache192, true);
		string name152 = "m_breakMaterialIconGo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakMaterialIconGo);
		}
		LuaCSFunction get152 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache193;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakMaterialIconGo);
		}
		LuaObject.addMember(l, name152, get152, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache194, true);
		string name153 = "m_breakMaterialIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakMaterialIcon);
		}
		LuaCSFunction get153 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache195;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakMaterialIcon);
		}
		LuaObject.addMember(l, name153, get153, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache196, true);
		string name154 = "m_breakMaterialIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakMaterialIconBg);
		}
		LuaCSFunction get154 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache197;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakMaterialIconBg);
		}
		LuaObject.addMember(l, name154, get154, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache198, true);
		string name155 = "m_breakMaterialSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakMaterialSSREffect);
		}
		LuaCSFunction get155 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache199;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakMaterialSSREffect);
		}
		LuaObject.addMember(l, name155, get155, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19A, true);
		string name156 = "m_breakItemsContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakItemsContent);
		}
		LuaCSFunction get156 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakItemsContent);
		}
		LuaObject.addMember(l, name156, get156, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19C, true);
		string name157 = "m_breakGoldText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakGoldText);
		}
		LuaCSFunction get157 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakGoldText);
		}
		LuaObject.addMember(l, name157, get157, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19E, true);
		string name158 = "m_breakButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakButton);
		}
		LuaCSFunction get158 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache19F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakButton);
		}
		LuaObject.addMember(l, name158, get158, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A0, true);
		string name159 = "m_breakCantIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCantIcon);
		}
		LuaCSFunction get159 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCantIcon);
		}
		LuaObject.addMember(l, name159, get159, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A2, true);
		string name160 = "m_breakCantIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCantIconBg);
		}
		LuaCSFunction get160 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCantIconBg);
		}
		LuaObject.addMember(l, name160, get160, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A4, true);
		string name161 = "m_breakCantStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCantStarGroup);
		}
		LuaCSFunction get161 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCantStarGroup);
		}
		LuaObject.addMember(l, name161, get161, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A6, true);
		string name162 = "m_breakCantTitleText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakCantTitleText);
		}
		LuaCSFunction get162 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakCantTitleText);
		}
		LuaObject.addMember(l, name162, get162, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A8, true);
		string name163 = "m_breakSuccessPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessPanel);
		}
		LuaCSFunction get163 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1A9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessPanel);
		}
		LuaObject.addMember(l, name163, get163, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AA, true);
		string name164 = "m_breakSuccessPanelBlackButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessPanelBlackButton);
		}
		LuaCSFunction get164 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessPanelBlackButton);
		}
		LuaObject.addMember(l, name164, get164, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AC, true);
		string name165 = "m_breakSuccessInfoIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoIconBg);
		}
		LuaCSFunction get165 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoIconBg);
		}
		LuaObject.addMember(l, name165, get165, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AE, true);
		string name166 = "m_breakSuccessInfoIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoIcon);
		}
		LuaCSFunction get166 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1AF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoIcon);
		}
		LuaObject.addMember(l, name166, get166, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B0, true);
		string name167 = "m_breakSuccessInfoStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoStarGroup);
		}
		LuaCSFunction get167 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoStarGroup);
		}
		LuaObject.addMember(l, name167, get167, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B2, true);
		string name168 = "m_breakSuccessInfoCurOldLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoCurOldLvText);
		}
		LuaCSFunction get168 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoCurOldLvText);
		}
		LuaObject.addMember(l, name168, get168, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B4, true);
		string name169 = "m_breakSuccessInfoCurMaxLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoCurMaxLvText);
		}
		LuaCSFunction get169 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoCurMaxLvText);
		}
		LuaObject.addMember(l, name169, get169, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B6, true);
		string name170 = "m_breakSuccessInfoNextOldLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoNextOldLvText);
		}
		LuaCSFunction get170 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoNextOldLvText);
		}
		LuaObject.addMember(l, name170, get170, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B8, true);
		string name171 = "m_breakSuccessInfoNextMaxLvText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_breakSuccessInfoNextMaxLvText);
		}
		LuaCSFunction get171 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1B9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_breakSuccessInfoNextMaxLvText);
		}
		LuaObject.addMember(l, name171, get171, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BA, true);
		string name172 = "m_enchantmentItemNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentItemNameText);
		}
		LuaCSFunction get172 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentItemNameText);
		}
		LuaObject.addMember(l, name172, get172, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BC, true);
		string name173 = "m_enchantmentItemLevelValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentItemLevelValueText);
		}
		LuaCSFunction get173 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentItemLevelValueText);
		}
		LuaObject.addMember(l, name173, get173, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BE, true);
		string name174 = "m_enchantmentIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentIcon);
		}
		LuaCSFunction get174 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1BF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentIcon);
		}
		LuaObject.addMember(l, name174, get174, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C0, true);
		string name175 = "m_enchantmentIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentIconBg);
		}
		LuaCSFunction get175 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentIconBg);
		}
		LuaObject.addMember(l, name175, get175, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C2, true);
		string name176 = "m_enchantmentIconSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentIconSSREffect);
		}
		LuaCSFunction get176 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentIconSSREffect);
		}
		LuaObject.addMember(l, name176, get176, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C4, true);
		string name177 = "m_enchantmentStarGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStarGroup);
		}
		LuaCSFunction get177 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStarGroup);
		}
		LuaObject.addMember(l, name177, get177, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C6, true);
		string name178 = "m_enchantmentEnchantPropertyGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentEnchantPropertyGroup);
		}
		LuaCSFunction get178 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentEnchantPropertyGroup);
		}
		LuaObject.addMember(l, name178, get178, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C8, true);
		string name179 = "m_enchantmentEnchantPropertyGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentEnchantPropertyGroupStateCtrl);
		}
		LuaCSFunction get179 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1C9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentEnchantPropertyGroupStateCtrl);
		}
		LuaObject.addMember(l, name179, get179, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CA, true);
		string name180 = "m_enchantmentSuitInfoStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoStateCtrl);
		}
		LuaCSFunction get180 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoStateCtrl);
		}
		LuaObject.addMember(l, name180, get180, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CC, true);
		string name181 = "m_enchantmentSuitInfoGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoGroupStateCtrl);
		}
		LuaCSFunction get181 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoGroupStateCtrl);
		}
		LuaObject.addMember(l, name181, get181, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CE, true);
		string name182 = "m_enchantmentSuitInfoNowEffectStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectStateCtrl);
		}
		LuaCSFunction get182 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1CF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectStateCtrl);
		}
		LuaObject.addMember(l, name182, get182, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D0, true);
		string name183 = "m_enchantmentSuitInfoNowEffectRuneIconStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectRuneIconStateCtrl);
		}
		LuaCSFunction get183 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectRuneIconStateCtrl);
		}
		LuaObject.addMember(l, name183, get183, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D2, true);
		string name184 = "m_enchantmentSuitInfoNowEffectRuneActiveIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectRuneActiveIcon);
		}
		LuaCSFunction get184 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectRuneActiveIcon);
		}
		LuaObject.addMember(l, name184, get184, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D4, true);
		string name185 = "m_enchantmentSuitInfoNowEffectRuneUnactiveIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectRuneUnactiveIcon);
		}
		LuaCSFunction get185 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectRuneUnactiveIcon);
		}
		LuaObject.addMember(l, name185, get185, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D6, true);
		string name186 = "m_enchantmentSuitInfoNowEffectRuneNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectRuneNameText);
		}
		LuaCSFunction get186 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectRuneNameText);
		}
		LuaObject.addMember(l, name186, get186, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D8, true);
		string name187 = "m_enchantmentSuitInfoNowEffectRune2SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectRune2SuitInfoText);
		}
		LuaCSFunction get187 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1D9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectRune2SuitInfoText);
		}
		LuaObject.addMember(l, name187, get187, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DA, true);
		string name188 = "m_enchantmentSuitInfoNowEffectRune4SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoNowEffectRune4SuitInfoText);
		}
		LuaCSFunction get188 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoNowEffectRune4SuitInfoText);
		}
		LuaObject.addMember(l, name188, get188, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DC, true);
		string name189 = "m_enchantmentSuitInfoAfterEffectStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoAfterEffectStateCtrl);
		}
		LuaCSFunction get189 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoAfterEffectStateCtrl);
		}
		LuaObject.addMember(l, name189, get189, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DE, true);
		string name190 = "m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon);
		}
		LuaCSFunction get190 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1DF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon);
		}
		LuaObject.addMember(l, name190, get190, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E0, true);
		string name191 = "m_enchantmentSuitInfoAfterEffectRuneNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoAfterEffectRuneNameText);
		}
		LuaCSFunction get191 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoAfterEffectRuneNameText);
		}
		LuaObject.addMember(l, name191, get191, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E2, true);
		string name192 = "m_enchantmentSuitInfoAfterEffectRune2SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoAfterEffectRune2SuitInfoText);
		}
		LuaCSFunction get192 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoAfterEffectRune2SuitInfoText);
		}
		LuaObject.addMember(l, name192, get192, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E4, true);
		string name193 = "m_enchantmentSuitInfoAfterEffectRune4SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentSuitInfoAfterEffectRune4SuitInfoText);
		}
		LuaCSFunction get193 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentSuitInfoAfterEffectRune4SuitInfoText);
		}
		LuaObject.addMember(l, name193, get193, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E6, true);
		string name194 = "m_enchantmentMaterialGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentMaterialGroupStateCtrl);
		}
		LuaCSFunction get194 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentMaterialGroupStateCtrl);
		}
		LuaObject.addMember(l, name194, get194, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E8, true);
		string name195 = "m_enchantmentStoneIconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStoneIconBg);
		}
		LuaCSFunction get195 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1E9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStoneIconBg);
		}
		LuaObject.addMember(l, name195, get195, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EA, true);
		string name196 = "m_enchantmentStoneIcon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStoneIcon);
		}
		LuaCSFunction get196 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStoneIcon);
		}
		LuaObject.addMember(l, name196, get196, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EC, true);
		string name197 = "m_enchantmentStoneNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1ED == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1ED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStoneNameText);
		}
		LuaCSFunction get197 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1ED;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStoneNameText);
		}
		LuaObject.addMember(l, name197, get197, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EE, true);
		string name198 = "m_enchantmentStoneDescText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStoneDescText);
		}
		LuaCSFunction get198 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1EF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStoneDescText);
		}
		LuaObject.addMember(l, name198, get198, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F0, true);
		string name199 = "m_enchantmentStoneValueGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStoneValueGroupStateCtrl);
		}
		LuaCSFunction get199 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F1;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStoneValueGroupStateCtrl);
		}
		LuaObject.addMember(l, name199, get199, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F2, true);
		string name200 = "m_enchantmentStoneHaveCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentStoneHaveCount);
		}
		LuaCSFunction get200 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F3;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentStoneHaveCount);
		}
		LuaObject.addMember(l, name200, get200, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F4, true);
		string name201 = "m_enchantmentGoldenValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentGoldenValueText);
		}
		LuaCSFunction get201 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F5;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentGoldenValueText);
		}
		LuaObject.addMember(l, name201, get201, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F6, true);
		string name202 = "m_enchantmentGoldenValueTextStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentGoldenValueTextStateCtrl);
		}
		LuaCSFunction get202 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F7;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentGoldenValueTextStateCtrl);
		}
		LuaObject.addMember(l, name202, get202, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F8, true);
		string name203 = "m_enchantmentButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentButton);
		}
		LuaCSFunction get203 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1F9;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentButton);
		}
		LuaObject.addMember(l, name203, get203, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FA, true);
		string name204 = "m_enchantKeepPropertyGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantKeepPropertyGroup);
		}
		LuaCSFunction get204 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FB;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantKeepPropertyGroup);
		}
		LuaObject.addMember(l, name204, get204, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FC, true);
		string name205 = "m_enchantSuccessEffectPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantSuccessEffectPanel);
		}
		LuaCSFunction get205 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FD;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantSuccessEffectPanel);
		}
		LuaObject.addMember(l, name205, get205, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FE, true);
		string name206 = "m_enchantmentResultPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelStateCtrl);
		}
		LuaCSFunction get206 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache1FF;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache200 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache200 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelStateCtrl);
		}
		LuaObject.addMember(l, name206, get206, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache200, true);
		string name207 = "m_enchantmentResultPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache201 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache201 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelCloseButton);
		}
		LuaCSFunction get207 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache201;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache202 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache202 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelCloseButton);
		}
		LuaObject.addMember(l, name207, get207, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache202, true);
		string name208 = "m_enchantmentResultPanelOldPropretyGroup";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache203 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache203 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelOldPropretyGroup);
		}
		LuaCSFunction get208 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache203;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache204 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache204 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelOldPropretyGroup);
		}
		LuaObject.addMember(l, name208, get208, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache204, true);
		string name209 = "m_enchantmentResultPanelOldSuitInfoStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache205 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache205 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelOldSuitInfoStateCtrl);
		}
		LuaCSFunction get209 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache205;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache206 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache206 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelOldSuitInfoStateCtrl);
		}
		LuaObject.addMember(l, name209, get209, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache206, true);
		string name210 = "m_enchantmentResultPanelOldSuitInfoNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache207 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache207 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelOldSuitInfoNameText);
		}
		LuaCSFunction get210 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache207;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache208 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache208 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelOldSuitInfoNameText);
		}
		LuaObject.addMember(l, name210, get210, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache208, true);
		string name211 = "m_enchantmentResultPanelOld2SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache209 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache209 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelOld2SuitInfoText);
		}
		LuaCSFunction get211 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache209;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelOld2SuitInfoText);
		}
		LuaObject.addMember(l, name211, get211, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20A, true);
		string name212 = "m_enchantmentResultPanelOld4SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelOld4SuitInfoText);
		}
		LuaCSFunction get212 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelOld4SuitInfoText);
		}
		LuaObject.addMember(l, name212, get212, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20C, true);
		string name213 = "m_enchantmentResultPanelNewProprety1StateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety1StateCtrl);
		}
		LuaCSFunction get213 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety1StateCtrl);
		}
		LuaObject.addMember(l, name213, get213, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20E, true);
		string name214 = "m_enchantmentResultPanelNewProprety1ProgressBar";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety1ProgressBar);
		}
		LuaCSFunction get214 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache20F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache210 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache210 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety1ProgressBar);
		}
		LuaObject.addMember(l, name214, get214, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache210, true);
		string name215 = "m_enchantmentResultPanelNewProprety1NameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache211 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache211 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety1NameText);
		}
		LuaCSFunction get215 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache211;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache212 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache212 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety1NameText);
		}
		LuaObject.addMember(l, name215, get215, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache212, true);
		string name216 = "m_enchantmentResultPanelNewProprety1ValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache213 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache213 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety1ValueText);
		}
		LuaCSFunction get216 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache213;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache214 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache214 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety1ValueText);
		}
		LuaObject.addMember(l, name216, get216, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache214, true);
		string name217 = "m_enchantmentResultPanelNewProprety2StateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache215 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache215 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety2StateCtrl);
		}
		LuaCSFunction get217 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache215;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache216 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache216 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety2StateCtrl);
		}
		LuaObject.addMember(l, name217, get217, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache216, true);
		string name218 = "m_enchantmentResultPanelNewProprety2ProgressBar";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache217 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache217 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety2ProgressBar);
		}
		LuaCSFunction get218 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache217;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache218 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache218 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety2ProgressBar);
		}
		LuaObject.addMember(l, name218, get218, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache218, true);
		string name219 = "m_enchantmentResultPanelNewProprety2NameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache219 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache219 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety2NameText);
		}
		LuaCSFunction get219 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache219;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety2NameText);
		}
		LuaObject.addMember(l, name219, get219, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21A, true);
		string name220 = "m_enchantmentResultPanelNewProprety2ValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety2ValueText);
		}
		LuaCSFunction get220 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety2ValueText);
		}
		LuaObject.addMember(l, name220, get220, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21C, true);
		string name221 = "m_enchantmentResultPanelNewProprety3StateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety3StateCtrl);
		}
		LuaCSFunction get221 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety3StateCtrl);
		}
		LuaObject.addMember(l, name221, get221, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21E, true);
		string name222 = "m_enchantmentResultPanelNewProprety3ProgressBar";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety3ProgressBar);
		}
		LuaCSFunction get222 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache21F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache220 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache220 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety3ProgressBar);
		}
		LuaObject.addMember(l, name222, get222, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache220, true);
		string name223 = "m_enchantmentResultPanelNewProprety3NameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache221 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache221 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety3NameText);
		}
		LuaCSFunction get223 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache221;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache222 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache222 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety3NameText);
		}
		LuaObject.addMember(l, name223, get223, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache222, true);
		string name224 = "m_enchantmentResultPanelNewProprety3ValueText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache223 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache223 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewProprety3ValueText);
		}
		LuaCSFunction get224 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache223;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache224 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache224 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewProprety3ValueText);
		}
		LuaObject.addMember(l, name224, get224, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache224, true);
		string name225 = "m_enchantmentResultPanelNewSuitInfoNameText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache225 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache225 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNewSuitInfoNameText);
		}
		LuaCSFunction get225 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache225;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache226 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache226 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNewSuitInfoNameText);
		}
		LuaObject.addMember(l, name225, get225, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache226, true);
		string name226 = "m_enchantmentResultPanelNew2SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache227 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache227 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNew2SuitInfoText);
		}
		LuaCSFunction get226 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache227;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache228 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache228 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNew2SuitInfoText);
		}
		LuaObject.addMember(l, name226, get226, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache228, true);
		string name227 = "m_enchantmentResultPanelNew4SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache229 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache229 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNew4SuitInfoText);
		}
		LuaCSFunction get227 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache229;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNew4SuitInfoText);
		}
		LuaObject.addMember(l, name227, get227, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22A, true);
		string name228 = "m_enchantmentResultPanelEnchantmentAgainButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelEnchantmentAgainButton);
		}
		LuaCSFunction get228 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelEnchantmentAgainButton);
		}
		LuaObject.addMember(l, name228, get228, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22C, true);
		string name229 = "m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl);
		}
		LuaCSFunction get229 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl);
		}
		LuaObject.addMember(l, name229, get229, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22E, true);
		string name230 = "m_enchantmentResultPanelNumberText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelNumberText);
		}
		LuaCSFunction get230 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache22F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache230 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache230 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelNumberText);
		}
		LuaObject.addMember(l, name230, get230, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache230, true);
		string name231 = "m_enchantmentResultPanelGoldenNumberText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache231 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache231 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelGoldenNumberText);
		}
		LuaCSFunction get231 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache231;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache232 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache232 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelGoldenNumberText);
		}
		LuaObject.addMember(l, name231, get231, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache232, true);
		string name232 = "m_enchantmentResultPanelGoldenNumberStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache233 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache233 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelGoldenNumberStateCtrl);
		}
		LuaCSFunction get232 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache233;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache234 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache234 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelGoldenNumberStateCtrl);
		}
		LuaObject.addMember(l, name232, get232, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache234, true);
		string name233 = "m_enchantmentResultPanelItemImage";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache235 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache235 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelItemImage);
		}
		LuaCSFunction get233 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache235;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache236 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache236 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelItemImage);
		}
		LuaObject.addMember(l, name233, get233, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache236, true);
		string name234 = "m_enchantmentResultPanelSavePropretyButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache237 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache237 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelSavePropretyButton);
		}
		LuaCSFunction get234 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache237;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache238 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache238 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelSavePropretyButton);
		}
		LuaObject.addMember(l, name234, get234, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache238, true);
		string name235 = "m_enchantmentResultPanelContinueButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache239 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache239 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantmentResultPanelContinueButton);
		}
		LuaCSFunction get235 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache239;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantmentResultPanelContinueButton);
		}
		LuaObject.addMember(l, name235, get235, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23A, true);
		string name236 = "m_savePropretyPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_savePropretyPanelStateCtrl);
		}
		LuaCSFunction get236 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_savePropretyPanelStateCtrl);
		}
		LuaObject.addMember(l, name236, get236, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23C, true);
		string name237 = "m_savePropretyPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_savePropretyPanelCancelButton);
		}
		LuaCSFunction get237 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_savePropretyPanelCancelButton);
		}
		LuaObject.addMember(l, name237, get237, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23E, true);
		string name238 = "m_savePropretyPanelComfirmButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_savePropretyPanelComfirmButton);
		}
		LuaCSFunction get238 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache23F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache240 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache240 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_savePropretyPanelComfirmButton);
		}
		LuaObject.addMember(l, name238, get238, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache240, true);
		string name239 = "m_savePropretyPanelToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache241 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache241 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_savePropretyPanelToggle);
		}
		LuaCSFunction get239 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache241;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache242 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache242 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_savePropretyPanelToggle);
		}
		LuaObject.addMember(l, name239, get239, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache242, true);
		string name240 = "m_cancelPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache243 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache243 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_cancelPanelStateCtrl);
		}
		LuaCSFunction get240 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache243;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache244 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache244 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_cancelPanelStateCtrl);
		}
		LuaObject.addMember(l, name240, get240, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache244, true);
		string name241 = "m_cancelPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache245 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache245 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_cancelPanelCancelButton);
		}
		LuaCSFunction get241 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache245;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache246 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache246 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_cancelPanelCancelButton);
		}
		LuaObject.addMember(l, name241, get241, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache246, true);
		string name242 = "m_cancelPanelComfirmButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache247 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache247 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_cancelPanelComfirmButton);
		}
		LuaCSFunction get242 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache247;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache248 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache248 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_cancelPanelComfirmButton);
		}
		LuaObject.addMember(l, name242, get242, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache248, true);
		string name243 = "m_cancelPanelToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache249 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache249 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_cancelPanelToggle);
		}
		LuaCSFunction get243 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache249;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_cancelPanelToggle);
		}
		LuaObject.addMember(l, name243, get243, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24A, true);
		string name244 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_playerContext);
		}
		LuaCSFunction get244 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name244, get244, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24C, true);
		string name245 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_configDataLoader);
		}
		LuaCSFunction get245 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name245, get245, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24E, true);
		string name246 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_slot);
		}
		LuaCSFunction get246 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache24F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache250 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache250 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_slot);
		}
		LuaObject.addMember(l, name246, get246, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache250, true);
		string name247 = "m_isAscend";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache251 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache251 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_isAscend);
		}
		LuaCSFunction get247 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache251;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache252 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache252 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_isAscend);
		}
		LuaObject.addMember(l, name247, get247, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache252, true);
		string name248 = "m_isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache253 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache253 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_isFirstIn);
		}
		LuaCSFunction get248 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache253;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache254 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache254 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_isFirstIn);
		}
		LuaObject.addMember(l, name248, get248, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache254, true);
		string name249 = "m_isToggleChanged";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache255 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache255 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_isToggleChanged);
		}
		LuaCSFunction get249 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache255;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache256 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache256 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_isToggleChanged);
		}
		LuaObject.addMember(l, name249, get249, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache256, true);
		string name250 = "m_curForgeState";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache257 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache257 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curForgeState);
		}
		LuaCSFunction get250 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache257;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache258 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache258 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curForgeState);
		}
		LuaObject.addMember(l, name250, get250, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache258, true);
		string name251 = "m_curEquipmentInstanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache259 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache259 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curEquipmentInstanceId);
		}
		LuaCSFunction get251 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache259;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curEquipmentInstanceId);
		}
		LuaObject.addMember(l, name251, get251, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25A, true);
		string name252 = "m_curBreakMaterialEquipmentId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curBreakMaterialEquipmentId);
		}
		LuaCSFunction get252 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curBreakMaterialEquipmentId);
		}
		LuaObject.addMember(l, name252, get252, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25C, true);
		string name253 = "m_curAddEnhanceEquipmentInstanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curAddEnhanceEquipmentInstanceId);
		}
		LuaCSFunction get253 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curAddEnhanceEquipmentInstanceId);
		}
		LuaObject.addMember(l, name253, get253, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25E, true);
		string name254 = "m_curSelectEnchantStoneItem";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curSelectEnchantStoneItem);
		}
		LuaCSFunction get254 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache25F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache260 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache260 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curSelectEnchantStoneItem);
		}
		LuaObject.addMember(l, name254, get254, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache260, true);
		string name255 = "m_lastSelectEnchantStoneInfo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache261 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache261 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_lastSelectEnchantStoneInfo);
		}
		LuaCSFunction get255 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache261;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache262 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache262 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_lastSelectEnchantStoneInfo);
		}
		LuaObject.addMember(l, name255, get255, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache262, true);
		string name256 = "m_enhanceEquipmentInstanceIds";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache263 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache263 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enhanceEquipmentInstanceIds);
		}
		LuaCSFunction get256 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache263;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache264 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache264 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enhanceEquipmentInstanceIds);
		}
		LuaObject.addMember(l, name256, get256, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache264, true);
		string name257 = "m_equipmentItemCache";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache265 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache265 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_equipmentItemCache);
		}
		LuaCSFunction get257 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache265;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache266 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache266 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_equipmentItemCache);
		}
		LuaObject.addMember(l, name257, get257, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache266, true);
		string name258 = "m_enchantStoneItemCache";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache267 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache267 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_enchantStoneItemCache);
		}
		LuaCSFunction get258 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache267;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache268 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache268 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_enchantStoneItemCache);
		}
		LuaObject.addMember(l, name258, get258, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache268, true);
		string name259 = "m_equipmentForgeCtrlList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache269 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache269 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_equipmentForgeCtrlList);
		}
		LuaCSFunction get259 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache269;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_equipmentForgeCtrlList);
		}
		LuaObject.addMember(l, name259, get259, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26A, true);
		string name260 = "m_curEquipmentSortType";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curEquipmentSortType);
		}
		LuaCSFunction get260 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curEquipmentSortType);
		}
		LuaObject.addMember(l, name260, get260, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26C, true);
		string name261 = "m_curEnchantmentSortTypeId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_curEnchantmentSortTypeId);
		}
		LuaCSFunction get261 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_curEnchantmentSortTypeId);
		}
		LuaObject.addMember(l, name261, get261, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26E, true);
		string name262 = "m_properties";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_properties);
		}
		LuaCSFunction get262 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache26F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache270 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache270 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_properties);
		}
		LuaObject.addMember(l, name262, get262, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache270, true);
		string name263 = "m_isAfter3DTouch";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache271 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache271 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_isAfter3DTouch);
		}
		LuaCSFunction get263 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache271;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache272 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache272 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_isAfter3DTouch);
		}
		LuaObject.addMember(l, name263, get263, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache272, true);
		string name264 = "m_oldSkillLevelStr";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache273 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache273 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.get_m_oldSkillLevelStr);
		}
		LuaCSFunction get264 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache273;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache274 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache274 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.set_m_oldSkillLevelStr);
		}
		LuaObject.addMember(l, name264, get264, Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.<>f__mg$cache274, true);
		LuaObject.createTypeMetatable(l, null, typeof(EquipmentForgeUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013911 RID: 80145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013912 RID: 80146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013913 RID: 80147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013914 RID: 80148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013915 RID: 80149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013916 RID: 80150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013917 RID: 80151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013918 RID: 80152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013919 RID: 80153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401391A RID: 80154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401391B RID: 80155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401391C RID: 80156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401391D RID: 80157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401391E RID: 80158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401391F RID: 80159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013920 RID: 80160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013921 RID: 80161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013922 RID: 80162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013923 RID: 80163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013924 RID: 80164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013925 RID: 80165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013926 RID: 80166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013927 RID: 80167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013928 RID: 80168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013929 RID: 80169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401392A RID: 80170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401392B RID: 80171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401392C RID: 80172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401392D RID: 80173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401392E RID: 80174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401392F RID: 80175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013930 RID: 80176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013931 RID: 80177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013932 RID: 80178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013933 RID: 80179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013934 RID: 80180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013935 RID: 80181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013936 RID: 80182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013937 RID: 80183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013938 RID: 80184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013939 RID: 80185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401393A RID: 80186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401393B RID: 80187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401393C RID: 80188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401393D RID: 80189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401393E RID: 80190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401393F RID: 80191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013940 RID: 80192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013941 RID: 80193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013942 RID: 80194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013943 RID: 80195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013944 RID: 80196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013945 RID: 80197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013946 RID: 80198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013947 RID: 80199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013948 RID: 80200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013949 RID: 80201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401394A RID: 80202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401394B RID: 80203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401394C RID: 80204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401394D RID: 80205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401394E RID: 80206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401394F RID: 80207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013950 RID: 80208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013951 RID: 80209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013952 RID: 80210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013953 RID: 80211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013954 RID: 80212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013955 RID: 80213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013956 RID: 80214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013957 RID: 80215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013958 RID: 80216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013959 RID: 80217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401395A RID: 80218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401395B RID: 80219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401395C RID: 80220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401395D RID: 80221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401395E RID: 80222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401395F RID: 80223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013960 RID: 80224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013961 RID: 80225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013962 RID: 80226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013963 RID: 80227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013964 RID: 80228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013965 RID: 80229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013966 RID: 80230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013967 RID: 80231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013968 RID: 80232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013969 RID: 80233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401396A RID: 80234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401396B RID: 80235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401396C RID: 80236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401396D RID: 80237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401396E RID: 80238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401396F RID: 80239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013970 RID: 80240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013971 RID: 80241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013972 RID: 80242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013973 RID: 80243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013974 RID: 80244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013975 RID: 80245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013976 RID: 80246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013977 RID: 80247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013978 RID: 80248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013979 RID: 80249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401397A RID: 80250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401397B RID: 80251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401397C RID: 80252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401397D RID: 80253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401397E RID: 80254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401397F RID: 80255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04013980 RID: 80256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04013981 RID: 80257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04013982 RID: 80258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013983 RID: 80259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013984 RID: 80260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013985 RID: 80261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013986 RID: 80262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013987 RID: 80263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013988 RID: 80264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04013989 RID: 80265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401398A RID: 80266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401398B RID: 80267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401398C RID: 80268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401398D RID: 80269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401398E RID: 80270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401398F RID: 80271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04013990 RID: 80272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04013991 RID: 80273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04013992 RID: 80274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04013993 RID: 80275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013994 RID: 80276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013995 RID: 80277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013996 RID: 80278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013997 RID: 80279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04013998 RID: 80280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04013999 RID: 80281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401399A RID: 80282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401399B RID: 80283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401399C RID: 80284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401399D RID: 80285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401399E RID: 80286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401399F RID: 80287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040139A0 RID: 80288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040139A1 RID: 80289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040139A2 RID: 80290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040139A3 RID: 80291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040139A4 RID: 80292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040139A5 RID: 80293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040139A6 RID: 80294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040139A7 RID: 80295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040139A8 RID: 80296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040139A9 RID: 80297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040139AA RID: 80298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040139AB RID: 80299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040139AC RID: 80300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040139AD RID: 80301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040139AE RID: 80302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040139AF RID: 80303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040139B0 RID: 80304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040139B1 RID: 80305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040139B2 RID: 80306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040139B3 RID: 80307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040139B4 RID: 80308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040139B5 RID: 80309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040139B6 RID: 80310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040139B7 RID: 80311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040139B8 RID: 80312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040139B9 RID: 80313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040139BA RID: 80314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040139BB RID: 80315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040139BC RID: 80316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040139BD RID: 80317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040139BE RID: 80318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040139BF RID: 80319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040139C0 RID: 80320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040139C1 RID: 80321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040139C2 RID: 80322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040139C3 RID: 80323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040139C4 RID: 80324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040139C5 RID: 80325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040139C6 RID: 80326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040139C7 RID: 80327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040139C8 RID: 80328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040139C9 RID: 80329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040139CA RID: 80330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040139CB RID: 80331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040139CC RID: 80332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040139CD RID: 80333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040139CE RID: 80334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040139CF RID: 80335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040139D0 RID: 80336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040139D1 RID: 80337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040139D2 RID: 80338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040139D3 RID: 80339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040139D4 RID: 80340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040139D5 RID: 80341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040139D6 RID: 80342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040139D7 RID: 80343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040139D8 RID: 80344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040139D9 RID: 80345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040139DA RID: 80346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040139DB RID: 80347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040139DC RID: 80348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040139DD RID: 80349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040139DE RID: 80350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040139DF RID: 80351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040139E0 RID: 80352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040139E1 RID: 80353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040139E2 RID: 80354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040139E3 RID: 80355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040139E4 RID: 80356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040139E5 RID: 80357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040139E6 RID: 80358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040139E7 RID: 80359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040139E8 RID: 80360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040139E9 RID: 80361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040139EA RID: 80362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040139EB RID: 80363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040139EC RID: 80364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040139ED RID: 80365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040139EE RID: 80366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040139EF RID: 80367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040139F0 RID: 80368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040139F1 RID: 80369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040139F2 RID: 80370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040139F3 RID: 80371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040139F4 RID: 80372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040139F5 RID: 80373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040139F6 RID: 80374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040139F7 RID: 80375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040139F8 RID: 80376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040139F9 RID: 80377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040139FA RID: 80378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040139FB RID: 80379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040139FC RID: 80380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040139FD RID: 80381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040139FE RID: 80382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040139FF RID: 80383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04013A00 RID: 80384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04013A01 RID: 80385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04013A02 RID: 80386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04013A03 RID: 80387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04013A04 RID: 80388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04013A05 RID: 80389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04013A06 RID: 80390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04013A07 RID: 80391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04013A08 RID: 80392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04013A09 RID: 80393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04013A0A RID: 80394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04013A0B RID: 80395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x04013A0C RID: 80396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x04013A0D RID: 80397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04013A0E RID: 80398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04013A0F RID: 80399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x04013A10 RID: 80400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x04013A11 RID: 80401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04013A12 RID: 80402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04013A13 RID: 80403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04013A14 RID: 80404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04013A15 RID: 80405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04013A16 RID: 80406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04013A17 RID: 80407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04013A18 RID: 80408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04013A19 RID: 80409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04013A1A RID: 80410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04013A1B RID: 80411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04013A1C RID: 80412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04013A1D RID: 80413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04013A1E RID: 80414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04013A1F RID: 80415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x04013A20 RID: 80416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x04013A21 RID: 80417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x04013A22 RID: 80418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04013A23 RID: 80419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04013A24 RID: 80420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04013A25 RID: 80421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04013A26 RID: 80422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04013A27 RID: 80423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04013A28 RID: 80424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04013A29 RID: 80425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04013A2A RID: 80426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04013A2B RID: 80427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04013A2C RID: 80428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04013A2D RID: 80429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x04013A2E RID: 80430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x04013A2F RID: 80431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x04013A30 RID: 80432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x04013A31 RID: 80433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x04013A32 RID: 80434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x04013A33 RID: 80435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x04013A34 RID: 80436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x04013A35 RID: 80437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x04013A36 RID: 80438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x04013A37 RID: 80439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04013A38 RID: 80440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04013A39 RID: 80441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04013A3A RID: 80442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04013A3B RID: 80443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04013A3C RID: 80444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x04013A3D RID: 80445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x04013A3E RID: 80446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x04013A3F RID: 80447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x04013A40 RID: 80448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x04013A41 RID: 80449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x04013A42 RID: 80450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x04013A43 RID: 80451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x04013A44 RID: 80452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x04013A45 RID: 80453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x04013A46 RID: 80454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x04013A47 RID: 80455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x04013A48 RID: 80456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x04013A49 RID: 80457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04013A4A RID: 80458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04013A4B RID: 80459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04013A4C RID: 80460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04013A4D RID: 80461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x04013A4E RID: 80462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x04013A4F RID: 80463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x04013A50 RID: 80464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x04013A51 RID: 80465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x04013A52 RID: 80466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x04013A53 RID: 80467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x04013A54 RID: 80468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x04013A55 RID: 80469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x04013A56 RID: 80470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x04013A57 RID: 80471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x04013A58 RID: 80472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x04013A59 RID: 80473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x04013A5A RID: 80474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x04013A5B RID: 80475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x04013A5C RID: 80476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x04013A5D RID: 80477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x04013A5E RID: 80478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x04013A5F RID: 80479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x04013A60 RID: 80480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x04013A61 RID: 80481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x04013A62 RID: 80482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x04013A63 RID: 80483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x04013A64 RID: 80484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x04013A65 RID: 80485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x04013A66 RID: 80486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x04013A67 RID: 80487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x04013A68 RID: 80488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x04013A69 RID: 80489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x04013A6A RID: 80490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x04013A6B RID: 80491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x04013A6C RID: 80492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x04013A6D RID: 80493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x04013A6E RID: 80494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x04013A6F RID: 80495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x04013A70 RID: 80496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x04013A71 RID: 80497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x04013A72 RID: 80498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x04013A73 RID: 80499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x04013A74 RID: 80500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x04013A75 RID: 80501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x04013A76 RID: 80502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x04013A77 RID: 80503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x04013A78 RID: 80504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x04013A79 RID: 80505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x04013A7A RID: 80506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x04013A7B RID: 80507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x04013A7C RID: 80508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x04013A7D RID: 80509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x04013A7E RID: 80510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x04013A7F RID: 80511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x04013A80 RID: 80512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x04013A81 RID: 80513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x04013A82 RID: 80514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x04013A83 RID: 80515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x04013A84 RID: 80516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x04013A85 RID: 80517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x04013A86 RID: 80518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x04013A87 RID: 80519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x04013A88 RID: 80520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x04013A89 RID: 80521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x04013A8A RID: 80522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x04013A8B RID: 80523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x04013A8C RID: 80524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x04013A8D RID: 80525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x04013A8E RID: 80526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x04013A8F RID: 80527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x04013A90 RID: 80528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x04013A91 RID: 80529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x04013A92 RID: 80530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x04013A93 RID: 80531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x04013A94 RID: 80532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x04013A95 RID: 80533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x04013A96 RID: 80534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x04013A97 RID: 80535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x04013A98 RID: 80536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x04013A99 RID: 80537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x04013A9A RID: 80538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x04013A9B RID: 80539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x04013A9C RID: 80540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x04013A9D RID: 80541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x04013A9E RID: 80542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x04013A9F RID: 80543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x04013AA0 RID: 80544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x04013AA1 RID: 80545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x04013AA2 RID: 80546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x04013AA3 RID: 80547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x04013AA4 RID: 80548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x04013AA5 RID: 80549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x04013AA6 RID: 80550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x04013AA7 RID: 80551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x04013AA8 RID: 80552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x04013AA9 RID: 80553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x04013AAA RID: 80554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;

	// Token: 0x04013AAB RID: 80555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19A;

	// Token: 0x04013AAC RID: 80556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19B;

	// Token: 0x04013AAD RID: 80557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19C;

	// Token: 0x04013AAE RID: 80558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19D;

	// Token: 0x04013AAF RID: 80559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19E;

	// Token: 0x04013AB0 RID: 80560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19F;

	// Token: 0x04013AB1 RID: 80561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A0;

	// Token: 0x04013AB2 RID: 80562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A1;

	// Token: 0x04013AB3 RID: 80563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A2;

	// Token: 0x04013AB4 RID: 80564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A3;

	// Token: 0x04013AB5 RID: 80565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A4;

	// Token: 0x04013AB6 RID: 80566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A5;

	// Token: 0x04013AB7 RID: 80567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A6;

	// Token: 0x04013AB8 RID: 80568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A7;

	// Token: 0x04013AB9 RID: 80569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A8;

	// Token: 0x04013ABA RID: 80570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A9;

	// Token: 0x04013ABB RID: 80571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AA;

	// Token: 0x04013ABC RID: 80572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AB;

	// Token: 0x04013ABD RID: 80573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AC;

	// Token: 0x04013ABE RID: 80574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AD;

	// Token: 0x04013ABF RID: 80575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AE;

	// Token: 0x04013AC0 RID: 80576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AF;

	// Token: 0x04013AC1 RID: 80577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B0;

	// Token: 0x04013AC2 RID: 80578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B1;

	// Token: 0x04013AC3 RID: 80579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B2;

	// Token: 0x04013AC4 RID: 80580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B3;

	// Token: 0x04013AC5 RID: 80581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B4;

	// Token: 0x04013AC6 RID: 80582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B5;

	// Token: 0x04013AC7 RID: 80583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B6;

	// Token: 0x04013AC8 RID: 80584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B7;

	// Token: 0x04013AC9 RID: 80585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B8;

	// Token: 0x04013ACA RID: 80586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B9;

	// Token: 0x04013ACB RID: 80587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BA;

	// Token: 0x04013ACC RID: 80588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BB;

	// Token: 0x04013ACD RID: 80589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BC;

	// Token: 0x04013ACE RID: 80590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BD;

	// Token: 0x04013ACF RID: 80591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BE;

	// Token: 0x04013AD0 RID: 80592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BF;

	// Token: 0x04013AD1 RID: 80593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C0;

	// Token: 0x04013AD2 RID: 80594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C1;

	// Token: 0x04013AD3 RID: 80595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C2;

	// Token: 0x04013AD4 RID: 80596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C3;

	// Token: 0x04013AD5 RID: 80597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C4;

	// Token: 0x04013AD6 RID: 80598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C5;

	// Token: 0x04013AD7 RID: 80599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C6;

	// Token: 0x04013AD8 RID: 80600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C7;

	// Token: 0x04013AD9 RID: 80601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C8;

	// Token: 0x04013ADA RID: 80602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C9;

	// Token: 0x04013ADB RID: 80603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CA;

	// Token: 0x04013ADC RID: 80604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CB;

	// Token: 0x04013ADD RID: 80605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CC;

	// Token: 0x04013ADE RID: 80606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CD;

	// Token: 0x04013ADF RID: 80607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CE;

	// Token: 0x04013AE0 RID: 80608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CF;

	// Token: 0x04013AE1 RID: 80609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D0;

	// Token: 0x04013AE2 RID: 80610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D1;

	// Token: 0x04013AE3 RID: 80611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D2;

	// Token: 0x04013AE4 RID: 80612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D3;

	// Token: 0x04013AE5 RID: 80613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D4;

	// Token: 0x04013AE6 RID: 80614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D5;

	// Token: 0x04013AE7 RID: 80615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D6;

	// Token: 0x04013AE8 RID: 80616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D7;

	// Token: 0x04013AE9 RID: 80617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D8;

	// Token: 0x04013AEA RID: 80618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D9;

	// Token: 0x04013AEB RID: 80619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DA;

	// Token: 0x04013AEC RID: 80620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DB;

	// Token: 0x04013AED RID: 80621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DC;

	// Token: 0x04013AEE RID: 80622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DD;

	// Token: 0x04013AEF RID: 80623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DE;

	// Token: 0x04013AF0 RID: 80624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DF;

	// Token: 0x04013AF1 RID: 80625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E0;

	// Token: 0x04013AF2 RID: 80626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E1;

	// Token: 0x04013AF3 RID: 80627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E2;

	// Token: 0x04013AF4 RID: 80628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E3;

	// Token: 0x04013AF5 RID: 80629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E4;

	// Token: 0x04013AF6 RID: 80630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E5;

	// Token: 0x04013AF7 RID: 80631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E6;

	// Token: 0x04013AF8 RID: 80632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E7;

	// Token: 0x04013AF9 RID: 80633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E8;

	// Token: 0x04013AFA RID: 80634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E9;

	// Token: 0x04013AFB RID: 80635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EA;

	// Token: 0x04013AFC RID: 80636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EB;

	// Token: 0x04013AFD RID: 80637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EC;

	// Token: 0x04013AFE RID: 80638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1ED;

	// Token: 0x04013AFF RID: 80639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EE;

	// Token: 0x04013B00 RID: 80640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EF;

	// Token: 0x04013B01 RID: 80641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F0;

	// Token: 0x04013B02 RID: 80642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F1;

	// Token: 0x04013B03 RID: 80643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F2;

	// Token: 0x04013B04 RID: 80644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F3;

	// Token: 0x04013B05 RID: 80645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F4;

	// Token: 0x04013B06 RID: 80646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F5;

	// Token: 0x04013B07 RID: 80647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F6;

	// Token: 0x04013B08 RID: 80648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F7;

	// Token: 0x04013B09 RID: 80649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F8;

	// Token: 0x04013B0A RID: 80650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F9;

	// Token: 0x04013B0B RID: 80651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FA;

	// Token: 0x04013B0C RID: 80652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FB;

	// Token: 0x04013B0D RID: 80653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FC;

	// Token: 0x04013B0E RID: 80654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FD;

	// Token: 0x04013B0F RID: 80655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FE;

	// Token: 0x04013B10 RID: 80656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FF;

	// Token: 0x04013B11 RID: 80657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache200;

	// Token: 0x04013B12 RID: 80658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache201;

	// Token: 0x04013B13 RID: 80659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache202;

	// Token: 0x04013B14 RID: 80660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache203;

	// Token: 0x04013B15 RID: 80661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache204;

	// Token: 0x04013B16 RID: 80662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache205;

	// Token: 0x04013B17 RID: 80663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache206;

	// Token: 0x04013B18 RID: 80664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache207;

	// Token: 0x04013B19 RID: 80665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache208;

	// Token: 0x04013B1A RID: 80666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache209;

	// Token: 0x04013B1B RID: 80667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20A;

	// Token: 0x04013B1C RID: 80668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20B;

	// Token: 0x04013B1D RID: 80669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20C;

	// Token: 0x04013B1E RID: 80670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20D;

	// Token: 0x04013B1F RID: 80671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20E;

	// Token: 0x04013B20 RID: 80672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20F;

	// Token: 0x04013B21 RID: 80673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache210;

	// Token: 0x04013B22 RID: 80674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache211;

	// Token: 0x04013B23 RID: 80675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache212;

	// Token: 0x04013B24 RID: 80676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache213;

	// Token: 0x04013B25 RID: 80677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache214;

	// Token: 0x04013B26 RID: 80678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache215;

	// Token: 0x04013B27 RID: 80679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache216;

	// Token: 0x04013B28 RID: 80680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache217;

	// Token: 0x04013B29 RID: 80681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache218;

	// Token: 0x04013B2A RID: 80682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache219;

	// Token: 0x04013B2B RID: 80683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21A;

	// Token: 0x04013B2C RID: 80684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21B;

	// Token: 0x04013B2D RID: 80685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21C;

	// Token: 0x04013B2E RID: 80686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21D;

	// Token: 0x04013B2F RID: 80687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21E;

	// Token: 0x04013B30 RID: 80688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21F;

	// Token: 0x04013B31 RID: 80689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache220;

	// Token: 0x04013B32 RID: 80690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache221;

	// Token: 0x04013B33 RID: 80691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache222;

	// Token: 0x04013B34 RID: 80692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache223;

	// Token: 0x04013B35 RID: 80693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache224;

	// Token: 0x04013B36 RID: 80694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache225;

	// Token: 0x04013B37 RID: 80695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache226;

	// Token: 0x04013B38 RID: 80696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache227;

	// Token: 0x04013B39 RID: 80697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache228;

	// Token: 0x04013B3A RID: 80698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache229;

	// Token: 0x04013B3B RID: 80699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22A;

	// Token: 0x04013B3C RID: 80700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22B;

	// Token: 0x04013B3D RID: 80701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22C;

	// Token: 0x04013B3E RID: 80702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22D;

	// Token: 0x04013B3F RID: 80703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22E;

	// Token: 0x04013B40 RID: 80704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22F;

	// Token: 0x04013B41 RID: 80705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache230;

	// Token: 0x04013B42 RID: 80706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache231;

	// Token: 0x04013B43 RID: 80707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache232;

	// Token: 0x04013B44 RID: 80708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache233;

	// Token: 0x04013B45 RID: 80709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache234;

	// Token: 0x04013B46 RID: 80710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache235;

	// Token: 0x04013B47 RID: 80711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache236;

	// Token: 0x04013B48 RID: 80712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache237;

	// Token: 0x04013B49 RID: 80713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache238;

	// Token: 0x04013B4A RID: 80714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache239;

	// Token: 0x04013B4B RID: 80715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23A;

	// Token: 0x04013B4C RID: 80716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23B;

	// Token: 0x04013B4D RID: 80717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23C;

	// Token: 0x04013B4E RID: 80718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23D;

	// Token: 0x04013B4F RID: 80719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23E;

	// Token: 0x04013B50 RID: 80720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23F;

	// Token: 0x04013B51 RID: 80721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache240;

	// Token: 0x04013B52 RID: 80722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache241;

	// Token: 0x04013B53 RID: 80723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache242;

	// Token: 0x04013B54 RID: 80724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache243;

	// Token: 0x04013B55 RID: 80725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache244;

	// Token: 0x04013B56 RID: 80726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache245;

	// Token: 0x04013B57 RID: 80727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache246;

	// Token: 0x04013B58 RID: 80728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache247;

	// Token: 0x04013B59 RID: 80729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache248;

	// Token: 0x04013B5A RID: 80730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache249;

	// Token: 0x04013B5B RID: 80731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24A;

	// Token: 0x04013B5C RID: 80732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24B;

	// Token: 0x04013B5D RID: 80733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24C;

	// Token: 0x04013B5E RID: 80734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24D;

	// Token: 0x04013B5F RID: 80735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24E;

	// Token: 0x04013B60 RID: 80736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24F;

	// Token: 0x04013B61 RID: 80737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache250;

	// Token: 0x04013B62 RID: 80738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache251;

	// Token: 0x04013B63 RID: 80739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache252;

	// Token: 0x04013B64 RID: 80740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache253;

	// Token: 0x04013B65 RID: 80741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache254;

	// Token: 0x04013B66 RID: 80742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache255;

	// Token: 0x04013B67 RID: 80743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache256;

	// Token: 0x04013B68 RID: 80744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache257;

	// Token: 0x04013B69 RID: 80745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache258;

	// Token: 0x04013B6A RID: 80746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache259;

	// Token: 0x04013B6B RID: 80747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25A;

	// Token: 0x04013B6C RID: 80748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25B;

	// Token: 0x04013B6D RID: 80749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25C;

	// Token: 0x04013B6E RID: 80750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25D;

	// Token: 0x04013B6F RID: 80751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25E;

	// Token: 0x04013B70 RID: 80752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25F;

	// Token: 0x04013B71 RID: 80753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache260;

	// Token: 0x04013B72 RID: 80754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache261;

	// Token: 0x04013B73 RID: 80755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache262;

	// Token: 0x04013B74 RID: 80756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache263;

	// Token: 0x04013B75 RID: 80757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache264;

	// Token: 0x04013B76 RID: 80758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache265;

	// Token: 0x04013B77 RID: 80759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache266;

	// Token: 0x04013B78 RID: 80760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache267;

	// Token: 0x04013B79 RID: 80761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache268;

	// Token: 0x04013B7A RID: 80762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache269;

	// Token: 0x04013B7B RID: 80763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26A;

	// Token: 0x04013B7C RID: 80764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26B;

	// Token: 0x04013B7D RID: 80765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26C;

	// Token: 0x04013B7E RID: 80766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26D;

	// Token: 0x04013B7F RID: 80767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26E;

	// Token: 0x04013B80 RID: 80768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26F;

	// Token: 0x04013B81 RID: 80769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache270;

	// Token: 0x04013B82 RID: 80770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache271;

	// Token: 0x04013B83 RID: 80771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache272;

	// Token: 0x04013B84 RID: 80772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache273;

	// Token: 0x04013B85 RID: 80773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache274;
}
