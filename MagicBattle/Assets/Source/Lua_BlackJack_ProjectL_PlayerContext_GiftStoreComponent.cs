using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C4 RID: 4804
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent : LuaObject
{
	// Token: 0x06019472 RID: 103538 RVA: 0x0073ED28 File Offset: 0x0073CF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent o = new GiftStoreComponent();
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

	// Token: 0x06019473 RID: 103539 RVA: 0x0073ED70 File Offset: 0x0073CF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019474 RID: 103540 RVA: 0x0073EDBC File Offset: 0x0073CFBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019475 RID: 103541 RVA: 0x0073EE08 File Offset: 0x0073D008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019476 RID: 103542 RVA: 0x0073EE54 File Offset: 0x0073D054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			ushort dsversion = giftStoreComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019477 RID: 103543 RVA: 0x0073EEA8 File Offset: 0x0073D0A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGiftStoreItemSellOut(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			GiftStoreItem item;
			LuaObject.checkType<GiftStoreItem>(l, 2, out item);
			bool b = giftStoreComponent.IsGiftStoreItemSellOut(item);
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

	// Token: 0x06019478 RID: 103544 RVA: 0x0073EF0C File Offset: 0x0073D10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(DSGiftStoreNtf)))
			{
				GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
				DSGiftStoreNtf msg;
				LuaObject.checkType<DSGiftStoreNtf>(l, 2, out msg);
				giftStoreComponent.DeSerialize(msg);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(GiftStoreOperationalGoodsUpdateNtf)))
			{
				GiftStoreComponent giftStoreComponent2 = (GiftStoreComponent)LuaObject.checkSelf(l);
				GiftStoreOperationalGoodsUpdateNtf msg2;
				LuaObject.checkType<GiftStoreOperationalGoodsUpdateNtf>(l, 2, out msg2);
				giftStoreComponent2.DeSerialize(msg2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DeSerialize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019479 RID: 103545 RVA: 0x0073EFE4 File Offset: 0x0073D1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string registerId;
			LuaObject.checkType(l, 3, out registerId);
			int boughtNums;
			LuaObject.checkType(l, 4, out boughtNums);
			long nextFlushTime;
			LuaObject.checkType(l, 5, out nextFlushTime);
			giftStoreComponent.BuyGoods(goodsId, registerId, boughtNums, nextFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601947A RID: 103546 RVA: 0x0073F064 File Offset: 0x0073D264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			string s = giftStoreComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601947B RID: 103547 RVA: 0x0073F0C0 File Offset: 0x0073D2C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601947C RID: 103548 RVA: 0x0073F114 File Offset: 0x0073D314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601947D RID: 103549 RVA: 0x0073F168 File Offset: 0x0073D368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601947E RID: 103550 RVA: 0x0073F1BC File Offset: 0x0073D3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			giftStoreComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601947F RID: 103551 RVA: 0x0073F218 File Offset: 0x0073D418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			giftStoreComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019480 RID: 103552 RVA: 0x0073F26C File Offset: 0x0073D46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetOfferedStoreItems(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			List<GiftStoreItem> o = giftStoreComponent.m_luaExportHelper.__callBase_GetOfferedStoreItems();
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

	// Token: 0x06019481 RID: 103553 RVA: 0x0073F2C8 File Offset: 0x0073D4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOnSaleTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			DateTime saleStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out saleStartTime);
			DateTime saleEndTime;
			LuaObject.checkValueType<DateTime>(l, 3, out saleEndTime);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 4, out currentTime);
			bool b = giftStoreComponent.m_luaExportHelper.__callBase_IsOnSaleTime(saleStartTime, saleEndTime, currentTime);
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

	// Token: 0x06019482 RID: 103554 RVA: 0x0073F34C File Offset: 0x0073D54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasBought(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = giftStoreComponent.m_luaExportHelper.__callBase_HasBought(goodsId);
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

	// Token: 0x06019483 RID: 103555 RVA: 0x0073F3B4 File Offset: 0x0073D5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanBuyGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int i = giftStoreComponent.m_luaExportHelper.__callBase_CanBuyGoods(goodsId);
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

	// Token: 0x06019484 RID: 103556 RVA: 0x0073F41C File Offset: 0x0073D61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAppleSubscribeGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int i = giftStoreComponent.m_luaExportHelper.__callBase_CanAppleSubscribeGoods(goodsId);
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

	// Token: 0x06019485 RID: 103557 RVA: 0x0073F484 File Offset: 0x0073D684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddFirstBuyGoodsRecord(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsRegisterId;
			LuaObject.checkType(l, 3, out goodsRegisterId);
			giftStoreComponent.m_luaExportHelper.__callBase_AddFirstBuyGoodsRecord(goodsId, goodsRegisterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019486 RID: 103558 RVA: 0x0073F4F0 File Offset: 0x0073D6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllOrderRewards(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			List<OrderReward> o = giftStoreComponent.m_luaExportHelper.__callBase_GetAllOrderRewards();
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

	// Token: 0x06019487 RID: 103559 RVA: 0x0073F54C File Offset: 0x0073D74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveOrderReward(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			giftStoreComponent.m_luaExportHelper.__callBase_RemoveOrderReward(orderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019488 RID: 103560 RVA: 0x0073F5A8 File Offset: 0x0073D7A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddOrderReward(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			OrderReward reward;
			LuaObject.checkType<OrderReward>(l, 3, out reward);
			giftStoreComponent.m_luaExportHelper.__callBase_AddOrderReward(orderId, reward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019489 RID: 103561 RVA: 0x0073F614 File Offset: 0x0073D814
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindOrderReward(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			OrderReward o = giftStoreComponent.m_luaExportHelper.__callBase_FindOrderReward(orderId);
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

	// Token: 0x0601948A RID: 103562 RVA: 0x0073F67C File Offset: 0x0073D87C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBuyGiftStoreGoods(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreComponent giftStoreComponent = (GiftStoreComponent)LuaObject.checkSelf(l);
			ConfigDataGiftStoreItemInfo goodsInfo;
			LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 2, out goodsInfo);
			giftStoreComponent.m_luaExportHelper.__callBase_OnBuyGiftStoreGoods(goodsInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601948B RID: 103563 RVA: 0x0073F6D8 File Offset: 0x0073D8D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.GiftStoreComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.IsGiftStoreItemSellOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.BuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_GetOfferedStoreItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_IsOnSaleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_HasBought);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_CanBuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_CanAppleSubscribeGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_AddFirstBuyGoodsRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_GetAllOrderRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_RemoveOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_AddOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_FindOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.__callBase_OnBuyGiftStoreGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.<>f__mg$cache18, typeof(GiftStoreComponent), typeof(GiftStoreComponentCommon));
	}

	// Token: 0x0400F8CC RID: 63692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F8CD RID: 63693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F8CE RID: 63694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F8CF RID: 63695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F8D0 RID: 63696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F8D1 RID: 63697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F8D2 RID: 63698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F8D3 RID: 63699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F8D4 RID: 63700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F8D5 RID: 63701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F8D6 RID: 63702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F8D7 RID: 63703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F8D8 RID: 63704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F8D9 RID: 63705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F8DA RID: 63706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F8DB RID: 63707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F8DC RID: 63708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F8DD RID: 63709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F8DE RID: 63710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F8DF RID: 63711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F8E0 RID: 63712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F8E1 RID: 63713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F8E2 RID: 63714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F8E3 RID: 63715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F8E4 RID: 63716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
