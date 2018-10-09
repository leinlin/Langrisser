using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200158C RID: 5516
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreUITask : LuaObject
{
	// Token: 0x06021567 RID: 136551 RVA: 0x00B41CF0 File Offset: 0x00B3FEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			StoreUITask o = new StoreUITask(name);
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

	// Token: 0x06021568 RID: 136552 RVA: 0x00B41D44 File Offset: 0x00B3FF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPDSDKPayCancel(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.OnPDSDKPayCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021569 RID: 136553 RVA: 0x00B41D90 File Offset: 0x00B3FF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPDSDKPayFailed(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.OnPDSDKPayFailed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602156A RID: 136554 RVA: 0x00B41DDC File Offset: 0x00B3FFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPDSDKPaySuccess(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.OnPDSDKPaySuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602156B RID: 136555 RVA: 0x00B41E28 File Offset: 0x00B40028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeUITask.OnNewIntent(intent);
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

	// Token: 0x0602156C RID: 136556 RVA: 0x00B41E8C File Offset: 0x00B4008C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 1, out fromIntent);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			int? itemId;
			LuaObject.checkNullable<int>(l, 3, out itemId);
			bool isNeedOpenMemoryExtractionPanel;
			LuaObject.checkType(l, 4, out isNeedOpenMemoryExtractionPanel);
			StoreUITask.StartUITask(fromIntent, storeId, itemId, isNeedOpenMemoryExtractionPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602156D RID: 136557 RVA: 0x00B41EFC File Offset: 0x00B400FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SpecialStartStoreUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 1, out uiIntent);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			StoreUITask.SpecialStartStoreUITask(uiIntent, storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602156E RID: 136558 RVA: 0x00B41F54 File Offset: 0x00B40154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask.StoreUIUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602156F RID: 136559 RVA: 0x00B41F94 File Offset: 0x00B40194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDKRequestBuyGoods_s(IntPtr l)
	{
		int result;
		try
		{
			string goodID;
			LuaObject.checkType(l, 1, out goodID);
			PDSDKGoodType goodType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 2, out goodType);
			int number;
			LuaObject.checkType(l, 3, out number);
			StoreUITask.PDSDKRequestBuyGoods(goodID, goodType, number);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021570 RID: 136560 RVA: 0x00B41FF8 File Offset: 0x00B401F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDKGetGoods_s(IntPtr l)
	{
		int result;
		try
		{
			List<PDSDKGood> o = StoreUITask.PDSDKGetGoods();
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

	// Token: 0x06021571 RID: 136561 RVA: 0x00B42040 File Offset: 0x00B40240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDKRequestGoods_s(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask.PDSDKRequestGoods();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021572 RID: 136562 RVA: 0x00B42080 File Offset: 0x00B40280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPDSDKReqGoodsAck_s(IntPtr l)
	{
		int result;
		try
		{
			bool isSuccess;
			LuaObject.checkType(l, 1, out isSuccess);
			StoreUITask.OnPDSDKReqGoodsAck(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021573 RID: 136563 RVA: 0x00B420CC File Offset: 0x00B402CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOrderReward_s(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask.CheckOrderReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021574 RID: 136564 RVA: 0x00B4210C File Offset: 0x00B4030C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendPullOrderRewardReq_s(IntPtr l)
	{
		int result;
		try
		{
			string orderId;
			LuaObject.checkType(l, 1, out orderId);
			Action successedCallback;
			LuaObject.checkDelegate<Action>(l, 2, out successedCallback);
			Action failedCallback;
			LuaObject.checkDelegate<Action>(l, 3, out failedCallback);
			StoreUITask.SendPullOrderRewardReq(orderId, successedCallback, failedCallback);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021575 RID: 136565 RVA: 0x00B42170 File Offset: 0x00B40370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProcessOrderRewards_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> rewardList;
			LuaObject.checkType<List<Goods>>(l, 1, out rewardList);
			Action successedCallback;
			LuaObject.checkDelegate<Action>(l, 2, out successedCallback);
			StoreUITask.ProcessOrderRewards(rewardList, successedCallback);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021576 RID: 136566 RVA: 0x00B421C8 File Offset: 0x00B403C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleOneGiftStoreBuyItems_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			Action successedCallback;
			LuaObject.checkDelegate<Action>(l, 3, out successedCallback);
			StoreUITask.HandleOneGiftStoreBuyItems(ref i, rewards, successedCallback);
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

	// Token: 0x06021577 RID: 136567 RVA: 0x00B42234 File Offset: 0x00B40434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StaticGetRewardGoodsUITask_OnStop_s(IntPtr l)
	{
		int result;
		try
		{
			Task task;
			LuaObject.checkType<Task>(l, 1, out task);
			StoreUITask.StaticGetRewardGoodsUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021578 RID: 136568 RVA: 0x00B42280 File Offset: 0x00B40480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StaticGetRewardGoodsUITask_OnClose_s(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask.StaticGetRewardGoodsUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021579 RID: 136569 RVA: 0x00B422C0 File Offset: 0x00B404C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0602157A RID: 136570 RVA: 0x00B42328 File Offset: 0x00B40528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0602157B RID: 136571 RVA: 0x00B42390 File Offset: 0x00B40590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			storeUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602157C RID: 136572 RVA: 0x00B423EC File Offset: 0x00B405EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602157D RID: 136573 RVA: 0x00B42440 File Offset: 0x00B40640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			bool b = storeUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0602157E RID: 136574 RVA: 0x00B4249C File Offset: 0x00B4069C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602157F RID: 136575 RVA: 0x00B424F0 File Offset: 0x00B406F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021580 RID: 136576 RVA: 0x00B42544 File Offset: 0x00B40744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021581 RID: 136577 RVA: 0x00B42598 File Offset: 0x00B40798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.StoreUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021582 RID: 136578 RVA: 0x00B425EC File Offset: 0x00B407EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnChangeStore(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeUITask.m_luaExportHelper.StoreUIController_OnChangeStore(storeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021583 RID: 136579 RVA: 0x00B42648 File Offset: 0x00B40848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnFixedStoreHeroSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreHeroSkinItemUIController itemCtrl;
			LuaObject.checkType<StoreHeroSkinItemUIController>(l, 2, out itemCtrl);
			storeUITask.m_luaExportHelper.StoreUIController_OnFixedStoreHeroSkinItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021584 RID: 136580 RVA: 0x00B426A4 File Offset: 0x00B408A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnFixedStoreSoldierSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreSoldierSkinItemUIController itemCtrl;
			LuaObject.checkType<StoreSoldierSkinItemUIController>(l, 2, out itemCtrl);
			storeUITask.m_luaExportHelper.StoreUIController_OnFixedStoreSoldierSkinItemClick(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021585 RID: 136581 RVA: 0x00B42700 File Offset: 0x00B40900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnFixedStoreItemBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId fixedStoreID;
			LuaObject.checkEnum<StoreId>(l, 2, out fixedStoreID);
			int fixedStoreItemGoodsID;
			LuaObject.checkType(l, 3, out fixedStoreItemGoodsID);
			int goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			int selfChooseItemIndex;
			LuaObject.checkType(l, 5, out selfChooseItemIndex);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 6, out gainGoodsList);
			storeUITask.m_luaExportHelper.StoreUIController_OnFixedStoreItemBuy(fixedStoreID, fixedStoreItemGoodsID, goodsId, selfChooseItemIndex, gainGoodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021586 RID: 136582 RVA: 0x00B42790 File Offset: 0x00B40990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnFixedStoreBoxBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId fixedStoreID;
			LuaObject.checkEnum<StoreId>(l, 2, out fixedStoreID);
			int fixedStoreItemGoodsID;
			LuaObject.checkType(l, 3, out fixedStoreItemGoodsID);
			int goodsID;
			LuaObject.checkType(l, 4, out goodsID);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 5, out gainGoodsList);
			storeUITask.m_luaExportHelper.StoreUIController_OnFixedStoreBoxBuy(fixedStoreID, fixedStoreItemGoodsID, goodsID, gainGoodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021587 RID: 136583 RVA: 0x00B42814 File Offset: 0x00B40A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnRandomStoreItemBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId randomStoreId;
			LuaObject.checkEnum<StoreId>(l, 2, out randomStoreId);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 4, out gainGoodsList);
			storeUITask.m_luaExportHelper.StoreUIController_OnRandomStoreItemBuy(randomStoreId, index, gainGoodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021588 RID: 136584 RVA: 0x00B4288C File Offset: 0x00B40A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnRandomStoreBoxBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId randomStoreId;
			LuaObject.checkEnum<StoreId>(l, 2, out randomStoreId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int goodsID;
			LuaObject.checkType(l, 4, out goodsID);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 5, out gainGoodsList);
			storeUITask.m_luaExportHelper.StoreUIController_OnRandomStoreBoxBuy(randomStoreId, index, goodsID, gainGoodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021589 RID: 136585 RVA: 0x00B42910 File Offset: 0x00B40B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_GetRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId randomStoreId;
			LuaObject.checkEnum<StoreId>(l, 2, out randomStoreId);
			storeUITask.m_luaExportHelper.StoreUIController_GetRandomStore(randomStoreId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602158A RID: 136586 RVA: 0x00B4296C File Offset: 0x00B40B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_RefreshRandomStore(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId randomStoreId;
			LuaObject.checkEnum<StoreId>(l, 2, out randomStoreId);
			storeUITask.m_luaExportHelper.StoreUIController_RefreshRandomStore(randomStoreId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602158B RID: 136587 RVA: 0x00B429C8 File Offset: 0x00B40BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OMemoryExtractionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			Action onSucced;
			LuaObject.checkDelegate<Action>(l, 2, out onSucced);
			storeUITask.m_luaExportHelper.StoreUIController_OMemoryExtractionButtonClick(onSucced);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602158C RID: 136588 RVA: 0x00B42A24 File Offset: 0x00B40C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreListUIController_OnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.StoreListUIController_OnSkinItemOutOfDate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602158D RID: 136589 RVA: 0x00B42A78 File Offset: 0x00B40C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnRechargeStoreBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			int itemGoodsId;
			LuaObject.checkType(l, 3, out itemGoodsId);
			int number;
			LuaObject.checkType(l, 4, out number);
			storeUITask.m_luaExportHelper.StoreUIController_OnRechargeStoreBuy(storeType, itemGoodsId, number);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602158E RID: 136590 RVA: 0x00B42AF0 File Offset: 0x00B40CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendStoreItemCancelBuyReq(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.SendStoreItemCancelBuyReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602158F RID: 136591 RVA: 0x00B42B44 File Offset: 0x00B40D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendCheckOnlineReq(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.SendCheckOnlineReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021590 RID: 136592 RVA: 0x00B42B98 File Offset: 0x00B40D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBuyingGoodsCache(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.ClearBuyingGoodsCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021591 RID: 136593 RVA: 0x00B42BEC File Offset: 0x00B40DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnGiftStoreBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			ConfigDataGiftStoreItemInfo giftStoreItem;
			LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 2, out giftStoreItem);
			bool isfristBuy;
			LuaObject.checkType(l, 3, out isfristBuy);
			int number;
			LuaObject.checkType(l, 4, out number);
			storeUITask.m_luaExportHelper.StoreUIController_OnGiftStoreBuy(giftStoreItem, isfristBuy, number);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021592 RID: 136594 RVA: 0x00B42C64 File Offset: 0x00B40E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendGiftStoreBuyStoreItemReq(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int number;
			LuaObject.checkType(l, 4, out number);
			PDSDKGoodType pdsdkGoodType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 5, out pdsdkGoodType);
			storeUITask.m_luaExportHelper.SendGiftStoreBuyStoreItemReq(storeType, goodsId, number, pdsdkGoodType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021593 RID: 136595 RVA: 0x00B42CE8 File Offset: 0x00B40EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendGiftStoreAppleSubscribeItemReq(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int number;
			LuaObject.checkType(l, 4, out number);
			PDSDKGoodType pdsdkGoodType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 5, out pdsdkGoodType);
			storeUITask.m_luaExportHelper.SendGiftStoreAppleSubscribeItemReq(storeType, goodsId, number, pdsdkGoodType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021594 RID: 136596 RVA: 0x00B42D6C File Offset: 0x00B40F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendRechargeStoreBuyStoreItemReq(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int number;
			LuaObject.checkType(l, 4, out number);
			PDSDKGoodType pdsdkGoodType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 5, out pdsdkGoodType);
			storeUITask.m_luaExportHelper.SendRechargeStoreBuyStoreItemReq(storeType, goodsId, number, pdsdkGoodType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021595 RID: 136597 RVA: 0x00B42DF0 File Offset: 0x00B40FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContex_OnGiftStoreBuyNtf(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			storeUITask.m_luaExportHelper.PlayerContex_OnGiftStoreBuyNtf(orderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021596 RID: 136598 RVA: 0x00B42E4C File Offset: 0x00B4104C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021597 RID: 136599 RVA: 0x00B42EA0 File Offset: 0x00B410A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.PlayerContext_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021598 RID: 136600 RVA: 0x00B42EF4 File Offset: 0x00B410F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleBoxOpenNetTask(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			Action<List<Goods>> successedCallback;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 5, out successedCallback);
			Action failedCallback;
			LuaObject.checkDelegate<Action>(l, 6, out failedCallback);
			storeUITask.m_luaExportHelper.HandleBoxOpenNetTask(type, id, count, successedCallback, failedCallback);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021599 RID: 136601 RVA: 0x00B42F84 File Offset: 0x00B41184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnRechargeNoughtSuccessNtf(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			storeUITask.m_luaExportHelper.PlayerContext_OnRechargeNoughtSuccessNtf(orderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602159A RID: 136602 RVA: 0x00B42FE0 File Offset: 0x00B411E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreListUIController_OpenAddGoldStore(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.StoreListUIController_OpenAddGoldStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602159B RID: 136603 RVA: 0x00B43034 File Offset: 0x00B41234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreListUIController_OpenAddCrystalStore(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.StoreListUIController_OpenAddCrystalStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602159C RID: 136604 RVA: 0x00B43088 File Offset: 0x00B41288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_CrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.StoreUIController_CrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602159D RID: 136605 RVA: 0x00B430DC File Offset: 0x00B412DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUIController_OnExtraCurrencyBuy(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			storeUITask.m_luaExportHelper.StoreUIController_OnExtraCurrencyBuy(goodsType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602159E RID: 136606 RVA: 0x00B43138 File Offset: 0x00B41338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewAndOpenRewardGoodsUI(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			List<Goods> rewardGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out rewardGoods);
			storeUITask.m_luaExportHelper.UpdateViewAndOpenRewardGoodsUI(rewardGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602159F RID: 136607 RVA: 0x00B43194 File Offset: 0x00B41394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060215A0 RID: 136608 RVA: 0x00B431FC File Offset: 0x00B413FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215A1 RID: 136609 RVA: 0x00B43250 File Offset: 0x00B41450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215A2 RID: 136610 RVA: 0x00B432A4 File Offset: 0x00B414A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060215A3 RID: 136611 RVA: 0x00B4330C File Offset: 0x00B4150C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060215A4 RID: 136612 RVA: 0x00B43374 File Offset: 0x00B41574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			storeUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215A5 RID: 136613 RVA: 0x00B433E0 File Offset: 0x00B415E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			bool b = storeUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060215A6 RID: 136614 RVA: 0x00B4343C File Offset: 0x00B4163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			List<string> o = storeUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060215A7 RID: 136615 RVA: 0x00B43498 File Offset: 0x00B41698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215A8 RID: 136616 RVA: 0x00B434EC File Offset: 0x00B416EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215A9 RID: 136617 RVA: 0x00B43540 File Offset: 0x00B41740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215AA RID: 136618 RVA: 0x00B43594 File Offset: 0x00B41794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215AB RID: 136619 RVA: 0x00B435E8 File Offset: 0x00B417E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215AC RID: 136620 RVA: 0x00B4363C File Offset: 0x00B4183C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			storeUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215AD RID: 136621 RVA: 0x00B43698 File Offset: 0x00B41898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			storeUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215AE RID: 136622 RVA: 0x00B436F4 File Offset: 0x00B418F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			storeUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215AF RID: 136623 RVA: 0x00B43750 File Offset: 0x00B41950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			storeUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215B0 RID: 136624 RVA: 0x00B437AC File Offset: 0x00B419AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			bool b = storeUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060215B1 RID: 136625 RVA: 0x00B43808 File Offset: 0x00B41A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			bool b = storeUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060215B2 RID: 136626 RVA: 0x00B43864 File Offset: 0x00B41A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			bool b = storeUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060215B3 RID: 136627 RVA: 0x00B438C0 File Offset: 0x00B41AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UITaskBase o = storeUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060215B4 RID: 136628 RVA: 0x00B4391C File Offset: 0x00B41B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215B5 RID: 136629 RVA: 0x00B43970 File Offset: 0x00B41B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			storeUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215B6 RID: 136630 RVA: 0x00B439C4 File Offset: 0x00B41BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onBuyGiftStoreGoodsEvent_s(IntPtr l)
	{
		int result;
		try
		{
			int obj;
			LuaObject.checkType(l, 1, out obj);
			StoreUITask.LuaExportHelper.__callDele_m_onBuyGiftStoreGoodsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215B7 RID: 136631 RVA: 0x00B43A10 File Offset: 0x00B41C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onBuyGiftStoreGoodsEvent_s(IntPtr l)
	{
		int result;
		try
		{
			int obj;
			LuaObject.checkType(l, 1, out obj);
			StoreUITask.LuaExportHelper.__clearDele_m_onBuyGiftStoreGoodsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215B8 RID: 136632 RVA: 0x00B43A5C File Offset: 0x00B41C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215B9 RID: 136633 RVA: 0x00B43AB4 File Offset: 0x00B41CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			storeUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215BA RID: 136634 RVA: 0x00B43B10 File Offset: 0x00B41D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215BB RID: 136635 RVA: 0x00B43B68 File Offset: 0x00B41D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			storeUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215BC RID: 136636 RVA: 0x00B43BC4 File Offset: 0x00B41DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeListUIController(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_storeListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215BD RID: 136637 RVA: 0x00B43C1C File Offset: 0x00B41E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeListUIController(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreListUIController storeListUIController;
			LuaObject.checkType<StoreListUIController>(l, 2, out storeListUIController);
			storeUITask.m_luaExportHelper.m_storeListUIController = storeListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215BE RID: 136638 RVA: 0x00B43C78 File Offset: 0x00B41E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSecond(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_nowSecond);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215BF RID: 136639 RVA: 0x00B43CD0 File Offset: 0x00B41ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSecond(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			int nowSecond;
			LuaObject.checkType(l, 2, out nowSecond);
			storeUITask.m_luaExportHelper.m_nowSecond = nowSecond;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C0 RID: 136640 RVA: 0x00B43D2C File Offset: 0x00B41F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C1 RID: 136641 RVA: 0x00B43D84 File Offset: 0x00B41F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			storeUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C2 RID: 136642 RVA: 0x00B43DE0 File Offset: 0x00B41FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configdataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_configdataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C3 RID: 136643 RVA: 0x00B43E38 File Offset: 0x00B42038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configdataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			ClientConfigDataLoader configdataLoader;
			LuaObject.checkType<ClientConfigDataLoader>(l, 2, out configdataLoader);
			storeUITask.m_luaExportHelper.m_configdataLoader = configdataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C4 RID: 136644 RVA: 0x00B43E94 File Offset: 0x00B42094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pdsdkGoods(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, StoreUITask.LuaExportHelper.m_pdsdkGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C5 RID: 136645 RVA: 0x00B43EDC File Offset: 0x00B420DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pdsdkGoods(IntPtr l)
	{
		int result;
		try
		{
			List<PDSDKGood> pdsdkGoods;
			LuaObject.checkType<List<PDSDKGood>>(l, 2, out pdsdkGoods);
			StoreUITask.LuaExportHelper.m_pdsdkGoods = pdsdkGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C6 RID: 136646 RVA: 0x00B43F28 File Offset: 0x00B42128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBuyingGoodsId(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.m_curBuyingGoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C7 RID: 136647 RVA: 0x00B43F80 File Offset: 0x00B42180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBuyingGoodsId(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			string curBuyingGoodsId;
			LuaObject.checkType(l, 2, out curBuyingGoodsId);
			storeUITask.m_luaExportHelper.m_curBuyingGoodsId = curBuyingGoodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C8 RID: 136648 RVA: 0x00B43FDC File Offset: 0x00B421DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_StoreInfoId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "StoreInfoID");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215C9 RID: 136649 RVA: 0x00B44024 File Offset: 0x00B42224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_StoreItemId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "StoreItemId");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215CA RID: 136650 RVA: 0x00B4406C File Offset: 0x00B4226C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_IsShowExtractionPanel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "IsShowExtractionPanel");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215CB RID: 136651 RVA: 0x00B440B4 File Offset: 0x00B422B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeId(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeUITask.m_luaExportHelper.m_storeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215CC RID: 136652 RVA: 0x00B4410C File Offset: 0x00B4230C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeId(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			storeUITask.m_luaExportHelper.m_storeId = storeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215CD RID: 136653 RVA: 0x00B44168 File Offset: 0x00B42368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onBuyGiftStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					StoreUITask.m_onBuyGiftStoreGoodsEvent += value;
				}
				else if (num == 2)
				{
					StoreUITask.m_onBuyGiftStoreGoodsEvent -= value;
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

	// Token: 0x060215CE RID: 136654 RVA: 0x00B441D8 File Offset: 0x00B423D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_orderGetRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, StoreUITask.m_orderGetRewardGoodsUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215CF RID: 136655 RVA: 0x00B44220 File Offset: 0x00B42420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_orderGetRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask orderGetRewardGoodsUITask;
			LuaObject.checkType<GetRewardGoodsUITask>(l, 2, out orderGetRewardGoodsUITask);
			StoreUITask.m_orderGetRewardGoodsUITask = orderGetRewardGoodsUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D0 RID: 136656 RVA: 0x00B4426C File Offset: 0x00B4246C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_orderGetRewardUICloseCallback(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				StoreUITask.m_orderGetRewardUICloseCallback = action;
			}
			else if (num == 1)
			{
				StoreUITask.m_orderGetRewardUICloseCallback = (Action)Delegate.Combine(StoreUITask.m_orderGetRewardUICloseCallback, action);
			}
			else if (num == 2)
			{
				StoreUITask.m_orderGetRewardUICloseCallback = (Action)Delegate.Remove(StoreUITask.m_orderGetRewardUICloseCallback, action);
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

	// Token: 0x060215D1 RID: 136657 RVA: 0x00B44300 File Offset: 0x00B42500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D2 RID: 136658 RVA: 0x00B44358 File Offset: 0x00B42558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreUITask storeUITask = (StoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D3 RID: 136659 RVA: 0x00B443B0 File Offset: 0x00B425B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreUITask");
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnPDSDKPayCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnPDSDKPayFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnPDSDKPaySuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SpecialStartStoreUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PDSDKRequestBuyGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PDSDKGetGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PDSDKRequestGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnPDSDKReqGoodsAck_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.CheckOrderReward_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SendPullOrderRewardReq_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.ProcessOrderRewards_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.HandleOneGiftStoreBuyItems_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StaticGetRewardGoodsUITask_OnStop_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StaticGetRewardGoodsUITask_OnClose_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnChangeStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnFixedStoreHeroSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnFixedStoreSoldierSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnFixedStoreItemBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnFixedStoreBoxBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnRandomStoreItemBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnRandomStoreBoxBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_GetRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_RefreshRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OMemoryExtractionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreListUIController_OnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnRechargeStoreBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SendStoreItemCancelBuyReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SendCheckOnlineReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.ClearBuyingGoodsCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnGiftStoreBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SendGiftStoreBuyStoreItemReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SendGiftStoreAppleSubscribeItemReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.SendRechargeStoreBuyStoreItemReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PlayerContex_OnGiftStoreBuyNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PlayerContext_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.HandleBoxOpenNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.PlayerContext_OnRechargeNoughtSuccessNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreListUIController_OpenAddGoldStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreListUIController_OpenAddCrystalStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_CrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.StoreUIController_OnExtraCurrencyBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.UpdateViewAndOpenRewardGoodsUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__callDele_m_onBuyGiftStoreGoodsEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.__clearDele_m_onBuyGiftStoreGoodsEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache4F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache51, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache53, true);
		string name3 = "m_storeListUIController";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_storeListUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_storeListUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache55, true);
		string name4 = "m_nowSecond";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_nowSecond);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_nowSecond);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache57, true);
		string name5 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_playerContext);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache59, true);
		string name6 = "m_configdataLoader";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_configdataLoader);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_configdataLoader);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5B, true);
		string name7 = "m_pdsdkGoods";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_pdsdkGoods);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_pdsdkGoods);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5D, false);
		string name8 = "m_curBuyingGoodsId";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_curBuyingGoodsId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_curBuyingGoodsId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache5F, true);
		string name9 = "ParamsKey_StoreInfoId";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_ParamsKey_StoreInfoId);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache60, null, false);
		string name10 = "ParamsKey_StoreItemId";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_ParamsKey_StoreItemId);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache61, null, false);
		string name11 = "ParamsKey_IsShowExtractionPanel";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_ParamsKey_IsShowExtractionPanel);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache62, null, false);
		string name12 = "m_storeId";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_storeId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_storeId);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache64, true);
		string name13 = "m_onBuyGiftStoreGoodsEvent";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_onBuyGiftStoreGoodsEvent);
		}
		LuaObject.addMember(l, name13, get10, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache65, false);
		string name14 = "m_orderGetRewardGoodsUITask";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_m_orderGetRewardGoodsUITask);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_orderGetRewardGoodsUITask);
		}
		LuaObject.addMember(l, name14, get11, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache67, false);
		string name15 = "m_orderGetRewardUICloseCallback";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.set_m_orderGetRewardUICloseCallback);
		}
		LuaObject.addMember(l, name15, get12, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache68, false);
		string name16 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache69, null, true);
		string name17 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6A, null, true);
		if (Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_StoreUITask.<>f__mg$cache6B, typeof(StoreUITask), typeof(UITask));
	}

	// Token: 0x04017431 RID: 95281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017432 RID: 95282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017433 RID: 95283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017434 RID: 95284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017435 RID: 95285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017436 RID: 95286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017437 RID: 95287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017438 RID: 95288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017439 RID: 95289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401743A RID: 95290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401743B RID: 95291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401743C RID: 95292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401743D RID: 95293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401743E RID: 95294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401743F RID: 95295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017440 RID: 95296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017441 RID: 95297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017442 RID: 95298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017443 RID: 95299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017444 RID: 95300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017445 RID: 95301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017446 RID: 95302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017447 RID: 95303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017448 RID: 95304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017449 RID: 95305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401744A RID: 95306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401744B RID: 95307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401744C RID: 95308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401744D RID: 95309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401744E RID: 95310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401744F RID: 95311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017450 RID: 95312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017451 RID: 95313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017452 RID: 95314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017453 RID: 95315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017454 RID: 95316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017455 RID: 95317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017456 RID: 95318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017457 RID: 95319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017458 RID: 95320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017459 RID: 95321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401745A RID: 95322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401745B RID: 95323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401745C RID: 95324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401745D RID: 95325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401745E RID: 95326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401745F RID: 95327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017460 RID: 95328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017461 RID: 95329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017462 RID: 95330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017463 RID: 95331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017464 RID: 95332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017465 RID: 95333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017466 RID: 95334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017467 RID: 95335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017468 RID: 95336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017469 RID: 95337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401746A RID: 95338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401746B RID: 95339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401746C RID: 95340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401746D RID: 95341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401746E RID: 95342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401746F RID: 95343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017470 RID: 95344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017471 RID: 95345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017472 RID: 95346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017473 RID: 95347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017474 RID: 95348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017475 RID: 95349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017476 RID: 95350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017477 RID: 95351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017478 RID: 95352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017479 RID: 95353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401747A RID: 95354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401747B RID: 95355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401747C RID: 95356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401747D RID: 95357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401747E RID: 95358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401747F RID: 95359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017480 RID: 95360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017481 RID: 95361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017482 RID: 95362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017483 RID: 95363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017484 RID: 95364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017485 RID: 95365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017486 RID: 95366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017487 RID: 95367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017488 RID: 95368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017489 RID: 95369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401748A RID: 95370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401748B RID: 95371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401748C RID: 95372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401748D RID: 95373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401748E RID: 95374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401748F RID: 95375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017490 RID: 95376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017491 RID: 95377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04017492 RID: 95378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04017493 RID: 95379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04017494 RID: 95380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04017495 RID: 95381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04017496 RID: 95382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04017497 RID: 95383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04017498 RID: 95384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04017499 RID: 95385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401749A RID: 95386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401749B RID: 95387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401749C RID: 95388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;
}
