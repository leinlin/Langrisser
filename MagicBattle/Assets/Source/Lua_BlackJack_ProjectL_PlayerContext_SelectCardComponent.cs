using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E2 RID: 4834
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent : LuaObject
{
	// Token: 0x0601A040 RID: 106560 RVA: 0x007A1884 File Offset: 0x0079FA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent o = new SelectCardComponent();
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

	// Token: 0x0601A041 RID: 106561 RVA: 0x007A18CC File Offset: 0x0079FACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A042 RID: 106562 RVA: 0x007A1918 File Offset: 0x0079FB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A043 RID: 106563 RVA: 0x007A1964 File Offset: 0x0079FB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A044 RID: 106564 RVA: 0x007A19B0 File Offset: 0x0079FBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			DSSelectCardNtf msg;
			LuaObject.checkType<DSSelectCardNtf>(l, 2, out msg);
			selectCardComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A045 RID: 106565 RVA: 0x007A1A08 File Offset: 0x0079FC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActivityCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			List<CardPool> activityCardPool = selectCardComponent.GetActivityCardPool();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityCardPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A046 RID: 106566 RVA: 0x007A1A5C File Offset: 0x0079FC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool isUsingTicket;
			LuaObject.checkType(l, 4, out isUsingTicket);
			int guaranteedAccumulatedValue;
			LuaObject.checkType(l, 5, out guaranteedAccumulatedValue);
			int guaranteedSelectCardCount;
			LuaObject.checkType(l, 6, out guaranteedSelectCardCount);
			selectCardComponent.SelectCard(cardPoolId, isSingleSelect, isUsingTicket, guaranteedAccumulatedValue, guaranteedSelectCardCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A047 RID: 106567 RVA: 0x007A1AE8 File Offset: 0x0079FCE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActivityTimeByPoolId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			string activityTimeByPoolId = selectCardComponent.GetActivityTimeByPoolId(poolId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityTimeByPoolId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A048 RID: 106568 RVA: 0x007A1B4C File Offset: 0x0079FD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool isUsingTickets;
			LuaObject.checkType(l, 4, out isUsingTickets);
			int i = selectCardComponent.CanSelectCard(cardPoolId, isSingleSelect, isUsingTickets);
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

	// Token: 0x0601A049 RID: 106569 RVA: 0x007A1BC8 File Offset: 0x0079FDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			ushort dsversion = selectCardComponent.GetDSVersion();
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

	// Token: 0x0601A04A RID: 106570 RVA: 0x007A1C1C File Offset: 0x0079FE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			string s = selectCardComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601A04B RID: 106571 RVA: 0x007A1C78 File Offset: 0x0079FE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A04C RID: 106572 RVA: 0x007A1CCC File Offset: 0x0079FECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A04D RID: 106573 RVA: 0x007A1D20 File Offset: 0x0079FF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A04E RID: 106574 RVA: 0x007A1D74 File Offset: 0x0079FF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			selectCardComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A04F RID: 106575 RVA: 0x007A1DD0 File Offset: 0x0079FFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			selectCardComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A050 RID: 106576 RVA: 0x007A1E24 File Offset: 0x007A0024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int cardPool;
			LuaObject.checkType(l, 2, out cardPool);
			selectCardComponent.m_luaExportHelper.__callBase_RemoveCardPool(cardPool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A051 RID: 106577 RVA: 0x007A1E80 File Offset: 0x007A0080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitCardPoolConfigs(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			List<CardPool> cardPools;
			LuaObject.checkType<List<CardPool>>(l, 2, out cardPools);
			selectCardComponent.m_luaExportHelper.__callBase_InitCardPoolConfigs(cardPools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A052 RID: 106578 RVA: 0x007A1EDC File Offset: 0x007A00DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsActivityCardPoolOnActivityTime(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			int i = selectCardComponent.m_luaExportHelper.__callBase_IsActivityCardPoolOnActivityTime(activityCardPoolId);
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

	// Token: 0x0601A053 RID: 106579 RVA: 0x007A1F44 File Offset: 0x007A0144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindOperationalActivityByActivityCardPoolId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			OperationalActivityBase o = selectCardComponent.m_luaExportHelper.__callBase_FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
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

	// Token: 0x0601A054 RID: 106580 RVA: 0x007A1FAC File Offset: 0x007A01AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllOpenActivityCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			List<int> o = selectCardComponent.m_luaExportHelper.__callBase_GetAllOpenActivityCardPool();
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

	// Token: 0x0601A055 RID: 106581 RVA: 0x007A2008 File Offset: 0x007A0208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsUsedOutActivityCardPoolSelectOpportunity(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool b = selectCardComponent.m_luaExportHelper.__callBase_IsUsedOutActivityCardPoolSelectOpportunity(cardPool);
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

	// Token: 0x0601A056 RID: 106582 RVA: 0x007A2070 File Offset: 0x007A0270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCardPoolById(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool ignoreActivityCheck;
			LuaObject.checkType(l, 3, out ignoreActivityCheck);
			CardPool o = selectCardComponent.m_luaExportHelper.__callBase_GetCardPoolById(cardPoolId, ignoreActivityCheck);
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

	// Token: 0x0601A057 RID: 106583 RVA: 0x007A20E4 File Offset: 0x007A02E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsTicketsEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int ticketId;
			LuaObject.checkType(l, 2, out ticketId);
			int ticketCount;
			LuaObject.checkType(l, 3, out ticketCount);
			bool b = selectCardComponent.m_luaExportHelper.__callBase_IsTicketsEnough(ticketId, ticketCount);
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

	// Token: 0x0601A058 RID: 106584 RVA: 0x007A2158 File Offset: 0x007A0358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCrystalCount(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool b;
			int i = selectCardComponent.m_luaExportHelper.__callBase_GetCrystalCount(cardPool, isSingleSelect, out b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, b);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A059 RID: 106585 RVA: 0x007A21D8 File Offset: 0x007A03D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SelectCardUseTickets(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			selectCardComponent.m_luaExportHelper.__callBase_SelectCardUseTickets(cardPool, isSingleSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A05A RID: 106586 RVA: 0x007A2244 File Offset: 0x007A0444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SelectCardUseCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			selectCardComponent.m_luaExportHelper.__callBase_SelectCardUseCrystal(cardPool, isSingleSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A05B RID: 106587 RVA: 0x007A22B0 File Offset: 0x007A04B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool isUsingTickets;
			LuaObject.checkType(l, 4, out isUsingTickets);
			int i = selectCardComponent.m_luaExportHelper.__callBase_CanSelectCard(cardPool, isSingleSelect, isUsingTickets);
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

	// Token: 0x0601A05C RID: 106588 RVA: 0x007A2334 File Offset: 0x007A0534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCrystalOrActivityCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPoolType cardPoolType;
			LuaObject.checkEnum<CardPoolType>(l, 2, out cardPoolType);
			bool b = selectCardComponent.m_luaExportHelper.__callBase_IsCrystalOrActivityCardPool(cardPoolType);
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

	// Token: 0x0601A05D RID: 106589 RVA: 0x007A239C File Offset: 0x007A059C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanUseTicketSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			int ticketNums;
			LuaObject.checkType(l, 3, out ticketNums);
			int i = selectCardComponent.m_luaExportHelper.__callBase_CanUseTicketSelectCard(cardPool, ticketNums);
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

	// Token: 0x0601A05E RID: 106590 RVA: 0x007A2410 File Offset: 0x007A0610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SelectCardSpendTicketsOrCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool isUsingTickets;
			LuaObject.checkType(l, 4, out isUsingTickets);
			selectCardComponent.m_luaExportHelper.__callBase_SelectCardSpendTicketsOrCrystal(cardPool, isSingleSelect, isUsingTickets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A05F RID: 106591 RVA: 0x007A2488 File Offset: 0x007A0688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SelectHeroCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponent selectCardComponent = (SelectCardComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			selectCardComponent.m_luaExportHelper.__callBase_SelectHeroCard(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A060 RID: 106592 RVA: 0x007A24E4 File Offset: 0x007A06E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.SelectCardComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.GetActivityCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.SelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.GetActivityTimeByPoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.CanSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_RemoveCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_InitCardPoolConfigs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_IsActivityCardPoolOnActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_FindOperationalActivityByActivityCardPoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_GetAllOpenActivityCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_IsUsedOutActivityCardPoolSelectOpportunity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_GetCardPoolById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_IsTicketsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_GetCrystalCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_SelectCardUseTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_SelectCardUseCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_CanSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_IsCrystalOrActivityCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_CanUseTicketSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_SelectCardSpendTicketsOrCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.__callBase_SelectHeroCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.<>f__mg$cache1F, typeof(SelectCardComponent), typeof(SelectCardComponentCommon));
	}

	// Token: 0x0401045E RID: 66654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401045F RID: 66655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010460 RID: 66656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010461 RID: 66657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010462 RID: 66658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010463 RID: 66659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010464 RID: 66660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010465 RID: 66661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010466 RID: 66662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010467 RID: 66663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010468 RID: 66664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010469 RID: 66665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401046A RID: 66666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401046B RID: 66667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401046C RID: 66668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401046D RID: 66669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401046E RID: 66670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401046F RID: 66671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010470 RID: 66672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010471 RID: 66673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010472 RID: 66674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010473 RID: 66675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010474 RID: 66676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010475 RID: 66677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010476 RID: 66678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010477 RID: 66679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010478 RID: 66680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010479 RID: 66681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401047A RID: 66682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401047B RID: 66683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401047C RID: 66684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401047D RID: 66685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
