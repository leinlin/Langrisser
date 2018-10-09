using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001224 RID: 4644
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods : LuaObject
{
	// Token: 0x06018178 RID: 98680 RVA: 0x006B1520 File Offset: 0x006AF720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods o = new GiftStoreOperationalGoods();
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

	// Token: 0x06018179 RID: 98681 RVA: 0x006B1568 File Offset: 0x006AF768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPB_s(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods goods;
			LuaObject.checkType<GiftStoreOperationalGoods>(l, 1, out goods);
			ProGiftStoreOperationalGoods o = GiftStoreOperationalGoods.ToPB(goods);
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

	// Token: 0x0601817A RID: 98682 RVA: 0x006B15BC File Offset: 0x006AF7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromPB_s(IntPtr l)
	{
		int result;
		try
		{
			ProGiftStoreOperationalGoods pbGoods;
			LuaObject.checkType<ProGiftStoreOperationalGoods>(l, 1, out pbGoods);
			GiftStoreOperationalGoods o = GiftStoreOperationalGoods.FromPB(pbGoods);
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

	// Token: 0x0601817B RID: 98683 RVA: 0x006B1610 File Offset: 0x006AF810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods giftStoreOperationalGoods = (GiftStoreOperationalGoods)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreOperationalGoods.GoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601817C RID: 98684 RVA: 0x006B1664 File Offset: 0x006AF864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods giftStoreOperationalGoods = (GiftStoreOperationalGoods)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			giftStoreOperationalGoods.GoodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601817D RID: 98685 RVA: 0x006B16BC File Offset: 0x006AF8BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SaleStartTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods giftStoreOperationalGoods = (GiftStoreOperationalGoods)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreOperationalGoods.SaleStartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601817E RID: 98686 RVA: 0x006B1714 File Offset: 0x006AF914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SaleStartTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods giftStoreOperationalGoods = (GiftStoreOperationalGoods)LuaObject.checkSelf(l);
			DateTime saleStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out saleStartTime);
			giftStoreOperationalGoods.SaleStartTime = saleStartTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601817F RID: 98687 RVA: 0x006B176C File Offset: 0x006AF96C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SaleEndTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods giftStoreOperationalGoods = (GiftStoreOperationalGoods)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreOperationalGoods.SaleEndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018180 RID: 98688 RVA: 0x006B17C4 File Offset: 0x006AF9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SaleEndTime(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreOperationalGoods giftStoreOperationalGoods = (GiftStoreOperationalGoods)LuaObject.checkSelf(l);
			DateTime saleEndTime;
			LuaObject.checkValueType<DateTime>(l, 2, out saleEndTime);
			giftStoreOperationalGoods.SaleEndTime = saleEndTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018181 RID: 98689 RVA: 0x006B181C File Offset: 0x006AFA1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GiftStoreOperationalGoods");
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.ToPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.FromPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache1);
		string name = "GoodsId";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.get_GoodsId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.set_GoodsId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache3, true);
		string name2 = "SaleStartTime";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.get_SaleStartTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.set_SaleStartTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache5, true);
		string name3 = "SaleEndTime";
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.get_SaleEndTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.set_SaleEndTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.<>f__mg$cache8, typeof(GiftStoreOperationalGoods));
	}

	// Token: 0x0400E712 RID: 59154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E713 RID: 59155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E714 RID: 59156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E715 RID: 59157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E716 RID: 59158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E717 RID: 59159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E718 RID: 59160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E719 RID: 59161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E71A RID: 59162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
