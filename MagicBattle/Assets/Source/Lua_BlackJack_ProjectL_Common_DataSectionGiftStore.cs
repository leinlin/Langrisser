using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011FE RID: 4606
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionGiftStore : LuaObject
{
	// Token: 0x06017E21 RID: 97825 RVA: 0x006990F8 File Offset: 0x006972F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore o = new DataSectionGiftStore();
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

	// Token: 0x06017E22 RID: 97826 RVA: 0x00699140 File Offset: 0x00697340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			dataSectionGiftStore.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E23 RID: 97827 RVA: 0x0069918C File Offset: 0x0069738C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			object o = dataSectionGiftStore.SerializeToClient();
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

	// Token: 0x06017E24 RID: 97828 RVA: 0x006991E0 File Offset: 0x006973E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindLocalBoughtItemById(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			GiftStoreItem o = dataSectionGiftStore.FindLocalBoughtItemById(goodsId);
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

	// Token: 0x06017E25 RID: 97829 RVA: 0x00699244 File Offset: 0x00697444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBoughtItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			GiftStoreItem item;
			LuaObject.checkType<GiftStoreItem>(l, 2, out item);
			dataSectionGiftStore.AddBoughtItem(item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E26 RID: 97830 RVA: 0x0069929C File Offset: 0x0069749C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddFirstBuyGoodsRecord(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsRegisterId;
			LuaObject.checkType(l, 3, out goodsRegisterId);
			dataSectionGiftStore.AddFirstBuyGoodsRecord(goodsId, goodsRegisterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E27 RID: 97831 RVA: 0x00699300 File Offset: 0x00697500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasBought(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = dataSectionGiftStore.HasBought(goodsId);
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

	// Token: 0x06017E28 RID: 97832 RVA: 0x00699364 File Offset: 0x00697564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFirstBoughtItemRegisterId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string firstBoughtItemRegisterId = dataSectionGiftStore.GetFirstBoughtItemRegisterId(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, firstBoughtItemRegisterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E29 RID: 97833 RVA: 0x006993C8 File Offset: 0x006975C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBoughtItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			GiftStoreItem storeItem;
			LuaObject.checkType<GiftStoreItem>(l, 2, out storeItem);
			dataSectionGiftStore.InitBoughtItem(storeItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E2A RID: 97834 RVA: 0x00699420 File Offset: 0x00697620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBoughtItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			List<GiftStoreItem> boughtItems;
			LuaObject.checkType<List<GiftStoreItem>>(l, 2, out boughtItems);
			dataSectionGiftStore.SetBoughtItems(boughtItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E2B RID: 97835 RVA: 0x00699478 File Offset: 0x00697678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFirstBuyGoodsRecord(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string registerId;
			LuaObject.checkType(l, 3, out registerId);
			dataSectionGiftStore.InitFirstBuyGoodsRecord(goodsId, registerId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E2C RID: 97836 RVA: 0x006994DC File Offset: 0x006976DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLocalBoughtItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			List<GiftStoreItem> localBoughtItems = dataSectionGiftStore.GetLocalBoughtItems();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBoughtItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E2D RID: 97837 RVA: 0x00699530 File Offset: 0x00697730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFirstBoughtRecords(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			Dictionary<int, string> firstBoughtRecords = dataSectionGiftStore.GetFirstBoughtRecords();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, firstBoughtRecords);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E2E RID: 97838 RVA: 0x00699584 File Offset: 0x00697784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGoodsOnBanBuyingPeriod(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			bool b = dataSectionGiftStore.IsGoodsOnBanBuyingPeriod(goodsId, currentTime);
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

	// Token: 0x06017E2F RID: 97839 RVA: 0x006995F4 File Offset: 0x006977F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBanBuyingGoodsTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			DateTime expiredTime;
			LuaObject.checkValueType<DateTime>(l, 3, out expiredTime);
			dataSectionGiftStore.SetBanBuyingGoodsTime(goodsId, expiredTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E30 RID: 97840 RVA: 0x00699658 File Offset: 0x00697858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitmBanBuyingGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			Dictionary<int, DateTime> goodsList;
			LuaObject.checkType<Dictionary<int, DateTime>>(l, 2, out goodsList);
			dataSectionGiftStore.InitmBanBuyingGoodsList(goodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E31 RID: 97841 RVA: 0x006996B0 File Offset: 0x006978B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindGiftStoreOperationalGoods(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			GiftStoreOperationalGoods o = dataSectionGiftStore.FindGiftStoreOperationalGoods(goodsId);
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

	// Token: 0x06017E32 RID: 97842 RVA: 0x00699714 File Offset: 0x00697914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGiftStoreOperationalGoods(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			dataSectionGiftStore.ClearGiftStoreOperationalGoods();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E33 RID: 97843 RVA: 0x00699760 File Offset: 0x00697960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitOperationalGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			GiftStoreOperationalGoods goods;
			LuaObject.checkType<GiftStoreOperationalGoods>(l, 2, out goods);
			dataSectionGiftStore.InitOperationalGoodsList(goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E34 RID: 97844 RVA: 0x006997B8 File Offset: 0x006979B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOperationalGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			List<GiftStoreOperationalGoods> operationalGoodsList = dataSectionGiftStore.GetOperationalGoodsList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E35 RID: 97845 RVA: 0x0069980C File Offset: 0x00697A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitOrderReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			OrderReward orderReward;
			LuaObject.checkType<OrderReward>(l, 2, out orderReward);
			dataSectionGiftStore.InitOrderReward(orderReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E36 RID: 97846 RVA: 0x00699864 File Offset: 0x00697A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveOrderReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			dataSectionGiftStore.RemoveOrderReward(orderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E37 RID: 97847 RVA: 0x006998BC File Offset: 0x00697ABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddOrderReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			OrderReward reward;
			LuaObject.checkType<OrderReward>(l, 3, out reward);
			dataSectionGiftStore.AddOrderReward(orderId, reward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E38 RID: 97848 RVA: 0x00699920 File Offset: 0x00697B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindOrderReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			OrderReward o = dataSectionGiftStore.FindOrderReward(orderId);
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

	// Token: 0x06017E39 RID: 97849 RVA: 0x00699984 File Offset: 0x00697B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllOrderRewards(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			Dictionary<string, OrderReward> allOrderRewards = dataSectionGiftStore.GetAllOrderRewards();
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

	// Token: 0x06017E3A RID: 97850 RVA: 0x006999D8 File Offset: 0x00697BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BanBuyingGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionGiftStore dataSectionGiftStore = (DataSectionGiftStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionGiftStore.BanBuyingGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E3B RID: 97851 RVA: 0x00699A2C File Offset: 0x00697C2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionGiftStore");
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.FindLocalBoughtItemById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.AddBoughtItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.AddFirstBuyGoodsRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.HasBought);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.GetFirstBoughtItemRegisterId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.InitBoughtItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.SetBoughtItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.InitFirstBuyGoodsRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.GetLocalBoughtItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.GetFirstBoughtRecords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.IsGoodsOnBanBuyingPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.SetBanBuyingGoodsTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.InitmBanBuyingGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.FindGiftStoreOperationalGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.ClearGiftStoreOperationalGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.InitOperationalGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.GetOperationalGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.InitOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.RemoveOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.AddOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.FindOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.GetAllOrderRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache17);
		string name = "BanBuyingGoodsList";
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.get_BanBuyingGoodsList);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache18, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.<>f__mg$cache19, typeof(DataSectionGiftStore), typeof(DataSection));
	}

	// Token: 0x0400E407 RID: 58375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E408 RID: 58376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E409 RID: 58377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E40A RID: 58378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E40B RID: 58379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E40C RID: 58380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E40D RID: 58381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E40E RID: 58382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E40F RID: 58383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E410 RID: 58384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E411 RID: 58385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E412 RID: 58386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E413 RID: 58387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E414 RID: 58388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E415 RID: 58389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E416 RID: 58390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E417 RID: 58391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E418 RID: 58392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E419 RID: 58393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E41A RID: 58394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E41B RID: 58395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E41C RID: 58396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E41D RID: 58397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E41E RID: 58398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E41F RID: 58399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E420 RID: 58400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
