using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200116D RID: 4461
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo : LuaObject
{
	// Token: 0x06016DFC RID: 93692 RVA: 0x00620DEC File Offset: 0x0061EFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo o = new ConfigDataThearchyTrialInfo();
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

	// Token: 0x06016DFD RID: 93693 RVA: 0x00620E34 File Offset: 0x0061F034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.m_levelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DFE RID: 93694 RVA: 0x00620E88 File Offset: 0x0061F088
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			List<ConfigDataThearchyTrialLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataThearchyTrialLevelInfo>>(l, 2, out levelInfos);
			configDataThearchyTrialInfo.m_levelInfos = levelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DFF RID: 93695 RVA: 0x00620EE0 File Offset: 0x0061F0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E00 RID: 93696 RVA: 0x00620F34 File Offset: 0x0061F134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataThearchyTrialInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E01 RID: 93697 RVA: 0x00620F8C File Offset: 0x0061F18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E02 RID: 93698 RVA: 0x00620FE0 File Offset: 0x0061F1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataThearchyTrialInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E03 RID: 93699 RVA: 0x00621038 File Offset: 0x0061F238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E04 RID: 93700 RVA: 0x0062108C File Offset: 0x0061F28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataThearchyTrialInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E05 RID: 93701 RVA: 0x006210E4 File Offset: 0x0061F2E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E06 RID: 93702 RVA: 0x00621138 File Offset: 0x0061F338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataThearchyTrialInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E07 RID: 93703 RVA: 0x00621190 File Offset: 0x0061F390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.LevelList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E08 RID: 93704 RVA: 0x006211E4 File Offset: 0x0061F3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartTimeList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.StartTimeList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E09 RID: 93705 RVA: 0x00621238 File Offset: 0x0061F438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Armys_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.Armys_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E0A RID: 93706 RVA: 0x0062128C File Offset: 0x0061F48C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E0B RID: 93707 RVA: 0x006212E0 File Offset: 0x0061F4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataThearchyTrialInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E0C RID: 93708 RVA: 0x00621338 File Offset: 0x0061F538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Fx(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.Fx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E0D RID: 93709 RVA: 0x0062138C File Offset: 0x0061F58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Fx(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			string fx;
			LuaObject.checkType(l, 2, out fx);
			configDataThearchyTrialInfo.Fx = fx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E0E RID: 93710 RVA: 0x006213E4 File Offset: 0x0061F5E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.UI_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E0F RID: 93711 RVA: 0x00621438 File Offset: 0x0061F638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			int ui_ModelScale;
			LuaObject.checkType(l, 2, out ui_ModelScale);
			configDataThearchyTrialInfo.UI_ModelScale = ui_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E10 RID: 93712 RVA: 0x00621490 File Offset: 0x0061F690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.UI_ModelOffsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E11 RID: 93713 RVA: 0x006214E4 File Offset: 0x0061F6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetX;
			LuaObject.checkType(l, 2, out ui_ModelOffsetX);
			configDataThearchyTrialInfo.UI_ModelOffsetX = ui_ModelOffsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E12 RID: 93714 RVA: 0x0062153C File Offset: 0x0061F73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialInfo.UI_ModelOffsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E13 RID: 93715 RVA: 0x00621590 File Offset: 0x0061F790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = (ConfigDataThearchyTrialInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetY;
			LuaObject.checkType(l, 2, out ui_ModelOffsetY);
			configDataThearchyTrialInfo.UI_ModelOffsetY = ui_ModelOffsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E14 RID: 93716 RVA: 0x006215E8 File Offset: 0x0061F7E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataThearchyTrialInfo");
		string name = "m_levelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_m_levelInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_m_levelInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache7, true);
		string name5 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_TeamName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_TeamName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache9, true);
		string name6 = "LevelList";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_LevelList);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheA, null, true);
		string name7 = "StartTimeList";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_StartTimeList);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheB, null, true);
		string name8 = "Armys_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_Armys_ID);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheC, null, true);
		string name9 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_Model);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_Model);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheE, true);
		string name10 = "Fx";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_Fx);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_Fx);
		}
		LuaObject.addMember(l, name10, get7, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache10, true);
		string name11 = "UI_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_UI_ModelScale);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_UI_ModelScale);
		}
		LuaObject.addMember(l, name11, get8, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache12, true);
		string name12 = "UI_ModelOffsetX";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_UI_ModelOffsetX);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_UI_ModelOffsetX);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache14, true);
		string name13 = "UI_ModelOffsetY";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.get_UI_ModelOffsetY);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.set_UI_ModelOffsetY);
		}
		LuaObject.addMember(l, name13, get10, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache16, true);
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.<>f__mg$cache17, typeof(ConfigDataThearchyTrialInfo));
	}

	// Token: 0x0400D504 RID: 54532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D505 RID: 54533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D506 RID: 54534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D507 RID: 54535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D508 RID: 54536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D509 RID: 54537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D50A RID: 54538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D50B RID: 54539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D50C RID: 54540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D50D RID: 54541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D50E RID: 54542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D50F RID: 54543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D510 RID: 54544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D511 RID: 54545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D512 RID: 54546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D513 RID: 54547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D514 RID: 54548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D515 RID: 54549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D516 RID: 54550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D517 RID: 54551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D518 RID: 54552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D519 RID: 54553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D51A RID: 54554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D51B RID: 54555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
