using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001173 RID: 4467
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo : LuaObject
{
	// Token: 0x06016E8C RID: 93836 RVA: 0x00624D34 File Offset: 0x00622F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo o = new ConfigDataTreasureLevelInfo();
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

	// Token: 0x06016E8D RID: 93837 RVA: 0x00624D7C File Offset: 0x00622F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_banditInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.m_banditInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E8E RID: 93838 RVA: 0x00624DD0 File Offset: 0x00622FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_banditInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			List<ConfigDataBanditInfo> banditInfos;
			LuaObject.checkType<List<ConfigDataBanditInfo>>(l, 2, out banditInfos);
			configDataTreasureLevelInfo.m_banditInfos = banditInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E8F RID: 93839 RVA: 0x00624E28 File Offset: 0x00623028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E90 RID: 93840 RVA: 0x00624E7C File Offset: 0x0062307C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataTreasureLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E91 RID: 93841 RVA: 0x00624ED4 File Offset: 0x006230D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E92 RID: 93842 RVA: 0x00624F28 File Offset: 0x00623128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataTreasureLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E93 RID: 93843 RVA: 0x00624F80 File Offset: 0x00623180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E94 RID: 93844 RVA: 0x00624FD4 File Offset: 0x006231D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataTreasureLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E95 RID: 93845 RVA: 0x0062502C File Offset: 0x0062322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IconResource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.IconResource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E96 RID: 93846 RVA: 0x00625080 File Offset: 0x00623280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IconResource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			string iconResource;
			LuaObject.checkType(l, 2, out iconResource);
			configDataTreasureLevelInfo.IconResource = iconResource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E97 RID: 93847 RVA: 0x006250D8 File Offset: 0x006232D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.OpenPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E98 RID: 93848 RVA: 0x0062512C File Offset: 0x0062332C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OpenPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int openPlayerLevel;
			LuaObject.checkType(l, 2, out openPlayerLevel);
			configDataTreasureLevelInfo.OpenPlayerLevel = openPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E99 RID: 93849 RVA: 0x00625184 File Offset: 0x00623384
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E9A RID: 93850 RVA: 0x006251D8 File Offset: 0x006233D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataTreasureLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E9B RID: 93851 RVA: 0x00625230 File Offset: 0x00623430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E9C RID: 93852 RVA: 0x00625284 File Offset: 0x00623484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataTreasureLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E9D RID: 93853 RVA: 0x006252DC File Offset: 0x006234DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.TicketCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E9E RID: 93854 RVA: 0x00625330 File Offset: 0x00623530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int ticketCost;
			LuaObject.checkType(l, 2, out ticketCost);
			configDataTreasureLevelInfo.TicketCost = ticketCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E9F RID: 93855 RVA: 0x00625388 File Offset: 0x00623588
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA0 RID: 93856 RVA: 0x006253DC File Offset: 0x006235DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataTreasureLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA1 RID: 93857 RVA: 0x00625434 File Offset: 0x00623634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA2 RID: 93858 RVA: 0x00625488 File Offset: 0x00623688
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataTreasureLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA3 RID: 93859 RVA: 0x006254E0 File Offset: 0x006236E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA4 RID: 93860 RVA: 0x00625534 File Offset: 0x00623734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataTreasureLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA5 RID: 93861 RVA: 0x0062558C File Offset: 0x0062378C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA6 RID: 93862 RVA: 0x006255E0 File Offset: 0x006237E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataTreasureLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA7 RID: 93863 RVA: 0x00625638 File Offset: 0x00623838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Bandits_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.Bandits_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA8 RID: 93864 RVA: 0x0062568C File Offset: 0x0062388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.RewardList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EA9 RID: 93865 RVA: 0x006256E0 File Offset: 0x006238E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTreasureLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EAA RID: 93866 RVA: 0x00625734 File Offset: 0x00623934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = (ConfigDataTreasureLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataTreasureLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EAB RID: 93867 RVA: 0x0062578C File Offset: 0x0062398C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataTreasureLevelInfo");
		string name = "m_banditInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_m_banditInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_m_banditInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache7, true);
		string name5 = "IconResource";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_IconResource);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_IconResource);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache9, true);
		string name6 = "OpenPlayerLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_OpenPlayerLevel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_OpenPlayerLevel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheB, true);
		string name7 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheD, true);
		string name8 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cacheF, true);
		string name9 = "TicketCost";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_TicketCost);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_TicketCost);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache11, true);
		string name10 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache13, true);
		string name11 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache15, true);
		string name12 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache17, true);
		string name13 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_HeroExp);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache19, true);
		string name14 = "Bandits_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_Bandits_ID);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1A, null, true);
		string name15 = "RewardList";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_RewardList);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1B, null, true);
		string name16 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.get_Strategy);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name16, get14, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1D, true);
		if (Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.<>f__mg$cache1E, typeof(ConfigDataTreasureLevelInfo));
	}

	// Token: 0x0400D588 RID: 54664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D589 RID: 54665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D58A RID: 54666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D58B RID: 54667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D58C RID: 54668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D58D RID: 54669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D58E RID: 54670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D58F RID: 54671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D590 RID: 54672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D591 RID: 54673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D592 RID: 54674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D593 RID: 54675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D594 RID: 54676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D595 RID: 54677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D596 RID: 54678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D597 RID: 54679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D598 RID: 54680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D599 RID: 54681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D59A RID: 54682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D59B RID: 54683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D59C RID: 54684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D59D RID: 54685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D59E RID: 54686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D59F RID: 54687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D5A0 RID: 54688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D5A1 RID: 54689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D5A2 RID: 54690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D5A3 RID: 54691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D5A4 RID: 54692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D5A5 RID: 54693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D5A6 RID: 54694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
