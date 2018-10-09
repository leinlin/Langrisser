using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001178 RID: 4472
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo : LuaObject
{
	// Token: 0x06016F43 RID: 94019 RVA: 0x00629FC0 File Offset: 0x006281C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo o = new ConfigDataWorldMapInfo();
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

	// Token: 0x06016F44 RID: 94020 RVA: 0x0062A008 File Offset: 0x00628208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.m_regionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F45 RID: 94021 RVA: 0x0062A05C File Offset: 0x0062825C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			ConfigDataRegionInfo[] regionInfos;
			LuaObject.checkArray<ConfigDataRegionInfo>(l, 2, out regionInfos);
			configDataWorldMapInfo.m_regionInfos = regionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F46 RID: 94022 RVA: 0x0062A0B4 File Offset: 0x006282B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startRegionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.m_startRegionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F47 RID: 94023 RVA: 0x0062A108 File Offset: 0x00628308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startRegionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			ConfigDataRegionInfo startRegionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out startRegionInfo);
			configDataWorldMapInfo.m_startRegionInfo = startRegionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F48 RID: 94024 RVA: 0x0062A160 File Offset: 0x00628360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.m_startWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F49 RID: 94025 RVA: 0x0062A1B4 File Offset: 0x006283B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo startWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out startWaypointInfo);
			configDataWorldMapInfo.m_startWaypointInfo = startWaypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F4A RID: 94026 RVA: 0x0062A20C File Offset: 0x0062840C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F4B RID: 94027 RVA: 0x0062A260 File Offset: 0x00628460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataWorldMapInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F4C RID: 94028 RVA: 0x0062A2B8 File Offset: 0x006284B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F4D RID: 94029 RVA: 0x0062A30C File Offset: 0x0062850C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataWorldMapInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F4E RID: 94030 RVA: 0x0062A364 File Offset: 0x00628564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F4F RID: 94031 RVA: 0x0062A3B8 File Offset: 0x006285B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataWorldMapInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F50 RID: 94032 RVA: 0x0062A410 File Offset: 0x00628610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F51 RID: 94033 RVA: 0x0062A464 File Offset: 0x00628664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataWorldMapInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F52 RID: 94034 RVA: 0x0062A4BC File Offset: 0x006286BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Regions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.Regions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F53 RID: 94035 RVA: 0x0062A510 File Offset: 0x00628710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartRegion_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.StartRegion_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F54 RID: 94036 RVA: 0x0062A564 File Offset: 0x00628764
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StartRegion_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			int startRegion_ID;
			LuaObject.checkType(l, 2, out startRegion_ID);
			configDataWorldMapInfo.StartRegion_ID = startRegion_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F55 RID: 94037 RVA: 0x0062A5BC File Offset: 0x006287BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartWaypoint_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.StartWaypoint_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F56 RID: 94038 RVA: 0x0062A610 File Offset: 0x00628810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StartWaypoint_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			int startWaypoint_ID;
			LuaObject.checkType(l, 2, out startWaypoint_ID);
			configDataWorldMapInfo.StartWaypoint_ID = startWaypoint_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F57 RID: 94039 RVA: 0x0062A668 File Offset: 0x00628868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldMap(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.WorldMap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F58 RID: 94040 RVA: 0x0062A6BC File Offset: 0x006288BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WorldMap(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			string worldMap;
			LuaObject.checkType(l, 2, out worldMap);
			configDataWorldMapInfo.WorldMap = worldMap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F59 RID: 94041 RVA: 0x0062A714 File Offset: 0x00628914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BackgroundWidth(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.BackgroundWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F5A RID: 94042 RVA: 0x0062A768 File Offset: 0x00628968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BackgroundWidth(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			int backgroundWidth;
			LuaObject.checkType(l, 2, out backgroundWidth);
			configDataWorldMapInfo.BackgroundWidth = backgroundWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F5B RID: 94043 RVA: 0x0062A7C0 File Offset: 0x006289C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BackgroundHeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWorldMapInfo.BackgroundHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F5C RID: 94044 RVA: 0x0062A814 File Offset: 0x00628A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BackgroundHeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWorldMapInfo configDataWorldMapInfo = (ConfigDataWorldMapInfo)LuaObject.checkSelf(l);
			int backgroundHeight;
			LuaObject.checkType(l, 2, out backgroundHeight);
			configDataWorldMapInfo.BackgroundHeight = backgroundHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F5D RID: 94045 RVA: 0x0062A86C File Offset: 0x00628A6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataWorldMapInfo");
		string name = "m_regionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_m_regionInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_m_regionInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache1, true);
		string name2 = "m_startRegionInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_m_startRegionInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_m_startRegionInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache3, true);
		string name3 = "m_startWaypointInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_m_startWaypointInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_m_startWaypointInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache9, true);
		string name6 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_NameStrKey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheB, true);
		string name7 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_Desc);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_Desc);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheD, true);
		string name8 = "Regions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_Regions_ID);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheE, null, true);
		string name9 = "StartRegion_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_StartRegion_ID);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_StartRegion_ID);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache10, true);
		string name10 = "StartWaypoint_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_StartWaypoint_ID);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_StartWaypoint_ID);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache12, true);
		string name11 = "WorldMap";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_WorldMap);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_WorldMap);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache14, true);
		string name12 = "BackgroundWidth";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_BackgroundWidth);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_BackgroundWidth);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache16, true);
		string name13 = "BackgroundHeight";
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.get_BackgroundHeight);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.set_BackgroundHeight);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache18, true);
		if (Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.<>f__mg$cache19, typeof(ConfigDataWorldMapInfo));
	}

	// Token: 0x0400D635 RID: 54837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D636 RID: 54838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D637 RID: 54839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D638 RID: 54840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D639 RID: 54841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D63A RID: 54842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D63B RID: 54843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D63C RID: 54844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D63D RID: 54845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D63E RID: 54846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D63F RID: 54847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D640 RID: 54848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D641 RID: 54849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D642 RID: 54850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D643 RID: 54851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D644 RID: 54852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D645 RID: 54853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D646 RID: 54854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D647 RID: 54855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D648 RID: 54856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D649 RID: 54857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D64A RID: 54858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D64B RID: 54859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D64C RID: 54860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D64D RID: 54861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D64E RID: 54862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
