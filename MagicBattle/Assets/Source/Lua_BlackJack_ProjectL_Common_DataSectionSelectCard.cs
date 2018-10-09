using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001211 RID: 4625
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionSelectCard : LuaObject
{
	// Token: 0x06018032 RID: 98354 RVA: 0x006A84D4 File Offset: 0x006A66D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard o = new DataSectionSelectCard();
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

	// Token: 0x06018033 RID: 98355 RVA: 0x006A851C File Offset: 0x006A671C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			dataSectionSelectCard.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018034 RID: 98356 RVA: 0x006A8568 File Offset: 0x006A6768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			object o = dataSectionSelectCard.SerializeToClient();
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

	// Token: 0x06018035 RID: 98357 RVA: 0x006A85BC File Offset: 0x006A67BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitCardPools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			List<CardPool> cardPools;
			LuaObject.checkType<List<CardPool>>(l, 2, out cardPools);
			dataSectionSelectCard.InitCardPools(cardPools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018036 RID: 98358 RVA: 0x006A8614 File Offset: 0x006A6814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCardPools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			List<CardPool> cardPools;
			LuaObject.checkType<List<CardPool>>(l, 2, out cardPools);
			dataSectionSelectCard.SetCardPools(cardPools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018037 RID: 98359 RVA: 0x006A866C File Offset: 0x006A686C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanTenSelectDiscount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool b = dataSectionSelectCard.CanTenSelectDiscount(cardPool);
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

	// Token: 0x06018038 RID: 98360 RVA: 0x006A86D0 File Offset: 0x006A68D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindCardPool(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			CardPool o = dataSectionSelectCard.FindCardPool(cardPoolId);
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

	// Token: 0x06018039 RID: 98361 RVA: 0x006A8734 File Offset: 0x006A6934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveCardPool(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			dataSectionSelectCard.RemoveCardPool(cardPoolId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601803A RID: 98362 RVA: 0x006A878C File Offset: 0x006A698C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCardPool(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool newCardPool;
			LuaObject.checkType<CardPool>(l, 2, out newCardPool);
			CardPool o = dataSectionSelectCard.AddCardPool(newCardPool);
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

	// Token: 0x0601803B RID: 98363 RVA: 0x006A87F0 File Offset: 0x006A69F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSelectCount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			int count;
			LuaObject.checkType(l, 3, out count);
			dataSectionSelectCard.AddSelectCount(cardPool, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601803C RID: 98364 RVA: 0x006A8854 File Offset: 0x006A6A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SummonRareHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			dataSectionSelectCard.SummonRareHero(cardPool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601803D RID: 98365 RVA: 0x006A88AC File Offset: 0x006A6AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGuaranteedSelectCount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			dataSectionSelectCard.AddGuaranteedSelectCount(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601803E RID: 98366 RVA: 0x006A8904 File Offset: 0x006A6B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTenSelectDiscountCount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			dataSectionSelectCard.AddTenSelectDiscountCount(cardPool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601803F RID: 98367 RVA: 0x006A895C File Offset: 0x006A6B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFirstSingleSelectCard(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool b = dataSectionSelectCard.IsFirstSingleSelectCard(cardPool);
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

	// Token: 0x06018040 RID: 98368 RVA: 0x006A89C0 File Offset: 0x006A6BC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFirstTenSelectCard(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool b = dataSectionSelectCard.IsFirstTenSelectCard(cardPool);
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

	// Token: 0x06018041 RID: 98369 RVA: 0x006A8A24 File Offset: 0x006A6C24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFirstSelectCard(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			bool b = dataSectionSelectCard.IsFirstSelectCard(cardPool);
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

	// Token: 0x06018042 RID: 98370 RVA: 0x006A8A88 File Offset: 0x006A6C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishFirstSingleSelect(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			dataSectionSelectCard.FinishFirstSingleSelect(cardPool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018043 RID: 98371 RVA: 0x006A8AE0 File Offset: 0x006A6CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishFirstTenSelect(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			dataSectionSelectCard.FinishFirstTenSelect(cardPool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018044 RID: 98372 RVA: 0x006A8B38 File Offset: 0x006A6D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuaranteedAccumulatedValue(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int guaranteedAccumulatedValue;
			LuaObject.checkType(l, 2, out guaranteedAccumulatedValue);
			dataSectionSelectCard.SetGuaranteedAccumulatedValue(guaranteedAccumulatedValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018045 RID: 98373 RVA: 0x006A8B90 File Offset: 0x006A6D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitGuaranteedAccumulatedValue(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			dataSectionSelectCard.InitGuaranteedAccumulatedValue(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018046 RID: 98374 RVA: 0x006A8BE8 File Offset: 0x006A6DE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsReachGuaranteedAccumulatedValue(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			bool b = dataSectionSelectCard.IsReachGuaranteedAccumulatedValue(value);
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

	// Token: 0x06018047 RID: 98375 RVA: 0x006A8C4C File Offset: 0x006A6E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAboveGuaranteedAccumulatedValue(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			bool b = dataSectionSelectCard.IsAboveGuaranteedAccumulatedValue();
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

	// Token: 0x06018048 RID: 98376 RVA: 0x006A8CA0 File Offset: 0x006A6EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsCardPoolExistGuaranteedMechanism(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			bool b = dataSectionSelectCard.IsCardPoolExistGuaranteedMechanism();
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

	// Token: 0x06018049 RID: 98377 RVA: 0x006A8CF4 File Offset: 0x006A6EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuaranteedSelectCardCount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int guaranteedSelectCardCount;
			LuaObject.checkType(l, 2, out guaranteedSelectCardCount);
			dataSectionSelectCard.SetGuaranteedSelectCardCount(guaranteedSelectCardCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601804A RID: 98378 RVA: 0x006A8D4C File Offset: 0x006A6F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitGuaranteedSelectCardCount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			dataSectionSelectCard.InitGuaranteedSelectCardCount(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601804B RID: 98379 RVA: 0x006A8DA4 File Offset: 0x006A6FA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitSelectCardGuaranteedStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			SelectCardGuaranteedStatus status;
			LuaObject.checkEnum<SelectCardGuaranteedStatus>(l, 2, out status);
			dataSectionSelectCard.InitSelectCardGuaranteedStatus(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601804C RID: 98380 RVA: 0x006A8DFC File Offset: 0x006A6FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectCardGuaranteedStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			SelectCardGuaranteedStatus selectCardGuaranteedStatus;
			LuaObject.checkEnum<SelectCardGuaranteedStatus>(l, 2, out selectCardGuaranteedStatus);
			dataSectionSelectCard.SetSelectCardGuaranteedStatus(selectCardGuaranteedStatus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601804D RID: 98381 RVA: 0x006A8E54 File Offset: 0x006A7054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardPools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionSelectCard.CardPools);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601804E RID: 98382 RVA: 0x006A8EA8 File Offset: 0x006A70A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardPools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			Dictionary<int, CardPool> cardPools;
			LuaObject.checkType<Dictionary<int, CardPool>>(l, 2, out cardPools);
			dataSectionSelectCard.CardPools = cardPools;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601804F RID: 98383 RVA: 0x006A8F00 File Offset: 0x006A7100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GuaranteedAccumulatedValue(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionSelectCard.GuaranteedAccumulatedValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018050 RID: 98384 RVA: 0x006A8F54 File Offset: 0x006A7154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GuaranteedSelectCardCount(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionSelectCard.GuaranteedSelectCardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018051 RID: 98385 RVA: 0x006A8FA8 File Offset: 0x006A71A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GuaranteedStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSelectCard dataSectionSelectCard = (DataSectionSelectCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)dataSectionSelectCard.GuaranteedStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018052 RID: 98386 RVA: 0x006A8FFC File Offset: 0x006A71FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionSelectCard");
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.InitCardPools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.SetCardPools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.CanTenSelectDiscount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.FindCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.RemoveCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.AddCardPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.AddSelectCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.SummonRareHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.AddGuaranteedSelectCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.AddTenSelectDiscountCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.IsFirstSingleSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.IsFirstTenSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.IsFirstSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.FinishFirstSingleSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.FinishFirstTenSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.SetGuaranteedAccumulatedValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.InitGuaranteedAccumulatedValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.IsReachGuaranteedAccumulatedValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.IsAboveGuaranteedAccumulatedValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.IsCardPoolExistGuaranteedMechanism);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.SetGuaranteedSelectCardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.InitGuaranteedSelectCardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.InitSelectCardGuaranteedStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.SetSelectCardGuaranteedStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache19);
		string name = "CardPools";
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.get_CardPools);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.set_CardPools);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1B, true);
		string name2 = "GuaranteedAccumulatedValue";
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.get_GuaranteedAccumulatedValue);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1C, null, true);
		string name3 = "GuaranteedSelectCardCount";
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.get_GuaranteedSelectCardCount);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1D, null, true);
		string name4 = "GuaranteedStatus";
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.get_GuaranteedStatus);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1E, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.<>f__mg$cache1F, typeof(DataSectionSelectCard), typeof(DataSection));
	}

	// Token: 0x0400E5F2 RID: 58866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E5F3 RID: 58867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E5F4 RID: 58868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E5F5 RID: 58869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E5F6 RID: 58870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E5F7 RID: 58871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E5F8 RID: 58872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E5F9 RID: 58873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E5FA RID: 58874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E5FB RID: 58875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E5FC RID: 58876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E5FD RID: 58877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E5FE RID: 58878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E5FF RID: 58879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E600 RID: 58880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E601 RID: 58881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E602 RID: 58882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E603 RID: 58883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E604 RID: 58884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E605 RID: 58885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E606 RID: 58886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E607 RID: 58887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E608 RID: 58888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E609 RID: 58889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E60A RID: 58890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E60B RID: 58891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E60C RID: 58892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E60D RID: 58893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E60E RID: 58894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E60F RID: 58895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E610 RID: 58896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E611 RID: 58897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
