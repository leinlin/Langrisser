using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200114E RID: 4430
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo : LuaObject
{
	// Token: 0x06016813 RID: 92179 RVA: 0x005F5A34 File Offset: 0x005F3C34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo o = new ConfigDataFreeCardPoolGroupInfo();
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

	// Token: 0x06016814 RID: 92180 RVA: 0x005F5A7C File Offset: 0x005F3C7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016815 RID: 92181 RVA: 0x005F5AD0 File Offset: 0x005F3CD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataFreeCardPoolGroupInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016816 RID: 92182 RVA: 0x005F5B28 File Offset: 0x005F3D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Description(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.Description);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016817 RID: 92183 RVA: 0x005F5B7C File Offset: 0x005F3D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Description(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			string description;
			LuaObject.checkType(l, 2, out description);
			configDataFreeCardPoolGroupInfo.Description = description;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016818 RID: 92184 RVA: 0x005F5BD4 File Offset: 0x005F3DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.GroupID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016819 RID: 92185 RVA: 0x005F5C28 File Offset: 0x005F3E28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			int groupID;
			LuaObject.checkType(l, 2, out groupID);
			configDataFreeCardPoolGroupInfo.GroupID = groupID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601681A RID: 92186 RVA: 0x005F5C80 File Offset: 0x005F3E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardItems(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.CardItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601681B RID: 92187 RVA: 0x005F5CD4 File Offset: 0x005F3ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.DefaultWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601681C RID: 92188 RVA: 0x005F5D28 File Offset: 0x005F3F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			int defaultWeight;
			LuaObject.checkType(l, 2, out defaultWeight);
			configDataFreeCardPoolGroupInfo.DefaultWeight = defaultWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601681D RID: 92189 RVA: 0x005F5D80 File Offset: 0x005F3F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardPoolItemID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.CardPoolItemID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601681E RID: 92190 RVA: 0x005F5DD4 File Offset: 0x005F3FD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Items(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.Items);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601681F RID: 92191 RVA: 0x005F5E28 File Offset: 0x005F4028
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemDefaultWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataFreeCardPoolGroupInfo configDataFreeCardPoolGroupInfo = (ConfigDataFreeCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataFreeCardPoolGroupInfo.ItemDefaultWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016820 RID: 92192 RVA: 0x005F5E7C File Offset: 0x005F407C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataFreeCardPoolGroupInfo");
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache1, true);
		string name2 = "Description";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_Description);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.set_Description);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache3, true);
		string name3 = "GroupID";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_GroupID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.set_GroupID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache5, true);
		string name4 = "CardItems";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_CardItems);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache6, null, true);
		string name5 = "DefaultWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_DefaultWeight);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.set_DefaultWeight);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache8, true);
		string name6 = "CardPoolItemID";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_CardPoolItemID);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cache9, null, true);
		string name7 = "Items";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_Items);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheA, null, true);
		string name8 = "ItemDefaultWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.get_ItemDefaultWeight);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheB, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.<>f__mg$cacheC, typeof(ConfigDataFreeCardPoolGroupInfo));
	}

	// Token: 0x0400CF59 RID: 53081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CF5A RID: 53082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CF5B RID: 53083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CF5C RID: 53084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CF5D RID: 53085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CF5E RID: 53086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CF5F RID: 53087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CF60 RID: 53088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CF61 RID: 53089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CF62 RID: 53090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CF63 RID: 53091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CF64 RID: 53092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CF65 RID: 53093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
