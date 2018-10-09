using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001227 RID: 4647
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon : LuaObject
{
	// Token: 0x06018195 RID: 98709 RVA: 0x006B2064 File Offset: 0x006B0264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon o = new GlobalRankingListComponentCommon();
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

	// Token: 0x06018196 RID: 98710 RVA: 0x006B20AC File Offset: 0x006B02AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			string name = globalRankingListComponentCommon.GetName();
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

	// Token: 0x06018197 RID: 98711 RVA: 0x006B2100 File Offset: 0x006B0300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			globalRankingListComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018198 RID: 98712 RVA: 0x006B214C File Offset: 0x006B034C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			globalRankingListComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018199 RID: 98713 RVA: 0x006B2198 File Offset: 0x006B0398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			globalRankingListComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601819A RID: 98714 RVA: 0x006B21E4 File Offset: 0x006B03E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			globalRankingListComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601819B RID: 98715 RVA: 0x006B223C File Offset: 0x006B043C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			globalRankingListComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601819C RID: 98716 RVA: 0x006B2288 File Offset: 0x006B0488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckRankingListInfoQuery(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			RankingListType rankingListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingListType);
			int i;
			bool b = globalRankingListComponentCommon.CheckRankingListInfoQuery(rankingListType, out i);
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

	// Token: 0x0601819D RID: 98717 RVA: 0x006B22F8 File Offset: 0x006B04F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateLastRankingListQueryTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			RankingListType rankingListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingListType);
			DateTime currTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currTime);
			globalRankingListComponentCommon.UpdateLastRankingListQueryTime(rankingListType, currTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601819E RID: 98718 RVA: 0x006B235C File Offset: 0x006B055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601819F RID: 98719 RVA: 0x006B23B4 File Offset: 0x006B05B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			globalRankingListComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A0 RID: 98720 RVA: 0x006B2410 File Offset: 0x006B0610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A1 RID: 98721 RVA: 0x006B2468 File Offset: 0x006B0668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			globalRankingListComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A2 RID: 98722 RVA: 0x006B24C4 File Offset: 0x006B06C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A3 RID: 98723 RVA: 0x006B251C File Offset: 0x006B071C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			globalRankingListComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A4 RID: 98724 RVA: 0x006B2578 File Offset: 0x006B0778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A5 RID: 98725 RVA: 0x006B25D0 File Offset: 0x006B07D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			globalRankingListComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A6 RID: 98726 RVA: 0x006B262C File Offset: 0x006B082C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRankingListQueryTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponentCommon.m_luaExportHelper.LastRankingListQueryTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A7 RID: 98727 RVA: 0x006B2684 File Offset: 0x006B0884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastRankingListQueryTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			DateTime[] lastRankingListQueryTime;
			LuaObject.checkArray<DateTime>(l, 2, out lastRankingListQueryTime);
			globalRankingListComponentCommon.m_luaExportHelper.LastRankingListQueryTime = lastRankingListQueryTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A8 RID: 98728 RVA: 0x006B26E0 File Offset: 0x006B08E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalRankingListComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181A9 RID: 98729 RVA: 0x006B2734 File Offset: 0x006B0934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			GlobalRankingListComponentCommon globalRankingListComponentCommon = (GlobalRankingListComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			globalRankingListComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181AA RID: 98730 RVA: 0x006B278C File Offset: 0x006B098C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GlobalRankingListComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.CheckRankingListInfoQuery);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.UpdateLastRankingListQueryTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache7);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache9, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheB, true);
		string name3 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.get_m_rift);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheD, true);
		string name4 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.get_m_hero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cacheF, true);
		string name5 = "LastRankingListQueryTime";
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.get_LastRankingListQueryTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.set_LastRankingListQueryTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache11, true);
		string name6 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.get_Owner);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache13, true);
		if (Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.<>f__mg$cache14, typeof(GlobalRankingListComponentCommon));
	}

	// Token: 0x0400E729 RID: 59177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E72A RID: 59178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E72B RID: 59179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E72C RID: 59180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E72D RID: 59181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E72E RID: 59182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E72F RID: 59183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E730 RID: 59184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E731 RID: 59185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E732 RID: 59186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E733 RID: 59187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E734 RID: 59188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E735 RID: 59189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E736 RID: 59190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E737 RID: 59191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E738 RID: 59192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E739 RID: 59193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E73A RID: 59194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E73B RID: 59195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E73C RID: 59196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E73D RID: 59197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
