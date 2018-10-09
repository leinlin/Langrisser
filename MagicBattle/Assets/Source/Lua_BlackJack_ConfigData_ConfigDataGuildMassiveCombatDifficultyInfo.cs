using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001151 RID: 4433
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo : LuaObject
{
	// Token: 0x06016872 RID: 92274 RVA: 0x005F84C0 File Offset: 0x005F66C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo o = new ConfigDataGuildMassiveCombatDifficultyInfo();
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

	// Token: 0x06016873 RID: 92275 RVA: 0x005F8508 File Offset: 0x005F6708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SortedRewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.SortedRewardsInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016874 RID: 92276 RVA: 0x005F855C File Offset: 0x005F675C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SortedRewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			List<Rewards> sortedRewardsInfo;
			LuaObject.checkType<List<Rewards>>(l, 2, out sortedRewardsInfo);
			configDataGuildMassiveCombatDifficultyInfo.SortedRewardsInfo = sortedRewardsInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016875 RID: 92277 RVA: 0x005F85B4 File Offset: 0x005F67B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016876 RID: 92278 RVA: 0x005F8608 File Offset: 0x005F6808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataGuildMassiveCombatDifficultyInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016877 RID: 92279 RVA: 0x005F8660 File Offset: 0x005F6860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016878 RID: 92280 RVA: 0x005F86B4 File Offset: 0x005F68B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataGuildMassiveCombatDifficultyInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016879 RID: 92281 RVA: 0x005F870C File Offset: 0x005F690C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601687A RID: 92282 RVA: 0x005F8760 File Offset: 0x005F6960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataGuildMassiveCombatDifficultyInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601687B RID: 92283 RVA: 0x005F87B8 File Offset: 0x005F69B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SuggestedLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.SuggestedLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601687C RID: 92284 RVA: 0x005F880C File Offset: 0x005F6A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SuggestedLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			string suggestedLevel;
			LuaObject.checkType(l, 2, out suggestedLevel);
			configDataGuildMassiveCombatDifficultyInfo.SuggestedLevel = suggestedLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601687D RID: 92285 RVA: 0x005F8864 File Offset: 0x005F6A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Requirements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.Requirements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601687E RID: 92286 RVA: 0x005F88B8 File Offset: 0x005F6AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StrongholdList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.StrongholdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601687F RID: 92287 RVA: 0x005F890C File Offset: 0x005F6B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.RewardsInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016880 RID: 92288 RVA: 0x005F8960 File Offset: 0x005F6B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BonusGuildCoins(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.BonusGuildCoins);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016881 RID: 92289 RVA: 0x005F89B4 File Offset: 0x005F6BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BonusGuildCoins(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			int bonusGuildCoins;
			LuaObject.checkType(l, 2, out bonusGuildCoins);
			configDataGuildMassiveCombatDifficultyInfo.BonusGuildCoins = bonusGuildCoins;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016882 RID: 92290 RVA: 0x005F8A0C File Offset: 0x005F6C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IndividualPointsRewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.IndividualPointsRewardsInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016883 RID: 92291 RVA: 0x005F8A60 File Offset: 0x005F6C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IndividualPointsRewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			int individualPointsRewardsInfo;
			LuaObject.checkType(l, 2, out individualPointsRewardsInfo);
			configDataGuildMassiveCombatDifficultyInfo.IndividualPointsRewardsInfo = individualPointsRewardsInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016884 RID: 92292 RVA: 0x005F8AB8 File Offset: 0x005F6CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StrongholdRewardMailTemplateId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.StrongholdRewardMailTemplateId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016885 RID: 92293 RVA: 0x005F8B0C File Offset: 0x005F6D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StrongholdRewardMailTemplateId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			int strongholdRewardMailTemplateId;
			LuaObject.checkType(l, 2, out strongholdRewardMailTemplateId);
			configDataGuildMassiveCombatDifficultyInfo.StrongholdRewardMailTemplateId = strongholdRewardMailTemplateId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016886 RID: 92294 RVA: 0x005F8B64 File Offset: 0x005F6D64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IndividualRewardMailTemplateId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatDifficultyInfo.IndividualRewardMailTemplateId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016887 RID: 92295 RVA: 0x005F8BB8 File Offset: 0x005F6DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IndividualRewardMailTemplateId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = (ConfigDataGuildMassiveCombatDifficultyInfo)LuaObject.checkSelf(l);
			int individualRewardMailTemplateId;
			LuaObject.checkType(l, 2, out individualRewardMailTemplateId);
			configDataGuildMassiveCombatDifficultyInfo.IndividualRewardMailTemplateId = individualRewardMailTemplateId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016888 RID: 92296 RVA: 0x005F8C10 File Offset: 0x005F6E10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataGuildMassiveCombatDifficultyInfo");
		string name = "SortedRewardsInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_SortedRewardsInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_SortedRewardsInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache7, true);
		string name5 = "SuggestedLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_SuggestedLevel);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_SuggestedLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache9, true);
		string name6 = "Requirements";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_Requirements);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheA, null, true);
		string name7 = "StrongholdList";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_StrongholdList);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheB, null, true);
		string name8 = "RewardsInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_RewardsInfo);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheC, null, true);
		string name9 = "BonusGuildCoins";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_BonusGuildCoins);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_BonusGuildCoins);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheE, true);
		string name10 = "IndividualPointsRewardsInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_IndividualPointsRewardsInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_IndividualPointsRewardsInfo);
		}
		LuaObject.addMember(l, name10, get7, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache10, true);
		string name11 = "StrongholdRewardMailTemplateId";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_StrongholdRewardMailTemplateId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_StrongholdRewardMailTemplateId);
		}
		LuaObject.addMember(l, name11, get8, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache12, true);
		string name12 = "IndividualRewardMailTemplateId";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.get_IndividualRewardMailTemplateId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.set_IndividualRewardMailTemplateId);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache14, true);
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.<>f__mg$cache15, typeof(ConfigDataGuildMassiveCombatDifficultyInfo));
	}

	// Token: 0x0400CFB2 RID: 53170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CFB3 RID: 53171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CFB4 RID: 53172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CFB5 RID: 53173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CFB6 RID: 53174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CFB7 RID: 53175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CFB8 RID: 53176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CFB9 RID: 53177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CFBA RID: 53178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CFBB RID: 53179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CFBC RID: 53180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CFBD RID: 53181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CFBE RID: 53182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CFBF RID: 53183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CFC0 RID: 53184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CFC1 RID: 53185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CFC2 RID: 53186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CFC3 RID: 53187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CFC4 RID: 53188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CFC5 RID: 53189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CFC6 RID: 53190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CFC7 RID: 53191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
