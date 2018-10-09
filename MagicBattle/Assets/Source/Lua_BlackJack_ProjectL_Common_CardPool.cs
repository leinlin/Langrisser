using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011DA RID: 4570
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CardPool : LuaObject
{
	// Token: 0x06017B44 RID: 97092 RVA: 0x00684C8C File Offset: 0x00682E8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			CardPool o = new CardPool(poolId);
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

	// Token: 0x06017B45 RID: 97093 RVA: 0x00684CE0 File Offset: 0x00682EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBCardPoolToCardPool_s(IntPtr l)
	{
		int result;
		try
		{
			ProCardPool pbCardPool;
			LuaObject.checkType<ProCardPool>(l, 1, out pbCardPool);
			CardPool o = CardPool.PBCardPoolToCardPool(pbCardPool);
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

	// Token: 0x06017B46 RID: 97094 RVA: 0x00684D34 File Offset: 0x00682F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBActivityCardPoolsToCardPools_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProCardPool> pbCardPools;
			LuaObject.checkType<List<ProCardPool>>(l, 1, out pbCardPools);
			List<CardPool> o = CardPool.PBActivityCardPoolsToCardPools(pbCardPools);
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

	// Token: 0x06017B47 RID: 97095 RVA: 0x00684D88 File Offset: 0x00682F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CardPoolToPBCardPool_s(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 1, out cardPool);
			ProCardPool o = CardPool.CardPoolToPBCardPool(cardPool);
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

	// Token: 0x06017B48 RID: 97096 RVA: 0x00684DDC File Offset: 0x00682FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CardPoolsToPBActivityCardPools_s(IntPtr l)
	{
		int result;
		try
		{
			List<CardPool> cardPools;
			LuaObject.checkType<List<CardPool>>(l, 1, out cardPools);
			List<ProCardPool> o = CardPool.CardPoolsToPBActivityCardPools(cardPools);
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

	// Token: 0x06017B49 RID: 97097 RVA: 0x00684E30 File Offset: 0x00683030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PoolId(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.PoolId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B4A RID: 97098 RVA: 0x00684E84 File Offset: 0x00683084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PoolId(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			cardPool.PoolId = poolId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B4B RID: 97099 RVA: 0x00684EDC File Offset: 0x006830DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SummonedRareHero(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.SummonedRareHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B4C RID: 97100 RVA: 0x00684F30 File Offset: 0x00683130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SummonedRareHero(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			bool summonedRareHero;
			LuaObject.checkType(l, 2, out summonedRareHero);
			cardPool.SummonedRareHero = summonedRareHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B4D RID: 97101 RVA: 0x00684F88 File Offset: 0x00683188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectCardCount(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.SelectCardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B4E RID: 97102 RVA: 0x00684FDC File Offset: 0x006831DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectCardCount(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			int selectCardCount;
			LuaObject.checkType(l, 2, out selectCardCount);
			cardPool.SelectCardCount = selectCardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B4F RID: 97103 RVA: 0x00685034 File Offset: 0x00683234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DisconnectCount(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.DisconnectCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B50 RID: 97104 RVA: 0x00685088 File Offset: 0x00683288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DisconnectCount(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			int disconnectCount;
			LuaObject.checkType(l, 2, out disconnectCount);
			cardPool.DisconnectCount = disconnectCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B51 RID: 97105 RVA: 0x006850E0 File Offset: 0x006832E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFirstSignleSelect(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.IsFirstSignleSelect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B52 RID: 97106 RVA: 0x00685134 File Offset: 0x00683334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsFirstSignleSelect(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			bool isFirstSignleSelect;
			LuaObject.checkType(l, 2, out isFirstSignleSelect);
			cardPool.IsFirstSignleSelect = isFirstSignleSelect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B53 RID: 97107 RVA: 0x0068518C File Offset: 0x0068338C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFirstTenSelect(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.IsFirstTenSelect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B54 RID: 97108 RVA: 0x006851E0 File Offset: 0x006833E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsFirstTenSelect(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			bool isFirstTenSelect;
			LuaObject.checkType(l, 2, out isFirstTenSelect);
			cardPool.IsFirstTenSelect = isFirstTenSelect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B55 RID: 97109 RVA: 0x00685238 File Offset: 0x00683438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActivityInstanceId(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.ActivityInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B56 RID: 97110 RVA: 0x0068528C File Offset: 0x0068348C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityInstanceId(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			ulong activityInstanceId;
			LuaObject.checkType(l, 2, out activityInstanceId);
			cardPool.ActivityInstanceId = activityInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B57 RID: 97111 RVA: 0x006852E4 File Offset: 0x006834E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardPool.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B58 RID: 97112 RVA: 0x00685338 File Offset: 0x00683538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Config(IntPtr l)
	{
		int result;
		try
		{
			CardPool cardPool = (CardPool)LuaObject.checkSelf(l);
			ConfigDataCardPoolInfo config;
			LuaObject.checkType<ConfigDataCardPoolInfo>(l, 2, out config);
			cardPool.Config = config;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B59 RID: 97113 RVA: 0x00685390 File Offset: 0x00683590
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CardPool");
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.PBCardPoolToCardPool_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.PBActivityCardPoolsToCardPools_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.CardPoolToPBCardPool_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.CardPoolsToPBActivityCardPools_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache3);
		string name = "PoolId";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_PoolId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_PoolId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache5, true);
		string name2 = "SummonedRareHero";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_SummonedRareHero);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_SummonedRareHero);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache7, true);
		string name3 = "SelectCardCount";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_SelectCardCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_SelectCardCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache9, true);
		string name4 = "DisconnectCount";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_DisconnectCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_DisconnectCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheB, true);
		string name5 = "IsFirstSignleSelect";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_IsFirstSignleSelect);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_IsFirstSignleSelect);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheD, true);
		string name6 = "IsFirstTenSelect";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_IsFirstTenSelect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_IsFirstTenSelect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cacheF, true);
		string name7 = "ActivityInstanceId";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_ActivityInstanceId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_ActivityInstanceId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache11, true);
		string name8 = "Config";
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.get_Config);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.set_Config);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache13, true);
		if (Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CardPool.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CardPool.<>f__mg$cache14, typeof(CardPool));
	}

	// Token: 0x0400E172 RID: 57714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E173 RID: 57715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E174 RID: 57716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E175 RID: 57717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E176 RID: 57718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E177 RID: 57719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E178 RID: 57720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E179 RID: 57721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E17A RID: 57722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E17B RID: 57723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E17C RID: 57724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E17D RID: 57725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E17E RID: 57726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E17F RID: 57727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E180 RID: 57728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E181 RID: 57729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E182 RID: 57730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E183 RID: 57731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E184 RID: 57732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E185 RID: 57733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E186 RID: 57734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
