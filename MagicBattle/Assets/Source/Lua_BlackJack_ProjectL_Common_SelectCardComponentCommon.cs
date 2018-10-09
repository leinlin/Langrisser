using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200127B RID: 4731
[Preserve]
public class Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon : LuaObject
{
	// Token: 0x06018A73 RID: 100979 RVA: 0x006F4CBC File Offset: 0x006F2EBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon o = new SelectCardComponentCommon();
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

	// Token: 0x06018A74 RID: 100980 RVA: 0x006F4D04 File Offset: 0x006F2F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			string name = selectCardComponentCommon.GetName();
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

	// Token: 0x06018A75 RID: 100981 RVA: 0x006F4D58 File Offset: 0x006F2F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			selectCardComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A76 RID: 100982 RVA: 0x006F4DA4 File Offset: 0x006F2FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			selectCardComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A77 RID: 100983 RVA: 0x006F4DF0 File Offset: 0x006F2FF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			selectCardComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A78 RID: 100984 RVA: 0x006F4E3C File Offset: 0x006F303C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			selectCardComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A79 RID: 100985 RVA: 0x006F4E94 File Offset: 0x006F3094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			selectCardComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A7A RID: 100986 RVA: 0x006F4EE0 File Offset: 0x006F30E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int cardPool;
			LuaObject.checkType(l, 2, out cardPool);
			selectCardComponentCommon.RemoveCardPool(cardPool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A7B RID: 100987 RVA: 0x006F4F38 File Offset: 0x006F3138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActivityCardPoolOnActivityTime(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			int i = selectCardComponentCommon.IsActivityCardPoolOnActivityTime(activityCardPoolId);
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

	// Token: 0x06018A7C RID: 100988 RVA: 0x006F4F9C File Offset: 0x006F319C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOperationalActivityByActivityCardPoolId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			OperationalActivityBase o = selectCardComponentCommon.FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
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

	// Token: 0x06018A7D RID: 100989 RVA: 0x006F5000 File Offset: 0x006F3200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllOpenActivityCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			List<int> allOpenActivityCardPool = selectCardComponentCommon.GetAllOpenActivityCardPool();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allOpenActivityCardPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A7E RID: 100990 RVA: 0x006F5054 File Offset: 0x006F3254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCardPoolById(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool ignoreActivityCheck;
			LuaObject.checkType(l, 3, out ignoreActivityCheck);
			CardPool cardPoolById = selectCardComponentCommon.GetCardPoolById(cardPoolId, ignoreActivityCheck);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPoolById);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A7F RID: 100991 RVA: 0x006F50C4 File Offset: 0x006F32C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCrystalCount(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool b;
			int crystalCount = selectCardComponentCommon.GetCrystalCount(cardPool, isSingleSelect, out b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crystalCount);
			LuaObject.pushValue(l, b);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A80 RID: 100992 RVA: 0x006F5140 File Offset: 0x006F3340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SelectHeroCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			selectCardComponentCommon.SelectHeroCard(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A81 RID: 100993 RVA: 0x006F5198 File Offset: 0x006F3398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitCardPoolConfigs(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			List<CardPool> cardPools;
			LuaObject.checkType<List<CardPool>>(l, 2, out cardPools);
			selectCardComponentCommon.m_luaExportHelper.InitCardPoolConfigs(cardPools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A82 RID: 100994 RVA: 0x006F51F4 File Offset: 0x006F33F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUsedOutActivityCardPoolSelectOpportunity(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool b = selectCardComponentCommon.m_luaExportHelper.IsUsedOutActivityCardPoolSelectOpportunity(cardPool);
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

	// Token: 0x06018A83 RID: 100995 RVA: 0x006F525C File Offset: 0x006F345C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTicketsEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int ticketId;
			LuaObject.checkType(l, 2, out ticketId);
			int ticketCount;
			LuaObject.checkType(l, 3, out ticketCount);
			bool b = selectCardComponentCommon.m_luaExportHelper.IsTicketsEnough(ticketId, ticketCount);
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

	// Token: 0x06018A84 RID: 100996 RVA: 0x006F52D0 File Offset: 0x006F34D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUseTickets(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			selectCardComponentCommon.m_luaExportHelper.SelectCardUseTickets(cardPool, isSingleSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A85 RID: 100997 RVA: 0x006F533C File Offset: 0x006F353C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUseCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			selectCardComponentCommon.m_luaExportHelper.SelectCardUseCrystal(cardPool, isSingleSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A86 RID: 100998 RVA: 0x006F53A8 File Offset: 0x006F35A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool isUsingTickets;
			LuaObject.checkType(l, 4, out isUsingTickets);
			int i = selectCardComponentCommon.m_luaExportHelper.CanSelectCard(cardPool, isSingleSelect, isUsingTickets);
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

	// Token: 0x06018A87 RID: 100999 RVA: 0x006F542C File Offset: 0x006F362C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsCrystalOrActivityCardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPoolType cardPoolType;
			LuaObject.checkEnum<CardPoolType>(l, 2, out cardPoolType);
			bool b = selectCardComponentCommon.m_luaExportHelper.IsCrystalOrActivityCardPool(cardPoolType);
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

	// Token: 0x06018A88 RID: 101000 RVA: 0x006F5494 File Offset: 0x006F3694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUseTicketSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			int ticketNums;
			LuaObject.checkType(l, 3, out ticketNums);
			int i = selectCardComponentCommon.m_luaExportHelper.CanUseTicketSelectCard(cardPool, ticketNums);
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

	// Token: 0x06018A89 RID: 101001 RVA: 0x006F5508 File Offset: 0x006F3708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectCardFinished(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			selectCardComponentCommon.m_luaExportHelper.OnSelectCardFinished(cardPoolId, isSingleSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A8A RID: 101002 RVA: 0x006F5574 File Offset: 0x006F3774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardSpendTicketsOrCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool isSingleSelect;
			LuaObject.checkType(l, 3, out isSingleSelect);
			bool isUsingTickets;
			LuaObject.checkType(l, 4, out isUsingTickets);
			selectCardComponentCommon.m_luaExportHelper.SelectCardSpendTicketsOrCrystal(cardPool, isSingleSelect, isUsingTickets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A8B RID: 101003 RVA: 0x006F55EC File Offset: 0x006F37EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_SelectCardMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			selectCardComponentCommon.m_luaExportHelper.__callDele_SelectCardMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A8C RID: 101004 RVA: 0x006F5658 File Offset: 0x006F3858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_SelectCardMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			selectCardComponentCommon.m_luaExportHelper.__clearDele_SelectCardMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A8D RID: 101005 RVA: 0x006F56C4 File Offset: 0x006F38C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_SummonHeroMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			selectCardComponentCommon.m_luaExportHelper.__callDele_SummonHeroMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A8E RID: 101006 RVA: 0x006F5720 File Offset: 0x006F3920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_SummonHeroMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			selectCardComponentCommon.m_luaExportHelper.__clearDele_SummonHeroMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A8F RID: 101007 RVA: 0x006F577C File Offset: 0x006F397C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A90 RID: 101008 RVA: 0x006F57D4 File Offset: 0x006F39D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			selectCardComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A91 RID: 101009 RVA: 0x006F5830 File Offset: 0x006F3A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A92 RID: 101010 RVA: 0x006F5888 File Offset: 0x006F3A88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			selectCardComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A93 RID: 101011 RVA: 0x006F58E4 File Offset: 0x006F3AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A94 RID: 101012 RVA: 0x006F593C File Offset: 0x006F3B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			selectCardComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A95 RID: 101013 RVA: 0x006F5998 File Offset: 0x006F3B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_operationalActivity(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardComponentCommon.m_luaExportHelper.m_operationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A96 RID: 101014 RVA: 0x006F59F0 File Offset: 0x006F3BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_operationalActivity(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			OperationalActivityCompomentCommon operationalActivity;
			LuaObject.checkType<OperationalActivityCompomentCommon>(l, 2, out operationalActivity);
			selectCardComponentCommon.m_luaExportHelper.m_operationalActivity = operationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A97 RID: 101015 RVA: 0x006F5A4C File Offset: 0x006F3C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCardDS(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardComponentCommon.m_luaExportHelper.m_selectCardDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A98 RID: 101016 RVA: 0x006F5AA4 File Offset: 0x006F3CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectCardDS(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			DataSectionSelectCard selectCardDS;
			LuaObject.checkType<DataSectionSelectCard>(l, 2, out selectCardDS);
			selectCardComponentCommon.m_luaExportHelper.m_selectCardDS = selectCardDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A99 RID: 101017 RVA: 0x006F5B00 File Offset: 0x006F3D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectCardMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardComponentCommon.SelectCardMissionEvent += value;
				}
				else if (num == 2)
				{
					selectCardComponentCommon.SelectCardMissionEvent -= value;
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

	// Token: 0x06018A9A RID: 101018 RVA: 0x006F5B80 File Offset: 0x006F3D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SummonHeroMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardComponentCommon.SummonHeroMissionEvent += value;
				}
				else if (num == 2)
				{
					selectCardComponentCommon.SummonHeroMissionEvent -= value;
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

	// Token: 0x06018A9B RID: 101019 RVA: 0x006F5C00 File Offset: 0x006F3E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A9C RID: 101020 RVA: 0x006F5C54 File Offset: 0x006F3E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			SelectCardComponentCommon selectCardComponentCommon = (SelectCardComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			selectCardComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A9D RID: 101021 RVA: 0x006F5CAC File Offset: 0x006F3EAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.SelectCardComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.RemoveCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.IsActivityCardPoolOnActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.FindOperationalActivityByActivityCardPoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.GetAllOpenActivityCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.GetCardPoolById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.GetCrystalCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.SelectHeroCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.InitCardPoolConfigs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.IsUsedOutActivityCardPoolSelectOpportunity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.IsTicketsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.SelectCardUseTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.SelectCardUseCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.CanSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.IsCrystalOrActivityCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.CanUseTicketSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.OnSelectCardFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.SelectCardSpendTicketsOrCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.__callDele_SelectCardMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.__clearDele_SelectCardMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.__callDele_SummonHeroMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.__clearDele_SummonHeroMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1A);
		string name = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1C, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1E, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache20, true);
		string name4 = "m_operationalActivity";
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.get_m_operationalActivity);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_m_operationalActivity);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache22, true);
		string name5 = "m_selectCardDS";
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.get_m_selectCardDS);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_m_selectCardDS);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache24, true);
		string name6 = "SelectCardMissionEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_SelectCardMissionEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache25, true);
		string name7 = "SummonHeroMissionEvent";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_SummonHeroMissionEvent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache26, true);
		string name8 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.get_Owner);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache28, true);
		if (Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.<>f__mg$cache29, typeof(SelectCardComponentCommon));
	}

	// Token: 0x0400EF5F RID: 61279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF60 RID: 61280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF61 RID: 61281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF62 RID: 61282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF63 RID: 61283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF64 RID: 61284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF65 RID: 61285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EF66 RID: 61286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EF67 RID: 61287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EF68 RID: 61288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EF69 RID: 61289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EF6A RID: 61290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EF6B RID: 61291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EF6C RID: 61292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EF6D RID: 61293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EF6E RID: 61294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EF6F RID: 61295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EF70 RID: 61296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EF71 RID: 61297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EF72 RID: 61298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EF73 RID: 61299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EF74 RID: 61300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EF75 RID: 61301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EF76 RID: 61302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EF77 RID: 61303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EF78 RID: 61304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EF79 RID: 61305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EF7A RID: 61306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EF7B RID: 61307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EF7C RID: 61308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EF7D RID: 61309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EF7E RID: 61310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EF7F RID: 61311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EF80 RID: 61312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EF81 RID: 61313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EF82 RID: 61314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EF83 RID: 61315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EF84 RID: 61316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EF85 RID: 61317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EF86 RID: 61318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EF87 RID: 61319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EF88 RID: 61320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
