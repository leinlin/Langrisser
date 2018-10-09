using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001165 RID: 4453
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataRegionInfo : LuaObject
{
	// Token: 0x06016BDF RID: 93151 RVA: 0x00611450 File Offset: 0x0060F650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo o = new ConfigDataRegionInfo();
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

	// Token: 0x06016BE0 RID: 93152 RVA: 0x00611498 File Offset: 0x0060F698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_waypointInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.m_waypointInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE1 RID: 93153 RVA: 0x006114EC File Offset: 0x0060F6EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_waypointInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo[] waypointInfos;
			LuaObject.checkArray<ConfigDataWaypointInfo>(l, 2, out waypointInfos);
			configDataRegionInfo.m_waypointInfos = waypointInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE2 RID: 93154 RVA: 0x00611544 File Offset: 0x0060F744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_openByScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.m_openByScenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE3 RID: 93155 RVA: 0x00611598 File Offset: 0x0060F798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_openByScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo openByScenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out openByScenarioInfo);
			configDataRegionInfo.m_openByScenarioInfo = openByScenarioInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE4 RID: 93156 RVA: 0x006115F0 File Offset: 0x0060F7F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE5 RID: 93157 RVA: 0x00611644 File Offset: 0x0060F844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataRegionInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE6 RID: 93158 RVA: 0x0061169C File Offset: 0x0060F89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE7 RID: 93159 RVA: 0x006116F0 File Offset: 0x0060F8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataRegionInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE8 RID: 93160 RVA: 0x00611748 File Offset: 0x0060F948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BE9 RID: 93161 RVA: 0x0061179C File Offset: 0x0060F99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataRegionInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BEA RID: 93162 RVA: 0x006117F4 File Offset: 0x0060F9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BEB RID: 93163 RVA: 0x00611848 File Offset: 0x0060FA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataRegionInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BEC RID: 93164 RVA: 0x006118A0 File Offset: 0x0060FAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BED RID: 93165 RVA: 0x006118F4 File Offset: 0x0060FAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataRegionInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BEE RID: 93166 RVA: 0x0061194C File Offset: 0x0060FB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Waypoints_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.Waypoints_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BEF RID: 93167 RVA: 0x006119A0 File Offset: 0x0060FBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenByScenario_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRegionInfo.OpenByScenario_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF0 RID: 93168 RVA: 0x006119F4 File Offset: 0x0060FBF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpenByScenario_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRegionInfo configDataRegionInfo = (ConfigDataRegionInfo)LuaObject.checkSelf(l);
			int openByScenario_ID;
			LuaObject.checkType(l, 2, out openByScenario_ID);
			configDataRegionInfo.OpenByScenario_ID = openByScenario_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF1 RID: 93169 RVA: 0x00611A4C File Offset: 0x0060FC4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataRegionInfo");
		string name = "m_waypointInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_m_waypointInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_m_waypointInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache1, true);
		string name2 = "m_openByScenarioInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_m_openByScenarioInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_m_openByScenarioInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache7, true);
		string name5 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_NameStrKey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache9, true);
		string name6 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_Desc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_Desc);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheB, true);
		string name7 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_DescStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheD, true);
		string name8 = "Waypoints_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_Waypoints_ID);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheE, null, true);
		string name9 = "OpenByScenario_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.get_OpenByScenario_ID);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.set_OpenByScenario_ID);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache10, true);
		if (Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataRegionInfo.<>f__mg$cache11, typeof(ConfigDataRegionInfo));
	}

	// Token: 0x0400D2F7 RID: 54007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D2F8 RID: 54008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D2F9 RID: 54009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D2FA RID: 54010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D2FB RID: 54011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D2FC RID: 54012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D2FD RID: 54013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D2FE RID: 54014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D2FF RID: 54015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D300 RID: 54016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D301 RID: 54017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D302 RID: 54018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D303 RID: 54019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D304 RID: 54020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D305 RID: 54021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D306 RID: 54022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D307 RID: 54023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D308 RID: 54024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
