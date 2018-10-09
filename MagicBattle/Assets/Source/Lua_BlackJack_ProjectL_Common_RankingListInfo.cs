using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200126A RID: 4714
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RankingListInfo : LuaObject
{
	// Token: 0x06018913 RID: 100627 RVA: 0x006EAD78 File Offset: 0x006E8F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo o = new RankingListInfo();
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

	// Token: 0x06018914 RID: 100628 RVA: 0x006EADC0 File Offset: 0x006E8FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RankingListToPBRankingList_s(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingList;
			LuaObject.checkType<RankingListInfo>(l, 1, out rankingList);
			ProRankingListInfo o = RankingListInfo.RankingListToPBRankingList(rankingList);
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

	// Token: 0x06018915 RID: 100629 RVA: 0x006EAE14 File Offset: 0x006E9014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBRankingListToRankingList_s(IntPtr l)
	{
		int result;
		try
		{
			ProRankingListInfo proRankingList;
			LuaObject.checkType<ProRankingListInfo>(l, 1, out proRankingList);
			RankingListInfo o = RankingListInfo.PBRankingListToRankingList(proRankingList);
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

	// Token: 0x06018916 RID: 100630 RVA: 0x006EAE68 File Offset: 0x006E9068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rankingListInfo.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018917 RID: 100631 RVA: 0x006EAEBC File Offset: 0x006E90BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			RankingListType type;
			LuaObject.checkEnum<RankingListType>(l, 2, out type);
			rankingListInfo.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018918 RID: 100632 RVA: 0x006EAF14 File Offset: 0x006E9114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Score(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListInfo.Score);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018919 RID: 100633 RVA: 0x006EAF68 File Offset: 0x006E9168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Score(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			rankingListInfo.Score = score;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601891A RID: 100634 RVA: 0x006EAFC0 File Offset: 0x006E91C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CurrRank(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListInfo.CurrRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601891B RID: 100635 RVA: 0x006EB014 File Offset: 0x006E9214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CurrRank(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			int currRank;
			LuaObject.checkType(l, 2, out currRank);
			rankingListInfo.CurrRank = currRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601891C RID: 100636 RVA: 0x006EB06C File Offset: 0x006E926C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRank(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListInfo.LastRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601891D RID: 100637 RVA: 0x006EB0C0 File Offset: 0x006E92C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastRank(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			int lastRank;
			LuaObject.checkType(l, 2, out lastRank);
			rankingListInfo.LastRank = lastRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601891E RID: 100638 RVA: 0x006EB118 File Offset: 0x006E9318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListInfo.ChampionHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601891F RID: 100639 RVA: 0x006EB16C File Offset: 0x006E936C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			int championHeroId;
			LuaObject.checkType(l, 2, out championHeroId);
			rankingListInfo.ChampionHeroId = championHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018920 RID: 100640 RVA: 0x006EB1C4 File Offset: 0x006E93C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerList(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListInfo.PlayerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018921 RID: 100641 RVA: 0x006EB218 File Offset: 0x006E9418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerList(IntPtr l)
	{
		int result;
		try
		{
			RankingListInfo rankingListInfo = (RankingListInfo)LuaObject.checkSelf(l);
			List<RankingTargetPlayerInfo> playerList;
			LuaObject.checkType<List<RankingTargetPlayerInfo>>(l, 2, out playerList);
			rankingListInfo.PlayerList = playerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018922 RID: 100642 RVA: 0x006EB270 File Offset: 0x006E9470
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RankingListInfo");
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.RankingListToPBRankingList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.PBRankingListToRankingList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache1);
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache3, true);
		string name2 = "Score";
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.get_Score);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.set_Score);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache5, true);
		string name3 = "CurrRank";
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.get_CurrRank);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.set_CurrRank);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache7, true);
		string name4 = "LastRank";
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.get_LastRank);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.set_LastRank);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cache9, true);
		string name5 = "ChampionHeroId";
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.get_ChampionHeroId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.set_ChampionHeroId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheB, true);
		string name6 = "PlayerList";
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.get_PlayerList);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.set_PlayerList);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingListInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RankingListInfo.<>f__mg$cacheE, typeof(RankingListInfo));
	}

	// Token: 0x0400EE21 RID: 60961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE22 RID: 60962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE23 RID: 60963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE24 RID: 60964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE25 RID: 60965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE26 RID: 60966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE27 RID: 60967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EE28 RID: 60968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EE29 RID: 60969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EE2A RID: 60970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EE2B RID: 60971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EE2C RID: 60972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EE2D RID: 60973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EE2E RID: 60974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EE2F RID: 60975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
