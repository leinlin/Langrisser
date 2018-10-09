using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001260 RID: 4704
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RaffleComponentCommon : LuaObject
{
	// Token: 0x06018879 RID: 100473 RVA: 0x006E6A74 File Offset: 0x006E4C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon o = new RaffleComponentCommon();
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

	// Token: 0x0601887A RID: 100474 RVA: 0x006E6ABC File Offset: 0x006E4CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			string name = raffleComponentCommon.GetName();
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

	// Token: 0x0601887B RID: 100475 RVA: 0x006E6B10 File Offset: 0x006E4D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			raffleComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601887C RID: 100476 RVA: 0x006E6B5C File Offset: 0x006E4D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			raffleComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601887D RID: 100477 RVA: 0x006E6BA8 File Offset: 0x006E4DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			raffleComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601887E RID: 100478 RVA: 0x006E6BF4 File Offset: 0x006E4DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			raffleComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601887F RID: 100479 RVA: 0x006E6C4C File Offset: 0x006E4E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			raffleComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018880 RID: 100480 RVA: 0x006E6C98 File Offset: 0x006E4E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveRafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			raffleComponentCommon.RemoveRafflePool(poolId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018881 RID: 100481 RVA: 0x006E6CF0 File Offset: 0x006E4EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRafflePoolOnActivityTime(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			int rafflePoolId;
			LuaObject.checkType(l, 2, out rafflePoolId);
			int i = raffleComponentCommon.IsRafflePoolOnActivityTime(rafflePoolId);
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

	// Token: 0x06018882 RID: 100482 RVA: 0x006E6D54 File Offset: 0x006E4F54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOperationalActivityByRafflePoolId(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			OperationalActivityBase o = raffleComponentCommon.FindOperationalActivityByRafflePoolId(activityCardPoolId);
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

	// Token: 0x06018883 RID: 100483 RVA: 0x006E6DB8 File Offset: 0x006E4FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllOpenActivityRafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			List<int> allOpenActivityRafflePool = raffleComponentCommon.GetAllOpenActivityRafflePool();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allOpenActivityRafflePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018884 RID: 100484 RVA: 0x006E6E0C File Offset: 0x006E500C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			RafflePool rafflePool = raffleComponentCommon.GetRafflePool(poolId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018885 RID: 100485 RVA: 0x006E6E70 File Offset: 0x006E5070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaffleItemsAllDrawed(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			bool b = raffleComponentCommon.IsRaffleItemsAllDrawed(pool);
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

	// Token: 0x06018886 RID: 100486 RVA: 0x006E6ED4 File Offset: 0x006E50D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsDrawItemsEnough(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int drawItemId;
			LuaObject.checkType(l, 3, out drawItemId);
			int count;
			LuaObject.checkType(l, 4, out count);
			bool b = raffleComponentCommon.IsDrawItemsEnough(goodsType, drawItemId, count);
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

	// Token: 0x06018887 RID: 100487 RVA: 0x006E6F50 File Offset: 0x006E5150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDrawItemCost(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int drawItemCost = raffleComponentCommon.GetDrawItemCost(pool);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drawItemCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018888 RID: 100488 RVA: 0x006E6FB4 File Offset: 0x006E51B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanFreeDraw(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			bool b = raffleComponentCommon.CanFreeDraw(pool);
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

	// Token: 0x06018889 RID: 100489 RVA: 0x006E7018 File Offset: 0x006E5218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanDraw(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			int i = raffleComponentCommon.CanDraw(poolId);
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

	// Token: 0x0601888A RID: 100490 RVA: 0x006E707C File Offset: 0x006E527C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRaffleItem(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int raffleId;
			LuaObject.checkType(l, 3, out raffleId);
			RaffleItem raffleItem = raffleComponentCommon.GetRaffleItem(pool, raffleId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601888B RID: 100491 RVA: 0x006E70EC File Offset: 0x006E52EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFreeDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int freeDrawedCount = raffleComponentCommon.GetFreeDrawedCount(pool);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, freeDrawedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601888C RID: 100492 RVA: 0x006E7150 File Offset: 0x006E5350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int drawedCount = raffleComponentCommon.GetDrawedCount(pool);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drawedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601888D RID: 100493 RVA: 0x006E71B4 File Offset: 0x006E53B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int allDrawedCount = raffleComponentCommon.GetAllDrawedCount(pool);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allDrawedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601888E RID: 100494 RVA: 0x006E7218 File Offset: 0x006E5418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitRafflePoolConfigs(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			List<RafflePool> rafflePools;
			LuaObject.checkType<List<RafflePool>>(l, 2, out rafflePools);
			raffleComponentCommon.m_luaExportHelper.InitRafflePoolConfigs(rafflePools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601888F RID: 100495 RVA: 0x006E7274 File Offset: 0x006E5474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrawCostItem(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			int raffleId;
			LuaObject.checkType(l, 3, out raffleId);
			raffleComponentCommon.m_luaExportHelper.DrawCostItem(rafflePool, raffleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018890 RID: 100496 RVA: 0x006E72E0 File Offset: 0x006E54E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018891 RID: 100497 RVA: 0x006E7338 File Offset: 0x006E5538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			raffleComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018892 RID: 100498 RVA: 0x006E7394 File Offset: 0x006E5594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018893 RID: 100499 RVA: 0x006E73EC File Offset: 0x006E55EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			raffleComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018894 RID: 100500 RVA: 0x006E7448 File Offset: 0x006E5648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018895 RID: 100501 RVA: 0x006E74A0 File Offset: 0x006E56A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			raffleComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018896 RID: 100502 RVA: 0x006E74FC File Offset: 0x006E56FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_operationalActivity(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleComponentCommon.m_luaExportHelper.m_operationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018897 RID: 100503 RVA: 0x006E7554 File Offset: 0x006E5754
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_operationalActivity(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			OperationalActivityCompomentCommon operationalActivity;
			LuaObject.checkType<OperationalActivityCompomentCommon>(l, 2, out operationalActivity);
			raffleComponentCommon.m_luaExportHelper.m_operationalActivity = operationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018898 RID: 100504 RVA: 0x006E75B0 File Offset: 0x006E57B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_RaffleDS(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleComponentCommon.m_luaExportHelper.m_RaffleDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018899 RID: 100505 RVA: 0x006E7608 File Offset: 0x006E5808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_RaffleDS(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			DataSectionRaffle raffleDS;
			LuaObject.checkType<DataSectionRaffle>(l, 2, out raffleDS);
			raffleComponentCommon.m_luaExportHelper.m_RaffleDS = raffleDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601889A RID: 100506 RVA: 0x006E7664 File Offset: 0x006E5864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601889B RID: 100507 RVA: 0x006E76B8 File Offset: 0x006E58B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponentCommon raffleComponentCommon = (RaffleComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			raffleComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601889C RID: 100508 RVA: 0x006E7710 File Offset: 0x006E5910
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RaffleComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.RemoveRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.IsRafflePoolOnActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.FindOperationalActivityByRafflePoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetAllOpenActivityRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.IsRaffleItemsAllDrawed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.IsDrawItemsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetDrawItemCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.CanFreeDraw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.CanDraw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetRaffleItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetFreeDrawedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetDrawedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.GetAllDrawedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.InitRafflePoolConfigs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.DrawCostItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache15);
		string name = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache17, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache19, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1B, true);
		string name4 = "m_operationalActivity";
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.get_m_operationalActivity);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.set_m_operationalActivity);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1D, true);
		string name5 = "m_RaffleDS";
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.get_m_RaffleDS);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.set_m_RaffleDS);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache1F, true);
		string name6 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.get_Owner);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache21, true);
		if (Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.<>f__mg$cache22, typeof(RaffleComponentCommon));
	}

	// Token: 0x0400ED9B RID: 60827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED9C RID: 60828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED9D RID: 60829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED9E RID: 60830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ED9F RID: 60831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EDA0 RID: 60832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EDA1 RID: 60833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EDA2 RID: 60834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EDA3 RID: 60835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EDA4 RID: 60836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EDA5 RID: 60837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EDA6 RID: 60838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EDA7 RID: 60839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EDA8 RID: 60840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EDA9 RID: 60841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EDAA RID: 60842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EDAB RID: 60843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EDAC RID: 60844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EDAD RID: 60845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EDAE RID: 60846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EDAF RID: 60847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EDB0 RID: 60848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EDB1 RID: 60849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EDB2 RID: 60850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EDB3 RID: 60851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EDB4 RID: 60852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EDB5 RID: 60853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EDB6 RID: 60854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EDB7 RID: 60855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EDB8 RID: 60856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EDB9 RID: 60857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EDBA RID: 60858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EDBB RID: 60859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EDBC RID: 60860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EDBD RID: 60861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
