using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C5 RID: 4805
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent : LuaObject
{
	// Token: 0x0601948D RID: 103565 RVA: 0x0073FA78 File Offset: 0x0073DC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent o = new GlobalRankingListComponent();
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

	// Token: 0x0601948E RID: 103566 RVA: 0x0073FAC0 File Offset: 0x0073DCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRankingListInfoToCache(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			RankingListType rankingType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingType);
			RankingListInfo rankingListInfo;
			LuaObject.checkType<RankingListInfo>(l, 3, out rankingListInfo);
			globalRankingListComponent.AddRankingListInfoToCache(rankingType, rankingListInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601948F RID: 103567 RVA: 0x0073FB24 File Offset: 0x0073DD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRankingListInfoByType(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			RankingListType rankingType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingType);
			RankingListInfo rankingListInfoByType = globalRankingListComponent.GetRankingListInfoByType(rankingType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListInfoByType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019490 RID: 103568 RVA: 0x0073FB88 File Offset: 0x0073DD88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRankingListInfoValid(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			RankingListType rankingListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingListType);
			bool b = globalRankingListComponent.IsRankingListInfoValid(rankingListType);
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

	// Token: 0x06019491 RID: 103569 RVA: 0x0073FBEC File Offset: 0x0073DDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSingleHeroRankingListInfoToCache(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			RankingListInfo rankingListInfo;
			LuaObject.checkType<RankingListInfo>(l, 3, out rankingListInfo);
			globalRankingListComponent.AddSingleHeroRankingListInfoToCache(heroId, rankingListInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019492 RID: 103570 RVA: 0x0073FC50 File Offset: 0x0073DE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSingleHeroRankingListInfoByHeroId(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			RankingListInfo singleHeroRankingListInfoByHeroId = globalRankingListComponent.GetSingleHeroRankingListInfoByHeroId(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, singleHeroRankingListInfoByHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019493 RID: 103571 RVA: 0x0073FCB4 File Offset: 0x0073DEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAbleQueryRankingListInfo(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			RankingListType rankingListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingListType);
			int i;
			bool b = globalRankingListComponent.IsAbleQueryRankingListInfo(rankingListType, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019494 RID: 103572 RVA: 0x0073FD24 File Offset: 0x0073DF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSingleHeroRankingListInfoValid(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = globalRankingListComponent.IsSingleHeroRankingListInfoValid(heroId);
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

	// Token: 0x06019495 RID: 103573 RVA: 0x0073FD88 File Offset: 0x0073DF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			string s = globalRankingListComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019496 RID: 103574 RVA: 0x0073FDE4 File Offset: 0x0073DFE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			globalRankingListComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019497 RID: 103575 RVA: 0x0073FE38 File Offset: 0x0073E038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			globalRankingListComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019498 RID: 103576 RVA: 0x0073FE8C File Offset: 0x0073E08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			globalRankingListComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019499 RID: 103577 RVA: 0x0073FEE0 File Offset: 0x0073E0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			globalRankingListComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601949A RID: 103578 RVA: 0x0073FF3C File Offset: 0x0073E13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			globalRankingListComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601949B RID: 103579 RVA: 0x0073FF90 File Offset: 0x0073E190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckRankingListInfoQuery(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			RankingListType rankingListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingListType);
			int i;
			bool b = globalRankingListComponent.m_luaExportHelper.__callBase_CheckRankingListInfoQuery(rankingListType, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601949C RID: 103580 RVA: 0x00740004 File Offset: 0x0073E204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UpdateLastRankingListQueryTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			RankingListType rankingListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingListType);
			DateTime currTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currTime);
			globalRankingListComponent.m_luaExportHelper.__callBase_UpdateLastRankingListQueryTime(rankingListType, currTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601949D RID: 103581 RVA: 0x00740070 File Offset: 0x0073E270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cachedRankingListDict(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponent.m_luaExportHelper.m_cachedRankingListDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601949E RID: 103582 RVA: 0x007400C8 File Offset: 0x0073E2C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cachedRankingListDict(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			Dictionary<RankingListType, GlobalRankingListComponent.CachedRankingListInfo> cachedRankingListDict;
			LuaObject.checkType<Dictionary<RankingListType, GlobalRankingListComponent.CachedRankingListInfo>>(l, 2, out cachedRankingListDict);
			globalRankingListComponent.m_luaExportHelper.m_cachedRankingListDict = cachedRankingListDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601949F RID: 103583 RVA: 0x00740124 File Offset: 0x0073E324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cachedSingleHeroRankListDict(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponent.m_luaExportHelper.m_cachedSingleHeroRankListDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A0 RID: 103584 RVA: 0x0074017C File Offset: 0x0073E37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cachedSingleHeroRankListDict(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent globalRankingListComponent = (GlobalRankingListComponent)LuaObject.checkSelf(l);
			Dictionary<int, GlobalRankingListComponent.CachedRankingListInfo> cachedSingleHeroRankListDict;
			LuaObject.checkType<Dictionary<int, GlobalRankingListComponent.CachedRankingListInfo>>(l, 2, out cachedSingleHeroRankListDict);
			globalRankingListComponent.m_luaExportHelper.m_cachedSingleHeroRankListDict = cachedSingleHeroRankListDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A1 RID: 103585 RVA: 0x007401D8 File Offset: 0x0073E3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OutDateTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GlobalRankingListComponent.LuaExportHelper.OutDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A2 RID: 103586 RVA: 0x00740220 File Offset: 0x0073E420
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.GlobalRankingListComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.AddRankingListInfoToCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.GetRankingListInfoByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.IsRankingListInfoValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.AddSingleHeroRankingListInfoToCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.GetSingleHeroRankingListInfoByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.IsAbleQueryRankingListInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.IsSingleHeroRankingListInfoValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_CheckRankingListInfoQuery);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.__callBase_UpdateLastRankingListQueryTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheE);
		string name = "m_cachedRankingListDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.get_m_cachedRankingListDict);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.set_m_cachedRankingListDict);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache10, true);
		string name2 = "m_cachedSingleHeroRankListDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.get_m_cachedSingleHeroRankListDict);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.set_m_cachedSingleHeroRankListDict);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache12, true);
		string name3 = "OutDateTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.get_OutDateTime);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache13, null, false);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.<>f__mg$cache14, typeof(GlobalRankingListComponent), typeof(GlobalRankingListComponentCommon));
	}

	// Token: 0x0400F8E5 RID: 63717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F8E6 RID: 63718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F8E7 RID: 63719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F8E8 RID: 63720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F8E9 RID: 63721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F8EA RID: 63722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F8EB RID: 63723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F8EC RID: 63724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F8ED RID: 63725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F8EE RID: 63726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F8EF RID: 63727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F8F0 RID: 63728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F8F1 RID: 63729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F8F2 RID: 63730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F8F3 RID: 63731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F8F4 RID: 63732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F8F5 RID: 63733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F8F6 RID: 63734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F8F7 RID: 63735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F8F8 RID: 63736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F8F9 RID: 63737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
