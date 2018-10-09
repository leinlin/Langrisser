using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001148 RID: 4424
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo : LuaObject
{
	// Token: 0x060166F8 RID: 91896 RVA: 0x005ED8C4 File Offset: 0x005EBAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo o = new ConfigDataCooperateBattleInfo();
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

	// Token: 0x060166F9 RID: 91897 RVA: 0x005ED90C File Offset: 0x005EBB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.m_levelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166FA RID: 91898 RVA: 0x005ED960 File Offset: 0x005EBB60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			List<ConfigDataCooperateBattleLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataCooperateBattleLevelInfo>>(l, 2, out levelInfos);
			configDataCooperateBattleInfo.m_levelInfos = levelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166FB RID: 91899 RVA: 0x005ED9B8 File Offset: 0x005EBBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenTimeSpan(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.OpenTimeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166FC RID: 91900 RVA: 0x005EDA10 File Offset: 0x005EBC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpenTimeSpan(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			TimeSpan openTimeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 2, out openTimeSpan);
			configDataCooperateBattleInfo.OpenTimeSpan = openTimeSpan;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166FD RID: 91901 RVA: 0x005EDA68 File Offset: 0x005EBC68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CloseTimeSpan(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.CloseTimeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166FE RID: 91902 RVA: 0x005EDAC0 File Offset: 0x005EBCC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CloseTimeSpan(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			TimeSpan closeTimeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 2, out closeTimeSpan);
			configDataCooperateBattleInfo.CloseTimeSpan = closeTimeSpan;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166FF RID: 91903 RVA: 0x005EDB18 File Offset: 0x005EBD18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpenDaysOfWeek(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.OpenDaysOfWeek);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016700 RID: 91904 RVA: 0x005EDB6C File Offset: 0x005EBD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OpenDaysOfWeek(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			List<DayOfWeek> openDaysOfWeek;
			LuaObject.checkType<List<DayOfWeek>>(l, 2, out openDaysOfWeek);
			configDataCooperateBattleInfo.OpenDaysOfWeek = openDaysOfWeek;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016701 RID: 91905 RVA: 0x005EDBC4 File Offset: 0x005EBDC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016702 RID: 91906 RVA: 0x005EDC18 File Offset: 0x005EBE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataCooperateBattleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016703 RID: 91907 RVA: 0x005EDC70 File Offset: 0x005EBE70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016704 RID: 91908 RVA: 0x005EDCC4 File Offset: 0x005EBEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataCooperateBattleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016705 RID: 91909 RVA: 0x005EDD1C File Offset: 0x005EBF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016706 RID: 91910 RVA: 0x005EDD70 File Offset: 0x005EBF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataCooperateBattleInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016707 RID: 91911 RVA: 0x005EDDC8 File Offset: 0x005EBFC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016708 RID: 91912 RVA: 0x005EDE1C File Offset: 0x005EC01C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataCooperateBattleInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016709 RID: 91913 RVA: 0x005EDE74 File Offset: 0x005EC074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601670A RID: 91914 RVA: 0x005EDEC8 File Offset: 0x005EC0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string image;
			LuaObject.checkType(l, 2, out image);
			configDataCooperateBattleInfo.Image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601670B RID: 91915 RVA: 0x005EDF20 File Offset: 0x005EC120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BriefView(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.BriefView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601670C RID: 91916 RVA: 0x005EDF74 File Offset: 0x005EC174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BriefView(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string briefView;
			LuaObject.checkType(l, 2, out briefView);
			configDataCooperateBattleInfo.BriefView = briefView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601670D RID: 91917 RVA: 0x005EDFCC File Offset: 0x005EC1CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.LevelList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601670E RID: 91918 RVA: 0x005EE020 File Offset: 0x005EC220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenHour(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.OpenHour);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601670F RID: 91919 RVA: 0x005EE074 File Offset: 0x005EC274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpenHour(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string openHour;
			LuaObject.checkType(l, 2, out openHour);
			configDataCooperateBattleInfo.OpenHour = openHour;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016710 RID: 91920 RVA: 0x005EE0CC File Offset: 0x005EC2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CloseHour(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.CloseHour);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016711 RID: 91921 RVA: 0x005EE120 File Offset: 0x005EC320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CloseHour(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			string closeHour;
			LuaObject.checkType(l, 2, out closeHour);
			configDataCooperateBattleInfo.CloseHour = closeHour;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016712 RID: 91922 RVA: 0x005EE178 File Offset: 0x005EC378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenWeekDays(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = (ConfigDataCooperateBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleInfo.OpenWeekDays);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016713 RID: 91923 RVA: 0x005EE1CC File Offset: 0x005EC3CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataCooperateBattleInfo");
		string name = "m_levelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_m_levelInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_m_levelInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache1, true);
		string name2 = "OpenTimeSpan";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_OpenTimeSpan);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_OpenTimeSpan);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache3, true);
		string name3 = "CloseTimeSpan";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_CloseTimeSpan);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_CloseTimeSpan);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache5, true);
		string name4 = "OpenDaysOfWeek";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_OpenDaysOfWeek);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_OpenDaysOfWeek);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheB, true);
		string name7 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_Desc);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_Desc);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheD, true);
		string name8 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_TeamName);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_TeamName);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cacheF, true);
		string name9 = "Image";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_Image);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_Image);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache11, true);
		string name10 = "BriefView";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_BriefView);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_BriefView);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache13, true);
		string name11 = "LevelList";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_LevelList);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache14, null, true);
		string name12 = "OpenHour";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_OpenHour);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_OpenHour);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache16, true);
		string name13 = "CloseHour";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_CloseHour);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.set_CloseHour);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache18, true);
		string name14 = "OpenWeekDays";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.get_OpenWeekDays);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache19, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.<>f__mg$cache1A, typeof(ConfigDataCooperateBattleInfo));
	}

	// Token: 0x0400CE4A RID: 52810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CE4B RID: 52811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CE4C RID: 52812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CE4D RID: 52813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CE4E RID: 52814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CE4F RID: 52815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CE50 RID: 52816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CE51 RID: 52817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CE52 RID: 52818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CE53 RID: 52819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CE54 RID: 52820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CE55 RID: 52821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CE56 RID: 52822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CE57 RID: 52823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CE58 RID: 52824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CE59 RID: 52825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CE5A RID: 52826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CE5B RID: 52827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CE5C RID: 52828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CE5D RID: 52829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CE5E RID: 52830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CE5F RID: 52831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CE60 RID: 52832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CE61 RID: 52833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CE62 RID: 52834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CE63 RID: 52835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CE64 RID: 52836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
