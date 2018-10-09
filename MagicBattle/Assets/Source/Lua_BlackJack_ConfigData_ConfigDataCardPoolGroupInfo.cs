using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001144 RID: 4420
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo : LuaObject
{
	// Token: 0x0601664B RID: 91723 RVA: 0x005E8A20 File Offset: 0x005E6C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo o = new ConfigDataCardPoolGroupInfo();
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

	// Token: 0x0601664C RID: 91724 RVA: 0x005E8A68 File Offset: 0x005E6C68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CardItemList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.CardItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601664D RID: 91725 RVA: 0x005E8ABC File Offset: 0x005E6CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardItemList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			Dictionary<int, ICardPoolItemWeight> cardItemList;
			LuaObject.checkType<Dictionary<int, ICardPoolItemWeight>>(l, 2, out cardItemList);
			configDataCardPoolGroupInfo.CardItemList = cardItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601664E RID: 91726 RVA: 0x005E8B14 File Offset: 0x005E6D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601664F RID: 91727 RVA: 0x005E8B68 File Offset: 0x005E6D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataCardPoolGroupInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016650 RID: 91728 RVA: 0x005E8BC0 File Offset: 0x005E6DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardPoolID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.CardPoolID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016651 RID: 91729 RVA: 0x005E8C14 File Offset: 0x005E6E14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CardPoolID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int cardPoolID;
			LuaObject.checkType(l, 2, out cardPoolID);
			configDataCardPoolGroupInfo.CardPoolID = cardPoolID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016652 RID: 91730 RVA: 0x005E8C6C File Offset: 0x005E6E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FirstSingleSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.FirstSingleSelectWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016653 RID: 91731 RVA: 0x005E8CC0 File Offset: 0x005E6EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FirstSingleSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int firstSingleSelectWeight;
			LuaObject.checkType(l, 2, out firstSingleSelectWeight);
			configDataCardPoolGroupInfo.FirstSingleSelectWeight = firstSingleSelectWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016654 RID: 91732 RVA: 0x005E8D18 File Offset: 0x005E6F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefaultSingleSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.DefaultSingleSelectWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016655 RID: 91733 RVA: 0x005E8D6C File Offset: 0x005E6F6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefaultSingleSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int defaultSingleSelectWeight;
			LuaObject.checkType(l, 2, out defaultSingleSelectWeight);
			configDataCardPoolGroupInfo.DefaultSingleSelectWeight = defaultSingleSelectWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016656 RID: 91734 RVA: 0x005E8DC4 File Offset: 0x005E6FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefaultTenSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.DefaultTenSelectWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016657 RID: 91735 RVA: 0x005E8E18 File Offset: 0x005E7018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefaultTenSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int defaultTenSelectWeight;
			LuaObject.checkType(l, 2, out defaultTenSelectWeight);
			configDataCardPoolGroupInfo.DefaultTenSelectWeight = defaultTenSelectWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016658 RID: 91736 RVA: 0x005E8E70 File Offset: 0x005E7070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FirstTenSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.FirstTenSelectWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016659 RID: 91737 RVA: 0x005E8EC4 File Offset: 0x005E70C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FirstTenSelectWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int firstTenSelectWeight;
			LuaObject.checkType(l, 2, out firstTenSelectWeight);
			configDataCardPoolGroupInfo.FirstTenSelectWeight = firstTenSelectWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601665A RID: 91738 RVA: 0x005E8F1C File Offset: 0x005E711C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TenSelectAccumulateWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolGroupInfo.TenSelectAccumulateWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601665B RID: 91739 RVA: 0x005E8F70 File Offset: 0x005E7170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TenSelectAccumulateWeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolGroupInfo configDataCardPoolGroupInfo = (ConfigDataCardPoolGroupInfo)LuaObject.checkSelf(l);
			int tenSelectAccumulateWeight;
			LuaObject.checkType(l, 2, out tenSelectAccumulateWeight);
			configDataCardPoolGroupInfo.TenSelectAccumulateWeight = tenSelectAccumulateWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601665C RID: 91740 RVA: 0x005E8FC8 File Offset: 0x005E71C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataCardPoolGroupInfo");
		string name = "CardItemList";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_CardItemList);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_CardItemList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache3, true);
		string name3 = "CardPoolID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_CardPoolID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_CardPoolID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache5, true);
		string name4 = "FirstSingleSelectWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_FirstSingleSelectWeight);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_FirstSingleSelectWeight);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache7, true);
		string name5 = "DefaultSingleSelectWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_DefaultSingleSelectWeight);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_DefaultSingleSelectWeight);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache9, true);
		string name6 = "DefaultTenSelectWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_DefaultTenSelectWeight);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_DefaultTenSelectWeight);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheB, true);
		string name7 = "FirstTenSelectWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_FirstTenSelectWeight);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_FirstTenSelectWeight);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheD, true);
		string name8 = "TenSelectAccumulateWeight";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.get_TenSelectAccumulateWeight);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.set_TenSelectAccumulateWeight);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.<>f__mg$cache10, typeof(ConfigDataCardPoolGroupInfo));
	}

	// Token: 0x0400CDA5 RID: 52645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CDA6 RID: 52646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CDA7 RID: 52647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CDA8 RID: 52648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CDA9 RID: 52649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CDAA RID: 52650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CDAB RID: 52651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CDAC RID: 52652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CDAD RID: 52653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CDAE RID: 52654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CDAF RID: 52655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CDB0 RID: 52656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CDB1 RID: 52657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CDB2 RID: 52658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CDB3 RID: 52659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CDB4 RID: 52660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CDB5 RID: 52661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
