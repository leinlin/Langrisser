using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200120E RID: 4622
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore : LuaObject
{
	// Token: 0x06017FE8 RID: 98280 RVA: 0x006A6138 File Offset: 0x006A4338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore o = new DataSectionRechargeStore();
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

	// Token: 0x06017FE9 RID: 98281 RVA: 0x006A6180 File Offset: 0x006A4380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			dataSectionRechargeStore.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FEA RID: 98282 RVA: 0x006A61CC File Offset: 0x006A43CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			object o = dataSectionRechargeStore.SerializeToClient();
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

	// Token: 0x06017FEB RID: 98283 RVA: 0x006A6220 File Offset: 0x006A4420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBoughtGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			List<int> goodsList;
			LuaObject.checkType<List<int>>(l, 2, out goodsList);
			dataSectionRechargeStore.InitBoughtGoodsList(goodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FEC RID: 98284 RVA: 0x006A6278 File Offset: 0x006A4478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearBoughtGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			dataSectionRechargeStore.ClearBoughtGoodsList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FED RID: 98285 RVA: 0x006A62C4 File Offset: 0x006A44C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGoodsBought(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = dataSectionRechargeStore.IsGoodsBought(goodsId);
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

	// Token: 0x06017FEE RID: 98286 RVA: 0x006A6328 File Offset: 0x006A4528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyGoods(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			dataSectionRechargeStore.BuyGoods(goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FEF RID: 98287 RVA: 0x006A6380 File Offset: 0x006A4580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBoughtGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			HashSet<int> boughtGoodsList = dataSectionRechargeStore.GetBoughtGoodsList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boughtGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FF0 RID: 98288 RVA: 0x006A63D4 File Offset: 0x006A45D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGoodsOnBanBuyingPeriod(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			bool b = dataSectionRechargeStore.IsGoodsOnBanBuyingPeriod(goodsId, currentTime);
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

	// Token: 0x06017FF1 RID: 98289 RVA: 0x006A6444 File Offset: 0x006A4644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBanBuyingGoodsTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			DateTime expiredTime;
			LuaObject.checkValueType<DateTime>(l, 3, out expiredTime);
			dataSectionRechargeStore.SetBanBuyingGoodsTime(goodsId, expiredTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FF2 RID: 98290 RVA: 0x006A64A8 File Offset: 0x006A46A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitmBanBuyingGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			Dictionary<int, DateTime> goodsList;
			LuaObject.checkType<Dictionary<int, DateTime>>(l, 2, out goodsList);
			dataSectionRechargeStore.InitmBanBuyingGoodsList(goodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FF3 RID: 98291 RVA: 0x006A6500 File Offset: 0x006A4700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_banBuyingGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRechargeStore.m_banBuyingGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FF4 RID: 98292 RVA: 0x006A6554 File Offset: 0x006A4754
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_banBuyingGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			Dictionary<int, DateTime> banBuyingGoodsList;
			LuaObject.checkType<Dictionary<int, DateTime>>(l, 2, out banBuyingGoodsList);
			dataSectionRechargeStore.m_banBuyingGoodsList = banBuyingGoodsList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FF5 RID: 98293 RVA: 0x006A65AC File Offset: 0x006A47AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BanBuyingGoodsList(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRechargeStore dataSectionRechargeStore = (DataSectionRechargeStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRechargeStore.BanBuyingGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FF6 RID: 98294 RVA: 0x006A6600 File Offset: 0x006A4800
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionRechargeStore");
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.InitBoughtGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.ClearBoughtGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.IsGoodsBought);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.BuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.GetBoughtGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.IsGoodsOnBanBuyingPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.SetBanBuyingGoodsTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.InitmBanBuyingGoodsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cache9);
		string name = "m_banBuyingGoodsList";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.get_m_banBuyingGoodsList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.set_m_banBuyingGoodsList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheB, true);
		string name2 = "BanBuyingGoodsList";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.get_BanBuyingGoodsList);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheC, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.<>f__mg$cacheD, typeof(DataSectionRechargeStore), typeof(DataSection));
	}

	// Token: 0x0400E5AE RID: 58798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E5AF RID: 58799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E5B0 RID: 58800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E5B1 RID: 58801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E5B2 RID: 58802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E5B3 RID: 58803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E5B4 RID: 58804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E5B5 RID: 58805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E5B6 RID: 58806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E5B7 RID: 58807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E5B8 RID: 58808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E5B9 RID: 58809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E5BA RID: 58810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E5BB RID: 58811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
