using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C5 RID: 4549
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BagItemBase : LuaObject
{
	// Token: 0x0601794F RID: 96591 RVA: 0x00676810 File Offset: 0x00674A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			BagItemBase o = new BagItemBase(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06017950 RID: 96592 RVA: 0x0067688C File Offset: 0x00674A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnough(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = bagItemBase.IsEnough(consumeNums);
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

	// Token: 0x06017951 RID: 96593 RVA: 0x006768F0 File Offset: 0x00674AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsThisGoodsType(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			bool b = bagItemBase.IsThisGoodsType(goodsType);
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

	// Token: 0x06017952 RID: 96594 RVA: 0x00676954 File Offset: 0x00674B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBGoods(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			ProGoods o = bagItemBase.ToPBGoods();
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

	// Token: 0x06017953 RID: 96595 RVA: 0x006769A8 File Offset: 0x00674BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToGoods(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			Goods o = bagItemBase.ToGoods();
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

	// Token: 0x06017954 RID: 96596 RVA: 0x006769FC File Offset: 0x00674BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInstanceBagItem_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsTypeId);
			bool b = BagItemBase.IsInstanceBagItem(goodsTypeId);
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

	// Token: 0x06017955 RID: 96597 RVA: 0x00676A50 File Offset: 0x00674C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBagItem_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			bool b = BagItemBase.IsBagItem(goodsType);
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

	// Token: 0x06017956 RID: 96598 RVA: 0x00676AA4 File Offset: 0x00674CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMoney_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			bool b = BagItemBase.IsMoney(goodsType);
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

	// Token: 0x06017957 RID: 96599 RVA: 0x00676AF8 File Offset: 0x00674CF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBGoodsToBagItem_s(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory;
			LuaObject.checkType<BagItemFactory>(l, 1, out bagItemFactory);
			ProGoods pbGoods;
			LuaObject.checkType<ProGoods>(l, 2, out pbGoods);
			BagItemBase o = BagItemBase.PBGoodsToBagItem(bagItemFactory, pbGoods);
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

	// Token: 0x06017958 RID: 96600 RVA: 0x00676B58 File Offset: 0x00674D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBGoodsToBagItems_s(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory;
			LuaObject.checkType<BagItemFactory>(l, 1, out bagItemFactory);
			List<ProGoods> goodsList;
			LuaObject.checkType<List<ProGoods>>(l, 2, out goodsList);
			List<BagItemBase> o = BagItemBase.PBGoodsToBagItems(bagItemFactory, goodsList);
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

	// Token: 0x06017959 RID: 96601 RVA: 0x00676BB8 File Offset: 0x00674DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagItemsToPBGoods_s(IntPtr l)
	{
		int result;
		try
		{
			List<BagItemBase> bagItems;
			LuaObject.checkType<List<BagItemBase>>(l, 1, out bagItems);
			List<ProGoods> o = BagItemBase.BagItemsToPBGoods(bagItems);
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

	// Token: 0x0601795A RID: 96602 RVA: 0x00676C0C File Offset: 0x00674E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GoodsListToPBGoodsList_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 1, out goodsList);
			List<ProGoods> o = BagItemBase.GoodsListToPBGoodsList(goodsList);
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

	// Token: 0x0601795B RID: 96603 RVA: 0x00676C60 File Offset: 0x00674E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBGoodsListToGoodsList_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProGoods> pbGoodsList;
			LuaObject.checkType<List<ProGoods>>(l, 1, out pbGoodsList);
			List<Goods> o = BagItemBase.PBGoodsListToGoodsList(pbGoodsList);
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

	// Token: 0x0601795C RID: 96604 RVA: 0x00676CB4 File Offset: 0x00674EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoodsToPBGoods_s(IntPtr l)
	{
		int result;
		try
		{
			Goods goods;
			LuaObject.checkType<Goods>(l, 1, out goods);
			ProGoods o = BagItemBase.GoodsToPBGoods(goods);
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

	// Token: 0x0601795D RID: 96605 RVA: 0x00676D08 File Offset: 0x00674F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBGoodsToGoods_s(IntPtr l)
	{
		int result;
		try
		{
			ProGoods pbGoods;
			LuaObject.checkType<ProGoods>(l, 1, out pbGoods);
			Goods o = BagItemBase.PBGoodsToGoods(pbGoods);
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

	// Token: 0x0601795E RID: 96606 RVA: 0x00676D5C File Offset: 0x00674F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ListItemName(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.ListItemName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601795F RID: 96607 RVA: 0x00676DB0 File Offset: 0x00674FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsTypeId(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)bagItemBase.GoodsTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017960 RID: 96608 RVA: 0x00676E04 File Offset: 0x00675004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GoodsTypeId(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			bagItemBase.GoodsTypeId = goodsTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017961 RID: 96609 RVA: 0x00676E5C File Offset: 0x0067505C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ContentId(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.ContentId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017962 RID: 96610 RVA: 0x00676EB0 File Offset: 0x006750B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ContentId(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			int contentId;
			LuaObject.checkType(l, 2, out contentId);
			bagItemBase.ContentId = contentId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017963 RID: 96611 RVA: 0x00676F08 File Offset: 0x00675108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Nums(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.Nums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017964 RID: 96612 RVA: 0x00676F5C File Offset: 0x0067515C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Nums(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bagItemBase.Nums = nums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017965 RID: 96613 RVA: 0x00676FB4 File Offset: 0x006751B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017966 RID: 96614 RVA: 0x00677008 File Offset: 0x00675208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			bagItemBase.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017967 RID: 96615 RVA: 0x00677060 File Offset: 0x00675260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.ItemInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017968 RID: 96616 RVA: 0x006770B4 File Offset: 0x006752B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobMaterialInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.JobMaterialInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017969 RID: 96617 RVA: 0x00677108 File Offset: 0x00675308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.EquipmentInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601796A RID: 96618 RVA: 0x0067715C File Offset: 0x0067535C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnchantStoneInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItemBase = (BagItemBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemBase.EnchantStoneInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601796B RID: 96619 RVA: 0x006771B0 File Offset: 0x006753B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BagItemBase");
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.IsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.IsThisGoodsType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.ToPBGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.ToGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.IsInstanceBagItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.IsBagItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.IsMoney_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.PBGoodsToBagItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.PBGoodsToBagItems_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.BagItemsToPBGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.GoodsListToPBGoodsList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.PBGoodsListToGoodsList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.GoodsToPBGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.PBGoodsToGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheD);
		string name = "ListItemName";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_ListItemName);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheE, null, true);
		string name2 = "GoodsTypeId";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_GoodsTypeId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.set_GoodsTypeId);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache10, true);
		string name3 = "ContentId";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_ContentId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.set_ContentId);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache12, true);
		string name4 = "Nums";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_Nums);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.set_Nums);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache14, true);
		string name5 = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_InstanceId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.set_InstanceId);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache16, true);
		string name6 = "ItemInfo";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_ItemInfo);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache17, null, true);
		string name7 = "JobMaterialInfo";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_JobMaterialInfo);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache18, null, true);
		string name8 = "EquipmentInfo";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_EquipmentInfo);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache19, null, true);
		string name9 = "EnchantStoneInfo";
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.get_EnchantStoneInfo);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1A, null, true);
		if (Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BagItemBase.<>f__mg$cache1B, typeof(BagItemBase));
	}

	// Token: 0x0400DFA7 RID: 57255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DFA8 RID: 57256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DFA9 RID: 57257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DFAA RID: 57258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DFAB RID: 57259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DFAC RID: 57260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DFAD RID: 57261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DFAE RID: 57262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DFAF RID: 57263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DFB0 RID: 57264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DFB1 RID: 57265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DFB2 RID: 57266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DFB3 RID: 57267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DFB4 RID: 57268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DFB5 RID: 57269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DFB6 RID: 57270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DFB7 RID: 57271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DFB8 RID: 57272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DFB9 RID: 57273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DFBA RID: 57274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DFBB RID: 57275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DFBC RID: 57276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DFBD RID: 57277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DFBE RID: 57278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DFBF RID: 57279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DFC0 RID: 57280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DFC1 RID: 57281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DFC2 RID: 57282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
