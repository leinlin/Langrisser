using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200114A RID: 4426
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo : LuaObject
{
	// Token: 0x06016740 RID: 91968 RVA: 0x005EF938 File Offset: 0x005EDB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo o = new ConfigDataCrystalCardPoolGroupInfo();
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

	// Token: 0x06016741 RID: 91969 RVA: 0x005EF980 File Offset: 0x005EDB80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016742 RID: 91970 RVA: 0x005EF9D4 File Offset: 0x005EDBD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataCrystalCardPoolGroupInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016743 RID: 91971 RVA: 0x005EFA2C File Offset: 0x005EDC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Description(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.Description);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016744 RID: 91972 RVA: 0x005EFA80 File Offset: 0x005EDC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Description(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			string description;
			LuaObject.checkType(l, 2, out description);
			configDataCrystalCardPoolGroupInfo.Description = description;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016745 RID: 91973 RVA: 0x005EFAD8 File Offset: 0x005EDCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.GroupID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016746 RID: 91974 RVA: 0x005EFB2C File Offset: 0x005EDD2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			int groupID;
			LuaObject.checkType(l, 2, out groupID);
			configDataCrystalCardPoolGroupInfo.GroupID = groupID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016747 RID: 91975 RVA: 0x005EFB84 File Offset: 0x005EDD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardItems(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.CardItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016748 RID: 91976 RVA: 0x005EFBD8 File Offset: 0x005EDDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.DefaultWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016749 RID: 91977 RVA: 0x005EFC2C File Offset: 0x005EDE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			int defaultWeight;
			LuaObject.checkType(l, 2, out defaultWeight);
			configDataCrystalCardPoolGroupInfo.DefaultWeight = defaultWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601674A RID: 91978 RVA: 0x005EFC84 File Offset: 0x005EDE84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CardPoolItemID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.CardPoolItemID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601674B RID: 91979 RVA: 0x005EFCD8 File Offset: 0x005EDED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Items(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.Items);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601674C RID: 91980 RVA: 0x005EFD2C File Offset: 0x005EDF2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemDefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCrystalCardPoolGroupInfo configDataCrystalCardPoolGroupInfo = (ConfigDataCrystalCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCrystalCardPoolGroupInfo.ItemDefaultWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601674D RID: 91981 RVA: 0x005EFD80 File Offset: 0x005EDF80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataCrystalCardPoolGroupInfo");
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache1, true);
		string name2 = "Description";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_Description);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.set_Description);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache3, true);
		string name3 = "GroupID";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_GroupID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.set_GroupID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache5, true);
		string name4 = "CardItems";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_CardItems);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache6, null, true);
		string name5 = "DefaultWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_DefaultWeight);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.set_DefaultWeight);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache8, true);
		string name6 = "CardPoolItemID";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_CardPoolItemID);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cache9, null, true);
		string name7 = "Items";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_Items);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheA, null, true);
		string name8 = "ItemDefaultWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.get_ItemDefaultWeight);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheB, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.<>f__mg$cacheC, typeof(ConfigDataCrystalCardPoolGroupInfo));
	}

	// Token: 0x0400CE8E RID: 52878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CE8F RID: 52879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CE90 RID: 52880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CE91 RID: 52881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CE92 RID: 52882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CE93 RID: 52883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CE94 RID: 52884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CE95 RID: 52885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CE96 RID: 52886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CE97 RID: 52887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CE98 RID: 52888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CE99 RID: 52889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CE9A RID: 52890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
