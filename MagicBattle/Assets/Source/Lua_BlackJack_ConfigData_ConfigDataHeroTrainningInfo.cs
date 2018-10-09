using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200115A RID: 4442
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo : LuaObject
{
	// Token: 0x060169D8 RID: 92632 RVA: 0x00602768 File Offset: 0x00600968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo o = new ConfigDataHeroTrainningInfo();
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

	// Token: 0x060169D9 RID: 92633 RVA: 0x006027B0 File Offset: 0x006009B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.m_levelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169DA RID: 92634 RVA: 0x00602804 File Offset: 0x00600A04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			List<ConfigDataHeroTrainningLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataHeroTrainningLevelInfo>>(l, 2, out levelInfos);
			configDataHeroTrainningInfo.m_levelInfos = levelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169DB RID: 92635 RVA: 0x0060285C File Offset: 0x00600A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169DC RID: 92636 RVA: 0x006028B0 File Offset: 0x00600AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroTrainningInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169DD RID: 92637 RVA: 0x00602908 File Offset: 0x00600B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169DE RID: 92638 RVA: 0x0060295C File Offset: 0x00600B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroTrainningInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169DF RID: 92639 RVA: 0x006029B4 File Offset: 0x00600BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E0 RID: 92640 RVA: 0x00602A08 File Offset: 0x00600C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataHeroTrainningInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E1 RID: 92641 RVA: 0x00602A60 File Offset: 0x00600C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E2 RID: 92642 RVA: 0x00602AB4 File Offset: 0x00600CB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataHeroTrainningInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E3 RID: 92643 RVA: 0x00602B0C File Offset: 0x00600D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.LevelList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E4 RID: 92644 RVA: 0x00602B60 File Offset: 0x00600D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartTimeList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.StartTimeList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E5 RID: 92645 RVA: 0x00602BB4 File Offset: 0x00600DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E6 RID: 92646 RVA: 0x00602C08 File Offset: 0x00600E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataHeroTrainningInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E7 RID: 92647 RVA: 0x00602C60 File Offset: 0x00600E60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E8 RID: 92648 RVA: 0x00602CB4 File Offset: 0x00600EB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataHeroTrainningInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169E9 RID: 92649 RVA: 0x00602D0C File Offset: 0x00600F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.UI_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169EA RID: 92650 RVA: 0x00602D60 File Offset: 0x00600F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			int ui_ModelScale;
			LuaObject.checkType(l, 2, out ui_ModelScale);
			configDataHeroTrainningInfo.UI_ModelScale = ui_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169EB RID: 92651 RVA: 0x00602DB8 File Offset: 0x00600FB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.UI_ModelOffsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169EC RID: 92652 RVA: 0x00602E0C File Offset: 0x0060100C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetX;
			LuaObject.checkType(l, 2, out ui_ModelOffsetX);
			configDataHeroTrainningInfo.UI_ModelOffsetX = ui_ModelOffsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169ED RID: 92653 RVA: 0x00602E64 File Offset: 0x00601064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningInfo.UI_ModelOffsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169EE RID: 92654 RVA: 0x00602EB8 File Offset: 0x006010B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = (ConfigDataHeroTrainningInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetY;
			LuaObject.checkType(l, 2, out ui_ModelOffsetY);
			configDataHeroTrainningInfo.UI_ModelOffsetY = ui_ModelOffsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169EF RID: 92655 RVA: 0x00602F10 File Offset: 0x00601110
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroTrainningInfo");
		string name = "m_levelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_m_levelInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_m_levelInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache7, true);
		string name5 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_TeamName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_TeamName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache9, true);
		string name6 = "LevelList";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_LevelList);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheA, null, true);
		string name7 = "StartTimeList";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_StartTimeList);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheB, null, true);
		string name8 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_Icon);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_Icon);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheD, true);
		string name9 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_Model);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_Model);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cacheF, true);
		string name10 = "UI_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_UI_ModelScale);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_UI_ModelScale);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache11, true);
		string name11 = "UI_ModelOffsetX";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_UI_ModelOffsetX);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_UI_ModelOffsetX);
		}
		LuaObject.addMember(l, name11, get9, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache13, true);
		string name12 = "UI_ModelOffsetY";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.get_UI_ModelOffsetY);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.set_UI_ModelOffsetY);
		}
		LuaObject.addMember(l, name12, get10, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache15, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.<>f__mg$cache16, typeof(ConfigDataHeroTrainningInfo));
	}

	// Token: 0x0400D106 RID: 53510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D107 RID: 53511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D108 RID: 53512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D109 RID: 53513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D10A RID: 53514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D10B RID: 53515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D10C RID: 53516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D10D RID: 53517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D10E RID: 53518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D10F RID: 53519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D110 RID: 53520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D111 RID: 53521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D112 RID: 53522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D113 RID: 53523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D114 RID: 53524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D115 RID: 53525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D116 RID: 53526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D117 RID: 53527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D118 RID: 53528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D119 RID: 53529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D11A RID: 53530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D11B RID: 53531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D11C RID: 53532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
