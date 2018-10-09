using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001177 RID: 4471
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataWaypointInfo : LuaObject
{
	// Token: 0x06016F26 RID: 93990 RVA: 0x006292D4 File Offset: 0x006274D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo o = new ConfigDataWaypointInfo();
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

	// Token: 0x06016F27 RID: 93991 RVA: 0x0062931C File Offset: 0x0062751C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.m_waypointInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F28 RID: 93992 RVA: 0x00629370 File Offset: 0x00627570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypointInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo[] waypointInfos;
			LuaObject.checkArray<ConfigDataWaypointInfo>(l, 2, out waypointInfos);
			configDataWaypointInfo.m_waypointInfos = waypointInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F29 RID: 93993 RVA: 0x006293C8 File Offset: 0x006275C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.m_regionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F2A RID: 93994 RVA: 0x0062941C File Offset: 0x0062761C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			configDataWaypointInfo.m_regionInfo = regionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F2B RID: 93995 RVA: 0x00629474 File Offset: 0x00627674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F2C RID: 93996 RVA: 0x006294C8 File Offset: 0x006276C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataWaypointInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F2D RID: 93997 RVA: 0x00629520 File Offset: 0x00627720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F2E RID: 93998 RVA: 0x00629574 File Offset: 0x00627774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataWaypointInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F2F RID: 93999 RVA: 0x006295CC File Offset: 0x006277CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F30 RID: 94000 RVA: 0x00629620 File Offset: 0x00627820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataWaypointInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F31 RID: 94001 RVA: 0x00629678 File Offset: 0x00627878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F32 RID: 94002 RVA: 0x006296CC File Offset: 0x006278CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataWaypointInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F33 RID: 94003 RVA: 0x00629724 File Offset: 0x00627924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F34 RID: 94004 RVA: 0x00629778 File Offset: 0x00627978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataWaypointInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F35 RID: 94005 RVA: 0x006297D0 File Offset: 0x006279D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FuncType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataWaypointInfo.FuncType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F36 RID: 94006 RVA: 0x00629824 File Offset: 0x00627A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FuncType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			WaypointFuncType funcType;
			LuaObject.checkEnum<WaypointFuncType>(l, 2, out funcType);
			configDataWaypointInfo.FuncType = funcType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F37 RID: 94007 RVA: 0x0062987C File Offset: 0x00627A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FuncTypeParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.FuncTypeParam1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F38 RID: 94008 RVA: 0x006298D0 File Offset: 0x00627AD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FuncTypeParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			int funcTypeParam;
			LuaObject.checkType(l, 2, out funcTypeParam);
			configDataWaypointInfo.FuncTypeParam1 = funcTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F39 RID: 94009 RVA: 0x00629928 File Offset: 0x00627B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Waypoints_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.Waypoints_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F3A RID: 94010 RVA: 0x0062997C File Offset: 0x00627B7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StyleType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataWaypointInfo.StyleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F3B RID: 94011 RVA: 0x006299D0 File Offset: 0x00627BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StyleType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			WaypointStyleType styleType;
			LuaObject.checkEnum<WaypointStyleType>(l, 2, out styleType);
			configDataWaypointInfo.StyleType = styleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F3C RID: 94012 RVA: 0x00629A28 File Offset: 0x00627C28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F3D RID: 94013 RVA: 0x00629A7C File Offset: 0x00627C7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataWaypointInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F3E RID: 94014 RVA: 0x00629AD4 File Offset: 0x00627CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Background(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.Background);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F3F RID: 94015 RVA: 0x00629B28 File Offset: 0x00627D28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Background(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			string background;
			LuaObject.checkType(l, 2, out background);
			configDataWaypointInfo.Background = background;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F40 RID: 94016 RVA: 0x00629B80 File Offset: 0x00627D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StateList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataWaypointInfo configDataWaypointInfo = (ConfigDataWaypointInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataWaypointInfo.StateList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F41 RID: 94017 RVA: 0x00629BD4 File Offset: 0x00627DD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataWaypointInfo");
		string name = "m_waypointInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_m_waypointInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_m_waypointInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache1, true);
		string name2 = "m_regionInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_m_regionInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_m_regionInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache7, true);
		string name5 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_NameStrKey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache9, true);
		string name6 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_Desc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_Desc);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheB, true);
		string name7 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_DescStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheD, true);
		string name8 = "FuncType";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_FuncType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_FuncType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cacheF, true);
		string name9 = "FuncTypeParam1";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_FuncTypeParam1);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_FuncTypeParam1);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache11, true);
		string name10 = "Waypoints_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_Waypoints_ID);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache12, null, true);
		string name11 = "StyleType";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_StyleType);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_StyleType);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache14, true);
		string name12 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_Model);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_Model);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache16, true);
		string name13 = "Background";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_Background);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.set_Background);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache18, true);
		string name14 = "StateList";
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.get_StateList);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache19, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.<>f__mg$cache1A, typeof(ConfigDataWaypointInfo));
	}

	// Token: 0x0400D61A RID: 54810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D61B RID: 54811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D61C RID: 54812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D61D RID: 54813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D61E RID: 54814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D61F RID: 54815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D620 RID: 54816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D621 RID: 54817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D622 RID: 54818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D623 RID: 54819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D624 RID: 54820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D625 RID: 54821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D626 RID: 54822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D627 RID: 54823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D628 RID: 54824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D629 RID: 54825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D62A RID: 54826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D62B RID: 54827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D62C RID: 54828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D62D RID: 54829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D62E RID: 54830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D62F RID: 54831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D630 RID: 54832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D631 RID: 54833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D632 RID: 54834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D633 RID: 54835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D634 RID: 54836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
