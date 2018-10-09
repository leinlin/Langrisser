using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C4 RID: 4548
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BagComponentCommon : LuaObject
{
	// Token: 0x060178E1 RID: 96481 RVA: 0x00672C38 File Offset: 0x00670E38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon o = new BagComponentCommon();
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

	// Token: 0x060178E2 RID: 96482 RVA: 0x00672C80 File Offset: 0x00670E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			string name = bagComponentCommon.GetName();
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

	// Token: 0x060178E3 RID: 96483 RVA: 0x00672CD4 File Offset: 0x00670ED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			bagComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178E4 RID: 96484 RVA: 0x00672D20 File Offset: 0x00670F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			bagComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178E5 RID: 96485 RVA: 0x00672D6C File Offset: 0x00670F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			bagComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178E6 RID: 96486 RVA: 0x00672DB8 File Offset: 0x00670FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			bagComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178E7 RID: 96487 RVA: 0x00672E10 File Offset: 0x00671010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			bagComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178E8 RID: 96488 RVA: 0x00672E5C File Offset: 0x0067105C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGoodsEnough(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> conditions;
			LuaObject.checkType<List<Goods>>(l, 2, out conditions);
			List<BagItemBase> o;
			int i = bagComponentCommon.IsGoodsEnough(conditions, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178E9 RID: 96489 RVA: 0x00672ECC File Offset: 0x006710CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ConsumeGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> needToConsumeGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out needToConsumeGoods);
			List<BagItemBase> bagItemsInBag;
			LuaObject.checkType<List<BagItemBase>>(l, 3, out bagItemsInBag);
			List<BagItemBase> changedGoods;
			LuaObject.checkType<List<BagItemBase>>(l, 4, out changedGoods);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 5, out causeId);
			string location;
			LuaObject.checkType(l, 6, out location);
			bagComponentCommon.ConsumeGoods(needToConsumeGoods, bagItemsInBag, changedGoods, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178EA RID: 96490 RVA: 0x00672F58 File Offset: 0x00671158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBagFullByRandomGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int addRandomRewardExpectSize;
			LuaObject.checkType(l, 2, out addRandomRewardExpectSize);
			List<Goods> addGoods;
			LuaObject.checkType<List<Goods>>(l, 3, out addGoods);
			List<Goods> deleteGoods;
			LuaObject.checkType<List<Goods>>(l, 4, out deleteGoods);
			bool b = bagComponentCommon.IsBagFullByRandomGoods(addRandomRewardExpectSize, addGoods, deleteGoods);
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

	// Token: 0x060178EB RID: 96491 RVA: 0x00672FD4 File Offset: 0x006711D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBagFullByGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> addGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out addGoods);
			List<Goods> deleteGoods;
			LuaObject.checkType<List<Goods>>(l, 3, out deleteGoods);
			bool b = bagComponentCommon.IsBagFullByGoods(addGoods, deleteGoods);
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

	// Token: 0x060178EC RID: 96492 RVA: 0x00673044 File Offset: 0x00671244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBagFull(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int expectSize;
			LuaObject.checkType(l, 2, out expectSize);
			bool b = bagComponentCommon.IsBagFull(expectSize);
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

	// Token: 0x060178ED RID: 96493 RVA: 0x006730A8 File Offset: 0x006712A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBagSize(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int bagSize = bagComponentCommon.GetBagSize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178EE RID: 96494 RVA: 0x006730FC File Offset: 0x006712FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBagFullByCurrentSize(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			bool b = bagComponentCommon.IsBagFullByCurrentSize();
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

	// Token: 0x060178EF RID: 96495 RVA: 0x00673150 File Offset: 0x00671350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBagItemContentIdInConfig(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int i = bagComponentCommon.IsBagItemContentIdInConfig(goodsTypeId, contentId);
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

	// Token: 0x060178F0 RID: 96496 RVA: 0x006731C0 File Offset: 0x006713C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<BagItemBase> changedBagItems;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out changedBagItems);
			int removeItemMaxNums;
			LuaObject.checkType(l, 3, out removeItemMaxNums);
			bagComponentCommon.RemoveAllBagItems(changedBagItems, removeItemMaxNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178F1 RID: 96497 RVA: 0x00673224 File Offset: 0x00671424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 4, out consumeNums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 6, out caseId);
			string location;
			LuaObject.checkType(l, 7, out location);
			int i = bagComponentCommon.RemoveBagItem(goodsTypeId, contentId, consumeNums, instanceId, caseId, location);
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

	// Token: 0x060178F2 RID: 96498 RVA: 0x006732C4 File Offset: 0x006714C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveBagItemByType(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 4, out consumeNums);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 5, out caseId);
			string location;
			LuaObject.checkType(l, 6, out location);
			int i = bagComponentCommon.RemoveBagItemByType(goodsTypeId, contentId, consumeNums, caseId, location);
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

	// Token: 0x060178F3 RID: 96499 RVA: 0x00673358 File Offset: 0x00671558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveBagItemByInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out caseId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = bagComponentCommon.RemoveBagItemByInstanceId(instanceId, caseId, location);
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

	// Token: 0x060178F4 RID: 96500 RVA: 0x006733D4 File Offset: 0x006715D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveBagItemDirectly(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out caseId);
			string location;
			LuaObject.checkType(l, 5, out location);
			BagItemBase o = bagComponentCommon.RemoveBagItemDirectly(bagItem, consumeNums, caseId, location);
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

	// Token: 0x060178F5 RID: 96501 RVA: 0x0067345C File Offset: 0x0067165C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			ulong instanceId;
			LuaObject.checkType(l, 4, out instanceId);
			BagItemBase o = bagComponentCommon.FindBagItem(goodsTypeId, contentId, instanceId);
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

	// Token: 0x060178F6 RID: 96502 RVA: 0x006734D8 File Offset: 0x006716D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindBagItemByInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			BagItemBase o = bagComponentCommon.FindBagItemByInstanceId(instanceId);
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

	// Token: 0x060178F7 RID: 96503 RVA: 0x0067353C File Offset: 0x0067173C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindBagItemByType(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			BagItemBase o = bagComponentCommon.FindBagItemByType(goodsTypeId, contentId);
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

	// Token: 0x060178F8 RID: 96504 RVA: 0x006735AC File Offset: 0x006717AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindUseableBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			UseableBagItem o = bagComponentCommon.FindUseableBagItem(goodsTypeId, contentId);
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

	// Token: 0x060178F9 RID: 96505 RVA: 0x0067361C File Offset: 0x0067181C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<BagItemBase> allBagItems = bagComponentCommon.GetAllBagItems();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allBagItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178FA RID: 96506 RVA: 0x00673670 File Offset: 0x00671870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IterateAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			IEnumerable<BagItemBase> o = bagComponentCommon.IterateAllBagItems();
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

	// Token: 0x060178FB RID: 96507 RVA: 0x006736C4 File Offset: 0x006718C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindEnoughBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> conditions;
			LuaObject.checkType<List<Goods>>(l, 2, out conditions);
			List<BagItemBase> o = bagComponentCommon.FindEnoughBagItems(conditions);
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

	// Token: 0x060178FC RID: 96508 RVA: 0x00673728 File Offset: 0x00671928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UseBagItem(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
				UseableBagItem useableBagItem;
				LuaObject.checkType<UseableBagItem>(l, 2, out useableBagItem);
				int consumeNums;
				LuaObject.checkType(l, 3, out consumeNums);
				object[] param;
				LuaObject.checkParams<object>(l, 4, out param);
				int i = bagComponentCommon.UseBagItem(useableBagItem, consumeNums, param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				BagComponentCommon bagComponentCommon2 = (BagComponentCommon)LuaObject.checkSelf(l);
				GoodsType goodsTypeId;
				LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
				int contentId;
				LuaObject.checkType(l, 3, out contentId);
				int consumeNums2;
				LuaObject.checkType(l, 4, out consumeNums2);
				object[] param2;
				LuaObject.checkParams<object>(l, 5, out param2);
				int i2 = bagComponentCommon2.UseBagItem(goodsTypeId, contentId, consumeNums2, param2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function UseBagItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178FD RID: 96509 RVA: 0x00673834 File Offset: 0x00671A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UseBagItemDirectly(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			UseableBagItem useableBagItem;
			LuaObject.checkType<UseableBagItem>(l, 2, out useableBagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			object[] param;
			LuaObject.checkParams<object>(l, 4, out param);
			int i = bagComponentCommon.UseBagItemDirectly(useableBagItem, consumeNums, param);
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

	// Token: 0x060178FE RID: 96510 RVA: 0x006738B0 File Offset: 0x00671AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasEnoughBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			int i = bagComponentCommon.HasEnoughBagItem(bagItem, consumeNums);
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

	// Token: 0x060178FF RID: 96511 RVA: 0x00673920 File Offset: 0x00671B20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBagItemEnough(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType bagItemType;
			LuaObject.checkEnum<GoodsType>(l, 2, out bagItemType);
			int bagItemId;
			LuaObject.checkType(l, 3, out bagItemId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			bool b = bagComponentCommon.IsBagItemEnough(bagItemType, bagItemId, nums);
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

	// Token: 0x06017900 RID: 96512 RVA: 0x0067399C File Offset: 0x00671B9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTicketId(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out causeId);
			int ticketId = bagComponentCommon.GetTicketId(causeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ticketId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017901 RID: 96513 RVA: 0x00673A00 File Offset: 0x00671C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelTicketsMaxByUI(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out causeId);
			GoodsType goodTypeId;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodTypeId);
			int contentId;
			LuaObject.checkType(l, 4, out contentId);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			bool b = bagComponentCommon.IsLevelTicketsMaxByUI(causeId, goodTypeId, contentId, nums);
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

	// Token: 0x06017902 RID: 96514 RVA: 0x00673A88 File Offset: 0x00671C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SellBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int i = bagComponentCommon.SellBagItem(instanceId, nums);
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

	// Token: 0x06017903 RID: 96515 RVA: 0x00673AF8 File Offset: 0x00671CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombineSameGoodsAndReplaceExistHeroToFragment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodsList);
			bagComponentCommon.CombineSameGoodsAndReplaceExistHeroToFragment(goodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017904 RID: 96516 RVA: 0x00673B50 File Offset: 0x00671D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanDecomposeBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<ProGoods> goods;
			LuaObject.checkType<List<ProGoods>>(l, 2, out goods);
			int i = bagComponentCommon.CanDecomposeBagItems(goods);
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

	// Token: 0x06017905 RID: 96517 RVA: 0x00673BB4 File Offset: 0x00671DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanDecomposeABagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			int i = bagComponentCommon.CanDecomposeABagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06017906 RID: 96518 RVA: 0x00673C3C File Offset: 0x00671E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBagItemDirty(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase bagItemDirty;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItemDirty);
			bagComponentCommon.SetBagItemDirty(bagItemDirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017907 RID: 96519 RVA: 0x00673C94 File Offset: 0x00671E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPercentBaseBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			PropertyModifyType id;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out id);
			bool b = bagComponentCommon.IsPercentBaseBattleProperty(id);
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

	// Token: 0x06017908 RID: 96520 RVA: 0x00673CF8 File Offset: 0x00671EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanLockAndUnLockEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = bagComponentCommon.CanLockAndUnLockEquipment(instanceId);
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

	// Token: 0x06017909 RID: 96521 RVA: 0x00673D5C File Offset: 0x00671F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LockAndUnLockEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = bagComponentCommon.LockAndUnLockEquipment(instanceId);
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

	// Token: 0x0601790A RID: 96522 RVA: 0x00673DC0 File Offset: 0x00671FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanEnhanceEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 3, out materialIds);
			int i = bagComponentCommon.CanEnhanceEquipment(instanceId, materialIds);
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

	// Token: 0x0601790B RID: 96523 RVA: 0x00673E30 File Offset: 0x00672030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanWearEquipmentByEquipmentType(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase equipment;
			LuaObject.checkType<BagItemBase>(l, 2, out equipment);
			bool b = bagComponentCommon.CanWearEquipmentByEquipmentType(equipment);
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

	// Token: 0x0601790C RID: 96524 RVA: 0x00673E94 File Offset: 0x00672094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateEnhanceEquipmentExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<BagItemBase> materials;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out materials);
			int i = bagComponentCommon.CalculateEnhanceEquipmentExp(materials);
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

	// Token: 0x0601790D RID: 96525 RVA: 0x00673EF8 File Offset: 0x006720F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateEnhanceEquipmentGold(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			int i = bagComponentCommon.CalculateEnhanceEquipmentGold(exp);
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

	// Token: 0x0601790E RID: 96526 RVA: 0x00673F5C File Offset: 0x0067215C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnhanceEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 3, out materialIds);
			int i = bagComponentCommon.EnhanceEquipment(instanceId, materialIds);
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

	// Token: 0x0601790F RID: 96527 RVA: 0x00673FCC File Offset: 0x006721CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanEnchantEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			ulong enchantStoneInstanceId;
			LuaObject.checkType(l, 3, out enchantStoneInstanceId);
			int i = bagComponentCommon.CanEnchantEquipment(equipmentInstanceId, enchantStoneInstanceId);
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

	// Token: 0x06017910 RID: 96528 RVA: 0x0067403C File Offset: 0x0067223C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CaculateEquipmentNextLevelExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int equipmentContentId;
			LuaObject.checkType(l, 2, out equipmentContentId);
			int equipmentLevel;
			LuaObject.checkType(l, 3, out equipmentLevel);
			int i = bagComponentCommon.CaculateEquipmentNextLevelExp(equipmentContentId, equipmentLevel);
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

	// Token: 0x06017911 RID: 96529 RVA: 0x006740AC File Offset: 0x006722AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanLevelUpEquipmentStar(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 3, out materialId);
			int i = bagComponentCommon.CanLevelUpEquipmentStar(instanceId, materialId);
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

	// Token: 0x06017912 RID: 96530 RVA: 0x0067411C File Offset: 0x0067231C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateLevelUpEquipmentStarGold(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int i = bagComponentCommon.CalculateLevelUpEquipmentStarGold(equipment);
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

	// Token: 0x06017913 RID: 96531 RVA: 0x00674180 File Offset: 0x00672380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelUpEquipmentStar(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 3, out materialId);
			int i = bagComponentCommon.LevelUpEquipmentStar(instanceId, materialId);
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

	// Token: 0x06017914 RID: 96532 RVA: 0x006741F0 File Offset: 0x006723F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateEquipmentTotalExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int i = bagComponentCommon.CalculateEquipmentTotalExp(equipment);
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

	// Token: 0x06017915 RID: 96533 RVA: 0x00674254 File Offset: 0x00672454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateDecomposeEquipmentBackGold(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int i = bagComponentCommon.CalculateDecomposeEquipmentBackGold(equipment);
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

	// Token: 0x06017916 RID: 96534 RVA: 0x006742B8 File Offset: 0x006724B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSaveEnchantSaveMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bagComponentCommon.OnSaveEnchantSaveMissionEvent(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017917 RID: 96535 RVA: 0x00674310 File Offset: 0x00672510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bagComponentCommon.OnEnchantMissionEvent(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017918 RID: 96536 RVA: 0x00674368 File Offset: 0x00672568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateBagItemEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			bagComponentCommon.OnCreateBagItemEvent(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017919 RID: 96537 RVA: 0x006743C0 File Offset: 0x006725C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CountIncreaseBagSize(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> addBagItems;
			LuaObject.checkType<List<Goods>>(l, 2, out addBagItems);
			int i = bagComponentCommon.m_luaExportHelper.CountIncreaseBagSize(addBagItems);
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

	// Token: 0x0601791A RID: 96538 RVA: 0x00674428 File Offset: 0x00672628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CountDecreaseBagSize(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> deleteBagItems;
			LuaObject.checkType<List<Goods>>(l, 2, out deleteBagItems);
			int i = bagComponentCommon.m_luaExportHelper.CountDecreaseBagSize(deleteBagItems);
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

	// Token: 0x0601791B RID: 96539 RVA: 0x00674490 File Offset: 0x00672690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBagFullByGoodsOperation(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> addGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out addGoods);
			List<Goods> deleteGoods;
			LuaObject.checkType<List<Goods>>(l, 3, out deleteGoods);
			int addRandomRewardExpectSize;
			LuaObject.checkType(l, 4, out addRandomRewardExpectSize);
			bool b = bagComponentCommon.m_luaExportHelper.IsBagFullByGoodsOperation(addGoods, deleteGoods, addRandomRewardExpectSize);
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

	// Token: 0x0601791C RID: 96540 RVA: 0x00674514 File Offset: 0x00672714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBagFullByBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> addBagItems;
			LuaObject.checkType<List<Goods>>(l, 2, out addBagItems);
			List<Goods> deleteBagItems;
			LuaObject.checkType<List<Goods>>(l, 3, out deleteBagItems);
			int addRandomRewardExpectSize;
			LuaObject.checkType(l, 4, out addRandomRewardExpectSize);
			bool b = bagComponentCommon.m_luaExportHelper.IsBagFullByBagItems(addBagItems, deleteBagItems, addRandomRewardExpectSize);
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

	// Token: 0x0601791D RID: 96541 RVA: 0x00674598 File Offset: 0x00672798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsHeuristicBagFull(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> adds;
			LuaObject.checkType<List<Goods>>(l, 2, out adds);
			bool b = bagComponentCommon.m_luaExportHelper.IsHeuristicBagFull(adds);
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

	// Token: 0x0601791E RID: 96542 RVA: 0x00674600 File Offset: 0x00672800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FilterNonBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 2, out goods);
			List<Goods> o = bagComponentCommon.m_luaExportHelper.FilterNonBagItem(goods);
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

	// Token: 0x0601791F RID: 96543 RVA: 0x00674668 File Offset: 0x00672868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FilterNonBagItemsWhenAdd(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodsList);
			List<Goods> o = bagComponentCommon.m_luaExportHelper.FilterNonBagItemsWhenAdd(goodsList);
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

	// Token: 0x06017920 RID: 96544 RVA: 0x006746D0 File Offset: 0x006728D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TransformHeroGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			List<Goods> o = bagComponentCommon.m_luaExportHelper.TransformHeroGoods(heroId, nums);
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

	// Token: 0x06017921 RID: 96545 RVA: 0x00674744 File Offset: 0x00672944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveBagItemByItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out caseId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = bagComponentCommon.m_luaExportHelper.RemoveBagItemByItem(bagItem, consumeNums, caseId, location);
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

	// Token: 0x06017922 RID: 96546 RVA: 0x006747D4 File Offset: 0x006729D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelTicketsMax(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTicketLimitInfo ticketLimitInfo;
			LuaObject.checkType<ConfigDataTicketLimitInfo>(l, 2, out ticketLimitInfo);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			bool b = bagComponentCommon.m_luaExportHelper.IsLevelTicketsMax(ticketLimitInfo, contentId, nums);
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

	// Token: 0x06017923 RID: 96547 RVA: 0x00674858 File Offset: 0x00672A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsThisEquipmentType(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase equipment;
			LuaObject.checkType<BagItemBase>(l, 2, out equipment);
			EquipmentType type;
			LuaObject.checkEnum<EquipmentType>(l, 3, out type);
			bool b = bagComponentCommon.m_luaExportHelper.IsThisEquipmentType(equipment, type);
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

	// Token: 0x06017924 RID: 96548 RVA: 0x006748CC File Offset: 0x00672ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelUpEquipmentStarLevel(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bool b = bagComponentCommon.m_luaExportHelper.IsLevelUpEquipmentStarLevel(equipment);
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

	// Token: 0x06017925 RID: 96549 RVA: 0x00674934 File Offset: 0x00672B34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutEqipmentEnhanceOperateLog(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int preLevel;
			LuaObject.checkType(l, 3, out preLevel);
			int preExp;
			LuaObject.checkType(l, 4, out preExp);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			bagComponentCommon.m_luaExportHelper.OutPutEqipmentEnhanceOperateLog(equipment, preLevel, preExp, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017926 RID: 96550 RVA: 0x006749B8 File Offset: 0x00672BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutEquipmentUpgrageOperateLog(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			EquipmentBagItem material;
			LuaObject.checkType<EquipmentBagItem>(l, 3, out material);
			int preLvlLimit;
			LuaObject.checkType(l, 4, out preLvlLimit);
			int postLvlLimit;
			LuaObject.checkType(l, 5, out postLvlLimit);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 6, out costItems);
			bagComponentCommon.m_luaExportHelper.OutPutEquipmentUpgrageOperateLog(equipment, material, preLvlLimit, postLvlLimit, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017927 RID: 96551 RVA: 0x00674A48 File Offset: 0x00672C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddEquipmentExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			bagComponentCommon.m_luaExportHelper.AddEquipmentExp(equipment, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017928 RID: 96552 RVA: 0x00674AB4 File Offset: 0x00672CB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LevelUpEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bagComponentCommon.m_luaExportHelper.LevelUpEquipment(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017929 RID: 96553 RVA: 0x00674B10 File Offset: 0x00672D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEquipmentMaxExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bool b = bagComponentCommon.m_luaExportHelper.IsEquipmentMaxExp(equipment);
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

	// Token: 0x0601792A RID: 96554 RVA: 0x00674B78 File Offset: 0x00672D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEquipmentMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bool b = bagComponentCommon.m_luaExportHelper.IsEquipmentMaxLevel(equipment);
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

	// Token: 0x0601792B RID: 96555 RVA: 0x00674BE0 File Offset: 0x00672DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipmentLevelLimit(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int equipmentStarLevel;
			LuaObject.checkType(l, 2, out equipmentStarLevel);
			int equipmentLevelLimit = bagComponentCommon.m_luaExportHelper.GetEquipmentLevelLimit(equipmentStarLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentLevelLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601792C RID: 96556 RVA: 0x00674C48 File Offset: 0x00672E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLevelUpEquipmentStarItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int star;
			LuaObject.checkType(l, 2, out star);
			ConfigDataEquipmentInfo equipmentInfo;
			LuaObject.checkType<ConfigDataEquipmentInfo>(l, 3, out equipmentInfo);
			List<Goods> levelUpEquipmentStarItems = bagComponentCommon.m_luaExportHelper.GetLevelUpEquipmentStarItems(star, equipmentInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelUpEquipmentStarItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601792D RID: 96557 RVA: 0x00674CBC File Offset: 0x00672EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OutPutItemOperationLog(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			GoodsType itemTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out itemTypeId);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 5, out causeId);
			string location;
			LuaObject.checkType(l, 6, out location);
			bagComponentCommon.m_luaExportHelper.OutPutItemOperationLog(itemTypeId, itemId, nums, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601792E RID: 96558 RVA: 0x00674D4C File Offset: 0x00672F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_UseHeroExpItemMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__callDele_UseHeroExpItemMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601792F RID: 96559 RVA: 0x00674DA8 File Offset: 0x00672FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_UseHeroExpItemMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__clearDele_UseHeroExpItemMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017930 RID: 96560 RVA: 0x00674E04 File Offset: 0x00673004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EquipmentLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem obj;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__callDele_EquipmentLevelupMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017931 RID: 96561 RVA: 0x00674E60 File Offset: 0x00673060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EquipmentLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem obj;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__clearDele_EquipmentLevelupMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017932 RID: 96562 RVA: 0x00674EBC File Offset: 0x006730BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EnchantEquipmentPropertiesSaveMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem obj;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__callDele_EnchantEquipmentPropertiesSaveMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017933 RID: 96563 RVA: 0x00674F18 File Offset: 0x00673118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EnchantEquipmentPropertiesSaveMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem obj;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__clearDele_EnchantEquipmentPropertiesSaveMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017934 RID: 96564 RVA: 0x00674F74 File Offset: 0x00673174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EnchantEquipmentsMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem obj;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__callDele_EnchantEquipmentsMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017935 RID: 96565 RVA: 0x00674FD0 File Offset: 0x006731D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EnchantEquipmentsMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem obj;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__clearDele_EnchantEquipmentsMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017936 RID: 96566 RVA: 0x0067502C File Offset: 0x0067322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CreateBagItemEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase obj;
			LuaObject.checkType<BagItemBase>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__callDele_CreateBagItemEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017937 RID: 96567 RVA: 0x00675088 File Offset: 0x00673288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CreateBagItemEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemBase obj;
			LuaObject.checkType<BagItemBase>(l, 2, out obj);
			bagComponentCommon.m_luaExportHelper.__clearDele_CreateBagItemEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017938 RID: 96568 RVA: 0x006750E4 File Offset: 0x006732E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UseHeroExpItemMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagComponentCommon.UseHeroExpItemMissionEvent += value;
				}
				else if (num == 2)
				{
					bagComponentCommon.UseHeroExpItemMissionEvent -= value;
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

	// Token: 0x06017939 RID: 96569 RVA: 0x00675164 File Offset: 0x00673364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagDS(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_bagDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601793A RID: 96570 RVA: 0x006751BC File Offset: 0x006733BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagDS(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			DataSectionBag bagDS;
			LuaObject.checkType<DataSectionBag>(l, 2, out bagDS);
			bagComponentCommon.m_luaExportHelper.m_bagDS = bagDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601793B RID: 96571 RVA: 0x00675218 File Offset: 0x00673418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601793C RID: 96572 RVA: 0x00675270 File Offset: 0x00673470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			bagComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601793D RID: 96573 RVA: 0x006752CC File Offset: 0x006734CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601793E RID: 96574 RVA: 0x00675324 File Offset: 0x00673524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			bagComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601793F RID: 96575 RVA: 0x00675380 File Offset: 0x00673580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017940 RID: 96576 RVA: 0x006753D8 File Offset: 0x006735D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			bagComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017941 RID: 96577 RVA: 0x00675434 File Offset: 0x00673634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017942 RID: 96578 RVA: 0x0067548C File Offset: 0x0067368C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			bagComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017943 RID: 96579 RVA: 0x006754E8 File Offset: 0x006736E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagItemFactory(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_bagItemFactory);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017944 RID: 96580 RVA: 0x00675540 File Offset: 0x00673740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bagItemFactory(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			BagItemFactory bagItemFactory;
			LuaObject.checkType<BagItemFactory>(l, 2, out bagItemFactory);
			bagComponentCommon.m_luaExportHelper.m_bagItemFactory = bagItemFactory;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017945 RID: 96581 RVA: 0x0067559C File Offset: 0x0067379C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enhanceEquipmentMaterialExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.m_luaExportHelper.m_enhanceEquipmentMaterialExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017946 RID: 96582 RVA: 0x006755F4 File Offset: 0x006737F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enhanceEquipmentMaterialExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			int enhanceEquipmentMaterialExp;
			LuaObject.checkType(l, 2, out enhanceEquipmentMaterialExp);
			bagComponentCommon.m_luaExportHelper.m_enhanceEquipmentMaterialExp = enhanceEquipmentMaterialExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017947 RID: 96583 RVA: 0x00675650 File Offset: 0x00673850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EquipmentLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			Action<EquipmentBagItem> value;
			int num = LuaObject.checkDelegate<Action<EquipmentBagItem>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagComponentCommon.EquipmentLevelupMissionEvent += value;
				}
				else if (num == 2)
				{
					bagComponentCommon.EquipmentLevelupMissionEvent -= value;
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

	// Token: 0x06017948 RID: 96584 RVA: 0x006756D0 File Offset: 0x006738D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnchantEquipmentPropertiesSaveMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			Action<EquipmentBagItem> value;
			int num = LuaObject.checkDelegate<Action<EquipmentBagItem>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagComponentCommon.EnchantEquipmentPropertiesSaveMissionEvent += value;
				}
				else if (num == 2)
				{
					bagComponentCommon.EnchantEquipmentPropertiesSaveMissionEvent -= value;
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

	// Token: 0x06017949 RID: 96585 RVA: 0x00675750 File Offset: 0x00673950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnchantEquipmentsMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			Action<EquipmentBagItem> value;
			int num = LuaObject.checkDelegate<Action<EquipmentBagItem>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagComponentCommon.EnchantEquipmentsMissionEvent += value;
				}
				else if (num == 2)
				{
					bagComponentCommon.EnchantEquipmentsMissionEvent -= value;
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

	// Token: 0x0601794A RID: 96586 RVA: 0x006757D0 File Offset: 0x006739D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CreateBagItemEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			Action<BagItemBase> value;
			int num = LuaObject.checkDelegate<Action<BagItemBase>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagComponentCommon.CreateBagItemEvent += value;
				}
				else if (num == 2)
				{
					bagComponentCommon.CreateBagItemEvent -= value;
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

	// Token: 0x0601794B RID: 96587 RVA: 0x00675850 File Offset: 0x00673A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601794C RID: 96588 RVA: 0x006758A4 File Offset: 0x00673AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			BagComponentCommon bagComponentCommon = (BagComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			bagComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601794D RID: 96589 RVA: 0x006758FC File Offset: 0x00673AFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BagComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsGoodsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.ConsumeGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagFullByRandomGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagFullByGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.GetBagSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagFullByCurrentSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagItemContentIdInConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.RemoveAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.RemoveBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.RemoveBagItemByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.RemoveBagItemByInstanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.RemoveBagItemDirectly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FindBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FindBagItemByInstanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FindBagItemByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FindUseableBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.GetAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IterateAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FindEnoughBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.UseBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.UseBagItemDirectly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.HasEnoughBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagItemEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.GetTicketId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsLevelTicketsMaxByUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.SellBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CombineSameGoodsAndReplaceExistHeroToFragment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanDecomposeBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanDecomposeABagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.SetBagItemDirty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsPercentBaseBattleProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanLockAndUnLockEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.LockAndUnLockEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanEnhanceEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanWearEquipmentByEquipmentType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CalculateEnhanceEquipmentExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CalculateEnhanceEquipmentGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.EnhanceEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanEnchantEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CaculateEquipmentNextLevelExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CanLevelUpEquipmentStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CalculateLevelUpEquipmentStarGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.LevelUpEquipmentStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CalculateEquipmentTotalExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CalculateDecomposeEquipmentBackGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.OnSaveEnchantSaveMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.OnEnchantMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.OnCreateBagItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CountIncreaseBagSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.CountDecreaseBagSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagFullByGoodsOperation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsBagFullByBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsHeuristicBagFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FilterNonBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.FilterNonBagItemsWhenAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.TransformHeroGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.RemoveBagItemByItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsLevelTicketsMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsThisEquipmentType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsLevelUpEquipmentStarLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.OutPutEqipmentEnhanceOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.OutPutEquipmentUpgrageOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.AddEquipmentExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.LevelUpEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsEquipmentMaxExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.IsEquipmentMaxLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.GetEquipmentLevelLimit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.GetLevelUpEquipmentStarItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.OutPutItemOperationLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__callDele_UseHeroExpItemMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__clearDele_UseHeroExpItemMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__callDele_EquipmentLevelupMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__clearDele_EquipmentLevelupMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__callDele_EnchantEquipmentPropertiesSaveMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__clearDele_EnchantEquipmentPropertiesSaveMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__callDele_EnchantEquipmentsMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__clearDele_EnchantEquipmentsMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__callDele_CreateBagItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.__clearDele_CreateBagItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache55);
		string name = "UseHeroExpItemMissionEvent";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_UseHeroExpItemMissionEvent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache56, true);
		string name2 = "m_bagDS";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_bagDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_bagDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache58, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5A, true);
		string name4 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_resource);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5C, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5E, true);
		string name6 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache60, true);
		string name7 = "m_bagItemFactory";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_bagItemFactory);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_bagItemFactory);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache62, true);
		string name8 = "m_enhanceEquipmentMaterialExp";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_m_enhanceEquipmentMaterialExp);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_m_enhanceEquipmentMaterialExp);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache64, true);
		string name9 = "EquipmentLevelupMissionEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_EquipmentLevelupMissionEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache65, true);
		string name10 = "EnchantEquipmentPropertiesSaveMissionEvent";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_EnchantEquipmentPropertiesSaveMissionEvent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache66, true);
		string name11 = "EnchantEquipmentsMissionEvent";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_EnchantEquipmentsMissionEvent);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache67, true);
		string name12 = "CreateBagItemEvent";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_CreateBagItemEvent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache68, true);
		string name13 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.get_Owner);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6A, true);
		if (Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BagComponentCommon.<>f__mg$cache6B, typeof(BagComponentCommon));
	}

	// Token: 0x0400DF3B RID: 57147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DF3C RID: 57148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DF3D RID: 57149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DF3E RID: 57150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DF3F RID: 57151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DF40 RID: 57152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DF41 RID: 57153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DF42 RID: 57154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DF43 RID: 57155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DF44 RID: 57156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DF45 RID: 57157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DF46 RID: 57158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DF47 RID: 57159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DF48 RID: 57160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DF49 RID: 57161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DF4A RID: 57162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DF4B RID: 57163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DF4C RID: 57164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DF4D RID: 57165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DF4E RID: 57166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DF4F RID: 57167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DF50 RID: 57168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DF51 RID: 57169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DF52 RID: 57170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DF53 RID: 57171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DF54 RID: 57172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DF55 RID: 57173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DF56 RID: 57174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DF57 RID: 57175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DF58 RID: 57176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DF59 RID: 57177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DF5A RID: 57178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DF5B RID: 57179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DF5C RID: 57180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DF5D RID: 57181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DF5E RID: 57182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DF5F RID: 57183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DF60 RID: 57184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DF61 RID: 57185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DF62 RID: 57186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DF63 RID: 57187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DF64 RID: 57188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DF65 RID: 57189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DF66 RID: 57190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DF67 RID: 57191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DF68 RID: 57192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DF69 RID: 57193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DF6A RID: 57194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DF6B RID: 57195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DF6C RID: 57196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DF6D RID: 57197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DF6E RID: 57198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DF6F RID: 57199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DF70 RID: 57200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DF71 RID: 57201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DF72 RID: 57202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DF73 RID: 57203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DF74 RID: 57204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DF75 RID: 57205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DF76 RID: 57206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DF77 RID: 57207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DF78 RID: 57208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DF79 RID: 57209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DF7A RID: 57210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DF7B RID: 57211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400DF7C RID: 57212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400DF7D RID: 57213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400DF7E RID: 57214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400DF7F RID: 57215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400DF80 RID: 57216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400DF81 RID: 57217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400DF82 RID: 57218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400DF83 RID: 57219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400DF84 RID: 57220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400DF85 RID: 57221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400DF86 RID: 57222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400DF87 RID: 57223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400DF88 RID: 57224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400DF89 RID: 57225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400DF8A RID: 57226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400DF8B RID: 57227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400DF8C RID: 57228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400DF8D RID: 57229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400DF8E RID: 57230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400DF8F RID: 57231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400DF90 RID: 57232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400DF91 RID: 57233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400DF92 RID: 57234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400DF93 RID: 57235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400DF94 RID: 57236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400DF95 RID: 57237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400DF96 RID: 57238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400DF97 RID: 57239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400DF98 RID: 57240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400DF99 RID: 57241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400DF9A RID: 57242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400DF9B RID: 57243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400DF9C RID: 57244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400DF9D RID: 57245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400DF9E RID: 57246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400DF9F RID: 57247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400DFA0 RID: 57248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400DFA1 RID: 57249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400DFA2 RID: 57250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400DFA3 RID: 57251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400DFA4 RID: 57252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400DFA5 RID: 57253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400DFA6 RID: 57254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;
}
