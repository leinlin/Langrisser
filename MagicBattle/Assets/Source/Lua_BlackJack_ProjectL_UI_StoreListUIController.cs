using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001588 RID: 5512
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreListUIController : LuaObject
{
	// Token: 0x06021327 RID: 135975 RVA: 0x00B2FBA8 File Offset: 0x00B2DDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroSkinItemCtrlByFixedStoreItemId(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			int fixedStoreItemId;
			LuaObject.checkType(l, 2, out fixedStoreItemId);
			StoreHeroSkinItemUIController heroSkinItemCtrlByFixedStoreItemId = storeListUIController.GetHeroSkinItemCtrlByFixedStoreItemId(fixedStoreItemId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinItemCtrlByFixedStoreItemId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021328 RID: 135976 RVA: 0x00B2FC0C File Offset: 0x00B2DE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroSkinItemLimitTime(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.UpdateHeroSkinItemLimitTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021329 RID: 135977 RVA: 0x00B2FC58 File Offset: 0x00B2DE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeListUIController.UpdateStore(storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602132A RID: 135978 RVA: 0x00B2FCB0 File Offset: 0x00B2DEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkinTicketCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.SetSkinTicketCountText();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602132B RID: 135979 RVA: 0x00B2FCFC File Offset: 0x00B2DEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedRefreshPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool b = storeListUIController.IsNeedRefreshPanel();
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

	// Token: 0x0602132C RID: 135980 RVA: 0x00B2FD50 File Offset: 0x00B2DF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreOpenTween(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.StoreOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602132D RID: 135981 RVA: 0x00B2FD9C File Offset: 0x00B2DF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNormalItemBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			StoreItemUIController storeItemUIController;
			LuaObject.checkType<StoreItemUIController>(l, 3, out storeItemUIController);
			storeListUIController.SetNormalItemBuyPanel(goods, storeItemUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602132E RID: 135982 RVA: 0x00B2FE00 File Offset: 0x00B2E000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			StoreItemUIController storeItemUIController;
			LuaObject.checkType<StoreItemUIController>(l, 3, out storeItemUIController);
			storeListUIController.SetItemBuyPanel(goods, storeItemUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602132F RID: 135983 RVA: 0x00B2FE64 File Offset: 0x00B2E064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomStoreCountDown(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.SetRandomStoreCountDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021330 RID: 135984 RVA: 0x00B2FEB0 File Offset: 0x00B2E0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			storeListUIController.OpenBuyPanel(storeId, itemId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021331 RID: 135985 RVA: 0x00B2FF14 File Offset: 0x00B2E114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryEntranceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.OnMemoryEntranceButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021332 RID: 135986 RVA: 0x00B2FF60 File Offset: 0x00B2E160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMemoryExtractionPanelInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.SetMemoryExtractionPanelInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021333 RID: 135987 RVA: 0x00B2FFAC File Offset: 0x00B2E1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021334 RID: 135988 RVA: 0x00B30000 File Offset: 0x00B2E200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStoreTypeByStoreId(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			StoreType storeTypeByStoreId = storeListUIController.m_luaExportHelper.GetStoreTypeByStoreId(storeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeTypeByStoreId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021335 RID: 135989 RVA: 0x00B30068 File Offset: 0x00B2E268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRechargeStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.UpdateRechargeStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021336 RID: 135990 RVA: 0x00B300BC File Offset: 0x00B2E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGiftStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeListUIController.m_luaExportHelper.UpdateGiftStore(storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021337 RID: 135991 RVA: 0x00B30118 File Offset: 0x00B2E318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFixedStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeListUIController.m_luaExportHelper.UpdateFixedStore(storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021338 RID: 135992 RVA: 0x00B30174 File Offset: 0x00B2E374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.UpdateRandomStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021339 RID: 135993 RVA: 0x00B301C8 File Offset: 0x00B2E3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.ClearPool();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602133A RID: 135994 RVA: 0x00B3021C File Offset: 0x00B2E41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFixedStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeID;
			LuaObject.checkEnum<StoreId>(l, 2, out storeID);
			storeListUIController.m_luaExportHelper.UpdateFixedStoreInfo(storeID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602133B RID: 135995 RVA: 0x00B30278 File Offset: 0x00B2E478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeID;
			LuaObject.checkEnum<StoreId>(l, 2, out storeID);
			GameObjectPool<StoreHeroSkinItemUIController> pool;
			LuaObject.checkType<GameObjectPool<StoreHeroSkinItemUIController>>(l, 3, out pool);
			storeListUIController.m_luaExportHelper.UpdateHeroSkinInfo(storeID, pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602133C RID: 135996 RVA: 0x00B302E4 File Offset: 0x00B2E4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSoldierSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeID;
			LuaObject.checkEnum<StoreId>(l, 2, out storeID);
			GameObjectPool<StoreSoldierSkinItemUIController> pool;
			LuaObject.checkType<GameObjectPool<StoreSoldierSkinItemUIController>>(l, 3, out pool);
			storeListUIController.m_luaExportHelper.UpdateSoldierSkinInfo(storeID, pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602133D RID: 135997 RVA: 0x00B30350 File Offset: 0x00B2E550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRandomStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeListUIController.m_luaExportHelper.UpdateRandomStoreInfo(storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602133E RID: 135998 RVA: 0x00B303AC File Offset: 0x00B2E5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRechargeStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.UpdateRechargeStoreInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602133F RID: 135999 RVA: 0x00B30400 File Offset: 0x00B2E600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDefaultState(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool defaultState;
			LuaObject.checkType(l, 2, out defaultState);
			storeListUIController.m_luaExportHelper.SetDefaultState(defaultState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021340 RID: 136000 RVA: 0x00B3045C File Offset: 0x00B2E65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFixedStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId fixedStoreID;
			LuaObject.checkEnum<StoreId>(l, 2, out fixedStoreID);
			GameObjectPool<StoreItemUIController> pool;
			LuaObject.checkType<GameObjectPool<StoreItemUIController>>(l, 3, out pool);
			storeListUIController.m_luaExportHelper.SetFixedStoreInfo(fixedStoreID, pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021341 RID: 136001 RVA: 0x00B304C8 File Offset: 0x00B2E6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortFixedStoreItemByUISort(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			FixedStoreItem a;
			LuaObject.checkType<FixedStoreItem>(l, 2, out a);
			FixedStoreItem b;
			LuaObject.checkType<FixedStoreItem>(l, 3, out b);
			int i = storeListUIController.m_luaExportHelper.SortFixedStoreItemByUISort(a, b);
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

	// Token: 0x06021342 RID: 136002 RVA: 0x00B3053C File Offset: 0x00B2E73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshCurrencyDisplay(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			List<StoreItemUIController> currencyTypeList;
			LuaObject.checkType<List<StoreItemUIController>>(l, 2, out currencyTypeList);
			storeListUIController.m_luaExportHelper.RefreshCurrencyDisplay(currencyTypeList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021343 RID: 136003 RVA: 0x00B30598 File Offset: 0x00B2E798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			GameObjectPool<StoreItemUIController> pool;
			LuaObject.checkType<GameObjectPool<StoreItemUIController>>(l, 3, out pool);
			storeListUIController.m_luaExportHelper.SetRandomStoreInfo(storeId, pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021344 RID: 136004 RVA: 0x00B30604 File Offset: 0x00B2E804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRechargeStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObjectPool<StoreItemUIController> rechargeStoreInfo;
			LuaObject.checkType<GameObjectPool<StoreItemUIController>>(l, 2, out rechargeStoreInfo);
			storeListUIController.m_luaExportHelper.SetRechargeStoreInfo(rechargeStoreInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021345 RID: 136005 RVA: 0x00B30660 File Offset: 0x00B2E860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRefreshPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.ShowRefreshPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021346 RID: 136006 RVA: 0x00B306B4 File Offset: 0x00B2E8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideRefreshPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.HideRefreshPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021347 RID: 136007 RVA: 0x00B30708 File Offset: 0x00B2E908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRefreshPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId refreshPanel;
			LuaObject.checkEnum<StoreId>(l, 2, out refreshPanel);
			storeListUIController.m_luaExportHelper.SetRefreshPanel(refreshPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021348 RID: 136008 RVA: 0x00B30764 File Offset: 0x00B2E964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStoreItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController goCtrl;
			LuaObject.checkType<StoreItemUIController>(l, 2, out goCtrl);
			storeListUIController.m_luaExportHelper.OnStoreItemClick(goCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021349 RID: 136009 RVA: 0x00B307C0 File Offset: 0x00B2E9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreHeroSkinItemUIController itemCtrl;
			LuaObject.checkType<StoreHeroSkinItemUIController>(l, 2, out itemCtrl);
			storeListUIController.m_luaExportHelper.OnHeroSkinItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602134A RID: 136010 RVA: 0x00B3081C File Offset: 0x00B2EA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnSkinItemOutOfDate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602134B RID: 136011 RVA: 0x00B30870 File Offset: 0x00B2EA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreSoldierSkinItemUIController itemCtrl;
			LuaObject.checkType<StoreSoldierSkinItemUIController>(l, 2, out itemCtrl);
			storeListUIController.m_luaExportHelper.OnSoldierSkinItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602134C RID: 136012 RVA: 0x00B308CC File Offset: 0x00B2EACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStoreBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController storeBuyPanel;
			LuaObject.checkType<StoreItemUIController>(l, 2, out storeBuyPanel);
			storeListUIController.m_luaExportHelper.SetStoreBuyPanel(storeBuyPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602134D RID: 136013 RVA: 0x00B30928 File Offset: 0x00B2EB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRechargeBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController rechargeBuyPanel;
			LuaObject.checkType<StoreItemUIController>(l, 2, out rechargeBuyPanel);
			storeListUIController.m_luaExportHelper.SetRechargeBuyPanel(rechargeBuyPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602134E RID: 136014 RVA: 0x00B30984 File Offset: 0x00B2EB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBoxBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController boxBuyPanel;
			LuaObject.checkType<StoreItemUIController>(l, 2, out boxBuyPanel);
			storeListUIController.m_luaExportHelper.SetBoxBuyPanel(boxBuyPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602134F RID: 136015 RVA: 0x00B309E0 File Offset: 0x00B2EBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnchantStoneResonanceInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsID;
			LuaObject.checkType(l, 3, out goodsID);
			storeListUIController.m_luaExportHelper.SetEnchantStoneResonanceInfoPanel(goodsType, goodsID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021350 RID: 136016 RVA: 0x00B30A4C File Offset: 0x00B2EC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGiftStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeID;
			LuaObject.checkEnum<StoreId>(l, 2, out storeID);
			GameObjectPool<StoreItemUIController> pool;
			LuaObject.checkType<GameObjectPool<StoreItemUIController>>(l, 3, out pool);
			storeListUIController.m_luaExportHelper.UpdateGiftStoreInfo(storeID, pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021351 RID: 136017 RVA: 0x00B30AB8 File Offset: 0x00B2ECB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGiftStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			GameObjectPool<StoreItemUIController> pool;
			LuaObject.checkType<GameObjectPool<StoreItemUIController>>(l, 3, out pool);
			storeListUIController.m_luaExportHelper.SetGiftStoreInfo(storeId, pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021352 RID: 136018 RVA: 0x00B30B24 File Offset: 0x00B2ED24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGiftStoreBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController giftStoreBuyPanel;
			LuaObject.checkType<StoreItemUIController>(l, 2, out giftStoreBuyPanel);
			storeListUIController.m_luaExportHelper.SetGiftStoreBuyPanel(giftStoreBuyPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021353 RID: 136019 RVA: 0x00B30B80 File Offset: 0x00B2ED80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGiftStoreStaticBoxBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController ctrl;
			LuaObject.checkType<StoreItemUIController>(l, 2, out ctrl);
			ConfigDataItemInfo itemInfo;
			LuaObject.checkType<ConfigDataItemInfo>(l, 3, out itemInfo);
			storeListUIController.m_luaExportHelper.SetGiftStoreStaticBoxBuyPanel(ctrl, itemInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021354 RID: 136020 RVA: 0x00B30BEC File Offset: 0x00B2EDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMothCardBuyPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController mothCardBuyPanel;
			LuaObject.checkType<StoreItemUIController>(l, 2, out mothCardBuyPanel);
			storeListUIController.m_luaExportHelper.SetMothCardBuyPanel(mothCardBuyPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021355 RID: 136021 RVA: 0x00B30C48 File Offset: 0x00B2EE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPresentPresentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnPresentPresentToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021356 RID: 136022 RVA: 0x00B30CA4 File Offset: 0x00B2EEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPresentPreogativeToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnPresentPreogativeToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021357 RID: 136023 RVA: 0x00B30D00 File Offset: 0x00B2EF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnMonthCardBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021358 RID: 136024 RVA: 0x00B30D54 File Offset: 0x00B2EF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubscribePrivateClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnSubscribePrivateClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021359 RID: 136025 RVA: 0x00B30DA8 File Offset: 0x00B2EFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelSubscribeClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnCancelSubscribeClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602135A RID: 136026 RVA: 0x00B30DFC File Offset: 0x00B2EFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardPanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnMonthCardPanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602135B RID: 136027 RVA: 0x00B30E50 File Offset: 0x00B2F050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPresentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnPresentToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602135C RID: 136028 RVA: 0x00B30EAC File Offset: 0x00B2F0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602135D RID: 136029 RVA: 0x00B30F00 File Offset: 0x00B2F100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRefreshButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnRefreshButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602135E RID: 136030 RVA: 0x00B30F54 File Offset: 0x00B2F154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemBuyPanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnItemBuyPanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602135F RID: 136031 RVA: 0x00B30FA8 File Offset: 0x00B2F1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnItemBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021360 RID: 136032 RVA: 0x00B30FFC File Offset: 0x00B2F1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBoxBuyPanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnBoxBuyPanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021361 RID: 136033 RVA: 0x00B31050 File Offset: 0x00B2F250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRechargePanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnRechargePanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021362 RID: 136034 RVA: 0x00B310A4 File Offset: 0x00B2F2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBoxBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnBoxBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021363 RID: 136035 RVA: 0x00B310F8 File Offset: 0x00B2F2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsStoreItemIOSSubscribeItem(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreItemUIController ctrl;
			LuaObject.checkType<StoreItemUIController>(l, 2, out ctrl);
			bool b = storeListUIController.m_luaExportHelper.IsStoreItemIOSSubscribeItem(ctrl);
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

	// Token: 0x06021364 RID: 136036 RVA: 0x00B31160 File Offset: 0x00B2F360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortFragmentItemComparer(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			HeroFragmentBagItem f;
			LuaObject.checkType<HeroFragmentBagItem>(l, 2, out f);
			HeroFragmentBagItem f2;
			LuaObject.checkType<HeroFragmentBagItem>(l, 3, out f2);
			int i = storeListUIController.m_luaExportHelper.SortFragmentItemComparer(f, f2);
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

	// Token: 0x06021365 RID: 136037 RVA: 0x00B311D4 File Offset: 0x00B2F3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryExtractionPanelExtractionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnMemoryExtractionPanelExtractionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021366 RID: 136038 RVA: 0x00B31228 File Offset: 0x00B2F428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemeryExtractionHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnMemeryExtractionHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021367 RID: 136039 RVA: 0x00B3127C File Offset: 0x00B2F47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseMemoryExtractionPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.CloseMemoryExtractionPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021368 RID: 136040 RVA: 0x00B312D0 File Offset: 0x00B2F4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FireChangeStoreEvent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeListUIController.m_luaExportHelper.FireChangeStoreEvent(storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021369 RID: 136041 RVA: 0x00B3132C File Offset: 0x00B2F52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRechargeBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.OnRechargeBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602136A RID: 136042 RVA: 0x00B31380 File Offset: 0x00B2F580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRechargeToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnRechargeToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602136B RID: 136043 RVA: 0x00B313DC File Offset: 0x00B2F5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCystalToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnCystalToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602136C RID: 136044 RVA: 0x00B31438 File Offset: 0x00B2F638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnSkinToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602136D RID: 136045 RVA: 0x00B31494 File Offset: 0x00B2F694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinTab_HeroToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnSkinTab_HeroToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602136E RID: 136046 RVA: 0x00B314F0 File Offset: 0x00B2F6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinTab_SoldierToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnSkinTab_SoldierToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602136F RID: 136047 RVA: 0x00B3154C File Offset: 0x00B2F74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021370 RID: 136048 RVA: 0x00B315A8 File Offset: 0x00B2F7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousBlackMarketToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousBlackMarketToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021371 RID: 136049 RVA: 0x00B31604 File Offset: 0x00B2F804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousMemoryToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousMemoryToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021372 RID: 136050 RVA: 0x00B31660 File Offset: 0x00B2F860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousEquipmentToggleValueChange(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousEquipmentToggleValueChange(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021373 RID: 136051 RVA: 0x00B316BC File Offset: 0x00B2F8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousHonorToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousHonorToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021374 RID: 136052 RVA: 0x00B31718 File Offset: 0x00B2F918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousMedalToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousMedalToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021375 RID: 136053 RVA: 0x00B31774 File Offset: 0x00B2F974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousFriendshipToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousFriendshipToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021376 RID: 136054 RVA: 0x00B317D0 File Offset: 0x00B2F9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMysteriousUnionToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			storeListUIController.m_luaExportHelper.OnMysteriousUnionToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021377 RID: 136055 RVA: 0x00B3182C File Offset: 0x00B2FA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitStoreSubType2Toggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.InitStoreSubType2Toggle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021378 RID: 136056 RVA: 0x00B31880 File Offset: 0x00B2FA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveOriginalScrollViewLocalPosition(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.SaveOriginalScrollViewLocalPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021379 RID: 136057 RVA: 0x00B318D4 File Offset: 0x00B2FAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateToggles(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			bool b = storeListUIController.m_luaExportHelper.UpdateToggles(storeId);
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

	// Token: 0x0602137A RID: 136058 RVA: 0x00B3193C File Offset: 0x00B2FB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FixedStoreSkinListSortFunc(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			FixedStoreItem itemA;
			LuaObject.checkType<FixedStoreItem>(l, 2, out itemA);
			FixedStoreItem itemB;
			LuaObject.checkType<FixedStoreItem>(l, 3, out itemB);
			int i = storeListUIController.m_luaExportHelper.FixedStoreSkinListSortFunc(itemA, itemB);
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

	// Token: 0x0602137B RID: 136059 RVA: 0x00B319B0 File Offset: 0x00B2FBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			storeListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602137C RID: 136060 RVA: 0x00B31A1C File Offset: 0x00B2FC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602137D RID: 136061 RVA: 0x00B31A70 File Offset: 0x00B2FC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602137E RID: 136062 RVA: 0x00B31AC4 File Offset: 0x00B2FCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = storeListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602137F RID: 136063 RVA: 0x00B31B6C File Offset: 0x00B2FD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021380 RID: 136064 RVA: 0x00B31BC0 File Offset: 0x00B2FDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			storeListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021381 RID: 136065 RVA: 0x00B31C2C File Offset: 0x00B2FE2C
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
				StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				storeListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				StoreListUIController storeListUIController2 = (StoreListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				storeListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021382 RID: 136066 RVA: 0x00B31D3C File Offset: 0x00B2FF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021383 RID: 136067 RVA: 0x00B31DA8 File Offset: 0x00B2FFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021384 RID: 136068 RVA: 0x00B31E14 File Offset: 0x00B30014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021385 RID: 136069 RVA: 0x00B31E80 File Offset: 0x00B30080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021386 RID: 136070 RVA: 0x00B31EEC File Offset: 0x00B300EC
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
				StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				storeListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				StoreListUIController storeListUIController2 = (StoreListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				storeListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021387 RID: 136071 RVA: 0x00B31FFC File Offset: 0x00B301FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			string s = storeListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021388 RID: 136072 RVA: 0x00B32058 File Offset: 0x00B30258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId obj;
			LuaObject.checkEnum<StoreId>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnChangeStore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021389 RID: 136073 RVA: 0x00B320B4 File Offset: 0x00B302B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId obj;
			LuaObject.checkEnum<StoreId>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnChangeStore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602138A RID: 136074 RVA: 0x00B32110 File Offset: 0x00B30310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFixedStoreHeroSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreHeroSkinItemUIController obj;
			LuaObject.checkType<StoreHeroSkinItemUIController>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnFixedStoreHeroSkinItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602138B RID: 136075 RVA: 0x00B3216C File Offset: 0x00B3036C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFixedStoreHeroSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreHeroSkinItemUIController obj;
			LuaObject.checkType<StoreHeroSkinItemUIController>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnFixedStoreHeroSkinItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602138C RID: 136076 RVA: 0x00B321C8 File Offset: 0x00B303C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFixedStoreSoldierSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreSoldierSkinItemUIController obj;
			LuaObject.checkType<StoreSoldierSkinItemUIController>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnFixedStoreSoldierSkinItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602138D RID: 136077 RVA: 0x00B32224 File Offset: 0x00B30424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFixedStoreSoldierSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreSoldierSkinItemUIController obj;
			LuaObject.checkType<StoreSoldierSkinItemUIController>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnFixedStoreSoldierSkinItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602138E RID: 136078 RVA: 0x00B32280 File Offset: 0x00B30480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__callDele_EventOnSkinItemOutOfDate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602138F RID: 136079 RVA: 0x00B322D4 File Offset: 0x00B304D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnSkinItemOutOfDate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021390 RID: 136080 RVA: 0x00B32328 File Offset: 0x00B30528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFixedStoreItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			List<Goods> arg5;
			LuaObject.checkType<List<Goods>>(l, 6, out arg5);
			storeListUIController.m_luaExportHelper.__callDele_EventOnFixedStoreItemBuyClick(arg, arg2, arg3, arg4, arg5);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021391 RID: 136081 RVA: 0x00B323B8 File Offset: 0x00B305B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFixedStoreItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			List<Goods> arg5;
			LuaObject.checkType<List<Goods>>(l, 6, out arg5);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnFixedStoreItemBuyClick(arg, arg2, arg3, arg4, arg5);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021392 RID: 136082 RVA: 0x00B32448 File Offset: 0x00B30648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFixedStoreBoxBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			List<Goods> arg4;
			LuaObject.checkType<List<Goods>>(l, 5, out arg4);
			storeListUIController.m_luaExportHelper.__callDele_EventOnFixedStoreBoxBuyClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021393 RID: 136083 RVA: 0x00B324CC File Offset: 0x00B306CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFixedStoreBoxBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			List<Goods> arg4;
			LuaObject.checkType<List<Goods>>(l, 5, out arg4);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnFixedStoreBoxBuyClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021394 RID: 136084 RVA: 0x00B32550 File Offset: 0x00B30750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRandomStoreItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<Goods> arg3;
			LuaObject.checkType<List<Goods>>(l, 4, out arg3);
			storeListUIController.m_luaExportHelper.__callDele_EventOnRandomStoreItemBuyClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021395 RID: 136085 RVA: 0x00B325C8 File Offset: 0x00B307C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRandomStoreItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<Goods> arg3;
			LuaObject.checkType<List<Goods>>(l, 4, out arg3);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnRandomStoreItemBuyClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021396 RID: 136086 RVA: 0x00B32640 File Offset: 0x00B30840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRandomStoreBoxBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			List<Goods> arg4;
			LuaObject.checkType<List<Goods>>(l, 5, out arg4);
			storeListUIController.m_luaExportHelper.__callDele_EventOnRandomStoreBoxBuyClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021397 RID: 136087 RVA: 0x00B326C4 File Offset: 0x00B308C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRandomStoreBoxBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId arg;
			LuaObject.checkEnum<StoreId>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			List<Goods> arg4;
			LuaObject.checkType<List<Goods>>(l, 5, out arg4);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnRandomStoreBoxBuyClick(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021398 RID: 136088 RVA: 0x00B32748 File Offset: 0x00B30948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRechargeStoreBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreType arg;
			LuaObject.checkEnum<StoreType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			storeListUIController.m_luaExportHelper.__callDele_EventOnRechargeStoreBuyClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021399 RID: 136089 RVA: 0x00B327C0 File Offset: 0x00B309C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRechargeStoreBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreType arg;
			LuaObject.checkEnum<StoreType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnRechargeStoreBuyClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602139A RID: 136090 RVA: 0x00B32838 File Offset: 0x00B30A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGiftStoreBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			ConfigDataGiftStoreItemInfo arg;
			LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			storeListUIController.m_luaExportHelper.__callDele_EventOnGiftStoreBuyClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602139B RID: 136091 RVA: 0x00B328B0 File Offset: 0x00B30AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGiftStoreBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			ConfigDataGiftStoreItemInfo arg;
			LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnGiftStoreBuyClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602139C RID: 136092 RVA: 0x00B32928 File Offset: 0x00B30B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId obj;
			LuaObject.checkEnum<StoreId>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnGetRandomStore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602139D RID: 136093 RVA: 0x00B32984 File Offset: 0x00B30B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId obj;
			LuaObject.checkEnum<StoreId>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnGetRandomStore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602139E RID: 136094 RVA: 0x00B329E0 File Offset: 0x00B30BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRefreshRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId obj;
			LuaObject.checkEnum<StoreId>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnRefreshRandomStore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602139F RID: 136095 RVA: 0x00B32A3C File Offset: 0x00B30C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRefreshRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId obj;
			LuaObject.checkEnum<StoreId>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnRefreshRandomStore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A0 RID: 136096 RVA: 0x00B32A98 File Offset: 0x00B30C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__callDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A1 RID: 136097 RVA: 0x00B32AEC File Offset: 0x00B30CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A2 RID: 136098 RVA: 0x00B32B40 File Offset: 0x00B30D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A3 RID: 136099 RVA: 0x00B32B94 File Offset: 0x00B30D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A4 RID: 136100 RVA: 0x00B32BE8 File Offset: 0x00B30DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExtraButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GoodsType obj;
			LuaObject.checkEnum<GoodsType>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnExtraButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A5 RID: 136101 RVA: 0x00B32C44 File Offset: 0x00B30E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExtraButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GoodsType obj;
			LuaObject.checkEnum<GoodsType>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnExtraButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A6 RID: 136102 RVA: 0x00B32CA0 File Offset: 0x00B30EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMemoryExtraction(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__callDele_EventOnMemoryExtraction(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A7 RID: 136103 RVA: 0x00B32CFC File Offset: 0x00B30EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMemoryExtraction(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action obj;
			LuaObject.checkDelegate<Action>(l, 2, out obj);
			storeListUIController.m_luaExportHelper.__clearDele_EventOnMemoryExtraction(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213A8 RID: 136104 RVA: 0x00B32D58 File Offset: 0x00B30F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreId> value;
			int num = LuaObject.checkDelegate<Action<StoreId>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnChangeStore += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnChangeStore -= value;
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

	// Token: 0x060213A9 RID: 136105 RVA: 0x00B32DD8 File Offset: 0x00B30FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFixedStoreHeroSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreHeroSkinItemUIController> value;
			int num = LuaObject.checkDelegate<Action<StoreHeroSkinItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnFixedStoreHeroSkinItemClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnFixedStoreHeroSkinItemClick -= value;
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

	// Token: 0x060213AA RID: 136106 RVA: 0x00B32E58 File Offset: 0x00B31058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFixedStoreSoldierSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreSoldierSkinItemUIController> value;
			int num = LuaObject.checkDelegate<Action<StoreSoldierSkinItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnFixedStoreSoldierSkinItemClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnFixedStoreSoldierSkinItemClick -= value;
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

	// Token: 0x060213AB RID: 136107 RVA: 0x00B32ED8 File Offset: 0x00B310D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnSkinItemOutOfDate += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnSkinItemOutOfDate -= value;
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

	// Token: 0x060213AC RID: 136108 RVA: 0x00B32F58 File Offset: 0x00B31158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFixedStoreItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreListUIController.Action<StoreId, int, int, int, List<Goods>> value;
			int num = LuaObject.checkDelegate<StoreListUIController.Action<StoreId, int, int, int, List<Goods>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnFixedStoreItemBuyClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnFixedStoreItemBuyClick -= value;
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

	// Token: 0x060213AD RID: 136109 RVA: 0x00B32FD8 File Offset: 0x00B311D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFixedStoreBoxBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreId, int, int, List<Goods>> value;
			int num = LuaObject.checkDelegate<Action<StoreId, int, int, List<Goods>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnFixedStoreBoxBuyClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnFixedStoreBoxBuyClick -= value;
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

	// Token: 0x060213AE RID: 136110 RVA: 0x00B33058 File Offset: 0x00B31258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRandomStoreItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreId, int, List<Goods>> value;
			int num = LuaObject.checkDelegate<Action<StoreId, int, List<Goods>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnRandomStoreItemBuyClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnRandomStoreItemBuyClick -= value;
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

	// Token: 0x060213AF RID: 136111 RVA: 0x00B330D8 File Offset: 0x00B312D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRandomStoreBoxBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreId, int, int, List<Goods>> value;
			int num = LuaObject.checkDelegate<Action<StoreId, int, int, List<Goods>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnRandomStoreBoxBuyClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnRandomStoreBoxBuyClick -= value;
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

	// Token: 0x060213B0 RID: 136112 RVA: 0x00B33158 File Offset: 0x00B31358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRechargeStoreBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreType, int, int> value;
			int num = LuaObject.checkDelegate<Action<StoreType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnRechargeStoreBuyClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnRechargeStoreBuyClick -= value;
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

	// Token: 0x060213B1 RID: 136113 RVA: 0x00B331D8 File Offset: 0x00B313D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGiftStoreBuyClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<ConfigDataGiftStoreItemInfo, bool, int> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataGiftStoreItemInfo, bool, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnGiftStoreBuyClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnGiftStoreBuyClick -= value;
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

	// Token: 0x060213B2 RID: 136114 RVA: 0x00B33258 File Offset: 0x00B31458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreId> value;
			int num = LuaObject.checkDelegate<Action<StoreId>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnGetRandomStore += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnGetRandomStore -= value;
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

	// Token: 0x060213B3 RID: 136115 RVA: 0x00B332D8 File Offset: 0x00B314D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRefreshRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<StoreId> value;
			int num = LuaObject.checkDelegate<Action<StoreId>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnRefreshRandomStore += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnRefreshRandomStore -= value;
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

	// Token: 0x060213B4 RID: 136116 RVA: 0x00B33358 File Offset: 0x00B31558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnCrystalNotEnough += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnCrystalNotEnough -= value;
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

	// Token: 0x060213B5 RID: 136117 RVA: 0x00B333D8 File Offset: 0x00B315D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnClose -= value;
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

	// Token: 0x060213B6 RID: 136118 RVA: 0x00B33458 File Offset: 0x00B31658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExtraButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<GoodsType> value;
			int num = LuaObject.checkDelegate<Action<GoodsType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnExtraButtonClick += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnExtraButtonClick -= value;
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

	// Token: 0x060213B7 RID: 136119 RVA: 0x00B334D8 File Offset: 0x00B316D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMemoryExtraction(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Action<Action> value;
			int num = LuaObject.checkDelegate<Action<Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeListUIController.EventOnMemoryExtraction += value;
				}
				else if (num == 2)
				{
					storeListUIController.EventOnMemoryExtraction -= value;
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

	// Token: 0x060213B8 RID: 136120 RVA: 0x00B33558 File Offset: 0x00B31758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213B9 RID: 136121 RVA: 0x00B335B0 File Offset: 0x00B317B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController storeUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out storeUIStateCtrl);
			storeListUIController.m_luaExportHelper.m_storeUIStateCtrl = storeUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213BA RID: 136122 RVA: 0x00B3360C File Offset: 0x00B3180C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshPanelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshPanelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213BB RID: 136123 RVA: 0x00B33664 File Offset: 0x00B31864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshPanelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController refreshPanelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out refreshPanelUIStateCtrl);
			storeListUIController.m_luaExportHelper.m_refreshPanelUIStateCtrl = refreshPanelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213BC RID: 136124 RVA: 0x00B336C0 File Offset: 0x00B318C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewStoreContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_scrollViewStoreContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213BD RID: 136125 RVA: 0x00B33718 File Offset: 0x00B31918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewStoreContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject scrollViewStoreContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewStoreContent);
			storeListUIController.m_luaExportHelper.m_scrollViewStoreContent = scrollViewStoreContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213BE RID: 136126 RVA: 0x00B33774 File Offset: 0x00B31974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewHeroContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_scrollViewHeroContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213BF RID: 136127 RVA: 0x00B337CC File Offset: 0x00B319CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewHeroContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject scrollViewHeroContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewHeroContent);
			storeListUIController.m_luaExportHelper.m_scrollViewHeroContent = scrollViewHeroContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C0 RID: 136128 RVA: 0x00B33828 File Offset: 0x00B31A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemBuyPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemBuyPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C1 RID: 136129 RVA: 0x00B33880 File Offset: 0x00B31A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemBuyPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController itemBuyPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out itemBuyPanelUIStateController);
			storeListUIController.m_luaExportHelper.m_itemBuyPanelUIStateController = itemBuyPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C2 RID: 136130 RVA: 0x00B338DC File Offset: 0x00B31ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C3 RID: 136131 RVA: 0x00B33934 File Offset: 0x00B31B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image itemIconImage;
			LuaObject.checkType<Image>(l, 2, out itemIconImage);
			storeListUIController.m_luaExportHelper.m_itemIconImage = itemIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C4 RID: 136132 RVA: 0x00B33990 File Offset: 0x00B31B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C5 RID: 136133 RVA: 0x00B339E8 File Offset: 0x00B31BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text itemCountText;
			LuaObject.checkType<Text>(l, 2, out itemCountText);
			storeListUIController.m_luaExportHelper.m_itemCountText = itemCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C6 RID: 136134 RVA: 0x00B33A44 File Offset: 0x00B31C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemCountBgGo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemCountBgGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C7 RID: 136135 RVA: 0x00B33A9C File Offset: 0x00B31C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemCountBgGo(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject itemCountBgGo;
			LuaObject.checkType<GameObject>(l, 2, out itemCountBgGo);
			storeListUIController.m_luaExportHelper.m_itemCountBgGo = itemCountBgGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C8 RID: 136136 RVA: 0x00B33AF8 File Offset: 0x00B31CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213C9 RID: 136137 RVA: 0x00B33B50 File Offset: 0x00B31D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text itemNameText;
			LuaObject.checkType<Text>(l, 2, out itemNameText);
			storeListUIController.m_luaExportHelper.m_itemNameText = itemNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213CA RID: 136138 RVA: 0x00B33BAC File Offset: 0x00B31DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemGoodCountObj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemGoodCountObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213CB RID: 136139 RVA: 0x00B33C04 File Offset: 0x00B31E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemGoodCountObj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject itemGoodCountObj;
			LuaObject.checkType<GameObject>(l, 2, out itemGoodCountObj);
			storeListUIController.m_luaExportHelper.m_itemGoodCountObj = itemGoodCountObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213CC RID: 136140 RVA: 0x00B33C60 File Offset: 0x00B31E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemHaveCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213CD RID: 136141 RVA: 0x00B33CB8 File Offset: 0x00B31EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text itemHaveCountText;
			LuaObject.checkType<Text>(l, 2, out itemHaveCountText);
			storeListUIController.m_luaExportHelper.m_itemHaveCountText = itemHaveCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213CE RID: 136142 RVA: 0x00B33D14 File Offset: 0x00B31F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemDescText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213CF RID: 136143 RVA: 0x00B33D6C File Offset: 0x00B31F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemDescText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text itemDescText;
			LuaObject.checkType<Text>(l, 2, out itemDescText);
			storeListUIController.m_luaExportHelper.m_itemDescText = itemDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D0 RID: 136144 RVA: 0x00B33DC8 File Offset: 0x00B31FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemPriceIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemPriceIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D1 RID: 136145 RVA: 0x00B33E20 File Offset: 0x00B32020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemPriceIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image itemPriceIcon;
			LuaObject.checkType<Image>(l, 2, out itemPriceIcon);
			storeListUIController.m_luaExportHelper.m_itemPriceIcon = itemPriceIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D2 RID: 136146 RVA: 0x00B33E7C File Offset: 0x00B3207C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemPriceIconEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemPriceIconEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D3 RID: 136147 RVA: 0x00B33ED4 File Offset: 0x00B320D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemPriceIconEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject itemPriceIconEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out itemPriceIconEffectGameObject);
			storeListUIController.m_luaExportHelper.m_itemPriceIconEffectGameObject = itemPriceIconEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D4 RID: 136148 RVA: 0x00B33F30 File Offset: 0x00B32130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemPriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemPriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D5 RID: 136149 RVA: 0x00B33F88 File Offset: 0x00B32188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemPriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text itemPriceText;
			LuaObject.checkType<Text>(l, 2, out itemPriceText);
			storeListUIController.m_luaExportHelper.m_itemPriceText = itemPriceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D6 RID: 136150 RVA: 0x00B33FE4 File Offset: 0x00B321E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemBuyPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemBuyPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D7 RID: 136151 RVA: 0x00B3403C File Offset: 0x00B3223C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemBuyPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button itemBuyPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out itemBuyPanelCloseButton);
			storeListUIController.m_luaExportHelper.m_itemBuyPanelCloseButton = itemBuyPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D8 RID: 136152 RVA: 0x00B34098 File Offset: 0x00B32298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_itemBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213D9 RID: 136153 RVA: 0x00B340F0 File Offset: 0x00B322F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button itemBuyButton;
			LuaObject.checkType<Button>(l, 2, out itemBuyButton);
			storeListUIController.m_luaExportHelper.m_itemBuyButton = itemBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213DA RID: 136154 RVA: 0x00B3414C File Offset: 0x00B3234C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_resonanceInfoPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213DB RID: 136155 RVA: 0x00B341A4 File Offset: 0x00B323A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject resonanceInfoPanel;
			LuaObject.checkType<GameObject>(l, 2, out resonanceInfoPanel);
			storeListUIController.m_luaExportHelper.m_resonanceInfoPanel = resonanceInfoPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213DC RID: 136156 RVA: 0x00B34200 File Offset: 0x00B32400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanelNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_resonanceInfoPanelNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213DD RID: 136157 RVA: 0x00B34258 File Offset: 0x00B32458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanelNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text resonanceInfoPanelNameText;
			LuaObject.checkType<Text>(l, 2, out resonanceInfoPanelNameText);
			storeListUIController.m_luaExportHelper.m_resonanceInfoPanelNameText = resonanceInfoPanelNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213DE RID: 136158 RVA: 0x00B342B4 File Offset: 0x00B324B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanel2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_resonanceInfoPanel2SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213DF RID: 136159 RVA: 0x00B3430C File Offset: 0x00B3250C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanel2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text resonanceInfoPanel2SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out resonanceInfoPanel2SuitInfoText);
			storeListUIController.m_luaExportHelper.m_resonanceInfoPanel2SuitInfoText = resonanceInfoPanel2SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E0 RID: 136160 RVA: 0x00B34368 File Offset: 0x00B32568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanel4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_resonanceInfoPanel4SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E1 RID: 136161 RVA: 0x00B343C0 File Offset: 0x00B325C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanel4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text resonanceInfoPanel4SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out resonanceInfoPanel4SuitInfoText);
			storeListUIController.m_luaExportHelper.m_resonanceInfoPanel4SuitInfoText = resonanceInfoPanel4SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E2 RID: 136162 RVA: 0x00B3441C File Offset: 0x00B3261C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxBuyPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxBuyPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E3 RID: 136163 RVA: 0x00B34474 File Offset: 0x00B32674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxBuyPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController boxBuyPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out boxBuyPanelUIStateController);
			storeListUIController.m_luaExportHelper.m_boxBuyPanelUIStateController = boxBuyPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E4 RID: 136164 RVA: 0x00B344D0 File Offset: 0x00B326D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E5 RID: 136165 RVA: 0x00B34528 File Offset: 0x00B32728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image boxIconImage;
			LuaObject.checkType<Image>(l, 2, out boxIconImage);
			storeListUIController.m_luaExportHelper.m_boxIconImage = boxIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E6 RID: 136166 RVA: 0x00B34584 File Offset: 0x00B32784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E7 RID: 136167 RVA: 0x00B345DC File Offset: 0x00B327DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text boxCountText;
			LuaObject.checkType<Text>(l, 2, out boxCountText);
			storeListUIController.m_luaExportHelper.m_boxCountText = boxCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E8 RID: 136168 RVA: 0x00B34638 File Offset: 0x00B32838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213E9 RID: 136169 RVA: 0x00B34690 File Offset: 0x00B32890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text boxNameText;
			LuaObject.checkType<Text>(l, 2, out boxNameText);
			storeListUIController.m_luaExportHelper.m_boxNameText = boxNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213EA RID: 136170 RVA: 0x00B346EC File Offset: 0x00B328EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxHaveCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213EB RID: 136171 RVA: 0x00B34744 File Offset: 0x00B32944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text boxHaveCountText;
			LuaObject.checkType<Text>(l, 2, out boxHaveCountText);
			storeListUIController.m_luaExportHelper.m_boxHaveCountText = boxHaveCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213EC RID: 136172 RVA: 0x00B347A0 File Offset: 0x00B329A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxDescText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213ED RID: 136173 RVA: 0x00B347F8 File Offset: 0x00B329F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxDescText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text boxDescText;
			LuaObject.checkType<Text>(l, 2, out boxDescText);
			storeListUIController.m_luaExportHelper.m_boxDescText = boxDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213EE RID: 136174 RVA: 0x00B34854 File Offset: 0x00B32A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxListScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213EF RID: 136175 RVA: 0x00B348AC File Offset: 0x00B32AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject boxListScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out boxListScrollViewContent);
			storeListUIController.m_luaExportHelper.m_boxListScrollViewContent = boxListScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F0 RID: 136176 RVA: 0x00B34908 File Offset: 0x00B32B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxPriceIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxPriceIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F1 RID: 136177 RVA: 0x00B34960 File Offset: 0x00B32B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxPriceIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image boxPriceIcon;
			LuaObject.checkType<Image>(l, 2, out boxPriceIcon);
			storeListUIController.m_luaExportHelper.m_boxPriceIcon = boxPriceIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F2 RID: 136178 RVA: 0x00B349BC File Offset: 0x00B32BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxPriceIconEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxPriceIconEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F3 RID: 136179 RVA: 0x00B34A14 File Offset: 0x00B32C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxPriceIconEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject boxPriceIconEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out boxPriceIconEffectGameObject);
			storeListUIController.m_luaExportHelper.m_boxPriceIconEffectGameObject = boxPriceIconEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F4 RID: 136180 RVA: 0x00B34A70 File Offset: 0x00B32C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxPriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxPriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F5 RID: 136181 RVA: 0x00B34AC8 File Offset: 0x00B32CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxPriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text boxPriceText;
			LuaObject.checkType<Text>(l, 2, out boxPriceText);
			storeListUIController.m_luaExportHelper.m_boxPriceText = boxPriceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F6 RID: 136182 RVA: 0x00B34B24 File Offset: 0x00B32D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxBuyPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxBuyPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F7 RID: 136183 RVA: 0x00B34B7C File Offset: 0x00B32D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxBuyPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button boxBuyPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out boxBuyPanelCloseButton);
			storeListUIController.m_luaExportHelper.m_boxBuyPanelCloseButton = boxBuyPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F8 RID: 136184 RVA: 0x00B34BD8 File Offset: 0x00B32DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_boxBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213F9 RID: 136185 RVA: 0x00B34C30 File Offset: 0x00B32E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button boxBuyButton;
			LuaObject.checkType<Button>(l, 2, out boxBuyButton);
			storeListUIController.m_luaExportHelper.m_boxBuyButton = boxBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213FA RID: 136186 RVA: 0x00B34C8C File Offset: 0x00B32E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213FB RID: 136187 RVA: 0x00B34CE4 File Offset: 0x00B32EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			storeListUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213FC RID: 136188 RVA: 0x00B34D40 File Offset: 0x00B32F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeBoxItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeBoxItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213FD RID: 136189 RVA: 0x00B34D98 File Offset: 0x00B32F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeBoxItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject storeBoxItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out storeBoxItemPrefab);
			storeListUIController.m_luaExportHelper.m_storeBoxItemPrefab = storeBoxItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213FE RID: 136190 RVA: 0x00B34DF4 File Offset: 0x00B32FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060213FF RID: 136191 RVA: 0x00B34E4C File Offset: 0x00B3304C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject storeItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out storeItemPrefab);
			storeListUIController.m_luaExportHelper.m_storeItemPrefab = storeItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021400 RID: 136192 RVA: 0x00B34EA8 File Offset: 0x00B330A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeHeroSkinItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeHeroSkinItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021401 RID: 136193 RVA: 0x00B34F00 File Offset: 0x00B33100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeHeroSkinItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject storeHeroSkinItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out storeHeroSkinItemPrefab);
			storeListUIController.m_luaExportHelper.m_storeHeroSkinItemPrefab = storeHeroSkinItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021402 RID: 136194 RVA: 0x00B34F5C File Offset: 0x00B3315C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeSoldierSkinItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeSoldierSkinItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021403 RID: 136195 RVA: 0x00B34FB4 File Offset: 0x00B331B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeSoldierSkinItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject storeSoldierSkinItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out storeSoldierSkinItemPrefab);
			storeListUIController.m_luaExportHelper.m_storeSoldierSkinItemPrefab = storeSoldierSkinItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021404 RID: 136196 RVA: 0x00B35010 File Offset: 0x00B33210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021405 RID: 136197 RVA: 0x00B35068 File Offset: 0x00B33268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			storeListUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021406 RID: 136198 RVA: 0x00B350C4 File Offset: 0x00B332C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021407 RID: 136199 RVA: 0x00B3511C File Offset: 0x00B3331C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle rechargeToggle;
			LuaObject.checkType<Toggle>(l, 2, out rechargeToggle);
			storeListUIController.m_luaExportHelper.m_rechargeToggle = rechargeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021408 RID: 136200 RVA: 0x00B35178 File Offset: 0x00B33378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_presentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021409 RID: 136201 RVA: 0x00B351D0 File Offset: 0x00B333D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle presentToggle;
			LuaObject.checkType<Toggle>(l, 2, out presentToggle);
			storeListUIController.m_luaExportHelper.m_presentToggle = presentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602140A RID: 136202 RVA: 0x00B3522C File Offset: 0x00B3342C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_crystalToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602140B RID: 136203 RVA: 0x00B35284 File Offset: 0x00B33484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle crystalToggle;
			LuaObject.checkType<Toggle>(l, 2, out crystalToggle);
			storeListUIController.m_luaExportHelper.m_crystalToggle = crystalToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602140C RID: 136204 RVA: 0x00B352E0 File Offset: 0x00B334E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_skinToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602140D RID: 136205 RVA: 0x00B35338 File Offset: 0x00B33538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle skinToggle;
			LuaObject.checkType<Toggle>(l, 2, out skinToggle);
			storeListUIController.m_luaExportHelper.m_skinToggle = skinToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602140E RID: 136206 RVA: 0x00B35394 File Offset: 0x00B33594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602140F RID: 136207 RVA: 0x00B353EC File Offset: 0x00B335EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousToggle = mysteriousToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021410 RID: 136208 RVA: 0x00B35448 File Offset: 0x00B33648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selfChoosePanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_selfChoosePanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021411 RID: 136209 RVA: 0x00B354A0 File Offset: 0x00B336A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selfChoosePanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject selfChoosePanel;
			LuaObject.checkType<GameObject>(l, 2, out selfChoosePanel);
			storeListUIController.m_luaExportHelper.m_selfChoosePanel = selfChoosePanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021412 RID: 136210 RVA: 0x00B354FC File Offset: 0x00B336FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshTimeText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021413 RID: 136211 RVA: 0x00B35554 File Offset: 0x00B33754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshTimeText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text refreshTimeText;
			LuaObject.checkType<Text>(l, 2, out refreshTimeText);
			storeListUIController.m_luaExportHelper.m_refreshTimeText = refreshTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021414 RID: 136212 RVA: 0x00B355B0 File Offset: 0x00B337B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshCurrencyTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshCurrencyTypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021415 RID: 136213 RVA: 0x00B35608 File Offset: 0x00B33808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshCurrencyTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image refreshCurrencyTypeIcon;
			LuaObject.checkType<Image>(l, 2, out refreshCurrencyTypeIcon);
			storeListUIController.m_luaExportHelper.m_refreshCurrencyTypeIcon = refreshCurrencyTypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021416 RID: 136214 RVA: 0x00B35664 File Offset: 0x00B33864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshCurrencyTypeIconEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshCurrencyTypeIconEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021417 RID: 136215 RVA: 0x00B356BC File Offset: 0x00B338BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshCurrencyTypeIconEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject refreshCurrencyTypeIconEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out refreshCurrencyTypeIconEffectGameObject);
			storeListUIController.m_luaExportHelper.m_refreshCurrencyTypeIconEffectGameObject = refreshCurrencyTypeIconEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021418 RID: 136216 RVA: 0x00B35718 File Offset: 0x00B33918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshPriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshPriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021419 RID: 136217 RVA: 0x00B35770 File Offset: 0x00B33970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshPriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text refreshPriceText;
			LuaObject.checkType<Text>(l, 2, out refreshPriceText);
			storeListUIController.m_luaExportHelper.m_refreshPriceText = refreshPriceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602141A RID: 136218 RVA: 0x00B357CC File Offset: 0x00B339CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602141B RID: 136219 RVA: 0x00B35824 File Offset: 0x00B33A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button refreshButton;
			LuaObject.checkType<Button>(l, 2, out refreshButton);
			storeListUIController.m_luaExportHelper.m_refreshButton = refreshButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602141C RID: 136220 RVA: 0x00B35880 File Offset: 0x00B33A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshTimesText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_refreshTimesText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602141D RID: 136221 RVA: 0x00B358D8 File Offset: 0x00B33AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshTimesText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text refreshTimesText;
			LuaObject.checkType<Text>(l, 2, out refreshTimesText);
			storeListUIController.m_luaExportHelper.m_refreshTimesText = refreshTimesText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602141E RID: 136222 RVA: 0x00B35934 File Offset: 0x00B33B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSkinToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_soldierSkinToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602141F RID: 136223 RVA: 0x00B3598C File Offset: 0x00B33B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSkinToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle soldierSkinToggle;
			LuaObject.checkType<Toggle>(l, 2, out soldierSkinToggle);
			storeListUIController.m_luaExportHelper.m_soldierSkinToggle = soldierSkinToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021420 RID: 136224 RVA: 0x00B359E8 File Offset: 0x00B33BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkinToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_heroSkinToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021421 RID: 136225 RVA: 0x00B35A40 File Offset: 0x00B33C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkinToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle heroSkinToggle;
			LuaObject.checkType<Toggle>(l, 2, out heroSkinToggle);
			storeListUIController.m_luaExportHelper.m_heroSkinToggle = heroSkinToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021422 RID: 136226 RVA: 0x00B35A9C File Offset: 0x00B33C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousBlackMarketToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousBlackMarketToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021423 RID: 136227 RVA: 0x00B35AF4 File Offset: 0x00B33CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousBlackMarketToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousBlackMarketToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousBlackMarketToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousBlackMarketToggle = mysteriousBlackMarketToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021424 RID: 136228 RVA: 0x00B35B50 File Offset: 0x00B33D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousHonorToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousHonorToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021425 RID: 136229 RVA: 0x00B35BA8 File Offset: 0x00B33DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousHonorToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousHonorToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousHonorToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousHonorToggle = mysteriousHonorToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021426 RID: 136230 RVA: 0x00B35C04 File Offset: 0x00B33E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousMedalToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousMedalToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021427 RID: 136231 RVA: 0x00B35C5C File Offset: 0x00B33E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousMedalToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousMedalToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousMedalToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousMedalToggle = mysteriousMedalToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021428 RID: 136232 RVA: 0x00B35CB8 File Offset: 0x00B33EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousFriendshipToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousFriendshipToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021429 RID: 136233 RVA: 0x00B35D10 File Offset: 0x00B33F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousFriendshipToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousFriendshipToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousFriendshipToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousFriendshipToggle = mysteriousFriendshipToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602142A RID: 136234 RVA: 0x00B35D6C File Offset: 0x00B33F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousUnionToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousUnionToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602142B RID: 136235 RVA: 0x00B35DC4 File Offset: 0x00B33FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousUnionToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousUnionToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousUnionToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousUnionToggle = mysteriousUnionToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602142C RID: 136236 RVA: 0x00B35E20 File Offset: 0x00B34020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentPresentToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_presentPresentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602142D RID: 136237 RVA: 0x00B35E78 File Offset: 0x00B34078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentPresentToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle presentPresentToggle;
			LuaObject.checkType<Toggle>(l, 2, out presentPresentToggle);
			storeListUIController.m_luaExportHelper.m_presentPresentToggle = presentPresentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602142E RID: 136238 RVA: 0x00B35ED4 File Offset: 0x00B340D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentPreogativeToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_presentPreogativeToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602142F RID: 136239 RVA: 0x00B35F2C File Offset: 0x00B3412C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentPreogativeToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle presentPreogativeToggle;
			LuaObject.checkType<Toggle>(l, 2, out presentPreogativeToggle);
			storeListUIController.m_luaExportHelper.m_presentPreogativeToggle = presentPreogativeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021430 RID: 136240 RVA: 0x00B35F88 File Offset: 0x00B34188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinHeroToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_skinHeroToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021431 RID: 136241 RVA: 0x00B35FE0 File Offset: 0x00B341E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinHeroToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle skinHeroToggle;
			LuaObject.checkType<Toggle>(l, 2, out skinHeroToggle);
			storeListUIController.m_luaExportHelper.m_skinHeroToggle = skinHeroToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021432 RID: 136242 RVA: 0x00B3603C File Offset: 0x00B3423C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinSoldierToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_skinSoldierToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021433 RID: 136243 RVA: 0x00B36094 File Offset: 0x00B34294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinSoldierToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle skinSoldierToggle;
			LuaObject.checkType<Toggle>(l, 2, out skinSoldierToggle);
			storeListUIController.m_luaExportHelper.m_skinSoldierToggle = skinSoldierToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021434 RID: 136244 RVA: 0x00B360F0 File Offset: 0x00B342F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousMemoryToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousMemoryToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021435 RID: 136245 RVA: 0x00B36148 File Offset: 0x00B34348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousMemoryToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousMemoryToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousMemoryToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousMemoryToggle = mysteriousMemoryToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021436 RID: 136246 RVA: 0x00B361A4 File Offset: 0x00B343A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mysteriousEquipmentToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_mysteriousEquipmentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021437 RID: 136247 RVA: 0x00B361FC File Offset: 0x00B343FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mysteriousEquipmentToggle(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Toggle mysteriousEquipmentToggle;
			LuaObject.checkType<Toggle>(l, 2, out mysteriousEquipmentToggle);
			storeListUIController.m_luaExportHelper.m_mysteriousEquipmentToggle = mysteriousEquipmentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021438 RID: 136248 RVA: 0x00B36258 File Offset: 0x00B34458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency1Obj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency1Obj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021439 RID: 136249 RVA: 0x00B362B0 File Offset: 0x00B344B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency1Obj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject currency1Obj;
			LuaObject.checkType<GameObject>(l, 2, out currency1Obj);
			storeListUIController.m_luaExportHelper.m_currency1Obj = currency1Obj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602143A RID: 136250 RVA: 0x00B3630C File Offset: 0x00B3450C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency1Icon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency1Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602143B RID: 136251 RVA: 0x00B36364 File Offset: 0x00B34564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency1Icon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image currency1Icon;
			LuaObject.checkType<Image>(l, 2, out currency1Icon);
			storeListUIController.m_luaExportHelper.m_currency1Icon = currency1Icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602143C RID: 136252 RVA: 0x00B363C0 File Offset: 0x00B345C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency1CountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency1CountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602143D RID: 136253 RVA: 0x00B36418 File Offset: 0x00B34618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency1CountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text currency1CountText;
			LuaObject.checkType<Text>(l, 2, out currency1CountText);
			storeListUIController.m_luaExportHelper.m_currency1CountText = currency1CountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602143E RID: 136254 RVA: 0x00B36474 File Offset: 0x00B34674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency1AddButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency1AddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602143F RID: 136255 RVA: 0x00B364CC File Offset: 0x00B346CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency1AddButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button currency1AddButton;
			LuaObject.checkType<Button>(l, 2, out currency1AddButton);
			storeListUIController.m_luaExportHelper.m_currency1AddButton = currency1AddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021440 RID: 136256 RVA: 0x00B36528 File Offset: 0x00B34728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency1DescriptionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency1DescriptionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021441 RID: 136257 RVA: 0x00B36580 File Offset: 0x00B34780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency1DescriptionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button currency1DescriptionButton;
			LuaObject.checkType<Button>(l, 2, out currency1DescriptionButton);
			storeListUIController.m_luaExportHelper.m_currency1DescriptionButton = currency1DescriptionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021442 RID: 136258 RVA: 0x00B365DC File Offset: 0x00B347DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency2Obj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency2Obj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021443 RID: 136259 RVA: 0x00B36634 File Offset: 0x00B34834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency2Obj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject currency2Obj;
			LuaObject.checkType<GameObject>(l, 2, out currency2Obj);
			storeListUIController.m_luaExportHelper.m_currency2Obj = currency2Obj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021444 RID: 136260 RVA: 0x00B36690 File Offset: 0x00B34890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency2Icon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency2Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021445 RID: 136261 RVA: 0x00B366E8 File Offset: 0x00B348E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency2Icon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image currency2Icon;
			LuaObject.checkType<Image>(l, 2, out currency2Icon);
			storeListUIController.m_luaExportHelper.m_currency2Icon = currency2Icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021446 RID: 136262 RVA: 0x00B36744 File Offset: 0x00B34944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency2CountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency2CountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021447 RID: 136263 RVA: 0x00B3679C File Offset: 0x00B3499C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency2CountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text currency2CountText;
			LuaObject.checkType<Text>(l, 2, out currency2CountText);
			storeListUIController.m_luaExportHelper.m_currency2CountText = currency2CountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021448 RID: 136264 RVA: 0x00B367F8 File Offset: 0x00B349F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency2AddButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency2AddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021449 RID: 136265 RVA: 0x00B36850 File Offset: 0x00B34A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency2AddButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button currency2AddButton;
			LuaObject.checkType<Button>(l, 2, out currency2AddButton);
			storeListUIController.m_luaExportHelper.m_currency2AddButton = currency2AddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602144A RID: 136266 RVA: 0x00B368AC File Offset: 0x00B34AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency2DescriptionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency2DescriptionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602144B RID: 136267 RVA: 0x00B36904 File Offset: 0x00B34B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency2DescriptionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button currency2DescriptionButton;
			LuaObject.checkType<Button>(l, 2, out currency2DescriptionButton);
			storeListUIController.m_luaExportHelper.m_currency2DescriptionButton = currency2DescriptionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602144C RID: 136268 RVA: 0x00B36960 File Offset: 0x00B34B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency3Obj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency3Obj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602144D RID: 136269 RVA: 0x00B369B8 File Offset: 0x00B34BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency3Obj(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject currency3Obj;
			LuaObject.checkType<GameObject>(l, 2, out currency3Obj);
			storeListUIController.m_luaExportHelper.m_currency3Obj = currency3Obj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602144E RID: 136270 RVA: 0x00B36A14 File Offset: 0x00B34C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency3Icon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency3Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602144F RID: 136271 RVA: 0x00B36A6C File Offset: 0x00B34C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency3Icon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image currency3Icon;
			LuaObject.checkType<Image>(l, 2, out currency3Icon);
			storeListUIController.m_luaExportHelper.m_currency3Icon = currency3Icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021450 RID: 136272 RVA: 0x00B36AC8 File Offset: 0x00B34CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency3CountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency3CountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021451 RID: 136273 RVA: 0x00B36B20 File Offset: 0x00B34D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency3CountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text currency3CountText;
			LuaObject.checkType<Text>(l, 2, out currency3CountText);
			storeListUIController.m_luaExportHelper.m_currency3CountText = currency3CountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021452 RID: 136274 RVA: 0x00B36B7C File Offset: 0x00B34D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency3AddButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency3AddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021453 RID: 136275 RVA: 0x00B36BD4 File Offset: 0x00B34DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency3AddButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button currency3AddButton;
			LuaObject.checkType<Button>(l, 2, out currency3AddButton);
			storeListUIController.m_luaExportHelper.m_currency3AddButton = currency3AddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021454 RID: 136276 RVA: 0x00B36C30 File Offset: 0x00B34E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currency3DescriptionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_currency3DescriptionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021455 RID: 136277 RVA: 0x00B36C88 File Offset: 0x00B34E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currency3DescriptionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button currency3DescriptionButton;
			LuaObject.checkType<Button>(l, 2, out currency3DescriptionButton);
			storeListUIController.m_luaExportHelper.m_currency3DescriptionButton = currency3DescriptionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021456 RID: 136278 RVA: 0x00B36CE4 File Offset: 0x00B34EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021457 RID: 136279 RVA: 0x00B36D3C File Offset: 0x00B34F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text rechargeNameText;
			LuaObject.checkType<Text>(l, 2, out rechargeNameText);
			storeListUIController.m_luaExportHelper.m_rechargeNameText = rechargeNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021458 RID: 136280 RVA: 0x00B36D98 File Offset: 0x00B34F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021459 RID: 136281 RVA: 0x00B36DF0 File Offset: 0x00B34FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image rechargeIconImage;
			LuaObject.checkType<Image>(l, 2, out rechargeIconImage);
			storeListUIController.m_luaExportHelper.m_rechargeIconImage = rechargeIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602145A RID: 136282 RVA: 0x00B36E4C File Offset: 0x00B3504C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeHaveCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602145B RID: 136283 RVA: 0x00B36EA4 File Offset: 0x00B350A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text rechargeHaveCountText;
			LuaObject.checkType<Text>(l, 2, out rechargeHaveCountText);
			storeListUIController.m_luaExportHelper.m_rechargeHaveCountText = rechargeHaveCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602145C RID: 136284 RVA: 0x00B36F00 File Offset: 0x00B35100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargePriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargePriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602145D RID: 136285 RVA: 0x00B36F58 File Offset: 0x00B35158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargePriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text rechargePriceText;
			LuaObject.checkType<Text>(l, 2, out rechargePriceText);
			storeListUIController.m_luaExportHelper.m_rechargePriceText = rechargePriceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602145E RID: 136286 RVA: 0x00B36FB4 File Offset: 0x00B351B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeGetCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeGetCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602145F RID: 136287 RVA: 0x00B3700C File Offset: 0x00B3520C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeGetCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text rechargeGetCountText;
			LuaObject.checkType<Text>(l, 2, out rechargeGetCountText);
			storeListUIController.m_luaExportHelper.m_rechargeGetCountText = rechargeGetCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021460 RID: 136288 RVA: 0x00B37068 File Offset: 0x00B35268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeGetExtraCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeGetExtraCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021461 RID: 136289 RVA: 0x00B370C0 File Offset: 0x00B352C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeGetExtraCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text rechargeGetExtraCountText;
			LuaObject.checkType<Text>(l, 2, out rechargeGetExtraCountText);
			storeListUIController.m_luaExportHelper.m_rechargeGetExtraCountText = rechargeGetExtraCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021462 RID: 136290 RVA: 0x00B3711C File Offset: 0x00B3531C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargePanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021463 RID: 136291 RVA: 0x00B37174 File Offset: 0x00B35374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button rechargePanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out rechargePanelCloseButton);
			storeListUIController.m_luaExportHelper.m_rechargePanelCloseButton = rechargePanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021464 RID: 136292 RVA: 0x00B371D0 File Offset: 0x00B353D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargePanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargePanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021465 RID: 136293 RVA: 0x00B37228 File Offset: 0x00B35428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargePanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController rechargePanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out rechargePanelUIStateController);
			storeListUIController.m_luaExportHelper.m_rechargePanelUIStateController = rechargePanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021466 RID: 136294 RVA: 0x00B37284 File Offset: 0x00B35484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_rechargeBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021467 RID: 136295 RVA: 0x00B372DC File Offset: 0x00B354DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button rechargeBuyButton;
			LuaObject.checkType<Button>(l, 2, out rechargeBuyButton);
			storeListUIController.m_luaExportHelper.m_rechargeBuyButton = rechargeBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021468 RID: 136296 RVA: 0x00B37338 File Offset: 0x00B35538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021469 RID: 136297 RVA: 0x00B37390 File Offset: 0x00B35590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			storeListUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602146A RID: 136298 RVA: 0x00B373EC File Offset: 0x00B355EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeBuyDetailPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeBuyDetailPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602146B RID: 136299 RVA: 0x00B37444 File Offset: 0x00B35644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeBuyDetailPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController storePrivilegeBuyDetailPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out storePrivilegeBuyDetailPanelStateCtrl);
			storeListUIController.m_luaExportHelper.m_storePrivilegeBuyDetailPanelStateCtrl = storePrivilegeBuyDetailPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602146C RID: 136300 RVA: 0x00B374A0 File Offset: 0x00B356A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeBuyDetailPanelBGButon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeBuyDetailPanelBGButon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602146D RID: 136301 RVA: 0x00B374F8 File Offset: 0x00B356F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeBuyDetailPanelBGButon(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button storePrivilegeBuyDetailPanelBGButon;
			LuaObject.checkType<Button>(l, 2, out storePrivilegeBuyDetailPanelBGButon);
			storeListUIController.m_luaExportHelper.m_storePrivilegeBuyDetailPanelBGButon = storePrivilegeBuyDetailPanelBGButon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602146E RID: 136302 RVA: 0x00B37554 File Offset: 0x00B35754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602146F RID: 136303 RVA: 0x00B375AC File Offset: 0x00B357AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController storePrivilegeStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out storePrivilegeStateCtrl);
			storeListUIController.m_luaExportHelper.m_storePrivilegeStateCtrl = storePrivilegeStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021470 RID: 136304 RVA: 0x00B37608 File Offset: 0x00B35808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_StorePrivilegeItemName(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_StorePrivilegeItemName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021471 RID: 136305 RVA: 0x00B37660 File Offset: 0x00B35860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_StorePrivilegeItemName(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text storePrivilegeItemName;
			LuaObject.checkType<Text>(l, 2, out storePrivilegeItemName);
			storeListUIController.m_luaExportHelper.m_StorePrivilegeItemName = storePrivilegeItemName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021472 RID: 136306 RVA: 0x00B376BC File Offset: 0x00B358BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_StorePrivilegeItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_StorePrivilegeItemIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021473 RID: 136307 RVA: 0x00B37714 File Offset: 0x00B35914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_StorePrivilegeItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Image storePrivilegeItemIconImage;
			LuaObject.checkType<Image>(l, 2, out storePrivilegeItemIconImage);
			storeListUIController.m_luaExportHelper.m_StorePrivilegeItemIconImage = storePrivilegeItemIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021474 RID: 136308 RVA: 0x00B37770 File Offset: 0x00B35970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeItemCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeItemCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021475 RID: 136309 RVA: 0x00B377C8 File Offset: 0x00B359C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeItemCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text storePrivilegeItemCountText;
			LuaObject.checkType<Text>(l, 2, out storePrivilegeItemCountText);
			storeListUIController.m_luaExportHelper.m_storePrivilegeItemCountText = storePrivilegeItemCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021476 RID: 136310 RVA: 0x00B37824 File Offset: 0x00B35A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeItemDescText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeItemDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021477 RID: 136311 RVA: 0x00B3787C File Offset: 0x00B35A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeItemDescText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text storePrivilegeItemDescText;
			LuaObject.checkType<Text>(l, 2, out storePrivilegeItemDescText);
			storeListUIController.m_luaExportHelper.m_storePrivilegeItemDescText = storePrivilegeItemDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021478 RID: 136312 RVA: 0x00B378D8 File Offset: 0x00B35AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeItemLeftDayGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeItemLeftDayGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021479 RID: 136313 RVA: 0x00B37930 File Offset: 0x00B35B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeItemLeftDayGameObject(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject storePrivilegeItemLeftDayGameObject;
			LuaObject.checkType<GameObject>(l, 2, out storePrivilegeItemLeftDayGameObject);
			storeListUIController.m_luaExportHelper.m_storePrivilegeItemLeftDayGameObject = storePrivilegeItemLeftDayGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602147A RID: 136314 RVA: 0x00B3798C File Offset: 0x00B35B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeItemLeftDay(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeItemLeftDay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602147B RID: 136315 RVA: 0x00B379E4 File Offset: 0x00B35BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeItemLeftDay(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text storePrivilegeItemLeftDay;
			LuaObject.checkType<Text>(l, 2, out storePrivilegeItemLeftDay);
			storeListUIController.m_luaExportHelper.m_storePrivilegeItemLeftDay = storePrivilegeItemLeftDay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602147C RID: 136316 RVA: 0x00B37A40 File Offset: 0x00B35C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeItemBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeItemBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602147D RID: 136317 RVA: 0x00B37A98 File Offset: 0x00B35C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeItemBuyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button storePrivilegeItemBuyButton;
			LuaObject.checkType<Button>(l, 2, out storePrivilegeItemBuyButton);
			storeListUIController.m_luaExportHelper.m_storePrivilegeItemBuyButton = storePrivilegeItemBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602147E RID: 136318 RVA: 0x00B37AF4 File Offset: 0x00B35CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storePrivilegeItemBuyPrice(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storePrivilegeItemBuyPrice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602147F RID: 136319 RVA: 0x00B37B4C File Offset: 0x00B35D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storePrivilegeItemBuyPrice(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text storePrivilegeItemBuyPrice;
			LuaObject.checkType<Text>(l, 2, out storePrivilegeItemBuyPrice);
			storeListUIController.m_luaExportHelper.m_storePrivilegeItemBuyPrice = storePrivilegeItemBuyPrice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021480 RID: 136320 RVA: 0x00B37BA8 File Offset: 0x00B35DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeMonthExtraRewardCount(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeMonthExtraRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021481 RID: 136321 RVA: 0x00B37C00 File Offset: 0x00B35E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeMonthExtraRewardCount(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text storeMonthExtraRewardCount;
			LuaObject.checkType<Text>(l, 2, out storeMonthExtraRewardCount);
			storeListUIController.m_luaExportHelper.m_storeMonthExtraRewardCount = storeMonthExtraRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021482 RID: 136322 RVA: 0x00B37C5C File Offset: 0x00B35E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subscribePrice(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_subscribePrice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021483 RID: 136323 RVA: 0x00B37CB4 File Offset: 0x00B35EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subscribePrice(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text subscribePrice;
			LuaObject.checkType<Text>(l, 2, out subscribePrice);
			storeListUIController.m_luaExportHelper.m_subscribePrice = subscribePrice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021484 RID: 136324 RVA: 0x00B37D10 File Offset: 0x00B35F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subscribePanelPrivateButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_subscribePanelPrivateButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021485 RID: 136325 RVA: 0x00B37D68 File Offset: 0x00B35F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subscribePanelPrivateButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button subscribePanelPrivateButton;
			LuaObject.checkType<Button>(l, 2, out subscribePanelPrivateButton);
			storeListUIController.m_luaExportHelper.m_subscribePanelPrivateButton = subscribePanelPrivateButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021486 RID: 136326 RVA: 0x00B37DC4 File Offset: 0x00B35FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_subscribePanelCancelSubscribeButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_subscribePanelCancelSubscribeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021487 RID: 136327 RVA: 0x00B37E1C File Offset: 0x00B3601C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_subscribePanelCancelSubscribeButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button subscribePanelCancelSubscribeButton;
			LuaObject.checkType<Button>(l, 2, out subscribePanelCancelSubscribeButton);
			storeListUIController.m_luaExportHelper.m_subscribePanelCancelSubscribeButton = subscribePanelCancelSubscribeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021488 RID: 136328 RVA: 0x00B37E78 File Offset: 0x00B36078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryEntranceButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryEntranceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021489 RID: 136329 RVA: 0x00B37ED0 File Offset: 0x00B360D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryEntranceButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button memoryEntranceButton;
			LuaObject.checkType<Button>(l, 2, out memoryEntranceButton);
			storeListUIController.m_luaExportHelper.m_memoryEntranceButton = memoryEntranceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602148A RID: 136330 RVA: 0x00B37F2C File Offset: 0x00B3612C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryEntranceButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryEntranceButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602148B RID: 136331 RVA: 0x00B37F84 File Offset: 0x00B36184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryEntranceButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController memoryEntranceButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out memoryEntranceButtonStateCtrl);
			storeListUIController.m_luaExportHelper.m_memoryEntranceButtonStateCtrl = memoryEntranceButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602148C RID: 136332 RVA: 0x00B37FE0 File Offset: 0x00B361E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryEntranceButtonRedPoint(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryEntranceButtonRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602148D RID: 136333 RVA: 0x00B38038 File Offset: 0x00B36238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryEntranceButtonRedPoint(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject memoryEntranceButtonRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out memoryEntranceButtonRedPoint);
			storeListUIController.m_luaExportHelper.m_memoryEntranceButtonRedPoint = memoryEntranceButtonRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602148E RID: 136334 RVA: 0x00B38094 File Offset: 0x00B36294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602148F RID: 136335 RVA: 0x00B380EC File Offset: 0x00B362EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			CommonUIStateController memoryExtractionPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out memoryExtractionPanelStateCtrl);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelStateCtrl = memoryExtractionPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021490 RID: 136336 RVA: 0x00B38148 File Offset: 0x00B36348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelScrollRect(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021491 RID: 136337 RVA: 0x00B381A0 File Offset: 0x00B363A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelScrollRect(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			ScrollRect memoryExtractionPanelScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out memoryExtractionPanelScrollRect);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelScrollRect = memoryExtractionPanelScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021492 RID: 136338 RVA: 0x00B381FC File Offset: 0x00B363FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelScrollContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelScrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021493 RID: 136339 RVA: 0x00B38254 File Offset: 0x00B36454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelScrollContent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject memoryExtractionPanelScrollContent;
			LuaObject.checkType<GameObject>(l, 2, out memoryExtractionPanelScrollContent);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelScrollContent = memoryExtractionPanelScrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021494 RID: 136340 RVA: 0x00B382B0 File Offset: 0x00B364B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelHelpButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelHelpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021495 RID: 136341 RVA: 0x00B38308 File Offset: 0x00B36508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelHelpButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button memoryExtractionPanelHelpButton;
			LuaObject.checkType<Button>(l, 2, out memoryExtractionPanelHelpButton);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelHelpButton = memoryExtractionPanelHelpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021496 RID: 136342 RVA: 0x00B38364 File Offset: 0x00B36564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelExtractionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelExtractionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021497 RID: 136343 RVA: 0x00B383BC File Offset: 0x00B365BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelExtractionButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button memoryExtractionPanelExtractionButton;
			LuaObject.checkType<Button>(l, 2, out memoryExtractionPanelExtractionButton);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelExtractionButton = memoryExtractionPanelExtractionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021498 RID: 136344 RVA: 0x00B38418 File Offset: 0x00B36618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelTotalValueText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelTotalValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021499 RID: 136345 RVA: 0x00B38470 File Offset: 0x00B36670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelTotalValueText(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Text memoryExtractionPanelTotalValueText;
			LuaObject.checkType<Text>(l, 2, out memoryExtractionPanelTotalValueText);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelTotalValueText = memoryExtractionPanelTotalValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602149A RID: 136346 RVA: 0x00B384CC File Offset: 0x00B366CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602149B RID: 136347 RVA: 0x00B38524 File Offset: 0x00B36724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button memoryExtractionPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out memoryExtractionPanelCloseButton);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelCloseButton = memoryExtractionPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602149C RID: 136348 RVA: 0x00B38580 File Offset: 0x00B36780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelBGReturnButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelBGReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602149D RID: 136349 RVA: 0x00B385D8 File Offset: 0x00B367D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelBGReturnButton(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Button memoryExtractionPanelBGReturnButton;
			LuaObject.checkType<Button>(l, 2, out memoryExtractionPanelBGReturnButton);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelBGReturnButton = memoryExtractionPanelBGReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602149E RID: 136350 RVA: 0x00B38634 File Offset: 0x00B36834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryExtractionPanelEmptyTip(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_memoryExtractionPanelEmptyTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602149F RID: 136351 RVA: 0x00B3868C File Offset: 0x00B3688C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryExtractionPanelEmptyTip(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject memoryExtractionPanelEmptyTip;
			LuaObject.checkType<GameObject>(l, 2, out memoryExtractionPanelEmptyTip);
			storeListUIController.m_luaExportHelper.m_memoryExtractionPanelEmptyTip = memoryExtractionPanelEmptyTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A0 RID: 136352 RVA: 0x00B386E8 File Offset: 0x00B368E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_HeroFragmentItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_HeroFragmentItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A1 RID: 136353 RVA: 0x00B38740 File Offset: 0x00B36940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_HeroFragmentItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObject heroFragmentItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroFragmentItemPrefab);
			storeListUIController.m_luaExportHelper.m_HeroFragmentItemPrefab = heroFragmentItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A2 RID: 136354 RVA: 0x00B3879C File Offset: 0x00B3699C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needRefreshPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_needRefreshPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A3 RID: 136355 RVA: 0x00B387F4 File Offset: 0x00B369F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needRefreshPanel(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool needRefreshPanel;
			LuaObject.checkType(l, 2, out needRefreshPanel);
			storeListUIController.m_luaExportHelper.m_needRefreshPanel = needRefreshPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A4 RID: 136356 RVA: 0x00B38850 File Offset: 0x00B36A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A5 RID: 136357 RVA: 0x00B388A8 File Offset: 0x00B36AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			storeListUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A6 RID: 136358 RVA: 0x00B38904 File Offset: 0x00B36B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeListUIController.m_luaExportHelper.m_storeType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A7 RID: 136359 RVA: 0x00B3895C File Offset: 0x00B36B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			storeListUIController.m_luaExportHelper.m_storeType = storeType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A8 RID: 136360 RVA: 0x00B389B8 File Offset: 0x00B36BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeId(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeListUIController.m_luaExportHelper.m_storeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214A9 RID: 136361 RVA: 0x00B38A10 File Offset: 0x00B36C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeId(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeListUIController.m_luaExportHelper.m_storeId = storeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214AA RID: 136362 RVA: 0x00B38A6C File Offset: 0x00B36C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fixedStoreItemGoodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_fixedStoreItemGoodsID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214AB RID: 136363 RVA: 0x00B38AC4 File Offset: 0x00B36CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fixedStoreItemGoodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			int fixedStoreItemGoodsID;
			LuaObject.checkType(l, 2, out fixedStoreItemGoodsID);
			storeListUIController.m_luaExportHelper.m_fixedStoreItemGoodsID = fixedStoreItemGoodsID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214AC RID: 136364 RVA: 0x00B38B20 File Offset: 0x00B36D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_goodsID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214AD RID: 136365 RVA: 0x00B38B78 File Offset: 0x00B36D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			int goodsID;
			LuaObject.checkType(l, 2, out goodsID);
			storeListUIController.m_luaExportHelper.m_goodsID = goodsID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214AE RID: 136366 RVA: 0x00B38BD4 File Offset: 0x00B36DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214AF RID: 136367 RVA: 0x00B38C2C File Offset: 0x00B36E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			storeListUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B0 RID: 136368 RVA: 0x00B38C88 File Offset: 0x00B36E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fixedStoreID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeListUIController.m_luaExportHelper.m_fixedStoreID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B1 RID: 136369 RVA: 0x00B38CE0 File Offset: 0x00B36EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fixedStoreID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId fixedStoreID;
			LuaObject.checkEnum<StoreId>(l, 2, out fixedStoreID);
			storeListUIController.m_luaExportHelper.m_fixedStoreID = fixedStoreID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B2 RID: 136370 RVA: 0x00B38D3C File Offset: 0x00B36F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomStoreID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeListUIController.m_luaExportHelper.m_randomStoreID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B3 RID: 136371 RVA: 0x00B38D94 File Offset: 0x00B36F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomStoreID(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreId randomStoreID;
			LuaObject.checkEnum<StoreId>(l, 2, out randomStoreID);
			storeListUIController.m_luaExportHelper.m_randomStoreID = randomStoreID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B4 RID: 136372 RVA: 0x00B38DF0 File Offset: 0x00B36FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStaticBox(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_isStaticBox);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B5 RID: 136373 RVA: 0x00B38E48 File Offset: 0x00B37048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStaticBox(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			bool isStaticBox;
			LuaObject.checkType(l, 2, out isStaticBox);
			storeListUIController.m_luaExportHelper.m_isStaticBox = isStaticBox;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B6 RID: 136374 RVA: 0x00B38EA4 File Offset: 0x00B370A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selfChooseItemIndex(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_selfChooseItemIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B7 RID: 136375 RVA: 0x00B38EF8 File Offset: 0x00B370F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selfChooseItemIndex(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			int selfChooseItemIndex;
			LuaObject.checkType(l, 2, out selfChooseItemIndex);
			storeListUIController.m_selfChooseItemIndex = selfChooseItemIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B8 RID: 136376 RVA: 0x00B38F50 File Offset: 0x00B37150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewStoreContentOriginalLocalPos(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_scrollViewStoreContentOriginalLocalPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214B9 RID: 136377 RVA: 0x00B38FA8 File Offset: 0x00B371A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewStoreContentOriginalLocalPos(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Vector3 scrollViewStoreContentOriginalLocalPos;
			LuaObject.checkType(l, 2, out scrollViewStoreContentOriginalLocalPos);
			storeListUIController.m_luaExportHelper.m_scrollViewStoreContentOriginalLocalPos = scrollViewStoreContentOriginalLocalPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214BA RID: 136378 RVA: 0x00B39004 File Offset: 0x00B37204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewHeroContentOriginalLocalPos(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_scrollViewHeroContentOriginalLocalPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214BB RID: 136379 RVA: 0x00B3905C File Offset: 0x00B3725C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewHeroContentOriginalLocalPos(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Vector3 scrollViewHeroContentOriginalLocalPos;
			LuaObject.checkType(l, 2, out scrollViewHeroContentOriginalLocalPos);
			storeListUIController.m_luaExportHelper.m_scrollViewHeroContentOriginalLocalPos = scrollViewHeroContentOriginalLocalPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214BC RID: 136380 RVA: 0x00B390B8 File Offset: 0x00B372B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_giftStoreItem(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_giftStoreItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214BD RID: 136381 RVA: 0x00B39110 File Offset: 0x00B37310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_giftStoreItem(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GiftStoreItem giftStoreItem;
			LuaObject.checkType<GiftStoreItem>(l, 2, out giftStoreItem);
			storeListUIController.m_luaExportHelper.m_giftStoreItem = giftStoreItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214BE RID: 136382 RVA: 0x00B3916C File Offset: 0x00B3736C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeUnderItemPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeUnderItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214BF RID: 136383 RVA: 0x00B391C4 File Offset: 0x00B373C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeUnderItemPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObjectPool<StoreItemUIController> storeUnderItemPool;
			LuaObject.checkType<GameObjectPool<StoreItemUIController>>(l, 2, out storeUnderItemPool);
			storeListUIController.m_luaExportHelper.m_storeUnderItemPool = storeUnderItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C0 RID: 136384 RVA: 0x00B39220 File Offset: 0x00B37420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeHeroSkinItemPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeHeroSkinItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C1 RID: 136385 RVA: 0x00B39278 File Offset: 0x00B37478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeHeroSkinItemPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObjectPool<StoreHeroSkinItemUIController> storeHeroSkinItemPool;
			LuaObject.checkType<GameObjectPool<StoreHeroSkinItemUIController>>(l, 2, out storeHeroSkinItemPool);
			storeListUIController.m_luaExportHelper.m_storeHeroSkinItemPool = storeHeroSkinItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C2 RID: 136386 RVA: 0x00B392D4 File Offset: 0x00B374D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeSoldierSkinItemPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeSoldierSkinItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C3 RID: 136387 RVA: 0x00B3932C File Offset: 0x00B3752C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeSoldierSkinItemPool(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			GameObjectPool<StoreSoldierSkinItemUIController> storeSoldierSkinItemPool;
			LuaObject.checkType<GameObjectPool<StoreSoldierSkinItemUIController>>(l, 2, out storeSoldierSkinItemPool);
			storeListUIController.m_luaExportHelper.m_storeSoldierSkinItemPool = storeSoldierSkinItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C4 RID: 136388 RVA: 0x00B39388 File Offset: 0x00B37588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gainGoodsList(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_gainGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C5 RID: 136389 RVA: 0x00B393E0 File Offset: 0x00B375E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gainGoodsList(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out gainGoodsList);
			storeListUIController.m_luaExportHelper.m_gainGoodsList = gainGoodsList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C6 RID: 136390 RVA: 0x00B3943C File Offset: 0x00B3763C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeSubType2ToggleDic(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeSubType2ToggleDic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C7 RID: 136391 RVA: 0x00B39494 File Offset: 0x00B37694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeSubType2ToggleDic(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			Dictionary<StoreId, List<Toggle>> storeSubType2ToggleDic;
			LuaObject.checkType<Dictionary<StoreId, List<Toggle>>>(l, 2, out storeSubType2ToggleDic);
			storeListUIController.m_luaExportHelper.m_storeSubType2ToggleDic = storeSubType2ToggleDic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C8 RID: 136392 RVA: 0x00B394F0 File Offset: 0x00B376F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeSelfChooseUIController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_storeSelfChooseUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214C9 RID: 136393 RVA: 0x00B39548 File Offset: 0x00B37748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeSelfChooseUIController(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			StoreSelfChooseUIController storeSelfChooseUIController;
			LuaObject.checkType<StoreSelfChooseUIController>(l, 2, out storeSelfChooseUIController);
			storeListUIController.m_luaExportHelper.m_storeSelfChooseUIController = storeSelfChooseUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214CA RID: 136394 RVA: 0x00B395A4 File Offset: 0x00B377A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214CB RID: 136395 RVA: 0x00B395FC File Offset: 0x00B377FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			storeListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214CC RID: 136396 RVA: 0x00B39658 File Offset: 0x00B37858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214CD RID: 136397 RVA: 0x00B396B0 File Offset: 0x00B378B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			storeListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214CE RID: 136398 RVA: 0x00B3970C File Offset: 0x00B3790C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurStoreId(IntPtr l)
	{
		int result;
		try
		{
			StoreListUIController storeListUIController = (StoreListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeListUIController.CurStoreId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214CF RID: 136399 RVA: 0x00B39760 File Offset: 0x00B37960
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreListUIController");
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.GetHeroSkinItemCtrlByFixedStoreItemId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateHeroSkinItemLimitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetSkinTicketCountText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.IsNeedRefreshPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.StoreOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetNormalItemBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetItemBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetRandomStoreCountDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OpenBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMemoryEntranceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetMemoryExtractionPanelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.GetStoreTypeByStoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateRechargeStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateGiftStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateFixedStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.ClearPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateFixedStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateHeroSkinInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateSoldierSkinInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateRandomStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateRechargeStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetDefaultState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetFixedStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SortFixedStoreItemByUISort);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.RefreshCurrencyDisplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetRandomStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetRechargeStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.ShowRefreshPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.HideRefreshPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetRefreshPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnStoreItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnHeroSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnSoldierSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetStoreBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetRechargeBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetBoxBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetEnchantStoneResonanceInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateGiftStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetGiftStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetGiftStoreBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetGiftStoreStaticBoxBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SetMothCardBuyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnPresentPresentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnPresentPreogativeToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMonthCardBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnSubscribePrivateClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnCancelSubscribeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMonthCardPanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnPresentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnRefreshButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnItemBuyPanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnItemBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnBoxBuyPanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnRechargePanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnBoxBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.IsStoreItemIOSSubscribeItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SortFragmentItemComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMemoryExtractionPanelExtractionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMemeryExtractionHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.CloseMemoryExtractionPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.FireChangeStoreEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnRechargeBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnRechargeToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnCystalToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnSkinToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnSkinTab_HeroToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnSkinTab_SoldierToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousBlackMarketToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousMemoryToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousEquipmentToggleValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousHonorToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousMedalToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousFriendshipToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.OnMysteriousUnionToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.InitStoreSubType2Toggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.SaveOriginalScrollViewLocalPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.UpdateToggles);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.FixedStoreSkinListSortFunc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnChangeStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnChangeStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnFixedStoreHeroSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnFixedStoreHeroSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnFixedStoreSoldierSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnFixedStoreSoldierSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnFixedStoreItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnFixedStoreItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnFixedStoreBoxBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnFixedStoreBoxBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnRandomStoreItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnRandomStoreItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnRandomStoreBoxBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnRandomStoreBoxBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnRechargeStoreBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnRechargeStoreBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnGiftStoreBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnGiftStoreBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnGetRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnGetRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnRefreshRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnRefreshRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnExtraButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnExtraButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__callDele_EventOnMemoryExtraction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.__clearDele_EventOnMemoryExtraction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache80);
		string name = "EventOnChangeStore";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnChangeStore);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache81, true);
		string name2 = "EventOnFixedStoreHeroSkinItemClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnFixedStoreHeroSkinItemClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache82, true);
		string name3 = "EventOnFixedStoreSoldierSkinItemClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnFixedStoreSoldierSkinItemClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache83, true);
		string name4 = "EventOnSkinItemOutOfDate";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache84, true);
		string name5 = "EventOnFixedStoreItemBuyClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnFixedStoreItemBuyClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache85, true);
		string name6 = "EventOnFixedStoreBoxBuyClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnFixedStoreBoxBuyClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache86, true);
		string name7 = "EventOnRandomStoreItemBuyClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnRandomStoreItemBuyClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache87, true);
		string name8 = "EventOnRandomStoreBoxBuyClick";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnRandomStoreBoxBuyClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache88, true);
		string name9 = "EventOnRechargeStoreBuyClick";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnRechargeStoreBuyClick);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache89, true);
		string name10 = "EventOnGiftStoreBuyClick";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnGiftStoreBuyClick);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8A, true);
		string name11 = "EventOnGetRandomStore";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnGetRandomStore);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8B, true);
		string name12 = "EventOnRefreshRandomStore";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnRefreshRandomStore);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8C, true);
		string name13 = "EventOnCrystalNotEnough";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8D, true);
		string name14 = "EventOnClose";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8E, true);
		string name15 = "EventOnExtraButtonClick";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnExtraButtonClick);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache8F, true);
		string name16 = "EventOnMemoryExtraction";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_EventOnMemoryExtraction);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache90, true);
		string name17 = "m_storeUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeUIStateCtrl);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeUIStateCtrl);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache92, true);
		string name18 = "m_refreshPanelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshPanelUIStateCtrl);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshPanelUIStateCtrl);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache94, true);
		string name19 = "m_scrollViewStoreContent";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_scrollViewStoreContent);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_scrollViewStoreContent);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache96, true);
		string name20 = "m_scrollViewHeroContent";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_scrollViewHeroContent);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_scrollViewHeroContent);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache98, true);
		string name21 = "m_itemBuyPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemBuyPanelUIStateController);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemBuyPanelUIStateController);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9A, true);
		string name22 = "m_itemIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemIconImage);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemIconImage);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9C, true);
		string name23 = "m_itemCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemCountText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemCountText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9E, true);
		string name24 = "m_itemCountBgGo";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemCountBgGo);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemCountBgGo);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA0, true);
		string name25 = "m_itemNameText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemNameText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemNameText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA2, true);
		string name26 = "m_itemGoodCountObj";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemGoodCountObj);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemGoodCountObj);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA4, true);
		string name27 = "m_itemHaveCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemHaveCountText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemHaveCountText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA6, true);
		string name28 = "m_itemDescText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemDescText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemDescText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA8, true);
		string name29 = "m_itemPriceIcon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemPriceIcon);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemPriceIcon);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAA, true);
		string name30 = "m_itemPriceIconEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemPriceIconEffectGameObject);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemPriceIconEffectGameObject);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAC, true);
		string name31 = "m_itemPriceText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemPriceText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemPriceText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAE, true);
		string name32 = "m_itemBuyPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemBuyPanelCloseButton);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemBuyPanelCloseButton);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB0, true);
		string name33 = "m_itemBuyButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_itemBuyButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_itemBuyButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB2, true);
		string name34 = "m_resonanceInfoPanel";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_resonanceInfoPanel);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_resonanceInfoPanel);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB4, true);
		string name35 = "m_resonanceInfoPanelNameText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_resonanceInfoPanelNameText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_resonanceInfoPanelNameText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB6, true);
		string name36 = "m_resonanceInfoPanel2SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_resonanceInfoPanel2SuitInfoText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_resonanceInfoPanel2SuitInfoText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB8, true);
		string name37 = "m_resonanceInfoPanel4SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_resonanceInfoPanel4SuitInfoText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_resonanceInfoPanel4SuitInfoText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBA, true);
		string name38 = "m_boxBuyPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxBuyPanelUIStateController);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxBuyPanelUIStateController);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBC, true);
		string name39 = "m_boxIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxIconImage);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxIconImage);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBE, true);
		string name40 = "m_boxCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxCountText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxCountText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC0, true);
		string name41 = "m_boxNameText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxNameText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxNameText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC2, true);
		string name42 = "m_boxHaveCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxHaveCountText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxHaveCountText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC4, true);
		string name43 = "m_boxDescText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxDescText);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxDescText);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC6, true);
		string name44 = "m_boxListScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxListScrollViewContent);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxListScrollViewContent);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC8, true);
		string name45 = "m_boxPriceIcon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxPriceIcon);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxPriceIcon);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCA, true);
		string name46 = "m_boxPriceIconEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxPriceIconEffectGameObject);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxPriceIconEffectGameObject);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCC, true);
		string name47 = "m_boxPriceText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxPriceText);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxPriceText);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCE, true);
		string name48 = "m_boxBuyPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxBuyPanelCloseButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxBuyPanelCloseButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD0, true);
		string name49 = "m_boxBuyButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_boxBuyButton);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_boxBuyButton);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD2, true);
		string name50 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD4, true);
		string name51 = "m_storeBoxItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeBoxItemPrefab);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeBoxItemPrefab);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD6, true);
		string name52 = "m_storeItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeItemPrefab);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeItemPrefab);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD8, true);
		string name53 = "m_storeHeroSkinItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeHeroSkinItemPrefab);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeHeroSkinItemPrefab);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDA, true);
		string name54 = "m_storeSoldierSkinItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeSoldierSkinItemPrefab);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeSoldierSkinItemPrefab);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDC, true);
		string name55 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_marginTransform);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDE, true);
		string name56 = "m_rechargeToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeToggle);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeToggle);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE0, true);
		string name57 = "m_presentToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_presentToggle);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_presentToggle);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE2, true);
		string name58 = "m_crystalToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_crystalToggle);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_crystalToggle);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE4, true);
		string name59 = "m_skinToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_skinToggle);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_skinToggle);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE6, true);
		string name60 = "m_mysteriousToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousToggle);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousToggle);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE8, true);
		string name61 = "m_selfChoosePanel";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_selfChoosePanel);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_selfChoosePanel);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEA, true);
		string name62 = "m_refreshTimeText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshTimeText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshTimeText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEC, true);
		string name63 = "m_refreshCurrencyTypeIcon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshCurrencyTypeIcon);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshCurrencyTypeIcon);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEE, true);
		string name64 = "m_refreshCurrencyTypeIconEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshCurrencyTypeIconEffectGameObject);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshCurrencyTypeIconEffectGameObject);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF0, true);
		string name65 = "m_refreshPriceText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshPriceText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshPriceText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF2, true);
		string name66 = "m_refreshButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshButton);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshButton);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF4, true);
		string name67 = "m_refreshTimesText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_refreshTimesText);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_refreshTimesText);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF6, true);
		string name68 = "m_soldierSkinToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_soldierSkinToggle);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_soldierSkinToggle);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF8, true);
		string name69 = "m_heroSkinToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_heroSkinToggle);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_heroSkinToggle);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFA, true);
		string name70 = "m_mysteriousBlackMarketToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousBlackMarketToggle);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousBlackMarketToggle);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFC, true);
		string name71 = "m_mysteriousHonorToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousHonorToggle);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousHonorToggle);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFE, true);
		string name72 = "m_mysteriousMedalToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousMedalToggle);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousMedalToggle);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache100, true);
		string name73 = "m_mysteriousFriendshipToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousFriendshipToggle);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousFriendshipToggle);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache102, true);
		string name74 = "m_mysteriousUnionToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousUnionToggle);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousUnionToggle);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache104, true);
		string name75 = "m_presentPresentToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_presentPresentToggle);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache105;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_presentPresentToggle);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache106, true);
		string name76 = "m_presentPreogativeToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_presentPreogativeToggle);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache107;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_presentPreogativeToggle);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache108, true);
		string name77 = "m_skinHeroToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_skinHeroToggle);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache109;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_skinHeroToggle);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10A, true);
		string name78 = "m_skinSoldierToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_skinSoldierToggle);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_skinSoldierToggle);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10C, true);
		string name79 = "m_mysteriousMemoryToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousMemoryToggle);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousMemoryToggle);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10E, true);
		string name80 = "m_mysteriousEquipmentToggle";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_mysteriousEquipmentToggle);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_mysteriousEquipmentToggle);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache110, true);
		string name81 = "m_currency1Obj";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency1Obj);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency1Obj);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache112, true);
		string name82 = "m_currency1Icon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency1Icon);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency1Icon);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache114, true);
		string name83 = "m_currency1CountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency1CountText);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency1CountText);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache116, true);
		string name84 = "m_currency1AddButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency1AddButton);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency1AddButton);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache118, true);
		string name85 = "m_currency1DescriptionButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency1DescriptionButton);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency1DescriptionButton);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11A, true);
		string name86 = "m_currency2Obj";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency2Obj);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency2Obj);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11C, true);
		string name87 = "m_currency2Icon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency2Icon);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency2Icon);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11E, true);
		string name88 = "m_currency2CountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency2CountText);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency2CountText);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache120, true);
		string name89 = "m_currency2AddButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency2AddButton);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency2AddButton);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache122, true);
		string name90 = "m_currency2DescriptionButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency2DescriptionButton);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency2DescriptionButton);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache124, true);
		string name91 = "m_currency3Obj";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency3Obj);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency3Obj);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache126, true);
		string name92 = "m_currency3Icon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency3Icon);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency3Icon);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache128, true);
		string name93 = "m_currency3CountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency3CountText);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency3CountText);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12A, true);
		string name94 = "m_currency3AddButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency3AddButton);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency3AddButton);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12C, true);
		string name95 = "m_currency3DescriptionButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_currency3DescriptionButton);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_currency3DescriptionButton);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12E, true);
		string name96 = "m_rechargeNameText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeNameText);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeNameText);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache130, true);
		string name97 = "m_rechargeIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeIconImage);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeIconImage);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache132, true);
		string name98 = "m_rechargeHaveCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeHaveCountText);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache133;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeHaveCountText);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache134, true);
		string name99 = "m_rechargePriceText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargePriceText);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache135;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargePriceText);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache136, true);
		string name100 = "m_rechargeGetCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeGetCountText);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache137;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeGetCountText);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache138, true);
		string name101 = "m_rechargeGetExtraCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeGetExtraCountText);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache139;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeGetExtraCountText);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13A, true);
		string name102 = "m_rechargePanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargePanelCloseButton);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargePanelCloseButton);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13C, true);
		string name103 = "m_rechargePanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargePanelUIStateController);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargePanelUIStateController);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13E, true);
		string name104 = "m_rechargeBuyButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_rechargeBuyButton);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache13F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_rechargeBuyButton);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache140, true);
		string name105 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_closeButton);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache141;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache142, true);
		string name106 = "m_storePrivilegeBuyDetailPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeBuyDetailPanelStateCtrl);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache143;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeBuyDetailPanelStateCtrl);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache144, true);
		string name107 = "m_storePrivilegeBuyDetailPanelBGButon";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeBuyDetailPanelBGButon);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache145;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeBuyDetailPanelBGButon);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache146, true);
		string name108 = "m_storePrivilegeStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeStateCtrl);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache147;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeStateCtrl);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache148, true);
		string name109 = "m_StorePrivilegeItemName";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_StorePrivilegeItemName);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache149;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_StorePrivilegeItemName);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14A, true);
		string name110 = "m_StorePrivilegeItemIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_StorePrivilegeItemIconImage);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_StorePrivilegeItemIconImage);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14C, true);
		string name111 = "m_storePrivilegeItemCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeItemCountText);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeItemCountText);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14E, true);
		string name112 = "m_storePrivilegeItemDescText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeItemDescText);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache14F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeItemDescText);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache150, true);
		string name113 = "m_storePrivilegeItemLeftDayGameObject";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeItemLeftDayGameObject);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache151;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeItemLeftDayGameObject);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache152, true);
		string name114 = "m_storePrivilegeItemLeftDay";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeItemLeftDay);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache153;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeItemLeftDay);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache154, true);
		string name115 = "m_storePrivilegeItemBuyButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeItemBuyButton);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache155;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeItemBuyButton);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache156, true);
		string name116 = "m_storePrivilegeItemBuyPrice";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storePrivilegeItemBuyPrice);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache157;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storePrivilegeItemBuyPrice);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache158, true);
		string name117 = "m_storeMonthExtraRewardCount";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeMonthExtraRewardCount);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache159;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeMonthExtraRewardCount);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15A, true);
		string name118 = "m_subscribePrice";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_subscribePrice);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_subscribePrice);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15C, true);
		string name119 = "m_subscribePanelPrivateButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_subscribePanelPrivateButton);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_subscribePanelPrivateButton);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15E, true);
		string name120 = "m_subscribePanelCancelSubscribeButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_subscribePanelCancelSubscribeButton);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache15F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_subscribePanelCancelSubscribeButton);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache160, true);
		string name121 = "m_memoryEntranceButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryEntranceButton);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache161;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryEntranceButton);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache162, true);
		string name122 = "m_memoryEntranceButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryEntranceButtonStateCtrl);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache163;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryEntranceButtonStateCtrl);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache164, true);
		string name123 = "m_memoryEntranceButtonRedPoint";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryEntranceButtonRedPoint);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache165;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryEntranceButtonRedPoint);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache166, true);
		string name124 = "m_memoryExtractionPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelStateCtrl);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache167;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelStateCtrl);
		}
		LuaObject.addMember(l, name124, get124, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache168, true);
		string name125 = "m_memoryExtractionPanelScrollRect";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelScrollRect);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache169;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelScrollRect);
		}
		LuaObject.addMember(l, name125, get125, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16A, true);
		string name126 = "m_memoryExtractionPanelScrollContent";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelScrollContent);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelScrollContent);
		}
		LuaObject.addMember(l, name126, get126, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16C, true);
		string name127 = "m_memoryExtractionPanelHelpButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelHelpButton);
		}
		LuaCSFunction get127 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelHelpButton);
		}
		LuaObject.addMember(l, name127, get127, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16E, true);
		string name128 = "m_memoryExtractionPanelExtractionButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelExtractionButton);
		}
		LuaCSFunction get128 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache16F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelExtractionButton);
		}
		LuaObject.addMember(l, name128, get128, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache170, true);
		string name129 = "m_memoryExtractionPanelTotalValueText";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelTotalValueText);
		}
		LuaCSFunction get129 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache171;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelTotalValueText);
		}
		LuaObject.addMember(l, name129, get129, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache172, true);
		string name130 = "m_memoryExtractionPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelCloseButton);
		}
		LuaCSFunction get130 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache173;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelCloseButton);
		}
		LuaObject.addMember(l, name130, get130, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache174, true);
		string name131 = "m_memoryExtractionPanelBGReturnButton";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelBGReturnButton);
		}
		LuaCSFunction get131 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache175;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelBGReturnButton);
		}
		LuaObject.addMember(l, name131, get131, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache176, true);
		string name132 = "m_memoryExtractionPanelEmptyTip";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_memoryExtractionPanelEmptyTip);
		}
		LuaCSFunction get132 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache177;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_memoryExtractionPanelEmptyTip);
		}
		LuaObject.addMember(l, name132, get132, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache178, true);
		string name133 = "m_HeroFragmentItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_HeroFragmentItemPrefab);
		}
		LuaCSFunction get133 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache179;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_HeroFragmentItemPrefab);
		}
		LuaObject.addMember(l, name133, get133, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17A, true);
		string name134 = "m_needRefreshPanel";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_needRefreshPanel);
		}
		LuaCSFunction get134 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_needRefreshPanel);
		}
		LuaObject.addMember(l, name134, get134, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17C, true);
		string name135 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get135 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name135, get135, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17E, true);
		string name136 = "m_storeType";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeType);
		}
		LuaCSFunction get136 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache17F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeType);
		}
		LuaObject.addMember(l, name136, get136, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache180, true);
		string name137 = "m_storeId";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeId);
		}
		LuaCSFunction get137 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache181;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeId);
		}
		LuaObject.addMember(l, name137, get137, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache182, true);
		string name138 = "m_fixedStoreItemGoodsID";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_fixedStoreItemGoodsID);
		}
		LuaCSFunction get138 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache183;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_fixedStoreItemGoodsID);
		}
		LuaObject.addMember(l, name138, get138, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache184, true);
		string name139 = "m_goodsID";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_goodsID);
		}
		LuaCSFunction get139 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache185;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_goodsID);
		}
		LuaObject.addMember(l, name139, get139, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache186, true);
		string name140 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_index);
		}
		LuaCSFunction get140 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache187;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_index);
		}
		LuaObject.addMember(l, name140, get140, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache188, true);
		string name141 = "m_fixedStoreID";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_fixedStoreID);
		}
		LuaCSFunction get141 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache189;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_fixedStoreID);
		}
		LuaObject.addMember(l, name141, get141, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18A, true);
		string name142 = "m_randomStoreID";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_randomStoreID);
		}
		LuaCSFunction get142 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_randomStoreID);
		}
		LuaObject.addMember(l, name142, get142, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18C, true);
		string name143 = "m_isStaticBox";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_isStaticBox);
		}
		LuaCSFunction get143 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_isStaticBox);
		}
		LuaObject.addMember(l, name143, get143, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18E, true);
		string name144 = "m_selfChooseItemIndex";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_selfChooseItemIndex);
		}
		LuaCSFunction get144 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache18F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_selfChooseItemIndex);
		}
		LuaObject.addMember(l, name144, get144, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache190, true);
		string name145 = "m_scrollViewStoreContentOriginalLocalPos";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_scrollViewStoreContentOriginalLocalPos);
		}
		LuaCSFunction get145 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache191;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_scrollViewStoreContentOriginalLocalPos);
		}
		LuaObject.addMember(l, name145, get145, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache192, true);
		string name146 = "m_scrollViewHeroContentOriginalLocalPos";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_scrollViewHeroContentOriginalLocalPos);
		}
		LuaCSFunction get146 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache193;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_scrollViewHeroContentOriginalLocalPos);
		}
		LuaObject.addMember(l, name146, get146, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache194, true);
		string name147 = "m_giftStoreItem";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_giftStoreItem);
		}
		LuaCSFunction get147 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache195;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_giftStoreItem);
		}
		LuaObject.addMember(l, name147, get147, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache196, true);
		string name148 = "m_storeUnderItemPool";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeUnderItemPool);
		}
		LuaCSFunction get148 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache197;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeUnderItemPool);
		}
		LuaObject.addMember(l, name148, get148, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache198, true);
		string name149 = "m_storeHeroSkinItemPool";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeHeroSkinItemPool);
		}
		LuaCSFunction get149 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache199;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeHeroSkinItemPool);
		}
		LuaObject.addMember(l, name149, get149, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19A, true);
		string name150 = "m_storeSoldierSkinItemPool";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeSoldierSkinItemPool);
		}
		LuaCSFunction get150 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19B;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeSoldierSkinItemPool);
		}
		LuaObject.addMember(l, name150, get150, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19C, true);
		string name151 = "m_gainGoodsList";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_gainGoodsList);
		}
		LuaCSFunction get151 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19D;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_gainGoodsList);
		}
		LuaObject.addMember(l, name151, get151, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19E, true);
		string name152 = "m_storeSubType2ToggleDic";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeSubType2ToggleDic);
		}
		LuaCSFunction get152 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache19F;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeSubType2ToggleDic);
		}
		LuaObject.addMember(l, name152, get152, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A0, true);
		string name153 = "m_storeSelfChooseUIController";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_storeSelfChooseUIController);
		}
		LuaCSFunction get153 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A1;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_storeSelfChooseUIController);
		}
		LuaObject.addMember(l, name153, get153, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A2, true);
		string name154 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_playerContext);
		}
		LuaCSFunction get154 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A3;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name154, get154, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A4, true);
		string name155 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get155 = Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A5;
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name155, get155, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A6, true);
		string name156 = "CurStoreId";
		if (Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreListUIController.get_CurStoreId);
		}
		LuaObject.addMember(l, name156, Lua_BlackJack_ProjectL_UI_StoreListUIController.<>f__mg$cache1A7, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(StoreListUIController), typeof(UIControllerBase));
	}

	// Token: 0x040171F9 RID: 94713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040171FA RID: 94714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040171FB RID: 94715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040171FC RID: 94716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040171FD RID: 94717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040171FE RID: 94718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040171FF RID: 94719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017200 RID: 94720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017201 RID: 94721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017202 RID: 94722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017203 RID: 94723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017204 RID: 94724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017205 RID: 94725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017206 RID: 94726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017207 RID: 94727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017208 RID: 94728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017209 RID: 94729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401720A RID: 94730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401720B RID: 94731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401720C RID: 94732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401720D RID: 94733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401720E RID: 94734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401720F RID: 94735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017210 RID: 94736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017211 RID: 94737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017212 RID: 94738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017213 RID: 94739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017214 RID: 94740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017215 RID: 94741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017216 RID: 94742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017217 RID: 94743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017218 RID: 94744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017219 RID: 94745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401721A RID: 94746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401721B RID: 94747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401721C RID: 94748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401721D RID: 94749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401721E RID: 94750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401721F RID: 94751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017220 RID: 94752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017221 RID: 94753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017222 RID: 94754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017223 RID: 94755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017224 RID: 94756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017225 RID: 94757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017226 RID: 94758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017227 RID: 94759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017228 RID: 94760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017229 RID: 94761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401722A RID: 94762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401722B RID: 94763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401722C RID: 94764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401722D RID: 94765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401722E RID: 94766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401722F RID: 94767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017230 RID: 94768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017231 RID: 94769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017232 RID: 94770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017233 RID: 94771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017234 RID: 94772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017235 RID: 94773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017236 RID: 94774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017237 RID: 94775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017238 RID: 94776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017239 RID: 94777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401723A RID: 94778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401723B RID: 94779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401723C RID: 94780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401723D RID: 94781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401723E RID: 94782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401723F RID: 94783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017240 RID: 94784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017241 RID: 94785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017242 RID: 94786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017243 RID: 94787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017244 RID: 94788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017245 RID: 94789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017246 RID: 94790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017247 RID: 94791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017248 RID: 94792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017249 RID: 94793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401724A RID: 94794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401724B RID: 94795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401724C RID: 94796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401724D RID: 94797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401724E RID: 94798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401724F RID: 94799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017250 RID: 94800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017251 RID: 94801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017252 RID: 94802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04017253 RID: 94803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04017254 RID: 94804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04017255 RID: 94805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04017256 RID: 94806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04017257 RID: 94807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017258 RID: 94808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017259 RID: 94809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401725A RID: 94810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401725B RID: 94811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401725C RID: 94812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401725D RID: 94813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401725E RID: 94814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401725F RID: 94815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04017260 RID: 94816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04017261 RID: 94817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04017262 RID: 94818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04017263 RID: 94819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04017264 RID: 94820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04017265 RID: 94821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04017266 RID: 94822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04017267 RID: 94823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04017268 RID: 94824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04017269 RID: 94825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401726A RID: 94826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0401726B RID: 94827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0401726C RID: 94828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401726D RID: 94829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401726E RID: 94830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401726F RID: 94831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04017270 RID: 94832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04017271 RID: 94833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04017272 RID: 94834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04017273 RID: 94835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04017274 RID: 94836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04017275 RID: 94837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04017276 RID: 94838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04017277 RID: 94839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04017278 RID: 94840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04017279 RID: 94841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0401727A RID: 94842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0401727B RID: 94843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0401727C RID: 94844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0401727D RID: 94845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0401727E RID: 94846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0401727F RID: 94847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04017280 RID: 94848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04017281 RID: 94849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04017282 RID: 94850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04017283 RID: 94851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04017284 RID: 94852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04017285 RID: 94853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04017286 RID: 94854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04017287 RID: 94855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04017288 RID: 94856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04017289 RID: 94857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0401728A RID: 94858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0401728B RID: 94859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0401728C RID: 94860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0401728D RID: 94861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0401728E RID: 94862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0401728F RID: 94863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04017290 RID: 94864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04017291 RID: 94865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04017292 RID: 94866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04017293 RID: 94867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04017294 RID: 94868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04017295 RID: 94869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04017296 RID: 94870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04017297 RID: 94871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04017298 RID: 94872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04017299 RID: 94873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0401729A RID: 94874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0401729B RID: 94875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0401729C RID: 94876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0401729D RID: 94877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0401729E RID: 94878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0401729F RID: 94879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040172A0 RID: 94880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040172A1 RID: 94881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040172A2 RID: 94882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040172A3 RID: 94883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040172A4 RID: 94884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040172A5 RID: 94885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040172A6 RID: 94886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040172A7 RID: 94887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040172A8 RID: 94888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040172A9 RID: 94889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040172AA RID: 94890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040172AB RID: 94891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040172AC RID: 94892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040172AD RID: 94893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040172AE RID: 94894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040172AF RID: 94895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040172B0 RID: 94896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040172B1 RID: 94897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040172B2 RID: 94898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040172B3 RID: 94899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040172B4 RID: 94900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040172B5 RID: 94901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040172B6 RID: 94902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040172B7 RID: 94903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040172B8 RID: 94904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040172B9 RID: 94905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040172BA RID: 94906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040172BB RID: 94907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040172BC RID: 94908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040172BD RID: 94909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040172BE RID: 94910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040172BF RID: 94911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040172C0 RID: 94912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040172C1 RID: 94913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040172C2 RID: 94914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040172C3 RID: 94915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040172C4 RID: 94916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040172C5 RID: 94917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040172C6 RID: 94918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040172C7 RID: 94919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040172C8 RID: 94920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040172C9 RID: 94921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040172CA RID: 94922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040172CB RID: 94923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040172CC RID: 94924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040172CD RID: 94925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040172CE RID: 94926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040172CF RID: 94927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040172D0 RID: 94928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040172D1 RID: 94929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040172D2 RID: 94930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040172D3 RID: 94931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040172D4 RID: 94932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040172D5 RID: 94933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040172D6 RID: 94934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040172D7 RID: 94935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040172D8 RID: 94936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040172D9 RID: 94937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040172DA RID: 94938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040172DB RID: 94939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040172DC RID: 94940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040172DD RID: 94941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040172DE RID: 94942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040172DF RID: 94943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040172E0 RID: 94944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040172E1 RID: 94945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040172E2 RID: 94946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040172E3 RID: 94947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040172E4 RID: 94948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040172E5 RID: 94949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040172E6 RID: 94950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040172E7 RID: 94951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x040172E8 RID: 94952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x040172E9 RID: 94953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x040172EA RID: 94954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x040172EB RID: 94955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x040172EC RID: 94956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x040172ED RID: 94957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x040172EE RID: 94958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x040172EF RID: 94959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x040172F0 RID: 94960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x040172F1 RID: 94961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x040172F2 RID: 94962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x040172F3 RID: 94963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x040172F4 RID: 94964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x040172F5 RID: 94965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x040172F6 RID: 94966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x040172F7 RID: 94967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x040172F8 RID: 94968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x040172F9 RID: 94969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x040172FA RID: 94970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x040172FB RID: 94971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x040172FC RID: 94972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x040172FD RID: 94973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x040172FE RID: 94974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x040172FF RID: 94975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04017300 RID: 94976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04017301 RID: 94977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04017302 RID: 94978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04017303 RID: 94979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04017304 RID: 94980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04017305 RID: 94981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04017306 RID: 94982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04017307 RID: 94983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x04017308 RID: 94984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x04017309 RID: 94985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x0401730A RID: 94986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x0401730B RID: 94987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x0401730C RID: 94988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x0401730D RID: 94989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x0401730E RID: 94990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x0401730F RID: 94991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04017310 RID: 94992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04017311 RID: 94993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04017312 RID: 94994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04017313 RID: 94995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04017314 RID: 94996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04017315 RID: 94997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x04017316 RID: 94998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x04017317 RID: 94999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x04017318 RID: 95000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x04017319 RID: 95001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0401731A RID: 95002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x0401731B RID: 95003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x0401731C RID: 95004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x0401731D RID: 95005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x0401731E RID: 95006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x0401731F RID: 95007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04017320 RID: 95008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04017321 RID: 95009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04017322 RID: 95010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04017323 RID: 95011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04017324 RID: 95012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x04017325 RID: 95013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x04017326 RID: 95014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x04017327 RID: 95015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x04017328 RID: 95016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x04017329 RID: 95017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0401732A RID: 95018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x0401732B RID: 95019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x0401732C RID: 95020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x0401732D RID: 95021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x0401732E RID: 95022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x0401732F RID: 95023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x04017330 RID: 95024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x04017331 RID: 95025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04017332 RID: 95026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04017333 RID: 95027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04017334 RID: 95028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04017335 RID: 95029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x04017336 RID: 95030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x04017337 RID: 95031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x04017338 RID: 95032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x04017339 RID: 95033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x0401733A RID: 95034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x0401733B RID: 95035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x0401733C RID: 95036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0401733D RID: 95037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0401733E RID: 95038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0401733F RID: 95039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x04017340 RID: 95040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x04017341 RID: 95041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x04017342 RID: 95042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x04017343 RID: 95043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x04017344 RID: 95044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x04017345 RID: 95045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x04017346 RID: 95046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x04017347 RID: 95047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x04017348 RID: 95048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x04017349 RID: 95049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x0401734A RID: 95050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x0401734B RID: 95051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x0401734C RID: 95052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x0401734D RID: 95053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x0401734E RID: 95054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x0401734F RID: 95055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x04017350 RID: 95056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x04017351 RID: 95057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x04017352 RID: 95058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x04017353 RID: 95059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x04017354 RID: 95060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x04017355 RID: 95061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x04017356 RID: 95062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x04017357 RID: 95063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x04017358 RID: 95064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x04017359 RID: 95065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x0401735A RID: 95066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x0401735B RID: 95067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x0401735C RID: 95068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x0401735D RID: 95069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x0401735E RID: 95070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x0401735F RID: 95071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x04017360 RID: 95072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x04017361 RID: 95073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x04017362 RID: 95074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x04017363 RID: 95075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x04017364 RID: 95076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x04017365 RID: 95077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x04017366 RID: 95078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x04017367 RID: 95079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x04017368 RID: 95080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x04017369 RID: 95081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x0401736A RID: 95082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x0401736B RID: 95083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x0401736C RID: 95084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x0401736D RID: 95085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x0401736E RID: 95086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x0401736F RID: 95087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x04017370 RID: 95088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x04017371 RID: 95089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x04017372 RID: 95090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x04017373 RID: 95091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x04017374 RID: 95092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x04017375 RID: 95093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x04017376 RID: 95094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x04017377 RID: 95095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x04017378 RID: 95096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x04017379 RID: 95097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x0401737A RID: 95098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x0401737B RID: 95099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x0401737C RID: 95100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x0401737D RID: 95101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x0401737E RID: 95102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x0401737F RID: 95103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x04017380 RID: 95104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x04017381 RID: 95105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x04017382 RID: 95106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x04017383 RID: 95107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x04017384 RID: 95108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x04017385 RID: 95109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x04017386 RID: 95110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x04017387 RID: 95111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x04017388 RID: 95112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x04017389 RID: 95113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x0401738A RID: 95114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x0401738B RID: 95115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x0401738C RID: 95116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x0401738D RID: 95117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x0401738E RID: 95118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x0401738F RID: 95119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x04017390 RID: 95120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x04017391 RID: 95121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x04017392 RID: 95122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;

	// Token: 0x04017393 RID: 95123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19A;

	// Token: 0x04017394 RID: 95124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19B;

	// Token: 0x04017395 RID: 95125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19C;

	// Token: 0x04017396 RID: 95126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19D;

	// Token: 0x04017397 RID: 95127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19E;

	// Token: 0x04017398 RID: 95128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19F;

	// Token: 0x04017399 RID: 95129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A0;

	// Token: 0x0401739A RID: 95130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A1;

	// Token: 0x0401739B RID: 95131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A2;

	// Token: 0x0401739C RID: 95132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A3;

	// Token: 0x0401739D RID: 95133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A4;

	// Token: 0x0401739E RID: 95134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A5;

	// Token: 0x0401739F RID: 95135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A6;

	// Token: 0x040173A0 RID: 95136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A7;
}
