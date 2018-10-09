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

// Token: 0x02001396 RID: 5014
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagListUIController : LuaObject
{
	// Token: 0x0601B574 RID: 111988 RVA: 0x00845B60 File Offset: 0x00843D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B575 RID: 111989 RVA: 0x00845BAC File Offset: 0x00843DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInBagList(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 2, out displayType);
			ulong clickInstanceId;
			LuaObject.checkType(l, 3, out clickInstanceId);
			bagListUIController.UpdateViewInBagList(displayType, clickInstanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B576 RID: 111990 RVA: 0x00845C10 File Offset: 0x00843E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetBagUIView(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.ResetBagUIView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B577 RID: 111991 RVA: 0x00845C5C File Offset: 0x00843E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseBagInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.CloseBagInfoPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B578 RID: 111992 RVA: 0x00845CA8 File Offset: 0x00843EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B579 RID: 111993 RVA: 0x00845CFC File Offset: 0x00843EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLoopScrollViewRect(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.InitLoopScrollViewRect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B57A RID: 111994 RVA: 0x00845D50 File Offset: 0x00843F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBagItemOfDisplayType(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagItemBase itm;
			LuaObject.checkType<BagItemBase>(l, 2, out itm);
			bool b = bagListUIController.m_luaExportHelper.IsBagItemOfDisplayType(itm);
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

	// Token: 0x0601B57B RID: 111995 RVA: 0x00845DB8 File Offset: 0x00843FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNoItemPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			bagListUIController.m_luaExportHelper.ShowNoItemPanelObj(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B57C RID: 111996 RVA: 0x00845E14 File Offset: 0x00844014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagItemComparer(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagItemBase item;
			LuaObject.checkType<BagItemBase>(l, 2, out item);
			BagItemBase item2;
			LuaObject.checkType<BagItemBase>(l, 3, out item2);
			int i = bagListUIController.m_luaExportHelper.BagItemComparer(item, item2);
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

	// Token: 0x0601B57D RID: 111997 RVA: 0x00845E88 File Offset: 0x00844088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBagItemClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			bagListUIController.m_luaExportHelper.OnBagItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B57E RID: 111998 RVA: 0x00845EE4 File Offset: 0x008440E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBagItemNeedFill(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			bagListUIController.m_luaExportHelper.OnBagItemNeedFill(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B57F RID: 111999 RVA: 0x00845F40 File Offset: 0x00844140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagItemBase infoPanel;
			LuaObject.checkType<BagItemBase>(l, 2, out infoPanel);
			bagListUIController.m_luaExportHelper.SetInfoPanel(infoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B580 RID: 112000 RVA: 0x00845F9C File Offset: 0x0084419C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentInfo;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentInfo);
			bagListUIController.m_luaExportHelper.SetEquipmentInfo(equipmentInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B581 RID: 112001 RVA: 0x00845FF8 File Offset: 0x008441F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentSkillInfo;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentSkillInfo);
			bagListUIController.m_luaExportHelper.SetEquipmentSkillInfo(equipmentSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B582 RID: 112002 RVA: 0x00846054 File Offset: 0x00844254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentLimitInfo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentLimitInfo;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentLimitInfo);
			bagListUIController.m_luaExportHelper.SetEquipmentLimitInfo(equipmentLimitInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B583 RID: 112003 RVA: 0x008460B0 File Offset: 0x008442B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentEnchantInfo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipmentEnchantInfo;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipmentEnchantInfo);
			bagListUIController.m_luaExportHelper.SetEquipmentEnchantInfo(equipmentEnchantInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B584 RID: 112004 RVA: 0x0084610C File Offset: 0x0084430C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentPropItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			int addValue;
			LuaObject.checkType(l, 4, out addValue);
			int level;
			LuaObject.checkType(l, 5, out level);
			bagListUIController.m_luaExportHelper.SetEquipmentPropItem(type, value, addValue, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B585 RID: 112005 RVA: 0x00846190 File Offset: 0x00844390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBagCountLimit(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.SetBagCountLimit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B586 RID: 112006 RVA: 0x008461E4 File Offset: 0x008443E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnGetItemButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B587 RID: 112007 RVA: 0x00846238 File Offset: 0x00844438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentForgeButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnEquipmentForgeButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B588 RID: 112008 RVA: 0x0084628C File Offset: 0x0084448C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B589 RID: 112009 RVA: 0x008462E0 File Offset: 0x008444E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnAlchemyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B58A RID: 112010 RVA: 0x00846334 File Offset: 0x00844534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnUseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B58B RID: 112011 RVA: 0x00846388 File Offset: 0x00844588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubItemUseItemClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnSubItemUseItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B58C RID: 112012 RVA: 0x008463DC File Offset: 0x008445DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSubItemUsePanel(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.CloseSubItemUsePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B58D RID: 112013 RVA: 0x00846430 File Offset: 0x00844630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInputEditEnd(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string inputString;
			LuaObject.checkType(l, 2, out inputString);
			bagListUIController.m_luaExportHelper.OnInputEditEnd(inputString);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B58E RID: 112014 RVA: 0x0084648C File Offset: 0x0084468C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemMinusButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnItemMinusButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B58F RID: 112015 RVA: 0x008464E0 File Offset: 0x008446E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnItemAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B590 RID: 112016 RVA: 0x00846534 File Offset: 0x00844734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemMaxButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnItemMaxButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B591 RID: 112017 RVA: 0x00846588 File Offset: 0x00844788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddAllItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnAddAllItemButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B592 RID: 112018 RVA: 0x008465DC File Offset: 0x008447DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddAllEquipmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnAddAllEquipmentButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B593 RID: 112019 RVA: 0x00846630 File Offset: 0x00844830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnAddItemButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B594 RID: 112020 RVA: 0x00846684 File Offset: 0x00844884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClearBagButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnClearBagButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B595 RID: 112021 RVA: 0x008466D8 File Offset: 0x008448D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSpeedUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnSpeedUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B596 RID: 112022 RVA: 0x0084672C File Offset: 0x0084492C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B597 RID: 112023 RVA: 0x00846780 File Offset: 0x00844980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			bagListUIController.m_luaExportHelper.OnItemToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B598 RID: 112024 RVA: 0x008467DC File Offset: 0x008449DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobMaterialToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			bagListUIController.m_luaExportHelper.OnJobMaterialToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B599 RID: 112025 RVA: 0x00846838 File Offset: 0x00844A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			bagListUIController.m_luaExportHelper.OnEquipmentToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B59A RID: 112026 RVA: 0x00846894 File Offset: 0x00844A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFragmentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			bagListUIController.m_luaExportHelper.OnFragmentToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B59B RID: 112027 RVA: 0x008468F0 File Offset: 0x00844AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.OnToggleChanged();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B59C RID: 112028 RVA: 0x00846944 File Offset: 0x00844B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			bagListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B59D RID: 112029 RVA: 0x008469B0 File Offset: 0x00844BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B59E RID: 112030 RVA: 0x00846A04 File Offset: 0x00844C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B59F RID: 112031 RVA: 0x00846A58 File Offset: 0x00844C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = bagListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B5A0 RID: 112032 RVA: 0x00846B00 File Offset: 0x00844D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5A1 RID: 112033 RVA: 0x00846B54 File Offset: 0x00844D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			bagListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5A2 RID: 112034 RVA: 0x00846BC0 File Offset: 0x00844DC0
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
				BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				bagListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BagListUIController bagListUIController2 = (BagListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				bagListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B5A3 RID: 112035 RVA: 0x00846CD0 File Offset: 0x00844ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5A4 RID: 112036 RVA: 0x00846D3C File Offset: 0x00844F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5A5 RID: 112037 RVA: 0x00846DA8 File Offset: 0x00844FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5A6 RID: 112038 RVA: 0x00846E14 File Offset: 0x00845014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5A7 RID: 112039 RVA: 0x00846E80 File Offset: 0x00845080
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
				BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				bagListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BagListUIController bagListUIController2 = (BagListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				bagListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B5A8 RID: 112040 RVA: 0x00846F90 File Offset: 0x00845190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string s = bagListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B5A9 RID: 112041 RVA: 0x00846FEC File Offset: 0x008451EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5AA RID: 112042 RVA: 0x00847040 File Offset: 0x00845240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5AB RID: 112043 RVA: 0x00847094 File Offset: 0x00845294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClearBag(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callDele_EventOnClearBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5AC RID: 112044 RVA: 0x008470E8 File Offset: 0x008452E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClearBag(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnClearBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5AD RID: 112045 RVA: 0x0084713C File Offset: 0x0084533C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSpeedUp(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			BagListUIController.DisplayType arg3;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 4, out arg3);
			bagListUIController.m_luaExportHelper.__callDele_EventOnSpeedUp(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5AE RID: 112046 RVA: 0x008471B4 File Offset: 0x008453B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSpeedUp(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			BagListUIController.DisplayType arg3;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 4, out arg3);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnSpeedUp(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5AF RID: 112047 RVA: 0x0084722C File Offset: 0x0084542C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddAllItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callDele_EventOnAddAllItem();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B0 RID: 112048 RVA: 0x00847280 File Offset: 0x00845480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddAllItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnAddAllItem();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B1 RID: 112049 RVA: 0x008472D4 File Offset: 0x008454D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddAllEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callDele_EventOnAddAllEquipment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B2 RID: 112050 RVA: 0x00847328 File Offset: 0x00845528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddAllEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnAddAllEquipment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B3 RID: 112051 RVA: 0x0084737C File Offset: 0x0084557C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__callDele_EventOnAlchemyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B4 RID: 112052 RVA: 0x008473D0 File Offset: 0x008455D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnAlchemyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B5 RID: 112053 RVA: 0x00847424 File Offset: 0x00845624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			bagListUIController.m_luaExportHelper.__callDele_EventOnAddItem(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B6 RID: 112054 RVA: 0x00847480 File Offset: 0x00845680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnAddItem(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B7 RID: 112055 RVA: 0x008474DC File Offset: 0x008456DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUse(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			BagListUIController.DisplayType arg4;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 5, out arg4);
			bagListUIController.m_luaExportHelper.__callDele_EventOnUse(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B8 RID: 112056 RVA: 0x00847560 File Offset: 0x00845760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUse(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			BagListUIController.DisplayType arg4;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 5, out arg4);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnUse(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5B9 RID: 112057 RVA: 0x008475E4 File Offset: 0x008457E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			BagListUIController.DisplayType arg3;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 4, out arg3);
			bagListUIController.m_luaExportHelper.__callDele_EventOnEquipmentForge(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5BA RID: 112058 RVA: 0x0084765C File Offset: 0x0084585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			BagListUIController.DisplayType arg3;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 4, out arg3);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnEquipmentForge(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5BB RID: 112059 RVA: 0x008476D4 File Offset: 0x008458D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagItemBase arg;
			LuaObject.checkType<BagItemBase>(l, 2, out arg);
			BagListUIController.DisplayType arg2;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 3, out arg2);
			bagListUIController.m_luaExportHelper.__callDele_EventOnShowGetPath(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5BC RID: 112060 RVA: 0x00847740 File Offset: 0x00845940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagItemBase arg;
			LuaObject.checkType<BagItemBase>(l, 2, out arg);
			BagListUIController.DisplayType arg2;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 3, out arg2);
			bagListUIController.m_luaExportHelper.__clearDele_EventOnShowGetPath(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5BD RID: 112061 RVA: 0x008477AC File Offset: 0x008459AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnReturn -= value;
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

	// Token: 0x0601B5BE RID: 112062 RVA: 0x0084782C File Offset: 0x00845A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClearBag(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnClearBag += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnClearBag -= value;
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

	// Token: 0x0601B5BF RID: 112063 RVA: 0x008478AC File Offset: 0x00845AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSpeedUp(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action<int, ulong, BagListUIController.DisplayType> value;
			int num = LuaObject.checkDelegate<Action<int, ulong, BagListUIController.DisplayType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnSpeedUp += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnSpeedUp -= value;
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

	// Token: 0x0601B5C0 RID: 112064 RVA: 0x0084792C File Offset: 0x00845B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddAllItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnAddAllItem += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnAddAllItem -= value;
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

	// Token: 0x0601B5C1 RID: 112065 RVA: 0x008479AC File Offset: 0x00845BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddAllEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnAddAllEquipment += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnAddAllEquipment -= value;
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

	// Token: 0x0601B5C2 RID: 112066 RVA: 0x00847A2C File Offset: 0x00845C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnAlchemyButtonClick += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnAlchemyButtonClick -= value;
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

	// Token: 0x0601B5C3 RID: 112067 RVA: 0x00847AAC File Offset: 0x00845CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnAddItem += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnAddItem -= value;
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

	// Token: 0x0601B5C4 RID: 112068 RVA: 0x00847B2C File Offset: 0x00845D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUse(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int, BagListUIController.DisplayType> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int, BagListUIController.DisplayType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnUse += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnUse -= value;
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

	// Token: 0x0601B5C5 RID: 112069 RVA: 0x00847BAC File Offset: 0x00845DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action<int, ulong, BagListUIController.DisplayType> value;
			int num = LuaObject.checkDelegate<Action<int, ulong, BagListUIController.DisplayType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnEquipmentForge += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnEquipmentForge -= value;
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

	// Token: 0x0601B5C6 RID: 112070 RVA: 0x00847C2C File Offset: 0x00845E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Action<BagItemBase, BagListUIController.DisplayType> value;
			int num = LuaObject.checkDelegate<Action<BagItemBase, BagListUIController.DisplayType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagListUIController.EventOnShowGetPath += value;
				}
				else if (num == 2)
				{
					bagListUIController.EventOnShowGetPath -= value;
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

	// Token: 0x0601B5C7 RID: 112071 RVA: 0x00847CAC File Offset: 0x00845EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5C8 RID: 112072 RVA: 0x00847D04 File Offset: 0x00845F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			bagListUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5C9 RID: 112073 RVA: 0x00847D60 File Offset: 0x00845F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_itemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5CA RID: 112074 RVA: 0x00847DB8 File Offset: 0x00845FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Toggle itemToggle;
			LuaObject.checkType<Toggle>(l, 2, out itemToggle);
			bagListUIController.m_luaExportHelper.m_itemToggle = itemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5CB RID: 112075 RVA: 0x00847E14 File Offset: 0x00846014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5CC RID: 112076 RVA: 0x00847E6C File Offset: 0x0084606C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Toggle equipmentToggle;
			LuaObject.checkType<Toggle>(l, 2, out equipmentToggle);
			bagListUIController.m_luaExportHelper.m_equipmentToggle = equipmentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5CD RID: 112077 RVA: 0x00847EC8 File Offset: 0x008460C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fragmentToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_fragmentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5CE RID: 112078 RVA: 0x00847F20 File Offset: 0x00846120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fragmentToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Toggle fragmentToggle;
			LuaObject.checkType<Toggle>(l, 2, out fragmentToggle);
			bagListUIController.m_luaExportHelper.m_fragmentToggle = fragmentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5CF RID: 112079 RVA: 0x00847F7C File Offset: 0x0084617C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_jobMaterialToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D0 RID: 112080 RVA: 0x00847FD4 File Offset: 0x008461D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialToggle(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Toggle jobMaterialToggle;
			LuaObject.checkType<Toggle>(l, 2, out jobMaterialToggle);
			bagListUIController.m_luaExportHelper.m_jobMaterialToggle = jobMaterialToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D1 RID: 112081 RVA: 0x00848030 File Offset: 0x00846230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alchemyButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_alchemyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D2 RID: 112082 RVA: 0x00848088 File Offset: 0x00846288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alchemyButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button alchemyButton;
			LuaObject.checkType<Button>(l, 2, out alchemyButton);
			bagListUIController.m_luaExportHelper.m_alchemyButton = alchemyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D3 RID: 112083 RVA: 0x008480E4 File Offset: 0x008462E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D4 RID: 112084 RVA: 0x0084813C File Offset: 0x0084633C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			bagListUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D5 RID: 112085 RVA: 0x00848198 File Offset: 0x00846398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_loopScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D6 RID: 112086 RVA: 0x008481F0 File Offset: 0x008463F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LoopVerticalScrollRect loopScrollView;
			LuaObject.checkType<LoopVerticalScrollRect>(l, 2, out loopScrollView);
			bagListUIController.m_luaExportHelper.m_loopScrollView = loopScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D7 RID: 112087 RVA: 0x0084824C File Offset: 0x0084644C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_listItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D8 RID: 112088 RVA: 0x008482A4 File Offset: 0x008464A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			EasyObjectPool listItemPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out listItemPool);
			bagListUIController.m_luaExportHelper.m_listItemPool = listItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5D9 RID: 112089 RVA: 0x00848300 File Offset: 0x00846500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listScrollViewItemTemplateRoot(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_listScrollViewItemTemplateRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5DA RID: 112090 RVA: 0x00848358 File Offset: 0x00846558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listScrollViewItemTemplateRoot(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject listScrollViewItemTemplateRoot;
			LuaObject.checkType<GameObject>(l, 2, out listScrollViewItemTemplateRoot);
			bagListUIController.m_luaExportHelper.m_listScrollViewItemTemplateRoot = listScrollViewItemTemplateRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5DB RID: 112091 RVA: 0x008483B4 File Offset: 0x008465B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewBagItemContent(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_scrollViewBagItemContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5DC RID: 112092 RVA: 0x0084840C File Offset: 0x0084660C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewBagItemContent(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject scrollViewBagItemContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewBagItemContent);
			bagListUIController.m_luaExportHelper.m_scrollViewBagItemContent = scrollViewBagItemContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5DD RID: 112093 RVA: 0x00848468 File Offset: 0x00846668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagListPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagListPointBgContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5DE RID: 112094 RVA: 0x008484C0 File Offset: 0x008466C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagListPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject bagListPointBgContent;
			LuaObject.checkType<GameObject>(l, 2, out bagListPointBgContent);
			bagListUIController.m_luaExportHelper.m_bagListPointBgContent = bagListPointBgContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5DF RID: 112095 RVA: 0x0084851C File Offset: 0x0084671C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagListPointItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagListPointItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E0 RID: 112096 RVA: 0x00848574 File Offset: 0x00846774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagListPointItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject bagListPointItem;
			LuaObject.checkType<GameObject>(l, 2, out bagListPointItem);
			bagListUIController.m_luaExportHelper.m_bagListPointItem = bagListPointItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E1 RID: 112097 RVA: 0x008485D0 File Offset: 0x008467D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noItemPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_noItemPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E2 RID: 112098 RVA: 0x00848628 File Offset: 0x00846828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noItemPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject noItemPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out noItemPanelObj);
			bagListUIController.m_luaExportHelper.m_noItemPanelObj = noItemPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E3 RID: 112099 RVA: 0x00848684 File Offset: 0x00846884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagInfoPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E4 RID: 112100 RVA: 0x008486DC File Offset: 0x008468DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject bagInfoPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out bagInfoPanelObj);
			bagListUIController.m_luaExportHelper.m_bagInfoPanelObj = bagInfoPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E5 RID: 112101 RVA: 0x00848738 File Offset: 0x00846938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagInfoStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E6 RID: 112102 RVA: 0x00848790 File Offset: 0x00846990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagInfoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController bagInfoStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out bagInfoStateCtrl);
			bagListUIController.m_luaExportHelper.m_bagInfoStateCtrl = bagInfoStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E7 RID: 112103 RVA: 0x008487EC File Offset: 0x008469EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_useButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_useButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E8 RID: 112104 RVA: 0x00848844 File Offset: 0x00846A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_useButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button useButton;
			LuaObject.checkType<Button>(l, 2, out useButton);
			bagListUIController.m_luaExportHelper.m_useButton = useButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5E9 RID: 112105 RVA: 0x008488A0 File Offset: 0x00846AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_itemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5EA RID: 112106 RVA: 0x008488F8 File Offset: 0x00846AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text itemNameText;
			LuaObject.checkType<Text>(l, 2, out itemNameText);
			bagListUIController.m_luaExportHelper.m_itemNameText = itemNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5EB RID: 112107 RVA: 0x00848954 File Offset: 0x00846B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemCountText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_itemCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5EC RID: 112108 RVA: 0x008489AC File Offset: 0x00846BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemCountText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text itemCountText;
			LuaObject.checkType<Text>(l, 2, out itemCountText);
			bagListUIController.m_luaExportHelper.m_itemCountText = itemCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5ED RID: 112109 RVA: 0x00848A08 File Offset: 0x00846C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemDescText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_itemDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5EE RID: 112110 RVA: 0x00848A60 File Offset: 0x00846C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemDescText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text itemDescText;
			LuaObject.checkType<Text>(l, 2, out itemDescText);
			bagListUIController.m_luaExportHelper.m_itemDescText = itemDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5EF RID: 112111 RVA: 0x00848ABC File Offset: 0x00846CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemIconImage(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_itemIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F0 RID: 112112 RVA: 0x00848B14 File Offset: 0x00846D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemIconImage(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Image itemIconImage;
			LuaObject.checkType<Image>(l, 2, out itemIconImage);
			bagListUIController.m_luaExportHelper.m_itemIconImage = itemIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F1 RID: 112113 RVA: 0x00848B70 File Offset: 0x00846D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemGetButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_itemGetButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F2 RID: 112114 RVA: 0x00848BC8 File Offset: 0x00846DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemGetButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button itemGetButton;
			LuaObject.checkType<Button>(l, 2, out itemGetButton);
			bagListUIController.m_luaExportHelper.m_itemGetButton = itemGetButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F3 RID: 112115 RVA: 0x00848C24 File Offset: 0x00846E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagCountLimitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagCountLimitStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F4 RID: 112116 RVA: 0x00848C7C File Offset: 0x00846E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagCountLimitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController bagCountLimitStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out bagCountLimitStateCtrl);
			bagListUIController.m_luaExportHelper.m_bagCountLimitStateCtrl = bagCountLimitStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F5 RID: 112117 RVA: 0x00848CD8 File Offset: 0x00846ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagCountText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F6 RID: 112118 RVA: 0x00848D30 File Offset: 0x00846F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagCountText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text bagCountText;
			LuaObject.checkType<Text>(l, 2, out bagCountText);
			bagListUIController.m_luaExportHelper.m_bagCountText = bagCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F7 RID: 112119 RVA: 0x00848D8C File Offset: 0x00846F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagMaxCountText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagMaxCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F8 RID: 112120 RVA: 0x00848DE4 File Offset: 0x00846FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagMaxCountText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text bagMaxCountText;
			LuaObject.checkType<Text>(l, 2, out bagMaxCountText);
			bagListUIController.m_luaExportHelper.m_bagMaxCountText = bagMaxCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5F9 RID: 112121 RVA: 0x00848E40 File Offset: 0x00847040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentInfoExplainText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentInfoExplainText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5FA RID: 112122 RVA: 0x00848E98 File Offset: 0x00847098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentInfoExplainText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentInfoExplainText;
			LuaObject.checkType<Text>(l, 2, out equipmentInfoExplainText);
			bagListUIController.m_luaExportHelper.m_equipmentInfoExplainText = equipmentInfoExplainText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5FB RID: 112123 RVA: 0x00848EF4 File Offset: 0x008470F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentForgeButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentForgeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5FC RID: 112124 RVA: 0x00848F4C File Offset: 0x0084714C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentForgeButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button equipmentForgeButton;
			LuaObject.checkType<Button>(l, 2, out equipmentForgeButton);
			bagListUIController.m_luaExportHelper.m_equipmentForgeButton = equipmentForgeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5FD RID: 112125 RVA: 0x00848FA8 File Offset: 0x008471A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5FE RID: 112126 RVA: 0x00849000 File Offset: 0x00847200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipmentSkillStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipmentSkillStateCtrl);
			bagListUIController.m_luaExportHelper.m_equipmentSkillStateCtrl = equipmentSkillStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B5FF RID: 112127 RVA: 0x0084905C File Offset: 0x0084725C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B600 RID: 112128 RVA: 0x008490B4 File Offset: 0x008472B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentSkillNameText;
			LuaObject.checkType<Text>(l, 2, out equipmentSkillNameText);
			bagListUIController.m_luaExportHelper.m_equipmentSkillNameText = equipmentSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B601 RID: 112129 RVA: 0x00849110 File Offset: 0x00847310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillLvValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B602 RID: 112130 RVA: 0x00849168 File Offset: 0x00847368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillLvValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentSkillLvValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentSkillLvValueText);
			bagListUIController.m_luaExportHelper.m_equipmentSkillLvValueText = equipmentSkillLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B603 RID: 112131 RVA: 0x008491C4 File Offset: 0x008473C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillUnlockCoditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B604 RID: 112132 RVA: 0x0084921C File Offset: 0x0084741C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentSkillUnlockCoditionText;
			LuaObject.checkType<Text>(l, 2, out equipmentSkillUnlockCoditionText);
			bagListUIController.m_luaExportHelper.m_equipmentSkillUnlockCoditionText = equipmentSkillUnlockCoditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B605 RID: 112133 RVA: 0x00849278 File Offset: 0x00847478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillCharNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillCharNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B606 RID: 112134 RVA: 0x008492D0 File Offset: 0x008474D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillCharNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentSkillCharNameText;
			LuaObject.checkType<Text>(l, 2, out equipmentSkillCharNameText);
			bagListUIController.m_luaExportHelper.m_equipmentSkillCharNameText = equipmentSkillCharNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B607 RID: 112135 RVA: 0x0084932C File Offset: 0x0084752C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillCharNameBGImage(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillCharNameBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B608 RID: 112136 RVA: 0x00849384 File Offset: 0x00847584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillCharNameBGImage(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentSkillCharNameBGImage;
			LuaObject.checkType<GameObject>(l, 2, out equipmentSkillCharNameBGImage);
			bagListUIController.m_luaExportHelper.m_equipmentSkillCharNameBGImage = equipmentSkillCharNameBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B609 RID: 112137 RVA: 0x008493E0 File Offset: 0x008475E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B60A RID: 112138 RVA: 0x00849438 File Offset: 0x00847638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentSkillDescText;
			LuaObject.checkType<Text>(l, 2, out equipmentSkillDescText);
			bagListUIController.m_luaExportHelper.m_equipmentSkillDescText = equipmentSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B60B RID: 112139 RVA: 0x00849494 File Offset: 0x00847694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentSkillContentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B60C RID: 112140 RVA: 0x008494EC File Offset: 0x008476EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipmentSkillContentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipmentSkillContentStateCtrl);
			bagListUIController.m_luaExportHelper.m_equipmentSkillContentStateCtrl = equipmentSkillContentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B60D RID: 112141 RVA: 0x00849548 File Offset: 0x00847748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentLimitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentLimitStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B60E RID: 112142 RVA: 0x008495A0 File Offset: 0x008477A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentLimitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipmentLimitStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipmentLimitStateCtrl);
			bagListUIController.m_luaExportHelper.m_equipmentLimitStateCtrl = equipmentLimitStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B60F RID: 112143 RVA: 0x008495FC File Offset: 0x008477FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentLimitContent(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentLimitContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B610 RID: 112144 RVA: 0x00849654 File Offset: 0x00847854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentLimitContent(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentLimitContent;
			LuaObject.checkType<GameObject>(l, 2, out equipmentLimitContent);
			bagListUIController.m_luaExportHelper.m_equipmentLimitContent = equipmentLimitContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B611 RID: 112145 RVA: 0x008496B0 File Offset: 0x008478B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentEquipUnlimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B612 RID: 112146 RVA: 0x00849708 File Offset: 0x00847908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentEquipUnlimitText;
			LuaObject.checkType<Text>(l, 2, out equipmentEquipUnlimitText);
			bagListUIController.m_luaExportHelper.m_equipmentEquipUnlimitText = equipmentEquipUnlimitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B613 RID: 112147 RVA: 0x00849764 File Offset: 0x00847964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropertyGroup(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropertyGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B614 RID: 112148 RVA: 0x008497BC File Offset: 0x008479BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropertyGroup(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropertyGroup;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropertyGroup);
			bagListUIController.m_luaExportHelper.m_equipmentPropertyGroup = equipmentPropertyGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B615 RID: 112149 RVA: 0x00849818 File Offset: 0x00847A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropATGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B616 RID: 112150 RVA: 0x00849870 File Offset: 0x00847A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropATGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropATGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropATGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropATGo = equipmentPropATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B617 RID: 112151 RVA: 0x008498CC File Offset: 0x00847ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B618 RID: 112152 RVA: 0x00849924 File Offset: 0x00847B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropATValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropATValueText);
			bagListUIController.m_luaExportHelper.m_equipmentPropATValueText = equipmentPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B619 RID: 112153 RVA: 0x00849980 File Offset: 0x00847B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B61A RID: 112154 RVA: 0x008499D8 File Offset: 0x00847BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropDFGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropDFGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropDFGo = equipmentPropDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B61B RID: 112155 RVA: 0x00849A34 File Offset: 0x00847C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B61C RID: 112156 RVA: 0x00849A8C File Offset: 0x00847C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropDFValueText);
			bagListUIController.m_luaExportHelper.m_equipmentPropDFValueText = equipmentPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B61D RID: 112157 RVA: 0x00849AE8 File Offset: 0x00847CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropHPGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B61E RID: 112158 RVA: 0x00849B40 File Offset: 0x00847D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropHPGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropHPGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropHPGo = equipmentPropHPGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B61F RID: 112159 RVA: 0x00849B9C File Offset: 0x00847D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B620 RID: 112160 RVA: 0x00849BF4 File Offset: 0x00847DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropHPValueText);
			bagListUIController.m_luaExportHelper.m_equipmentPropHPValueText = equipmentPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B621 RID: 112161 RVA: 0x00849C50 File Offset: 0x00847E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropMagiccGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B622 RID: 112162 RVA: 0x00849CA8 File Offset: 0x00847EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropMagiccGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropMagiccGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropMagiccGo = equipmentPropMagiccGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B623 RID: 112163 RVA: 0x00849D04 File Offset: 0x00847F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B624 RID: 112164 RVA: 0x00849D5C File Offset: 0x00847F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropMagicValueText);
			bagListUIController.m_luaExportHelper.m_equipmentPropMagicValueText = equipmentPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B625 RID: 112165 RVA: 0x00849DB8 File Offset: 0x00847FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B626 RID: 112166 RVA: 0x00849E10 File Offset: 0x00848010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropMagicDFGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropMagicDFGo = equipmentPropMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B627 RID: 112167 RVA: 0x00849E6C File Offset: 0x0084806C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B628 RID: 112168 RVA: 0x00849EC4 File Offset: 0x008480C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropMagicDFValueText);
			bagListUIController.m_luaExportHelper.m_equipmentPropMagicDFValueText = equipmentPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B629 RID: 112169 RVA: 0x00849F20 File Offset: 0x00848120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropDexGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B62A RID: 112170 RVA: 0x00849F78 File Offset: 0x00848178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropDexGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropDexGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropDexGo = equipmentPropDexGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B62B RID: 112171 RVA: 0x00849FD4 File Offset: 0x008481D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropDexValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B62C RID: 112172 RVA: 0x0084A02C File Offset: 0x0084822C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropDexValueText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropDexValueText);
			bagListUIController.m_luaExportHelper.m_equipmentPropDexValueText = equipmentPropDexValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B62D RID: 112173 RVA: 0x0084A088 File Offset: 0x00848288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B62E RID: 112174 RVA: 0x0084A0E0 File Offset: 0x008482E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipmentPropGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipmentPropGroupStateCtrl);
			bagListUIController.m_luaExportHelper.m_equipmentPropGroupStateCtrl = equipmentPropGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B62F RID: 112175 RVA: 0x0084A13C File Offset: 0x0084833C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B630 RID: 112176 RVA: 0x0084A194 File Offset: 0x00848394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropEnchantmentGroup;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropEnchantmentGroup);
			bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroup = equipmentPropEnchantmentGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B631 RID: 112177 RVA: 0x0084A1F0 File Offset: 0x008483F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropEnchantmentGroupResonanceGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupResonanceGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B632 RID: 112178 RVA: 0x0084A248 File Offset: 0x00848448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropEnchantmentGroupResonanceGo(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject equipmentPropEnchantmentGroupResonanceGo;
			LuaObject.checkType<GameObject>(l, 2, out equipmentPropEnchantmentGroupResonanceGo);
			bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupResonanceGo = equipmentPropEnchantmentGroupResonanceGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B633 RID: 112179 RVA: 0x0084A2A4 File Offset: 0x008484A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupRuneStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B634 RID: 112180 RVA: 0x0084A2FC File Offset: 0x008484FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipmentPropEnchantmentGroupRuneStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipmentPropEnchantmentGroupRuneStateCtrl);
			bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupRuneStateCtrl = equipmentPropEnchantmentGroupRuneStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B635 RID: 112181 RVA: 0x0084A358 File Offset: 0x00848558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupRuneIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B636 RID: 112182 RVA: 0x0084A3B0 File Offset: 0x008485B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Image equipmentPropEnchantmentGroupRuneIconImage;
			LuaObject.checkType<Image>(l, 2, out equipmentPropEnchantmentGroupRuneIconImage);
			bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupRuneIconImage = equipmentPropEnchantmentGroupRuneIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B637 RID: 112183 RVA: 0x0084A40C File Offset: 0x0084860C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupRuneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B638 RID: 112184 RVA: 0x0084A464 File Offset: 0x00848664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Text equipmentPropEnchantmentGroupRuneNameText;
			LuaObject.checkType<Text>(l, 2, out equipmentPropEnchantmentGroupRuneNameText);
			bagListUIController.m_luaExportHelper.m_equipmentPropEnchantmentGroupRuneNameText = equipmentPropEnchantmentGroupRuneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B639 RID: 112185 RVA: 0x0084A4C0 File Offset: 0x008486C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subBagInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subBagInfoPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B63A RID: 112186 RVA: 0x0084A518 File Offset: 0x00848718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subBagInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			GameObject subBagInfoPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out subBagInfoPanelObj);
			bagListUIController.m_luaExportHelper.m_subBagInfoPanelObj = subBagInfoPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B63B RID: 112187 RVA: 0x0084A574 File Offset: 0x00848774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemMinusButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subItemMinusButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B63C RID: 112188 RVA: 0x0084A5CC File Offset: 0x008487CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemMinusButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button subItemMinusButton;
			LuaObject.checkType<Button>(l, 2, out subItemMinusButton);
			bagListUIController.m_luaExportHelper.m_subItemMinusButton = subItemMinusButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B63D RID: 112189 RVA: 0x0084A628 File Offset: 0x00848828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemAddButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subItemAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B63E RID: 112190 RVA: 0x0084A680 File Offset: 0x00848880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemAddButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button subItemAddButton;
			LuaObject.checkType<Button>(l, 2, out subItemAddButton);
			bagListUIController.m_luaExportHelper.m_subItemAddButton = subItemAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B63F RID: 112191 RVA: 0x0084A6DC File Offset: 0x008488DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemMaxButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subItemMaxButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B640 RID: 112192 RVA: 0x0084A734 File Offset: 0x00848934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemMaxButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button subItemMaxButton;
			LuaObject.checkType<Button>(l, 2, out subItemMaxButton);
			bagListUIController.m_luaExportHelper.m_subItemMaxButton = subItemMaxButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B641 RID: 112193 RVA: 0x0084A790 File Offset: 0x00848990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemNumInputField(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subItemNumInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B642 RID: 112194 RVA: 0x0084A7E8 File Offset: 0x008489E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemNumInputField(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			InputField subItemNumInputField;
			LuaObject.checkType<InputField>(l, 2, out subItemNumInputField);
			bagListUIController.m_luaExportHelper.m_subItemNumInputField = subItemNumInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B643 RID: 112195 RVA: 0x0084A844 File Offset: 0x00848A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemUseButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subItemUseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B644 RID: 112196 RVA: 0x0084A89C File Offset: 0x00848A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemUseButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button subItemUseButton;
			LuaObject.checkType<Button>(l, 2, out subItemUseButton);
			bagListUIController.m_luaExportHelper.m_subItemUseButton = subItemUseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B645 RID: 112197 RVA: 0x0084A8F8 File Offset: 0x00848AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemPanelReturnButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_subItemPanelReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B646 RID: 112198 RVA: 0x0084A950 File Offset: 0x00848B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemPanelReturnButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button subItemPanelReturnButton;
			LuaObject.checkType<Button>(l, 2, out subItemPanelReturnButton);
			bagListUIController.m_luaExportHelper.m_subItemPanelReturnButton = subItemPanelReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B647 RID: 112199 RVA: 0x0084A9AC File Offset: 0x00848BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addAllItemButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_addAllItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B648 RID: 112200 RVA: 0x0084AA04 File Offset: 0x00848C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addAllItemButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button addAllItemButton;
			LuaObject.checkType<Button>(l, 2, out addAllItemButton);
			bagListUIController.m_luaExportHelper.m_addAllItemButton = addAllItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B649 RID: 112201 RVA: 0x0084AA60 File Offset: 0x00848C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addAllEquipmentButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_addAllEquipmentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B64A RID: 112202 RVA: 0x0084AAB8 File Offset: 0x00848CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addAllEquipmentButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button addAllEquipmentButton;
			LuaObject.checkType<Button>(l, 2, out addAllEquipmentButton);
			bagListUIController.m_luaExportHelper.m_addAllEquipmentButton = addAllEquipmentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B64B RID: 112203 RVA: 0x0084AB14 File Offset: 0x00848D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addItemButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_addItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B64C RID: 112204 RVA: 0x0084AB6C File Offset: 0x00848D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addItemButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button addItemButton;
			LuaObject.checkType<Button>(l, 2, out addItemButton);
			bagListUIController.m_luaExportHelper.m_addItemButton = addItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B64D RID: 112205 RVA: 0x0084ABC8 File Offset: 0x00848DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clearBagItemButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_clearBagItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B64E RID: 112206 RVA: 0x0084AC20 File Offset: 0x00848E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clearBagItemButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button clearBagItemButton;
			LuaObject.checkType<Button>(l, 2, out clearBagItemButton);
			bagListUIController.m_luaExportHelper.m_clearBagItemButton = clearBagItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B64F RID: 112207 RVA: 0x0084AC7C File Offset: 0x00848E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagItemInputField(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagItemInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B650 RID: 112208 RVA: 0x0084ACD4 File Offset: 0x00848ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagItemInputField(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			InputField bagItemInputField;
			LuaObject.checkType<InputField>(l, 2, out bagItemInputField);
			bagListUIController.m_luaExportHelper.m_bagItemInputField = bagItemInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B651 RID: 112209 RVA: 0x0084AD30 File Offset: 0x00848F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_speedUpButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_speedUpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B652 RID: 112210 RVA: 0x0084AD88 File Offset: 0x00848F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_speedUpButton(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			Button speedUpButton;
			LuaObject.checkType<Button>(l, 2, out speedUpButton);
			bagListUIController.m_luaExportHelper.m_speedUpButton = speedUpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B653 RID: 112211 RVA: 0x0084ADE4 File Offset: 0x00848FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_displayType(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)bagListUIController.m_luaExportHelper.m_displayType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B654 RID: 112212 RVA: 0x0084AE3C File Offset: 0x0084903C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_displayType(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 2, out displayType);
			bagListUIController.m_luaExportHelper.m_displayType = displayType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B655 RID: 112213 RVA: 0x0084AE98 File Offset: 0x00849098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastClickBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_lastClickBagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B656 RID: 112214 RVA: 0x0084AEF0 File Offset: 0x008490F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastClickBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagItemBase lastClickBagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out lastClickBagItem);
			bagListUIController.m_luaExportHelper.m_lastClickBagItem = lastClickBagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B657 RID: 112215 RVA: 0x0084AF4C File Offset: 0x0084914C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastClickBagItemType(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)bagListUIController.m_luaExportHelper.m_lastClickBagItemType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B658 RID: 112216 RVA: 0x0084AFA4 File Offset: 0x008491A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastClickBagItemType(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			BagListUIController.DisplayType lastClickBagItemType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 2, out lastClickBagItemType);
			bagListUIController.m_luaExportHelper.m_lastClickBagItemType = lastClickBagItemType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B659 RID: 112217 RVA: 0x0084B000 File Offset: 0x00849200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagItemCache(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagItemCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B65A RID: 112218 RVA: 0x0084B058 File Offset: 0x00849258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagItemCache(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			List<BagItemBase> bagItemCache;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out bagItemCache);
			bagListUIController.m_luaExportHelper.m_bagItemCache = bagItemCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B65B RID: 112219 RVA: 0x0084B0B4 File Offset: 0x008492B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_bagItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B65C RID: 112220 RVA: 0x0084B10C File Offset: 0x0084930C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			List<BagItemUIController> bagItemCtrlList;
			LuaObject.checkType<List<BagItemUIController>>(l, 2, out bagItemCtrlList);
			bagListUIController.m_luaExportHelper.m_bagItemCtrlList = bagItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B65D RID: 112221 RVA: 0x0084B168 File Offset: 0x00849368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B65E RID: 112222 RVA: 0x0084B1C0 File Offset: 0x008493C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			bagListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B65F RID: 112223 RVA: 0x0084B21C File Offset: 0x0084941C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B660 RID: 112224 RVA: 0x0084B274 File Offset: 0x00849474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BagListUIController bagListUIController = (BagListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			bagListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B661 RID: 112225 RVA: 0x0084B2D0 File Offset: 0x008494D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagListUIController");
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.UpdateViewInBagList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.ResetBagUIView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.CloseBagInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.InitLoopScrollViewRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.IsBagItemOfDisplayType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.ShowNoItemPanelObj);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.BagItemComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnBagItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnBagItemNeedFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetEquipmentInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetEquipmentSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetEquipmentLimitInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetEquipmentEnchantInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetEquipmentPropItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.SetBagCountLimit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnGetItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnEquipmentForgeButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnUseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnSubItemUseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.CloseSubItemUsePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnInputEditEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnItemMinusButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnItemAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnItemMaxButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnAddAllItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnAddAllEquipmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnAddItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnClearBagButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnSpeedUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnItemToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnJobMaterialToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnEquipmentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnFragmentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.OnToggleChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnClearBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnClearBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnSpeedUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnSpeedUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnAddAllItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnAddAllItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnAddAllEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnAddAllEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnAddItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnAddItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnUse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnUse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnEquipmentForge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnEquipmentForge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__callDele_EventOnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.__clearDele_EventOnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache48);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache49, true);
		string name2 = "EventOnClearBag";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnClearBag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4A, true);
		string name3 = "EventOnSpeedUp";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnSpeedUp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4B, true);
		string name4 = "EventOnAddAllItem";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnAddAllItem);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4C, true);
		string name5 = "EventOnAddAllEquipment";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnAddAllEquipment);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4D, true);
		string name6 = "EventOnAlchemyButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnAlchemyButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4E, true);
		string name7 = "EventOnAddItem";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnAddItem);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache4F, true);
		string name8 = "EventOnUse";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnUse);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache50, true);
		string name9 = "EventOnEquipmentForge";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnEquipmentForge);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache51, true);
		string name10 = "EventOnShowGetPath";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_EventOnShowGetPath);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache52, true);
		string name11 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_marginTransform);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache54, true);
		string name12 = "m_itemToggle";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_itemToggle);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_itemToggle);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache56, true);
		string name13 = "m_equipmentToggle";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentToggle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentToggle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache58, true);
		string name14 = "m_fragmentToggle";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_fragmentToggle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_fragmentToggle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5A, true);
		string name15 = "m_jobMaterialToggle";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_jobMaterialToggle);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_jobMaterialToggle);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5C, true);
		string name16 = "m_alchemyButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_alchemyButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_alchemyButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5E, true);
		string name17 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_returnButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache60, true);
		string name18 = "m_loopScrollView";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_loopScrollView);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_loopScrollView);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache62, true);
		string name19 = "m_listItemPool";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_listItemPool);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_listItemPool);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache64, true);
		string name20 = "m_listScrollViewItemTemplateRoot";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_listScrollViewItemTemplateRoot);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_listScrollViewItemTemplateRoot);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache66, true);
		string name21 = "m_scrollViewBagItemContent";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_scrollViewBagItemContent);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_scrollViewBagItemContent);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache68, true);
		string name22 = "m_bagListPointBgContent";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagListPointBgContent);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagListPointBgContent);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6A, true);
		string name23 = "m_bagListPointItem";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagListPointItem);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagListPointItem);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6C, true);
		string name24 = "m_noItemPanelObj";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_noItemPanelObj);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_noItemPanelObj);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6E, true);
		string name25 = "m_bagInfoPanelObj";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagInfoPanelObj);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagInfoPanelObj);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache70, true);
		string name26 = "m_bagInfoStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagInfoStateCtrl);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagInfoStateCtrl);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache72, true);
		string name27 = "m_useButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_useButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_useButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache74, true);
		string name28 = "m_itemNameText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_itemNameText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_itemNameText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache76, true);
		string name29 = "m_itemCountText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_itemCountText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_itemCountText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache78, true);
		string name30 = "m_itemDescText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_itemDescText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_itemDescText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7A, true);
		string name31 = "m_itemIconImage";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_itemIconImage);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_itemIconImage);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7C, true);
		string name32 = "m_itemGetButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_itemGetButton);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_itemGetButton);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7E, true);
		string name33 = "m_bagCountLimitStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagCountLimitStateCtrl);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagCountLimitStateCtrl);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache80, true);
		string name34 = "m_bagCountText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagCountText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagCountText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache82, true);
		string name35 = "m_bagMaxCountText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagMaxCountText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagMaxCountText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache84, true);
		string name36 = "m_equipmentInfoExplainText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentInfoExplainText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentInfoExplainText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache86, true);
		string name37 = "m_equipmentForgeButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentForgeButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentForgeButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache88, true);
		string name38 = "m_equipmentSkillStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillStateCtrl);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillStateCtrl);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8A, true);
		string name39 = "m_equipmentSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillNameText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillNameText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8C, true);
		string name40 = "m_equipmentSkillLvValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillLvValueText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillLvValueText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8E, true);
		string name41 = "m_equipmentSkillUnlockCoditionText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillUnlockCoditionText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillUnlockCoditionText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache90, true);
		string name42 = "m_equipmentSkillCharNameText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillCharNameText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillCharNameText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache92, true);
		string name43 = "m_equipmentSkillCharNameBGImage";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillCharNameBGImage);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillCharNameBGImage);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache94, true);
		string name44 = "m_equipmentSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillDescText);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillDescText);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache96, true);
		string name45 = "m_equipmentSkillContentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentSkillContentStateCtrl);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentSkillContentStateCtrl);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache98, true);
		string name46 = "m_equipmentLimitStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentLimitStateCtrl);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentLimitStateCtrl);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9A, true);
		string name47 = "m_equipmentLimitContent";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentLimitContent);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentLimitContent);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9C, true);
		string name48 = "m_equipmentEquipUnlimitText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentEquipUnlimitText);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentEquipUnlimitText);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9E, true);
		string name49 = "m_equipmentPropertyGroup";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropertyGroup);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropertyGroup);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA0, true);
		string name50 = "m_equipmentPropATGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropATGo);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropATGo);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA2, true);
		string name51 = "m_equipmentPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropATValueText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropATValueText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA4, true);
		string name52 = "m_equipmentPropDFGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropDFGo);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropDFGo);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA6, true);
		string name53 = "m_equipmentPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropDFValueText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropDFValueText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA8, true);
		string name54 = "m_equipmentPropHPGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropHPGo);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropHPGo);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAA, true);
		string name55 = "m_equipmentPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropHPValueText);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropHPValueText);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAC, true);
		string name56 = "m_equipmentPropMagiccGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropMagiccGo);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropMagiccGo);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAE, true);
		string name57 = "m_equipmentPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropMagicValueText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropMagicValueText);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB0, true);
		string name58 = "m_equipmentPropMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropMagicDFGo);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropMagicDFGo);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB2, true);
		string name59 = "m_equipmentPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropMagicDFValueText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropMagicDFValueText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB4, true);
		string name60 = "m_equipmentPropDexGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropDexGo);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropDexGo);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB6, true);
		string name61 = "m_equipmentPropDexValueText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropDexValueText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropDexValueText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB8, true);
		string name62 = "m_equipmentPropGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropGroupStateCtrl);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropGroupStateCtrl);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBA, true);
		string name63 = "m_equipmentPropEnchantmentGroup";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropEnchantmentGroup);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropEnchantmentGroup);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBC, true);
		string name64 = "m_equipmentPropEnchantmentGroupResonanceGo";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropEnchantmentGroupResonanceGo);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropEnchantmentGroupResonanceGo);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBE, true);
		string name65 = "m_equipmentPropEnchantmentGroupRuneStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropEnchantmentGroupRuneStateCtrl);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropEnchantmentGroupRuneStateCtrl);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC0, true);
		string name66 = "m_equipmentPropEnchantmentGroupRuneIconImage";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropEnchantmentGroupRuneIconImage);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropEnchantmentGroupRuneIconImage);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC2, true);
		string name67 = "m_equipmentPropEnchantmentGroupRuneNameText";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_equipmentPropEnchantmentGroupRuneNameText);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_equipmentPropEnchantmentGroupRuneNameText);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC4, true);
		string name68 = "m_subBagInfoPanelObj";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subBagInfoPanelObj);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subBagInfoPanelObj);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC6, true);
		string name69 = "m_subItemMinusButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subItemMinusButton);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subItemMinusButton);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC8, true);
		string name70 = "m_subItemAddButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subItemAddButton);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subItemAddButton);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCA, true);
		string name71 = "m_subItemMaxButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subItemMaxButton);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subItemMaxButton);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCC, true);
		string name72 = "m_subItemNumInputField";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subItemNumInputField);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subItemNumInputField);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCE, true);
		string name73 = "m_subItemUseButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subItemUseButton);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subItemUseButton);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD0, true);
		string name74 = "m_subItemPanelReturnButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_subItemPanelReturnButton);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_subItemPanelReturnButton);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD2, true);
		string name75 = "m_addAllItemButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_addAllItemButton);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_addAllItemButton);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD4, true);
		string name76 = "m_addAllEquipmentButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_addAllEquipmentButton);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_addAllEquipmentButton);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD6, true);
		string name77 = "m_addItemButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_addItemButton);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_addItemButton);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD8, true);
		string name78 = "m_clearBagItemButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_clearBagItemButton);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_clearBagItemButton);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDA, true);
		string name79 = "m_bagItemInputField";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagItemInputField);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagItemInputField);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDC, true);
		string name80 = "m_speedUpButton";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_speedUpButton);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_speedUpButton);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDE, true);
		string name81 = "m_displayType";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_displayType);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_displayType);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE0, true);
		string name82 = "m_lastClickBagItem";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_lastClickBagItem);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_lastClickBagItem);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE2, true);
		string name83 = "m_lastClickBagItemType";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_lastClickBagItemType);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_lastClickBagItemType);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE4, true);
		string name84 = "m_bagItemCache";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagItemCache);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagItemCache);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE6, true);
		string name85 = "m_bagItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_bagItemCtrlList);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_bagItemCtrlList);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE8, true);
		string name86 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_playerContext);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEA, true);
		string name87 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_BagListUIController.<>f__mg$cacheEC, true);
		LuaObject.createTypeMetatable(l, null, typeof(BagListUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401182A RID: 71722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401182B RID: 71723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401182C RID: 71724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401182D RID: 71725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401182E RID: 71726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401182F RID: 71727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011830 RID: 71728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011831 RID: 71729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011832 RID: 71730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011833 RID: 71731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011834 RID: 71732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011835 RID: 71733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011836 RID: 71734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011837 RID: 71735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011838 RID: 71736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011839 RID: 71737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401183A RID: 71738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401183B RID: 71739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401183C RID: 71740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401183D RID: 71741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401183E RID: 71742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401183F RID: 71743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011840 RID: 71744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011841 RID: 71745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011842 RID: 71746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011843 RID: 71747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011844 RID: 71748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011845 RID: 71749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011846 RID: 71750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011847 RID: 71751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011848 RID: 71752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011849 RID: 71753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401184A RID: 71754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401184B RID: 71755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401184C RID: 71756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401184D RID: 71757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401184E RID: 71758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401184F RID: 71759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011850 RID: 71760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011851 RID: 71761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011852 RID: 71762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011853 RID: 71763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011854 RID: 71764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011855 RID: 71765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011856 RID: 71766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011857 RID: 71767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011858 RID: 71768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011859 RID: 71769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401185A RID: 71770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401185B RID: 71771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401185C RID: 71772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401185D RID: 71773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401185E RID: 71774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401185F RID: 71775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011860 RID: 71776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011861 RID: 71777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011862 RID: 71778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011863 RID: 71779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011864 RID: 71780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011865 RID: 71781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011866 RID: 71782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011867 RID: 71783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011868 RID: 71784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011869 RID: 71785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401186A RID: 71786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401186B RID: 71787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401186C RID: 71788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401186D RID: 71789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401186E RID: 71790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401186F RID: 71791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011870 RID: 71792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011871 RID: 71793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011872 RID: 71794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011873 RID: 71795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011874 RID: 71796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011875 RID: 71797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011876 RID: 71798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011877 RID: 71799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011878 RID: 71800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011879 RID: 71801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401187A RID: 71802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401187B RID: 71803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401187C RID: 71804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401187D RID: 71805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401187E RID: 71806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401187F RID: 71807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011880 RID: 71808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011881 RID: 71809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011882 RID: 71810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011883 RID: 71811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011884 RID: 71812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011885 RID: 71813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011886 RID: 71814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011887 RID: 71815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011888 RID: 71816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011889 RID: 71817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401188A RID: 71818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401188B RID: 71819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401188C RID: 71820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401188D RID: 71821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401188E RID: 71822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401188F RID: 71823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011890 RID: 71824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011891 RID: 71825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011892 RID: 71826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011893 RID: 71827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011894 RID: 71828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011895 RID: 71829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011896 RID: 71830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011897 RID: 71831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011898 RID: 71832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04011899 RID: 71833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401189A RID: 71834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401189B RID: 71835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0401189C RID: 71836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0401189D RID: 71837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401189E RID: 71838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401189F RID: 71839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040118A0 RID: 71840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040118A1 RID: 71841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040118A2 RID: 71842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040118A3 RID: 71843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040118A4 RID: 71844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040118A5 RID: 71845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040118A6 RID: 71846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040118A7 RID: 71847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040118A8 RID: 71848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040118A9 RID: 71849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040118AA RID: 71850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040118AB RID: 71851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040118AC RID: 71852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040118AD RID: 71853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040118AE RID: 71854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040118AF RID: 71855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040118B0 RID: 71856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040118B1 RID: 71857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040118B2 RID: 71858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040118B3 RID: 71859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040118B4 RID: 71860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040118B5 RID: 71861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040118B6 RID: 71862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040118B7 RID: 71863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040118B8 RID: 71864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040118B9 RID: 71865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040118BA RID: 71866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040118BB RID: 71867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040118BC RID: 71868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040118BD RID: 71869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040118BE RID: 71870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040118BF RID: 71871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040118C0 RID: 71872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040118C1 RID: 71873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040118C2 RID: 71874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040118C3 RID: 71875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040118C4 RID: 71876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040118C5 RID: 71877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040118C6 RID: 71878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040118C7 RID: 71879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040118C8 RID: 71880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040118C9 RID: 71881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040118CA RID: 71882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040118CB RID: 71883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040118CC RID: 71884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040118CD RID: 71885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040118CE RID: 71886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040118CF RID: 71887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040118D0 RID: 71888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040118D1 RID: 71889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040118D2 RID: 71890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040118D3 RID: 71891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040118D4 RID: 71892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040118D5 RID: 71893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040118D6 RID: 71894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040118D7 RID: 71895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040118D8 RID: 71896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040118D9 RID: 71897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040118DA RID: 71898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040118DB RID: 71899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040118DC RID: 71900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040118DD RID: 71901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040118DE RID: 71902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040118DF RID: 71903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040118E0 RID: 71904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040118E1 RID: 71905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040118E2 RID: 71906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040118E3 RID: 71907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040118E4 RID: 71908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040118E5 RID: 71909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040118E6 RID: 71910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040118E7 RID: 71911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040118E8 RID: 71912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040118E9 RID: 71913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040118EA RID: 71914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040118EB RID: 71915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040118EC RID: 71916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040118ED RID: 71917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040118EE RID: 71918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040118EF RID: 71919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040118F0 RID: 71920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040118F1 RID: 71921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040118F2 RID: 71922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040118F3 RID: 71923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040118F4 RID: 71924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040118F5 RID: 71925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040118F6 RID: 71926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040118F7 RID: 71927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040118F8 RID: 71928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040118F9 RID: 71929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040118FA RID: 71930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040118FB RID: 71931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040118FC RID: 71932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040118FD RID: 71933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040118FE RID: 71934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040118FF RID: 71935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04011900 RID: 71936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04011901 RID: 71937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04011902 RID: 71938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04011903 RID: 71939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04011904 RID: 71940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04011905 RID: 71941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04011906 RID: 71942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04011907 RID: 71943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04011908 RID: 71944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04011909 RID: 71945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0401190A RID: 71946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x0401190B RID: 71947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x0401190C RID: 71948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x0401190D RID: 71949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x0401190E RID: 71950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x0401190F RID: 71951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04011910 RID: 71952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04011911 RID: 71953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04011912 RID: 71954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04011913 RID: 71955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04011914 RID: 71956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04011915 RID: 71957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04011916 RID: 71958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;
}
