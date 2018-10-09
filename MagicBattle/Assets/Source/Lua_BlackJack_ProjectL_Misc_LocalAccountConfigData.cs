using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A7 RID: 4775
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData : LuaObject
{
	// Token: 0x0601908A RID: 102538 RVA: 0x00721278 File Offset: 0x0071F478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData o = new LocalAccountConfigData();
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

	// Token: 0x0601908B RID: 102539 RVA: 0x007212C0 File Offset: 0x0071F4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveReadAnnounceActivities(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.HaveReadAnnounceActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601908C RID: 102540 RVA: 0x00721314 File Offset: 0x0071F514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveReadAnnounceActivities(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			string[] haveReadAnnounceActivities;
			LuaObject.checkArray<string>(l, 2, out haveReadAnnounceActivities);
			localAccountConfigData.HaveReadAnnounceActivities = haveReadAnnounceActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601908D RID: 102541 RVA: 0x0072136C File Offset: 0x0071F56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveReadHeroBiographyIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.HaveReadHeroBiographyIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601908E RID: 102542 RVA: 0x007213C0 File Offset: 0x0071F5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveReadHeroBiographyIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] haveReadHeroBiographyIds;
			LuaObject.checkArray<int>(l, 2, out haveReadHeroBiographyIds);
			localAccountConfigData.HaveReadHeroBiographyIds = haveReadHeroBiographyIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601908F RID: 102543 RVA: 0x00721418 File Offset: 0x0071F618
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HaveReadHeroPerformanceIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.HaveReadHeroPerformanceIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019090 RID: 102544 RVA: 0x0072146C File Offset: 0x0071F66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HaveReadHeroPerformanceIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] haveReadHeroPerformanceIds;
			LuaObject.checkArray<int>(l, 2, out haveReadHeroPerformanceIds);
			localAccountConfigData.HaveReadHeroPerformanceIds = haveReadHeroPerformanceIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019091 RID: 102545 RVA: 0x007214C4 File Offset: 0x0071F6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockHeroBiographyIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.UnlockHeroBiographyIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019092 RID: 102546 RVA: 0x00721518 File Offset: 0x0071F718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnlockHeroBiographyIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] unlockHeroBiographyIds;
			LuaObject.checkArray<int>(l, 2, out unlockHeroBiographyIds);
			localAccountConfigData.UnlockHeroBiographyIds = unlockHeroBiographyIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019093 RID: 102547 RVA: 0x00721570 File Offset: 0x0071F770
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnlockHeroPerformanceIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.UnlockHeroPerformanceIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019094 RID: 102548 RVA: 0x007215C4 File Offset: 0x0071F7C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UnlockHeroPerformanceIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] unlockHeroPerformanceIds;
			LuaObject.checkArray<int>(l, 2, out unlockHeroPerformanceIds);
			localAccountConfigData.UnlockHeroPerformanceIds = unlockHeroPerformanceIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019095 RID: 102549 RVA: 0x0072161C File Offset: 0x0071F81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockHeroDungeonLevelIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.UnlockHeroDungeonLevelIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019096 RID: 102550 RVA: 0x00721670 File Offset: 0x0071F870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnlockHeroDungeonLevelIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] unlockHeroDungeonLevelIds;
			LuaObject.checkArray<int>(l, 2, out unlockHeroDungeonLevelIds);
			localAccountConfigData.UnlockHeroDungeonLevelIds = unlockHeroDungeonLevelIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019097 RID: 102551 RVA: 0x007216C8 File Offset: 0x0071F8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockHeroFetterIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.UnlockHeroFetterIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019098 RID: 102552 RVA: 0x0072171C File Offset: 0x0071F91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnlockHeroFetterIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] unlockHeroFetterIds;
			LuaObject.checkArray<int>(l, 2, out unlockHeroFetterIds);
			localAccountConfigData.UnlockHeroFetterIds = unlockHeroFetterIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019099 RID: 102553 RVA: 0x00721774 File Offset: 0x0071F974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaAttackerHeroIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.ArenaAttackerHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601909A RID: 102554 RVA: 0x007217C8 File Offset: 0x0071F9C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaAttackerHeroIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int[] arenaAttackerHeroIds;
			LuaObject.checkArray<int>(l, 2, out arenaAttackerHeroIds);
			localAccountConfigData.ArenaAttackerHeroIds = arenaAttackerHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601909B RID: 102555 RVA: 0x00721820 File Offset: 0x0071FA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamPlayerLevelMin(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.TeamPlayerLevelMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601909C RID: 102556 RVA: 0x00721874 File Offset: 0x0071FA74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamPlayerLevelMin(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int teamPlayerLevelMin;
			LuaObject.checkType(l, 2, out teamPlayerLevelMin);
			localAccountConfigData.TeamPlayerLevelMin = teamPlayerLevelMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601909D RID: 102557 RVA: 0x007218CC File Offset: 0x0071FACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamPlayerLevelMax(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.TeamPlayerLevelMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601909E RID: 102558 RVA: 0x00721920 File Offset: 0x0071FB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamPlayerLevelMax(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			int teamPlayerLevelMax;
			LuaObject.checkType(l, 2, out teamPlayerLevelMax);
			localAccountConfigData.TeamPlayerLevelMax = teamPlayerLevelMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601909F RID: 102559 RVA: 0x00721978 File Offset: 0x0071FB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsRealtimePVPShowNotice(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.IsRealtimePVPShowNotice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190A0 RID: 102560 RVA: 0x007219CC File Offset: 0x0071FBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsRealtimePVPShowNotice(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			bool isRealtimePVPShowNotice;
			LuaObject.checkType(l, 2, out isRealtimePVPShowNotice);
			localAccountConfigData.IsRealtimePVPShowNotice = isRealtimePVPShowNotice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190A1 RID: 102561 RVA: 0x00721A24 File Offset: 0x0071FC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveDoneMemoryExtraction(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfigData.HaveDoneMemoryExtraction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190A2 RID: 102562 RVA: 0x00721A78 File Offset: 0x0071FC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveDoneMemoryExtraction(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfigData localAccountConfigData = (LocalAccountConfigData)LuaObject.checkSelf(l);
			bool haveDoneMemoryExtraction;
			LuaObject.checkType(l, 2, out haveDoneMemoryExtraction);
			localAccountConfigData.HaveDoneMemoryExtraction = haveDoneMemoryExtraction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190A3 RID: 102563 RVA: 0x00721AD0 File Offset: 0x0071FCD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalAccountConfigData");
		string name = "HaveReadAnnounceActivities";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_HaveReadAnnounceActivities);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_HaveReadAnnounceActivities);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache1, true);
		string name2 = "HaveReadHeroBiographyIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_HaveReadHeroBiographyIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_HaveReadHeroBiographyIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache3, true);
		string name3 = "HaveReadHeroPerformanceIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_HaveReadHeroPerformanceIds);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_HaveReadHeroPerformanceIds);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache5, true);
		string name4 = "UnlockHeroBiographyIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_UnlockHeroBiographyIds);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_UnlockHeroBiographyIds);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache7, true);
		string name5 = "UnlockHeroPerformanceIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_UnlockHeroPerformanceIds);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_UnlockHeroPerformanceIds);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache9, true);
		string name6 = "UnlockHeroDungeonLevelIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_UnlockHeroDungeonLevelIds);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_UnlockHeroDungeonLevelIds);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheB, true);
		string name7 = "UnlockHeroFetterIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_UnlockHeroFetterIds);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_UnlockHeroFetterIds);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheD, true);
		string name8 = "ArenaAttackerHeroIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_ArenaAttackerHeroIds);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_ArenaAttackerHeroIds);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cacheF, true);
		string name9 = "TeamPlayerLevelMin";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_TeamPlayerLevelMin);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_TeamPlayerLevelMin);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache11, true);
		string name10 = "TeamPlayerLevelMax";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_TeamPlayerLevelMax);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_TeamPlayerLevelMax);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache13, true);
		string name11 = "IsRealtimePVPShowNotice";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_IsRealtimePVPShowNotice);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_IsRealtimePVPShowNotice);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache15, true);
		string name12 = "HaveDoneMemoryExtraction";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.get_HaveDoneMemoryExtraction);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.set_HaveDoneMemoryExtraction);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache17, true);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.<>f__mg$cache18, typeof(LocalAccountConfigData));
	}

	// Token: 0x0400F51E RID: 62750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F51F RID: 62751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F520 RID: 62752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F521 RID: 62753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F522 RID: 62754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F523 RID: 62755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F524 RID: 62756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F525 RID: 62757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F526 RID: 62758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F527 RID: 62759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F528 RID: 62760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F529 RID: 62761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F52A RID: 62762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F52B RID: 62763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F52C RID: 62764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F52D RID: 62765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F52E RID: 62766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F52F RID: 62767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F530 RID: 62768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F531 RID: 62769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F532 RID: 62770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F533 RID: 62771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F534 RID: 62772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F535 RID: 62773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F536 RID: 62774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
