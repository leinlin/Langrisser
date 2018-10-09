using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200135A RID: 4954
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AlchemyUIController : LuaObject
{
	// Token: 0x0601AA98 RID: 109208 RVA: 0x007EF66C File Offset: 0x007ED86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA99 RID: 109209 RVA: 0x007EF6B8 File Offset: 0x007ED8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA9A RID: 109210 RVA: 0x007EF704 File Offset: 0x007ED904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetAlchemyUIView(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.ResetAlchemyUIView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA9B RID: 109211 RVA: 0x007EF750 File Offset: 0x007ED950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA9C RID: 109212 RVA: 0x007EF7A4 File Offset: 0x007ED9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLoopScrollViewRect(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.InitLoopScrollViewRect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA9D RID: 109213 RVA: 0x007EF7F8 File Offset: 0x007ED9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.SetPointBgContent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA9E RID: 109214 RVA: 0x007EF84C File Offset: 0x007EDA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBagItemOfDisplayType(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			BagItemBase itm;
			LuaObject.checkType<BagItemBase>(l, 2, out itm);
			bool b = alchemyUIController.m_luaExportHelper.IsBagItemOfDisplayType(itm);
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

	// Token: 0x0601AA9F RID: 109215 RVA: 0x007EF8B4 File Offset: 0x007EDAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagItemComparer(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			BagItemBase item;
			LuaObject.checkType<BagItemBase>(l, 2, out item);
			BagItemBase item2;
			LuaObject.checkType<BagItemBase>(l, 3, out item2);
			int i = alchemyUIController.m_luaExportHelper.BagItemComparer(item, item2);
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

	// Token: 0x0601AAA0 RID: 109216 RVA: 0x007EF928 File Offset: 0x007EDB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBagItemClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			alchemyUIController.m_luaExportHelper.OnBagItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA1 RID: 109217 RVA: 0x007EF984 File Offset: 0x007EDB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRewardListPanel(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.ShowRewardListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA2 RID: 109218 RVA: 0x007EF9D8 File Offset: 0x007EDBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseRewardListPanel(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.CloseRewardListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA3 RID: 109219 RVA: 0x007EFA2C File Offset: 0x007EDC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBagItemNeedFill(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			alchemyUIController.m_luaExportHelper.OnBagItemNeedFill(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA4 RID: 109220 RVA: 0x007EFA88 File Offset: 0x007EDC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseRewardGoodsDescPanel(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.CloseRewardGoodsDescPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA5 RID: 109221 RVA: 0x007EFADC File Offset: 0x007EDCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenSubUseItemPanel(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OpenSubUseItemPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA6 RID: 109222 RVA: 0x007EFB30 File Offset: 0x007EDD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLastAlchemyCount(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string lastAlchemyCount;
			LuaObject.checkType(l, 2, out lastAlchemyCount);
			alchemyUIController.m_luaExportHelper.SetLastAlchemyCount(lastAlchemyCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA7 RID: 109223 RVA: 0x007EFB8C File Offset: 0x007EDD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastAlchemyCount(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			int lastAlchemyCount = alchemyUIController.m_luaExportHelper.GetLastAlchemyCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastAlchemyCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA8 RID: 109224 RVA: 0x007EFBE8 File Offset: 0x007EDDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubItemUseItemClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnSubItemUseItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAA9 RID: 109225 RVA: 0x007EFC3C File Offset: 0x007EDE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemMinusButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnItemMinusButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAAA RID: 109226 RVA: 0x007EFC90 File Offset: 0x007EDE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnItemAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAAB RID: 109227 RVA: 0x007EFCE4 File Offset: 0x007EDEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemMaxButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnItemMaxButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAAC RID: 109228 RVA: 0x007EFD38 File Offset: 0x007EDF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSubItemUsePanel(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.CloseSubItemUsePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAAD RID: 109229 RVA: 0x007EFD8C File Offset: 0x007EDF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInputEditEnd(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string str;
			LuaObject.checkType(l, 2, out str);
			alchemyUIController.m_luaExportHelper.OnInputEditEnd(str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAAE RID: 109230 RVA: 0x007EFDE8 File Offset: 0x007EDFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAAF RID: 109231 RVA: 0x007EFE3C File Offset: 0x007EE03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB0 RID: 109232 RVA: 0x007EFE90 File Offset: 0x007EE090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnAlchemyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB1 RID: 109233 RVA: 0x007EFEE4 File Offset: 0x007EE0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAlchemySucceed(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			IEnumerator o = alchemyUIController.m_luaExportHelper.OnAlchemySucceed(rewards);
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

	// Token: 0x0601AAB2 RID: 109234 RVA: 0x007EFF4C File Offset: 0x007EE14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB3 RID: 109235 RVA: 0x007EFFA0 File Offset: 0x007EE1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			alchemyUIController.m_luaExportHelper.OnItemToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB4 RID: 109236 RVA: 0x007EFFFC File Offset: 0x007EE1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobMaterialToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			alchemyUIController.m_luaExportHelper.OnJobMaterialToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB5 RID: 109237 RVA: 0x007F0058 File Offset: 0x007EE258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			alchemyUIController.m_luaExportHelper.OnEquipmentToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB6 RID: 109238 RVA: 0x007F00B4 File Offset: 0x007EE2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFragmentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			alchemyUIController.m_luaExportHelper.OnFragmentToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB7 RID: 109239 RVA: 0x007F0110 File Offset: 0x007EE310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.OnToggleChanged();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB8 RID: 109240 RVA: 0x007F0164 File Offset: 0x007EE364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			alchemyUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAB9 RID: 109241 RVA: 0x007F01D0 File Offset: 0x007EE3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AABA RID: 109242 RVA: 0x007F0224 File Offset: 0x007EE424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AABB RID: 109243 RVA: 0x007F0278 File Offset: 0x007EE478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = alchemyUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AABC RID: 109244 RVA: 0x007F0320 File Offset: 0x007EE520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AABD RID: 109245 RVA: 0x007F0374 File Offset: 0x007EE574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			alchemyUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AABE RID: 109246 RVA: 0x007F03E0 File Offset: 0x007EE5E0
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
				AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				alchemyUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				AlchemyUIController alchemyUIController2 = (AlchemyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				alchemyUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AABF RID: 109247 RVA: 0x007F04F0 File Offset: 0x007EE6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			alchemyUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC0 RID: 109248 RVA: 0x007F055C File Offset: 0x007EE75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			alchemyUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC1 RID: 109249 RVA: 0x007F05C8 File Offset: 0x007EE7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			alchemyUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC2 RID: 109250 RVA: 0x007F0634 File Offset: 0x007EE834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			alchemyUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC3 RID: 109251 RVA: 0x007F06A0 File Offset: 0x007EE8A0
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
				AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				alchemyUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				AlchemyUIController alchemyUIController2 = (AlchemyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				alchemyUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AAC4 RID: 109252 RVA: 0x007F07B0 File Offset: 0x007EE9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			string s = alchemyUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AAC5 RID: 109253 RVA: 0x007F080C File Offset: 0x007EEA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC6 RID: 109254 RVA: 0x007F0860 File Offset: 0x007EEA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC7 RID: 109255 RVA: 0x007F08B4 File Offset: 0x007EEAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC8 RID: 109256 RVA: 0x007F0908 File Offset: 0x007EEB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			alchemyUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAC9 RID: 109257 RVA: 0x007F095C File Offset: 0x007EEB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			List<ProGoods> arg;
			LuaObject.checkType<List<ProGoods>>(l, 2, out arg);
			Action<List<Goods>> arg2;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 3, out arg2);
			alchemyUIController.m_luaExportHelper.__callDele_EventOnAlchemyButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AACA RID: 109258 RVA: 0x007F09C8 File Offset: 0x007EEBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			List<ProGoods> arg;
			LuaObject.checkType<List<ProGoods>>(l, 2, out arg);
			Action<List<Goods>> arg2;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 3, out arg2);
			alchemyUIController.m_luaExportHelper.__clearDele_EventOnAlchemyButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AACB RID: 109259 RVA: 0x007F0A34 File Offset: 0x007EEC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					alchemyUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					alchemyUIController.EventOnReturn -= value;
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

	// Token: 0x0601AACC RID: 109260 RVA: 0x007F0AB4 File Offset: 0x007EECB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					alchemyUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					alchemyUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601AACD RID: 109261 RVA: 0x007F0B34 File Offset: 0x007EED34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Action<List<ProGoods>, Action<List<Goods>>> value;
			int num = LuaObject.checkDelegate<Action<List<ProGoods>, Action<List<Goods>>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					alchemyUIController.EventOnAlchemyButtonClick += value;
				}
				else if (num == 2)
				{
					alchemyUIController.EventOnAlchemyButtonClick -= value;
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

	// Token: 0x0601AACE RID: 109262 RVA: 0x007F0BB4 File Offset: 0x007EEDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AACF RID: 109263 RVA: 0x007F0C0C File Offset: 0x007EEE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			alchemyUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD0 RID: 109264 RVA: 0x007F0C68 File Offset: 0x007EEE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mithralStoneText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_mithralStoneText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD1 RID: 109265 RVA: 0x007F0CC0 File Offset: 0x007EEEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mithralStoneText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Text mithralStoneText;
			LuaObject.checkType<Text>(l, 2, out mithralStoneText);
			alchemyUIController.m_luaExportHelper.m_mithralStoneText = mithralStoneText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD2 RID: 109266 RVA: 0x007F0D1C File Offset: 0x007EEF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_brillianceMithralStoneText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_brillianceMithralStoneText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD3 RID: 109267 RVA: 0x007F0D74 File Offset: 0x007EEF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_brillianceMithralStoneText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Text brillianceMithralStoneText;
			LuaObject.checkType<Text>(l, 2, out brillianceMithralStoneText);
			alchemyUIController.m_luaExportHelper.m_brillianceMithralStoneText = brillianceMithralStoneText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD4 RID: 109268 RVA: 0x007F0DD0 File Offset: 0x007EEFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_itemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD5 RID: 109269 RVA: 0x007F0E28 File Offset: 0x007EF028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Toggle itemToggle;
			LuaObject.checkType<Toggle>(l, 2, out itemToggle);
			alchemyUIController.m_luaExportHelper.m_itemToggle = itemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD6 RID: 109270 RVA: 0x007F0E84 File Offset: 0x007EF084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_equipmentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD7 RID: 109271 RVA: 0x007F0EDC File Offset: 0x007EF0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Toggle equipmentToggle;
			LuaObject.checkType<Toggle>(l, 2, out equipmentToggle);
			alchemyUIController.m_luaExportHelper.m_equipmentToggle = equipmentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD8 RID: 109272 RVA: 0x007F0F38 File Offset: 0x007EF138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fragmentToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_fragmentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAD9 RID: 109273 RVA: 0x007F0F90 File Offset: 0x007EF190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fragmentToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Toggle fragmentToggle;
			LuaObject.checkType<Toggle>(l, 2, out fragmentToggle);
			alchemyUIController.m_luaExportHelper.m_fragmentToggle = fragmentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AADA RID: 109274 RVA: 0x007F0FEC File Offset: 0x007EF1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_jobMaterialToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AADB RID: 109275 RVA: 0x007F1044 File Offset: 0x007EF244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialToggle(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Toggle jobMaterialToggle;
			LuaObject.checkType<Toggle>(l, 2, out jobMaterialToggle);
			alchemyUIController.m_luaExportHelper.m_jobMaterialToggle = jobMaterialToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AADC RID: 109276 RVA: 0x007F10A0 File Offset: 0x007EF2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alchemyButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_alchemyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AADD RID: 109277 RVA: 0x007F10F8 File Offset: 0x007EF2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alchemyButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button alchemyButton;
			LuaObject.checkType<Button>(l, 2, out alchemyButton);
			alchemyUIController.m_luaExportHelper.m_alchemyButton = alchemyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AADE RID: 109278 RVA: 0x007F1154 File Offset: 0x007EF354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alchemyButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_alchemyButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AADF RID: 109279 RVA: 0x007F11AC File Offset: 0x007EF3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alchemyButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			CommonUIStateController alchemyButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out alchemyButtonStateCtrl);
			alchemyUIController.m_luaExportHelper.m_alchemyButtonStateCtrl = alchemyButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE0 RID: 109280 RVA: 0x007F1208 File Offset: 0x007EF408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectGameObject(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_effectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE1 RID: 109281 RVA: 0x007F1260 File Offset: 0x007EF460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectGameObject(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject effectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out effectGameObject);
			alchemyUIController.m_luaExportHelper.m_effectGameObject = effectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE2 RID: 109282 RVA: 0x007F12BC File Offset: 0x007EF4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE3 RID: 109283 RVA: 0x007F1314 File Offset: 0x007EF514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			alchemyUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE4 RID: 109284 RVA: 0x007F1370 File Offset: 0x007EF570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE5 RID: 109285 RVA: 0x007F13C8 File Offset: 0x007EF5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			alchemyUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE6 RID: 109286 RVA: 0x007F1424 File Offset: 0x007EF624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_loopScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE7 RID: 109287 RVA: 0x007F147C File Offset: 0x007EF67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loopScrollView(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LoopVerticalScrollRect loopScrollView;
			LuaObject.checkType<LoopVerticalScrollRect>(l, 2, out loopScrollView);
			alchemyUIController.m_luaExportHelper.m_loopScrollView = loopScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE8 RID: 109288 RVA: 0x007F14D8 File Offset: 0x007EF6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_listItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAE9 RID: 109289 RVA: 0x007F1530 File Offset: 0x007EF730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listItemPool(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			EasyObjectPool listItemPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out listItemPool);
			alchemyUIController.m_luaExportHelper.m_listItemPool = listItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAEA RID: 109290 RVA: 0x007F158C File Offset: 0x007EF78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listScrollViewItemTemplateRoot(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_listScrollViewItemTemplateRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAEB RID: 109291 RVA: 0x007F15E4 File Offset: 0x007EF7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listScrollViewItemTemplateRoot(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject listScrollViewItemTemplateRoot;
			LuaObject.checkType<GameObject>(l, 2, out listScrollViewItemTemplateRoot);
			alchemyUIController.m_luaExportHelper.m_listScrollViewItemTemplateRoot = listScrollViewItemTemplateRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAEC RID: 109292 RVA: 0x007F1640 File Offset: 0x007EF840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewBagItemContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_scrollViewBagItemContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAED RID: 109293 RVA: 0x007F1698 File Offset: 0x007EF898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewBagItemContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject scrollViewBagItemContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewBagItemContent);
			alchemyUIController.m_luaExportHelper.m_scrollViewBagItemContent = scrollViewBagItemContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAEE RID: 109294 RVA: 0x007F16F4 File Offset: 0x007EF8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagListPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_bagListPointBgContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAEF RID: 109295 RVA: 0x007F174C File Offset: 0x007EF94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagListPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject bagListPointBgContent;
			LuaObject.checkType<GameObject>(l, 2, out bagListPointBgContent);
			alchemyUIController.m_luaExportHelper.m_bagListPointBgContent = bagListPointBgContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF0 RID: 109296 RVA: 0x007F17A8 File Offset: 0x007EF9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagListPointItem(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_bagListPointItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF1 RID: 109297 RVA: 0x007F1800 File Offset: 0x007EFA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagListPointItem(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject bagListPointItem;
			LuaObject.checkType<GameObject>(l, 2, out bagListPointItem);
			alchemyUIController.m_luaExportHelper.m_bagListPointItem = bagListPointItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF2 RID: 109298 RVA: 0x007F185C File Offset: 0x007EFA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardListPanelGo(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardListPanelGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF3 RID: 109299 RVA: 0x007F18B4 File Offset: 0x007EFAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardListPanelGo(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject rewardListPanelGo;
			LuaObject.checkType<GameObject>(l, 2, out rewardListPanelGo);
			alchemyUIController.m_luaExportHelper.m_rewardListPanelGo = rewardListPanelGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF4 RID: 109300 RVA: 0x007F1910 File Offset: 0x007EFB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardListPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardListPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF5 RID: 109301 RVA: 0x007F1968 File Offset: 0x007EFB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardListPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			CommonUIStateController rewardListPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out rewardListPanelStateCtrl);
			alchemyUIController.m_luaExportHelper.m_rewardListPanelStateCtrl = rewardListPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF6 RID: 109302 RVA: 0x007F19C4 File Offset: 0x007EFBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF7 RID: 109303 RVA: 0x007F1A1C File Offset: 0x007EFC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsContent(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject rewardsContent;
			LuaObject.checkType<GameObject>(l, 2, out rewardsContent);
			alchemyUIController.m_luaExportHelper.m_rewardsContent = rewardsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF8 RID: 109304 RVA: 0x007F1A78 File Offset: 0x007EFC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsNothingGo(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardsNothingGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAF9 RID: 109305 RVA: 0x007F1AD0 File Offset: 0x007EFCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsNothingGo(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject rewardsNothingGo;
			LuaObject.checkType<GameObject>(l, 2, out rewardsNothingGo);
			alchemyUIController.m_luaExportHelper.m_rewardsNothingGo = rewardsNothingGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAFA RID: 109306 RVA: 0x007F1B2C File Offset: 0x007EFD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsMaterialCountText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardsMaterialCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAFB RID: 109307 RVA: 0x007F1B84 File Offset: 0x007EFD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsMaterialCountText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Text rewardsMaterialCountText;
			LuaObject.checkType<Text>(l, 2, out rewardsMaterialCountText);
			alchemyUIController.m_luaExportHelper.m_rewardsMaterialCountText = rewardsMaterialCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAFC RID: 109308 RVA: 0x007F1BE0 File Offset: 0x007EFDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsGoldenValueText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardsGoldenValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAFD RID: 109309 RVA: 0x007F1C38 File Offset: 0x007EFE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsGoldenValueText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Text rewardsGoldenValueText;
			LuaObject.checkType<Text>(l, 2, out rewardsGoldenValueText);
			alchemyUIController.m_luaExportHelper.m_rewardsGoldenValueText = rewardsGoldenValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAFE RID: 109310 RVA: 0x007F1C94 File Offset: 0x007EFE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsNoticTextGo(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardsNoticTextGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AAFF RID: 109311 RVA: 0x007F1CEC File Offset: 0x007EFEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsNoticTextGo(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject rewardsNoticTextGo;
			LuaObject.checkType<GameObject>(l, 2, out rewardsNoticTextGo);
			alchemyUIController.m_luaExportHelper.m_rewardsNoticTextGo = rewardsNoticTextGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB00 RID: 109312 RVA: 0x007F1D48 File Offset: 0x007EFF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsNoticText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_rewardsNoticText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB01 RID: 109313 RVA: 0x007F1DA0 File Offset: 0x007EFFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsNoticText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Text rewardsNoticText;
			LuaObject.checkType<Text>(l, 2, out rewardsNoticText);
			alchemyUIController.m_luaExportHelper.m_rewardsNoticText = rewardsNoticText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB02 RID: 109314 RVA: 0x007F1DFC File Offset: 0x007EFFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subBagInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subBagInfoPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB03 RID: 109315 RVA: 0x007F1E54 File Offset: 0x007F0054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subBagInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			GameObject subBagInfoPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out subBagInfoPanelObj);
			alchemyUIController.m_luaExportHelper.m_subBagInfoPanelObj = subBagInfoPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB04 RID: 109316 RVA: 0x007F1EB0 File Offset: 0x007F00B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemNumInputField(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemNumInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB05 RID: 109317 RVA: 0x007F1F08 File Offset: 0x007F0108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemNumInputField(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			InputField subItemNumInputField;
			LuaObject.checkType<InputField>(l, 2, out subItemNumInputField);
			alchemyUIController.m_luaExportHelper.m_subItemNumInputField = subItemNumInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB06 RID: 109318 RVA: 0x007F1F64 File Offset: 0x007F0164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemUseButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemUseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB07 RID: 109319 RVA: 0x007F1FBC File Offset: 0x007F01BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemUseButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button subItemUseButton;
			LuaObject.checkType<Button>(l, 2, out subItemUseButton);
			alchemyUIController.m_luaExportHelper.m_subItemUseButton = subItemUseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB08 RID: 109320 RVA: 0x007F2018 File Offset: 0x007F0218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemPanelReturnButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemPanelReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB09 RID: 109321 RVA: 0x007F2070 File Offset: 0x007F0270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemPanelReturnButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button subItemPanelReturnButton;
			LuaObject.checkType<Button>(l, 2, out subItemPanelReturnButton);
			alchemyUIController.m_luaExportHelper.m_subItemPanelReturnButton = subItemPanelReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB0A RID: 109322 RVA: 0x007F20CC File Offset: 0x007F02CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemMinusButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemMinusButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB0B RID: 109323 RVA: 0x007F2124 File Offset: 0x007F0324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemMinusButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button subItemMinusButton;
			LuaObject.checkType<Button>(l, 2, out subItemMinusButton);
			alchemyUIController.m_luaExportHelper.m_subItemMinusButton = subItemMinusButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB0C RID: 109324 RVA: 0x007F2180 File Offset: 0x007F0380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemAddButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB0D RID: 109325 RVA: 0x007F21D8 File Offset: 0x007F03D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemAddButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button subItemAddButton;
			LuaObject.checkType<Button>(l, 2, out subItemAddButton);
			alchemyUIController.m_luaExportHelper.m_subItemAddButton = subItemAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB0E RID: 109326 RVA: 0x007F2234 File Offset: 0x007F0434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemMaxButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemMaxButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB0F RID: 109327 RVA: 0x007F228C File Offset: 0x007F048C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemMaxButton(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Button subItemMaxButton;
			LuaObject.checkType<Button>(l, 2, out subItemMaxButton);
			alchemyUIController.m_luaExportHelper.m_subItemMaxButton = subItemMaxButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB10 RID: 109328 RVA: 0x007F22E8 File Offset: 0x007F04E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subItemAvailalbeValueText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_subItemAvailalbeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB11 RID: 109329 RVA: 0x007F2340 File Offset: 0x007F0540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subItemAvailalbeValueText(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Text subItemAvailalbeValueText;
			LuaObject.checkType<Text>(l, 2, out subItemAvailalbeValueText);
			alchemyUIController.m_luaExportHelper.m_subItemAvailalbeValueText = subItemAvailalbeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB12 RID: 109330 RVA: 0x007F239C File Offset: 0x007F059C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_displayType(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)alchemyUIController.m_luaExportHelper.m_displayType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB13 RID: 109331 RVA: 0x007F23F4 File Offset: 0x007F05F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_displayType(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			AlchemyUIController.DisplayType displayType;
			LuaObject.checkEnum<AlchemyUIController.DisplayType>(l, 2, out displayType);
			alchemyUIController.m_luaExportHelper.m_displayType = displayType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB14 RID: 109332 RVA: 0x007F2450 File Offset: 0x007F0650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagItemCache(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_bagItemCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB15 RID: 109333 RVA: 0x007F24A8 File Offset: 0x007F06A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagItemCache(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			List<BagItemBase> bagItemCache;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out bagItemCache);
			alchemyUIController.m_luaExportHelper.m_bagItemCache = bagItemCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB16 RID: 109334 RVA: 0x007F2504 File Offset: 0x007F0704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_bagItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB17 RID: 109335 RVA: 0x007F255C File Offset: 0x007F075C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			List<BagItemUIController> bagItemCtrlList;
			LuaObject.checkType<List<BagItemUIController>>(l, 2, out bagItemCtrlList);
			alchemyUIController.m_luaExportHelper.m_bagItemCtrlList = bagItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB18 RID: 109336 RVA: 0x007F25B8 File Offset: 0x007F07B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_checkBagItemToCountDict(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_checkBagItemToCountDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB19 RID: 109337 RVA: 0x007F2610 File Offset: 0x007F0810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_checkBagItemToCountDict(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			Dictionary<BagItemBase, int> checkBagItemToCountDict;
			LuaObject.checkType<Dictionary<BagItemBase, int>>(l, 2, out checkBagItemToCountDict);
			alchemyUIController.m_luaExportHelper.m_checkBagItemToCountDict = checkBagItemToCountDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB1A RID: 109338 RVA: 0x007F266C File Offset: 0x007F086C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastCheckBagItem(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_lastCheckBagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB1B RID: 109339 RVA: 0x007F26C4 File Offset: 0x007F08C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastCheckBagItem(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			BagItemBase lastCheckBagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out lastCheckBagItem);
			alchemyUIController.m_luaExportHelper.m_lastCheckBagItem = lastCheckBagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB1C RID: 109340 RVA: 0x007F2720 File Offset: 0x007F0920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canAlchemyListIndex(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_canAlchemyListIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB1D RID: 109341 RVA: 0x007F2778 File Offset: 0x007F0978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canAlchemyListIndex(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			int canAlchemyListIndex;
			LuaObject.checkType(l, 2, out canAlchemyListIndex);
			alchemyUIController.m_luaExportHelper.m_canAlchemyListIndex = canAlchemyListIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB1E RID: 109342 RVA: 0x007F27D4 File Offset: 0x007F09D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB1F RID: 109343 RVA: 0x007F282C File Offset: 0x007F0A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			alchemyUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB20 RID: 109344 RVA: 0x007F2888 File Offset: 0x007F0A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alchemyUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB21 RID: 109345 RVA: 0x007F28E0 File Offset: 0x007F0AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			AlchemyUIController alchemyUIController = (AlchemyUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			alchemyUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB22 RID: 109346 RVA: 0x007F293C File Offset: 0x007F0B3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AlchemyUIController");
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.ResetAlchemyUIView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.InitLoopScrollViewRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.SetPointBgContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.IsBagItemOfDisplayType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.BagItemComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnBagItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.ShowRewardListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.CloseRewardListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnBagItemNeedFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.CloseRewardGoodsDescPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OpenSubUseItemPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.SetLastAlchemyCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.GetLastAlchemyCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnSubItemUseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnItemMinusButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnItemAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnItemMaxButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.CloseSubItemUsePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnInputEditEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnAlchemySucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnItemToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnJobMaterialToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnEquipmentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnFragmentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.OnToggleChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__callDele_EventOnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.__clearDele_EventOnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache32);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache33, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache34, true);
		string name3 = "EventOnAlchemyButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_EventOnAlchemyButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache35, true);
		string name4 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_marginTransform);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache37, true);
		string name5 = "m_mithralStoneText";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_mithralStoneText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_mithralStoneText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache39, true);
		string name6 = "m_brillianceMithralStoneText";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_brillianceMithralStoneText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_brillianceMithralStoneText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3B, true);
		string name7 = "m_itemToggle";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_itemToggle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_itemToggle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3D, true);
		string name8 = "m_equipmentToggle";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_equipmentToggle);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_equipmentToggle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache3F, true);
		string name9 = "m_fragmentToggle";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_fragmentToggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_fragmentToggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache41, true);
		string name10 = "m_jobMaterialToggle";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_jobMaterialToggle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_jobMaterialToggle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache43, true);
		string name11 = "m_alchemyButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_alchemyButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_alchemyButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache45, true);
		string name12 = "m_alchemyButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_alchemyButtonStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_alchemyButtonStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache47, true);
		string name13 = "m_effectGameObject";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_effectGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_effectGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache49, true);
		string name14 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_returnButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4B, true);
		string name15 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_helpButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4D, true);
		string name16 = "m_loopScrollView";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_loopScrollView);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_loopScrollView);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache4F, true);
		string name17 = "m_listItemPool";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_listItemPool);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_listItemPool);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache51, true);
		string name18 = "m_listScrollViewItemTemplateRoot";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_listScrollViewItemTemplateRoot);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_listScrollViewItemTemplateRoot);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache53, true);
		string name19 = "m_scrollViewBagItemContent";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_scrollViewBagItemContent);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_scrollViewBagItemContent);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache55, true);
		string name20 = "m_bagListPointBgContent";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_bagListPointBgContent);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_bagListPointBgContent);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache57, true);
		string name21 = "m_bagListPointItem";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_bagListPointItem);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_bagListPointItem);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache59, true);
		string name22 = "m_rewardListPanelGo";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardListPanelGo);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardListPanelGo);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5B, true);
		string name23 = "m_rewardListPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardListPanelStateCtrl);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardListPanelStateCtrl);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5D, true);
		string name24 = "m_rewardsContent";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardsContent);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardsContent);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache5F, true);
		string name25 = "m_rewardsNothingGo";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardsNothingGo);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardsNothingGo);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache61, true);
		string name26 = "m_rewardsMaterialCountText";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardsMaterialCountText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardsMaterialCountText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache63, true);
		string name27 = "m_rewardsGoldenValueText";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardsGoldenValueText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardsGoldenValueText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache65, true);
		string name28 = "m_rewardsNoticTextGo";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardsNoticTextGo);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardsNoticTextGo);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache67, true);
		string name29 = "m_rewardsNoticText";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_rewardsNoticText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_rewardsNoticText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache69, true);
		string name30 = "m_subBagInfoPanelObj";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subBagInfoPanelObj);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subBagInfoPanelObj);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6B, true);
		string name31 = "m_subItemNumInputField";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemNumInputField);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemNumInputField);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6D, true);
		string name32 = "m_subItemUseButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemUseButton);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemUseButton);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache6F, true);
		string name33 = "m_subItemPanelReturnButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemPanelReturnButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemPanelReturnButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache71, true);
		string name34 = "m_subItemMinusButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemMinusButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemMinusButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache73, true);
		string name35 = "m_subItemAddButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemAddButton);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemAddButton);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache75, true);
		string name36 = "m_subItemMaxButton";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemMaxButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemMaxButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache77, true);
		string name37 = "m_subItemAvailalbeValueText";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_subItemAvailalbeValueText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_subItemAvailalbeValueText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache79, true);
		string name38 = "m_displayType";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_displayType);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_displayType);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7B, true);
		string name39 = "m_bagItemCache";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_bagItemCache);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_bagItemCache);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7D, true);
		string name40 = "m_bagItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_bagItemCtrlList);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_bagItemCtrlList);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache7F, true);
		string name41 = "m_checkBagItemToCountDict";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_checkBagItemToCountDict);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_checkBagItemToCountDict);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache81, true);
		string name42 = "m_lastCheckBagItem";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_lastCheckBagItem);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_lastCheckBagItem);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache83, true);
		string name43 = "m_canAlchemyListIndex";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_canAlchemyListIndex);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_canAlchemyListIndex);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache85, true);
		string name44 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_playerContext);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache87, true);
		string name45 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.get_m_configDataLoader);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AlchemyUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_AlchemyUIController.<>f__mg$cache89, true);
		LuaObject.createTypeMetatable(l, null, typeof(AlchemyUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010DC6 RID: 69062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010DC7 RID: 69063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010DC8 RID: 69064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010DC9 RID: 69065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010DCA RID: 69066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010DCB RID: 69067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010DCC RID: 69068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010DCD RID: 69069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010DCE RID: 69070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010DCF RID: 69071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010DD0 RID: 69072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010DD1 RID: 69073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010DD2 RID: 69074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010DD3 RID: 69075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010DD4 RID: 69076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010DD5 RID: 69077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010DD6 RID: 69078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010DD7 RID: 69079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010DD8 RID: 69080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010DD9 RID: 69081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010DDA RID: 69082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010DDB RID: 69083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010DDC RID: 69084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010DDD RID: 69085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010DDE RID: 69086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010DDF RID: 69087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010DE0 RID: 69088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010DE1 RID: 69089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010DE2 RID: 69090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010DE3 RID: 69091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010DE4 RID: 69092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010DE5 RID: 69093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010DE6 RID: 69094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010DE7 RID: 69095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010DE8 RID: 69096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010DE9 RID: 69097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010DEA RID: 69098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010DEB RID: 69099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010DEC RID: 69100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010DED RID: 69101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010DEE RID: 69102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010DEF RID: 69103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010DF0 RID: 69104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010DF1 RID: 69105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010DF2 RID: 69106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010DF3 RID: 69107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010DF4 RID: 69108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010DF5 RID: 69109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010DF6 RID: 69110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010DF7 RID: 69111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010DF8 RID: 69112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010DF9 RID: 69113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010DFA RID: 69114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010DFB RID: 69115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010DFC RID: 69116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010DFD RID: 69117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010DFE RID: 69118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010DFF RID: 69119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010E00 RID: 69120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010E01 RID: 69121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04010E02 RID: 69122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04010E03 RID: 69123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04010E04 RID: 69124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04010E05 RID: 69125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04010E06 RID: 69126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04010E07 RID: 69127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04010E08 RID: 69128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04010E09 RID: 69129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04010E0A RID: 69130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04010E0B RID: 69131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04010E0C RID: 69132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04010E0D RID: 69133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04010E0E RID: 69134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04010E0F RID: 69135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04010E10 RID: 69136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04010E11 RID: 69137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04010E12 RID: 69138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04010E13 RID: 69139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04010E14 RID: 69140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04010E15 RID: 69141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04010E16 RID: 69142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04010E17 RID: 69143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04010E18 RID: 69144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04010E19 RID: 69145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04010E1A RID: 69146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04010E1B RID: 69147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04010E1C RID: 69148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04010E1D RID: 69149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04010E1E RID: 69150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04010E1F RID: 69151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04010E20 RID: 69152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04010E21 RID: 69153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04010E22 RID: 69154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04010E23 RID: 69155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04010E24 RID: 69156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04010E25 RID: 69157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04010E26 RID: 69158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04010E27 RID: 69159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04010E28 RID: 69160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04010E29 RID: 69161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04010E2A RID: 69162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04010E2B RID: 69163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04010E2C RID: 69164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04010E2D RID: 69165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04010E2E RID: 69166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04010E2F RID: 69167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04010E30 RID: 69168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04010E31 RID: 69169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04010E32 RID: 69170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04010E33 RID: 69171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04010E34 RID: 69172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04010E35 RID: 69173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04010E36 RID: 69174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04010E37 RID: 69175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04010E38 RID: 69176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04010E39 RID: 69177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04010E3A RID: 69178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04010E3B RID: 69179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04010E3C RID: 69180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04010E3D RID: 69181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04010E3E RID: 69182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04010E3F RID: 69183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04010E40 RID: 69184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04010E41 RID: 69185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04010E42 RID: 69186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04010E43 RID: 69187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04010E44 RID: 69188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04010E45 RID: 69189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04010E46 RID: 69190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04010E47 RID: 69191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04010E48 RID: 69192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04010E49 RID: 69193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04010E4A RID: 69194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04010E4B RID: 69195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04010E4C RID: 69196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04010E4D RID: 69197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04010E4E RID: 69198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04010E4F RID: 69199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;
}
