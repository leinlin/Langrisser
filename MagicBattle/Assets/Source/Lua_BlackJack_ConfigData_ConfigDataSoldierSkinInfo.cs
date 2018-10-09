using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200116C RID: 4460
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo : LuaObject
{
	// Token: 0x06016DE8 RID: 93672 RVA: 0x0062053C File Offset: 0x0061E73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo o = new ConfigDataSoldierSkinInfo();
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

	// Token: 0x06016DE9 RID: 93673 RVA: 0x00620584 File Offset: 0x0061E784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FixedStoreItemId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.FixedStoreItemId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DEA RID: 93674 RVA: 0x006205D8 File Offset: 0x0061E7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FixedStoreItemId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			int fixedStoreItemId;
			LuaObject.checkType(l, 2, out fixedStoreItemId);
			configDataSoldierSkinInfo.FixedStoreItemId = fixedStoreItemId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DEB RID: 93675 RVA: 0x00620630 File Offset: 0x0061E830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DEC RID: 93676 RVA: 0x00620684 File Offset: 0x0061E884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataSoldierSkinInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DED RID: 93677 RVA: 0x006206DC File Offset: 0x0061E8DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DEE RID: 93678 RVA: 0x00620730 File Offset: 0x0061E930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataSoldierSkinInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DEF RID: 93679 RVA: 0x00620788 File Offset: 0x0061E988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowInListSkinResInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.ShowInListSkinResInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF0 RID: 93680 RVA: 0x006207DC File Offset: 0x0061E9DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SpecifiedSoldier(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.SpecifiedSoldier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF1 RID: 93681 RVA: 0x00620830 File Offset: 0x0061EA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF2 RID: 93682 RVA: 0x00620884 File Offset: 0x0061EA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataSoldierSkinInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF3 RID: 93683 RVA: 0x006208DC File Offset: 0x0061EADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF4 RID: 93684 RVA: 0x00620930 File Offset: 0x0061EB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataSoldierSkinInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF5 RID: 93685 RVA: 0x00620988 File Offset: 0x0061EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetPathList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.GetPathList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF6 RID: 93686 RVA: 0x006209DC File Offset: 0x0061EBDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GetPathDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.GetPathDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF7 RID: 93687 RVA: 0x00620A30 File Offset: 0x0061EC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetPathDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			string getPathDesc;
			LuaObject.checkType(l, 2, out getPathDesc);
			configDataSoldierSkinInfo.GetPathDesc = getPathDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF8 RID: 93688 RVA: 0x00620A88 File Offset: 0x0061EC88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsShowBeforeGet(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierSkinInfo.IsShowBeforeGet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DF9 RID: 93689 RVA: 0x00620ADC File Offset: 0x0061ECDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsShowBeforeGet(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = (ConfigDataSoldierSkinInfo)LuaObject.checkSelf(l);
			bool isShowBeforeGet;
			LuaObject.checkType(l, 2, out isShowBeforeGet);
			configDataSoldierSkinInfo.IsShowBeforeGet = isShowBeforeGet;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DFA RID: 93690 RVA: 0x00620B34 File Offset: 0x0061ED34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataSoldierSkinInfo");
		string name = "FixedStoreItemId";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_FixedStoreItemId);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_FixedStoreItemId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache5, true);
		string name4 = "ShowInListSkinResInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_ShowInListSkinResInfo);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache6, null, true);
		string name5 = "SpecifiedSoldier";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_SpecifiedSoldier);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache7, null, true);
		string name6 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_Desc);
		}
		LuaObject.addMember(l, name6, get4, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache9, true);
		string name7 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_Icon);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_Icon);
		}
		LuaObject.addMember(l, name7, get5, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheB, true);
		string name8 = "GetPathList";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_GetPathList);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheC, null, true);
		string name9 = "GetPathDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_GetPathDesc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_GetPathDesc);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheE, true);
		string name10 = "IsShowBeforeGet";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.get_IsShowBeforeGet);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.set_IsShowBeforeGet);
		}
		LuaObject.addMember(l, name10, get7, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache10, true);
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.<>f__mg$cache11, typeof(ConfigDataSoldierSkinInfo));
	}

	// Token: 0x0400D4F2 RID: 54514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D4F3 RID: 54515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D4F4 RID: 54516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D4F5 RID: 54517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D4F6 RID: 54518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D4F7 RID: 54519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D4F8 RID: 54520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D4F9 RID: 54521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D4FA RID: 54522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D4FB RID: 54523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D4FC RID: 54524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D4FD RID: 54525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D4FE RID: 54526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D4FF RID: 54527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D500 RID: 54528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D501 RID: 54529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D502 RID: 54530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D503 RID: 54531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
