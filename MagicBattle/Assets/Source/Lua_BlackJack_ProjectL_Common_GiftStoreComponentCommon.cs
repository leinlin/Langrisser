using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001222 RID: 4642
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon : LuaObject
{
	// Token: 0x0601813D RID: 98621 RVA: 0x006AF9B8 File Offset: 0x006ADBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon o = new GiftStoreComponentCommon();
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

	// Token: 0x0601813E RID: 98622 RVA: 0x006AFA00 File Offset: 0x006ADC00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			string name = giftStoreComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601813F RID: 98623 RVA: 0x006AFA54 File Offset: 0x006ADC54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			giftStoreComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018140 RID: 98624 RVA: 0x006AFAA0 File Offset: 0x006ADCA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			giftStoreComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018141 RID: 98625 RVA: 0x006AFAEC File Offset: 0x006ADCEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			giftStoreComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018142 RID: 98626 RVA: 0x006AFB38 File Offset: 0x006ADD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			giftStoreComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018143 RID: 98627 RVA: 0x006AFB90 File Offset: 0x006ADD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			giftStoreComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018144 RID: 98628 RVA: 0x006AFBDC File Offset: 0x006ADDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOfferedStoreItems(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			List<GiftStoreItem> offeredStoreItems = giftStoreComponentCommon.GetOfferedStoreItems();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offeredStoreItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018145 RID: 98629 RVA: 0x006AFC30 File Offset: 0x006ADE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasBought(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = giftStoreComponentCommon.HasBought(goodsId);
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

	// Token: 0x06018146 RID: 98630 RVA: 0x006AFC94 File Offset: 0x006ADE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBuyGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int i = giftStoreComponentCommon.CanBuyGoods(goodsId);
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

	// Token: 0x06018147 RID: 98631 RVA: 0x006AFCF8 File Offset: 0x006ADEF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAppleSubscribeGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int i = giftStoreComponentCommon.CanAppleSubscribeGoods(goodsId);
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

	// Token: 0x06018148 RID: 98632 RVA: 0x006AFD5C File Offset: 0x006ADF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFirstBuyGoodsRecord(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsRegisterId;
			LuaObject.checkType(l, 3, out goodsRegisterId);
			giftStoreComponentCommon.AddFirstBuyGoodsRecord(goodsId, goodsRegisterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018149 RID: 98633 RVA: 0x006AFDC0 File Offset: 0x006ADFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllOrderRewards(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			List<OrderReward> allOrderRewards = giftStoreComponentCommon.GetAllOrderRewards();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allOrderRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601814A RID: 98634 RVA: 0x006AFE14 File Offset: 0x006AE014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveOrderReward(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			giftStoreComponentCommon.RemoveOrderReward(orderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601814B RID: 98635 RVA: 0x006AFE6C File Offset: 0x006AE06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddOrderReward(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			OrderReward reward;
			LuaObject.checkType<OrderReward>(l, 3, out reward);
			giftStoreComponentCommon.AddOrderReward(orderId, reward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601814C RID: 98636 RVA: 0x006AFED0 File Offset: 0x006AE0D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOrderReward(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			OrderReward o = giftStoreComponentCommon.FindOrderReward(orderId);
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

	// Token: 0x0601814D RID: 98637 RVA: 0x006AFF34 File Offset: 0x006AE134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushBoughtNums(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			giftStoreComponentCommon.m_luaExportHelper.OnFlushBoughtNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601814E RID: 98638 RVA: 0x006AFF88 File Offset: 0x006AE188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOfferedStoreItemsByConfig(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			List<GiftStoreItem> offeredStoreItemsByConfig = giftStoreComponentCommon.m_luaExportHelper.GetOfferedStoreItemsByConfig();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offeredStoreItemsByConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601814F RID: 98639 RVA: 0x006AFFE4 File Offset: 0x006AE1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOnSaleTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			DateTime saleStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out saleStartTime);
			DateTime saleEndTime;
			LuaObject.checkValueType<DateTime>(l, 3, out saleEndTime);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 4, out currentTime);
			bool b = giftStoreComponentCommon.m_luaExportHelper.IsOnSaleTime(saleStartTime, saleEndTime, currentTime);
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

	// Token: 0x06018150 RID: 98640 RVA: 0x006B0068 File Offset: 0x006AE268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBuyGiftStoreGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataGiftStoreItemInfo goodsInfo;
			LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 2, out goodsInfo);
			giftStoreComponentCommon.m_luaExportHelper.OnBuyGiftStoreGoods(goodsInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018151 RID: 98641 RVA: 0x006B00C4 File Offset: 0x006AE2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_BuyGiftStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			giftStoreComponentCommon.m_luaExportHelper.__callDele_BuyGiftStoreGoodsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018152 RID: 98642 RVA: 0x006B0120 File Offset: 0x006AE320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_BuyGiftStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			giftStoreComponentCommon.m_luaExportHelper.__clearDele_BuyGiftStoreGoodsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018153 RID: 98643 RVA: 0x006B017C File Offset: 0x006AE37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			giftStoreComponentCommon.m_luaExportHelper.__callDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018154 RID: 98644 RVA: 0x006B01E8 File Offset: 0x006AE3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			giftStoreComponentCommon.m_luaExportHelper.__clearDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018155 RID: 98645 RVA: 0x006B0254 File Offset: 0x006AE454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018156 RID: 98646 RVA: 0x006B02AC File Offset: 0x006AE4AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			giftStoreComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018157 RID: 98647 RVA: 0x006B0308 File Offset: 0x006AE508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_giftStoreDS(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreComponentCommon.m_luaExportHelper.m_giftStoreDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018158 RID: 98648 RVA: 0x006B0360 File Offset: 0x006AE560
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_giftStoreDS(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			DataSectionGiftStore giftStoreDS;
			LuaObject.checkType<DataSectionGiftStore>(l, 2, out giftStoreDS);
			giftStoreComponentCommon.m_luaExportHelper.m_giftStoreDS = giftStoreDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018159 RID: 98649 RVA: 0x006B03BC File Offset: 0x006AE5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601815A RID: 98650 RVA: 0x006B0414 File Offset: 0x006AE614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			giftStoreComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601815B RID: 98651 RVA: 0x006B0470 File Offset: 0x006AE670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601815C RID: 98652 RVA: 0x006B04C8 File Offset: 0x006AE6C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			giftStoreComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601815D RID: 98653 RVA: 0x006B0524 File Offset: 0x006AE724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601815E RID: 98654 RVA: 0x006B057C File Offset: 0x006AE77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			giftStoreComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601815F RID: 98655 RVA: 0x006B05D8 File Offset: 0x006AE7D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuyGiftStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					giftStoreComponentCommon.BuyGiftStoreGoodsEvent += value;
				}
				else if (num == 2)
				{
					giftStoreComponentCommon.BuyGiftStoreGoodsEvent -= value;
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

	// Token: 0x06018160 RID: 98656 RVA: 0x006B0658 File Offset: 0x006AE858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					giftStoreComponentCommon.BuyStoreItemEvent += value;
				}
				else if (num == 2)
				{
					giftStoreComponentCommon.BuyStoreItemEvent -= value;
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

	// Token: 0x06018161 RID: 98657 RVA: 0x006B06D8 File Offset: 0x006AE8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018162 RID: 98658 RVA: 0x006B072C File Offset: 0x006AE92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponentCommon giftStoreComponentCommon = (GiftStoreComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			giftStoreComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018163 RID: 98659 RVA: 0x006B0784 File Offset: 0x006AE984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GiftStoreComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.GetOfferedStoreItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.HasBought);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.CanBuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.CanAppleSubscribeGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.AddFirstBuyGoodsRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.GetAllOrderRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.RemoveOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.AddOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.FindOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.OnFlushBoughtNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.GetOfferedStoreItemsByConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.IsOnSaleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.OnBuyGiftStoreGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.__callDele_BuyGiftStoreGoodsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.__clearDele_BuyGiftStoreGoodsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.__callDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.__clearDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache16);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache18, true);
		string name2 = "m_giftStoreDS";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.get_m_giftStoreDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_m_giftStoreDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1A, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1C, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1E, true);
		string name5 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.get_m_resource);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache20, true);
		string name6 = "BuyGiftStoreGoodsEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_BuyGiftStoreGoodsEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache21, true);
		string name7 = "BuyStoreItemEvent";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache22, true);
		string name8 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.get_Owner);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache24, true);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.<>f__mg$cache25, typeof(GiftStoreComponentCommon));
	}

	// Token: 0x0400E6DB RID: 59099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E6DC RID: 59100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E6DD RID: 59101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E6DE RID: 59102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E6DF RID: 59103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E6E0 RID: 59104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E6E1 RID: 59105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E6E2 RID: 59106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E6E3 RID: 59107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E6E4 RID: 59108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E6E5 RID: 59109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E6E6 RID: 59110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E6E7 RID: 59111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E6E8 RID: 59112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E6E9 RID: 59113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E6EA RID: 59114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E6EB RID: 59115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E6EC RID: 59116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E6ED RID: 59117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E6EE RID: 59118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E6EF RID: 59119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E6F0 RID: 59120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E6F1 RID: 59121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E6F2 RID: 59122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E6F3 RID: 59123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E6F4 RID: 59124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E6F5 RID: 59125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E6F6 RID: 59126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E6F7 RID: 59127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E6F8 RID: 59128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E6F9 RID: 59129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E6FA RID: 59130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E6FB RID: 59131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E6FC RID: 59132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E6FD RID: 59133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E6FE RID: 59134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E6FF RID: 59135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E700 RID: 59136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
