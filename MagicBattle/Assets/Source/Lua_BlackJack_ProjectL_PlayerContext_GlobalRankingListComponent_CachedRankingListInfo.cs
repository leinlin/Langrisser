using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C6 RID: 4806
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo : LuaObject
{
	// Token: 0x060194A4 RID: 103588 RVA: 0x0074053C File Offset: 0x0073E73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent.CachedRankingListInfo o = new GlobalRankingListComponent.CachedRankingListInfo();
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

	// Token: 0x060194A5 RID: 103589 RVA: 0x00740584 File Offset: 0x0073E784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_outDateTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent.CachedRankingListInfo cachedRankingListInfo = (GlobalRankingListComponent.CachedRankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cachedRankingListInfo.m_outDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A6 RID: 103590 RVA: 0x007405DC File Offset: 0x0073E7DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_outDateTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent.CachedRankingListInfo cachedRankingListInfo = (GlobalRankingListComponent.CachedRankingListInfo)LuaObject.checkSelf(l);
			DateTime outDateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out outDateTime);
			cachedRankingListInfo.m_outDateTime = outDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A7 RID: 103591 RVA: 0x00740634 File Offset: 0x0073E834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingListInfo(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent.CachedRankingListInfo cachedRankingListInfo = (GlobalRankingListComponent.CachedRankingListInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cachedRankingListInfo.m_rankingListInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A8 RID: 103592 RVA: 0x00740688 File Offset: 0x0073E888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingListInfo(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponent.CachedRankingListInfo cachedRankingListInfo = (GlobalRankingListComponent.CachedRankingListInfo)LuaObject.checkSelf(l);
			RankingListInfo rankingListInfo;
			LuaObject.checkType<RankingListInfo>(l, 2, out rankingListInfo);
			cachedRankingListInfo.m_rankingListInfo = rankingListInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194A9 RID: 103593 RVA: 0x007406E0 File Offset: 0x0073E8E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.GlobalRankingListComponent.CachedRankingListInfo");
		string name = "m_outDateTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.get_m_outDateTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.set_m_outDateTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache1, true);
		string name2 = "m_rankingListInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.get_m_rankingListInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.set_m_rankingListInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.<>f__mg$cache4, typeof(GlobalRankingListComponent.CachedRankingListInfo));
	}

	// Token: 0x0400F8FA RID: 63738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F8FB RID: 63739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F8FC RID: 63740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F8FD RID: 63741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F8FE RID: 63742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
