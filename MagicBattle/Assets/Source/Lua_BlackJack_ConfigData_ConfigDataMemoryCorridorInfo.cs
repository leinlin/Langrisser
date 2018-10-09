using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200115F RID: 4447
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo : LuaObject
{
	// Token: 0x06016ADF RID: 92895 RVA: 0x00609FEC File Offset: 0x006081EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo o = new ConfigDataMemoryCorridorInfo();
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

	// Token: 0x06016AE0 RID: 92896 RVA: 0x0060A034 File Offset: 0x00608234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.m_levelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE1 RID: 92897 RVA: 0x0060A088 File Offset: 0x00608288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			List<ConfigDataMemoryCorridorLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataMemoryCorridorLevelInfo>>(l, 2, out levelInfos);
			configDataMemoryCorridorInfo.m_levelInfos = levelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE2 RID: 92898 RVA: 0x0060A0E0 File Offset: 0x006082E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE3 RID: 92899 RVA: 0x0060A134 File Offset: 0x00608334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataMemoryCorridorInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE4 RID: 92900 RVA: 0x0060A18C File Offset: 0x0060838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE5 RID: 92901 RVA: 0x0060A1E0 File Offset: 0x006083E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataMemoryCorridorInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE6 RID: 92902 RVA: 0x0060A238 File Offset: 0x00608438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE7 RID: 92903 RVA: 0x0060A28C File Offset: 0x0060848C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataMemoryCorridorInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE8 RID: 92904 RVA: 0x0060A2E4 File Offset: 0x006084E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AE9 RID: 92905 RVA: 0x0060A338 File Offset: 0x00608538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataMemoryCorridorInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AEA RID: 92906 RVA: 0x0060A390 File Offset: 0x00608590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.LevelList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AEB RID: 92907 RVA: 0x0060A3E4 File Offset: 0x006085E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartTimeList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.StartTimeList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AEC RID: 92908 RVA: 0x0060A438 File Offset: 0x00608638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Background(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.Background);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AED RID: 92909 RVA: 0x0060A48C File Offset: 0x0060868C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Background(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			string background;
			LuaObject.checkType(l, 2, out background);
			configDataMemoryCorridorInfo.Background = background;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AEE RID: 92910 RVA: 0x0060A4E4 File Offset: 0x006086E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AEF RID: 92911 RVA: 0x0060A538 File Offset: 0x00608738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataMemoryCorridorInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF0 RID: 92912 RVA: 0x0060A590 File Offset: 0x00608790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.UI_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF1 RID: 92913 RVA: 0x0060A5E4 File Offset: 0x006087E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			int ui_ModelScale;
			LuaObject.checkType(l, 2, out ui_ModelScale);
			configDataMemoryCorridorInfo.UI_ModelScale = ui_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF2 RID: 92914 RVA: 0x0060A63C File Offset: 0x0060883C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.UI_ModelOffsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF3 RID: 92915 RVA: 0x0060A690 File Offset: 0x00608890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetX;
			LuaObject.checkType(l, 2, out ui_ModelOffsetX);
			configDataMemoryCorridorInfo.UI_ModelOffsetX = ui_ModelOffsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF4 RID: 92916 RVA: 0x0060A6E8 File Offset: 0x006088E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorInfo.UI_ModelOffsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF5 RID: 92917 RVA: 0x0060A73C File Offset: 0x0060893C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = (ConfigDataMemoryCorridorInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetY;
			LuaObject.checkType(l, 2, out ui_ModelOffsetY);
			configDataMemoryCorridorInfo.UI_ModelOffsetY = ui_ModelOffsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AF6 RID: 92918 RVA: 0x0060A794 File Offset: 0x00608994
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataMemoryCorridorInfo");
		string name = "m_levelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_m_levelInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_m_levelInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache7, true);
		string name5 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_TeamName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_TeamName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache9, true);
		string name6 = "LevelList";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_LevelList);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheA, null, true);
		string name7 = "StartTimeList";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_StartTimeList);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheB, null, true);
		string name8 = "Background";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_Background);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_Background);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheD, true);
		string name9 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_Model);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_Model);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cacheF, true);
		string name10 = "UI_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_UI_ModelScale);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_UI_ModelScale);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache11, true);
		string name11 = "UI_ModelOffsetX";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_UI_ModelOffsetX);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_UI_ModelOffsetX);
		}
		LuaObject.addMember(l, name11, get9, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache13, true);
		string name12 = "UI_ModelOffsetY";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.get_UI_ModelOffsetY);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.set_UI_ModelOffsetY);
		}
		LuaObject.addMember(l, name12, get10, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache15, true);
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.<>f__mg$cache16, typeof(ConfigDataMemoryCorridorInfo));
	}

	// Token: 0x0400D203 RID: 53763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D204 RID: 53764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D205 RID: 53765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D206 RID: 53766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D207 RID: 53767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D208 RID: 53768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D209 RID: 53769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D20A RID: 53770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D20B RID: 53771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D20C RID: 53772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D20D RID: 53773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D20E RID: 53774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D20F RID: 53775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D210 RID: 53776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D211 RID: 53777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D212 RID: 53778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D213 RID: 53779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D214 RID: 53780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D215 RID: 53781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D216 RID: 53782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D217 RID: 53783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D218 RID: 53784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D219 RID: 53785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
