using System;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using PD.SDK;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F19 RID: 3865
	internal class IosPromotingPay
	{
		// Token: 0x060132BD RID: 78525 RVA: 0x004E2968 File Offset: 0x004E0B68
		public static void SendIosPromotingReq(PDSDKGood goods)
		{
			StoreType storeTypeId = (StoreType)RMBStoreoreGoodsIdTools.GetStoreTypeId(goods.m_ID);
			if (storeTypeId == StoreType.StoreType_Gift)
			{
				if (goods.m_type == PDSDKGoodType.IosSubscribe)
				{
					IosPromotingPay.SendIosPromotingAppleSubscribeReq(goods);
				}
				else
				{
					IosPromotingPay.SendIosPromotingGiftReq(goods);
				}
			}
			else if (storeTypeId == StoreType.StoreType_Recharge)
			{
				IosPromotingPay.SendIosPromotingItemReq(goods);
			}
		}

		// Token: 0x060132BE RID: 78526 RVA: 0x004E29BC File Offset: 0x004E0BBC
		private static void SendIosPromotingItemReq(PDSDKGood goods)
		{
			int realGoodsId = RMBStoreoreGoodsIdTools.GetRealGoodsId(goods.m_ID);
			RechargeStoreBuyStoreItemNetTask rechargeStoreBuyStoreItemNetTask = new RechargeStoreBuyStoreItemNetTask(realGoodsId);
			rechargeStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
			{
				int result = (task as RechargeStoreBuyStoreItemNetTask).Result;
				if (result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
				else
				{
					PDSDK.Instance.DoPromotingPay(goods.m_name, 1, goods.m_ID, goods.m_registerID, goods.m_price, string.Empty, goods.m_desc);
				}
			};
			rechargeStoreBuyStoreItemNetTask.Start(null);
		}

		// Token: 0x060132BF RID: 78527 RVA: 0x004E2A08 File Offset: 0x004E0C08
		private static void SendIosPromotingGiftReq(PDSDKGood goods)
		{
			int realGoodsId = RMBStoreoreGoodsIdTools.GetRealGoodsId(goods.m_ID);
			GiftStoreBuyStoreItemNetTask giftStoreBuyStoreItemNetTask = new GiftStoreBuyStoreItemNetTask(realGoodsId);
			giftStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
			{
				int result = (task as GiftStoreBuyStoreItemNetTask).Result;
				if (result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
				else
				{
					PDSDK.Instance.DoPromotingPay(goods.m_name, 1, goods.m_ID, goods.m_registerID, goods.m_price, string.Empty, goods.m_desc);
				}
			};
			giftStoreBuyStoreItemNetTask.Start(null);
		}

		// Token: 0x060132C0 RID: 78528 RVA: 0x004E2A54 File Offset: 0x004E0C54
		private static void SendIosPromotingAppleSubscribeReq(PDSDKGood goods)
		{
			int realGoodsId = RMBStoreoreGoodsIdTools.GetRealGoodsId(goods.m_ID);
			GiftStoreAppleSubscribeNetTask giftStoreAppleSubscribeNetTask = new GiftStoreAppleSubscribeNetTask(realGoodsId);
			giftStoreAppleSubscribeNetTask.EventOnStop += delegate(Task task)
			{
				int result = (task as GiftStoreAppleSubscribeNetTask).Result;
				if (result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
				else
				{
					PDSDK.Instance.DoPromotingPay(goods.m_name, 1, goods.m_ID, goods.m_registerID, goods.m_price, string.Empty, goods.m_desc);
				}
			};
			giftStoreAppleSubscribeNetTask.Start(null);
		}
	}
}
