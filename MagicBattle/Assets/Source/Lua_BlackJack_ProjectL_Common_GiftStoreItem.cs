using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001223 RID: 4643
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GiftStoreItem : LuaObject
{
	// Token: 0x06018165 RID: 98661 RVA: 0x006B0CF0 File Offset: 0x006AEEF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem o = new GiftStoreItem();
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

	// Token: 0x06018166 RID: 98662 RVA: 0x006B0D38 File Offset: 0x006AEF38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPB_s(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem item;
			LuaObject.checkType<GiftStoreItem>(l, 1, out item);
			ProGiftStoreItem o = GiftStoreItem.ToPB(item);
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

	// Token: 0x06018167 RID: 98663 RVA: 0x006B0D8C File Offset: 0x006AEF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromPB_s(IntPtr l)
	{
		int result;
		try
		{
			ProGiftStoreItem pbItem;
			LuaObject.checkType<ProGiftStoreItem>(l, 1, out pbItem);
			GiftStoreItem o = GiftStoreItem.FromPB(pbItem);
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

	// Token: 0x06018168 RID: 98664 RVA: 0x006B0DE0 File Offset: 0x006AEFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.GoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018169 RID: 98665 RVA: 0x006B0E34 File Offset: 0x006AF034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			giftStoreItem.GoodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601816A RID: 98666 RVA: 0x006B0E8C File Offset: 0x006AF08C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsFirstBuy(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.IsFirstBuy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601816B RID: 98667 RVA: 0x006B0EE0 File Offset: 0x006AF0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsFirstBuy(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			bool isFirstBuy;
			LuaObject.checkType(l, 2, out isFirstBuy);
			giftStoreItem.IsFirstBuy = isFirstBuy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601816C RID: 98668 RVA: 0x006B0F38 File Offset: 0x006AF138
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BoughtNums(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.BoughtNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601816D RID: 98669 RVA: 0x006B0F8C File Offset: 0x006AF18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BoughtNums(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			int boughtNums;
			LuaObject.checkType(l, 2, out boughtNums);
			giftStoreItem.BoughtNums = boughtNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601816E RID: 98670 RVA: 0x006B0FE4 File Offset: 0x006AF1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.NextFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601816F RID: 98671 RVA: 0x006B103C File Offset: 0x006AF23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			DateTime nextFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextFlushTime);
			giftStoreItem.NextFlushTime = nextFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018170 RID: 98672 RVA: 0x006B1094 File Offset: 0x006AF294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SaleStartTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.SaleStartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018171 RID: 98673 RVA: 0x006B10EC File Offset: 0x006AF2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SaleStartTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			DateTime saleStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out saleStartTime);
			giftStoreItem.SaleStartTime = saleStartTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018172 RID: 98674 RVA: 0x006B1144 File Offset: 0x006AF344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SaleEndTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.SaleEndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018173 RID: 98675 RVA: 0x006B119C File Offset: 0x006AF39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SaleEndTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			DateTime saleEndTime;
			LuaObject.checkValueType<DateTime>(l, 2, out saleEndTime);
			giftStoreItem.SaleEndTime = saleEndTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018174 RID: 98676 RVA: 0x006B11F4 File Offset: 0x006AF3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreItem.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018175 RID: 98677 RVA: 0x006B1248 File Offset: 0x006AF448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Config(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreItem giftStoreItem = (GiftStoreItem)LuaObject.checkSelf(l);
			ConfigDataGiftStoreItemInfo config;
			LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 2, out config);
			giftStoreItem.Config = config;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018176 RID: 98678 RVA: 0x006B12A0 File Offset: 0x006AF4A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GiftStoreItem");
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.ToPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.FromPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache1);
		string name = "GoodsId";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_GoodsId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_GoodsId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache3, true);
		string name2 = "IsFirstBuy";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_IsFirstBuy);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_IsFirstBuy);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache5, true);
		string name3 = "BoughtNums";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_BoughtNums);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_BoughtNums);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache7, true);
		string name4 = "NextFlushTime";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_NextFlushTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_NextFlushTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache9, true);
		string name5 = "SaleStartTime";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_SaleStartTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_SaleStartTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheB, true);
		string name6 = "SaleEndTime";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_SaleEndTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_SaleEndTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheD, true);
		string name7 = "Config";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.get_Config);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.set_Config);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GiftStoreItem.<>f__mg$cache10, typeof(GiftStoreItem));
	}

	// Token: 0x0400E701 RID: 59137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E702 RID: 59138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E703 RID: 59139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E704 RID: 59140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E705 RID: 59141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E706 RID: 59142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E707 RID: 59143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E708 RID: 59144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E709 RID: 59145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E70A RID: 59146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E70B RID: 59147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E70C RID: 59148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E70D RID: 59149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E70E RID: 59150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E70F RID: 59151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E710 RID: 59152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E711 RID: 59153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
