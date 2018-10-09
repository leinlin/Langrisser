using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001133 RID: 4403
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo : LuaObject
{
	// Token: 0x0601641E RID: 91166 RVA: 0x005D8ECC File Offset: 0x005D70CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo o = new ConfigDataActivityCardPoolGroupInfo();
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

	// Token: 0x0601641F RID: 91167 RVA: 0x005D8F14 File Offset: 0x005D7114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016420 RID: 91168 RVA: 0x005D8F68 File Offset: 0x005D7168
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataActivityCardPoolGroupInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016421 RID: 91169 RVA: 0x005D8FC0 File Offset: 0x005D71C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Description(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.Description);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016422 RID: 91170 RVA: 0x005D9014 File Offset: 0x005D7214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Description(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			string description;
			LuaObject.checkType(l, 2, out description);
			configDataActivityCardPoolGroupInfo.Description = description;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016423 RID: 91171 RVA: 0x005D906C File Offset: 0x005D726C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.GroupID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016424 RID: 91172 RVA: 0x005D90C0 File Offset: 0x005D72C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			int groupID;
			LuaObject.checkType(l, 2, out groupID);
			configDataActivityCardPoolGroupInfo.GroupID = groupID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016425 RID: 91173 RVA: 0x005D9118 File Offset: 0x005D7318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CardItems(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.CardItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016426 RID: 91174 RVA: 0x005D916C File Offset: 0x005D736C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.DefaultWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016427 RID: 91175 RVA: 0x005D91C0 File Offset: 0x005D73C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			int defaultWeight;
			LuaObject.checkType(l, 2, out defaultWeight);
			configDataActivityCardPoolGroupInfo.DefaultWeight = defaultWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016428 RID: 91176 RVA: 0x005D9218 File Offset: 0x005D7418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardPoolItemID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.CardPoolItemID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016429 RID: 91177 RVA: 0x005D926C File Offset: 0x005D746C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Items(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.Items);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601642A RID: 91178 RVA: 0x005D92C0 File Offset: 0x005D74C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemDefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataActivityCardPoolGroupInfo configDataActivityCardPoolGroupInfo = (ConfigDataActivityCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataActivityCardPoolGroupInfo.ItemDefaultWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601642B RID: 91179 RVA: 0x005D9314 File Offset: 0x005D7514
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataActivityCardPoolGroupInfo");
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache1, true);
		string name2 = "Description";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_Description);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.set_Description);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache3, true);
		string name3 = "GroupID";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_GroupID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.set_GroupID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache5, true);
		string name4 = "CardItems";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_CardItems);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache6, null, true);
		string name5 = "DefaultWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_DefaultWeight);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.set_DefaultWeight);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache8, true);
		string name6 = "CardPoolItemID";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_CardPoolItemID);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cache9, null, true);
		string name7 = "Items";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_Items);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheA, null, true);
		string name8 = "ItemDefaultWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.get_ItemDefaultWeight);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheB, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.<>f__mg$cacheC, typeof(ConfigDataActivityCardPoolGroupInfo));
	}

	// Token: 0x0400CB9A RID: 52122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CB9B RID: 52123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CB9C RID: 52124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CB9D RID: 52125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CB9E RID: 52126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CB9F RID: 52127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CBA0 RID: 52128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CBA1 RID: 52129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CBA2 RID: 52130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CBA3 RID: 52131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CBA4 RID: 52132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CBA5 RID: 52133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CBA6 RID: 52134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
